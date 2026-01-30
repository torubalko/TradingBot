using Microsoft.ApplicationInsights.Channel;

namespace Microsoft.ApplicationInsights.Extensibility;

public interface ITelemetryProcessor
{
	void Process(ITelemetry item);
}
