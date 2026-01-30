namespace Org.BouncyCastle.Math.EC.Multiplier;

public class FixedPointUtilities
{
	private class FixedPointCallback : IPreCompCallback
	{
		private readonly ECPoint m_p;

		internal FixedPointCallback(ECPoint p)
		{
			m_p = p;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			FixedPointPreCompInfo existingFP = ((existing is FixedPointPreCompInfo) ? ((FixedPointPreCompInfo)existing) : null);
			ECCurve c = m_p.Curve;
			int bits = GetCombSize(c);
			int minWidth = ((bits > 250) ? 6 : 5);
			int n = 1 << minWidth;
			if (CheckExisting(existingFP, n))
			{
				return existingFP;
			}
			int d = (bits + minWidth - 1) / minWidth;
			ECPoint[] pow2Table = new ECPoint[minWidth + 1];
			pow2Table[0] = m_p;
			for (int i = 1; i < minWidth; i++)
			{
				pow2Table[i] = pow2Table[i - 1].TimesPow2(d);
			}
			pow2Table[minWidth] = pow2Table[0].Subtract(pow2Table[1]);
			c.NormalizeAll(pow2Table);
			ECPoint[] lookupTable = new ECPoint[n];
			lookupTable[0] = pow2Table[0];
			for (int bit = minWidth - 1; bit >= 0; bit--)
			{
				ECPoint pow2 = pow2Table[bit];
				int step = 1 << bit;
				for (int j = step; j < n; j += step << 1)
				{
					lookupTable[j] = lookupTable[j - step].Add(pow2);
				}
			}
			c.NormalizeAll(lookupTable);
			return new FixedPointPreCompInfo
			{
				LookupTable = c.CreateCacheSafeLookupTable(lookupTable, 0, lookupTable.Length),
				Offset = pow2Table[minWidth],
				Width = minWidth
			};
		}

		private bool CheckExisting(FixedPointPreCompInfo existingFP, int n)
		{
			if (existingFP != null)
			{
				return CheckTable(existingFP.LookupTable, n);
			}
			return false;
		}

		private bool CheckTable(ECLookupTable table, int n)
		{
			if (table != null)
			{
				return table.Size >= n;
			}
			return false;
		}
	}

	public static readonly string PRECOMP_NAME = "bc_fixed_point";

	public static int GetCombSize(ECCurve c)
	{
		return c.Order?.BitLength ?? (c.FieldSize + 1);
	}

	public static FixedPointPreCompInfo GetFixedPointPreCompInfo(PreCompInfo preCompInfo)
	{
		return preCompInfo as FixedPointPreCompInfo;
	}

	public static FixedPointPreCompInfo Precompute(ECPoint p)
	{
		return (FixedPointPreCompInfo)p.Curve.Precompute(p, PRECOMP_NAME, new FixedPointCallback(p));
	}
}
