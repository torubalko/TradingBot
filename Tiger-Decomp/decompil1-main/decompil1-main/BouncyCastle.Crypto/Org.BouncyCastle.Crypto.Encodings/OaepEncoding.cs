using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Encodings;

public class OaepEncoding : IAsymmetricBlockCipher
{
	private byte[] defHash;

	private IDigest mgf1Hash;

	private IAsymmetricBlockCipher engine;

	private SecureRandom random;

	private bool forEncryption;

	public string AlgorithmName => engine.AlgorithmName + "/OAEPPadding";

	public OaepEncoding(IAsymmetricBlockCipher cipher)
		: this(cipher, new Sha1Digest(), null)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash)
		: this(cipher, hash, null)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, byte[] encodingParams)
		: this(cipher, hash, hash, encodingParams)
	{
	}

	public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, IDigest mgf1Hash, byte[] encodingParams)
	{
		engine = cipher;
		this.mgf1Hash = mgf1Hash;
		defHash = new byte[hash.GetDigestSize()];
		hash.Reset();
		if (encodingParams != null)
		{
			hash.BlockUpdate(encodingParams, 0, encodingParams.Length);
		}
		hash.DoFinal(defHash, 0);
	}

	public IAsymmetricBlockCipher GetUnderlyingCipher()
	{
		return engine;
	}

	public void Init(bool forEncryption, ICipherParameters param)
	{
		if (param is ParametersWithRandom)
		{
			ParametersWithRandom rParam = (ParametersWithRandom)param;
			random = rParam.Random;
		}
		else
		{
			random = new SecureRandom();
		}
		engine.Init(forEncryption, param);
		this.forEncryption = forEncryption;
	}

	public int GetInputBlockSize()
	{
		int baseBlockSize = engine.GetInputBlockSize();
		if (forEncryption)
		{
			return baseBlockSize - 1 - 2 * defHash.Length;
		}
		return baseBlockSize;
	}

	public int GetOutputBlockSize()
	{
		int baseBlockSize = engine.GetOutputBlockSize();
		if (forEncryption)
		{
			return baseBlockSize;
		}
		return baseBlockSize - 1 - 2 * defHash.Length;
	}

	public byte[] ProcessBlock(byte[] inBytes, int inOff, int inLen)
	{
		if (forEncryption)
		{
			return EncodeBlock(inBytes, inOff, inLen);
		}
		return DecodeBlock(inBytes, inOff, inLen);
	}

	private byte[] EncodeBlock(byte[] inBytes, int inOff, int inLen)
	{
		Check.DataLength(inLen > GetInputBlockSize(), "input data too long");
		byte[] block = new byte[GetInputBlockSize() + 1 + 2 * defHash.Length];
		Array.Copy(inBytes, inOff, block, block.Length - inLen, inLen);
		block[block.Length - inLen - 1] = 1;
		Array.Copy(defHash, 0, block, defHash.Length, defHash.Length);
		byte[] seed = SecureRandom.GetNextBytes(random, defHash.Length);
		byte[] mask = MaskGeneratorFunction(seed, 0, seed.Length, block.Length - defHash.Length);
		for (int i = defHash.Length; i != block.Length; i++)
		{
			block[i] ^= mask[i - defHash.Length];
		}
		Array.Copy(seed, 0, block, 0, defHash.Length);
		mask = MaskGeneratorFunction(block, defHash.Length, block.Length - defHash.Length, defHash.Length);
		for (int j = 0; j != defHash.Length; j++)
		{
			block[j] ^= mask[j];
		}
		return engine.ProcessBlock(block, 0, block.Length);
	}

	private byte[] DecodeBlock(byte[] inBytes, int inOff, int inLen)
	{
		byte[] data = engine.ProcessBlock(inBytes, inOff, inLen);
		byte[] block = new byte[engine.GetOutputBlockSize()];
		bool wrongData = block.Length < 2 * defHash.Length + 1;
		if (data.Length <= block.Length)
		{
			Array.Copy(data, 0, block, block.Length - data.Length, data.Length);
		}
		else
		{
			Array.Copy(data, 0, block, 0, block.Length);
			wrongData = true;
		}
		byte[] mask = MaskGeneratorFunction(block, defHash.Length, block.Length - defHash.Length, defHash.Length);
		for (int i = 0; i != defHash.Length; i++)
		{
			block[i] ^= mask[i];
		}
		mask = MaskGeneratorFunction(block, 0, defHash.Length, block.Length - defHash.Length);
		for (int j = defHash.Length; j != block.Length; j++)
		{
			block[j] ^= mask[j - defHash.Length];
		}
		bool defHashWrong = false;
		for (int k = 0; k != defHash.Length; k++)
		{
			if (defHash[k] != block[defHash.Length + k])
			{
				defHashWrong = true;
			}
		}
		int start = block.Length;
		for (int index = 2 * defHash.Length; index != block.Length; index++)
		{
			if ((block[index] != 0) & (start == block.Length))
			{
				start = index;
			}
		}
		bool dataStartWrong = (start > block.Length - 1) | (block[start] != 1);
		start++;
		if (defHashWrong || wrongData || dataStartWrong)
		{
			Arrays.Fill(block, 0);
			throw new InvalidCipherTextException("data wrong");
		}
		byte[] output = new byte[block.Length - start];
		Array.Copy(block, start, output, 0, output.Length);
		Array.Clear(block, 0, block.Length);
		return output;
	}

	private byte[] MaskGeneratorFunction(byte[] Z, int zOff, int zLen, int length)
	{
		if (mgf1Hash is IXof)
		{
			byte[] mask = new byte[length];
			mgf1Hash.BlockUpdate(Z, zOff, zLen);
			((IXof)mgf1Hash).DoFinal(mask, 0, mask.Length);
			return mask;
		}
		return MaskGeneratorFunction1(Z, zOff, zLen, length);
	}

	private byte[] MaskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
	{
		byte[] mask = new byte[length];
		byte[] hashBuf = new byte[mgf1Hash.GetDigestSize()];
		byte[] C = new byte[4];
		int counter = 0;
		mgf1Hash.Reset();
		for (; counter < length / hashBuf.Length; counter++)
		{
			Pack.UInt32_To_BE((uint)counter, C);
			mgf1Hash.BlockUpdate(Z, zOff, zLen);
			mgf1Hash.BlockUpdate(C, 0, C.Length);
			mgf1Hash.DoFinal(hashBuf, 0);
			Array.Copy(hashBuf, 0, mask, counter * hashBuf.Length, hashBuf.Length);
		}
		if (counter * hashBuf.Length < length)
		{
			Pack.UInt32_To_BE((uint)counter, C);
			mgf1Hash.BlockUpdate(Z, zOff, zLen);
			mgf1Hash.BlockUpdate(C, 0, C.Length);
			mgf1Hash.DoFinal(hashBuf, 0);
			Array.Copy(hashBuf, 0, mask, counter * hashBuf.Length, mask.Length - counter * hashBuf.Length);
		}
		return mask;
	}
}
