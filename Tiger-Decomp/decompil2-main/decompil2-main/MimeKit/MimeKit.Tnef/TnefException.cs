using System;
using System.Runtime.Serialization;
using System.Security;

namespace MimeKit.Tnef;

[Serializable]
public class TnefException : FormatException
{
	public TnefComplianceStatus Error { get; private set; }

	protected TnefException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Error = (TnefComplianceStatus)info.GetValue("Error", typeof(TnefComplianceStatus));
	}

	public TnefException(TnefComplianceStatus error, string message, Exception innerException)
		: base(message, innerException)
	{
		Error = error;
	}

	public TnefException(TnefComplianceStatus error, string message)
		: base(message)
	{
		Error = error;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Error", Error);
	}
}
