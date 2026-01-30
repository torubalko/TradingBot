using System;
using System.Text;
using MimeKit;

namespace MailKit;

public class BodyPartBasic : BodyPart
{
	public string ContentId { get; set; }

	public string ContentDescription { get; set; }

	public string ContentTransferEncoding { get; set; }

	public uint Octets { get; set; }

	public string ContentMd5 { get; set; }

	public ContentDisposition ContentDisposition { get; set; }

	public string[] ContentLanguage { get; set; }

	public Uri ContentLocation { get; set; }

	public bool IsAttachment
	{
		get
		{
			if (ContentDisposition != null)
			{
				return ContentDisposition.IsAttachment;
			}
			return false;
		}
	}

	public string FileName
	{
		get
		{
			string text = null;
			if (ContentDisposition != null)
			{
				text = ContentDisposition.FileName;
			}
			if (text == null)
			{
				text = base.ContentType.Name;
			}
			return text?.Trim();
		}
	}

	public override void Accept(BodyPartVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitBodyPartBasic(this);
	}

	protected override void Encode(StringBuilder builder)
	{
		BodyPart.Encode(builder, base.ContentType);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentId);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentDescription);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentTransferEncoding);
		builder.Append(' ');
		BodyPart.Encode(builder, Octets);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentMd5);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentDisposition);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentLanguage);
		builder.Append(' ');
		BodyPart.Encode(builder, ContentLocation);
	}
}
