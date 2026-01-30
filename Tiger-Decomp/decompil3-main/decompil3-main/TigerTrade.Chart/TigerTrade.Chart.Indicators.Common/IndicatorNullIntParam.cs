using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Indicators.Common;

[Browsable(false)]
[DataContract(Name = "IndicatorNullIntParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class IndicatorNullIntParam : IndicatorParam<int?>
{
	internal static IndicatorNullIntParam OZcuRdeMcUXDdcLEmeZj;

	public IndicatorNullIntParam()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	public IndicatorNullIntParam(int? value)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		base.Value = value;
	}

	public bool Set(string key, int? value, int minValue = int.MinValue, int maxValue = int.MaxValue)
	{
		if (value.HasValue)
		{
			value = Math.Max(minValue, Math.Min(maxValue, value.Value));
		}
		return base.Set(key, value);
	}

	static IndicatorNullIntParam()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		c6eWOAeMQL6nNv8ZS7Bn();
	}

	internal static bool Tjo6qreMj9YeS19xra7k()
	{
		return OZcuRdeMcUXDdcLEmeZj == null;
	}

	internal static IndicatorNullIntParam LH1OvMeMEUvRJCBOrDqE()
	{
		return OZcuRdeMcUXDdcLEmeZj;
	}

	internal static void c6eWOAeMQL6nNv8ZS7Bn()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
