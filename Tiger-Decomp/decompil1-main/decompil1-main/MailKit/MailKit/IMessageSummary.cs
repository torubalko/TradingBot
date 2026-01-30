using System;
using System.Collections.Generic;
using MimeKit;

namespace MailKit;

public interface IMessageSummary
{
	IMailFolder Folder { get; }

	MessageSummaryItems Fields { get; }

	BodyPart Body { get; }

	BodyPartText TextBody { get; }

	BodyPartText HtmlBody { get; }

	IEnumerable<BodyPartBasic> BodyParts { get; }

	IEnumerable<BodyPartBasic> Attachments { get; }

	string PreviewText { get; }

	Envelope Envelope { get; }

	string NormalizedSubject { get; }

	DateTimeOffset Date { get; }

	bool IsReply { get; }

	MessageFlags? Flags { get; }

	HashSet<string> Keywords { get; }

	[Obsolete("Use Keywords instead.")]
	HashSet<string> UserFlags { get; }

	IList<Annotation> Annotations { get; }

	HeaderList Headers { get; }

	DateTimeOffset? InternalDate { get; }

	DateTimeOffset? SaveDate { get; }

	uint? Size { get; }

	ulong? ModSeq { get; }

	MessageIdList References { get; }

	string EmailId { get; }

	[Obsolete("Use EmailId instead.")]
	string Id { get; }

	string ThreadId { get; }

	UniqueId UniqueId { get; }

	int Index { get; }

	ulong? GMailMessageId { get; }

	ulong? GMailThreadId { get; }

	IList<string> GMailLabels { get; }
}
