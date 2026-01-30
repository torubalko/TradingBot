using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

namespace MailKit;

public abstract class MailTransport : MailService, IMailTransport, IMailService, IDisposable
{
	private static readonly FormatOptions DefaultOptions;

	public event EventHandler<MessageSentEventArgs> MessageSent;

	static MailTransport()
	{
		FormatOptions formatOptions = FormatOptions.Default.Clone();
		formatOptions.HiddenHeaders.Add(HeaderId.ContentLength);
		formatOptions.HiddenHeaders.Add(HeaderId.ResentBcc);
		formatOptions.HiddenHeaders.Add(HeaderId.Bcc);
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		DefaultOptions = formatOptions;
	}

	protected MailTransport(IProtocolLogger protocolLogger)
		: base(protocolLogger)
	{
	}

	public virtual void Send(MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		Send(DefaultOptions, message, cancellationToken, progress);
	}

	public virtual Task SendAsync(MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return SendAsync(DefaultOptions, message, cancellationToken, progress);
	}

	public virtual void Send(MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		Send(DefaultOptions, message, sender, recipients, cancellationToken, progress);
	}

	public virtual Task SendAsync(MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return SendAsync(DefaultOptions, message, sender, recipients, cancellationToken, progress);
	}

	public abstract void Send(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task SendAsync(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract void Send(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	public abstract Task SendAsync(FormatOptions options, MimeMessage message, MailboxAddress sender, IEnumerable<MailboxAddress> recipients, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null);

	protected virtual void OnMessageSent(MessageSentEventArgs e)
	{
		this.MessageSent?.Invoke(this, e);
	}
}
