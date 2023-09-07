using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Poc.Net.R2R.Infrastructure.Modules;

namespace Poc.Net.R2R.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection RegisterContainer(this IServiceCollection services, IConfiguration configuration)
            => services.RegisterInfrastructure(configuration)
                       .RegisterApplication();
    }
}
