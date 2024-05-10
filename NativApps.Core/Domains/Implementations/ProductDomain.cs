using NativApps.Core.Extensions;
using NativApps.Core.Helpers;
using NativApps.Core.InterfacesRepository;
using NativApps.Core.Models.DTOs;
using NativApps.Core.Models.Entities;

namespace NativApps.Core.Domains.Implementations
{
	internal class ProductDomain(IProductRepository productRepository) : IProductDomain
	{
		private readonly IProductRepository _productRepository = productRepository;

		public async Task<PaginateResponseDTO<ProductResponseDTO>> GetAllAsync(QueryRequestDTO filters)
		{
			var products = await _productRepository.GetAllAsync(filters);
			var totalRecords = await _productRepository.CountTotalRecordsAsync(filters);
			var pageCount = (int)Math.Ceiling(totalRecords / (decimal)filters.PageSize);

			return FormatResponsePaginate(filters, products, totalRecords, pageCount);
		}

		public async Task<PaginateResponseDTO<ProductResponseDTO>> SearchAsync(QueryRequestDTO filters, SearchRequestDTO searchRequest)
		{
			searchRequest.PriceMin.ValidateParameter(nameof(searchRequest.PriceMin));
			searchRequest.PriceMax.ValidateParameter(nameof(searchRequest.PriceMax));
			searchRequest.Search.ValidateParameter(nameof(searchRequest.Search));

			var products = await _productRepository.SearchAsync(filters, searchRequest);
			var totalRecords = await _productRepository.CountTotalRecordsAsync(filters, searchRequest);
			var pageCount = (int)Math.Ceiling(totalRecords / (decimal)filters.PageSize);
			return FormatResponsePaginate(filters, products, totalRecords, pageCount);
		}

		public async Task CreateAsync(ProductDto product, int currentUserId)
		{
			var productModel = MapProductHelper.MapToProductmodel(product);
			productModel.CreatedBy = currentUserId;
			productModel.CreatedOn = DateTime.UtcNow;

			await _productRepository.CreateAsync(productModel);
		}

		public async Task UpdateAsync(int id, ProductDto product, int currentUserId)
		{
			var productModel = MapProductHelper.MapToProductmodel(product);
			productModel.Id = id;
			productModel.ModifiedBy = currentUserId;
			productModel.ModifiedOn = DateTime.UtcNow;

			await _productRepository.UpdateAsync(productModel);
		}

		public async Task DeleteAsync(int id, int currentUserId)
		{
			var productModel = new ProductModel
			{
				Id = id,
				ModifiedBy = currentUserId,
				ModifiedOn = DateTime.UtcNow,
			};

			await _productRepository.DeleteAsync(productModel);
		}

		private static PaginateResponseDTO<ProductResponseDTO> FormatResponsePaginate(QueryRequestDTO filters, IEnumerable<ProductModel> products, int totalRecords, int pageCount)
		{
			return new PaginateResponseDTO<ProductResponseDTO>
			{
				PageIndex = filters.PageIndex,
				PageSize = filters.PageSize,
				PageCount = pageCount,
				TotalRecords = totalRecords,
				Data = products.Select(x => MapProductHelper.MapToProductResponseDTO(x))
			};
		}
	}
}
