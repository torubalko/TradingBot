using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509;

public sealed class SubjectPublicKeyInfoFactory
{
	private SubjectPublicKeyInfoFactory()
	{
	}

	public static SubjectPublicKeyInfo CreateSubjectPublicKeyInfo(AsymmetricKeyParameter publicKey)
	{
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		if (publicKey.IsPrivate)
		{
			throw new ArgumentException("Private key passed - public key expected.", "publicKey");
		}
		if (publicKey is ElGamalPublicKeyParameters)
		{
			ElGamalPublicKeyParameters _key = (ElGamalPublicKeyParameters)publicKey;
			ElGamalParameters kp = _key.Parameters;
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(OiwObjectIdentifiers.ElGamalAlgorithm, new ElGamalParameter(kp.P, kp.G).ToAsn1Object()), new DerInteger(_key.Y));
		}
		if (publicKey is DsaPublicKeyParameters)
		{
			DsaPublicKeyParameters _key2 = (DsaPublicKeyParameters)publicKey;
			DsaParameters kp2 = _key2.Parameters;
			Asn1Encodable ae = ((kp2 == null) ? null : new DsaParameter(kp2.P, kp2.Q, kp2.G).ToAsn1Object());
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(X9ObjectIdentifiers.IdDsa, ae), new DerInteger(_key2.Y));
		}
		if (publicKey is DHPublicKeyParameters)
		{
			DHPublicKeyParameters _key3 = (DHPublicKeyParameters)publicKey;
			DHParameters kp3 = _key3.Parameters;
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(_key3.AlgorithmOid, new DHParameter(kp3.P, kp3.G, kp3.L).ToAsn1Object()), new DerInteger(_key3.Y));
		}
		if (publicKey is RsaKeyParameters)
		{
			RsaKeyParameters _key4 = (RsaKeyParameters)publicKey;
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(PkcsObjectIdentifiers.RsaEncryption, DerNull.Instance), new RsaPublicKeyStructure(_key4.Modulus, _key4.Exponent).ToAsn1Object());
		}
		if (publicKey is ECPublicKeyParameters)
		{
			ECPublicKeyParameters _key5 = (ECPublicKeyParameters)publicKey;
			if (_key5.Parameters is ECGost3410Parameters)
			{
				ECGost3410Parameters gostParams = (ECGost3410Parameters)_key5.Parameters;
				BigInteger bX = _key5.Q.AffineXCoord.ToBigInteger();
				BigInteger bY = _key5.Q.AffineYCoord.ToBigInteger();
				bool num = bX.BitLength > 256;
				Gost3410PublicKeyAlgParameters parameters = new Gost3410PublicKeyAlgParameters(gostParams.PublicKeyParamSet, gostParams.DigestParamSet, gostParams.EncryptionParamSet);
				int encKeySize;
				int offset;
				DerObjectIdentifier algIdentifier;
				if (num)
				{
					encKeySize = 128;
					offset = 64;
					algIdentifier = RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512;
				}
				else
				{
					encKeySize = 64;
					offset = 32;
					algIdentifier = RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256;
				}
				byte[] encKey = new byte[encKeySize];
				ExtractBytes(encKey, encKeySize / 2, 0, bX);
				ExtractBytes(encKey, encKeySize / 2, offset, bY);
				return new SubjectPublicKeyInfo(new AlgorithmIdentifier(algIdentifier, parameters), new DerOctetString(encKey));
			}
			if (_key5.AlgorithmName == "ECGOST3410")
			{
				if (_key5.PublicKeyParamSet == null)
				{
					throw Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
				}
				ECPoint eCPoint = _key5.Q.Normalize();
				BigInteger bX2 = eCPoint.AffineXCoord.ToBigInteger();
				BigInteger bY2 = eCPoint.AffineYCoord.ToBigInteger();
				byte[] encKey2 = new byte[64];
				ExtractBytes(encKey2, 0, bX2);
				ExtractBytes(encKey2, 32, bY2);
				Gost3410PublicKeyAlgParameters gostParams2 = new Gost3410PublicKeyAlgParameters(_key5.PublicKeyParamSet, CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet);
				return new SubjectPublicKeyInfo(new AlgorithmIdentifier(CryptoProObjectIdentifiers.GostR3410x2001, gostParams2.ToAsn1Object()), new DerOctetString(encKey2));
			}
			X962Parameters x962;
			if (_key5.PublicKeyParamSet == null)
			{
				ECDomainParameters kp4 = _key5.Parameters;
				x962 = new X962Parameters(new X9ECParameters(kp4.Curve, kp4.G, kp4.N, kp4.H, kp4.GetSeed()));
			}
			else
			{
				x962 = new X962Parameters(_key5.PublicKeyParamSet);
			}
			byte[] pubKey = _key5.Q.GetEncoded(compressed: false);
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(X9ObjectIdentifiers.IdECPublicKey, x962.ToAsn1Object()), pubKey);
		}
		if (publicKey is Gost3410PublicKeyParameters)
		{
			Gost3410PublicKeyParameters _key6 = (Gost3410PublicKeyParameters)publicKey;
			if (_key6.PublicKeyParamSet == null)
			{
				throw Platform.CreateNotImplementedException("Not a CryptoPro parameter set");
			}
			byte[] keyEnc = _key6.Y.ToByteArrayUnsigned();
			byte[] keyBytes = new byte[keyEnc.Length];
			for (int i = 0; i != keyBytes.Length; i++)
			{
				keyBytes[i] = keyEnc[keyEnc.Length - 1 - i];
			}
			Gost3410PublicKeyAlgParameters algParams = new Gost3410PublicKeyAlgParameters(_key6.PublicKeyParamSet, CryptoProObjectIdentifiers.GostR3411x94CryptoProParamSet);
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(CryptoProObjectIdentifiers.GostR3410x94, algParams.ToAsn1Object()), new DerOctetString(keyBytes));
		}
		if (publicKey is X448PublicKeyParameters)
		{
			X448PublicKeyParameters key = (X448PublicKeyParameters)publicKey;
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_X448), key.GetEncoded());
		}
		if (publicKey is X25519PublicKeyParameters)
		{
			X25519PublicKeyParameters key2 = (X25519PublicKeyParameters)publicKey;
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_X25519), key2.GetEncoded());
		}
		if (publicKey is Ed448PublicKeyParameters)
		{
			Ed448PublicKeyParameters key3 = (Ed448PublicKeyParameters)publicKey;
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_Ed448), key3.GetEncoded());
		}
		if (publicKey is Ed25519PublicKeyParameters)
		{
			Ed25519PublicKeyParameters key4 = (Ed25519PublicKeyParameters)publicKey;
			return new SubjectPublicKeyInfo(new AlgorithmIdentifier(EdECObjectIdentifiers.id_Ed25519), key4.GetEncoded());
		}
		throw new ArgumentException("Class provided no convertible: " + Platform.GetTypeName(publicKey));
	}

	private static void ExtractBytes(byte[] encKey, int offset, BigInteger bI)
	{
		byte[] val = bI.ToByteArray();
		int n = (bI.BitLength + 7) / 8;
		for (int i = 0; i < n; i++)
		{
			encKey[offset + i] = val[val.Length - 1 - i];
		}
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
