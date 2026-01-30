using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class DesEdeWrapEngine : IWrapper
{
	private CbcBlockCipher engine;

	private KeyParameter param;

	private ParametersWithIV paramPlusIV;

	private byte[] iv;

	private bool forWrapping;

	private static readonly byte[] IV2 = new byte[8] { 74, 221, 162, 44, 121, 232, 33, 5 };

	private readonly IDigest sha1 = new Sha1Digest();

	private readonly byte[] digest = new byte[20];

	public virtual string AlgorithmName => "DESede";

	public virtual void Init(bool forWrapping, ICipherParameters parameters)
	{
		this.forWrapping = forWrapping;
		engine = new CbcBlockCipher(new DesEdeEngine());
		SecureRandom sr;
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom obj = (ParametersWithRandom)parameters;
			parameters = obj.Parameters;
			sr = obj.Random;
		}
		else
		{
			sr = new SecureRandom();
		}
		if (parameters is KeyParameter)
		{
			param = (KeyParameter)parameters;
			if (this.forWrapping)
			{
				iv = new byte[8];
				sr.NextBytes(iv);
				paramPlusIV = new ParametersWithIV(param, iv);
			}
		}
		else if (parameters is ParametersWithIV)
		{
			if (!forWrapping)
			{
				throw new ArgumentException("You should not supply an IV for unwrapping");
			}
			paramPlusIV = (ParametersWithIV)parameters;
			iv = paramPlusIV.GetIV();
			param = (KeyParameter)paramPlusIV.Parameters;
			if (iv.Length != 8)
			{
				throw new ArgumentException("IV is not 8 octets", "parameters");
			}
		}
	}

	public virtual byte[] Wrap(byte[] input, int inOff, int length)
	{
		if (!forWrapping)
		{
			throw new InvalidOperationException("Not initialized for wrapping");
		}
		byte[] keyToBeWrapped = new byte[length];
		Array.Copy(input, inOff, keyToBeWrapped, 0, length);
		byte[] CKS = CalculateCmsKeyChecksum(keyToBeWrapped);
		byte[] WKCKS = new byte[keyToBeWrapped.Length + CKS.Length];
		Array.Copy(keyToBeWrapped, 0, WKCKS, 0, keyToBeWrapped.Length);
		Array.Copy(CKS, 0, WKCKS, keyToBeWrapped.Length, CKS.Length);
		int blockSize = engine.GetBlockSize();
		if (WKCKS.Length % blockSize != 0)
		{
			throw new InvalidOperationException("Not multiple of block length");
		}
		engine.Init(forEncryption: true, paramPlusIV);
		byte[] TEMP1 = new byte[WKCKS.Length];
		for (int currentBytePos = 0; currentBytePos != WKCKS.Length; currentBytePos += blockSize)
		{
			engine.ProcessBlock(WKCKS, currentBytePos, TEMP1, currentBytePos);
		}
		byte[] TEMP2 = new byte[iv.Length + TEMP1.Length];
		Array.Copy(iv, 0, TEMP2, 0, iv.Length);
		Array.Copy(TEMP1, 0, TEMP2, iv.Length, TEMP1.Length);
		byte[] TEMP3 = reverse(TEMP2);
		ParametersWithIV param2 = new ParametersWithIV(param, IV2);
		engine.Init(forEncryption: true, param2);
		for (int i = 0; i != TEMP3.Length; i += blockSize)
		{
			engine.ProcessBlock(TEMP3, i, TEMP3, i);
		}
		return TEMP3;
	}

	public virtual byte[] Unwrap(byte[] input, int inOff, int length)
	{
		if (forWrapping)
		{
			throw new InvalidOperationException("Not set for unwrapping");
		}
		if (input == null)
		{
			throw new InvalidCipherTextException("Null pointer as ciphertext");
		}
		int blockSize = engine.GetBlockSize();
		if (length % blockSize != 0)
		{
			throw new InvalidCipherTextException("Ciphertext not multiple of " + blockSize);
		}
		ParametersWithIV param2 = new ParametersWithIV(param, IV2);
		engine.Init(forEncryption: false, param2);
		byte[] TEMP3 = new byte[length];
		for (int currentBytePos = 0; currentBytePos != TEMP3.Length; currentBytePos += blockSize)
		{
			engine.ProcessBlock(input, inOff + currentBytePos, TEMP3, currentBytePos);
		}
		byte[] TEMP4 = reverse(TEMP3);
		iv = new byte[8];
		byte[] TEMP5 = new byte[TEMP4.Length - 8];
		Array.Copy(TEMP4, 0, iv, 0, 8);
		Array.Copy(TEMP4, 8, TEMP5, 0, TEMP4.Length - 8);
		paramPlusIV = new ParametersWithIV(param, iv);
		engine.Init(forEncryption: false, paramPlusIV);
		byte[] WKCKS = new byte[TEMP5.Length];
		for (int i = 0; i != WKCKS.Length; i += blockSize)
		{
			engine.ProcessBlock(TEMP5, i, WKCKS, i);
		}
		byte[] result = new byte[WKCKS.Length - 8];
		byte[] CKStoBeVerified = new byte[8];
		Array.Copy(WKCKS, 0, result, 0, WKCKS.Length - 8);
		Array.Copy(WKCKS, WKCKS.Length - 8, CKStoBeVerified, 0, 8);
		if (!CheckCmsKeyChecksum(result, CKStoBeVerified))
		{
			throw new InvalidCipherTextException("Checksum inside ciphertext is corrupted");
		}
		return result;
	}

	private byte[] CalculateCmsKeyChecksum(byte[] key)
	{
		sha1.BlockUpdate(key, 0, key.Length);
		sha1.DoFinal(digest, 0);
		byte[] result = new byte[8];
		Array.Copy(digest, 0, result, 0, 8);
		return result;
	}

	private bool CheckCmsKeyChecksum(byte[] key, byte[] checksum)
	{
		return Arrays.ConstantTimeAreEqual(CalculateCmsKeyChecksum(key), checksum);
	}

	private static byte[] reverse(byte[] bs)
	{
		byte[] result = new byte[bs.Length];
		for (int i = 0; i < bs.Length; i++)
		{
			result[i] = bs[bs.Length - (i + 1)];
		}
		return result;
	}
}
