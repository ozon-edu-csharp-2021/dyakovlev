using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MerchandiseService
{
    public class OkResponseMiddleware
    {
        public OkResponseMiddleware(RequestDelegate next)
        {
        }

        public Task Invoke(HttpContext context)
        {
            if (!context.Response.HasStarted)
            {
                context.Response.StatusCode = StatusCodes.Status200OK;
            }
            return Task.CompletedTask;
        }
    }
}