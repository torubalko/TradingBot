using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using DQ3RIRilFbsKdQctor4q;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;

namespace E9bbokiaMTlGnhJCf296;

[ChartObject("Pitchfork", "ChartObjectsPitchfork", 3, Type = typeof(LQwHHQia6KNV1RXNQ7lQ))]
[DataContract(Name = "PitchforkObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
internal sealed class LQwHHQia6KNV1RXNQ7lQ : LineGroupObjectBase
{
	private int TrDiaWoATN4;

	internal static LQwHHQia6KNV1RXNQ7lQ YHJgSTefkJS8HJW4nunR;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLinesCount")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[DataMember(Name = "LineCount")]
	public int LineCount
	{
		get
		{
			return TrDiaWoATN4;
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
					if (num3 != TrDiaWoATN4)
					{
						TrDiaWoATN4 = num3;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDCDD9));
					}
					return;
				case 1:
					num3 = OlncCjefSm76OBN037rE(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LQwHHQia6KNV1RXNQ7lQ()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		LineCount = 2;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void CalcPoint()
	{
		Point[] array = ToPoints(base.ControlPoints);
		StartPoints = new Point[3 + LineCount * 2];
		int num = 3;
		int num2 = default(int);
		double num3 = default(double);
		int num5 = default(int);
		double num4 = default(double);
		double num6 = default(double);
		double num7 = default(double);
		while (true)
		{
			switch (num)
			{
			case 1:
				StartPoints[3 + num2] = new Point(EndPoints[2].X - num3 * (double)num5, EndPoints[2].Y - num4 * (double)num5);
				num = 7;
				break;
			case 8:
				EndPoints[2] = new Point((array[1].X + array[2].X) / 2.0, (array[1].Y + array[2].Y) / 2.0);
				num6 = EndPoints[2].X - array[0].X;
				num7 = EndPoints[2].Y - array[0].Y;
				num = 10;
				break;
			case 9:
				num2++;
				goto IL_0396;
			case 7:
			{
				EndPoints[3 + num2] = new Point(StartPoints[3 + num2].X + num6 * (double)Math.Abs(num5), StartPoints[3 + num2].Y + num7 * (double)Math.Abs(num5));
				XyaVo8ilJa9AfK2KZEye.LkYi424Ks5t(base.Canvas, StartPoints[3 + num2], EndPoints[3 + num2], out var point2);
				EndPoints[3 + num2] = point2;
				num = 9;
				break;
			}
			case 2:
				return;
			case 4:
				if (num5 >= 0)
				{
					int num8 = 5;
					num = num8;
					break;
				}
				goto case 1;
			case 3:
				EndPoints = new Point[3 + LineCount * 2];
				StartPoints[0] = default(Point);
				EndPoints[0] = default(Point);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num = 0;
				}
				break;
			case 5:
				num5++;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
				{
					num = 1;
				}
				break;
			case 10:
				num3 = EndPoints[2].X - array[1].X;
				num4 = EndPoints[2].Y - array[1].Y;
				num2 = 0;
				goto IL_0396;
			case 6:
			{
				StartPoints[1] = StartPoints[3];
				EndPoints[1] = StartPoints[StartPoints.Length - 1];
				XyaVo8ilJa9AfK2KZEye.LkYi424Ks5t(base.Canvas, StartPoints[2], EndPoints[2], out var point);
				EndPoints[2] = point;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
				{
					num = 2;
				}
				break;
			}
			default:
				{
					StartPoints[2] = array[0];
					num = 8;
					break;
				}
				IL_0396:
				if (num2 < LineCount * 2)
				{
					num5 = num2 - LineCount;
					num = 4;
					break;
				}
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num = 6;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(ObjectBase P_0, bool P_1)
	{
		if (P_0 is LQwHHQia6KNV1RXNQ7lQ lQwHHQia6KNV1RXNQ7lQ)
		{
			LineCount = lQwHHQia6KNV1RXNQ7lQ.LineCount;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		base.CopyTemplate(P_0, P_1);
	}

	public static ObjectBase OtYiaOVOOAh(IChartTheme P_0)
	{
		LQwHHQia6KNV1RXNQ7lQ lQwHHQia6KNV1RXNQ7lQ = new LQwHHQia6KNV1RXNQ7lQ();
		lQwHHQia6KNV1RXNQ7lQ.ApplyTheme(P_0);
		return lQwHHQia6KNV1RXNQ7lQ;
	}

	static LQwHHQia6KNV1RXNQ7lQ()
	{
		cIMGWxefxYFei9ZlFIbL();
		KRaroVefLcVyb5kB30mR();
	}

	internal static int OlncCjefSm76OBN037rE(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool Dv5Galef1aYndCHrl24h()
	{
		return YHJgSTefkJS8HJW4nunR == null;
	}

	internal static LQwHHQia6KNV1RXNQ7lQ cvaAJUef5hRRbvOZDx43()
	{
		return YHJgSTefkJS8HJW4nunR;
	}

	internal static void cIMGWxefxYFei9ZlFIbL()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void KRaroVefLcVyb5kB30mR()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
