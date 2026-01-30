using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "IndicatorIntParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Browsable(false)]
public sealed class IndicatorIntParam : IndicatorParam<int>
{
	private static IndicatorIntParam xEQhUQeMSE2Jlq0wGpSo;

	public IndicatorIntParam()
	{
		ctk0Z0eMeX4Dbq2gpyBp();
		base._002Ector();
	}

	public IndicatorIntParam(int value)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Value = value;
	}

	public bool Set(string key, int value, int minValue = int.MinValue, int maxValue = int.MaxValue)
	{
		value = Math.Max(minValue, I6KfOaeMskZc5gYKB64H(maxValue, value));
		return base.Set(key, value);
	}

	static IndicatorIntParam()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		hBUIkLeMX2RFF25aHayP();
	}

	internal static void ctk0Z0eMeX4Dbq2gpyBp()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static bool TUAvc6eMxJkuYLTrdUbo()
	{
		return xEQhUQeMSE2Jlq0wGpSo == null;
	}

	internal static IndicatorIntParam lxdL2SeMLl73Na3SW9F4()
	{
		return xEQhUQeMSE2Jlq0wGpSo;
	}

	internal static int I6KfOaeMskZc5gYKB64H(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void hBUIkLeMX2RFF25aHayP()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
