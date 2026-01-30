using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Channel;

internal class InMemoryTransmitter : IDisposable
{
	private readonly TelemetryBuffer buffer;

	private object sendingLockObj = new object();

	private AutoResetEvent startRunnerEvent;

	private bool enabled = true;

	private int disposeCount;

	private TimeSpan sendingInterval = TimeSpan.FromSeconds(30.0);

	private Uri endpointAddress = new Uri("https://dc.services.visualstudio.com/v2/track");

	internal Uri EndpointAddress
	{
		get
		{
			return endpointAddress;
		}
		set
		{
			Property.Set(ref endpointAddress, value);
		}
	}

	internal TimeSpan SendingInterval
	{
		get
		{
			return sendingInterval;
		}
		set
		{
			sendingInterval = value;
		}
	}

	internal InMemoryTransmitter(TelemetryBuffer buffer)
	{
		this.buffer = buffer;
		this.buffer.OnFull = OnBufferFull;
		Task.Factory.StartNew(Runner, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default).ContinueWith(delegate(Task task)
		{
			string msg = string.Format(CultureInfo.InvariantCulture, "InMemoryTransmitter: Unhandled exception in Runner: {0}", task.Exception);
			CoreEventSource.Log.LogVerbose(msg);
		}, TaskContinuationOptions.OnlyOnFaulted);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	internal void Flush(TimeSpan timeout)
	{
		DequeueAndSend(timeout);
	}

	private void Runner()
	{
		using (startRunnerEvent = new AutoResetEvent(initialState: false))
		{
			while (enabled)
			{
				DequeueAndSend(default(TimeSpan));
				startRunnerEvent.WaitOne(sendingInterval);
			}
		}
	}

	private void OnBufferFull()
	{
		startRunnerEvent.Set();
	}

	private void DequeueAndSend(TimeSpan timeout)
	{
		lock (sendingLockObj)
		{
			IEnumerable<ITelemetry> telemetryItems = buffer.Dequeue();
			try
			{
				Send(telemetryItems, timeout).Wait();
			}
			catch (Exception ex)
			{
				CoreEventSource.Log.FailedToSend(ex.Message);
			}
		}
	}

	private Task Send(IEnumerable<ITelemetry> telemetryItems, TimeSpan timeout)
	{
		if (telemetryItems == null || !telemetryItems.Any())
		{
			CoreEventSource.Log.LogVerbose("No Telemetry Items passed to Enqueue");
			return Task.FromResult<object>(null);
		}
		byte[] content = JsonSerializer.Serialize(telemetryItems);
		return new Transmission(endpointAddress, content, JsonSerializer.ContentType, JsonSerializer.CompressionType, timeout).SendAsync();
	}

	private void Dispose(bool disposing)
	{
		if (Interlocked.Increment(ref disposeCount) == 1)
		{
			enabled = false;
			if (startRunnerEvent != null)
			{
				startRunnerEvent.Set();
			}
		}
	}
}
