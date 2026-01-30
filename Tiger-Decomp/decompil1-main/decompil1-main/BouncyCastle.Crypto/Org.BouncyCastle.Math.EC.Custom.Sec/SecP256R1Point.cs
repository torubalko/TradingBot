using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP256R1Point : AbstractFpPoint
{
	public SecP256R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	public SecP256R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal SecP256R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new SecP256R1Point(null, AffineXCoord, AffineYCoord);
	}

	public override ECPoint Add(ECPoint b)
	{
		if (base.IsInfinity)
		{
			return b;
		}
		if (b.IsInfinity)
		{
			return this;
		}
		if (this == b)
		{
			return Twice();
		}
		ECCurve curve = Curve;
		SecP256R1FieldElement X1 = (SecP256R1FieldElement)base.RawXCoord;
		SecP256R1FieldElement Y1 = (SecP256R1FieldElement)base.RawYCoord;
		SecP256R1FieldElement X2 = (SecP256R1FieldElement)b.RawXCoord;
		SecP256R1FieldElement Y2 = (SecP256R1FieldElement)b.RawYCoord;
		SecP256R1FieldElement Z1 = (SecP256R1FieldElement)base.RawZCoords[0];
		SecP256R1FieldElement Z2 = (SecP256R1FieldElement)b.RawZCoords[0];
		uint[] tt1 = Nat256.CreateExt();
		uint[] t2 = Nat256.Create();
		uint[] t3 = Nat256.Create();
		uint[] t4 = Nat256.Create();
		bool Z1IsOne = Z1.IsOne;
		uint[] U2;
		uint[] S2;
		if (Z1IsOne)
		{
			U2 = X2.x;
			S2 = Y2.x;
		}
		else
		{
			S2 = t3;
			SecP256R1Field.Square(Z1.x, S2);
			U2 = t2;
			SecP256R1Field.Multiply(S2, X2.x, U2);
			SecP256R1Field.Multiply(S2, Z1.x, S2);
			SecP256R1Field.Multiply(S2, Y2.x, S2);
		}
		bool Z2IsOne = Z2.IsOne;
		uint[] U3;
		uint[] S3;
		if (Z2IsOne)
		{
			U3 = X1.x;
			S3 = Y1.x;
		}
		else
		{
			S3 = t4;
			SecP256R1Field.Square(Z2.x, S3);
			U3 = tt1;
			SecP256R1Field.Multiply(S3, X1.x, U3);
			SecP256R1Field.Multiply(S3, Z2.x, S3);
			SecP256R1Field.Multiply(S3, Y1.x, S3);
		}
		uint[] H = Nat256.Create();
		SecP256R1Field.Subtract(U3, U2, H);
		uint[] R = t2;
		SecP256R1Field.Subtract(S3, S2, R);
		if (Nat256.IsZero(H))
		{
			if (Nat256.IsZero(R))
			{
				return Twice();
			}
			return curve.Infinity;
		}
		uint[] HSquared = t3;
		SecP256R1Field.Square(H, HSquared);
		uint[] G = Nat256.Create();
		SecP256R1Field.Multiply(HSquared, H, G);
		uint[] V = t3;
		SecP256R1Field.Multiply(HSquared, U3, V);
		SecP256R1Field.Negate(G, G);
		Nat256.Mul(S3, G, tt1);
		SecP256R1Field.Reduce32(Nat256.AddBothTo(V, V, G), G);
		SecP256R1FieldElement X3 = new SecP256R1FieldElement(t4);
		SecP256R1Field.Square(R, X3.x);
		SecP256R1Field.Subtract(X3.x, G, X3.x);
		SecP256R1FieldElement Y3 = new SecP256R1FieldElement(G);
		SecP256R1Field.Subtract(V, X3.x, Y3.x);
		SecP256R1Field.MultiplyAddToExt(Y3.x, R, tt1);
		SecP256R1Field.Reduce(tt1, Y3.x);
		SecP256R1FieldElement Z3 = new SecP256R1FieldElement(H);
		if (!Z1IsOne)
		{
			SecP256R1Field.Multiply(Z3.x, Z1.x, Z3.x);
		}
		if (!Z2IsOne)
		{
			SecP256R1Field.Multiply(Z3.x, Z2.x, Z3.x);
		}
		ECFieldElement[] zs = new ECFieldElement[1] { Z3 };
		return new SecP256R1Point(curve, X3, Y3, zs, base.IsCompressed);
	}

	public override ECPoint Twice()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		SecP256R1FieldElement Y1 = (SecP256R1FieldElement)base.RawYCoord;
		if (Y1.IsZero)
		{
			return curve.Infinity;
		}
		SecP256R1FieldElement X1 = (SecP256R1FieldElement)base.RawXCoord;
		SecP256R1FieldElement Z1 = (SecP256R1FieldElement)base.RawZCoords[0];
		uint[] t1 = Nat256.Create();
		uint[] t2 = Nat256.Create();
		uint[] Y1Squared = Nat256.Create();
		SecP256R1Field.Square(Y1.x, Y1Squared);
		uint[] T = Nat256.Create();
		SecP256R1Field.Square(Y1Squared, T);
		bool isOne = Z1.IsOne;
		uint[] Z1Squared = Z1.x;
		if (!isOne)
		{
			Z1Squared = t2;
			SecP256R1Field.Square(Z1.x, Z1Squared);
		}
		SecP256R1Field.Subtract(X1.x, Z1Squared, t1);
		uint[] M = t2;
		SecP256R1Field.Add(X1.x, Z1Squared, M);
		SecP256R1Field.Multiply(M, t1, M);
		SecP256R1Field.Reduce32(Nat256.AddBothTo(M, M, M), M);
		uint[] S = Y1Squared;
		SecP256R1Field.Multiply(Y1Squared, X1.x, S);
		SecP256R1Field.Reduce32(Nat.ShiftUpBits(8, S, 2, 0u), S);
		SecP256R1Field.Reduce32(Nat.ShiftUpBits(8, T, 3, 0u, t1), t1);
		SecP256R1FieldElement X3 = new SecP256R1FieldElement(T);
		SecP256R1Field.Square(M, X3.x);
		SecP256R1Field.Subtract(X3.x, S, X3.x);
		SecP256R1Field.Subtract(X3.x, S, X3.x);
		SecP256R1FieldElement Y3 = new SecP256R1FieldElement(S);
		SecP256R1Field.Subtract(S, X3.x, Y3.x);
		SecP256R1Field.Multiply(Y3.x, M, Y3.x);
		SecP256R1Field.Subtract(Y3.x, t1, Y3.x);
		SecP256R1FieldElement Z3 = new SecP256R1FieldElement(M);
		SecP256R1Field.Twice(Y1.x, Z3.x);
		if (!isOne)
		{
			SecP256R1Field.Multiply(Z3.x, Z1.x, Z3.x);
		}
		return new SecP256R1Point(curve, X3, Y3, new ECFieldElement[1] { Z3 }, base.IsCompressed);
	}

	public override ECPoint TwicePlus(ECPoint b)
	{
		if (this == b)
		{
			return ThreeTimes();
		}
		if (base.IsInfinity)
		{
			return b;
		}
		if (b.IsInfinity)
		{
			return Twice();
		}
		if (base.RawYCoord.IsZero)
		{
			return b;
		}
		return Twice().Add(b);
	}

	public override ECPoint ThreeTimes()
	{
		if (base.IsInfinity || base.RawYCoord.IsZero)
		{
			return this;
		}
		return Twice().Add(this);
	}

	public override ECPoint Negate()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		return new SecP256R1Point(Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
	}
}
