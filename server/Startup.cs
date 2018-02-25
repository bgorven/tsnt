using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Tas.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            Uri tazzyUri;
            services.AddScoped<TasClient>()
                    .AddSingleton(new TasConfig()
                    {
                        App = Configuration["app"],
                        Secret = Configuration["hmac"],
                        Uri = Uri.TryCreate(Configuration["tazzyUri"], UriKind.Absolute, out tazzyUri)
                            ? tazzyUri
                            : new Uri("https://" + Configuration["app"] + ".tazzy.io")
                    })
                    .AddMvc(options => options.ModelBinderProviders.Insert(0, new TokenJwtBinderProvider(Configuration["hmac"])));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseMiddleware<TasMiddleware>();
            }

            app.UseStaticFiles(new StaticFileOptions { ServeUnknownFileTypes = true })
               .UseForwardedHeaders(new ForwardedHeadersOptions() { ForwardedHeaders = ForwardedHeaders.XForwardedHost | ForwardedHeaders.XForwardedProto })
               .UseMvc();
        }
    }
}
