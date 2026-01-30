using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs;

public class VmpcMac : IMac
{
	private byte g;

	private byte n;

	private byte[] P;

	private byte s;

	private byte[] T;

	private byte[] workingIV;

	private byte[] workingKey;

	private byte x1;

	private byte x2;

	private byte x3;

	private byte x4;

	public virtual string AlgorithmName => "VMPC-MAC";

	public virtual int DoFinal(byte[] output, int outOff)
	{
		for (int r = 1; r < 25; r++)
		{
			s = P[(s + P[n & 0xFF]) & 0xFF];
			x4 = P[(x4 + x3 + r) & 0xFF];
			x3 = P[(x3 + x2 + r) & 0xFF];
			x2 = P[(x2 + x1 + r) & 0xFF];
			x1 = P[(x1 + s + r) & 0xFF];
			T[g & 0x1F] = (byte)(T[g & 0x1F] ^ x1);
			T[(g + 1) & 0x1F] = (byte)(T[(g + 1) & 0x1F] ^ x2);
			T[(g + 2) & 0x1F] = (byte)(T[(g + 2) & 0x1F] ^ x3);
			T[(g + 3) & 0x1F] = (byte)(T[(g + 3) & 0x1F] ^ x4);
			g = (byte)((g + 4) & 0x1F);
			byte temp = P[n & 0xFF];
			P[n & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp;
			n = (byte)((n + 1) & 0xFF);
		}
		for (int m = 0; m < 768; m++)
		{
			s = P[(s + P[m & 0xFF] + T[m & 0x1F]) & 0xFF];
			byte temp2 = P[m & 0xFF];
			P[m & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp2;
		}
		byte[] M = new byte[20];
		for (int i = 0; i < 20; i++)
		{
			s = P[(s + P[i & 0xFF]) & 0xFF];
			M[i] = P[(P[P[s & 0xFF] & 0xFF] + 1) & 0xFF];
			byte temp3 = P[i & 0xFF];
			P[i & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp3;
		}
		Array.Copy(M, 0, output, outOff, M.Length);
		Reset();
		return M.Length;
	}

	public virtual int GetMacSize()
	{
		return 20;
	}

	public virtual void Init(ICipherParameters parameters)
	{
		if (!(parameters is ParametersWithIV))
		{
			throw new ArgumentException("VMPC-MAC Init parameters must include an IV", "parameters");
		}
		ParametersWithIV ivParams = (ParametersWithIV)parameters;
		KeyParameter key = (KeyParameter)ivParams.Parameters;
		if (!(ivParams.Parameters is KeyParameter))
		{
			throw new ArgumentException("VMPC-MAC Init parameters must include a key", "parameters");
		}
		workingIV = ivParams.GetIV();
		if (workingIV == null || workingIV.Length < 1 || workingIV.Length > 768)
		{
			throw new ArgumentException("VMPC-MAC requires 1 to 768 bytes of IV", "parameters");
		}
		workingKey = key.GetKey();
		Reset();
	}

	private void initKey(byte[] keyBytes, byte[] ivBytes)
	{
		s = 0;
		P = new byte[256];
		for (int i = 0; i < 256; i++)
		{
			P[i] = (byte)i;
		}
		for (int m = 0; m < 768; m++)
		{
			s = P[(s + P[m & 0xFF] + keyBytes[m % keyBytes.Length]) & 0xFF];
			byte temp = P[m & 0xFF];
			P[m & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp;
		}
		for (int j = 0; j < 768; j++)
		{
			s = P[(s + P[j & 0xFF] + ivBytes[j % ivBytes.Length]) & 0xFF];
			byte temp2 = P[j & 0xFF];
			P[j & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp2;
		}
		n = 0;
	}

	public virtual void Reset()
	{
		initKey(workingKey, workingIV);
		g = (x1 = (x2 = (x3 = (x4 = (n = 0)))));
		T = new byte[32];
		for (int i = 0; i < 32; i++)
		{
			T[i] = 0;
		}
	}

	public virtual void Update(byte input)
	{
		s = P[(s + P[n & 0xFF]) & 0xFF];
		byte c = (byte)(input ^ P[(P[P[s & 0xFF] & 0xFF] + 1) & 0xFF]);
		x4 = P[(x4 + x3) & 0xFF];
		x3 = P[(x3 + x2) & 0xFF];
		x2 = P[(x2 + x1) & 0xFF];
		x1 = P[(x1 + s + c) & 0xFF];
		T[g & 0x1F] = (byte)(T[g & 0x1F] ^ x1);
		T[(g + 1) & 0x1F] = (byte)(T[(g + 1) & 0x1F] ^ x2);
		T[(g + 2) & 0x1F] = (byte)(T[(g + 2) & 0x1F] ^ x3);
		T[(g + 3) & 0x1F] = (byte)(T[(g + 3) & 0x1F] ^ x4);
		g = (byte)((g + 4) & 0x1F);
		byte temp = P[n & 0xFF];
		P[n & 0xFF] = P[s & 0xFF];
		P[s & 0xFF] = temp;
		n = (byte)((n + 1) & 0xFF);
	}

	public virtual void BlockUpdate(byte[] input, int inOff, int len)
	{
		if (inOff + len > input.Length)
		{
			throw new DataLengthException("input buffer too short");
		}
		for (int i = 0; i < len; i++)
		{
			Update(input[inOff + i]);
		}
	}
}
