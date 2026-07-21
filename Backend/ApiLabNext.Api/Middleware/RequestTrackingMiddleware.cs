namespace ApiLabNext.Api.Middleware
{
    using global::ApiLabNext.Aplication.DTOs;
    using global::ApiLabNext.Aplication.Interfaces;
    using System.Diagnostics;

    namespace ApiLabNext.Api.Middleware
    {
        public class RequestTrackingMiddleware(RequestDelegate _next)
        {
            public async Task InvokeAsync(HttpContext context)
            {
                var stopwatch = Stopwatch.StartNew();
                var addLog = context.RequestServices.GetRequiredService<IAdd<LogDTO>>();
                // Continuar pipeline
                await _next(context);

                stopwatch.Stop();

                var request = context.Request;
                var response = context.Response;

                // Crear log
                var log = new LogDTO(request.Method!,
                                     request.Path!,
                                     response.StatusCode,
                                     stopwatch.ElapsedMilliseconds,
                                     DateTime.UtcNow);

                await addLog.ExecuteAsync(log);


                Console.WriteLine($"[TRACKING] {log.Method} {log.Path} -> {log.StatusCode} ({log.Duration} ms)");
            }
        }
    }
}
