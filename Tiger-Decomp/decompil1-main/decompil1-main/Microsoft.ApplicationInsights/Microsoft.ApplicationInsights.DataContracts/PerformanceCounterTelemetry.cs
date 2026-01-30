using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Channel;

namespace Microsoft.ApplicationInsights.DataContracts;

[Obsolete("Use MetricTelemetry instead.")]
public sealed class PerformanceCounterTelemetry : ITelemetry, ISupportProperties
{
	internal readonly MetricTelemetry Data;

	private string categoryName = string.Empty;

	private string counterName = string.Empty;

	public DateTimeOffset Timestamp
	{
		get
		{
			return Data.Timestamp;
		}
		set
		{
			Data.Timestamp = value;
		}
	}

	public string Sequence
	{
		get
		{
			return Data.Sequence;
		}
		set
		{
			Data.Sequence = value;
		}
	}

	public TelemetryContext Context => Data.Context;

	public double Value
	{
		get
		{
			return Data.Value;
		}
		set
		{
			Data.Value = value;
		}
	}

	public string CategoryName
	{
		get
		{
			return categoryName;
		}
		set
		{
			categoryName = value;
			UpdateName();
		}
	}

	public string CounterName
	{
		get
		{
			return counterName;
		}
		set
		{
			counterName = value;
			UpdateName();
		}
	}

	public string InstanceName
	{
		get
		{
			if (Properties.ContainsKey("CounterInstanceName"))
			{
				return Properties["CounterInstanceName"];
			}
			return string.Empty;
		}
		set
		{
			Properties["CounterInstanceName"] = value;
			UpdateName();
		}
	}

	public IDictionary<string, string> Properties => Data.Properties;

	public PerformanceCounterTelemetry()
	{
		Data = new MetricTelemetry();
	}

	public PerformanceCounterTelemetry(string categoryName, string counterName, string instanceName, double value)
		: this()
	{
		CategoryName = categoryName;
		CounterName = counterName;
		InstanceName = instanceName;
		Value = value;
	}

	void ITelemetry.Sanitize()
	{
		((ITelemetry)Data).Sanitize();
	}

	private void UpdateName()
	{
		if (categoryName == "Processor")
		{
			Data.Name = "\\" + categoryName + "(_Total)\\" + counterName;
			return;
		}
		if (categoryName == "Process")
		{
			Data.Name = "\\" + categoryName + "(??APP_WIN32_PROC??)\\" + counterName;
			return;
		}
		if (categoryName == "ASP.NET Applications")
		{
			Data.Name = "\\" + categoryName + "(??APP_W3SVC_PROC??)\\" + counterName;
			return;
		}
		if (categoryName == ".NET CLR Exceptions")
		{
			Data.Name = "\\" + categoryName + "(??APP_CLR_PROC??)\\" + counterName;
			return;
		}
		MetricTelemetry data = Data;
		string name;
		if (!string.IsNullOrEmpty(InstanceName))
		{
			string text = (Data.Name = "\\" + categoryName + "(" + InstanceName + ")\\" + counterName);
			name = text;
		}
		else
		{
			string text = (Data.Name = "\\" + categoryName + "\\" + counterName);
			name = text;
		}
		data.Name = name;
	}
}
