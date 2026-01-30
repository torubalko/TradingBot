using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class DiagnosticsListener : IDisposable
{
	private readonly IList<IDiagnosticsSender> diagnosticsSenders = new List<IDiagnosticsSender>();

	private EventLevel logLevel = EventLevel.Error;

	private DiagnosticsEventListener eventListener;

	public EventLevel LogLevel
	{
		get
		{
			return logLevel;
		}
		set
		{
			if (LogLevel != value)
			{
				DiagnosticsEventListener diagnosticsEventListener = eventListener;
				eventListener = new DiagnosticsEventListener(this, value);
				diagnosticsEventListener.Dispose();
			}
			logLevel = value;
		}
	}

	public DiagnosticsListener(IList<IDiagnosticsSender> senders)
	{
		if (senders == null || senders.Count < 1)
		{
			throw new ArgumentNullException("senders");
		}
		diagnosticsSenders = senders;
		eventListener = new DiagnosticsEventListener(this, LogLevel);
	}

	public void WriteEvent(TraceEvent eventData)
	{
		if (eventData.MetaData == null || eventData.MetaData.MessageFormat == null || eventData.MetaData.Level > LogLevel)
		{
			return;
		}
		foreach (IDiagnosticsSender diagnosticsSender in diagnosticsSenders)
		{
			diagnosticsSender.Send(eventData);
		}
	}

	public void Dispose()
	{
		eventListener.Dispose();
	}
}
