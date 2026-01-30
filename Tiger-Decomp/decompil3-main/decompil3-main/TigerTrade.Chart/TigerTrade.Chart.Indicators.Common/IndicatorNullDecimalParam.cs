using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "IndicatorNullDecimalParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Browsable(false)]
public sealed class IndicatorNullDecimalParam : IndicatorParam<decimal?>
{
	internal static IndicatorNullDecimalParam LD1dSueMmtG44gHG58cl;

	public IndicatorNullDecimalParam()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	public IndicatorNullDecimalParam(decimal? value)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		base.Value = value;
	}

	public bool Set(string key, decimal? value, decimal minValue = decimal.MinValue, decimal maxValue = decimal.MaxValue)
	{
		if (value.HasValue)
		{
			value = Math.Max(minValue, Math.Min(maxValue, value.Value));
		}
		return base.Set(key, value);
	}

	static IndicatorNullDecimalParam()
	{
		LvLf2oeM7uHfVRe5EhVH();
		jy2eHVeM8ZwnGbPSBoYT();
	}

	internal static bool MY7PayeMhhl8QquZbqHm()
	{
		return LD1dSueMmtG44gHG58cl == null;
	}

	internal static IndicatorNullDecimalParam qxdBxReMwbQIQW2jCCTT()
	{
		return LD1dSueMmtG44gHG58cl;
	}

	internal static void LvLf2oeM7uHfVRe5EhVH()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void jy2eHVeM8ZwnGbPSBoYT()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
