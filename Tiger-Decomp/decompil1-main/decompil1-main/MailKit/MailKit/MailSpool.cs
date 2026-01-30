using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

namespace MailKit;

public abstract class MailSpool : MailService, IMailSpool, IMailService, IDisposable, IEnumerable<MimeMessage>, IEnumerable
{
	public abstract int Count { get; }

	public abstract bool SupportsUids { get; }

	protected MailSpool(IProtocolLogger protocolLogger)
		: base(protocolLogger)
	{
	}

	public abstract int GetMessageCount(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<int> GetMessageCountAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract string GetMessageUid(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<string> GetMessageUidAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<string> GetMessageUids(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<string>> GetMessageUidsAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract int GetMessageSize(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<int> GetMessageSizeAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<int> GetMessageSizes(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<int>> GetMessageSizesAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract HeaderList GetMessageHeaders(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<HeaderList> GetMessageHeadersAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<HeaderList> GetMessageHeaders(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<HeaderList>> GetMessageHeadersAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	public abstract IList<HeaderList> GetMessageHeaders(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<IList<HeaderList>> GetMessageHeadersAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	public abstract MimeMessage GetMessage(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<MimeMessage> GetMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract IList<MimeMessage> GetMessages(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<IList<MimeMessage>> GetMessagesAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract IList<MimeMessage> GetMessages(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<IList<MimeMessage>> GetMessagesAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Stream GetStream(int index, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<Stream> GetStreamAsync(int index, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract IList<Stream> GetStreams(IList<int> indexes, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<IList<Stream>> GetStreamsAsync(IList<int> indexes, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract IList<Stream> GetStreams(int startIndex, int count, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task<IList<Stream>> GetStreamsAsync(int startIndex, int count, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract void DeleteMessage(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task DeleteMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void DeleteMessages(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task DeleteMessagesAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void DeleteMessages(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task DeleteMessagesAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void DeleteAllMessages(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task DeleteAllMessagesAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Reset(CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task ResetAsync(CancellationToken cancellationToken = default(CancellationToken));

	public abstract IEnumerator<MimeMessage> GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
