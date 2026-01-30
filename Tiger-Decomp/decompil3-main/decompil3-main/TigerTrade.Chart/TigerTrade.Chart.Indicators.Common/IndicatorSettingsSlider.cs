using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Annotations;

namespace TigerTrade.Chart.Indicators.Common;

public sealed class IndicatorSettingsSlider : INotifyPropertyChanged
{
	private double _value;

	private readonly IndicatorBase _indicator;

	private readonly string _name;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static IndicatorSettingsSlider PCFKJseOb58efF5ji0fV;

	[NotifyParentProperty(true)]
	public double Value
	{
		get
		{
			return _value;
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
					value = cnEUoSeO12euh4C2fEBv(Minimum, Math.Min(Maximum, value));
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
				{
					if (value.Equals(_value))
					{
						return;
					}
					_value = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1087080834 ^ -1087049724));
					IndicatorBase indicator = _indicator;
					if (indicator != null)
					{
						indicator.SetSettingsParam(_name, _value);
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 0:
					return;
				}
			}
		}
	}

	public double Minimum { get; }

	public double Maximum { get; }

	public double TickFrequency { get; set; }

	public double SmallChange { get; set; }

	public double LargeChange { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
						{
							num = 1;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public IndicatorSettingsSlider(IndicatorBase indicator, string name, double value, double min, double max)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				_name = name;
				TickFrequency = 1.0;
				SmallChange = 0.1;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
				{
					num = 0;
				}
				break;
			default:
				Value = value;
				Minimum = min;
				Maximum = max;
				num = 2;
				break;
			case 2:
				_indicator = indicator;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				LargeChange = 1.0;
				return;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			BrDdXteO5mV8ryJlOYSn(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	static IndicatorSettingsSlider()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static double cnEUoSeO12euh4C2fEBv(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool tmEvZseONu0ArEHAlOHY()
	{
		return PCFKJseOb58efF5ji0fV == null;
	}

	internal static IndicatorSettingsSlider CayPNbeOkMeGGNB8mMKo()
	{
		return PCFKJseOb58efF5ji0fV;
	}

	internal static void BrDdXteO5mV8ryJlOYSn(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}
}
