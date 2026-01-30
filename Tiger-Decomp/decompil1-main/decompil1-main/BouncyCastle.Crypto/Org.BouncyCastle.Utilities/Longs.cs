using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Utilities;

public abstract class Longs
{
	public const int NumBits = 64;

	public const int NumBytes = 8;

	private static readonly byte[] DeBruijnTZ = new byte[64]
	{
		63, 0, 1, 52, 2, 6, 53, 26, 3, 37,
		40, 7, 33, 54, 47, 27, 61, 4, 38, 45,
		43, 41, 21, 8, 23, 34, 58, 55, 48, 17,
		28, 10, 62, 51, 5, 25, 36, 39, 32, 46,
		60, 44, 42, 20, 22, 57, 16, 9, 50, 24,
		35, 31, 59, 19, 56, 15, 49, 30, 18, 14,
		29, 13, 12, 11
	};

	public static int NumberOfLeadingZeros(long i)
	{
		int x = (int)(i >> 32);
		int n = 0;
		if (x == 0)
		{
			n = 32;
			x = (int)i;
		}
		return n + Integers.NumberOfLeadingZeros(x);
	}

	public static int NumberOfTrailingZeros(long i)
	{
		byte num = DeBruijnTZ[(int)((i & -i) * 315175865370177754L >>> 58)];
		long m = ((i & 0xFFFFFFFFu) | (i >>> 32)) - 1 >> 63;
		return num - (int)m;
	}

	public static long Reverse(long i)
	{
		return (long)Reverse((ulong)i);
	}

	[CLSCompliant(false)]
	public static ulong Reverse(ulong i)
	{
		i = Bits.BitPermuteStepSimple(i, 6148914691236517205uL, 1);
		i = Bits.BitPermuteStepSimple(i, 3689348814741910323uL, 2);
		i = Bits.BitPermuteStepSimple(i, 1085102592571150095uL, 4);
		return ReverseBytes(i);
	}

	public static long ReverseBytes(long i)
	{
		return (long)ReverseBytes((ulong)i);
	}

	[CLSCompliant(false)]
	public static ulong ReverseBytes(ulong i)
	{
		return RotateLeft(i & 0xFF000000FF000000uL, 8) | RotateLeft(i & 0xFF000000FF0000L, 24) | RotateLeft(i & 0xFF000000FF00L, 40) | RotateLeft(i & 0xFF000000FFL, 56);
	}

	public static long RotateLeft(long i, int distance)
	{
		return (i << distance) ^ (i >>> -distance);
	}

	[CLSCompliant(false)]
	public static ulong RotateLeft(ulong i, int distance)
	{
		return (i << distance) ^ (i >> -distance);
	}

	public static long RotateRight(long i, int distance)
	{
		return (i >>> distance) ^ (i << -distance);
	}

	[CLSCompliant(false)]
	public static ulong RotateRight(ulong i, int distance)
	{
		return (i >> distance) ^ (i << -distance);
	}
}
