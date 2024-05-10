using Microsoft.Extensions.DependencyInjection;
using NativApps.Core.Domains;
using NativApps.Core.Domains.Implementations;

namespace NativApps.Core
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddDomains(this IServiceCollection services)
		{
			services.AddTransient<IProductDomain, ProductDomain>();
			services.AddTransient<IAuthenticationDomain, AuthenticationDomain>();

			return services;
		}
	}
}
