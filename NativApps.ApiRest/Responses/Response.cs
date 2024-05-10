namespace NativApps.ApiRest.Responses
{
	public class Response
	{
		public bool Success { get; set; }
		public int StatusCode { get; set; }
		public object? Data { get; set; }
	}
}
