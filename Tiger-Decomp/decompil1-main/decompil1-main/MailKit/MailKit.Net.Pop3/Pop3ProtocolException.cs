using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit.Net.Pop3;

[Serializable]
public class Pop3ProtocolException : ProtocolException
{
	[SecuritySafeCritical]
	protected Pop3ProtocolException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public Pop3ProtocolException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public Pop3ProtocolException(string message)
		: base(message)
	{
	}

	public Pop3ProtocolException()
	{
	}
}
