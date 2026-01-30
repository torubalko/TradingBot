using System;
using System.Text;

namespace Org.BouncyCastle.Math.EC.Abc;

internal class SimpleBigDecimal
{
	private readonly BigInteger bigInt;

	private readonly int scale;

	public int IntValue => Floor().IntValue;

	public long LongValue => Floor().LongValue;

	public int Scale => scale;

	public static SimpleBigDecimal GetInstance(BigInteger val, int scale)
	{
		return new SimpleBigDecimal(val.ShiftLeft(scale), scale);
	}

	public SimpleBigDecimal(BigInteger bigInt, int scale)
	{
		if (scale < 0)
		{
			throw new ArgumentException("scale may not be negative");
		}
		this.bigInt = bigInt;
		this.scale = scale;
	}

	private SimpleBigDecimal(SimpleBigDecimal limBigDec)
	{
		bigInt = limBigDec.bigInt;
		scale = limBigDec.scale;
	}

	private void CheckScale(SimpleBigDecimal b)
	{
		if (scale != b.scale)
		{
			throw new ArgumentException("Only SimpleBigDecimal of same scale allowed in arithmetic operations");
		}
	}

	public SimpleBigDecimal AdjustScale(int newScale)
	{
		if (newScale < 0)
		{
			throw new ArgumentException("scale may not be negative");
		}
		if (newScale == scale)
		{
			return this;
		}
		return new SimpleBigDecimal(bigInt.ShiftLeft(newScale - scale), newScale);
	}

	public SimpleBigDecimal Add(SimpleBigDecimal b)
	{
		CheckScale(b);
		return new SimpleBigDecimal(bigInt.Add(b.bigInt), scale);
	}

	public SimpleBigDecimal Add(BigInteger b)
	{
		return new SimpleBigDecimal(bigInt.Add(b.ShiftLeft(scale)), scale);
	}

	public SimpleBigDecimal Negate()
	{
		return new SimpleBigDecimal(bigInt.Negate(), scale);
	}

	public SimpleBigDecimal Subtract(SimpleBigDecimal b)
	{
		return Add(b.Negate());
	}

	public SimpleBigDecimal Subtract(BigInteger b)
	{
		return new SimpleBigDecimal(bigInt.Subtract(b.ShiftLeft(scale)), scale);
	}

	public SimpleBigDecimal Multiply(SimpleBigDecimal b)
	{
		CheckScale(b);
		return new SimpleBigDecimal(bigInt.Multiply(b.bigInt), scale + scale);
	}

	public SimpleBigDecimal Multiply(BigInteger b)
	{
		return new SimpleBigDecimal(bigInt.Multiply(b), scale);
	}

	public SimpleBigDecimal Divide(SimpleBigDecimal b)
	{
		CheckScale(b);
		return new SimpleBigDecimal(bigInt.ShiftLeft(scale).Divide(b.bigInt), scale);
	}

	public SimpleBigDecimal Divide(BigInteger b)
	{
		return new SimpleBigDecimal(bigInt.Divide(b), scale);
	}

	public SimpleBigDecimal ShiftLeft(int n)
	{
		return new SimpleBigDecimal(bigInt.ShiftLeft(n), scale);
	}

	public int CompareTo(SimpleBigDecimal val)
	{
		CheckScale(val);
		return bigInt.CompareTo(val.bigInt);
	}

	public int CompareTo(BigInteger val)
	{
		return bigInt.CompareTo(val.ShiftLeft(scale));
	}

	public BigInteger Floor()
	{
		return bigInt.ShiftRight(scale);
	}

	public BigInteger Round()
	{
		SimpleBigDecimal oneHalf = new SimpleBigDecimal(BigInteger.One, 1);
		return Add(oneHalf.AdjustScale(scale)).Floor();
	}

	public override string ToString()
	{
		if (scale == 0)
		{
			return bigInt.ToString();
		}
		BigInteger floorBigInt = Floor();
		BigInteger fract = bigInt.Subtract(floorBigInt.ShiftLeft(scale));
		if (bigInt.SignValue < 0)
		{
			fract = BigInteger.One.ShiftLeft(scale).Subtract(fract);
		}
		if (floorBigInt.SignValue == -1 && !fract.Equals(BigInteger.Zero))
		{
			floorBigInt = floorBigInt.Add(BigInteger.One);
		}
		string leftOfPoint = floorBigInt.ToString();
		char[] fractCharArr = new char[scale];
		string fractStr = fract.ToString(2);
		int fractLen = fractStr.Length;
		int zeroes = scale - fractLen;
		for (int i = 0; i < zeroes; i++)
		{
			fractCharArr[i] = '0';
		}
		for (int j = 0; j < fractLen; j++)
		{
			fractCharArr[zeroes + j] = fractStr[j];
		}
		string rightOfPoint = new string(fractCharArr);
		StringBuilder stringBuilder = new StringBuilder(leftOfPoint);
		stringBuilder.Append(".");
		stringBuilder.Append(rightOfPoint);
		return stringBuilder.ToString();
	}

	public override bool Equals(object obj)
	{
		if (this == obj)
		{
			return true;
		}
		if (!(obj is SimpleBigDecimal other))
		{
			return false;
		}
		if (bigInt.Equals(other.bigInt))
		{
			return scale == other.scale;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return bigInt.GetHashCode() ^ scale;
	}
}
