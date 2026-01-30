using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class PageViewTelemetry : ITelemetry, ISupportProperties, ISupportSampling
{
	internal const string TelemetryName = "PageView";

	internal readonly string BaseType = typeof(PageViewData).Name;

	internal readonly PageViewData Data;

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

	public Uri Url
	{
		get
		{
			if (Data.url.IsNullOrWhiteSpace())
			{
				return null;
			}
			return new Uri(Data.url, UriKind.RelativeOrAbsolute);
		}
		set
		{
			if (value == null)
			{
				Data.url = null;
			}
			else
			{
				Data.url = value.ToString();
			}
		}
	}

	public TimeSpan Duration
	{
		get
		{
			return Utils.ValidateDuration(Data.duration);
		}
		set
		{
			Data.duration = value.ToString();
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

	public PageViewTelemetry()
	{
		Data = new PageViewData();
		context = new TelemetryContext(Data.properties);
	}

	public PageViewTelemetry(string pageName)
		: this()
	{
		Name = pageName;
	}

	void ITelemetry.Sanitize()
	{
		Name = Name.SanitizeName();
		Name = Utils.PopulateRequiredStringValue(Name, "name", typeof(PageViewTelemetry).FullName);
		Properties.SanitizeProperties();
		Metrics.SanitizeMeasurements();
		Url = Url.SanitizeUri();
		Context.SanitizeTelemetryContext();
	}
}
