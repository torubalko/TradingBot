using System;

namespace MimeKit;

public class MimeMessageBeginEventArgs : EventArgs
{
	public MimeMessage Message { get; }

	public MessagePart Parent { get; }

	public long BeginOffset { get; set; }

	internal int LineNumber { get; set; }

	public MimeMessageBeginEventArgs(MimeMessage message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		Message = message;
	}

	public MimeMessageBeginEventArgs(MimeMessage message, MessagePart parent)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		Message = message;
		Parent = parent;
	}
}
