using System;

namespace Org.BouncyCastle.Math.EC.Multiplier;

[Obsolete("Will be removed")]
public class ZSignedDigitL2RMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		ECPoint addP = p.Normalize();
		ECPoint subP = addP.Negate();
		ECPoint R0 = addP;
		int bitLength = k.BitLength;
		int s = k.GetLowestSetBit();
		int i = bitLength;
		while (--i > s)
		{
			R0 = R0.TwicePlus(k.TestBit(i) ? addP : subP);
		}
		return R0.TimesPow2(s);
	}
}
