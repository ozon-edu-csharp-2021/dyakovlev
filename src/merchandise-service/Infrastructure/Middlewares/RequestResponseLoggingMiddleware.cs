using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MerchandiseService
{
    class RequestResponseLoggingMiddleware
    {
        private RequestDelegate _next;
        private ILogger<RequestResponseLoggingMiddleware> _logger;
        
        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
    
        public async Task Invoke(HttpContext context)
        {
            LogRequest(context);
            await _next(context);
            LogResponse(context);
        }

        private void LogRequest(HttpContext context)
        {
            Log(context, "Request");
        }

        private void LogResponse(HttpContext context)
        {
            Log(context, "Response");
        }
        
        private void Log(HttpContext context, string requestResponseWord)
        {
            var headersAsString =
                string.Join("; ", context.Request.Headers.Select(header => $"{header.Key}: {header.Value}"));
            _logger.LogInformation($"{requestResponseWord} {context.Request.Path}, headers: {headersAsString}");
        }
    }
}