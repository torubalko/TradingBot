using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Multiplier;

public class FixedPointCombMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		ECCurve curve = p.Curve;
		int size = FixedPointUtilities.GetCombSize(curve);
		if (k.BitLength > size)
		{
			throw new InvalidOperationException("fixed-point comb doesn't support scalars larger than the curve order");
		}
		FixedPointPreCompInfo info = FixedPointUtilities.Precompute(p);
		ECLookupTable lookupTable = info.LookupTable;
		int width = info.Width;
		int d = (size + width - 1) / width;
		ECPoint R = curve.Infinity;
		int num = d * width;
		uint[] K = Nat.FromBigInteger(num, k);
		int top = num - 1;
		for (int i = 0; i < d; i++)
		{
			uint secretIndex = 0u;
			for (int j = top - i; j >= 0; j -= d)
			{
				uint secretBit = K[j >> 5] >> j;
				secretIndex ^= secretBit >> 1;
				secretIndex <<= 1;
				secretIndex ^= secretBit;
			}
			ECPoint add = lookupTable.Lookup((int)secretIndex);
			R = R.TwicePlus(add);
		}
		return R.Add(info.Offset);
	}
}
