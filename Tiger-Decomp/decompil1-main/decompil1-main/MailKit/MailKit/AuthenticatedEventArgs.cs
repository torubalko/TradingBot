using System;

namespace MailKit;

public class AuthenticatedEventArgs : EventArgs
{
	public string Message { get; private set; }

	public AuthenticatedEventArgs(string message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
	}
}
