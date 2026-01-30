using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[DataContract(Name = "ParabolicSARSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("ParabolicSAR", Type = typeof(ParabolicSARSource))]
public sealed class ParabolicSARSource : IndicatorSourceBase
{
	private decimal _max;

	private decimal _step;

	internal static ParabolicSARSource gr0uj2eaeNlfV9ivm6Vq;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaxStep")]
	[DataMember(Name = "Max")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public decimal Max
	{
		get
		{
			return _max;
		}
		set
		{
			value = Math.Max(0m, value);
			if (value == _max)
			{
				return;
			}
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				_max = value;
				OnPropertyChanged((string)C3xQoOeac4iUXlFeBIuS(-1161619942 ^ -1161585992));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStep")]
	[DataMember(Name = "Step")]
	public decimal Step
	{
		get
		{
			return _step;
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
					if (!(value == _step))
					{
						_step = value;
						OnPropertyChanged((string)C3xQoOeac4iUXlFeBIuS(-839659358 ^ -839689202));
					}
					return;
				case 1:
					value = Math.Max(0m, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ParabolicSARSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Step = 0.02m;
				base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x446AB724 ^ 0x446A3B9C);
				return;
			case 1:
				Max = 0.2m;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x130FEA25 ^ 0x130F669D) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return helper.SAR((double)Step, hsry2Ieajncsp2dOxCpd(Max));
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is ParabolicSARSource parabolicSARSource)
		{
			base.SelectedSeries = parabolicSARSource.SelectedSeries;
		}
	}

	public override string ToString()
	{
		return (string)bZSk4YeaE3xBmaHAkVoo(new string[5]
		{
			(string)C3xQoOeac4iUXlFeBIuS(-44540535 ^ -44510883),
			Step.ToString(CultureInfo.InvariantCulture),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2123795572 ^ -2123759764),
			Max.ToString(CultureInfo.InvariantCulture),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-198991962 ^ -198974414)
		});
	}

	static ParabolicSARSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		O9fL6SeaQa7t6EfDXbZw();
	}

	internal static object C3xQoOeac4iUXlFeBIuS(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool d7cHymeasugTc8G94sZM()
	{
		return gr0uj2eaeNlfV9ivm6Vq == null;
	}

	internal static ParabolicSARSource Lx9O8beaXEBE28J4Lhju()
	{
		return gr0uj2eaeNlfV9ivm6Vq;
	}

	internal static double hsry2Ieajncsp2dOxCpd(decimal P_0)
	{
		return (double)P_0;
	}

	internal static object bZSk4YeaE3xBmaHAkVoo(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static void O9fL6SeaQa7t6EfDXbZw()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
