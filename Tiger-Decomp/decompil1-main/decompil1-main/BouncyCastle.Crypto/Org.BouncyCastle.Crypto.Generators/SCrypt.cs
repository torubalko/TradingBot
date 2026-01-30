using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

public class SCrypt
{
	public static byte[] Generate(byte[] P, byte[] S, int N, int r, int p, int dkLen)
	{
		if (P == null)
		{
			throw new ArgumentNullException("Passphrase P must be provided.");
		}
		if (S == null)
		{
			throw new ArgumentNullException("Salt S must be provided.");
		}
		if (N <= 1 || !IsPowerOf2(N))
		{
			throw new ArgumentException("Cost parameter N must be > 1 and a power of 2.");
		}
		if (r == 1 && N >= 65536)
		{
			throw new ArgumentException("Cost parameter N must be > 1 and < 65536.");
		}
		if (r < 1)
		{
			throw new ArgumentException("Block size r must be >= 1.");
		}
		int maxParallel = int.MaxValue / (128 * r * 8);
		if (p < 1 || p > maxParallel)
		{
			throw new ArgumentException("Parallelisation parameter p must be >= 1 and <= " + maxParallel + " (based on block size r of " + r + ")");
		}
		if (dkLen < 1)
		{
			throw new ArgumentException("Generated key length dkLen must be >= 1.");
		}
		return MFcrypt(P, S, N, r, p, dkLen);
	}

	private static byte[] MFcrypt(byte[] P, byte[] S, int N, int r, int p, int dkLen)
	{
		int MFLenBytes = r * 128;
		byte[] bytes = SingleIterationPBKDF2(P, S, p * MFLenBytes);
		uint[] B = null;
		try
		{
			int BLen = bytes.Length >> 2;
			B = new uint[BLen];
			Pack.LE_To_UInt32(bytes, 0, B);
			int d = 0;
			int total = N * r;
			while (N - d > 2 && total > 1024)
			{
				d++;
				total >>= 1;
			}
			int MFLenWords = MFLenBytes >> 2;
			for (int BOff = 0; BOff < BLen; BOff += MFLenWords)
			{
				SMix(B, BOff, N, d, r);
			}
			Pack.UInt32_To_LE(B, bytes, 0);
			return SingleIterationPBKDF2(P, bytes, dkLen);
		}
		finally
		{
			ClearAll(bytes, B);
		}
	}

	private static byte[] SingleIterationPBKDF2(byte[] P, byte[] S, int dkLen)
	{
		Pkcs5S2ParametersGenerator pkcs5S2ParametersGenerator = new Pkcs5S2ParametersGenerator(new Sha256Digest());
		pkcs5S2ParametersGenerator.Init(P, S, 1);
		return ((KeyParameter)pkcs5S2ParametersGenerator.GenerateDerivedMacParameters(dkLen * 8)).GetKey();
	}

	private static void SMix(uint[] B, int BOff, int N, int d, int r)
	{
		int num = Integers.NumberOfTrailingZeros(N);
		int blocksPerChunk = N >> d;
		int chunkCount = 1 << d;
		int chunkMask = blocksPerChunk - 1;
		int chunkPow = num - d;
		int BCount = r * 32;
		uint[] blockX1 = new uint[16];
		uint[] blockX2 = new uint[16];
		uint[] blockY = new uint[BCount];
		uint[] X = new uint[BCount];
		uint[][] VV = new uint[chunkCount][];
		try
		{
			Array.Copy(B, BOff, X, 0, BCount);
			for (int c = 0; c < chunkCount; c++)
			{
				uint[] V = (VV[c] = new uint[blocksPerChunk * BCount]);
				int off = 0;
				for (int i = 0; i < blocksPerChunk; i += 2)
				{
					Array.Copy(X, 0, V, off, BCount);
					off += BCount;
					BlockMix(X, blockX1, blockX2, blockY, r);
					Array.Copy(blockY, 0, V, off, BCount);
					off += BCount;
					BlockMix(blockY, blockX1, blockX2, X, r);
				}
			}
			uint mask = (uint)(N - 1);
			for (int j = 0; j < N; j++)
			{
				int j2 = (int)(X[BCount - 16] & mask);
				uint[] sourceArray = VV[j2 >> chunkPow];
				int VOff = (j2 & chunkMask) * BCount;
				Array.Copy(sourceArray, VOff, blockY, 0, BCount);
				Xor(blockY, X, 0, blockY);
				BlockMix(blockY, blockX1, blockX2, X, r);
			}
			Array.Copy(X, 0, B, BOff, BCount);
		}
		finally
		{
			Array[] arrays = VV;
			ClearAll(arrays);
			ClearAll(X, blockX1, blockX2, blockY);
		}
	}

	private static void BlockMix(uint[] B, uint[] X1, uint[] X2, uint[] Y, int r)
	{
		Array.Copy(B, B.Length - 16, X1, 0, 16);
		int BOff = 0;
		int YOff = 0;
		int halfLen = B.Length >> 1;
		for (int i = 2 * r; i > 0; i--)
		{
			Xor(X1, B, BOff, X2);
			Salsa20Engine.SalsaCore(8, X2, X1);
			Array.Copy(X1, 0, Y, YOff, 16);
			YOff = halfLen + BOff - YOff;
			BOff += 16;
		}
	}

	private static void Xor(uint[] a, uint[] b, int bOff, uint[] output)
	{
		for (int i = output.Length - 1; i >= 0; i--)
		{
			output[i] = a[i] ^ b[bOff + i];
		}
	}

	private static void Clear(Array array)
	{
		if (array != null)
		{
			Array.Clear(array, 0, array.Length);
		}
	}

	private static void ClearAll(params Array[] arrays)
	{
		for (int i = 0; i < arrays.Length; i++)
		{
			Clear(arrays[i]);
		}
	}

	private static bool IsPowerOf2(int x)
	{
		return (x & (x - 1)) == 0;
	}
}
