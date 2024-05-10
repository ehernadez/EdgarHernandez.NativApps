using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NativApps.ApiRest.Responses;
using NativApps.Core.Domains;
using NativApps.Core.Models.DTOs;

namespace NativApps.ApiRest.Controllers
{
	[AllowAnonymous]
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController(IAuthenticationDomain authenticationDomain) : BaseController
	{
		private readonly IAuthenticationDomain _authenticationDomain = authenticationDomain;

		[HttpPost]
		public async Task<Response> SignIn(UserCredentialDTO userCredential)
		{
			return await ExecuteServiceAsync(async () => await _authenticationDomain.SignInAsync(userCredential));
		}
	}
}
