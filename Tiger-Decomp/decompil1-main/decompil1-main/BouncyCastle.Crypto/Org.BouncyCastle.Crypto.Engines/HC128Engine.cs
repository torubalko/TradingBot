using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class HC128Engine : IStreamCipher
{
	private uint[] p = new uint[512];

	private uint[] q = new uint[512];

	private uint cnt;

	private byte[] key;

	private byte[] iv;

	private bool initialised;

	private byte[] buf = new byte[4];

	private int idx;

	public virtual string AlgorithmName => "HC-128";

	private static uint F1(uint x)
	{
		return RotateRight(x, 7) ^ RotateRight(x, 18) ^ (x >> 3);
	}

	private static uint F2(uint x)
	{
		return RotateRight(x, 17) ^ RotateRight(x, 19) ^ (x >> 10);
	}

	private uint G1(uint x, uint y, uint z)
	{
		return (RotateRight(x, 10) ^ RotateRight(z, 23)) + RotateRight(y, 8);
	}

	private uint G2(uint x, uint y, uint z)
	{
		return (RotateLeft(x, 10) ^ RotateLeft(z, 23)) + RotateLeft(y, 8);
	}

	private static uint RotateLeft(uint x, int bits)
	{
		return (x << bits) | (x >> -bits);
	}

	private static uint RotateRight(uint x, int bits)
	{
		return (x >> bits) | (x << -bits);
	}

	private uint H1(uint x)
	{
		return q[x & 0xFF] + q[((x >> 16) & 0xFF) + 256];
	}

	private uint H2(uint x)
	{
		return p[x & 0xFF] + p[((x >> 16) & 0xFF) + 256];
	}

	private static uint Mod1024(uint x)
	{
		return x & 0x3FF;
	}

	private static uint Mod512(uint x)
	{
		return x & 0x1FF;
	}

	private static uint Dim(uint x, uint y)
	{
		return Mod512(x - y);
	}

	private uint Step()
	{
		uint j = Mod512(cnt);
		uint ret;
		if (cnt < 512)
		{
			p[j] += G1(p[Dim(j, 3u)], p[Dim(j, 10u)], p[Dim(j, 511u)]);
			ret = H1(p[Dim(j, 12u)]) ^ p[j];
		}
		else
		{
			q[j] += G2(q[Dim(j, 3u)], q[Dim(j, 10u)], q[Dim(j, 511u)]);
			ret = H2(q[Dim(j, 12u)]) ^ q[j];
		}
		cnt = Mod1024(cnt + 1);
		return ret;
	}

	private void Init()
	{
		if (key.Length != 16)
		{
			throw new ArgumentException("The key must be 128 bits long");
		}
		idx = 0;
		cnt = 0u;
		uint[] w = new uint[1280];
		for (int i = 0; i < 16; i++)
		{
			w[i >> 2] |= (uint)(key[i] << 8 * (i & 3));
		}
		Array.Copy(w, 0, w, 4, 4);
		for (int j = 0; j < iv.Length && j < 16; j++)
		{
			w[(j >> 2) + 8] |= (uint)(iv[j] << 8 * (j & 3));
		}
		Array.Copy(w, 8, w, 12, 4);
		for (uint i2 = 16u; i2 < 1280; i2++)
		{
			w[i2] = F2(w[i2 - 2]) + w[i2 - 7] + F1(w[i2 - 15]) + w[i2 - 16] + i2;
		}
		Array.Copy(w, 256, p, 0, 512);
		Array.Copy(w, 768, q, 0, 512);
		for (int k = 0; k < 512; k++)
		{
			p[k] = Step();
		}
		for (int l = 0; l < 512; l++)
		{
			q[l] = Step();
		}
		cnt = 0u;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		ICipherParameters keyParam = parameters;
		if (parameters is ParametersWithIV)
		{
			iv = ((ParametersWithIV)parameters).GetIV();
			keyParam = ((ParametersWithIV)parameters).Parameters;
		}
		else
		{
			iv = new byte[0];
		}
		if (keyParam is KeyParameter)
		{
			key = ((KeyParameter)keyParam).GetKey();
			Init();
			initialised = true;
			return;
		}
		throw new ArgumentException("Invalid parameter passed to HC128 init - " + Platform.GetTypeName(parameters), "parameters");
	}

	private byte GetByte()
	{
		if (idx == 0)
		{
			Pack.UInt32_To_LE(Step(), buf);
		}
		byte result = buf[idx];
		idx = (idx + 1) & 3;
		return result;
	}

	public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
	{
		if (!initialised)
		{
			throw new InvalidOperationException(AlgorithmName + " not initialised");
		}
		Check.DataLength(input, inOff, len, "input buffer too short");
		Check.OutputLength(output, outOff, len, "output buffer too short");
		for (int i = 0; i < len; i++)
		{
			output[outOff + i] = (byte)(input[inOff + i] ^ GetByte());
		}
	}

	public virtual void Reset()
	{
		Init();
	}

	public virtual byte ReturnByte(byte input)
	{
		return (byte)(input ^ GetByte());
	}
}
