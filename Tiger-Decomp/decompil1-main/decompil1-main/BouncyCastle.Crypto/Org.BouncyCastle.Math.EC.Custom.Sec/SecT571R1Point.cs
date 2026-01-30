using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT571R1Point : AbstractF2mPoint
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

	public SecT571R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	public SecT571R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal SecT571R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new SecT571R1Point(null, AffineXCoord, AffineYCoord);
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
		SecT571FieldElement X1 = (SecT571FieldElement)base.RawXCoord;
		SecT571FieldElement X2 = (SecT571FieldElement)b.RawXCoord;
		if (X1.IsZero)
		{
			if (X2.IsZero)
			{
				return curve.Infinity;
			}
			return b.Add(this);
		}
		SecT571FieldElement L1 = (SecT571FieldElement)base.RawYCoord;
		SecT571FieldElement Z1 = (SecT571FieldElement)base.RawZCoords[0];
		SecT571FieldElement L2 = (SecT571FieldElement)b.RawYCoord;
		SecT571FieldElement Z2 = (SecT571FieldElement)b.RawZCoords[0];
		ulong[] t1 = Nat576.Create64();
		ulong[] t2 = Nat576.Create64();
		ulong[] t3 = Nat576.Create64();
		ulong[] t4 = Nat576.Create64();
		ulong[] Z1Precomp = (Z1.IsOne ? null : SecT571Field.PrecompMultiplicand(Z1.x));
		ulong[] U2;
		ulong[] S2;
		if (Z1Precomp == null)
		{
			U2 = X2.x;
			S2 = L2.x;
		}
		else
		{
			SecT571Field.MultiplyPrecomp(X2.x, Z1Precomp, U2 = t2);
			SecT571Field.MultiplyPrecomp(L2.x, Z1Precomp, S2 = t4);
		}
		ulong[] Z2Precomp = (Z2.IsOne ? null : SecT571Field.PrecompMultiplicand(Z2.x));
		ulong[] U3;
		ulong[] S3;
		if (Z2Precomp == null)
		{
			U3 = X1.x;
			S3 = L1.x;
		}
		else
		{
			SecT571Field.MultiplyPrecomp(X1.x, Z2Precomp, U3 = t1);
			SecT571Field.MultiplyPrecomp(L1.x, Z2Precomp, S3 = t3);
		}
		ulong[] A = t3;
		SecT571Field.Add(S3, S2, A);
		ulong[] B = t4;
		SecT571Field.Add(U3, U2, B);
		if (Nat576.IsZero64(B))
		{
			if (Nat576.IsZero64(A))
			{
				return Twice();
			}
			return curve.Infinity;
		}
		SecT571FieldElement X3;
		SecT571FieldElement L4;
		SecT571FieldElement Z3;
		if (X2.IsZero)
		{
			ECPoint eCPoint = Normalize();
			X1 = (SecT571FieldElement)eCPoint.XCoord;
			ECFieldElement Y1 = eCPoint.YCoord;
			ECFieldElement Y2 = L2;
			ECFieldElement L3 = Y1.Add(Y2).Divide(X1);
			X3 = (SecT571FieldElement)L3.Square().Add(L3).Add(X1)
				.AddOne();
			if (X3.IsZero)
			{
				return new SecT571R1Point(curve, X3, SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
			}
			L4 = (SecT571FieldElement)L3.Multiply(X1.Add(X3)).Add(X3).Add(Y1)
				.Divide(X3)
				.Add(X3);
			Z3 = (SecT571FieldElement)curve.FromBigInteger(BigInteger.One);
		}
		else
		{
			SecT571Field.Square(B, B);
			ulong[] APrecomp = SecT571Field.PrecompMultiplicand(A);
			ulong[] AU1 = t1;
			ulong[] AU2 = t2;
			SecT571Field.MultiplyPrecomp(U3, APrecomp, AU1);
			SecT571Field.MultiplyPrecomp(U2, APrecomp, AU2);
			X3 = new SecT571FieldElement(t1);
			SecT571Field.Multiply(AU1, AU2, X3.x);
			if (X3.IsZero)
			{
				return new SecT571R1Point(curve, X3, SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
			}
			Z3 = new SecT571FieldElement(t3);
			SecT571Field.MultiplyPrecomp(B, APrecomp, Z3.x);
			if (Z2Precomp != null)
			{
				SecT571Field.MultiplyPrecomp(Z3.x, Z2Precomp, Z3.x);
			}
			ulong[] tt = Nat576.CreateExt64();
			SecT571Field.Add(AU2, B, t4);
			SecT571Field.SquareAddToExt(t4, tt);
			SecT571Field.Add(L1.x, Z1.x, t4);
			SecT571Field.MultiplyAddToExt(t4, Z3.x, tt);
			L4 = new SecT571FieldElement(t4);
			SecT571Field.Reduce(tt, L4.x);
			if (Z1Precomp != null)
			{
				SecT571Field.MultiplyPrecomp(Z3.x, Z1Precomp, Z3.x);
			}
		}
		return new SecT571R1Point(curve, X3, L4, new ECFieldElement[1] { Z3 }, base.IsCompressed);
	}

	public override ECPoint Twice()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		SecT571FieldElement X1 = (SecT571FieldElement)base.RawXCoord;
		if (X1.IsZero)
		{
			return curve.Infinity;
		}
		SecT571FieldElement L1 = (SecT571FieldElement)base.RawYCoord;
		SecT571FieldElement Z1 = (SecT571FieldElement)base.RawZCoords[0];
		ulong[] t1 = Nat576.Create64();
		ulong[] t2 = Nat576.Create64();
		ulong[] Z1Precomp = (Z1.IsOne ? null : SecT571Field.PrecompMultiplicand(Z1.x));
		ulong[] L1Z1;
		ulong[] Z1Sq;
		if (Z1Precomp == null)
		{
			L1Z1 = L1.x;
			Z1Sq = Z1.x;
		}
		else
		{
			SecT571Field.MultiplyPrecomp(L1.x, Z1Precomp, L1Z1 = t1);
			SecT571Field.Square(Z1.x, Z1Sq = t2);
		}
		ulong[] T = Nat576.Create64();
		SecT571Field.Square(L1.x, T);
		SecT571Field.AddBothTo(L1Z1, Z1Sq, T);
		if (Nat576.IsZero64(T))
		{
			return new SecT571R1Point(curve, new SecT571FieldElement(T), SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
		}
		ulong[] tt = Nat576.CreateExt64();
		SecT571Field.MultiplyAddToExt(T, L1Z1, tt);
		SecT571FieldElement X3 = new SecT571FieldElement(t1);
		SecT571Field.Square(T, X3.x);
		SecT571FieldElement Z3 = new SecT571FieldElement(T);
		if (Z1Precomp != null)
		{
			SecT571Field.Multiply(Z3.x, Z1Sq, Z3.x);
		}
		ulong[] X1Z1;
		if (Z1Precomp == null)
		{
			X1Z1 = X1.x;
		}
		else
		{
			SecT571Field.MultiplyPrecomp(X1.x, Z1Precomp, X1Z1 = t2);
		}
		SecT571Field.SquareAddToExt(X1Z1, tt);
		SecT571Field.Reduce(tt, t2);
		SecT571Field.AddBothTo(X3.x, Z3.x, t2);
		SecT571FieldElement L3 = new SecT571FieldElement(t2);
		return new SecT571R1Point(curve, X3, L3, new ECFieldElement[1] { Z3 }, base.IsCompressed);
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
			return new SecT571R1Point(curve, A, SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
		}
		ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
		ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
		ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2.AddOne(), Z4);
		return new SecT571R1Point(curve, X3, L3, new ECFieldElement[1] { Z4 }, base.IsCompressed);
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
		return new SecT571R1Point(Curve, X, L.Add(Z), new ECFieldElement[1] { Z }, base.IsCompressed);
	}
}
