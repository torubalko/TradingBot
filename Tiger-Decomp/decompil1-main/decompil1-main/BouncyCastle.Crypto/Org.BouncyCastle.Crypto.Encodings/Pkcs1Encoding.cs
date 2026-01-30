using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Encodings;

public class Pkcs1Encoding : IAsymmetricBlockCipher
{
	public const string StrictLengthEnabledProperty = "Org.BouncyCastle.Pkcs1.Strict";

	private const int HeaderLength = 10;

	private static readonly bool[] strictLengthEnabled;

	private SecureRandom random;

	private IAsymmetricBlockCipher engine;

	private bool forEncryption;

	private bool forPrivateKey;

	private bool useStrictLength;

	private int pLen = -1;

	private byte[] fallback;

	private byte[] blockBuffer;

	public static bool StrictLengthEnabled
	{
		get
		{
			return strictLengthEnabled[0];
		}
		set
		{
			strictLengthEnabled[0] = value;
		}
	}

	public string AlgorithmName => engine.AlgorithmName + "/PKCS1Padding";

	static Pkcs1Encoding()
	{
		string strictProperty = Platform.GetEnvironmentVariable("Org.BouncyCastle.Pkcs1.Strict");
		strictLengthEnabled = new bool[1] { strictProperty == null || Platform.EqualsIgnoreCase("true", strictProperty) };
	}

	public Pkcs1Encoding(IAsymmetricBlockCipher cipher)
	{
		engine = cipher;
		useStrictLength = StrictLengthEnabled;
	}

	public Pkcs1Encoding(IAsymmetricBlockCipher cipher, int pLen)
	{
		engine = cipher;
		useStrictLength = StrictLengthEnabled;
		this.pLen = pLen;
	}

	public Pkcs1Encoding(IAsymmetricBlockCipher cipher, byte[] fallback)
	{
		engine = cipher;
		useStrictLength = StrictLengthEnabled;
		this.fallback = fallback;
		pLen = fallback.Length;
	}

	public IAsymmetricBlockCipher GetUnderlyingCipher()
	{
		return engine;
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
		AsymmetricKeyParameter kParam;
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom rParam = (ParametersWithRandom)parameters;
			random = rParam.Random;
			kParam = (AsymmetricKeyParameter)rParam.Parameters;
		}
		else
		{
			random = new SecureRandom();
			kParam = (AsymmetricKeyParameter)parameters;
		}
		engine.Init(forEncryption, parameters);
		forPrivateKey = kParam.IsPrivate;
		this.forEncryption = forEncryption;
		blockBuffer = new byte[engine.GetOutputBlockSize()];
		if (pLen > 0 && fallback == null && random == null)
		{
			throw new ArgumentException("encoder requires random");
		}
	}

	public int GetInputBlockSize()
	{
		int baseBlockSize = engine.GetInputBlockSize();
		if (!forEncryption)
		{
			return baseBlockSize;
		}
		return baseBlockSize - 10;
	}

	public int GetOutputBlockSize()
	{
		int baseBlockSize = engine.GetOutputBlockSize();
		if (!forEncryption)
		{
			return baseBlockSize - 10;
		}
		return baseBlockSize;
	}

	public byte[] ProcessBlock(byte[] input, int inOff, int length)
	{
		if (!forEncryption)
		{
			return DecodeBlock(input, inOff, length);
		}
		return EncodeBlock(input, inOff, length);
	}

	private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
	{
		if (inLen > GetInputBlockSize())
		{
			throw new ArgumentException("input data too large", "inLen");
		}
		byte[] block = new byte[engine.GetInputBlockSize()];
		if (forPrivateKey)
		{
			block[0] = 1;
			for (int i = 1; i != block.Length - inLen - 1; i++)
			{
				block[i] = byte.MaxValue;
			}
		}
		else
		{
			random.NextBytes(block);
			block[0] = 2;
			for (int j = 1; j != block.Length - inLen - 1; j++)
			{
				while (block[j] == 0)
				{
					block[j] = (byte)random.NextInt();
				}
			}
		}
		block[block.Length - inLen - 1] = 0;
		Array.Copy(input, inOff, block, block.Length - inLen, inLen);
		return engine.ProcessBlock(block, 0, block.Length);
	}

	private static int CheckPkcs1Encoding(byte[] encoded, int pLen)
	{
		int correct = 0;
		correct |= encoded[0] ^ 2;
		int plen = encoded.Length - (pLen + 1);
		for (int i = 1; i < plen; i++)
		{
			int tmp = encoded[i];
			tmp |= tmp >> 1;
			tmp |= tmp >> 2;
			tmp |= tmp >> 4;
			correct |= (tmp & 1) - 1;
		}
		correct |= encoded[encoded.Length - (pLen + 1)];
		correct |= correct >> 1;
		correct |= correct >> 2;
		correct |= correct >> 4;
		return ~((correct & 1) - 1);
	}

	private byte[] DecodeBlockOrRandom(byte[] input, int inOff, int inLen)
	{
		if (!forPrivateKey)
		{
			throw new InvalidCipherTextException("sorry, this method is only for decryption, not for signing");
		}
		byte[] block = engine.ProcessBlock(input, inOff, inLen);
		byte[] random;
		if (fallback == null)
		{
			random = new byte[pLen];
			this.random.NextBytes(random);
		}
		else
		{
			random = fallback;
		}
		byte[] data = ((useStrictLength & (block.Length != engine.GetOutputBlockSize())) ? blockBuffer : block);
		int correct = CheckPkcs1Encoding(data, pLen);
		byte[] result = new byte[pLen];
		for (int i = 0; i < pLen; i++)
		{
			result[i] = (byte)((data[i + (data.Length - pLen)] & ~correct) | (random[i] & correct));
		}
		Arrays.Fill(data, 0);
		return result;
	}

	private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
	{
		if (pLen != -1)
		{
			return DecodeBlockOrRandom(input, inOff, inLen);
		}
		byte[] block = engine.ProcessBlock(input, inOff, inLen);
		bool num = useStrictLength & (block.Length != engine.GetOutputBlockSize());
		byte[] data = ((block.Length >= GetOutputBlockSize()) ? block : blockBuffer);
		byte expectedType = (byte)((!forPrivateKey) ? 1u : 2u);
		byte type = data[0];
		bool num2 = type != expectedType;
		int start = FindStart(type, data);
		start++;
		if (num2 || start < 10)
		{
			Arrays.Fill(data, 0);
			throw new InvalidCipherTextException("block incorrect");
		}
		if (num)
		{
			Arrays.Fill(data, 0);
			throw new InvalidCipherTextException("block incorrect size");
		}
		byte[] result = new byte[data.Length - start];
		Array.Copy(data, start, result, 0, result.Length);
		return result;
	}

	private int FindStart(byte type, byte[] block)
	{
		int start = -1;
		bool padErr = false;
		for (int i = 1; i != block.Length; i++)
		{
			byte pad = block[i];
			if (pad == 0 && start < 0)
			{
				start = i;
			}
			padErr = padErr || (type == 1 && start < 0 && pad != byte.MaxValue);
		}
		if (!padErr)
		{
			return start;
		}
		return -1;
	}
}
