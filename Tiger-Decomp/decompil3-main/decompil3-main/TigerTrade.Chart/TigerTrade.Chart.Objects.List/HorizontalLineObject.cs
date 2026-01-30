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
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Chart.Properties;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using ukNOheilAMuZk4emlXeV;

namespace TigerTrade.Chart.Objects.List;

[KnownType(typeof(HorizontalRayObject))]
[DataContract(Name = "HorizontalLineObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("HorizontalLine", "ChartObjectsHorizontalLine", 1, Type = typeof(HorizontalLineObject))]
public class HorizontalLineObject : LineObjectBase
{
	private ObjectTextAlignment _priceLabelAlignment;

	private int _priveLabelFontSize;

	private XColor _activeAlertLineColor;

	[DataMember(Name = "InactiveAlertLineColor")]
	[Browsable(false)]
	public XColor InactiveAlertLineColor;

	private ChartAlertSettings _alert;

	private int _alertMinDistance;

	private string _text;

	private ObjectTextAlignment _textAlignment;

	private int _fontSize;

	protected Rect LineRect;

	private double _lastAlertValue;

	private int _lastAlertIndex;

	internal static HorizontalLineObject MQsl5Xe0V1jtykuFF1tJ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsPrice")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsPrice")]
	public decimal Price
	{
		get
		{
			return (decimal)base.ControlPoints[0].Y;
		}
		set
		{
			if (!SVGlIre0Ktfyn3jA7iQX(value, (decimal)base.ControlPoints[0].Y))
			{
				base.ControlPoints[0].Y = (double)value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82847212));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x809C621));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsPriceLabelAlignment")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsPriceLabel")]
	[DataMember(Name = "PriceLabelAlignment")]
	public ObjectTextAlignment PriceLabelAlignment
	{
		get
		{
			return _priceLabelAlignment;
		}
		set
		{
			if (value != _priceLabelAlignment)
			{
				_priceLabelAlignment = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1763895751 ^ -1763873999));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
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

	[DataMember(Name = "PriceLabelFontSize")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsPriceLabel")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsPriceLabelFontSize")]
	public int PriceLabelFontSize
	{
		get
		{
			return _priveLabelFontSize;
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
					value = RYKr1ie0hDcvMdNw40XD(10, fXacuIe0mb8tCO83r3T6(100, value));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (value != _priveLabelFontSize)
					{
						_priveLabelFontSize = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x60620FC1 ^ 0x606272F3));
					}
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush ActiveAlertLineBrush { get; private set; }

	[Browsable(false)]
	public XPen ActiveAlertLinePen { get; private set; }

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsActiveAlertLineColor")]
	[DataMember(Name = "ActiveAlertLineColor")]
	public XColor ActiveAlertLineColor
	{
		get
		{
			return _activeAlertLineColor;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				default:
					ActiveAlertLineBrush = new XBrush(value);
					ActiveAlertLinePen = new XPen(ActiveAlertLineBrush, base.LineWidth, base.LineStyle);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-44540535 ^ -44556077));
					return;
				case 2:
					if (!(value == _activeAlertLineColor))
					{
						_activeAlertLineColor = value;
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsAlert")]
	[DataMember(Name = "Alert")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlert")]
	[Browsable(true)]
	public ChartAlertSettings Alert
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_alert = new ChartAlertSettings();
					KQyjqFe0wfD3n53iDEiZ(_alert, new PropertyChangedEventHandler(AlertOnPropertyChanged));
					goto IL_0040;
				case 1:
					{
						if (_alert == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0040;
					}
					IL_0040:
					return _alert;
				}
			}
		}
		set
		{
			if (object.Equals(value, _alert))
			{
				return;
			}
			int num;
			if (_alert != null)
			{
				d9vomOe071gt8iLyKinV(_alert, new PropertyChangedEventHandler(AlertOnPropertyChanged));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_0071;
			IL_0071:
			_alert = value;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
			{
				num = 0;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 1:
					if (_alert != null)
					{
						_alert.PropertyChanged += AlertOnPropertyChanged;
						num = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
						{
							num = 0;
						}
						continue;
					}
					goto case 2;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28C965BE ^ 0x28C91838));
					return;
				}
				break;
			}
			goto IL_0071;
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsAlert")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsSignalMinDistance")]
	[DataMember(Name = "AlertMinDistance")]
	public int AlertMinDistance
	{
		get
		{
			return _alertMinDistance;
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
					if (value != _alertMinDistance)
					{
						_alertMinDistance = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x684F243E ^ 0x684F59AA));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsText")]
	[DataMember(Name = "Text")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	public string Text
	{
		get
		{
			return _text;
		}
		set
		{
			if (!(value == _text))
			{
				_text = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)j08ANBe083Rwd3eGiAm7(-342738082 ^ -342735130));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlignment")]
	[DataMember(Name = "TextAlignment")]
	public ObjectTextAlignment TextAlignment
	{
		get
		{
			return _textAlignment;
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
					if (value != _textAlignment)
					{
						_textAlignment = value;
						OnPropertyChanged((string)j08ANBe083Rwd3eGiAm7(-1309555870 ^ -1309556988));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "FontSize")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsSize")]
	public int FontSize
	{
		get
		{
			return _fontSize;
		}
		set
		{
			value = Math.Max(10, Math.Min(100, value));
			if (value != _fontSize)
			{
				_fontSize = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)j08ANBe083Rwd3eGiAm7(0xAD5B8B3 ^ 0xAD5C577));
			}
		}
	}

	private void AlertOnPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-894902996 ^ -894918486));
	}

	public HorizontalLineObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		AlertMinDistance = 0;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				TextAlignment = ObjectTextAlignment.RightTop;
				PriceLabelAlignment = ObjectTextAlignment.Hide;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
				{
					num = 2;
				}
				break;
			case 3:
				return;
			default:
				Text = "";
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				PriceLabelFontSize = 14;
				ActiveAlertLineColor = l9dQeCe0AvaKkBQ6pEuE();
				FontSize = 14;
				num = 3;
				break;
			}
		}
	}

	protected override void UpdateLinePens(int lineWidth, XDashStyle lineStyle)
	{
		base.UpdateLinePens(lineWidth, lineStyle);
		ActiveAlertLinePen = new XPen(ActiveAlertLineBrush, lineWidth, lineStyle);
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		ActiveAlertLineColor = theme.ChartObjectLineColor;
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		if (base.Canvas == null)
		{
			return;
		}
		Point point = ToPoint(base.ControlPoints[0]);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 == 0)
		{
			num = 0;
		}
		Point point3 = default(Point);
		Point point2 = default(Point);
		XColor color = default(XColor);
		double step = default(double);
		long num3 = default(long);
		double y = default(double);
		double y2 = default(double);
		while (true)
		{
			int num2;
			XPen xPen;
			switch (num)
			{
			case 9:
				return;
			case 1:
				point3 = new Point(base.Canvas.Rect.Right, point.Y);
				LineRect = new Rect(point2, point3);
				if (!base.Settings.TransformHorLines)
				{
					goto IL_0044;
				}
				goto case 2;
			case 6:
				color = (Alert.IsActive ? ActiveAlertLineColor : base.LineColor);
				num = 3;
				continue;
			case 2:
				if (base.Canvas.IsStock && base.Canvas.StockType == ChartStockType.Clusters)
				{
					double y3 = base.ControlPoints[0].Y;
					step = base.DataProvider.Step;
					num3 = (long)Math.Round(y3 / step);
					num2 = 8;
					goto IL_0005;
				}
				goto IL_0044;
			case 8:
				y = GetY(((double)num3 + 0.5) * step);
				y2 = GetY(((double)num3 - 0.5) * step);
				if (y2 - y > (double)(base.LineWidth + 2))
				{
					num = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
					{
						num = 3;
					}
					continue;
				}
				goto IL_0044;
			case 3:
				labels.Add(new ObjectLabelInfo((double)num3 * step, y, y2, color));
				num = 9;
				continue;
			case 10:
				return;
			default:
				point2 = new Point(base.Canvas.Rect.Left, point.Y);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
				{
					num = 1;
				}
				continue;
			case 4:
				xPen = base.LinePen;
				break;
			case 11:
				DrawTextAndPriceLabel(visual);
				num = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
				{
					num = 2;
				}
				continue;
			case 5:
				return;
			case 7:
				{
					XBrush brush = new XBrush(base.LineColor, (base.LineColor.Alpha > 127) ? 127 : base.LineColor.Alpha);
					LineRect = new Rect(new Point(point2.X, y), new Point(point3.X, y2));
					visual.FillRectangle(brush, LineRect);
					num2 = 11;
					goto IL_0005;
				}
				IL_0005:
				num = num2;
				continue;
				IL_0044:
				if (!Alert.IsActive)
				{
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
					{
						num = 4;
					}
					continue;
				}
				xPen = ActiveAlertLinePen;
				break;
			}
			XPen xPen2 = xPen;
			JHOGNBe0PSXLfurst69Z(visual, xPen2, point2, point3);
			DrawTextAndPriceLabel(visual);
			labels.Add(new ObjectLabelInfo(base.ControlPoints[0].Y, Alert.IsActive ? ActiveAlertLineColor : base.LineColor));
			num = 4;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
			{
				num = 10;
			}
		}
	}

	protected void DrawTextAndPriceLabel(DxVisualQueue visual)
	{
		Rect rect = Sn3cTXe0JMuqEAULhHKE();
		XFont xFont = null;
		if (string.IsNullOrEmpty(Text) || TextAlignment == ObjectTextAlignment.Hide)
		{
			goto IL_00cd;
		}
		xFont = new XFont(base.Canvas.ChartFont.Name, FontSize);
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
		{
			num = 18;
		}
		goto IL_0009;
		IL_0009:
		XBrush xBrush = default(XBrush);
		Rect rect2 = default(Rect);
		Size size = default(Size);
		XFont xFont2 = default(XFont);
		Size size2 = default(Size);
		string text = default(string);
		Point point2 = default(Point);
		Point point = default(Point);
		while (true)
		{
			switch (num)
			{
			case 13:
				xBrush = (WCMJ0le0psdlMqqN8sMD(Alert) ? ActiveAlertLineBrush : base.LineBrush);
				num = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 != 0)
				{
					num = 17;
				}
				continue;
			case 7:
				if (TextAlignment == ObjectTextAlignment.RightTop)
				{
					goto IL_00d9;
				}
				rect2.Y = rect.Bottom + 5.0;
				goto case 3;
			case 18:
				size = xFont.GetSize(Text);
				num = 9;
				continue;
			case 10:
				break;
			case 14:
				xFont2 = new XFont(((XFont)AigFBPe033pTpUMW7FsM(base.Canvas)).Name, PriceLabelFontSize);
				size2 = xFont2.GetSize(text);
				point2 = CalcTextPosition(PriceLabelAlignment, size2);
				num = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
				{
					num = 5;
				}
				continue;
			case 3:
			case 15:
				if (!rect.IsEmpty)
				{
					num = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
					{
						num = 11;
					}
					continue;
				}
				goto IL_0115;
			case 5:
				if (rect.IntersectsWith(rect2))
				{
					num = 16;
					continue;
				}
				goto case 3;
			case 2:
				PZ0JGce0uStHuQJLZRgl(visual, text, xFont2, xBrush, rect2, XTextAlignment.Left);
				return;
			case 16:
				if (TextAlignment.usHilPAaaIC(PriceLabelAlignment))
				{
					if (PriceLabelAlignment != ObjectTextAlignment.LeftTop)
					{
						num = 4;
						continue;
					}
					goto IL_01ae;
				}
				if (TextAlignment != ObjectTextAlignment.LeftTop)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
					{
						num = 0;
					}
					continue;
				}
				goto IL_00d9;
			default:
				if (TextAlignment != ObjectTextAlignment.CenterTop)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
					{
						num = 7;
					}
					continue;
				}
				goto IL_00d9;
			case 6:
				text = null;
				if (base.ControlPoints[0].Y != 0.0 && PriceLabelAlignment != ObjectTextAlignment.Hide)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 13;
			case 4:
				if (PriceLabelAlignment != ObjectTextAlignment.CenterTop && PriceLabelAlignment != ObjectTextAlignment.RightTop)
				{
					rect.Y = rect2.Bottom + 5.0;
					num = 15;
					continue;
				}
				goto IL_01ae;
			case 1:
				text = ((IChartSymbol)Lm9KWDe0FrShocvj9Nxv(base.DataProvider)).FormatPrice((decimal)base.ControlPoints[0].Y, shortDecimals: false);
				num = 14;
				continue;
			case 17:
				if (rect.IsEmpty)
				{
					goto case 3;
				}
				if (rect2.IsEmpty)
				{
					num = 3;
					continue;
				}
				goto case 5;
			case 11:
				PZ0JGce0uStHuQJLZRgl(visual, Text, xFont, xBrush, rect, XTextAlignment.Left);
				goto IL_0115;
			case 12:
				rect = new Rect(point.X, point.Y, size.Width, size.Height);
				num = 10;
				continue;
			case 8:
				rect2 = new Rect(point2.X, point2.Y, size2.Width, size2.Height);
				num = 13;
				continue;
			case 9:
				{
					point = CalcTextPosition(TextAlignment, size);
					num = 12;
					continue;
				}
				IL_01ae:
				rect2.Y = rect.Y - rect2.Height - 5.0;
				goto case 3;
				IL_00d9:
				rect.Y = rect2.Y - rect.Height - 5.0;
				goto case 3;
				IL_0115:
				if (rect2.IsEmpty)
				{
					return;
				}
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num = 2;
				}
				continue;
			}
			break;
		}
		goto IL_00cd;
		IL_00cd:
		rect2 = Rect.Empty;
		xFont2 = null;
		num = 6;
		goto IL_0009;
	}

	private Point CalcTextPosition(ObjectTextAlignment alignment, Size textSize)
	{
		int num = 3;
		double y = default(double);
		double num3 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					y = 0.0;
					switch (alignment)
					{
					case ObjectTextAlignment.LeftTop:
					case ObjectTextAlignment.CenterTop:
					case ObjectTextAlignment.RightTop:
						break;
					case ObjectTextAlignment.LeftMiddle:
					case ObjectTextAlignment.CenterMiddle:
					case ObjectTextAlignment.RightMiddle:
						goto end_IL_0012;
					case ObjectTextAlignment.LeftBottom:
					case ObjectTextAlignment.CenterBottom:
					case ObjectTextAlignment.RightBottom:
						y = LineRect.Bottom + 4.0;
						goto IL_0220;
					default:
						goto IL_0220;
					}
					goto case 1;
				case 1:
					y = LineRect.Top - 4.0 - textSize.Height;
					goto IL_0220;
				default:
					goto end_IL_0012;
				case 3:
					num3 = 0.0;
					num2 = 2;
					continue;
				case 7:
					goto IL_015c;
				case 8:
					num3 = Math.Max(num3, LineRect.Left);
					goto IL_00ff;
				case 4:
					num3 = SsDiaFe0zOkMbw9Ob6h3(num3, LineRect.Left);
					goto IL_00ff;
				case 6:
					break;
				case 5:
					goto IL_0220;
					IL_0220:
					switch (alignment)
					{
					case ObjectTextAlignment.CenterTop:
					case ObjectTextAlignment.CenterMiddle:
					case ObjectTextAlignment.CenterBottom:
						goto IL_015c;
					case ObjectTextAlignment.LeftTop:
					case ObjectTextAlignment.LeftMiddle:
					case ObjectTextAlignment.LeftBottom:
						num3 = LineRect.X;
						break;
					case ObjectTextAlignment.RightTop:
					case ObjectTextAlignment.RightMiddle:
					case ObjectTextAlignment.RightBottom:
						goto end_IL_0012_2;
					}
					goto IL_00ff;
					IL_015c:
					num3 = LineRect.Right - (LineRect.Width + textSize.Width) / 2.0;
					num2 = 4;
					continue;
					IL_00ff:
					return new Point(num3, y);
					end_IL_0012_2:
					break;
				}
				num3 = LineRect.Right - textSize.Width;
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
				{
					num2 = 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			y = (LineRect.Top + LineRect.Bottom - textSize.Height) / 2.0;
			num = 5;
		}
	}

	public override void DrawControlPoints(DxVisualQueue visual)
	{
		if (LineRect == Rect.Empty)
		{
			return;
		}
		int num = base.LineWidth / 2 + 4;
		Point point = new Point((LineRect.Left + LineRect.Right) / 2.0, (LineRect.Top + LineRect.Bottom) / 2.0);
		Rect rect = new Rect(point, point);
		rect.Inflate(new Size(num, num));
		int num2 = 2;
		while (true)
		{
			switch (num2)
			{
			default:
				visual.DrawRectangle(base.Theme.ChartCpLinePen, rect);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				visual.FillRectangle((XBrush)QsXBlje201YN8fnkrxoN(base.Theme), rect);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	protected override bool InObject(int x, int y)
	{
		if (LineRect == Rect.Empty)
		{
			return false;
		}
		return Rect.Inflate(LineRect, new Size(0.0, 2.0)).Contains(x, y);
	}

	protected override bool IsObjectOnChart()
	{
		return true;
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 5;
		int num2 = num;
		HorizontalLineObject horizontalLineObject = default(HorizontalLineObject);
		while (true)
		{
			switch (num2)
			{
			default:
				Alert.Copy(horizontalLineObject.Alert, !style);
				num2 = 3;
				break;
			case 1:
				FontSize = horizontalLineObject.FontSize;
				PriceLabelAlignment = BJg9NGe29qlNuQvaH2Fm(horizontalLineObject);
				PriceLabelFontSize = horizontalLineObject.PriceLabelFontSize;
				num2 = 2;
				break;
			case 2:
				base.CopyTemplate(objectBase, style);
				return;
			case 4:
				if (horizontalLineObject == null)
				{
					goto case 2;
				}
				if (!Alert.Equals((ChartAlertSettings)K8ngSue22bW8Qktk26hD(horizontalLineObject)))
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0156;
			case 5:
				horizontalLineObject = objectBase as HorizontalLineObject;
				num2 = 4;
				break;
			case 3:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-203064540 ^ -203094366));
				goto IL_0156;
			case 6:
				{
					Text = horizontalLineObject.Text;
					TextAlignment = horizontalLineObject.TextAlignment;
					ActiveAlertLineColor = sg8EEGe2foa9QU8BPQld(horizontalLineObject);
					InactiveAlertLineColor = horizontalLineObject.InactiveAlertLineColor;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_0156:
				AlertMinDistance = mI9gYRe2Hyu3BxlB9Gcf(horizontalLineObject);
				num2 = 6;
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
			foreach (IndicatorBase indicator in indicators)
			{
				if (indicator.CheckAlert(base.ControlPoints[0].Y, AlertMinDistance, ref _lastAlertIndex, ref _lastAlertValue))
				{
					string message = string.Format(Resources.ChartObjectsHorizontalLineObjectAlert, indicator.Name, base.DataProvider.Symbol.FormatPrice((decimal)base.ControlPoints[0].Y));
					AddAlert(Alert, message);
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	[OnDeserializing]
	private new void SetValuesOnDeserializing(StreamingContext context)
	{
		base.SetValuesOnDeserializing(context);
		InactiveAlertLineColor = XColor.IncorrectValue;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ActiveAlertLineColor = XColor.IncorrectValue;
	}

	[OnDeserialized]
	private void SetValuesOnDeserialized(StreamingContext context)
	{
		if (ActiveAlertLineColor == zuXCe6e2np7K3utGT0ee())
		{
			goto IL_0083;
		}
		goto IL_00a6;
		IL_00a6:
		if (!(InactiveAlertLineColor == XColor.IncorrectValue))
		{
			switch (2)
			{
			case 1:
				break;
			default:
				goto IL_0083;
			case 2:
				return;
			}
		}
		InactiveAlertLineColor = base.LineColor;
		return;
		IL_0083:
		ActiveAlertLineColor = base.LineColor;
		if (InactiveAlertLineColor != zuXCe6e2np7K3utGT0ee())
		{
			base.LineColor = InactiveAlertLineColor;
		}
		goto IL_00a6;
	}

	static HorizontalLineObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool gJ2M3Ye0CxFJdDRJWMOt()
	{
		return MQsl5Xe0V1jtykuFF1tJ == null;
	}

	internal static HorizontalLineObject QGK9mve0reqjMlfObmxc()
	{
		return MQsl5Xe0V1jtykuFF1tJ;
	}

	internal static bool SVGlIre0Ktfyn3jA7iQX(decimal P_0, decimal P_1)
	{
		return P_0 == P_1;
	}

	internal static int fXacuIe0mb8tCO83r3T6(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int RYKr1ie0hDcvMdNw40XD(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void KQyjqFe0wfD3n53iDEiZ(object P_0, object P_1)
	{
		((ChartAlertSettings)P_0).PropertyChanged += (PropertyChangedEventHandler)P_1;
	}

	internal static void d9vomOe071gt8iLyKinV(object P_0, object P_1)
	{
		((ChartAlertSettings)P_0).PropertyChanged -= (PropertyChangedEventHandler)P_1;
	}

	internal static object j08ANBe083Rwd3eGiAm7(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color l9dQeCe0AvaKkBQ6pEuE()
	{
		return Colors.Black;
	}

	internal static void JHOGNBe0PSXLfurst69Z(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static Rect Sn3cTXe0JMuqEAULhHKE()
	{
		return Rect.Empty;
	}

	internal static object Lm9KWDe0FrShocvj9Nxv(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static object AigFBPe033pTpUMW7FsM(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static bool WCMJ0le0psdlMqqN8sMD(object P_0)
	{
		return ((ChartAlertSettings)P_0).IsActive;
	}

	internal static void PZ0JGce0uStHuQJLZRgl(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static double SsDiaFe0zOkMbw9Ob6h3(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object QsXBlje201YN8fnkrxoN(object P_0)
	{
		return ((IChartTheme)P_0).ChartCpFillBrush;
	}

	internal static object K8ngSue22bW8Qktk26hD(object P_0)
	{
		return ((HorizontalLineObject)P_0).Alert;
	}

	internal static int mI9gYRe2Hyu3BxlB9Gcf(object P_0)
	{
		return ((HorizontalLineObject)P_0).AlertMinDistance;
	}

	internal static XColor sg8EEGe2foa9QU8BPQld(object P_0)
	{
		return ((HorizontalLineObject)P_0).ActiveAlertLineColor;
	}

	internal static ObjectTextAlignment BJg9NGe29qlNuQvaH2Fm(object P_0)
	{
		return ((HorizontalLineObject)P_0).PriceLabelAlignment;
	}

	internal static XColor zuXCe6e2np7K3utGT0ee()
	{
		return XColor.IncorrectValue;
	}
}
