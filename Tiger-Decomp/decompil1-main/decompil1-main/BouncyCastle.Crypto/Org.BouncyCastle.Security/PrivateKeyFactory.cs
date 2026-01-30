using System;
using System.IO;
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
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security;

public sealed class PrivateKeyFactory
{
	private PrivateKeyFactory()
	{
	}

	public static AsymmetricKeyParameter CreateKey(byte[] privateKeyInfoData)
	{
		return CreateKey(PrivateKeyInfo.GetInstance(Asn1Object.FromByteArray(privateKeyInfoData)));
	}

	public static AsymmetricKeyParameter CreateKey(Stream inStr)
	{
		return CreateKey(PrivateKeyInfo.GetInstance(Asn1Object.FromStream(inStr)));
	}

	public static AsymmetricKeyParameter CreateKey(PrivateKeyInfo keyInfo)
	{
		AlgorithmIdentifier algID = keyInfo.PrivateKeyAlgorithm;
		DerObjectIdentifier algOid = algID.Algorithm;
		if (algOid.Equals(PkcsObjectIdentifiers.RsaEncryption) || algOid.Equals(X509ObjectIdentifiers.IdEARsa) || algOid.Equals(PkcsObjectIdentifiers.IdRsassaPss) || algOid.Equals(PkcsObjectIdentifiers.IdRsaesOaep))
		{
			RsaPrivateKeyStructure keyStructure = RsaPrivateKeyStructure.GetInstance(keyInfo.ParsePrivateKey());
			return new RsaPrivateCrtKeyParameters(keyStructure.Modulus, keyStructure.PublicExponent, keyStructure.PrivateExponent, keyStructure.Prime1, keyStructure.Prime2, keyStructure.Exponent1, keyStructure.Exponent2, keyStructure.Coefficient);
		}
		if (algOid.Equals(PkcsObjectIdentifiers.DhKeyAgreement))
		{
			DHParameter para = new DHParameter(Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object()));
			DerInteger obj = (DerInteger)keyInfo.ParsePrivateKey();
			return new DHPrivateKeyParameters(parameters: new DHParameters(l: para.L?.IntValue ?? 0, p: para.P, g: para.G, q: null), x: obj.Value, algorithmOid: algOid);
		}
		if (algOid.Equals(OiwObjectIdentifiers.ElGamalAlgorithm))
		{
			ElGamalParameter para2 = new ElGamalParameter(Asn1Sequence.GetInstance(algID.Parameters.ToAsn1Object()));
			return new ElGamalPrivateKeyParameters(((DerInteger)keyInfo.ParsePrivateKey()).Value, new ElGamalParameters(para2.P, para2.G));
		}
		if (algOid.Equals(X9ObjectIdentifiers.IdDsa))
		{
			DerInteger obj2 = (DerInteger)keyInfo.ParsePrivateKey();
			Asn1Encodable ae = algID.Parameters;
			DsaParameters parameters = null;
			if (ae != null)
			{
				DsaParameter para3 = DsaParameter.GetInstance(ae.ToAsn1Object());
				parameters = new DsaParameters(para3.P, para3.Q, para3.G);
			}
			return new DsaPrivateKeyParameters(obj2.Value, parameters);
		}
		if (algOid.Equals(X9ObjectIdentifiers.IdECPublicKey))
		{
			X962Parameters para4 = X962Parameters.GetInstance(algID.Parameters.ToAsn1Object());
			X9ECParameters x9 = ((!para4.IsNamedCurve) ? new X9ECParameters((Asn1Sequence)para4.Parameters) : ECKeyPairGenerator.FindECCurveByOid((DerObjectIdentifier)para4.Parameters));
			BigInteger d = ECPrivateKeyStructure.GetInstance(keyInfo.ParsePrivateKey()).GetKey();
			if (para4.IsNamedCurve)
			{
				return new ECPrivateKeyParameters("EC", d, (DerObjectIdentifier)para4.Parameters);
			}
			ECDomainParameters dParams = new ECDomainParameters(x9.Curve, x9.G, x9.N, x9.H, x9.GetSeed());
			return new ECPrivateKeyParameters(d, dParams);
		}
		if (algOid.Equals(CryptoProObjectIdentifiers.GostR3410x2001))
		{
			Gost3410PublicKeyAlgParameters gostParams = Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters.ToAsn1Object());
			X9ECParameters ecP = ECGost3410NamedCurves.GetByOidX9(gostParams.PublicKeyParamSet);
			if (ecP == null)
			{
				throw new ArgumentException("Unrecognized curve OID for GostR3410x2001 private key");
			}
			Asn1Object privKey = keyInfo.ParsePrivateKey();
			ECPrivateKeyStructure ec = ((!(privKey is DerInteger)) ? ECPrivateKeyStructure.GetInstance(privKey) : new ECPrivateKeyStructure(ecP.N.BitLength, ((DerInteger)privKey).PositiveValue));
			return new ECPrivateKeyParameters("ECGOST3410", ec.GetKey(), gostParams.PublicKeyParamSet);
		}
		if (algOid.Equals(CryptoProObjectIdentifiers.GostR3410x94))
		{
			Gost3410PublicKeyAlgParameters gostParams2 = Gost3410PublicKeyAlgParameters.GetInstance(algID.Parameters);
			Asn1Object privKey2 = keyInfo.ParsePrivateKey();
			BigInteger x10 = ((!(privKey2 is DerInteger)) ? new BigInteger(1, Arrays.Reverse(Asn1OctetString.GetInstance(privKey2).GetOctets())) : DerInteger.GetInstance(privKey2).PositiveValue);
			return new Gost3410PrivateKeyParameters(x10, gostParams2.PublicKeyParamSet);
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_X25519))
		{
			return new X25519PrivateKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_X448))
		{
			return new X448PrivateKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_Ed25519))
		{
			return new Ed25519PrivateKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(EdECObjectIdentifiers.id_Ed448))
		{
			return new Ed448PrivateKeyParameters(GetRawKey(keyInfo));
		}
		if (algOid.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512) || algOid.Equals(RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256))
		{
			Gost3410PublicKeyAlgParameters gostParams3 = Gost3410PublicKeyAlgParameters.GetInstance(keyInfo.PrivateKeyAlgorithm.Parameters);
			Asn1Object p = keyInfo.PrivateKeyAlgorithm.Parameters.ToAsn1Object();
			ECGost3410Parameters ecSpec;
			BigInteger d2;
			if (p is Asn1Sequence && (Asn1Sequence.GetInstance(p).Count == 2 || Asn1Sequence.GetInstance(p).Count == 3))
			{
				X9ECParameters ecP2 = ECGost3410NamedCurves.GetByOidX9(gostParams3.PublicKeyParamSet);
				ecSpec = new ECGost3410Parameters(new ECNamedDomainParameters(gostParams3.PublicKeyParamSet, ecP2), gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet);
				Asn1OctetString privEnc = keyInfo.PrivateKeyData;
				if (privEnc.GetOctets().Length == 32 || privEnc.GetOctets().Length == 64)
				{
					byte[] dVal = Arrays.Reverse(privEnc.GetOctets());
					d2 = new BigInteger(1, dVal);
				}
				else
				{
					Asn1Encodable privKey3 = keyInfo.ParsePrivateKey();
					if (privKey3 is DerInteger)
					{
						d2 = DerInteger.GetInstance(privKey3).PositiveValue;
					}
					else
					{
						byte[] dVal2 = Arrays.Reverse(Asn1OctetString.GetInstance(privKey3).GetOctets());
						d2 = new BigInteger(1, dVal2);
					}
				}
			}
			else
			{
				X962Parameters parameters2 = X962Parameters.GetInstance(keyInfo.PrivateKeyAlgorithm.Parameters);
				if (parameters2.IsNamedCurve)
				{
					DerObjectIdentifier instance = DerObjectIdentifier.GetInstance(parameters2.Parameters);
					X9ECParameters ecP3 = ECNamedCurveTable.GetByOid(instance);
					ecSpec = new ECGost3410Parameters(new ECNamedDomainParameters(instance, ecP3), gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet);
				}
				else if (parameters2.IsImplicitlyCA)
				{
					ecSpec = null;
				}
				else
				{
					X9ECParameters ecP4 = X9ECParameters.GetInstance(parameters2.Parameters);
					ecSpec = new ECGost3410Parameters(new ECNamedDomainParameters(algOid, ecP4), gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet);
				}
				Asn1Encodable privKey4 = keyInfo.ParsePrivateKey();
				d2 = ((!(privKey4 is DerInteger)) ? ECPrivateKeyStructure.GetInstance(privKey4).GetKey() : DerInteger.GetInstance(privKey4).Value);
			}
			return new ECPrivateKeyParameters(d2, new ECGost3410Parameters(ecSpec, gostParams3.PublicKeyParamSet, gostParams3.DigestParamSet, gostParams3.EncryptionParamSet));
		}
		throw new SecurityUtilityException("algorithm identifier in private key not recognised");
	}

	private static byte[] GetRawKey(PrivateKeyInfo keyInfo)
	{
		return Asn1OctetString.GetInstance(keyInfo.ParsePrivateKey()).GetOctets();
	}

	public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, EncryptedPrivateKeyInfo encInfo)
	{
		return CreateKey(PrivateKeyInfoFactory.CreatePrivateKeyInfo(passPhrase, encInfo));
	}

	public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, byte[] encryptedPrivateKeyInfoData)
	{
		return DecryptKey(passPhrase, Asn1Object.FromByteArray(encryptedPrivateKeyInfoData));
	}

	public static AsymmetricKeyParameter DecryptKey(char[] passPhrase, Stream encryptedPrivateKeyInfoStream)
	{
		return DecryptKey(passPhrase, Asn1Object.FromStream(encryptedPrivateKeyInfoStream));
	}

	private static AsymmetricKeyParameter DecryptKey(char[] passPhrase, Asn1Object asn1Object)
	{
		return DecryptKey(passPhrase, EncryptedPrivateKeyInfo.GetInstance(asn1Object));
	}

	public static byte[] EncryptKey(DerObjectIdentifier algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
	{
		return EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm, passPhrase, salt, iterationCount, key).GetEncoded();
	}

	public static byte[] EncryptKey(string algorithm, char[] passPhrase, byte[] salt, int iterationCount, AsymmetricKeyParameter key)
	{
		return EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(algorithm, passPhrase, salt, iterationCount, key).GetEncoded();
	}
}
