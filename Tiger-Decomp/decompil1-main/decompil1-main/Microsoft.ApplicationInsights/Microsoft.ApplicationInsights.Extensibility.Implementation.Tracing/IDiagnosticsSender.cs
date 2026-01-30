namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal interface IDiagnosticsSender
{
	void Send(TraceEvent eventData);
}
