using System;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

namespace MailKit.Net.Smtp;

public interface ISmtpClient : IMailTransport, IMailService, IDisposable
{
	SmtpCapabilities Capabilities { get; }

	string LocalDomain { get; set; }

	uint MaxSize { get; }

	DeliveryStatusNotificationType DeliveryStatusNotificationType { get; set; }

	InternetAddressList Expand(string alias, CancellationToken cancellationToken = default(CancellationToken));

	Task<InternetAddressList> ExpandAsync(string alias, CancellationToken cancellationToken = default(CancellationToken));

	MailboxAddress Verify(string address, CancellationToken cancellationToken = default(CancellationToken));

	Task<MailboxAddress> VerifyAsync(string address, CancellationToken cancellationToken = default(CancellationToken));
}
