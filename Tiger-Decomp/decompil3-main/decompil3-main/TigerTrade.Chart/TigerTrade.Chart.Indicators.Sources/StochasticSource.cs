using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;

namespace TigerTrade.Chart.Indicators.Sources;

[DataContract(Name = "StochasticSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[IndicatorSource("Stochastic", Type = typeof(StochasticSource))]
public sealed class StochasticSource : IndicatorSourceBase
{
	private int _fastK;

	private int _smooth;

	private int _slowD;

	private IndicatorMaType _slowDMaType;

	private static StochasticSource m5ApGreilFYqWpw0xtAb;

	[DataMember(Name = "FastK")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPK")]
	public int FastK
	{
		get
		{
			return _fastK;
		}
		set
		{
			value = w5Prtpeib0VUt933PWGN(1, value);
			if (value != _fastK)
			{
				_fastK = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-203064540 ^ -203032886));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSmooth")]
	[DataMember(Name = "Smooth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPK")]
	public int Smooth
	{
		get
		{
			return _smooth;
		}
		set
		{
			value = Math.Max(1, value);
			if (value == _smooth)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else
			{
				_smooth = value;
				OnPropertyChanged((string)E4c3GbeiNPwyUWLXBFcl(-842040449 ^ -842008957));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPD")]
	[DataMember(Name = "SlowD")]
	public int SlowD
	{
		get
		{
			return _slowD;
		}
		set
		{
			value = Math.Max(1, value);
			if (value != _slowD)
			{
				_slowD = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x706541F3 ^ 0x7065CFFF));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParametersPD")]
	[DataMember(Name = "SlowDMA")]
	public IndicatorMaType SlowDMaType
	{
		get
		{
			return _slowDMaType;
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
					if (value == _slowDMaType)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
						{
							num2 = 0;
						}
						break;
					}
					_slowDMaType = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1009517961 ^ -1009552275));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public StochasticSource()
	{
		cs4c5XeikE41E5P7qGSb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Smooth = 1;
				SlowD = 3;
				SlowDMaType = IndicatorMaType.SMA;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
				{
					num = 2;
				}
				break;
			default:
				FastK = 14;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				base.SelectedSeries = (string)E4c3GbeiNPwyUWLXBFcl(-2074141628 ^ -2074111376);
				return;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B50AE6),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--500511424 ^ 0x1DD5BCFC)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		helper.Stoch(FastK, Smooth, IndicatorMaType.SMA, SlowD, SlowDMaType, out var slowK, out var slowD);
		string selectedSeries = base.SelectedSeries;
		if (!yhT6Y4ei11heJqAhuRMU(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x86EFEF6 ^ 0x86E70C2)))
		{
			if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7F55E538 ^ 0x7F556B04))
			{
				return slowD;
			}
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				return null;
			}
		}
		return slowK;
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (!(source is StochasticSource stochasticSource))
		{
			return;
		}
		base.SelectedSeries = stochasticSource.SelectedSeries;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				FastK = stochasticSource.FastK;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
				{
					num = 0;
				}
				break;
			default:
				Smooth = stochasticSource.Smooth;
				num = 2;
				break;
			case 2:
				SlowD = stochasticSource.SlowD;
				SlowDMaType = zPZIuLei5KTqU3f1KM2H(stochasticSource);
				return;
			}
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return (string)E4c3GbeiNPwyUWLXBFcl(-1346994499 ^ -1346963111);
		}
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x86EFEF6 ^ 0x86E7658), base.SelectedSeries, FastK, Smooth, SlowD);
	}

	static StochasticSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int w5Prtpeib0VUt933PWGN(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool GrKmedei409SCSpk4uTW()
	{
		return m5ApGreilFYqWpw0xtAb == null;
	}

	internal static StochasticSource Sjeu91eiDKMFPVlBq5I0()
	{
		return m5ApGreilFYqWpw0xtAb;
	}

	internal static object E4c3GbeiNPwyUWLXBFcl(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void cs4c5XeikE41E5P7qGSb()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static bool yhT6Y4ei11heJqAhuRMU(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static IndicatorMaType zPZIuLei5KTqU3f1KM2H(object P_0)
	{
		return ((StochasticSource)P_0).SlowDMaType;
	}
}
