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

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "PriceRangeObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("PriceRange", "ChartObjectsPriceRange", 2, Type = typeof(PriceRangeObject))]
public sealed class PriceRangeObject : PolygonObjectBase
{
	private class LhWOQpiCyi5GhXHKZHUm
	{
		public Point wU3iCZikUZF;

		public Point QGCiCV5RE5D;

		public Point Center;

		public Rect nNriCCByPVb;

		public Rect lK1iCrjfEGp;

		public double TNhiCKUeNr4;

		public double P0eiCmV8UPu;

		private static LhWOQpiCyi5GhXHKZHUm bEyDTRetsMWNonFwok2e;

		public LhWOQpiCyi5GhXHKZHUm()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		static LhWOQpiCyi5GhXHKZHUm()
		{
			v1aJYfetjolNVeyw3sY9();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool lMU2aEetX6LO2FpHAcTB()
		{
			return bEyDTRetsMWNonFwok2e == null;
		}

		internal static LhWOQpiCyi5GhXHKZHUm SomBymetc1W2IRF6JGE6()
		{
			return bEyDTRetsMWNonFwok2e;
		}

		internal static void v1aJYfetjolNVeyw3sY9()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}
	}

	private ChartAlertSettings _alert;

	private string _text;

	private ObjectTextAlignment _textAlignment;

	private int _fontSize;

	private LhWOQpiCyi5GhXHKZHUm _rangeInfo;

	private double _lastAlertValue;

	private int _lastAlertIndex;

	private static PriceRangeObject kLq4slefe6rxpjJnxxND;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsPrice1")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsPrice")]
	public decimal Price1
	{
		get
		{
			return uTLwtbefcIftUnFw7I9k(base.ControlPoints[0].Y);
		}
		set
		{
			if (!(value == (decimal)base.ControlPoints[0].Y))
			{
				base.ControlPoints[0].Y = (double)value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769CFBD3));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsPrice")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsPrice2")]
	public decimal Price2
	{
		get
		{
			return (decimal)base.ControlPoints[1].Y;
		}
		set
		{
			if (!(value == (decimal)base.ControlPoints[1].Y))
			{
				base.ControlPoints[1].Y = SH66UmefjNisso08W1dI(value);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1774602229 ^ -1774634247));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlert")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsAlert")]
	[DataMember(Name = "Alert")]
	[Browsable(true)]
	public ChartAlertSettings Alert
	{
		get
		{
			return _alert ?? (_alert = new ChartAlertSettings());
		}
		set
		{
			if (!FgIDtXefETAoJb6mPaSQ(value, _alert))
			{
				_alert = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)jd2W6hefQiN2E7sM9BQi(-198991962 ^ -198974944));
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
			if (!viZoeeefdBRawmSJLjoX(value, _text))
			{
				_text = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)jd2W6hefQiN2E7sM9BQi(-1999650146 ^ -1999651034));
			}
		}
	}

	[DataMember(Name = "TextAlignment")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsAlignment")]
	public ObjectTextAlignment TextAlignment
	{
		get
		{
			return _textAlignment;
		}
		set
		{
			if (value != _textAlignment)
			{
				_textAlignment = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB47515));
			}
		}
	}

	[DataMember(Name = "FontSize")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsSize")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309557082));
			}
		}
	}

	public PriceRangeObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				FontSize = 14;
				return;
			}
			Text = "";
			TextAlignment = ObjectTextAlignment.RightTop;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
			{
				num = 1;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		_rangeInfo = new LhWOQpiCyi5GhXHKZHUm();
		Point point = pCQagbefRkilEO9P8Gd2(base.Canvas, gHrHalefgs1MaDjcWC5Y(base.Canvas).Left + base.Canvas.Rect.Width / 2.0, 0.0);
		int num = 17;
		Point wU3iCZikUZF = default(Point);
		Point qGCiCV5RE5D = default(Point);
		Point point2 = default(Point);
		double num2 = default(double);
		Point point3 = default(Point);
		Point point4 = default(Point);
		Point p = default(Point);
		double y = default(double);
		while (true)
		{
			double num3;
			switch (num)
			{
			case 18:
				wU3iCZikUZF = _rangeInfo.wU3iCZikUZF;
				qGCiCV5RE5D = _rangeInfo.QGCiCV5RE5D;
				num = 4;
				continue;
			default:
				point2 = new Point(base.Canvas.Rect.Right, qGCiCV5RE5D.Y + num2);
				if (base.DrawBorder)
				{
					OOICqUefO4tvXiai5DL4(visual, base.LinePen, point3, point4);
					num = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
					{
						num = 3;
					}
					continue;
				}
				goto IL_012b;
			case 3:
				num3 = 0.0;
				break;
			case 15:
				_rangeInfo.P0eiCmV8UPu = base.ControlPoints[1].Y;
				if (_rangeInfo.TNhiCKUeNr4 > _rangeInfo.P0eiCmV8UPu)
				{
					num = 8;
					continue;
				}
				goto case 11;
			case 9:
				visual.DrawLine(base.LinePen, p, point2);
				goto IL_012b;
			case 11:
				point3 = new Point(gHrHalefgs1MaDjcWC5Y(base.Canvas).Left, wU3iCZikUZF.Y - num2);
				point4 = new Point(gHrHalefgs1MaDjcWC5Y(base.Canvas).Right, wU3iCZikUZF.Y - num2);
				num = 2;
				continue;
			case 10:
				visual.FillRectangle(base.BackBrush, _rangeInfo.nNriCCByPVb);
				goto case 6;
			case 1:
				labels.Add(new ObjectLabelInfo(base.ControlPoints[0].Y, base.LineColor));
				labels.Add(new ObjectLabelInfo(base.ControlPoints[1].Y, base.LineColor));
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num = 14;
				}
				continue;
			case 7:
				if (hjPBFLefMqcIohxFqHa5(base.Canvas) != ChartStockType.Clusters)
				{
					num = 3;
					continue;
				}
				num3 = base.Canvas.StepHeight / 2.0;
				break;
			case 4:
				if (wU3iCZikUZF.Y > qGCiCV5RE5D.Y)
				{
					num = 13;
					continue;
				}
				goto case 12;
			case 13:
				y = wU3iCZikUZF.Y;
				wU3iCZikUZF.Y = qGCiCV5RE5D.Y;
				num = 16;
				continue;
			case 16:
				qGCiCV5RE5D.Y = y;
				_rangeInfo.wU3iCZikUZF.Y += num2;
				_rangeInfo.QGCiCV5RE5D.Y -= num2;
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a != 0)
				{
					num = 3;
				}
				continue;
			case 6:
				DrawText(visual);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
				{
					num = 1;
				}
				continue;
			case 5:
				_rangeInfo.TNhiCKUeNr4 = base.ControlPoints[0].Y;
				num = 15;
				continue;
			case 14:
				return;
			case 2:
				p = new Point(base.Canvas.Rect.Left, qGCiCV5RE5D.Y + num2);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
				{
					num = 0;
				}
				continue;
			case 8:
			{
				double tNhiCKUeNr = _rangeInfo.TNhiCKUeNr4;
				_rangeInfo.TNhiCKUeNr4 = _rangeInfo.P0eiCmV8UPu;
				_rangeInfo.P0eiCmV8UPu = tNhiCKUeNr;
				num = 11;
				continue;
			}
			case 17:
				base.ControlPoints[0].X = point.X;
				base.ControlPoints[1].X = point.X;
				if (base.Settings.TransformHorLines && LvJi6gef6ibyt0DfZ33o(base.Canvas))
				{
					num = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
					{
						num = 5;
					}
					continue;
				}
				goto case 3;
			case 12:
				{
					_rangeInfo.wU3iCZikUZF.Y -= num2;
					_rangeInfo.QGCiCV5RE5D.Y += num2;
					goto case 5;
				}
				IL_012b:
				_rangeInfo.Center = new Point(wU3iCZikUZF.X, (point3.Y + p.Y) / 2.0);
				_rangeInfo.nNriCCByPVb = new Rect(point3, point2);
				_rangeInfo.lK1iCrjfEGp = new Rect(new Point(_rangeInfo.Center.X - 10.0, _rangeInfo.Center.Y - 10.0), new Point(_rangeInfo.Center.X + 10.0, _rangeInfo.Center.Y + 10.0));
				if (!base.DrawBack)
				{
					int num4 = 6;
					num = num4;
					continue;
				}
				goto case 10;
			}
			num2 = num3;
			_rangeInfo.wU3iCZikUZF = ToPoint(base.ControlPoints[0]);
			_rangeInfo.QGCiCV5RE5D = ToPoint(base.ControlPoints[1]);
			num = 18;
		}
	}

	private void DrawText(DxVisualQueue visual)
	{
		if (string.IsNullOrEmpty(Text) || TextAlignment == ObjectTextAlignment.Hide)
		{
			return;
		}
		XFont xFont = new XFont(base.Canvas.ChartFont.Name, FontSize);
		Size size = xFont.GetSize(Text);
		int num = 10;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
		{
			num = 11;
		}
		double x = default(double);
		Rect rect2 = default(Rect);
		double width = default(double);
		double y = default(double);
		Rect rect = default(Rect);
		while (true)
		{
			switch (num)
			{
			case 11:
				x = 0.0;
				num = 10;
				continue;
			case 8:
				rect2 = base.Canvas.Rect;
				x = (rect2.Right - width) / 2.0;
				break;
			case 6:
				x = rect2.Right - width;
				num = 5;
				continue;
			case 1:
				return;
			default:
				switch (TextAlignment)
				{
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.CenterBottom:
					break;
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.LeftBottom:
					goto IL_01c7;
				case ObjectTextAlignment.RightTop:
				case ObjectTextAlignment.RightMiddle:
				case ObjectTextAlignment.RightBottom:
					goto IL_0248;
				default:
					goto end_IL_0009;
				}
				goto case 8;
			case 2:
				goto IL_010b;
			case 3:
				goto IL_01c7;
			case 10:
				y = 0.0;
				width = size.Width;
				switch (TextAlignment)
				{
				case ObjectTextAlignment.LeftMiddle:
				case ObjectTextAlignment.CenterMiddle:
				case ObjectTextAlignment.RightMiddle:
					goto IL_010b;
				case ObjectTextAlignment.LeftTop:
				case ObjectTextAlignment.CenterTop:
				case ObjectTextAlignment.RightTop:
					goto IL_0271;
				case ObjectTextAlignment.LeftBottom:
				case ObjectTextAlignment.CenterBottom:
				case ObjectTextAlignment.RightBottom:
					y = _rangeInfo.nNriCCByPVb.Bottom + 4.0 + Math.Ceiling((double)base.LineWidth / 2.0);
					break;
				}
				goto default;
			case 4:
				Xt9f8OefICPSDe1QLOJE(visual, Text, xFont, base.LineBrush, rect, XTextAlignment.Left);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num = 1;
				}
				continue;
			case 9:
				goto IL_0271;
			case 5:
				break;
				IL_0271:
				y = _rangeInfo.nNriCCByPVb.Top - 4.0 - d9e0Vtefqr1h8kgxQVZJ((double)base.LineWidth / 2.0) - size.Height;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num = 0;
				}
				continue;
				IL_010b:
				y = (_rangeInfo.nNriCCByPVb.Top + _rangeInfo.nNriCCByPVb.Bottom) / 2.0 - Math.Ceiling((double)base.LineWidth / 2.0) - size.Height / 2.0;
				num = 7;
				continue;
				IL_0248:
				rect2 = gHrHalefgs1MaDjcWC5Y(base.Canvas);
				num = 6;
				continue;
				IL_01c7:
				x = 0.0;
				break;
				end_IL_0009:
				break;
			}
			rect = new Rect(x, y, width, size.Height);
			num = 4;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
			{
				num = 0;
			}
		}
	}

	public override void DrawControlPoints(DxVisualQueue visual)
	{
		if (_rangeInfo == null)
		{
			return;
		}
		DrawControlPoint(visual, _rangeInfo.wU3iCZikUZF);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				DrawControlPoint(visual, _rangeInfo.QGCiCV5RE5D);
				return;
			}
			DrawControlPoint(visual, _rangeInfo.Center);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
			{
				num = 1;
			}
		}
	}

	public override int GetControlPoint(int x, int y)
	{
		int num = 2;
		Point[] array = default(Point[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (_rangeInfo != null)
					{
						goto end_IL_0012;
					}
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
				{
					for (int i = 0; i < array.Length; i++)
					{
						double num3 = array[i].Y - (double)y;
						if (num3 * num3 < 9.0 + (double)IDMCXOefWCheiodJGFdc(this) / 2.0)
						{
							return i;
						}
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					return -1;
				case 1:
					return -1;
				}
				continue;
				end_IL_0012:
				break;
			}
			array = new Point[2] { _rangeInfo.wU3iCZikUZF, _rangeInfo.QGCiCV5RE5D };
			num = 3;
		}
	}

	protected override bool InObject(int x, int y)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (_rangeInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (HES6Z5eft0MtkjgO5qIq(this, x, y) != -1)
				{
					return true;
				}
				if (_rangeInfo.lK1iCrjfEGp != Rect.Empty)
				{
					return _rangeInfo.lK1iCrjfEGp.Contains(x, y);
				}
				return false;
			default:
				return false;
			}
		}
	}

	protected override bool IsObjectOnChart()
	{
		return true;
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 1;
		int num2 = num;
		PriceRangeObject priceRangeObject = default(PriceRangeObject);
		while (true)
		{
			switch (num2)
			{
			default:
				if (priceRangeObject != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				priceRangeObject = objectBase as PriceRangeObject;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				FontSize = priceRangeObject.FontSize;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				base.CopyTemplate(objectBase, style);
				return;
			case 2:
				if (!Alert.Equals(priceRangeObject.Alert))
				{
					Alert.Copy((ChartAlertSettings)rxF9u5efUMblxJGLG7ek(priceRangeObject), !style);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6D18F862 ^ 0x6D1885E4));
				}
				Text = (string)jNVvSrefTPH4s6IuOvhf(priceRangeObject);
				TextAlignment = priceRangeObject.TextAlignment;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
				{
					num2 = 3;
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
			double num = base.ControlPoints[0].Y;
			double num2 = base.ControlPoints[1].Y;
			if (num > num2)
			{
				double num3 = num;
				num = num2;
				num2 = num3;
			}
			IChartDataProvider dataProvider = base.DataProvider;
			double value = (num + num2) / 2.0;
			int distance = (int)Math.Floor(Math.Abs(num - num2) / dataProvider.Step / 2.0);
			foreach (IndicatorBase indicator in indicators)
			{
				if (indicator.CheckAlert(value, distance, ref _lastAlertIndex, ref _lastAlertValue))
				{
					string message = string.Format(Resources.ChartObjectsPriceRangeObjectAlert, indicator.Name, dataProvider.Symbol.FormatPrice((decimal)num), dataProvider.Symbol.FormatPrice((decimal)num2));
					AddAlert(Alert, message);
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	static PriceRangeObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static decimal uTLwtbefcIftUnFw7I9k(double P_0)
	{
		return (decimal)P_0;
	}

	internal static bool LTPmipefsMZfd8WRSCQg()
	{
		return kLq4slefe6rxpjJnxxND == null;
	}

	internal static PriceRangeObject lKBIP3efXfFjYpqHqQ0k()
	{
		return kLq4slefe6rxpjJnxxND;
	}

	internal static double SH66UmefjNisso08W1dI(decimal P_0)
	{
		return (double)P_0;
	}

	internal static bool FgIDtXefETAoJb6mPaSQ(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static object jd2W6hefQiN2E7sM9BQi(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool viZoeeefdBRawmSJLjoX(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Rect gHrHalefgs1MaDjcWC5Y(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static Point pCQagbefRkilEO9P8Gd2(object P_0, double x, double y)
	{
		return ((IChartCanvas)P_0).GetValueFromPos(x, y);
	}

	internal static bool LvJi6gef6ibyt0DfZ33o(object P_0)
	{
		return ((IChartCanvas)P_0).IsStock;
	}

	internal static ChartStockType hjPBFLefMqcIohxFqHa5(object P_0)
	{
		return ((IChartCanvas)P_0).StockType;
	}

	internal static void OOICqUefO4tvXiai5DL4(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static double d9e0Vtefqr1h8kgxQVZJ(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static void Xt9f8OefICPSDe1QLOJE(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static int IDMCXOefWCheiodJGFdc(object P_0)
	{
		return ((ObjectBase)P_0).PenWidth;
	}

	internal static int HES6Z5eft0MtkjgO5qIq(object P_0, int x, int y)
	{
		return ((ObjectBase)P_0).GetControlPoint(x, y);
	}

	internal static object rxF9u5efUMblxJGLG7ek(object P_0)
	{
		return ((PriceRangeObject)P_0).Alert;
	}

	internal static object jNVvSrefTPH4s6IuOvhf(object P_0)
	{
		return ((PriceRangeObject)P_0).Text;
	}
}
