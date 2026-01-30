using System;

namespace MailKit;

public sealed class NullProtocolLogger : IProtocolLogger, IDisposable
{
	public IAuthenticationSecretDetector AuthenticationSecretDetector { get; set; }

	public void LogConnect(Uri uri)
	{
	}

	public void LogClient(byte[] buffer, int offset, int count)
	{
	}

	public void LogServer(byte[] buffer, int offset, int count)
	{
	}

	public void Dispose()
	{
	}
}
