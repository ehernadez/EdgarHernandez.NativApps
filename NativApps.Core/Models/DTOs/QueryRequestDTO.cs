namespace NativApps.Core.Models.DTOs
{
	public class QueryRequestDTO
	{
		public bool OrderByDesc { get; set; }
		public int PageIndex { get; set; }
		public int PageSize { get; set; }
	}
}
