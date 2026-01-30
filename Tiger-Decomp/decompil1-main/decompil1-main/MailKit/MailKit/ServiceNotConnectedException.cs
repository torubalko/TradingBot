using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit;

[Serializable]
public class ServiceNotConnectedException : InvalidOperationException
{
	[SecuritySafeCritical]
	protected ServiceNotConnectedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public ServiceNotConnectedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public ServiceNotConnectedException(string message)
		: base(message)
	{
	}

	public ServiceNotConnectedException()
	{
	}
}
