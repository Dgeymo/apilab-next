using ApiLabNext.Api.Middleware.ApiLabNext.Api.Middleware;
using ApiLabNext.Aplication.DTOs;
using ApiLabNext.Aplication.Interfaces;
using ApiLabNext.Aplication.UseCases;
using ApiLabNext.Domain.Interfaces;
using ApiLabNext.Infraestructure.Repositories;

namespace ApiLabNext.Api.Injections
{
    public static class Injection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //repositories
            services.AddScoped<IRepositoryLog, RepositoryLog>();

            //use cases
            services.AddScoped<IGetByPage<LogsPageDTO>, GetLogsByPage>();
            services.AddScoped<IAdd<LogDTO>, AddLog>();


            return services;
        }
    }
}
