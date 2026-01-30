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
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Dx;

namespace qEgdqniZfCf83STmtl4P;

[Indicator("VHF", "VHF", false, Type = typeof(vhLEVriZHHlmfPE1fOkk))]
[DataContract(Name = "VHFIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class vhLEVriZHHlmfPE1fOkk : IndicatorBase
{
	private int TjbiZBr32TD;

	private ChartSeries tndiZamd5pe;

	private static vhLEVriZHHlmfPE1fOkk dE2B9ueRnsi7oMlWW0iG;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public int Period
	{
		get
		{
			return TjbiZBr32TD;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == TjbiZBr32TD)
			{
				return;
			}
			TjbiZBr32TD = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OnPropertyChanged((string)UdKB8aeRoxZ9j35b5OAK(-1763895751 ^ -1763864177));
					OnPropertyChanged((string)UdKB8aeRoxZ9j35b5OAK(0x28B345BB ^ 0x28B3D49F));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[DisplayName("VHF")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "VHF")]
	public ChartSeries VHFSeries
	{
		get
		{
			return tndiZamd5pe ?? (tndiZamd5pe = new ChartSeries(ChartSeriesType.Line, eiPDb9eRBE9VDS9L6ZIO(TY924MeRvRG0EEtFRn5N())));
		}
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (!object.Equals(objA, tndiZamd5pe))
					{
						tndiZamd5pe = objA;
						OnPropertyChanged((string)UdKB8aeRoxZ9j35b5OAK(-1774602229 ^ -1774644565));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> Si6iZvPuqqw => base.Levels;

	public vhLEVriZHHlmfPE1fOkk()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 28;
	}

	protected override void Execute()
	{
		double[] data = base.Helper.VHF(Period);
		base.Series.Add(new IndicatorSeriesData(data, VHFSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		VHFSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		vhLEVriZHHlmfPE1fOkk vhLEVriZHHlmfPE1fOkk2 = default(vhLEVriZHHlmfPE1fOkk);
		while (true)
		{
			switch (num2)
			{
			default:
				Period = vhLEVriZHHlmfPE1fOkk2.Period;
				VHFSeries.CopyTheme((ChartSeries)eKY9A4eRaUeTYP5sGaEu(vhLEVriZHHlmfPE1fOkk2));
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				vhLEVriZHHlmfPE1fOkk2 = (vhLEVriZHHlmfPE1fOkk)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7DB10E6E ^ 0x7DB1899E), base.Name, Period);
	}

	static vhLEVriZHHlmfPE1fOkk()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		zgB4pheRijiZ7bjO20BG();
	}

	internal static object UdKB8aeRoxZ9j35b5OAK(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool lRiIZKeRG709nL7tckP9()
	{
		return dE2B9ueRnsi7oMlWW0iG == null;
	}

	internal static vhLEVriZHHlmfPE1fOkk fSLMHSeRYbfQylwBMvZE()
	{
		return dE2B9ueRnsi7oMlWW0iG;
	}

	internal static Color TY924MeRvRG0EEtFRn5N()
	{
		return Colors.Blue;
	}

	internal static XColor eiPDb9eRBE9VDS9L6ZIO(Color P_0)
	{
		return P_0;
	}

	internal static object eKY9A4eRaUeTYP5sGaEu(object P_0)
	{
		return ((vhLEVriZHHlmfPE1fOkk)P_0).VHFSeries;
	}

	internal static void zgB4pheRijiZ7bjO20BG()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
