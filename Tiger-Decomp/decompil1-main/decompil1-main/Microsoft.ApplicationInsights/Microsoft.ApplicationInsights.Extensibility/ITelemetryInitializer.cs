using Microsoft.ApplicationInsights.Channel;

namespace Microsoft.ApplicationInsights.Extensibility;

public interface ITelemetryInitializer
{
	void Initialize(ITelemetry telemetry);
}
