using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Tracing;

[EventSource(Name = "Microsoft-ApplicationInsights-Core")]
internal sealed class CoreEventSource : EventSource
{
	public sealed class Keywords
	{
		public const EventKeywords UserActionable = (EventKeywords)1L;

		public const EventKeywords Diagnostics = (EventKeywords)2L;

		public const EventKeywords VerboseFailure = (EventKeywords)4L;

		public const EventKeywords ErrorFailure = (EventKeywords)8L;
	}

	public static readonly CoreEventSource Log = new CoreEventSource();

	private readonly ApplicationNameProvider nameProvider = new ApplicationNameProvider();

	public bool IsVerboseEnabled
	{
		[NonEvent]
		get
		{
			return Log.IsEnabled(EventLevel.Verbose, EventKeywords.All);
		}
	}

	[Event(1, Message = "Operation object is null.", Level = EventLevel.Warning)]
	public void OperationIsNullWarning(string appDomainName = "Incorrect")
	{
		WriteEvent(1, nameProvider.Name);
	}

	[Event(2, Message = "Operation to stop does not match the current operation.", Level = EventLevel.Error)]
	public void InvalidOperationToStopError(string appDomainName = "Incorrect")
	{
		WriteEvent(2, nameProvider.Name);
	}

	[Event(3, Keywords = (EventKeywords)4L, Message = "[msg=Log verbose];[msg={0}]", Level = EventLevel.Verbose)]
	public void LogVerbose(string msg, string appDomainName = "Incorrect")
	{
		WriteEvent(3, msg ?? string.Empty, nameProvider.Name);
	}

	[Event(4, Keywords = (EventKeywords)3L, Message = "Diagnostics event throttling has been started for the event {0}", Level = EventLevel.Informational)]
	public void DiagnosticsEventThrottlingHasBeenStartedForTheEvent(string eventId, string appDomainName = "Incorrect")
	{
		WriteEvent(4, eventId ?? "NULL", nameProvider.Name);
	}

	[Event(5, Keywords = (EventKeywords)3L, Message = "Diagnostics event throttling has been reset for the event {0}, event was fired {1} times during last interval", Level = EventLevel.Informational)]
	public void DiagnosticsEventThrottlingHasBeenResetForTheEvent(int eventId, int executionCount, string appDomainName = "Incorrect")
	{
		WriteEvent(5, eventId, executionCount, nameProvider.Name);
	}

	[Event(6, Keywords = (EventKeywords)2L, Message = "Scheduler timer dispose failure: {0}", Level = EventLevel.Warning)]
	public void DiagnoisticsEventThrottlingSchedulerDisposeTimerFailure(string exception, string appDomainName = "Incorrect")
	{
		WriteEvent(6, exception ?? string.Empty, nameProvider.Name);
	}

	[Event(7, Keywords = (EventKeywords)2L, Message = "A scheduler timer was created for the interval: {0}", Level = EventLevel.Verbose)]
	public void DiagnoisticsEventThrottlingSchedulerTimerWasCreated(string intervalInMilliseconds, string appDomainName = "Incorrect")
	{
		WriteEvent(7, intervalInMilliseconds ?? "NULL", nameProvider.Name);
	}

	[Event(8, Keywords = (EventKeywords)2L, Message = "A scheduler timer was removed", Level = EventLevel.Verbose)]
	public void DiagnoisticsEventThrottlingSchedulerTimerWasRemoved(string appDomainName = "Incorrect")
	{
		WriteEvent(8, nameProvider.Name);
	}

	[Event(9, Message = "No Telemetry Configuration provided. Using the default TelemetryConfiguration.Active.", Level = EventLevel.Warning)]
	public void TelemetryClientConstructorWithNoTelemetryConfiguration(string appDomainName = "Incorrect")
	{
		WriteEvent(9, nameProvider.Name);
	}

	[Event(10, Message = "Value for property '{0}' of {1} was not found. Populating it by default.", Level = EventLevel.Verbose)]
	public void PopulateRequiredStringWithValue(string parameterName, string telemetryType, string appDomainName = "Incorrect")
	{
		WriteEvent(10, parameterName ?? string.Empty, telemetryType ?? string.Empty, nameProvider.Name);
	}

	[Event(11, Message = "Invalid duration for Telemetry. Setting it to '00:00:00'.", Level = EventLevel.Warning)]
	public void TelemetryIncorrectDuration(string appDomainName = "Incorrect")
	{
		WriteEvent(11, nameProvider.Name);
	}

	[Event(12, Message = "Telemetry tracking was disabled. Message is dropped.", Level = EventLevel.Verbose)]
	public void TrackingWasDisabled(string appDomainName = "Incorrect")
	{
		WriteEvent(12, nameProvider.Name);
	}

	[Event(13, Message = "Telemetry tracking was enabled. Messages are being logged.", Level = EventLevel.Verbose)]
	public void TrackingWasEnabled(string appDomainName = "Incorrect")
	{
		WriteEvent(13, nameProvider.Name);
	}

	[Event(14, Keywords = (EventKeywords)8L, Message = "[msg=Log Error];[msg={0}]", Level = EventLevel.Error)]
	public void LogError(string msg, string appDomainName = "Incorrect")
	{
		WriteEvent(14, msg ?? string.Empty, nameProvider.Name);
	}

	[Event(15, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. Type '{0}' was not found. Type loading was skipped. Monitoring will continue.", Level = EventLevel.Error)]
	public void TypeWasNotFoundConfigurationError(string type, string appDomainName = "Incorrect")
	{
		WriteEvent(15, type ?? string.Empty, nameProvider.Name);
	}

	[Event(16, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. Type '{0}' does not implement '{1}'. Type loading was skipped. Monitoring will continue.", Level = EventLevel.Error)]
	public void IncorrectTypeConfigurationError(string type, string expectedType, string appDomainName = "Incorrect")
	{
		WriteEvent(16, type ?? string.Empty, expectedType ?? string.Empty, nameProvider.Name);
	}

	[Event(17, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. Type '{0}' does not have property '{1}'. Property initialization was skipped. Monitoring will continue.", Level = EventLevel.Error)]
	public void IncorrectPropertyConfigurationError(string type, string property, string appDomainName = "Incorrect")
	{
		WriteEvent(17, type ?? string.Empty, property ?? string.Empty, nameProvider.Name);
	}

	[Event(18, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. Element '{0}' element does not have a Type attribute, does not specify a value and is not a valid collection type. Type initialization was skipped. Monitoring will continue.", Level = EventLevel.Error)]
	public void IncorrectInstanceAtributesConfigurationError(string definition, string appDomainName = "Incorrect")
	{
		WriteEvent(18, definition ?? string.Empty, nameProvider.Name);
	}

	[Event(19, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. '{0}' element has unexpected contents: '{1}': '{2}'. Type initialization was skipped. Monitoring will continue.", Level = EventLevel.Error)]
	public void LoadInstanceFromValueConfigurationError(string element, string contents, string error, string appDomainName = "Incorrect")
	{
		WriteEvent(19, element ?? string.Empty, contents ?? string.Empty, error ?? string.Empty, nameProvider.Name);
	}

	[Event(20, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. Exception: '{0}'. Monitoring will continue if you set InstrumentationKey programmatically.", Level = EventLevel.Error)]
	public void ConfigurationFileCouldNotBeParsedError(string error, string appDomainName = "Incorrect")
	{
		WriteEvent(20, error ?? string.Empty, nameProvider.Name);
	}

	[Event(21, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. Type '{0}' will not be create. Error: '{1}'. Monitoring will continue if you set InstrumentationKey programmatically.", Level = EventLevel.Error)]
	public void MissingMethodExceptionConfigurationError(string type, string error, string appDomainName = "Incorrect")
	{
		WriteEvent(21, type ?? string.Empty, error ?? string.Empty, nameProvider.Name);
	}

	[Event(22, Keywords = (EventKeywords)1L, Message = "ApplicationInsights configuration file loading failed. Type '{0}' will not be initialized. Error: '{1}'. Monitoring will continue if you set InstrumentationKey programmatically.", Level = EventLevel.Error)]
	public void ComponentInitializationConfigurationError(string type, string error, string appDomainName = "Incorrect")
	{
		WriteEvent(22, type ?? string.Empty, error ?? string.Empty, nameProvider.Name);
	}

	[Event(23, Message = "ApplicationInsights configuration file '{0}' was not found.", Level = EventLevel.Warning)]
	public void ApplicationInsightsConfigNotFoundWarning(string file, string appDomainName = "Incorrect")
	{
		WriteEvent(23, file ?? string.Empty, nameProvider.Name);
	}

	[Event(24, Message = "Failed to send: {0}.", Level = EventLevel.Warning)]
	public void FailedToSend(string msg, string appDomainName = "Incorrect")
	{
		WriteEvent(24, msg ?? string.Empty, nameProvider.Name);
	}

	[Event(25, Message = "Exception happened during getting the machine name: '{0}'.", Level = EventLevel.Error)]
	public void FailedToGetMachineName(string error, string appDomainName = "Incorrect")
	{
		WriteEvent(25, error ?? string.Empty, nameProvider.Name);
	}
}
