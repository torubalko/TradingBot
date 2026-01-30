using System;

namespace MailKit;

public class AlertEventArgs : EventArgs
{
	public string Message { get; private set; }

	public AlertEventArgs(string message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
	}
}
