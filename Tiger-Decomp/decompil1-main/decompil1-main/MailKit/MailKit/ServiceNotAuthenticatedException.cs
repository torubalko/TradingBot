using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit;

[Serializable]
public class ServiceNotAuthenticatedException : InvalidOperationException
{
	[SecuritySafeCritical]
	protected ServiceNotAuthenticatedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public ServiceNotAuthenticatedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public ServiceNotAuthenticatedException(string message)
		: base(message)
	{
	}

	public ServiceNotAuthenticatedException()
	{
	}
}
