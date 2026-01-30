using System;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class X509CrlRecord
{
	public int Id { get; internal set; }

	public bool IsDelta { get; internal set; }

	public string IssuerName { get; internal set; }

	public DateTime ThisUpdate { get; internal set; }

	public DateTime NextUpdate { get; internal set; }

	public X509Crl Crl { get; set; }

	public X509CrlRecord(X509Crl crl)
	{
		if (crl == null)
		{
			throw new ArgumentNullException("crl");
		}
		if (crl.NextUpdate != null)
		{
			NextUpdate = crl.NextUpdate.Value.ToUniversalTime();
		}
		IssuerName = crl.IssuerDN.ToString();
		ThisUpdate = crl.ThisUpdate.ToUniversalTime();
		IsDelta = crl.IsDelta();
		Crl = crl;
	}

	public X509CrlRecord()
	{
	}
}
