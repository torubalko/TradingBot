using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class NoekeonEngine : IBlockCipher
{
	private const int Size = 16;

	private static readonly byte[] RoundConstants = new byte[17]
	{
		128, 27, 54, 108, 216, 171, 77, 154, 47, 94,
		188, 99, 198, 151, 53, 106, 212
	};

	private readonly uint[] k = new uint[4];

	private bool _initialised;

	private bool _forEncryption;

	public virtual string AlgorithmName => "Noekeon";

	public virtual bool IsPartialBlockOkay => false;

	public NoekeonEngine()
	{
		_initialised = false;
	}

	public virtual int GetBlockSize()
	{
		return 16;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("Invalid parameters passed to Noekeon init - " + Platform.GetTypeName(parameters), "parameters");
		}
		byte[] key = ((KeyParameter)parameters).GetKey();
		if (key.Length != 16)
		{
			throw new ArgumentException("Key length not 128 bits.");
		}
		Pack.BE_To_UInt32(key, 0, k, 0, 4);
		if (!forEncryption)
		{
			uint a0 = k[0];
			uint a1 = k[1];
			uint a2 = k[2];
			uint a3 = k[3];
			uint t02 = a0 ^ a2;
			t02 ^= Integers.RotateLeft(t02, 8) ^ Integers.RotateLeft(t02, 24);
			uint t13 = a1 ^ a3;
			t13 ^= Integers.RotateLeft(t13, 8) ^ Integers.RotateLeft(t13, 24);
			a0 ^= t13;
			a1 ^= t02;
			a2 ^= t13;
			a3 ^= t02;
			k[0] = a0;
			k[1] = a1;
			k[2] = a2;
			k[3] = a3;
		}
		_forEncryption = forEncryption;
		_initialised = true;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (!_initialised)
		{
			throw new InvalidOperationException(AlgorithmName + " not initialised");
		}
		Check.DataLength(input, inOff, 16, "input buffer too short");
		Check.OutputLength(output, outOff, 16, "output buffer too short");
		if (!_forEncryption)
		{
			return DecryptBlock(input, inOff, output, outOff);
		}
		return EncryptBlock(input, inOff, output, outOff);
	}

	public virtual void Reset()
	{
	}

	private int EncryptBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		uint a0 = Pack.BE_To_UInt32(input, inOff);
		uint a1 = Pack.BE_To_UInt32(input, inOff + 4);
		uint a2 = Pack.BE_To_UInt32(input, inOff + 8);
		uint a3 = Pack.BE_To_UInt32(input, inOff + 12);
		uint k0 = k[0];
		uint k1 = k[1];
		uint k2 = k[2];
		uint k3 = k[3];
		int round = 0;
		while (true)
		{
			a0 ^= RoundConstants[round];
			uint t02 = a0 ^ a2;
			t02 ^= Integers.RotateLeft(t02, 8) ^ Integers.RotateLeft(t02, 24);
			a0 ^= k0;
			a1 ^= k1;
			a2 ^= k2;
			a3 ^= k3;
			uint t13 = a1 ^ a3;
			t13 ^= Integers.RotateLeft(t13, 8) ^ Integers.RotateLeft(t13, 24);
			a0 ^= t13;
			a1 ^= t02;
			a2 ^= t13;
			a3 ^= t02;
			if (++round > 16)
			{
				break;
			}
			a1 = Integers.RotateLeft(a1, 1);
			a2 = Integers.RotateLeft(a2, 5);
			a3 = Integers.RotateLeft(a3, 2);
			uint num = a3;
			a1 ^= a3 | a2;
			a3 = a0 ^ (a2 & ~a1);
			a2 = num ^ ~a1 ^ a2 ^ a3;
			a1 ^= a3 | a2;
			a0 = num ^ (a2 & a1);
			a1 = Integers.RotateLeft(a1, 31);
			a2 = Integers.RotateLeft(a2, 27);
			a3 = Integers.RotateLeft(a3, 30);
		}
		Pack.UInt32_To_BE(a0, output, outOff);
		Pack.UInt32_To_BE(a1, output, outOff + 4);
		Pack.UInt32_To_BE(a2, output, outOff + 8);
		Pack.UInt32_To_BE(a3, output, outOff + 12);
		return 16;
	}

	private int DecryptBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		uint a0 = Pack.BE_To_UInt32(input, inOff);
		uint a1 = Pack.BE_To_UInt32(input, inOff + 4);
		uint a2 = Pack.BE_To_UInt32(input, inOff + 8);
		uint a3 = Pack.BE_To_UInt32(input, inOff + 12);
		uint k0 = k[0];
		uint k1 = k[1];
		uint k2 = k[2];
		uint k3 = k[3];
		int round = 16;
		while (true)
		{
			uint t02 = a0 ^ a2;
			t02 ^= Integers.RotateLeft(t02, 8) ^ Integers.RotateLeft(t02, 24);
			a0 ^= k0;
			a1 ^= k1;
			a2 ^= k2;
			a3 ^= k3;
			uint t13 = a1 ^ a3;
			t13 ^= Integers.RotateLeft(t13, 8) ^ Integers.RotateLeft(t13, 24);
			a0 ^= t13;
			a1 ^= t02;
			a2 ^= t13;
			a3 ^= t02;
			a0 ^= RoundConstants[round];
			if (--round < 0)
			{
				break;
			}
			a1 = Integers.RotateLeft(a1, 1);
			a2 = Integers.RotateLeft(a2, 5);
			a3 = Integers.RotateLeft(a3, 2);
			uint num = a3;
			a1 ^= a3 | a2;
			a3 = a0 ^ (a2 & ~a1);
			a2 = num ^ ~a1 ^ a2 ^ a3;
			a1 ^= a3 | a2;
			a0 = num ^ (a2 & a1);
			a1 = Integers.RotateLeft(a1, 31);
			a2 = Integers.RotateLeft(a2, 27);
			a3 = Integers.RotateLeft(a3, 30);
		}
		Pack.UInt32_To_BE(a0, output, outOff);
		Pack.UInt32_To_BE(a1, output, outOff + 4);
		Pack.UInt32_To_BE(a2, output, outOff + 8);
		Pack.UInt32_To_BE(a3, output, outOff + 12);
		return 16;
	}
}
