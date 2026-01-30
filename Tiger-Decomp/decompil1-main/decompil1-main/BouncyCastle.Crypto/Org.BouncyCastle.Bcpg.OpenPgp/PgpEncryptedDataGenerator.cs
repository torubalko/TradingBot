using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpEncryptedDataGenerator : IStreamGenerator
{
	private abstract class EncMethod : ContainedPacket
	{
		protected byte[] sessionInfo;

		protected SymmetricKeyAlgorithmTag encAlgorithm;

		protected KeyParameter key;

		public abstract void AddSessionInfo(byte[] si, SecureRandom random);
	}

	private class PbeMethod : EncMethod
	{
		private S2k s2k;

		internal PbeMethod(SymmetricKeyAlgorithmTag encAlgorithm, S2k s2k, KeyParameter key)
		{
			base.encAlgorithm = encAlgorithm;
			this.s2k = s2k;
			base.key = key;
		}

		public KeyParameter GetKey()
		{
			return key;
		}

		public override void AddSessionInfo(byte[] si, SecureRandom random)
		{
			IBufferedCipher c = CipherUtilities.GetCipher(PgpUtilities.GetSymmetricCipherName(encAlgorithm) + "/CFB/NoPadding");
			byte[] iv = new byte[c.GetBlockSize()];
			c.Init(forEncryption: true, new ParametersWithRandom(new ParametersWithIV(key, iv), random));
			sessionInfo = c.DoFinal(si, 0, si.Length - 2);
		}

		public override void Encode(BcpgOutputStream pOut)
		{
			SymmetricKeyEncSessionPacket pk = new SymmetricKeyEncSessionPacket(encAlgorithm, s2k, sessionInfo);
			pOut.WritePacket(pk);
		}
	}

	private class PubMethod : EncMethod
	{
		internal PgpPublicKey pubKey;

		internal bool sessionKeyObfuscation;

		internal byte[][] data;

		internal PubMethod(PgpPublicKey pubKey, bool sessionKeyObfuscation)
		{
			this.pubKey = pubKey;
			this.sessionKeyObfuscation = sessionKeyObfuscation;
		}

		public override void AddSessionInfo(byte[] sessionInfo, SecureRandom random)
		{
			byte[] encryptedSessionInfo = EncryptSessionInfo(sessionInfo, random);
			data = ProcessSessionInfo(encryptedSessionInfo);
		}

		private byte[] EncryptSessionInfo(byte[] sessionInfo, SecureRandom random)
		{
			if (pubKey.Algorithm != PublicKeyAlgorithmTag.EC)
			{
				IBufferedCipher c;
				switch (pubKey.Algorithm)
				{
				case PublicKeyAlgorithmTag.RsaGeneral:
				case PublicKeyAlgorithmTag.RsaEncrypt:
					c = CipherUtilities.GetCipher("RSA//PKCS1Padding");
					break;
				case PublicKeyAlgorithmTag.ElGamalEncrypt:
				case PublicKeyAlgorithmTag.ElGamalGeneral:
					c = CipherUtilities.GetCipher("ElGamal/ECB/PKCS1Padding");
					break;
				case PublicKeyAlgorithmTag.Dsa:
					throw new PgpException("Can't use DSA for encryption.");
				case PublicKeyAlgorithmTag.ECDsa:
					throw new PgpException("Can't use ECDSA for encryption.");
				default:
					throw new PgpException("unknown asymmetric algorithm: " + pubKey.Algorithm);
				}
				AsymmetricKeyParameter akp = pubKey.GetKey();
				c.Init(forEncryption: true, new ParametersWithRandom(akp, random));
				return c.DoFinal(sessionInfo);
			}
			ECDHPublicBcpgKey ecKey = (ECDHPublicBcpgKey)pubKey.PublicKeyPacket.Key;
			IAsymmetricCipherKeyPairGenerator keyPairGenerator = GeneratorUtilities.GetKeyPairGenerator("ECDH");
			keyPairGenerator.Init(new ECKeyGenerationParameters(ecKey.CurveOid, random));
			AsymmetricCipherKeyPair asymmetricCipherKeyPair = keyPairGenerator.GenerateKeyPair();
			ECPrivateKeyParameters ephPriv = (ECPrivateKeyParameters)asymmetricCipherKeyPair.Private;
			ECPublicKeyParameters ephPub = (ECPublicKeyParameters)asymmetricCipherKeyPair.Public;
			ECPoint S = ((ECPublicKeyParameters)pubKey.GetKey()).Q.Multiply(ephPriv.D).Normalize();
			KeyParameter key = new KeyParameter(Rfc6637Utilities.CreateKey(pubKey.PublicKeyPacket, S));
			IWrapper wrapper = PgpUtilities.CreateWrapper(ecKey.SymmetricKeyAlgorithm);
			wrapper.Init(forWrapping: true, new ParametersWithRandom(key, random));
			byte[] paddedSessionData = PgpPad.PadSessionData(sessionInfo, sessionKeyObfuscation);
			byte[] C = wrapper.Wrap(paddedSessionData, 0, paddedSessionData.Length);
			byte[] VB = new MPInteger(new BigInteger(1, ephPub.Q.GetEncoded(compressed: false))).GetEncoded();
			byte[] rv = new byte[VB.Length + 1 + C.Length];
			Array.Copy(VB, 0, rv, 0, VB.Length);
			rv[VB.Length] = (byte)C.Length;
			Array.Copy(C, 0, rv, VB.Length + 1, C.Length);
			return rv;
		}

		private byte[][] ProcessSessionInfo(byte[] encryptedSessionInfo)
		{
			switch (pubKey.Algorithm)
			{
			case PublicKeyAlgorithmTag.RsaGeneral:
			case PublicKeyAlgorithmTag.RsaEncrypt:
				return new byte[1][] { ConvertToEncodedMpi(encryptedSessionInfo) };
			case PublicKeyAlgorithmTag.ElGamalEncrypt:
			case PublicKeyAlgorithmTag.ElGamalGeneral:
			{
				int halfLength = encryptedSessionInfo.Length / 2;
				byte[] b1 = new byte[halfLength];
				byte[] b2 = new byte[halfLength];
				Array.Copy(encryptedSessionInfo, 0, b1, 0, halfLength);
				Array.Copy(encryptedSessionInfo, halfLength, b2, 0, halfLength);
				return new byte[2][]
				{
					ConvertToEncodedMpi(b1),
					ConvertToEncodedMpi(b2)
				};
			}
			case PublicKeyAlgorithmTag.EC:
				return new byte[1][] { encryptedSessionInfo };
			default:
				throw new PgpException("unknown asymmetric algorithm: " + pubKey.Algorithm);
			}
		}

		private byte[] ConvertToEncodedMpi(byte[] encryptedSessionInfo)
		{
			try
			{
				return new MPInteger(new BigInteger(1, encryptedSessionInfo)).GetEncoded();
			}
			catch (IOException ex)
			{
				throw new PgpException("Invalid MPI encoding: " + ex.Message, ex);
			}
		}

		public override void Encode(BcpgOutputStream pOut)
		{
			PublicKeyEncSessionPacket pk = new PublicKeyEncSessionPacket(pubKey.KeyId, pubKey.Algorithm, data);
			pOut.WritePacket(pk);
		}
	}

	private BcpgOutputStream pOut;

	private CipherStream cOut;

	private IBufferedCipher c;

	private bool withIntegrityPacket;

	private bool oldFormat;

	private DigestStream digestOut;

	private readonly IList methods = Platform.CreateArrayList();

	private readonly SymmetricKeyAlgorithmTag defAlgorithm;

	private readonly SecureRandom rand;

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm)
	{
		defAlgorithm = encAlgorithm;
		rand = new SecureRandom();
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, bool withIntegrityPacket)
	{
		defAlgorithm = encAlgorithm;
		this.withIntegrityPacket = withIntegrityPacket;
		rand = new SecureRandom();
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, SecureRandom rand)
	{
		defAlgorithm = encAlgorithm;
		this.rand = rand;
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, bool withIntegrityPacket, SecureRandom rand)
	{
		defAlgorithm = encAlgorithm;
		this.rand = rand;
		this.withIntegrityPacket = withIntegrityPacket;
	}

	public PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag encAlgorithm, SecureRandom rand, bool oldFormat)
	{
		defAlgorithm = encAlgorithm;
		this.rand = rand;
		this.oldFormat = oldFormat;
	}

	[Obsolete("Use version that takes an explicit s2kDigest parameter")]
	public void AddMethod(char[] passPhrase)
	{
		AddMethod(passPhrase, HashAlgorithmTag.Sha1);
	}

	public void AddMethod(char[] passPhrase, HashAlgorithmTag s2kDigest)
	{
		DoAddMethod(PgpUtilities.EncodePassPhrase(passPhrase, utf8: false), clearPassPhrase: true, s2kDigest);
	}

	public void AddMethodUtf8(char[] passPhrase, HashAlgorithmTag s2kDigest)
	{
		DoAddMethod(PgpUtilities.EncodePassPhrase(passPhrase, utf8: true), clearPassPhrase: true, s2kDigest);
	}

	public void AddMethodRaw(byte[] rawPassPhrase, HashAlgorithmTag s2kDigest)
	{
		DoAddMethod(rawPassPhrase, clearPassPhrase: false, s2kDigest);
	}

	internal void DoAddMethod(byte[] rawPassPhrase, bool clearPassPhrase, HashAlgorithmTag s2kDigest)
	{
		S2k s2k = PgpUtilities.GenerateS2k(s2kDigest, 96, rand);
		methods.Add(new PbeMethod(defAlgorithm, s2k, PgpUtilities.DoMakeKeyFromPassPhrase(defAlgorithm, s2k, rawPassPhrase, clearPassPhrase)));
	}

	public void AddMethod(PgpPublicKey key)
	{
		AddMethod(key, sessionKeyObfuscation: true);
	}

	public void AddMethod(PgpPublicKey key, bool sessionKeyObfuscation)
	{
		if (!key.IsEncryptionKey)
		{
			throw new ArgumentException("passed in key not an encryption key!");
		}
		methods.Add(new PubMethod(key, sessionKeyObfuscation));
	}

	private void AddCheckSum(byte[] sessionInfo)
	{
		int check = 0;
		for (int i = 1; i < sessionInfo.Length - 2; i++)
		{
			check += sessionInfo[i];
		}
		sessionInfo[sessionInfo.Length - 2] = (byte)(check >> 8);
		sessionInfo[sessionInfo.Length - 1] = (byte)check;
	}

	private byte[] CreateSessionInfo(SymmetricKeyAlgorithmTag algorithm, KeyParameter key)
	{
		byte[] key2 = key.GetKey();
		byte[] sessionInfo = new byte[key2.Length + 3];
		sessionInfo[0] = (byte)algorithm;
		key2.CopyTo(sessionInfo, 1);
		AddCheckSum(sessionInfo);
		return sessionInfo;
	}

	private Stream Open(Stream outStr, long length, byte[] buffer)
	{
		if (cOut != null)
		{
			throw new InvalidOperationException("generator already in open state");
		}
		if (methods.Count == 0)
		{
			throw new InvalidOperationException("No encryption methods specified");
		}
		if (outStr == null)
		{
			throw new ArgumentNullException("outStr");
		}
		pOut = new BcpgOutputStream(outStr);
		KeyParameter key;
		if (methods.Count == 1)
		{
			if (methods[0] is PbeMethod)
			{
				key = ((PbeMethod)methods[0]).GetKey();
			}
			else
			{
				key = PgpUtilities.MakeRandomKey(defAlgorithm, rand);
				byte[] sessionInfo = CreateSessionInfo(defAlgorithm, key);
				PubMethod m = (PubMethod)methods[0];
				try
				{
					m.AddSessionInfo(sessionInfo, rand);
				}
				catch (Exception exception)
				{
					throw new PgpException("exception encrypting session key", exception);
				}
			}
			pOut.WritePacket((ContainedPacket)methods[0]);
		}
		else
		{
			key = PgpUtilities.MakeRandomKey(defAlgorithm, rand);
			byte[] sessionInfo2 = CreateSessionInfo(defAlgorithm, key);
			for (int i = 0; i != methods.Count; i++)
			{
				EncMethod m2 = (EncMethod)methods[i];
				try
				{
					m2.AddSessionInfo(sessionInfo2, rand);
				}
				catch (Exception exception2)
				{
					throw new PgpException("exception encrypting session key", exception2);
				}
				pOut.WritePacket(m2);
			}
		}
		string cName = PgpUtilities.GetSymmetricCipherName(defAlgorithm);
		if (cName == null)
		{
			throw new PgpException("null cipher specified");
		}
		try
		{
			cName = ((!withIntegrityPacket) ? (cName + "/OpenPGPCFB/NoPadding") : (cName + "/CFB/NoPadding"));
			c = CipherUtilities.GetCipher(cName);
			byte[] iv = new byte[c.GetBlockSize()];
			c.Init(forEncryption: true, new ParametersWithRandom(new ParametersWithIV(key, iv), rand));
			if (buffer == null)
			{
				if (withIntegrityPacket)
				{
					pOut = new BcpgOutputStream(outStr, PacketTag.SymmetricEncryptedIntegrityProtected, length + c.GetBlockSize() + 2 + 1 + 22);
					pOut.WriteByte(1);
				}
				else
				{
					pOut = new BcpgOutputStream(outStr, PacketTag.SymmetricKeyEncrypted, length + c.GetBlockSize() + 2, oldFormat);
				}
			}
			else if (withIntegrityPacket)
			{
				pOut = new BcpgOutputStream(outStr, PacketTag.SymmetricEncryptedIntegrityProtected, buffer);
				pOut.WriteByte(1);
			}
			else
			{
				pOut = new BcpgOutputStream(outStr, PacketTag.SymmetricKeyEncrypted, buffer);
			}
			int blockSize = c.GetBlockSize();
			byte[] inLineIv = new byte[blockSize + 2];
			rand.NextBytes(inLineIv, 0, blockSize);
			Array.Copy(inLineIv, inLineIv.Length - 4, inLineIv, inLineIv.Length - 2, 2);
			Stream myOut = (cOut = new CipherStream(pOut, null, c));
			if (withIntegrityPacket)
			{
				IDigest digest = DigestUtilities.GetDigest(PgpUtilities.GetDigestName(HashAlgorithmTag.Sha1));
				myOut = (digestOut = new DigestStream(myOut, null, digest));
			}
			myOut.Write(inLineIv, 0, inLineIv.Length);
			return new WrappedGeneratorStream(this, myOut);
		}
		catch (Exception exception3)
		{
			throw new PgpException("Exception creating cipher", exception3);
		}
	}

	public Stream Open(Stream outStr, long length)
	{
		return Open(outStr, length, null);
	}

	public Stream Open(Stream outStr, byte[] buffer)
	{
		return Open(outStr, 0L, buffer);
	}

	public void Close()
	{
		if (cOut != null)
		{
			if (digestOut != null)
			{
				new BcpgOutputStream(digestOut, PacketTag.ModificationDetectionCode, 20L).Flush();
				digestOut.Flush();
				byte[] dig = DigestUtilities.DoFinal(digestOut.WriteDigest());
				cOut.Write(dig, 0, dig.Length);
			}
			cOut.Flush();
			try
			{
				pOut.Write(c.DoFinal());
				pOut.Finish();
			}
			catch (Exception ex)
			{
				throw new IOException(ex.Message, ex);
			}
			cOut = null;
			pOut = null;
		}
	}
}
