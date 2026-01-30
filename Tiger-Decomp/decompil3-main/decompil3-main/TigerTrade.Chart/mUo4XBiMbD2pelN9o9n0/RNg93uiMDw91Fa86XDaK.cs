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
using TigerTrade.Chart.Indicators.Enums;

namespace mUo4XBiMbD2pelN9o9n0;

[Indicator("AC", "AC", false, Type = typeof(RNg93uiMDw91Fa86XDaK))]
[DataContract(Name = "ACIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class RNg93uiMDw91Fa86XDaK : IndicatorBase
{
	private int mBUiMcNR1KO;

	private int ArAiMjmdmr7;

	private IndicatorMaType ASciMEc9v3b;

	private ChartSeries DMpiMQ2sxfb;

	internal static RNg93uiMDw91Fa86XDaK MIGO3qeX4YXfuU0sFps1;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShortPeriod")]
	[DataMember(Name = "ShortPeriod")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int ShortPeriod
	{
		get
		{
			return mBUiMcNR1KO;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == mBUiMcNR1KO)
			{
				return;
			}
			mBUiMcNR1KO = num;
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B50394));
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6D18F862 ^ 0x6D186946));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
				{
					num2 = 0;
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
			return ArAiMjmdmr7;
		}
		set
		{
			num = Math.Max(1, num);
			int num2;
			if (num != ArAiMjmdmr7)
			{
				ArAiMjmdmr7 = num;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 != 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1435596783 ^ -1435627663));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--500511424 ^ 0x1DD5A3E4));
				break;
			case 0:
				break;
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
			return ASciMEc9v3b;
		}
		set
		{
			if (indicatorMaType != ASciMEc9v3b)
			{
				ASciMEc9v3b = indicatorMaType;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x12628510));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
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

	[DisplayName("AC")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "AC")]
	public ChartSeries ACSeries
	{
		get
		{
			return DMpiMQ2sxfb ?? (DMpiMQ2sxfb = new ChartSeries(ChartSeriesType.Columns, Kym1RleXN8l4nulMpRr8()));
		}
		private set
		{
			if (!object.Equals(chartSeries, DMpiMQ2sxfb))
			{
				DMpiMQ2sxfb = chartSeries;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)uGgLY5eXkNYRq9YPsrNs(0x11D1040B ^ 0x11D1A15B));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> dwliMXUAHDf => base.Levels;

	public RNg93uiMDw91Fa86XDaK()
	{
		ecPJaoeX1ihRxNNFQvkT();
		base._002Ector();
		ShortPeriod = 5;
		LongPeriod = 34;
		MaType = IndicatorMaType.EMA;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
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
			base.Levels.Add(new ChartLevel(0m, ojLkQPeX5dlV3A1yyRmo()));
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e != 0)
			{
				num = 1;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = base.Helper.AC(MaType, ShortPeriod, LongPeriod);
		base.Series.Add(new IndicatorSeriesData(data, ACSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		ACSeries.AllColors = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		RNg93uiMDw91Fa86XDaK rNg93uiMDw91Fa86XDaK = (RNg93uiMDw91Fa86XDaK)P_0;
		ShortPeriod = rNg93uiMDw91Fa86XDaK.ShortPeriod;
		LongPeriod = rNg93uiMDw91Fa86XDaK.LongPeriod;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.CopyTemplate(P_0, P_1);
				return;
			}
			MaType = rNg93uiMDw91Fa86XDaK.MaType;
			qEjOeLeXxZiUFS5lXbOH(ACSeries, dYq7sGeXS9ofWbi6A8yH(rNg93uiMDw91Fa86XDaK));
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
			{
				num = 0;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)uGgLY5eXkNYRq9YPsrNs(-1346994499 ^ -1346963155), base.Name, ShortPeriod, LongPeriod);
	}

	static RNg93uiMDw91Fa86XDaK()
	{
		k7UrNJeXLlhZJMMxj2wW();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool LXTIqMeXDm9O09OBT9us()
	{
		return MIGO3qeX4YXfuU0sFps1 == null;
	}

	internal static RNg93uiMDw91Fa86XDaK hoWglSeXbxKSDRwRKDF5()
	{
		return MIGO3qeX4YXfuU0sFps1;
	}

	internal static Color Kym1RleXN8l4nulMpRr8()
	{
		return Colors.Blue;
	}

	internal static object uGgLY5eXkNYRq9YPsrNs(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void ecPJaoeX1ihRxNNFQvkT()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color ojLkQPeX5dlV3A1yyRmo()
	{
		return Colors.Gray;
	}

	internal static object dYq7sGeXS9ofWbi6A8yH(object P_0)
	{
		return ((RNg93uiMDw91Fa86XDaK)P_0).ACSeries;
	}

	internal static void qEjOeLeXxZiUFS5lXbOH(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void k7UrNJeXLlhZJMMxj2wW()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
