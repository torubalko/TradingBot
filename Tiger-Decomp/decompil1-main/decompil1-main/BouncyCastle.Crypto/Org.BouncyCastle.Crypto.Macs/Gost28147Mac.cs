using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Macs;

public class Gost28147Mac : IMac
{
	private const int blockSize = 8;

	private const int macSize = 4;

	private int bufOff;

	private byte[] buf;

	private byte[] mac;

	private bool firstStep = true;

	private int[] workingKey;

	private byte[] macIV;

	private byte[] S = new byte[128]
	{
		9, 6, 3, 2, 8, 11, 1, 7, 10, 4,
		14, 15, 12, 0, 13, 5, 3, 7, 14, 9,
		8, 10, 15, 0, 5, 2, 6, 12, 11, 4,
		13, 1, 14, 4, 6, 2, 11, 3, 13, 8,
		12, 15, 5, 10, 0, 7, 1, 9, 14, 7,
		10, 12, 13, 1, 3, 9, 0, 2, 11, 4,
		15, 8, 5, 6, 11, 5, 1, 9, 8, 13,
		15, 0, 14, 4, 2, 3, 12, 7, 10, 6,
		3, 10, 13, 12, 1, 2, 0, 11, 7, 5,
		9, 4, 8, 15, 14, 6, 1, 13, 2, 9,
		7, 10, 6, 0, 8, 12, 4, 5, 15, 3,
		11, 14, 11, 10, 15, 5, 0, 12, 14, 8,
		6, 2, 3, 9, 1, 7, 13, 4
	};

	public string AlgorithmName => "Gost28147Mac";

	public Gost28147Mac()
	{
		mac = new byte[8];
		buf = new byte[8];
		bufOff = 0;
	}

	private static int[] GenerateWorkingKey(byte[] userKey)
	{
		if (userKey.Length != 32)
		{
			throw new ArgumentException("Key length invalid. Key needs to be 32 byte - 256 bit!!!");
		}
		int[] key = new int[8];
		for (int i = 0; i != 8; i++)
		{
			key[i] = bytesToint(userKey, i * 4);
		}
		return key;
	}

	public void Init(ICipherParameters parameters)
	{
		Reset();
		buf = new byte[8];
		macIV = null;
		if (parameters is ParametersWithSBox)
		{
			ParametersWithSBox param = (ParametersWithSBox)parameters;
			param.GetSBox().CopyTo(S, 0);
			if (param.Parameters != null)
			{
				workingKey = GenerateWorkingKey(((KeyParameter)param.Parameters).GetKey());
			}
			return;
		}
		if (parameters is KeyParameter)
		{
			workingKey = GenerateWorkingKey(((KeyParameter)parameters).GetKey());
			return;
		}
		if (parameters is ParametersWithIV)
		{
			ParametersWithIV p = (ParametersWithIV)parameters;
			workingKey = GenerateWorkingKey(((KeyParameter)p.Parameters).GetKey());
			Array.Copy(p.GetIV(), 0, mac, 0, mac.Length);
			macIV = p.GetIV();
			return;
		}
		throw new ArgumentException("invalid parameter passed to Gost28147 init - " + Platform.GetTypeName(parameters));
	}

	public int GetMacSize()
	{
		return 4;
	}

	private int gost28147_mainStep(int n1, int key)
	{
		int cm = key + n1;
		int num = S[cm & 0xF] + (S[16 + ((cm >> 4) & 0xF)] << 4) + (S[32 + ((cm >> 8) & 0xF)] << 8) + (S[48 + ((cm >> 12) & 0xF)] << 12) + (S[64 + ((cm >> 16) & 0xF)] << 16) + (S[80 + ((cm >> 20) & 0xF)] << 20) + (S[96 + ((cm >> 24) & 0xF)] << 24) + (S[112 + ((cm >> 28) & 0xF)] << 28);
		int omLeft = num << 11;
		int omRight = num >>> 21;
		return omLeft | omRight;
	}

	private void gost28147MacFunc(int[] workingKey, byte[] input, int inOff, byte[] output, int outOff)
	{
		int N1 = bytesToint(input, inOff);
		int N2 = bytesToint(input, inOff + 4);
		for (int k = 0; k < 2; k++)
		{
			for (int j = 0; j < 8; j++)
			{
				int num = N1;
				N1 = N2 ^ gost28147_mainStep(N1, workingKey[j]);
				N2 = num;
			}
		}
		intTobytes(N1, output, outOff);
		intTobytes(N2, output, outOff + 4);
	}

	private static int bytesToint(byte[] input, int inOff)
	{
		return (int)((input[inOff + 3] << 24) & 0xFF000000u) + ((input[inOff + 2] << 16) & 0xFF0000) + ((input[inOff + 1] << 8) & 0xFF00) + (input[inOff] & 0xFF);
	}

	private static void intTobytes(int num, byte[] output, int outOff)
	{
		output[outOff + 3] = (byte)(num >> 24);
		output[outOff + 2] = (byte)(num >> 16);
		output[outOff + 1] = (byte)(num >> 8);
		output[outOff] = (byte)num;
	}

	private static byte[] CM5func(byte[] buf, int bufOff, byte[] mac)
	{
		byte[] sum = new byte[buf.Length - bufOff];
		Array.Copy(buf, bufOff, sum, 0, mac.Length);
		for (int i = 0; i != mac.Length; i++)
		{
			sum[i] ^= mac[i];
		}
		return sum;
	}

	public void Update(byte input)
	{
		if (bufOff == buf.Length)
		{
			byte[] sumbuf = new byte[buf.Length];
			Array.Copy(buf, 0, sumbuf, 0, mac.Length);
			if (firstStep)
			{
				firstStep = false;
				if (macIV != null)
				{
					sumbuf = CM5func(buf, 0, macIV);
				}
			}
			else
			{
				sumbuf = CM5func(buf, 0, mac);
			}
			gost28147MacFunc(workingKey, sumbuf, 0, mac, 0);
			bufOff = 0;
		}
		buf[bufOff++] = input;
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
		if (len < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
		}
		int gapLen = 8 - bufOff;
		if (len > gapLen)
		{
			Array.Copy(input, inOff, buf, bufOff, gapLen);
			byte[] sumbuf = new byte[buf.Length];
			Array.Copy(buf, 0, sumbuf, 0, mac.Length);
			if (firstStep)
			{
				firstStep = false;
				if (macIV != null)
				{
					sumbuf = CM5func(buf, 0, macIV);
				}
			}
			else
			{
				sumbuf = CM5func(buf, 0, mac);
			}
			gost28147MacFunc(workingKey, sumbuf, 0, mac, 0);
			bufOff = 0;
			len -= gapLen;
			inOff += gapLen;
			while (len > 8)
			{
				sumbuf = CM5func(input, inOff, mac);
				gost28147MacFunc(workingKey, sumbuf, 0, mac, 0);
				len -= 8;
				inOff += 8;
			}
		}
		Array.Copy(input, inOff, buf, bufOff, len);
		bufOff += len;
	}

	public int DoFinal(byte[] output, int outOff)
	{
		while (bufOff < 8)
		{
			buf[bufOff++] = 0;
		}
		byte[] sumbuf = new byte[buf.Length];
		Array.Copy(buf, 0, sumbuf, 0, mac.Length);
		if (firstStep)
		{
			firstStep = false;
		}
		else
		{
			sumbuf = CM5func(buf, 0, mac);
		}
		gost28147MacFunc(workingKey, sumbuf, 0, mac, 0);
		Array.Copy(mac, mac.Length / 2 - 4, output, outOff, 4);
		Reset();
		return 4;
	}

	public void Reset()
	{
		Array.Clear(buf, 0, buf.Length);
		bufOff = 0;
		firstStep = true;
	}
}
