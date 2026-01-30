using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Annotations;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Core.UI.Common;
using TigerTrade.Parts.HotKeys;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.Chart.Base;

[DataContract(Name = "DataCycle", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
internal sealed class DataCycle : IChartPeriod, ICloneable, INotifyPropertyChanged, IDynamicProperty
{
	[CompilerGenerated]
	private sealed class aC7w4OG0Fh7rnUYAZexZ : IEnumerable<DataCycleBase>, IEnumerable, IEnumerator<DataCycleBase>, IDisposable, IEnumerator
	{
		private int d1EG036c28c;

		private DataCycleBase MXIG0po9ExB;

		private int neKG0uxcSiO;

		internal static aC7w4OG0Fh7rnUYAZexZ JZy6jZNTOywNejbRBoJt;

		DataCycleBase IEnumerator<DataCycleBase>.Current
		{
			[DebuggerHidden]
			get
			{
				return MXIG0po9ExB;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MXIG0po9ExB;
			}
		}

		[DebuggerHidden]
		public aC7w4OG0Fh7rnUYAZexZ(int _003C_003E1__state)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			d1EG036c28c = _003C_003E1__state;
			neKG0uxcSiO = Environment.CurrentManagedThreadId;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = 4;
			int num3 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						return false;
					default:
						d1EG036c28c = 11;
						return true;
					case 10:
						return true;
					case 5:
						MXIG0po9ExB = DataCycleBase.Volume;
						d1EG036c28c = 9;
						return true;
					case 15:
						return true;
					case 4:
						num3 = d1EG036c28c;
						num2 = 3;
						continue;
					case 16:
						MXIG0po9ExB = DataCycleBase.Range;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
						{
							num2 = 0;
						}
						continue;
					case 17:
						MXIG0po9ExB = DataCycleBase.Week;
						d1EG036c28c = 5;
						return true;
					case 12:
						return false;
					case 7:
						d1EG036c28c = 10;
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
						{
							num2 = 11;
						}
						continue;
					case 9:
						MXIG0po9ExB = DataCycleBase.Renko;
						d1EG036c28c = 12;
						num2 = 13;
						continue;
					case 14:
						MXIG0po9ExB = DataCycleBase.Reversal;
						d1EG036c28c = 13;
						return true;
					case 11:
						return true;
					case 1:
						d1EG036c28c = 3;
						return true;
					case 2:
						MXIG0po9ExB = DataCycleBase.Delta;
						num2 = 6;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
						{
							num2 = 7;
						}
						continue;
					case 3:
						switch (num3)
						{
						case 9:
							d1EG036c28c = -1;
							num2 = 2;
							continue;
						case 8:
							d1EG036c28c = -1;
							num2 = 5;
							continue;
						case 1:
							d1EG036c28c = -1;
							MXIG0po9ExB = DataCycleBase.Minute;
							d1EG036c28c = 2;
							return true;
						case 4:
							d1EG036c28c = -1;
							num2 = 17;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
							{
								num2 = 0;
							}
							continue;
						case 0:
							d1EG036c28c = -1;
							MXIG0po9ExB = DataCycleBase.Second;
							d1EG036c28c = 1;
							num2 = 10;
							continue;
						case 10:
							d1EG036c28c = -1;
							num2 = 16;
							continue;
						case 3:
							d1EG036c28c = -1;
							MXIG0po9ExB = DataCycleBase.Day;
							d1EG036c28c = 4;
							num2 = 15;
							continue;
						case 13:
							d1EG036c28c = -1;
							num2 = 6;
							continue;
						case 2:
							d1EG036c28c = -1;
							MXIG0po9ExB = DataCycleBase.Hour;
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
							{
								num2 = 1;
							}
							continue;
						case 11:
							d1EG036c28c = -1;
							num2 = 9;
							continue;
						case 6:
							d1EG036c28c = -1;
							num2 = 18;
							continue;
						case 5:
							d1EG036c28c = -1;
							MXIG0po9ExB = DataCycleBase.Month;
							d1EG036c28c = 6;
							return true;
						default:
							num2 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
							{
								num2 = 12;
							}
							continue;
						case 7:
							d1EG036c28c = -1;
							MXIG0po9ExB = DataCycleBase.Tick;
							d1EG036c28c = 8;
							return true;
						case 12:
							break;
						}
						d1EG036c28c = -1;
						num = 14;
						break;
					case 8:
						return true;
					case 13:
						return true;
					case 18:
						MXIG0po9ExB = DataCycleBase.Year;
						d1EG036c28c = 7;
						num = 8;
						break;
					}
					break;
				}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<DataCycleBase> IEnumerable<DataCycleBase>.GetEnumerator()
		{
			if (d1EG036c28c == -2 && neKG0uxcSiO == Environment.CurrentManagedThreadId)
			{
				d1EG036c28c = 0;
				return this;
			}
			return new aC7w4OG0Fh7rnUYAZexZ(0);
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DataCycleBase>)this).GetEnumerator();
		}

		static aC7w4OG0Fh7rnUYAZexZ()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool bMrRNsNTqPAyh8BGQpvu()
		{
			return JZy6jZNTOywNejbRBoJt == null;
		}

		internal static aC7w4OG0Fh7rnUYAZexZ anJJ12NTItM1326R7ORJ()
		{
			return JZy6jZNTOywNejbRBoJt;
		}
	}

	[CompilerGenerated]
	private sealed class JMjuRJG0zYi8uSQthYAk : IEnumerable<DataCycleDataType>, IEnumerable, IEnumerator<DataCycleDataType>, IDisposable, IEnumerator
	{
		private int DpDG206lral;

		private DataCycleDataType VI2G22YEaKy;

		private int pemG2HiXRTR;

		private static JMjuRJG0zYi8uSQthYAk zRw0LVNTWIV71VQSTPbv;

		DataCycleDataType IEnumerator<DataCycleDataType>.Current
		{
			[DebuggerHidden]
			get
			{
				return VI2G22YEaKy;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return VI2G22YEaKy;
			}
		}

		[DebuggerHidden]
		public JMjuRJG0zYi8uSQthYAk(int _003C_003E1__state)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			DpDG206lral = _003C_003E1__state;
			pemG2HiXRTR = vyLrnVNTT6wSpprgpEEi();
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 4:
					VI2G22YEaKy = DataCycleDataType.Clusters;
					DpDG206lral = 1;
					return true;
				case 2:
					VI2G22YEaKy = DataCycleDataType.ExtendedBars;
					DpDG206lral = 2;
					return true;
				case 1:
					num3 = DpDG206lral;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return false;
				}
				switch (num3)
				{
				case 1:
					DpDG206lral = -1;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					DpDG206lral = -1;
					return false;
				default:
					num2 = 3;
					break;
				case 0:
					DpDG206lral = -1;
					num2 = 4;
					break;
				}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<DataCycleDataType> IEnumerable<DataCycleDataType>.GetEnumerator()
		{
			if (DpDG206lral == -2 && pemG2HiXRTR == Environment.CurrentManagedThreadId)
			{
				DpDG206lral = 0;
				return this;
			}
			return new JMjuRJG0zYi8uSQthYAk(0);
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<DataCycleDataType>)this).GetEnumerator();
		}

		static JMjuRJG0zYi8uSQthYAk()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static int vyLrnVNTT6wSpprgpEEi()
		{
			return Environment.CurrentManagedThreadId;
		}

		internal static bool Xhec0nNTt0Xo6W6yAh8R()
		{
			return zRw0LVNTWIV71VQSTPbv == null;
		}

		internal static JMjuRJG0zYi8uSQthYAk Vg6WWlNTUSQnIFwl3dXV()
		{
			return zRw0LVNTWIV71VQSTPbv;
		}
	}

	private DataCycleBase _cycleBase;

	private int _repeat;

	private int _repeatParam1;

	private int _repeatParam2;

	private int? _daysToLoadChart;

	private int? _daysToLoadDom;

	private DateTime? _startDate;

	private DateTime? _endDate;

	private PeriodHotKey _hotKey;

	private DataCycleDataType _dataType;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static DataCycle KnyguwbJXJ3a97qIETx9;

	[DefaultValue(DataCycleBase.Minute)]
	[DataMember(Name = "Name")]
	[T4IXj62qBfXCaxs2RI5("DataCyclePeriod")]
	[bBo0Zd2ycQQr3LNHQf4("DataCycleBase")]
	public DataCycleBase CycleBase
	{
		get
		{
			return _cycleBase;
		}
		set
		{
			if (value == _cycleBase)
			{
				return;
			}
			_cycleBase = value;
			OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x735394DD));
			OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42DC18F7));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged((string)koLGArbJEOaQvkgNiBxn(-1346994499 ^ -1347223607));
					return;
				}
				OnPropertyChanged((string)koLGArbJEOaQvkgNiBxn(0x28C965BE ^ 0x28CDE4E6));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num = 0;
				}
			}
		}
	}

	[DefaultValue(1)]
	[T4IXj62qBfXCaxs2RI5("DataCyclePeriod")]
	[DataMember(Name = "Repeat")]
	[bBo0Zd2ycQQr3LNHQf4("DataCycleRepeat")]
	public int Repeat
	{
		get
		{
			return _repeat;
		}
		set
		{
			value = iICFRTbJQ5LyS19iNDD8(value, 1);
			int num;
			if (value == _repeat)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
				{
					num = 1;
				}
			}
			else
			{
				_repeat = value;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			case 1:
				return;
			}
			OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774372453));
			OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404A51FC));
		}
	}

	[T4IXj62qBfXCaxs2RI5("DataCyclePeriod")]
	[bBo0Zd2ycQQr3LNHQf4("DataCycleRepeatParam1")]
	[DataMember(Name = "RepeatParam1")]
	[DefaultValue(1)]
	public int RepeatParam1
	{
		get
		{
			return _repeatParam1;
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
				case 0:
					return;
				case 2:
					value = iICFRTbJQ5LyS19iNDD8(value, 1);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (value != _repeatParam1)
					{
						_repeatParam1 = value;
						OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673389031));
						OnPropertyChanged((string)koLGArbJEOaQvkgNiBxn(-45476899 ^ -45182305));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("DataCyclePeriod")]
	[DefaultValue(1)]
	[bBo0Zd2ycQQr3LNHQf4("DataCycleRepeatParam2")]
	[DataMember(Name = "RepeatParam2")]
	public int RepeatParam2
	{
		get
		{
			return _repeatParam2;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					value = Math.Max(value, 1);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (value == _repeatParam2)
					{
						return;
					}
					_repeatParam2 = value;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799805701));
					OnPropertyChanged((string)koLGArbJEOaQvkgNiBxn(0x78D396D8 ^ 0x78D7179A));
					return;
				}
			}
		}
	}

	[DefaultValue(null)]
	[DataMember(Name = "DaysToLoadChart")]
	[bBo0Zd2ycQQr3LNHQf4("DataCycleDaysToLoadChart")]
	[T4IXj62qBfXCaxs2RI5("DataCycleDaysToLoad")]
	public int? DaysToLoadChart
	{
		get
		{
			return _daysToLoadChart;
		}
		set
		{
			if (value != _daysToLoadChart)
			{
				if (TryGetMaxDaysToLoad(out var maxDaysToLoad) && value.HasValue && value > maxDaysToLoad)
				{
					value = maxDaysToLoad;
				}
				_daysToLoadChart = value;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADF7731));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("DataCycleDaysToLoadDom")]
	[T4IXj62qBfXCaxs2RI5("DataCycleDaysToLoad")]
	[DataMember(Name = "DaysToLoadCluster")]
	[DefaultValue(null)]
	public int? DaysToLoadDom
	{
		get
		{
			return _daysToLoadDom;
		}
		set
		{
			if (value != _daysToLoadDom)
			{
				if (TryGetMaxDaysToLoad(out var maxDaysToLoad) && value.HasValue && value > maxDaysToLoad)
				{
					value = maxDaysToLoad;
				}
				_daysToLoadDom = value;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999944868));
			}
		}
	}

	[Browsable(false)]
	[DataMember(Name = "StartDate")]
	public DateTime? StartDate
	{
		get
		{
			return _startDate;
		}
		set
		{
			if (!(value == _startDate))
			{
				_startDate = value;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461305761));
			}
		}
	}

	[Browsable(false)]
	[DataMember(Name = "EndDate")]
	public DateTime? EndDate
	{
		get
		{
			return _endDate;
		}
		set
		{
			if (!(value == _endDate))
			{
				_endDate = value;
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325217789));
			}
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("DataCycleHotKey")]
	[T4IXj62qBfXCaxs2RI5("DataCyclePeriod")]
	[DefaultValue(PeriodHotKey.None)]
	[DataMember(Name = "HotKey")]
	public PeriodHotKey HotKey
	{
		get
		{
			return _hotKey;
		}
		set
		{
			if (value != _hotKey)
			{
				_hotKey = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)koLGArbJEOaQvkgNiBxn(0x2CBEEA31 ^ 0x2CBD1D29));
			}
		}
	}

	[Browsable(false)]
	[DataMember(Name = "DataType")]
	public DataCycleDataType DataType
	{
		get
		{
			return _dataType;
		}
		set
		{
			if (value != _dataType)
			{
				_dataType = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799805841));
			}
		}
	}

	[Browsable(false)]
	public string ShortName
	{
		get
		{
			switch (CycleBase)
			{
			case DataCycleBase.Volume:
			case DataCycleBase.Delta:
			case DataCycleBase.Range:
			case DataCycleBase.Renko:
				return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD41C3), Repeat, CycleBase);
			case DataCycleBase.Reversal:
				return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-377195341 ^ -377424159), Repeat, RepeatParam1, CycleBase);
			case DataCycleBase.Second:
				return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671433253), Repeat);
			case DataCycleBase.Minute:
				return string.Format((string)koLGArbJEOaQvkgNiBxn(0x7DB10E6E ^ 0x7DB58F64), Repeat);
			case DataCycleBase.Hour:
				return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017108630), Repeat);
			case DataCycleBase.Day:
				return (string)BJwxO3bJdRUJgYfVTrCb(koLGArbJEOaQvkgNiBxn(-1380525184 ^ -1380820596), Repeat);
			case DataCycleBase.Week:
				return string.Format((string)koLGArbJEOaQvkgNiBxn(0x7F55E538 ^ 0x7F516720), Repeat);
			case DataCycleBase.Month:
				return string.Format((string)koLGArbJEOaQvkgNiBxn(-1461292091 ^ -1461521951), Repeat);
			case DataCycleBase.Year:
				return string.Format((string)koLGArbJEOaQvkgNiBxn(-1311293279 ^ -1311522157), Repeat);
			case DataCycleBase.Tick:
				if (Repeat != 1)
				{
					return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42DC1B8B), Repeat);
				}
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690530527);
			default:
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710435120), 
				};
			}
			}
		}
	}

	[Browsable(false)]
	public string ShortBase
	{
		get
		{
			switch (CycleBase)
			{
			default:
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B1B356), 
				};
			}
			case DataCycleBase.Second:
				return (string)koLGArbJEOaQvkgNiBxn(--146713930 ^ 0x8BFBAC4);
			case DataCycleBase.Minute:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x404ED0BE ^ 0x404FC7CE);
			case DataCycleBase.Hour:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746FC357);
			case DataCycleBase.Day:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x735602CB);
			case DataCycleBase.Week:
				return (string)koLGArbJEOaQvkgNiBxn(-1380525184 ^ -1380463578);
			case DataCycleBase.Month:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774372249);
			case DataCycleBase.Year:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123846625);
			case DataCycleBase.Tick:
				return (string)koLGArbJEOaQvkgNiBxn(0x706541F3 ^ 0x70645667);
			case DataCycleBase.Volume:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -5906843);
			case DataCycleBase.Delta:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315E3397);
			case DataCycleBase.Range:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127718744);
			case DataCycleBase.Renko:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108232424);
			case DataCycleBase.Reversal:
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7BF1C7);
			}
		}
	}

	public static DataCycle Minute => new DataCycle(DataCycleBase.Minute, 1);

	public static DataCycle Day => new DataCycle(DataCycleBase.Day, 1);

	[Browsable(false)]
	public ChartPeriodType Type => (ChartPeriodType)CycleBase;

	[Browsable(false)]
	public int Interval => Repeat;

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
				case 2:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto default;
				default:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 0;
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
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto default;
				}
			}
		}
	}

	private bool TryGetMaxDaysToLoad(out int maxDaysToLoad)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					return false;
				case 5:
				case 6:
				case 9:
				case 10:
					return true;
				case 3:
					return true;
				case 14:
					maxDaysToLoad = 10;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
					{
						num2 = 4;
					}
					break;
				case 8:
					maxDaysToLoad = 10;
					num2 = 6;
					break;
				case 2:
					if (Repeat > 0)
					{
						switch (CycleBase)
						{
						case DataCycleBase.Range:
						case DataCycleBase.Renko:
						case DataCycleBase.Reversal:
							goto IL_00f9;
						case DataCycleBase.Tick:
						case DataCycleBase.Volume:
						case DataCycleBase.Delta:
							goto IL_0130;
						case DataCycleBase.Hour:
							maxDaysToLoad = 360;
							return true;
						case DataCycleBase.Day:
						case DataCycleBase.Week:
						case DataCycleBase.Month:
						case DataCycleBase.Year:
							goto IL_01f6;
						case DataCycleBase.Minute:
							maxDaysToLoad = 180;
							return true;
						case DataCycleBase.Second:
							maxDaysToLoad = 15;
							return true;
						}
						num2 = 7;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num2 = 1;
						}
					}
					break;
				default:
					if (Repeat < 5)
					{
						maxDaysToLoad = 5;
						goto case 4;
					}
					if (Repeat < 10)
					{
						num2 = 14;
						break;
					}
					goto case 15;
				case 15:
					maxDaysToLoad = 20;
					goto case 4;
				case 11:
					maxDaysToLoad = 0;
					goto case 5;
				case 13:
					if (Repeat < 1000)
					{
						goto end_IL_0012;
					}
					maxDaysToLoad = 30;
					num2 = 10;
					break;
				case 1:
					maxDaysToLoad = -1;
					num2 = 12;
					break;
				case 4:
					return true;
				case 7:
					{
						maxDaysToLoad = -1;
						return false;
					}
					IL_00f9:
					if (Repeat >= 2)
					{
						goto default;
					}
					maxDaysToLoad = 0;
					goto case 4;
					IL_01f6:
					maxDaysToLoad = 1440;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num2 = 3;
					}
					break;
					IL_0130:
					if (Repeat < 5)
					{
						num2 = 11;
						break;
					}
					if (Repeat < 50)
					{
						maxDaysToLoad = 5;
						num2 = 9;
						break;
					}
					if (Repeat < 100)
					{
						num2 = 8;
						break;
					}
					goto case 13;
				}
				continue;
				end_IL_0012:
				break;
			}
			maxDaysToLoad = 20;
			num = 5;
		}
	}

	public DataCycle()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		this._002Ector(DataCycleBase.Minute, 1);
	}

	public DataCycle(DataCycleBase cycleBase, int repeat)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		CycleBase = cycleBase;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Repeat = repeat;
				RepeatParam1 = 0;
				RepeatParam2 = 0;
				num = 3;
				break;
			case 2:
				HotKey = PeriodHotKey.None;
				DataType = DataCycleDataType.ExtendedBars;
				return;
			case 3:
				DaysToLoadChart = null;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
				{
					num = 1;
				}
				break;
			case 1:
				DaysToLoadDom = null;
				num = 2;
				break;
			}
		}
	}

	public DataCycle(DataCycle dataCycle)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Copy(dataCycle);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[IteratorStateMachine(typeof(aC7w4OG0Fh7rnUYAZexZ))]
	public static IEnumerable<DataCycleBase> CycleBaseList()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new aC7w4OG0Fh7rnUYAZexZ(-2);
	}

	[IteratorStateMachine(typeof(JMjuRJG0zYi8uSQthYAk))]
	public static IEnumerable<DataCycleDataType> DataTypeList()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new JMjuRJG0zYi8uSQthYAk(-2);
	}

	private static int GetSequence(DataCycleBase cycleBase, int repeat, double d)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (cycleBase)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num2 = 0;
					}
					break;
				case DataCycleBase.Second:
					return (int)(((double)((int)d % 100) + d - (double)(int)d) * 24.0 * 3600.0 / (double)repeat + 0.001);
				case DataCycleBase.Minute:
					return (int)(d * 24.0 * 60.0 / (double)repeat + 0.001);
				case DataCycleBase.Hour:
					return (int)(d * 24.0 / (double)repeat + 0.001);
				case DataCycleBase.Day:
					return (int)d / repeat;
				case DataCycleBase.Week:
					return (int)(d - 2.0) / 7 / repeat;
				case DataCycleBase.Month:
				{
					DateTime dateTime = DateTime.FromOADate(d);
					return (dateTime.Year * 12 + dateTime.Month - 1) / repeat;
				}
				case DataCycleBase.Year:
					return DateTime.FromOADate(d).Year / repeat;
				}
				break;
			default:
				return 0;
			}
		}
	}

	public static int GetSequence(DataCycleBase cycleBase, int repeat, DateTime d, double offset)
	{
		return c6xGMJbJgKFcQ6Qr9foj(cycleBase, repeat, d.ToOADate() + offset);
	}

	public static int GetSequence(DataCycleBase cycleBase, int repeat, double d, double offset)
	{
		return GetSequence(cycleBase, repeat, d + offset);
	}

	public int GetSequence(DateTime date, double offset)
	{
		return GetSequence(date.ToOADate(), offset);
	}

	public int GetSequence(double d, double offset)
	{
		return c6xGMJbJgKFcQ6Qr9foj(CycleBase, Repeat, d + offset);
	}

	public int GetTimeSequence()
	{
		switch (CycleBase)
		{
		case DataCycleBase.Second:
			return Math.Min(86400, Repeat);
		case DataCycleBase.Minute:
			return Math.Min(3600, Repeat) * 60;
		case DataCycleBase.Hour:
			return Math.Min(24, Repeat) * 60 * 60;
		case DataCycleBase.Day:
		case DataCycleBase.Week:
		case DataCycleBase.Month:
		case DataCycleBase.Year:
			return 86400;
		default:
			return 60;
		}
	}

	public static DateTime GetSequenceTime(DataCycleBase cycleBase, int repeat, int s, double offset)
	{
		return cycleBase switch
		{
			DataCycleBase.Second => imhjukbJRpjeDbNYwQDF((double)s / 24.0 / 3600.0 - offset), 
			DataCycleBase.Minute => DateTime.FromOADate((double)s / 24.0 / 60.0 - offset), 
			DataCycleBase.Hour => imhjukbJRpjeDbNYwQDF((double)s / 24.0 - offset), 
			DataCycleBase.Day => imhjukbJRpjeDbNYwQDF((double)s - offset), 
			DataCycleBase.Week => DateTime.FromOADate((double)s * 7.0 - offset), 
			_ => DateTime.MinValue, 
		};
	}

	public override bool Equals(object obj)
	{
		int num = 1;
		DataCycle dataCycle = default(DataCycle);
		DateTime? dateTime2 = default(DateTime?);
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					if (E10T5EbJ6pV0pJNXEJuH(dataCycle) == CycleBase)
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				default:
					return false;
				case 2:
					dateTime2 = EndDate;
					num2 = 5;
					continue;
				case 5:
					if (dateTime.HasValue == dateTime2.HasValue)
					{
						if (!dateTime.HasValue)
						{
							goto end_IL_0012;
						}
						if (dateTime.GetValueOrDefault() == dateTime2.GetValueOrDefault())
						{
							break;
						}
					}
					goto case 3;
				case 7:
					dateTime = dataCycle.EndDate;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					return TgkwcUbJOuFjMQlXRmbN(dataCycle) == DataType;
				case 3:
				case 11:
					return false;
				case 8:
					if (dataCycle.Repeat != Repeat || dataCycle.RepeatParam1 != RepeatParam1 || SeZq2JbJMSZuxMOlyAPX(dataCycle) != RepeatParam2)
					{
						goto case 3;
					}
					if (dataCycle.DaysToLoadChart != DaysToLoadChart)
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 6;
				case 6:
					if (dataCycle.DaysToLoadDom == DaysToLoadDom)
					{
						dateTime2 = dataCycle.StartDate;
						num2 = 9;
						continue;
					}
					goto case 3;
				case 1:
					if (obj is DataCycle)
					{
						dataCycle = (DataCycle)obj;
						num2 = 12;
						continue;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					dateTime = StartDate;
					if (dateTime2.HasValue == dateTime.HasValue)
					{
						if (!dateTime2.HasValue)
						{
							num2 = 7;
							continue;
						}
						if (dateTime2.GetValueOrDefault() == dateTime.GetValueOrDefault())
						{
							goto case 7;
						}
						goto case 3;
					}
					num2 = 11;
					continue;
				case 4:
					break;
				}
				num2 = 10;
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public bool Equals(DataCycle dc)
	{
		if (dc != null)
		{
			if (dc.CycleBase != CycleBase || dc.Repeat != Repeat || dc.RepeatParam1 != RepeatParam1 || dc.RepeatParam2 != RepeatParam2)
			{
				goto IL_009d;
			}
			int num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
			{
				num = 1;
			}
			int? num2 = default(int?);
			int? num3 = default(int?);
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				case 3:
					return num2 == num3;
				case 2:
					goto IL_00b1;
				default:
					num2 = dc.DaysToLoadDom;
					num3 = DaysToLoadDom;
					num = 3;
					continue;
				}
				break;
				IL_00b1:
				num3 = dc.DaysToLoadChart;
				num2 = DaysToLoadChart;
				if (num3 == num2)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto IL_009d;
			}
		}
		return false;
		IL_009d:
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	public override string ToString()
	{
		return ShortName;
	}

	[NotifyPropertyChangedInvocator]
	private void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public void Copy(DataCycle dataCycle)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					break;
				case 1:
					DataType = dataCycle.DataType;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					CycleBase = E10T5EbJ6pV0pJNXEJuH(dataCycle);
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					DaysToLoadChart = dataCycle.DaysToLoadChart;
					DaysToLoadDom = dataCycle.DaysToLoadDom;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				}
				break;
			}
			Repeat = Q6g3SYbJqkKderehj9EX(dataCycle);
			RepeatParam1 = EZuZ1tbJI7tpFpB4MUgL(dataCycle);
			RepeatParam2 = dataCycle.RepeatParam2;
			StartDate = dataCycle.StartDate;
			EndDate = dataCycle.EndDate;
			num = 2;
		}
	}

	public string GetKey()
	{
		if (CycleBase == DataCycleBase.Reversal)
		{
			return (string)OcCHBSbJWAs8ASV8LD97(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673389099), CycleBase, Repeat, RepeatParam1);
		}
		return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53788606), CycleBase, Repeat);
	}

	public int GetSequence(ChartPeriodType type, int interval, DateTime dateTime, double timeOffset)
	{
		return GetSequence((DataCycleBase)type, interval, dateTime, timeOffset);
	}

	public int GetSequence(ChartPeriodType type, int interval, double dateTime, double timeOffset)
	{
		return GetSequence((DataCycleBase)type, interval, dateTime, timeOffset);
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

	public bool GetPropertyVisibility(string propertyName)
	{
		if (!a1NdJEbJtmHqyMqZj7mx(propertyName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529757887)))
		{
			if (!(propertyName == (string)koLGArbJEOaQvkgNiBxn(0x78D396D8 ^ 0x78D717AC)))
			{
				return true;
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => false, 
			};
		}
		return CycleBase == DataCycleBase.Reversal;
	}

	[OnDeserialized]
	private void SetValuesOnDeserialized(StreamingContext context)
	{
		if (!TryGetMaxDaysToLoad(out var maxDaysToLoad))
		{
			return;
		}
		int? num = DaysToLoadChart;
		int num2 = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
		{
			num2 = 1;
		}
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!num.HasValue)
				{
					goto IL_0048;
				}
				goto case 4;
			case 2:
				if (num > maxDaysToLoad)
				{
					DaysToLoadChart = maxDaysToLoad;
				}
				goto IL_0048;
			case 3:
				if (num.HasValue)
				{
					num = DaysToLoadDom;
					num2 = 5;
					break;
				}
				return;
			case 4:
				num = DaysToLoadChart;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (!(num > maxDaysToLoad))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				{
					DaysToLoadDom = maxDaysToLoad;
					return;
				}
				IL_0048:
				num = DaysToLoadDom;
				num2 = 3;
				break;
			}
		}
	}

	static DataCycle()
	{
		TQo3STbJUA7mcIF0XaDW();
	}

	internal static object koLGArbJEOaQvkgNiBxn(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool o0lfMPbJc9EGlD99UZWP()
	{
		return KnyguwbJXJ3a97qIETx9 == null;
	}

	internal static DataCycle ds1ANNbJjMKrq0uetSLR()
	{
		return KnyguwbJXJ3a97qIETx9;
	}

	internal static int iICFRTbJQ5LyS19iNDD8(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object BJwxO3bJdRUJgYfVTrCb(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static int c6xGMJbJgKFcQ6Qr9foj(DataCycleBase cycleBase, int repeat, double d)
	{
		return GetSequence(cycleBase, repeat, d);
	}

	internal static DateTime imhjukbJRpjeDbNYwQDF(double P_0)
	{
		return DateTime.FromOADate(P_0);
	}

	internal static DataCycleBase E10T5EbJ6pV0pJNXEJuH(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static int SeZq2JbJMSZuxMOlyAPX(object P_0)
	{
		return ((DataCycle)P_0).RepeatParam2;
	}

	internal static DataCycleDataType TgkwcUbJOuFjMQlXRmbN(object P_0)
	{
		return ((DataCycle)P_0).DataType;
	}

	internal static int Q6g3SYbJqkKderehj9EX(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static int EZuZ1tbJI7tpFpB4MUgL(object P_0)
	{
		return ((DataCycle)P_0).RepeatParam1;
	}

	internal static object OcCHBSbJWAs8ASV8LD97(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool a1NdJEbJtmHqyMqZj7mx(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void TQo3STbJUA7mcIF0XaDW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
