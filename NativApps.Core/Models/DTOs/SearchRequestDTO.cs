namespace NativApps.Core.Models.DTOs
{
	public class SearchRequestDTO
	{
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
        public string? Search { get; set; }
    }
}
