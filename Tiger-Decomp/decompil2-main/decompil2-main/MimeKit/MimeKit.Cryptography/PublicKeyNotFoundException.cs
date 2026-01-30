using System;
using System.Runtime.Serialization;
using System.Security;

namespace MimeKit.Cryptography;

[Serializable]
public class PublicKeyNotFoundException : Exception
{
	public MailboxAddress Mailbox { get; private set; }

	protected PublicKeyNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		string text = info.GetString("Mailbox");
		if (MailboxAddress.TryParse(text, out var mailbox))
		{
			Mailbox = mailbox;
		}
	}

	public PublicKeyNotFoundException(MailboxAddress mailbox, string message)
		: base(message)
	{
		Mailbox = mailbox;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Mailbox", Mailbox.ToString(encode: true));
	}
}
