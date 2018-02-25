using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tas.Core.Routes;

namespace Tas.Server.Controllers
{
    [Route("/t/{tenant}/")]
    public class WebController : Controller
    {
        private readonly TasClient tasClient;
        private readonly TasConfig tasConfig;

        public WebController(TasClient client, TasConfig config)
        {
            tasClient = client;
            tasConfig = config;
        }

        [HttpGet]
        public async Task<ViewResult> Index(string tenant, [FromHeader(Name = "tazzy-saml")] string samlKey)
        {
            //Tazzy-SSO-protected web page -> use tazzy-saml header
            var user = tasClient.GetWellKnownSamlAttributes(tenant, samlKey);

            var simple = tasClient.Builder(tenant).WithDev("buddy").RequestAsync<string>("/helloWorld");
            var onBehalf = tasClient.Builder(tenant).WithDev("buddy").WithAuth(Request).RequestAsync<string>("/helloWorld/me");
            var nonSot = tasClient.Builder(tenant).WithDev("buddy").RollupAsync<string>("/helloWorld/forApp");

            ViewData["tenant"] = tenant;
            ViewData["user"] = (await user).TasPersonalEmail;
            ViewData["simple"] = await simple;
            ViewData["onBehalf"] = await onBehalf;
            ViewData["nonSot"] = await nonSot;
            return View();
        }

        [HttpGet("tas/logout")]
        public ViewResult AfterLogout(string tenant)
        {
            return View();
        }
    }
}
