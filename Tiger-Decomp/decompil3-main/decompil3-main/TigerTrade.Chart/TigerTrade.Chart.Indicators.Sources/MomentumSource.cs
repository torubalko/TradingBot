using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[DataContract(Name = "MomentumSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("Momentum", Type = typeof(MomentumSource))]
public sealed class MomentumSource : IndicatorSourceBase
{
	private int _period;

	private IndicatorSourceBase _source;

	internal static MomentumSource pfevrNeafPHKLeGxEqtw;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period
	{
		get
		{
			return _period;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (value != _period)
					{
						_period = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-5977659 ^ -6009229));
					}
					return;
				case 1:
					value = LFF6jSeaG0wnvSNliO4T(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Source")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	public IndicatorSourceBase Source
	{
		get
		{
			return _source ?? (_source = new StockSource());
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (value == _source)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
						{
							num2 = 0;
						}
						break;
					}
					_source = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7C3B9));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public MomentumSource()
	{
		LiyItFeaYjuTOclE0G9d();
		base._002Ector();
		Period = 10;
		base.SelectedSeries = (string)oLUXJbeaoDYvgW9PRnOi(-838841832 ^ -838810028);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x706541F3 ^ 0x7065CDBF) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		double[] series = Source.GetSeries(helper);
		if (series != null)
		{
			return (double[])k7u3wxeavkHvieLdqFa1(helper, series, Period);
		}
		return null;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 1;
		int num2 = num;
		MomentumSource momentumSource = default(MomentumSource);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Source = (IndicatorSourceBase)GpBY4ReaaWtc63yNAH0U(momentumSource.Source);
				return;
			case 1:
				momentumSource = source as MomentumSource;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (momentumSource == null)
			{
				return;
			}
			base.SelectedSeries = (string)tctHbleaBOAssA8CY3MV(momentumSource);
			Period = momentumSource.Period;
			num2 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
			{
				num2 = 1;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)oLUXJbeaoDYvgW9PRnOi(0x4220DA8 ^ 0x4228A38), base.Name, Source, Period);
	}

	static MomentumSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ah6XgQeaiwPUwUpSaAdy();
	}

	internal static int LFF6jSeaG0wnvSNliO4T(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool CCnybuea992JtR2c5ZAx()
	{
		return pfevrNeafPHKLeGxEqtw == null;
	}

	internal static MomentumSource wRrcoKeanYTLx7tThvmv()
	{
		return pfevrNeafPHKLeGxEqtw;
	}

	internal static void LiyItFeaYjuTOclE0G9d()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object oLUXJbeaoDYvgW9PRnOi(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object k7u3wxeavkHvieLdqFa1(object P_0, object P_1, int period)
	{
		return ((IndicatorsHelper)P_0).Momentum((double[])P_1, period);
	}

	internal static object tctHbleaBOAssA8CY3MV(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static object GpBY4ReaaWtc63yNAH0U(object P_0)
	{
		return ((IndicatorSourceBase)P_0).CloneSource();
	}

	internal static void ah6XgQeaiwPUwUpSaAdy()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
