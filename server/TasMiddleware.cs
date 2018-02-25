using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Tas.Server
{
    public class TasMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _hmac;

        public TasMiddleware(RequestDelegate next, TasConfig options)
        {
            _next = next;
            _hmac = options.Secret;
        }

        public async Task Invoke(HttpContext context)
        {
            string header = context.Request.Headers["tazzy-secret"];
            if (header != null && header.Equals(_hmac))
            {
                await _next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = 401;
                return;
            }
        }
    }
}