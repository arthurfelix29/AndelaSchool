using AndelaSchool.Application.Services;
using AndelaSchool.Application.Services.Interfaces;
using AndelaSchool.Domain.Core.Interfaces;
using AndelaSchool.Domain.Interfaces;
using AndelaSchool.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AndelaSchool.Infra.CrossCutting.IoC
{
    public static class InjectorBootStrapper
    {
        public static IServiceCollection RegisterServices(IServiceCollection services) =>
            services
                .RegisterApplicationLayer()
                .RegisterDataLayer();

        private static IServiceCollection RegisterApplicationLayer(this IServiceCollection services) =>
            services
                .AddScoped<IStudentService, StudentService>();

        private static IServiceCollection RegisterDataLayer(this IServiceCollection services) =>
             services
                .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddTransient<IStudentRepository, StudentRepository>();
    }
}
