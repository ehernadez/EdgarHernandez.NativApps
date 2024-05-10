using NativApps.Core.Models.DTOs;

namespace NativApps.Core.Domains
{
	public interface IProductDomain
	{
		Task<PaginateResponseDTO<ProductResponseDTO>> GetAllAsync(QueryRequestDTO filters);
		Task<PaginateResponseDTO<ProductResponseDTO>> SearchAsync(QueryRequestDTO filters, SearchRequestDTO searchRequest);
		Task CreateAsync(ProductDto product, int currentUserId);
		Task UpdateAsync(int id, ProductDto product, int currentUserId);
		Task DeleteAsync(int id, int currentUserId);
	}
}
