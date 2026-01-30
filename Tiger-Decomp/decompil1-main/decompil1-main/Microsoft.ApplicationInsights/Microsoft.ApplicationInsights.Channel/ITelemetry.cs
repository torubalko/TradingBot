using System;
using Microsoft.ApplicationInsights.DataContracts;

namespace Microsoft.ApplicationInsights.Channel;

public interface ITelemetry
{
	DateTimeOffset Timestamp { get; set; }

	TelemetryContext Context { get; }

	string Sequence { get; set; }

	void Sanitize();
}
