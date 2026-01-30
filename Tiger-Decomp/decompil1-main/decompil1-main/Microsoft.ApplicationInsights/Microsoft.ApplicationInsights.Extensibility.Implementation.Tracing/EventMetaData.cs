using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class EventMetaData
{
	public int EventId { get; set; }

	public string MessageFormat { get; set; }

	public long Keywords { get; set; }

	public EventLevel Level { get; set; }
}
