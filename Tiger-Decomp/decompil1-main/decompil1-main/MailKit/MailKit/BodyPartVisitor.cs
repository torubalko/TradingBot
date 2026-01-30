namespace MailKit;

public abstract class BodyPartVisitor
{
	public virtual void Visit(BodyPart body)
	{
		body?.Accept(this);
	}

	protected internal virtual void VisitBodyPart(BodyPart entity)
	{
	}

	protected internal virtual void VisitBodyPartBasic(BodyPartBasic entity)
	{
		VisitBodyPart(entity);
	}

	protected virtual void VisitMessage(BodyPart message)
	{
		message?.Accept(this);
	}

	protected internal virtual void VisitBodyPartMessage(BodyPartMessage entity)
	{
		VisitBodyPartBasic(entity);
		VisitMessage(entity.Body);
	}

	protected virtual void VisitChildren(BodyPartMultipart multipart)
	{
		for (int i = 0; i < multipart.BodyParts.Count; i++)
		{
			multipart.BodyParts[i].Accept(this);
		}
	}

	protected internal virtual void VisitBodyPartMultipart(BodyPartMultipart multipart)
	{
		VisitBodyPart(multipart);
		VisitChildren(multipart);
	}

	protected internal virtual void VisitBodyPartText(BodyPartText entity)
	{
		VisitBodyPartBasic(entity);
	}
}
