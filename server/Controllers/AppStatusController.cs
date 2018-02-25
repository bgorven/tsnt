using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tas.Tenant.AppStatus;
using Tas.Core.WellKnownSamlAttributes;

namespace Tas.Server.Controllers
{
    [Route("t/{tenant}/tas/devs/tas/[controller]")]
    public class AppStatusController : Controller
    {
        [HttpGet]
        public AppStatus Status(string tenant)
        {
            //Request scheme and host should be populated with tazzy public address, thanks to UseForwardedHeaders middleware in Startup.cs
            return new AppStatus() { LandingPage = $"{Request.Scheme}://{Request.Host}/t/{tenant}/" };
        }
    }
}
