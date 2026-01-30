using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.Sources;

namespace VMuLQAiTLMhHohMqiOIv;

[Indicator("PriceOscillator", "PriceOscillator", false, Type = typeof(hLcIS4iTxe7gLFUEklZK))]
[DataContract(Name = "PriceOscillatorIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class hLcIS4iTxe7gLFUEklZK : IndicatorBase
{
	private int va1iTOMOO7Z;

	private int XZwiTqHcxRG;

	private IndicatorMaType ysYiTIsCIls;

	private IndicatorSourceBase KKviTWauwQd;

	private ChartSeries l0ZiTtqpUB1;

	internal static hLcIS4iTxe7gLFUEklZK L2J6TTed3Ylh8IFRvOLZ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "ShortPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShortPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int ShortPeriod
	{
		get
		{
			return va1iTOMOO7Z;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == va1iTOMOO7Z)
			{
				return;
			}
			va1iTOMOO7Z = num;
			int num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192952870));
					return;
				case 1:
					OnPropertyChanged((string)FSJk2ledzOFHEk6GWUHE(-377195341 ^ -377162763));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLongPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "LongPeriod")]
	public int LongPeriod
	{
		get
		{
			return XZwiTqHcxRG;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == XZwiTqHcxRG)
			{
				return;
			}
			XZwiTqHcxRG = num;
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xB15786A ^ 0xB15FF0A));
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45448455));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMaType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "MaType")]
	public IndicatorMaType MaType
	{
		get
		{
			return ysYiTIsCIls;
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
					if (indicatorMaType == ysYiTIsCIls)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
						{
							num2 = 0;
						}
						break;
					}
					ysYiTIsCIls = indicatorMaType;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x38578D3));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Source")]
	public IndicatorSourceBase Source
	{
		get
		{
			return KKviTWauwQd ?? (KKviTWauwQd = new StockSource());
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
					if (indicatorSourceBase == KKviTWauwQd)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					KKviTWauwQd = indicatorSourceBase;
					OnPropertyChanged((string)FSJk2ledzOFHEk6GWUHE(0x22BF43FC ^ 0x22BFCB9A));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("PPO")]
	[DataMember(Name = "PPO")]
	public ChartSeries PPOSeries
	{
		get
		{
			return l0ZiTtqpUB1 ?? (l0ZiTtqpUB1 = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(objA, l0ZiTtqpUB1))
			{
				l0ZiTtqpUB1 = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108504674));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> RHBiTMQ4M9k => base.Levels;

	public hLcIS4iTxe7gLFUEklZK()
	{
		w7gDraeg0EmSL3yS3E3f();
		base._002Ector();
		ShortPeriod = 10;
		LongPeriod = 21;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				MaType = IndicatorMaType.EMA;
				base.Levels.Add(new ChartLevel(0m, VIiIQveg2kNNxHL9gUn1()));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Execute()
	{
		int num = 1;
		int num2 = num;
		double[] array = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array = (double[])uiWhfjegHY6eRNFCO26j(Source, base.Helper);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (array != null)
				{
					double[] data = base.Helper.PPO(MaType, array, ShortPeriod, LongPeriod);
					rpchF8egf9uU910FFSAH(base.Series, new IndicatorSeriesData(data, PPOSeries));
				}
				return;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		PPOSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		hLcIS4iTxe7gLFUEklZK hLcIS4iTxe7gLFUEklZK2 = (hLcIS4iTxe7gLFUEklZK)P_0;
		ShortPeriod = hLcIS4iTxe7gLFUEklZK2.ShortPeriod;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				xNai7ceg9981RvMuLBR8(PPOSeries, hLcIS4iTxe7gLFUEklZK2.PPOSeries);
				base.CopyTemplate(P_0, P_1);
				num = 2;
				continue;
			case 2:
				return;
			}
			LongPeriod = hLcIS4iTxe7gLFUEklZK2.LongPeriod;
			MaType = hLcIS4iTxe7gLFUEklZK2.MaType;
			if (!P_1)
			{
				Source = hLcIS4iTxe7gLFUEklZK2.Source.CloneSource();
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num = 3;
				}
			}
			else
			{
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
				{
					num = 0;
				}
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)FSJk2ledzOFHEk6GWUHE(-181342698 ^ -181377352), base.Name, Source, ShortPeriod, LongPeriod);
	}

	static hLcIS4iTxe7gLFUEklZK()
	{
		WwAI2Vegnul5278xw4G3();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object FSJk2ledzOFHEk6GWUHE(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool ERbT96edpfyDJ2wmwqgl()
	{
		return L2J6TTed3Ylh8IFRvOLZ == null;
	}

	internal static hLcIS4iTxe7gLFUEklZK ScaJmAeduX20c7ORJ7Bd()
	{
		return L2J6TTed3Ylh8IFRvOLZ;
	}

	internal static void w7gDraeg0EmSL3yS3E3f()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color VIiIQveg2kNNxHL9gUn1()
	{
		return Colors.Gray;
	}

	internal static object uiWhfjegHY6eRNFCO26j(object P_0, object P_1)
	{
		return ((IndicatorSourceBase)P_0).GetSeries((IndicatorsHelper)P_1);
	}

	internal static void rpchF8egf9uU910FFSAH(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static void xNai7ceg9981RvMuLBR8(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void WwAI2Vegnul5278xw4G3()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
