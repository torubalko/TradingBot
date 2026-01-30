using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class TraceTelemetry : ITelemetry, ISupportProperties, ISupportSampling
{
	internal const string TelemetryName = "Message";

	internal readonly string BaseType = typeof(MessageData).Name;

	internal readonly MessageData Data;

	private readonly TelemetryContext context;

	private double? samplingPercentage;

	public DateTimeOffset Timestamp { get; set; }

	public string Sequence { get; set; }

	public TelemetryContext Context => context;

	public string Message
	{
		get
		{
			return Data.message;
		}
		set
		{
			Data.message = value;
		}
	}

	public SeverityLevel? SeverityLevel
	{
		get
		{
			return Data.severityLevel.TranslateSeverityLevel();
		}
		set
		{
			Data.severityLevel = value.TranslateSeverityLevel();
		}
	}

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

	public TraceTelemetry()
	{
		Data = new MessageData();
		context = new TelemetryContext(Data.properties);
	}

	public TraceTelemetry(string message)
		: this()
	{
		Message = message;
	}

	public TraceTelemetry(string message, SeverityLevel severityLevel)
		: this(message)
	{
		SeverityLevel = severityLevel;
	}

	void ITelemetry.Sanitize()
	{
		Data.message = Data.message.SanitizeMessage();
		Data.message = Utils.PopulateRequiredStringValue(Data.message, "message", typeof(TraceTelemetry).FullName);
		Data.properties.SanitizeProperties();
		Context.SanitizeTelemetryContext();
	}
}
