using System;
using System.Collections.Generic;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public abstract class OperationTelemetry : ITelemetry, ISupportProperties
{
	[Obsolete("Use Timestamp")]
	public DateTimeOffset StartTime
	{
		get
		{
			return Timestamp;
		}
		set
		{
			Timestamp = value;
		}
	}

	public abstract string Id { get; set; }

	public abstract string Name { get; set; }

	public abstract bool? Success { get; set; }

	public abstract TimeSpan Duration { get; set; }

	public abstract IDictionary<string, string> Properties { get; }

	public abstract DateTimeOffset Timestamp { get; set; }

	public abstract TelemetryContext Context { get; }

	public abstract string Sequence { get; set; }

	internal long BeginTimeInTicks { get; set; }

	void ITelemetry.Sanitize()
	{
		Sanitize();
	}

	protected void Sanitize()
	{
	}
}
