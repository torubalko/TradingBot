using System;
using System.Text;

namespace MailKit;

public class BodyPartText : BodyPartBasic
{
	public bool IsPlain => base.ContentType.IsMimeType("text", "plain");

	public bool IsHtml => base.ContentType.IsMimeType("text", "html");

	public uint Lines { get; set; }

	public override void Accept(BodyPartVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitBodyPartText(this);
	}

	protected override void Encode(StringBuilder builder)
	{
		base.Encode(builder);
		builder.Append(' ');
		BodyPart.Encode(builder, Lines);
	}
}
