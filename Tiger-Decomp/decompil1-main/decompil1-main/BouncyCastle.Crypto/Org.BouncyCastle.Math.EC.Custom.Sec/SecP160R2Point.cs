using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP160R2Point : AbstractFpPoint
{
	public SecP160R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	public SecP160R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal SecP160R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new SecP160R2Point(null, AffineXCoord, AffineYCoord);
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
		SecP160R2FieldElement X1 = (SecP160R2FieldElement)base.RawXCoord;
		SecP160R2FieldElement Y1 = (SecP160R2FieldElement)base.RawYCoord;
		SecP160R2FieldElement X2 = (SecP160R2FieldElement)b.RawXCoord;
		SecP160R2FieldElement Y2 = (SecP160R2FieldElement)b.RawYCoord;
		SecP160R2FieldElement Z1 = (SecP160R2FieldElement)base.RawZCoords[0];
		SecP160R2FieldElement Z2 = (SecP160R2FieldElement)b.RawZCoords[0];
		uint[] tt1 = Nat160.CreateExt();
		uint[] t2 = Nat160.Create();
		uint[] t3 = Nat160.Create();
		uint[] t4 = Nat160.Create();
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
			SecP160R2Field.Square(Z1.x, S2);
			U2 = t2;
			SecP160R2Field.Multiply(S2, X2.x, U2);
			SecP160R2Field.Multiply(S2, Z1.x, S2);
			SecP160R2Field.Multiply(S2, Y2.x, S2);
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
			SecP160R2Field.Square(Z2.x, S3);
			U3 = tt1;
			SecP160R2Field.Multiply(S3, X1.x, U3);
			SecP160R2Field.Multiply(S3, Z2.x, S3);
			SecP160R2Field.Multiply(S3, Y1.x, S3);
		}
		uint[] H = Nat160.Create();
		SecP160R2Field.Subtract(U3, U2, H);
		uint[] R = t2;
		SecP160R2Field.Subtract(S3, S2, R);
		if (Nat160.IsZero(H))
		{
			if (Nat160.IsZero(R))
			{
				return Twice();
			}
			return curve.Infinity;
		}
		uint[] HSquared = t3;
		SecP160R2Field.Square(H, HSquared);
		uint[] G = Nat160.Create();
		SecP160R2Field.Multiply(HSquared, H, G);
		uint[] V = t3;
		SecP160R2Field.Multiply(HSquared, U3, V);
		SecP160R2Field.Negate(G, G);
		Nat160.Mul(S3, G, tt1);
		SecP160R2Field.Reduce32(Nat160.AddBothTo(V, V, G), G);
		SecP160R2FieldElement X3 = new SecP160R2FieldElement(t4);
		SecP160R2Field.Square(R, X3.x);
		SecP160R2Field.Subtract(X3.x, G, X3.x);
		SecP160R2FieldElement Y3 = new SecP160R2FieldElement(G);
		SecP160R2Field.Subtract(V, X3.x, Y3.x);
		SecP160R2Field.MultiplyAddToExt(Y3.x, R, tt1);
		SecP160R2Field.Reduce(tt1, Y3.x);
		SecP160R2FieldElement Z3 = new SecP160R2FieldElement(H);
		if (!Z1IsOne)
		{
			SecP160R2Field.Multiply(Z3.x, Z1.x, Z3.x);
		}
		if (!Z2IsOne)
		{
			SecP160R2Field.Multiply(Z3.x, Z2.x, Z3.x);
		}
		ECFieldElement[] zs = new ECFieldElement[1] { Z3 };
		return new SecP160R2Point(curve, X3, Y3, zs, base.IsCompressed);
	}

	public override ECPoint Twice()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		SecP160R2FieldElement Y1 = (SecP160R2FieldElement)base.RawYCoord;
		if (Y1.IsZero)
		{
			return curve.Infinity;
		}
		SecP160R2FieldElement X1 = (SecP160R2FieldElement)base.RawXCoord;
		SecP160R2FieldElement Z1 = (SecP160R2FieldElement)base.RawZCoords[0];
		uint[] t1 = Nat160.Create();
		uint[] t2 = Nat160.Create();
		uint[] Y1Squared = Nat160.Create();
		SecP160R2Field.Square(Y1.x, Y1Squared);
		uint[] T = Nat160.Create();
		SecP160R2Field.Square(Y1Squared, T);
		bool isOne = Z1.IsOne;
		uint[] Z1Squared = Z1.x;
		if (!isOne)
		{
			Z1Squared = t2;
			SecP160R2Field.Square(Z1.x, Z1Squared);
		}
		SecP160R2Field.Subtract(X1.x, Z1Squared, t1);
		uint[] M = t2;
		SecP160R2Field.Add(X1.x, Z1Squared, M);
		SecP160R2Field.Multiply(M, t1, M);
		SecP160R2Field.Reduce32(Nat160.AddBothTo(M, M, M), M);
		uint[] S = Y1Squared;
		SecP160R2Field.Multiply(Y1Squared, X1.x, S);
		SecP160R2Field.Reduce32(Nat.ShiftUpBits(5, S, 2, 0u), S);
		SecP160R2Field.Reduce32(Nat.ShiftUpBits(5, T, 3, 0u, t1), t1);
		SecP160R2FieldElement X3 = new SecP160R2FieldElement(T);
		SecP160R2Field.Square(M, X3.x);
		SecP160R2Field.Subtract(X3.x, S, X3.x);
		SecP160R2Field.Subtract(X3.x, S, X3.x);
		SecP160R2FieldElement Y3 = new SecP160R2FieldElement(S);
		SecP160R2Field.Subtract(S, X3.x, Y3.x);
		SecP160R2Field.Multiply(Y3.x, M, Y3.x);
		SecP160R2Field.Subtract(Y3.x, t1, Y3.x);
		SecP160R2FieldElement Z3 = new SecP160R2FieldElement(M);
		SecP160R2Field.Twice(Y1.x, Z3.x);
		if (!isOne)
		{
			SecP160R2Field.Multiply(Z3.x, Z1.x, Z3.x);
		}
		return new SecP160R2Point(curve, X3, Y3, new ECFieldElement[1] { Z3 }, base.IsCompressed);
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
		return new SecP160R2Point(Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
	}
}
