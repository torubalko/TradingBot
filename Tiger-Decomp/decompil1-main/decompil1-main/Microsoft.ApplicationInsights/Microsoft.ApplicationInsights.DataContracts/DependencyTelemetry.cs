using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class DependencyTelemetry : OperationTelemetry, ITelemetry, ISupportProperties, ISupportSampling
{
	internal const string TelemetryName = "RemoteDependency";

	internal readonly string BaseType = typeof(RemoteDependencyData).Name;

	internal readonly RemoteDependencyData InternalData;

	private readonly TelemetryContext context;

	private double? samplingPercentage;

	public override DateTimeOffset Timestamp { get; set; }

	public override string Sequence { get; set; }

	public override TelemetryContext Context => context;

	public override string Id
	{
		get
		{
			return InternalData.id;
		}
		set
		{
			InternalData.id = value;
		}
	}

	public string ResultCode
	{
		get
		{
			return InternalData.resultCode;
		}
		set
		{
			InternalData.resultCode = value;
		}
	}

	public override string Name
	{
		get
		{
			return InternalData.name;
		}
		set
		{
			InternalData.name = value;
		}
	}

	[Obsolete("Renamed to Data")]
	public string CommandName
	{
		get
		{
			return InternalData.data;
		}
		set
		{
			InternalData.data = value;
		}
	}

	public string Data
	{
		get
		{
			return InternalData.data;
		}
		set
		{
			InternalData.data = value;
		}
	}

	public string Target
	{
		get
		{
			return InternalData.target;
		}
		set
		{
			InternalData.target = value;
		}
	}

	[Obsolete("Renamed to Type")]
	public string DependencyTypeName
	{
		get
		{
			return Type;
		}
		set
		{
			Type = value;
		}
	}

	public string Type
	{
		get
		{
			return InternalData.type;
		}
		set
		{
			InternalData.type = value;
		}
	}

	public override TimeSpan Duration
	{
		get
		{
			return Utils.ValidateDuration(InternalData.duration);
		}
		set
		{
			InternalData.duration = value.ToString();
		}
	}

	public override bool? Success
	{
		get
		{
			return InternalData.success;
		}
		set
		{
			InternalData.success = value;
		}
	}

	public override IDictionary<string, string> Properties => InternalData.properties;

	public IDictionary<string, double> Metrics => InternalData.measurements;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use Type")]
	public string DependencyKind
	{
		get
		{
			return DependencyTypeName;
		}
		set
		{
			DependencyTypeName = value;
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

	public DependencyTelemetry()
	{
		InternalData = new RemoteDependencyData();
		context = new TelemetryContext(InternalData.properties);
		Id = Convert.ToBase64String(BitConverter.GetBytes(WeakConcurrentRandom.Instance.Next()));
	}

	[Obsolete("Use other constructors which allows to define dependency call with all the properties.")]
	public DependencyTelemetry(string dependencyName, string data, DateTimeOffset startTime, TimeSpan duration, bool success)
		: this()
	{
		Name = dependencyName;
		Data = data;
		Duration = duration;
		Success = success;
		Timestamp = startTime;
	}

	public DependencyTelemetry(string dependencyTypeName, string target, string dependencyName, string data)
		: this()
	{
		Type = dependencyTypeName;
		Target = target;
		Name = dependencyName;
		Data = data;
	}

	public DependencyTelemetry(string dependencyTypeName, string target, string dependencyName, string data, DateTimeOffset startTime, TimeSpan duration, string resultCode, bool success)
		: this()
	{
		Type = dependencyTypeName;
		Target = target;
		Name = dependencyName;
		Data = data;
		Timestamp = startTime;
		Duration = duration;
		ResultCode = resultCode;
		Success = success;
	}

	void ITelemetry.Sanitize()
	{
		Name = Name.SanitizeName();
		Name = Utils.PopulateRequiredStringValue(Name, "name", typeof(DependencyTelemetry).FullName);
		Id.SanitizeName();
		ResultCode = ResultCode.SanitizeResultCode();
		Type = Type.SanitizeDependencyType();
		Data = Data.SanitizeData();
		Properties.SanitizeProperties();
		Context.SanitizeTelemetryContext();
	}
}
