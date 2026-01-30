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
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Dx.Fonts;

namespace TigerTrade.Chart.Objects.List;

[ChartObject("Icon", "ChartObjectsIcon", 1, Type = typeof(IconObject))]
[DataContract(Name = "IconObject", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public class IconObject : ObjectBase
{
	private string _icon;

	private XColor _color;

	private int _size;

	private Rect _objectRect;

	internal static IconObject mmVkdYe2bhf73JHxC2jZ;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	[DataMember(Name = "Icon")]
	public string Icon
	{
		get
		{
			return _icon;
		}
		set
		{
			if (!rLTOcPe21OmKqQRInWJi(value, _icon))
			{
				_icon = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1325234765 ^ -1325205397));
			}
		}
	}

	[Browsable(false)]
	protected XBrush Brush { get; private set; }

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsColor")]
	[DataMember(Name = "Color")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsIcon")]
	public XColor Color
	{
		get
		{
			return _color;
		}
		set
		{
			if (!(value == _color))
			{
				_color = value;
				Brush = new XBrush(_color);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)adEHSNe25CNQlwbUX6MR(0xC1DDB3B ^ 0xC1DA6DF));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsIcon")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsSize")]
	[DataMember(Name = "Size")]
	public int Size
	{
		get
		{
			return _size;
		}
		set
		{
			value = zT92dfe2xPbOMUaLjIN6(10, QdB904e2SrM0vdFoX1Hr(100, value));
			if (value != _size)
			{
				_size = value;
				OnPropertyChanged((string)adEHSNe25CNQlwbUX6MR(0x3E0426F0 ^ 0x3E045B02));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
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

	public IconObject()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		_objectRect = Rect.Empty;
		base._002Ector();
		Color = Colors.Black;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Size = 20;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f != 0)
			{
				num = 1;
			}
		}
	}

	protected override void Draw(DxVisualQueue visual, ref List<ObjectLabelInfo> labels)
	{
		int num = 2;
		Point point = default(Point);
		FontAwesomeIcon result = default(FontAwesomeIcon);
		string text = default(string);
		XFont xFont = default(XFont);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!(point == default(Point)))
					{
						num2 = 4;
						break;
					}
					return;
				case 4:
					if (!Enum.TryParse<FontAwesomeIcon>(Icon, out result))
					{
						return;
					}
					goto end_IL_0012;
				case 3:
					text = (string)AQxMhle2LJoZEYK000iY((int)result);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 != 0)
					{
						num2 = 0;
					}
					break;
				default:
				{
					Size size = bA4oMje2e599XrFDmgwT(xFont, text);
					_objectRect = new Rect(point.X - size.Width / 2.0 - 2.0, point.Y - size.Height / 2.0 - 2.0, size.Width + 4.0, size.Height + 4.0);
					P0VR29e2sSr3aJxncCQc(visual, text, xFont, Brush, _objectRect, XTextAlignment.Center);
					return;
				}
				case 2:
					point = ToPoint(base.ControlPoints[0]);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			int num3 = (int)((double)Size * 96.0 / 72.0);
			xFont = new XFont(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1763895751 ^ -1763873849), num3);
			num = 3;
		}
	}

	protected override bool InObject(int x, int y)
	{
		return _objectRect.Contains(x, y);
	}

	public override void ApplyTheme(IChartTheme theme)
	{
		base.ApplyTheme(theme);
		Color = theme.ChartFontColor;
	}

	public override void CopyTemplate(ObjectBase objectBase, bool style)
	{
		int num = 1;
		int num2 = num;
		IconObject iconObject = default(IconObject);
		while (true)
		{
			switch (num2)
			{
			default:
				if (iconObject != null)
				{
					Color = iconObject.Color;
					Size = dP7AC9e2XVHjMXca09hT(iconObject);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			case 2:
				base.CopyTemplate(objectBase, style);
				return;
			case 1:
				iconObject = objectBase as IconObject;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static IconObject()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool rLTOcPe21OmKqQRInWJi(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool yO9j4Ae2NPcum5XIMroQ()
	{
		return mmVkdYe2bhf73JHxC2jZ == null;
	}

	internal static IconObject pkPMJoe2kmvMGXi7tg7c()
	{
		return mmVkdYe2bhf73JHxC2jZ;
	}

	internal static object adEHSNe25CNQlwbUX6MR(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static int QdB904e2SrM0vdFoX1Hr(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int zT92dfe2xPbOMUaLjIN6(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object AQxMhle2LJoZEYK000iY(int P_0)
	{
		return char.ConvertFromUtf32(P_0);
	}

	internal static Size bA4oMje2e599XrFDmgwT(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static void P0VR29e2sSr3aJxncCQc(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static int dP7AC9e2XVHjMXca09hT(object P_0)
	{
		return ((IconObject)P_0).Size;
	}
}
