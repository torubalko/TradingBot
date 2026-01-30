using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit.Net.Pop3;

[Serializable]
public class Pop3CommandException : CommandException
{
	public string StatusText { get; private set; }

	[SecuritySafeCritical]
	protected Pop3CommandException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		StatusText = info.GetString("StatusText");
	}

	public Pop3CommandException(string message, Exception innerException)
		: base(message, innerException)
	{
		StatusText = string.Empty;
	}

	public Pop3CommandException(string message, string statusText, Exception innerException)
		: base(message, innerException)
	{
		if (statusText == null)
		{
			throw new ArgumentNullException("statusText");
		}
		StatusText = statusText;
	}

	public Pop3CommandException(string message)
		: base(message)
	{
		StatusText = string.Empty;
	}

	public Pop3CommandException(string message, string statusText)
		: base(message)
	{
		if (statusText == null)
		{
			throw new ArgumentNullException("statusText");
		}
		StatusText = statusText;
	}

	public Pop3CommandException()
	{
		StatusText = string.Empty;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("StatusText", StatusText);
	}
}
