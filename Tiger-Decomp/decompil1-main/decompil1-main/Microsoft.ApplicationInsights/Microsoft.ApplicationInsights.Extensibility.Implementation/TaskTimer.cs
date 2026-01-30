using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public class TaskTimer : IDisposable
{
	public static readonly TimeSpan InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, -1);

	private TimeSpan delay = TimeSpan.FromMinutes(1.0);

	private CancellationTokenSource tokenSource;

	public TimeSpan Delay
	{
		get
		{
			return delay;
		}
		set
		{
			if ((value <= TimeSpan.Zero || value.TotalMilliseconds > 2147483647.0) && value != InfiniteTimeSpan)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			delay = value;
		}
	}

	public bool IsStarted => tokenSource != null;

	public void Start(Func<Task> elapsed)
	{
		CancellationTokenSource newTokenSource = new CancellationTokenSource();
		Task.Delay(Delay, newTokenSource.Token).ContinueWith((Func<Task, Task>)async delegate
		{
			CancelAndDispose(Interlocked.CompareExchange(ref tokenSource, null, newTokenSource));
			try
			{
				Task task = elapsed();
				if (task != null)
				{
					await task.ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			catch (Exception exception)
			{
				LogException(exception);
			}
		}, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		CancelAndDispose(Interlocked.Exchange(ref tokenSource, newTokenSource));
	}

	public void Cancel()
	{
		CancelAndDispose(Interlocked.Exchange(ref tokenSource, null));
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private static void LogException(Exception exception)
	{
		if (exception is AggregateException ex)
		{
			AggregateException ex2 = ex.Flatten();
			foreach (Exception innerException in ex2.InnerExceptions)
			{
				CoreEventSource.Log.LogError(innerException.ToInvariantString());
			}
		}
		CoreEventSource.Log.LogError(exception.ToInvariantString());
	}

	private static void CancelAndDispose(CancellationTokenSource tokenSource)
	{
		if (tokenSource != null)
		{
			tokenSource.Cancel();
			tokenSource.Dispose();
		}
	}

	private void Dispose(bool disposing)
	{
		if (disposing)
		{
			Cancel();
		}
	}
}
