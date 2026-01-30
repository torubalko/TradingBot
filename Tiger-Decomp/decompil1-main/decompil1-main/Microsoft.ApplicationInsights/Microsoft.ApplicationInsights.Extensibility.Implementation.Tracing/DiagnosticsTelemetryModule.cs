using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

public sealed class DiagnosticsTelemetryModule : ITelemetryModule, IDisposable
{
	internal readonly IList<IDiagnosticsSender> Senders = new List<IDiagnosticsSender>();

	internal readonly DiagnosticsListener EventListener;

	private readonly object lockObject = new object();

	private readonly IDiagnoisticsEventThrottlingScheduler throttlingScheduler = new DiagnoisticsEventThrottlingScheduler();

	private volatile bool disposed;

	private string instrumentationKey;

	private bool isInitialized;

	public string Severity
	{
		get
		{
			return EventListener.LogLevel.ToString();
		}
		set
		{
			if (!string.IsNullOrEmpty(value) && Enum.IsDefined(typeof(EventLevel), value))
			{
				EventLevel logLevel = (EventLevel)Enum.Parse(typeof(EventLevel), value, ignoreCase: true);
				EventListener.LogLevel = logLevel;
			}
		}
	}

	public string DiagnosticsInstrumentationKey
	{
		get
		{
			return instrumentationKey;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			instrumentationKey = value;
			foreach (PortalDiagnosticsSender item in Senders.OfType<PortalDiagnosticsSender>())
			{
				item.DiagnosticsInstrumentationKey = instrumentationKey;
			}
		}
	}

	public DiagnosticsTelemetryModule()
	{
		Senders.Add(new PortalDiagnosticsQueueSender());
		Senders.Add(new F5DiagnosticsSender());
		EventListener = new DiagnosticsListener(Senders);
	}

	~DiagnosticsTelemetryModule()
	{
		Dispose(managed: false);
	}

	public void Initialize(TelemetryConfiguration configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (isInitialized)
		{
			return;
		}
		lock (lockObject)
		{
			if (isInitialized)
			{
				return;
			}
			PortalDiagnosticsQueueSender portalDiagnosticsQueueSender = Senders.OfType<PortalDiagnosticsQueueSender>().First();
			portalDiagnosticsQueueSender.IsDisabled = true;
			Senders.Remove(portalDiagnosticsQueueSender);
			PortalDiagnosticsSender portalDiagnosticsSender = new PortalDiagnosticsSender(configuration, new DiagnoisticsEventThrottlingManager<DiagnoisticsEventThrottling>(new DiagnoisticsEventThrottling(5), throttlingScheduler, 5u));
			portalDiagnosticsSender.DiagnosticsInstrumentationKey = DiagnosticsInstrumentationKey;
			Senders.Add(portalDiagnosticsSender);
			foreach (TraceEvent eventDatum in portalDiagnosticsQueueSender.EventData)
			{
				portalDiagnosticsSender.Send(eventDatum);
			}
			isInitialized = true;
		}
	}

	public void Dispose()
	{
		Dispose(managed: true);
	}

	private void Dispose(bool managed)
	{
		if (managed && !disposed)
		{
			EventListener.Dispose();
			(throttlingScheduler as IDisposable).Dispose();
			GC.SuppressFinalize(this);
		}
		disposed = true;
	}
}
