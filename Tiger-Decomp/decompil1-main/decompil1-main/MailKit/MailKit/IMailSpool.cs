using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

namespace MailKit;

public interface IMailSpool : IMailService, IDisposable, IEnumerable<MimeMessage>, IEnumerable
{
	int Count { get; }

	bool SupportsUids { get; }

	int GetMessageCount(CancellationToken cancellationToken = default(CancellationToken));

	Task<int> GetMessageCountAsync(CancellationToken cancellationToken = default(CancellationToken));

	string GetMessageUid(int index, CancellationToken cancellationToken = default(CancellationToken));

	Task<string> GetMessageUidAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	IList<string> GetMessageUids(CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<string>> GetMessageUidsAsync(CancellationToken cancellationToken = default(CancellationToken));

	int GetMessageSize(int index, CancellationToken cancellationToken = default(CancellationToken));

	Task<int> GetMessageSizeAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	IList<int> GetMessageSizes(CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<int>> GetMessageSizesAsync(CancellationToken cancellationToken = default(CancellationToken));

	HeaderList GetMessageHeaders(int index, CancellationToken cancellationToken = default(CancellationToken));

	Task<HeaderList> GetMessageHeadersAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	IList<HeaderList> GetMessageHeaders(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<HeaderList>> GetMessageHeadersAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	IList<HeaderList> GetMessageHeaders(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<HeaderList>> GetMessageHeadersAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	MimeMessage GetMessage(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<MimeMessage> GetMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<MimeMessage> GetMessages(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<MimeMessage>> GetMessagesAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<MimeMessage> GetMessages(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<MimeMessage>> GetMessagesAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Stream GetStream(int index, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<Stream> GetStreamAsync(int index, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<Stream> GetStreams(IList<int> indexes, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<Stream>> GetStreamsAsync(IList<int> indexes, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	IList<Stream> GetStreams(int startIndex, int count, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task<IList<Stream>> GetStreamsAsync(int startIndex, int count, bool headersOnly = false, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void DeleteMessage(int index, CancellationToken cancellationToken = default(CancellationToken));

	Task DeleteMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken));

	void DeleteMessages(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	Task DeleteMessagesAsync(IList<int> indexes, CancellationToken cancellationToken = default(CancellationToken));

	void DeleteMessages(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	Task DeleteMessagesAsync(int startIndex, int count, CancellationToken cancellationToken = default(CancellationToken));

	void DeleteAllMessages(CancellationToken cancellationToken = default(CancellationToken));

	Task DeleteAllMessagesAsync(CancellationToken cancellationToken = default(CancellationToken));

	void Reset(CancellationToken cancellationToken = default(CancellationToken));

	Task ResetAsync(CancellationToken cancellationToken = default(CancellationToken));
}
