using System;
using System.IO;
using System.Threading;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Smime;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public abstract class SecureMimeContext : CryptographyContext
{
	private static readonly string[] ProtocolSubtypes = new string[6] { "pkcs7-signature", "pkcs7-mime", "pkcs7-keys", "x-pkcs7-signature", "x-pkcs7-mime", "x-pkcs7-keys" };

	internal const X509KeyUsageFlags DigitalSignatureKeyUsageFlags = X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature;

	internal static readonly int EncryptionAlgorithmCount = Enum.GetValues(typeof(EncryptionAlgorithm)).Length;

	internal static readonly DerObjectIdentifier Blowfish = new DerObjectIdentifier("1.3.6.1.4.1.3029.1.2");

	internal static readonly DerObjectIdentifier Twofish = new DerObjectIdentifier("1.3.6.1.4.1.25258.3.3");

	public override string SignatureProtocol => "application/pkcs7-signature";

	public override string EncryptionProtocol => "application/pkcs7-mime";

	public override string KeyExchangeProtocol => "application/pkcs7-mime";

	protected SecureMimeContext()
	{
		base.EncryptionAlgorithmRank = new EncryptionAlgorithm[15]
		{
			EncryptionAlgorithm.Aes256,
			EncryptionAlgorithm.Aes192,
			EncryptionAlgorithm.Aes128,
			EncryptionAlgorithm.Seed,
			EncryptionAlgorithm.Camellia256,
			EncryptionAlgorithm.Camellia192,
			EncryptionAlgorithm.Camellia128,
			EncryptionAlgorithm.Cast5,
			EncryptionAlgorithm.Blowfish,
			EncryptionAlgorithm.TripleDes,
			EncryptionAlgorithm.Idea,
			EncryptionAlgorithm.RC2128,
			EncryptionAlgorithm.RC264,
			EncryptionAlgorithm.Des,
			EncryptionAlgorithm.RC240
		};
		EncryptionAlgorithm[] array = base.EncryptionAlgorithmRank;
		foreach (EncryptionAlgorithm encryptionAlgorithm in array)
		{
			Enable(encryptionAlgorithm);
			if (encryptionAlgorithm == EncryptionAlgorithm.TripleDes)
			{
				break;
			}
		}
		Disable(EncryptionAlgorithm.Blowfish);
		Disable(EncryptionAlgorithm.Twofish);
	}

	public override bool Supports(string protocol)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (!protocol.StartsWith("application/", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		int length = "application/".Length;
		int num = protocol.Length - length;
		for (int i = 0; i < ProtocolSubtypes.Length; i++)
		{
			if (num == ProtocolSubtypes[i].Length && string.Compare(protocol, length, ProtocolSubtypes[i], 0, num, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public override string GetDigestAlgorithmName(DigestAlgorithm micalg)
	{
		return micalg switch
		{
			DigestAlgorithm.MD5 => "md5", 
			DigestAlgorithm.Sha1 => "sha-1", 
			DigestAlgorithm.RipeMD160 => "ripemd160", 
			DigestAlgorithm.MD2 => "md2", 
			DigestAlgorithm.Tiger192 => "tiger192", 
			DigestAlgorithm.Haval5160 => "haval-5-160", 
			DigestAlgorithm.Sha256 => "sha-256", 
			DigestAlgorithm.Sha384 => "sha-384", 
			DigestAlgorithm.Sha512 => "sha-512", 
			DigestAlgorithm.Sha224 => "sha-224", 
			DigestAlgorithm.MD4 => "md4", 
			DigestAlgorithm.DoubleSha => throw new NotSupportedException($"{micalg} is not supported."), 
			_ => throw new ArgumentOutOfRangeException("micalg", micalg, $"Unknown DigestAlgorithm: {micalg}"), 
		};
	}

	public override DigestAlgorithm GetDigestAlgorithm(string micalg)
	{
		if (micalg == null)
		{
			throw new ArgumentNullException("micalg");
		}
		return micalg.ToLowerInvariant() switch
		{
			"md5" => DigestAlgorithm.MD5, 
			"sha-1" => DigestAlgorithm.Sha1, 
			"ripemd160" => DigestAlgorithm.RipeMD160, 
			"md2" => DigestAlgorithm.MD2, 
			"tiger192" => DigestAlgorithm.Tiger192, 
			"haval-5-160" => DigestAlgorithm.Haval5160, 
			"sha-256" => DigestAlgorithm.Sha256, 
			"sha-384" => DigestAlgorithm.Sha384, 
			"sha-512" => DigestAlgorithm.Sha512, 
			"sha-224" => DigestAlgorithm.Sha224, 
			"md4" => DigestAlgorithm.MD4, 
			_ => DigestAlgorithm.None, 
		};
	}

	protected internal static string GetDigestOid(DigestAlgorithm digestAlgo)
	{
		switch (digestAlgo)
		{
		case DigestAlgorithm.MD5:
			return CmsSignedGenerator.DigestMD5;
		case DigestAlgorithm.Sha1:
			return CmsSignedGenerator.DigestSha1;
		case DigestAlgorithm.MD2:
			return PkcsObjectIdentifiers.MD2.Id;
		case DigestAlgorithm.Sha256:
			return CmsSignedGenerator.DigestSha256;
		case DigestAlgorithm.Sha384:
			return CmsSignedGenerator.DigestSha384;
		case DigestAlgorithm.Sha512:
			return CmsSignedGenerator.DigestSha512;
		case DigestAlgorithm.Sha224:
			return CmsSignedGenerator.DigestSha224;
		case DigestAlgorithm.MD4:
			return PkcsObjectIdentifiers.MD4.Id;
		case DigestAlgorithm.RipeMD160:
			return CmsSignedGenerator.DigestRipeMD160;
		case DigestAlgorithm.DoubleSha:
		case DigestAlgorithm.Tiger192:
		case DigestAlgorithm.Haval5160:
			throw new NotSupportedException($"{digestAlgo} is not supported.");
		default:
			throw new ArgumentOutOfRangeException("digestAlgo", digestAlgo, $"Unknown DigestAlgorithm: {digestAlgo}");
		}
	}

	internal static bool TryGetDigestAlgorithm(string id, out DigestAlgorithm algorithm)
	{
		if (id == CmsSignedGenerator.DigestSha1)
		{
			algorithm = DigestAlgorithm.Sha1;
			return true;
		}
		if (id == CmsSignedGenerator.DigestSha224)
		{
			algorithm = DigestAlgorithm.Sha224;
			return true;
		}
		if (id == CmsSignedGenerator.DigestSha256)
		{
			algorithm = DigestAlgorithm.Sha256;
			return true;
		}
		if (id == CmsSignedGenerator.DigestSha384)
		{
			algorithm = DigestAlgorithm.Sha384;
			return true;
		}
		if (id == CmsSignedGenerator.DigestSha512)
		{
			algorithm = DigestAlgorithm.Sha512;
			return true;
		}
		if (id == CmsSignedGenerator.DigestRipeMD160)
		{
			algorithm = DigestAlgorithm.RipeMD160;
			return true;
		}
		if (id == CmsSignedGenerator.DigestMD5)
		{
			algorithm = DigestAlgorithm.MD5;
			return true;
		}
		if (id == PkcsObjectIdentifiers.MD4.Id)
		{
			algorithm = DigestAlgorithm.MD4;
			return true;
		}
		if (id == PkcsObjectIdentifiers.MD2.Id)
		{
			algorithm = DigestAlgorithm.MD2;
			return true;
		}
		algorithm = DigestAlgorithm.None;
		return false;
	}

	protected virtual EncryptionAlgorithm GetPreferredEncryptionAlgorithm(CmsRecipientCollection recipients)
	{
		int[] array = new int[EncryptionAlgorithmCount];
		int count = recipients.Count;
		foreach (CmsRecipient recipient in recipients)
		{
			int encryptionAlgorithmCount = EncryptionAlgorithmCount;
			EncryptionAlgorithm[] encryptionAlgorithms = recipient.EncryptionAlgorithms;
			foreach (EncryptionAlgorithm encryptionAlgorithm in encryptionAlgorithms)
			{
				array[(int)encryptionAlgorithm]++;
			}
		}
		EncryptionAlgorithm result = EncryptionAlgorithm.TripleDes;
		int num = 0;
		array[8] = count;
		EncryptionAlgorithm[] array2 = base.EncryptionAlgorithmRank;
		foreach (EncryptionAlgorithm encryptionAlgorithm2 in array2)
		{
			if (IsEnabled(encryptionAlgorithm2) && array[(int)encryptionAlgorithm2] > num)
			{
				num = array[(int)encryptionAlgorithm2];
				result = encryptionAlgorithm2;
			}
		}
		return result;
	}

	public ApplicationPkcs7Mime Compress(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		CmsCompressedDataGenerator cmsCompressedDataGenerator = new CmsCompressedDataGenerator();
		CmsProcessableInputStream content = new CmsProcessableInputStream(stream);
		CmsCompressedData cmsCompressedData = cmsCompressedDataGenerator.Generate(content, "1.2.840.113549.1.9.16.3.8");
		byte[] encoded = cmsCompressedData.GetEncoded();
		return new ApplicationPkcs7Mime(SecureMimeType.CompressedData, new MemoryStream(encoded, writable: false));
	}

	public MimeEntity Decompress(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		CmsCompressedDataParser cmsCompressedDataParser = new CmsCompressedDataParser(stream);
		CmsTypedStream content = cmsCompressedDataParser.GetContent();
		return MimeEntity.Load(content.ContentStream);
	}

	public virtual void DecompressTo(Stream stream, Stream output)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		CmsCompressedDataParser cmsCompressedDataParser = new CmsCompressedDataParser(stream);
		CmsTypedStream content = cmsCompressedDataParser.GetContent();
		content.ContentStream.CopyTo(output, 4096);
	}

	internal SmimeCapabilitiesAttribute GetSecureMimeCapabilitiesAttribute(bool includeRsaesOaep)
	{
		SmimeCapabilityVector smimeCapabilityVector = new SmimeCapabilityVector();
		EncryptionAlgorithm[] array = base.EncryptionAlgorithmRank;
		foreach (EncryptionAlgorithm encryptionAlgorithm in array)
		{
			if (IsEnabled(encryptionAlgorithm))
			{
				switch (encryptionAlgorithm)
				{
				case EncryptionAlgorithm.Aes128:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.Aes128Cbc);
					break;
				case EncryptionAlgorithm.Aes192:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.Aes192Cbc);
					break;
				case EncryptionAlgorithm.Aes256:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.Aes256Cbc);
					break;
				case EncryptionAlgorithm.Blowfish:
					smimeCapabilityVector.AddCapability(Blowfish);
					break;
				case EncryptionAlgorithm.Camellia128:
					smimeCapabilityVector.AddCapability(NttObjectIdentifiers.IdCamellia128Cbc);
					break;
				case EncryptionAlgorithm.Camellia192:
					smimeCapabilityVector.AddCapability(NttObjectIdentifiers.IdCamellia192Cbc);
					break;
				case EncryptionAlgorithm.Camellia256:
					smimeCapabilityVector.AddCapability(NttObjectIdentifiers.IdCamellia256Cbc);
					break;
				case EncryptionAlgorithm.Cast5:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.Cast5Cbc);
					break;
				case EncryptionAlgorithm.Des:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.DesCbc);
					break;
				case EncryptionAlgorithm.Idea:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.IdeaCbc);
					break;
				case EncryptionAlgorithm.RC240:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.RC2Cbc, 40);
					break;
				case EncryptionAlgorithm.RC264:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.RC2Cbc, 64);
					break;
				case EncryptionAlgorithm.RC2128:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.RC2Cbc, 128);
					break;
				case EncryptionAlgorithm.Seed:
					smimeCapabilityVector.AddCapability(KisaObjectIdentifiers.IdSeedCbc);
					break;
				case EncryptionAlgorithm.TripleDes:
					smimeCapabilityVector.AddCapability(SmimeCapabilities.DesEde3Cbc);
					break;
				}
			}
		}
		if (includeRsaesOaep)
		{
			smimeCapabilityVector.AddCapability(PkcsObjectIdentifiers.IdRsaesOaep, RsaEncryptionPadding.OaepSha1.GetRsaesOaepParameters());
			smimeCapabilityVector.AddCapability(PkcsObjectIdentifiers.IdRsaesOaep, RsaEncryptionPadding.OaepSha256.GetRsaesOaepParameters());
			smimeCapabilityVector.AddCapability(PkcsObjectIdentifiers.IdRsaesOaep, RsaEncryptionPadding.OaepSha384.GetRsaesOaepParameters());
			smimeCapabilityVector.AddCapability(PkcsObjectIdentifiers.IdRsaesOaep, RsaEncryptionPadding.OaepSha512.GetRsaesOaepParameters());
		}
		return new SmimeCapabilitiesAttribute(smimeCapabilityVector);
	}

	public abstract ApplicationPkcs7Mime EncapsulatedSign(CmsSigner signer, Stream content);

	public abstract ApplicationPkcs7Mime EncapsulatedSign(MailboxAddress signer, DigestAlgorithm digestAlgo, Stream content);

	public abstract ApplicationPkcs7Signature Sign(CmsSigner signer, Stream content);

	public abstract DigitalSignatureCollection Verify(Stream signedData, out MimeEntity entity, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Stream Verify(Stream signedData, out DigitalSignatureCollection signatures, CancellationToken cancellationToken = default(CancellationToken));

	public abstract ApplicationPkcs7Mime Encrypt(CmsRecipientCollection recipients, Stream content);

	public abstract void DecryptTo(Stream encryptedData, Stream decryptedData);

	public abstract void Import(Stream stream, string password);

	public virtual void Import(string fileName, string password)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		using FileStream stream = File.OpenRead(fileName);
		Import(stream, password);
	}

	public abstract void Import(X509Certificate certificate);

	public abstract void Import(X509Crl crl);

	public override void Import(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		CmsSignedDataParser cmsSignedDataParser = new CmsSignedDataParser(stream);
		IX509Store certificates = cmsSignedDataParser.GetCertificates("Collection");
		foreach (X509Certificate match in certificates.GetMatches(null))
		{
			Import(match);
		}
		IX509Store crls = cmsSignedDataParser.GetCrls("Collection");
		foreach (X509Crl match2 in crls.GetMatches(null))
		{
			Import(match2);
		}
	}
}
