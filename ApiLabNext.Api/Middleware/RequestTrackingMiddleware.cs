namespace ApiLabNext.Api.Middleware
{
    using global::ApiLabNext.Api.Models;
    using global::ApiLabNext.Api.Services.ApiLabNext.Api.Services;
    using System.Diagnostics;

    namespace ApiLabNext.Api.Middleware
    {
        public class RequestTrackingMiddleware
        {
            private readonly RequestDelegate _next;

            public RequestTrackingMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task InvokeAsync(HttpContext context)
            {
                var stopwatch = Stopwatch.StartNew();

                // Continuar pipeline
                await _next(context);

                stopwatch.Stop();

                var request = context.Request;
                var response = context.Response;


                var log = new ApiRequestLog
                {
                    Method = request.Method!,
                    Path = request.Path!,
                    StatusCode = response.StatusCode,
                    Duration = stopwatch.ElapsedMilliseconds,
                    Timestamp = DateTime.UtcNow
                };

                var logService = context.RequestServices.GetRequiredService<RequestLogService>();
                logService.Add(log);

                Console.WriteLine($"[TRACKING] {log.Method} {log.Path} -> {log.StatusCode} ({log.Duration} ms)");
            }
        }
    }
}
