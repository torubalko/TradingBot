using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Search;
using MimeKit;

namespace MailKit.Net.Imap;

public interface IImapFolder : IMailFolder, IEnumerable<MimeMessage>, IEnumerable
{
	HeaderList GetHeaders(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<HeaderList> GetHeadersAsync(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	HeaderList GetHeaders(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<HeaderList> GetHeadersAsync(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	MimeEntity GetBodyPart(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<MimeEntity> GetBodyPartAsync(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	MimeEntity GetBodyPart(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<MimeEntity> GetBodyPartAsync(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void GetStreams(IList<UniqueId> uids, ImapFetchStreamCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task GetStreamsAsync(IList<UniqueId> uids, ImapFetchStreamAsyncCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void GetStreams(IList<int> indexes, ImapFetchStreamCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task GetStreamsAsync(IList<int> indexes, ImapFetchStreamAsyncCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void GetStreams(int min, int max, ImapFetchStreamCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task GetStreamsAsync(int min, int max, ImapFetchStreamAsyncCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	SearchResults Search(string query, CancellationToken cancellationToken = default(CancellationToken));

	Task<SearchResults> SearchAsync(string query, CancellationToken cancellationToken = default(CancellationToken));

	SearchResults Sort(string query, CancellationToken cancellationToken = default(CancellationToken));

	Task<SearchResults> SortAsync(string query, CancellationToken cancellationToken = default(CancellationToken));
}
