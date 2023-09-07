using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poc.Net.R2R.Repository.Interfaces;
using Poc.Net.R2R.Repository.Repositories;

namespace Poc.Net.R2R.Infrastructure.Modules
{
    internal static class InfrastructureModules
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services, IConfiguration configuration)
            => services.RegisterRepositories(configuration);

        private static IServiceCollection RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
            => services.AddScoped<IEmployeeRepository>(sp => new EmployeeRepository(configuration.GetConnectionString("POSTGRESCONNECTION").ToString()));
    }
}
