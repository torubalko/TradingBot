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
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Properties;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Objects.List;

[DataContract(Name = "LabelObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
[ChartObject("Label", "ChartObjectsText", 1, Type = typeof(LabelObject))]
public sealed class LabelObject : PolygonObjectBase
{
	private string _labelText;

	private XColor _labelColor;

	private int _fontSize;

	private Rect _objectRect;

	internal static LabelObject WnUgPCeHqpRSncEBBe0x;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "LabelText")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsText")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	public string LabelText
	{
		get
		{
			return _labelText;
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
				case 1:
					if (value == _labelText)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
						{
							num2 = 0;
						}
						break;
					}
					_labelText = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24B0B9E6 ^ 0x24B03806));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	private XBrush LabelBrush { get; set; }

	[DataMember(Name = "LabelColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsText")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor")]
	public XColor LabelColor
	{
		get
		{
			return _labelColor;
		}
		set
		{
			if (!(value == _labelColor))
			{
				_labelColor = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68C7EAE6 ^ 0x68C76B10));
				LabelBrush = new XBrush(value);
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
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (value != _fontSize)
					{
						_fontSize = value;
						OnPropertyChanged((string)ITd0sieHUW5Z4bt8FXc0(0x11D1040B ^ 0x11D179CF));
					}
					return;
				case 1:
					value = XrfEq2eHtba2fQto0eil(10, Math.Min(100, value));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LabelObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		_objectRect = Rect.Empty;
		base._002Ector();
		base.DrawBack = false;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				LabelColor = ynN6MqeHTPBpWKpYSDSP();
				FontSize = 24;
				return;
			default:
				LabelText = Resources.ChartObjectsText;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				base.DrawBorder = false;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		Point point = ToPoint(base.ControlPoints[0]);
		if (point == default(Point))
		{
			return;
		}
		XFont xFont = new XFont(((XFont)w1Bx4reHyrsEQj2ofR83(base.Canvas)).Name, FontSize);
		Size size = G84OrYeHZLXRjfABXReR(xFont, LabelText);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				_objectRect = new Rect(point.X, point.Y, size.Width + 8.0 + (double)PenWidth, size.Height + 8.0 + (double)w1NVYaeHVyHkq1mxcs7Z(this));
				if (base.DrawBack)
				{
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
					{
						num = 0;
					}
					break;
				}
				goto default;
			default:
				if (base.DrawBorder)
				{
					visual.DrawRectangle(base.LinePen, _objectRect);
				}
				visual.DrawString(LabelText, xFont, LabelBrush, _objectRect, XTextAlignment.Center);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 3:
				tMYHwIeHCcWPrnpvchU3(visual, base.BackBrush, _objectRect);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override bool InObject(int x, int y)
	{
		return _objectRect.Contains(x, y);
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		LabelColor = LtYDXieHrNI3Pb2RiJqb(theme);
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 1;
		int num2 = num;
		LabelObject labelObject = default(LabelObject);
		while (true)
		{
			switch (num2)
			{
			case 1:
				labelObject = objectBase as LabelObject;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				LabelColor = Glg1fdeHKePjdAEg1x3P(labelObject);
				FontSize = labelObject.FontSize;
				goto IL_003a;
			default:
				{
					if (labelObject != null)
					{
						LabelText = labelObject.LabelText;
						num2 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_003a;
				}
				IL_003a:
				base.CopyTemplate(objectBase, style);
				return;
			}
		}
	}

	static LabelObject()
	{
		xWnqvpeHmU0uIyIqDGjo();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool FnFvtLeHI0yHHr1uXnDD()
	{
		return WnUgPCeHqpRSncEBBe0x == null;
	}

	internal static LabelObject BRRZwJeHWZIHKQWVoBKq()
	{
		return WnUgPCeHqpRSncEBBe0x;
	}

	internal static int XrfEq2eHtba2fQto0eil(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object ITd0sieHUW5Z4bt8FXc0(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color ynN6MqeHTPBpWKpYSDSP()
	{
		return Colors.Black;
	}

	internal static object w1Bx4reHyrsEQj2ofR83(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static Size G84OrYeHZLXRjfABXReR(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static int w1NVYaeHVyHkq1mxcs7Z(object P_0)
	{
		return ((ObjectBase)P_0).PenWidth;
	}

	internal static void tMYHwIeHCcWPrnpvchU3(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static XColor LtYDXieHrNI3Pb2RiJqb(object P_0)
	{
		return ((IChartTheme)P_0).ChartFontColor;
	}

	internal static XColor Glg1fdeHKePjdAEg1x3P(object P_0)
	{
		return ((LabelObject)P_0).LabelColor;
	}

	internal static void xWnqvpeHmU0uIyIqDGjo()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
