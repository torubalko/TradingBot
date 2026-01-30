using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security;
using System.Threading;
using Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Platform;

internal class PlatformImplementation : IPlatform
{
	private readonly IDictionary environmentVariables = Environment.GetEnvironmentVariables();

	private IDebugOutput debugOutput;

	private string hostName;

	public string ReadConfigurationXml()
	{
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ApplicationInsights.config");
		try
		{
			if (File.Exists(text))
			{
				return File.ReadAllText(text);
			}
		}
		catch (FileNotFoundException)
		{
			CoreEventSource.Log.ApplicationInsightsConfigNotFoundWarning(text);
		}
		catch (DirectoryNotFoundException)
		{
			CoreEventSource.Log.ApplicationInsightsConfigNotFoundWarning(text);
		}
		catch (IOException)
		{
			CoreEventSource.Log.ApplicationInsightsConfigNotFoundWarning(text);
		}
		catch (UnauthorizedAccessException)
		{
			CoreEventSource.Log.ApplicationInsightsConfigNotFoundWarning(text);
		}
		catch (SecurityException)
		{
			CoreEventSource.Log.ApplicationInsightsConfigNotFoundWarning(text);
		}
		return string.Empty;
	}

	public IDebugOutput GetDebugOutput()
	{
		return debugOutput ?? (debugOutput = new TelemetryDebugWriter());
	}

	public string GetEnvironmentVariable(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentNullException();
		}
		return environmentVariables[name]?.ToString();
	}

	public string GetMachineName()
	{
		return LazyInitializer.EnsureInitialized(ref hostName, GetHostName);
	}

	private string GetHostName()
	{
		try
		{
			string domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
			string text = Dns.GetHostName();
			if (!text.EndsWith(domainName, StringComparison.OrdinalIgnoreCase))
			{
				text = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", text, domainName);
			}
			return text;
		}
		catch (Exception ex)
		{
			CoreEventSource.Log.FailedToGetMachineName(ex.Message);
		}
		return string.Empty;
	}
}
