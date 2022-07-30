using AndelaSchool.Application.AutoMapper;
using AndelaSchool.Infra.CrossCutting.IoC;
using AndelaSchool.Infra.Data.Contexts;
using AndelaSchool.Services.Api.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AndelaSchool.Services.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
            => InjectorBootStrapper.RegisterServices(services);

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<AndelaSchoolContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

        public static IServiceCollection AddCore(this IServiceCollection services)
            => services
                    .AddAutoMapper()
                    .AddVersioning()
                    .AddSwaggerVersioning();

        private static IServiceCollection AddAutoMapper(this IServiceCollection services)
            => services.AddAutoMapper(typeof(DomainToDtoMappingProfile), typeof(DtoToDomainMappingProfile));

        private static IServiceCollection AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(setup =>
            {
                setup.DefaultApiVersion = new ApiVersion(1, 0);
                setup.AssumeDefaultVersionWhenUnspecified = true;
                setup.ReportApiVersions = true;
            });

            return services.AddVersionedApiExplorer(setup =>
            {
                setup.GroupNameFormat = "'v'VVV";
                setup.SubstituteApiVersionInUrl = true;
            });
        }

        private static IServiceCollection AddSwaggerVersioning(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            services.ConfigureOptions<ConfigureSwaggerOptions>();

            return services;
        }
    }
}