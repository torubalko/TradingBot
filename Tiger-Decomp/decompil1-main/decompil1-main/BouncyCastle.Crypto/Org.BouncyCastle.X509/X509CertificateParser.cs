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

public class X509CertificateParser
{
	private static readonly PemParser PemCertParser = new PemParser("CERTIFICATE");

	private Asn1Set sData;

	private int sDataObjectCount;

	private Stream currentStream;

	private X509Certificate ReadDerCertificate(Asn1InputStream dIn)
	{
		Asn1Sequence seq = (Asn1Sequence)dIn.ReadObject();
		if (seq.Count > 1 && seq[0] is DerObjectIdentifier && seq[0].Equals(PkcsObjectIdentifiers.SignedData))
		{
			sData = SignedData.GetInstance(Asn1Sequence.GetInstance((Asn1TaggedObject)seq[1], explicitly: true)).Certificates;
			return GetCertificate();
		}
		return CreateX509Certificate(X509CertificateStructure.GetInstance(seq));
	}

	private X509Certificate GetCertificate()
	{
		if (sData != null)
		{
			while (sDataObjectCount < sData.Count)
			{
				object obj = sData[sDataObjectCount++];
				if (obj is Asn1Sequence)
				{
					return CreateX509Certificate(X509CertificateStructure.GetInstance(obj));
				}
			}
		}
		return null;
	}

	private X509Certificate ReadPemCertificate(Stream inStream)
	{
		Asn1Sequence seq = PemCertParser.ReadPemObject(inStream);
		if (seq != null)
		{
			return CreateX509Certificate(X509CertificateStructure.GetInstance(seq));
		}
		return null;
	}

	protected virtual X509Certificate CreateX509Certificate(X509CertificateStructure c)
	{
		return new X509Certificate(c);
	}

	public X509Certificate ReadCertificate(byte[] input)
	{
		return ReadCertificate(new MemoryStream(input, writable: false));
	}

	public ICollection ReadCertificates(byte[] input)
	{
		return ReadCertificates(new MemoryStream(input, writable: false));
	}

	public X509Certificate ReadCertificate(Stream inStream)
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
		catch (Exception exception)
		{
			throw new CertificateException("Failed to read certificate", exception);
		}
	}

	public ICollection ReadCertificates(Stream inStream)
	{
		IList certs = Platform.CreateArrayList();
		X509Certificate cert;
		while ((cert = ReadCertificate(inStream)) != null)
		{
			certs.Add(cert);
		}
		return certs;
	}
}
