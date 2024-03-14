using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ValhallaVaultCyberGroup.Data.Models.AdminConnection;
using ValhallaVaultCyberGroup.Data.Repositories;

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

        public async Task InvokeAsync(HttpContext context, AdminConnectionRepo repo)
        {
            logger.LogInformation($"Request: {context.Request.Method} {context.Request.Path} from {context.Connection.RemoteIpAddress}");

            foreach (var cookie in context.Request.Cookies)
            {
                logger.LogInformation($"Cookie: {cookie}");
            }

            if (context.Request.Path == "/Admin")
            {
                AdminConnectionModel adminConnectionLogToSave = new AdminConnectionModel();
                if (context.Connection.RemoteIpAddress != null)
                {
                    adminConnectionLogToSave.FromIp = context.Connection.RemoteIpAddress.ToString();
                }
                adminConnectionLogToSave.DateTimeConnected = DateTime.UtcNow;
                await repo.AddAdminConnectionAsync(adminConnectionLogToSave);

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
