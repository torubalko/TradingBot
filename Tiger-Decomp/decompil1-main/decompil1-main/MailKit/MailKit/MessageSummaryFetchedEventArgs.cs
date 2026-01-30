using System;

namespace MailKit;

public class MessageSummaryFetchedEventArgs : EventArgs
{
	public IMessageSummary Message { get; private set; }

	public MessageSummaryFetchedEventArgs(IMessageSummary message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
	}
}
