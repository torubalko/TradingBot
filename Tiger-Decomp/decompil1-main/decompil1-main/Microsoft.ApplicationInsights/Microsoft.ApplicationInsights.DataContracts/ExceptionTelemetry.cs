using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.Extensibility.Implementation.External;

namespace Microsoft.ApplicationInsights.DataContracts;

public sealed class ExceptionTelemetry : ITelemetry, ISupportProperties, ISupportSampling
{
	internal const string TelemetryName = "Exception";

	internal readonly string BaseType = typeof(ExceptionData).Name;

	internal readonly ExceptionData Data;

	private readonly TelemetryContext context;

	private Exception exception;

	private string message;

	private double? samplingPercentage;

	public DateTimeOffset Timestamp { get; set; }

	public string Sequence { get; set; }

	public TelemetryContext Context => context;

	[Obsolete("Use custom properties to report exception handling layer")]
	public ExceptionHandledAt HandledAt
	{
		get
		{
			ExceptionHandledAt result = ExceptionHandledAt.Unhandled;
			if (Properties.ContainsKey("handledAt"))
			{
				Enum.TryParse<ExceptionHandledAt>(Properties["handledAt"], out result);
			}
			return result;
		}
		set
		{
			Properties["handledAt"] = value.ToString();
		}
	}

	public Exception Exception
	{
		get
		{
			return exception;
		}
		set
		{
			exception = value;
			UpdateExceptions(value);
		}
	}

	public string Message
	{
		get
		{
			return message;
		}
		set
		{
			message = value;
			if (Data.exceptions != null && Data.exceptions.Count > 0)
			{
				Data.exceptions[0].message = value;
			}
			else
			{
				UpdateExceptions(Exception);
			}
		}
	}

	public IDictionary<string, double> Metrics => Data.measurements;

	public IDictionary<string, string> Properties => Data.properties;

	public SeverityLevel? SeverityLevel
	{
		get
		{
			return Data.severityLevel.TranslateSeverityLevel();
		}
		set
		{
			Data.severityLevel = value.TranslateSeverityLevel();
		}
	}

	double? ISupportSampling.SamplingPercentage
	{
		get
		{
			return samplingPercentage;
		}
		set
		{
			samplingPercentage = value;
		}
	}

	internal IList<ExceptionDetails> Exceptions => Data.exceptions;

	public ExceptionTelemetry()
	{
		Data = new ExceptionData();
		context = new TelemetryContext(Data.properties);
	}

	public ExceptionTelemetry(Exception exception)
		: this()
	{
		if (exception == null)
		{
			exception = new Exception(Utils.PopulateRequiredStringValue(null, "message", typeof(ExceptionTelemetry).FullName));
		}
		Exception = exception;
	}

	void ITelemetry.Sanitize()
	{
		Properties.SanitizeProperties();
		Metrics.SanitizeMeasurements();
		Context.SanitizeTelemetryContext();
	}

	private void ConvertExceptionTree(Exception exception, ExceptionDetails parentExceptionDetails, List<ExceptionDetails> exceptions)
	{
		if (exception == null)
		{
			exception = new Exception(Utils.PopulateRequiredStringValue(null, "message", typeof(ExceptionTelemetry).FullName));
		}
		ExceptionDetails exceptionDetails = ExceptionConverter.ConvertToExceptionDetails(exception, parentExceptionDetails);
		if (parentExceptionDetails == null && !string.IsNullOrWhiteSpace(Message))
		{
			exceptionDetails.message = Message;
		}
		exceptions.Add(exceptionDetails);
		if (exception is AggregateException ex)
		{
			{
				foreach (Exception innerException in ex.InnerExceptions)
				{
					ConvertExceptionTree(innerException, exceptionDetails, exceptions);
				}
				return;
			}
		}
		if (exception.InnerException != null)
		{
			ConvertExceptionTree(exception.InnerException, exceptionDetails, exceptions);
		}
	}

	private void UpdateExceptions(Exception exception)
	{
		List<ExceptionDetails> list = new List<ExceptionDetails>();
		ConvertExceptionTree(exception, null, list);
		if (list.Count > 10)
		{
			InnerExceptionCountExceededException ex = new InnerExceptionCountExceededException(string.Format(CultureInfo.InvariantCulture, "The number of inner exceptions was {0} which is larger than {1}, the maximum number allowed during transmission. All but the first {1} have been dropped.", list.Count, 10));
			list.RemoveRange(10, list.Count - 10);
			list.Add(ExceptionConverter.ConvertToExceptionDetails(ex, list[0]));
		}
		Data.exceptions = list;
	}
}
