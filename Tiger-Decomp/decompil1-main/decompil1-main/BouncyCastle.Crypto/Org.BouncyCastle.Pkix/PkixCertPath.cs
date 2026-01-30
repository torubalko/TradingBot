using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkix;

public class PkixCertPath
{
	internal static readonly IList certPathEncodings;

	private readonly IList certificates;

	public virtual IEnumerable Encodings => new EnumerableProxy(certPathEncodings);

	public virtual IList Certificates => CollectionUtilities.ReadOnly(certificates);

	static PkixCertPath()
	{
		IList list = Platform.CreateArrayList();
		list.Add("PkiPath");
		list.Add("PEM");
		list.Add("PKCS7");
		certPathEncodings = CollectionUtilities.ReadOnly(list);
	}

	private static IList SortCerts(IList certs)
	{
		if (certs.Count < 2)
		{
			return certs;
		}
		X509Name issuer = ((X509Certificate)certs[0]).IssuerDN;
		bool okay = true;
		for (int i = 1; i != certs.Count; i++)
		{
			X509Certificate cert = (X509Certificate)certs[i];
			if (issuer.Equivalent(cert.SubjectDN, inOrder: true))
			{
				issuer = ((X509Certificate)certs[i]).IssuerDN;
				continue;
			}
			okay = false;
			break;
		}
		if (okay)
		{
			return certs;
		}
		IList retList = Platform.CreateArrayList(certs.Count);
		IList orig = Platform.CreateArrayList(certs);
		for (int j = 0; j < certs.Count; j++)
		{
			X509Certificate cert2 = (X509Certificate)certs[j];
			bool found = false;
			X509Name subject = cert2.SubjectDN;
			foreach (X509Certificate cert3 in certs)
			{
				if (cert3.IssuerDN.Equivalent(subject, inOrder: true))
				{
					found = true;
					break;
				}
			}
			if (!found)
			{
				retList.Add(cert2);
				certs.RemoveAt(j);
			}
		}
		if (retList.Count > 1)
		{
			return orig;
		}
		for (int k = 0; k != retList.Count; k++)
		{
			issuer = ((X509Certificate)retList[k]).IssuerDN;
			for (int l = 0; l < certs.Count; l++)
			{
				X509Certificate c = (X509Certificate)certs[l];
				if (issuer.Equivalent(c.SubjectDN, inOrder: true))
				{
					retList.Add(c);
					certs.RemoveAt(l);
					break;
				}
			}
		}
		if (certs.Count > 0)
		{
			return orig;
		}
		return retList;
	}

	public PkixCertPath(ICollection certificates)
	{
		this.certificates = SortCerts(Platform.CreateArrayList(certificates));
	}

	public PkixCertPath(Stream inStream)
		: this(inStream, "PkiPath")
	{
	}

	public PkixCertPath(Stream inStream, string encoding)
	{
		string upper = Platform.ToUpperInvariant(encoding);
		IList certs;
		try
		{
			if (upper.Equals(Platform.ToUpperInvariant("PkiPath")))
			{
				Asn1Object asn1Object = new Asn1InputStream(inStream).ReadObject();
				if (!(asn1Object is Asn1Sequence))
				{
					throw new CertificateException("input stream does not contain a ASN1 SEQUENCE while reading PkiPath encoded data to load CertPath");
				}
				certs = Platform.CreateArrayList();
				foreach (Asn1Encodable item in (Asn1Sequence)asn1Object)
				{
					Stream certInStream = new MemoryStream(item.GetEncoded("DER"), writable: false);
					certs.Insert(0, new X509CertificateParser().ReadCertificate(certInStream));
				}
			}
			else
			{
				if (!upper.Equals("PKCS7") && !upper.Equals("PEM"))
				{
					throw new CertificateException("unsupported encoding: " + encoding);
				}
				certs = Platform.CreateArrayList(new X509CertificateParser().ReadCertificates(inStream));
			}
		}
		catch (IOException ex)
		{
			throw new CertificateException("IOException throw while decoding CertPath:\n" + ex.ToString());
		}
		certificates = SortCerts(certs);
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (!(obj is PkixCertPath other))
		{
			return false;
		}
		IList thisCerts = Certificates;
		IList otherCerts = other.Certificates;
		if (thisCerts.Count != otherCerts.Count)
		{
			return false;
		}
		IEnumerator e1 = thisCerts.GetEnumerator();
		IEnumerator e2 = otherCerts.GetEnumerator();
		while (e1.MoveNext())
		{
			e2.MoveNext();
			if (!object.Equals(e1.Current, e2.Current))
			{
				return false;
			}
		}
		return true;
	}

	public override int GetHashCode()
	{
		return Certificates.GetHashCode();
	}

	public virtual byte[] GetEncoded()
	{
		foreach (object enc in Encodings)
		{
			if (enc is string)
			{
				return GetEncoded((string)enc);
			}
		}
		return null;
	}

	public virtual byte[] GetEncoded(string encoding)
	{
		if (Platform.EqualsIgnoreCase(encoding, "PkiPath"))
		{
			Asn1EncodableVector v = new Asn1EncodableVector();
			for (int i = certificates.Count - 1; i >= 0; i--)
			{
				v.Add(ToAsn1Object((X509Certificate)certificates[i]));
			}
			return ToDerEncoded(new DerSequence(v));
		}
		if (Platform.EqualsIgnoreCase(encoding, "PKCS7"))
		{
			ContentInfo encInfo = new ContentInfo(PkcsObjectIdentifiers.Data, null);
			Asn1EncodableVector v2 = new Asn1EncodableVector();
			for (int j = 0; j != certificates.Count; j++)
			{
				v2.Add(ToAsn1Object((X509Certificate)certificates[j]));
			}
			SignedData sd = new SignedData(new DerInteger(1), new DerSet(), encInfo, new DerSet(v2), null, new DerSet());
			return ToDerEncoded(new ContentInfo(PkcsObjectIdentifiers.SignedData, sd));
		}
		if (Platform.EqualsIgnoreCase(encoding, "PEM"))
		{
			MemoryStream bOut = new MemoryStream();
			PemWriter pWrt = new PemWriter(new StreamWriter(bOut));
			try
			{
				for (int k = 0; k != certificates.Count; k++)
				{
					pWrt.WriteObject(certificates[k]);
				}
				Platform.Dispose(pWrt.Writer);
			}
			catch (Exception)
			{
				throw new CertificateEncodingException("can't encode certificate for PEM encoded path");
			}
			return bOut.ToArray();
		}
		throw new CertificateEncodingException("unsupported encoding: " + encoding);
	}

	private Asn1Object ToAsn1Object(X509Certificate cert)
	{
		try
		{
			return Asn1Object.FromByteArray(cert.GetEncoded());
		}
		catch (Exception e)
		{
			throw new CertificateEncodingException("Exception while encoding certificate", e);
		}
	}

	private byte[] ToDerEncoded(Asn1Encodable obj)
	{
		try
		{
			return obj.GetEncoded("DER");
		}
		catch (IOException e)
		{
			throw new CertificateEncodingException("Exception thrown", e);
		}
	}
}
