using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP256K1FieldElement : AbstractFpFieldElement
{
	public static readonly BigInteger Q = new BigInteger(1, Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFC2F"));

	protected internal readonly uint[] x;

	public override bool IsZero => Nat256.IsZero(x);

	public override bool IsOne => Nat256.IsOne(x);

	public override string FieldName => "SecP256K1Field";

	public override int FieldSize => Q.BitLength;

	public SecP256K1FieldElement(BigInteger x)
	{
		if (x == null || x.SignValue < 0 || x.CompareTo(Q) >= 0)
		{
			throw new ArgumentException("value invalid for SecP256K1FieldElement", "x");
		}
		this.x = SecP256K1Field.FromBigInteger(x);
	}

	public SecP256K1FieldElement()
	{
		x = Nat256.Create();
	}

	protected internal SecP256K1FieldElement(uint[] x)
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
		SecP256K1Field.Add(x, ((SecP256K1FieldElement)b).x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement AddOne()
	{
		uint[] z = Nat256.Create();
		SecP256K1Field.AddOne(x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement Subtract(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		SecP256K1Field.Subtract(x, ((SecP256K1FieldElement)b).x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement Multiply(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		SecP256K1Field.Multiply(x, ((SecP256K1FieldElement)b).x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement Divide(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		SecP256K1Field.Inv(((SecP256K1FieldElement)b).x, z);
		SecP256K1Field.Multiply(z, x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement Negate()
	{
		uint[] z = Nat256.Create();
		SecP256K1Field.Negate(x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement Square()
	{
		uint[] z = Nat256.Create();
		SecP256K1Field.Square(x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement Invert()
	{
		uint[] z = Nat256.Create();
		SecP256K1Field.Inv(x, z);
		return new SecP256K1FieldElement(z);
	}

	public override ECFieldElement Sqrt()
	{
		uint[] x1 = x;
		if (Nat256.IsZero(x1) || Nat256.IsOne(x1))
		{
			return this;
		}
		uint[] x2 = Nat256.Create();
		SecP256K1Field.Square(x1, x2);
		SecP256K1Field.Multiply(x2, x1, x2);
		uint[] x3 = Nat256.Create();
		SecP256K1Field.Square(x2, x3);
		SecP256K1Field.Multiply(x3, x1, x3);
		uint[] x6 = Nat256.Create();
		SecP256K1Field.SquareN(x3, 3, x6);
		SecP256K1Field.Multiply(x6, x3, x6);
		uint[] x9 = x6;
		SecP256K1Field.SquareN(x6, 3, x9);
		SecP256K1Field.Multiply(x9, x3, x9);
		uint[] x11 = x9;
		SecP256K1Field.SquareN(x9, 2, x11);
		SecP256K1Field.Multiply(x11, x2, x11);
		uint[] x22 = Nat256.Create();
		SecP256K1Field.SquareN(x11, 11, x22);
		SecP256K1Field.Multiply(x22, x11, x22);
		uint[] x44 = x11;
		SecP256K1Field.SquareN(x22, 22, x44);
		SecP256K1Field.Multiply(x44, x22, x44);
		uint[] x88 = Nat256.Create();
		SecP256K1Field.SquareN(x44, 44, x88);
		SecP256K1Field.Multiply(x88, x44, x88);
		uint[] x176 = Nat256.Create();
		SecP256K1Field.SquareN(x88, 88, x176);
		SecP256K1Field.Multiply(x176, x88, x176);
		uint[] x220 = x88;
		SecP256K1Field.SquareN(x176, 44, x220);
		SecP256K1Field.Multiply(x220, x44, x220);
		uint[] x223 = x44;
		SecP256K1Field.SquareN(x220, 3, x223);
		SecP256K1Field.Multiply(x223, x3, x223);
		uint[] t1 = x223;
		SecP256K1Field.SquareN(t1, 23, t1);
		SecP256K1Field.Multiply(t1, x22, t1);
		SecP256K1Field.SquareN(t1, 6, t1);
		SecP256K1Field.Multiply(t1, x2, t1);
		SecP256K1Field.SquareN(t1, 2, t1);
		uint[] t2 = x2;
		SecP256K1Field.Square(t1, t2);
		if (!Nat256.Eq(x1, t2))
		{
			return null;
		}
		return new SecP256K1FieldElement(t1);
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as SecP256K1FieldElement);
	}

	public override bool Equals(ECFieldElement other)
	{
		return Equals(other as SecP256K1FieldElement);
	}

	public virtual bool Equals(SecP256K1FieldElement other)
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
