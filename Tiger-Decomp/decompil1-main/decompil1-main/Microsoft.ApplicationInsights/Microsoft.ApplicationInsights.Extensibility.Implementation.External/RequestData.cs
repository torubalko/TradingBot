using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_RequestData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class RequestData : Domain
{
	public int ver { get; set; }

	public string id { get; set; }

	public string source { get; set; }

	public string name { get; set; }

	public string duration { get; set; }

	public string responseCode { get; set; }

	public bool success { get; set; }

	public string url { get; set; }

	public IDictionary<string, string> properties { get; set; }

	public IDictionary<string, double> measurements { get; set; }

	public RequestData()
		: this("AI.RequestData", "RequestData")
	{
	}

	protected RequestData(string fullName, string name)
	{
		ver = 2;
		id = "";
		source = "";
		this.name = "";
		duration = "";
		responseCode = "";
		url = "";
		properties = new ConcurrentDictionary<string, string>();
		measurements = new ConcurrentDictionary<string, double>();
	}
}
