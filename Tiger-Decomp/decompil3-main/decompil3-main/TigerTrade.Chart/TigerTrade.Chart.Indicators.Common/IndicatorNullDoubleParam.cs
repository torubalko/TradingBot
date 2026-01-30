using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "IndicatorNullDoubleParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Browsable(false)]
public sealed class IndicatorNullDoubleParam : IndicatorParam<double?>
{
	internal static IndicatorNullDoubleParam UY5x22eMTVU6IOHMDqDX;

	public IndicatorNullDoubleParam()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	public IndicatorNullDoubleParam(double? value)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		base.Value = value;
	}

	public bool Set(string key, double? value, double minValue = double.MinValue, double maxValue = double.MaxValue)
	{
		if (value.HasValue)
		{
			value = Math.Max(minValue, Math.Min(maxValue, value.Value));
		}
		return base.Set(key, value);
	}

	static IndicatorNullDoubleParam()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		xWm3ageMVxn4s1rkFU4v();
	}

	internal static bool mNeie5eMyblQEtxOxV0R()
	{
		return UY5x22eMTVU6IOHMDqDX == null;
	}

	internal static IndicatorNullDoubleParam BXMmDseMZGXXrHNPEh9W()
	{
		return UY5x22eMTVU6IOHMDqDX;
	}

	internal static void xWm3ageMVxn4s1rkFU4v()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
