using System;

namespace Microsoft.ApplicationInsights.Extensibility;

public interface IOperationHolder<T> : IDisposable
{
	T Telemetry { get; }
}
