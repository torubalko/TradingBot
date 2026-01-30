using System.Collections.Generic;

namespace MailKit;

public class MessageThread
{
	public IMessageSummary Message { get; private set; }

	public UniqueId? UniqueId { get; private set; }

	public IList<MessageThread> Children { get; private set; }

	public MessageThread(UniqueId? uid)
	{
		Children = new List<MessageThread>();
		UniqueId = uid;
	}

	public MessageThread(IMessageSummary message)
	{
		Children = new List<MessageThread>();
		if (message != null && message.UniqueId.IsValid)
		{
			UniqueId = message.UniqueId;
		}
		Message = message;
	}
}
