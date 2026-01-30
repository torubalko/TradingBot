using System;
using System.Runtime.Serialization;
using System.Security;
using MimeKit;

namespace MailKit.Net.Smtp;

[Serializable]
public class SmtpCommandException : CommandException
{
	public SmtpErrorCode ErrorCode { get; private set; }

	public MailboxAddress Mailbox { get; private set; }

	public SmtpStatusCode StatusCode { get; private set; }

	[SecuritySafeCritical]
	protected SmtpCommandException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		string text = info.GetString("Mailbox");
		if (!string.IsNullOrEmpty(text) && MailboxAddress.TryParse(text, out var mailbox))
		{
			Mailbox = mailbox;
		}
		ErrorCode = (SmtpErrorCode)info.GetValue("ErrorCode", typeof(SmtpErrorCode));
		StatusCode = (SmtpStatusCode)info.GetValue("StatusCode", typeof(SmtpStatusCode));
	}

	public SmtpCommandException(SmtpErrorCode code, SmtpStatusCode status, MailboxAddress mailbox, string message, Exception innerException)
		: base(message, innerException)
	{
		StatusCode = status;
		Mailbox = mailbox;
		ErrorCode = code;
	}

	public SmtpCommandException(SmtpErrorCode code, SmtpStatusCode status, MailboxAddress mailbox, string message)
		: base(message)
	{
		StatusCode = status;
		Mailbox = mailbox;
		ErrorCode = code;
	}

	public SmtpCommandException(SmtpErrorCode code, SmtpStatusCode status, string message, Exception innerException)
		: base(message, innerException)
	{
		StatusCode = status;
		ErrorCode = code;
	}

	public SmtpCommandException(SmtpErrorCode code, SmtpStatusCode status, string message)
		: base(message)
	{
		StatusCode = status;
		ErrorCode = code;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		if (Mailbox != null)
		{
			info.AddValue("Mailbox", Mailbox.ToString());
		}
		else
		{
			info.AddValue("Mailbox", string.Empty);
		}
		info.AddValue("ErrorCode", ErrorCode, typeof(SmtpErrorCode));
		info.AddValue("StatusCode", StatusCode, typeof(SmtpStatusCode));
	}
}
