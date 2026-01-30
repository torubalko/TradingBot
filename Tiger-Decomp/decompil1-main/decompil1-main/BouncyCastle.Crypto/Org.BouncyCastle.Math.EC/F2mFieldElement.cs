using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC;

public class F2mFieldElement : AbstractF2mFieldElement
{
	public const int Gnb = 1;

	public const int Tpb = 2;

	public const int Ppb = 3;

	private int representation;

	private int m;

	private int[] ks;

	internal LongArray x;

	public override int BitLength => x.Degree();

	public override bool IsOne => x.IsOne();

	public override bool IsZero => x.IsZero();

	public override string FieldName => "F2m";

	public override int FieldSize => m;

	public int Representation => representation;

	public int M => m;

	public int K1 => ks[0];

	public int K2
	{
		get
		{
			if (ks.Length < 2)
			{
				return 0;
			}
			return ks[1];
		}
	}

	public int K3
	{
		get
		{
			if (ks.Length < 3)
			{
				return 0;
			}
			return ks[2];
		}
	}

	[Obsolete("Use ECCurve.FromBigInteger to construct field elements")]
	public F2mFieldElement(int m, int k1, int k2, int k3, BigInteger x)
	{
		if (x == null || x.SignValue < 0 || x.BitLength > m)
		{
			throw new ArgumentException("value invalid in F2m field element", "x");
		}
		if (k2 == 0 && k3 == 0)
		{
			representation = 2;
			ks = new int[1] { k1 };
		}
		else
		{
			if (k2 >= k3)
			{
				throw new ArgumentException("k2 must be smaller than k3");
			}
			if (k2 <= 0)
			{
				throw new ArgumentException("k2 must be larger than 0");
			}
			representation = 3;
			ks = new int[3] { k1, k2, k3 };
		}
		this.m = m;
		this.x = new LongArray(x);
	}

	[Obsolete("Use ECCurve.FromBigInteger to construct field elements")]
	public F2mFieldElement(int m, int k, BigInteger x)
		: this(m, k, 0, 0, x)
	{
	}

	internal F2mFieldElement(int m, int[] ks, LongArray x)
	{
		this.m = m;
		representation = ((ks.Length == 1) ? 2 : 3);
		this.ks = ks;
		this.x = x;
	}

	public override bool TestBitZero()
	{
		return x.TestBitZero();
	}

	public override BigInteger ToBigInteger()
	{
		return x.ToBigInteger();
	}

	public static void CheckFieldElements(ECFieldElement a, ECFieldElement b)
	{
		if (!(a is F2mFieldElement) || !(b is F2mFieldElement))
		{
			throw new ArgumentException("Field elements are not both instances of F2mFieldElement");
		}
		F2mFieldElement aF2m = (F2mFieldElement)a;
		F2mFieldElement bF2m = (F2mFieldElement)b;
		if (aF2m.representation != bF2m.representation)
		{
			throw new ArgumentException("One of the F2m field elements has incorrect representation");
		}
		if (aF2m.m != bF2m.m || !Arrays.AreEqual(aF2m.ks, bF2m.ks))
		{
			throw new ArgumentException("Field elements are not elements of the same field F2m");
		}
	}

	public override ECFieldElement Add(ECFieldElement b)
	{
		LongArray iarrClone = x.Copy();
		F2mFieldElement bF2m = (F2mFieldElement)b;
		iarrClone.AddShiftedByWords(bF2m.x, 0);
		return new F2mFieldElement(m, ks, iarrClone);
	}

	public override ECFieldElement AddOne()
	{
		return new F2mFieldElement(m, ks, x.AddOne());
	}

	public override ECFieldElement Subtract(ECFieldElement b)
	{
		return Add(b);
	}

	public override ECFieldElement Multiply(ECFieldElement b)
	{
		return new F2mFieldElement(m, ks, x.ModMultiply(((F2mFieldElement)b).x, m, ks));
	}

	public override ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
	{
		return MultiplyPlusProduct(b, x, y);
	}

	public override ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
	{
		LongArray ax = this.x;
		LongArray bx = ((F2mFieldElement)b).x;
		LongArray longArray = ((F2mFieldElement)x).x;
		LongArray yx = ((F2mFieldElement)y).x;
		LongArray ab = ax.Multiply(bx, m, ks);
		LongArray xy = longArray.Multiply(yx, m, ks);
		if (ab == ax || ab == bx)
		{
			ab = ab.Copy();
		}
		ab.AddShiftedByWords(xy, 0);
		ab.Reduce(m, ks);
		return new F2mFieldElement(m, ks, ab);
	}

	public override ECFieldElement Divide(ECFieldElement b)
	{
		ECFieldElement bInv = b.Invert();
		return Multiply(bInv);
	}

	public override ECFieldElement Negate()
	{
		return this;
	}

	public override ECFieldElement Square()
	{
		return new F2mFieldElement(m, ks, x.ModSquare(m, ks));
	}

	public override ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
	{
		return SquarePlusProduct(x, y);
	}

	public override ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
	{
		LongArray ax = this.x;
		LongArray longArray = ((F2mFieldElement)x).x;
		LongArray yx = ((F2mFieldElement)y).x;
		LongArray aa = ax.Square(m, ks);
		LongArray xy = longArray.Multiply(yx, m, ks);
		if (aa == ax)
		{
			aa = aa.Copy();
		}
		aa.AddShiftedByWords(xy, 0);
		aa.Reduce(m, ks);
		return new F2mFieldElement(m, ks, aa);
	}

	public override ECFieldElement SquarePow(int pow)
	{
		if (pow >= 1)
		{
			return new F2mFieldElement(m, ks, x.ModSquareN(pow, m, ks));
		}
		return this;
	}

	public override ECFieldElement Invert()
	{
		return new F2mFieldElement(m, ks, x.ModInverse(m, ks));
	}

	public override ECFieldElement Sqrt()
	{
		if (!x.IsZero() && !x.IsOne())
		{
			return SquarePow(m - 1);
		}
		return this;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is F2mFieldElement other))
		{
			return false;
		}
		return Equals(other);
	}

	public virtual bool Equals(F2mFieldElement other)
	{
		if (m == other.m && representation == other.representation && Arrays.AreEqual(ks, other.ks))
		{
			return x.Equals(other.x);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return x.GetHashCode() ^ m ^ Arrays.GetHashCode(ks);
	}
}
