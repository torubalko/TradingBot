using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Utilities;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509;

public class X509Crl : X509ExtensionBase
{
	private class CachedEncoding
	{
		private readonly byte[] encoding;

		private readonly CrlException exception;

		internal byte[] Encoding => encoding;

		internal CachedEncoding(byte[] encoding, CrlException exception)
		{
			this.encoding = encoding;
			this.exception = exception;
		}

		internal byte[] GetEncoded()
		{
			if (exception != null)
			{
				throw exception;
			}
			if (encoding == null)
			{
				throw new CrlException();
			}
			return encoding;
		}
	}

	private readonly CertificateList c;

	private readonly string sigAlgName;

	private readonly byte[] sigAlgParams;

	private readonly bool isIndirect;

	private readonly object cacheLock = new object();

	private CachedEncoding cachedEncoding;

	private volatile bool hashValueSet;

	private volatile int hashValue;

	public virtual CertificateList CertificateList => c;

	public virtual int Version => c.Version;

	public virtual X509Name IssuerDN => c.Issuer;

	public virtual DateTime ThisUpdate => c.ThisUpdate.ToDateTime();

	public virtual DateTimeObject NextUpdate
	{
		get
		{
			if (c.NextUpdate != null)
			{
				return new DateTimeObject(c.NextUpdate.ToDateTime());
			}
			return null;
		}
	}

	public virtual string SigAlgName => sigAlgName;

	public virtual string SigAlgOid => c.SignatureAlgorithm.Algorithm.Id;

	protected virtual bool IsIndirectCrl
	{
		get
		{
			Asn1OctetString idp = GetExtensionValue(X509Extensions.IssuingDistributionPoint);
			bool isIndirect = false;
			try
			{
				if (idp != null)
				{
					isIndirect = IssuingDistributionPoint.GetInstance(X509ExtensionUtilities.FromExtensionValue(idp)).IsIndirectCrl;
				}
			}
			catch (Exception ex)
			{
				throw new CrlException("Exception reading IssuingDistributionPoint" + ex);
			}
			return isIndirect;
		}
	}

	public X509Crl(byte[] encoding)
		: this(CertificateList.GetInstance(encoding))
	{
	}

	public X509Crl(CertificateList c)
	{
		this.c = c;
		try
		{
			sigAlgName = X509SignatureUtilities.GetSignatureName(c.SignatureAlgorithm);
			sigAlgParams = c.SignatureAlgorithm.Parameters?.GetEncoded("DER");
			isIndirect = IsIndirectCrl;
		}
		catch (Exception ex)
		{
			throw new CrlException("CRL contents invalid: " + ex);
		}
	}

	protected override X509Extensions GetX509Extensions()
	{
		if (c.Version < 2)
		{
			return null;
		}
		return c.TbsCertList.Extensions;
	}

	public virtual void Verify(AsymmetricKeyParameter publicKey)
	{
		Verify(new Asn1VerifierFactoryProvider(publicKey));
	}

	public virtual void Verify(IVerifierFactoryProvider verifierProvider)
	{
		CheckSignature(verifierProvider.CreateVerifierFactory(c.SignatureAlgorithm));
	}

	protected virtual void CheckSignature(IVerifierFactory verifier)
	{
		if (!c.SignatureAlgorithm.Equals(c.TbsCertList.Signature))
		{
			throw new CrlException("Signature algorithm on CertificateList does not match TbsCertList.");
		}
		_ = c.SignatureAlgorithm.Parameters;
		IStreamCalculator streamCalculator = verifier.CreateCalculator();
		byte[] b = GetTbsCertList();
		streamCalculator.Stream.Write(b, 0, b.Length);
		Platform.Dispose(streamCalculator.Stream);
		if (!((IVerifier)streamCalculator.GetResult()).IsVerified(GetSignature()))
		{
			throw new InvalidKeyException("CRL does not verify with supplied public key.");
		}
	}

	private ISet LoadCrlEntries()
	{
		ISet entrySet = new HashSet();
		IEnumerable revokedCertificateEnumeration = c.GetRevokedCertificateEnumeration();
		X509Name previousCertificateIssuer = IssuerDN;
		foreach (CrlEntry item in revokedCertificateEnumeration)
		{
			X509CrlEntry crlEntry = new X509CrlEntry(item, isIndirect, previousCertificateIssuer);
			entrySet.Add(crlEntry);
			previousCertificateIssuer = crlEntry.GetCertificateIssuer();
		}
		return entrySet;
	}

	public virtual X509CrlEntry GetRevokedCertificate(BigInteger serialNumber)
	{
		IEnumerable revokedCertificateEnumeration = c.GetRevokedCertificateEnumeration();
		X509Name previousCertificateIssuer = IssuerDN;
		foreach (CrlEntry entry in revokedCertificateEnumeration)
		{
			X509CrlEntry crlEntry = new X509CrlEntry(entry, isIndirect, previousCertificateIssuer);
			if (serialNumber.Equals(entry.UserCertificate.Value))
			{
				return crlEntry;
			}
			previousCertificateIssuer = crlEntry.GetCertificateIssuer();
		}
		return null;
	}

	public virtual ISet GetRevokedCertificates()
	{
		ISet entrySet = LoadCrlEntries();
		if (entrySet.Count > 0)
		{
			return entrySet;
		}
		return null;
	}

	public virtual byte[] GetTbsCertList()
	{
		try
		{
			return c.TbsCertList.GetDerEncoded();
		}
		catch (Exception ex)
		{
			throw new CrlException(ex.ToString());
		}
	}

	public virtual byte[] GetSignature()
	{
		return c.GetSignatureOctets();
	}

	public virtual byte[] GetSigAlgParams()
	{
		return Arrays.Clone(sigAlgParams);
	}

	public virtual byte[] GetEncoded()
	{
		return Arrays.Clone(GetCachedEncoding().GetEncoded());
	}

	public override bool Equals(object other)
	{
		if (this == other)
		{
			return true;
		}
		if (!(other is X509Crl that))
		{
			return false;
		}
		if (hashValueSet && that.hashValueSet)
		{
			if (hashValue != that.hashValue)
			{
				return false;
			}
		}
		else if (cachedEncoding == null || that.cachedEncoding == null)
		{
			DerBitString signature = c.Signature;
			if (signature != null && !signature.Equals(that.c.Signature))
			{
				return false;
			}
		}
		byte[] thisEncoding = GetCachedEncoding().Encoding;
		byte[] thatEncoding = that.GetCachedEncoding().Encoding;
		if (thisEncoding != null && thatEncoding != null)
		{
			return Arrays.AreEqual(thisEncoding, thatEncoding);
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (!hashValueSet)
		{
			byte[] thisEncoding = GetCachedEncoding().Encoding;
			hashValue = Arrays.GetHashCode(thisEncoding);
			hashValueSet = true;
		}
		return hashValue;
	}

	public override string ToString()
	{
		StringBuilder buf = new StringBuilder();
		string nl = Platform.NewLine;
		buf.Append("              Version: ").Append(Version).Append(nl);
		buf.Append("             IssuerDN: ").Append(IssuerDN).Append(nl);
		buf.Append("          This update: ").Append(ThisUpdate).Append(nl);
		buf.Append("          Next update: ").Append(NextUpdate).Append(nl);
		buf.Append("  Signature Algorithm: ").Append(SigAlgName).Append(nl);
		byte[] sig = GetSignature();
		buf.Append("            Signature: ");
		buf.Append(Hex.ToHexString(sig, 0, 20)).Append(nl);
		for (int i = 20; i < sig.Length; i += 20)
		{
			int count = System.Math.Min(20, sig.Length - i);
			buf.Append("                       ");
			buf.Append(Hex.ToHexString(sig, i, count)).Append(nl);
		}
		X509Extensions extensions = c.TbsCertList.Extensions;
		if (extensions != null)
		{
			IEnumerator e = extensions.ExtensionOids.GetEnumerator();
			if (e.MoveNext())
			{
				buf.Append("           Extensions: ").Append(nl);
			}
			do
			{
				DerObjectIdentifier oid = (DerObjectIdentifier)e.Current;
				X509Extension ext = extensions.GetExtension(oid);
				if (ext.Value != null)
				{
					Asn1Object asn1Value = X509ExtensionUtilities.FromExtensionValue(ext.Value);
					buf.Append("                       critical(").Append(ext.IsCritical).Append(") ");
					try
					{
						if (oid.Equals(X509Extensions.CrlNumber))
						{
							buf.Append(new CrlNumber(DerInteger.GetInstance(asn1Value).PositiveValue)).Append(nl);
							continue;
						}
						if (oid.Equals(X509Extensions.DeltaCrlIndicator))
						{
							buf.Append("Base CRL: " + new CrlNumber(DerInteger.GetInstance(asn1Value).PositiveValue)).Append(nl);
							continue;
						}
						if (oid.Equals(X509Extensions.IssuingDistributionPoint))
						{
							buf.Append(IssuingDistributionPoint.GetInstance((Asn1Sequence)asn1Value)).Append(nl);
							continue;
						}
						if (oid.Equals(X509Extensions.CrlDistributionPoints))
						{
							buf.Append(CrlDistPoint.GetInstance((Asn1Sequence)asn1Value)).Append(nl);
							continue;
						}
						if (oid.Equals(X509Extensions.FreshestCrl))
						{
							buf.Append(CrlDistPoint.GetInstance((Asn1Sequence)asn1Value)).Append(nl);
							continue;
						}
						buf.Append(oid.Id);
						buf.Append(" value = ").Append(Asn1Dump.DumpAsString(asn1Value)).Append(nl);
					}
					catch (Exception)
					{
						buf.Append(oid.Id);
						buf.Append(" value = ").Append("*****").Append(nl);
					}
				}
				else
				{
					buf.Append(nl);
				}
			}
			while (e.MoveNext());
		}
		ISet certSet = GetRevokedCertificates();
		if (certSet != null)
		{
			foreach (X509CrlEntry entry in certSet)
			{
				buf.Append(entry);
				buf.Append(nl);
			}
		}
		return buf.ToString();
	}

	public virtual bool IsRevoked(X509Certificate cert)
	{
		CrlEntry[] certs = c.GetRevokedCertificates();
		if (certs != null)
		{
			BigInteger serial = cert.SerialNumber;
			for (int i = 0; i < certs.Length; i++)
			{
				if (certs[i].UserCertificate.HasValue(serial))
				{
					return true;
				}
			}
		}
		return false;
	}

	private CachedEncoding GetCachedEncoding()
	{
		lock (cacheLock)
		{
			if (cachedEncoding != null)
			{
				return cachedEncoding;
			}
		}
		byte[] encoding = null;
		CrlException exception = null;
		try
		{
			encoding = c.GetEncoded("DER");
		}
		catch (IOException e)
		{
			exception = new CrlException("Failed to DER-encode CRL", e);
		}
		CachedEncoding temp = new CachedEncoding(encoding, exception);
		lock (cacheLock)
		{
			if (cachedEncoding == null)
			{
				cachedEncoding = temp;
			}
			return cachedEncoding;
		}
	}
}
