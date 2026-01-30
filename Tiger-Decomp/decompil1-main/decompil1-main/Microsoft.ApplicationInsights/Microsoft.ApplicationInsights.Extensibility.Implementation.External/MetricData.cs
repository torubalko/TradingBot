using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_MetricData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class MetricData : Domain
{
	public int ver { get; set; }

	public IList<DataPoint> metrics { get; set; }

	public IDictionary<string, string> properties { get; set; }

	public MetricData()
		: this("AI.MetricData", "MetricData")
	{
	}

	protected MetricData(string fullName, string name)
	{
		ver = 2;
		metrics = new List<DataPoint>();
		properties = new ConcurrentDictionary<string, string>();
	}
}
