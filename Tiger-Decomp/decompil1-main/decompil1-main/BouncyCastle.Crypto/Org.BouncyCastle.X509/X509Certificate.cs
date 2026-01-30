using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Utilities;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509;

public class X509Certificate : X509ExtensionBase
{
	private class CachedEncoding
	{
		private readonly byte[] encoding;

		private readonly CertificateEncodingException exception;

		internal byte[] Encoding => encoding;

		internal CachedEncoding(byte[] encoding, CertificateEncodingException exception)
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
				throw new CertificateEncodingException();
			}
			return encoding;
		}
	}

	private readonly X509CertificateStructure c;

	private readonly string sigAlgName;

	private readonly byte[] sigAlgParams;

	private readonly BasicConstraints basicConstraints;

	private readonly bool[] keyUsage;

	private readonly object cacheLock = new object();

	private AsymmetricKeyParameter publicKeyValue;

	private CachedEncoding cachedEncoding;

	private volatile bool hashValueSet;

	private volatile int hashValue;

	public virtual X509CertificateStructure CertificateStructure => c;

	public virtual bool IsValidNow => IsValid(DateTime.UtcNow);

	public virtual int Version => c.Version;

	public virtual BigInteger SerialNumber => c.SerialNumber.Value;

	public virtual X509Name IssuerDN => c.Issuer;

	public virtual X509Name SubjectDN => c.Subject;

	public virtual DateTime NotBefore => c.StartDate.ToDateTime();

	public virtual DateTime NotAfter => c.EndDate.ToDateTime();

	public virtual string SigAlgName => sigAlgName;

	public virtual string SigAlgOid => c.SignatureAlgorithm.Algorithm.Id;

	public virtual DerBitString IssuerUniqueID => c.TbsCertificate.IssuerUniqueID;

	public virtual DerBitString SubjectUniqueID => c.TbsCertificate.SubjectUniqueID;

	protected X509Certificate()
	{
	}

	public X509Certificate(byte[] certData)
		: this(X509CertificateStructure.GetInstance(certData))
	{
	}

	public X509Certificate(X509CertificateStructure c)
	{
		this.c = c;
		try
		{
			sigAlgName = X509SignatureUtilities.GetSignatureName(c.SignatureAlgorithm);
			sigAlgParams = c.SignatureAlgorithm.Parameters?.GetEncoded("DER");
		}
		catch (Exception ex)
		{
			throw new CertificateParsingException("Certificate contents invalid: " + ex);
		}
		try
		{
			Asn1OctetString str = GetExtensionValue(new DerObjectIdentifier("2.5.29.19"));
			if (str != null)
			{
				basicConstraints = BasicConstraints.GetInstance(X509ExtensionUtilities.FromExtensionValue(str));
			}
		}
		catch (Exception ex2)
		{
			throw new CertificateParsingException("cannot construct BasicConstraints: " + ex2);
		}
		try
		{
			Asn1OctetString str2 = GetExtensionValue(new DerObjectIdentifier("2.5.29.15"));
			if (str2 != null)
			{
				DerBitString bits = DerBitString.GetInstance(X509ExtensionUtilities.FromExtensionValue(str2));
				byte[] bytes = bits.GetBytes();
				int length = bytes.Length * 8 - bits.PadBits;
				keyUsage = new bool[(length < 9) ? 9 : length];
				for (int i = 0; i != length; i++)
				{
					keyUsage[i] = (bytes[i / 8] & (128 >> i % 8)) != 0;
				}
			}
			else
			{
				keyUsage = null;
			}
		}
		catch (Exception ex3)
		{
			throw new CertificateParsingException("cannot construct KeyUsage: " + ex3);
		}
	}

	public virtual bool IsValid(DateTime time)
	{
		if (time.CompareTo(NotBefore) >= 0)
		{
			return time.CompareTo(NotAfter) <= 0;
		}
		return false;
	}

	public virtual void CheckValidity()
	{
		CheckValidity(DateTime.UtcNow);
	}

	public virtual void CheckValidity(DateTime time)
	{
		if (time.CompareTo(NotAfter) > 0)
		{
			throw new CertificateExpiredException("certificate expired on " + c.EndDate.GetTime());
		}
		if (time.CompareTo(NotBefore) < 0)
		{
			throw new CertificateNotYetValidException("certificate not valid until " + c.StartDate.GetTime());
		}
	}

	public virtual byte[] GetTbsCertificate()
	{
		return c.TbsCertificate.GetDerEncoded();
	}

	public virtual byte[] GetSignature()
	{
		return c.GetSignatureOctets();
	}

	public virtual byte[] GetSigAlgParams()
	{
		return Arrays.Clone(sigAlgParams);
	}

	public virtual bool[] GetKeyUsage()
	{
		return Arrays.Clone(keyUsage);
	}

	public virtual IList GetExtendedKeyUsage()
	{
		Asn1OctetString str = GetExtensionValue(new DerObjectIdentifier("2.5.29.37"));
		if (str == null)
		{
			return null;
		}
		try
		{
			Asn1Sequence instance = Asn1Sequence.GetInstance(X509ExtensionUtilities.FromExtensionValue(str));
			IList list = Platform.CreateArrayList();
			foreach (DerObjectIdentifier oid in instance)
			{
				list.Add(oid.Id);
			}
			return list;
		}
		catch (Exception exception)
		{
			throw new CertificateParsingException("error processing extended key usage extension", exception);
		}
	}

	public virtual int GetBasicConstraints()
	{
		if (basicConstraints != null && basicConstraints.IsCA())
		{
			if (basicConstraints.PathLenConstraint == null)
			{
				return int.MaxValue;
			}
			return basicConstraints.PathLenConstraint.IntValue;
		}
		return -1;
	}

	public virtual ICollection GetSubjectAlternativeNames()
	{
		return GetAlternativeNames("2.5.29.17");
	}

	public virtual ICollection GetIssuerAlternativeNames()
	{
		return GetAlternativeNames("2.5.29.18");
	}

	protected virtual ICollection GetAlternativeNames(string oid)
	{
		Asn1OctetString altNames = GetExtensionValue(new DerObjectIdentifier(oid));
		if (altNames == null)
		{
			return null;
		}
		GeneralNames instance = GeneralNames.GetInstance(X509ExtensionUtilities.FromExtensionValue(altNames));
		IList result = Platform.CreateArrayList();
		GeneralName[] names = instance.GetNames();
		foreach (GeneralName gn in names)
		{
			IList entry = Platform.CreateArrayList();
			entry.Add(gn.TagNo);
			entry.Add(gn.Name.ToString());
			result.Add(entry);
		}
		return result;
	}

	protected override X509Extensions GetX509Extensions()
	{
		if (c.Version < 3)
		{
			return null;
		}
		return c.TbsCertificate.Extensions;
	}

	public virtual AsymmetricKeyParameter GetPublicKey()
	{
		lock (cacheLock)
		{
			if (publicKeyValue != null)
			{
				return publicKeyValue;
			}
		}
		AsymmetricKeyParameter temp = PublicKeyFactory.CreateKey(c.SubjectPublicKeyInfo);
		lock (cacheLock)
		{
			if (publicKeyValue == null)
			{
				publicKeyValue = temp;
			}
			return publicKeyValue;
		}
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
		if (!(other is X509Certificate that))
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
		buf.Append("  [0]         Version: ").Append(Version).Append(nl);
		buf.Append("         SerialNumber: ").Append(SerialNumber).Append(nl);
		buf.Append("             IssuerDN: ").Append(IssuerDN).Append(nl);
		buf.Append("           Start Date: ").Append(NotBefore).Append(nl);
		buf.Append("           Final Date: ").Append(NotAfter).Append(nl);
		buf.Append("            SubjectDN: ").Append(SubjectDN).Append(nl);
		buf.Append("           Public Key: ").Append(GetPublicKey()).Append(nl);
		buf.Append("  Signature Algorithm: ").Append(SigAlgName).Append(nl);
		byte[] sig = GetSignature();
		buf.Append("            Signature: ").Append(Hex.ToHexString(sig, 0, 20)).Append(nl);
		for (int i = 20; i < sig.Length; i += 20)
		{
			int len = System.Math.Min(20, sig.Length - i);
			buf.Append("                       ").Append(Hex.ToHexString(sig, i, len)).Append(nl);
		}
		X509Extensions extensions = c.TbsCertificate.Extensions;
		if (extensions != null)
		{
			IEnumerator e = extensions.ExtensionOids.GetEnumerator();
			if (e.MoveNext())
			{
				buf.Append("       Extensions: \n");
			}
			do
			{
				DerObjectIdentifier oid = (DerObjectIdentifier)e.Current;
				X509Extension ext = extensions.GetExtension(oid);
				if (ext.Value != null)
				{
					Asn1Object obj = X509ExtensionUtilities.FromExtensionValue(ext.Value);
					buf.Append("                       critical(").Append(ext.IsCritical).Append(") ");
					try
					{
						if (oid.Equals(X509Extensions.BasicConstraints))
						{
							buf.Append(BasicConstraints.GetInstance(obj));
						}
						else if (oid.Equals(X509Extensions.KeyUsage))
						{
							buf.Append(KeyUsage.GetInstance(obj));
						}
						else if (oid.Equals(MiscObjectIdentifiers.NetscapeCertType))
						{
							buf.Append(new NetscapeCertType((DerBitString)obj));
						}
						else if (oid.Equals(MiscObjectIdentifiers.NetscapeRevocationUrl))
						{
							buf.Append(new NetscapeRevocationUrl((DerIA5String)obj));
						}
						else if (oid.Equals(MiscObjectIdentifiers.VerisignCzagExtension))
						{
							buf.Append(new VerisignCzagExtension((DerIA5String)obj));
						}
						else
						{
							buf.Append(oid.Id);
							buf.Append(" value = ").Append(Asn1Dump.DumpAsString(obj));
						}
					}
					catch (Exception)
					{
						buf.Append(oid.Id);
						buf.Append(" value = ").Append("*****");
					}
				}
				buf.Append(nl);
			}
			while (e.MoveNext());
		}
		return buf.ToString();
	}

	public virtual void Verify(AsymmetricKeyParameter key)
	{
		CheckSignature(new Asn1VerifierFactory(c.SignatureAlgorithm, key));
	}

	public virtual void Verify(IVerifierFactoryProvider verifierProvider)
	{
		CheckSignature(verifierProvider.CreateVerifierFactory(c.SignatureAlgorithm));
	}

	protected virtual void CheckSignature(IVerifierFactory verifier)
	{
		if (!IsAlgIDEqual(c.SignatureAlgorithm, c.TbsCertificate.Signature))
		{
			throw new CertificateException("signature algorithm in TBS cert not same as outer cert");
		}
		_ = c.SignatureAlgorithm.Parameters;
		IStreamCalculator streamCalculator = verifier.CreateCalculator();
		byte[] b = GetTbsCertificate();
		streamCalculator.Stream.Write(b, 0, b.Length);
		Platform.Dispose(streamCalculator.Stream);
		if (!((IVerifier)streamCalculator.GetResult()).IsVerified(GetSignature()))
		{
			throw new InvalidKeyException("Public key presented not for certificate signature");
		}
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
		CertificateEncodingException exception = null;
		try
		{
			encoding = c.GetEncoded("DER");
		}
		catch (IOException e)
		{
			exception = new CertificateEncodingException("Failed to DER-encode certificate", e);
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

	private static bool IsAlgIDEqual(AlgorithmIdentifier id1, AlgorithmIdentifier id2)
	{
		if (!id1.Algorithm.Equals(id2.Algorithm))
		{
			return false;
		}
		Asn1Encodable p1 = id1.Parameters;
		Asn1Encodable p2 = id2.Parameters;
		if (p1 == null == (p2 == null))
		{
			return object.Equals(p1, p2);
		}
		if (p1 != null)
		{
			return p1.ToAsn1Object() is Asn1Null;
		}
		return p2.ToAsn1Object() is Asn1Null;
	}
}
