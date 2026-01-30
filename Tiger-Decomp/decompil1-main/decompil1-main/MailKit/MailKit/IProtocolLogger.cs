using System;

namespace MailKit;

public interface IProtocolLogger : IDisposable
{
	IAuthenticationSecretDetector AuthenticationSecretDetector { get; set; }

	void LogConnect(Uri uri);

	void LogClient(byte[] buffer, int offset, int count);

	void LogServer(byte[] buffer, int offset, int count);
}
