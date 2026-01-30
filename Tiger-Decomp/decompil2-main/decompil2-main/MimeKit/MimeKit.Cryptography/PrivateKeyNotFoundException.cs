using System;
using System.Runtime.Serialization;
using System.Security;

namespace MimeKit.Cryptography;

[Serializable]
public class PrivateKeyNotFoundException : Exception
{
	public string KeyId { get; private set; }

	protected PrivateKeyNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		KeyId = info.GetString("KeyId");
	}

	public PrivateKeyNotFoundException(MailboxAddress mailbox, string message)
		: base(message)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		KeyId = mailbox.Address;
	}

	public PrivateKeyNotFoundException(string keyid, string message)
		: base(message)
	{
		if (keyid == null)
		{
			throw new ArgumentNullException("keyid");
		}
		KeyId = keyid;
	}

	public PrivateKeyNotFoundException(long keyid, string message)
		: base(message)
	{
		KeyId = keyid.ToString("X");
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("KeyId", KeyId);
	}
}
