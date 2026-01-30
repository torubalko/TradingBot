using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class DiagnoisticsEventThrottlingManager<T> : IDiagnoisticsEventThrottlingManager where T : IDiagnoisticsEventThrottling
{
	private readonly T snapshotContainer;

	internal DiagnoisticsEventThrottlingManager(T snapshotContainer, IDiagnoisticsEventThrottlingScheduler scheduler, uint throttlingRecycleIntervalInMinutes)
	{
		if (snapshotContainer == null)
		{
			throw new ArgumentNullException("snapshotContainer");
		}
		if (scheduler == null)
		{
			throw new ArgumentNullException("scheduler");
		}
		if (!throttlingRecycleIntervalInMinutes.IsInRangeThrottlingRecycleInterval())
		{
			throw new ArgumentOutOfRangeException("throttlingRecycleIntervalInMinutes");
		}
		this.snapshotContainer = snapshotContainer;
		int interval = (int)(throttlingRecycleIntervalInMinutes * 60 * 1000);
		scheduler.ScheduleToRunEveryTimeIntervalInMilliseconds(interval, ResetThrottling);
	}

	public bool ThrottleEvent(int eventId, long keywords)
	{
		bool justExceededThreshold;
		bool result = snapshotContainer.ThrottleEvent(eventId, keywords, out justExceededThreshold);
		if (justExceededThreshold)
		{
			CoreEventSource.Log.DiagnosticsEventThrottlingHasBeenStartedForTheEvent(eventId.ToString(CultureInfo.InvariantCulture));
		}
		return result;
	}

	private void ResetThrottling()
	{
		foreach (KeyValuePair<int, DiagnoisticsEventCounters> item in snapshotContainer.CollectSnapshot())
		{
			CoreEventSource.Log.DiagnosticsEventThrottlingHasBeenResetForTheEvent(item.Key, item.Value.ExecCount);
		}
	}
}
