using System;
using System.Text;
using MimeKit;

namespace MailKit;

public class BodyPartMultipart : BodyPart
{
	public BodyPartCollection BodyParts { get; private set; }

	public ContentDisposition ContentDisposition { get; set; }

	public string[] ContentLanguage { get; set; }

	public Uri ContentLocation { get; set; }

	public BodyPartMultipart()
	{
		BodyParts = new BodyPartCollection();
	}

	public override void Accept(BodyPartVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitBodyPartMultipart(this);
	}

	protected override void Encode(StringBuilder builder)
	{
		BodyPart.Encode(builder, BodyParts);
		builder.Append(' ');
		BodyPart.Encode(builder, base.ContentType.MediaSubtype);
		builder.Append(' ');
		BodyPart.Encode(builder, base.ContentType.Parameters);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentDisposition);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentLanguage);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentLocation);
	}
}
