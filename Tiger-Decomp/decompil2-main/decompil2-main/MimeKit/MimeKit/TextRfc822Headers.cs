using System;

namespace MimeKit;

public class TextRfc822Headers : MessagePart
{
	public TextRfc822Headers(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public TextRfc822Headers(params object[] args)
		: this()
	{
		MimeMessage mimeMessage = null;
		foreach (object obj in args)
		{
			if (obj != null && !TryInit(obj))
			{
				if (!(obj is MimeMessage mimeMessage2))
				{
					throw new ArgumentException("Unknown initialization parameter: " + obj.GetType());
				}
				if (mimeMessage != null)
				{
					throw new ArgumentException("MimeMessage should not be specified more than once.");
				}
				mimeMessage = mimeMessage2;
			}
		}
		if (mimeMessage != null)
		{
			base.Message = mimeMessage;
		}
	}

	public TextRfc822Headers()
		: base("text", "rfc822-headers")
	{
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitTextRfc822Headers(this);
	}
}
