namespace NativApps.Core.Models.DTOs
{
	public class PaginateResponseDTO<T>
	{
		public int PageIndex { get; set; }
		public int PageSize { get; set; }
		public int PageCount { get; set; }
		public int TotalRecords { get; set; }
		public IEnumerable<T>? Data { get; set; }
	}
}
