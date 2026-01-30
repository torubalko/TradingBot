using System;
using System.Runtime.Serialization;

namespace Microsoft.ApplicationInsights.DataContracts;

[Serializable]
internal class InnerExceptionCountExceededException : Exception
{
	public InnerExceptionCountExceededException()
	{
	}

	public InnerExceptionCountExceededException(string message)
		: base(message)
	{
	}

	public InnerExceptionCountExceededException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InnerExceptionCountExceededException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
