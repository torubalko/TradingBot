using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpSecretKey
{
	private readonly SecretKeyPacket secret;

	private readonly PgpPublicKey pub;

	public bool IsSigningKey
	{
		get
		{
			switch (pub.Algorithm)
			{
			case PublicKeyAlgorithmTag.RsaGeneral:
			case PublicKeyAlgorithmTag.RsaSign:
			case PublicKeyAlgorithmTag.Dsa:
			case PublicKeyAlgorithmTag.ECDsa:
			case PublicKeyAlgorithmTag.ElGamalGeneral:
			case PublicKeyAlgorithmTag.EdDsa:
				return true;
			default:
				return false;
			}
		}
	}

	public bool IsMasterKey => pub.IsMasterKey;

	public bool IsPrivateKeyEmpty
	{
		get
		{
			byte[] secKeyData = secret.GetSecretKeyData();
			if (secKeyData != null)
			{
				return secKeyData.Length < 1;
			}
			return true;
		}
	}

	public SymmetricKeyAlgorithmTag KeyEncryptionAlgorithm => secret.EncAlgorithm;

	public long KeyId => pub.KeyId;

	public int S2kUsage => secret.S2kUsage;

	public S2k S2k => secret.S2k;

	public PgpPublicKey PublicKey => pub;

	public IEnumerable UserIds => pub.GetUserIds();

	public IEnumerable UserAttributes => pub.GetUserAttributes();

	internal PgpSecretKey(SecretKeyPacket secret, PgpPublicKey pub)
	{
		this.secret = secret;
		this.pub = pub;
	}

	internal PgpSecretKey(PgpPrivateKey privKey, PgpPublicKey pubKey, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, SecureRandom rand, bool isMasterKey)
	{
		pub = pubKey;
		BcpgObject secKey;
		switch (pubKey.Algorithm)
		{
		case PublicKeyAlgorithmTag.RsaGeneral:
		case PublicKeyAlgorithmTag.RsaEncrypt:
		case PublicKeyAlgorithmTag.RsaSign:
		{
			RsaPrivateCrtKeyParameters rsK = (RsaPrivateCrtKeyParameters)privKey.Key;
			secKey = new RsaSecretBcpgKey(rsK.Exponent, rsK.P, rsK.Q);
			break;
		}
		case PublicKeyAlgorithmTag.Dsa:
			secKey = new DsaSecretBcpgKey(((DsaPrivateKeyParameters)privKey.Key).X);
			break;
		case PublicKeyAlgorithmTag.EC:
		case PublicKeyAlgorithmTag.ECDsa:
			secKey = new ECSecretBcpgKey(((ECPrivateKeyParameters)privKey.Key).D);
			break;
		case PublicKeyAlgorithmTag.ElGamalEncrypt:
		case PublicKeyAlgorithmTag.ElGamalGeneral:
			secKey = new ElGamalSecretBcpgKey(((ElGamalPrivateKeyParameters)privKey.Key).X);
			break;
		default:
			throw new PgpException("unknown key class");
		}
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			new BcpgOutputStream(memoryStream).WriteObject(secKey);
			byte[] keyData = memoryStream.ToArray();
			byte[] checksumData = Checksum(useSha1, keyData, keyData.Length);
			keyData = Arrays.Concatenate(keyData, checksumData);
			if (encAlgorithm == SymmetricKeyAlgorithmTag.Null)
			{
				if (isMasterKey)
				{
					secret = new SecretKeyPacket(pub.publicPk, encAlgorithm, null, null, keyData);
				}
				else
				{
					secret = new SecretSubkeyPacket(pub.publicPk, encAlgorithm, null, null, keyData);
				}
				return;
			}
			S2k s2k;
			byte[] iv;
			byte[] encData = ((pub.Version < 4) ? EncryptKeyDataV3(keyData, encAlgorithm, rawPassPhrase, clearPassPhrase, rand, out s2k, out iv) : EncryptKeyDataV4(keyData, encAlgorithm, HashAlgorithmTag.Sha1, rawPassPhrase, clearPassPhrase, rand, out s2k, out iv));
			int s2kUsage = (useSha1 ? 254 : 255);
			if (isMasterKey)
			{
				secret = new SecretKeyPacket(pub.publicPk, encAlgorithm, s2kUsage, s2k, iv, encData);
			}
			else
			{
				secret = new SecretSubkeyPacket(pub.publicPk, encAlgorithm, s2kUsage, s2k, iv, encData);
			}
		}
		catch (PgpException ex)
		{
			throw ex;
		}
		catch (Exception exception)
		{
			throw new PgpException("Exception encrypting key", exception);
		}
	}

	[Obsolete("Use the constructor taking an explicit 'useSha1' parameter instead")]
	public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, keyPair, id, encAlgorithm, passPhrase, useSha1: false, hashedPackets, unhashedPackets, rand)
	{
	}

	public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, keyPair, id, encAlgorithm, utf8PassPhrase: false, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
	{
	}

	public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, keyPair, id, encAlgorithm, PgpUtilities.EncodePassPhrase(passPhrase, utf8PassPhrase), clearPassPhrase: true, useSha1, hashedPackets, unhashedPackets, rand)
	{
	}

	public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, keyPair, id, encAlgorithm, rawPassPhrase, clearPassPhrase: false, useSha1, hashedPackets, unhashedPackets, rand)
	{
	}

	internal PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(keyPair.PrivateKey, CertifiedPublicKey(certificationLevel, keyPair, id, hashedPackets, unhashedPackets), encAlgorithm, rawPassPhrase, clearPassPhrase, useSha1, rand, isMasterKey: true)
	{
	}

	public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, keyPair, id, encAlgorithm, hashAlgorithm, utf8PassPhrase: false, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
	{
	}

	public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, keyPair, id, encAlgorithm, hashAlgorithm, PgpUtilities.EncodePassPhrase(passPhrase, utf8PassPhrase), clearPassPhrase: true, useSha1, hashedPackets, unhashedPackets, rand)
	{
	}

	public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, keyPair, id, encAlgorithm, hashAlgorithm, rawPassPhrase, clearPassPhrase: false, useSha1, hashedPackets, unhashedPackets, rand)
	{
	}

	internal PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(keyPair.PrivateKey, CertifiedPublicKey(certificationLevel, keyPair, id, hashedPackets, unhashedPackets, hashAlgorithm), encAlgorithm, rawPassPhrase, clearPassPhrase, useSha1, rand, isMasterKey: true)
	{
	}

	private static PgpPublicKey CertifiedPublicKey(int certificationLevel, PgpKeyPair keyPair, string id, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets)
	{
		PgpSignatureGenerator sGen;
		try
		{
			sGen = new PgpSignatureGenerator(keyPair.PublicKey.Algorithm, HashAlgorithmTag.Sha1);
		}
		catch (Exception ex)
		{
			throw new PgpException("Creating signature generator: " + ex.Message, ex);
		}
		sGen.InitSign(certificationLevel, keyPair.PrivateKey);
		sGen.SetHashedSubpackets(hashedPackets);
		sGen.SetUnhashedSubpackets(unhashedPackets);
		try
		{
			PgpSignature certification = sGen.GenerateCertification(id, keyPair.PublicKey);
			return PgpPublicKey.AddCertification(keyPair.PublicKey, id, certification);
		}
		catch (Exception ex2)
		{
			throw new PgpException("Exception doing certification: " + ex2.Message, ex2);
		}
	}

	private static PgpPublicKey CertifiedPublicKey(int certificationLevel, PgpKeyPair keyPair, string id, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, HashAlgorithmTag hashAlgorithm)
	{
		PgpSignatureGenerator sGen;
		try
		{
			sGen = new PgpSignatureGenerator(keyPair.PublicKey.Algorithm, hashAlgorithm);
		}
		catch (Exception ex)
		{
			throw new PgpException("Creating signature generator: " + ex.Message, ex);
		}
		sGen.InitSign(certificationLevel, keyPair.PrivateKey);
		sGen.SetHashedSubpackets(hashedPackets);
		sGen.SetUnhashedSubpackets(unhashedPackets);
		try
		{
			PgpSignature certification = sGen.GenerateCertification(id, keyPair.PublicKey);
			return PgpPublicKey.AddCertification(keyPair.PublicKey, id, certification);
		}
		catch (Exception ex2)
		{
			throw new PgpException("Exception doing certification: " + ex2.Message, ex2);
		}
	}

	public PgpSecretKey(int certificationLevel, PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, AsymmetricKeyParameter privKey, DateTime time, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, new PgpKeyPair(algorithm, pubKey, privKey, time), id, encAlgorithm, passPhrase, useSha1: false, hashedPackets, unhashedPackets, rand)
	{
	}

	public PgpSecretKey(int certificationLevel, PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, AsymmetricKeyParameter privKey, DateTime time, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		: this(certificationLevel, new PgpKeyPair(algorithm, pubKey, privKey, time), id, encAlgorithm, passPhrase, useSha1, hashedPackets, unhashedPackets, rand)
	{
	}

	private byte[] ExtractKeyData(byte[] rawPassPhrase, bool clearPassPhrase)
	{
		SymmetricKeyAlgorithmTag encAlgorithm = secret.EncAlgorithm;
		byte[] encData = secret.GetSecretKeyData();
		if (encAlgorithm == SymmetricKeyAlgorithmTag.Null)
		{
			return encData;
		}
		try
		{
			KeyParameter key = PgpUtilities.DoMakeKeyFromPassPhrase(secret.EncAlgorithm, secret.S2k, rawPassPhrase, clearPassPhrase);
			byte[] iv = secret.GetIV();
			byte[] data;
			if (secret.PublicKeyPacket.Version >= 4)
			{
				data = RecoverKeyData(encAlgorithm, "/CFB/NoPadding", key, iv, encData, 0, encData.Length);
				bool useSha1 = secret.S2kUsage == 254;
				byte[] check = Checksum(useSha1, data, useSha1 ? (data.Length - 20) : (data.Length - 2));
				for (int i = 0; i != check.Length; i++)
				{
					if (check[i] != data[data.Length - check.Length + i])
					{
						throw new PgpException("Checksum mismatch at " + i + " of " + check.Length);
					}
				}
			}
			else
			{
				data = new byte[encData.Length];
				iv = Arrays.Clone(iv);
				int pos = 0;
				for (int j = 0; j != 4; j++)
				{
					int encLen = ((((encData[pos] & 0xFF) << 8) | (encData[pos + 1] & 0xFF)) + 7) / 8;
					data[pos] = encData[pos];
					data[pos + 1] = encData[pos + 1];
					pos += 2;
					if (encLen > encData.Length - pos)
					{
						throw new PgpException("out of range encLen found in encData");
					}
					Array.Copy(RecoverKeyData(encAlgorithm, "/CFB/NoPadding", key, iv, encData, pos, encLen), 0, data, pos, encLen);
					pos += encLen;
					if (j != 3)
					{
						Array.Copy(encData, pos - iv.Length, iv, 0, iv.Length);
					}
				}
				data[pos] = encData[pos];
				data[pos + 1] = encData[pos + 1];
				int cs = ((encData[pos] << 8) & 0xFF00) | (encData[pos + 1] & 0xFF);
				int calcCs = 0;
				for (int k = 0; k < pos; k++)
				{
					calcCs += data[k] & 0xFF;
				}
				calcCs &= 0xFFFF;
				if (calcCs != cs)
				{
					throw new PgpException("Checksum mismatch: passphrase wrong, expected " + cs.ToString("X") + " found " + calcCs.ToString("X"));
				}
			}
			return data;
		}
		catch (PgpException ex)
		{
			throw ex;
		}
		catch (Exception exception)
		{
			throw new PgpException("Exception decrypting key", exception);
		}
	}

	private static byte[] RecoverKeyData(SymmetricKeyAlgorithmTag encAlgorithm, string modeAndPadding, KeyParameter key, byte[] iv, byte[] keyData, int keyOff, int keyLen)
	{
		IBufferedCipher c;
		try
		{
			c = CipherUtilities.GetCipher(PgpUtilities.GetSymmetricCipherName(encAlgorithm) + modeAndPadding);
		}
		catch (Exception exception)
		{
			throw new PgpException("Exception creating cipher", exception);
		}
		c.Init(forEncryption: false, new ParametersWithIV(key, iv));
		return c.DoFinal(keyData, keyOff, keyLen);
	}

	public PgpPrivateKey ExtractPrivateKey(char[] passPhrase)
	{
		return DoExtractPrivateKey(PgpUtilities.EncodePassPhrase(passPhrase, utf8: false), clearPassPhrase: true);
	}

	public PgpPrivateKey ExtractPrivateKeyUtf8(char[] passPhrase)
	{
		return DoExtractPrivateKey(PgpUtilities.EncodePassPhrase(passPhrase, utf8: true), clearPassPhrase: true);
	}

	public PgpPrivateKey ExtractPrivateKeyRaw(byte[] rawPassPhrase)
	{
		return DoExtractPrivateKey(rawPassPhrase, clearPassPhrase: false);
	}

	internal PgpPrivateKey DoExtractPrivateKey(byte[] rawPassPhrase, bool clearPassPhrase)
	{
		if (IsPrivateKeyEmpty)
		{
			return null;
		}
		PublicKeyPacket pubPk = secret.PublicKeyPacket;
		try
		{
			BcpgInputStream bcpgIn = BcpgInputStream.Wrap(new MemoryStream(ExtractKeyData(rawPassPhrase, clearPassPhrase), writable: false));
			AsymmetricKeyParameter privateKey;
			switch (pubPk.Algorithm)
			{
			case PublicKeyAlgorithmTag.RsaGeneral:
			case PublicKeyAlgorithmTag.RsaEncrypt:
			case PublicKeyAlgorithmTag.RsaSign:
			{
				RsaPublicBcpgKey rsaPub = (RsaPublicBcpgKey)pubPk.Key;
				RsaSecretBcpgKey rsaPriv = new RsaSecretBcpgKey(bcpgIn);
				privateKey = new RsaPrivateCrtKeyParameters(rsaPriv.Modulus, rsaPub.PublicExponent, rsaPriv.PrivateExponent, rsaPriv.PrimeP, rsaPriv.PrimeQ, rsaPriv.PrimeExponentP, rsaPriv.PrimeExponentQ, rsaPriv.CrtCoefficient);
				break;
			}
			case PublicKeyAlgorithmTag.Dsa:
			{
				DsaPublicBcpgKey dsaPub = (DsaPublicBcpgKey)pubPk.Key;
				DsaSecretBcpgKey dsaSecretBcpgKey = new DsaSecretBcpgKey(bcpgIn);
				privateKey = new DsaPrivateKeyParameters(parameters: new DsaParameters(dsaPub.P, dsaPub.Q, dsaPub.G), x: dsaSecretBcpgKey.X);
				break;
			}
			case PublicKeyAlgorithmTag.EC:
				privateKey = GetECKey("ECDH", bcpgIn);
				break;
			case PublicKeyAlgorithmTag.ECDsa:
				privateKey = GetECKey("ECDSA", bcpgIn);
				break;
			case PublicKeyAlgorithmTag.ElGamalEncrypt:
			case PublicKeyAlgorithmTag.ElGamalGeneral:
			{
				ElGamalPublicBcpgKey elPub = (ElGamalPublicBcpgKey)pubPk.Key;
				ElGamalSecretBcpgKey elGamalSecretBcpgKey = new ElGamalSecretBcpgKey(bcpgIn);
				privateKey = new ElGamalPrivateKeyParameters(parameters: new ElGamalParameters(elPub.P, elPub.G), x: elGamalSecretBcpgKey.X);
				break;
			}
			default:
				throw new PgpException("unknown public key algorithm encountered");
			}
			return new PgpPrivateKey(KeyId, pubPk, privateKey);
		}
		catch (PgpException ex)
		{
			throw ex;
		}
		catch (Exception exception)
		{
			throw new PgpException("Exception constructing key", exception);
		}
	}

	private ECPrivateKeyParameters GetECKey(string algorithm, BcpgInputStream bcpgIn)
	{
		ECPublicBcpgKey ecdsaPub = (ECPublicBcpgKey)secret.PublicKeyPacket.Key;
		ECSecretBcpgKey ecdsaPriv = new ECSecretBcpgKey(bcpgIn);
		return new ECPrivateKeyParameters(algorithm, ecdsaPriv.X, ecdsaPub.CurveOid);
	}

	private static byte[] Checksum(bool useSha1, byte[] bytes, int length)
	{
		if (useSha1)
		{
			try
			{
				IDigest digest = DigestUtilities.GetDigest("SHA1");
				digest.BlockUpdate(bytes, 0, length);
				return DigestUtilities.DoFinal(digest);
			}
			catch (Exception exception)
			{
				throw new PgpException("Can't find SHA-1", exception);
			}
		}
		int Checksum = 0;
		for (int i = 0; i != length; i++)
		{
			Checksum += bytes[i];
		}
		return new byte[2]
		{
			(byte)(Checksum >> 8),
			(byte)Checksum
		};
	}

	public byte[] GetEncoded()
	{
		MemoryStream bOut = new MemoryStream();
		Encode(bOut);
		return bOut.ToArray();
	}

	public void Encode(Stream outStr)
	{
		BcpgOutputStream bcpgOut = BcpgOutputStream.Wrap(outStr);
		bcpgOut.WritePacket(secret);
		if (pub.trustPk != null)
		{
			bcpgOut.WritePacket(pub.trustPk);
		}
		if (pub.subSigs == null)
		{
			foreach (PgpSignature keySig in pub.keySigs)
			{
				keySig.Encode(bcpgOut);
			}
			for (int i = 0; i != pub.ids.Count; i++)
			{
				object pubID = pub.ids[i];
				if (pubID is string)
				{
					string id = (string)pubID;
					bcpgOut.WritePacket(new UserIdPacket(id));
				}
				else
				{
					PgpUserAttributeSubpacketVector v = (PgpUserAttributeSubpacketVector)pubID;
					bcpgOut.WritePacket(new UserAttributePacket(v.ToSubpacketArray()));
				}
				if (pub.idTrusts[i] != null)
				{
					bcpgOut.WritePacket((ContainedPacket)pub.idTrusts[i]);
				}
				foreach (PgpSignature item in (IList)pub.idSigs[i])
				{
					item.Encode(bcpgOut);
				}
			}
			return;
		}
		foreach (PgpSignature subSig in pub.subSigs)
		{
			subSig.Encode(bcpgOut);
		}
	}

	public static PgpSecretKey CopyWithNewPassword(PgpSecretKey key, char[] oldPassPhrase, char[] newPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
	{
		return DoCopyWithNewPassword(key, PgpUtilities.EncodePassPhrase(oldPassPhrase, utf8: false), PgpUtilities.EncodePassPhrase(newPassPhrase, utf8: false), clearPassPhrase: true, newEncAlgorithm, rand);
	}

	public static PgpSecretKey CopyWithNewPasswordUtf8(PgpSecretKey key, char[] oldPassPhrase, char[] newPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
	{
		return DoCopyWithNewPassword(key, PgpUtilities.EncodePassPhrase(oldPassPhrase, utf8: true), PgpUtilities.EncodePassPhrase(newPassPhrase, utf8: true), clearPassPhrase: true, newEncAlgorithm, rand);
	}

	public static PgpSecretKey CopyWithNewPasswordRaw(PgpSecretKey key, byte[] rawOldPassPhrase, byte[] rawNewPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
	{
		return DoCopyWithNewPassword(key, rawOldPassPhrase, rawNewPassPhrase, clearPassPhrase: false, newEncAlgorithm, rand);
	}

	internal static PgpSecretKey DoCopyWithNewPassword(PgpSecretKey key, byte[] rawOldPassPhrase, byte[] rawNewPassPhrase, bool clearPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
	{
		if (key.IsPrivateKeyEmpty)
		{
			throw new PgpException("no private key in this SecretKey - public key present only.");
		}
		byte[] rawKeyData = key.ExtractKeyData(rawOldPassPhrase, clearPassPhrase);
		int s2kUsage = key.secret.S2kUsage;
		byte[] iv = null;
		S2k s2k = null;
		PublicKeyPacket pubKeyPacket = key.secret.PublicKeyPacket;
		byte[] keyData;
		if (newEncAlgorithm == SymmetricKeyAlgorithmTag.Null)
		{
			s2kUsage = 0;
			if (key.secret.S2kUsage == 254)
			{
				keyData = new byte[rawKeyData.Length - 18];
				Array.Copy(rawKeyData, 0, keyData, 0, keyData.Length - 2);
				byte[] check = Checksum(useSha1: false, keyData, keyData.Length - 2);
				keyData[keyData.Length - 2] = check[0];
				keyData[keyData.Length - 1] = check[1];
			}
			else
			{
				keyData = rawKeyData;
			}
		}
		else
		{
			if (s2kUsage == 0)
			{
				s2kUsage = 255;
			}
			try
			{
				keyData = ((pubKeyPacket.Version < 4) ? EncryptKeyDataV3(rawKeyData, newEncAlgorithm, rawNewPassPhrase, clearPassPhrase, rand, out s2k, out iv) : EncryptKeyDataV4(rawKeyData, newEncAlgorithm, HashAlgorithmTag.Sha1, rawNewPassPhrase, clearPassPhrase, rand, out s2k, out iv));
			}
			catch (PgpException ex)
			{
				throw ex;
			}
			catch (Exception exception)
			{
				throw new PgpException("Exception encrypting key", exception);
			}
		}
		SecretKeyPacket secret = ((!(key.secret is SecretSubkeyPacket)) ? new SecretKeyPacket(pubKeyPacket, newEncAlgorithm, s2kUsage, s2k, iv, keyData) : new SecretSubkeyPacket(pubKeyPacket, newEncAlgorithm, s2kUsage, s2k, iv, keyData));
		return new PgpSecretKey(secret, key.pub);
	}

	public static PgpSecretKey ReplacePublicKey(PgpSecretKey secretKey, PgpPublicKey publicKey)
	{
		if (publicKey.KeyId != secretKey.KeyId)
		{
			throw new ArgumentException("KeyId's do not match");
		}
		return new PgpSecretKey(secretKey.secret, publicKey);
	}

	private static byte[] EncryptKeyDataV3(byte[] rawKeyData, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, SecureRandom random, out S2k s2k, out byte[] iv)
	{
		s2k = null;
		iv = null;
		KeyParameter encKey = PgpUtilities.DoMakeKeyFromPassPhrase(encAlgorithm, s2k, rawPassPhrase, clearPassPhrase);
		byte[] keyData = new byte[rawKeyData.Length];
		int pos = 0;
		for (int i = 0; i != 4; i++)
		{
			int encLen = ((((rawKeyData[pos] & 0xFF) << 8) | (rawKeyData[pos + 1] & 0xFF)) + 7) / 8;
			keyData[pos] = rawKeyData[pos];
			keyData[pos + 1] = rawKeyData[pos + 1];
			if (encLen > rawKeyData.Length - (pos + 2))
			{
				throw new PgpException("out of range encLen found in rawKeyData");
			}
			byte[] tmp;
			if (i == 0)
			{
				tmp = EncryptData(encAlgorithm, encKey, rawKeyData, pos + 2, encLen, random, ref iv);
			}
			else
			{
				byte[] tmpIv = Arrays.CopyOfRange(keyData, pos - iv.Length, pos);
				tmp = EncryptData(encAlgorithm, encKey, rawKeyData, pos + 2, encLen, random, ref tmpIv);
			}
			Array.Copy(tmp, 0, keyData, pos + 2, tmp.Length);
			pos += 2 + encLen;
		}
		keyData[pos] = rawKeyData[pos];
		keyData[pos + 1] = rawKeyData[pos + 1];
		return keyData;
	}

	private static byte[] EncryptKeyDataV4(byte[] rawKeyData, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, SecureRandom random, out S2k s2k, out byte[] iv)
	{
		s2k = PgpUtilities.GenerateS2k(hashAlgorithm, 96, random);
		KeyParameter key = PgpUtilities.DoMakeKeyFromPassPhrase(encAlgorithm, s2k, rawPassPhrase, clearPassPhrase);
		iv = null;
		return EncryptData(encAlgorithm, key, rawKeyData, 0, rawKeyData.Length, random, ref iv);
	}

	private static byte[] EncryptData(SymmetricKeyAlgorithmTag encAlgorithm, KeyParameter key, byte[] data, int dataOff, int dataLen, SecureRandom random, ref byte[] iv)
	{
		IBufferedCipher c;
		try
		{
			c = CipherUtilities.GetCipher(PgpUtilities.GetSymmetricCipherName(encAlgorithm) + "/CFB/NoPadding");
		}
		catch (Exception exception)
		{
			throw new PgpException("Exception creating cipher", exception);
		}
		if (iv == null)
		{
			iv = PgpUtilities.GenerateIV(c.GetBlockSize(), random);
		}
		c.Init(forEncryption: true, new ParametersWithRandom(new ParametersWithIV(key, iv), random));
		return c.DoFinal(data, dataOff, dataLen);
	}

	public static PgpSecretKey ParseSecretKeyFromSExpr(Stream inputStream, char[] passPhrase, PgpPublicKey pubKey)
	{
		return DoParseSecretKeyFromSExpr(inputStream, PgpUtilities.EncodePassPhrase(passPhrase, utf8: false), clearPassPhrase: true, pubKey);
	}

	public static PgpSecretKey ParseSecretKeyFromSExprUtf8(Stream inputStream, char[] passPhrase, PgpPublicKey pubKey)
	{
		return DoParseSecretKeyFromSExpr(inputStream, PgpUtilities.EncodePassPhrase(passPhrase, utf8: true), clearPassPhrase: true, pubKey);
	}

	public static PgpSecretKey ParseSecretKeyFromSExprRaw(Stream inputStream, byte[] rawPassPhrase, PgpPublicKey pubKey)
	{
		return DoParseSecretKeyFromSExpr(inputStream, rawPassPhrase, clearPassPhrase: false, pubKey);
	}

	internal static PgpSecretKey DoParseSecretKeyFromSExpr(Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase, PgpPublicKey pubKey)
	{
		SXprUtilities.SkipOpenParenthesis(inputStream);
		if (SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("protected-private-key"))
		{
			SXprUtilities.SkipOpenParenthesis(inputStream);
			if (SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("ecc"))
			{
				SXprUtilities.SkipOpenParenthesis(inputStream);
				SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
				string curveName = SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
				SXprUtilities.SkipCloseParenthesis(inputStream);
				SXprUtilities.SkipOpenParenthesis(inputStream);
				if (SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("q"))
				{
					SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
					SXprUtilities.SkipCloseParenthesis(inputStream);
					byte[] dValue = GetDValue(inputStream, rawPassPhrase, clearPassPhrase, curveName);
					return new PgpSecretKey(new SecretKeyPacket(pubKey.PublicKeyPacket, SymmetricKeyAlgorithmTag.Null, null, null, new ECSecretBcpgKey(new BigInteger(1, dValue)).GetEncoded()), pubKey);
				}
				throw new PgpException("no q value found");
			}
			throw new PgpException("no curve details found");
		}
		throw new PgpException("unknown key type found");
	}

	public static PgpSecretKey ParseSecretKeyFromSExpr(Stream inputStream, char[] passPhrase)
	{
		return DoParseSecretKeyFromSExpr(inputStream, PgpUtilities.EncodePassPhrase(passPhrase, utf8: false), clearPassPhrase: true);
	}

	public static PgpSecretKey ParseSecretKeyFromSExprUtf8(Stream inputStream, char[] passPhrase)
	{
		return DoParseSecretKeyFromSExpr(inputStream, PgpUtilities.EncodePassPhrase(passPhrase, utf8: true), clearPassPhrase: true);
	}

	public static PgpSecretKey ParseSecretKeyFromSExprRaw(Stream inputStream, byte[] rawPassPhrase)
	{
		return DoParseSecretKeyFromSExpr(inputStream, rawPassPhrase, clearPassPhrase: false);
	}

	internal static PgpSecretKey DoParseSecretKeyFromSExpr(Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase)
	{
		SXprUtilities.SkipOpenParenthesis(inputStream);
		if (SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("protected-private-key"))
		{
			SXprUtilities.SkipOpenParenthesis(inputStream);
			if (SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("ecc"))
			{
				SXprUtilities.SkipOpenParenthesis(inputStream);
				SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
				string curveName = SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
				if (Platform.StartsWith(curveName, "NIST "))
				{
					curveName = curveName.Substring("NIST ".Length);
				}
				SXprUtilities.SkipCloseParenthesis(inputStream);
				SXprUtilities.SkipOpenParenthesis(inputStream);
				if (SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("q"))
				{
					byte[] qVal = SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
					PublicKeyPacket pubPacket = new PublicKeyPacket(PublicKeyAlgorithmTag.ECDsa, DateTime.UtcNow, new ECDsaPublicBcpgKey(ECNamedCurveTable.GetOid(curveName), new BigInteger(1, qVal)));
					SXprUtilities.SkipCloseParenthesis(inputStream);
					byte[] dValue = GetDValue(inputStream, rawPassPhrase, clearPassPhrase, curveName);
					return new PgpSecretKey(new SecretKeyPacket(pubPacket, SymmetricKeyAlgorithmTag.Null, null, null, new ECSecretBcpgKey(new BigInteger(1, dValue)).GetEncoded()), new PgpPublicKey(pubPacket));
				}
				throw new PgpException("no q value found");
			}
			throw new PgpException("no curve details found");
		}
		throw new PgpException("unknown key type found");
	}

	private static byte[] GetDValue(Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase, string curveName)
	{
		SXprUtilities.SkipOpenParenthesis(inputStream);
		if (SXprUtilities.ReadString(inputStream, inputStream.ReadByte()).Equals("protected"))
		{
			SXprUtilities.ReadString(inputStream, inputStream.ReadByte());
			SXprUtilities.SkipOpenParenthesis(inputStream);
			S2k s2k = SXprUtilities.ParseS2k(inputStream);
			byte[] iv = SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
			SXprUtilities.SkipCloseParenthesis(inputStream);
			byte[] secKeyData = SXprUtilities.ReadBytes(inputStream, inputStream.ReadByte());
			KeyParameter key = PgpUtilities.DoMakeKeyFromPassPhrase(SymmetricKeyAlgorithmTag.Aes128, s2k, rawPassPhrase, clearPassPhrase);
			MemoryStream memoryStream = new MemoryStream(RecoverKeyData(SymmetricKeyAlgorithmTag.Aes128, "/CBC/NoPadding", key, iv, secKeyData, 0, secKeyData.Length), writable: false);
			SXprUtilities.SkipOpenParenthesis(memoryStream);
			SXprUtilities.SkipOpenParenthesis(memoryStream);
			SXprUtilities.SkipOpenParenthesis(memoryStream);
			SXprUtilities.ReadString(memoryStream, memoryStream.ReadByte());
			return SXprUtilities.ReadBytes(memoryStream, memoryStream.ReadByte());
		}
		throw new PgpException("protected block not found");
	}
}
