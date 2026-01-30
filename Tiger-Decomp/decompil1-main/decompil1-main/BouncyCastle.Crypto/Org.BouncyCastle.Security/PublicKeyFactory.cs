using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security;

public sealed class PublicKeyFactory
{
	private PublicKeyFactory()
	{
	}

	public static AsymmetricKeyParameter CreateKey(byte[] keyInfoData)
	{
		return CreateKey(SubjectPublicKeyInfo.GetInstance(Asn1Object.FromByteArray(keyInfoData)));
	}

	public static AsymmetricKeyParameter CreateKey(Stream inStr)
	{
		return CreateKey(SubjectPublicKeyInfo.GetInstance(Asn1Object.FromStream(inStr)));
	}

	public static AsymmetricKeyParameter CreateKey(SubjectPublicKeyInfo keyInfo)
	{
		AlgorithmIdentifier algID = keyInfo.AlgorithmID;
		DerObjectIdentifier algOid = algID.Algorithm;
		if (algOid.Equals(PkcsObjectIdentifiers.RsaEncryption) || algOid.Equals(X509ObjectIdentifiers.IdEARsa) || algOid.Equals(PkcsObjectIdentifiers.IdRsassaPss) || algOid.Equals(PkcsObjectIdentifiers.IdRsaesOaep))
		{
			RsaPublicKeyStructure pubKey = RsaPublicKeyStructure.GetInstance(keyInfo.ParsePublicKey());
			return new RsaKeyParameters(isPrivate: false, pubKey.Modulus, pubKey.PublicExponent);
		}
		if (algOid.Equals(X9ObjectIdentifiers.DHPublicNumber))
		{
			Asn1Sequence seq = Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object());
			BigInteger y = DHPublicKey.GetInstance(keyInfo.ParsePublicKey()).Y.Value;
			if (IsPkcsDHParam(seq))
			{
				return ReadPkcsDHParam(algOid, y, seq);
			}
			DHDomainParameters dhParams = DHDomainParameters.GetInstance(seq);
			BigInteger p = dhParams.P.Value;
			BigInteger g = dhParams.G.Value;
			BigInteger q = dhParams.Q.Value;
			BigInteger j = null;
			if (dhParams.J != null)
			{
				j = dhParams.J.Value;
			}
			DHValidationParameters validation = null;
			DHValidationParms dhValidationParms = dhParams.ValidationParms;
			if (dhValidationParms != null)
			{
				byte[] seed = dhValidationParms.Seed.GetBytes();
				BigInteger pgenCounter = dhValidationParms.PgenCounter.Value;
				validation = new DHValidationParameters(seed, pgenCounter.IntValue);
			}
			return new DHPublicKeyParameters(y, new DHParameters(p, g, q, j, validation));
		}
		if (algOid.Equals(PkcsObjectIdentifiers.DhKeyAgreement))
		{
			Asn1Sequence seq2 = Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object());
			DerInteger derY = (DerInteger)keyInfo.ParsePublicKey();
			return ReadPkcsDHParam(algOid, derY.Value, seq2);
		}
		if (algOid.Equals(OiwObjectIdentifiers.ElGamalAlgorithm))
		{
			ElGamalParameter para = new ElGamalParameter(Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object()));
			return new ElGamalPublicKeyParameters(((DerInteger)keyInfo.ParsePublicKey()).Value, new ElGamalParameters(para.P, para.G));
		}
		if (algOid.Equals(X9ObjectIdentifiers.IdDsa) || algOid.Equals(OiwObjectIdentifiers.DsaWithSha1))
		{
			DerInteger obj = (DerInteger)keyInfo.ParsePublicKey();
			Asn1Encodable ae = algID.Parameters;
			DsaParameters parameters = null;
			if (ae != null)
			{
				DsaParameter para2 = DsaParameter.GetInstance(ae.ToAsn1Object());
				parameters = new DsaParameters(para2.P, para2.Q, para2.G);
			}
			return new DsaPublicKeyParameters(obj.Value, parameters);
		}
		if (algOid.Equals(X9ObjectIdentifiers.IdECPublicKey))
		{
			X962Parameters para3 = X962Parameters.GetInstance(algID.Parameters.ToAsn1Object());
			X9ECParameters x9 = ((!para3.IsNamedCurve) ? new X9ECParameters((Asn1Sequence)para3.Parameters) : ECKeyPairGenerator.FindECCurveByOid((DerObjectIdentifier)para3.Parameters));
			Asn1OctetString key = new DerOctetString(keyInfo.PublicKeyData.GetBytes());
			ECPoint q2 = new X9ECPoint(x9.Curve, key).Point;
			if (para3.IsNamedCurve)
			{
				return new ECPublicKeyParameters("EC", q2, (DerObjectIdentifier)para3.Parameters);
			}
			ECDomainParameters dParams = new ECDomainParameters(x9);
			return new ECPublicKeyParameters(q2, dParams);
		}
		if (algOid.Equals(CryptoProObjectIdentifiers.GostR3410x2001))
		{
			DerObjectIdentifier publicKeyParamSet = Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters).PublicKeyParamSet;
			X9ECParameters ecP = ECGost3410NamedCurves.GetByOidX9(publicKeyParamSet);
			if (ecP == null)
			{
				return null;
			}
			Asn1OctetString key2;
			try
			{
				key2 = (Asn1OctetString)keyInfo.ParsePublicKey();
			}
			catch (IOException innerException)
			{
				throw new ArgumentException("error recovering GOST3410_2001 public key", innerException);
			}
			int fieldSize = 32;
			int keySize = 2 * fieldSize;
			byte[] keyEnc = key2.GetOctets();
			if (keyEnc.Length != keySize)
			{
				throw new ArgumentException("invalid length for GOST3410_2001 public key");
			}
			byte[] x9Encoding = new byte[1 + keySize];
			x9Encoding[0] = 4;
			for (int i = 1; i <= fieldSize; i++)
			{
				x9Encoding[i] = keyEnc[fieldSize - i];
				x9Encoding[i + fieldSize] = keyEnc[keySize - i];
			}
			ECPoint q3 = ecP.Curve.DecodePoint(x9Encoding);
			return new ECPublicKeyParameters("ECGOST3410", q3, publicKeyParamSet);
		}
		if (algOid.Equals(CryptoProObjectIdentifiers.GostR3410x94))
		{
			Gost3410PublicKeyAlgParameters algParams = Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters);
			Asn1OctetString key3;
			try
			{
				key3 = (Asn1OctetString)keyInfo.ParsePublicKey();
			}
			catch (IOException innerException2)
			{
				throw new ArgumentException("error recovering GOST3410_94 public key", innerException2);
			}
			byte[] keyBytes = Arrays.Reverse(key3.GetOctets());
			return new Gost3410PublicKeyParameters(new BigInteger(1, keyBytes), algParams.PublicKeyParamSet);
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_X25519))
		{
			return new X25519PublicKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_X448))
		{
			return new X448PublicKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_Ed25519))
		{
			return new Ed25519PublicKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_Ed448))
		{
			return new Ed448PublicKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256) || algOid.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512))
		{
			Gost3410PublicKeyAlgParameters gostParams = Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters);
			DerObjectIdentifier publicKeyParamSet2 = gostParams.PublicKeyParamSet;
			ECGost3410Parameters ecDomainParameters = new ECGost3410Parameters(new ECNamedDomainParameters(publicKeyParamSet2, ECGost3410NamedCurves.GetByOidX9(publicKeyParamSet2)), publicKeyParamSet2, gostParams.DigestParamSet, gostParams.EncryptionParamSet);
			Asn1OctetString key4;
			try
			{
				key4 = (Asn1OctetString)keyInfo.ParsePublicKey();
			}
			catch (IOException innerException3)
			{
				throw new ArgumentException("error recovering GOST3410_2012 public key", innerException3);
			}
			int fieldSize2 = 32;
			if (algOid.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512))
			{
				fieldSize2 = 64;
			}
			int keySize2 = 2 * fieldSize2;
			byte[] keyEnc2 = key4.GetOctets();
			if (keyEnc2.Length != keySize2)
			{
				throw new ArgumentException("invalid length for GOST3410_2012 public key");
			}
			byte[] x9Encoding2 = new byte[1 + keySize2];
			x9Encoding2[0] = 4;
			for (int k = 1; k <= fieldSize2; k++)
			{
				x9Encoding2[k] = keyEnc2[fieldSize2 - k];
				x9Encoding2[k + fieldSize2] = keyEnc2[keySize2 - k];
			}
			return new ECPublicKeyParameters(ecDomainParameters.Curve.DecodePoint(x9Encoding2), ecDomainParameters);
		}
		throw new SecurityUtilityException("algorithm identifier in public key not recognised: " + algOid);
	}

	private static byte[] GetRawKey(SubjectPublicKeyInfo keyInfo)
	{
		return keyInfo.PublicKeyData.GetOctets();
	}

	private static bool IsPkcsDHParam(Asn1Sequence seq)
	{
		if (seq.Count == 2)
		{
			return true;
		}
		if (seq.Count > 3)
		{
			return false;
		}
		DerInteger instance = DerInteger.GetInstance(seq[2]);
		DerInteger p = DerInteger.GetInstance(seq[0]);
		return instance.Value.CompareTo(BigInteger.ValueOf(p.Value.BitLength)) <= 0;
	}

	private static DHPublicKeyParameters ReadPkcsDHParam(DerObjectIdentifier algOid, BigInteger y, Asn1Sequence seq)
	{
		DHParameter para = new DHParameter(seq);
		int l = para.L?.IntValue ?? 0;
		DHParameters dhParams = new DHParameters(para.P, para.G, null, l);
		return new DHPublicKeyParameters(y, dhParams, algOid);
	}
}
