using System;
using System.Text;

namespace MailKit;

public class BodyPartMessage : BodyPartBasic
{
	public Envelope Envelope { get; set; }

	public BodyPart Body { get; set; }

	public uint Lines { get; set; }

	public override void Accept(BodyPartVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitBodyPartMessage(this);
	}

	protected override void Encode(StringBuilder builder)
	{
		base.Encode(builder);
		builder.Append(' ');
		BodyPart.Encode(builder, Envelope);
		builder.Append(' ');
		BodyPart.Encode(builder, Body);
		builder.Append(' ');
		BodyPart.Encode(builder, Lines);
	}
}
