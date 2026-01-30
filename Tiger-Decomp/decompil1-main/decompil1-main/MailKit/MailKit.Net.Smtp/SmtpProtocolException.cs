using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit.Net.Smtp;

[Serializable]
public class SmtpProtocolException : ProtocolException
{
	[SecuritySafeCritical]
	protected SmtpProtocolException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public SmtpProtocolException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public SmtpProtocolException(string message)
		: base(message)
	{
	}

	public SmtpProtocolException()
	{
	}
}
