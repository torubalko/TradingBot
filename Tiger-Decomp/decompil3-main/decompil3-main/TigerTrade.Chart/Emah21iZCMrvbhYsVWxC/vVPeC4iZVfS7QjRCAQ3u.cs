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

namespace Emah21iZCMrvbhYsVWxC;

[DataContract(Name = "ZigZagIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("ZigZag", "ZigZag", true, Type = typeof(vVPeC4iZVfS7QjRCAQ3u))]
internal sealed class vVPeC4iZVfS7QjRCAQ3u : IndicatorBase
{
	private int zSxiZP4qWgo;

	private int Y5aiZJXKovB;

	private int HuFiZFuBwZS;

	private ChartSeries koOiZ3lekRP;

	internal static vVPeC4iZVfS7QjRCAQ3u UStcnceRt1waaBw9XKu1;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDepth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Depth")]
	public int Depth
	{
		get
		{
			return zSxiZP4qWgo;
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
					num3 = cNCEEFeRyTI6bDL0tFuJ(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num3 == zSxiZP4qWgo)
				{
					return;
				}
				zSxiZP4qWgo = num3;
				OnPropertyChanged((string)iPqp1feRZXuFSLaZgIlm(-530053095 ^ -530013459));
				OnPropertyChanged((string)iPqp1feRZXuFSLaZgIlm(-338769610 ^ -338798574));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDeviation")]
	[DataMember(Name = "Deviation")]
	public int Deviation
	{
		get
		{
			return Y5aiZJXKovB;
		}
		set
		{
			num = cNCEEFeRyTI6bDL0tFuJ(1, num);
			int num2;
			if (num != Y5aiZJXKovB)
			{
				Y5aiZJXKovB = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECA942A));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 0:
				break;
			case 1:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--927068468 ^ 0x37416010));
				break;
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Backstep")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBackstep")]
	public int Backstep
	{
		get
		{
			return HuFiZFuBwZS;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = Math.Max(1, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (num3 == HuFiZFuBwZS)
					{
						return;
					}
					HuFiZFuBwZS = num3;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-203064540 ^ -203042756));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-617064403 ^ -617035511));
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "ZigZag")]
	[DisplayName("ZigZag")]
	public ChartSeries ZigZagSeries
	{
		get
		{
			return koOiZ3lekRP ?? (koOiZ3lekRP = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(objA, koOiZ3lekRP))
			{
				koOiZ3lekRP = objA;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736525548));
			}
		}
	}

	public vVPeC4iZVfS7QjRCAQ3u()
	{
		G5BD7NeRVlGR6r1S12JX();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Backstep = 3;
				return;
			case 1:
				Depth = 12;
				Deviation = 5;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Execute()
	{
		double[] data = base.Helper.ZIGZAG(Depth, Deviation, Backstep);
		base.Series.Add(new IndicatorSeriesData(data, ZigZagSeries));
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		foreach (IndicatorSeriesData item in base.Series)
		{
			if (!item.Style.DisableValue && cursorPos >= 0 && cursorPos < item.Length && !double.IsNaN(item[cursorPos]))
			{
				string text = "";
				if (!string.IsNullOrEmpty(item.Style.Name))
				{
					text = item.Style.Name + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D3191F8);
				}
				text += base.Canvas.FormatValue(item[cursorPos]);
				list.Add(new IndicatorValueInfo(text, new XBrush(item.Style.Color)));
			}
		}
		return list;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		pxkFZjeRCdxGJClaLkCU(ZigZagSeries, P_0.GetNextColor());
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		vVPeC4iZVfS7QjRCAQ3u vVPeC4iZVfS7QjRCAQ3u2 = (vVPeC4iZVfS7QjRCAQ3u)P_0;
		Depth = vVPeC4iZVfS7QjRCAQ3u2.Depth;
		Deviation = bPNE45eRrWThXkng0vsA(vVPeC4iZVfS7QjRCAQ3u2);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				lfVISseRKvd9ScsAWrGa(ZigZagSeries, vVPeC4iZVfS7QjRCAQ3u2.ZigZagSeries);
				base.CopyTemplate(P_0, P_1);
				return;
			}
			Backstep = vVPeC4iZVfS7QjRCAQ3u2.Backstep;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
			{
				num = 1;
			}
		}
	}

	public override string ToString()
	{
		return (string)xV9H5oeRmeCMQjTudBfX(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461292091 ^ -1461257365), new object[4] { base.Name, Depth, Deviation, Backstep });
	}

	static vVPeC4iZVfS7QjRCAQ3u()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int cNCEEFeRyTI6bDL0tFuJ(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object iPqp1feRZXuFSLaZgIlm(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool n6v1IVeRUVP0dcEtdiRT()
	{
		return UStcnceRt1waaBw9XKu1 == null;
	}

	internal static vVPeC4iZVfS7QjRCAQ3u QOffDgeRTYrxl6ZX8gY4()
	{
		return UStcnceRt1waaBw9XKu1;
	}

	internal static void G5BD7NeRVlGR6r1S12JX()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void pxkFZjeRCdxGJClaLkCU(object P_0, XColor value)
	{
		((ChartSeries)P_0).AllColors = value;
	}

	internal static int bPNE45eRrWThXkng0vsA(object P_0)
	{
		return ((vVPeC4iZVfS7QjRCAQ3u)P_0).Deviation;
	}

	internal static void lfVISseRKvd9ScsAWrGa(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static object xV9H5oeRmeCMQjTudBfX(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}
}
