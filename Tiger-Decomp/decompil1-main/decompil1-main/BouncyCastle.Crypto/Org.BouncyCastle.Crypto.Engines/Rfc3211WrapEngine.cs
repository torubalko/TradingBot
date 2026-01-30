using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines;

public class Rfc3211WrapEngine : IWrapper
{
	private CbcBlockCipher engine;

	private ParametersWithIV param;

	private bool forWrapping;

	private SecureRandom rand;

	public virtual string AlgorithmName => engine.GetUnderlyingCipher().AlgorithmName + "/RFC3211Wrap";

	public Rfc3211WrapEngine(IBlockCipher engine)
	{
		this.engine = new CbcBlockCipher(engine);
	}

	public virtual void Init(bool forWrapping, ICipherParameters param)
	{
		this.forWrapping = forWrapping;
		if (param is ParametersWithRandom)
		{
			ParametersWithRandom p = (ParametersWithRandom)param;
			rand = p.Random;
			this.param = p.Parameters as ParametersWithIV;
		}
		else
		{
			if (forWrapping)
			{
				rand = new SecureRandom();
			}
			this.param = param as ParametersWithIV;
		}
		if (this.param == null)
		{
			throw new ArgumentException("RFC3211Wrap requires an IV", "param");
		}
	}

	public virtual byte[] Wrap(byte[] inBytes, int inOff, int inLen)
	{
		if (!forWrapping)
		{
			throw new InvalidOperationException("not set for wrapping");
		}
		if (inLen > 255 || inLen < 0)
		{
			throw new ArgumentException("input must be from 0 to 255 bytes", "inLen");
		}
		engine.Init(forEncryption: true, param);
		int blockSize = engine.GetBlockSize();
		byte[] cekBlock = ((inLen + 4 >= blockSize * 2) ? new byte[((inLen + 4) % blockSize == 0) ? (inLen + 4) : (((inLen + 4) / blockSize + 1) * blockSize)] : new byte[blockSize * 2]);
		cekBlock[0] = (byte)inLen;
		Array.Copy(inBytes, inOff, cekBlock, 4, inLen);
		rand.NextBytes(cekBlock, inLen + 4, cekBlock.Length - inLen - 4);
		cekBlock[1] = (byte)(~cekBlock[4]);
		cekBlock[2] = (byte)(~cekBlock[5]);
		cekBlock[3] = (byte)(~cekBlock[6]);
		for (int i = 0; i < cekBlock.Length; i += blockSize)
		{
			engine.ProcessBlock(cekBlock, i, cekBlock, i);
		}
		for (int j = 0; j < cekBlock.Length; j += blockSize)
		{
			engine.ProcessBlock(cekBlock, j, cekBlock, j);
		}
		return cekBlock;
	}

	public virtual byte[] Unwrap(byte[] inBytes, int inOff, int inLen)
	{
		if (forWrapping)
		{
			throw new InvalidOperationException("not set for unwrapping");
		}
		int blockSize = engine.GetBlockSize();
		if (inLen < 2 * blockSize)
		{
			throw new InvalidCipherTextException("input too short");
		}
		byte[] cekBlock = new byte[inLen];
		byte[] iv = new byte[blockSize];
		Array.Copy(inBytes, inOff, cekBlock, 0, inLen);
		Array.Copy(inBytes, inOff, iv, 0, iv.Length);
		engine.Init(forEncryption: false, new ParametersWithIV(param.Parameters, iv));
		for (int i = blockSize; i < cekBlock.Length; i += blockSize)
		{
			engine.ProcessBlock(cekBlock, i, cekBlock, i);
		}
		Array.Copy(cekBlock, cekBlock.Length - iv.Length, iv, 0, iv.Length);
		engine.Init(forEncryption: false, new ParametersWithIV(param.Parameters, iv));
		engine.ProcessBlock(cekBlock, 0, cekBlock, 0);
		engine.Init(forEncryption: false, param);
		for (int j = 0; j < cekBlock.Length; j += blockSize)
		{
			engine.ProcessBlock(cekBlock, j, cekBlock, j);
		}
		bool invalidLength = cekBlock[0] > cekBlock.Length - 4;
		byte[] key = ((!invalidLength) ? new byte[cekBlock[0]] : new byte[cekBlock.Length - 4]);
		Array.Copy(cekBlock, 4, key, 0, key.Length);
		int nonEqual = 0;
		for (int k = 0; k != 3; k++)
		{
			byte check = (byte)(~cekBlock[1 + k]);
			nonEqual |= check ^ cekBlock[4 + k];
		}
		Array.Clear(cekBlock, 0, cekBlock.Length);
		if (nonEqual != 0 || invalidLength)
		{
			throw new InvalidCipherTextException("wrapped key corrupted");
		}
		return key;
	}
}
