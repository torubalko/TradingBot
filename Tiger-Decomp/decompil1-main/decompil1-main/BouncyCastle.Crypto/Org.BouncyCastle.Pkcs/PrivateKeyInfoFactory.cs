using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Pkcs;

public sealed class PrivateKeyInfoFactory
{
	private PrivateKeyInfoFactory()
	{
	}

	public static PrivateKeyInfo CreatePrivateKeyInfo(AsymmetricKeyParameter privateKey)
	{
		return CreatePrivateKeyInfo(privateKey, null);
	}

	public static PrivateKeyInfo CreatePrivateKeyInfo(AsymmetricKeyParameter privateKey, Asn1Set attributes)
	{
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (!privateKey.IsPrivate)
		{
			throw new ArgumentException("Public key passed - private key expected", "privateKey");
		}
		if (privateKey is ElGamalPrivateKeyParameters)
		{
			ElGamalPrivateKeyParameters _key = (ElGamalPrivateKeyParameters)privateKey;
			ElGamalParameters egp = _key.Parameters;
			return new PrivateKeyInfo(new AlgorithmIdentifier(OiwObjectIdentifiers.ElGamalAlgorithm, new ElGamalParameter(egp.P, egp.G).ToAsn1Object()), new DerInteger(_key.X), attributes);
		}
		if (privateKey is DsaPrivateKeyParameters)
		{
			DsaPrivateKeyParameters _key2 = (DsaPrivateKeyParameters)privateKey;
			DsaParameters dp = _key2.Parameters;
			return new PrivateKeyInfo(new AlgorithmIdentifier(X9ObjectIdentifiers.IdDsa, new DsaParameter(dp.P, dp.Q, dp.G).ToAsn1Object()), new DerInteger(_key2.X), attributes);
		}
		if (privateKey is DHPrivateKeyParameters)
		{
			DHPrivateKeyParameters _key3 = (DHPrivateKeyParameters)privateKey;
			DHParameter p = new DHParameter(_key3.Parameters.P, _key3.Parameters.G, _key3.Parameters.L);
			return new PrivateKeyInfo(new AlgorithmIdentifier(_key3.AlgorithmOid, p.ToAsn1Object()), new DerInteger(_key3.X), attributes);
		}
		if (privateKey is RsaKeyParameters)
		{
			AlgorithmIdentifier privateKeyAlgorithm = new AlgorithmIdentifier(PkcsObjectIdentifiers.RsaEncryption, DerNull.Instance);
			RsaPrivateKeyStructure keyStruct;
			if (privateKey is RsaPrivateCrtKeyParameters)
			{
				RsaPrivateCrtKeyParameters _key4 = (RsaPrivateCrtKeyParameters)privateKey;
				keyStruct = new RsaPrivateKeyStructure(_key4.Modulus, _key4.PublicExponent, _key4.Exponent, _key4.P, _key4.Q, _key4.DP, _key4.DQ, _key4.QInv);
			}
			else
			{
				RsaKeyParameters _key5 = (RsaKeyParameters)privateKey;
				keyStruct = new RsaPrivateKeyStructure(_key5.Modulus, BigInteger.Zero, _key5.Exponent, BigInteger.Zero, BigInteger.Zero, BigInteger.Zero, BigInteger.Zero, BigInteger.Zero);
			}
			return new PrivateKeyInfo(privateKeyAlgorithm, keyStruct.ToAsn1Object(), attributes);
		}
		if (privateKey is ECPrivateKeyParameters)
		{
			ECPrivateKeyParameters priv = (ECPrivateKeyParameters)privateKey;
			DerBitString publicKey = new DerBitString(ECKeyPairGenerator.GetCorrespondingPublicKey(priv).Q.GetEncoded(compressed: false));
			ECDomainParameters dp2 = priv.Parameters;
			if (dp2 is ECGost3410Parameters)
			{
				ECGost3410Parameters domainParameters = (ECGost3410Parameters)dp2;
				Gost3410PublicKeyAlgParameters gostParams = new Gost3410PublicKeyAlgParameters(domainParameters.PublicKeyParamSet, domainParameters.DigestParamSet, domainParameters.EncryptionParamSet);
				bool num = priv.D.BitLength > 256;
				DerObjectIdentifier identifier = (num ? RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512 : RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256);
				int size = (num ? 64 : 32);
				byte[] encKey = new byte[size];
				ExtractBytes(encKey, size, 0, priv.D);
				return new PrivateKeyInfo(new AlgorithmIdentifier(identifier, gostParams), new DerOctetString(encKey));
			}
			int orderBitLength = dp2.N.BitLength;
			AlgorithmIdentifier algID;
			ECPrivateKeyStructure ec;
			if (priv.AlgorithmName == "ECGOST3410")
			{
				if (priv.PublicKeyParamSet == null)
				{
					throw Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
				}
				Gost3410PublicKeyAlgParameters gostParams2 = new Gost3410PublicKeyAlgParameters(priv.PublicKeyParamSet, CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet);
				algID = new AlgorithmIdentifier(CryptoProObjectIdentifiers.GostR3410x2001, gostParams2);
				ec = new ECPrivateKeyStructure(orderBitLength, priv.D, publicKey, null);
			}
			else
			{
				X962Parameters x962 = ((priv.PublicKeyParamSet != null) ? new X962Parameters(priv.PublicKeyParamSet) : new X962Parameters(new X9ECParameters(dp2.Curve, dp2.G, dp2.N, dp2.H, dp2.GetSeed())));
				ec = new ECPrivateKeyStructure(orderBitLength, priv.D, publicKey, x962);
				algID = new AlgorithmIdentifier(X9ObjectIdentifiers.IdECPublicKey, x962);
			}
			return new PrivateKeyInfo(algID, ec, attributes);
		}
		if (privateKey is Gost3410PrivateKeyParameters)
		{
			Gost3410PrivateKeyParameters _key6 = (Gost3410PrivateKeyParameters)privateKey;
			if (_key6.PublicKeyParamSet == null)
			{
				throw Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
			}
			byte[] keyEnc = _key6.X.ToByteArrayUnsigned();
			byte[] keyBytes = new byte[keyEnc.Length];
			for (int i = 0; i != keyBytes.Length; i++)
			{
				keyBytes[i] = keyEnc[keyEnc.Length - 1 - i];
			}
			Gost3410PublicKeyAlgParameters algParams = new Gost3410PublicKeyAlgParameters(_key6.PublicKeyParamSet, CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet, null);
			return new PrivateKeyInfo(new AlgorithmIdentifier(CryptoProObjectIdentifiers.GostR3410x94, algParams.ToAsn1Object()), new DerOctetString(keyBytes), attributes);
		}
		if (privateKey is X448PrivateKeyParameters)
		{
			X448PrivateKeyParameters key = (X448PrivateKeyParameters)privateKey;
			return new PrivateKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_X448), new DerOctetString(key.GetEncoded()), attributes, key.GeneratePublicKey().GetEncoded());
		}
		if (privateKey is X25519PrivateKeyParameters)
		{
			X25519PrivateKeyParameters key2 = (X25519PrivateKeyParameters)privateKey;
			return new PrivateKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_X25519), new DerOctetString(key2.GetEncoded()), attributes, key2.GeneratePublicKey().GetEncoded());
		}
		if (privateKey is Ed448PrivateKeyParameters)
		{
			Ed448PrivateKeyParameters key3 = (Ed448PrivateKeyParameters)privateKey;
			return new PrivateKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_Ed448), new DerOctetString(key3.GetEncoded()), attributes, key3.GeneratePublicKey().GetEncoded());
		}
		if (privateKey is Ed25519PrivateKeyParameters)
		{
			Ed25519PrivateKeyParameters key4 = (Ed25519PrivateKeyParameters)privateKey;
			return new PrivateKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_Ed25519), new DerOctetString(key4.GetEncoded()), attributes, key4.GeneratePublicKey().GetEncoded());
		}
		throw new ArgumentException("Class provided is not convertible: " + Platform.GetTypeName(privateKey));
	}

	public static PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, EncryptedPrivateKeyInfo encInfo)
	{
		return CreatePrivateKeyInfo(passPhrase, wrongPkcs12Zero: false, encInfo);
	}

	public static PrivateKeyInfo CreatePrivateKeyInfo(char[] passPhrase, bool wrongPkcs12Zero, EncryptedPrivateKeyInfo encInfo)
	{
		AlgorithmIdentifier algID = encInfo.EncryptionAlgorithm;
		IBufferedCipher obj = (PbeUtilities.CreateEngine(algID) as IBufferedCipher) ?? throw new Exception("Unknown encryption algorithm: " + algID.Algorithm);
		ICipherParameters cipherParameters = PbeUtilities.GenerateCipherParameters(algID, passPhrase, wrongPkcs12Zero);
		obj.Init(forEncryption: false, cipherParameters);
		return PrivateKeyInfo.GetInstance(obj.DoFinal(encInfo.GetEncryptedData()));
	}

	private static void ExtractBytes(byte[] encKey, int size, int offSet, BigInteger bI)
	{
		byte[] val = bI.ToByteArray();
		if (val.Length < size)
		{
			byte[] tmp = new byte[size];
			Array.Copy(val, 0, tmp, tmp.Length - val.Length, val.Length);
			val = tmp;
		}
		for (int i = 0; i != size; i++)
		{
			encKey[offSet + i] = val[val.Length - 1 - i];
		}
	}
}
