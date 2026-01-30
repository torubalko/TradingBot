using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.OpenSsl;

namespace MimeKit.Cryptography;

public abstract class DkimSignerBase
{
	public string Domain { get; private set; }

	public string Selector { get; private set; }

	public DkimSignatureAlgorithm SignatureAlgorithm { get; set; }

	public DkimCanonicalizationAlgorithm BodyCanonicalizationAlgorithm { get; set; }

	public DkimCanonicalizationAlgorithm HeaderCanonicalizationAlgorithm { get; set; }

	protected AsymmetricKeyParameter PrivateKey { get; set; }

	protected DkimSignerBase(string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		SignatureAlgorithm = algorithm;
		Selector = selector;
		Domain = domain;
	}

	internal static AsymmetricKeyParameter LoadPrivateKey(Stream stream)
	{
		AsymmetricKeyParameter asymmetricKeyParameter = null;
		using (StreamReader reader = new StreamReader(stream))
		{
			PemReader pemReader = new PemReader(reader);
			object obj = pemReader.ReadObject();
			if (obj is AsymmetricCipherKeyPair asymmetricCipherKeyPair)
			{
				asymmetricKeyParameter = asymmetricCipherKeyPair.Private;
			}
			else if (obj is AsymmetricKeyParameter)
			{
				asymmetricKeyParameter = (AsymmetricKeyParameter)obj;
			}
		}
		if (asymmetricKeyParameter == null || !asymmetricKeyParameter.IsPrivate)
		{
			throw new FormatException("Private key not found.");
		}
		return asymmetricKeyParameter;
	}

	protected internal virtual ISigner CreateSigningContext()
	{
		ISigner signer = SignatureAlgorithm switch
		{
			DkimSignatureAlgorithm.RsaSha1 => new RsaDigestSigner(new Sha1Digest()), 
			DkimSignatureAlgorithm.RsaSha256 => new RsaDigestSigner(new Sha256Digest()), 
			DkimSignatureAlgorithm.Ed25519Sha256 => new Ed25519DigestSigner(new Sha256Digest()), 
			_ => throw new NotSupportedException($"{SignatureAlgorithm} is not supported."), 
		};
		signer.Init(forSigning: true, PrivateKey);
		return signer;
	}
}
