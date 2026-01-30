using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;

namespace RH9viWiDOi5Pj3hUavjd;

[Indicator("BidAsk", "BidAsk", false, Type = typeof(ac2kfgiDMQBIgVlUJb5J))]
[DataContract(Name = "BidAskIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class ac2kfgiDMQBIgVlUJb5J : IndicatorBase
{
	private XBrush KL5iDUYU8Bv;

	private XPen ApZiDTk7xo4;

	private XColor aGoiDyOFtQ6;

	private XBrush VO8iDZQKka6;

	private XPen rQTiDVMfteV;

	private XColor qmZiDCdF7KF;

	internal static ac2kfgiDMQBIgVlUJb5J mVjqNXe44tgKb4Jr2xPr;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBidColor")]
	[DataMember(Name = "BidColor")]
	public XColor BidColor
	{
		get
		{
			return aGoiDyOFtQ6;
		}
		set
		{
			if (xColor == aGoiDyOFtQ6)
			{
				return;
			}
			aGoiDyOFtQ6 = xColor;
			KL5iDUYU8Bv = new XBrush(aGoiDyOFtQ6);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged((string)iJ6oBwe4NQ3nSPplcPi4(-1306877528 ^ -1306906280));
					return;
				}
				ApZiDTk7xo4 = new XPen(KL5iDUYU8Bv, 1);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAskColor")]
	[DataMember(Name = "AskColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor AskColor
	{
		get
		{
			return qmZiDCdF7KF;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					rQTiDVMfteV = new XPen(VO8iDZQKka6, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-894902996 ^ -894940120));
					return;
				case 2:
					if (xColor == qmZiDCdF7KF)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
						{
							num2 = 1;
						}
						break;
					}
					qmZiDCdF7KF = xColor;
					VO8iDZQKka6 = new XBrush(qmZiDCdF7KF);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public override bool IntegerValues => true;

	public ac2kfgiDMQBIgVlUJb5J()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		BidColor = Ao234Qe41TW08RxdZV6v(rOBDupe4kZRVBRhfmAle(byte.MaxValue, 178, 34, 34));
		AskColor = Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue);
	}

	protected override void Execute()
	{
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 9;
		int num2 = num;
		double y = default(double);
		double num6 = default(double);
		int num5 = default(int);
		double x = default(double);
		double num4 = default(double);
		int num3 = default(int);
		int index = default(int);
		IChartCluster cluster = default(IChartCluster);
		while (true)
		{
			switch (num2)
			{
			case 9:
				y = GetY(0.0);
				num2 = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				num6 = Math.Max(FqGqNve45C232La0ZGj1(base.Canvas) - 1.0, 1.0);
				num5 = 0;
				goto case 16;
			case 1:
				P_0.DrawLine(ApZiDTk7xo4, x, num4, x, num4 + (double)num3);
				goto IL_01a7;
			case 6:
				num5++;
				num2 = 16;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
				{
					num2 = 11;
				}
				break;
			case 14:
				P_0.FillRectangle(VO8iDZQKka6, new Rect(x - num6 / 2.0, num4, num6, num3));
				goto case 6;
			case 16:
				if (num5 >= base.Canvas.Count)
				{
					return;
				}
				index = base.Canvas.GetIndex(num5);
				cluster = base.DataProvider.GetCluster(index);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (cluster != null)
				{
					x = base.Canvas.GetX(index);
					num4 = GetY(RF5rEHe4xbYU49jOV4ie(nnuGWge4S7f2xSIhG6H3(cluster)));
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 6;
			case 15:
				if ((double)num3 < 0.0)
				{
					num4 += (double)num3;
					num3 = -num3;
					num2 = 13;
					break;
				}
				goto case 13;
			case 10:
				num3 = -num3;
				goto IL_0213;
			case 11:
				num3 = (int)y - (int)num4;
				if ((double)num3 < 0.0)
				{
					num4 += (double)num3;
					num2 = 10;
					break;
				}
				goto IL_0213;
			case 13:
				if (num3 < 1)
				{
					num4 = (int)y - 1;
					num3 = 1;
				}
				num3 = znd7TKe4stIYiA6kbaK5(1, num3);
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				num3 = 1;
				num2 = 12;
				break;
			case 2:
				num4 = (int)y;
				num2 = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (!(num6 > 1.0))
				{
					rAyZGSe4XSIrTPUpqOe2(P_0, rQTiDVMfteV, x, num4, x, num4 + (double)num3);
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 14;
				}
				break;
			case 12:
				num3 = Math.Max(1, num3);
				num2 = 3;
				break;
			case 3:
				if (!(num6 > 1.0))
				{
					goto case 1;
				}
				X5v4Xqe4Ln7jgP1UpoQY(P_0, KL5iDUYU8Bv, new Rect(x - num6 / 2.0, num4, num6, num3));
				goto IL_01a7;
			case 4:
				{
					num3 = (int)y - (int)num4;
					num2 = 8;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
					{
						num2 = 15;
					}
					break;
				}
				IL_01a7:
				num4 = GetY(v0tS6ae4e8SvxusCLGt7(cluster));
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
				{
					num2 = 0;
				}
				break;
				IL_0213:
				if (num3 < 1)
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 12;
			}
		}
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		IChartCluster chartCluster = default(IChartCluster);
		while (true)
		{
			IL_00c9:
			int num4;
			if (num3 < vvv2dFe4Q7T4TeIJSDU1(base.Canvas))
			{
				int i = nnlRfDe4cmVdA3kKPUAv(base.Canvas, num3);
				chartCluster = (IChartCluster)A0rkaCe4jrXYsvHZILAm(base.DataProvider, i);
				if (chartCluster == null)
				{
					goto IL_0027;
				}
				num = Math.Max(num, (double)chartCluster.Bid);
				num4 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 == 0)
				{
					num4 = 1;
				}
			}
			else
			{
				num4 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
				{
					num4 = 2;
				}
			}
			goto IL_0009;
			IL_0027:
			num3++;
			num4 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
			{
				num4 = 0;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num4)
				{
				case 2:
					break;
				case 3:
					P_1 = num2;
					num4 = 4;
					continue;
				case 1:
				{
					num2 = a48lGue4EOEvvCa03qnB(num2, (double)chartCluster.Ask);
					int num5 = 2;
					num4 = num5;
					continue;
				}
				default:
					goto IL_00c9;
				case 4:
					P_0 = 0.0 - num;
					return true;
				}
				break;
			}
			goto IL_0027;
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		IChartCluster cluster = base.DataProvider.GetCluster(cursorPos);
		if (cluster == null)
		{
			return list;
		}
		list.Clear();
		string value = base.Canvas.FormatValue((double)cluster.Bid);
		list.Add(new IndicatorValueInfo(value, BidColor));
		string value2 = base.Canvas.FormatValue((double)cluster.Ask);
		list.Add(new IndicatorValueInfo(value2, AskColor));
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		if (base.DataProvider.Count <= base.Canvas.Start)
		{
			return;
		}
		IChartCluster cluster = base.DataProvider.GetCluster(base.DataProvider.Count - 1 - base.Canvas.Start);
		int num;
		if (cluster == null)
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
			{
				num = 1;
			}
		}
		else
		{
			P_0.Add(new IndicatorLabelInfo(xViAnhe4dRDvxrGkaXFa(cluster.Bid), BidColor));
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			return;
		}
		P_0.Add(new IndicatorLabelInfo((double)v0tS6ae4e8SvxusCLGt7(cluster), AskColor));
	}

	public override bool CheckAlert(double P_0, int P_1, ref int P_2, ref double P_3)
	{
		if (AsO4pLe4gQ58GAwTTiDL(base.DataProvider) == P_2 && P_0 == P_3)
		{
			return false;
		}
		IChartCluster cluster = base.DataProvider.GetCluster(base.DataProvider.Count - 1);
		bool flag = default(bool);
		if (cluster != null)
		{
			flag = false;
			if (P_0 > 0.0 && (double)cluster.Ask >= P_0 - (double)P_1)
			{
				flag = true;
				goto IL_004e;
			}
			goto IL_005a;
		}
		int num = 3;
		goto IL_0009;
		IL_004e:
		if (!flag)
		{
			return false;
		}
		P_2 = base.DataProvider.Count;
		num = 2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 5:
				return true;
			case 4:
				goto IL_005a;
			case 3:
				return false;
			case 1:
				if (xViAnhe4dRDvxrGkaXFa(cluster.Bid) <= P_0 + (double)P_1)
				{
					flag = true;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 2:
				P_3 = P_0;
				num = 5;
				continue;
			}
			break;
		}
		goto IL_004e;
		IL_005a:
		if (P_0 < 0.0)
		{
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_004e;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		BidColor = P_0.PaletteColor7;
		AskColor = P_0.PaletteColor6;
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		ac2kfgiDMQBIgVlUJb5J ac2kfgiDMQBIgVlUJb5J2 = default(ac2kfgiDMQBIgVlUJb5J);
		while (true)
		{
			switch (num2)
			{
			default:
				BidColor = ac2kfgiDMQBIgVlUJb5J2.BidColor;
				AskColor = ac2kfgiDMQBIgVlUJb5J2.AskColor;
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				ac2kfgiDMQBIgVlUJb5J2 = (ac2kfgiDMQBIgVlUJb5J)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static ac2kfgiDMQBIgVlUJb5J()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object iJ6oBwe4NQ3nSPplcPi4(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool Wf3YvRe4DO7NansCVguQ()
	{
		return mVjqNXe44tgKb4Jr2xPr == null;
	}

	internal static ac2kfgiDMQBIgVlUJb5J dPZOpXe4b8Fso6qC9WwF()
	{
		return mVjqNXe44tgKb4Jr2xPr;
	}

	internal static Color rOBDupe4kZRVBRhfmAle(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor Ao234Qe41TW08RxdZV6v(Color P_0)
	{
		return P_0;
	}

	internal static double FqGqNve45C232La0ZGj1(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static decimal nnuGWge4S7f2xSIhG6H3(object P_0)
	{
		return ((IChartCluster)P_0).Bid;
	}

	internal static decimal RF5rEHe4xbYU49jOV4ie(decimal P_0)
	{
		return -P_0;
	}

	internal static void X5v4Xqe4Ln7jgP1UpoQY(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static decimal v0tS6ae4e8SvxusCLGt7(object P_0)
	{
		return ((IChartCluster)P_0).Ask;
	}

	internal static int znd7TKe4stIYiA6kbaK5(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void rAyZGSe4XSIrTPUpqOe2(object P_0, object P_1, double P_2, double P_3, double P_4, double P_5)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3, P_4, P_5);
	}

	internal static int nnlRfDe4cmVdA3kKPUAv(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static object A0rkaCe4jrXYsvHZILAm(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetCluster(i);
	}

	internal static double a48lGue4EOEvvCa03qnB(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static int vvv2dFe4Q7T4TeIJSDU1(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static double xViAnhe4dRDvxrGkaXFa(decimal P_0)
	{
		return (double)P_0;
	}

	internal static int AsO4pLe4gQ58GAwTTiDL(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}
}
