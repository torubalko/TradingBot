using System;
using System.Collections.Generic;
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
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Properties;
using TigerTrade.Core.UI.Common;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace TigerTrade.Chart.Indicators.Drawings;

[DataContract(Name = "ChartSeries", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Drawings")]
[ReadOnly(true)]
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ChartSeries : INotifyPropertyChanged, IDynamicProperty
{
	private bool _visible;

	private bool _showMarker;

	private ChartSeriesType _type;

	private ChartSeriesColorSplit _colorSplit;

	private XColor _color;

	private XColor _color2;

	private int _width;

	private XDashStyle _style;

	private ChartSeriesDotStyle _dotStyle;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ChartSeries G6wOLge6t3HLfnEXElQi;

	[DataMember(Name = "Visible")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonChart")]
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
				OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(-2002318893 ^ -2002279681));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
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
					if (value != _showMarker)
					{
						_showMarker = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFE89E));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Type")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonChartType")]
	public ChartSeriesType Type
	{
		get
		{
			return _type;
		}
		set
		{
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (value != _type)
						{
							_type = value;
							num2 = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto end_IL_0012;
					default:
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-377195341 ^ -377170153));
						return;
					case 2:
						return;
					case 1:
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306906448));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x32DEA4F1 ^ 0x32DE3A09));
						OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(-2063361985 ^ -2063387789));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1763895751 ^ -1763852989));
						OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(0x385FFAB ^ 0x3855425));
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
						{
							num2 = 0;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartCommonColorSplit")]
	[DataMember(Name = "ColorSplit")]
	public ChartSeriesColorSplit ColorSplit
	{
		get
		{
			return _colorSplit;
		}
		set
		{
			if (value != _colorSplit)
			{
				_colorSplit = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(-181342698 ^ -181385832));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2063361985 ^ -2063385701));
			}
		}
	}

	[Browsable(false)]
	public XColor AllColors
	{
		set
		{
			Color = value;
			Color2 = value;
		}
	}

	[DataMember(Name = "Color")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonColor")]
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--134855371 ^ 0x809C72F));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
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

	[DataMember(Name = "Color2")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonColor2")]
	public XColor Color2
	{
		get
		{
			return _color2;
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
					if (mdQCQ0e6Zx4Ih5JU4n3B(value, _color2))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_color2 = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x1D7BA1ED ^ 0x1D7B0249));
					return;
				case 0:
					return;
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
			value = Math.Max(1, sWeu1Xe6VnTfemdbaRdt(10, value));
			if (value != _width)
			{
				_width = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-57768881 ^ -57795913));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartCommonLineStyle")]
	[DataMember(Name = "Style")]
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
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(0x6EC99CAF ^ 0x6EC937E3));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartCommonDotStyle")]
	[DataMember(Name = "DotStyle")]
	public ChartSeriesDotStyle DotStyle
	{
		get
		{
			return _dotStyle;
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
					if (value == _dotStyle)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_dotStyle = value;
					OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(0x5CD4F15 ^ 0x5CDE46F));
					OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(0x446AB724 ^ 0x446A29DC));
					OnPropertyChanged((string)hbeHmZe6yVkIwJb8GrTE(-837284864 ^ -837245108));
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 0:
					return;
				}
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
				default:
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
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
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				}
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public ChartSeries()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(ChartSeriesType.Line, Colors.Transparent, XDashStyle.Solid);
	}

	public ChartSeries(ChartSeriesType type, XColor color)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(type, color, XDashStyle.Solid);
	}

	public ChartSeries(ChartSeriesType type, XColor color, XDashStyle style)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				Style = style;
				num = 2;
				break;
			case 3:
				Visible = true;
				ShowMarker = true;
				Type = type;
				ColorSplit = ChartSeriesColorSplit.NoSplit;
				Color = color;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				DotStyle = ChartSeriesDotStyle.Point;
				return;
			case 1:
				Color2 = color;
				Width = 1;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void CopyTheme(ChartSeries chartSeries)
	{
		if (chartSeries == null)
		{
			return;
		}
		Visible = TwHt13e6CiNNOWlHSKTr(chartSeries);
		ShowMarker = chartSeries.ShowMarker;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Color2 = chartSeries.Color2;
				num = 2;
				break;
			default:
				Type = chartSeries.Type;
				ColorSplit = GWQK6Ve6rncMP6BSqKaR(chartSeries);
				Color = chartSeries.Color;
				num = 3;
				break;
			case 2:
				Width = JwBNXme6KX6IUt2oI7C2(chartSeries);
				Style = chartSeries.Style;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				DotStyle = chartSeries.DotStyle;
				return;
			}
		}
	}

	public override string ToString()
	{
		return Resources.ChartCommonChart;
	}

	public bool GetPropertyVisibility(string propertyName)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (propertyName == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7F645F3C ^ 0x7F64C1C4))
				{
					num2 = 2;
					break;
				}
				if (vAAJo3e6mp4Aly1ZLuVo(propertyName, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-165474503 ^ -165436299)))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 1:
			case 2:
			case 4:
				if (Type == ChartSeriesType.Line)
				{
					return true;
				}
				if (Type == ChartSeriesType.Points)
				{
					return DotStyle != ChartSeriesDotStyle.Point;
				}
				return false;
			default:
				if (!(propertyName == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7394D272 ^ 0x73947908)))
				{
					if (propertyName == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x60620FC1 ^ 0x6062A44F))
					{
						if (Type != ChartSeriesType.Area)
						{
							num2 = 5;
							break;
						}
						return false;
					}
					if (!vAAJo3e6mp4Aly1ZLuVo(propertyName, hbeHmZe6yVkIwJb8GrTE(-198991962 ^ -199017470)))
					{
						return true;
					}
					if (Type != ChartSeriesType.Area)
					{
						num2 = 6;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto IL_0042;
				}
				return Type == ChartSeriesType.Points;
			case 6:
				if (Type != ChartSeriesType.Region)
				{
					return ColorSplit != ChartSeriesColorSplit.NoSplit;
				}
				goto IL_0042;
			case 5:
				{
					return Type != ChartSeriesType.Region;
				}
				IL_0042:
				return false;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			q6iZY9e6hAIoSo4gy8gg(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public bool GetPropertyHasStandardValues(string propertyName)
	{
		return false;
	}

	public bool GetPropertyReadOnly(string propertyName)
	{
		return false;
	}

	public IEnumerable<object> GetPropertyStandardValues(string propertyName)
	{
		return null;
	}

	static ChartSeries()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object hbeHmZe6yVkIwJb8GrTE(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool FLeptAe6UesOeFTX2ES6()
	{
		return G6wOLge6t3HLfnEXElQi == null;
	}

	internal static ChartSeries TVgyqpe6Tv3gyTYjyd82()
	{
		return G6wOLge6t3HLfnEXElQi;
	}

	internal static bool mdQCQ0e6Zx4Ih5JU4n3B(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static int sWeu1Xe6VnTfemdbaRdt(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static bool TwHt13e6CiNNOWlHSKTr(object P_0)
	{
		return ((ChartSeries)P_0).Visible;
	}

	internal static ChartSeriesColorSplit GWQK6Ve6rncMP6BSqKaR(object P_0)
	{
		return ((ChartSeries)P_0).ColorSplit;
	}

	internal static int JwBNXme6KX6IUt2oI7C2(object P_0)
	{
		return ((ChartSeries)P_0).Width;
	}

	internal static bool vAAJo3e6mp4Aly1ZLuVo(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void q6iZY9e6hAIoSo4gy8gg(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}
}
