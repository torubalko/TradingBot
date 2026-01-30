using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.X509;

public class X509AttrCertParser
{
	private static readonly PemParser PemAttrCertParser = new PemParser("ATTRIBUTE CERTIFICATE");

	private Asn1Set sData;

	private int sDataObjectCount;

	private Stream currentStream;

	private IX509AttributeCertificate ReadDerCertificate(Asn1InputStream dIn)
	{
		Asn1Sequence seq = (Asn1Sequence)dIn.ReadObject();
		if (seq.Count > 1 && seq[0] is DerObjectIdentifier && seq[0].Equals(PkcsObjectIdentifiers.SignedData))
		{
			sData = SignedData.GetInstance(Asn1Sequence.GetInstance((Asn1TaggedObject)seq[1], explicitly: true)).Certificates;
			return GetCertificate();
		}
		return new X509V2AttributeCertificate(AttributeCertificate.GetInstance(seq));
	}

	private IX509AttributeCertificate GetCertificate()
	{
		if (sData != null)
		{
			while (sDataObjectCount < sData.Count)
			{
				object obj = sData[sDataObjectCount++];
				if (obj is Asn1TaggedObject && ((Asn1TaggedObject)obj).TagNo == 2)
				{
					return new X509V2AttributeCertificate(AttributeCertificate.GetInstance(Asn1Sequence.GetInstance((Asn1TaggedObject)obj, explicitly: false)));
				}
			}
		}
		return null;
	}

	private IX509AttributeCertificate ReadPemCertificate(Stream inStream)
	{
		Asn1Sequence seq = PemAttrCertParser.ReadPemObject(inStream);
		if (seq != null)
		{
			return new X509V2AttributeCertificate(AttributeCertificate.GetInstance(seq));
		}
		return null;
	}

	public IX509AttributeCertificate ReadAttrCert(byte[] input)
	{
		return ReadAttrCert(new MemoryStream(input, writable: false));
	}

	public ICollection ReadAttrCerts(byte[] input)
	{
		return ReadAttrCerts(new MemoryStream(input, writable: false));
	}

	public IX509AttributeCertificate ReadAttrCert(Stream inStream)
	{
		if (inStream == null)
		{
			throw new ArgumentNullException("inStream");
		}
		if (!inStream.CanRead)
		{
			throw new ArgumentException("inStream must be read-able", "inStream");
		}
		if (currentStream == null)
		{
			currentStream = inStream;
			sData = null;
			sDataObjectCount = 0;
		}
		else if (currentStream != inStream)
		{
			currentStream = inStream;
			sData = null;
			sDataObjectCount = 0;
		}
		try
		{
			if (sData != null)
			{
				if (sDataObjectCount != sData.Count)
				{
					return GetCertificate();
				}
				sData = null;
				sDataObjectCount = 0;
				return null;
			}
			PushbackStream pis = new PushbackStream(inStream);
			int tag = pis.ReadByte();
			if (tag < 0)
			{
				return null;
			}
			pis.Unread(tag);
			if (tag != 48)
			{
				return ReadPemCertificate(pis);
			}
			return ReadDerCertificate(new Asn1InputStream(pis));
		}
		catch (Exception ex)
		{
			throw new CertificateException(ex.ToString());
		}
	}

	public ICollection ReadAttrCerts(Stream inStream)
	{
		IList attrCerts = Platform.CreateArrayList();
		IX509AttributeCertificate attrCert;
		while ((attrCert = ReadAttrCert(inStream)) != null)
		{
			attrCerts.Add(attrCert);
		}
		return attrCerts;
	}
}
