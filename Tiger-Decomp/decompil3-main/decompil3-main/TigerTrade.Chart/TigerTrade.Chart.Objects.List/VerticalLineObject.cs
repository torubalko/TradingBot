using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Properties;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "VerticalLineObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("VerticalLine", "ChartObjectsVerticalLine", 1, Type = typeof(VerticalLineObject))]
public sealed class VerticalLineObject : LineObjectBase
{
	private ChartAlertSettings _alert;

	private Rect _lineRect;

	private int _lastAlertIndex;

	private DateTime _lastLineTime;

	internal static VerticalLineObject FGxBwAe9gJS89OiHCoGk;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(true)]
	[DataMember(Name = "Alert")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlert")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsAlert")]
	public ChartAlertSettings Alert
	{
		get
		{
			return _alert ?? (_alert = new ChartAlertSettings());
		}
		set
		{
			if (!FUmF6Ve9MXtiCcZHeDMR(value, _alert))
			{
				_alert = value;
				OnPropertyChanged((string)tuspwIe9Of8OBvFKPL40(-165474503 ^ -165449025));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
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

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		if (base.Canvas == null)
		{
			return;
		}
		Point point = ToPoint(base.ControlPoints[0]);
		int num = 5;
		Point point2 = default(Point);
		Point point3 = default(Point);
		double num2 = default(double);
		double num3 = default(double);
		XBrush xBrush = default(XBrush);
		while (true)
		{
			switch (num)
			{
			default:
				visual.DrawLine(base.LinePen, point2, point3);
				return;
			case 3:
				_lineRect = new Rect(point2, point3);
				if (!base.Settings.TransformVertLines)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				_lineRect = new Rect(new Point(num2, point2.Y), new Point(num3, point3.Y));
				KHSMqle9IAE2lwjmgXPo(visual, xBrush, _lineRect);
				return;
			case 4:
				if (base.Canvas.IsStock)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
					{
						num = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (base.Canvas.StockType == ChartStockType.Clusters)
				{
					xBrush = new XBrush(Xpd8iXe9q20Rpdf8L0D2(base.LineBrush), (Xpd8iXe9q20Rpdf8L0D2(base.LineBrush).Alpha > 127) ? 127 : 255);
					double x = point.X;
					num2 = x - base.Canvas.ColumnWidth / 2.0;
					num3 = x + base.Canvas.ColumnWidth / 2.0;
					if (num3 - num2 > (double)(base.LineWidth + 2))
					{
						num = 2;
						break;
					}
				}
				goto default;
			case 5:
				point2 = new Point(point.X, base.Canvas.Rect.Top);
				point3 = new Point(point.X, base.Canvas.Rect.Bottom);
				num = 3;
				break;
			}
		}
	}

	public override void DrawControlPoints(DxVisualQueue visual)
	{
		if (_lineRect == Rect.Empty)
		{
			return;
		}
		int num = base.LineWidth / 2 + 4;
		int num2 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
		{
			num2 = 0;
		}
		Rect rect = default(Rect);
		Point point = default(Point);
		while (true)
		{
			switch (num2)
			{
			case 2:
				rect.Inflate(new Size(num, num));
				visual.FillRectangle((XBrush)bKCXqLe9WKoTLRpCEq2K(base.Theme), rect);
				visual.DrawRectangle(base.Theme.ChartCpLinePen, rect);
				return;
			case 1:
				rect = new Rect(point, point);
				num2 = 2;
				continue;
			}
			point = new Point((_lineRect.Left + _lineRect.Right) / 2.0, (_lineRect.Top + _lineRect.Bottom) / 2.0);
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
			{
				num2 = 1;
			}
		}
	}

	protected override bool InObject(int x, int y)
	{
		if (_lineRect == Rect.Empty)
		{
			return false;
		}
		return C4fPOPe9t41DNKMtO8ak(_lineRect, new Size(2.0, 0.0)).Contains(x, y);
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 2;
		int num2 = num;
		VerticalLineObject verticalLineObject = default(VerticalLineObject);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (verticalLineObject != null && !Alert.Equals(verticalLineObject.Alert))
				{
					Alert.Copy(verticalLineObject.Alert, !style);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1841489831 ^ -1841469985));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				base.CopyTemplate(objectBase, style);
				return;
			case 2:
				verticalLineObject = objectBase as VerticalLineObject;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void CheckAlert(List<IndicatorBase> indicators)
	{
		if (!Alert.IsActive)
		{
			return;
		}
		try
		{
			IChartDataProvider dataProvider = base.DataProvider;
			DateTime dateTime = DateTime.FromOADate(base.ControlPoints[0].X);
			IChartCluster cluster = dataProvider.GetCluster(dataProvider.Count - 1);
			if (dateTime != _lastLineTime)
			{
				DateTime value = dateTime;
				DateTime? obj = cluster?.CloseTime;
				if (value > obj)
				{
					_lastAlertIndex = -1;
					_lastLineTime = dateTime;
				}
			}
			if (cluster != null && cluster.CloseTime > dateTime && _lastAlertIndex == -1)
			{
				_lastAlertIndex = dataProvider.Count;
				string message = string.Format(Resources.ChartObjectsVerticalLineObjectAlert, DateTime.FromOADate(base.ControlPoints[0].X).ToString(CultureInfo.CurrentCulture));
				AddAlert(Alert, message);
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public VerticalLineObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static VerticalLineObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool HAZ6aRe9Rk1TGgXyI2PH()
	{
		return FGxBwAe9gJS89OiHCoGk == null;
	}

	internal static VerticalLineObject kTj4Tfe96ZHoi8kcTyGb()
	{
		return FGxBwAe9gJS89OiHCoGk;
	}

	internal static bool FUmF6Ve9MXtiCcZHeDMR(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object tuspwIe9Of8OBvFKPL40(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static XColor Xpd8iXe9q20Rpdf8L0D2(object P_0)
	{
		return ((XBrush)P_0).Color;
	}

	internal static void KHSMqle9IAE2lwjmgXPo(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static object bKCXqLe9WKoTLRpCEq2K(object P_0)
	{
		return ((IChartTheme)P_0).ChartCpFillBrush;
	}

	internal static Rect C4fPOPe9t41DNKMtO8ak(Rect P_0, Size P_1)
	{
		return Rect.Inflate(P_0, P_1);
	}
}
