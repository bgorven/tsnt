using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tas.Core.Tenant;
using Tas.Core.TokenJwt;
using Tas.Core.WellKnownSamlAttributes;

namespace Tas.Server.Controllers
{
    [Route("t/{tenant}/tas/devs/buddy/[controller]")]
    public class HelloWorldController : Controller
    {
        private readonly TasClient tasClient;

        public HelloWorldController(TasClient client)
        {
            tasClient = client;
        }

        [HttpGet]
        public  async Task<string> HelloWorld(string tenant)
        {
            var tenantDetails = await tasClient.GetTenant(tenant);
            return $"Hello, {tenantDetails.Name}";
        }

        [HttpGet("me")]
        public async Task<string> HelloUser(TokenJwt token, string tenant)
        {
            //TAS on-behalf API -> get saml key from auth token
            var attrs = await tasClient.GetWellKnownSamlAttributes(tenant, token.Sub.SamlKey);
            return $"Hello, {attrs.TasPersonalGivenName}";
        }

        [HttpGet("forApp")]
        public string HelloNonSot(TokenJwt token)
        {
            //Ca = Consuming app
            return $"Hello, {token.Cons.Ca}";
        }
    }
}
