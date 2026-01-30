using System.CodeDom.Compiler;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[EventData]
[GeneratedCode("gbc", "0.4.1.0")]
internal class DataPoint
{
	public string name { get; set; }

	public DataPointType kind { get; set; }

	public double value { get; set; }

	public int? count { get; set; }

	public double? min { get; set; }

	public double? max { get; set; }

	public double? stdDev { get; set; }

	public DataPoint()
		: this("AI.DataPoint", "DataPoint")
	{
	}

	protected DataPoint(string fullName, string name)
	{
		this.name = "";
		kind = DataPointType.Measurement;
	}
}
