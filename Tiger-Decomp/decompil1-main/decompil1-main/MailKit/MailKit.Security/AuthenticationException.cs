using System;
using System.Runtime.Serialization;

namespace MailKit.Security;

[Serializable]
public class AuthenticationException : Exception
{
	protected AuthenticationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public AuthenticationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public AuthenticationException(string message)
		: base(message)
	{
	}

	public AuthenticationException()
		: base("Authentication failed.")
	{
	}
}
