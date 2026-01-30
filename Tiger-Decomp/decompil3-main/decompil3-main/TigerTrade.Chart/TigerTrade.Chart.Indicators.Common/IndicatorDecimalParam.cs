using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "IndicatorDecimalParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Browsable(false)]
public sealed class IndicatorDecimalParam : IndicatorParam<decimal>
{
	private static IndicatorDecimalParam eapogdeMC7eXQ9kN0L1x;

	public IndicatorDecimalParam()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	public IndicatorDecimalParam(decimal value)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		base.Value = value;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public bool Set(string key, decimal value, decimal minValue = decimal.MinValue, decimal maxValue = decimal.MaxValue)
	{
		value = Math.Max(minValue, Math.Min(maxValue, value));
		return base.Set(key, value);
	}

	static IndicatorDecimalParam()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool GrPfPSeMrN7vLjpN1bZP()
	{
		return eapogdeMC7eXQ9kN0L1x == null;
	}

	internal static IndicatorDecimalParam dkYoQseMKwDhbQdtPwAq()
	{
		return eapogdeMC7eXQ9kN0L1x;
	}
}
