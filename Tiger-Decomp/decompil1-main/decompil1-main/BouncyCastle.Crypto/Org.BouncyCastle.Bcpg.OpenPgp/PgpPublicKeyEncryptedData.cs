using System;
using System.IO;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpPublicKeyEncryptedData : PgpEncryptedData
{
	private PublicKeyEncSessionPacket keyData;

	public long KeyId => keyData.KeyId;

	internal PgpPublicKeyEncryptedData(PublicKeyEncSessionPacket keyData, InputStreamPacket encData)
		: base(encData)
	{
		this.keyData = keyData;
	}

	private static IBufferedCipher GetKeyCipher(PublicKeyAlgorithmTag algorithm)
	{
		try
		{
			switch (algorithm)
			{
			case PublicKeyAlgorithmTag.RsaGeneral:
			case PublicKeyAlgorithmTag.RsaEncrypt:
				return CipherUtilities.GetCipher("RSA//PKCS1Padding");
			case PublicKeyAlgorithmTag.ElGamalEncrypt:
			case PublicKeyAlgorithmTag.ElGamalGeneral:
				return CipherUtilities.GetCipher("ElGamal/ECB/PKCS1Padding");
			default:
				throw new PgpException("unknown asymmetric algorithm: " + algorithm);
			}
		}
		catch (PgpException ex)
		{
			throw ex;
		}
		catch (Exception exception)
		{
			throw new PgpException("Exception creating cipher", exception);
		}
	}

	private bool ConfirmCheckSum(byte[] sessionInfo)
	{
		int check = 0;
		for (int i = 1; i != sessionInfo.Length - 2; i++)
		{
			check += sessionInfo[i] & 0xFF;
		}
		if (sessionInfo[sessionInfo.Length - 2] == (byte)(check >> 8))
		{
			return sessionInfo[sessionInfo.Length - 1] == (byte)check;
		}
		return false;
	}

	public SymmetricKeyAlgorithmTag GetSymmetricAlgorithm(PgpPrivateKey privKey)
	{
		return (SymmetricKeyAlgorithmTag)RecoverSessionData(privKey)[0];
	}

	public Stream GetDataStream(PgpPrivateKey privKey)
	{
		byte[] sessionData = RecoverSessionData(privKey);
		if (!ConfirmCheckSum(sessionData))
		{
			throw new PgpKeyValidationException("key checksum failed");
		}
		SymmetricKeyAlgorithmTag symmAlg = (SymmetricKeyAlgorithmTag)sessionData[0];
		if (symmAlg == SymmetricKeyAlgorithmTag.Null)
		{
			return encData.GetInputStream();
		}
		string cipherName = PgpUtilities.GetSymmetricCipherName(symmAlg);
		string cName = cipherName;
		IBufferedCipher cipher;
		try
		{
			cName = ((!(encData is SymmetricEncIntegrityPacket)) ? (cName + "/OpenPGPCFB/NoPadding") : (cName + "/CFB/NoPadding"));
			cipher = CipherUtilities.GetCipher(cName);
		}
		catch (PgpException ex)
		{
			throw ex;
		}
		catch (Exception exception)
		{
			throw new PgpException("exception creating cipher", exception);
		}
		try
		{
			KeyParameter key = ParameterUtilities.CreateKeyParameter(cipherName, sessionData, 1, sessionData.Length - 3);
			byte[] iv = new byte[cipher.GetBlockSize()];
			cipher.Init(forEncryption: false, new ParametersWithIV(key, iv));
			encStream = BcpgInputStream.Wrap(new CipherStream(encData.GetInputStream(), cipher, null));
			if (encData is SymmetricEncIntegrityPacket)
			{
				truncStream = new TruncatedStream(encStream);
				IDigest digest = DigestUtilities.GetDigest(PgpUtilities.GetDigestName(HashAlgorithmTag.Sha1));
				encStream = new DigestStream(truncStream, digest, null);
			}
			if (Streams.ReadFully(encStream, iv, 0, iv.Length) < iv.Length)
			{
				throw new EndOfStreamException("unexpected end of stream.");
			}
			int num = encStream.ReadByte();
			int v2 = encStream.ReadByte();
			if (num < 0 || v2 < 0)
			{
				throw new EndOfStreamException("unexpected end of stream.");
			}
			return encStream;
		}
		catch (PgpException ex2)
		{
			throw ex2;
		}
		catch (Exception exception2)
		{
			throw new PgpException("Exception starting decryption", exception2);
		}
	}

	private byte[] RecoverSessionData(PgpPrivateKey privKey)
	{
		byte[][] secKeyData = keyData.GetEncSessionKey();
		if (keyData.Algorithm == PublicKeyAlgorithmTag.EC)
		{
			ECDHPublicBcpgKey obj = (ECDHPublicBcpgKey)privKey.PublicKeyPacket.Key;
			X9ECParameters x9ECParameters = ECKeyPairGenerator.FindECCurveByOid(obj.CurveOid);
			byte[] enc = secKeyData[0];
			int pLen = (((enc[0] & 0xFF) << 8) + (enc[1] & 0xFF) + 7) / 8;
			if (2 + pLen + 1 > enc.Length)
			{
				throw new PgpException("encoded length out of range");
			}
			byte[] pEnc = new byte[pLen];
			Array.Copy(enc, 2, pEnc, 0, pLen);
			int keyLen = enc[pLen + 2];
			if (2 + pLen + 1 + keyLen > enc.Length)
			{
				throw new PgpException("encoded length out of range");
			}
			byte[] keyEnc = new byte[keyLen];
			Array.Copy(enc, 2 + pLen + 1, keyEnc, 0, keyEnc.Length);
			ECPoint eCPoint = x9ECParameters.Curve.DecodePoint(pEnc);
			ECPrivateKeyParameters privKeyParams = (ECPrivateKeyParameters)privKey.Key;
			KeyParameter key = new KeyParameter(Rfc6637Utilities.CreateKey(s: eCPoint.Multiply(privKeyParams.D).Normalize(), pubKeyData: privKey.PublicKeyPacket));
			IWrapper wrapper = PgpUtilities.CreateWrapper(obj.SymmetricKeyAlgorithm);
			wrapper.Init(forWrapping: false, key);
			return PgpPad.UnpadSessionData(wrapper.Unwrap(keyEnc, 0, keyEnc.Length));
		}
		IBufferedCipher cipher = GetKeyCipher(keyData.Algorithm);
		try
		{
			cipher.Init(forEncryption: false, privKey.Key);
		}
		catch (InvalidKeyException exception)
		{
			throw new PgpException("error setting asymmetric cipher", exception);
		}
		if (keyData.Algorithm == PublicKeyAlgorithmTag.RsaEncrypt || keyData.Algorithm == PublicKeyAlgorithmTag.RsaGeneral)
		{
			byte[] bi = secKeyData[0];
			cipher.ProcessBytes(bi, 2, bi.Length - 2);
		}
		else
		{
			int size = (((ElGamalPrivateKeyParameters)privKey.Key).Parameters.P.BitLength + 7) / 8;
			ProcessEncodedMpi(cipher, size, secKeyData[0]);
			ProcessEncodedMpi(cipher, size, secKeyData[1]);
		}
		try
		{
			return cipher.DoFinal();
		}
		catch (Exception exception2)
		{
			throw new PgpException("exception decrypting secret key", exception2);
		}
	}

	private static void ProcessEncodedMpi(IBufferedCipher cipher, int size, byte[] mpiEnc)
	{
		if (mpiEnc.Length - 2 > size)
		{
			cipher.ProcessBytes(mpiEnc, 3, mpiEnc.Length - 3);
			return;
		}
		byte[] tmp = new byte[size];
		Array.Copy(mpiEnc, 2, tmp, tmp.Length - (mpiEnc.Length - 2), mpiEnc.Length - 2);
		cipher.ProcessBytes(tmp, 0, tmp.Length);
	}
}
