namespace Microsoft.ApplicationInsights.Extensibility;

public interface ITelemetryModule
{
	void Initialize(TelemetryConfiguration configuration);
}
