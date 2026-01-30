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
using TigerTrade.Dx;

namespace aJwVVciymWhfGUobuY7y;

[Indicator("UltimateOscillator", "UltimateOscillator", false, Type = typeof(v5UDFpiyK1n6PvUo1FBH))]
[DataContract(Name = "UltimateOscillatorIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class v5UDFpiyK1n6PvUo1FBH : IndicatorBase
{
	private int OQpiyucyomk;

	private int obMiyzx7V9S;

	private int GdHiZ07uBbc;

	private ChartSeries CBjiZ2adst0;

	internal static v5UDFpiyK1n6PvUo1FBH XjXG6WegpMoERcMTa1rj;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod1")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period1")]
	public int Period1
	{
		get
		{
			return OQpiyucyomk;
		}
		set
		{
			num = Math.Max(1, num);
			int num2;
			if (num == OQpiyucyomk)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				OQpiyucyomk = num;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged((string)ntRyNVeR04gg2y1bkWw1(0xB15786A ^ 0xB15F2F0));
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x86EFEF6 ^ 0x86E6FD2));
		}
	}

	[DataMember(Name = "Period2")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod2")]
	public int Period2
	{
		get
		{
			return obMiyzx7V9S;
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
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					OnPropertyChanged((string)ntRyNVeR04gg2y1bkWw1(0x7DB10E6E ^ 0x7DB19F4A));
					return;
				}
				if (num3 == obMiyzx7V9S)
				{
					return;
				}
				obMiyzx7V9S = num3;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x8093067));
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod3")]
	[DataMember(Name = "Period3")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int Period3
	{
		get
		{
			return GdHiZ07uBbc;
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
					return;
				case 1:
					num3 = KAqn4OeR2t11FGFaEtSr(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num3 != GdHiZ07uBbc)
				{
					GdHiZ07uBbc = num3;
					OnPropertyChanged((string)ntRyNVeR04gg2y1bkWw1(-448941864 ^ -448972186));
					OnPropertyChanged((string)ntRyNVeR04gg2y1bkWw1(0x2CBEEA31 ^ 0x2CBE7B15));
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[DisplayName("UltOsc")]
	[DataMember(Name = "UltOsc")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartSeries UltOscSeries
	{
		get
		{
			return CBjiZ2adst0 ?? (CBjiZ2adst0 = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(chartSeries, CBjiZ2adst0))
			{
				CBjiZ2adst0 = chartSeries;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-991861155 ^ -991834919));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	public List<ChartLevel> oQ7iypR3Dxo => base.Levels;

	public v5UDFpiyK1n6PvUo1FBH()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				Period1 = 7;
				Period2 = 14;
				num = 2;
				break;
			case 2:
				Period3 = 28;
				base.Levels.Add(new ChartLevel(70m, Colors.Gray));
				base.Levels.Add(new ChartLevel(30m, Colors.Gray));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = base.Helper.UltOsc(Period1, Period2, Period3);
		G87IBoeRHBxXYONvMdJ2(base.Series, new IndicatorSeriesData(data, UltOscSeries));
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		UltOscSeries.AllColors = bLWrAHeRfAQPDEOD1W09(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		v5UDFpiyK1n6PvUo1FBH v5UDFpiyK1n6PvUo1FBH2 = (v5UDFpiyK1n6PvUo1FBH)P_0;
		Period1 = v5UDFpiyK1n6PvUo1FBH2.Period1;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
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
			Period2 = v5UDFpiyK1n6PvUo1FBH2.Period2;
			Period3 = v5UDFpiyK1n6PvUo1FBH2.Period3;
			UltOscSeries.CopyTheme((ChartSeries)XpyAXseR9Eqc0cwE8L9x(v5UDFpiyK1n6PvUo1FBH2));
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68C7EAE6 ^ 0x68C76248), base.Name, Period1, Period2, Period3);
	}

	static v5UDFpiyK1n6PvUo1FBH()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object ntRyNVeR04gg2y1bkWw1(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool AaDj1AeguI0Ao61vhb3D()
	{
		return XjXG6WegpMoERcMTa1rj == null;
	}

	internal static v5UDFpiyK1n6PvUo1FBH ah8n2gegzFMu0hoBshf9()
	{
		return XjXG6WegpMoERcMTa1rj;
	}

	internal static int KAqn4OeR2t11FGFaEtSr(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void G87IBoeRHBxXYONvMdJ2(object P_0, object P_1)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1);
	}

	internal static XColor bLWrAHeRfAQPDEOD1W09(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static object XpyAXseR9Eqc0cwE8L9x(object P_0)
	{
		return ((v5UDFpiyK1n6PvUo1FBH)P_0).UltOscSeries;
	}
}
