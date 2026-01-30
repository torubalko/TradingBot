using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit.Net.Imap;

[Serializable]
public class ImapProtocolException : ProtocolException
{
	internal bool UnexpectedToken { get; set; }

	[SecuritySafeCritical]
	protected ImapProtocolException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public ImapProtocolException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public ImapProtocolException(string message)
		: base(message)
	{
	}

	public ImapProtocolException()
	{
	}
}
