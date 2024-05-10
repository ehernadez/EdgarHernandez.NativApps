using NativApps.Core.Models.DTOs;
using NativApps.Core.Models.Entities;

namespace NativApps.Core.InterfacesRepository
{
	public interface IProductRepository
	{
		Task<IEnumerable<ProductModel>> GetAllAsync(QueryRequestDTO filters);
		Task<IEnumerable<ProductModel>> SearchAsync(QueryRequestDTO filters, SearchRequestDTO searchRequest);
		Task<int> CountTotalRecordsAsync(QueryRequestDTO filters);
		Task<int> CountTotalRecordsAsync(QueryRequestDTO filters, SearchRequestDTO searchRequest);
		Task CreateAsync(ProductModel product);
		Task UpdateAsync(ProductModel product);
		Task DeleteAsync(ProductModel product);
	}
}
