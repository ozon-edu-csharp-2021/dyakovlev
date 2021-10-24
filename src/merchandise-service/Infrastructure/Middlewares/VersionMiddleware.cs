using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MerchandiseService
{
    public class VersionMiddleware
    {
        public VersionMiddleware(RequestDelegate next)
        {
        }

        public async Task Invoke(HttpContext context)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            if (!context.Response.HasStarted)
            {
                await context.Response.WriteAsJsonAsync(new
                    {
                        version = assemblyName.Version?.ToString() ?? "Unknown",
                        serviceName = assemblyName.Name
                    }
                ); 
            }
            
        }
    }
}