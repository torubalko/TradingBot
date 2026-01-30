using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit;

public abstract class MailStore : MailService, IMailStore, IMailService, IDisposable
{
	public abstract FolderNamespaceCollection PersonalNamespaces { get; }

	public abstract FolderNamespaceCollection SharedNamespaces { get; }

	public abstract FolderNamespaceCollection OtherNamespaces { get; }

	public abstract bool SupportsQuotas { get; }

	public abstract HashSet<ThreadingAlgorithm> ThreadingAlgorithms { get; }

	public abstract IMailFolder Inbox { get; }

	public event EventHandler<AlertEventArgs> Alert;

	public event EventHandler<FolderCreatedEventArgs> FolderCreated;

	public event EventHandler<MetadataChangedEventArgs> MetadataChanged;

	protected MailStore(IProtocolLogger protocolLogger)
		: base(protocolLogger)
	{
	}

	public abstract void EnableQuickResync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task EnableQuickResyncAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract IMailFolder GetFolder(SpecialFolder folder);

	public abstract IMailFolder GetFolder(FolderNamespace @namespace);

	public virtual IList<IMailFolder> GetFolders(FolderNamespace @namespace, bool subscribedOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetFolders(@namespace, StatusItems.None, subscribedOnly, cancellationToken);
	}

	public virtual Task<IList<IMailFolder>> GetFoldersAsync(FolderNamespace @namespace, bool subscribedOnly, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetFoldersAsync(@namespace, StatusItems.None, subscribedOnly, cancellationToken);
	}

	public abstract IList<IMailFolder> GetFolders(FolderNamespace @namespace, StatusItems items = StatusItems.None, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<IMailFolder>> GetFoldersAsync(FolderNamespace @namespace, StatusItems items = StatusItems.None, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IMailFolder GetFolder(string path, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IMailFolder> GetFolderAsync(string path, CancellationToken cancellationToken = default(CancellationToken));

	public abstract string GetMetadata(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<string> GetMetadataAsync(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	public virtual MetadataCollection GetMetadata(IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken))
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

	protected virtual void OnAlert(string message)
	{
		this.Alert?.Invoke(this, new AlertEventArgs(message));
	}

	protected virtual void OnFolderCreated(IMailFolder folder)
	{
		this.FolderCreated?.Invoke(this, new FolderCreatedEventArgs(folder));
	}

	protected virtual void OnMetadataChanged(Metadata metadata)
	{
		this.MetadataChanged?.Invoke(this, new MetadataChangedEventArgs(metadata));
	}
}
