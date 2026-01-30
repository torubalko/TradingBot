using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public abstract class RsaUtilities
{
	private static readonly byte[] RSAPSSParams_256_A;

	private static readonly byte[] RSAPSSParams_384_A;

	private static readonly byte[] RSAPSSParams_512_A;

	private static readonly byte[] RSAPSSParams_256_B;

	private static readonly byte[] RSAPSSParams_384_B;

	private static readonly byte[] RSAPSSParams_512_B;

	static RsaUtilities()
	{
		AlgorithmIdentifier sha256Identifier_A = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha256);
		AlgorithmIdentifier sha384Identifier_A = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha384);
		AlgorithmIdentifier sha512Identifier_A = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha512);
		AlgorithmIdentifier sha256Identifier_B = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha256, DerNull.Instance);
		AlgorithmIdentifier sha384Identifier_B = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha384, DerNull.Instance);
		AlgorithmIdentifier sha512Identifier_B = new AlgorithmIdentifier(NistObjectIdentifiers.IdSha512, DerNull.Instance);
		AlgorithmIdentifier mgf1SHA256Identifier_A = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, sha256Identifier_A);
		AlgorithmIdentifier mgf1SHA384Identifier_A = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, sha384Identifier_A);
		AlgorithmIdentifier mgf1SHA512Identifier_A = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, sha512Identifier_A);
		AlgorithmIdentifier mgf1SHA256Identifier_B = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, sha256Identifier_B);
		AlgorithmIdentifier mgf1SHA384Identifier_B = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, sha384Identifier_B);
		AlgorithmIdentifier mgf1SHA512Identifier_B = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, sha512Identifier_B);
		DerInteger sha256Size = new DerInteger(TlsCryptoUtilities.GetHashOutputSize(4));
		DerInteger sha384Size = new DerInteger(TlsCryptoUtilities.GetHashOutputSize(5));
		DerInteger sha512Size = new DerInteger(TlsCryptoUtilities.GetHashOutputSize(6));
		DerInteger trailerField = new DerInteger(1);
		try
		{
			RSAPSSParams_256_A = new RsassaPssParameters(sha256Identifier_A, mgf1SHA256Identifier_A, sha256Size, trailerField).GetEncoded("DER");
			RSAPSSParams_384_A = new RsassaPssParameters(sha384Identifier_A, mgf1SHA384Identifier_A, sha384Size, trailerField).GetEncoded("DER");
			RSAPSSParams_512_A = new RsassaPssParameters(sha512Identifier_A, mgf1SHA512Identifier_A, sha512Size, trailerField).GetEncoded("DER");
			RSAPSSParams_256_B = new RsassaPssParameters(sha256Identifier_B, mgf1SHA256Identifier_B, sha256Size, trailerField).GetEncoded("DER");
			RSAPSSParams_384_B = new RsassaPssParameters(sha384Identifier_B, mgf1SHA384Identifier_B, sha384Size, trailerField).GetEncoded("DER");
			RSAPSSParams_512_B = new RsassaPssParameters(sha512Identifier_B, mgf1SHA512Identifier_B, sha512Size, trailerField).GetEncoded("DER");
		}
		catch (IOException ex)
		{
			throw new InvalidOperationException(ex.Message);
		}
	}

	public static bool SupportsPkcs1(AlgorithmIdentifier pubKeyAlgID)
	{
		DerObjectIdentifier oid = pubKeyAlgID.Algorithm;
		if (!PkcsObjectIdentifiers.RsaEncryption.Equals(oid))
		{
			return X509ObjectIdentifiers.IdEARsa.Equals(oid);
		}
		return true;
	}

	public static bool SupportsPss_Pss(short signatureAlgorithm, AlgorithmIdentifier pubKeyAlgID)
	{
		DerObjectIdentifier oid = pubKeyAlgID.Algorithm;
		if (!PkcsObjectIdentifiers.IdRsassaPss.Equals(oid))
		{
			return false;
		}
		Asn1Encodable pssParams = pubKeyAlgID.Parameters;
		if (pssParams == null || pssParams is DerNull)
		{
			if ((uint)(signatureAlgorithm - 9) <= 2u)
			{
				return true;
			}
			return false;
		}
		byte[] encoded;
		try
		{
			encoded = pssParams.ToAsn1Object().GetEncoded("DER");
		}
		catch (Exception)
		{
			return false;
		}
		byte[] expected_A;
		byte[] expected_B;
		switch (signatureAlgorithm)
		{
		case 9:
			expected_A = RSAPSSParams_256_A;
			expected_B = RSAPSSParams_256_B;
			break;
		case 10:
			expected_A = RSAPSSParams_384_A;
			expected_B = RSAPSSParams_384_B;
			break;
		case 11:
			expected_A = RSAPSSParams_512_A;
			expected_B = RSAPSSParams_512_B;
			break;
		default:
			return false;
		}
		if (!Arrays.AreEqual(expected_A, encoded))
		{
			return Arrays.AreEqual(expected_B, encoded);
		}
		return true;
	}

	public static bool SupportsPss_Rsae(AlgorithmIdentifier pubKeyAlgID)
	{
		DerObjectIdentifier oid = pubKeyAlgID.Algorithm;
		return PkcsObjectIdentifiers.RsaEncryption.Equals(oid);
	}
}
