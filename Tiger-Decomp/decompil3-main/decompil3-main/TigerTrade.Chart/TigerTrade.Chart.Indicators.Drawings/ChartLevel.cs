using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using TigerTrade.Chart.Annotations;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Indicators.Drawings;

[DataContract(Name = "ChartLevel", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Drawings")]
[ReadOnly(true)]
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ChartLevel : INotifyPropertyChanged
{
	private bool _visible;

	private decimal _level;

	private XColor _color;

	private int _width;

	private XDashStyle _style;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static ChartLevel JhU5bHe6vk2ji2AMjTVv;

	[DataMember(Name = "Visible")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonLevel")]
	public bool Visible
	{
		get
		{
			return _visible;
		}
		set
		{
			if (value != _visible)
			{
				_visible = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68DEE0F ^ 0x68D4523));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a != 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartCommonValue")]
	[DataMember(Name = "Level")]
	[NotifyParentProperty(true)]
	public decimal Level
	{
		get
		{
			return _level;
		}
		set
		{
			if (!(value == _level))
			{
				_level = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-710503328 ^ -710525090));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc != 0)
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

	[Browsable(false)]
	public XBrush LineBrush { get; private set; }

	[Browsable(false)]
	public XPen LinePen { get; private set; }

	[DataMember(Name = "Color")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonLineColor")]
	public XColor Color
	{
		get
		{
			return _color;
		}
		set
		{
			if (K0UoNTe6iM958YsH4rEY(value, _color))
			{
				return;
			}
			_color = value;
			LineBrush = new XBrush(_color);
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					LinePen = new XPen(LineBrush, Width, Style);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-838841832 ^ -838846468));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartCommonLineWidth")]
	[DataMember(Name = "Width")]
	public int Width
	{
		get
		{
			return _width;
		}
		set
		{
			value = Math.Max(1, Math.Min(10, value));
			if (value == _width)
			{
				return;
			}
			_width = value;
			LinePen = new XPen(LineBrush, _width, Style);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b != 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1EFE0A28 ^ 0x1EFE94D0));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "Style")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonLineStyle")]
	public XDashStyle Style
	{
		get
		{
			return _style;
		}
		set
		{
			if (value != _style)
			{
				_style = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				LinePen = new XPen(LineBrush, Width, _style);
				OnPropertyChanged((string)vmGEcje6lgQ8fX3m42Uk(0x7F645F3C ^ 0x7F64F470));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					break;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				}
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)KTpnW4e6NarsfI2tScuW(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
				{
					num2 = 0;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto default;
				}
			}
		}
	}

	public ChartLevel()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(0m, gdurene64f4GNNPYRngu());
	}

	public ChartLevel(decimal level, XColor color)
	{
		vFImx5e6DHq5a5jFFcbf();
		base._002Ector();
		Level = level;
		Visible = true;
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Width = 1;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Style = XDashStyle.Solid;
				return;
			case 2:
				Color = color;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void CopyTheme(ChartLevel chartLevel)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Style = LuTpqae6bFT65xj4mQQL(chartLevel);
				return;
			case 1:
				Level = chartLevel.Level;
				Color = chartLevel.Color;
				Width = chartLevel.Width;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Visible = chartLevel.Visible;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return Level.ToString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x68DEE0F ^ 0x68D4555));
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			b1X4Dfe6kgfs6cK0iFHk(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	static ChartLevel()
	{
		SI2dADe61ZfGX9mvBnyD();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool BxfhFVe6BEnlqfYy43iY()
	{
		return JhU5bHe6vk2ji2AMjTVv == null;
	}

	internal static ChartLevel b3UAUDe6alITUciWMKeu()
	{
		return JhU5bHe6vk2ji2AMjTVv;
	}

	internal static bool K0UoNTe6iM958YsH4rEY(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static object vmGEcje6lgQ8fX3m42Uk(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color gdurene64f4GNNPYRngu()
	{
		return Colors.Black;
	}

	internal static void vFImx5e6DHq5a5jFFcbf()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static XDashStyle LuTpqae6bFT65xj4mQQL(object P_0)
	{
		return ((ChartLevel)P_0).Style;
	}

	internal static object KTpnW4e6NarsfI2tScuW(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void b1X4Dfe6kgfs6cK0iFHk(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void SI2dADe61ZfGX9mvBnyD()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
