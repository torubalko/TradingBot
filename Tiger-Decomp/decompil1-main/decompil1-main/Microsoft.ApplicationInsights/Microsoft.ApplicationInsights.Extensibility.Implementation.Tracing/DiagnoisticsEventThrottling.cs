using System;
using System.Collections.Generic;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class DiagnoisticsEventThrottling : IDiagnoisticsEventThrottling
{
	private readonly int throttleAfterCount;

	private readonly object syncRoot = new object();

	private Dictionary<int, DiagnoisticsEventCounters> counters = new Dictionary<int, DiagnoisticsEventCounters>();

	internal int ThrottleAfterCount => throttleAfterCount;

	internal DiagnoisticsEventThrottling(int throttleAfterCount)
	{
		if (!throttleAfterCount.IsInRangeThrottleAfterCount())
		{
			throw new ArgumentOutOfRangeException("throttleAfterCount");
		}
		this.throttleAfterCount = throttleAfterCount;
	}

	public bool ThrottleEvent(int eventId, long keywords, out bool justExceededThreshold)
	{
		if (!IsExcludedFromThrottling(keywords))
		{
			DiagnoisticsEventCounters diagnoisticsEventCounters = InternalGetEventCounter(eventId);
			justExceededThreshold = ThrottleAfterCount == diagnoisticsEventCounters.Increment() - 1;
			return ThrottleAfterCount < diagnoisticsEventCounters.ExecCount;
		}
		justExceededThreshold = false;
		return false;
	}

	public IDictionary<int, DiagnoisticsEventCounters> CollectSnapshot()
	{
		Dictionary<int, DiagnoisticsEventCounters> result = counters;
		syncRoot.ExecuteSpinWaitLock(delegate
		{
			counters = new Dictionary<int, DiagnoisticsEventCounters>();
		});
		return result;
	}

	private static bool IsExcludedFromThrottling(long keywords)
	{
		return (keywords & 2) != 0;
	}

	private DiagnoisticsEventCounters InternalGetEventCounter(int eventId)
	{
		DiagnoisticsEventCounters result = null;
		syncRoot.ExecuteSpinWaitLock(delegate
		{
			if (!counters.TryGetValue(eventId, out result))
			{
				result = new DiagnoisticsEventCounters();
				counters.Add(eventId, result);
			}
		});
		return result;
	}
}
