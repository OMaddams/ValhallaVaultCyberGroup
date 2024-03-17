


using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace ValhallaVaultCyberGroup.Ui.Middleware


{
    public class LoggingMiddleware
    {

        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"Request skedde till: {context.Request.Method} {context.Request.Path}");
            await _next(context);
        }
    }
}

