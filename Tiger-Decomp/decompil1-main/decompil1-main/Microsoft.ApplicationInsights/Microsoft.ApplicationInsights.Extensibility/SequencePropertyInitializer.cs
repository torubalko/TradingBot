using System;
using System.Threading;
using Microsoft.ApplicationInsights.Channel;

namespace Microsoft.ApplicationInsights.Extensibility;

public sealed class SequencePropertyInitializer : ITelemetryInitializer
{
	private readonly string stablePrefix = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).TrimEnd('=') + ":";

	private long currentNumber;

	public void Initialize(ITelemetry telemetry)
	{
		if (string.IsNullOrEmpty(telemetry.Sequence))
		{
			telemetry.Sequence = stablePrefix + Interlocked.Increment(ref currentNumber);
		}
	}
}
