using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;

namespace Org.BouncyCastle.X509;

public class X509CertificatePair
{
	private readonly X509Certificate forward;

	private readonly X509Certificate reverse;

	public X509Certificate Forward => forward;

	public X509Certificate Reverse => reverse;

	public X509CertificatePair(X509Certificate forward, X509Certificate reverse)
	{
		this.forward = forward;
		this.reverse = reverse;
	}

	public X509CertificatePair(CertificatePair pair)
	{
		if (pair.Forward != null)
		{
			forward = new X509Certificate(pair.Forward);
		}
		if (pair.Reverse != null)
		{
			reverse = new X509Certificate(pair.Reverse);
		}
	}

	public byte[] GetEncoded()
	{
		try
		{
			X509CertificateStructure f = null;
			X509CertificateStructure r = null;
			if (forward != null)
			{
				f = X509CertificateStructure.GetInstance(Asn1Object.FromByteArray(forward.GetEncoded()));
				if (f == null)
				{
					throw new CertificateEncodingException("unable to get encoding for forward");
				}
			}
			if (reverse != null)
			{
				r = X509CertificateStructure.GetInstance(Asn1Object.FromByteArray(reverse.GetEncoded()));
				if (r == null)
				{
					throw new CertificateEncodingException("unable to get encoding for reverse");
				}
			}
			return new CertificatePair(f, r).GetDerEncoded();
		}
		catch (Exception ex)
		{
			throw new CertificateEncodingException(ex.Message, ex);
		}
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is X509CertificatePair other))
		{
			return false;
		}
		if (object.Equals(forward, other.forward))
		{
			return object.Equals(reverse, other.reverse);
		}
		return false;
	}

	public override int GetHashCode()
	{
		int hash = -1;
		if (forward != null)
		{
			hash ^= forward.GetHashCode();
		}
		if (reverse != null)
		{
			hash *= 17;
			hash ^= reverse.GetHashCode();
		}
		return hash;
	}
}
