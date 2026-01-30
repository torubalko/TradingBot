using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Search;
using MimeKit;

namespace MailKit;

public abstract class MailFolder : IMailFolder, IEnumerable<MimeMessage>, IEnumerable
{
	protected static readonly MessageFlags SettableFlags = MessageFlags.Seen | MessageFlags.Answered | MessageFlags.Flagged | MessageFlags.Deleted | MessageFlags.Draft;

	private IMailFolder parent;

	public abstract object SyncRoot { get; }

	public IMailFolder ParentFolder
	{
		get
		{
			return parent;
		}
		protected internal set
		{
			if (value != parent)
			{
				if (parent != null)
				{
					parent.Renamed -= OnParentFolderRenamed;
				}
				parent = value;
				if (parent != null)
				{
					parent.Renamed += OnParentFolderRenamed;
				}
			}
		}
	}

	public FolderAttributes Attributes { get; protected internal set; }

	public AnnotationAccess AnnotationAccess { get; protected internal set; }

	public AnnotationScope AnnotationScopes { get; protected internal set; }

	public uint MaxAnnotationSize { get; protected internal set; }

	public MessageFlags PermanentFlags { get; protected set; }

	public MessageFlags AcceptedFlags { get; protected set; }

	public char DirectorySeparator { get; protected set; }

	public FolderAccess Access { get; protected internal set; }

	public bool IsNamespace { get; protected set; }

	public string FullName { get; protected set; }

	public string Name { get; protected set; }

	public string Id { get; protected set; }

	public bool IsSubscribed => (Attributes & FolderAttributes.Subscribed) != 0;

	public abstract bool IsOpen { get; }

	public bool Exists => (Attributes & FolderAttributes.NonExistent) == 0;

	[Obsolete("Use Supports (FolderFeature.ModSequences) instead.")]
	public bool SupportsModSeq => Supports(FolderFeature.ModSequences);

	public ulong HighestModSeq { get; protected set; }

	public uint UidValidity { get; protected set; }

	public UniqueId? UidNext { get; protected set; }

	public uint? AppendLimit { get; protected set; }

	public ulong? Size { get; protected set; }

	public int FirstUnread { get; protected set; }

	public int Unread { get; protected set; }

	public int Recent { get; protected set; }

	public int Count { get; protected set; }

	public abstract HashSet<ThreadingAlgorithm> ThreadingAlgorithms { get; }

	public event EventHandler<EventArgs> Opened;

	public event EventHandler<EventArgs> Closed;

	public event EventHandler<EventArgs> Deleted;

	public event EventHandler<FolderRenamedEventArgs> Renamed;

	public event EventHandler<EventArgs> Subscribed;

	public event EventHandler<EventArgs> Unsubscribed;

	public event EventHandler<MessageEventArgs> MessageExpunged;

	public event EventHandler<MessagesVanishedEventArgs> MessagesVanished;

	public event EventHandler<MessageFlagsChangedEventArgs> MessageFlagsChanged;

	public event EventHandler<MessageLabelsChangedEventArgs> MessageLabelsChanged;

	public event EventHandler<AnnotationsChangedEventArgs> AnnotationsChanged;

	public event EventHandler<MessageSummaryFetchedEventArgs> MessageSummaryFetched;

	public event EventHandler<MetadataChangedEventArgs> MetadataChanged;

	public event EventHandler<ModSeqChangedEventArgs> ModSeqChanged;

	public event EventHandler<EventArgs> HighestModSeqChanged;

	public event EventHandler<EventArgs> UidNextChanged;

	public event EventHandler<EventArgs> UidValidityChanged;

	public event EventHandler<EventArgs> IdChanged;

	public event EventHandler<EventArgs> SizeChanged;

	public event EventHandler<EventArgs> CountChanged;

	public event EventHandler<EventArgs> RecentChanged;

	public event EventHandler<EventArgs> UnreadChanged;

	public abstract bool Supports(FolderFeature feature);

	public abstract FolderAccess Open(FolderAccess access, uint uidValidity, ulong highestModSeq, IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<FolderAccess> OpenAsync(FolderAccess access, uint uidValidity, ulong highestModSeq, IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	public abstract FolderAccess Open(FolderAccess access, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<FolderAccess> OpenAsync(FolderAccess access, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Close(bool expunge = false, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task CloseAsync(bool expunge = false, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IMailFolder Create(string name, bool isMessageFolder, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IMailFolder> CreateAsync(string name, bool isMessageFolder, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IMailFolder Create(string name, IEnumerable<SpecialFolder> specialUses, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IMailFolder> CreateAsync(string name, IEnumerable<SpecialFolder> specialUses, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IMailFolder Create(string name, SpecialFolder specialUse, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Create(name, new SpecialFolder[1] { specialUse }, cancellationToken);
	}

	public virtual Task<IMailFolder> CreateAsync(string name, SpecialFolder specialUse, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CreateAsync(name, new SpecialFolder[1] { specialUse }, cancellationToken);
	}

	public abstract void Rename(IMailFolder parent, string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RenameAsync(IMailFolder parent, string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Delete(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Subscribe(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task SubscribeAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Unsubscribe(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task UnsubscribeAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMailFolder> GetSubfolders(StatusItems items, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMailFolder>> GetSubfoldersAsync(StatusItems items, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<IMailFolder> GetSubfolders(bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetSubfolders(StatusItems.None, subscribedOnly, cancellationToken);
	}

	public virtual Task<IList<IMailFolder>> GetSubfoldersAsync(bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetSubfoldersAsync(StatusItems.None, subscribedOnly, cancellationToken);
	}

	public abstract IMailFolder GetSubfolder(string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IMailFolder> GetSubfolderAsync(string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Check(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task CheckAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Status(StatusItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task StatusAsync(StatusItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract AccessControlList GetAccessControlList(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<AccessControlList> GetAccessControlListAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract AccessRights GetAccessRights(string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<AccessRights> GetAccessRightsAsync(string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract AccessRights GetMyAccessRights(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<AccessRights> GetMyAccessRightsAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract void AddAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task AddAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void RemoveAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RemoveAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void SetAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task SetAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void RemoveAccess(string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RemoveAccessAsync(string name, CancellationToken cancellationToken = default(CancellationToken));

	public abstract FolderQuota GetQuota(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<FolderQuota> GetQuotaAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract FolderQuota SetQuota(uint? messageLimit, uint? storageLimit, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<FolderQuota> SetQuotaAsync(uint? messageLimit, uint? storageLimit, CancellationToken cancellationToken = default(CancellationToken));

	public abstract string GetMetadata(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<string> GetMetadataAsync(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	public MetadataCollection GetMetadata(IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadata(new MetadataOptions(), tags, cancellationToken);
	}

	public virtual Task<MetadataCollection> GetMetadataAsync(IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(new MetadataOptions(), tags, cancellationToken);
	}

	public abstract MetadataCollection GetMetadata(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<MetadataCollection> GetMetadataAsync(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void SetMetadata(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task SetMetadataAsync(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Expunge(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task ExpungeAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Expunge(IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task ExpungeAsync(IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken));

	public virtual UniqueId? Append(MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Append(FormatOptions.Default, message, flags, cancellationToken, progress);
	}

	public virtual Task<UniqueId?> AppendAsync(MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(FormatOptions.Default, message, flags, cancellationToken, progress);
	}

	public virtual UniqueId? Append(MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Append(FormatOptions.Default, message, flags, date, cancellationToken, progress);
	}

	public virtual Task<UniqueId?> AppendAsync(MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(FormatOptions.Default, message, flags, date, cancellationToken, progress);
	}

	public virtual UniqueId? Append(MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Append(FormatOptions.Default, message, flags, date, annotations, cancellationToken, progress);
	}

	public virtual Task<UniqueId?> AppendAsync(MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(FormatOptions.Default, message, flags, date, annotations, cancellationToken, progress);
	}

	public abstract UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public virtual IList<UniqueId> Append(IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Append(FormatOptions.Default, messages, flags, cancellationToken, progress);
	}

	public virtual Task<IList<UniqueId>> AppendAsync(IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(FormatOptions.Default, messages, flags, cancellationToken, progress);
	}

	public virtual IList<UniqueId> Append(IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Append(FormatOptions.Default, messages, flags, dates, cancellationToken, progress);
	}

	public virtual Task<IList<UniqueId>> AppendAsync(IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(FormatOptions.Default, messages, flags, dates, cancellationToken, progress);
	}

	public abstract IList<UniqueId> Append(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract IList<UniqueId> Append(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public virtual UniqueId? Replace(UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Replace(FormatOptions.Default, uid, message, flags, cancellationToken, progress);
	}

	public virtual Task<UniqueId?> ReplaceAsync(UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(FormatOptions.Default, uid, message, flags, cancellationToken, progress);
	}

	public virtual UniqueId? Replace(UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Replace(FormatOptions.Default, uid, message, flags, date, cancellationToken, progress);
	}

	public virtual Task<UniqueId?> ReplaceAsync(UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(FormatOptions.Default, uid, message, flags, date, cancellationToken, progress);
	}

	public abstract UniqueId? Replace(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<UniqueId?> ReplaceAsync(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract UniqueId? Replace(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<UniqueId?> ReplaceAsync(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public virtual UniqueId? Replace(int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Replace(FormatOptions.Default, index, message, flags, cancellationToken, progress);
	}

	public virtual Task<UniqueId?> ReplaceAsync(int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(FormatOptions.Default, index, message, flags, cancellationToken, progress);
	}

	public virtual UniqueId? Replace(int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return Replace(FormatOptions.Default, index, message, flags, date, cancellationToken, progress);
	}

	public virtual Task<UniqueId?> ReplaceAsync(int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(FormatOptions.Default, index, message, flags, date, cancellationToken, progress);
	}

	public abstract UniqueId? Replace(FormatOptions options, int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<UniqueId?> ReplaceAsync(FormatOptions options, int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract UniqueId? Replace(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<UniqueId?> ReplaceAsync(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public virtual UniqueId? CopyTo(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		UniqueIdMap uniqueIdMap = CopyTo(new UniqueId[1] { uid }, destination, cancellationToken);
		if (uniqueIdMap != null && uniqueIdMap.Destination.Count > 0)
		{
			return uniqueIdMap.Destination[0];
		}
		return null;
	}

	public virtual async Task<UniqueId?> CopyToAsync(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		UniqueIdMap uniqueIdMap = await CopyToAsync(new UniqueId[1] { uid }, destination, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (uniqueIdMap != null && uniqueIdMap.Destination.Count > 0)
		{
			return uniqueIdMap.Destination[0];
		}
		return null;
	}

	public abstract UniqueIdMap CopyTo(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<UniqueIdMap> CopyToAsync(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public virtual UniqueId? MoveTo(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		UniqueIdMap uniqueIdMap = MoveTo(new UniqueId[1] { uid }, destination, cancellationToken);
		if (uniqueIdMap != null && uniqueIdMap.Destination.Count > 0)
		{
			return uniqueIdMap.Destination[0];
		}
		return null;
	}

	public virtual async Task<UniqueId?> MoveToAsync(UniqueId uid, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		UniqueIdMap uniqueIdMap = await MoveToAsync(new UniqueId[1] { uid }, destination, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (uniqueIdMap != null && uniqueIdMap.Destination.Count > 0)
		{
			return uniqueIdMap.Destination[0];
		}
		return null;
	}

	public abstract UniqueIdMap MoveTo(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<UniqueIdMap> MoveToAsync(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void CopyTo(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		CopyTo(new int[1] { index }, destination, cancellationToken);
	}

	public virtual Task CopyToAsync(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		return CopyToAsync(new int[1] { index }, destination, cancellationToken);
	}

	public abstract void CopyTo(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task CopyToAsync(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void MoveTo(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		MoveTo(new int[1] { index }, destination, cancellationToken);
	}

	public virtual Task MoveToAsync(int index, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		return MoveToAsync(new int[1] { index }, destination, cancellationToken);
	}

	public abstract void MoveTo(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task MoveToAsync(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken));

	public abstract HeaderList GetHeaders(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<HeaderList> GetHeadersAsync(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract HeaderList GetHeaders(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<HeaderList> GetHeadersAsync(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract HeaderList GetHeaders(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<HeaderList> GetHeadersAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract HeaderList GetHeaders(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<HeaderList> GetHeadersAsync(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract MimeMessage GetMessage(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<MimeMessage> GetMessageAsync(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract MimeMessage GetMessage(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<MimeMessage> GetMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract MimeEntity GetBodyPart(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<MimeEntity> GetBodyPartAsync(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract MimeEntity GetBodyPart(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<MimeEntity> GetBodyPartAsync(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Stream GetStream(UniqueId uid, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<Stream> GetStreamAsync(UniqueId uid, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Stream GetStream(int index, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<Stream> GetStreamAsync(int index, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public virtual Stream GetStream(UniqueId uid, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (uid.Id == 0)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		return GetStream(uid, part.PartSpecifier, offset, count, cancellationToken, progress);
	}

	public virtual Task<Stream> GetStreamAsync(UniqueId uid, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		return GetStreamAsync(uid, part.PartSpecifier, offset, count, cancellationToken, progress);
	}

	public virtual Stream GetStream(int index, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		return GetStream(index, part.PartSpecifier, offset, count, cancellationToken, progress);
	}

	public virtual Task<Stream> GetStreamAsync(int index, BodyPart part, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		return GetStreamAsync(index, part.PartSpecifier, offset, count, cancellationToken, progress);
	}

	public abstract Stream GetStream(UniqueId uid, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<Stream> GetStreamAsync(UniqueId uid, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Stream GetStream(UniqueId uid, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<Stream> GetStreamAsync(UniqueId uid, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Stream GetStream(int index, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<Stream> GetStreamAsync(int index, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Stream GetStream(int index, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<Stream> GetStreamAsync(int index, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public virtual void AddFlags(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddFlags(new UniqueId[1] { uid }, flags, silent, cancellationToken);
	}

	public virtual Task AddFlagsAsync(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(new UniqueId[1] { uid }, flags, silent, cancellationToken);
	}

	public virtual void AddFlags(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddFlags(new UniqueId[1] { uid }, flags, keywords, silent, cancellationToken);
	}

	public virtual Task AddFlagsAsync(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(new UniqueId[1] { uid }, flags, keywords, silent, cancellationToken);
	}

	public virtual void AddFlags(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddFlags(uids, flags, null, silent, cancellationToken);
	}

	public virtual Task AddFlagsAsync(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(uids, flags, null, silent, cancellationToken);
	}

	public abstract void AddFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task AddFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void RemoveFlags(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveFlags(new UniqueId[1] { uid }, flags, silent, cancellationToken);
	}

	public virtual Task RemoveFlagsAsync(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(new UniqueId[1] { uid }, flags, silent, cancellationToken);
	}

	public virtual void RemoveFlags(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveFlags(new UniqueId[1] { uid }, flags, keywords, silent, cancellationToken);
	}

	public virtual Task RemoveFlagsAsync(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(new UniqueId[1] { uid }, flags, keywords, silent, cancellationToken);
	}

	public virtual void RemoveFlags(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveFlags(uids, flags, null, silent, cancellationToken);
	}

	public virtual Task RemoveFlagsAsync(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(uids, flags, null, silent, cancellationToken);
	}

	public abstract void RemoveFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RemoveFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void SetFlags(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetFlags(new UniqueId[1] { uid }, flags, silent, cancellationToken);
	}

	public virtual Task SetFlagsAsync(UniqueId uid, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(new UniqueId[1] { uid }, flags, silent, cancellationToken);
	}

	public virtual void SetFlags(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetFlags(new UniqueId[1] { uid }, flags, keywords, silent, cancellationToken);
	}

	public virtual Task SetFlagsAsync(UniqueId uid, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(new UniqueId[1] { uid }, flags, keywords, silent, cancellationToken);
	}

	public virtual void SetFlags(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetFlags(uids, flags, null, silent, cancellationToken);
	}

	public virtual Task SetFlagsAsync(IList<UniqueId> uids, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(uids, flags, null, silent, cancellationToken);
	}

	public abstract void SetFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task SetFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<UniqueId> AddFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlags(uids, modseq, flags, null, silent, cancellationToken);
	}

	public virtual Task<IList<UniqueId>> AddFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(uids, modseq, flags, null, silent, cancellationToken);
	}

	public abstract IList<UniqueId> AddFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> AddFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<UniqueId> RemoveFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlags(uids, modseq, flags, null, silent, cancellationToken);
	}

	public virtual Task<IList<UniqueId>> RemoveFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(uids, modseq, flags, null, silent, cancellationToken);
	}

	public abstract IList<UniqueId> RemoveFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> RemoveFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<UniqueId> SetFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlags(uids, modseq, flags, null, silent, cancellationToken);
	}

	public virtual Task<IList<UniqueId>> SetFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(uids, modseq, flags, null, silent, cancellationToken);
	}

	public abstract IList<UniqueId> SetFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> SetFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void AddFlags(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddFlags(new int[1] { index }, flags, silent, cancellationToken);
	}

	public virtual Task AddFlagsAsync(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(new int[1] { index }, flags, silent, cancellationToken);
	}

	public virtual void AddFlags(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddFlags(new int[1] { index }, flags, keywords, silent, cancellationToken);
	}

	public virtual Task AddFlagsAsync(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(new int[1] { index }, flags, keywords, silent, cancellationToken);
	}

	public virtual void AddFlags(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddFlags(indexes, flags, null, silent, cancellationToken);
	}

	public virtual Task AddFlagsAsync(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(indexes, flags, null, silent, cancellationToken);
	}

	public abstract void AddFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task AddFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void RemoveFlags(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveFlags(new int[1] { index }, flags, silent, cancellationToken);
	}

	public virtual Task RemoveFlagsAsync(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(new int[1] { index }, flags, silent, cancellationToken);
	}

	public virtual void RemoveFlags(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveFlags(new int[1] { index }, flags, keywords, silent, cancellationToken);
	}

	public virtual Task RemoveFlagsAsync(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(new int[1] { index }, flags, keywords, silent, cancellationToken);
	}

	public virtual void RemoveFlags(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveFlags(indexes, flags, null, silent, cancellationToken);
	}

	public virtual Task RemoveFlagsAsync(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(indexes, flags, null, silent, cancellationToken);
	}

	public abstract void RemoveFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RemoveFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void SetFlags(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetFlags(new int[1] { index }, flags, silent, cancellationToken);
	}

	public virtual Task SetFlagsAsync(int index, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(new int[1] { index }, flags, silent, cancellationToken);
	}

	public virtual void SetFlags(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetFlags(new int[1] { index }, flags, keywords, silent, cancellationToken);
	}

	public virtual Task SetFlagsAsync(int index, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(new int[1] { index }, flags, keywords, silent, cancellationToken);
	}

	public virtual void SetFlags(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetFlags(indexes, flags, null, silent, cancellationToken);
	}

	public virtual Task SetFlagsAsync(IList<int> indexes, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(indexes, flags, null, silent, cancellationToken);
	}

	public abstract void SetFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task SetFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<int> AddFlags(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlags(indexes, modseq, flags, null, silent, cancellationToken);
	}

	public virtual Task<IList<int>> AddFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddFlagsAsync(indexes, modseq, flags, null, silent, cancellationToken);
	}

	public abstract IList<int> AddFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> AddFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<int> RemoveFlags(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlags(indexes, modseq, flags, null, silent, cancellationToken);
	}

	public virtual Task<IList<int>> RemoveFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveFlagsAsync(indexes, modseq, flags, null, silent, cancellationToken);
	}

	public abstract IList<int> RemoveFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> RemoveFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<int> SetFlags(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlags(indexes, modseq, flags, null, silent, cancellationToken);
	}

	public virtual Task<IList<int>> SetFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetFlagsAsync(indexes, modseq, flags, null, silent, cancellationToken);
	}

	public abstract IList<int> SetFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> SetFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void AddLabels(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddLabels(new UniqueId[1] { uid }, labels, silent, cancellationToken);
	}

	public virtual Task AddLabelsAsync(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddLabelsAsync(new UniqueId[1] { uid }, labels, silent, cancellationToken);
	}

	public abstract void AddLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task AddLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void RemoveLabels(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveLabels(new UniqueId[1] { uid }, labels, silent, cancellationToken);
	}

	public virtual Task RemoveLabelsAsync(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveLabelsAsync(new UniqueId[1] { uid }, labels, silent, cancellationToken);
	}

	public abstract void RemoveLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RemoveLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void SetLabels(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetLabels(new UniqueId[1] { uid }, labels, silent, cancellationToken);
	}

	public virtual Task SetLabelsAsync(UniqueId uid, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetLabelsAsync(new UniqueId[1] { uid }, labels, silent, cancellationToken);
	}

	public abstract void SetLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task SetLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<UniqueId> AddLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> AddLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<UniqueId> RemoveLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> RemoveLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<UniqueId> SetLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> SetLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void AddLabels(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		AddLabels(new int[1] { index }, labels, silent, cancellationToken);
	}

	public virtual Task AddLabelsAsync(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return AddLabelsAsync(new int[1] { index }, labels, silent, cancellationToken);
	}

	public abstract void AddLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task AddLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void RemoveLabels(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveLabels(new int[1] { index }, labels, silent, cancellationToken);
	}

	public virtual Task RemoveLabelsAsync(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveLabelsAsync(new int[1] { index }, labels, silent, cancellationToken);
	}

	public abstract void RemoveLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task RemoveLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void SetLabels(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetLabels(new int[1] { index }, labels, silent, cancellationToken);
	}

	public virtual Task SetLabelsAsync(int index, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetLabelsAsync(new int[1] { index }, labels, silent, cancellationToken);
	}

	public abstract void SetLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task SetLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<int> AddLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> AddLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<int> RemoveLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> RemoveLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<int> SetLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> SetLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void Store(UniqueId uid, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		Store(new UniqueId[1] { uid }, annotations, cancellationToken);
	}

	public virtual Task StoreAsync(UniqueId uid, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(new UniqueId[1] { uid }, annotations, cancellationToken);
	}

	public abstract void Store(IList<UniqueId> uids, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task StoreAsync(IList<UniqueId> uids, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<UniqueId> Store(IList<UniqueId> uids, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> StoreAsync(IList<UniqueId> uids, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public virtual void Store(int index, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		Store(new int[1] { index }, annotations, cancellationToken);
	}

	public virtual Task StoreAsync(int index, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(new int[1] { index }, annotations, cancellationToken);
	}

	public abstract void Store(IList<int> indexes, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task StoreAsync(IList<int> indexes, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<int> Store(IList<int> indexes, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> StoreAsync(IList<int> indexes, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<UniqueId> Search(SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	public virtual Task<IList<UniqueId>> SearchAsync(SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return Task.Factory.StartNew(delegate
		{
			lock (SyncRoot)
			{
				return Search(query, cancellationToken);
			}
		}, cancellationToken, TaskCreationOptions.None, TaskScheduler.Default);
	}

	public virtual IList<UniqueId> Search(IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return Search(uidSearchQuery.And(query), cancellationToken);
	}

	public virtual Task<IList<UniqueId>> SearchAsync(IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return SearchAsync(uidSearchQuery.And(query), cancellationToken);
	}

	public abstract SearchResults Search(SearchOptions options, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<SearchResults> SearchAsync(SearchOptions options, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	public virtual SearchResults Search(SearchOptions options, IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return Search(options, uidSearchQuery.And(query), cancellationToken);
	}

	public virtual Task<SearchResults> SearchAsync(SearchOptions options, IList<UniqueId> uids, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return SearchAsync(options, uidSearchQuery.And(query), cancellationToken);
	}

	public abstract IList<UniqueId> Sort(SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<UniqueId>> SortAsync(SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	public virtual IList<UniqueId> Sort(IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return Sort(uidSearchQuery.And(query), orderBy, cancellationToken);
	}

	public virtual Task<IList<UniqueId>> SortAsync(IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return SortAsync(uidSearchQuery.And(query), orderBy, cancellationToken);
	}

	public abstract SearchResults Sort(SearchOptions options, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<SearchResults> SortAsync(SearchOptions options, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken));

	public virtual SearchResults Sort(SearchOptions options, IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return Sort(options, uidSearchQuery.And(query), orderBy, cancellationToken);
	}

	public virtual Task<SearchResults> SortAsync(SearchOptions options, IList<UniqueId> uids, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		UidSearchQuery uidSearchQuery = new UidSearchQuery(uids);
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		return SortAsync(options, uidSearchQuery.And(query), orderBy, cancellationToken);
	}

	public abstract IList<MessageThread> Thread(ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<MessageThread>> ThreadAsync(ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<MessageThread> Thread(IList<UniqueId> uids, ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<MessageThread>> ThreadAsync(IList<UniqueId> uids, ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken));

	protected virtual void OnOpened()
	{
		this.Opened?.Invoke(this, EventArgs.Empty);
	}

	protected internal virtual void OnClosed()
	{
		PermanentFlags = MessageFlags.None;
		AcceptedFlags = MessageFlags.None;
		Access = FolderAccess.None;
		AnnotationAccess = AnnotationAccess.None;
		AnnotationScopes = AnnotationScope.None;
		MaxAnnotationSize = 0u;
		this.Closed?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnDeleted()
	{
		this.Deleted?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnRenamed(string oldName, string newName)
	{
		this.Renamed?.Invoke(this, new FolderRenamedEventArgs(oldName, newName));
	}

	protected virtual void OnParentFolderRenamed()
	{
	}

	private void OnParentFolderRenamed(object sender, FolderRenamedEventArgs e)
	{
		string fullName = FullName;
		OnParentFolderRenamed();
		if (FullName != fullName)
		{
			OnRenamed(fullName, FullName);
		}
	}

	protected virtual void OnSubscribed()
	{
		this.Subscribed?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnUnsubscribed()
	{
		this.Unsubscribed?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnMessageExpunged(MessageEventArgs args)
	{
		this.MessageExpunged?.Invoke(this, args);
	}

	protected virtual void OnMessagesVanished(MessagesVanishedEventArgs args)
	{
		this.MessagesVanished?.Invoke(this, args);
	}

	protected virtual void OnMessageFlagsChanged(MessageFlagsChangedEventArgs args)
	{
		this.MessageFlagsChanged?.Invoke(this, args);
	}

	protected virtual void OnMessageLabelsChanged(MessageLabelsChangedEventArgs args)
	{
		this.MessageLabelsChanged?.Invoke(this, args);
	}

	protected virtual void OnAnnotationsChanged(AnnotationsChangedEventArgs args)
	{
		this.AnnotationsChanged?.Invoke(this, args);
	}

	protected virtual void OnMessageSummaryFetched(IMessageSummary message)
	{
		this.MessageSummaryFetched?.Invoke(this, new MessageSummaryFetchedEventArgs(message));
	}

	protected internal virtual void OnMetadataChanged(Metadata metadata)
	{
		this.MetadataChanged?.Invoke(this, new MetadataChangedEventArgs(metadata));
	}

	protected virtual void OnModSeqChanged(ModSeqChangedEventArgs args)
	{
		this.ModSeqChanged?.Invoke(this, args);
	}

	protected virtual void OnHighestModSeqChanged()
	{
		this.HighestModSeqChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnUidNextChanged()
	{
		this.UidNextChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnUidValidityChanged()
	{
		this.UidValidityChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnIdChanged()
	{
		this.IdChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnSizeChanged()
	{
		this.SizeChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnCountChanged()
	{
		this.CountChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnRecentChanged()
	{
		this.RecentChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnUnreadChanged()
	{
		this.UnreadChanged?.Invoke(this, EventArgs.Empty);
	}

	public abstract IEnumerator<MimeMessage> GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public override string ToString()
	{
		return FullName;
	}
}
