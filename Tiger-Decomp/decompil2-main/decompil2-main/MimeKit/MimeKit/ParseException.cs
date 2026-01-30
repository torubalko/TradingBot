using System;
using System.Runtime.Serialization;
using System.Security;

namespace MimeKit;

[Serializable]
public class ParseException : FormatException
{
	public int TokenIndex { get; private set; }

	public int ErrorIndex { get; private set; }

	protected ParseException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		TokenIndex = info.GetInt32("TokenIndex");
		ErrorIndex = info.GetInt32("ErrorIndex");
	}

	public ParseException(string message, int tokenIndex, int errorIndex, Exception innerException)
		: base(message, innerException)
	{
		TokenIndex = tokenIndex;
		ErrorIndex = errorIndex;
	}

	public ParseException(string message, int tokenIndex, int errorIndex)
		: base(message)
	{
		TokenIndex = tokenIndex;
		ErrorIndex = errorIndex;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("TokenIndex", TokenIndex);
		info.AddValue("ErrorIndex", ErrorIndex);
	}
}
