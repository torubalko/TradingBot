namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class TraceEvent
{
	public EventMetaData MetaData { get; set; }

	public object[] Payload { get; set; }
}
