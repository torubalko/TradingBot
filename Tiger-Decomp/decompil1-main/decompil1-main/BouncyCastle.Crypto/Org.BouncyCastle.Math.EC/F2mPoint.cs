using System;

namespace Org.BouncyCastle.Math.EC;

public class F2mPoint : AbstractF2mPoint
{
	public override ECFieldElement YCoord
	{
		get
		{
			int coord = CurveCoordinateSystem;
			if ((uint)(coord - 5) <= 1u)
			{
				ECFieldElement X = base.RawXCoord;
				ECFieldElement L = base.RawYCoord;
				if (base.IsInfinity || X.IsZero)
				{
					return L;
				}
				ECFieldElement Y = L.Add(X).Multiply(X);
				if (6 == coord)
				{
					ECFieldElement Z = base.RawZCoords[0];
					if (!Z.IsOne)
					{
						Y = Y.Divide(Z);
					}
				}
				return Y;
			}
			return base.RawYCoord;
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
			ECFieldElement Y = base.RawYCoord;
			int curveCoordinateSystem = CurveCoordinateSystem;
			if ((uint)(curveCoordinateSystem - 5) <= 1u)
			{
				return Y.TestBitZero() != X.TestBitZero();
			}
			return Y.Divide(X).TestBitZero();
		}
	}

	[Obsolete("Use ECCurve.CreatePoint to construct points")]
	public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	[Obsolete("Per-point compression property will be removed, see GetEncoded(bool)")]
	public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
		if (x != null)
		{
			F2mFieldElement.CheckFieldElements(x, y);
			if (curve != null)
			{
				F2mFieldElement.CheckFieldElements(x, curve.A);
			}
		}
	}

	internal F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new F2mPoint(null, AffineXCoord, AffineYCoord, withCompression: false);
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
		int coord = curve.CoordinateSystem;
		ECFieldElement X1 = base.RawXCoord;
		ECFieldElement X2 = b.RawXCoord;
		switch (coord)
		{
		case 0:
		{
			ECFieldElement Y6 = base.RawYCoord;
			ECFieldElement Y7 = b.RawYCoord;
			ECFieldElement dx = X1.Add(X2);
			ECFieldElement dy = Y6.Add(Y7);
			if (dx.IsZero)
			{
				if (dy.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement L5 = dy.Divide(dx);
			ECFieldElement X5 = L5.Square().Add(L5).Add(dx)
				.Add(curve.A);
			ECFieldElement Y8 = L5.Multiply(X1.Add(X5)).Add(X5).Add(Y6);
			return new F2mPoint(curve, X5, Y8, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement Y3 = base.RawYCoord;
			ECFieldElement Z4 = base.RawZCoords[0];
			ECFieldElement Y4 = b.RawYCoord;
			ECFieldElement Z5 = b.RawZCoords[0];
			bool Z1IsOne2 = Z4.IsOne;
			ECFieldElement U4 = Y4;
			ECFieldElement V1 = X2;
			if (!Z1IsOne2)
			{
				U4 = U4.Multiply(Z4);
				V1 = V1.Multiply(Z4);
			}
			bool Z2IsOne2 = Z5.IsOne;
			ECFieldElement U5 = Y3;
			ECFieldElement V2 = X1;
			if (!Z2IsOne2)
			{
				U5 = U5.Multiply(Z5);
				V2 = V2.Multiply(Z5);
			}
			ECFieldElement U6 = U4.Add(U5);
			ECFieldElement V3 = V1.Add(V2);
			if (V3.IsZero)
			{
				if (U6.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement VSq = V3.Square();
			ECFieldElement VCu = VSq.Multiply(V3);
			ECFieldElement W = (Z1IsOne2 ? Z5 : (Z2IsOne2 ? Z4 : Z4.Multiply(Z5)));
			ECFieldElement uv = U6.Add(V3);
			ECFieldElement A2 = uv.MultiplyPlusProduct(U6, VSq, curve.A).Multiply(W).Add(VCu);
			ECFieldElement X4 = V3.Multiply(A2);
			ECFieldElement VSqZ2 = (Z2IsOne2 ? VSq : VSq.Multiply(Z5));
			ECFieldElement Y5 = U6.MultiplyPlusProduct(X1, V3, Y3).MultiplyPlusProduct(VSqZ2, uv, A2);
			ECFieldElement Z6 = VCu.Multiply(W);
			return new F2mPoint(curve, X4, Y5, new ECFieldElement[1] { Z6 }, base.IsCompressed);
		}
		case 6:
		{
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
				X1 = eCPoint.RawXCoord;
				ECFieldElement Y1 = eCPoint.YCoord;
				ECFieldElement Y2 = L2;
				ECFieldElement L3 = Y1.Add(Y2).Divide(X1);
				X3 = L3.Square().Add(L3).Add(X1)
					.Add(curve.A);
				if (X3.IsZero)
				{
					return new F2mPoint(curve, X3, curve.B.Sqrt(), base.IsCompressed);
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
					return new F2mPoint(curve, X3, curve.B.Sqrt(), base.IsCompressed);
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
			return new F2mPoint(curve, X3, L4, new ECFieldElement[1] { Z3 }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		}
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
		switch (curve.CoordinateSystem)
		{
		case 0:
		{
			ECFieldElement L4 = base.RawYCoord.Divide(X1).Add(X1);
			ECFieldElement X4 = L4.Square().Add(L4).Add(curve.A);
			ECFieldElement Y3 = X1.SquarePlusProduct(X4, L4.AddOne());
			return new F2mPoint(curve, X4, Y3, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement Y4 = base.RawYCoord;
			ECFieldElement Z4 = base.RawZCoords[0];
			bool isOne = Z4.IsOne;
			ECFieldElement X1Z1 = (isOne ? X1 : X1.Multiply(Z4));
			ECFieldElement Y1Z1 = (isOne ? Y4 : Y4.Multiply(Z4));
			ECFieldElement eCFieldElement = X1.Square();
			ECFieldElement S = eCFieldElement.Add(Y1Z1);
			ECFieldElement V = X1Z1;
			ECFieldElement vSquared = V.Square();
			ECFieldElement sv = S.Add(V);
			ECFieldElement h = sv.MultiplyPlusProduct(S, vSquared, curve.A);
			ECFieldElement X5 = V.Multiply(h);
			ECFieldElement Y5 = eCFieldElement.Square().MultiplyPlusProduct(V, h, sv);
			ECFieldElement Z5 = V.Multiply(vSquared);
			return new F2mPoint(curve, X5, Y5, new ECFieldElement[1] { Z5 }, base.IsCompressed);
		}
		case 6:
		{
			ECFieldElement L1 = base.RawYCoord;
			ECFieldElement Z1 = base.RawZCoords[0];
			bool Z1IsOne = Z1.IsOne;
			ECFieldElement L1Z1 = (Z1IsOne ? L1 : L1.Multiply(Z1));
			ECFieldElement Z1Sq = (Z1IsOne ? Z1 : Z1.Square());
			ECFieldElement a = curve.A;
			ECFieldElement aZ1Sq = (Z1IsOne ? a : a.Multiply(Z1Sq));
			ECFieldElement T = L1.Square().Add(L1Z1).Add(aZ1Sq);
			if (T.IsZero)
			{
				return new F2mPoint(curve, T, curve.B.Sqrt(), base.IsCompressed);
			}
			ECFieldElement X3 = T.Square();
			ECFieldElement Z3 = (Z1IsOne ? T : T.Multiply(Z1Sq));
			ECFieldElement b = curve.B;
			ECFieldElement L3;
			if (b.BitLength < curve.FieldSize >> 1)
			{
				ECFieldElement t1 = L1.Add(X1).Square();
				ECFieldElement t2 = ((!b.IsOne) ? aZ1Sq.SquarePlusProduct(b, Z1Sq.Square()) : aZ1Sq.Add(Z1Sq).Square());
				L3 = t1.Add(T).Add(Z1Sq).Multiply(t1)
					.Add(t2)
					.Add(X3);
				if (a.IsZero)
				{
					L3 = L3.Add(Z3);
				}
				else if (!a.IsOne)
				{
					L3 = L3.Add(a.AddOne().Multiply(Z3));
				}
			}
			else
			{
				L3 = (Z1IsOne ? X1 : X1.Multiply(Z1)).SquarePlusProduct(T, L1Z1).Add(X3).Add(Z3);
			}
			return new F2mPoint(curve, X3, L3, new ECFieldElement[1] { Z3 }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		}
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
		if (curve.CoordinateSystem == 6)
		{
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
			ECFieldElement T = curve.A.Multiply(Z1Sq).Add(L1Sq).Add(L1Z1);
			ECFieldElement L2plus1 = L2.AddOne();
			ECFieldElement A = curve.A.Add(L2plus1).Multiply(Z1Sq).Add(L1Sq)
				.MultiplyPlusProduct(T, X1Sq, Z1Sq);
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
				return new F2mPoint(curve, A, curve.B.Sqrt(), base.IsCompressed);
			}
			ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
			ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
			ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2plus1, Z4);
			return new F2mPoint(curve, X3, L3, new ECFieldElement[1] { Z4 }, base.IsCompressed);
		}
		return Twice().Add(b);
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
		ECCurve curve = Curve;
		switch (curve.CoordinateSystem)
		{
		case 0:
		{
			ECFieldElement Y2 = base.RawYCoord;
			return new F2mPoint(curve, X, Y2.Add(X), base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement Y = base.RawYCoord;
			ECFieldElement Z2 = base.RawZCoords[0];
			return new F2mPoint(curve, X, Y.Add(X), new ECFieldElement[1] { Z2 }, base.IsCompressed);
		}
		case 5:
		{
			ECFieldElement L2 = base.RawYCoord;
			return new F2mPoint(curve, X, L2.AddOne(), base.IsCompressed);
		}
		case 6:
		{
			ECFieldElement L = base.RawYCoord;
			ECFieldElement Z = base.RawZCoords[0];
			return new F2mPoint(curve, X, L.Add(Z), new ECFieldElement[1] { Z }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		}
	}
}
