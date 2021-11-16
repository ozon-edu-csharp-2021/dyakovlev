using System;
using MerchandiseService.Grpc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace MerchandiseService
{
    class TerminalStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                app.UseWhen(
                    ctx => ctx.Connection.LocalPort != 5004,
                    app => app.UseMiddleware<RequestResponseLoggingMiddleware>()
                );
                app.Map("/version", app => app.UseMiddleware<VersionMiddleware>());
                app.Map("/ready", app => app.UseMiddleware<OkResponseMiddleware>());
                app.Map("/live", app => app.UseMiddleware<OkResponseMiddleware>());
                next(app);
            };
        }
    }
}