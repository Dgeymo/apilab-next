using ApiLabNext.Api.Injections;
using ApiLabNext.Api.Middleware.ApiLabNext.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
//Add Middleware
app.UseMiddleware<RequestTrackingMiddleware>();

app.MapGet("/health", () => new { status = "ok" });

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
