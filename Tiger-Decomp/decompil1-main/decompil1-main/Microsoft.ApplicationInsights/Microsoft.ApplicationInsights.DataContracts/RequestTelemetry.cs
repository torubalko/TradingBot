using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class RequestTelemetry : OperationTelemetry, ITelemetry, ISupportProperties, ISupportSampling
{
	internal const string TelemetryName = "Request";

	internal readonly string BaseType = typeof(RequestData).Name;

	internal readonly RequestData Data;

	private readonly TelemetryContext context;

	private bool successFieldSet;

	private double? samplingPercentage;

	public override DateTimeOffset Timestamp { get; set; }

	public override string Sequence { get; set; }

	public override TelemetryContext Context => context;

	public override string Id
	{
		get
		{
			return Data.id;
		}
		set
		{
			Data.id = value;
		}
	}

	public override string Name
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

	public string ResponseCode
	{
		get
		{
			return Data.responseCode;
		}
		set
		{
			Data.responseCode = value;
		}
	}

	public override bool? Success
	{
		get
		{
			if (successFieldSet)
			{
				return Data.success;
			}
			return null;
		}
		set
		{
			if (value.HasValue && value.HasValue)
			{
				Data.success = value.Value;
				successFieldSet = true;
			}
			else
			{
				Data.success = true;
				successFieldSet = false;
			}
		}
	}

	public override TimeSpan Duration
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

	public override IDictionary<string, string> Properties => Data.properties;

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
			Data.url = ((value == null) ? null : value.ToString());
		}
	}

	public IDictionary<string, double> Metrics => Data.measurements;

	[Obsolete("Include http verb into request telemetry name and use custom properties to report http method as a dimension.")]
	public string HttpMethod
	{
		get
		{
			return Properties["httpMethod"];
		}
		set
		{
			Properties["httpMethod"] = value;
		}
	}

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

	public string Source
	{
		get
		{
			return Data.source;
		}
		set
		{
			Data.source = value;
		}
	}

	public RequestTelemetry()
	{
		Data = new RequestData();
		context = new TelemetryContext(Data.properties);
		Id = Convert.ToBase64String(BitConverter.GetBytes(WeakConcurrentRandom.Instance.Next()));
	}

	public RequestTelemetry(string name, DateTimeOffset startTime, TimeSpan duration, string responseCode, bool success)
		: this()
	{
		Name = name;
		Timestamp = startTime;
		Duration = duration;
		ResponseCode = responseCode;
		Success = success;
	}

	void ITelemetry.Sanitize()
	{
		Name = Name.SanitizeName();
		Properties.SanitizeProperties();
		Metrics.SanitizeMeasurements();
		Url = Url.SanitizeUri();
		Data.id = Data.id.SanitizeName();
		Data.id = Utils.PopulateRequiredStringValue(Data.id, "id", typeof(RequestTelemetry).FullName);
		if (string.IsNullOrEmpty(ResponseCode))
		{
			ResponseCode = "200";
			Success = true;
		}
		if (!Success.HasValue)
		{
			if (int.TryParse(ResponseCode, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
			{
				Success = result < 400 || result == 401;
			}
			else
			{
				Success = true;
			}
		}
		Context.SanitizeTelemetryContext();
	}
}
