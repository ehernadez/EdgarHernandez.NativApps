using NativApps.Core.Models.DTOs;
using System.Data.SqlClient;

namespace NativApps.Infraestructure.Repositories.Implementations
{
	public class BaseRepository
	{
		public static SqlParameter[] GetFilterParameters(QueryRequestDTO filters)
		{
			SqlParameter[] parameters = [
				new("@PageIndex", filters.PageIndex),
				new("@PageSize", filters.PageSize),
			];

			return parameters;
		}

		public static SqlParameter[] GetFilterParameters(QueryRequestDTO filters, SearchRequestDTO searchRequest)
		{
			SqlParameter[] parameters = [
				new("@PageIndex", filters.PageIndex),
				new("@PageSize", filters.PageSize),
				new("@Search", searchRequest.Search),
				new("@PriceMin", searchRequest.PriceMin),
				new("@PriceMax", searchRequest.PriceMax),
			];

			return parameters;
		}

		public static string FormatOrderSqlQuery(string query, bool orderByDesc, string columnOrder = "Id")
		{
			string isDesc = orderByDesc ? "DESC" : "ASC";
			string sqlStatement = string.Format(query, columnOrder, isDesc);

			return sqlStatement;
		}
	}
}
