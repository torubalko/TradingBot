using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace Microsoft.ApplicationInsights;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class OperationTelemetryExtensions
{
	public static void Start(this OperationTelemetry telemetry)
	{
		telemetry.Timestamp = DateTimeOffset.UtcNow;
		telemetry.BeginTimeInTicks = Stopwatch.GetTimestamp();
	}

	public static void Stop(this OperationTelemetry telemetry)
	{
		if (telemetry.BeginTimeInTicks != 0L)
		{
			double value = (double)((Stopwatch.GetTimestamp() - telemetry.BeginTimeInTicks) * 1000) / (double)Stopwatch.Frequency;
			telemetry.Duration = TimeSpan.FromMilliseconds(value);
		}
		else
		{
			telemetry.Duration = TimeSpan.Zero;
		}
		if (telemetry.Timestamp == DateTimeOffset.MinValue)
		{
			telemetry.Timestamp = DateTimeOffset.UtcNow;
		}
	}

	public static void GenerateOperationId(this OperationTelemetry telemetry)
	{
		telemetry.Id = Convert.ToBase64String(BitConverter.GetBytes(WeakConcurrentRandom.Instance.Next()));
	}
}
