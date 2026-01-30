using System;

namespace Org.BouncyCastle.Math.EC.Multiplier;

[Obsolete("Will be removed")]
public class MixedNafR2LMultiplier : AbstractECMultiplier
{
	protected readonly int additionCoord;

	protected readonly int doublingCoord;

	public MixedNafR2LMultiplier()
		: this(2, 4)
	{
	}

	public MixedNafR2LMultiplier(int additionCoord, int doublingCoord)
	{
		this.additionCoord = additionCoord;
		this.doublingCoord = doublingCoord;
	}

	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		ECCurve curveOrig = p.Curve;
		ECCurve curveAdd = ConfigureCurve(curveOrig, additionCoord);
		ECCurve eCCurve = ConfigureCurve(curveOrig, doublingCoord);
		int[] naf = WNafUtilities.GenerateCompactNaf(k);
		ECPoint Ra = curveAdd.Infinity;
		ECPoint Td = eCCurve.ImportPoint(p);
		int zeroes = 0;
		foreach (int ni in naf)
		{
			int num = ni >> 16;
			zeroes += ni & 0xFFFF;
			Td = Td.TimesPow2(zeroes);
			ECPoint Tj = curveAdd.ImportPoint(Td);
			if (num < 0)
			{
				Tj = Tj.Negate();
			}
			Ra = Ra.Add(Tj);
			zeroes = 1;
		}
		return curveOrig.ImportPoint(Ra);
	}

	protected virtual ECCurve ConfigureCurve(ECCurve c, int coord)
	{
		if (c.CoordinateSystem == coord)
		{
			return c;
		}
		if (!c.SupportsCoordinateSystem(coord))
		{
			throw new ArgumentException("Coordinate system " + coord + " not supported by this curve", "coord");
		}
		return c.Configure().SetCoordinateSystem(coord).Create();
	}
}
