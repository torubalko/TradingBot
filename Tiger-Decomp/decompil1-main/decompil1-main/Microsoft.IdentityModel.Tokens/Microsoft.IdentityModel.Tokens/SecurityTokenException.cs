using System;
using System.Runtime.Serialization;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

[Serializable]
public class SecurityTokenException : Exception
{
	public SecurityTokenException()
	{
	}

	public SecurityTokenException(string message)
		: base(message)
	{
	}

	public SecurityTokenException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SecurityTokenException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw LogHelper.LogArgumentNullException("info");
		}
		base.GetObjectData(info, context);
	}
}
