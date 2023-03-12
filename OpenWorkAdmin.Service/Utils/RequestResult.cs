using System.Net;

namespace OpenWorkAdmin.Service.Utils;

public class RequestResult
{
	public string Content { get; set; } = string.Empty;
	public HttpStatusCode StatusCode { get; set; }

	public RequestResult(string content, HttpStatusCode statusCode)
	{
		Content = content;
		StatusCode = statusCode;
	}
}
