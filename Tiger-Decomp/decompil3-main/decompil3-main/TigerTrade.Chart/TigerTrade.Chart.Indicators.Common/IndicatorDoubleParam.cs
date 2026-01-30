using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "IndicatorDoubleParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Browsable(false)]
public sealed class IndicatorDoubleParam : IndicatorParam<double>
{
	internal static IndicatorDoubleParam xIk0wneMIgPcXSK3Ea2Z;

	public IndicatorDoubleParam()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	public IndicatorDoubleParam(double value)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Value = value;
	}

	public bool Set(string key, double value, double minValue = double.MinValue, double maxValue = double.MaxValue)
	{
		value = Math.Max(minValue, uGgafZeMUS4dbHAIpTX1(maxValue, value));
		return base.Set(key, value);
	}

	static IndicatorDoubleParam()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool bRPBGweMWPB8RoCVys5u()
	{
		return xIk0wneMIgPcXSK3Ea2Z == null;
	}

	internal static IndicatorDoubleParam h8dGbMeMt2TERHlSV9Lb()
	{
		return xIk0wneMIgPcXSK3Ea2Z;
	}

	internal static double uGgafZeMUS4dbHAIpTX1(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}
}
