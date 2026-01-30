using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class XteaEngine : IBlockCipher
{
	private const int rounds = 32;

	private const int block_size = 8;

	private const int delta = -1640531527;

	private uint[] _S = new uint[4];

	private uint[] _sum0 = new uint[32];

	private uint[] _sum1 = new uint[32];

	private bool _initialised;

	private bool _forEncryption;

	public virtual string AlgorithmName => "XTEA";

	public virtual bool IsPartialBlockOkay => false;

	public XteaEngine()
	{
		_initialised = false;
	}

	public virtual int GetBlockSize()
	{
		return 8;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("invalid parameter passed to TEA init - " + Platform.GetTypeName(parameters));
		}
		_forEncryption = forEncryption;
		_initialised = true;
		KeyParameter p = (KeyParameter)parameters;
		setKey(p.GetKey());
	}

	public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
		if (!_initialised)
		{
			throw new InvalidOperationException(AlgorithmName + " not initialised");
		}
		Check.DataLength(inBytes, inOff, 8, "input buffer too short");
		Check.OutputLength(outBytes, outOff, 8, "output buffer too short");
		if (!_forEncryption)
		{
			return decryptBlock(inBytes, inOff, outBytes, outOff);
		}
		return encryptBlock(inBytes, inOff, outBytes, outOff);
	}

	public virtual void Reset()
	{
	}

	private void setKey(byte[] key)
	{
		int j;
		int i = (j = 0);
		while (i < 4)
		{
			_S[i] = Pack.BE_To_UInt32(key, j);
			i++;
			j += 4;
		}
		for (i = (j = 0); i < 32; i++)
		{
			_sum0[i] = (uint)j + _S[j & 3];
			j += -1640531527;
			_sum1[i] = (uint)j + _S[(j >> 11) & 3];
		}
	}

	private int encryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
		uint v0 = Pack.BE_To_UInt32(inBytes, inOff);
		uint v1 = Pack.BE_To_UInt32(inBytes, inOff + 4);
		for (int i = 0; i < 32; i++)
		{
			v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ _sum0[i];
			v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ _sum1[i];
		}
		Pack.UInt32_To_BE(v0, outBytes, outOff);
		Pack.UInt32_To_BE(v1, outBytes, outOff + 4);
		return 8;
	}

	private int decryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
	{
		uint v0 = Pack.BE_To_UInt32(inBytes, inOff);
		uint v1 = Pack.BE_To_UInt32(inBytes, inOff + 4);
		for (int i = 31; i >= 0; i--)
		{
			v1 -= (((v0 << 4) ^ (v0 >> 5)) + v0) ^ _sum1[i];
			v0 -= (((v1 << 4) ^ (v1 >> 5)) + v1) ^ _sum0[i];
		}
		Pack.UInt32_To_BE(v0, outBytes, outOff);
		Pack.UInt32_To_BE(v1, outBytes, outOff + 4);
		return 8;
	}
}
