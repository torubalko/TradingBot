using System;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Platform;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal class TransmissionProcessor : ITelemetryProcessor
{
	private readonly TelemetryConfiguration configuration;

	private readonly IDebugOutput debugOutput;

	internal TransmissionProcessor(TelemetryConfiguration configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		this.configuration = configuration;
		debugOutput = PlatformSingleton.Current.GetDebugOutput();
	}

	public void Process(ITelemetry item)
	{
		TelemetryDebugWriter.WriteTelemetry(item);
		configuration.TelemetryChannel.Send(item);
	}
}
