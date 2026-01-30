using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class DiagnosticsEventListener : EventListener
{
	private const long AllKeyword = -1L;

	private readonly EventLevel logLevel;

	private readonly DiagnosticsListener listener;

	public DiagnosticsEventListener(DiagnosticsListener listener, EventLevel logLevel)
	{
		this.listener = listener;
		this.logLevel = logLevel;
	}

	protected override void OnEventWritten(EventWrittenEventArgs eventSourceEvent)
	{
		EventMetaData metaData = new EventMetaData
		{
			Keywords = (long)eventSourceEvent.Keywords,
			MessageFormat = eventSourceEvent.Message,
			EventId = eventSourceEvent.EventId,
			Level = eventSourceEvent.Level
		};
		TraceEvent eventData = new TraceEvent
		{
			MetaData = metaData,
			Payload = ((eventSourceEvent.Payload != null) ? eventSourceEvent.Payload.ToArray() : null)
		};
		listener.WriteEvent(eventData);
	}

	protected override void OnEventSourceCreated(EventSource eventSource)
	{
		if (eventSource.Name.StartsWith("Microsoft-ApplicationInsights-", StringComparison.Ordinal))
		{
			EnableEvents(eventSource, logLevel, EventKeywords.All);
		}
		base.OnEventSourceCreated(eventSource);
	}
}
