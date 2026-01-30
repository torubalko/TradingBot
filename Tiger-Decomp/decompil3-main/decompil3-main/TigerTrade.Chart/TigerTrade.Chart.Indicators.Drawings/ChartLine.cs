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
using TigerTrade.Chart.Properties;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Indicators.Drawings;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ReadOnly(true)]
[DataContract(Name = "ChartLine", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Drawings")]
public sealed class ChartLine : INotifyPropertyChanged
{
	private bool _visible;

	private bool _showMarker;

	private XColor _color;

	private int _width;

	private XDashStyle _style;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ChartLine GH5CQse65mqN8wH6HTGJ;

	[DataMember(Name = "Visible")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonChart")]
	[NotifyParentProperty(true)]
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
				OnPropertyChanged((string)LyWn4He6Lq8anlv4URTR(-342738082 ^ -342716302));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
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

	[NotifyParentProperty(true)]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonMarker")]
	[DataMember(Name = "ShowMarker")]
	public bool ShowMarker
	{
		get
		{
			return _showMarker;
		}
		set
		{
			if (value != _showMarker)
			{
				_showMarker = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_caac71a6f9cb44c08459ac3c8bd80328 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D3134C9 ^ 0x2D319FAB));
			}
		}
	}

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
			if (!(value == _color))
			{
				_color = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1153206687 ^ -1153234043));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
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

	[DataMember(Name = "Width")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonLineWidth")]
	public int Width
	{
		get
		{
			return _width;
		}
		set
		{
			value = Math.Max(1, Math.Min(10, value));
			if (value != _width)
			{
				_width = value;
				OnPropertyChanged((string)LyWn4He6Lq8anlv4URTR(0x4297C3EB ^ 0x42975D13));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736526900));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
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

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto case 1;
				}
				case 1:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 != 0)
					{
						num2 = 1;
					}
					break;
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
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
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
					{
						num = 1;
					}
				}
			}
		}
	}

	public ChartLine()
	{
		rFoTsie6ektObW1oZocH();
		base._002Ector();
		Visible = true;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
			{
				Style = XDashStyle.Solid;
				int num2 = 2;
				num = num2;
				continue;
			}
			}
			ShowMarker = true;
			Color = JuADP5e6XgItXgEvVMjL(VDPD4ae6sE2FE9kq2IMC());
			Width = 1;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
			{
				num = 1;
			}
		}
	}

	public void CopyTheme(ChartLine chartLine)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				Visible = chartLine.Visible;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				ShowMarker = n76C1Pe6ctvZEFEwqlVt(chartLine);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				Color = miVTape6jLuXZ9G16tmG(chartLine);
				Width = RD2bwEe6EEicugiIOnUC(chartLine);
				Style = LiGmFye6QPcxAeKosDYy(chartLine);
				return;
			}
		}
	}

	public override string ToString()
	{
		return Resources.ChartCommonLine;
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static ChartLine()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		Gncvj9e6djDuFQoFdVcZ();
	}

	internal static object LyWn4He6Lq8anlv4URTR(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool upOHD3e6SXI6whN7sUHI()
	{
		return GH5CQse65mqN8wH6HTGJ == null;
	}

	internal static ChartLine rXEEAGe6xvZp8R95879p()
	{
		return GH5CQse65mqN8wH6HTGJ;
	}

	internal static void rFoTsie6ektObW1oZocH()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color VDPD4ae6sE2FE9kq2IMC()
	{
		return Colors.Blue;
	}

	internal static XColor JuADP5e6XgItXgEvVMjL(Color P_0)
	{
		return P_0;
	}

	internal static bool n76C1Pe6ctvZEFEwqlVt(object P_0)
	{
		return ((ChartLine)P_0).ShowMarker;
	}

	internal static XColor miVTape6jLuXZ9G16tmG(object P_0)
	{
		return ((ChartLine)P_0).Color;
	}

	internal static int RD2bwEe6EEicugiIOnUC(object P_0)
	{
		return ((ChartLine)P_0).Width;
	}

	internal static XDashStyle LiGmFye6QPcxAeKosDYy(object P_0)
	{
		return ((ChartLine)P_0).Style;
	}

	internal static void Gncvj9e6djDuFQoFdVcZ()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
