using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NativApps.ApiRest.Responses;
using NativApps.Core.Domains;
using NativApps.Core.Models.DTOs;

namespace NativApps.ApiRest.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProductController(IProductDomain productDomain) : BaseController
	{
		private readonly IProductDomain _productDomain = productDomain;

		[Authorize]
		[HttpGet]
		public async Task<Response> Get([FromQuery] QueryRequestDTO filters)
			=> await ExecuteServiceAsync(async () => await _productDomain.GetAllAsync(filters));

		[Authorize]
		[HttpGet("Search")]
		public async Task<Response> Search([FromQuery] QueryRequestDTO filters, [FromBody] SearchRequestDTO searchRequest)
			=> await ExecuteServiceAsync(async () => await _productDomain.SearchAsync(filters, searchRequest));

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public async Task<Response> Post(ProductDto product)
			=> await ExecuteServiceAsync(async () => await _productDomain.CreateAsync(product, UserIdentity));

		[Authorize(Roles = "Admin")]
		[HttpPut("{id}")]
		public async Task<Response> Put(int id, [FromBody] ProductDto product)
			=> await ExecuteServiceAsync(async () => await _productDomain.UpdateAsync(id, product, UserIdentity));

		[Authorize(Roles = "Admin")]
		[HttpDelete("{id}")]
		public async Task<Response> Delete(int id)
			=> await ExecuteServiceAsync(async () => await _productDomain.DeleteAsync(id, UserIdentity));
	}
}
