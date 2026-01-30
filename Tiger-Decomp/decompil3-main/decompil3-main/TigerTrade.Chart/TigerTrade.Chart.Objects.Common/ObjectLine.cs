using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Annotations;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Objects.Common;

[ReadOnly(true)]
[TypeConverter(typeof(ExpandableObjectConverter))]
[DataContract(Name = "ObjectLine", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects")]
public sealed class ObjectLine : INotifyPropertyChanged
{
	private bool _showLine;

	private double _value;

	private XColor _lineColor;

	private int _lineWidth;

	private XDashStyle _lineStyle;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static ObjectLine oTlXsOeGtQMWMYs4Cnvn;

	[DataMember(Name = "ShowLine")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsShowLine")]
	public bool ShowLine
	{
		get
		{
			return _showLine;
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
					if (value != _showLine)
					{
						_showLine = value;
						OnPropertyChanged((string)H7nO5LeGyDbe3s7XnAEw(-527080372 ^ -527048150));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLevelValue")]
	[DataMember(Name = "Value")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[NotifyParentProperty(true)]
	public double Value
	{
		get
		{
			return _value;
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
					if (!value.Equals(_value))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					_value = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1416986301 ^ -1417017543));
					return;
				}
			}
		}
	}

	[Browsable(false)]
	public XBrush LineBrush { get; private set; }

	[Browsable(false)]
	public XPen LinePen { get; private set; }

	[DataMember(Name = "LineColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineColor")]
	public XColor LineColor
	{
		get
		{
			return _lineColor;
		}
		set
		{
			if (value == _lineColor)
			{
				return;
			}
			_lineColor = value;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					LinePen = new XPen(LineBrush, LineWidth, LineStyle);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1346994499 ^ -1346963403));
					return;
				}
				LineBrush = new XBrush(_lineColor);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	[DataMember(Name = "LineWidth")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineWidth")]
	public int LineWidth
	{
		get
		{
			return _lineWidth;
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
					return;
				case 2:
					value = Math.Max(1, Math.Min(10, value));
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (value == _lineWidth)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
						{
							num2 = 0;
						}
						break;
					}
					_lineWidth = value;
					LinePen = new XPen(LineBrush, _lineWidth, LineStyle);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-53782092 ^ -53747926));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "LineStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartObjectsLineStyle")]
	[IY0CXri4H6cGjAdYCVwG("ChartObjectsLine")]
	public XDashStyle LineStyle
	{
		get
		{
			return _lineStyle;
		}
		set
		{
			if (value != _lineStyle)
			{
				_lineStyle = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				LinePen = new XPen(LineBrush, LineWidth, _lineStyle);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D31B6FC));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyChangedEventHandler2 = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler, value);
					propertyChangedEventHandler2 = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler);
					if ((object)propertyChangedEventHandler2 == propertyChangedEventHandler)
					{
						return;
					}
					break;
				}
				}
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
				{
					num2 = 2;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)A8oRuaeGCwJLb58UM1Ph(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public ObjectLine()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(0.0, aphqKxeGZrNjyi4Coe0B(Colors.Black));
	}

	public ObjectLine(double value, XColor color)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShowLine = true;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				LineStyle = XDashStyle.Solid;
				return;
			case 1:
				LineWidth = 1;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
				{
					num = 0;
				}
				break;
			case 2:
				Value = value;
				LineColor = color;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public ObjectLine(ObjectLine line)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ShowLine = line.ShowLine;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Value = line.Value;
				LineColor = line.LineColor;
				LineWidth = line.LineWidth;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				LineStyle = kUNsD8eGVSI6MURPUMlG(line);
				num = 2;
				break;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public override string ToString()
	{
		return Value.ToString((IFormatProvider)DDHbp7eGrx8JhQtUaLx1());
	}

	static ObjectLine()
	{
		EIl3IYeGKb1vtYRoYuYW();
		BKRuQheGmOb57KI6YPZJ();
	}

	internal static object H7nO5LeGyDbe3s7XnAEw(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool X7cXvUeGUnGQRpFyBBYx()
	{
		return oTlXsOeGtQMWMYs4Cnvn == null;
	}

	internal static ObjectLine lgDg0SeGTtIPN5uRanoK()
	{
		return oTlXsOeGtQMWMYs4Cnvn;
	}

	internal static XColor aphqKxeGZrNjyi4Coe0B(Color P_0)
	{
		return P_0;
	}

	internal static XDashStyle kUNsD8eGVSI6MURPUMlG(object P_0)
	{
		return ((ObjectLine)P_0).LineStyle;
	}

	internal static object A8oRuaeGCwJLb58UM1Ph(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object DDHbp7eGrx8JhQtUaLx1()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static void EIl3IYeGKb1vtYRoYuYW()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void BKRuQheGmOb57KI6YPZJ()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
