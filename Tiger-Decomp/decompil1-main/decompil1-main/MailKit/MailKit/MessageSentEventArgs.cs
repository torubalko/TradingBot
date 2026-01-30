using System;
using MimeKit;

namespace MailKit;

public class MessageSentEventArgs : EventArgs
{
	public MimeMessage Message { get; private set; }

	public string Response { get; private set; }

	public MessageSentEventArgs(MimeMessage message, string response)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		Message = message;
		Response = response;
	}
}
