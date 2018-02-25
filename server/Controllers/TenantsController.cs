using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tas.Server.Controllers
{
    [Route("tas/core/[controller]")]
    public class TenantsController : Controller
    {
        [HttpPost]
        public void InstallTenant([FromBody] Tas.Core.Tenant.Tenant tenant)
        {
            Console.WriteLine("Installing " + tenant.ShortCode);
        }

        [HttpDelete("{tenant}")]
        public void UninstallTenant(string tenant)
        {
        }

        [HttpPost("{tenant}/preHalts")]
        public void PreHalt(string tenant)
        {
            //Stop making requests for this tenant
        }

        [HttpPost("{tenant}/halts")]
        public void Halt(string tenant)
        {
            //Should not receive any more requests for this tenant
        }

        [HttpPost("{tenant}/preStarts")]
        public void PreStart(string tenant)
        {
            //Get ready to receive requests for this tenant
        }

        [HttpPost("{tenant}/starts")]
        public void start(string tenant)
        {
            //Start making requests for this tenant
        }
    }
}
