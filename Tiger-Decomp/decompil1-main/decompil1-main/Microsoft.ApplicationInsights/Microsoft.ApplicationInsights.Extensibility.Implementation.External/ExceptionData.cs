using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData(Name = "PartB_ExceptionData")]
[GeneratedCode("gbc", "0.4.1.0")]
internal class ExceptionData : Domain
{
	public int ver { get; set; }

	public IList<ExceptionDetails> exceptions { get; set; }

	public SeverityLevel? severityLevel { get; set; }

	public string problemId { get; set; }

	public IDictionary<string, string> properties { get; set; }

	public IDictionary<string, double> measurements { get; set; }

	public ExceptionData()
		: this("AI.ExceptionData", "ExceptionData")
	{
	}

	protected ExceptionData(string fullName, string name)
	{
		ver = 2;
		exceptions = new List<ExceptionDetails>();
		problemId = "";
		properties = new ConcurrentDictionary<string, string>();
		measurements = new ConcurrentDictionary<string, double>();
	}
}
