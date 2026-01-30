using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Channel;

internal class TelemetryBuffer
{
	public Action OnFull;

	private const int DefaultCapacity = 500;

	private readonly object lockObj = new object();

	private int capacity = 500;

	private List<ITelemetry> items;

	public int Capacity
	{
		get
		{
			return capacity;
		}
		set
		{
			if (value < 1)
			{
				capacity = 500;
			}
			else
			{
				capacity = value;
			}
		}
	}

	internal TelemetryBuffer()
	{
		items = new List<ITelemetry>();
	}

	public void Enqueue(ITelemetry item)
	{
		if (item == null)
		{
			CoreEventSource.Log.LogVerbose("item is null in TelemetryBuffer.Enqueue");
			return;
		}
		lock (lockObj)
		{
			items.Add(item);
			if (items.Count >= Capacity)
			{
				OnFull?.Invoke();
			}
		}
	}

	public IEnumerable<ITelemetry> Dequeue()
	{
		List<ITelemetry> result = null;
		if (items.Count > 0)
		{
			lock (lockObj)
			{
				if (items.Count > 0)
				{
					result = items;
					items = new List<ITelemetry>();
				}
			}
		}
		return result;
	}
}
