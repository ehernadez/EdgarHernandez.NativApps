using NativApps.Core.Models.Entities;

namespace NativApps.Core.InterfacesRepository
{
	public interface IAuthenticationRepository
	{
		Task<UserModel> SignInAsync(string userName, string password);
	}
}
