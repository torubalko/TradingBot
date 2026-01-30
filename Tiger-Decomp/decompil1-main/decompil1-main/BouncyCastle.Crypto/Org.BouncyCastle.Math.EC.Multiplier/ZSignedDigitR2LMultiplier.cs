using System;

namespace Org.BouncyCastle.Math.EC.Multiplier;

[Obsolete("Will be removed")]
public class ZSignedDigitR2LMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		ECPoint R0 = p.Curve.Infinity;
		ECPoint R1 = p;
		int n = k.BitLength;
		int s = k.GetLowestSetBit();
		R1 = R1.TimesPow2(s);
		int i = s;
		while (++i < n)
		{
			R0 = R0.Add(k.TestBit(i) ? R1 : R1.Negate());
			R1 = R1.Twice();
		}
		return R0.Add(R1);
	}
}
