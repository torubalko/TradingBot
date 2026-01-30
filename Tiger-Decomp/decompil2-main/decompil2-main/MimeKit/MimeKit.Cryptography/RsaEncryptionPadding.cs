using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace MimeKit.Cryptography;

public sealed class RsaEncryptionPadding : IEquatable<RsaEncryptionPadding>
{
	public static readonly RsaEncryptionPadding Pkcs1 = new RsaEncryptionPadding(RsaEncryptionPaddingScheme.Pkcs1, DigestAlgorithm.None);

	public static readonly RsaEncryptionPadding OaepSha1 = new RsaEncryptionPadding(RsaEncryptionPaddingScheme.Oaep, DigestAlgorithm.Sha1);

	public static readonly RsaEncryptionPadding OaepSha256 = new RsaEncryptionPadding(RsaEncryptionPaddingScheme.Oaep, DigestAlgorithm.Sha256);

	public static readonly RsaEncryptionPadding OaepSha384 = new RsaEncryptionPadding(RsaEncryptionPaddingScheme.Oaep, DigestAlgorithm.Sha384);

	public static readonly RsaEncryptionPadding OaepSha512 = new RsaEncryptionPadding(RsaEncryptionPaddingScheme.Oaep, DigestAlgorithm.Sha512);

	public RsaEncryptionPaddingScheme Scheme { get; private set; }

	public DigestAlgorithm OaepHashAlgorithm { get; private set; }

	private RsaEncryptionPadding(RsaEncryptionPaddingScheme scheme, DigestAlgorithm oaepHashAlgorithm)
	{
		OaepHashAlgorithm = oaepHashAlgorithm;
		Scheme = scheme;
	}

	public bool Equals(RsaEncryptionPadding other)
	{
		if (other == null)
		{
			return false;
		}
		if (other.Scheme == Scheme)
		{
			return other.OaepHashAlgorithm == OaepHashAlgorithm;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as RsaEncryptionPadding);
	}

	public override int GetHashCode()
	{
		int hashCode = Scheme.GetHashCode();
		return ((hashCode << 5) + hashCode) ^ OaepHashAlgorithm.GetHashCode();
	}

	public override string ToString()
	{
		if (Scheme != RsaEncryptionPaddingScheme.Pkcs1)
		{
			return "Oaep" + OaepHashAlgorithm;
		}
		return "Pkcs1";
	}

	public static bool operator ==(RsaEncryptionPadding left, RsaEncryptionPadding right)
	{
		return left?.Equals(right) ?? ((object)right == null);
	}

	public static bool operator !=(RsaEncryptionPadding left, RsaEncryptionPadding right)
	{
		return !(left == right);
	}

	public static RsaEncryptionPadding CreateOaep(DigestAlgorithm hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			DigestAlgorithm.Sha1 => OaepSha1, 
			DigestAlgorithm.Sha256 => OaepSha256, 
			DigestAlgorithm.Sha384 => OaepSha384, 
			DigestAlgorithm.Sha512 => OaepSha512, 
			_ => throw new NotSupportedException($"The {hashAlgorithm} hash algorithm is not supported."), 
		};
	}

	internal RsaesOaepParameters GetRsaesOaepParameters()
	{
		if (OaepHashAlgorithm == DigestAlgorithm.Sha1)
		{
			return new RsaesOaepParameters();
		}
		string digestOid = SecureMimeContext.GetDigestOid(OaepHashAlgorithm);
		AlgorithmIdentifier algorithmIdentifier = new AlgorithmIdentifier(new DerObjectIdentifier(digestOid), DerNull.Instance);
		AlgorithmIdentifier maskGenAlgorithm = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, algorithmIdentifier);
		return new RsaesOaepParameters(algorithmIdentifier, maskGenAlgorithm, RsaesOaepParameters.DefaultPSourceAlgorithm);
	}

	internal AlgorithmIdentifier GetAlgorithmIdentifier()
	{
		if (Scheme != RsaEncryptionPaddingScheme.Oaep)
		{
			return null;
		}
		return new AlgorithmIdentifier(PkcsObjectIdentifiers.IdRsaesOaep, GetRsaesOaepParameters());
	}
}
