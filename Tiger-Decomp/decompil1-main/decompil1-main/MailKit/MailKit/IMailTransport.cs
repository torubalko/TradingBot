using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

namespace MailKit;

public interface IMailTransport : IMailService, IDisposable
{
	event EventHandler<MessageSentEventArgs> MessageSent;

	void Send(MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task SendAsync(MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void Send(MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task SendAsync(MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void Send(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task SendAsync(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	void Send(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	Task SendAsync(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);
}
