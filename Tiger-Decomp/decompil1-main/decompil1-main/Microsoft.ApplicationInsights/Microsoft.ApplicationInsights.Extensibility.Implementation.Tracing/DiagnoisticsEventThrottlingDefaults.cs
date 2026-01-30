namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal static class DiagnoisticsEventThrottlingDefaults
{
	internal const int MinimalThrottleAfterCount = 1;

	internal const int DefaultThrottleAfterCount = 5;

	internal const int MaxThrottleAfterCount = 10;

	internal const uint MinimalThrottlingRecycleIntervalInMinutes = 1u;

	internal const uint DefaultThrottlingRecycleIntervalInMinutes = 5u;

	internal const uint MaxThrottlingRecycleIntervalInMinutes = 60u;

	internal const int KeywordsExcludedFromEventThrottling = 2;

	internal static bool IsInRangeThrottleAfterCount(this int throttleAfterCount)
	{
		if (throttleAfterCount >= 1)
		{
			return throttleAfterCount <= 10;
		}
		return false;
	}

	internal static bool IsInRangeThrottlingRecycleInterval(this uint throttlingRecycleIntervalInMinutes)
	{
		if (throttlingRecycleIntervalInMinutes >= 1)
		{
			return throttlingRecycleIntervalInMinutes <= 60;
		}
		return false;
	}
}
