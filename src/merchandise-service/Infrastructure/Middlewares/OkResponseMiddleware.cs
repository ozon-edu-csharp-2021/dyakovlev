using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MerchandiseService
{
    public class OkResponseMiddleware
    {
        public OkResponseMiddleware(RequestDelegate next)
        {
        }

        public async Task Invoke(HttpContext context)
        {
            if (!context.Response.HasStarted)
            {
                context.Response.StatusCode = StatusCodes.Status200OK;
                await context.Response.WriteAsync("OK");
            }
        }
    }
}