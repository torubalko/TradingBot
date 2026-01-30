using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

public sealed class TelemetryProcessorChainBuilder
{
	private readonly List<Func<ITelemetryProcessor, ITelemetryProcessor>> factories;

	private readonly TelemetryConfiguration configuration;

	public TelemetryProcessorChainBuilder(TelemetryConfiguration configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		this.configuration = configuration;
		factories = new List<Func<ITelemetryProcessor, ITelemetryProcessor>>();
	}

	public TelemetryProcessorChainBuilder Use(Func<ITelemetryProcessor, ITelemetryProcessor> telemetryProcessorFactory)
	{
		factories.Add(telemetryProcessorFactory);
		return this;
	}

	public void Build()
	{
		List<ITelemetryProcessor> list = new List<ITelemetryProcessor>();
		ITelemetryProcessor telemetryProcessor = new TransmissionProcessor(configuration);
		list.Add(telemetryProcessor);
		foreach (Func<ITelemetryProcessor, ITelemetryProcessor> item in factories.AsEnumerable().Reverse())
		{
			ITelemetryProcessor telemetryProcessor2 = telemetryProcessor;
			telemetryProcessor = item(telemetryProcessor);
			if (telemetryProcessor == null)
			{
				telemetryProcessor = telemetryProcessor2;
			}
			else
			{
				list.Add(telemetryProcessor);
			}
		}
		TelemetryProcessorChain telemetryProcessorChain = new TelemetryProcessorChain(list.AsEnumerable().Reverse());
		configuration.TelemetryProcessorChain = telemetryProcessorChain;
	}
}
