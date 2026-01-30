namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public class HttpWebResponseWrapper
{
	public string Content { get; set; }

	public int StatusCode { get; set; }

	public string RetryAfterHeader { get; set; }

	public string StatusDescription { get; set; }
}
