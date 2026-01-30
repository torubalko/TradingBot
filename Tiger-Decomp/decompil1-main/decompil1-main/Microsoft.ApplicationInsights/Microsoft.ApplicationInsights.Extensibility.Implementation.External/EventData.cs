using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_EventData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class EventData : Domain
{
	public int ver { get; set; }

	public string name { get; set; }

	public IDictionary<string, string> properties { get; set; }

	public IDictionary<string, double> measurements { get; set; }

	public EventData()
		: this("AI.EventData", "EventData")
	{
	}

	protected EventData(string fullName, string name)
	{
		ver = 2;
		this.name = "";
		properties = new ConcurrentDictionary<string, string>();
		measurements = new ConcurrentDictionary<string, double>();
	}
}
