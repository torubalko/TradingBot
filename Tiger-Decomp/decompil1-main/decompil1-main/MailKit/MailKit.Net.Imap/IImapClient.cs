using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Imap;

public interface IImapClient : IMailStore, IMailService, IDisposable
{
	ImapCapabilities Capabilities { get; set; }

	uint? AppendLimit { get; }

	int InternationalizationLevel { get; }

	AccessRights Rights { get; }

	bool IsIdle { get; }

	void Compress(CancellationToken cancellationToken = default(CancellationToken));

	Task CompressAsync(CancellationToken cancellationToken = default(CancellationToken));

	void EnableUTF8(CancellationToken cancellationToken = default(CancellationToken));

	Task EnableUTF8Async(CancellationToken cancellationToken = default(CancellationToken));

	ImapImplementation Identify(ImapImplementation clientImplementation, CancellationToken cancellationToken = default(CancellationToken));

	Task<ImapImplementation> IdentifyAsync(ImapImplementation clientImplementation, CancellationToken cancellationToken = default(CancellationToken));

	void Idle(CancellationToken doneToken, CancellationToken cancellationToken = default(CancellationToken));

	Task IdleAsync(CancellationToken doneToken, CancellationToken cancellationToken = default(CancellationToken));

	void Notify(bool status, IList<ImapEventGroup> eventGroups, CancellationToken cancellationToken = default(CancellationToken));

	Task NotifyAsync(bool status, IList<ImapEventGroup> eventGroups, CancellationToken cancellationToken = default(CancellationToken));

	void DisableNotify(CancellationToken cancellationToken = default(CancellationToken));

	Task DisableNotifyAsync(CancellationToken cancellationToken = default(CancellationToken));
}
