using System.Collections.Generic;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class PortalDiagnosticsQueueSender : IDiagnosticsSender
{
	public IList<TraceEvent> EventData { get; }

	public bool IsDisabled { get; set; }

	public PortalDiagnosticsQueueSender()
	{
		EventData = new List<TraceEvent>();
		IsDisabled = false;
	}

	public void Send(TraceEvent eventData)
	{
		if (!IsDisabled)
		{
			EventData.Add(eventData);
		}
	}
}
