using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class AvailabilityTelemetry : ITelemetry, ISupportProperties
{
	internal const string TelemetryName = "Availability";

	internal readonly string BaseType = typeof(AvailabilityData).Name;

	internal readonly AvailabilityData Data;

	private readonly TelemetryContext context;

	public string Id
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

	public bool Success
	{
		get
		{
			return Data.success;
		}
		set
		{
			Data.success = value;
		}
	}

	public string RunLocation
	{
		get
		{
			return Data.runLocation;
		}
		set
		{
			Data.runLocation = value;
		}
	}

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

	public string Sequence { get; set; }

	public TelemetryContext Context => context;

	public IDictionary<string, string> Properties => Data.properties;

	public IDictionary<string, double> Metrics => Data.measurements;

	public DateTimeOffset Timestamp { get; set; }

	public AvailabilityTelemetry()
	{
		Data = new AvailabilityData();
		context = new TelemetryContext(Data.properties);
		Data.id = Convert.ToBase64String(BitConverter.GetBytes(WeakConcurrentRandom.Instance.Next()));
		Success = true;
	}

	public AvailabilityTelemetry(string name, DateTimeOffset timeStamp, TimeSpan duration, string runLocation, bool success, string message = null)
		: this()
	{
		Data.name = name;
		Data.duration = duration.ToString(string.Empty, CultureInfo.InvariantCulture);
		Data.success = success;
		Data.runLocation = runLocation;
		Data.message = message;
	}

	void ITelemetry.Sanitize()
	{
		Message = ((Data.success && string.IsNullOrEmpty(Message)) ? "Passed" : ((!Data.success && string.IsNullOrEmpty(Message)) ? "Failed" : Message));
		Name = Name.SanitizeTestName();
		Name = Utils.PopulateRequiredStringValue(Name, "TestName", typeof(AvailabilityTelemetry).FullName);
		RunLocation = RunLocation.SanitizeRunLocation();
		Message = Message.SanitizeAvailabilityMessage();
		Data.properties.SanitizeProperties();
		Data.measurements.SanitizeMeasurements();
		Context.SanitizeTelemetryContext();
	}
}
