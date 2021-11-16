using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MerchandiseService
{
    public class GlobalExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                var exception = context.Exception;
                var resultMessage = new
                {
                    exceptionType = exception.GetType(),
                    stackTrace = exception.StackTrace
                };
                var result = new JsonResult(resultMessage)
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                context.Result = result;
            }
        }
    }
}