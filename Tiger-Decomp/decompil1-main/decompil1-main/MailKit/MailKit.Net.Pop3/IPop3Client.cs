using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MimeKit;

namespace MailKit.Net.Pop3;

public interface IPop3Client : IMailSpool, IMailService, IDisposable, IEnumerable<MimeMessage>, IEnumerable
{
	Pop3Capabilities Capabilities { get; set; }

	int ExpirePolicy { get; }

	string Implementation { get; }

	int LoginDelay { get; }

	void EnableUTF8(CancellationToken cancellationToken = default(CancellationToken));

	Task EnableUTF8Async(CancellationToken cancellationToken = default(CancellationToken));

	IList<Pop3Language> GetLanguages(CancellationToken cancellationToken = default(CancellationToken));

	Task<IList<Pop3Language>> GetLanguagesAsync(CancellationToken cancellationToken = default(CancellationToken));

	void SetLanguage(string lang, CancellationToken cancellationToken = default(CancellationToken));

	Task SetLanguageAsync(string lang, CancellationToken cancellationToken = default(CancellationToken));
}
