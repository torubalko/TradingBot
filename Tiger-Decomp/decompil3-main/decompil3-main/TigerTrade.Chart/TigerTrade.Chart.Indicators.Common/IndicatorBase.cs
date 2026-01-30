using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using CxrNctLVMAMdEWPCMHj4;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Annotations;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Core.UI.Common;
using TigerTrade.Dx;

namespace TigerTrade.Chart.Indicators.Common;

[DataContract(Name = "IndicatorBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public abstract class IndicatorBase : INotifyPropertyChanged, IDynamicProperty, ICloneable
{
	private string _revision;

	private int _lastCount;

	private long _lastPrice;

	protected bool _propChanged;

	private IndicatorSeries _series;

	private List<ChartLevel> _levels;

	private string _id;

	private string _name;

	private List<ChartAlertInfo> _alerts;

	private IndicatorCalculation _calculation;

	private string _panel;

	private List<string> _panels;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static IndicatorBase rbuGbLeOzhFeYrI35Hoo;

	protected bool ClearData { get; private set; }

	protected string SettingsShortKey { get; private set; }

	protected string SettingsLongKey { get; private set; }

	[Browsable(false)]
	public IndicatorSeries Series => _series ?? (_series = new IndicatorSeries());

	[DataMember(Name = "Levels")]
	[Browsable(false)]
	public List<ChartLevel> Levels
	{
		get
		{
			return _levels ?? (_levels = new List<ChartLevel>());
		}
		set
		{
			_levels = value;
		}
	}

	[Browsable(false)]
	public string ID
	{
		get
		{
			if (!cMt4JueqHkPqNEYyeE37(_id))
			{
				return _id;
			}
			IndicatorAttribute indicatorAttribute = (IndicatorAttribute)W6QGkieq9T3BhYU9VctP(GetType(), uhUrGUeqfpYFHTfZKrd6(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554738)));
			_id = (string)((indicatorAttribute != null) ? UMG4sLeqGLjuGGqFJTUY(indicatorAttribute) : guwf8weqnvLU9Odt8Jyq(-53782092 ^ -53747806));
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => _id, 
			};
		}
	}

	[Browsable(false)]
	public string Name
	{
		get
		{
			if (!string.IsNullOrEmpty(_name))
			{
				return _name;
			}
			IndicatorAttribute indicatorAttribute = (IndicatorAttribute)Attribute.GetCustomAttribute(GetType(), uhUrGUeqfpYFHTfZKrd6(PmCEjqLV6uu58HwXqSEy.q1FehnPSsFB(33554738)));
			_name = (string)((indicatorAttribute != null) ? indicatorAttribute.Name : guwf8weqnvLU9Odt8Jyq(0x684F243E ^ 0x684F8842));
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => _name, 
			};
		}
	}

	[Browsable(false)]
	public virtual ChartDataType ChartDataType => ChartDataType.Bar;

	[Browsable(false)]
	public virtual bool IsStock => false;

	[Browsable(false)]
	public virtual bool IntegerValues => false;

	[Browsable(false)]
	public string Title => ToString();

	[Browsable(false)]
	public bool DisableRender { get; protected set; }

	[Browsable(false)]
	public IChartCanvas Canvas { get; set; }

	protected IndicatorsHelper Helper { get; private set; }

	protected IChartDataProvider DataProvider { get; private set; }

	[DataMember(Name = "ShowIndicator")]
	[Browsable(false)]
	public bool? ShowIndicatorParam { get; set; }

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsIndicator")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowIndicator")]
	public bool ShowIndicator
	{
		get
		{
			if (!ShowIndicatorParam.HasValue)
			{
				return true;
			}
			bool? showIndicatorParam = ShowIndicatorParam;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => showIndicatorParam.Value, 
			};
		}
		set
		{
			if (value != ShowIndicatorParam)
			{
				ShowIndicatorParam = value;
				OnPropertyChanged((string)guwf8weqnvLU9Odt8Jyq(0x42D899B5 ^ 0x42D83527));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f != 0)
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
	[DataMember(Name = "ShowIndicatorTitle")]
	public bool? ShowIndicatorTitleParam { get; set; }

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsIndicator")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowIndicatorTitle")]
	public virtual bool ShowIndicatorTitle
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool? showIndicatorTitleParam = default(bool?);
			while (true)
			{
				switch (num2)
				{
				default:
					if (showIndicatorTitleParam.HasValue)
					{
						return ShowIndicatorTitleParam.Value;
					}
					return true;
				case 1:
					showIndicatorTitleParam = ShowIndicatorTitleParam;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
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
					if (value == ShowIndicatorTitleParam)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ebea16d83ff14ec5b816c14cbab4c1cf == 0)
						{
							num2 = 0;
						}
						break;
					}
					ShowIndicatorTitleParam = value;
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x315AB1E3 ^ 0x315A1D53));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[Browsable(false)]
	[DataMember(Name = "ShowIndicatorValues")]
	public bool? ShowIndicatorValuesParam { get; set; }

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowIndicatorValues")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsIndicator")]
	public virtual bool ShowIndicatorValues
	{
		get
		{
			if (ShowIndicatorValuesParam.HasValue)
			{
				bool? showIndicatorValuesParam = ShowIndicatorValuesParam;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => showIndicatorValuesParam.Value, 
				};
			}
			return true;
		}
		set
		{
			if (value != ShowIndicatorValuesParam)
			{
				ShowIndicatorValuesParam = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)guwf8weqnvLU9Odt8Jyq(-1461292091 ^ -1461264611));
			}
		}
	}

	[Browsable(false)]
	[DataMember(Name = "ShowIndicatorLabels")]
	public bool? ShowIndicatorLabelsParam { get; set; }

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowIndicatorLabels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsIndicator")]
	public virtual bool ShowIndicatorLabels
	{
		get
		{
			int num = 1;
			int num2 = num;
			bool? showIndicatorLabelsParam = default(bool?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					showIndicatorLabelsParam = ShowIndicatorLabelsParam;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (showIndicatorLabelsParam.HasValue)
					{
						return ShowIndicatorLabelsParam.Value;
					}
					return true;
				}
			}
		}
		set
		{
			if (value != ShowIndicatorLabelsParam)
			{
				ShowIndicatorLabelsParam = value;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x50C1C840 ^ 0x50C16542));
			}
		}
	}

	[Browsable(false)]
	public virtual IndicatorCalculation DefaultCalculation => IndicatorCalculation.OnBarClose;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsIndicator")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsCalculation")]
	[DataMember(Name = "Calculation")]
	public virtual IndicatorCalculation Calculation
	{
		get
		{
			return _calculation;
		}
		set
		{
			if (value != _calculation)
			{
				_calculation = value;
				OnPropertyChanged((string)guwf8weqnvLU9Odt8Jyq(-165474503 ^ -165436907));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsIndicator")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsArea")]
	public string Panel
	{
		get
		{
			return _panel;
		}
		set
		{
			if (!(value == _panel))
			{
				_panel = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x9F0F634 ^ 0x9F05B72));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
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
	public List<string> Panels => _panels ?? (_panels = new List<string>());

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
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
				case 1:
				{
					PropertyChangedEventHandler propertyChangedEventHandler2;
					do
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					}
					while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
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
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler, value);
					propertyChangedEventHandler2 = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler);
					if ((object)propertyChangedEventHandler2 == propertyChangedEventHandler)
					{
						return;
					}
					break;
				}
				}
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	protected IndicatorBase()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	public virtual void OnSetSymbol()
	{
	}

	public virtual void StartNextCheckAlertRound()
	{
	}

	public void Run(IChartDataProvider dp, string longKey, string shortKey, string revision)
	{
		int num = 7;
		IRawCluster rawCluster = default(IRawCluster);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
					if (rawCluster == null || rawCluster.Close != _lastPrice)
					{
						_lastPrice = ((rawCluster != null) ? XN1ywieqvBMbvkWOJjui(rawCluster) : 0);
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 5:
					_propChanged = false;
					_revision = revision;
					return;
				case 11:
					Helper = new IndicatorsHelper();
					num2 = 10;
					continue;
				case 1:
				case 20:
					if (flag || _propChanged)
					{
						cWujUpeqBAdIWCJiMkOv(Series);
						Execute();
						num2 = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 5;
				case 4:
					flag = true;
					goto case 1;
				case 10:
					HiS7poeqYF38BaTIkCPE(Helper, dp);
					num2 = 18;
					continue;
				case 14:
					rawCluster = DataProvider?.GetRawCluster(Dia5TQeqo5C0FIRVSwup(DataProvider) - 1);
					num2 = 16;
					continue;
				case 15:
					if (Helper == null)
					{
						num2 = 11;
						continue;
					}
					goto case 10;
				case 6:
					SettingsShortKey = shortKey;
					num2 = 15;
					continue;
				case 3:
					flag = true;
					num2 = 14;
					continue;
				case 13:
					goto IL_023f;
				case 7:
					SettingsLongKey = longKey;
					num2 = 6;
					continue;
				case 8:
					switch ((Calculation == IndicatorCalculation.Default) ? DefaultCalculation : Calculation)
					{
					case IndicatorCalculation.OnEachTick:
						break;
					default:
						goto IL_023f;
					case IndicatorCalculation.OnPriceChange:
						goto IL_0304;
					case IndicatorCalculation.OnBarClose:
						goto IL_0324;
					}
					flag = true;
					goto case 1;
				default:
					flag = true;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 == 0)
					{
						num2 = 1;
					}
					continue;
				case 18:
					DataProvider = dp;
					ClearData = _revision != revision;
					flag = false;
					num2 = 8;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
					{
						num2 = 8;
					}
					continue;
				case 19:
					goto IL_0324;
				case 2:
					if (dp.Count != 0 && !ClearData)
					{
						if (Dia5TQeqo5C0FIRVSwup(dp) != _lastCount)
						{
							goto end_IL_0012;
						}
						goto case 14;
					}
					goto case 9;
				case 9:
				case 17:
					_lastCount = dp?.Count ?? 0;
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					break;
					IL_0324:
					if (dp == null || Dia5TQeqo5C0FIRVSwup(dp) == 0)
					{
						break;
					}
					if (!ClearData)
					{
						if (dp.Count != _lastCount)
						{
							break;
						}
						goto case 1;
					}
					num2 = 12;
					continue;
					IL_0304:
					if (dp == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 2;
					IL_023f:
					flag = true;
					num2 = 20;
					continue;
				}
				_lastCount = ((dp != null) ? Dia5TQeqo5C0FIRVSwup(dp) : 0);
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 17;
		}
	}

	protected abstract void Execute();

	protected double GetX(int i)
	{
		return Canvas.GetX(i);
	}

	protected double GetY(double d)
	{
		return Su7EqOeqaXHtWTaRuYYN(Canvas, d);
	}

	protected double GetY(decimal d)
	{
		return GetY(Qy9ZFVeqiY3dfEeY3SnC(d));
	}

	public virtual bool GetMinMax(out double min, out double max)
	{
		int num = 2;
		int num2 = num;
		bool result = default(bool);
		IEnumerator<IndicatorSeriesData> enumerator = default(IEnumerator<IndicatorSeriesData>);
		double val = default(double);
		double num6 = default(double);
		double num4 = default(double);
		double highPercent = default(double);
		IndicatorSeriesData current = default(IndicatorSeriesData);
		double lowPercent = default(double);
		double num5 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
				min = double.MaxValue;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				max = double.MinValue;
				result = false;
				enumerator = Series.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
						{
							num3 = 0;
						}
						goto IL_00a3;
					}
					goto IL_0196;
					IL_00a3:
					while (true)
					{
						switch (num3)
						{
						case 6:
							goto IL_0138;
						case 3:
							val = (num6 - num4 * (1.0 - highPercent)) / highPercent;
							goto IL_0206;
						case 5:
							goto IL_0196;
						case 1:
							highPercent = ((IndicatorSeriesStyle)REyNCreq4U053JLdvFA0(current)).HighPercent;
							lowPercent = ((IndicatorSeriesStyle)REyNCreq4U053JLdvFA0(current)).LowPercent;
							num4 = num5;
							num3 = 6;
							continue;
						case 4:
							if (lowPercent != 0.0)
							{
								goto IL_00e7;
							}
							goto IL_0206;
						case 2:
							goto IL_0246;
						case 0:
							break;
							IL_0206:
							min = Math.Min(min, num4);
							num3 = 2;
							continue;
						}
						break;
						IL_0138:
						val = num6;
						if (highPercent == 1.0)
						{
							int num7 = 4;
							num3 = num7;
							continue;
						}
						goto IL_00e7;
						IL_00e7:
						num4 = (num5 * highPercent - num6 * lowPercent) / (highPercent - lowPercent);
						num3 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
						{
							num3 = 3;
						}
					}
					break;
					IL_0246:
					max = Math.Max(max, val);
					result = true;
					continue;
					IL_0196:
					current = enumerator.Current;
					if (current.Style.DisableMinMax)
					{
						continue;
					}
					num5 = current.MinValue(B48evMeqlki0uuGbSoQY(Canvas), Canvas.Count);
					num6 = current.MaxValue(Canvas.Start, Canvas.Count);
					num3 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 == 0)
					{
						num3 = 1;
					}
					goto IL_00a3;
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
			return result;
		}
	}

	public virtual double GetDistance(double x, double y)
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		IndicatorSeriesData current = default(IndicatorSeriesData);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = double.MaxValue;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			IEnumerator<IndicatorSeriesData> enumerator = Series.GetEnumerator();
			try
			{
				while (true)
				{
					int num4;
					if (!w7bhuteqDxcuyKoPCmiW(enumerator))
					{
						num4 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
						{
							num4 = 0;
						}
						goto IL_0072;
					}
					goto IL_00cc;
					IL_0072:
					switch (num4)
					{
					case 1:
						goto IL_0088;
					case 2:
						goto IL_00cc;
					case 0:
						break;
					}
					break;
					IL_0088:
					double distance = current.GetDistance(x, y);
					if (num3 > distance)
					{
						num3 = distance;
					}
					continue;
					IL_00cc:
					current = enumerator.Current;
					if (current.Style.DisableSelect)
					{
						continue;
					}
					num4 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 != 0)
					{
						num4 = 1;
					}
					goto IL_0072;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					B5KBXZeqbBqh3GBkUuxr(enumerator);
				}
			}
			return num3;
		}
	}

	protected Point[] GetPoints(IndicatorSeriesData seriesData, string name = null)
	{
		int num = 4;
		int num2 = num;
		Point[] array2 = default(Point[]);
		List<Point> list = default(List<Point>);
		int num4 = default(int);
		double[] array = default(double[]);
		int stop = default(int);
		while (true)
		{
			double[] array3;
			switch (num2)
			{
			case 5:
				seriesData.CachePoints(array2, name);
				return array2;
			case 2:
				list.Add(new Point(GetX(num4), GetY(array[num4])));
				goto IL_008b;
			case 3:
				array3 = seriesData[name];
				break;
			default:
				if (!rfytAKeqkmQ8l5e3u5c7(array[num4]))
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_008b;
			case 4:
				if (!string.IsNullOrEmpty(name))
				{
					num2 = 3;
					continue;
				}
				array3 = seriesData.Data;
				break;
			case 1:
				{
					if (array == null)
					{
						return null;
					}
					int num3 = array.Length - B4IkDTeqNQbffOptnRO0(0, Canvas.Start) - 1;
					stop = Canvas.Stop;
					list = new List<Point>(Math.Max(num3 - stop, 5));
					num4 = num3;
					goto IL_00ba;
				}
				IL_008b:
				num4--;
				goto IL_00ba;
				IL_00ba:
				if (num4 < stop)
				{
					array2 = list.ToArray();
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto default;
			}
			array = array3;
			num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
			{
				num2 = 1;
			}
		}
	}

	public virtual IndicatorTitleInfo GetTitle()
	{
		return new IndicatorTitleInfo(Title, Canvas.Theme.ChartFontBrush);
	}

	public virtual List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		foreach (IndicatorSeriesData item in Series)
		{
			if (!item.Style.DisableValue && cursorPos >= 0 && cursorPos < item.Length)
			{
				string text = "";
				if (!string.IsNullOrEmpty(item.Style.Name))
				{
					text = item.Style.Name + yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-673683647 ^ -673659151);
				}
				text += Canvas.FormatValue(item[cursorPos]);
				list.Add(new IndicatorValueInfo(text, new XBrush(item.Style.Color)));
			}
		}
		return list;
	}

	public virtual void GetLabels(ref List<IndicatorLabelInfo> labels)
	{
		using (List<ChartLevel>.Enumerator enumerator = Levels.GetEnumerator())
		{
			while (true)
			{
				if (!enumerator.MoveNext())
				{
					int num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num = 1;
					}
					switch (num)
					{
					case 1:
						goto end_IL_04bb;
					}
				}
				ChartLevel current = enumerator.Current;
				if (current.Visible)
				{
					labels.Add(new IndicatorLabelInfo((double)rOxDe4eq1QBv0MJHhbQX(current), current.Color));
				}
				continue;
				end_IL_04bb:
				break;
			}
		}
		IEnumerator<IndicatorSeriesData> enumerator2 = Series.GetEnumerator();
		int num2 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		}
		try
		{
			int num5 = default(int);
			int num6 = default(int);
			double num4 = default(double);
			ChartSeriesColorSplit colorSplit = default(ChartSeriesColorSplit);
			int num7 = default(int);
			int num8 = default(int);
			bool flag = default(bool);
			while (enumerator2.MoveNext())
			{
				while (true)
				{
					IL_0268:
					IndicatorSeriesData current2 = enumerator2.Current;
					if (current2.Style.DisableLabel)
					{
						break;
					}
					int num3 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 13:
							if (num5 >= 0)
							{
								goto case 15;
							}
							goto case 7;
						case 2:
							break;
						case 10:
							goto IL_00d0;
						default:
							goto end_IL_004d;
						case 1:
							goto IL_0152;
						case 15:
							if (!rfytAKeqkmQ8l5e3u5c7(current2[num5]))
							{
								num3 = 4;
								continue;
							}
							num5--;
							goto case 13;
						case 4:
							num6 = num5;
							num3 = 2;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db78327036c6481694d84ff5ec56fd0d != 0)
							{
								num3 = 7;
							}
							continue;
						case 11:
							goto IL_0268;
						case 7:
							num4 = q5MQc0eqxcEDbpaHEu20(current2, num6);
							colorSplit = ((IndicatorSeriesStyle)REyNCreq4U053JLdvFA0(current2)).ColorSplit;
							num3 = 2;
							continue;
						case 6:
							goto IL_02b5;
						case 12:
							if (knpNO8eq5NFdQY50EVHg(current2) > num7 + num8)
							{
								num3 = 14;
								continue;
							}
							goto end_IL_004d;
						case 5:
							num6 = knpNO8eq5NFdQY50EVHg(current2) - 1 - Math.Max(num8 - Canvas.AfterBars, 0);
							goto IL_023c;
						case 3:
							num7 = Math.Max(0, Canvas.Start);
							num8 = Math.Max(0, current2.Length - Dia5TQeqo5C0FIRVSwup(Helper.DataProvider));
							num3 = 12;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
							{
								num3 = 5;
							}
							continue;
						case 14:
							num6 = current2.Length - 1 - (num7 + num8);
							if (iZJVojeqSLon9UnFcLnQ(Canvas) > 0 && num8 > 0)
							{
								num3 = 5;
								continue;
							}
							goto IL_023c;
						case 9:
							{
								labels.Add(new IndicatorLabelInfo(num4, flag ? current2.Style.Color : current2.Style.Color2));
								num3 = 6;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa != 0)
								{
									num3 = 8;
								}
								continue;
							}
							IL_023c:
							num5 = num6;
							num3 = 13;
							continue;
						}
						if (colorSplit != ChartSeriesColorSplit.UpDown)
						{
							if (colorSplit != ChartSeriesColorSplit.UpDownZero)
							{
								labels.Add(new IndicatorLabelInfo(num4, current2.Style.Color));
								num3 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto IL_0152;
						}
						if (!double.IsNaN(num4))
						{
							num3 = 10;
							continue;
						}
						goto IL_0368;
						IL_02b5:
						if (num6 <= 0)
						{
							goto IL_03e0;
						}
						int num9 = ((num4 > 0.0) ? 1 : 0);
						goto IL_03e1;
						IL_0368:
						int num10 = 0;
						goto IL_0369;
						IL_00d0:
						if (num6 <= 0)
						{
							goto IL_0368;
						}
						num10 = ((current2[num6 - 1] < num4) ? 1 : 0);
						goto IL_0369;
						IL_0369:
						flag = (byte)num10 != 0;
						num3 = 5;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
						{
							num3 = 9;
						}
						continue;
						IL_03e1:
						bool flag2 = (byte)num9 != 0;
						labels.Add(new IndicatorLabelInfo(num4, flag2 ? ((IndicatorSeriesStyle)REyNCreq4U053JLdvFA0(current2)).Color : ((IndicatorSeriesStyle)REyNCreq4U053JLdvFA0(current2)).Color2));
						break;
						IL_0152:
						if (!double.IsNaN(num4))
						{
							int num11 = 6;
							num3 = num11;
							continue;
						}
						goto IL_03e0;
						IL_03e0:
						num9 = 0;
						goto IL_03e1;
						continue;
						end_IL_004d:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			enumerator2?.Dispose();
		}
	}

	public virtual void Render(DxVisualQueue visual)
	{
	}

	public virtual void RenderCursor(DxVisualQueue visual, int cursorPos, Point cursorCenter, ref int leftPos)
	{
	}

	public virtual bool CheckAlert(double value, int distance, ref int lastIndex, ref double lastValue)
	{
		return false;
	}

	protected void AddAlert(ChartAlertSettings settings, string message)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (_alerts == null)
				{
					_alerts = new List<ChartAlertInfo>();
				}
				_alerts.Add(new ChartAlertInfo(settings, message));
				return;
			case 1:
				KZSgxXeqLiR2nIl0XWkq(settings, false);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (settings.Execution == ChartAlertExecution.OnlyOnce)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public List<ChartAlertInfo> GetAlerts()
	{
		if (_alerts == null)
		{
			_alerts = new List<ChartAlertInfo>();
		}
		List<ChartAlertInfo> result = _alerts.ToList();
		_alerts.Clear();
		return result;
	}

	public virtual void ApplyColors(IChartTheme palette)
	{
		if (Levels.Count == 0)
		{
			return;
		}
		XColor color = oerZW5eqexYJulJ3SLok(palette);
		List<ChartLevel>.Enumerator enumerator = Levels.GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.Color = color;
			}
		}
		finally
		{
			((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
		}
	}

	public virtual void CopyTemplate(IndicatorBase indicator, bool style)
	{
		if (indicator == null)
		{
			return;
		}
		Levels.Clear();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
		{
			num = 1;
		}
		List<ChartLevel>.Enumerator enumerator = default(List<ChartLevel>.Enumerator);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				ShowIndicatorValues = rkO30feqXyV52SASdjhu(indicator);
				ShowIndicatorLabels = indicator.ShowIndicatorLabels;
				sJ9QBxeqjMulCXwdBKNe(this, mY0c4meqcwghL9TexGSG(indicator));
				return;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						ChartLevel current;
						while (true)
						{
							current = enumerator.Current;
							int num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
							{
								num2 = 0;
							}
							switch (num2)
							{
							case 1:
								continue;
							}
							break;
						}
						ChartLevel chartLevel = new ChartLevel(0m, Colors.Black);
						LlIGkkeqsR9NopD8Xpua(chartLevel, current);
						Levels.Add(chartLevel);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				ShowIndicatorTitle = indicator.ShowIndicatorTitle;
				num = 2;
				break;
			case 1:
				enumerator = indicator.Levels.GetEnumerator();
				num = 3;
				break;
			}
		}
	}

	public override string ToString()
	{
		return Name;
	}

	public virtual object Clone()
	{
		return MemberwiseClone();
	}

	public virtual bool CheckNeedRedraw()
	{
		return false;
	}

	public virtual void SetSettingsParam(string name, object param)
	{
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		_propChanged = true;
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler == null)
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			nI9J7AeqE4xk5vlGRXGH(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public virtual bool GetPropertyVisibility(string propertyName)
	{
		return true;
	}

	public virtual bool GetPropertyHasStandardValues(string propertyName)
	{
		if (eN2CCDeqQKilK8l9cHU0(propertyName, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-530053095 ^ -530012833)))
		{
			return true;
		}
		return false;
	}

	public virtual bool GetPropertyReadOnly(string propertyName)
	{
		return false;
	}

	public virtual IEnumerable<object> GetPropertyStandardValues(string propertyName)
	{
		if (propertyName == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xC1DDB3B ^ 0xC1D767D))
		{
			return Panels;
		}
		return null;
	}

	public void PropChanged()
	{
		_propChanged = true;
	}

	[OnDeserializing]
	private void SetValuesOnDeserializing(StreamingContext context)
	{
		CopyTemplate((IndicatorBase)Activator.CreateInstance(aJQDWBeqdGB3saFg92mW(this)), style: false);
	}

	static IndicatorBase()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool hFGZUgeq0YfSyv113Uv4()
	{
		return rbuGbLeOzhFeYrI35Hoo == null;
	}

	internal static IndicatorBase AFLngdeq2PZe5mFunDn5()
	{
		return rbuGbLeOzhFeYrI35Hoo;
	}

	internal static bool cMt4JueqHkPqNEYyeE37(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Type uhUrGUeqfpYFHTfZKrd6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object W6QGkieq9T3BhYU9VctP(object P_0, Type P_1)
	{
		return Attribute.GetCustomAttribute((MemberInfo)P_0, P_1);
	}

	internal static object guwf8weqnvLU9Odt8Jyq(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object UMG4sLeqGLjuGGqFJTUY(object P_0)
	{
		return ((IndicatorAttribute)P_0).ID;
	}

	internal static void HiS7poeqYF38BaTIkCPE(object P_0, object P_1)
	{
		((IndicatorsHelper)P_0).SetDataProvider((IChartDataProvider)P_1);
	}

	internal static int Dia5TQeqo5C0FIRVSwup(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static long XN1ywieqvBMbvkWOJjui(object P_0)
	{
		return ((IRawCluster)P_0).Close;
	}

	internal static void cWujUpeqBAdIWCJiMkOv(object P_0)
	{
		((IndicatorSeries)P_0).Clear();
	}

	internal static double Su7EqOeqaXHtWTaRuYYN(object P_0, double d)
	{
		return ((IChartCanvas)P_0).GetY(d);
	}

	internal static double Qy9ZFVeqiY3dfEeY3SnC(decimal P_0)
	{
		return (double)P_0;
	}

	internal static int B48evMeqlki0uuGbSoQY(object P_0)
	{
		return ((IChartCanvas)P_0).Start;
	}

	internal static object REyNCreq4U053JLdvFA0(object P_0)
	{
		return ((IndicatorSeriesData)P_0).Style;
	}

	internal static bool w7bhuteqDxcuyKoPCmiW(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void B5KBXZeqbBqh3GBkUuxr(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int B4IkDTeqNQbffOptnRO0(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool rfytAKeqkmQ8l5e3u5c7(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static decimal rOxDe4eq1QBv0MJHhbQX(object P_0)
	{
		return ((ChartLevel)P_0).Level;
	}

	internal static int knpNO8eq5NFdQY50EVHg(object P_0)
	{
		return ((IndicatorSeriesData)P_0).Length;
	}

	internal static int iZJVojeqSLon9UnFcLnQ(object P_0)
	{
		return ((IChartCanvas)P_0).AfterBars;
	}

	internal static double q5MQc0eqxcEDbpaHEu20(object P_0, int n)
	{
		return ((IndicatorSeriesData)P_0)[n];
	}

	internal static void KZSgxXeqLiR2nIl0XWkq(object P_0, bool value)
	{
		((ChartAlertSettings)P_0).Active = value;
	}

	internal static XColor oerZW5eqexYJulJ3SLok(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void LlIGkkeqsR9NopD8Xpua(object P_0, object P_1)
	{
		((ChartLevel)P_0).CopyTheme((ChartLevel)P_1);
	}

	internal static bool rkO30feqXyV52SASdjhu(object P_0)
	{
		return ((IndicatorBase)P_0).ShowIndicatorValues;
	}

	internal static IndicatorCalculation mY0c4meqcwghL9TexGSG(object P_0)
	{
		return ((IndicatorBase)P_0).Calculation;
	}

	internal static void sJ9QBxeqjMulCXwdBKNe(object P_0, IndicatorCalculation value)
	{
		((IndicatorBase)P_0).Calculation = value;
	}

	internal static void nI9J7AeqE4xk5vlGRXGH(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static bool eN2CCDeqQKilK8l9cHU0(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type aJQDWBeqdGB3saFg92mW(object P_0)
	{
		return P_0.GetType();
	}
}
