using System;
using System.Runtime.Serialization;
using System.Security;

namespace MailKit.Net.Imap;

[Serializable]
public class ImapCommandException : CommandException
{
	public ImapCommandResponse Response { get; private set; }

	public string ResponseText { get; private set; }

	[SecuritySafeCritical]
	protected ImapCommandException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Response = (ImapCommandResponse)info.GetValue("Response", typeof(ImapCommandResponse));
		ResponseText = info.GetString("ResponseText");
	}

	internal static ImapCommandException Create(string command, ImapCommand ic)
	{
		string arg = ic.Response.ToString().ToUpperInvariant();
		string text = null;
		if (string.IsNullOrEmpty(ic.ResponseText))
		{
			for (int num = ic.RespCodes.Count - 1; num >= 0; num--)
			{
				if (ic.RespCodes[num].IsError && !string.IsNullOrEmpty(ic.RespCodes[num].Message))
				{
					text = ic.RespCodes[num].Message;
					break;
				}
			}
		}
		else
		{
			text = ic.ResponseText;
		}
		string message = (string.IsNullOrEmpty(text) ? $"The IMAP server replied to the '{command}' command with a '{arg}' response." : $"The IMAP server replied to the '{command}' command with a '{arg}' response: {text}");
		if (ic.Exception == null)
		{
			return new ImapCommandException(ic.Response, text, message);
		}
		return new ImapCommandException(ic.Response, text, message, ic.Exception);
	}

	public ImapCommandException(ImapCommandResponse response, string responseText, string message, Exception innerException)
		: base(message, innerException)
	{
		ResponseText = responseText;
		Response = response;
	}

	public ImapCommandException(ImapCommandResponse response, string responseText, string message)
		: base(message)
	{
		ResponseText = responseText;
		Response = response;
	}

	public ImapCommandException(ImapCommandResponse response, string responseText)
	{
		ResponseText = responseText;
		Response = response;
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Response", Response, typeof(ImapCommandResponse));
		info.AddValue("ResponseText", ResponseText);
	}
}
