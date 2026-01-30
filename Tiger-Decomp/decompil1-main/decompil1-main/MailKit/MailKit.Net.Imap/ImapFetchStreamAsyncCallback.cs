using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Imap;

public delegate Task ImapFetchStreamAsyncCallback(ImapFolder folder, int index, UniqueId uid, Stream stream, CancellationToken cancellationToken);
