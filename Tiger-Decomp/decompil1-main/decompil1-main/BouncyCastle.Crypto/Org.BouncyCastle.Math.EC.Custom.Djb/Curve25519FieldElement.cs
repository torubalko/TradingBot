using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Custom.Djb;

internal class Curve25519FieldElement : AbstractFpFieldElement
{
	public static readonly BigInteger Q = Nat256.ToBigInteger(Curve25519Field.P);

	private static readonly uint[] PRECOMP_POW2 = new uint[8] { 1242472624u, 3303938855u, 2905597048u, 792926214u, 1039914919u, 726466713u, 1338105611u, 730014848u };

	protected internal readonly uint[] x;

	public override bool IsZero => Nat256.IsZero(x);

	public override bool IsOne => Nat256.IsOne(x);

	public override string FieldName => "Curve25519Field";

	public override int FieldSize => Q.BitLength;

	public Curve25519FieldElement(BigInteger x)
	{
		if (x == null || x.SignValue < 0 || x.CompareTo(Q) >= 0)
		{
			throw new ArgumentException("value invalid for Curve25519FieldElement", "x");
		}
		this.x = Curve25519Field.FromBigInteger(x);
	}

	public Curve25519FieldElement()
	{
		x = Nat256.Create();
	}

	protected internal Curve25519FieldElement(uint[] x)
	{
		this.x = x;
	}

	public override bool TestBitZero()
	{
		return Nat256.GetBit(x, 0) == 1;
	}

	public override BigInteger ToBigInteger()
	{
		return Nat256.ToBigInteger(x);
	}

	public override ECFieldElement Add(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		Curve25519Field.Add(x, ((Curve25519FieldElement)b).x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement AddOne()
	{
		uint[] z = Nat256.Create();
		Curve25519Field.AddOne(x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement Subtract(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		Curve25519Field.Subtract(x, ((Curve25519FieldElement)b).x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement Multiply(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		Curve25519Field.Multiply(x, ((Curve25519FieldElement)b).x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement Divide(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		Curve25519Field.Inv(((Curve25519FieldElement)b).x, z);
		Curve25519Field.Multiply(z, x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement Negate()
	{
		uint[] z = Nat256.Create();
		Curve25519Field.Negate(x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement Square()
	{
		uint[] z = Nat256.Create();
		Curve25519Field.Square(x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement Invert()
	{
		uint[] z = Nat256.Create();
		Curve25519Field.Inv(x, z);
		return new Curve25519FieldElement(z);
	}

	public override ECFieldElement Sqrt()
	{
		uint[] x1 = x;
		if (Nat256.IsZero(x1) || Nat256.IsOne(x1))
		{
			return this;
		}
		uint[] x2 = Nat256.Create();
		Curve25519Field.Square(x1, x2);
		Curve25519Field.Multiply(x2, x1, x2);
		uint[] x3 = x2;
		Curve25519Field.Square(x2, x3);
		Curve25519Field.Multiply(x3, x1, x3);
		uint[] x4 = Nat256.Create();
		Curve25519Field.Square(x3, x4);
		Curve25519Field.Multiply(x4, x1, x4);
		uint[] x7 = Nat256.Create();
		Curve25519Field.SquareN(x4, 3, x7);
		Curve25519Field.Multiply(x7, x3, x7);
		uint[] x11 = x3;
		Curve25519Field.SquareN(x7, 4, x11);
		Curve25519Field.Multiply(x11, x4, x11);
		uint[] x15 = x7;
		Curve25519Field.SquareN(x11, 4, x15);
		Curve25519Field.Multiply(x15, x4, x15);
		uint[] x30 = x4;
		Curve25519Field.SquareN(x15, 15, x30);
		Curve25519Field.Multiply(x30, x15, x30);
		uint[] x60 = x15;
		Curve25519Field.SquareN(x30, 30, x60);
		Curve25519Field.Multiply(x60, x30, x60);
		uint[] x120 = x30;
		Curve25519Field.SquareN(x60, 60, x120);
		Curve25519Field.Multiply(x120, x60, x120);
		uint[] x131 = x60;
		Curve25519Field.SquareN(x120, 11, x131);
		Curve25519Field.Multiply(x131, x11, x131);
		uint[] x251 = x11;
		Curve25519Field.SquareN(x131, 120, x251);
		Curve25519Field.Multiply(x251, x120, x251);
		uint[] t1 = x251;
		Curve25519Field.Square(t1, t1);
		uint[] t2 = x120;
		Curve25519Field.Square(t1, t2);
		if (Nat256.Eq(x1, t2))
		{
			return new Curve25519FieldElement(t1);
		}
		Curve25519Field.Multiply(t1, PRECOMP_POW2, t1);
		Curve25519Field.Square(t1, t2);
		if (Nat256.Eq(x1, t2))
		{
			return new Curve25519FieldElement(t1);
		}
		return null;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as Curve25519FieldElement);
	}

	public override bool Equals(ECFieldElement other)
	{
		return Equals(other as Curve25519FieldElement);
	}

	public virtual bool Equals(Curve25519FieldElement other)
	{
		if (this == other)
		{
			return true;
		}
		if (other == null)
		{
			return false;
		}
		return Nat256.Eq(x, other.x);
	}

	public override int GetHashCode()
	{
		return Q.GetHashCode() ^ Arrays.GetHashCode(x, 0, 8);
	}
}
