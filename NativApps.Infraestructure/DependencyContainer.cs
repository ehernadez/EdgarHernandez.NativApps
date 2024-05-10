using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NativApps.Core.InterfacesRepository;
using NativApps.Infraestructure.DataContext;
using NativApps.Infraestructure.DataContext.Implemetation;
using NativApps.Infraestructure.Repositories.Implementations;
using System.Data.SqlClient;

namespace NativApps.Infraestructure
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<INativAppsContext>(provider =>
			{
				var connectionString = configuration.GetConnectionString("NativAppsConnectionString");
				var connection = new SqlConnection(connectionString);
				connection.Open();
				return new NativAppsContext(connection);
			});
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

			return services;
		}
	}
}
