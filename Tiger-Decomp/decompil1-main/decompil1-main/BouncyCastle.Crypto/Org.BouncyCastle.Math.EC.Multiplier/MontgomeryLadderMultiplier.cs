using System;

namespace Org.BouncyCastle.Math.EC.Multiplier;

[Obsolete("Will be removed")]
public class MontgomeryLadderMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		ECPoint[] R = new ECPoint[2]
		{
			p.Curve.Infinity,
			p
		};
		int i = k.BitLength;
		while (--i >= 0)
		{
			int b = (k.TestBit(i) ? 1 : 0);
			int bp = 1 - b;
			R[bp] = R[bp].Add(R[b]);
			R[b] = R[b].Twice();
		}
		return R[0];
	}
}
