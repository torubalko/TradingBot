using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit;

[Serializable]
public abstract class ProtocolException : Exception
{
	[SecuritySafeCritical]
	protected ProtocolException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	protected ProtocolException(string message, Exception innerException)
		: base(message, innerException)
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#ProtocolLog";
	}

	protected ProtocolException(string message)
		: base(message)
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#ProtocolLog";
	}

	protected ProtocolException()
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#ProtocolLog";
	}
}
