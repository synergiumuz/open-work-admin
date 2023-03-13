using System;
using System.Net;

namespace OpenWorkAdmin.Service.Utils;

public class StatusCodeException : Exception
{
	public HttpStatusCode Code { get; set; }

	public StatusCodeException(HttpStatusCode code, string message) : base(message)
	{
		Code = code;
	}
}
