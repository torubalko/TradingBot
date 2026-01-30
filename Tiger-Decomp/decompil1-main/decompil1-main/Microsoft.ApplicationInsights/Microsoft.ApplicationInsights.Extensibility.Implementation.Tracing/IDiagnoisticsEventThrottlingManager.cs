namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal interface IDiagnoisticsEventThrottlingManager
{
	bool ThrottleEvent(int eventId, long keywords);
}
