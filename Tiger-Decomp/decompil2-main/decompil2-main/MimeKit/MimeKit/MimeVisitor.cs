using MimeKit.Cryptography;
using MimeKit.Tnef;

namespace MimeKit;

public abstract class MimeVisitor
{
	public virtual void Visit(MimeEntity entity)
	{
		entity?.Accept(this);
	}

	public virtual void Visit(MimeMessage message)
	{
		message?.Accept(this);
	}

	protected internal virtual void VisitApplicationPgpEncrypted(ApplicationPgpEncrypted entity)
	{
		VisitMimePart(entity);
	}

	protected internal virtual void VisitApplicationPgpSignature(ApplicationPgpSignature entity)
	{
		VisitMimePart(entity);
	}

	protected internal virtual void VisitApplicationPkcs7Mime(ApplicationPkcs7Mime entity)
	{
		VisitMimePart(entity);
	}

	protected internal virtual void VisitApplicationPkcs7Signature(ApplicationPkcs7Signature entity)
	{
		VisitMimePart(entity);
	}

	protected internal virtual void VisitMessageDispositionNotification(MessageDispositionNotification entity)
	{
		VisitMimePart(entity);
	}

	protected internal virtual void VisitMessageDeliveryStatus(MessageDeliveryStatus entity)
	{
		VisitMimePart(entity);
	}

	protected virtual void VisitMessage(MessagePart entity)
	{
		if (entity.Message != null)
		{
			entity.Message.Accept(this);
		}
	}

	protected internal virtual void VisitMessagePart(MessagePart entity)
	{
		VisitMimeEntity(entity);
		VisitMessage(entity);
	}

	protected internal virtual void VisitMessagePartial(MessagePartial entity)
	{
		VisitMimePart(entity);
	}

	protected internal virtual void VisitMimeEntity(MimeEntity entity)
	{
	}

	protected virtual void VisitBody(MimeMessage message)
	{
		if (message.Body != null)
		{
			message.Body.Accept(this);
		}
	}

	protected internal virtual void VisitMimeMessage(MimeMessage message)
	{
		VisitBody(message);
	}

	protected internal virtual void VisitMimePart(MimePart entity)
	{
		VisitMimeEntity(entity);
	}

	protected virtual void VisitChildren(Multipart multipart)
	{
		for (int i = 0; i < multipart.Count; i++)
		{
			multipart[i].Accept(this);
		}
	}

	protected internal virtual void VisitMultipart(Multipart multipart)
	{
		VisitMimeEntity(multipart);
		VisitChildren(multipart);
	}

	protected internal virtual void VisitMultipartAlternative(MultipartAlternative alternative)
	{
		VisitMultipart(alternative);
	}

	protected internal virtual void VisitMultipartEncrypted(MultipartEncrypted encrypted)
	{
		VisitMultipart(encrypted);
	}

	protected internal virtual void VisitMultipartRelated(MultipartRelated related)
	{
		VisitMultipart(related);
	}

	protected internal virtual void VisitMultipartReport(MultipartReport report)
	{
		VisitMultipart(report);
	}

	protected internal virtual void VisitMultipartSigned(MultipartSigned signed)
	{
		VisitMultipart(signed);
	}

	protected internal virtual void VisitTextPart(TextPart entity)
	{
		VisitMimePart(entity);
	}

	protected internal virtual void VisitTextRfc822Headers(TextRfc822Headers entity)
	{
		VisitMessagePart(entity);
	}

	protected internal virtual void VisitTnefPart(TnefPart entity)
	{
		VisitMimePart(entity);
	}
}
