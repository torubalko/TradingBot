using System;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes;

public class GcmBlockCipher : IAeadBlockCipher, IAeadCipher
{
	private const int BlockSize = 16;

	private readonly IBlockCipher cipher;

	private readonly IGcmMultiplier multiplier;

	private IGcmExponentiator exp;

	private bool forEncryption;

	private bool initialised;

	private int macSize;

	private byte[] lastKey;

	private byte[] nonce;

	private byte[] initialAssociatedText;

	private byte[] H;

	private byte[] J0;

	private byte[] bufBlock;

	private byte[] macBlock;

	private byte[] S;

	private byte[] S_at;

	private byte[] S_atPre;

	private byte[] counter;

	private uint blocksRemaining;

	private int bufOff;

	private ulong totalLength;

	private byte[] atBlock;

	private int atBlockPos;

	private ulong atLength;

	private ulong atLengthPre;

	public virtual string AlgorithmName => cipher.AlgorithmName + "/GCM";

	public GcmBlockCipher(IBlockCipher c)
		: this(c, null)
	{
	}

	public GcmBlockCipher(IBlockCipher c, IGcmMultiplier m)
	{
		if (c.GetBlockSize() != 16)
		{
			throw new ArgumentException("cipher required with a block size of " + 16 + ".");
		}
		if (m == null)
		{
			m = new Tables4kGcmMultiplier();
		}
		cipher = c;
		multiplier = m;
	}

	public IBlockCipher GetUnderlyingCipher()
	{
		return cipher;
	}

	public virtual int GetBlockSize()
	{
		return 16;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		this.forEncryption = forEncryption;
		macBlock = null;
		initialised = true;
		byte[] newNonce = null;
		KeyParameter keyParam;
		if (parameters is AeadParameters)
		{
			AeadParameters param = (AeadParameters)parameters;
			newNonce = param.GetNonce();
			initialAssociatedText = param.GetAssociatedText();
			int macSizeBits = param.MacSize;
			if (macSizeBits < 32 || macSizeBits > 128 || macSizeBits % 8 != 0)
			{
				throw new ArgumentException("Invalid value for MAC size: " + macSizeBits);
			}
			macSize = macSizeBits / 8;
			keyParam = param.Key;
		}
		else
		{
			if (!(parameters is ParametersWithIV))
			{
				throw new ArgumentException("invalid parameters passed to GCM");
			}
			ParametersWithIV obj = (ParametersWithIV)parameters;
			newNonce = obj.GetIV();
			initialAssociatedText = null;
			macSize = 16;
			keyParam = (KeyParameter)obj.Parameters;
		}
		int bufLength = (forEncryption ? 16 : (16 + macSize));
		bufBlock = new byte[bufLength];
		if (newNonce == null || newNonce.Length < 1)
		{
			throw new ArgumentException("IV must be at least 1 byte");
		}
		if (forEncryption && nonce != null && Arrays.AreEqual(nonce, newNonce))
		{
			if (keyParam == null)
			{
				throw new ArgumentException("cannot reuse nonce for GCM encryption");
			}
			if (lastKey != null && Arrays.AreEqual(lastKey, keyParam.GetKey()))
			{
				throw new ArgumentException("cannot reuse nonce for GCM encryption");
			}
		}
		nonce = newNonce;
		if (keyParam != null)
		{
			lastKey = keyParam.GetKey();
		}
		if (keyParam != null)
		{
			cipher.Init(forEncryption: true, keyParam);
			H = new byte[16];
			cipher.ProcessBlock(H, 0, H, 0);
			multiplier.Init(H);
			exp = null;
		}
		else if (H == null)
		{
			throw new ArgumentException("Key must be specified in initial init");
		}
		J0 = new byte[16];
		if (nonce.Length == 12)
		{
			Array.Copy(nonce, 0, J0, 0, nonce.Length);
			J0[15] = 1;
		}
		else
		{
			gHASH(J0, nonce, nonce.Length);
			byte[] X = new byte[16];
			Pack.UInt64_To_BE((ulong)nonce.Length * 8uL, X, 8);
			gHASHBlock(J0, X);
		}
		S = new byte[16];
		S_at = new byte[16];
		S_atPre = new byte[16];
		atBlock = new byte[16];
		atBlockPos = 0;
		atLength = 0uL;
		atLengthPre = 0uL;
		counter = Arrays.Clone(J0);
		blocksRemaining = 4294967294u;
		bufOff = 0;
		totalLength = 0uL;
		if (initialAssociatedText != null)
		{
			ProcessAadBytes(initialAssociatedText, 0, initialAssociatedText.Length);
		}
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
		int totalData = len + bufOff;
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
		int totalData = len + bufOff;
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
		CheckStatus();
		atBlock[atBlockPos] = input;
		if (++atBlockPos == 16)
		{
			gHASHBlock(S_at, atBlock);
			atBlockPos = 0;
			atLength += 16uL;
		}
	}

	public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
	{
		CheckStatus();
		for (int i = 0; i < len; i++)
		{
			atBlock[atBlockPos] = inBytes[inOff + i];
			if (++atBlockPos == 16)
			{
				gHASHBlock(S_at, atBlock);
				atBlockPos = 0;
				atLength += 16uL;
			}
		}
	}

	private void InitCipher()
	{
		if (atLength != 0)
		{
			Array.Copy(S_at, 0, S_atPre, 0, 16);
			atLengthPre = atLength;
		}
		if (atBlockPos > 0)
		{
			gHASHPartial(S_atPre, atBlock, 0, atBlockPos);
			atLengthPre += (uint)atBlockPos;
		}
		if (atLengthPre != 0)
		{
			Array.Copy(S_atPre, 0, S, 0, 16);
		}
	}

	public virtual int ProcessByte(byte input, byte[] output, int outOff)
	{
		CheckStatus();
		bufBlock[bufOff] = input;
		if (++bufOff == bufBlock.Length)
		{
			ProcessBlock(bufBlock, 0, output, outOff);
			if (forEncryption)
			{
				bufOff = 0;
			}
			else
			{
				Array.Copy(bufBlock, 16, bufBlock, 0, macSize);
				bufOff = macSize;
			}
			return 16;
		}
		return 0;
	}

	public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		CheckStatus();
		Check.DataLength(input, inOff, len, "input buffer too short");
		int resultLen = 0;
		if (forEncryption)
		{
			if (bufOff != 0)
			{
				while (len > 0)
				{
					len--;
					bufBlock[bufOff] = input[inOff++];
					if (++bufOff == 16)
					{
						ProcessBlock(bufBlock, 0, output, outOff);
						bufOff = 0;
						resultLen += 16;
						break;
					}
				}
			}
			while (len >= 16)
			{
				ProcessBlock(input, inOff, output, outOff + resultLen);
				inOff += 16;
				len -= 16;
				resultLen += 16;
			}
			if (len > 0)
			{
				Array.Copy(input, inOff, bufBlock, 0, len);
				bufOff = len;
			}
		}
		else
		{
			for (int i = 0; i < len; i++)
			{
				bufBlock[bufOff] = input[inOff + i];
				if (++bufOff == bufBlock.Length)
				{
					ProcessBlock(bufBlock, 0, output, outOff + resultLen);
					Array.Copy(bufBlock, 16, bufBlock, 0, macSize);
					bufOff = macSize;
					resultLen += 16;
				}
			}
		}
		return resultLen;
	}

	public int DoFinal(byte[] output, int outOff)
	{
		CheckStatus();
		if (totalLength == 0L)
		{
			InitCipher();
		}
		int extra = bufOff;
		if (forEncryption)
		{
			Check.OutputLength(output, outOff, extra + macSize, "Output buffer too short");
		}
		else
		{
			if (extra < macSize)
			{
				throw new InvalidCipherTextException("data too short");
			}
			extra -= macSize;
			Check.OutputLength(output, outOff, extra, "Output buffer too short");
		}
		if (extra > 0)
		{
			ProcessPartial(bufBlock, 0, extra, output, outOff);
		}
		atLength += (uint)atBlockPos;
		if (atLength > atLengthPre)
		{
			if (atBlockPos > 0)
			{
				gHASHPartial(S_at, atBlock, 0, atBlockPos);
			}
			if (atLengthPre != 0)
			{
				GcmUtilities.Xor(S_at, S_atPre);
			}
			long c = (long)(totalLength * 8 + 127 >> 7);
			byte[] H_c = new byte[16];
			if (exp == null)
			{
				exp = new BasicGcmExponentiator();
				exp.Init(H);
			}
			exp.ExponentiateX(c, H_c);
			GcmUtilities.Multiply(S_at, H_c);
			GcmUtilities.Xor(S, S_at);
		}
		byte[] X = new byte[16];
		Pack.UInt64_To_BE(atLength * 8, X, 0);
		Pack.UInt64_To_BE(totalLength * 8, X, 8);
		gHASHBlock(S, X);
		byte[] tag = new byte[16];
		cipher.ProcessBlock(J0, 0, tag, 0);
		GcmUtilities.Xor(tag, S);
		int resultLen = extra;
		macBlock = new byte[macSize];
		Array.Copy(tag, 0, macBlock, 0, macSize);
		if (forEncryption)
		{
			Array.Copy(macBlock, 0, output, outOff + bufOff, macSize);
			resultLen += macSize;
		}
		else
		{
			byte[] msgMac = new byte[macSize];
			Array.Copy(bufBlock, extra, msgMac, 0, macSize);
			if (!Arrays.ConstantTimeAreEqual(macBlock, msgMac))
			{
				throw new InvalidCipherTextException("mac check in GCM failed");
			}
		}
		Reset(clearMac: false);
		return resultLen;
	}

	public virtual void Reset()
	{
		Reset(clearMac: true);
	}

	private void Reset(bool clearMac)
	{
		cipher.Reset();
		S = new byte[16];
		S_at = new byte[16];
		S_atPre = new byte[16];
		atBlock = new byte[16];
		atBlockPos = 0;
		atLength = 0uL;
		atLengthPre = 0uL;
		counter = Arrays.Clone(J0);
		blocksRemaining = 4294967294u;
		bufOff = 0;
		totalLength = 0uL;
		if (bufBlock != null)
		{
			Arrays.Fill(bufBlock, 0);
		}
		if (clearMac)
		{
			macBlock = null;
		}
		if (forEncryption)
		{
			initialised = false;
		}
		else if (initialAssociatedText != null)
		{
			ProcessAadBytes(initialAssociatedText, 0, initialAssociatedText.Length);
		}
	}

	private void ProcessBlock(byte[] buf, int bufOff, byte[] output, int outOff)
	{
		Check.OutputLength(output, outOff, 16, "Output buffer too short");
		if (totalLength == 0L)
		{
			InitCipher();
		}
		byte[] ctrBlock = new byte[16];
		GetNextCtrBlock(ctrBlock);
		if (forEncryption)
		{
			GcmUtilities.Xor(ctrBlock, buf, bufOff);
			gHASHBlock(S, ctrBlock);
			Array.Copy(ctrBlock, 0, output, outOff, 16);
		}
		else
		{
			gHASHBlock(S, buf, bufOff);
			GcmUtilities.Xor(ctrBlock, 0, buf, bufOff, output, outOff);
		}
		totalLength += 16uL;
	}

	private void ProcessPartial(byte[] buf, int off, int len, byte[] output, int outOff)
	{
		byte[] ctrBlock = new byte[16];
		GetNextCtrBlock(ctrBlock);
		if (forEncryption)
		{
			GcmUtilities.Xor(buf, off, ctrBlock, 0, len);
			gHASHPartial(S, buf, off, len);
		}
		else
		{
			gHASHPartial(S, buf, off, len);
			GcmUtilities.Xor(buf, off, ctrBlock, 0, len);
		}
		Array.Copy(buf, off, output, outOff, len);
		totalLength += (uint)len;
	}

	private void gHASH(byte[] Y, byte[] b, int len)
	{
		for (int pos = 0; pos < len; pos += 16)
		{
			int num = System.Math.Min(len - pos, 16);
			gHASHPartial(Y, b, pos, num);
		}
	}

	private void gHASHBlock(byte[] Y, byte[] b)
	{
		GcmUtilities.Xor(Y, b);
		multiplier.MultiplyH(Y);
	}

	private void gHASHBlock(byte[] Y, byte[] b, int off)
	{
		GcmUtilities.Xor(Y, b, off);
		multiplier.MultiplyH(Y);
	}

	private void gHASHPartial(byte[] Y, byte[] b, int off, int len)
	{
		GcmUtilities.Xor(Y, b, off, len);
		multiplier.MultiplyH(Y);
	}

	private void GetNextCtrBlock(byte[] block)
	{
		if (blocksRemaining == 0)
		{
			throw new InvalidOperationException("Attempt to process too many blocks");
		}
		blocksRemaining--;
		uint c = 1u;
		c += counter[15];
		counter[15] = (byte)c;
		c >>= 8;
		c += counter[14];
		counter[14] = (byte)c;
		c >>= 8;
		c += counter[13];
		counter[13] = (byte)c;
		c >>= 8;
		c += counter[12];
		counter[12] = (byte)c;
		cipher.ProcessBlock(counter, 0, block, 0);
	}

	private void CheckStatus()
	{
		if (!initialised)
		{
			if (forEncryption)
			{
				throw new InvalidOperationException("GCM cipher cannot be reused for encryption");
			}
			throw new InvalidOperationException("GCM cipher needs to be initialised");
		}
	}
}
