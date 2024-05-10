using NativApps.Core.InterfacesRepository;
using NativApps.Core.Models.Entities;
using NativApps.Infraestructure.DataContext;
using NativApps.Infraestructure.SqlStatements;
using System.Data.SqlClient;

namespace NativApps.Infraestructure.Repositories.Implementations
{
	internal class AuthenticationRepository(INativAppsContext context) : BaseRepository, IAuthenticationRepository
	{
		private readonly INativAppsContext _context = context;

		public async Task<UserModel> SignInAsync(string userName, string password)
		{
			var sqlStatement = SqlStatement.SignIn;

			SqlParameter[] parameters = [
				new SqlParameter("@UserName", userName),
				new SqlParameter("@Password", password),
			];

			return await _context.GetSingleAsync<UserModel>(sqlStatement, parameters);
		}
	}
}
