using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Endo;

public abstract class EndoUtilities
{
	private class MapPointCallback : IPreCompCallback
	{
		private readonly ECEndomorphism m_endomorphism;

		private readonly ECPoint m_point;

		internal MapPointCallback(ECEndomorphism endomorphism, ECPoint point)
		{
			m_endomorphism = endomorphism;
			m_point = point;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			EndoPreCompInfo existingEndo = existing as EndoPreCompInfo;
			if (CheckExisting(existingEndo, m_endomorphism))
			{
				return existingEndo;
			}
			ECPoint mappedPoint = m_endomorphism.PointMap.Map(m_point);
			return new EndoPreCompInfo
			{
				Endomorphism = m_endomorphism,
				MappedPoint = mappedPoint
			};
		}

		private bool CheckExisting(EndoPreCompInfo existingEndo, ECEndomorphism endomorphism)
		{
			if (existingEndo != null && existingEndo.Endomorphism == endomorphism)
			{
				return existingEndo.MappedPoint != null;
			}
			return false;
		}
	}

	public static readonly string PRECOMP_NAME = "bc_endo";

	public static BigInteger[] DecomposeScalar(ScalarSplitParameters p, BigInteger k)
	{
		int bits = p.Bits;
		BigInteger b1 = CalculateB(k, p.G1, bits);
		BigInteger b2 = CalculateB(k, p.G2, bits);
		BigInteger a = k.Subtract(b1.Multiply(p.V1A).Add(b2.Multiply(p.V2A)));
		BigInteger b3 = b1.Multiply(p.V1B).Add(b2.Multiply(p.V2B)).Negate();
		return new BigInteger[2] { a, b3 };
	}

	public static ECPoint MapPoint(ECEndomorphism endomorphism, ECPoint p)
	{
		return ((EndoPreCompInfo)p.Curve.Precompute(p, PRECOMP_NAME, new MapPointCallback(endomorphism, p))).MappedPoint;
	}

	private static BigInteger CalculateB(BigInteger k, BigInteger g, int t)
	{
		bool num = g.SignValue < 0;
		BigInteger b = k.Multiply(g.Abs());
		bool num2 = b.TestBit(t - 1);
		b = b.ShiftRight(t);
		if (num2)
		{
			b = b.Add(BigInteger.One);
		}
		if (!num)
		{
			return b;
		}
		return b.Negate();
	}
}
