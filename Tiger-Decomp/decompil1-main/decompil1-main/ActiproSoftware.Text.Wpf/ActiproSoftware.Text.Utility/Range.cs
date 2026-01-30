using System;
using System.Globalization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public struct Range
{
	private int hBA;

	private int rBu;

	internal static object NWo;

	public static Range Empty => new Range(-1, -1);

	public bool IsEmpty => hBA == -1 && rBu == -1;

	public bool IsNormalized => rBu >= hBA;

	public int Length => rBu - hBA;

	public int Max
	{
		get
		{
			return rBu;
		}
		set
		{
			rBu = value;
		}
	}

	public int Min
	{
		get
		{
			return hBA;
		}
		set
		{
			hBA = value;
		}
	}

	public Range(int value)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		hBA = value;
		rBu = value;
	}

	public Range(int min, int max)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		hBA = min;
		rBu = max;
	}

	public bool Contains(int value)
	{
		return value >= hBA && value < rBu;
	}

	public bool Contains(Range range)
	{
		return range.Min >= hBA && range.Max <= rBu;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Range range))
		{
			int num = 0;
			if (!kWI())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => false, 
			};
		}
		return hBA == range.hBA && rBu == range.rBu;
	}

	public override int GetHashCode()
	{
		return hBA.GetHashCode() ^ rBu.GetHashCode();
	}

	public bool IntersectsWith(Range range)
	{
		return range.Max >= hBA && range.Min <= rBu;
	}

	public void Normalize()
	{
		if (!IsNormalized)
		{
			int num = hBA;
			hBA = rBu;
			rBu = num;
		}
	}

	public bool OverlapsWith(Range range)
	{
		return range.Max > hBA && range.Min < rBu;
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5262) + hBA.ToString(CultureInfo.CurrentCulture) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5276) + rBu.ToString(CultureInfo.CurrentCulture) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	public void Union(Range range)
	{
		int num = Math.Min(Math.Min(hBA, rBu), Math.Min(range.Min, range.Max));
		int num2 = Math.Max(Math.Max(hBA, rBu), Math.Max(range.Min, range.Max));
		hBA = num;
		rBu = num2;
	}

	public static bool operator ==(Range left, Range right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Range left, Range right)
	{
		return !left.Equals(right);
	}

	internal static bool kWI()
	{
		return NWo == null;
	}

	internal static object JWH()
	{
		return NWo;
	}
}
