using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class Rfc3394WrapEngine : IWrapper
{
	private readonly IBlockCipher engine;

	private KeyParameter param;

	private bool forWrapping;

	private byte[] iv = new byte[8] { 166, 166, 166, 166, 166, 166, 166, 166 };

	public virtual string AlgorithmName => engine.AlgorithmName;

	public Rfc3394WrapEngine(IBlockCipher engine)
	{
		this.engine = engine;
	}

	public virtual void Init(bool forWrapping, ICipherParameters parameters)
	{
		this.forWrapping = forWrapping;
		if (parameters is ParametersWithRandom)
		{
			parameters = ((ParametersWithRandom)parameters).Parameters;
		}
		if (parameters is KeyParameter)
		{
			param = (KeyParameter)parameters;
		}
		else if (parameters is ParametersWithIV)
		{
			ParametersWithIV pIV = (ParametersWithIV)parameters;
			byte[] iv = pIV.GetIV();
			if (iv.Length != 8)
			{
				throw new ArgumentException("IV length not equal to 8", "parameters");
			}
			this.iv = iv;
			param = (KeyParameter)pIV.Parameters;
		}
	}

	public virtual byte[] Wrap(byte[] input, int inOff, int inLen)
	{
		if (!forWrapping)
		{
			throw new InvalidOperationException("not set for wrapping");
		}
		int n = inLen / 8;
		if (n * 8 != inLen)
		{
			throw new DataLengthException("wrap data must be a multiple of 8 bytes");
		}
		byte[] block = new byte[inLen + iv.Length];
		byte[] buf = new byte[8 + iv.Length];
		Array.Copy(iv, 0, block, 0, iv.Length);
		Array.Copy(input, inOff, block, iv.Length, inLen);
		engine.Init(forEncryption: true, param);
		for (int j = 0; j != 6; j++)
		{
			for (int i = 1; i <= n; i++)
			{
				Array.Copy(block, 0, buf, 0, iv.Length);
				Array.Copy(block, 8 * i, buf, iv.Length, 8);
				engine.ProcessBlock(buf, 0, buf, 0);
				int t = n * j + i;
				int k = 1;
				while (t != 0)
				{
					byte v = (byte)t;
					buf[iv.Length - k] ^= v;
					t >>>= 8;
					k++;
				}
				Array.Copy(buf, 0, block, 0, 8);
				Array.Copy(buf, 8, block, 8 * i, 8);
			}
		}
		return block;
	}

	public virtual byte[] Unwrap(byte[] input, int inOff, int inLen)
	{
		if (forWrapping)
		{
			throw new InvalidOperationException("not set for unwrapping");
		}
		int n = inLen / 8;
		if (n * 8 != inLen)
		{
			throw new InvalidCipherTextException("unwrap data must be a multiple of 8 bytes");
		}
		byte[] block = new byte[inLen - iv.Length];
		byte[] a = new byte[iv.Length];
		byte[] buf = new byte[8 + iv.Length];
		Array.Copy(input, inOff, a, 0, iv.Length);
		Array.Copy(input, inOff + iv.Length, block, 0, inLen - iv.Length);
		engine.Init(forEncryption: false, param);
		n--;
		for (int j = 5; j >= 0; j--)
		{
			for (int i = n; i >= 1; i--)
			{
				Array.Copy(a, 0, buf, 0, iv.Length);
				Array.Copy(block, 8 * (i - 1), buf, iv.Length, 8);
				int t = n * j + i;
				int k = 1;
				while (t != 0)
				{
					byte v = (byte)t;
					buf[iv.Length - k] ^= v;
					t >>>= 8;
					k++;
				}
				engine.ProcessBlock(buf, 0, buf, 0);
				Array.Copy(buf, 0, a, 0, 8);
				Array.Copy(buf, 8, block, 8 * (i - 1), 8);
			}
		}
		if (!Arrays.ConstantTimeAreEqual(a, iv))
		{
			throw new InvalidCipherTextException("checksum failed");
		}
		return block;
	}
}
