using System;
using System.ComponentModel;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class TelemetryClientExtensions
{
	public static IOperationHolder<T> StartOperation<T>(this TelemetryClient telemetryClient, string operationName) where T : OperationTelemetry, new()
	{
		if (telemetryClient == null)
		{
			throw new ArgumentNullException("Telemetry client cannot be null.");
		}
		AsyncLocalBasedOperationHolder<T> asyncLocalBasedOperationHolder = new AsyncLocalBasedOperationHolder<T>(telemetryClient, new T());
		asyncLocalBasedOperationHolder.Telemetry.Start();
		asyncLocalBasedOperationHolder.ParentContext = AsyncLocalHelpers.GetCurrentOperationContext();
		if (string.IsNullOrEmpty(asyncLocalBasedOperationHolder.Telemetry.Name) && !string.IsNullOrEmpty(operationName))
		{
			asyncLocalBasedOperationHolder.Telemetry.Name = operationName;
		}
		telemetryClient.Initialize(asyncLocalBasedOperationHolder.Telemetry);
		if (string.IsNullOrEmpty(asyncLocalBasedOperationHolder.Telemetry.Id))
		{
			asyncLocalBasedOperationHolder.Telemetry.GenerateOperationId();
		}
		if (string.IsNullOrEmpty(asyncLocalBasedOperationHolder.Telemetry.Context.Operation.Id))
		{
			asyncLocalBasedOperationHolder.Telemetry.Context.Operation.Id = asyncLocalBasedOperationHolder.Telemetry.Id;
		}
		if (string.IsNullOrEmpty(asyncLocalBasedOperationHolder.Telemetry.Context.Operation.Name))
		{
			asyncLocalBasedOperationHolder.Telemetry.Context.Operation.Name = asyncLocalBasedOperationHolder.Telemetry.Name;
		}
		AsyncLocalHelpers.SaveOperationContext(new OperationContextForAsyncLocal
		{
			ParentOperationId = asyncLocalBasedOperationHolder.Telemetry.Id,
			RootOperationId = asyncLocalBasedOperationHolder.Telemetry.Context.Operation.Id,
			RootOperationName = asyncLocalBasedOperationHolder.Telemetry.Context.Operation.Name
		});
		return asyncLocalBasedOperationHolder;
	}

	public static void StopOperation<T>(this TelemetryClient telemetryClient, IOperationHolder<T> operation)
	{
		if (telemetryClient == null)
		{
			throw new ArgumentNullException("telemetryClient");
		}
		if (operation == null)
		{
			CoreEventSource.Log.OperationIsNullWarning();
		}
		else
		{
			operation.Dispose();
		}
	}
}
