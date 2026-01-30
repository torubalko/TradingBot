using System;

namespace Org.BouncyCastle.Math.EC;

public abstract class AbstractFpPoint : ECPointBase
{
	protected internal override bool CompressionYTilde => AffineYCoord.TestBitZero();

	protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
	}

	protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override bool SatisfiesCurveEquation()
	{
		ECFieldElement X = base.RawXCoord;
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement A = Curve.A;
		ECFieldElement B = Curve.B;
		ECFieldElement lhs = rawYCoord.Square();
		switch (CurveCoordinateSystem)
		{
		case 1:
		{
			ECFieldElement Z7 = base.RawZCoords[0];
			if (!Z7.IsOne)
			{
				ECFieldElement Z8 = Z7.Square();
				ECFieldElement Z9 = Z7.Multiply(Z8);
				lhs = lhs.Multiply(Z7);
				A = A.Multiply(Z8);
				B = B.Multiply(Z9);
			}
			break;
		}
		case 2:
		case 3:
		case 4:
		{
			ECFieldElement Z = base.RawZCoords[0];
			if (!Z.IsOne)
			{
				ECFieldElement eCFieldElement = Z.Square();
				ECFieldElement Z4 = eCFieldElement.Square();
				ECFieldElement Z6 = eCFieldElement.Multiply(Z4);
				A = A.Multiply(Z4);
				B = B.Multiply(Z6);
			}
			break;
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 0:
			break;
		}
		ECFieldElement rhs = X.Square().Add(A).Multiply(X)
			.Add(B);
		return lhs.Equals(rhs);
	}

	public override ECPoint Subtract(ECPoint b)
	{
		if (b.IsInfinity)
		{
			return this;
		}
		return Add(b.Negate());
	}
}
