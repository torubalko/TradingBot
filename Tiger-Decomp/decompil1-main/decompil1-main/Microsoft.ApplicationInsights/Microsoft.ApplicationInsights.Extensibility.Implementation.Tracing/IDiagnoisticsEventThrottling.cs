using System.Collections.Generic;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal interface IDiagnoisticsEventThrottling
{
	bool ThrottleEvent(int eventId, long keywords, out bool justExceededThreshold);

	IDictionary<int, DiagnoisticsEventCounters> CollectSnapshot();
}
