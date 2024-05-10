namespace NativApps.Core.Models.Entities
{
	public class UserModel : AuditableEntity
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
	}
}
