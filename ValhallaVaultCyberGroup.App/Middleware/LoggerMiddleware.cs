using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ValhallaVaultCyberGroup.App.Middleware
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;

        public LoggerMiddleware(RequestDelegate next, ILogger logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            logger.LogInformation($"Request {context.Request.Path} {context.Request.Cookies}");


            await next(context);

            logger.LogInformation($"Response {context.Response.StatusCode}");
        }
    }
}
