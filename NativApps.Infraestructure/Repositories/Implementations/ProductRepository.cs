using NativApps.Core.InterfacesRepository;
using NativApps.Core.Models.DTOs;
using NativApps.Core.Models.Entities;
using NativApps.Infraestructure.DataContext;
using NativApps.Infraestructure.SqlStatements;
using System.Data.SqlClient;

namespace NativApps.Infraestructure.Repositories.Implementations
{
	internal class ProductRepository(INativAppsContext context) : BaseRepository, IProductRepository
	{
		private readonly INativAppsContext _context = context;

		public async Task<IEnumerable<ProductModel>> GetAllAsync(QueryRequestDTO filters)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Product_GetAll, filters.OrderByDesc);
			SqlParameter[] parameters = GetFilterParameters(filters);

			return await _context.GetAsync<ProductModel>(sqlStatement, parameters);
		}

		public async Task<IEnumerable<ProductModel>> SearchAsync(QueryRequestDTO filters, SearchRequestDTO searchRequest)
		{
			var sqlStatement = FormatOrderSqlQuery(SqlStatement.Product_SearchProduct, filters.OrderByDesc);
			SqlParameter[] parameters = GetFilterParameters(filters, searchRequest);

			return await _context.GetAsync<ProductModel>(sqlStatement, parameters);
		}

		public async Task<int> CountTotalRecordsAsync(QueryRequestDTO filters)
			=> await _context.GetSingleValueAsync<int>(SqlStatement.Product_CountTotalRecords);

		public async Task<int> CountTotalRecordsAsync(QueryRequestDTO filters, SearchRequestDTO searchRequest)
		{
			SqlParameter[] parameters = GetFilterParameters(filters, searchRequest);
			return await _context.GetSingleValueAsync<int>(SqlStatement.Product_Search_CountTotalRecords, parameters);
		}

		public async Task CreateAsync(ProductModel product)
		{
			var sqlStatement = SqlStatement.Product_Create;

			SqlParameter[] parameters = [
				new("@Name", product.Name),
				new("@Category", product.Category),
				new("@Detail", product.Detail),
				new("@Price", product.Price),
				new("@InitialQuantity", product.InitialQuantity),
				new("@AvailableQuantity", product.AvailableQuantity),
				new("@CreatedBy", product.CreatedBy),
				new("@CreatedOn", product.CreatedOn),
			];

			await _context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task UpdateAsync(ProductModel product)
		{
			var sqlStatement = SqlStatement.Product_Update;

			SqlParameter[] parameters = [
				new("@Id", product.Id),
				new("@Name", product.Name),
				new("@Category", product.Category),
				new("@Detail", product.Detail),
				new("@Price", product.Price),
				new("@InitialQuantity", product.InitialQuantity),
				new("@AvailableQuantity", product.AvailableQuantity),
				new("@ModifiedBy", product.ModifiedBy),
				new("@ModifiedOn", product.ModifiedOn),
			];

			await _context.SentenciaTaskAsync(sqlStatement, parameters);
		}

		public async Task DeleteAsync(ProductModel product)
		{
			var sqlStatement = SqlStatement.Product_Delete;

			SqlParameter[] parameters = [
				new("@Id", product.Id),
				new("@ModifiedBy", product.ModifiedBy),
				new("@ModifiedOn", product.ModifiedOn),
			];

			await _context.SentenciaTaskAsync(sqlStatement, parameters);
		}
	}
}
