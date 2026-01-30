using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[ChartObject("HorizontalRay", "ChartObjectsHorizontalRay", 1, Type = typeof(HorizontalRayObject))]
[DataContract(Name = "HorizontalRayObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class HorizontalRayObject : HorizontalLineObject
{
	internal static HorizontalRayObject vj1Tfge2GiJaNyxJGpIj;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	public HorizontalRayObject()
	{
		OKyKDqe2vaQMnvMlSENR();
		base._002Ector();
		base.PriceLabelAlignment = ObjectTextAlignment.Hide;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 6;
		int num2 = num;
		XBrush brush = default(XBrush);
		long num3 = default(long);
		double num4 = default(double);
		double y2 = default(double);
		double y = default(double);
		Point point = default(Point);
		Point point2 = default(Point);
		while (true)
		{
			XPen xPen;
			switch (num2)
			{
			case 11:
				return;
			case 10:
				visual.FillRectangle(brush, LineRect);
				DrawTextAndPriceLabel(visual);
				labels.Add(new ObjectLabelInfo((double)num3 * num4, y2, y, base.LineColor));
				return;
			case 5:
				return;
			case 1:
				y2 = GetY(((double)num3 + 0.5) * num4);
				y = GetY(((double)num3 - 0.5) * num4);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (base.Settings.TransformHorLines && MbsEsDe2ik5cOtEtTkUx(base.Canvas) && base.Canvas.StockType == ChartStockType.Clusters)
				{
					num2 = 7;
					break;
				}
				goto IL_030b;
			case 7:
			{
				double y3 = base.ControlPoints[0].Y;
				num4 = Ftgd3Ee2lyZndeqAvPf0(base.DataProvider);
				num3 = (long)Math.Round(y3 / num4);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 6:
				if (base.Canvas != null)
				{
					Point point3 = ToPoint(base.ControlPoints[0]);
					if (!(point3.X >= base.Canvas.Rect.Right))
					{
						point = new Point(Math.Max(point3.X - Math.Floor(GAfpowe2aH8l7SJeKKVA(base.Canvas) / 2.0), base.Canvas.Rect.Left), point3.Y);
						point2 = new Point(base.Canvas.Rect.Right, point3.Y);
						LineRect = new Rect(point, point2);
						num2 = 8;
					}
					else
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			case 9:
				return;
			case 3:
				labels.Add(new ObjectLabelInfo(base.ControlPoints[0].Y, base.LineColor));
				num2 = 11;
				break;
			case 4:
				LineRect = Aon9r7e2B65HgsADkKcm();
				num2 = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
				{
					num2 = 9;
				}
				break;
			case 2:
				DrawTextAndPriceLabel(visual);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
				{
					num2 = 3;
				}
				break;
			default:
				{
					if (y - y2 > (double)(base.LineWidth + 2))
					{
						brush = new XBrush(base.LineColor, (base.LineColor.Alpha > 127) ? 127 : base.LineColor.Alpha);
						LineRect = new Rect(new Point(point.X, y2), new Point(point2.X, y));
						num2 = 10;
						break;
					}
					goto IL_030b;
				}
				IL_030b:
				xPen = (base.Alert.IsActive ? base.ActiveAlertLinePen : base.LinePen);
				dQv1rme24HUdhPtLGsGU(visual, xPen, point, point2);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	static HorizontalRayObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		l6ld2Qe2Dj5dNN713EF8();
	}

	internal static void OKyKDqe2vaQMnvMlSENR()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static bool V7fs6ye2Y873XNBth0Cr()
	{
		return vj1Tfge2GiJaNyxJGpIj == null;
	}

	internal static HorizontalRayObject e7OZLbe2omGSIlHjSyRf()
	{
		return vj1Tfge2GiJaNyxJGpIj;
	}

	internal static Rect Aon9r7e2B65HgsADkKcm()
	{
		return Rect.Empty;
	}

	internal static double GAfpowe2aH8l7SJeKKVA(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static bool MbsEsDe2ik5cOtEtTkUx(object P_0)
	{
		return ((IChartCanvas)P_0).IsStock;
	}

	internal static double Ftgd3Ee2lyZndeqAvPf0(object P_0)
	{
		return ((IChartDataProvider)P_0).Step;
	}

	internal static void dQv1rme24HUdhPtLGsGU(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static void l6ld2Qe2Dj5dNN713EF8()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
