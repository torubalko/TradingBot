using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_AvailabilityData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class AvailabilityData : Domain
{
	public int ver { get; set; }

	public string id { get; set; }

	public string name { get; set; }

	public string duration { get; set; }

	public bool success { get; set; }

	public string runLocation { get; set; }

	public string message { get; set; }

	public IDictionary<string, string> properties { get; set; }

	public IDictionary<string, double> measurements { get; set; }

	public AvailabilityData()
		: this("AI.AvailabilityData", "AvailabilityData")
	{
	}

	protected AvailabilityData(string fullName, string name)
	{
		ver = 2;
		id = "";
		this.name = "";
		duration = "";
		runLocation = "";
		message = "";
		properties = new ConcurrentDictionary<string, string>();
		measurements = new ConcurrentDictionary<string, double>();
	}
}
