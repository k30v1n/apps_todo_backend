using System.Text.Json.Serialization;

namespace TodoApp.Api.Http.Common
{
	public class ErrorDetailsResponse
	{
		[JsonPropertyName("error")]
		public string Error { get; set; }
	}
}