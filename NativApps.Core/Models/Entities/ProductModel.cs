namespace NativApps.Core.Models.Entities
{
	public class ProductModel : AuditableEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Detail { get; set; }
		public string? Category { get; set; }
		public int Price { get; set; }
		public int InitialQuantity { get; set; }
		public int? AvailableQuantity { get; set; }
	}
}
