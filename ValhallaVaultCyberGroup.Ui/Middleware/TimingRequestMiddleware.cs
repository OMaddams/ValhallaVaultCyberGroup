using System.Diagnostics;

namespace ValhallaVaultCyberGroup.Ui.Middleware
{
    // Middleware för att beräkna hur lång tid det tar att göra ett request
    public class TimingRequestMiddleware
    {


        private readonly RequestDelegate _next;
        private readonly ILogger<TimingRequestMiddleware> _logger;

        public TimingRequestMiddleware(RequestDelegate next, ILogger<TimingRequestMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }


        public async Task Invoke(HttpContext context)
        {
          var stopWatch = Stopwatch.StartNew();
            await _next(context);
            stopWatch.Stop();


            _logger.LogInformation($"Request: {context.Request.Path} took {stopWatch.ElapsedMilliseconds} ms to process");
        }
    }
}
