using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit.Security;

[Serializable]
public class SaslException : AuthenticationException
{
	public SaslErrorCode ErrorCode { get; private set; }

	public string Mechanism { get; private set; }

	protected SaslException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		ErrorCode = (SaslErrorCode)info.GetInt32("ErrorCode");
		Mechanism = info.GetString("Mechanism");
	}

	public SaslException(string mechanism, SaslErrorCode code, string message)
		: base(message)
	{
		if (mechanism == null)
		{
			throw new ArgumentNullException("mechanism");
		}
		Mechanism = mechanism;
		ErrorCode = code;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("ErrorCode", (int)ErrorCode);
		info.AddValue("Mechanism", Mechanism);
	}
}
