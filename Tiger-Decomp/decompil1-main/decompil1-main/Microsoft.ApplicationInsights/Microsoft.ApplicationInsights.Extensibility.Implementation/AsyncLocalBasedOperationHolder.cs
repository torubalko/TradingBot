using System;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal class AsyncLocalBasedOperationHolder<T> : IOperationHolder<T>, IDisposable
{
	public OperationContextForAsyncLocal ParentContext;

	private TelemetryClient telemetryClient;

	private T telemetry;

	private bool isDisposed;

	public T Telemetry => telemetry;

	public AsyncLocalBasedOperationHolder(TelemetryClient telemetryClient, T telemetry)
	{
		if (telemetry == null)
		{
			throw new ArgumentNullException("telemetry");
		}
		if (telemetryClient == null)
		{
			throw new ArgumentNullException("telemetryClient");
		}
		this.telemetryClient = telemetryClient;
		this.telemetry = telemetry;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposing || isDisposed)
		{
			return;
		}
		lock (this)
		{
			if (!isDisposed)
			{
				OperationTelemetry operationTelemetry = Telemetry as OperationTelemetry;
				OperationContextForAsyncLocal currentOperationContext = AsyncLocalHelpers.GetCurrentOperationContext();
				if (operationTelemetry.Id != currentOperationContext.ParentOperationId || operationTelemetry.Context.Operation.Name != currentOperationContext.RootOperationName)
				{
					CoreEventSource.Log.InvalidOperationToStopError();
					return;
				}
				operationTelemetry.Stop();
				AsyncLocalHelpers.RestoreOperationContext(ParentContext);
				telemetryClient.Track(operationTelemetry);
			}
			isDisposed = true;
		}
	}
}
