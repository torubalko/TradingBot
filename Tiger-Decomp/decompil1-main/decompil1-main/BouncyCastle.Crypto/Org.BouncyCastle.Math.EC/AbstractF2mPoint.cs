using System;

namespace Org.BouncyCastle.Math.EC;

public abstract class AbstractF2mPoint : ECPointBase
{
	protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
	}

	protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override bool SatisfiesCurveEquation()
	{
		ECCurve curve = Curve;
		ECFieldElement X = base.RawXCoord;
		ECFieldElement Y = base.RawYCoord;
		ECFieldElement A = curve.A;
		ECFieldElement B = curve.B;
		int coord = curve.CoordinateSystem;
		ECFieldElement rhs;
		ECFieldElement lhs;
		if (coord == 6)
		{
			ECFieldElement Z = base.RawZCoords[0];
			bool ZIsOne = Z.IsOne;
			if (X.IsZero)
			{
				lhs = Y.Square();
				rhs = B;
				if (!ZIsOne)
				{
					ECFieldElement Z2 = Z.Square();
					rhs = rhs.Multiply(Z2);
				}
			}
			else
			{
				ECFieldElement L = Y;
				ECFieldElement X2 = X.Square();
				if (ZIsOne)
				{
					lhs = L.Square().Add(L).Add(A);
					rhs = X2.Square().Add(B);
				}
				else
				{
					ECFieldElement Z3 = Z.Square();
					ECFieldElement Z4 = Z3.Square();
					lhs = L.Add(Z).MultiplyPlusProduct(L, A, Z3);
					rhs = X2.SquarePlusProduct(B, Z4);
				}
				lhs = lhs.Multiply(X2);
			}
		}
		else
		{
			lhs = Y.Add(X).Multiply(Y);
			switch (coord)
			{
			case 1:
			{
				ECFieldElement Z5 = base.RawZCoords[0];
				if (!Z5.IsOne)
				{
					ECFieldElement Z6 = Z5.Square();
					ECFieldElement Z7 = Z5.Multiply(Z6);
					lhs = lhs.Multiply(Z5);
					A = A.Multiply(Z5);
					B = B.Multiply(Z7);
				}
				break;
			}
			default:
				throw new InvalidOperationException("unsupported coordinate system");
			case 0:
				break;
			}
			rhs = X.Add(A).Multiply(X.Square()).Add(B);
		}
		return lhs.Equals(rhs);
	}

	protected override bool SatisfiesOrder()
	{
		ECCurve curve = Curve;
		BigInteger cofactor = curve.Cofactor;
		if (BigInteger.Two.Equals(cofactor))
		{
			ECFieldElement X = Normalize().AffineXCoord;
			return ((AbstractF2mFieldElement)X).Trace() != 0;
		}
		if (BigInteger.ValueOf(4L).Equals(cofactor))
		{
			ECPoint N = Normalize();
			ECFieldElement X2 = N.AffineXCoord;
			ECFieldElement L = ((AbstractF2mCurve)curve).SolveQuadraticEquation(X2.Add(curve.A));
			if (L == null)
			{
				return false;
			}
			ECFieldElement Y = N.AffineYCoord;
			ECFieldElement T = X2.Multiply(L).Add(Y);
			return ((AbstractF2mFieldElement)T).Trace() == 0;
		}
		return base.SatisfiesOrder();
	}

	public override ECPoint ScaleX(ECFieldElement scale)
	{
		if (base.IsInfinity)
		{
			return this;
		}
		switch (CurveCoordinateSystem)
		{
		case 5:
		{
			ECFieldElement X3 = base.RawXCoord;
			ECFieldElement rawYCoord2 = base.RawYCoord;
			ECFieldElement X4 = X3.Multiply(scale);
			ECFieldElement L3 = rawYCoord2.Add(X3).Divide(scale).Add(X4);
			return Curve.CreateRawPoint(X3, L3, base.RawZCoords, base.IsCompressed);
		}
		case 6:
		{
			ECFieldElement X = base.RawXCoord;
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement Z = base.RawZCoords[0];
			ECFieldElement X2 = X.Multiply(scale.Square());
			ECFieldElement L2 = rawYCoord.Add(X).Add(X2);
			ECFieldElement Z2 = Z.Multiply(scale);
			return Curve.CreateRawPoint(X, L2, new ECFieldElement[1] { Z2 }, base.IsCompressed);
		}
		default:
			return base.ScaleX(scale);
		}
	}

	public override ECPoint ScaleXNegateY(ECFieldElement scale)
	{
		return ScaleX(scale);
	}

	public override ECPoint ScaleY(ECFieldElement scale)
	{
		if (base.IsInfinity)
		{
			return this;
		}
		int curveCoordinateSystem = CurveCoordinateSystem;
		if ((uint)(curveCoordinateSystem - 5) <= 1u)
		{
			ECFieldElement X = base.RawXCoord;
			ECFieldElement L2 = base.RawYCoord.Add(X).Multiply(scale).Add(X);
			return Curve.CreateRawPoint(X, L2, base.RawZCoords, base.IsCompressed);
		}
		return base.ScaleY(scale);
	}

	public override ECPoint ScaleYNegateX(ECFieldElement scale)
	{
		return ScaleY(scale);
	}

	public override ECPoint Subtract(ECPoint b)
	{
		if (b.IsInfinity)
		{
			return this;
		}
		return Add(b.Negate());
	}

	public virtual AbstractF2mPoint Tau()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		int coord = curve.CoordinateSystem;
		ECFieldElement X1 = base.RawXCoord;
		switch (coord)
		{
		case 0:
		case 5:
		{
			ECFieldElement Y2 = base.RawYCoord;
			return (AbstractF2mPoint)curve.CreateRawPoint(X1.Square(), Y2.Square(), base.IsCompressed);
		}
		case 1:
		case 6:
		{
			ECFieldElement Y1 = base.RawYCoord;
			ECFieldElement Z1 = base.RawZCoords[0];
			return (AbstractF2mPoint)curve.CreateRawPoint(X1.Square(), Y1.Square(), new ECFieldElement[1] { Z1.Square() }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		}
	}

	public virtual AbstractF2mPoint TauPow(int pow)
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		int coord = curve.CoordinateSystem;
		ECFieldElement X1 = base.RawXCoord;
		switch (coord)
		{
		case 0:
		case 5:
		{
			ECFieldElement Y2 = base.RawYCoord;
			return (AbstractF2mPoint)curve.CreateRawPoint(X1.SquarePow(pow), Y2.SquarePow(pow), base.IsCompressed);
		}
		case 1:
		case 6:
		{
			ECFieldElement Y1 = base.RawYCoord;
			ECFieldElement Z1 = base.RawZCoords[0];
			return (AbstractF2mPoint)curve.CreateRawPoint(X1.SquarePow(pow), Y1.SquarePow(pow), new ECFieldElement[1] { Z1.SquarePow(pow) }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		}
	}
}
