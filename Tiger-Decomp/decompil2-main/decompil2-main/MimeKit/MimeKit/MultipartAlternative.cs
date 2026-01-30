using System;
using MimeKit.Text;

namespace MimeKit;

public class MultipartAlternative : Multipart
{
	public string TextBody => GetTextBody(TextFormat.Plain);

	public string HtmlBody => GetTextBody(TextFormat.Html);

	public MultipartAlternative(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MultipartAlternative(params object[] args)
		: base("alternative", args)
	{
	}

	public MultipartAlternative()
		: base("alternative")
	{
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMultipartAlternative(this);
	}

	internal static string GetText(TextPart text)
	{
		if (text.IsFlowed)
		{
			FlowedToText flowedToText = new FlowedToText();
			if (text.ContentType.Parameters.TryGetValue("delsp", out string value))
			{
				flowedToText.DeleteSpace = value.ToLowerInvariant() == "yes";
			}
			return flowedToText.Convert(text.Text);
		}
		return text.Text;
	}

	public string GetTextBody(TextFormat format)
	{
		for (int num = base.Count - 1; num >= 0; num--)
		{
			if (base[num] is MultipartAlternative multipartAlternative)
			{
				return multipartAlternative.GetTextBody(format);
			}
			MultipartRelated multipartRelated = base[num] as MultipartRelated;
			TextPart textPart = base[num] as TextPart;
			if (multipartRelated != null)
			{
				MimeEntity root = multipartRelated.Root;
				if (root is MultipartAlternative multipartAlternative2)
				{
					return multipartAlternative2.GetTextBody(format);
				}
				textPart = root as TextPart;
			}
			if (textPart != null && textPart.IsFormat(format))
			{
				return GetText(textPart);
			}
		}
		return null;
	}
}
