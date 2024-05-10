namespace NativApps.Core.Models.DTOs
{
	public class ProductDto
	{
		public string Name { get; set; }
		public string? Detail { get; set; }
		public string? Category { get; set; }
		public int Price { get; set; }
		public int InitialQuantity { get; set; }
		public int? AvailableQuantity { get; set; }
	}
}
