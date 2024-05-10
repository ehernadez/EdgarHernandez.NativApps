using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NativApps.Core.Extensions;
using NativApps.Core.InterfacesRepository;
using NativApps.Core.Models.DTOs;
using NativApps.Core.Models.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NativApps.Core.Domains.Implementations
{
	internal class AuthenticationDomain : IAuthenticationDomain
	{
		private readonly IConfiguration _configuration;
		private readonly IAuthenticationRepository _authenticationRepository;

		public AuthenticationDomain(IConfiguration configuration, IAuthenticationRepository authenticationRepository)
		{
			_configuration = configuration;
			_authenticationRepository = authenticationRepository;
		}

		public async Task<string> SignInAsync(UserCredentialDTO userCredential)
		{
			userCredential.UserName.ValidateValue(nameof(userCredential.UserName));
			userCredential.Password.ValidateValue(nameof(userCredential.Password));

			var sectionJwt = _configuration.GetSection("JwtSettings");
			var userSignInResult = await _authenticationRepository.SignInAsync(userCredential.UserName, userCredential.Password) ?? throw new ApplicationException("Autenticación fallida, por favor verifique el usuario y la contraseña");
			
			string accessToken = GenerateJwtToken(userSignInResult, sectionJwt);

			return accessToken;
		}

		private static string GenerateJwtToken(UserModel userSignInResult, IConfigurationSection sectionJwt)
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var jwtSecretKey = sectionJwt["SecretKey"];
			var keyBytes = Encoding.ASCII.GetBytes(jwtSecretKey);
			var expireToken = sectionJwt["ExpireMinutes"];
			double tokenExpireMinutes = double.Parse(expireToken);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new[]
				{
					new Claim(ClaimTypes.NameIdentifier, userSignInResult.Id.ToString()),
					new Claim(ClaimTypes.Role, userSignInResult.Role),
					new Claim(ClaimTypes.Authentication, "Bearer"),
				}),
				Expires = DateTime.UtcNow.AddMinutes(tokenExpireMinutes),
				Audience = sectionJwt["Audience"],
				Issuer = sectionJwt["Issuer"],
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);

			return tokenHandler.WriteToken(token);
		}
	}
}
