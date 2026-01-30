using System;

namespace Org.BouncyCastle.Math.EC.Multiplier;

[Obsolete("Will be removed")]
public class NafR2LMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		int[] naf = WNafUtilities.GenerateCompactNaf(k);
		ECPoint R0 = p.Curve.Infinity;
		ECPoint R1 = p;
		int zeroes = 0;
		foreach (int ni in naf)
		{
			int digit = ni >> 16;
			zeroes += ni & 0xFFFF;
			R1 = R1.TimesPow2(zeroes);
			R0 = R0.Add((digit < 0) ? R1.Negate() : R1);
			zeroes = 1;
		}
		return R0;
	}
}
