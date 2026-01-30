using System.Globalization;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Platform;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

internal class F5DiagnosticsSender : IDiagnosticsSender
{
	protected IDebugOutput debugOutput;

	public F5DiagnosticsSender()
	{
		debugOutput = PlatformSingleton.Current.GetDebugOutput();
	}

	public void Send(TraceEvent eventData)
	{
		if (debugOutput.IsLogging() && eventData.MetaData != null && !string.IsNullOrEmpty(eventData.MetaData.MessageFormat))
		{
			string message = ((eventData.Payload != null && eventData.Payload.Length != 0) ? string.Format(CultureInfo.InvariantCulture, eventData.MetaData.MessageFormat, eventData.Payload) : eventData.MetaData.MessageFormat);
			debugOutput.WriteLine(message);
		}
	}
}
