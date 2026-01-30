using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.ApplicationInsights.Channel;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class TelemetryProcessorChain : IDisposable
{
	private readonly SnapshottingList<ITelemetryProcessor> telemetryProcessors = new SnapshottingList<ITelemetryProcessor>();

	internal ITelemetryProcessor FirstTelemetryProcessor => telemetryProcessors.First();

	internal SnapshottingList<ITelemetryProcessor> TelemetryProcessors => telemetryProcessors;

	internal TelemetryProcessorChain()
	{
	}

	internal TelemetryProcessorChain(IEnumerable<ITelemetryProcessor> telemetryProcessors)
	{
		foreach (ITelemetryProcessor telemetryProcessor in telemetryProcessors)
		{
			this.telemetryProcessors.Add(telemetryProcessor);
		}
	}

	public void Process(ITelemetry item)
	{
		telemetryProcessors.First().Process(item);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		SnapshottingList<ITelemetryProcessor> snapshottingList = telemetryProcessors;
		if (snapshottingList == null)
		{
			return;
		}
		foreach (ITelemetryProcessor item in snapshottingList)
		{
			if (item is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}
}
