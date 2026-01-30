using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Search;
using MimeKit;

namespace MailKit;

public interface IMailFolder : IEnumerable<MimeMessage>, IEnumerable
{
	object SyncRoot { get; }

	IMailFolder ParentFolder { get; }

	FolderAttributes Attributes { get; }

	AnnotationAccess AnnotationAccess { get; }

	AnnotationScope AnnotationScopes { get; }

	uint MaxAnnotationSize { get; }

	MessageFlags PermanentFlags { get; }

	MessageFlags AcceptedFlags { get; }

	char DirectorySeparator { get; }

	FolderAccess Access { get; }

	bool IsNamespace { get; }

	string FullName { get; }

	string Name { get; }

	string Id { get; }

	bool IsSubscribed { get; }

	bool IsOpen { get; }

	bool Exists { get; }

	[Obsolete("Use Supports(FolderFeature.ModSequences) instead.")]
	bool SupportsModSeq { get; }

	ulong HighestModSeq { get; }

	uint UidValidity { get; }

	UniqueId? UidNext { get; }

	uint? AppendLimit { get; }

	ulong? Size { get; }

	int FirstUnread { get; }

	int Unread { get; }

	int Recent { get; }

	int Count { get; }

	HashSet<ThreadingAlgorithm> ThreadingAlgorithms { get; }

	event EventHandler<EventArgs> Opened;

	event EventHandler<EventArgs> Closed;

	event EventHandler<EventArgs> Deleted;

	event EventHandler<FolderRenamedEventArgs> Renamed;

	event EventHandler<EventArgs> Subscribed;

	event EventHandler<EventArgs> Unsubscribed;

	event EventHandler<MessageEventArgs> MessageExpunged;

	event EventHandler<MessagesVanishedEventArgs> MessagesVanished;

	event EventHandler<MessageFlagsChangedEventArgs> MessageFlagsChanged;

	event EventHandler<MessageLabelsChangedEventArgs> MessageLabelsChanged;

	event EventHandler<AnnotationsChangedEventArgs> AnnotationsChanged;

	event EventHandler<MessageSummaryFetchedEventArgs> MessageSummaryFetched;

	event EventHandler<MetadataChangedEventArgs> MetadataChanged;

	event EventHandler<ModSeqChangedEventArgs> ModSeqChanged;

	event EventHandler<EventArgs> HighestModSeqChanged;

	event EventHandler<EventArgs> UidNextChanged;

	event EventHandler<EventArgs> UidValidityChanged;

	event EventHandler<EventArgs> IdChanged;

	event EventHandler<EventArgs> SizeChanged;

	event EventHandler<EventArgs> CountChanged;

	event EventHandler<EventArgs> RecentChanged;

	event EventHandler<EventArgs> UnreadChanged;

	bool Supports(FolderFeature feature);

	FolderAccess Open(FolderAccess access, uint uidValidity, ulong highestModSeq, IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	Task<FolderAccess> OpenAsync(FolderAccess access, uint uidValidity, ulong highestModSeq, IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	FolderAccess Open(FolderAccess access, CancellationToken cancellationToken = default(CancellationToken));

	Task<FolderAccess> OpenAsync(FolderAccess access, CancellationToken cancellationToken = default(CancellationToken));

	void Close(bool expunge = false, CancellationToken cancellationToken = default(CancellationToken));

	Task CloseAsync(bool expunge = false, CancellationToken cancellationToken = default(CancellationToken));

	IMailFolder Create(string name, bool isMessageFolder, CancellationToken cancellationToken = default(CancellationToken));

	Task<IMailFolder> CreateAsync(string name, bool isMessageFolder, CancellationToken cancellationToken = default(CancellationToken));

	IMailFolder Create(string name, IEnumerable<SpecialFolder> specialUses, CancellationToken cancellationToken = default(CancellationToken));

	Task<IMailFolder> CreateAsync(string name, IEnumerable<SpecialFolder> specialUses, CancellationToken cancellationToken = default(CancellationToken));

	IMailFolder Create(string name, SpecialFolder specialUse, CancellationToken cancellationToken = default(CancellationToken));

	Task<IMailFolder> CreateAsync(string name, SpecialFolder specialUse, CancellationToken cancellationToken = default(CancellationToken));

	void Rename(IMailFolder parent, string name, CancellationToken cancellationToken = default(CancellationToken));

	Task RenameAsync(IMailFolder parent, string name, CancellationToken cancellationToken = default(CancellationToken));

	void Delete(CancellationToken cancellationToken = default(CancellationToken));

	Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

	void Subscribe(CancellationToken cancellationToken = default(CancellationToken));

	Task SubscribeAsync(CancellationToken cancellationToken = default(CancellationToken));

	void Unsubscribe(CancellationToken cancellationToken = default(CancellationToken));

	Task UnsubscribeAsync(CancellationToken cancellationToken = default(CancellationToken));

	IList<IMailFolder> GetSubfolders(StatusItems items, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMailFolder>> GetSubfoldersAsync(StatusItems items, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMailFolder> GetSubfolders(bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMailFolder>> GetSubfoldersAsync(bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	IMailFolder GetSubfolder(string name, CancellationToken cancellationToken = default(CancellationToken));

	Task<IMailFolder> GetSubfolderAsync(string name, CancellationToken cancellationToken = default(CancellationToken));

	void Check(CancellationToken cancellationToken = default(CancellationToken));

	Task CheckAsync(CancellationToken cancellationToken = default(CancellationToken));

	void Status(StatusItems items, CancellationToken cancellationToken = default(CancellationToken));

	Task StatusAsync(StatusItems items, CancellationToken cancellationToken = default(CancellationToken));

	AccessControlList GetAccessControlList(CancellationToken cancellationToken = default(CancellationToken));

	Task<AccessControlList> GetAccessControlListAsync(CancellationToken cancellationToken = default(CancellationToken));

	AccessRights GetAccessRights(string name, CancellationToken cancellationToken = default(CancellationToken));

	Task<AccessRights> GetAccessRightsAsync(string name, CancellationToken cancellationToken = default(CancellationToken));

	AccessRights GetMyAccessRights(CancellationToken cancellationToken = default(CancellationToken));

	Task<AccessRights> GetMyAccessRightsAsync(CancellationToken cancellationToken = default(CancellationToken));

	void AddAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	Task AddAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	void SetAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	Task SetAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveAccess(string name, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveAccessAsync(string name, CancellationToken cancellationToken = default(CancellationToken));

	FolderQuota GetQuota(CancellationToken cancellationToken = default(CancellationToken));

	Task<FolderQuota> GetQuotaAsync(CancellationToken cancellationToken = default(CancellationToken));

	FolderQuota SetQuota(uint? messageLimit, uint? storageLimit, CancellationToken cancellationToken = default(CancellationToken));

	Task<FolderQuota> SetQuotaAsync(uint? messageLimit, uint? storageLimit, CancellationToken cancellationToken = default(CancellationToken));

	string GetMetadata(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	Task<string> GetMetadataAsync(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	MetadataCollection GetMetadata(IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	Task<MetadataCollection> GetMetadataAsync(IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	MetadataCollection GetMetadata(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	Task<MetadataCollection> GetMetadataAsync(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	void SetMetadata(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken));

	Task SetMetadataAsync(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken));

	void Expunge(CancellationToken cancellationToken = default(CancellationToken));

	Task ExpungeAsync(CancellationToken cancellationToken = default(CancellationToken));

	void Expunge(IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	Task ExpungeAsync(IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	UniqueId? Append(MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> AppendAsync(MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Append(MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> AppendAsync(MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Append(MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> AppendAsync(MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<UniqueId> Append(IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<UniqueId>> AppendAsync(IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<UniqueId> Append(IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<UniqueId>> AppendAsync(IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<UniqueId> Append(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<UniqueId> Append(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(FormatOptions options, int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(FormatOptions options, int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? Replace(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<UniqueId?> ReplaceAsync(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	UniqueId? CopyTo(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task<UniqueId?> CopyToAsync(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	UniqueIdMap CopyTo(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task<UniqueIdMap> CopyToAsync(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	UniqueId? MoveTo(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task<UniqueId?> MoveToAsync(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	UniqueIdMap MoveTo(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task<UniqueIdMap> MoveToAsync(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	void CopyTo(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task CopyToAsync(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	void CopyTo(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task CopyToAsync(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	void MoveTo(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task MoveToAsync(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	void MoveTo(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	Task MoveToAsync(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	HeaderList GetHeaders(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<HeaderList> GetHeadersAsync(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	HeaderList GetHeaders(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<HeaderList> GetHeadersAsync(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	HeaderList GetHeaders(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<HeaderList> GetHeadersAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	HeaderList GetHeaders(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<HeaderList> GetHeadersAsync(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	MimeMessage GetMessage(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<MimeMessage> GetMessageAsync(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	MimeMessage GetMessage(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<MimeMessage> GetMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	MimeEntity GetBodyPart(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<MimeEntity> GetBodyPartAsync(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	MimeEntity GetBodyPart(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<MimeEntity> GetBodyPartAsync(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(UniqueId uid, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(UniqueId uid, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(int index, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(int index, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(UniqueId uid, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(UniqueId uid, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(int index, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(int index, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(UniqueId uid, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(UniqueId uid, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(UniqueId uid, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(UniqueId uid, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(int index, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(int index, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(int index, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(int index, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void AddFlags(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddFlags(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddFlags(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> AddFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> AddFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> AddFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> AddFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> RemoveFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> RemoveFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> RemoveFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> RemoveFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> SetFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> SetFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> SetFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> SetFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddFlags(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddFlags(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddFlags(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> AddFlags(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> AddFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> AddFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> AddFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> RemoveFlags(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> RemoveFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> RemoveFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> RemoveFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> SetFlags(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> SetFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> SetFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> SetFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddLabels(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddLabelsAsync(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveLabels(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveLabelsAsync(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetLabels(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetLabelsAsync(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> AddLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> AddLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> RemoveLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> RemoveLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> SetLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> SetLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddLabels(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddLabelsAsync(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void AddLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task AddLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveLabels(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveLabelsAsync(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void RemoveLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task RemoveLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetLabels(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetLabelsAsync(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void SetLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task SetLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> AddLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> AddLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> RemoveLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> RemoveLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> SetLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> SetLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	void Store(UniqueId uid, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	Task StoreAsync(UniqueId uid, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	void Store(IList<UniqueId> uids, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	Task StoreAsync(IList<UniqueId> uids, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> Store(IList<UniqueId> uids, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> StoreAsync(IList<UniqueId> uids, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	void Store(int index, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	Task StoreAsync(int index, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	void Store(IList<int> indexes, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	Task StoreAsync(IList<int> indexes, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> Store(IList<int> indexes, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> StoreAsync(IList<int> indexes, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> Search(SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> SearchAsync(SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> Search(IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> SearchAsync(IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	SearchResults Search(SearchOptions options, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	Task<SearchResults> SearchAsync(SearchOptions options, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	SearchResults Search(SearchOptions options, IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	Task<SearchResults> SearchAsync(SearchOptions options, IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> Sort(SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> SortAsync(SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	IList<UniqueId> Sort(IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<UniqueId>> SortAsync(IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	SearchResults Sort(SearchOptions options, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	Task<SearchResults> SortAsync(SearchOptions options, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	SearchResults Sort(SearchOptions options, IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	Task<SearchResults> SortAsync(SearchOptions options, IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	IList<MessageThread> Thread(ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<MessageThread>> ThreadAsync(ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	IList<MessageThread> Thread(IList<UniqueId> uids, ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<MessageThread>> ThreadAsync(IList<UniqueId> uids, ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));
}
