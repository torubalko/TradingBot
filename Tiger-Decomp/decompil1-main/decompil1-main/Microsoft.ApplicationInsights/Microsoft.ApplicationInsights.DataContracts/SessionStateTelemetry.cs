using System;
using Microsoft.ApplicationInsights.Channel;

namespace Microsoft.ApplicationInsights.DataContracts;

[Obsolete("Session state events are no longer used. This telemetry item will be sent as EventTelemetry.")]
public sealed class SessionStateTelemetry : ITelemetry
{
	internal readonly EventTelemetry Data;

	private readonly string startEventName = "Session started";

	private readonly string endEventName = "Session ended";

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

	public TelemetryContext Context => Data.Context;

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

	public SessionState State
	{
		get
		{
			if (Data.Name == startEventName)
			{
				return SessionState.Start;
			}
			return SessionState.End;
		}
		set
		{
			if (value == SessionState.Start)
			{
				Data.Name = startEventName;
			}
			else
			{
				Data.Name = endEventName;
			}
		}
	}

	public SessionStateTelemetry()
		: this(SessionState.Start)
	{
	}

	public SessionStateTelemetry(SessionState state)
	{
		Data = new EventTelemetry();
		State = state;
	}

	void ITelemetry.Sanitize()
	{
		((ITelemetry)Data).Sanitize();
	}
}
