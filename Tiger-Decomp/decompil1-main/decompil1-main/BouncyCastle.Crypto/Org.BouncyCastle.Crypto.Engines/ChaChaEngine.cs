using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class ChaChaEngine : Salsa20Engine
{
	public override string AlgorithmName => "ChaCha" + rounds;

	public ChaChaEngine()
	{
	}

	public ChaChaEngine(int rounds)
		: base(rounds)
	{
	}

	protected override void AdvanceCounter()
	{
		if (++engineState[12] == 0)
		{
			engineState[13]++;
		}
	}

	protected override void ResetCounter()
	{
		engineState[12] = (engineState[13] = 0u);
	}

	protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
	{
		if (keyBytes != null)
		{
			if (keyBytes.Length != 16 && keyBytes.Length != 32)
			{
				throw new ArgumentException(AlgorithmName + " requires 128 bit or 256 bit key");
			}
			PackTauOrSigma(keyBytes.Length, engineState, 0);
			Pack.LE_To_UInt32(keyBytes, 0, engineState, 4, 4);
			Pack.LE_To_UInt32(keyBytes, keyBytes.Length - 16, engineState, 8, 4);
		}
		Pack.LE_To_UInt32(ivBytes, 0, engineState, 14, 2);
	}

	protected override void GenerateKeyStream(byte[] output)
	{
		ChachaCore(rounds, engineState, x);
		Pack.UInt32_To_LE(x, output, 0);
	}

	internal static void ChachaCore(int rounds, uint[] input, uint[] x)
	{
		if (input.Length != 16)
		{
			throw new ArgumentException();
		}
		if (x.Length != 16)
		{
			throw new ArgumentException();
		}
		if (rounds % 2 != 0)
		{
			throw new ArgumentException("Number of rounds must be even");
		}
		uint x2 = input[0];
		uint x3 = input[1];
		uint x4 = input[2];
		uint x5 = input[3];
		uint x6 = input[4];
		uint x7 = input[5];
		uint x8 = input[6];
		uint x9 = input[7];
		uint x10 = input[8];
		uint x11 = input[9];
		uint x12 = input[10];
		uint x13 = input[11];
		uint x14 = input[12];
		uint x15 = input[13];
		uint x16 = input[14];
		uint x17 = input[15];
		for (int i = rounds; i > 0; i -= 2)
		{
			x2 += x6;
			x14 = Integers.RotateLeft(x14 ^ x2, 16);
			x10 += x14;
			x6 = Integers.RotateLeft(x6 ^ x10, 12);
			x2 += x6;
			x14 = Integers.RotateLeft(x14 ^ x2, 8);
			x10 += x14;
			x6 = Integers.RotateLeft(x6 ^ x10, 7);
			x3 += x7;
			x15 = Integers.RotateLeft(x15 ^ x3, 16);
			x11 += x15;
			x7 = Integers.RotateLeft(x7 ^ x11, 12);
			x3 += x7;
			x15 = Integers.RotateLeft(x15 ^ x3, 8);
			x11 += x15;
			x7 = Integers.RotateLeft(x7 ^ x11, 7);
			x4 += x8;
			x16 = Integers.RotateLeft(x16 ^ x4, 16);
			x12 += x16;
			x8 = Integers.RotateLeft(x8 ^ x12, 12);
			x4 += x8;
			x16 = Integers.RotateLeft(x16 ^ x4, 8);
			x12 += x16;
			x8 = Integers.RotateLeft(x8 ^ x12, 7);
			x5 += x9;
			x17 = Integers.RotateLeft(x17 ^ x5, 16);
			x13 += x17;
			x9 = Integers.RotateLeft(x9 ^ x13, 12);
			x5 += x9;
			x17 = Integers.RotateLeft(x17 ^ x5, 8);
			x13 += x17;
			x9 = Integers.RotateLeft(x9 ^ x13, 7);
			x2 += x7;
			x17 = Integers.RotateLeft(x17 ^ x2, 16);
			x12 += x17;
			x7 = Integers.RotateLeft(x7 ^ x12, 12);
			x2 += x7;
			x17 = Integers.RotateLeft(x17 ^ x2, 8);
			x12 += x17;
			x7 = Integers.RotateLeft(x7 ^ x12, 7);
			x3 += x8;
			x14 = Integers.RotateLeft(x14 ^ x3, 16);
			x13 += x14;
			x8 = Integers.RotateLeft(x8 ^ x13, 12);
			x3 += x8;
			x14 = Integers.RotateLeft(x14 ^ x3, 8);
			x13 += x14;
			x8 = Integers.RotateLeft(x8 ^ x13, 7);
			x4 += x9;
			x15 = Integers.RotateLeft(x15 ^ x4, 16);
			x10 += x15;
			x9 = Integers.RotateLeft(x9 ^ x10, 12);
			x4 += x9;
			x15 = Integers.RotateLeft(x15 ^ x4, 8);
			x10 += x15;
			x9 = Integers.RotateLeft(x9 ^ x10, 7);
			x5 += x6;
			x16 = Integers.RotateLeft(x16 ^ x5, 16);
			x11 += x16;
			x6 = Integers.RotateLeft(x6 ^ x11, 12);
			x5 += x6;
			x16 = Integers.RotateLeft(x16 ^ x5, 8);
			x11 += x16;
			x6 = Integers.RotateLeft(x6 ^ x11, 7);
		}
		x[0] = x2 + input[0];
		x[1] = x3 + input[1];
		x[2] = x4 + input[2];
		x[3] = x5 + input[3];
		x[4] = x6 + input[4];
		x[5] = x7 + input[5];
		x[6] = x8 + input[6];
		x[7] = x9 + input[7];
		x[8] = x10 + input[8];
		x[9] = x11 + input[9];
		x[10] = x12 + input[10];
		x[11] = x13 + input[11];
		x[12] = x14 + input[12];
		x[13] = x15 + input[13];
		x[14] = x16 + input[14];
		x[15] = x17 + input[15];
	}
}
