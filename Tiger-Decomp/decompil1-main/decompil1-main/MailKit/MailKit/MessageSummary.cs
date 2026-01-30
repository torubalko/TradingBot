using System;
using System.Collections.Generic;
using System.Linq;
using MimeKit;
using MimeKit.Utils;

namespace MailKit;

public class MessageSummary : IMessageSummary
{
	private int threadableReplyDepth = -1;

	private string normalizedSubject;

	public IMailFolder Folder { get; private set; }

	public MessageSummaryItems Fields { get; internal set; }

	public BodyPart Body { get; set; }

	public BodyPartText TextBody
	{
		get
		{
			if (Body is BodyPartMultipart multipart)
			{
				if (TryGetMessageBody(multipart, html: false, out var body))
				{
					return body;
				}
			}
			else if (Body is BodyPartText { IsPlain: not false } bodyPartText)
			{
				return bodyPartText;
			}
			return null;
		}
	}

	public BodyPartText HtmlBody
	{
		get
		{
			if (Body is BodyPartMultipart multipart)
			{
				if (TryGetMessageBody(multipart, html: true, out var body))
				{
					return body;
				}
			}
			else if (Body is BodyPartText { IsHtml: not false } bodyPartText)
			{
				return bodyPartText;
			}
			return null;
		}
	}

	public IEnumerable<BodyPartBasic> BodyParts => EnumerateBodyParts(Body, attachmentsOnly: false);

	public IEnumerable<BodyPartBasic> Attachments => EnumerateBodyParts(Body, attachmentsOnly: true);

	public string PreviewText { get; set; }

	public Envelope Envelope { get; set; }

	public string NormalizedSubject
	{
		get
		{
			UpdateThreadableSubject();
			return normalizedSubject;
		}
	}

	public bool IsReply
	{
		get
		{
			UpdateThreadableSubject();
			return threadableReplyDepth != 0;
		}
	}

	public DateTimeOffset Date => Envelope?.Date ?? InternalDate ?? DateTimeOffset.MinValue;

	public MessageFlags? Flags { get; set; }

	public HashSet<string> Keywords { get; set; }

	[Obsolete("Use Keywords instead.")]
	public HashSet<string> UserFlags
	{
		get
		{
			return Keywords;
		}
		set
		{
			Keywords = value;
		}
	}

	public IList<Annotation> Annotations { get; set; }

	public HeaderList Headers { get; set; }

	public DateTimeOffset? InternalDate { get; set; }

	public DateTimeOffset? SaveDate { get; set; }

	public uint? Size { get; set; }

	public ulong? ModSeq { get; set; }

	public MessageIdList References { get; set; }

	public string EmailId { get; set; }

	[Obsolete("Use EmailId instead.")]
	public string Id => EmailId;

	public string ThreadId { get; set; }

	public UniqueId UniqueId { get; set; }

	public int Index { get; internal set; }

	public ulong? GMailMessageId { get; set; }

	public ulong? GMailThreadId { get; set; }

	public IList<string> GMailLabels { get; set; }

	public MessageSummary(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		Keywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		Index = index;
	}

	public MessageSummary(IMailFolder folder, int index)
		: this(index)
	{
		if (folder == null)
		{
			throw new ArgumentNullException("folder");
		}
		Folder = folder;
	}

	private void UpdateThreadableSubject()
	{
		if (normalizedSubject == null)
		{
			if (Envelope?.Subject != null)
			{
				normalizedSubject = MessageThreader.GetThreadableSubject(Envelope.Subject, out threadableReplyDepth);
				return;
			}
			normalizedSubject = string.Empty;
			threadableReplyDepth = 0;
		}
	}

	private static BodyPart GetMultipartRelatedRoot(BodyPartMultipart related)
	{
		string text = related.ContentType.Parameters["start"];
		if (text == null)
		{
			if (related.BodyParts.Count <= 0)
			{
				return null;
			}
			return related.BodyParts[0];
		}
		string text2;
		if ((text2 = MimeUtils.EnumerateReferences(text).FirstOrDefault()) == null)
		{
			text2 = text;
		}
		Uri uri = new Uri($"cid:{text2}");
		for (int i = 0; i < related.BodyParts.Count; i++)
		{
			if (related.BodyParts[i] is BodyPartBasic bodyPartBasic && (bodyPartBasic.ContentId == text2 || bodyPartBasic.ContentLocation == uri))
			{
				return bodyPartBasic;
			}
			if (related.BodyParts[i] is BodyPartMultipart bodyPartMultipart && bodyPartMultipart.ContentLocation == uri)
			{
				return bodyPartMultipart;
			}
		}
		return null;
	}

	private static bool TryGetMultipartAlternativeBody(BodyPartMultipart multipart, bool html, out BodyPartText body)
	{
		for (int num = multipart.BodyParts.Count - 1; num >= 0; num--)
		{
			BodyPartMultipart bodyPartMultipart = multipart.BodyParts[num] as BodyPartMultipart;
			BodyPartText bodyPartText = null;
			if (bodyPartMultipart != null)
			{
				if (bodyPartMultipart.ContentType.IsMimeType("multipart", "related"))
				{
					bodyPartText = GetMultipartRelatedRoot(bodyPartMultipart) as BodyPartText;
				}
				else if (bodyPartMultipart.ContentType.IsMimeType("multipart", "alternative") && TryGetMultipartAlternativeBody(bodyPartMultipart, html, out body))
				{
					return true;
				}
			}
			else
			{
				bodyPartText = multipart.BodyParts[num] as BodyPartText;
			}
			if (bodyPartText != null && (html ? bodyPartText.IsHtml : bodyPartText.IsPlain))
			{
				body = bodyPartText;
				return true;
			}
		}
		body = null;
		return false;
	}

	private static bool TryGetMessageBody(BodyPartMultipart multipart, bool html, out BodyPartText body)
	{
		if (multipart.ContentType.IsMimeType("multipart", "alternative"))
		{
			return TryGetMultipartAlternativeBody(multipart, html, out body);
		}
		if (!multipart.ContentType.IsMimeType("multipart", "related"))
		{
			for (int i = 0; i < multipart.BodyParts.Count; i++)
			{
				if (multipart.BodyParts[i] is BodyPartMultipart multipart2)
				{
					if (!TryGetMessageBody(multipart2, html, out body))
					{
						break;
					}
					return true;
				}
				if (multipart.BodyParts[i] is BodyPartText { IsAttachment: false } bodyPartText)
				{
					if (!(html ? bodyPartText.IsHtml : bodyPartText.IsPlain))
					{
						break;
					}
					body = bodyPartText;
					return true;
				}
			}
		}
		else
		{
			BodyPart multipartRelatedRoot = GetMultipartRelatedRoot(multipart);
			if (multipartRelatedRoot is BodyPartText bodyPartText2)
			{
				body = ((html ? bodyPartText2.IsHtml : bodyPartText2.IsPlain) ? bodyPartText2 : null);
				return body != null;
			}
			if (multipartRelatedRoot is BodyPartMultipart multipart3)
			{
				return TryGetMessageBody(multipart3, html, out body);
			}
		}
		body = null;
		return false;
	}

	private static IEnumerable<BodyPartBasic> EnumerateBodyParts(BodyPart entity, bool attachmentsOnly)
	{
		if (entity == null)
		{
			yield break;
		}
		if (entity is BodyPartMultipart bodyPartMultipart)
		{
			foreach (BodyPart bodyPart in bodyPartMultipart.BodyParts)
			{
				foreach (BodyPartBasic item in EnumerateBodyParts(bodyPart, attachmentsOnly))
				{
					yield return item;
				}
			}
		}
		else
		{
			BodyPartBasic bodyPartBasic = (BodyPartBasic)entity;
			if (!attachmentsOnly || bodyPartBasic.IsAttachment)
			{
				yield return bodyPartBasic;
			}
		}
	}
}
