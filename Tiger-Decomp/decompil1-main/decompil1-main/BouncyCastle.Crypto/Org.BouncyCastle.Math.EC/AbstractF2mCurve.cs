using System;
using Org.BouncyCastle.Math.EC.Abc;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC;

public abstract class AbstractF2mCurve : ECCurve
{
	private BigInteger[] si;

	public virtual bool IsKoblitz
	{
		get
		{
			if (m_order != null && m_cofactor != null && m_b.IsOne)
			{
				if (!m_a.IsZero)
				{
					return m_a.IsOne;
				}
				return true;
			}
			return false;
		}
	}

	public static BigInteger Inverse(int m, int[] ks, BigInteger x)
	{
		return new LongArray(x).ModInverse(m, ks).ToBigInteger();
	}

	private static IFiniteField BuildField(int m, int k1, int k2, int k3)
	{
		if (k1 == 0)
		{
			throw new ArgumentException("k1 must be > 0");
		}
		if (k2 == 0)
		{
			if (k3 != 0)
			{
				throw new ArgumentException("k3 must be 0 if k2 == 0");
			}
			return FiniteFields.GetBinaryExtensionField(new int[3] { 0, k1, m });
		}
		if (k2 <= k1)
		{
			throw new ArgumentException("k2 must be > k1");
		}
		if (k3 <= k2)
		{
			throw new ArgumentException("k3 must be > k2");
		}
		return FiniteFields.GetBinaryExtensionField(new int[5] { 0, k1, k2, k3, m });
	}

	protected AbstractF2mCurve(int m, int k1, int k2, int k3)
		: base(BuildField(m, k1, k2, k3))
	{
	}

	[Obsolete("Per-point compression property will be removed")]
	public override ECPoint CreatePoint(BigInteger x, BigInteger y, bool withCompression)
	{
		ECFieldElement X = FromBigInteger(x);
		ECFieldElement Y = FromBigInteger(y);
		int coordinateSystem = CoordinateSystem;
		if ((uint)(coordinateSystem - 5) <= 1u)
		{
			if (X.IsZero)
			{
				if (!Y.Square().Equals(B))
				{
					throw new ArgumentException();
				}
			}
			else
			{
				Y = Y.Divide(X).Add(X);
			}
		}
		return CreateRawPoint(X, Y, withCompression);
	}

	public override bool IsValidFieldElement(BigInteger x)
	{
		if (x != null && x.SignValue >= 0)
		{
			return x.BitLength <= FieldSize;
		}
		return false;
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		int m = FieldSize;
		return FromBigInteger(BigIntegers.CreateRandomBigInteger(m, r));
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		int m = FieldSize;
		ECFieldElement eCFieldElement = FromBigInteger(ImplRandomFieldElementMult(r, m));
		ECFieldElement fe2 = FromBigInteger(ImplRandomFieldElementMult(r, m));
		return eCFieldElement.Multiply(fe2);
	}

	protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
	{
		ECFieldElement xp = FromBigInteger(X1);
		ECFieldElement yp = null;
		if (xp.IsZero)
		{
			yp = B.Sqrt();
		}
		else
		{
			ECFieldElement beta = xp.Square().Invert().Multiply(B)
				.Add(A)
				.Add(xp);
			ECFieldElement z = SolveQuadraticEquation(beta);
			if (z != null)
			{
				if (z.TestBitZero() != (yTilde == 1))
				{
					z = z.AddOne();
				}
				int coordinateSystem = CoordinateSystem;
				yp = (((uint)(coordinateSystem - 5) > 1u) ? z.Multiply(xp) : z.Add(xp));
			}
		}
		if (yp == null)
		{
			throw new ArgumentException("Invalid point compression");
		}
		return CreateRawPoint(xp, yp, withCompression: true);
	}

	internal ECFieldElement SolveQuadraticEquation(ECFieldElement beta)
	{
		AbstractF2mFieldElement betaF2m = (AbstractF2mFieldElement)beta;
		bool fastTrace = betaF2m.HasFastTrace;
		if (fastTrace && betaF2m.Trace() != 0)
		{
			return null;
		}
		int m = FieldSize;
		if ((m & 1) != 0)
		{
			ECFieldElement r = betaF2m.HalfTrace();
			if (fastTrace || r.Square().Add(r).Add(beta)
				.IsZero)
			{
				return r;
			}
			return null;
		}
		if (beta.IsZero)
		{
			return beta;
		}
		ECFieldElement zeroElement = FromBigInteger(BigInteger.Zero);
		ECFieldElement z;
		ECFieldElement gamma;
		do
		{
			ECFieldElement t = FromBigInteger(BigInteger.Arbitrary(m));
			z = zeroElement;
			ECFieldElement w = beta;
			for (int i = 1; i < m; i++)
			{
				ECFieldElement w2 = w.Square();
				z = z.Square().Add(w2.Multiply(t));
				w = w2.Add(beta);
			}
			if (!w.IsZero)
			{
				return null;
			}
			gamma = z.Square().Add(z);
		}
		while (gamma.IsZero);
		return z;
	}

	internal virtual BigInteger[] GetSi()
	{
		if (si == null)
		{
			lock (this)
			{
				if (si == null)
				{
					si = Tnaf.GetSi(this);
				}
			}
		}
		return si;
	}

	private static BigInteger ImplRandomFieldElementMult(SecureRandom r, int m)
	{
		BigInteger x;
		do
		{
			x = BigIntegers.CreateRandomBigInteger(m, r);
		}
		while (x.SignValue <= 0);
		return x;
	}
}
