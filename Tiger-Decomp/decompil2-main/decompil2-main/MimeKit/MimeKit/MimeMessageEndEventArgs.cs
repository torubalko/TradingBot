namespace MimeKit;

public class MimeMessageEndEventArgs : MimeMessageBeginEventArgs
{
	public long HeadersEndOffset { get; set; }

	public long EndOffset { get; set; }

	public MimeMessageEndEventArgs(MimeMessage message)
		: base(message)
	{
	}

	public MimeMessageEndEventArgs(MimeMessage message, MessagePart parent)
		: base(message, parent)
	{
	}
}
