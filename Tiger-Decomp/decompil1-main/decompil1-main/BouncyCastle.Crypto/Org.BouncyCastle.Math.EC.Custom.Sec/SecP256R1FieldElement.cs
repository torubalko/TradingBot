using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP256R1FieldElement : AbstractFpFieldElement
{
	public static readonly BigInteger Q = new BigInteger(1, Hex.DecodeStrict("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFF"));

	protected internal readonly uint[] x;

	public override bool IsZero => Nat256.IsZero(x);

	public override bool IsOne => Nat256.IsOne(x);

	public override string FieldName => "SecP256R1Field";

	public override int FieldSize => Q.BitLength;

	public SecP256R1FieldElement(BigInteger x)
	{
		if (x == null || x.SignValue < 0 || x.CompareTo(Q) >= 0)
		{
			throw new ArgumentException("value invalid for SecP256R1FieldElement", "x");
		}
		this.x = SecP256R1Field.FromBigInteger(x);
	}

	public SecP256R1FieldElement()
	{
		x = Nat256.Create();
	}

	protected internal SecP256R1FieldElement(uint[] x)
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
		SecP256R1Field.Add(x, ((SecP256R1FieldElement)b).x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement AddOne()
	{
		uint[] z = Nat256.Create();
		SecP256R1Field.AddOne(x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement Subtract(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		SecP256R1Field.Subtract(x, ((SecP256R1FieldElement)b).x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement Multiply(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		SecP256R1Field.Multiply(x, ((SecP256R1FieldElement)b).x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement Divide(ECFieldElement b)
	{
		uint[] z = Nat256.Create();
		SecP256R1Field.Inv(((SecP256R1FieldElement)b).x, z);
		SecP256R1Field.Multiply(z, x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement Negate()
	{
		uint[] z = Nat256.Create();
		SecP256R1Field.Negate(x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement Square()
	{
		uint[] z = Nat256.Create();
		SecP256R1Field.Square(x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement Invert()
	{
		uint[] z = Nat256.Create();
		SecP256R1Field.Inv(x, z);
		return new SecP256R1FieldElement(z);
	}

	public override ECFieldElement Sqrt()
	{
		uint[] x1 = x;
		if (Nat256.IsZero(x1) || Nat256.IsOne(x1))
		{
			return this;
		}
		uint[] t1 = Nat256.Create();
		uint[] t2 = Nat256.Create();
		SecP256R1Field.Square(x1, t1);
		SecP256R1Field.Multiply(t1, x1, t1);
		SecP256R1Field.SquareN(t1, 2, t2);
		SecP256R1Field.Multiply(t2, t1, t2);
		SecP256R1Field.SquareN(t2, 4, t1);
		SecP256R1Field.Multiply(t1, t2, t1);
		SecP256R1Field.SquareN(t1, 8, t2);
		SecP256R1Field.Multiply(t2, t1, t2);
		SecP256R1Field.SquareN(t2, 16, t1);
		SecP256R1Field.Multiply(t1, t2, t1);
		SecP256R1Field.SquareN(t1, 32, t1);
		SecP256R1Field.Multiply(t1, x1, t1);
		SecP256R1Field.SquareN(t1, 96, t1);
		SecP256R1Field.Multiply(t1, x1, t1);
		SecP256R1Field.SquareN(t1, 94, t1);
		SecP256R1Field.Multiply(t1, t1, t2);
		if (!Nat256.Eq(x1, t2))
		{
			return null;
		}
		return new SecP256R1FieldElement(t1);
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as SecP256R1FieldElement);
	}

	public override bool Equals(ECFieldElement other)
	{
		return Equals(other as SecP256R1FieldElement);
	}

	public virtual bool Equals(SecP256R1FieldElement other)
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
