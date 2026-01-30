using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit.Net.Proxy;

[Serializable]
public class ProxyProtocolException : ProtocolException
{
	[SecuritySafeCritical]
	protected ProxyProtocolException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public ProxyProtocolException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public ProxyProtocolException(string message)
		: base(message)
	{
	}

	public ProxyProtocolException()
	{
	}
}
