using System;
using System.Diagnostics;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Platform;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public class TelemetryDebugWriter : IDebugOutput
{
	public static bool IsTracingDisabled { get; set; }

	public static void WriteTelemetry(ITelemetry telemetry, string filteredBy = null)
	{
		IDebugOutput debugOutput = PlatformSingleton.Current.GetDebugOutput();
		if (debugOutput.IsAttached() && debugOutput.IsLogging())
		{
			string text = "Application Insights Telemetry: ";
			if (string.IsNullOrEmpty(telemetry.Context.InstrumentationKey))
			{
				text = "Application Insights Telemetry (unconfigured): ";
			}
			if (!string.IsNullOrEmpty(filteredBy))
			{
				text = "Application Insights Telemetry (filtered by " + filteredBy + "): ";
			}
			string text2 = JsonSerializer.SerializeAsString(telemetry);
			debugOutput.WriteLine(text + text2);
		}
	}

	void IDebugOutput.WriteLine(string message)
	{
		Debugger.Log(0, "category", message + Environment.NewLine);
	}

	bool IDebugOutput.IsLogging()
	{
		if (IsTracingDisabled)
		{
			return false;
		}
		return Debugger.IsLogging();
	}

	bool IDebugOutput.IsAttached()
	{
		return Debugger.IsAttached;
	}
}
