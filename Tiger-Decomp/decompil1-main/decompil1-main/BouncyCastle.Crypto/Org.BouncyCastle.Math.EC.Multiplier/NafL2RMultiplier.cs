using System;

namespace Org.BouncyCastle.Math.EC.Multiplier;

[Obsolete("Will be removed")]
public class NafL2RMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		int[] naf = WNafUtilities.GenerateCompactNaf(k);
		ECPoint addP = p.Normalize();
		ECPoint subP = addP.Negate();
		ECPoint R = p.Curve.Infinity;
		int i = naf.Length;
		while (--i >= 0)
		{
			int num = naf[i];
			int digit = num >> 16;
			int zeroes = num & 0xFFFF;
			R = R.TwicePlus((digit < 0) ? subP : addP);
			R = R.TimesPow2(zeroes);
		}
		return R;
	}
}
