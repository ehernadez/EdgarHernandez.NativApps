namespace NativApps.Core.Models.DTOs
{
	public class ProductResponseDTO : ProductDto
	{
        public int Id { get; set; }
		public DateTime CreatedOn { get; set; }
    }
}
