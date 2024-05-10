using NativApps.Core.Models.DTOs;

namespace NativApps.Core.Domains
{
	public interface IAuthenticationDomain
	{
		Task<string> SignInAsync(UserCredentialDTO userCredential);
	}
}
