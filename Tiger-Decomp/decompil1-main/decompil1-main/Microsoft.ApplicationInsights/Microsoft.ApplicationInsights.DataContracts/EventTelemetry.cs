using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class EventTelemetry : ITelemetry, ISupportProperties, ISupportSampling
{
	internal const string TelemetryName = "Event";

	internal readonly string BaseType = typeof(EventData).Name;

	internal readonly EventData Data;

	private readonly TelemetryContext context;

	private double? samplingPercentage;

	public DateTimeOffset Timestamp { get; set; }

	public string Sequence { get; set; }

	public TelemetryContext Context => context;

	public string Name
	{
		get
		{
			return Data.name;
		}
		set
		{
			Data.name = value;
		}
	}

	public IDictionary<string, double> Metrics => Data.measurements;

	public IDictionary<string, string> Properties => Data.properties;

	double? ISupportSampling.SamplingPercentage
	{
		get
		{
			return samplingPercentage;
		}
		set
		{
			samplingPercentage = value;
		}
	}

	public EventTelemetry()
	{
		Data = new EventData();
		context = new TelemetryContext(Data.properties);
	}

	public EventTelemetry(string name)
		: this()
	{
		Name = name;
	}

	void ITelemetry.Sanitize()
	{
		Name = Name.SanitizeEventName();
		Name = Utils.PopulateRequiredStringValue(Name, "name", typeof(EventTelemetry).FullName);
		Properties.SanitizeProperties();
		Metrics.SanitizeMeasurements();
		Context.SanitizeTelemetryContext();
	}
}
