using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace Microsoft.ApplicationInsights.Extensibility;

public class OperationCorrelationTelemetryInitializer : ITelemetryInitializer
{
	public void Initialize(ITelemetry telemetryItem)
	{
		OperationContext operation = telemetryItem.Context.Operation;
		if (!string.IsNullOrEmpty(operation.ParentId) && !string.IsNullOrEmpty(operation.Id) && !string.IsNullOrEmpty(operation.Name))
		{
			return;
		}
		OperationContextForAsyncLocal currentOperationContext = AsyncLocalHelpers.GetCurrentOperationContext();
		if (currentOperationContext != null)
		{
			if (string.IsNullOrEmpty(operation.ParentId) && !string.IsNullOrEmpty(currentOperationContext.ParentOperationId))
			{
				operation.ParentId = currentOperationContext.ParentOperationId;
			}
			if (string.IsNullOrEmpty(operation.Id) && !string.IsNullOrEmpty(currentOperationContext.RootOperationId))
			{
				operation.Id = currentOperationContext.RootOperationId;
			}
			if (string.IsNullOrEmpty(operation.Name) && !string.IsNullOrEmpty(currentOperationContext.RootOperationName))
			{
				operation.Name = currentOperationContext.RootOperationName;
			}
		}
	}
}
