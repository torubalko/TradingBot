using System;

namespace Microsoft.ApplicationInsights.Channel;

public interface ITelemetryChannel : IDisposable
{
	bool? DeveloperMode { get; set; }

	string EndpointAddress { get; set; }

	void Send(ITelemetry item);

	void Flush();
}
