using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class MetricTelemetry : ITelemetry, ISupportProperties
{
	internal const string TelemetryName = "Metric";

	internal readonly string BaseType = typeof(MetricData).Name;

	internal readonly MetricData Data;

	internal readonly DataPoint Metric;

	private bool isAggregation;

	public DateTimeOffset Timestamp { get; set; }

	public string Sequence { get; set; }

	public TelemetryContext Context { get; }

	public string Name
	{
		get
		{
			return Metric.name;
		}
		set
		{
			Metric.name = value;
		}
	}

	public double Value
	{
		get
		{
			return Metric.value;
		}
		set
		{
			Metric.value = value;
		}
	}

	public int? Count
	{
		get
		{
			return Metric.count;
		}
		set
		{
			Metric.count = value;
			UpdateKind();
		}
	}

	public double? Min
	{
		get
		{
			return Metric.min;
		}
		set
		{
			Metric.min = value;
			UpdateKind();
		}
	}

	public double? Max
	{
		get
		{
			return Metric.max;
		}
		set
		{
			Metric.max = value;
			UpdateKind();
		}
	}

	public double? StandardDeviation
	{
		get
		{
			return Metric.stdDev;
		}
		set
		{
			Metric.stdDev = value;
			UpdateKind();
		}
	}

	public IDictionary<string, string> Properties => Data.properties;

	public MetricTelemetry()
	{
		Data = new MetricData();
		Metric = new DataPoint();
		Context = new TelemetryContext(Data.properties);
		Data.metrics.Add(Metric);
	}

	public MetricTelemetry(string metricName, double metricValue)
		: this()
	{
		Name = metricName;
		Value = metricValue;
	}

	void ITelemetry.Sanitize()
	{
		Name = Name.SanitizeName();
		Name = Utils.PopulateRequiredStringValue(Name, "name", typeof(MetricTelemetry).FullName);
		Properties.SanitizeProperties();
		Value = Utils.SanitizeNanAndInfinity(Value);
		if (Min.HasValue)
		{
			Min = Utils.SanitizeNanAndInfinity(Min.Value);
		}
		if (Max.HasValue)
		{
			Max = Utils.SanitizeNanAndInfinity(Max.Value);
		}
		if (StandardDeviation.HasValue)
		{
			StandardDeviation = Utils.SanitizeNanAndInfinity(StandardDeviation.Value);
		}
		Context.SanitizeTelemetryContext();
	}

	private void UpdateKind()
	{
		bool flag = Metric.count.HasValue || Metric.min.HasValue || Metric.max.HasValue || Metric.stdDev.HasValue;
		if (isAggregation != flag)
		{
			Metric.kind = (flag ? DataPointType.Aggregation : DataPointType.Measurement);
		}
		isAggregation = flag;
	}
}
