using Microsoft.AspNetCore.Mvc;
using NativApps.ApiRest.Responses;
using System.Net;
using System.Security.Claims;

namespace NativApps.ApiRest.Controllers
{
	public class BaseController : ControllerBase
	{
		protected int UserIdentity
		{
			get
			{
				if (User.Identity.IsAuthenticated)
				{
					var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
					if (int.TryParse(userIdClaim, out int userId))
					{
						return userId;
					}
				}
				throw new ApplicationException("Sesion terminada, por favor intente loguearse nuevamente");
			}
		}
		
		protected async Task<Response> ExecuteServiceAsync(Func<Task> serviceMethodAsync)
		{
			var response = new Response();

			try
			{
				await serviceMethodAsync();
				response.Success = true;
				response.StatusCode = (int)HttpStatusCode.OK;
			}
			catch (ApplicationException ex)
			{
				response.Success = false;
				response.StatusCode = (int)HttpStatusCode.BadRequest;
				response.Data = ex.Message;
			}
			catch (Exception)
			{
				response.Success = false;
				response.StatusCode = (int)HttpStatusCode.InternalServerError;
				response.Data = "Ocurrio un error interno en el servidor al realizar esta solicitud, por favor intentelo más tarde";
			}

			return response;
		}

		protected async Task<Response> ExecuteServiceAsync<T>(Func<Task<T>> serviceMethodAsync)
		{
			var response = new Response();

			try
			{
				response.Success = true;
				response.StatusCode = (int)HttpStatusCode.OK;
				response.Data = await serviceMethodAsync();
			}
			catch (ApplicationException ex)
			{
				response.Success = false;
				response.StatusCode = (int)HttpStatusCode.BadRequest;
				response.Data = ex.Message;
			}
			catch (Exception)
			{
				response.Success = false;
				response.StatusCode = (int)HttpStatusCode.InternalServerError;
				response.Data = "Ocurrio un error interno en el servidor al realizar esta solicitud, por favor intentelo más tarde";
			}

			return response;
		}
	}
}
