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

namespace TigerTrade.Chart.Indicators.Drawings;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ReadOnly(true)]
[DataContract(Name = "ChartRegion", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Drawings")]
public sealed class ChartRegion : INotifyPropertyChanged
{
	private bool _visible;

	private XColor _color;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static ChartRegion gopt7ve6g1NU1g7F64ob;

	[DataMember(Name = "Visible")]
	[ye30Hki4oR4RQBdkwwe7("ChartCommonArea")]
	public bool Visible
	{
		get
		{
			return _visible;
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
					if (value == _visible)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_visible = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB4A25F));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartCommonColor")]
	[DataMember(Name = "Color")]
	public XColor Color
	{
		get
		{
			return _color;
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
					if (!(value == _color))
					{
						_color = value;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-617064403 ^ -617077303));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
					{
						num2 = 0;
					}
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
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					break;
				}
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)ogQgBue6IxHJCt6JVlWG(propertyChangedEventHandler2, value);
				int num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					}
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public ChartRegion()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(j4x8h5e6MpMu1iaZFpUD());
	}

	public ChartRegion(XColor color)
	{
		mUkGmEe6OuP3KonotiCD();
		base._002Ector();
		Visible = true;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Color = color;
	}

	public void CopyTheme(ChartRegion chartRegion)
	{
		Visible = chartRegion.Visible;
		Color = chartRegion.Color;
	}

	public override string ToString()
	{
		return (string)eA7F7we6qDO92jfbZJ03();
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static ChartRegion()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		IXcbcFe6WiXtuZkxjiJ4();
	}

	internal static bool WsLcOre6RPTmIq7PwMF0()
	{
		return gopt7ve6g1NU1g7F64ob == null;
	}

	internal static ChartRegion tx2Hw8e660MZAVmedEXP()
	{
		return gopt7ve6g1NU1g7F64ob;
	}

	internal static Color j4x8h5e6MpMu1iaZFpUD()
	{
		return Colors.Transparent;
	}

	internal static void mUkGmEe6OuP3KonotiCD()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object eA7F7we6qDO92jfbZJ03()
	{
		return Resources.ChartCommonArea;
	}

	internal static object ogQgBue6IxHJCt6JVlWG(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void IXcbcFe6WiXtuZkxjiJ4()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
