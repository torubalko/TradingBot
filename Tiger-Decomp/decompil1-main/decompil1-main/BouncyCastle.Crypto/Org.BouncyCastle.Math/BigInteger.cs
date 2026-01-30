using System;
using System.Collections;
using System.Globalization;
using System.Text;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math;

[Serializable]
public class BigInteger
{
	internal static readonly int[][] primeLists;

	internal static readonly int[] primeProducts;

	private const long IMASK = 4294967295L;

	private const ulong UIMASK = 4294967295uL;

	private static readonly int[] ZeroMagnitude;

	private static readonly byte[] ZeroEncoding;

	private static readonly BigInteger[] SMALL_CONSTANTS;

	public static readonly BigInteger Zero;

	public static readonly BigInteger One;

	public static readonly BigInteger Two;

	public static readonly BigInteger Three;

	public static readonly BigInteger Four;

	public static readonly BigInteger Ten;

	private static readonly byte[] BitLengthTable;

	private const int chunk2 = 1;

	private const int chunk8 = 1;

	private const int chunk10 = 19;

	private const int chunk16 = 16;

	private static readonly BigInteger radix2;

	private static readonly BigInteger radix2E;

	private static readonly BigInteger radix8;

	private static readonly BigInteger radix8E;

	private static readonly BigInteger radix10;

	private static readonly BigInteger radix10E;

	private static readonly BigInteger radix16;

	private static readonly BigInteger radix16E;

	private static readonly SecureRandom RandomSource;

	private static readonly int[] ExpWindowThresholds;

	private const int BitsPerByte = 8;

	private const int BitsPerInt = 32;

	private const int BytesPerInt = 4;

	private int[] magnitude;

	private int sign;

	private int nBits = -1;

	private int nBitLength = -1;

	private int mQuote;

	public int BitCount
	{
		get
		{
			if (nBits == -1)
			{
				if (sign < 0)
				{
					nBits = Not().BitCount;
				}
				else
				{
					int sum = 0;
					for (int i = 0; i < magnitude.Length; i++)
					{
						sum += BitCnt(magnitude[i]);
					}
					nBits = sum;
				}
			}
			return nBits;
		}
	}

	public int BitLength
	{
		get
		{
			if (nBitLength == -1)
			{
				nBitLength = ((sign != 0) ? CalcBitLength(sign, 0, magnitude) : 0);
			}
			return nBitLength;
		}
	}

	public int IntValue
	{
		get
		{
			if (sign == 0)
			{
				return 0;
			}
			int n = magnitude.Length;
			int v = magnitude[n - 1];
			if (sign >= 0)
			{
				return v;
			}
			return -v;
		}
	}

	public int IntValueExact
	{
		get
		{
			if (BitLength > 31)
			{
				throw new ArithmeticException("BigInteger out of int range");
			}
			return IntValue;
		}
	}

	public long LongValue
	{
		get
		{
			if (sign == 0)
			{
				return 0L;
			}
			int n = magnitude.Length;
			long v = magnitude[n - 1] & 0xFFFFFFFFu;
			if (n > 1)
			{
				v |= (magnitude[n - 2] & 0xFFFFFFFFu) << 32;
			}
			if (sign >= 0)
			{
				return v;
			}
			return -v;
		}
	}

	public long LongValueExact
	{
		get
		{
			if (BitLength > 63)
			{
				throw new ArithmeticException("BigInteger out of long range");
			}
			return LongValue;
		}
	}

	public int SignValue => sign;

	static BigInteger()
	{
		primeLists = new int[64][]
		{
			new int[8] { 3, 5, 7, 11, 13, 17, 19, 23 },
			new int[5] { 29, 31, 37, 41, 43 },
			new int[5] { 47, 53, 59, 61, 67 },
			new int[4] { 71, 73, 79, 83 },
			new int[4] { 89, 97, 101, 103 },
			new int[4] { 107, 109, 113, 127 },
			new int[4] { 131, 137, 139, 149 },
			new int[4] { 151, 157, 163, 167 },
			new int[4] { 173, 179, 181, 191 },
			new int[4] { 193, 197, 199, 211 },
			new int[3] { 223, 227, 229 },
			new int[3] { 233, 239, 241 },
			new int[3] { 251, 257, 263 },
			new int[3] { 269, 271, 277 },
			new int[3] { 281, 283, 293 },
			new int[3] { 307, 311, 313 },
			new int[3] { 317, 331, 337 },
			new int[3] { 347, 349, 353 },
			new int[3] { 359, 367, 373 },
			new int[3] { 379, 383, 389 },
			new int[3] { 397, 401, 409 },
			new int[3] { 419, 421, 431 },
			new int[3] { 433, 439, 443 },
			new int[3] { 449, 457, 461 },
			new int[3] { 463, 467, 479 },
			new int[3] { 487, 491, 499 },
			new int[3] { 503, 509, 521 },
			new int[3] { 523, 541, 547 },
			new int[3] { 557, 563, 569 },
			new int[3] { 571, 577, 587 },
			new int[3] { 593, 599, 601 },
			new int[3] { 607, 613, 617 },
			new int[3] { 619, 631, 641 },
			new int[3] { 643, 647, 653 },
			new int[3] { 659, 661, 673 },
			new int[3] { 677, 683, 691 },
			new int[3] { 701, 709, 719 },
			new int[3] { 727, 733, 739 },
			new int[3] { 743, 751, 757 },
			new int[3] { 761, 769, 773 },
			new int[3] { 787, 797, 809 },
			new int[3] { 811, 821, 823 },
			new int[3] { 827, 829, 839 },
			new int[3] { 853, 857, 859 },
			new int[3] { 863, 877, 881 },
			new int[3] { 883, 887, 907 },
			new int[3] { 911, 919, 929 },
			new int[3] { 937, 941, 947 },
			new int[3] { 953, 967, 971 },
			new int[3] { 977, 983, 991 },
			new int[3] { 997, 1009, 1013 },
			new int[3] { 1019, 1021, 1031 },
			new int[3] { 1033, 1039, 1049 },
			new int[3] { 1051, 1061, 1063 },
			new int[3] { 1069, 1087, 1091 },
			new int[3] { 1093, 1097, 1103 },
			new int[3] { 1109, 1117, 1123 },
			new int[3] { 1129, 1151, 1153 },
			new int[3] { 1163, 1171, 1181 },
			new int[3] { 1187, 1193, 1201 },
			new int[3] { 1213, 1217, 1223 },
			new int[3] { 1229, 1231, 1237 },
			new int[3] { 1249, 1259, 1277 },
			new int[3] { 1279, 1283, 1289 }
		};
		ZeroMagnitude = new int[0];
		ZeroEncoding = new byte[0];
		SMALL_CONSTANTS = new BigInteger[17];
		BitLengthTable = new byte[256]
		{
			0, 1, 2, 2, 3, 3, 3, 3, 4, 4,
			4, 4, 4, 4, 4, 4, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8
		};
		RandomSource = new SecureRandom();
		ExpWindowThresholds = new int[8] { 7, 25, 81, 241, 673, 1793, 4609, 2147483647 };
		Zero = new BigInteger(0, ZeroMagnitude, checkMag: false);
		Zero.nBits = 0;
		Zero.nBitLength = 0;
		SMALL_CONSTANTS[0] = Zero;
		for (uint i = 1u; i < SMALL_CONSTANTS.Length; i++)
		{
			SMALL_CONSTANTS[i] = CreateUValueOf(i);
		}
		One = SMALL_CONSTANTS[1];
		Two = SMALL_CONSTANTS[2];
		Three = SMALL_CONSTANTS[3];
		Four = SMALL_CONSTANTS[4];
		Ten = SMALL_CONSTANTS[10];
		radix2 = ValueOf(2L);
		radix2E = radix2.Pow(1);
		radix8 = ValueOf(8L);
		radix8E = radix8.Pow(1);
		radix10 = ValueOf(10L);
		radix10E = radix10.Pow(19);
		radix16 = ValueOf(16L);
		radix16E = radix16.Pow(16);
		primeProducts = new int[primeLists.Length];
		for (int j = 0; j < primeLists.Length; j++)
		{
			int[] primeList = primeLists[j];
			int product = primeList[0];
			for (int k = 1; k < primeList.Length; k++)
			{
				product *= primeList[k];
			}
			primeProducts[j] = product;
		}
	}

	private static int GetByteLength(int nBits)
	{
		return (nBits + 8 - 1) / 8;
	}

	public static BigInteger Arbitrary(int sizeInBits)
	{
		return new BigInteger(sizeInBits, RandomSource);
	}

	private BigInteger(int signum, int[] mag, bool checkMag)
	{
		if (checkMag)
		{
			int i;
			for (i = 0; i < mag.Length && mag[i] == 0; i++)
			{
			}
			if (i == mag.Length)
			{
				sign = 0;
				magnitude = ZeroMagnitude;
				return;
			}
			sign = signum;
			if (i == 0)
			{
				magnitude = mag;
				return;
			}
			magnitude = new int[mag.Length - i];
			Array.Copy(mag, i, magnitude, 0, magnitude.Length);
		}
		else
		{
			sign = signum;
			magnitude = mag;
		}
	}

	public BigInteger(string value)
		: this(value, 10)
	{
	}

	public BigInteger(string str, int radix)
	{
		if (str.Length == 0)
		{
			throw new FormatException("Zero length BigInteger");
		}
		NumberStyles style;
		int chunk;
		BigInteger r;
		BigInteger rE;
		switch (radix)
		{
		case 2:
			style = NumberStyles.Integer;
			chunk = 1;
			r = radix2;
			rE = radix2E;
			break;
		case 8:
			style = NumberStyles.Integer;
			chunk = 1;
			r = radix8;
			rE = radix8E;
			break;
		case 10:
			style = NumberStyles.Integer;
			chunk = 19;
			r = radix10;
			rE = radix10E;
			break;
		case 16:
			style = NumberStyles.AllowHexSpecifier;
			chunk = 16;
			r = radix16;
			rE = radix16E;
			break;
		default:
			throw new FormatException("Only bases 2, 8, 10, or 16 allowed");
		}
		int index = 0;
		sign = 1;
		if (str[0] == '-')
		{
			if (str.Length == 1)
			{
				throw new FormatException("Zero length BigInteger");
			}
			sign = -1;
			index = 1;
		}
		for (; index < str.Length && int.Parse(str[index].ToString(), style) == 0; index++)
		{
		}
		if (index >= str.Length)
		{
			sign = 0;
			magnitude = ZeroMagnitude;
			return;
		}
		BigInteger b = Zero;
		int next = index + chunk;
		if (next <= str.Length)
		{
			do
			{
				string s = str.Substring(index, chunk);
				ulong i = ulong.Parse(s, style);
				BigInteger bi = CreateUValueOf(i);
				switch (radix)
				{
				case 2:
					if (i >= 2)
					{
						throw new FormatException("Bad character in radix 2 string: " + s);
					}
					b = b.ShiftLeft(1);
					break;
				case 8:
					if (i >= 8)
					{
						throw new FormatException("Bad character in radix 8 string: " + s);
					}
					b = b.ShiftLeft(3);
					break;
				case 16:
					b = b.ShiftLeft(64);
					break;
				default:
					b = b.Multiply(rE);
					break;
				}
				b = b.Add(bi);
				index = next;
				next += chunk;
			}
			while (next <= str.Length);
		}
		if (index < str.Length)
		{
			string s2 = str.Substring(index);
			BigInteger bi2 = CreateUValueOf(ulong.Parse(s2, style));
			if (b.sign > 0)
			{
				switch (radix)
				{
				case 16:
					b = b.ShiftLeft(s2.Length << 2);
					break;
				default:
					b = b.Multiply(r.Pow(s2.Length));
					break;
				case 2:
				case 8:
					break;
				}
				b = b.Add(bi2);
			}
			else
			{
				b = bi2;
			}
		}
		magnitude = b.magnitude;
	}

	public BigInteger(byte[] bytes)
		: this(bytes, 0, bytes.Length)
	{
	}

	public BigInteger(byte[] bytes, int offset, int length)
	{
		if (length == 0)
		{
			throw new FormatException("Zero length BigInteger");
		}
		if ((sbyte)bytes[offset] < 0)
		{
			sign = -1;
			int end = offset + length;
			int iBval;
			for (iBval = offset; iBval < end && (sbyte)bytes[iBval] == -1; iBval++)
			{
			}
			if (iBval >= end)
			{
				magnitude = One.magnitude;
				return;
			}
			int numBytes = end - iBval;
			byte[] inverse = new byte[numBytes];
			int index = 0;
			while (index < numBytes)
			{
				inverse[index++] = (byte)(~bytes[iBval++]);
			}
			while (inverse[--index] == byte.MaxValue)
			{
				inverse[index] = 0;
			}
			inverse[index]++;
			magnitude = MakeMagnitude(inverse, 0, inverse.Length);
		}
		else
		{
			magnitude = MakeMagnitude(bytes, offset, length);
			sign = ((magnitude.Length != 0) ? 1 : 0);
		}
	}

	private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
	{
		int end = offset + length;
		int firstSignificant;
		for (firstSignificant = offset; firstSignificant < end && bytes[firstSignificant] == 0; firstSignificant++)
		{
		}
		if (firstSignificant >= end)
		{
			return ZeroMagnitude;
		}
		int nInts = (end - firstSignificant + 3) / 4;
		int bCount = (end - firstSignificant) % 4;
		if (bCount == 0)
		{
			bCount = 4;
		}
		if (nInts < 1)
		{
			return ZeroMagnitude;
		}
		int[] mag = new int[nInts];
		int v = 0;
		int magnitudeIndex = 0;
		for (int i = firstSignificant; i < end; i++)
		{
			v <<= 8;
			v |= bytes[i] & 0xFF;
			bCount--;
			if (bCount <= 0)
			{
				mag[magnitudeIndex] = v;
				magnitudeIndex++;
				bCount = 4;
				v = 0;
			}
		}
		if (magnitudeIndex < mag.Length)
		{
			mag[magnitudeIndex] = v;
		}
		return mag;
	}

	public BigInteger(int sign, byte[] bytes)
		: this(sign, bytes, 0, bytes.Length)
	{
	}

	public BigInteger(int sign, byte[] bytes, int offset, int length)
	{
		switch (sign)
		{
		default:
			throw new FormatException("Invalid sign value");
		case 0:
			this.sign = 0;
			magnitude = ZeroMagnitude;
			break;
		case -1:
		case 1:
			magnitude = MakeMagnitude(bytes, offset, length);
			this.sign = ((magnitude.Length >= 1) ? sign : 0);
			break;
		}
	}

	public BigInteger(int sizeInBits, Random random)
	{
		if (sizeInBits < 0)
		{
			throw new ArgumentException("sizeInBits must be non-negative");
		}
		nBits = -1;
		nBitLength = -1;
		if (sizeInBits == 0)
		{
			sign = 0;
			magnitude = ZeroMagnitude;
			return;
		}
		int nBytes = GetByteLength(sizeInBits);
		byte[] b = new byte[nBytes];
		random.NextBytes(b);
		int xBits = 8 * nBytes - sizeInBits;
		b[0] &= (byte)(255 >>> xBits);
		magnitude = MakeMagnitude(b, 0, b.Length);
		sign = ((magnitude.Length >= 1) ? 1 : 0);
	}

	public BigInteger(int bitLength, int certainty, Random random)
	{
		if (bitLength < 2)
		{
			throw new ArithmeticException("bitLength < 2");
		}
		sign = 1;
		nBitLength = bitLength;
		if (bitLength == 2)
		{
			magnitude = ((random.Next(2) == 0) ? Two.magnitude : Three.magnitude);
			return;
		}
		int nBytes = GetByteLength(bitLength);
		byte[] b = new byte[nBytes];
		int xBits = 8 * nBytes - bitLength;
		byte mask = (byte)(255u >> xBits);
		byte lead = (byte)(1 << 7 - xBits);
		while (true)
		{
			random.NextBytes(b);
			b[0] &= mask;
			b[0] |= lead;
			b[nBytes - 1] |= 1;
			magnitude = MakeMagnitude(b, 0, b.Length);
			nBits = -1;
			mQuote = 0;
			if (certainty < 1 || CheckProbablePrime(certainty, random, randomlySelected: true))
			{
				break;
			}
			for (int j = 1; j < magnitude.Length - 1; j++)
			{
				magnitude[j] ^= random.Next();
				if (CheckProbablePrime(certainty, random, randomlySelected: true))
				{
					return;
				}
			}
		}
	}

	public BigInteger Abs()
	{
		if (sign < 0)
		{
			return Negate();
		}
		return this;
	}

	private static int[] AddMagnitudes(int[] a, int[] b)
	{
		int tI = a.Length - 1;
		int vI = b.Length - 1;
		long m = 0L;
		while (vI >= 0)
		{
			m += (long)(uint)a[tI] + (long)(uint)b[vI--];
			a[tI--] = (int)m;
			m >>>= 32;
		}
		if (m != 0L)
		{
			while (tI >= 0 && ++a[tI--] == 0)
			{
			}
		}
		return a;
	}

	public BigInteger Add(BigInteger value)
	{
		if (sign == 0)
		{
			return value;
		}
		if (sign != value.sign)
		{
			if (value.sign == 0)
			{
				return this;
			}
			if (value.sign < 0)
			{
				return Subtract(value.Negate());
			}
			return value.Subtract(Negate());
		}
		return AddToMagnitude(value.magnitude);
	}

	private BigInteger AddToMagnitude(int[] magToAdd)
	{
		int[] big;
		int[] small;
		if (magnitude.Length < magToAdd.Length)
		{
			big = magToAdd;
			small = magnitude;
		}
		else
		{
			big = magnitude;
			small = magToAdd;
		}
		uint limit = uint.MaxValue;
		if (big.Length == small.Length)
		{
			limit -= (uint)small[0];
		}
		bool possibleOverflow = (uint)big[0] >= limit;
		int[] bigCopy;
		if (possibleOverflow)
		{
			bigCopy = new int[big.Length + 1];
			big.CopyTo(bigCopy, 1);
		}
		else
		{
			bigCopy = (int[])big.Clone();
		}
		bigCopy = AddMagnitudes(bigCopy, small);
		return new BigInteger(sign, bigCopy, possibleOverflow);
	}

	public BigInteger And(BigInteger value)
	{
		if (sign == 0 || value.sign == 0)
		{
			return Zero;
		}
		int[] aMag = ((sign > 0) ? magnitude : Add(One).magnitude);
		int[] bMag = ((value.sign > 0) ? value.magnitude : value.Add(One).magnitude);
		bool resultNeg = sign < 0 && value.sign < 0;
		int[] resultMag = new int[System.Math.Max(aMag.Length, bMag.Length)];
		int aStart = resultMag.Length - aMag.Length;
		int bStart = resultMag.Length - bMag.Length;
		for (int i = 0; i < resultMag.Length; i++)
		{
			int aWord = ((i >= aStart) ? aMag[i - aStart] : 0);
			int bWord = ((i >= bStart) ? bMag[i - bStart] : 0);
			if (sign < 0)
			{
				aWord = ~aWord;
			}
			if (value.sign < 0)
			{
				bWord = ~bWord;
			}
			resultMag[i] = aWord & bWord;
			if (resultNeg)
			{
				resultMag[i] = ~resultMag[i];
			}
		}
		BigInteger result = new BigInteger(1, resultMag, checkMag: true);
		if (resultNeg)
		{
			result = result.Not();
		}
		return result;
	}

	public BigInteger AndNot(BigInteger val)
	{
		return And(val.Not());
	}

	public static int BitCnt(int i)
	{
		uint u = (uint)i;
		u -= (u >> 1) & 0x55555555;
		u = (u & 0x33333333) + ((u >> 2) & 0x33333333);
		u = (u + (u >> 4)) & 0xF0F0F0F;
		u += u >> 8;
		u += u >> 16;
		return (int)(u & 0x3F);
	}

	private static int CalcBitLength(int sign, int indx, int[] mag)
	{
		while (true)
		{
			if (indx >= mag.Length)
			{
				return 0;
			}
			if (mag[indx] != 0)
			{
				break;
			}
			indx++;
		}
		int bitLength = 32 * (mag.Length - indx - 1);
		int firstMag = mag[indx];
		bitLength += BitLen(firstMag);
		if (sign < 0 && (firstMag & -firstMag) == firstMag)
		{
			do
			{
				if (++indx >= mag.Length)
				{
					bitLength--;
					break;
				}
			}
			while (mag[indx] == 0);
		}
		return bitLength;
	}

	internal static int BitLen(int w)
	{
		uint t = (uint)w >> 24;
		if (t != 0)
		{
			return 24 + BitLengthTable[t];
		}
		t = (uint)w >> 16;
		if (t != 0)
		{
			return 16 + BitLengthTable[t];
		}
		t = (uint)w >> 8;
		if (t != 0)
		{
			return 8 + BitLengthTable[t];
		}
		return BitLengthTable[w];
	}

	private bool QuickPow2Check()
	{
		if (sign > 0)
		{
			return nBits == 1;
		}
		return false;
	}

	public int CompareTo(object obj)
	{
		return CompareTo((BigInteger)obj);
	}

	private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
	{
		while (xIndx != x.Length && x[xIndx] == 0)
		{
			xIndx++;
		}
		while (yIndx != y.Length && y[yIndx] == 0)
		{
			yIndx++;
		}
		return CompareNoLeadingZeroes(xIndx, x, yIndx, y);
	}

	private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
	{
		int diff = x.Length - y.Length - (xIndx - yIndx);
		if (diff != 0)
		{
			if (diff >= 0)
			{
				return 1;
			}
			return -1;
		}
		while (xIndx < x.Length)
		{
			uint v1 = (uint)x[xIndx++];
			uint v2 = (uint)y[yIndx++];
			if (v1 != v2)
			{
				if (v1 >= v2)
				{
					return 1;
				}
				return -1;
			}
		}
		return 0;
	}

	public int CompareTo(BigInteger value)
	{
		if (sign >= value.sign)
		{
			if (sign <= value.sign)
			{
				if (sign != 0)
				{
					return sign * CompareNoLeadingZeroes(0, magnitude, 0, value.magnitude);
				}
				return 0;
			}
			return 1;
		}
		return -1;
	}

	private int[] Divide(int[] x, int[] y)
	{
		int xStart;
		for (xStart = 0; xStart < x.Length && x[xStart] == 0; xStart++)
		{
		}
		int yStart;
		for (yStart = 0; yStart < y.Length && y[yStart] == 0; yStart++)
		{
		}
		int xyCmp = CompareNoLeadingZeroes(xStart, x, yStart, y);
		int[] count;
		if (xyCmp > 0)
		{
			int yBitLength = CalcBitLength(1, yStart, y);
			int xBitLength = CalcBitLength(1, xStart, x);
			int shift = xBitLength - yBitLength;
			int iCountStart = 0;
			int cStart = 0;
			int cBitLength = yBitLength;
			int[] iCount;
			int[] c;
			if (shift > 0)
			{
				iCount = new int[(shift >> 5) + 1];
				iCount[0] = 1 << shift % 32;
				c = ShiftLeft(y, shift);
				cBitLength += shift;
			}
			else
			{
				iCount = new int[1] { 1 };
				int len = y.Length - yStart;
				c = new int[len];
				Array.Copy(y, yStart, c, 0, len);
			}
			count = new int[iCount.Length];
			while (true)
			{
				if (cBitLength < xBitLength || CompareNoLeadingZeroes(xStart, x, cStart, c) >= 0)
				{
					Subtract(xStart, x, cStart, c);
					AddMagnitudes(count, iCount);
					while (x[xStart] == 0)
					{
						if (++xStart == x.Length)
						{
							return count;
						}
					}
					xBitLength = 32 * (x.Length - xStart - 1) + BitLen(x[xStart]);
					if (xBitLength <= yBitLength)
					{
						if (xBitLength < yBitLength)
						{
							return count;
						}
						xyCmp = CompareNoLeadingZeroes(xStart, x, yStart, y);
						if (xyCmp <= 0)
						{
							break;
						}
					}
				}
				shift = cBitLength - xBitLength;
				if (shift == 1)
				{
					int num = c[cStart] >>> 1;
					uint firstX = (uint)x[xStart];
					if ((uint)num > firstX)
					{
						shift++;
					}
				}
				if (shift < 2)
				{
					ShiftRightOneInPlace(cStart, c);
					cBitLength--;
					ShiftRightOneInPlace(iCountStart, iCount);
				}
				else
				{
					ShiftRightInPlace(cStart, c, shift);
					cBitLength -= shift;
					ShiftRightInPlace(iCountStart, iCount, shift);
				}
				for (; c[cStart] == 0; cStart++)
				{
				}
				for (; iCount[iCountStart] == 0; iCountStart++)
				{
				}
			}
		}
		else
		{
			count = new int[1];
		}
		if (xyCmp == 0)
		{
			AddMagnitudes(count, One.magnitude);
			Array.Clear(x, xStart, x.Length - xStart);
		}
		return count;
	}

	public BigInteger Divide(BigInteger val)
	{
		if (val.sign == 0)
		{
			throw new ArithmeticException("Division by zero error");
		}
		if (sign == 0)
		{
			return Zero;
		}
		if (val.QuickPow2Check())
		{
			BigInteger result = Abs().ShiftRight(val.Abs().BitLength - 1);
			if (val.sign != sign)
			{
				return result.Negate();
			}
			return result;
		}
		int[] mag = (int[])magnitude.Clone();
		return new BigInteger(sign * val.sign, Divide(mag, val.magnitude), checkMag: true);
	}

	public BigInteger[] DivideAndRemainder(BigInteger val)
	{
		if (val.sign == 0)
		{
			throw new ArithmeticException("Division by zero error");
		}
		BigInteger[] biggies = new BigInteger[2];
		if (sign == 0)
		{
			biggies[0] = Zero;
			biggies[1] = Zero;
		}
		else if (val.QuickPow2Check())
		{
			int e = val.Abs().BitLength - 1;
			BigInteger quotient = Abs().ShiftRight(e);
			int[] remainder = LastNBits(e);
			biggies[0] = ((val.sign == sign) ? quotient : quotient.Negate());
			biggies[1] = new BigInteger(sign, remainder, checkMag: true);
		}
		else
		{
			int[] remainder2 = (int[])magnitude.Clone();
			int[] quotient2 = Divide(remainder2, val.magnitude);
			biggies[0] = new BigInteger(sign * val.sign, quotient2, checkMag: true);
			biggies[1] = new BigInteger(sign, remainder2, checkMag: true);
		}
		return biggies;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is BigInteger biggie))
		{
			return false;
		}
		if (sign == biggie.sign)
		{
			return IsEqualMagnitude(biggie);
		}
		return false;
	}

	private bool IsEqualMagnitude(BigInteger x)
	{
		_ = x.magnitude;
		if (magnitude.Length != x.magnitude.Length)
		{
			return false;
		}
		for (int i = 0; i < magnitude.Length; i++)
		{
			if (magnitude[i] != x.magnitude[i])
			{
				return false;
			}
		}
		return true;
	}

	public BigInteger Gcd(BigInteger value)
	{
		if (value.sign == 0)
		{
			return Abs();
		}
		if (sign == 0)
		{
			return value.Abs();
		}
		BigInteger u = this;
		BigInteger v = value;
		while (v.sign != 0)
		{
			BigInteger bigInteger = u.Mod(v);
			u = v;
			v = bigInteger;
		}
		return u;
	}

	public override int GetHashCode()
	{
		int hc = magnitude.Length;
		if (magnitude.Length != 0)
		{
			hc ^= magnitude[0];
			if (magnitude.Length > 1)
			{
				hc ^= magnitude[magnitude.Length - 1];
			}
		}
		if (sign >= 0)
		{
			return hc;
		}
		return ~hc;
	}

	private BigInteger Inc()
	{
		if (sign == 0)
		{
			return One;
		}
		if (sign < 0)
		{
			return new BigInteger(-1, doSubBigLil(magnitude, One.magnitude), checkMag: true);
		}
		return AddToMagnitude(One.magnitude);
	}

	public bool IsProbablePrime(int certainty)
	{
		return IsProbablePrime(certainty, randomlySelected: false);
	}

	internal bool IsProbablePrime(int certainty, bool randomlySelected)
	{
		if (certainty <= 0)
		{
			return true;
		}
		BigInteger n = Abs();
		if (!n.TestBit(0))
		{
			return n.Equals(Two);
		}
		if (n.Equals(One))
		{
			return false;
		}
		return n.CheckProbablePrime(certainty, RandomSource, randomlySelected);
	}

	private bool CheckProbablePrime(int certainty, Random random, bool randomlySelected)
	{
		int numLists = System.Math.Min(BitLength - 1, primeLists.Length);
		for (int i = 0; i < numLists; i++)
		{
			int test = Remainder(primeProducts[i]);
			int[] primeList = primeLists[i];
			foreach (int prime in primeList)
			{
				if (test % prime == 0)
				{
					if (BitLength < 16)
					{
						return IntValue == prime;
					}
					return false;
				}
			}
		}
		return RabinMillerTest(certainty, random, randomlySelected);
	}

	public bool RabinMillerTest(int certainty, Random random)
	{
		return RabinMillerTest(certainty, random, randomlySelected: false);
	}

	internal bool RabinMillerTest(int certainty, Random random, bool randomlySelected)
	{
		int bits = BitLength;
		int iterations = (certainty - 1) / 2 + 1;
		if (randomlySelected)
		{
			int itersFor100Cert = ((bits >= 1024) ? 4 : ((bits >= 512) ? 8 : ((bits >= 256) ? 16 : 50)));
			if (certainty < 100)
			{
				iterations = System.Math.Min(itersFor100Cert, iterations);
			}
			else
			{
				iterations -= 50;
				iterations += itersFor100Cert;
			}
		}
		int s = GetLowestSetBitMaskFirst(-2);
		BigInteger r = ShiftRight(s);
		BigInteger montRadix = One.ShiftLeft(32 * magnitude.Length).Remainder(this);
		BigInteger minusMontRadix = Subtract(montRadix);
		while (true)
		{
			BigInteger a = new BigInteger(BitLength, random);
			if (a.sign == 0 || a.CompareTo(this) >= 0 || a.IsEqualMagnitude(montRadix) || a.IsEqualMagnitude(minusMontRadix))
			{
				continue;
			}
			BigInteger y = ModPowMonty(a, r, this, convert: false);
			if (!y.Equals(montRadix))
			{
				int j = 0;
				while (!y.Equals(minusMontRadix))
				{
					if (++j == s)
					{
						return false;
					}
					y = ModPowMonty(y, Two, this, convert: false);
					if (y.Equals(montRadix))
					{
						return false;
					}
				}
			}
			if (--iterations <= 0)
			{
				break;
			}
		}
		return true;
	}

	public BigInteger Max(BigInteger value)
	{
		if (CompareTo(value) <= 0)
		{
			return value;
		}
		return this;
	}

	public BigInteger Min(BigInteger value)
	{
		if (CompareTo(value) >= 0)
		{
			return value;
		}
		return this;
	}

	public BigInteger Mod(BigInteger m)
	{
		if (m.sign < 1)
		{
			throw new ArithmeticException("Modulus must be positive");
		}
		BigInteger biggie = Remainder(m);
		if (biggie.sign < 0)
		{
			return biggie.Add(m);
		}
		return biggie;
	}

	public BigInteger ModInverse(BigInteger m)
	{
		if (m.sign < 1)
		{
			throw new ArithmeticException("Modulus must be positive");
		}
		if (m.QuickPow2Check())
		{
			return ModInversePow2(m);
		}
		if (!ExtEuclid(Remainder(m), m, out var x).Equals(One))
		{
			throw new ArithmeticException("Numbers not relatively prime.");
		}
		if (x.sign < 0)
		{
			return x.Add(m);
		}
		return x;
	}

	private BigInteger ModInversePow2(BigInteger m)
	{
		if (!TestBit(0))
		{
			throw new ArithmeticException("Numbers not relatively prime.");
		}
		int pow = m.BitLength - 1;
		long inv64 = ModInverse64(LongValue);
		if (pow < 64)
		{
			inv64 &= (1L << pow) - 1;
		}
		BigInteger x = ValueOf(inv64);
		if (pow > 64)
		{
			BigInteger d = Remainder(m);
			int bitsCorrect = 64;
			do
			{
				BigInteger t = x.Multiply(d).Remainder(m);
				x = x.Multiply(Two.Subtract(t)).Remainder(m);
				bitsCorrect <<= 1;
			}
			while (bitsCorrect < pow);
		}
		if (x.sign < 0)
		{
			x = x.Add(m);
		}
		return x;
	}

	private static int ModInverse32(int d)
	{
		int x = d + (((d + 1) & 4) << 1);
		x *= 2 - d * x;
		x *= 2 - d * x;
		return x * (2 - d * x);
	}

	private static long ModInverse64(long d)
	{
		long x = d + (((d + 1) & 4) << 1);
		x *= 2 - d * x;
		x *= 2 - d * x;
		x *= 2 - d * x;
		return x * (2 - d * x);
	}

	private static BigInteger ExtEuclid(BigInteger a, BigInteger b, out BigInteger u1Out)
	{
		BigInteger u1 = One;
		BigInteger v1 = Zero;
		BigInteger u3 = a;
		BigInteger v3 = b;
		if (v3.sign > 0)
		{
			while (true)
			{
				BigInteger[] q = u3.DivideAndRemainder(v3);
				u3 = v3;
				v3 = q[1];
				BigInteger oldU1 = u1;
				u1 = v1;
				if (v3.sign <= 0)
				{
					break;
				}
				v1 = oldU1.Subtract(v1.Multiply(q[0]));
			}
		}
		u1Out = u1;
		return u3;
	}

	private static void ZeroOut(int[] x)
	{
		Array.Clear(x, 0, x.Length);
	}

	public BigInteger ModPow(BigInteger e, BigInteger m)
	{
		if (m.sign < 1)
		{
			throw new ArithmeticException("Modulus must be positive");
		}
		if (m.Equals(One))
		{
			return Zero;
		}
		if (e.sign == 0)
		{
			return One;
		}
		if (sign == 0)
		{
			return Zero;
		}
		bool num = e.sign < 0;
		if (num)
		{
			e = e.Negate();
		}
		BigInteger result = Mod(m);
		if (!e.Equals(One))
		{
			result = (((m.magnitude[m.magnitude.Length - 1] & 1) != 0) ? ModPowMonty(result, e, m, convert: true) : ModPowBarrett(result, e, m));
		}
		if (num)
		{
			result = result.ModInverse(m);
		}
		return result;
	}

	private static BigInteger ModPowBarrett(BigInteger b, BigInteger e, BigInteger m)
	{
		int k = m.magnitude.Length;
		BigInteger mr = One.ShiftLeft(k + 1 << 5);
		BigInteger yu = One.ShiftLeft(k << 6).Divide(m);
		int extraBits = 0;
		for (int expLength = e.BitLength; expLength > ExpWindowThresholds[extraBits]; extraBits++)
		{
		}
		int numPowers = 1 << extraBits;
		BigInteger[] oddPowers = new BigInteger[numPowers];
		oddPowers[0] = b;
		BigInteger b2 = ReduceBarrett(b.Square(), m, mr, yu);
		for (int i = 1; i < numPowers; i++)
		{
			oddPowers[i] = ReduceBarrett(oddPowers[i - 1].Multiply(b2), m, mr, yu);
		}
		int[] windowList = GetWindowList(e.magnitude, extraBits);
		int window = windowList[0];
		int mult = window & 0xFF;
		int lastZeroes = window >> 8;
		BigInteger y;
		if (mult == 1)
		{
			y = b2;
			lastZeroes--;
		}
		else
		{
			y = oddPowers[mult >> 1];
		}
		int windowPos = 1;
		while ((window = windowList[windowPos++]) != -1)
		{
			mult = window & 0xFF;
			int bits = lastZeroes + BitLengthTable[mult];
			for (int j = 0; j < bits; j++)
			{
				y = ReduceBarrett(y.Square(), m, mr, yu);
			}
			y = ReduceBarrett(y.Multiply(oddPowers[mult >> 1]), m, mr, yu);
			lastZeroes = window >> 8;
		}
		for (int l = 0; l < lastZeroes; l++)
		{
			y = ReduceBarrett(y.Square(), m, mr, yu);
		}
		return y;
	}

	private static BigInteger ReduceBarrett(BigInteger x, BigInteger m, BigInteger mr, BigInteger yu)
	{
		int xLen = x.BitLength;
		int mLen = m.BitLength;
		if (xLen < mLen)
		{
			return x;
		}
		if (xLen - mLen > 1)
		{
			int k = m.magnitude.Length;
			BigInteger bigInteger = x.DivideWords(k - 1).Multiply(yu).DivideWords(k + 1);
			BigInteger r1 = x.RemainderWords(k + 1);
			BigInteger r3 = bigInteger.Multiply(m).RemainderWords(k + 1);
			x = r1.Subtract(r3);
			if (x.sign < 0)
			{
				x = x.Add(mr);
			}
		}
		while (x.CompareTo(m) >= 0)
		{
			x = x.Subtract(m);
		}
		return x;
	}

	private static BigInteger ModPowMonty(BigInteger b, BigInteger e, BigInteger m, bool convert)
	{
		int n = m.magnitude.Length;
		int powR = 32 * n;
		bool smallMontyModulus = m.BitLength + 2 <= powR;
		uint mDash = (uint)m.GetMQuote();
		if (convert)
		{
			b = b.ShiftLeft(powR).Remainder(m);
		}
		int[] yAccum = new int[n + 1];
		int[] zVal = b.magnitude;
		if (zVal.Length < n)
		{
			int[] tmp = new int[n];
			zVal.CopyTo(tmp, n - zVal.Length);
			zVal = tmp;
		}
		int extraBits = 0;
		if (e.magnitude.Length > 1 || e.BitCount > 2)
		{
			for (int expLength = e.BitLength; expLength > ExpWindowThresholds[extraBits]; extraBits++)
			{
			}
		}
		int numPowers = 1 << extraBits;
		int[][] oddPowers = new int[numPowers][];
		oddPowers[0] = zVal;
		int[] zSquared = Arrays.Clone(zVal);
		SquareMonty(yAccum, zSquared, m.magnitude, mDash, smallMontyModulus);
		for (int i = 1; i < numPowers; i++)
		{
			oddPowers[i] = Arrays.Clone(oddPowers[i - 1]);
			MultiplyMonty(yAccum, oddPowers[i], zSquared, m.magnitude, mDash, smallMontyModulus);
		}
		int[] windowList = GetWindowList(e.magnitude, extraBits);
		int window = windowList[0];
		int mult = window & 0xFF;
		int lastZeroes = window >> 8;
		int[] yVal;
		if (mult == 1)
		{
			yVal = zSquared;
			lastZeroes--;
		}
		else
		{
			yVal = Arrays.Clone(oddPowers[mult >> 1]);
		}
		int windowPos = 1;
		while ((window = windowList[windowPos++]) != -1)
		{
			mult = window & 0xFF;
			int bits = lastZeroes + BitLengthTable[mult];
			for (int j = 0; j < bits; j++)
			{
				SquareMonty(yAccum, yVal, m.magnitude, mDash, smallMontyModulus);
			}
			MultiplyMonty(yAccum, yVal, oddPowers[mult >> 1], m.magnitude, mDash, smallMontyModulus);
			lastZeroes = window >> 8;
		}
		for (int k = 0; k < lastZeroes; k++)
		{
			SquareMonty(yAccum, yVal, m.magnitude, mDash, smallMontyModulus);
		}
		if (convert)
		{
			MontgomeryReduce(yVal, m.magnitude, mDash);
		}
		else if (smallMontyModulus && CompareTo(0, yVal, 0, m.magnitude) >= 0)
		{
			Subtract(0, yVal, 0, m.magnitude);
		}
		return new BigInteger(1, yVal, checkMag: true);
	}

	private static int[] GetWindowList(int[] mag, int extraBits)
	{
		int v = mag[0];
		int leadingBits = BitLen(v);
		int[] result = new int[((mag.Length - 1 << 5) + leadingBits) / (1 + extraBits) + 2];
		int resultPos = 0;
		int bitPos = 33 - leadingBits;
		v <<= bitPos;
		int mult = 1;
		int multLimit = 1 << extraBits;
		int zeroes = 0;
		int i = 0;
		while (true)
		{
			if (bitPos < 32)
			{
				if (mult < multLimit)
				{
					mult = (mult << 1) | (v >>> 31);
				}
				else if (v < 0)
				{
					result[resultPos++] = CreateWindowEntry(mult, zeroes);
					mult = 1;
					zeroes = 0;
				}
				else
				{
					zeroes++;
				}
				v <<= 1;
				bitPos++;
			}
			else
			{
				if (++i == mag.Length)
				{
					break;
				}
				v = mag[i];
				bitPos = 0;
			}
		}
		result[resultPos++] = CreateWindowEntry(mult, zeroes);
		result[resultPos] = -1;
		return result;
	}

	private static int CreateWindowEntry(int mult, int zeroes)
	{
		while ((mult & 1) == 0)
		{
			mult >>= 1;
			zeroes++;
		}
		return mult | (zeroes << 8);
	}

	private static int[] Square(int[] w, int[] x)
	{
		int wBase = w.Length - 1;
		ulong c;
		for (int i = x.Length - 1; i > 0; i--)
		{
			ulong v = (uint)x[i];
			c = v * v + (uint)w[wBase];
			w[wBase] = (int)c;
			c >>= 32;
			for (int j = i - 1; j >= 0; j--)
			{
				ulong prod = v * (uint)x[j];
				c += ((ulong)(uint)w[--wBase] & 0xFFFFFFFFuL) + (uint)((int)prod << 1);
				w[wBase] = (int)c;
				c = (c >> 32) + (prod >> 31);
			}
			c += (uint)w[--wBase];
			w[wBase] = (int)c;
			if (--wBase >= 0)
			{
				w[wBase] = (int)(c >> 32);
			}
			wBase += i;
		}
		c = (uint)x[0];
		c = c * c + (uint)w[wBase];
		w[wBase] = (int)c;
		if (--wBase >= 0)
		{
			w[wBase] += (int)(c >> 32);
		}
		return w;
	}

	private static int[] Multiply(int[] x, int[] y, int[] z)
	{
		int i = z.Length;
		if (i < 1)
		{
			return x;
		}
		int xBase = x.Length - y.Length;
		do
		{
			long a = z[--i] & 0xFFFFFFFFu;
			long val = 0L;
			if (a != 0L)
			{
				for (int j = y.Length - 1; j >= 0; j--)
				{
					val += a * (y[j] & 0xFFFFFFFFu) + (x[xBase + j] & 0xFFFFFFFFu);
					x[xBase + j] = (int)val;
					val >>>= 32;
				}
			}
			xBase--;
			if (xBase >= 0)
			{
				x[xBase] = (int)val;
			}
		}
		while (i > 0);
		return x;
	}

	private int GetMQuote()
	{
		if (mQuote != 0)
		{
			return mQuote;
		}
		int d = -magnitude[magnitude.Length - 1];
		return mQuote = ModInverse32(d);
	}

	private static void MontgomeryReduce(int[] x, int[] m, uint mDash)
	{
		int n = m.Length;
		for (int i = n - 1; i >= 0; i--)
		{
			uint x2 = (uint)x[n - 1];
			ulong t = x2 * mDash;
			ulong carry = t * (uint)m[n - 1] + x2;
			carry >>= 32;
			for (int j = n - 2; j >= 0; j--)
			{
				carry += t * (uint)m[j] + (uint)x[j];
				x[j + 1] = (int)carry;
				carry >>= 32;
			}
			x[0] = (int)carry;
		}
		if (CompareTo(0, x, 0, m) >= 0)
		{
			Subtract(0, x, 0, m);
		}
	}

	private static void MultiplyMonty(int[] a, int[] x, int[] y, int[] m, uint mDash, bool smallMontyModulus)
	{
		int n = m.Length;
		if (n == 1)
		{
			x[0] = (int)MultiplyMontyNIsOne((uint)x[0], (uint)y[0], (uint)m[0], mDash);
			return;
		}
		uint y2 = (uint)y[n - 1];
		ulong xi = (uint)x[n - 1];
		ulong carry = xi * y2;
		ulong t = (uint)(int)carry * mDash;
		ulong prod2 = t * (uint)m[n - 1];
		carry += (uint)prod2;
		carry = (carry >> 32) + (prod2 >> 32);
		for (int j = n - 2; j >= 0; j--)
		{
			ulong prod3 = xi * (uint)y[j];
			prod2 = t * (uint)m[j];
			carry += (prod3 & 0xFFFFFFFFu) + (uint)prod2;
			a[j + 2] = (int)carry;
			carry = (carry >> 32) + (prod3 >> 32) + (prod2 >> 32);
		}
		a[1] = (int)carry;
		int aMax = (int)(carry >> 32);
		for (int i = n - 2; i >= 0; i--)
		{
			uint a2 = (uint)a[n];
			ulong xi2 = (uint)x[i];
			ulong prod4 = xi2 * y2;
			ulong carry2 = (prod4 & 0xFFFFFFFFu) + a2;
			ulong t2 = (uint)(int)carry2 * mDash;
			ulong prod5 = t2 * (uint)m[n - 1];
			carry2 += (uint)prod5;
			carry2 = (carry2 >> 32) + (prod4 >> 32) + (prod5 >> 32);
			for (int j2 = n - 2; j2 >= 0; j2--)
			{
				prod4 = xi2 * (uint)y[j2];
				prod5 = t2 * (uint)m[j2];
				carry2 += (prod4 & 0xFFFFFFFFu) + (uint)prod5 + (uint)a[j2 + 1];
				a[j2 + 2] = (int)carry2;
				carry2 = (carry2 >> 32) + (prod4 >> 32) + (prod5 >> 32);
			}
			carry2 += (uint)aMax;
			a[1] = (int)carry2;
			aMax = (int)(carry2 >> 32);
		}
		a[0] = aMax;
		if (!smallMontyModulus && CompareTo(0, a, 0, m) >= 0)
		{
			Subtract(0, a, 0, m);
		}
		Array.Copy(a, 1, x, 0, n);
	}

	private static void SquareMonty(int[] a, int[] x, int[] m, uint mDash, bool smallMontyModulus)
	{
		int n = m.Length;
		if (n == 1)
		{
			uint xVal = (uint)x[0];
			x[0] = (int)MultiplyMontyNIsOne(xVal, xVal, (uint)m[0], mDash);
			return;
		}
		ulong x2 = (uint)x[n - 1];
		ulong carry = x2 * x2;
		ulong t = (uint)(int)carry * mDash;
		ulong prod2 = t * (uint)m[n - 1];
		carry += (uint)prod2;
		carry = (carry >> 32) + (prod2 >> 32);
		for (int j = n - 2; j >= 0; j--)
		{
			ulong prod3 = x2 * (uint)x[j];
			prod2 = t * (uint)m[j];
			carry += (prod2 & 0xFFFFFFFFu) + (uint)((int)prod3 << 1);
			a[j + 2] = (int)carry;
			carry = (carry >> 32) + (prod3 >> 31) + (prod2 >> 32);
		}
		a[1] = (int)carry;
		int aMax = (int)(carry >> 32);
		for (int i = n - 2; i >= 0; i--)
		{
			uint a2 = (uint)a[n];
			ulong t2 = a2 * mDash;
			ulong carry2 = t2 * (uint)m[n - 1] + a2;
			carry2 >>= 32;
			for (int j2 = n - 2; j2 > i; j2--)
			{
				carry2 += t2 * (uint)m[j2] + (uint)a[j2 + 1];
				a[j2 + 2] = (int)carry2;
				carry2 >>= 32;
			}
			ulong xi = (uint)x[i];
			ulong prod4 = xi * xi;
			ulong prod5 = t2 * (uint)m[i];
			carry2 += (prod4 & 0xFFFFFFFFu) + (uint)prod5 + (uint)a[i + 1];
			a[i + 2] = (int)carry2;
			carry2 = (carry2 >> 32) + (prod4 >> 32) + (prod5 >> 32);
			for (int j3 = i - 1; j3 >= 0; j3--)
			{
				ulong prod6 = xi * (uint)x[j3];
				ulong prod7 = t2 * (uint)m[j3];
				carry2 += (prod7 & 0xFFFFFFFFu) + (uint)((int)prod6 << 1) + (uint)a[j3 + 1];
				a[j3 + 2] = (int)carry2;
				carry2 = (carry2 >> 32) + (prod6 >> 31) + (prod7 >> 32);
			}
			carry2 += (uint)aMax;
			a[1] = (int)carry2;
			aMax = (int)(carry2 >> 32);
		}
		a[0] = aMax;
		if (!smallMontyModulus && CompareTo(0, a, 0, m) >= 0)
		{
			Subtract(0, a, 0, m);
		}
		Array.Copy(a, 1, x, 0, n);
	}

	private static uint MultiplyMontyNIsOne(uint x, uint y, uint m, uint mDash)
	{
		ulong carry = (ulong)x * (ulong)y;
		uint t = (uint)(int)carry * mDash;
		ulong um = m;
		ulong prod2 = um * t;
		carry += (uint)prod2;
		carry = (carry >> 32) + (prod2 >> 32);
		if (carry > um)
		{
			carry -= um;
		}
		return (uint)carry;
	}

	public BigInteger Multiply(BigInteger val)
	{
		if (val == this)
		{
			return Square();
		}
		if ((sign & val.sign) == 0)
		{
			return Zero;
		}
		if (val.QuickPow2Check())
		{
			BigInteger result = ShiftLeft(val.Abs().BitLength - 1);
			if (val.sign <= 0)
			{
				return result.Negate();
			}
			return result;
		}
		if (QuickPow2Check())
		{
			BigInteger result2 = val.ShiftLeft(Abs().BitLength - 1);
			if (sign <= 0)
			{
				return result2.Negate();
			}
			return result2;
		}
		int[] res = new int[magnitude.Length + val.magnitude.Length];
		Multiply(res, magnitude, val.magnitude);
		return new BigInteger(sign ^ val.sign ^ 1, res, checkMag: true);
	}

	public BigInteger Square()
	{
		if (sign == 0)
		{
			return Zero;
		}
		if (QuickPow2Check())
		{
			return ShiftLeft(Abs().BitLength - 1);
		}
		int resLength = magnitude.Length << 1;
		if (magnitude[0] >>> 16 == 0)
		{
			resLength--;
		}
		int[] res = new int[resLength];
		Square(res, magnitude);
		return new BigInteger(1, res, checkMag: false);
	}

	public BigInteger Negate()
	{
		if (sign == 0)
		{
			return this;
		}
		return new BigInteger(-sign, magnitude, checkMag: false);
	}

	public BigInteger NextProbablePrime()
	{
		if (sign < 0)
		{
			throw new ArithmeticException("Cannot be called on value < 0");
		}
		if (CompareTo(Two) < 0)
		{
			return Two;
		}
		BigInteger n = Inc().SetBit(0);
		while (!n.CheckProbablePrime(100, RandomSource, randomlySelected: false))
		{
			n = n.Add(Two);
		}
		return n;
	}

	public BigInteger Not()
	{
		return Inc().Negate();
	}

	public BigInteger Pow(int exp)
	{
		if (exp <= 0)
		{
			if (exp < 0)
			{
				throw new ArithmeticException("Negative exponent");
			}
			return One;
		}
		if (sign == 0)
		{
			return this;
		}
		if (QuickPow2Check())
		{
			long powOf2 = (long)exp * (long)(BitLength - 1);
			if (powOf2 > int.MaxValue)
			{
				throw new ArithmeticException("Result too large");
			}
			return One.ShiftLeft((int)powOf2);
		}
		BigInteger y = One;
		BigInteger z = this;
		while (true)
		{
			if ((exp & 1) == 1)
			{
				y = y.Multiply(z);
			}
			exp >>= 1;
			if (exp == 0)
			{
				break;
			}
			z = z.Multiply(z);
		}
		return y;
	}

	public static BigInteger ProbablePrime(int bitLength, Random random)
	{
		return new BigInteger(bitLength, 100, random);
	}

	private int Remainder(int m)
	{
		long acc = 0L;
		for (int pos = 0; pos < magnitude.Length; pos++)
		{
			long posVal = (uint)magnitude[pos];
			acc = ((acc << 32) | posVal) % m;
		}
		return (int)acc;
	}

	private static int[] Remainder(int[] x, int[] y)
	{
		int xStart;
		for (xStart = 0; xStart < x.Length && x[xStart] == 0; xStart++)
		{
		}
		int yStart;
		for (yStart = 0; yStart < y.Length && y[yStart] == 0; yStart++)
		{
		}
		int xyCmp = CompareNoLeadingZeroes(xStart, x, yStart, y);
		if (xyCmp > 0)
		{
			int yBitLength = CalcBitLength(1, yStart, y);
			int xBitLength = CalcBitLength(1, xStart, x);
			int shift = xBitLength - yBitLength;
			int cStart = 0;
			int cBitLength = yBitLength;
			int[] c;
			if (shift > 0)
			{
				c = ShiftLeft(y, shift);
				cBitLength += shift;
			}
			else
			{
				int len = y.Length - yStart;
				c = new int[len];
				Array.Copy(y, yStart, c, 0, len);
			}
			while (true)
			{
				if (cBitLength < xBitLength || CompareNoLeadingZeroes(xStart, x, cStart, c) >= 0)
				{
					Subtract(xStart, x, cStart, c);
					while (x[xStart] == 0)
					{
						if (++xStart == x.Length)
						{
							return x;
						}
					}
					xBitLength = 32 * (x.Length - xStart - 1) + BitLen(x[xStart]);
					if (xBitLength <= yBitLength)
					{
						if (xBitLength < yBitLength)
						{
							return x;
						}
						xyCmp = CompareNoLeadingZeroes(xStart, x, yStart, y);
						if (xyCmp <= 0)
						{
							break;
						}
					}
				}
				shift = cBitLength - xBitLength;
				if (shift == 1)
				{
					int num = c[cStart] >>> 1;
					uint firstX = (uint)x[xStart];
					if ((uint)num > firstX)
					{
						shift++;
					}
				}
				if (shift < 2)
				{
					ShiftRightOneInPlace(cStart, c);
					cBitLength--;
				}
				else
				{
					ShiftRightInPlace(cStart, c, shift);
					cBitLength -= shift;
				}
				for (; c[cStart] == 0; cStart++)
				{
				}
			}
		}
		if (xyCmp == 0)
		{
			Array.Clear(x, xStart, x.Length - xStart);
		}
		return x;
	}

	public BigInteger Remainder(BigInteger n)
	{
		if (n.sign == 0)
		{
			throw new ArithmeticException("Division by zero error");
		}
		if (sign == 0)
		{
			return Zero;
		}
		if (n.magnitude.Length == 1)
		{
			int val = n.magnitude[0];
			if (val > 0)
			{
				if (val == 1)
				{
					return Zero;
				}
				int rem = Remainder(val);
				if (rem != 0)
				{
					return new BigInteger(sign, new int[1] { rem }, checkMag: false);
				}
				return Zero;
			}
		}
		if (CompareNoLeadingZeroes(0, magnitude, 0, n.magnitude) < 0)
		{
			return this;
		}
		int[] result;
		if (n.QuickPow2Check())
		{
			result = LastNBits(n.Abs().BitLength - 1);
		}
		else
		{
			result = (int[])magnitude.Clone();
			result = Remainder(result, n.magnitude);
		}
		return new BigInteger(sign, result, checkMag: true);
	}

	private int[] LastNBits(int n)
	{
		if (n < 1)
		{
			return ZeroMagnitude;
		}
		int numWords = (n + 32 - 1) / 32;
		numWords = System.Math.Min(numWords, magnitude.Length);
		int[] result = new int[numWords];
		Array.Copy(magnitude, magnitude.Length - numWords, result, 0, numWords);
		int excessBits = (numWords << 5) - n;
		if (excessBits > 0)
		{
			result[0] &= -1 >>> excessBits;
		}
		return result;
	}

	private BigInteger DivideWords(int w)
	{
		int n = magnitude.Length;
		if (w >= n)
		{
			return Zero;
		}
		int[] mag = new int[n - w];
		Array.Copy(magnitude, 0, mag, 0, n - w);
		return new BigInteger(sign, mag, checkMag: false);
	}

	private BigInteger RemainderWords(int w)
	{
		int n = magnitude.Length;
		if (w >= n)
		{
			return this;
		}
		int[] mag = new int[w];
		Array.Copy(magnitude, n - w, mag, 0, w);
		return new BigInteger(sign, mag, checkMag: false);
	}

	private static int[] ShiftLeft(int[] mag, int n)
	{
		int nInts = n >>> 5;
		int nBits = n & 0x1F;
		int magLen = mag.Length;
		int[] newMag;
		if (nBits == 0)
		{
			newMag = new int[magLen + nInts];
			mag.CopyTo(newMag, 0);
		}
		else
		{
			int i = 0;
			int nBits2 = 32 - nBits;
			int highBits = mag[0] >>> nBits2;
			if (highBits != 0)
			{
				newMag = new int[magLen + nInts + 1];
				newMag[i++] = highBits;
			}
			else
			{
				newMag = new int[magLen + nInts];
			}
			int m = mag[0];
			for (int j = 0; j < magLen - 1; j++)
			{
				int next = mag[j + 1];
				newMag[i++] = (m << nBits) | (next >>> nBits2);
				m = next;
			}
			newMag[i] = mag[magLen - 1] << nBits;
		}
		return newMag;
	}

	private static int ShiftLeftOneInPlace(int[] x, int carry)
	{
		int pos = x.Length;
		while (--pos >= 0)
		{
			uint val = (uint)x[pos];
			x[pos] = (int)(val << 1) | carry;
			carry = (int)(val >> 31);
		}
		return carry;
	}

	public BigInteger ShiftLeft(int n)
	{
		if (sign == 0 || magnitude.Length == 0)
		{
			return Zero;
		}
		if (n == 0)
		{
			return this;
		}
		if (n < 0)
		{
			return ShiftRight(-n);
		}
		BigInteger result = new BigInteger(sign, ShiftLeft(magnitude, n), checkMag: true);
		if (nBits != -1)
		{
			result.nBits = ((sign > 0) ? nBits : (nBits + n));
		}
		if (nBitLength != -1)
		{
			result.nBitLength = nBitLength + n;
		}
		return result;
	}

	private static void ShiftRightInPlace(int start, int[] mag, int n)
	{
		int nInts = (n >>> 5) + start;
		int nBits = n & 0x1F;
		int magEnd = mag.Length - 1;
		if (nInts != start)
		{
			int delta = nInts - start;
			for (int i = magEnd; i >= nInts; i--)
			{
				mag[i] = mag[i - delta];
			}
			for (int i2 = nInts - 1; i2 >= start; i2--)
			{
				mag[i2] = 0;
			}
		}
		if (nBits != 0)
		{
			int nBits2 = 32 - nBits;
			int m = mag[magEnd];
			for (int i3 = magEnd; i3 > nInts; i3--)
			{
				int next = mag[i3 - 1];
				mag[i3] = (m >>> nBits) | (next << nBits2);
				m = next;
			}
			mag[nInts] >>>= nBits;
		}
	}

	private static void ShiftRightOneInPlace(int start, int[] mag)
	{
		int i = mag.Length;
		int m = mag[i - 1];
		while (--i > start)
		{
			int next = mag[i - 1];
			mag[i] = (m >>> 1) | (next << 31);
			m = next;
		}
		mag[start] >>>= 1;
	}

	public BigInteger ShiftRight(int n)
	{
		if (n == 0)
		{
			return this;
		}
		if (n < 0)
		{
			return ShiftLeft(-n);
		}
		if (n >= BitLength)
		{
			if (sign >= 0)
			{
				return Zero;
			}
			return One.Negate();
		}
		int resultLength = BitLength - n + 31 >> 5;
		int[] res = new int[resultLength];
		int numInts = n >> 5;
		int numBits = n & 0x1F;
		if (numBits == 0)
		{
			Array.Copy(magnitude, 0, res, 0, res.Length);
		}
		else
		{
			int numBits2 = 32 - numBits;
			int magPos = magnitude.Length - 1 - numInts;
			for (int i = resultLength - 1; i >= 0; i--)
			{
				res[i] = magnitude[magPos--] >>> numBits;
				if (magPos >= 0)
				{
					res[i] |= magnitude[magPos] << numBits2;
				}
			}
		}
		return new BigInteger(sign, res, checkMag: false);
	}

	private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
	{
		int iT = x.Length;
		int iV = y.Length;
		int borrow = 0;
		do
		{
			long m = (x[--iT] & 0xFFFFFFFFu) - (y[--iV] & 0xFFFFFFFFu) + borrow;
			x[iT] = (int)m;
			borrow = (int)(m >> 63);
		}
		while (iV > yStart);
		if (borrow != 0)
		{
			while (--x[--iT] == -1)
			{
			}
		}
		return x;
	}

	public BigInteger Subtract(BigInteger n)
	{
		if (n.sign == 0)
		{
			return this;
		}
		if (sign == 0)
		{
			return n.Negate();
		}
		if (sign != n.sign)
		{
			return Add(n.Negate());
		}
		int compare = CompareNoLeadingZeroes(0, magnitude, 0, n.magnitude);
		if (compare == 0)
		{
			return Zero;
		}
		BigInteger bigun;
		BigInteger lilun;
		if (compare < 0)
		{
			bigun = n;
			lilun = this;
		}
		else
		{
			bigun = this;
			lilun = n;
		}
		return new BigInteger(sign * compare, doSubBigLil(bigun.magnitude, lilun.magnitude), checkMag: true);
	}

	private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
	{
		int[] res = (int[])bigMag.Clone();
		return Subtract(0, res, 0, lilMag);
	}

	public byte[] ToByteArray()
	{
		return ToByteArray(unsigned: false);
	}

	public byte[] ToByteArrayUnsigned()
	{
		return ToByteArray(unsigned: true);
	}

	private byte[] ToByteArray(bool unsigned)
	{
		if (sign == 0)
		{
			if (!unsigned)
			{
				return new byte[1];
			}
			return ZeroEncoding;
		}
		byte[] bytes = new byte[GetByteLength((unsigned && sign > 0) ? BitLength : (BitLength + 1))];
		int magIndex = magnitude.Length;
		int bytesIndex = bytes.Length;
		if (sign > 0)
		{
			while (magIndex > 1)
			{
				uint mag = (uint)magnitude[--magIndex];
				bytes[--bytesIndex] = (byte)mag;
				bytes[--bytesIndex] = (byte)(mag >> 8);
				bytes[--bytesIndex] = (byte)(mag >> 16);
				bytes[--bytesIndex] = (byte)(mag >> 24);
			}
			uint lastMag;
			for (lastMag = (uint)magnitude[0]; lastMag > 255; lastMag >>= 8)
			{
				bytes[--bytesIndex] = (byte)lastMag;
			}
			bytes[--bytesIndex] = (byte)lastMag;
		}
		else
		{
			bool carry = true;
			while (magIndex > 1)
			{
				uint mag2 = (uint)(~magnitude[--magIndex]);
				if (carry)
				{
					carry = ++mag2 == 0;
				}
				bytes[--bytesIndex] = (byte)mag2;
				bytes[--bytesIndex] = (byte)(mag2 >> 8);
				bytes[--bytesIndex] = (byte)(mag2 >> 16);
				bytes[--bytesIndex] = (byte)(mag2 >> 24);
			}
			uint lastMag2 = (uint)magnitude[0];
			if (carry)
			{
				lastMag2--;
			}
			while (lastMag2 > 255)
			{
				bytes[--bytesIndex] = (byte)(~lastMag2);
				lastMag2 >>= 8;
			}
			bytes[--bytesIndex] = (byte)(~lastMag2);
			if (bytesIndex > 0)
			{
				bytes[--bytesIndex] = byte.MaxValue;
			}
		}
		return bytes;
	}

	public override string ToString()
	{
		return ToString(10);
	}

	public string ToString(int radix)
	{
		switch (radix)
		{
		default:
			throw new FormatException("Only bases 2, 8, 10, 16 are allowed");
		case 2:
		case 8:
		case 10:
		case 16:
		{
			if (magnitude == null)
			{
				return "null";
			}
			if (sign == 0)
			{
				return "0";
			}
			int firstNonZero;
			for (firstNonZero = 0; firstNonZero < magnitude.Length && magnitude[firstNonZero] == 0; firstNonZero++)
			{
			}
			if (firstNonZero == magnitude.Length)
			{
				return "0";
			}
			StringBuilder sb = new StringBuilder();
			if (sign == -1)
			{
				sb.Append('-');
			}
			switch (radix)
			{
			case 2:
			{
				int pos2 = firstNonZero;
				sb.Append(Convert.ToString(magnitude[pos2], 2));
				while (++pos2 < magnitude.Length)
				{
					AppendZeroExtendedString(sb, Convert.ToString(magnitude[pos2], 2), 32);
				}
				break;
			}
			case 8:
			{
				int mask = 1073741823;
				BigInteger u = Abs();
				int bits = u.BitLength;
				IList S = Platform.CreateArrayList();
				while (bits > 30)
				{
					S.Add(Convert.ToString(u.IntValue & mask, 8));
					u = u.ShiftRight(30);
					bits -= 30;
				}
				sb.Append(Convert.ToString(u.IntValue, 8));
				for (int i = S.Count - 1; i >= 0; i--)
				{
					AppendZeroExtendedString(sb, (string)S[i], 10);
				}
				break;
			}
			case 16:
			{
				int pos = firstNonZero;
				sb.Append(Convert.ToString(magnitude[pos], 16));
				while (++pos < magnitude.Length)
				{
					AppendZeroExtendedString(sb, Convert.ToString(magnitude[pos], 16), 8);
				}
				break;
			}
			case 10:
			{
				BigInteger q = Abs();
				if (q.BitLength < 64)
				{
					sb.Append(Convert.ToString(q.LongValue, radix));
					break;
				}
				IList moduli = Platform.CreateArrayList();
				BigInteger R = ValueOf(radix);
				while (R.CompareTo(q) <= 0)
				{
					moduli.Add(R);
					R = R.Square();
				}
				int scale = moduli.Count;
				sb.EnsureCapacity(sb.Length + (1 << scale));
				ToString(sb, radix, moduli, scale, q);
				break;
			}
			}
			return sb.ToString();
		}
		}
	}

	private static void ToString(StringBuilder sb, int radix, IList moduli, int scale, BigInteger pos)
	{
		if (pos.BitLength < 64)
		{
			string s = Convert.ToString(pos.LongValue, radix);
			if (sb.Length > 1 || (sb.Length == 1 && sb[0] != '-'))
			{
				AppendZeroExtendedString(sb, s, 1 << scale);
			}
			else if (pos.SignValue != 0)
			{
				sb.Append(s);
			}
		}
		else
		{
			BigInteger[] qr = pos.DivideAndRemainder((BigInteger)moduli[--scale]);
			ToString(sb, radix, moduli, scale, qr[0]);
			ToString(sb, radix, moduli, scale, qr[1]);
		}
	}

	private static void AppendZeroExtendedString(StringBuilder sb, string s, int minLength)
	{
		for (int len = s.Length; len < minLength; len++)
		{
			sb.Append('0');
		}
		sb.Append(s);
	}

	private static BigInteger CreateUValueOf(ulong value)
	{
		int msw = (int)(value >> 32);
		int lsw = (int)value;
		if (msw != 0)
		{
			return new BigInteger(1, new int[2] { msw, lsw }, checkMag: false);
		}
		if (lsw != 0)
		{
			BigInteger n = new BigInteger(1, new int[1] { lsw }, checkMag: false);
			if ((lsw & -lsw) == lsw)
			{
				n.nBits = 1;
			}
			return n;
		}
		return Zero;
	}

	private static BigInteger CreateValueOf(long value)
	{
		if (value < 0)
		{
			if (value == long.MinValue)
			{
				return CreateValueOf(~value).Not();
			}
			return CreateValueOf(-value).Negate();
		}
		return CreateUValueOf((ulong)value);
	}

	public static BigInteger ValueOf(long value)
	{
		if (value >= 0 && value < SMALL_CONSTANTS.Length)
		{
			return SMALL_CONSTANTS[value];
		}
		return CreateValueOf(value);
	}

	public int GetLowestSetBit()
	{
		if (sign == 0)
		{
			return -1;
		}
		return GetLowestSetBitMaskFirst(-1);
	}

	private int GetLowestSetBitMaskFirst(int firstWordMask)
	{
		int w = magnitude.Length;
		int offset = 0;
		uint word = (uint)(magnitude[--w] & firstWordMask);
		while (word == 0)
		{
			word = (uint)magnitude[--w];
			offset += 32;
		}
		while ((word & 0xFF) == 0)
		{
			word >>= 8;
			offset += 8;
		}
		while ((word & 1) == 0)
		{
			word >>= 1;
			offset++;
		}
		return offset;
	}

	public bool TestBit(int n)
	{
		if (n < 0)
		{
			throw new ArithmeticException("Bit position must not be negative");
		}
		if (sign < 0)
		{
			return !Not().TestBit(n);
		}
		int wordNum = n / 32;
		if (wordNum >= magnitude.Length)
		{
			return false;
		}
		return ((magnitude[magnitude.Length - 1 - wordNum] >> n % 32) & 1) > 0;
	}

	public BigInteger Or(BigInteger value)
	{
		if (sign == 0)
		{
			return value;
		}
		if (value.sign == 0)
		{
			return this;
		}
		int[] aMag = ((sign > 0) ? magnitude : Add(One).magnitude);
		int[] bMag = ((value.sign > 0) ? value.magnitude : value.Add(One).magnitude);
		bool resultNeg = sign < 0 || value.sign < 0;
		int[] resultMag = new int[System.Math.Max(aMag.Length, bMag.Length)];
		int aStart = resultMag.Length - aMag.Length;
		int bStart = resultMag.Length - bMag.Length;
		for (int i = 0; i < resultMag.Length; i++)
		{
			int aWord = ((i >= aStart) ? aMag[i - aStart] : 0);
			int bWord = ((i >= bStart) ? bMag[i - bStart] : 0);
			if (sign < 0)
			{
				aWord = ~aWord;
			}
			if (value.sign < 0)
			{
				bWord = ~bWord;
			}
			resultMag[i] = aWord | bWord;
			if (resultNeg)
			{
				resultMag[i] = ~resultMag[i];
			}
		}
		BigInteger result = new BigInteger(1, resultMag, checkMag: true);
		if (resultNeg)
		{
			result = result.Not();
		}
		return result;
	}

	public BigInteger Xor(BigInteger value)
	{
		if (sign == 0)
		{
			return value;
		}
		if (value.sign == 0)
		{
			return this;
		}
		int[] aMag = ((sign > 0) ? magnitude : Add(One).magnitude);
		int[] bMag = ((value.sign > 0) ? value.magnitude : value.Add(One).magnitude);
		bool resultNeg = (sign < 0 && value.sign >= 0) || (sign >= 0 && value.sign < 0);
		int[] resultMag = new int[System.Math.Max(aMag.Length, bMag.Length)];
		int aStart = resultMag.Length - aMag.Length;
		int bStart = resultMag.Length - bMag.Length;
		for (int i = 0; i < resultMag.Length; i++)
		{
			int aWord = ((i >= aStart) ? aMag[i - aStart] : 0);
			int bWord = ((i >= bStart) ? bMag[i - bStart] : 0);
			if (sign < 0)
			{
				aWord = ~aWord;
			}
			if (value.sign < 0)
			{
				bWord = ~bWord;
			}
			resultMag[i] = aWord ^ bWord;
			if (resultNeg)
			{
				resultMag[i] = ~resultMag[i];
			}
		}
		BigInteger result = new BigInteger(1, resultMag, checkMag: true);
		if (resultNeg)
		{
			result = result.Not();
		}
		return result;
	}

	public BigInteger SetBit(int n)
	{
		if (n < 0)
		{
			throw new ArithmeticException("Bit address less than zero");
		}
		if (TestBit(n))
		{
			return this;
		}
		if (sign > 0 && n < BitLength - 1)
		{
			return FlipExistingBit(n);
		}
		return Or(One.ShiftLeft(n));
	}

	public BigInteger ClearBit(int n)
	{
		if (n < 0)
		{
			throw new ArithmeticException("Bit address less than zero");
		}
		if (!TestBit(n))
		{
			return this;
		}
		if (sign > 0 && n < BitLength - 1)
		{
			return FlipExistingBit(n);
		}
		return AndNot(One.ShiftLeft(n));
	}

	public BigInteger FlipBit(int n)
	{
		if (n < 0)
		{
			throw new ArithmeticException("Bit address less than zero");
		}
		if (sign > 0 && n < BitLength - 1)
		{
			return FlipExistingBit(n);
		}
		return Xor(One.ShiftLeft(n));
	}

	private BigInteger FlipExistingBit(int n)
	{
		int[] mag = (int[])magnitude.Clone();
		mag[mag.Length - 1 - (n >> 5)] ^= 1 << n;
		return new BigInteger(sign, mag, checkMag: false);
	}
}
