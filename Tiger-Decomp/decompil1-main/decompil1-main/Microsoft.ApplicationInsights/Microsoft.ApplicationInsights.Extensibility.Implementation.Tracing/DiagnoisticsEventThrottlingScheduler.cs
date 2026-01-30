using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class DiagnoisticsEventThrottlingScheduler : IDiagnoisticsEventThrottlingScheduler, IDisposable
{
	private readonly IList<TaskTimer> timers = new List<TaskTimer>();

	private volatile bool disposed;

	public ICollection<object> Tokens => new ReadOnlyCollection<object>(timers.Cast<object>().ToList());

	~DiagnoisticsEventThrottlingScheduler()
	{
		Dispose(managed: false);
	}

	public object ScheduleToRunEveryTimeIntervalInMilliseconds(int interval, Action actionToExecute)
	{
		if (interval <= 0)
		{
			throw new ArgumentOutOfRangeException("interval");
		}
		if (actionToExecute == null)
		{
			throw new ArgumentNullException("actionToExecute");
		}
		TaskTimer taskTimer = InternalCreateAndStartTimer(interval, actionToExecute);
		timers.Add(taskTimer);
		CoreEventSource.Log.DiagnoisticsEventThrottlingSchedulerTimerWasCreated(interval.ToString(CultureInfo.InvariantCulture));
		return taskTimer;
	}

	public void RemoveScheduledRoutine(object token)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		if (!(token is TaskTimer taskTimer))
		{
			throw new ArgumentException("token");
		}
		if (timers.Remove(taskTimer))
		{
			DisposeTimer(taskTimer);
			CoreEventSource.Log.DiagnoisticsEventThrottlingSchedulerTimerWasRemoved();
		}
	}

	public void Dispose()
	{
		Dispose(managed: true);
	}

	private static void DisposeTimer(IDisposable timer)
	{
		try
		{
			timer.Dispose();
		}
		catch (Exception exception)
		{
			CoreEventSource.Log.DiagnoisticsEventThrottlingSchedulerDisposeTimerFailure(exception.ToInvariantString());
		}
	}

	private static TaskTimer InternalCreateAndStartTimer(int intervalInMilliseconds, Action action)
	{
		TaskTimer timer = new TaskTimer
		{
			Delay = TimeSpan.FromMilliseconds(intervalInMilliseconds)
		};
		Func<Task> task = null;
		task = delegate
		{
			timer.Start(task);
			action();
			return Task.FromResult<object>(null);
		};
		timer.Start(task);
		return timer;
	}

	private void Dispose(bool managed)
	{
		if (managed && !disposed)
		{
			DisposeAllTimers();
			GC.SuppressFinalize(this);
		}
		disposed = true;
	}

	private void DisposeAllTimers()
	{
		foreach (TaskTimer timer in timers)
		{
			DisposeTimer(timer);
		}
		timers.Clear();
	}
}
