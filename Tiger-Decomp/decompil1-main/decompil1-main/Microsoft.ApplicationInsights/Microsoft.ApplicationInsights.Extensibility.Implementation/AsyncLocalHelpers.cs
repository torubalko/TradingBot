using System.Threading;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal static class AsyncLocalHelpers
{
	internal static AsyncLocal<OperationContextForAsyncLocal> AsyncLocalContext = new AsyncLocal<OperationContextForAsyncLocal>();

	internal static void SaveOperationContext(OperationContextForAsyncLocal operationContext)
	{
		AsyncLocalContext.Value = operationContext;
	}

	internal static OperationContextForAsyncLocal GetCurrentOperationContext()
	{
		return AsyncLocalContext.Value;
	}

	internal static void RestoreOperationContext(OperationContextForAsyncLocal parentContext)
	{
		AsyncLocalContext.Value = null;
		if (parentContext != null)
		{
			AsyncLocalContext.Value = parentContext;
		}
	}
}
