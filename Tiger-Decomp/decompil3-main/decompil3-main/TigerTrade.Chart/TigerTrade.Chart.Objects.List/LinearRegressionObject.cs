using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[ChartObject("LinearRegression", "ChartObjectsLinearRegression", 2, Type = typeof(LinearRegressionObject))]
[DataContract(Name = "LinearRegressionObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class LinearRegressionObject : LineGroupObjectBaseEx
{
	private bool _upLine;

	private bool _centerLine;

	private bool _downLine;

	private bool _showAuxLine;

	private double _percentage;

	private RegressionType _regressionType;

	private static LinearRegressionObject gA50EPeH8rON9vLqTD4o;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsUpLine")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[DataMember(Name = "UpLine")]
	public bool UpLine
	{
		get
		{
			return _upLine;
		}
		set
		{
			if (value != _upLine)
			{
				_upLine = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522664589));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsCenterLine")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[DataMember(Name = "CenterLine")]
	public bool CenterLine
	{
		get
		{
			return _centerLine;
		}
		set
		{
			if (value != _centerLine)
			{
				_centerLine = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-894902996 ^ -894935246));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
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

	[DataMember(Name = "DownLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsDownLine")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	public bool DownLine
	{
		get
		{
			return _downLine;
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
				case 0:
					return;
				case 1:
					if (value != _downLine)
					{
						_downLine = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xC1DDB3B ^ 0xC1D590D));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[DataMember(Name = "ShowAuxLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsGuideLines")]
	public bool ShowAuxLine
	{
		get
		{
			return _showAuxLine;
		}
		set
		{
			if (value != _showAuxLine)
			{
				_showAuxLine = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x16AD7E76 ^ 0x16ADFC3C));
			}
		}
	}

	[DataMember(Name = "Percentage")]
	[Browsable(false)]
	public double Percentage
	{
		get
		{
			return _percentage;
		}
		set
		{
			if (value != _percentage)
			{
				_percentage = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDCD71));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsParameters")]
	[DataMember(Name = "RegressionType")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsRegressionType")]
	public RegressionType RegressionType
	{
		get
		{
			return _regressionType;
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
				case 0:
					return;
				case 1:
					if (value != _regressionType)
					{
						_regressionType = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176493345));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LinearRegressionObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		base.OpenStart = false;
		base.OpenEnd = false;
		UpLine = true;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				DownLine = true;
				CenterLine = true;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				ShowAuxLine = false;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				Percentage = 1.0;
				RegressionType = RegressionType.UpDownTrend;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		base.Draw(visual, ref labels);
		Point point = ToPoint(base.ControlPoints[0]);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
		{
			num = 0;
		}
		Point point2 = default(Point);
		Rect rect = default(Rect);
		while (true)
		{
			switch (num)
			{
			case 2:
				if (point != default(Point) && point2 != default(Point))
				{
					visual.DrawLine(base.LinePen, point.X, rect.Y, point.X, rect.Bottom);
					visual.DrawLine(base.LinePen, point2.X, rect.Y, point2.X, rect.Bottom);
				}
				return;
			default:
				point2 = ToPoint(base.ControlPoints[1]);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				rect = base.Canvas.Rect;
				if (!InMove)
				{
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
					{
						num = 2;
					}
					break;
				}
				goto case 2;
			case 3:
				if (ShowAuxLine)
				{
					num = 2;
					break;
				}
				return;
			}
		}
	}

	private void AddLine(List<Tuple<ObjectPoint, ObjectPoint>> segments, ObjectPoint op1, ObjectPoint op2, double delta)
	{
		op1.Y -= delta * Percentage;
		op2.Y -= delta * Percentage;
		segments.Add(new Tuple<ObjectPoint, ObjectPoint>(op1, op2));
	}

	protected override void CalcPoint()
	{
		if (!base.Canvas.IsStock)
		{
			return;
		}
		int num = 0;
		int num2 = 12;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
		{
			num2 = 16;
		}
		double num10 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		List<Tuple<ObjectPoint, ObjectPoint>> list = default(List<Tuple<ObjectPoint, ObjectPoint>>);
		ObjectPoint objectPoint3 = default(ObjectPoint);
		Tuple<ObjectPoint, ObjectPoint> tuple = default(Tuple<ObjectPoint, ObjectPoint>);
		ObjectPoint objectPoint2 = default(ObjectPoint);
		ObjectPoint objectPoint = default(ObjectPoint);
		int num11 = default(int);
		double a = default(double);
		double[] f = default(double[]);
		double b = default(double);
		int num3 = default(int);
		int num4 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num9;
			switch (num2)
			{
			case 18:
				if (base.ControlPoints[0].X > base.ControlPoints[1].X)
				{
					num = 1;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_04f7;
			case 14:
				num10 = Math.Max(Math.Abs(num5), v6y8y8eHudg1vVNjTVik(num6));
				goto default;
			case 6:
				if (DownLine)
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 15;
			case 15:
				StartPoints = new Point[list.Count];
				num2 = 7;
				continue;
			case 13:
				objectPoint3 = tuple.Item2;
				num2 = 17;
				continue;
			case 21:
				if (!LGSNhAef0RvKsZ0AHBqX(objectPoint3.Y))
				{
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 20;
			case 24:
				num10 = 0.0 - num5;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
			case 25:
				objectPoint2 = base.ControlPoints[num];
				objectPoint = base.ControlPoints[num11];
				objectPoint2.Y = a;
				num2 = 2;
				continue;
			case 4:
				AddLine(list, objectPoint2, objectPoint, 0.0 - num10);
				goto case 15;
			case 11:
				f = base.DataProvider[yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2074141628 ^ -2074108200)];
				if (RegressionType == RegressionType.UpDownTrend)
				{
					a = base.ControlPoints[num].Y;
					b = (base.ControlPoints[num11].Y - base.ControlPoints[num].Y) / (double)(num3 - num4);
					num2 = 9;
				}
				else
				{
					CalcLinearRegression(f, num3, num3 - num4, out a, out b);
					num2 = 25;
				}
				continue;
			case 7:
				EndPoints = new Point[dZcriUeHz1atVCC7ogJJ(list)];
				num2 = 5;
				continue;
			case 5:
				num8 = 0;
				num2 = 10;
				continue;
			case 23:
				OpenStartEnd(base.OpenStart, base.OpenEnd);
				return;
			case 1:
				num11 = 0;
				goto IL_04f7;
			case 16:
				num11 = 1;
				num9 = 18;
				goto IL_0005;
			case 8:
				EndPoints[num8] = ToPoint(tuple.Item2);
				num2 = 22;
				continue;
			case 10:
			case 19:
				if (num8 < list.Count)
				{
					tuple = list[num8];
					objectPoint3 = tuple.Item1;
					num2 = 21;
					continue;
				}
				num9 = 23;
				goto IL_0005;
			case 12:
				if (RegressionType == RegressionType.Channel)
				{
					goto case 14;
				}
				goto case 24;
			case 17:
				if (LGSNhAef0RvKsZ0AHBqX(objectPoint3.Y))
				{
					goto case 20;
				}
				StartPoints[num8] = ToPoint(tuple.Item1);
				num2 = 8;
				continue;
			case 22:
				num8++;
				num2 = 19;
				continue;
			case 3:
				break;
			case 2:
				objectPoint.Y = a + b * (double)(num3 - num4);
				list = new List<Tuple<ObjectPoint, ObjectPoint>>();
				if (CenterLine)
				{
					list.Add(new Tuple<ObjectPoint, ObjectPoint>(objectPoint2, objectPoint));
				}
				switch (RegressionType)
				{
				case RegressionType.StdChannel:
				case RegressionType.StdErrorChannel:
				{
					double num7 = Std(RegressionType == RegressionType.StdErrorChannel, f, num4, num3);
					AddLine(list, objectPoint2, objectPoint, num7);
					AddLine(list, objectPoint2, objectPoint, 0.0 - num7);
					num2 = 15;
					continue;
				}
				case RegressionType.Channel:
				case RegressionType.AsynChannel:
				case RegressionType.UpDownTrend:
				{
					object obj = T0pyQweH3G3inJgGl6xQ(base.DataProvider, XCvchseHFZgwI9atJmsw(0x60620FC1 ^ 0x60628D6B));
					double[] data = (double[])T0pyQweH3G3inJgGl6xQ(base.DataProvider, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24085900 ^ 0x2408DBB6));
					num5 = GxXoJxeHplNE2DbixC1l(obj, a, b, num4, num3, XCvchseHFZgwI9atJmsw(-176525661 ^ -176493469), true);
					num6 = CalcDelta(data, a, b, num4, num3, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60821283), calcMax: false);
					num2 = 12;
					continue;
				}
				}
				goto case 15;
			default:
				if (UpLine)
				{
					AddLine(list, objectPoint2, objectPoint, num10);
				}
				if (RegressionType != RegressionType.Channel)
				{
					break;
				}
				goto case 6;
			case 20:
				{
					StartPoints[num8] = default(Point);
					EndPoints[num8] = default(Point);
					goto case 22;
				}
				IL_0005:
				num2 = num9;
				continue;
				IL_04f7:
				num4 = g7DyoSeHJvdbmdwWmaKc(base.Canvas, base.ControlPoints[num].X, 0);
				num3 = base.Canvas.DateToIndex(base.ControlPoints[num11].X, 0);
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num2 = 11;
				}
				continue;
			}
			num10 = num6;
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
			{
				num2 = 6;
			}
		}
	}

	private static double CalcDelta(double[] data, double a, double b, int bar1, int bar2, string lineName, bool calcMax)
	{
		int num = 1;
		int num2 = num;
		double num4 = default(double);
		double num6 = default(double);
		int num5 = default(int);
		while (true)
		{
			double num3;
			switch (num2)
			{
			case 1:
				num4 = double.MinValue;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				num6 = a + b * (double)(num5 - bar1);
				if (!calcMax)
				{
					num3 = rvDjwsef2I7FPXRSVXja(num4, data[num5] - num6);
					goto IL_0131;
				}
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				num4 = double.MaxValue;
				goto IL_004c;
			default:
				if (!calcMax)
				{
					num2 = 4;
					break;
				}
				goto IL_004c;
			case 5:
				return num4;
			case 2:
				{
					num3 = Math.Max(num4, data[num5] - num6);
					goto IL_0131;
				}
				IL_00f8:
				if (num5 >= AWxgHbefH5J6YxiaurIE(bar2, data.Length))
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 3;
				IL_004c:
				num5 = Math.Max(0, bar1);
				goto IL_00f8;
				IL_0131:
				num4 = num3;
				num5++;
				goto IL_00f8;
			}
		}
	}

	private static double Std(bool error, double[] f, int bar1, int bar2)
	{
		double num = 0.0;
		int num2 = Math.Min(bar2, f.Length);
		int num3 = AWxgHbefH5J6YxiaurIE(bar1, f.Length);
		int num4;
		int num5 = default(int);
		if (num2 == num3)
		{
			num4 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
			{
				num4 = 0;
			}
		}
		else
		{
			num5 = num3;
			num4 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
			{
				num4 = 0;
			}
		}
		int num6 = default(int);
		double num7 = default(double);
		while (true)
		{
			switch (num4)
			{
			case 5:
				num6 = num3;
				goto case 3;
			case 6:
				num5++;
				goto default;
			case 4:
				num7 += (f[num6] - num) * (f[num6] - num);
				num4 = 2;
				break;
			case 1:
				return 0.0;
			case 3:
				if (num6 >= num2)
				{
					num7 /= (double)(num2 - num3 - ((!error) ? 1 : 0));
					return Math.Sqrt(num7);
				}
				goto case 4;
			case 2:
				num6++;
				num4 = 3;
				break;
			default:
				if (num5 >= num2)
				{
					num /= (double)(num2 - num3);
					num7 = 0.0;
					num4 = 5;
					break;
				}
				goto case 7;
			case 7:
				num += f[num5];
				num4 = 6;
				break;
			}
		}
	}

	private static void CalcLinearRegression(double[] f, int start, int count, out double a, out double b)
	{
		double num = default(double);
		double num2 = default(double);
		double num3 = default(double);
		int num4;
		if (start >= count - 1)
		{
			num = ((double)count - 1.0) / 2.0;
			num2 = 0.0;
			num3 = 0.0;
			num4 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
			{
				num4 = 0;
			}
		}
		else
		{
			a = double.NaN;
			num4 = 7;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
			{
				num4 = 3;
			}
		}
		double num5 = default(double);
		int num7 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num4)
			{
			case 6:
				b = (num2 - (double)count * num * num5) / (num3 - (double)count * num * num);
				a = num5 - b * num;
				num4 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
				{
					num4 = 4;
				}
				break;
			case 4:
				return;
			case 3:
				num2 += (double)num7 * f[num6];
				num3 += (double)(num7 * num7);
				num5 += f[num6];
				num7++;
				goto IL_01c6;
			case 7:
				b = double.NaN;
				num4 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
				{
					num4 = 1;
				}
				break;
			default:
				num7 = 0;
				goto IL_01c6;
			case 1:
				return;
			case 2:
				num5 = 0.0;
				num4 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
				{
					num4 = 0;
				}
				break;
			case 5:
				{
					num6 = start - count + 1 + num7;
					if (num6 >= f.Length)
					{
						num6 = f.Length - 1;
						num4 = 3;
						break;
					}
					goto case 3;
				}
				IL_01c6:
				if (num7 >= count)
				{
					num5 /= (double)count;
					num4 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
					{
						num4 = 4;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 2;
		int num2 = num;
		LinearRegressionObject linearRegressionObject = default(LinearRegressionObject);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (linearRegressionObject != null)
				{
					UpLine = linearRegressionObject.UpLine;
					CenterLine = MILkjueff2VDt4T0MCry(linearRegressionObject);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_008c;
			case 3:
				ShowAuxLine = linearRegressionObject.ShowAuxLine;
				num2 = 4;
				break;
			default:
				DownLine = linearRegressionObject.DownLine;
				num2 = 3;
				break;
			case 4:
				Percentage = linearRegressionObject.Percentage;
				RegressionType = linearRegressionObject.RegressionType;
				goto IL_008c;
			case 2:
				{
					linearRegressionObject = objectBase as LinearRegressionObject;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_008c:
				base.CopyTemplate(objectBase, style);
				return;
			}
		}
	}

	static LinearRegressionObject()
	{
		mkiUXXef9PcDITawg1nH();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool pPS7UEeHAZwQMRQeGi5K()
	{
		return gA50EPeH8rON9vLqTD4o == null;
	}

	internal static LinearRegressionObject hYMftceHPruGuSHbLNRC()
	{
		return gA50EPeH8rON9vLqTD4o;
	}

	internal static int g7DyoSeHJvdbmdwWmaKc(object P_0, double dt, int dir)
	{
		return ((IChartCanvas)P_0).DateToIndex(dt, dir);
	}

	internal static object XCvchseHFZgwI9atJmsw(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object T0pyQweH3G3inJgGl6xQ(object P_0, object P_1)
	{
		return ((IChartDataProvider)P_0)[(string)P_1];
	}

	internal static double GxXoJxeHplNE2DbixC1l(object P_0, double a, double b, int bar1, int bar2, object P_5, bool calcMax)
	{
		return CalcDelta((double[])P_0, a, b, bar1, bar2, (string)P_5, calcMax);
	}

	internal static double v6y8y8eHudg1vVNjTVik(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static int dZcriUeHz1atVCC7ogJJ(object P_0)
	{
		return ((List<Tuple<ObjectPoint, ObjectPoint>>)P_0).Count;
	}

	internal static bool LGSNhAef0RvKsZ0AHBqX(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static double rvDjwsef2I7FPXRSVXja(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int AWxgHbefH5J6YxiaurIE(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static bool MILkjueff2VDt4T0MCry(object P_0)
	{
		return ((LinearRegressionObject)P_0).CenterLine;
	}

	internal static void mkiUXXef9PcDITawg1nH()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
