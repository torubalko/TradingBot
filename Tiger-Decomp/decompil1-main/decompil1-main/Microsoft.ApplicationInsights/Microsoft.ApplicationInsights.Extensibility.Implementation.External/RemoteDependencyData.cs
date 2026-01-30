using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_RemoteDependencyData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class RemoteDependencyData : Domain
{
	public int ver { get; set; }

	public string name { get; set; }

	public string id { get; set; }

	public string resultCode { get; set; }

	public string duration { get; set; }

	public bool? success { get; set; }

	public string data { get; set; }

	public string target { get; set; }

	public string type { get; set; }

	public IDictionary<string, string> properties { get; set; }

	public IDictionary<string, double> measurements { get; set; }

	public RemoteDependencyData()
		: this("AI.RemoteDependencyData", "RemoteDependencyData")
	{
	}

	protected RemoteDependencyData(string fullName, string name)
	{
		ver = 2;
		this.name = "";
		id = "";
		resultCode = "";
		duration = "";
		success = true;
		target = "";
		type = "";
		properties = new ConcurrentDictionary<string, string>();
		measurements = new ConcurrentDictionary<string, double>();
	}
}
