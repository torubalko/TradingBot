namespace MimeKit;

public class BodyBuilder
{
	public AttachmentCollection Attachments { get; private set; }

	public AttachmentCollection LinkedResources { get; private set; }

	public string TextBody { get; set; }

	public string HtmlBody { get; set; }

	public BodyBuilder()
	{
		LinkedResources = new AttachmentCollection(linkedResources: true);
		Attachments = new AttachmentCollection();
	}

	public MimeEntity ToMessageBody()
	{
		MultipartAlternative multipartAlternative = null;
		MimeEntity mimeEntity = null;
		if (TextBody != null)
		{
			TextPart textPart = new TextPart("plain");
			textPart.Text = TextBody;
			if (HtmlBody != null)
			{
				multipartAlternative = new MultipartAlternative();
				multipartAlternative.Add(textPart);
				mimeEntity = multipartAlternative;
			}
			else
			{
				mimeEntity = textPart;
			}
		}
		if (HtmlBody != null)
		{
			TextPart textPart2 = new TextPart("html");
			textPart2.Text = HtmlBody;
			MimeEntity mimeEntity2;
			if (LinkedResources.Count > 0)
			{
				MultipartRelated multipartRelated = new MultipartRelated
				{
					Root = textPart2
				};
				foreach (MimeEntity linkedResource in LinkedResources)
				{
					multipartRelated.Add(linkedResource);
				}
				mimeEntity2 = multipartRelated;
			}
			else
			{
				mimeEntity2 = textPart2;
			}
			if (multipartAlternative != null)
			{
				multipartAlternative.Add(mimeEntity2);
			}
			else
			{
				mimeEntity = mimeEntity2;
			}
		}
		if (Attachments.Count > 0)
		{
			if (mimeEntity == null && Attachments.Count == 1)
			{
				return Attachments[0];
			}
			Multipart multipart = new Multipart("mixed");
			if (mimeEntity != null)
			{
				multipart.Add(mimeEntity);
			}
			foreach (MimeEntity attachment in Attachments)
			{
				multipart.Add(attachment);
			}
			mimeEntity = multipart;
		}
		return mimeEntity ?? new TextPart("plain")
		{
			Text = string.Empty
		};
	}
}
