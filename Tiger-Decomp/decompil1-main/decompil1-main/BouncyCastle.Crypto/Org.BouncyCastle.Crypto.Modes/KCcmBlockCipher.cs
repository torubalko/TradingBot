using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes;

public class KCcmBlockCipher : IAeadBlockCipher, IAeadCipher
{
	private static readonly int BYTES_IN_INT = 4;

	private static readonly int BITS_IN_BYTE = 8;

	private static readonly int MAX_MAC_BIT_LENGTH = 512;

	private static readonly int MIN_MAC_BIT_LENGTH = 64;

	private IBlockCipher engine;

	private int macSize;

	private bool forEncryption;

	private byte[] initialAssociatedText;

	private byte[] mac;

	private byte[] macBlock;

	private byte[] nonce;

	private byte[] G1;

	private byte[] buffer;

	private byte[] s;

	private byte[] counter;

	private readonly MemoryStream associatedText = new MemoryStream();

	private readonly MemoryStream data = new MemoryStream();

	private int Nb_ = 4;

	public virtual string AlgorithmName => engine.AlgorithmName + "/KCCM";

	private void setNb(int Nb)
	{
		if (Nb == 4 || Nb == 6 || Nb == 8)
		{
			Nb_ = Nb;
			return;
		}
		throw new ArgumentException("Nb = 4 is recommended by DSTU7624 but can be changed to only 6 or 8 in this implementation");
	}

	public KCcmBlockCipher(IBlockCipher engine)
		: this(engine, 4)
	{
	}

	public KCcmBlockCipher(IBlockCipher engine, int Nb)
	{
		this.engine = engine;
		macSize = engine.GetBlockSize();
		nonce = new byte[engine.GetBlockSize()];
		initialAssociatedText = new byte[engine.GetBlockSize()];
		mac = new byte[engine.GetBlockSize()];
		macBlock = new byte[engine.GetBlockSize()];
		G1 = new byte[engine.GetBlockSize()];
		buffer = new byte[engine.GetBlockSize()];
		s = new byte[engine.GetBlockSize()];
		counter = new byte[engine.GetBlockSize()];
		setNb(Nb);
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		ICipherParameters cipherParameters;
		if (parameters is AeadParameters)
		{
			AeadParameters param = (AeadParameters)parameters;
			if (param.MacSize > MAX_MAC_BIT_LENGTH || param.MacSize < MIN_MAC_BIT_LENGTH || param.MacSize % 8 != 0)
			{
				throw new ArgumentException("Invalid mac size specified");
			}
			nonce = param.GetNonce();
			macSize = param.MacSize / BITS_IN_BYTE;
			initialAssociatedText = param.GetAssociatedText();
			cipherParameters = param.Key;
		}
		else
		{
			if (!(parameters is ParametersWithIV))
			{
				throw new ArgumentException("Invalid parameters specified");
			}
			nonce = ((ParametersWithIV)parameters).GetIV();
			macSize = engine.GetBlockSize();
			initialAssociatedText = null;
			cipherParameters = ((ParametersWithIV)parameters).Parameters;
		}
		mac = new byte[macSize];
		this.forEncryption = forEncryption;
		engine.Init(forEncryption: true, cipherParameters);
		counter[0] = 1;
		if (initialAssociatedText != null)
		{
			ProcessAadBytes(initialAssociatedText, 0, initialAssociatedText.Length);
		}
	}

	public virtual int GetBlockSize()
	{
		return engine.GetBlockSize();
	}

	public virtual IBlockCipher GetUnderlyingCipher()
	{
		return engine;
	}

	public virtual void ProcessAadByte(byte input)
	{
		associatedText.WriteByte(input);
	}

	public virtual void ProcessAadBytes(byte[] input, int inOff, int len)
	{
		associatedText.Write(input, inOff, len);
	}

	private void ProcessAAD(byte[] assocText, int assocOff, int assocLen, int dataLen)
	{
		if (assocLen - assocOff < engine.GetBlockSize())
		{
			throw new ArgumentException("authText buffer too short");
		}
		if (assocLen % engine.GetBlockSize() != 0)
		{
			throw new ArgumentException("padding not supported");
		}
		Array.Copy(nonce, 0, G1, 0, nonce.Length - Nb_ - 1);
		intToBytes(dataLen, buffer, 0);
		Array.Copy(buffer, 0, G1, nonce.Length - Nb_ - 1, BYTES_IN_INT);
		G1[G1.Length - 1] = getFlag(authTextPresents: true, macSize);
		engine.ProcessBlock(G1, 0, macBlock, 0);
		intToBytes(assocLen, buffer, 0);
		if (assocLen <= engine.GetBlockSize() - Nb_)
		{
			for (int byteIndex = 0; byteIndex < assocLen; byteIndex++)
			{
				buffer[byteIndex + Nb_] ^= assocText[assocOff + byteIndex];
			}
			for (int i = 0; i < engine.GetBlockSize(); i++)
			{
				macBlock[i] ^= buffer[i];
			}
			engine.ProcessBlock(macBlock, 0, macBlock, 0);
			return;
		}
		for (int j = 0; j < engine.GetBlockSize(); j++)
		{
			macBlock[j] ^= buffer[j];
		}
		engine.ProcessBlock(macBlock, 0, macBlock, 0);
		for (int authLen = assocLen; authLen != 0; authLen -= engine.GetBlockSize())
		{
			for (int k = 0; k < engine.GetBlockSize(); k++)
			{
				macBlock[k] ^= assocText[k + assocOff];
			}
			engine.ProcessBlock(macBlock, 0, macBlock, 0);
			assocOff += engine.GetBlockSize();
		}
	}

	public virtual int ProcessByte(byte input, byte[] output, int outOff)
	{
		data.WriteByte(input);
		return 0;
	}

	public virtual int ProcessBytes(byte[] input, int inOff, int inLen, byte[] output, int outOff)
	{
		Check.DataLength(input, inOff, inLen, "input buffer too short");
		data.Write(input, inOff, inLen);
		return 0;
	}

	public int ProcessPacket(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		Check.DataLength(input, inOff, len, "input buffer too short");
		Check.OutputLength(output, outOff, len, "output buffer too short");
		if (associatedText.Length > 0)
		{
			byte[] aad = associatedText.GetBuffer();
			int aadLen = (int)associatedText.Length;
			int dataLen = (int)(forEncryption ? data.Length : ((int)data.Length - macSize));
			ProcessAAD(aad, 0, aadLen, dataLen);
		}
		if (forEncryption)
		{
			Check.DataLength(len % engine.GetBlockSize() != 0, "partial blocks not supported");
			CalculateMac(input, inOff, len);
			engine.ProcessBlock(nonce, 0, s, 0);
			int totalLength = len;
			while (totalLength > 0)
			{
				ProcessBlock(input, inOff, len, output, outOff);
				totalLength -= engine.GetBlockSize();
				inOff += engine.GetBlockSize();
				outOff += engine.GetBlockSize();
			}
			for (int byteIndex = 0; byteIndex < counter.Length; byteIndex++)
			{
				s[byteIndex] += counter[byteIndex];
			}
			engine.ProcessBlock(s, 0, buffer, 0);
			for (int i = 0; i < macSize; i++)
			{
				output[outOff + i] = (byte)(buffer[i] ^ macBlock[i]);
			}
			Array.Copy(macBlock, 0, mac, 0, macSize);
			Reset();
			return len + macSize;
		}
		Check.DataLength((len - macSize) % engine.GetBlockSize() != 0, "partial blocks not supported");
		engine.ProcessBlock(nonce, 0, s, 0);
		int blocks = len / engine.GetBlockSize();
		for (int blockNum = 0; blockNum < blocks; blockNum++)
		{
			ProcessBlock(input, inOff, len, output, outOff);
			inOff += engine.GetBlockSize();
			outOff += engine.GetBlockSize();
		}
		if (len > inOff)
		{
			for (int j = 0; j < counter.Length; j++)
			{
				s[j] += counter[j];
			}
			engine.ProcessBlock(s, 0, buffer, 0);
			for (int k = 0; k < macSize; k++)
			{
				output[outOff + k] = (byte)(buffer[k] ^ input[inOff + k]);
			}
			outOff += macSize;
		}
		for (int l = 0; l < counter.Length; l++)
		{
			s[l] += counter[l];
		}
		engine.ProcessBlock(s, 0, buffer, 0);
		Array.Copy(output, outOff - macSize, buffer, 0, macSize);
		CalculateMac(output, 0, outOff - macSize);
		Array.Copy(macBlock, 0, mac, 0, macSize);
		byte[] calculatedMac = new byte[macSize];
		Array.Copy(buffer, 0, calculatedMac, 0, macSize);
		if (!Arrays.ConstantTimeAreEqual(mac, calculatedMac))
		{
			throw new InvalidCipherTextException("mac check failed");
		}
		Reset();
		return len - macSize;
	}

	private void ProcessBlock(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		for (int byteIndex = 0; byteIndex < counter.Length; byteIndex++)
		{
			s[byteIndex] += counter[byteIndex];
		}
		engine.ProcessBlock(s, 0, buffer, 0);
		for (int i = 0; i < engine.GetBlockSize(); i++)
		{
			output[outOff + i] = (byte)(buffer[i] ^ input[inOff + i]);
		}
	}

	private void CalculateMac(byte[] authText, int authOff, int len)
	{
		int totalLen = len;
		while (totalLen > 0)
		{
			for (int byteIndex = 0; byteIndex < engine.GetBlockSize(); byteIndex++)
			{
				macBlock[byteIndex] ^= authText[authOff + byteIndex];
			}
			engine.ProcessBlock(macBlock, 0, macBlock, 0);
			totalLen -= engine.GetBlockSize();
			authOff += engine.GetBlockSize();
		}
	}

	public virtual int DoFinal(byte[] output, int outOff)
	{
		byte[] buf = data.GetBuffer();
		int bufLen = (int)data.Length;
		int result = ProcessPacket(buf, 0, bufLen, output, outOff);
		Reset();
		return result;
	}

	public virtual byte[] GetMac()
	{
		return Arrays.Clone(mac);
	}

	public virtual int GetUpdateOutputSize(int len)
	{
		return len;
	}

	public virtual int GetOutputSize(int len)
	{
		return len + macSize;
	}

	public virtual void Reset()
	{
		Arrays.Fill(G1, 0);
		Arrays.Fill(buffer, 0);
		Arrays.Fill(counter, 0);
		Arrays.Fill(macBlock, 0);
		counter[0] = 1;
		data.SetLength(0L);
		associatedText.SetLength(0L);
		if (initialAssociatedText != null)
		{
			ProcessAadBytes(initialAssociatedText, 0, initialAssociatedText.Length);
		}
	}

	private void intToBytes(int num, byte[] outBytes, int outOff)
	{
		outBytes[outOff + 3] = (byte)(num >> 24);
		outBytes[outOff + 2] = (byte)(num >> 16);
		outBytes[outOff + 1] = (byte)(num >> 8);
		outBytes[outOff] = (byte)num;
	}

	private byte getFlag(bool authTextPresents, int macSize)
	{
		StringBuilder flagByte = new StringBuilder();
		if (authTextPresents)
		{
			flagByte.Append("1");
		}
		else
		{
			flagByte.Append("0");
		}
		switch (macSize)
		{
		case 8:
			flagByte.Append("010");
			break;
		case 16:
			flagByte.Append("011");
			break;
		case 32:
			flagByte.Append("100");
			break;
		case 48:
			flagByte.Append("101");
			break;
		case 64:
			flagByte.Append("110");
			break;
		}
		string binaryNb = Convert.ToString(Nb_ - 1, 2);
		while (binaryNb.Length < 4)
		{
			binaryNb = new StringBuilder(binaryNb).Insert(0, "0").ToString();
		}
		flagByte.Append(binaryNb);
		return (byte)Convert.ToInt32(flagByte.ToString(), 2);
	}
}
