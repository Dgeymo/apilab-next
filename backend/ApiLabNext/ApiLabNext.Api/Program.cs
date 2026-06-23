using ApiLabNext.Api.Middleware.ApiLabNext.Api.Middleware;
using ApiLabNext.Api.Services.ApiLabNext.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<RequestLogService>();

var app = builder.Build();
//Add Middleware
app.UseMiddleware<RequestTrackingMiddleware>();

app.MapGet("/health", () => new { status = "ok" });
app.MapGet("/logs", (RequestLogService service) => service.GetPageLog());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
