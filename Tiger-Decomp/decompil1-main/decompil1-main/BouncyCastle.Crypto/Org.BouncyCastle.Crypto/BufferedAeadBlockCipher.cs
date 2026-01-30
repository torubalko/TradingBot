using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto;

public class BufferedAeadBlockCipher : BufferedCipherBase
{
	private readonly IAeadBlockCipher cipher;

	public override string AlgorithmName => cipher.AlgorithmName;

	public BufferedAeadBlockCipher(IAeadBlockCipher cipher)
	{
		if (cipher == null)
		{
			throw new ArgumentNullException("cipher");
		}
		this.cipher = cipher;
	}

	public override void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (parameters is ParametersWithRandom)
		{
			parameters = ((ParametersWithRandom)parameters).Parameters;
		}
		cipher.Init(forEncryption, parameters);
	}

	public override int GetBlockSize()
	{
		return cipher.GetBlockSize();
	}

	public override int GetUpdateOutputSize(int length)
	{
		return cipher.GetUpdateOutputSize(length);
	}

	public override int GetOutputSize(int length)
	{
		return cipher.GetOutputSize(length);
	}

	public override int ProcessByte(byte input, byte[] output, int outOff)
	{
		return cipher.ProcessByte(input, output, outOff);
	}

	public override byte[] ProcessByte(byte input)
	{
		int outLength = GetUpdateOutputSize(1);
		byte[] outBytes = ((outLength > 0) ? new byte[outLength] : null);
		int pos = ProcessByte(input, outBytes, 0);
		if (outLength > 0 && pos < outLength)
		{
			byte[] tmp = new byte[pos];
			Array.Copy(outBytes, 0, tmp, 0, pos);
			outBytes = tmp;
		}
		return outBytes;
	}

	public override byte[] ProcessBytes(byte[] input, int inOff, int length)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (length < 1)
		{
			return null;
		}
		int outLength = GetUpdateOutputSize(length);
		byte[] outBytes = ((outLength > 0) ? new byte[outLength] : null);
		int pos = ProcessBytes(input, inOff, length, outBytes, 0);
		if (outLength > 0 && pos < outLength)
		{
			byte[] tmp = new byte[pos];
			Array.Copy(outBytes, 0, tmp, 0, pos);
			outBytes = tmp;
		}
		return outBytes;
	}

	public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
		return cipher.ProcessBytes(input, inOff, length, output, outOff);
	}

	public override byte[] DoFinal()
	{
		byte[] outBytes = new byte[GetOutputSize(0)];
		int pos = DoFinal(outBytes, 0);
		if (pos < outBytes.Length)
		{
			byte[] tmp = new byte[pos];
			Array.Copy(outBytes, 0, tmp, 0, pos);
			outBytes = tmp;
		}
		return outBytes;
	}

	public override byte[] DoFinal(byte[] input, int inOff, int inLen)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		byte[] outBytes = new byte[GetOutputSize(inLen)];
		int pos = ((inLen > 0) ? ProcessBytes(input, inOff, inLen, outBytes, 0) : 0);
		pos += DoFinal(outBytes, pos);
		if (pos < outBytes.Length)
		{
			byte[] tmp = new byte[pos];
			Array.Copy(outBytes, 0, tmp, 0, pos);
			outBytes = tmp;
		}
		return outBytes;
	}

	public override int DoFinal(byte[] output, int outOff)
	{
		return cipher.DoFinal(output, outOff);
	}

	public override void Reset()
	{
		cipher.Reset();
	}
}
