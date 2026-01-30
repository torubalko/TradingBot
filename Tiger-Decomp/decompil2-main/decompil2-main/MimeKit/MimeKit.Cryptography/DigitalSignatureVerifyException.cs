using System;
using System.Runtime.Serialization;
using System.Security;

namespace MimeKit.Cryptography;

[Serializable]
public class DigitalSignatureVerifyException : Exception
{
	public long? KeyId { get; private set; }

	protected DigitalSignatureVerifyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		KeyId = (long?)info.GetValue("KeyId", typeof(long?));
	}

	public DigitalSignatureVerifyException(long keyId, string message, Exception innerException)
		: base(message, innerException)
	{
		KeyId = keyId;
	}

	public DigitalSignatureVerifyException(long keyId, string message)
		: base(message)
	{
		KeyId = keyId;
	}

	public DigitalSignatureVerifyException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public DigitalSignatureVerifyException(string message)
		: base(message)
	{
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("KeyId", KeyId, typeof(long?));
	}
}
