namespace Microsoft.ApplicationInsights.Extensibility;

internal interface IDebugOutput
{
	void WriteLine(string message);

	bool IsLogging();

	bool IsAttached();
}
