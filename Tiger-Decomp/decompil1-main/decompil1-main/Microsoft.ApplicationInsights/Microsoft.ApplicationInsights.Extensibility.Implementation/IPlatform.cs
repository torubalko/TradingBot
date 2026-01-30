namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal interface IPlatform
{
	string ReadConfigurationXml();

	IDebugOutput GetDebugOutput();

	string GetEnvironmentVariable(string name);

	string GetMachineName();
}
