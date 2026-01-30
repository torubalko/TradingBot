using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit;

public interface IMailStore : IMailService, IDisposable
{
	FolderNamespaceCollection PersonalNamespaces { get; }

	FolderNamespaceCollection SharedNamespaces { get; }

	FolderNamespaceCollection OtherNamespaces { get; }

	bool SupportsQuotas { get; }

	HashSet<ThreadingAlgorithm> ThreadingAlgorithms { get; }

	IMailFolder Inbox { get; }

	event EventHandler<AlertEventArgs> Alert;

	event EventHandler<FolderCreatedEventArgs> FolderCreated;

	event EventHandler<MetadataChangedEventArgs> MetadataChanged;

	void EnableQuickResync(CancellationToken cancellationToken = default(CancellationToken));

	Task EnableQuickResyncAsync(CancellationToken cancellationToken = default(CancellationToken));

	IMailFolder GetFolder(SpecialFolder folder);

	IMailFolder GetFolder(FolderNamespace @namespace);

	IList<IMailFolder> GetFolders(FolderNamespace @namespace, bool subscribedOnly, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMailFolder>> GetFoldersAsync(FolderNamespace @namespace, bool subscribedOnly, CancellationToken cancellationToken = default(CancellationToken));

	IList<IMailFolder> GetFolders(FolderNamespace @namespace, StatusItems items = StatusItems.None, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<IMailFolder>> GetFoldersAsync(FolderNamespace @namespace, StatusItems items = StatusItems.None, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken));

	IMailFolder GetFolder(string path, CancellationToken cancellationToken = default(CancellationToken));

	Task<IMailFolder> GetFolderAsync(string path, CancellationToken cancellationToken = default(CancellationToken));

	string GetMetadata(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	Task<string> GetMetadataAsync(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken));

	MetadataCollection GetMetadata(IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	Task<MetadataCollection> GetMetadataAsync(IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	MetadataCollection GetMetadata(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	Task<MetadataCollection> GetMetadataAsync(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken));

	void SetMetadata(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken));

	Task SetMetadataAsync(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken));
}
