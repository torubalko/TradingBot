using System;
using System.IO;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes;

public class CcmBlockCipher : IAeadBlockCipher, IAeadCipher
{
	private static readonly int BlockSize = 16;

	private readonly IBlockCipher cipher;

	private readonly byte[] macBlock;

	private bool forEncryption;

	private byte[] nonce;

	private byte[] initialAssociatedText;

	private int macSize;

	private ICipherParameters keyParam;

	private readonly MemoryStream associatedText = new MemoryStream();

	private readonly MemoryStream data = new MemoryStream();

	public virtual string AlgorithmName => cipher.AlgorithmName + "/CCM";

	public CcmBlockCipher(IBlockCipher cipher)
	{
		this.cipher = cipher;
		macBlock = new byte[BlockSize];
		if (cipher.GetBlockSize() != BlockSize)
		{
			throw new ArgumentException("cipher required with a block size of " + BlockSize + ".");
		}
	}

	public virtual IBlockCipher GetUnderlyingCipher()
	{
		return cipher;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		this.forEncryption = forEncryption;
		ICipherParameters cipherParameters;
		if (parameters is AeadParameters)
		{
			AeadParameters param = (AeadParameters)parameters;
			nonce = param.GetNonce();
			initialAssociatedText = param.GetAssociatedText();
			macSize = GetMacSize(forEncryption, param.MacSize);
			cipherParameters = param.Key;
		}
		else
		{
			if (!(parameters is ParametersWithIV))
			{
				throw new ArgumentException("invalid parameters passed to CCM");
			}
			ParametersWithIV param2 = (ParametersWithIV)parameters;
			nonce = param2.GetIV();
			initialAssociatedText = null;
			macSize = GetMacSize(forEncryption, 64);
			cipherParameters = param2.Parameters;
		}
		if (cipherParameters != null)
		{
			keyParam = cipherParameters;
		}
		if (nonce == null || nonce.Length < 7 || nonce.Length > 13)
		{
			throw new ArgumentException("nonce must have length from 7 to 13 octets");
		}
		Reset();
	}

	public virtual int GetBlockSize()
	{
		return cipher.GetBlockSize();
	}

	public virtual void ProcessAadByte(byte input)
	{
		associatedText.WriteByte(input);
	}

	public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
	{
		associatedText.Write(inBytes, inOff, len);
	}

	public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
	{
		data.WriteByte(input);
		return 0;
	}

	public virtual int ProcessBytes(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
	{
		Check.DataLength(inBytes, inOff, inLen, "Input buffer too short");
		data.Write(inBytes, inOff, inLen);
		return 0;
	}

	public virtual int DoFinal(byte[] outBytes, int outOff)
	{
		byte[] input = data.GetBuffer();
		int inLen = (int)data.Position;
		int result = ProcessPacket(input, 0, inLen, outBytes, outOff);
		Reset();
		return result;
	}

	public virtual void Reset()
	{
		cipher.Reset();
		associatedText.SetLength(0L);
		data.SetLength(0L);
	}

	public virtual byte[] GetMac()
	{
		return Arrays.CopyOfRange(macBlock, 0, macSize);
	}

	public virtual int GetUpdateOutputSize(int len)
	{
		return 0;
	}

	public virtual int GetOutputSize(int len)
	{
		int totalData = (int)data.Length + len;
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

	public virtual byte[] ProcessPacket(byte[] input, int inOff, int inLen)
	{
		byte[] output;
		if (forEncryption)
		{
			output = new byte[inLen + macSize];
		}
		else
		{
			if (inLen < macSize)
			{
				throw new InvalidCipherTextException("data too short");
			}
			output = new byte[inLen - macSize];
		}
		ProcessPacket(input, inOff, inLen, output, 0);
		return output;
	}

	public virtual int ProcessPacket(byte[] input, int inOff, int inLen, byte[] output, int outOff)
	{
		if (keyParam == null)
		{
			throw new InvalidOperationException("CCM cipher unitialized.");
		}
		int n = nonce.Length;
		int q = 15 - n;
		if (q < 4)
		{
			int limitLen = 1 << 8 * q;
			if (inLen >= limitLen)
			{
				throw new InvalidOperationException("CCM packet too large for choice of q.");
			}
		}
		byte[] iv = new byte[BlockSize];
		iv[0] = (byte)((q - 1) & 7);
		nonce.CopyTo(iv, 1);
		IBlockCipher ctrCipher = new SicBlockCipher(cipher);
		ctrCipher.Init(forEncryption, new ParametersWithIV(keyParam, iv));
		int inIndex = inOff;
		int outIndex = outOff;
		int outputLen;
		if (forEncryption)
		{
			outputLen = inLen + macSize;
			Check.OutputLength(output, outOff, outputLen, "Output buffer too short.");
			CalculateMac(input, inOff, inLen, macBlock);
			byte[] encMac = new byte[BlockSize];
			ctrCipher.ProcessBlock(macBlock, 0, encMac, 0);
			for (; inIndex < inOff + inLen - BlockSize; inIndex += BlockSize)
			{
				ctrCipher.ProcessBlock(input, inIndex, output, outIndex);
				outIndex += BlockSize;
			}
			byte[] block = new byte[BlockSize];
			Array.Copy(input, inIndex, block, 0, inLen + inOff - inIndex);
			ctrCipher.ProcessBlock(block, 0, block, 0);
			Array.Copy(block, 0, output, outIndex, inLen + inOff - inIndex);
			Array.Copy(encMac, 0, output, outOff + inLen, macSize);
		}
		else
		{
			if (inLen < macSize)
			{
				throw new InvalidCipherTextException("data too short");
			}
			outputLen = inLen - macSize;
			Check.OutputLength(output, outOff, outputLen, "Output buffer too short.");
			Array.Copy(input, inOff + outputLen, macBlock, 0, macSize);
			ctrCipher.ProcessBlock(macBlock, 0, macBlock, 0);
			for (int i = macSize; i != macBlock.Length; i++)
			{
				macBlock[i] = 0;
			}
			for (; inIndex < inOff + outputLen - BlockSize; inIndex += BlockSize)
			{
				ctrCipher.ProcessBlock(input, inIndex, output, outIndex);
				outIndex += BlockSize;
			}
			byte[] block2 = new byte[BlockSize];
			Array.Copy(input, inIndex, block2, 0, outputLen - (inIndex - inOff));
			ctrCipher.ProcessBlock(block2, 0, block2, 0);
			Array.Copy(block2, 0, output, outIndex, outputLen - (inIndex - inOff));
			byte[] calculatedMacBlock = new byte[BlockSize];
			CalculateMac(output, outOff, outputLen, calculatedMacBlock);
			if (!Arrays.ConstantTimeAreEqual(macBlock, calculatedMacBlock))
			{
				throw new InvalidCipherTextException("mac check in CCM failed");
			}
		}
		return outputLen;
	}

	private int CalculateMac(byte[] data, int dataOff, int dataLen, byte[] macBlock)
	{
		IMac cMac = new CbcBlockCipherMac(cipher, macSize * 8);
		cMac.Init(keyParam);
		byte[] b0 = new byte[16];
		if (HasAssociatedText())
		{
			b0[0] |= 64;
		}
		b0[0] |= (byte)((((cMac.GetMacSize() - 2) / 2) & 7) << 3);
		b0[0] |= (byte)((15 - nonce.Length - 1) & 7);
		Array.Copy(nonce, 0, b0, 1, nonce.Length);
		int q = dataLen;
		int count = 1;
		while (q > 0)
		{
			b0[b0.Length - count] = (byte)(q & 0xFF);
			q >>= 8;
			count++;
		}
		cMac.BlockUpdate(b0, 0, b0.Length);
		if (HasAssociatedText())
		{
			int textLength = GetAssociatedTextLength();
			int extra;
			if (textLength < 65280)
			{
				cMac.Update((byte)(textLength >> 8));
				cMac.Update((byte)textLength);
				extra = 2;
			}
			else
			{
				cMac.Update(byte.MaxValue);
				cMac.Update(254);
				cMac.Update((byte)(textLength >> 24));
				cMac.Update((byte)(textLength >> 16));
				cMac.Update((byte)(textLength >> 8));
				cMac.Update((byte)textLength);
				extra = 6;
			}
			if (initialAssociatedText != null)
			{
				cMac.BlockUpdate(initialAssociatedText, 0, initialAssociatedText.Length);
			}
			if (associatedText.Position > 0)
			{
				byte[] input = associatedText.GetBuffer();
				int len = (int)associatedText.Position;
				cMac.BlockUpdate(input, 0, len);
			}
			extra = (extra + textLength) % 16;
			if (extra != 0)
			{
				for (int i = extra; i < 16; i++)
				{
					cMac.Update(0);
				}
			}
		}
		cMac.BlockUpdate(data, dataOff, dataLen);
		return cMac.DoFinal(macBlock, 0);
	}

	private int GetMacSize(bool forEncryption, int requestedMacBits)
	{
		if (forEncryption && (requestedMacBits < 32 || requestedMacBits > 128 || (requestedMacBits & 0xF) != 0))
		{
			throw new ArgumentException("tag length in octets must be one of {4,6,8,10,12,14,16}");
		}
		return requestedMacBits >> 3;
	}

	private int GetAssociatedTextLength()
	{
		return (int)associatedText.Length + ((initialAssociatedText != null) ? initialAssociatedText.Length : 0);
	}

	private bool HasAssociatedText()
	{
		return GetAssociatedTextLength() > 0;
	}
}
