using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("Ichimoku", Type = typeof(IchimokuSource))]
[DataContract(Name = "IchimokuSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class IchimokuSource : IndicatorSourceBase
{
	private int _period1;

	private int _period2;

	private int _period3;

	private int _period4;

	private int _period5;

	internal static IchimokuSource AyKdULeBs27ndinhnJhw;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DisplayName("Tenkan")]
	[DataMember(Name = "Period1")]
	public int Period1
	{
		get
		{
			return _period1;
		}
		set
		{
			value = Math.Max(1, value);
			if (value != _period1)
			{
				_period1 = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7ADBF691 ^ 0x7ADB7C0B));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period2")]
	[DisplayName("Kijun")]
	public int Period2
	{
		get
		{
			return _period2;
		}
		set
		{
			value = Math.Max(1, value);
			if (value == _period2)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
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
				_period2 = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165444203));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShift")]
	[DataMember(Name = "Period3")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period3
	{
		get
		{
			return _period3;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					value = awqXEmeBjiuglmTo6Iom(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _period3)
					{
						_period3 = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--855742383 ^ 0x33011D11));
					}
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DisplayName("SenkouB")]
	[DataMember(Name = "Period4")]
	public int Period4
	{
		get
		{
			return _period4;
		}
		set
		{
			value = Math.Max(1, value);
			if (value != _period4)
			{
				_period4 = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342707826));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DisplayName("Chikou")]
	[DataMember(Name = "Period5")]
	public int Period5
	{
		get
		{
			return _period5;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					value = awqXEmeBjiuglmTo6Iom(1, value);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _period5)
					{
						_period5 = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--737722733 ^ 0x2BF84B8F));
					}
					return;
				}
			}
		}
	}

	public IchimokuSource()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		Period1 = 9;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				base.SelectedSeries = (string)KYStNceBEmg4UPs27KMe(0x11D1040B ^ 0x11D18EFF);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
				{
					num = 1;
				}
				break;
			default:
				Period2 = 26;
				Period3 = 26;
				Period4 = 52;
				Period5 = 26;
				num = 2;
				break;
			case 1:
				return;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x11D1040B ^ 0x11D18EFF),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4297C3EB ^ 0x429748EF),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDC407),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-90307782 ^ -90273762),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2BD86B18 ^ 0x2BD8E02E)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		int num = 2;
		int num2 = num;
		string selectedSeries = default(string);
		double[] senkouA = default(double[]);
		double[] kijun = default(double[]);
		double[] tenkan = default(double[]);
		double[] chikou = default(double[]);
		double[] senkouB = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				selectedSeries = base.SelectedSeries;
				if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B50E26)))
				{
					if (!F68KqveBQEqJgR5xdUb9(selectedSeries, KYStNceBEmg4UPs27KMe(-1878953018 ^ -1878918974)))
					{
						if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B50FC0)))
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
							{
								num2 = 0;
							}
							continue;
						}
						return senkouA;
					}
					return kijun;
				}
				return tenkan;
			case 3:
				if (F68KqveBQEqJgR5xdUb9(selectedSeries, KYStNceBEmg4UPs27KMe(-1416986301 ^ -1417016715)))
				{
					return chikou;
				}
				return null;
			case 2:
				helper.Ichimoku(Period1, Period2, Period3, Period4, Period5, out tenkan, out kijun, out senkouA, out senkouB, out chikou);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			if (!(selectedSeries == (string)KYStNceBEmg4UPs27KMe(-1311293279 ^ -1311257723)))
			{
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return senkouB;
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 3;
		int num2 = num;
		IchimokuSource ichimokuSource = default(IchimokuSource);
		while (true)
		{
			switch (num2)
			{
			case 4:
				Period2 = ichimokuSource.Period2;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				Period1 = ichimokuSource.Period1;
				num2 = 4;
				break;
			case 3:
				ichimokuSource = source as IchimokuSource;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Period3 = ycYHFJeBd1RnOfHOImg6(ichimokuSource);
				Period4 = ichimokuSource.Period4;
				Period5 = w2kZ7ieBgqDya5xwlRVq(ichimokuSource);
				return;
			case 2:
				if (ichimokuSource == null)
				{
					return;
				}
				base.SelectedSeries = ichimokuSource.SelectedSeries;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return (string)KYStNceBEmg4UPs27KMe(-1127423276 ^ -1127455440);
		}
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1801468030 ^ -1801498836), base.SelectedSeries, Period1, Period2, Period3);
	}

	static IchimokuSource()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool GOhyBQeBXdZV69cS99i7()
	{
		return AyKdULeBs27ndinhnJhw == null;
	}

	internal static IchimokuSource qeob5ceBcYQfkyCEXC8T()
	{
		return AyKdULeBs27ndinhnJhw;
	}

	internal static int awqXEmeBjiuglmTo6Iom(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object KYStNceBEmg4UPs27KMe(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool F68KqveBQEqJgR5xdUb9(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static int ycYHFJeBd1RnOfHOImg6(object P_0)
	{
		return ((IchimokuSource)P_0).Period3;
	}

	internal static int w2kZ7ieBgqDya5xwlRVq(object P_0)
	{
		return ((IchimokuSource)P_0).Period5;
	}
}
