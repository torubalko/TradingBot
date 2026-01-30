using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkcs;

public class Pkcs10CertificationRequestDelaySigned : Pkcs10CertificationRequest
{
	protected Pkcs10CertificationRequestDelaySigned()
	{
	}

	public Pkcs10CertificationRequestDelaySigned(byte[] encoded)
		: base(encoded)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(Asn1Sequence seq)
		: base(seq)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(Stream input)
		: base(input)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes, AsymmetricKeyParameter signingKey)
		: base(signatureAlgorithm, subject, publicKey, attributes, signingKey)
	{
	}

	public Pkcs10CertificationRequestDelaySigned(string signatureAlgorithm, X509Name subject, AsymmetricKeyParameter publicKey, Asn1Set attributes)
	{
		if (signatureAlgorithm == null)
		{
			throw new ArgumentNullException("signatureAlgorithm");
		}
		if (subject == null)
		{
			throw new ArgumentNullException("subject");
		}
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		if (publicKey.IsPrivate)
		{
			throw new ArgumentException("expected public key", "publicKey");
		}
		string algorithmName = Platform.ToUpperInvariant(signatureAlgorithm);
		DerObjectIdentifier sigOid = (DerObjectIdentifier)Pkcs10CertificationRequest.algorithms[algorithmName];
		if (sigOid == null)
		{
			try
			{
				sigOid = new DerObjectIdentifier(algorithmName);
			}
			catch (Exception innerException)
			{
				throw new ArgumentException("Unknown signature type requested", innerException);
			}
		}
		if (Pkcs10CertificationRequest.noParams.Contains(sigOid))
		{
			sigAlgId = new AlgorithmIdentifier(sigOid);
		}
		else if (Pkcs10CertificationRequest.exParams.Contains(algorithmName))
		{
			sigAlgId = new AlgorithmIdentifier(sigOid, (Asn1Encodable)Pkcs10CertificationRequest.exParams[algorithmName]);
		}
		else
		{
			sigAlgId = new AlgorithmIdentifier(sigOid, DerNull.Instance);
		}
		SubjectPublicKeyInfo pubInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey);
		reqInfo = new CertificationRequestInfo(subject, pubInfo, attributes);
	}

	public byte[] GetDataToSign()
	{
		return reqInfo.GetDerEncoded();
	}

	public void SignRequest(byte[] signedData)
	{
		sigBits = new DerBitString(signedData);
	}

	public void SignRequest(DerBitString signedData)
	{
		sigBits = signedData;
	}
}
