using System;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal interface IDiagnoisticsEventThrottlingScheduler
{
	object ScheduleToRunEveryTimeIntervalInMilliseconds(int interval, Action actionToExecute);

	void RemoveScheduledRoutine(object token);
}
