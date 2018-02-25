using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Tas.Core.Routes;
using Tas.Core.WellKnownSamlAttributes;

namespace Tas.Server
{
    public class TasClient
    {
        public readonly HttpClient httpClient = new HttpClient();
        public readonly TasConfig tasConfig;
        public JsonSerializer Serializer { get; }

        public TasClient(TasConfig tasConfig)
        {
            Serializer = new JsonSerializer();
            this.tasConfig = tasConfig;
            httpClient.BaseAddress = tasConfig.Uri;
            httpClient.DefaultRequestHeaders.Add("tazzy-secret", tasConfig.Secret);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.Timeout = TimeSpan.FromSeconds(10);
        }

        public async Task<T> RequestAsync<T>(Func<HttpClient, Task<Stream>> request)
        {
            return await Task.Run(async () =>
            {
                using (var stream = await request(httpClient))
                using (var sr = new StreamReader(stream))
                {
                    object result = default(T);
                    if (typeof(T) == typeof(string))
                    {
                        result = sr.ReadToEnd();
                    }
                    else
                    {
                        using (var jr = new JsonTextReader(sr))
                        {
                            result = Serializer.Deserialize<T>(jr);
                        }
                    }
                    return (T)result;
                }
            });
        }

        public Task<T> GetAsync<T>(string uri)
        {
            return RequestAsync<T>(client => client.GetStreamAsync(uri));
        }

        internal Task<Tas.Core.Tenant.Tenant> GetTenant(string tenant)
        {
            return GetAsync<Tas.Core.Tenant.Tenant>($"/core/tenants/{tenant}");
        }

        internal Task<Routes> GetProducers(string tenant, string dev, string api)
        {
            return GetAsync<Routes>($"/core/routes/producers/{tenant}/{tasConfig.App}?apiDev={dev}&api={WebUtility.UrlEncode(api)}&sot=false");
        }

        public Task<WellKnownSamlAttributes> GetWellKnownSamlAttributes(string tenant, string samlKey)
        {
            return GetAsync<WellKnownSamlAttributes>($"/core/tenants/{tenant}/saml/assertions/byKey/{samlKey}/json");
        }

        public TenantApiBuilder Builder(string tenant)
        {
            return new TenantApiBuilder(this, tenant);
        }
    }

    public class TenantApiBuilder
    {
        private readonly TasClient client;
        private readonly string tenant;
        private string dev = "tas";
        private string app = "";
        private string saml;
        private string auth;
        private HttpMethod method = HttpMethod.Get;

        public TenantApiBuilder(TasClient tasClient, string tenant)
        {
            client = tasClient;
            this.tenant = tenant;
        }

        public TenantApiBuilder WithDev(string developer)
        {
            dev = developer;
            return this;
        }

        public TenantApiBuilder WithApp(string producingApp)
        {
            app = "/apps/" + producingApp;
            return this;
        }

        public TenantApiBuilder WithAuth(HttpRequest request)
        {
            string samlHeader = request.Headers["tazzy-saml"];
            if (!String.IsNullOrEmpty(samlHeader))
            {
                //Saml header will be set when handling a web request for a user that is signed in to our app
                saml = samlHeader;
            }
            else if (request.Headers.ContainsKey("Authorization"))
            {
                //Auth header will be set when handling an api call from another app
                auth = request.Headers["Authorization"];
            }
            return this;
        }

        public TenantApiBuilder WithMethod(HttpMethod method)
        {
            this.method = method;
            return this;
        }

        public TenantApiBuilder WithMethod(Method method)
        {
            this.method = ToHttpMethod(method);
            return this;
        }

        public Task<T> RequestAsync<T>(string api)
        {
            return client.RequestAsync<T>(async http =>
            {
                var response = await http.SendAsync(GetRequestMessage<T>(api), HttpCompletionOption.ResponseHeadersRead);
                await EnsureSuccessStatusCode(response);
                return await response.Content.ReadAsStreamAsync();
            });
        }

        public Task<T> RequestAsync<T>(string api, object content)
        {
            return client.RequestAsync<T>(async http =>
            {
                var requestMessage = GetRequestMessage<T>(api);
                using (var stream = new MemoryStream())
                using (var sw = new StreamWriter(stream))
                using (var jw = new JsonTextWriter(sw))
                {
                    client.Serializer.Serialize(jw, content);
                    requestMessage.Content = new StreamContent(stream);
                    var response = await http.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
                    await EnsureSuccessStatusCode(response);
                    return await response.Content.ReadAsStreamAsync();
                }
            });
        }

        private async Task EnsureSuccessStatusCode(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode && response.Content.Headers.ContentType.MediaType == "application/problem+json")
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var sr = new StreamReader(stream))
                using (var jr = new JsonTextReader(sr))
                    throw new TasException(client.Serializer.Deserialize<ProblemDetails>(jr));
            }
            response.EnsureSuccessStatusCode();
        }

        public async Task<Tuple<ConsumingAppInstall, T>[]> RollupAsync<T>(string api)
        {
            var routes = await client.GetProducers(tenant, dev, api);
            return await Task.WhenAll(routes.ProducingAppInstalls.Select(async app =>
                   Tuple.Create(app, await this.WithApp(app.App).RequestAsync<T>(api))
               ).ToArray());
        }

        public async Task<Tuple<ConsumingAppInstall, T>[]> RollupAsync<T>(string api, object content)
        {
            var routes = await client.GetAsync<Routes>($"/core/routes/producers/{tenant}/{client.tasConfig.App}?apiDev={dev}&api={WebUtility.UrlEncode(api)}&sot=false");
            return await Task.WhenAll(routes.ProducingAppInstalls.Select(async app =>
                   Tuple.Create(app, await this.WithApp(app.App).RequestAsync<T>(api, content))
               ).ToArray());
        }

        public HttpRequestMessage GetRequestMessage<T>(string api)
        {
            if (api.StartsWith('/'))
            {
                api = api.Substring(1);
            }
            var requestMessage = new HttpRequestMessage(method, $"{app}/devs/{dev}/{api}");

            requestMessage.Headers.Add("tazzy-tenant", tenant);

            if (typeof(T) == typeof(string))
            {
                requestMessage.Headers.Accept.ParseAdd("text/plain");
                requestMessage.Headers.Accept.ParseAdd("application/problem+json");
            }

            if (!String.IsNullOrEmpty(saml))
            {
                requestMessage.Headers.Add("tazzy-saml", saml);
            }
            else if (!String.IsNullOrEmpty(auth))
            {
                requestMessage.Headers.Add("Authorization", auth);
            }
            return requestMessage;
        }

        private static readonly HttpMethod PATCH = new HttpMethod("PATCH");

        public static HttpMethod ToHttpMethod(Method m)
        {
            switch (m)
            {
                case Method.DELETE:
                    return HttpMethod.Delete;
                case Method.GET:
                    return HttpMethod.Get;
                case Method.HEAD:
                    return HttpMethod.Head;
                case Method.PATCH:
                    return PATCH;
                case Method.POST:
                    return HttpMethod.Post;
                case Method.PUT:
                    return HttpMethod.Put;
                default:
                    return null;
            }
        }
    }
}