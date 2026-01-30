namespace MimeKit;

public class MimeEntityEndEventArgs : MimeEntityBeginEventArgs
{
	public long HeadersEndOffset { get; set; }

	public long EndOffset { get; set; }

	public int Lines { get; set; }

	public MimeEntityEndEventArgs(MimeEntity entity)
		: base(entity)
	{
	}

	public MimeEntityEndEventArgs(MimeEntity entity, Multipart parent)
		: base(entity, parent)
	{
	}
}
