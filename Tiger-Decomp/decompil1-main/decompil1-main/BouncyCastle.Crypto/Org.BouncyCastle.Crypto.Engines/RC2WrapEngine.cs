using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class RC2WrapEngine : IWrapper
{
	private CbcBlockCipher engine;

	private ICipherParameters parameters;

	private ParametersWithIV paramPlusIV;

	private byte[] iv;

	private bool forWrapping;

	private SecureRandom sr;

	private static readonly byte[] IV2 = new byte[8] { 74, 221, 162, 44, 121, 232, 33, 5 };

	private IDigest sha1 = new Sha1Digest();

	private byte[] digest = new byte[20];

	public virtual string AlgorithmName => "RC2";

	public virtual void Init(bool forWrapping, ICipherParameters parameters)
	{
		this.forWrapping = forWrapping;
		engine = new CbcBlockCipher(new RC2Engine());
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom pWithR = (ParametersWithRandom)parameters;
			sr = pWithR.Random;
			parameters = pWithR.Parameters;
		}
		else
		{
			sr = new SecureRandom();
		}
		if (parameters is ParametersWithIV)
		{
			if (!forWrapping)
			{
				throw new ArgumentException("You should not supply an IV for unwrapping");
			}
			paramPlusIV = (ParametersWithIV)parameters;
			iv = paramPlusIV.GetIV();
			this.parameters = paramPlusIV.Parameters;
			if (iv.Length != 8)
			{
				throw new ArgumentException("IV is not 8 octets");
			}
		}
		else
		{
			this.parameters = parameters;
			if (this.forWrapping)
			{
				iv = new byte[8];
				sr.NextBytes(iv);
				paramPlusIV = new ParametersWithIV(this.parameters, iv);
			}
		}
	}

	public virtual byte[] Wrap(byte[] input, int inOff, int length)
	{
		if (!forWrapping)
		{
			throw new InvalidOperationException("Not initialized for wrapping");
		}
		int len = length + 1;
		if (len % 8 != 0)
		{
			len += 8 - len % 8;
		}
		byte[] keyToBeWrapped = new byte[len];
		keyToBeWrapped[0] = (byte)length;
		Array.Copy(input, inOff, keyToBeWrapped, 1, length);
		byte[] pad = new byte[keyToBeWrapped.Length - length - 1];
		if (pad.Length != 0)
		{
			sr.NextBytes(pad);
			Array.Copy(pad, 0, keyToBeWrapped, length + 1, pad.Length);
		}
		byte[] CKS = CalculateCmsKeyChecksum(keyToBeWrapped);
		byte[] WKCKS = new byte[keyToBeWrapped.Length + CKS.Length];
		Array.Copy(keyToBeWrapped, 0, WKCKS, 0, keyToBeWrapped.Length);
		Array.Copy(CKS, 0, WKCKS, keyToBeWrapped.Length, CKS.Length);
		byte[] TEMP1 = new byte[WKCKS.Length];
		Array.Copy(WKCKS, 0, TEMP1, 0, WKCKS.Length);
		int noOfBlocks = WKCKS.Length / engine.GetBlockSize();
		if (WKCKS.Length % engine.GetBlockSize() != 0)
		{
			throw new InvalidOperationException("Not multiple of block length");
		}
		engine.Init(forEncryption: true, paramPlusIV);
		for (int i = 0; i < noOfBlocks; i++)
		{
			int currentBytePos = i * engine.GetBlockSize();
			engine.ProcessBlock(TEMP1, currentBytePos, TEMP1, currentBytePos);
		}
		byte[] TEMP2 = new byte[iv.Length + TEMP1.Length];
		Array.Copy(iv, 0, TEMP2, 0, iv.Length);
		Array.Copy(TEMP1, 0, TEMP2, iv.Length, TEMP1.Length);
		byte[] TEMP3 = new byte[TEMP2.Length];
		for (int j = 0; j < TEMP2.Length; j++)
		{
			TEMP3[j] = TEMP2[TEMP2.Length - (j + 1)];
		}
		ParametersWithIV param2 = new ParametersWithIV(parameters, IV2);
		engine.Init(forEncryption: true, param2);
		for (int k = 0; k < noOfBlocks + 1; k++)
		{
			int currentBytePos2 = k * engine.GetBlockSize();
			engine.ProcessBlock(TEMP3, currentBytePos2, TEMP3, currentBytePos2);
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
		if (length % engine.GetBlockSize() != 0)
		{
			throw new InvalidCipherTextException("Ciphertext not multiple of " + engine.GetBlockSize());
		}
		ParametersWithIV param2 = new ParametersWithIV(parameters, IV2);
		engine.Init(forEncryption: false, param2);
		byte[] TEMP3 = new byte[length];
		Array.Copy(input, inOff, TEMP3, 0, length);
		for (int i = 0; i < TEMP3.Length / engine.GetBlockSize(); i++)
		{
			int currentBytePos = i * engine.GetBlockSize();
			engine.ProcessBlock(TEMP3, currentBytePos, TEMP3, currentBytePos);
		}
		byte[] TEMP4 = new byte[TEMP3.Length];
		for (int j = 0; j < TEMP3.Length; j++)
		{
			TEMP4[j] = TEMP3[TEMP3.Length - (j + 1)];
		}
		iv = new byte[8];
		byte[] TEMP5 = new byte[TEMP4.Length - 8];
		Array.Copy(TEMP4, 0, iv, 0, 8);
		Array.Copy(TEMP4, 8, TEMP5, 0, TEMP4.Length - 8);
		paramPlusIV = new ParametersWithIV(parameters, iv);
		engine.Init(forEncryption: false, paramPlusIV);
		byte[] LCEKPADICV = new byte[TEMP5.Length];
		Array.Copy(TEMP5, 0, LCEKPADICV, 0, TEMP5.Length);
		for (int k = 0; k < LCEKPADICV.Length / engine.GetBlockSize(); k++)
		{
			int currentBytePos2 = k * engine.GetBlockSize();
			engine.ProcessBlock(LCEKPADICV, currentBytePos2, LCEKPADICV, currentBytePos2);
		}
		byte[] result = new byte[LCEKPADICV.Length - 8];
		byte[] CKStoBeVerified = new byte[8];
		Array.Copy(LCEKPADICV, 0, result, 0, LCEKPADICV.Length - 8);
		Array.Copy(LCEKPADICV, LCEKPADICV.Length - 8, CKStoBeVerified, 0, 8);
		if (!CheckCmsKeyChecksum(result, CKStoBeVerified))
		{
			throw new InvalidCipherTextException("Checksum inside ciphertext is corrupted");
		}
		if (result.Length - ((result[0] & 0xFF) + 1) > 7)
		{
			throw new InvalidCipherTextException("too many pad bytes (" + (result.Length - ((result[0] & 0xFF) + 1)) + ")");
		}
		byte[] CEK = new byte[result[0]];
		Array.Copy(result, 1, CEK, 0, CEK.Length);
		return CEK;
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
}
