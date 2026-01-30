using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_MessageData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class MessageData : Domain
{
	public int ver { get; set; }

	public string message { get; set; }

	public SeverityLevel? severityLevel { get; set; }

	public IDictionary<string, string> properties { get; set; }

	public MessageData()
		: this("AI.MessageData", "MessageData")
	{
	}

	protected MessageData(string fullName, string name)
	{
		ver = 2;
		message = "";
		properties = new ConcurrentDictionary<string, string>();
	}
}
