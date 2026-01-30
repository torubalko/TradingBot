using System;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT409R1Point : AbstractF2mPoint
{
	public override ECFieldElement YCoord
	{
		get
		{
			ECFieldElement X = base.RawXCoord;
			ECFieldElement L = base.RawYCoord;
			if (base.IsInfinity || X.IsZero)
			{
				return L;
			}
			ECFieldElement Y = L.Add(X).Multiply(X);
			ECFieldElement Z = base.RawZCoords[0];
			if (!Z.IsOne)
			{
				Y = Y.Divide(Z);
			}
			return Y;
		}
	}

	protected internal override bool CompressionYTilde
	{
		get
		{
			ECFieldElement X = base.RawXCoord;
			if (X.IsZero)
			{
				return false;
			}
			return base.RawYCoord.TestBitZero() != X.TestBitZero();
		}
	}

	public SecT409R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	public SecT409R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal SecT409R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new SecT409R1Point(null, AffineXCoord, AffineYCoord);
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
		ECCurve curve = Curve;
		ECFieldElement X1 = base.RawXCoord;
		ECFieldElement X2 = b.RawXCoord;
		if (X1.IsZero)
		{
			if (X2.IsZero)
			{
				return curve.Infinity;
			}
			return b.Add(this);
		}
		ECFieldElement L1 = base.RawYCoord;
		ECFieldElement Z1 = base.RawZCoords[0];
		ECFieldElement L2 = b.RawYCoord;
		ECFieldElement Z2 = b.RawZCoords[0];
		bool Z1IsOne = Z1.IsOne;
		ECFieldElement U2 = X2;
		ECFieldElement S2 = L2;
		if (!Z1IsOne)
		{
			U2 = U2.Multiply(Z1);
			S2 = S2.Multiply(Z1);
		}
		bool Z2IsOne = Z2.IsOne;
		ECFieldElement U3 = X1;
		ECFieldElement S3 = L1;
		if (!Z2IsOne)
		{
			U3 = U3.Multiply(Z2);
			S3 = S3.Multiply(Z2);
		}
		ECFieldElement A = S3.Add(S2);
		ECFieldElement B = U3.Add(U2);
		if (B.IsZero)
		{
			if (A.IsZero)
			{
				return Twice();
			}
			return curve.Infinity;
		}
		ECFieldElement X3;
		ECFieldElement L4;
		ECFieldElement Z3;
		if (X2.IsZero)
		{
			ECPoint eCPoint = Normalize();
			X1 = eCPoint.XCoord;
			ECFieldElement Y1 = eCPoint.YCoord;
			ECFieldElement Y2 = L2;
			ECFieldElement L3 = Y1.Add(Y2).Divide(X1);
			X3 = L3.Square().Add(L3).Add(X1)
				.AddOne();
			if (X3.IsZero)
			{
				return new SecT409R1Point(curve, X3, curve.B.Sqrt(), base.IsCompressed);
			}
			L4 = L3.Multiply(X1.Add(X3)).Add(X3).Add(Y1)
				.Divide(X3)
				.Add(X3);
			Z3 = curve.FromBigInteger(BigInteger.One);
		}
		else
		{
			B = B.Square();
			ECFieldElement AU1 = A.Multiply(U3);
			ECFieldElement AU2 = A.Multiply(U2);
			X3 = AU1.Multiply(AU2);
			if (X3.IsZero)
			{
				return new SecT409R1Point(curve, X3, curve.B.Sqrt(), base.IsCompressed);
			}
			ECFieldElement ABZ2 = A.Multiply(B);
			if (!Z2IsOne)
			{
				ABZ2 = ABZ2.Multiply(Z2);
			}
			L4 = AU2.Add(B).SquarePlusProduct(ABZ2, L1.Add(Z1));
			Z3 = ABZ2;
			if (!Z1IsOne)
			{
				Z3 = Z3.Multiply(Z1);
			}
		}
		return new SecT409R1Point(curve, X3, L4, new ECFieldElement[1] { Z3 }, base.IsCompressed);
	}

	public override ECPoint Twice()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		ECFieldElement X1 = base.RawXCoord;
		if (X1.IsZero)
		{
			return curve.Infinity;
		}
		ECFieldElement L1 = base.RawYCoord;
		ECFieldElement Z1 = base.RawZCoords[0];
		bool Z1IsOne = Z1.IsOne;
		ECFieldElement L1Z1 = (Z1IsOne ? L1 : L1.Multiply(Z1));
		ECFieldElement Z1Sq = (Z1IsOne ? Z1 : Z1.Square());
		ECFieldElement T = L1.Square().Add(L1Z1).Add(Z1Sq);
		if (T.IsZero)
		{
			return new SecT409R1Point(curve, T, curve.B.Sqrt(), base.IsCompressed);
		}
		ECFieldElement X3 = T.Square();
		ECFieldElement Z3 = (Z1IsOne ? T : T.Multiply(Z1Sq));
		ECFieldElement L3 = (Z1IsOne ? X1 : X1.Multiply(Z1)).SquarePlusProduct(T, L1Z1).Add(X3).Add(Z3);
		return new SecT409R1Point(curve, X3, L3, new ECFieldElement[1] { Z3 }, base.IsCompressed);
	}

	public override ECPoint TwicePlus(ECPoint b)
	{
		if (base.IsInfinity)
		{
			return b;
		}
		if (b.IsInfinity)
		{
			return Twice();
		}
		ECCurve curve = Curve;
		ECFieldElement X1 = base.RawXCoord;
		if (X1.IsZero)
		{
			return b;
		}
		ECFieldElement X2 = b.RawXCoord;
		ECFieldElement Z2 = b.RawZCoords[0];
		if (X2.IsZero || !Z2.IsOne)
		{
			return Twice().Add(b);
		}
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement Z3 = base.RawZCoords[0];
		ECFieldElement L2 = b.RawYCoord;
		ECFieldElement X1Sq = X1.Square();
		ECFieldElement L1Sq = rawYCoord.Square();
		ECFieldElement Z1Sq = Z3.Square();
		ECFieldElement L1Z1 = rawYCoord.Multiply(Z3);
		ECFieldElement T = Z1Sq.Add(L1Sq).Add(L1Z1);
		ECFieldElement A = L2.Multiply(Z1Sq).Add(L1Sq).MultiplyPlusProduct(T, X1Sq, Z1Sq);
		ECFieldElement X2Z1Sq = X2.Multiply(Z1Sq);
		ECFieldElement B = X2Z1Sq.Add(T).Square();
		if (B.IsZero)
		{
			if (A.IsZero)
			{
				return b.Twice();
			}
			return curve.Infinity;
		}
		if (A.IsZero)
		{
			return new SecT409R1Point(curve, A, curve.B.Sqrt(), base.IsCompressed);
		}
		ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
		ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
		ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2.AddOne(), Z4);
		return new SecT409R1Point(curve, X3, L3, new ECFieldElement[1] { Z4 }, base.IsCompressed);
	}

	public override ECPoint Negate()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECFieldElement X = base.RawXCoord;
		if (X.IsZero)
		{
			return this;
		}
		ECFieldElement L = base.RawYCoord;
		ECFieldElement Z = base.RawZCoords[0];
		return new SecT409R1Point(Curve, X, L.Add(Z), new ECFieldElement[1] { Z }, base.IsCompressed);
	}
}
