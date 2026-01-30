using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes;

public class OcbBlockCipher : IAeadBlockCipher, IAeadCipher
{
	private const int BLOCK_SIZE = 16;

	private readonly IBlockCipher hashCipher;

	private readonly IBlockCipher mainCipher;

	private bool forEncryption;

	private int macSize;

	private byte[] initialAssociatedText;

	private IList L;

	private byte[] L_Asterisk;

	private byte[] L_Dollar;

	private byte[] KtopInput;

	private byte[] Stretch = new byte[24];

	private byte[] OffsetMAIN_0 = new byte[16];

	private byte[] hashBlock;

	private byte[] mainBlock;

	private int hashBlockPos;

	private int mainBlockPos;

	private long hashBlockCount;

	private long mainBlockCount;

	private byte[] OffsetHASH;

	private byte[] Sum;

	private byte[] OffsetMAIN = new byte[16];

	private byte[] Checksum;

	private byte[] macBlock;

	public virtual string AlgorithmName => mainCipher.AlgorithmName + "/OCB";

	public OcbBlockCipher(IBlockCipher hashCipher, IBlockCipher mainCipher)
	{
		if (hashCipher == null)
		{
			throw new ArgumentNullException("hashCipher");
		}
		if (hashCipher.GetBlockSize() != 16)
		{
			throw new ArgumentException("must have a block size of " + 16, "hashCipher");
		}
		if (mainCipher == null)
		{
			throw new ArgumentNullException("mainCipher");
		}
		if (mainCipher.GetBlockSize() != 16)
		{
			throw new ArgumentException("must have a block size of " + 16, "mainCipher");
		}
		if (!hashCipher.AlgorithmName.Equals(mainCipher.AlgorithmName))
		{
			throw new ArgumentException("'hashCipher' and 'mainCipher' must be the same algorithm");
		}
		this.hashCipher = hashCipher;
		this.mainCipher = mainCipher;
	}

	public virtual IBlockCipher GetUnderlyingCipher()
	{
		return mainCipher;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		bool oldForEncryption = this.forEncryption;
		this.forEncryption = forEncryption;
		macBlock = null;
		byte[] N;
		KeyParameter keyParameter;
		if (parameters is AeadParameters)
		{
			AeadParameters aeadParameters = (AeadParameters)parameters;
			N = aeadParameters.GetNonce();
			initialAssociatedText = aeadParameters.GetAssociatedText();
			int macSizeBits = aeadParameters.MacSize;
			if (macSizeBits < 64 || macSizeBits > 128 || macSizeBits % 8 != 0)
			{
				throw new ArgumentException("Invalid value for MAC size: " + macSizeBits);
			}
			macSize = macSizeBits / 8;
			keyParameter = aeadParameters.Key;
		}
		else
		{
			if (!(parameters is ParametersWithIV))
			{
				throw new ArgumentException("invalid parameters passed to OCB");
			}
			ParametersWithIV obj = (ParametersWithIV)parameters;
			N = obj.GetIV();
			initialAssociatedText = null;
			macSize = 16;
			keyParameter = (KeyParameter)obj.Parameters;
		}
		hashBlock = new byte[16];
		mainBlock = new byte[forEncryption ? 16 : (16 + macSize)];
		if (N == null)
		{
			N = new byte[0];
		}
		if (N.Length > 15)
		{
			throw new ArgumentException("IV must be no more than 15 bytes");
		}
		if (keyParameter != null)
		{
			hashCipher.Init(forEncryption: true, keyParameter);
			mainCipher.Init(forEncryption, keyParameter);
			KtopInput = null;
		}
		else if (oldForEncryption != forEncryption)
		{
			throw new ArgumentException("cannot change encrypting state without providing key.");
		}
		L_Asterisk = new byte[16];
		hashCipher.ProcessBlock(L_Asterisk, 0, L_Asterisk, 0);
		L_Dollar = OCB_double(L_Asterisk);
		L = Platform.CreateArrayList();
		L.Add(OCB_double(L_Dollar));
		int num = ProcessNonce(N);
		int bits = num % 8;
		int bytes = num / 8;
		if (bits == 0)
		{
			Array.Copy(Stretch, bytes, OffsetMAIN_0, 0, 16);
		}
		else
		{
			for (int i = 0; i < 16; i++)
			{
				uint b1 = Stretch[bytes];
				uint b2 = Stretch[++bytes];
				OffsetMAIN_0[i] = (byte)((b1 << bits) | (b2 >> 8 - bits));
			}
		}
		hashBlockPos = 0;
		mainBlockPos = 0;
		hashBlockCount = 0L;
		mainBlockCount = 0L;
		OffsetHASH = new byte[16];
		Sum = new byte[16];
		Array.Copy(OffsetMAIN_0, 0, OffsetMAIN, 0, 16);
		Checksum = new byte[16];
		if (initialAssociatedText != null)
		{
			ProcessAadBytes(initialAssociatedText, 0, initialAssociatedText.Length);
		}
	}

	protected virtual int ProcessNonce(byte[] N)
	{
		byte[] nonce = new byte[16];
		Array.Copy(N, 0, nonce, nonce.Length - N.Length, N.Length);
		nonce[0] = (byte)(macSize << 4);
		nonce[15 - N.Length] |= 1;
		int bottom = nonce[15] & 0x3F;
		nonce[15] &= 192;
		if (KtopInput == null || !Arrays.AreEqual(nonce, KtopInput))
		{
			byte[] Ktop = new byte[16];
			KtopInput = nonce;
			hashCipher.ProcessBlock(KtopInput, 0, Ktop, 0);
			Array.Copy(Ktop, 0, Stretch, 0, 16);
			for (int i = 0; i < 8; i++)
			{
				Stretch[16 + i] = (byte)(Ktop[i] ^ Ktop[i + 1]);
			}
		}
		return bottom;
	}

	public virtual int GetBlockSize()
	{
		return 16;
	}

	public virtual byte[] GetMac()
	{
		if (macBlock != null)
		{
			return Arrays.Clone(macBlock);
		}
		return new byte[macSize];
	}

	public virtual int GetOutputSize(int len)
	{
		int totalData = len + mainBlockPos;
		if (forEncryption)
		{
			return totalData + macSize;
		}
		if (totalData >= macSize)
		{
			return totalData - macSize;
		}
		return 0;
	}

	public virtual int GetUpdateOutputSize(int len)
	{
		int totalData = len + mainBlockPos;
		if (!forEncryption)
		{
			if (totalData < macSize)
			{
				return 0;
			}
			totalData -= macSize;
		}
		return totalData - totalData % 16;
	}

	public virtual void ProcessAadByte(byte input)
	{
		hashBlock[hashBlockPos] = input;
		if (++hashBlockPos == hashBlock.Length)
		{
			ProcessHashBlock();
		}
	}

	public virtual void ProcessAadBytes(byte[] input, int off, int len)
	{
		for (int i = 0; i < len; i++)
		{
			hashBlock[hashBlockPos] = input[off + i];
			if (++hashBlockPos == hashBlock.Length)
			{
				ProcessHashBlock();
			}
		}
	}

	public virtual int ProcessByte(byte input, byte[] output, int outOff)
	{
		mainBlock[mainBlockPos] = input;
		if (++mainBlockPos == mainBlock.Length)
		{
			ProcessMainBlock(output, outOff);
			return 16;
		}
		return 0;
	}

	public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		int resultLen = 0;
		for (int i = 0; i < len; i++)
		{
			mainBlock[mainBlockPos] = input[inOff + i];
			if (++mainBlockPos == mainBlock.Length)
			{
				ProcessMainBlock(output, outOff + resultLen);
				resultLen += 16;
			}
		}
		return resultLen;
	}

	public virtual int DoFinal(byte[] output, int outOff)
	{
		byte[] tag = null;
		if (!forEncryption)
		{
			if (mainBlockPos < macSize)
			{
				throw new InvalidCipherTextException("data too short");
			}
			mainBlockPos -= macSize;
			tag = new byte[macSize];
			Array.Copy(mainBlock, mainBlockPos, tag, 0, macSize);
		}
		if (hashBlockPos > 0)
		{
			OCB_extend(hashBlock, hashBlockPos);
			UpdateHASH(L_Asterisk);
		}
		if (mainBlockPos > 0)
		{
			if (forEncryption)
			{
				OCB_extend(mainBlock, mainBlockPos);
				Xor(Checksum, mainBlock);
			}
			Xor(OffsetMAIN, L_Asterisk);
			byte[] Pad = new byte[16];
			hashCipher.ProcessBlock(OffsetMAIN, 0, Pad, 0);
			Xor(mainBlock, Pad);
			Check.OutputLength(output, outOff, mainBlockPos, "Output buffer too short");
			Array.Copy(mainBlock, 0, output, outOff, mainBlockPos);
			if (!forEncryption)
			{
				OCB_extend(mainBlock, mainBlockPos);
				Xor(Checksum, mainBlock);
			}
		}
		Xor(Checksum, OffsetMAIN);
		Xor(Checksum, L_Dollar);
		hashCipher.ProcessBlock(Checksum, 0, Checksum, 0);
		Xor(Checksum, Sum);
		macBlock = new byte[macSize];
		Array.Copy(Checksum, 0, macBlock, 0, macSize);
		int resultLen = mainBlockPos;
		if (forEncryption)
		{
			Check.OutputLength(output, outOff, resultLen + macSize, "Output buffer too short");
			Array.Copy(macBlock, 0, output, outOff + resultLen, macSize);
			resultLen += macSize;
		}
		else if (!Arrays.ConstantTimeAreEqual(macBlock, tag))
		{
			throw new InvalidCipherTextException("mac check in OCB failed");
		}
		Reset(clearMac: false);
		return resultLen;
	}

	public virtual void Reset()
	{
		Reset(clearMac: true);
	}

	protected virtual void Clear(byte[] bs)
	{
		if (bs != null)
		{
			Array.Clear(bs, 0, bs.Length);
		}
	}

	protected virtual byte[] GetLSub(int n)
	{
		while (n >= L.Count)
		{
			L.Add(OCB_double((byte[])L[L.Count - 1]));
		}
		return (byte[])L[n];
	}

	protected virtual void ProcessHashBlock()
	{
		UpdateHASH(GetLSub(OCB_ntz(++hashBlockCount)));
		hashBlockPos = 0;
	}

	protected virtual void ProcessMainBlock(byte[] output, int outOff)
	{
		Check.DataLength(output, outOff, 16, "Output buffer too short");
		if (forEncryption)
		{
			Xor(Checksum, mainBlock);
			mainBlockPos = 0;
		}
		Xor(OffsetMAIN, GetLSub(OCB_ntz(++mainBlockCount)));
		Xor(mainBlock, OffsetMAIN);
		mainCipher.ProcessBlock(mainBlock, 0, mainBlock, 0);
		Xor(mainBlock, OffsetMAIN);
		Array.Copy(mainBlock, 0, output, outOff, 16);
		if (!forEncryption)
		{
			Xor(Checksum, mainBlock);
			Array.Copy(mainBlock, 16, mainBlock, 0, macSize);
			mainBlockPos = macSize;
		}
	}

	protected virtual void Reset(bool clearMac)
	{
		hashCipher.Reset();
		mainCipher.Reset();
		Clear(hashBlock);
		Clear(mainBlock);
		hashBlockPos = 0;
		mainBlockPos = 0;
		hashBlockCount = 0L;
		mainBlockCount = 0L;
		Clear(OffsetHASH);
		Clear(Sum);
		Array.Copy(OffsetMAIN_0, 0, OffsetMAIN, 0, 16);
		Clear(Checksum);
		if (clearMac)
		{
			macBlock = null;
		}
		if (initialAssociatedText != null)
		{
			ProcessAadBytes(initialAssociatedText, 0, initialAssociatedText.Length);
		}
	}

	protected virtual void UpdateHASH(byte[] LSub)
	{
		Xor(OffsetHASH, LSub);
		Xor(hashBlock, OffsetHASH);
		hashCipher.ProcessBlock(hashBlock, 0, hashBlock, 0);
		Xor(Sum, hashBlock);
	}

	protected static byte[] OCB_double(byte[] block)
	{
		byte[] result = new byte[16];
		int carry = ShiftLeft(block, result);
		result[15] ^= (byte)(135 >> (1 - carry << 3));
		return result;
	}

	protected static void OCB_extend(byte[] block, int pos)
	{
		block[pos] = 128;
		while (++pos < 16)
		{
			block[pos] = 0;
		}
	}

	protected static int OCB_ntz(long x)
	{
		if (x == 0L)
		{
			return 64;
		}
		int n = 0;
		ulong ux = (ulong)x;
		while ((ux & 1) == 0L)
		{
			n++;
			ux >>= 1;
		}
		return n;
	}

	protected static int ShiftLeft(byte[] block, byte[] output)
	{
		int i = 16;
		uint bit = 0u;
		while (--i >= 0)
		{
			uint b = block[i];
			output[i] = (byte)((b << 1) | bit);
			bit = (b >> 7) & 1;
		}
		return (int)bit;
	}

	protected static void Xor(byte[] block, byte[] val)
	{
		for (int i = 15; i >= 0; i--)
		{
			block[i] ^= val[i];
		}
	}
}
