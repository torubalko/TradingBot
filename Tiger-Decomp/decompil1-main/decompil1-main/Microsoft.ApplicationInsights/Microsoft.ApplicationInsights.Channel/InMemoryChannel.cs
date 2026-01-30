using System;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Channel;

public class InMemoryChannel : ITelemetryChannel, IDisposable
{
	private readonly TelemetryBuffer buffer;

	private readonly InMemoryTransmitter transmitter;

	private bool? developerMode = false;

	private int bufferSize;

	public bool? DeveloperMode
	{
		get
		{
			return developerMode;
		}
		set
		{
			if (value != developerMode)
			{
				if (value.HasValue && value.Value)
				{
					bufferSize = buffer.Capacity;
					buffer.Capacity = 1;
				}
				else
				{
					buffer.Capacity = bufferSize;
				}
				developerMode = value;
			}
		}
	}

	public TimeSpan SendingInterval
	{
		get
		{
			return transmitter.SendingInterval;
		}
		set
		{
			transmitter.SendingInterval = value;
		}
	}

	public string EndpointAddress
	{
		get
		{
			return transmitter.EndpointAddress.ToString();
		}
		set
		{
			transmitter.EndpointAddress = new Uri(value);
		}
	}

	public int MaxTelemetryBufferCapacity
	{
		get
		{
			return buffer.Capacity;
		}
		set
		{
			buffer.Capacity = value;
		}
	}

	public InMemoryChannel()
	{
		buffer = new TelemetryBuffer();
		transmitter = new InMemoryTransmitter(buffer);
	}

	internal InMemoryChannel(TelemetryBuffer telemetryBuffer, InMemoryTransmitter transmitter)
	{
		buffer = telemetryBuffer;
		this.transmitter = transmitter;
	}

	public void Send(ITelemetry item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		try
		{
			buffer.Enqueue(item);
		}
		catch (Exception ex)
		{
			CoreEventSource.Log.LogVerbose("TelemetryBuffer.Enqueue failed: ", ex.ToString());
		}
	}

	public void Flush()
	{
		Flush(default(TimeSpan));
	}

	public void Flush(TimeSpan timeout)
	{
		transmitter.Flush(timeout);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (disposing && transmitter != null)
		{
			transmitter.Dispose();
		}
	}
}
