using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit;

[Serializable]
public class MessageNotFoundException : Exception
{
	[SecuritySafeCritical]
	protected MessageNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public MessageNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public MessageNotFoundException(string message)
		: base(message)
	{
	}
}
