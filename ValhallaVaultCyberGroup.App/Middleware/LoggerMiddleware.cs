using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ValhallaVaultCyberGroup.App.Middleware
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<LoggerMiddleware> logger;

        public LoggerMiddleware(RequestDelegate next, ILogger<LoggerMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            logger.LogInformation($"Request: {context.Request.Method} {context.Request.Path}");
            foreach (var cookie in context.Request.Cookies)
            {
                logger.LogInformation($"Cookie: {cookie}");
            }

            await next(context);
            if (context.Response.StatusCode >= 400)
            {
                logger.LogWarning($"Response error: {context.Response.StatusCode}");
            }
            else
            {
                logger.LogInformation($"Response {context.Response.StatusCode}");

            }
        }
    }
}
