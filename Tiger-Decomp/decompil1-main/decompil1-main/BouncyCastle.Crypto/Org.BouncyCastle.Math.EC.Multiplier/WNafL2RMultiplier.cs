using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Multiplier;

public class WNafL2RMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		int minWidth = WNafUtilities.GetWindowSize(k.BitLength);
		WNafPreCompInfo wNafPreCompInfo = WNafUtilities.Precompute(p, minWidth, includeNegated: true);
		ECPoint[] preComp = wNafPreCompInfo.PreComp;
		ECPoint[] preCompNeg = wNafPreCompInfo.PreCompNeg;
		int width = wNafPreCompInfo.Width;
		int[] wnaf = WNafUtilities.GenerateCompactWindowNaf(width, k);
		ECPoint R = p.Curve.Infinity;
		int i = wnaf.Length;
		if (i > 1)
		{
			int num = wnaf[--i];
			int digit = num >> 16;
			int zeroes = num & 0xFFFF;
			int n = System.Math.Abs(digit);
			ECPoint[] table = ((digit < 0) ? preCompNeg : preComp);
			if (n << 2 < 1 << width)
			{
				int highest = 32 - Integers.NumberOfLeadingZeros(n);
				int scale = width - highest;
				int num2 = n ^ (1 << highest - 1);
				int i2 = (1 << width - 1) - 1;
				int i3 = (num2 << scale) + 1;
				R = table[i2 >> 1].Add(table[i3 >> 1]);
				zeroes -= scale;
			}
			else
			{
				R = table[n >> 1];
			}
			R = R.TimesPow2(zeroes);
		}
		while (i > 0)
		{
			int num3 = wnaf[--i];
			int digit2 = num3 >> 16;
			int zeroes2 = num3 & 0xFFFF;
			int n2 = System.Math.Abs(digit2);
			ECPoint r = ((digit2 < 0) ? preCompNeg : preComp)[n2 >> 1];
			R = R.TwicePlus(r);
			R = R.TimesPow2(zeroes2);
		}
		return R;
	}
}
