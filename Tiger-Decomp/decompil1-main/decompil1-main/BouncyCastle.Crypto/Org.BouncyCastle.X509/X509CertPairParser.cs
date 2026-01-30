using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.X509;

public class X509CertPairParser
{
	private Stream currentStream;

	private X509CertificatePair ReadDerCrossCertificatePair(Stream inStream)
	{
		return new X509CertificatePair(CertificatePair.GetInstance((Asn1Sequence)new Asn1InputStream(inStream).ReadObject()));
	}

	public X509CertificatePair ReadCertPair(byte[] input)
	{
		return ReadCertPair(new MemoryStream(input, writable: false));
	}

	public ICollection ReadCertPairs(byte[] input)
	{
		return ReadCertPairs(new MemoryStream(input, writable: false));
	}

	public X509CertificatePair ReadCertPair(Stream inStream)
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
		}
		else if (currentStream != inStream)
		{
			currentStream = inStream;
		}
		try
		{
			PushbackStream pis = new PushbackStream(inStream);
			int tag = pis.ReadByte();
			if (tag < 0)
			{
				return null;
			}
			pis.Unread(tag);
			return ReadDerCrossCertificatePair(pis);
		}
		catch (Exception ex)
		{
			throw new CertificateException(ex.ToString());
		}
	}

	public ICollection ReadCertPairs(Stream inStream)
	{
		IList certPairs = Platform.CreateArrayList();
		X509CertificatePair certPair;
		while ((certPair = ReadCertPair(inStream)) != null)
		{
			certPairs.Add(certPair);
		}
		return certPairs;
	}
}
