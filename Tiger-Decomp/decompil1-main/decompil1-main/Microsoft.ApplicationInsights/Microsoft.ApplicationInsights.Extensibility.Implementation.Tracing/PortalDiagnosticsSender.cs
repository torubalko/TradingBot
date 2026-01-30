using System;
using System.Globalization;
using System.Linq;
using Microsoft.ApplicationInsights.DataContracts;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class PortalDiagnosticsSender : IDiagnosticsSender
{
	private const string AiPrefix = "AI: ";

	private const string AiNonUserActionable = "AI (Internal): ";

	private const string SdkTelemetrySyntheticSourceName = "SDKTelemetry";

	private readonly TelemetryClient telemetryClient;

	private readonly IDiagnoisticsEventThrottlingManager throttlingManager;

	public string DiagnosticsInstrumentationKey { get; set; }

	public PortalDiagnosticsSender(TelemetryConfiguration configuration, IDiagnoisticsEventThrottlingManager throttlingManager)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (throttlingManager == null)
		{
			throw new ArgumentNullException("throttlingManager");
		}
		telemetryClient = new TelemetryClient(configuration);
		this.throttlingManager = throttlingManager;
	}

	public void Send(TraceEvent eventData)
	{
		try
		{
			if (eventData.MetaData == null || string.IsNullOrEmpty(eventData.MetaData.MessageFormat) || ThreadResourceLock.IsResourceLocked)
			{
				return;
			}
			using (new ThreadResourceLock())
			{
				try
				{
					if (!throttlingManager.ThrottleEvent(eventData.MetaData.EventId, eventData.MetaData.Keywords))
					{
						InternalSendTraceTelemetry(eventData);
					}
				}
				catch (Exception exception)
				{
					CoreEventSource.Log.LogError("Failed to send traces to the portal: " + exception.ToInvariantString());
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void InternalSendTraceTelemetry(TraceEvent eventData)
	{
		if (telemetryClient.TelemetryConfiguration.TelemetryChannel != null)
		{
			TraceTelemetry traceTelemetry = new TraceTelemetry();
			string text = ((eventData.Payload != null) ? string.Format(CultureInfo.CurrentCulture, eventData.MetaData.MessageFormat, eventData.Payload.ToArray()) : eventData.MetaData.MessageFormat);
			text = (((eventData.MetaData.Keywords & 1) != 1) ? ("AI (Internal): " + text) : ("AI: " + text));
			traceTelemetry.Message = text;
			if (!string.IsNullOrEmpty(DiagnosticsInstrumentationKey))
			{
				traceTelemetry.Context.InstrumentationKey = DiagnosticsInstrumentationKey;
			}
			traceTelemetry.Context.Operation.SyntheticSource = "SDKTelemetry";
			telemetryClient.TrackTrace(traceTelemetry);
		}
	}
}
