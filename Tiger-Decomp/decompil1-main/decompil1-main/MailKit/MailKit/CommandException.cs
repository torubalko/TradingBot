using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit;

[Serializable]
public abstract class CommandException : Exception
{
	[SecuritySafeCritical]
	protected CommandException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	protected CommandException(string message, Exception innerException)
		: base(message, innerException)
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#ProtocolLog";
	}

	protected CommandException(string message)
		: base(message)
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#ProtocolLog";
	}

	protected CommandException()
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#ProtocolLog";
	}
}
