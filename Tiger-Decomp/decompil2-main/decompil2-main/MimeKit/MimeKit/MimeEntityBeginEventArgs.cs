using System;

namespace MimeKit;

public class MimeEntityBeginEventArgs : EventArgs
{
	public MimeEntity Entity { get; }

	public Multipart Parent { get; }

	public long BeginOffset { get; set; }

	internal int LineNumber { get; set; }

	public MimeEntityBeginEventArgs(MimeEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		Entity = entity;
	}

	public MimeEntityBeginEventArgs(MimeEntity entity, Multipart parent)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		Entity = entity;
		Parent = parent;
	}
}
