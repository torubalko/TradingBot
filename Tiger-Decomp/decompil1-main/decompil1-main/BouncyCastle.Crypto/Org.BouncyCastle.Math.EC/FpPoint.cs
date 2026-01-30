using System;

namespace Org.BouncyCastle.Math.EC;

public class FpPoint : AbstractFpPoint
{
	[Obsolete("Use ECCurve.CreatePoint to construct points")]
	public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	[Obsolete("Per-point compression property will be removed, see GetEncoded(bool)")]
	public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new FpPoint(null, AffineXCoord, AffineYCoord, withCompression: false);
	}

	public override ECFieldElement GetZCoord(int index)
	{
		if (index == 1 && 4 == CurveCoordinateSystem)
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
		int coord = curve.CoordinateSystem;
		ECFieldElement X1 = base.RawXCoord;
		ECFieldElement Y1 = base.RawYCoord;
		ECFieldElement X2 = b.RawXCoord;
		ECFieldElement Y2 = b.RawYCoord;
		switch (coord)
		{
		case 0:
		{
			ECFieldElement dx2 = X2.Subtract(X1);
			ECFieldElement dy2 = Y2.Subtract(Y1);
			if (dx2.IsZero)
			{
				if (dy2.IsZero)
				{
					return Twice();
				}
				return Curve.Infinity;
			}
			ECFieldElement eCFieldElement4 = dy2.Divide(dx2);
			ECFieldElement X5 = eCFieldElement4.Square().Subtract(X1).Subtract(X2);
			ECFieldElement Y5 = eCFieldElement4.Multiply(X1.Subtract(X5)).Subtract(Y1);
			return new FpPoint(Curve, X5, Y5, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement Z4 = base.RawZCoords[0];
			ECFieldElement Z5 = b.RawZCoords[0];
			bool Z1IsOne2 = Z4.IsOne;
			bool Z2IsOne2 = Z5.IsOne;
			ECFieldElement obj = (Z1IsOne2 ? Y2 : Y2.Multiply(Z4));
			ECFieldElement u2 = (Z2IsOne2 ? Y1 : Y1.Multiply(Z5));
			ECFieldElement u3 = obj.Subtract(u2);
			ECFieldElement obj2 = (Z1IsOne2 ? X2 : X2.Multiply(Z4));
			ECFieldElement v2 = (Z2IsOne2 ? X1 : X1.Multiply(Z5));
			ECFieldElement v3 = obj2.Subtract(v2);
			if (v3.IsZero)
			{
				if (u3.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement w = (Z1IsOne2 ? Z5 : (Z2IsOne2 ? Z4 : Z4.Multiply(Z5)));
			ECFieldElement eCFieldElement3 = v3.Square();
			ECFieldElement vCubed = eCFieldElement3.Multiply(v3);
			ECFieldElement vSquaredV2 = eCFieldElement3.Multiply(v2);
			ECFieldElement A2 = u3.Square().Multiply(w).Subtract(vCubed)
				.Subtract(Two(vSquaredV2));
			ECFieldElement X4 = v3.Multiply(A2);
			ECFieldElement Y4 = vSquaredV2.Subtract(A2).MultiplyMinusProduct(u3, u2, vCubed);
			ECFieldElement Z6 = vCubed.Multiply(w);
			return new FpPoint(curve, X4, Y4, new ECFieldElement[1] { Z6 }, base.IsCompressed);
		}
		case 2:
		case 4:
		{
			ECFieldElement Z1 = base.RawZCoords[0];
			ECFieldElement Z2 = b.RawZCoords[0];
			bool Z1IsOne = Z1.IsOne;
			ECFieldElement Z3Squared = null;
			ECFieldElement X3;
			ECFieldElement Y3;
			ECFieldElement Z3;
			if (!Z1IsOne && Z1.Equals(Z2))
			{
				ECFieldElement dx = X1.Subtract(X2);
				ECFieldElement dy = Y1.Subtract(Y2);
				if (dx.IsZero)
				{
					if (dy.IsZero)
					{
						return Twice();
					}
					return curve.Infinity;
				}
				ECFieldElement C = dx.Square();
				ECFieldElement W1 = X1.Multiply(C);
				ECFieldElement W2 = X2.Multiply(C);
				ECFieldElement A1 = W1.Subtract(W2).Multiply(Y1);
				X3 = dy.Square().Subtract(W1).Subtract(W2);
				Y3 = W1.Subtract(X3).Multiply(dy).Subtract(A1);
				Z3 = dx;
				if (Z1IsOne)
				{
					Z3Squared = C;
				}
				else
				{
					Z3 = Z3.Multiply(Z1);
				}
			}
			else
			{
				ECFieldElement U2;
				ECFieldElement S2;
				if (Z1IsOne)
				{
					U2 = X2;
					S2 = Y2;
				}
				else
				{
					ECFieldElement eCFieldElement = Z1.Square();
					U2 = eCFieldElement.Multiply(X2);
					S2 = eCFieldElement.Multiply(Z1).Multiply(Y2);
				}
				bool Z2IsOne = Z2.IsOne;
				ECFieldElement U3;
				ECFieldElement S3;
				if (Z2IsOne)
				{
					U3 = X1;
					S3 = Y1;
				}
				else
				{
					ECFieldElement eCFieldElement2 = Z2.Square();
					U3 = eCFieldElement2.Multiply(X1);
					S3 = eCFieldElement2.Multiply(Z2).Multiply(Y1);
				}
				ECFieldElement H = U3.Subtract(U2);
				ECFieldElement R = S3.Subtract(S2);
				if (H.IsZero)
				{
					if (R.IsZero)
					{
						return Twice();
					}
					return curve.Infinity;
				}
				ECFieldElement HSquared = H.Square();
				ECFieldElement G = HSquared.Multiply(H);
				ECFieldElement V = HSquared.Multiply(U3);
				X3 = R.Square().Add(G).Subtract(Two(V));
				Y3 = V.Subtract(X3).MultiplyMinusProduct(R, G, S3);
				Z3 = H;
				if (!Z1IsOne)
				{
					Z3 = Z3.Multiply(Z1);
				}
				if (!Z2IsOne)
				{
					Z3 = Z3.Multiply(Z2);
				}
				if (Z3 == H)
				{
					Z3Squared = HSquared;
				}
			}
			ECFieldElement[] zs;
			if (coord == 4)
			{
				ECFieldElement W3 = CalculateJacobianModifiedW(Z3, Z3Squared);
				zs = new ECFieldElement[2] { Z3, W3 };
			}
			else
			{
				zs = new ECFieldElement[1] { Z3 };
			}
			return new FpPoint(curve, X3, Y3, zs, base.IsCompressed);
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
		ECFieldElement Y1 = base.RawYCoord;
		if (Y1.IsZero)
		{
			return curve.Infinity;
		}
		int coord = curve.CoordinateSystem;
		ECFieldElement X1 = base.RawXCoord;
		switch (coord)
		{
		case 0:
		{
			ECFieldElement X1Squared2 = X1.Square();
			ECFieldElement eCFieldElement = Three(X1Squared2).Add(Curve.A).Divide(Two(Y1));
			ECFieldElement X4 = eCFieldElement.Square().Subtract(Two(X1));
			ECFieldElement Y4 = eCFieldElement.Multiply(X1.Subtract(X4)).Subtract(Y1);
			return new FpPoint(Curve, X4, Y4, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement Z4 = base.RawZCoords[0];
			bool Z1IsOne2 = Z4.IsOne;
			ECFieldElement w = curve.A;
			if (!w.IsZero && !Z1IsOne2)
			{
				w = w.Multiply(Z4.Square());
			}
			w = w.Add(Three(X1.Square()));
			ECFieldElement s = (Z1IsOne2 ? Y1 : Y1.Multiply(Z4));
			ECFieldElement t = (Z1IsOne2 ? Y1.Square() : s.Multiply(Y1));
			ECFieldElement B = X1.Multiply(t);
			ECFieldElement _4B = Four(B);
			ECFieldElement h = w.Square().Subtract(Two(_4B));
			ECFieldElement _2s = Two(s);
			ECFieldElement X5 = h.Multiply(_2s);
			ECFieldElement _2t = Two(t);
			ECFieldElement Y5 = _4B.Subtract(h).Multiply(w).Subtract(Two(_2t.Square()));
			ECFieldElement _4sSquared = (Z1IsOne2 ? Two(_2t) : _2s.Square());
			ECFieldElement Z5 = Two(_4sSquared).Multiply(s);
			return new FpPoint(curve, X5, Y5, new ECFieldElement[1] { Z5 }, base.IsCompressed);
		}
		case 2:
		{
			ECFieldElement Z1 = base.RawZCoords[0];
			bool Z1IsOne = Z1.IsOne;
			ECFieldElement Y1Squared = Y1.Square();
			ECFieldElement T = Y1Squared.Square();
			ECFieldElement a4 = curve.A;
			ECFieldElement a4Neg = a4.Negate();
			ECFieldElement M;
			ECFieldElement S;
			if (a4Neg.ToBigInteger().Equals(BigInteger.ValueOf(3L)))
			{
				ECFieldElement Z1Squared = (Z1IsOne ? Z1 : Z1.Square());
				M = Three(X1.Add(Z1Squared).Multiply(X1.Subtract(Z1Squared)));
				S = Four(Y1Squared.Multiply(X1));
			}
			else
			{
				ECFieldElement X1Squared = X1.Square();
				M = Three(X1Squared);
				if (Z1IsOne)
				{
					M = M.Add(a4);
				}
				else if (!a4.IsZero)
				{
					ECFieldElement Z1Pow4 = (Z1IsOne ? Z1 : Z1.Square()).Square();
					M = ((a4Neg.BitLength >= a4.BitLength) ? M.Add(Z1Pow4.Multiply(a4)) : M.Subtract(Z1Pow4.Multiply(a4Neg)));
				}
				S = Four(X1.Multiply(Y1Squared));
			}
			ECFieldElement X3 = M.Square().Subtract(Two(S));
			ECFieldElement Y3 = S.Subtract(X3).Multiply(M).Subtract(Eight(T));
			ECFieldElement Z3 = Two(Y1);
			if (!Z1IsOne)
			{
				Z3 = Z3.Multiply(Z1);
			}
			return new FpPoint(curve, X3, Y3, new ECFieldElement[1] { Z3 }, base.IsCompressed);
		}
		case 4:
			return TwiceJacobianModified(calculateW: true);
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		}
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
		ECFieldElement Y1 = base.RawYCoord;
		if (Y1.IsZero)
		{
			return b;
		}
		switch (Curve.CoordinateSystem)
		{
		case 0:
		{
			ECFieldElement X1 = base.RawXCoord;
			ECFieldElement X2 = b.RawXCoord;
			ECFieldElement rawYCoord = b.RawYCoord;
			ECFieldElement dx = X2.Subtract(X1);
			ECFieldElement dy = rawYCoord.Subtract(Y1);
			if (dx.IsZero)
			{
				if (dy.IsZero)
				{
					return ThreeTimes();
				}
				return this;
			}
			ECFieldElement X3 = dx.Square();
			ECFieldElement Y2 = dy.Square();
			ECFieldElement d = X3.Multiply(Two(X1).Add(X2)).Subtract(Y2);
			if (d.IsZero)
			{
				return Curve.Infinity;
			}
			ECFieldElement I = d.Multiply(dx).Invert();
			ECFieldElement L1 = d.Multiply(I).Multiply(dy);
			ECFieldElement L2 = Two(Y1).Multiply(X3).Multiply(dx).Multiply(I)
				.Subtract(L1);
			ECFieldElement X4 = L2.Subtract(L1).Multiply(L1.Add(L2)).Add(X2);
			ECFieldElement Y4 = X1.Subtract(X4).Multiply(L2).Subtract(Y1);
			return new FpPoint(Curve, X4, Y4, base.IsCompressed);
		}
		case 4:
			return TwiceJacobianModified(calculateW: false).Add(b);
		default:
			return Twice().Add(b);
		}
	}

	public override ECPoint ThreeTimes()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECFieldElement Y1 = base.RawYCoord;
		if (Y1.IsZero)
		{
			return this;
		}
		switch (Curve.CoordinateSystem)
		{
		case 0:
		{
			ECFieldElement X1 = base.RawXCoord;
			ECFieldElement _2Y1 = Two(Y1);
			ECFieldElement X2 = _2Y1.Square();
			ECFieldElement Z = Three(X1.Square()).Add(Curve.A);
			ECFieldElement Y2 = Z.Square();
			ECFieldElement d = Three(X1).Multiply(X2).Subtract(Y2);
			if (d.IsZero)
			{
				return Curve.Infinity;
			}
			ECFieldElement I = d.Multiply(_2Y1).Invert();
			ECFieldElement L1 = d.Multiply(I).Multiply(Z);
			ECFieldElement L2 = X2.Square().Multiply(I).Subtract(L1);
			ECFieldElement X4 = L2.Subtract(L1).Multiply(L1.Add(L2)).Add(X1);
			ECFieldElement Y4 = X1.Subtract(X4).Multiply(L2).Subtract(Y1);
			return new FpPoint(Curve, X4, Y4, base.IsCompressed);
		}
		case 4:
			return TwiceJacobianModified(calculateW: false).Add(this);
		default:
			return Twice().Add(this);
		}
	}

	public override ECPoint TimesPow2(int e)
	{
		if (e < 0)
		{
			throw new ArgumentException("cannot be negative", "e");
		}
		if (e == 0 || base.IsInfinity)
		{
			return this;
		}
		if (e == 1)
		{
			return Twice();
		}
		ECCurve curve = Curve;
		ECFieldElement Y1 = base.RawYCoord;
		if (Y1.IsZero)
		{
			return curve.Infinity;
		}
		int coord = curve.CoordinateSystem;
		ECFieldElement W1 = curve.A;
		ECFieldElement X1 = base.RawXCoord;
		ECFieldElement Z1 = ((base.RawZCoords.Length < 1) ? curve.FromBigInteger(BigInteger.One) : base.RawZCoords[0]);
		if (!Z1.IsOne)
		{
			switch (coord)
			{
			case 1:
			{
				ECFieldElement Z1Sq = Z1.Square();
				X1 = X1.Multiply(Z1);
				Y1 = Y1.Multiply(Z1Sq);
				W1 = CalculateJacobianModifiedW(Z1, Z1Sq);
				break;
			}
			case 2:
				W1 = CalculateJacobianModifiedW(Z1, null);
				break;
			case 4:
				W1 = GetJacobianModifiedW();
				break;
			}
		}
		for (int i = 0; i < e; i++)
		{
			if (Y1.IsZero)
			{
				return curve.Infinity;
			}
			ECFieldElement X1Squared = X1.Square();
			ECFieldElement M = Three(X1Squared);
			ECFieldElement _2Y1 = Two(Y1);
			ECFieldElement _2Y1Squared = _2Y1.Multiply(Y1);
			ECFieldElement S = Two(X1.Multiply(_2Y1Squared));
			ECFieldElement _4T = _2Y1Squared.Square();
			ECFieldElement _8T = Two(_4T);
			if (!W1.IsZero)
			{
				M = M.Add(W1);
				W1 = Two(_8T.Multiply(W1));
			}
			X1 = M.Square().Subtract(Two(S));
			Y1 = M.Multiply(S.Subtract(X1)).Subtract(_8T);
			Z1 = (Z1.IsOne ? _2Y1 : _2Y1.Multiply(Z1));
		}
		switch (coord)
		{
		case 0:
		{
			ECFieldElement zInv = Z1.Invert();
			ECFieldElement zInv2 = zInv.Square();
			ECFieldElement zInv3 = zInv2.Multiply(zInv);
			return new FpPoint(curve, X1.Multiply(zInv2), Y1.Multiply(zInv3), base.IsCompressed);
		}
		case 1:
			X1 = X1.Multiply(Z1);
			Z1 = Z1.Multiply(Z1.Square());
			return new FpPoint(curve, X1, Y1, new ECFieldElement[1] { Z1 }, base.IsCompressed);
		case 2:
			return new FpPoint(curve, X1, Y1, new ECFieldElement[1] { Z1 }, base.IsCompressed);
		case 4:
			return new FpPoint(curve, X1, Y1, new ECFieldElement[2] { Z1, W1 }, base.IsCompressed);
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		}
	}

	protected virtual ECFieldElement Two(ECFieldElement x)
	{
		return x.Add(x);
	}

	protected virtual ECFieldElement Three(ECFieldElement x)
	{
		return Two(x).Add(x);
	}

	protected virtual ECFieldElement Four(ECFieldElement x)
	{
		return Two(Two(x));
	}

	protected virtual ECFieldElement Eight(ECFieldElement x)
	{
		return Four(Two(x));
	}

	protected virtual ECFieldElement DoubleProductFromSquares(ECFieldElement a, ECFieldElement b, ECFieldElement aSquared, ECFieldElement bSquared)
	{
		return a.Add(b).Square().Subtract(aSquared)
			.Subtract(bSquared);
	}

	public override ECPoint Negate()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		if (curve.CoordinateSystem != 0)
		{
			return new FpPoint(curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}
		return new FpPoint(curve, base.RawXCoord, base.RawYCoord.Negate(), base.IsCompressed);
	}

	protected virtual ECFieldElement CalculateJacobianModifiedW(ECFieldElement Z, ECFieldElement ZSquared)
	{
		ECFieldElement a4 = Curve.A;
		if (a4.IsZero || Z.IsOne)
		{
			return a4;
		}
		if (ZSquared == null)
		{
			ZSquared = Z.Square();
		}
		ECFieldElement W = ZSquared.Square();
		ECFieldElement a4Neg = a4.Negate();
		if (a4Neg.BitLength < a4.BitLength)
		{
			return W.Multiply(a4Neg).Negate();
		}
		return W.Multiply(a4);
	}

	protected virtual ECFieldElement GetJacobianModifiedW()
	{
		ECFieldElement[] ZZ = base.RawZCoords;
		ECFieldElement W = ZZ[1];
		if (W == null)
		{
			W = (ZZ[1] = CalculateJacobianModifiedW(ZZ[0], null));
		}
		return W;
	}

	protected virtual FpPoint TwiceJacobianModified(bool calculateW)
	{
		ECFieldElement X1 = base.RawXCoord;
		ECFieldElement Y1 = base.RawYCoord;
		ECFieldElement Z1 = base.RawZCoords[0];
		ECFieldElement W1 = GetJacobianModifiedW();
		ECFieldElement X1Squared = X1.Square();
		ECFieldElement eCFieldElement = Three(X1Squared).Add(W1);
		ECFieldElement _2Y1 = Two(Y1);
		ECFieldElement _2Y1Squared = _2Y1.Multiply(Y1);
		ECFieldElement S = Two(X1.Multiply(_2Y1Squared));
		ECFieldElement X3 = eCFieldElement.Square().Subtract(Two(S));
		ECFieldElement _4T = _2Y1Squared.Square();
		ECFieldElement _8T = Two(_4T);
		ECFieldElement Y3 = eCFieldElement.Multiply(S.Subtract(X3)).Subtract(_8T);
		ECFieldElement W3 = (calculateW ? Two(_8T.Multiply(W1)) : null);
		ECFieldElement Z3 = (Z1.IsOne ? _2Y1 : _2Y1.Multiply(Z1));
		return new FpPoint(Curve, X3, Y3, new ECFieldElement[2] { Z3, W3 }, base.IsCompressed);
	}
}
