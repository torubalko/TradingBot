using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Engines;

public class VmpcEngine : IStreamCipher
{
	protected byte n;

	protected byte[] P;

	protected byte s;

	protected byte[] workingIV;

	protected byte[] workingKey;

	public virtual string AlgorithmName => "VMPC";

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is ParametersWithIV))
		{
			throw new ArgumentException("VMPC Init parameters must include an IV");
		}
		ParametersWithIV ivParams = (ParametersWithIV)parameters;
		if (!(ivParams.Parameters is KeyParameter))
		{
			throw new ArgumentException("VMPC Init parameters must include a key");
		}
		KeyParameter key = (KeyParameter)ivParams.Parameters;
		workingIV = ivParams.GetIV();
		if (workingIV == null || workingIV.Length < 1 || workingIV.Length > 768)
		{
			throw new ArgumentException("VMPC requires 1 to 768 bytes of IV");
		}
		workingKey = key.GetKey();
		InitKey(workingKey, workingIV);
	}

	protected virtual void InitKey(byte[] keyBytes, byte[] ivBytes)
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

	public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		Check.DataLength(input, inOff, len, "input buffer too short");
		Check.OutputLength(output, outOff, len, "output buffer too short");
		for (int i = 0; i < len; i++)
		{
			s = P[(s + P[n & 0xFF]) & 0xFF];
			byte z = P[(P[P[s & 0xFF] & 0xFF] + 1) & 0xFF];
			byte temp = P[n & 0xFF];
			P[n & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp;
			n = (byte)((n + 1) & 0xFF);
			output[i + outOff] = (byte)(input[i + inOff] ^ z);
		}
	}

	public virtual void Reset()
	{
		InitKey(workingKey, workingIV);
	}

	public virtual byte ReturnByte(byte input)
	{
		s = P[(s + P[n & 0xFF]) & 0xFF];
		byte z = P[(P[P[s & 0xFF] & 0xFF] + 1) & 0xFF];
		byte temp = P[n & 0xFF];
		P[n & 0xFF] = P[s & 0xFF];
		P[s & 0xFF] = temp;
		n = (byte)((n + 1) & 0xFF);
		return (byte)(input ^ z);
	}
}
