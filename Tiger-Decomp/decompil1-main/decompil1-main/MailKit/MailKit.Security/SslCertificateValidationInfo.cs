using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace MailKit.Security;

internal sealed class SslCertificateValidationInfo : IDisposable
{
	public readonly List<SslChainElement> ChainElements;

	public readonly X509ChainStatus[] ChainStatus;

	public readonly SslPolicyErrors SslPolicyErrors;

	public readonly X509Certificate2 Certificate;

	public readonly string Host;

	public SslCertificateValidationInfo(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		Certificate = new X509Certificate2(certificate.Export(X509ContentType.Cert));
		ChainElements = new List<SslChainElement>();
		SslPolicyErrors = sslPolicyErrors;
		ChainStatus = chain.ChainStatus;
		Host = sender as string;
		X509ChainElementEnumerator enumerator = chain.ChainElements.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509ChainElement current = enumerator.Current;
			ChainElements.Add(new SslChainElement(current));
		}
	}

	public void Dispose()
	{
		Certificate.Dispose();
		foreach (SslChainElement chainElement in ChainElements)
		{
			chainElement.Dispose();
		}
	}
}
