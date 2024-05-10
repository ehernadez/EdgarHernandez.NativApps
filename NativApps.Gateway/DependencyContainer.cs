using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NativApps.Core;
using NativApps.Infraestructure;

namespace NativApps.Gateway
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddRepositories(configuration);
			services.AddDomains();

			return services;
		}
	}
}
