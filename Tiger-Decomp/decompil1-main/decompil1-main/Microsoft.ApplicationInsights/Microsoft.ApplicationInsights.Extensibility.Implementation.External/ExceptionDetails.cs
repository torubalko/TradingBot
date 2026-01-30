using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External;

[GeneratedCode("gbc", "0.4.1.0")]
[EventData]
internal class ExceptionDetails
{
	public int id { get; set; }

	public int outerId { get; set; }

	public string typeName { get; set; }

	public string message { get; set; }

	public bool hasFullStack { get; set; }

	public string stack { get; set; }

	public IList<StackFrame> parsedStack { get; set; }

	public ExceptionDetails()
		: this("AI.ExceptionDetails", "ExceptionDetails")
	{
	}

	protected ExceptionDetails(string fullName, string name)
	{
		typeName = "";
		message = "";
		hasFullStack = true;
		stack = "";
		parsedStack = new List<StackFrame>();
	}

	internal static ExceptionDetails CreateWithoutStackInfo(Exception exception, ExceptionDetails parentExceptionDetails)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		ExceptionDetails exceptionDetails = new ExceptionDetails
		{
			id = exception.GetHashCode(),
			typeName = exception.GetType().FullName,
			message = exception.Message
		};
		if (parentExceptionDetails != null)
		{
			exceptionDetails.outerId = parentExceptionDetails.id;
		}
		return exceptionDetails;
	}
}
