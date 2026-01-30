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

namespace sL9kxRiq8aWfM69XWojj;

[Indicator("ChaikinMoneyFlow", "ChaikinMoneyFlow", false, Type = typeof(lYq71diq74SdXqUDuUm5))]
[DataContract(Name = "ChaikinMoneyFlowIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class lYq71diq74SdXqUDuUm5 : IndicatorBase
{
	private int ebOiquxk8PI;

	private ChartSeries D9piqzk7cn9;

	private static lYq71diq74SdXqUDuUm5 fe3iV1ejx2Vku91a8oFI;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return ebOiquxk8PI;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774633027));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-448941864 ^ -448978436));
					return;
				case 1:
					num3 = JE9vr9ejs5UxrhGSsJxK(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num3 == ebOiquxk8PI)
				{
					return;
				}
				ebOiquxk8PI = num3;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[DisplayName("CMF")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "CMF")]
	public ChartSeries CMFSeries
	{
		get
		{
			return D9piqzk7cn9 ?? (D9piqzk7cn9 = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
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
				case 1:
					if (object.Equals(chartSeries, D9piqzk7cn9))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					D9piqzk7cn9 = chartSeries;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306917360));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> EeTiqp8xPID => base.Levels;

	public lYq71diq74SdXqUDuUm5()
	{
		DLlawpejXB6HCmnBOiFa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Period = 21;
		base.Levels.Add(new ChartLevel(0m, DmZAbHejcm96kaqE10Zh()));
	}

	protected override void Execute()
	{
		double[] data = (double[])v01bxXejj1t8JRYliOt3(base.Helper, Period);
		base.Series.Add(new IndicatorSeriesData(data, CMFSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		UKZ4ktejE1qu9IyUB068(CMFSeries, P_0.GetNextColor());
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		lYq71diq74SdXqUDuUm5 lYq71diq74SdXqUDuUm6 = (lYq71diq74SdXqUDuUm5)P_0;
		Period = lYq71diq74SdXqUDuUm6.Period;
		CMFSeries.CopyTheme(lYq71diq74SdXqUDuUm6.CMFSeries);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.CopyTemplate(P_0, P_1);
	}

	public override string ToString()
	{
		return (string)mfIdu9ejQVXC6LhVweau(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xB15786A ^ 0xB15F116), Period);
	}

	static lYq71diq74SdXqUDuUm5()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		qTbnxoejduqWY34xJqfc();
	}

	internal static int JE9vr9ejs5UxrhGSsJxK(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool fVKG7eejLvf4xjUNdeYg()
	{
		return fe3iV1ejx2Vku91a8oFI == null;
	}

	internal static lYq71diq74SdXqUDuUm5 x4KeSOejelwfyDs9nUr5()
	{
		return fe3iV1ejx2Vku91a8oFI;
	}

	internal static void DLlawpejXB6HCmnBOiFa()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color DmZAbHejcm96kaqE10Zh()
	{
		return Colors.Gray;
	}

	internal static object v01bxXejj1t8JRYliOt3(object P_0, int n)
	{
		return ((IndicatorsHelper)P_0).CMF(n);
	}

	internal static void UKZ4ktejE1qu9IyUB068(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static object mfIdu9ejQVXC6LhVweau(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void qTbnxoejduqWY34xJqfc()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
