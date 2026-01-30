using System;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC;

public abstract class AbstractFpCurve : ECCurve
{
	protected AbstractFpCurve(BigInteger q)
		: base(FiniteFields.GetPrimeField(q))
	{
	}

	public override bool IsValidFieldElement(BigInteger x)
	{
		if (x != null && x.SignValue >= 0)
		{
			return x.CompareTo(Field.Characteristic) < 0;
		}
		return false;
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		BigInteger p = Field.Characteristic;
		ECFieldElement eCFieldElement = FromBigInteger(ImplRandomFieldElement(r, p));
		ECFieldElement fe2 = FromBigInteger(ImplRandomFieldElement(r, p));
		return eCFieldElement.Multiply(fe2);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		BigInteger p = Field.Characteristic;
		ECFieldElement eCFieldElement = FromBigInteger(ImplRandomFieldElementMult(r, p));
		ECFieldElement fe2 = FromBigInteger(ImplRandomFieldElementMult(r, p));
		return eCFieldElement.Multiply(fe2);
	}

	protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
	{
		ECFieldElement x = FromBigInteger(X1);
		ECFieldElement y = x.Square().Add(A).Multiply(x)
			.Add(B)
			.Sqrt();
		if (y == null)
		{
			throw new ArgumentException("Invalid point compression");
		}
		if (y.TestBitZero() != (yTilde == 1))
		{
			y = y.Negate();
		}
		return CreateRawPoint(x, y, withCompression: true);
	}

	private static BigInteger ImplRandomFieldElement(SecureRandom r, BigInteger p)
	{
		BigInteger x;
		do
		{
			x = BigIntegers.CreateRandomBigInteger(p.BitLength, r);
		}
		while (x.CompareTo(p) >= 0);
		return x;
	}

	private static BigInteger ImplRandomFieldElementMult(SecureRandom r, BigInteger p)
	{
		BigInteger x;
		do
		{
			x = BigIntegers.CreateRandomBigInteger(p.BitLength, r);
		}
		while (x.SignValue <= 0 || x.CompareTo(p) >= 0);
		return x;
	}
}
