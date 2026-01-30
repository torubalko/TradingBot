using System;
using System.Security.Cryptography.X509Certificates;

namespace MailKit.Security;

internal sealed class SslChainElement : IDisposable
{
	public readonly X509Certificate2 Certificate;

	public readonly X509ChainStatus[] ChainElementStatus;

	public readonly string Information;

	public SslChainElement(X509ChainElement element)
	{
		Certificate = new X509Certificate2(element.Certificate.RawData);
		ChainElementStatus = element.ChainElementStatus;
		Information = element.Information;
	}

	public void Dispose()
	{
		Certificate.Dispose();
	}
}
