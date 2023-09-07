using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Poc.Net.R2R.Application.Interfaces.Services;
using Poc.Net.R2R.Application.Services;

namespace Poc.Net.R2R.Infrastructure.Modules
{
    internal static class ApplicationModules
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
            => services.RegisterServices()
                       .SetSwaggerDoc();

        private static IServiceCollection RegisterServices(this IServiceCollection services)
            => services.AddScoped<IEmployeeService, EmployeeService>();

        private static IServiceCollection SetSwaggerDoc(this IServiceCollection services)
            => services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = ".NET Core WebAPI with Ready2Run Deployment",
                    Description = "WebAPI designed for Educational Purposes to learn how implements Minimal APIs with Ready2Run deployment!",
                    Contact = new OpenApiContact
                    {
                        Name = "Diego dos Santos Soares",
                        Email = "dieg657@gmail.com",
                        Url = new Uri("http://www.diegosoares.dev.br")
                    },
                    Version = "1"
                });
            });
    }
}
