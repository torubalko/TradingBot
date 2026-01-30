using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC;

public class FpFieldElement : AbstractFpFieldElement
{
	private readonly BigInteger q;

	private readonly BigInteger r;

	private readonly BigInteger x;

	public override string FieldName => "Fp";

	public override int FieldSize => q.BitLength;

	public BigInteger Q => q;

	internal static BigInteger CalculateResidue(BigInteger p)
	{
		int bitLength = p.BitLength;
		if (bitLength >= 96)
		{
			if (p.ShiftRight(bitLength - 64).LongValue == -1)
			{
				return BigInteger.One.ShiftLeft(bitLength).Subtract(p);
			}
			if ((bitLength & 7) == 0)
			{
				return BigInteger.One.ShiftLeft(bitLength << 1).Divide(p).Negate();
			}
		}
		return null;
	}

	[Obsolete("Use ECCurve.FromBigInteger to construct field elements")]
	public FpFieldElement(BigInteger q, BigInteger x)
		: this(q, CalculateResidue(q), x)
	{
	}

	internal FpFieldElement(BigInteger q, BigInteger r, BigInteger x)
	{
		if (x == null || x.SignValue < 0 || x.CompareTo(q) >= 0)
		{
			throw new ArgumentException("value invalid in Fp field element", "x");
		}
		this.q = q;
		this.r = r;
		this.x = x;
	}

	public override BigInteger ToBigInteger()
	{
		return x;
	}

	public override ECFieldElement Add(ECFieldElement b)
	{
		return new FpFieldElement(q, r, ModAdd(x, b.ToBigInteger()));
	}

	public override ECFieldElement AddOne()
	{
		BigInteger x2 = x.Add(BigInteger.One);
		if (x2.CompareTo(q) == 0)
		{
			x2 = BigInteger.Zero;
		}
		return new FpFieldElement(q, r, x2);
	}

	public override ECFieldElement Subtract(ECFieldElement b)
	{
		return new FpFieldElement(q, r, ModSubtract(x, b.ToBigInteger()));
	}

	public override ECFieldElement Multiply(ECFieldElement b)
	{
		return new FpFieldElement(q, r, ModMult(x, b.ToBigInteger()));
	}

	public override ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
	{
		BigInteger ax = this.x;
		BigInteger bx = b.ToBigInteger();
		BigInteger bigInteger = x.ToBigInteger();
		BigInteger yx = y.ToBigInteger();
		BigInteger ab = ax.Multiply(bx);
		BigInteger xy = bigInteger.Multiply(yx);
		return new FpFieldElement(q, r, ModReduce(ab.Subtract(xy)));
	}

	public override ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
	{
		BigInteger bigInteger = this.x;
		BigInteger bx = b.ToBigInteger();
		BigInteger xx = x.ToBigInteger();
		BigInteger yx = y.ToBigInteger();
		BigInteger bigInteger2 = bigInteger.Multiply(bx);
		BigInteger xy = xx.Multiply(yx);
		BigInteger sum = bigInteger2.Add(xy);
		if (r != null && r.SignValue < 0 && sum.BitLength > q.BitLength << 1)
		{
			sum = sum.Subtract(q.ShiftLeft(q.BitLength));
		}
		return new FpFieldElement(q, r, ModReduce(sum));
	}

	public override ECFieldElement Divide(ECFieldElement b)
	{
		return new FpFieldElement(q, r, ModMult(x, ModInverse(b.ToBigInteger())));
	}

	public override ECFieldElement Negate()
	{
		if (x.SignValue != 0)
		{
			return new FpFieldElement(q, r, q.Subtract(x));
		}
		return this;
	}

	public override ECFieldElement Square()
	{
		return new FpFieldElement(q, r, ModMult(x, x));
	}

	public override ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
	{
		BigInteger bigInteger = this.x;
		BigInteger xx = x.ToBigInteger();
		BigInteger yx = y.ToBigInteger();
		BigInteger aa = bigInteger.Multiply(bigInteger);
		BigInteger xy = xx.Multiply(yx);
		return new FpFieldElement(q, r, ModReduce(aa.Subtract(xy)));
	}

	public override ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
	{
		BigInteger bigInteger = this.x;
		BigInteger xx = x.ToBigInteger();
		BigInteger yx = y.ToBigInteger();
		BigInteger bigInteger2 = bigInteger.Multiply(bigInteger);
		BigInteger xy = xx.Multiply(yx);
		BigInteger sum = bigInteger2.Add(xy);
		if (r != null && r.SignValue < 0 && sum.BitLength > q.BitLength << 1)
		{
			sum = sum.Subtract(q.ShiftLeft(q.BitLength));
		}
		return new FpFieldElement(q, r, ModReduce(sum));
	}

	public override ECFieldElement Invert()
	{
		return new FpFieldElement(q, r, ModInverse(x));
	}

	public override ECFieldElement Sqrt()
	{
		if (IsZero || IsOne)
		{
			return this;
		}
		if (!q.TestBit(0))
		{
			throw Platform.CreateNotImplementedException("even value of q");
		}
		if (q.TestBit(1))
		{
			BigInteger e = q.ShiftRight(2).Add(BigInteger.One);
			return CheckSqrt(new FpFieldElement(q, r, x.ModPow(e, q)));
		}
		if (q.TestBit(2))
		{
			BigInteger t1 = x.ModPow(q.ShiftRight(3), q);
			BigInteger t2 = ModMult(t1, x);
			if (ModMult(t2, t1).Equals(BigInteger.One))
			{
				return CheckSqrt(new FpFieldElement(q, r, t2));
			}
			BigInteger t4 = BigInteger.Two.ModPow(q.ShiftRight(2), q);
			BigInteger y = ModMult(t2, t4);
			return CheckSqrt(new FpFieldElement(q, r, y));
		}
		BigInteger legendreExponent = q.ShiftRight(1);
		if (!x.ModPow(legendreExponent, q).Equals(BigInteger.One))
		{
			return null;
		}
		BigInteger X = x;
		BigInteger fourX = ModDouble(ModDouble(X));
		BigInteger k = legendreExponent.Add(BigInteger.One);
		BigInteger qMinusOne = q.Subtract(BigInteger.One);
		while (true)
		{
			BigInteger P = BigInteger.Arbitrary(q.BitLength);
			if (P.CompareTo(q) < 0 && ModReduce(P.Multiply(P).Subtract(fourX)).ModPow(legendreExponent, q).Equals(qMinusOne))
			{
				BigInteger[] array = LucasSequence(P, X, k);
				BigInteger U = array[0];
				BigInteger V = array[1];
				if (ModMult(V, V).Equals(fourX))
				{
					return new FpFieldElement(q, r, ModHalfAbs(V));
				}
				if (!U.Equals(BigInteger.One) && !U.Equals(qMinusOne))
				{
					break;
				}
			}
		}
		return null;
	}

	private ECFieldElement CheckSqrt(ECFieldElement z)
	{
		if (!z.Square().Equals(this))
		{
			return null;
		}
		return z;
	}

	private BigInteger[] LucasSequence(BigInteger P, BigInteger Q, BigInteger k)
	{
		int bitLength = k.BitLength;
		int s = k.GetLowestSetBit();
		BigInteger Uh = BigInteger.One;
		BigInteger Vl = BigInteger.Two;
		BigInteger Vh = P;
		BigInteger Ql = BigInteger.One;
		BigInteger Qh = BigInteger.One;
		for (int j = bitLength - 1; j >= s + 1; j--)
		{
			Ql = ModMult(Ql, Qh);
			if (k.TestBit(j))
			{
				Qh = ModMult(Ql, Q);
				Uh = ModMult(Uh, Vh);
				Vl = ModReduce(Vh.Multiply(Vl).Subtract(P.Multiply(Ql)));
				Vh = ModReduce(Vh.Multiply(Vh).Subtract(Qh.ShiftLeft(1)));
			}
			else
			{
				Qh = Ql;
				Uh = ModReduce(Uh.Multiply(Vl).Subtract(Ql));
				Vh = ModReduce(Vh.Multiply(Vl).Subtract(P.Multiply(Ql)));
				Vl = ModReduce(Vl.Multiply(Vl).Subtract(Ql.ShiftLeft(1)));
			}
		}
		Ql = ModMult(Ql, Qh);
		Qh = ModMult(Ql, Q);
		Uh = ModReduce(Uh.Multiply(Vl).Subtract(Ql));
		Vl = ModReduce(Vh.Multiply(Vl).Subtract(P.Multiply(Ql)));
		Ql = ModMult(Ql, Qh);
		for (int i = 1; i <= s; i++)
		{
			Uh = ModMult(Uh, Vl);
			Vl = ModReduce(Vl.Multiply(Vl).Subtract(Ql.ShiftLeft(1)));
			Ql = ModMult(Ql, Ql);
		}
		return new BigInteger[2] { Uh, Vl };
	}

	protected virtual BigInteger ModAdd(BigInteger x1, BigInteger x2)
	{
		BigInteger x3 = x1.Add(x2);
		if (x3.CompareTo(q) >= 0)
		{
			x3 = x3.Subtract(q);
		}
		return x3;
	}

	protected virtual BigInteger ModDouble(BigInteger x)
	{
		BigInteger _2x = x.ShiftLeft(1);
		if (_2x.CompareTo(q) >= 0)
		{
			_2x = _2x.Subtract(q);
		}
		return _2x;
	}

	protected virtual BigInteger ModHalf(BigInteger x)
	{
		if (x.TestBit(0))
		{
			x = q.Add(x);
		}
		return x.ShiftRight(1);
	}

	protected virtual BigInteger ModHalfAbs(BigInteger x)
	{
		if (x.TestBit(0))
		{
			x = q.Subtract(x);
		}
		return x.ShiftRight(1);
	}

	protected virtual BigInteger ModInverse(BigInteger x)
	{
		return BigIntegers.ModOddInverse(q, x);
	}

	protected virtual BigInteger ModMult(BigInteger x1, BigInteger x2)
	{
		return ModReduce(x1.Multiply(x2));
	}

	protected virtual BigInteger ModReduce(BigInteger x)
	{
		if (r == null)
		{
			x = x.Mod(q);
		}
		else
		{
			bool negative = x.SignValue < 0;
			if (negative)
			{
				x = x.Abs();
			}
			int qLen = q.BitLength;
			if (r.SignValue > 0)
			{
				BigInteger qMod = BigInteger.One.ShiftLeft(qLen);
				bool rIsOne = r.Equals(BigInteger.One);
				while (x.BitLength > qLen + 1)
				{
					BigInteger u = x.ShiftRight(qLen);
					BigInteger v = x.Remainder(qMod);
					if (!rIsOne)
					{
						u = u.Multiply(r);
					}
					x = u.Add(v);
				}
			}
			else
			{
				int d = ((qLen - 1) & 0x1F) + 1;
				BigInteger v2 = r.Negate().Multiply(x.ShiftRight(qLen - d)).ShiftRight(qLen + d)
					.Multiply(q);
				BigInteger bk1 = BigInteger.One.ShiftLeft(qLen + d);
				v2 = v2.Remainder(bk1);
				x = x.Remainder(bk1);
				x = x.Subtract(v2);
				if (x.SignValue < 0)
				{
					x = x.Add(bk1);
				}
			}
			while (x.CompareTo(q) >= 0)
			{
				x = x.Subtract(q);
			}
			if (negative && x.SignValue != 0)
			{
				x = q.Subtract(x);
			}
		}
		return x;
	}

	protected virtual BigInteger ModSubtract(BigInteger x1, BigInteger x2)
	{
		BigInteger x3 = x1.Subtract(x2);
		if (x3.SignValue < 0)
		{
			x3 = x3.Add(q);
		}
		return x3;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is FpFieldElement other))
		{
			return false;
		}
		return Equals(other);
	}

	public virtual bool Equals(FpFieldElement other)
	{
		if (q.Equals(other.q))
		{
			return base.Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return q.GetHashCode() ^ base.GetHashCode();
	}
}
