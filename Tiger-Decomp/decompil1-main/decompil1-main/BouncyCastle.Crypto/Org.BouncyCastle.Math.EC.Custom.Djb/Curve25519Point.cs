using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Djb;

internal class Curve25519Point : AbstractFpPoint
{
	public Curve25519Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	public Curve25519Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal Curve25519Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new Curve25519Point(null, AffineXCoord, AffineYCoord);
	}

	public override ECFieldElement GetZCoord(int index)
	{
		if (index == 1)
		{
			return GetJacobianModifiedW();
		}
		return base.GetZCoord(index);
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
		Curve25519FieldElement X1 = (Curve25519FieldElement)base.RawXCoord;
		Curve25519FieldElement Y1 = (Curve25519FieldElement)base.RawYCoord;
		Curve25519FieldElement Z1 = (Curve25519FieldElement)base.RawZCoords[0];
		Curve25519FieldElement X2 = (Curve25519FieldElement)b.RawXCoord;
		Curve25519FieldElement Y2 = (Curve25519FieldElement)b.RawYCoord;
		Curve25519FieldElement Z2 = (Curve25519FieldElement)b.RawZCoords[0];
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
			Curve25519Field.Square(Z1.x, S2);
			U2 = t2;
			Curve25519Field.Multiply(S2, X2.x, U2);
			Curve25519Field.Multiply(S2, Z1.x, S2);
			Curve25519Field.Multiply(S2, Y2.x, S2);
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
			Curve25519Field.Square(Z2.x, S3);
			U3 = tt1;
			Curve25519Field.Multiply(S3, X1.x, U3);
			Curve25519Field.Multiply(S3, Z2.x, S3);
			Curve25519Field.Multiply(S3, Y1.x, S3);
		}
		uint[] H = Nat256.Create();
		Curve25519Field.Subtract(U3, U2, H);
		uint[] R = t2;
		Curve25519Field.Subtract(S3, S2, R);
		if (Nat256.IsZero(H))
		{
			if (Nat256.IsZero(R))
			{
				return Twice();
			}
			return curve.Infinity;
		}
		uint[] HSquared = Nat256.Create();
		Curve25519Field.Square(H, HSquared);
		uint[] G = Nat256.Create();
		Curve25519Field.Multiply(HSquared, H, G);
		uint[] V = t3;
		Curve25519Field.Multiply(HSquared, U3, V);
		Curve25519Field.Negate(G, G);
		Nat256.Mul(S3, G, tt1);
		Curve25519Field.Reduce27(Nat256.AddBothTo(V, V, G), G);
		Curve25519FieldElement X3 = new Curve25519FieldElement(t4);
		Curve25519Field.Square(R, X3.x);
		Curve25519Field.Subtract(X3.x, G, X3.x);
		Curve25519FieldElement Y3 = new Curve25519FieldElement(G);
		Curve25519Field.Subtract(V, X3.x, Y3.x);
		Curve25519Field.MultiplyAddToExt(Y3.x, R, tt1);
		Curve25519Field.Reduce(tt1, Y3.x);
		Curve25519FieldElement Z3 = new Curve25519FieldElement(H);
		if (!Z1IsOne)
		{
			Curve25519Field.Multiply(Z3.x, Z1.x, Z3.x);
		}
		if (!Z2IsOne)
		{
			Curve25519Field.Multiply(Z3.x, Z2.x, Z3.x);
		}
		uint[] Z3Squared = ((Z1IsOne && Z2IsOne) ? HSquared : null);
		Curve25519FieldElement W3 = CalculateJacobianModifiedW(Z3, Z3Squared);
		ECFieldElement[] zs = new ECFieldElement[2] { Z3, W3 };
		return new Curve25519Point(curve, X3, Y3, zs, base.IsCompressed);
	}

	public override ECPoint Twice()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		if (base.RawYCoord.IsZero)
		{
			return curve.Infinity;
		}
		return TwiceJacobianModified(calculateW: true);
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
		return TwiceJacobianModified(calculateW: false).Add(b);
	}

	public override ECPoint ThreeTimes()
	{
		if (base.IsInfinity || base.RawYCoord.IsZero)
		{
			return this;
		}
		return TwiceJacobianModified(calculateW: false).Add(this);
	}

	public override ECPoint Negate()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		return new Curve25519Point(Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
	}

	protected virtual Curve25519FieldElement CalculateJacobianModifiedW(Curve25519FieldElement Z, uint[] ZSquared)
	{
		Curve25519FieldElement a4 = (Curve25519FieldElement)Curve.A;
		if (Z.IsOne)
		{
			return a4;
		}
		Curve25519FieldElement W = new Curve25519FieldElement();
		if (ZSquared == null)
		{
			ZSquared = W.x;
			Curve25519Field.Square(Z.x, ZSquared);
		}
		Curve25519Field.Square(ZSquared, W.x);
		Curve25519Field.Multiply(W.x, a4.x, W.x);
		return W;
	}

	protected virtual Curve25519FieldElement GetJacobianModifiedW()
	{
		ECFieldElement[] ZZ = base.RawZCoords;
		Curve25519FieldElement W = (Curve25519FieldElement)ZZ[1];
		if (W == null)
		{
			W = (Curve25519FieldElement)(ZZ[1] = CalculateJacobianModifiedW((Curve25519FieldElement)ZZ[0], null));
		}
		return W;
	}

	protected virtual Curve25519Point TwiceJacobianModified(bool calculateW)
	{
		Curve25519FieldElement X1 = (Curve25519FieldElement)base.RawXCoord;
		Curve25519FieldElement Y1 = (Curve25519FieldElement)base.RawYCoord;
		Curve25519FieldElement Z1 = (Curve25519FieldElement)base.RawZCoords[0];
		Curve25519FieldElement W1 = GetJacobianModifiedW();
		uint[] M = Nat256.Create();
		Curve25519Field.Square(X1.x, M);
		Curve25519Field.Reduce27(Nat256.AddBothTo(M, M, M) + Nat256.AddTo(W1.x, M), M);
		uint[] _2Y1 = Nat256.Create();
		Curve25519Field.Twice(Y1.x, _2Y1);
		uint[] _2Y1Squared = Nat256.Create();
		Curve25519Field.Multiply(_2Y1, Y1.x, _2Y1Squared);
		uint[] S = Nat256.Create();
		Curve25519Field.Multiply(_2Y1Squared, X1.x, S);
		Curve25519Field.Twice(S, S);
		uint[] _8T = Nat256.Create();
		Curve25519Field.Square(_2Y1Squared, _8T);
		Curve25519Field.Twice(_8T, _8T);
		Curve25519FieldElement X3 = new Curve25519FieldElement(_2Y1Squared);
		Curve25519Field.Square(M, X3.x);
		Curve25519Field.Subtract(X3.x, S, X3.x);
		Curve25519Field.Subtract(X3.x, S, X3.x);
		Curve25519FieldElement Y3 = new Curve25519FieldElement(S);
		Curve25519Field.Subtract(S, X3.x, Y3.x);
		Curve25519Field.Multiply(Y3.x, M, Y3.x);
		Curve25519Field.Subtract(Y3.x, _8T, Y3.x);
		Curve25519FieldElement Z3 = new Curve25519FieldElement(_2Y1);
		if (!Nat256.IsOne(Z1.x))
		{
			Curve25519Field.Multiply(Z3.x, Z1.x, Z3.x);
		}
		Curve25519FieldElement W3 = null;
		if (calculateW)
		{
			W3 = new Curve25519FieldElement(_8T);
			Curve25519Field.Multiply(W3.x, W1.x, W3.x);
			Curve25519Field.Twice(W3.x, W3.x);
		}
		return new Curve25519Point(Curve, X3, Y3, new ECFieldElement[2] { Z3, W3 }, base.IsCompressed);
	}
}
