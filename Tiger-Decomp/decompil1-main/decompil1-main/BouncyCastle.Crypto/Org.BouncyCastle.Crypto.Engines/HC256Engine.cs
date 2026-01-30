using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class HC256Engine : IStreamCipher
{
	private uint[] p = new uint[1024];

	private uint[] q = new uint[1024];

	private uint cnt;

	private byte[] key;

	private byte[] iv;

	private bool initialised;

	private byte[] buf = new byte[4];

	private int idx;

	public virtual string AlgorithmName => "HC-256";

	private uint Step()
	{
		uint j = cnt & 0x3FF;
		uint ret;
		if (cnt < 1024)
		{
			uint x = p[(j - 3) & 0x3FF];
			uint y = p[(j - 1023) & 0x3FF];
			p[j] += p[(j - 10) & 0x3FF] + (RotateRight(x, 10) ^ RotateRight(y, 23)) + q[(x ^ y) & 0x3FF];
			x = p[(j - 12) & 0x3FF];
			ret = (q[x & 0xFF] + q[((x >> 8) & 0xFF) + 256] + q[((x >> 16) & 0xFF) + 512] + q[((x >> 24) & 0xFF) + 768]) ^ p[j];
		}
		else
		{
			uint x2 = q[(j - 3) & 0x3FF];
			uint y2 = q[(j - 1023) & 0x3FF];
			q[j] += q[(j - 10) & 0x3FF] + (RotateRight(x2, 10) ^ RotateRight(y2, 23)) + p[(x2 ^ y2) & 0x3FF];
			x2 = q[(j - 12) & 0x3FF];
			ret = (p[x2 & 0xFF] + p[((x2 >> 8) & 0xFF) + 256] + p[((x2 >> 16) & 0xFF) + 512] + p[((x2 >> 24) & 0xFF) + 768]) ^ q[j];
		}
		cnt = (cnt + 1) & 0x7FF;
		return ret;
	}

	private void Init()
	{
		if (key.Length != 32 && key.Length != 16)
		{
			throw new ArgumentException("The key must be 128/256 bits long");
		}
		if (iv.Length < 16)
		{
			throw new ArgumentException("The IV must be at least 128 bits long");
		}
		if (key.Length != 32)
		{
			byte[] k = new byte[32];
			Array.Copy(key, 0, k, 0, key.Length);
			Array.Copy(key, 0, k, 16, key.Length);
			key = k;
		}
		if (iv.Length < 32)
		{
			byte[] newIV = new byte[32];
			Array.Copy(iv, 0, newIV, 0, iv.Length);
			Array.Copy(iv, 0, newIV, iv.Length, newIV.Length - iv.Length);
			iv = newIV;
		}
		idx = 0;
		cnt = 0u;
		uint[] w = new uint[2560];
		for (int i = 0; i < 32; i++)
		{
			w[i >> 2] |= (uint)(key[i] << 8 * (i & 3));
		}
		for (int j = 0; j < 32; j++)
		{
			w[(j >> 2) + 8] |= (uint)(iv[j] << 8 * (j & 3));
		}
		for (uint i2 = 16u; i2 < 2560; i2++)
		{
			uint x = w[i2 - 2];
			uint y = w[i2 - 15];
			w[i2] = (RotateRight(x, 17) ^ RotateRight(x, 19) ^ (x >> 10)) + w[i2 - 7] + (RotateRight(y, 7) ^ RotateRight(y, 18) ^ (y >> 3)) + w[i2 - 16] + i2;
		}
		Array.Copy(w, 512, p, 0, 1024);
		Array.Copy(w, 1536, q, 0, 1024);
		for (int l = 0; l < 4096; l++)
		{
			Step();
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
		throw new ArgumentException("Invalid parameter passed to HC256 init - " + Platform.GetTypeName(parameters), "parameters");
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

	private static uint RotateRight(uint x, int bits)
	{
		return (x >> bits) | (x << -bits);
	}
}
