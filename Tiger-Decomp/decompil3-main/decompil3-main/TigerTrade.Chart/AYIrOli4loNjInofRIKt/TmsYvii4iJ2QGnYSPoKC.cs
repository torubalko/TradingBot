using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using TigerTrade.Chart.Annotations;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Chart.Indicators.Sources;
using TigerTrade.Chart.Properties;
using TigerTrade.Core.UI.Common;

namespace AYIrOli4loNjInofRIKt;

[ReadOnly(true)]
[DataContract(Name = "BarSearchCondition", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[TypeConverter(typeof(ExpandableObjectConverter))]
internal sealed class TmsYvii4iJ2QGnYSPoKC : INotifyPropertyChanged, IDynamicProperty
{
	private BarSearchConditions kUEi4ErRnl1;

	private IndicatorSourceBase W73i4QU5TtX;

	private IndicatorSourceBase zE6i4d8ep8A;

	private decimal Y73i4gy16J0;

	private double[] qvki4RBh0Bw;

	private double[] AoTi46Bluws;

	[CompilerGenerated]
	private bool oapi4Mg6Q3y;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static TmsYvii4iJ2QGnYSPoKC h8KsKFelDInmSHFExhJW;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsCondition")]
	[DataMember(Name = "Condition")]
	public BarSearchConditions Condition
	{
		get
		{
			return kUEi4ErRnl1;
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
					if (!object.Equals(barSearchConditions, kUEi4ErRnl1))
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 1:
					kUEi4ErRnl1 = barSearchConditions;
					g7fi4NZSy9x(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFCC2A));
					g7fi4NZSy9x((string)d4thGjelkP1eUATwnLbw(-690510723 ^ -690541679));
					g7fi4NZSy9x((string)d4thGjelkP1eUATwnLbw(0x2D3134C9 ^ 0x2D31B2B3));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource1")]
	[DataMember(Name = "Source1")]
	public IndicatorSourceBase Source1
	{
		get
		{
			return W73i4QU5TtX ?? (W73i4QU5TtX = new StockSource());
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
					if (indicatorSourceBase == W73i4QU5TtX)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 == 0)
						{
							num2 = 0;
						}
						break;
					}
					W73i4QU5TtX = indicatorSourceBase;
					g7fi4NZSy9x(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1606927328 ^ -1606896674));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSource2")]
	[DataMember(Name = "Source2")]
	public IndicatorSourceBase Source2
	{
		get
		{
			return zE6i4d8ep8A ?? (zE6i4d8ep8A = new StockSource());
		}
		set
		{
			if (indicatorSourceBase != zE6i4d8ep8A)
			{
				zE6i4d8ep8A = indicatorSourceBase;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				g7fi4NZSy9x(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5EA8FF2A ^ 0x5EA870C6));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsValue")]
	[DataMember(Name = "Value")]
	public decimal Value
	{
		get
		{
			return Y73i4gy16J0;
		}
		set
		{
			if (!hX3fHUel1jwAonEwEIxd(num, Y73i4gy16J0))
			{
				Y73i4gy16J0 = num;
				g7fi4NZSy9x(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--146713930 ^ 0x8BE2B30));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	[Browsable(false)]
	public bool kZbi4jebxh9
	{
		[CompilerGenerated]
		get
		{
			return oapi4Mg6Q3y;
		}
		[CompilerGenerated]
		set
		{
			oapi4Mg6Q3y = flag;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)vXSnFcelLEXwZsOxR6vl(propertyChangedEventHandler2, propertyChangedEventHandler3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
						{
							num = 0;
						}
						continue;
					}
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					break;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				}
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public void Clear()
	{
		qvki4RBh0Bw = null;
		AoTi46Bluws = null;
	}

	private double[] LMYi44hwIRC(IndicatorsHelper P_0, int P_1)
	{
		int num;
		if (qvki4RBh0Bw != null && qvki4RBh0Bw.Length - 1 > P_1)
		{
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
			{
				num = 0;
			}
		}
		else
		{
			qvki4RBh0Bw = Source1.GetSeries(P_0);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			if (qvki4RBh0Bw == null || qvki4RBh0Bw.Length < P_1)
			{
				return null;
			}
			return qvki4RBh0Bw;
		default:
			return qvki4RBh0Bw;
		}
	}

	private double[] rnHi4D6n0hb(IndicatorsHelper P_0, int P_1)
	{
		if (AoTi46Bluws == null || AoTi46Bluws.Length - 1 <= P_1)
		{
			AoTi46Bluws = Source2.GetSeries(P_0);
			if (AoTi46Bluws != null)
			{
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						if (AoTi46Bluws.Length < P_1)
						{
							num = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
							{
								num = 1;
							}
							continue;
						}
						return AoTi46Bluws;
					case 1:
						break;
					}
					break;
				}
			}
			return null;
		}
		return AoTi46Bluws;
	}

	public bool Check(IndicatorsHelper helper, int barIndex)
	{
		int num = 2;
		int num2 = num;
		double[] array = default(double[]);
		double[] array4 = default(double[]);
		double[] array3 = default(double[]);
		double[] array2 = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (array[barIndex] < array4[barIndex])
				{
					return true;
				}
				goto IL_0042;
			case 4:
				if (array4 == null)
				{
					return false;
				}
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				switch (Condition)
				{
				case BarSearchConditions.LessThenValue:
					if (array[barIndex] <= (double)Value)
					{
						return true;
					}
					break;
				case BarSearchConditions.LessThenSource:
					goto IL_00ea;
				case BarSearchConditions.GreaterThenValue:
					if (array[barIndex] >= p85AUjel5txKdnap9HB8(Value))
					{
						return true;
					}
					break;
				case BarSearchConditions.EqualValue:
					if (array[barIndex] == (double)Value)
					{
						return true;
					}
					break;
				case BarSearchConditions.EqualSource:
					goto IL_0184;
				case BarSearchConditions.GreaterThenSource:
					goto end_IL_0012;
				}
				goto IL_0042;
			case 5:
				if (array3 == null)
				{
					num2 = 7;
					continue;
				}
				if (array[barIndex] == array3[barIndex])
				{
					return true;
				}
				goto IL_0042;
			case 6:
				if (array2 != null)
				{
					num2 = 8;
					continue;
				}
				return false;
			case 7:
				return false;
			case 2:
				array = LMYi44hwIRC(helper, barIndex);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				{
					if (array[barIndex] > array2[barIndex])
					{
						return true;
					}
					goto IL_0042;
				}
				IL_0042:
				return false;
				IL_0184:
				array3 = rnHi4D6n0hb(helper, barIndex);
				num2 = 5;
				continue;
				IL_00ea:
				array4 = rnHi4D6n0hb(helper, barIndex);
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			array2 = rnHi4D6n0hb(helper, barIndex);
			num2 = 6;
		}
	}

	public void OPhi4boAZTG(TmsYvii4iJ2QGnYSPoKC P_0)
	{
		Source1 = ((IndicatorSourceBase)cYgqtielSa22McqY8MST(P_0)).CloneSource();
		Source2 = ((IndicatorSourceBase)DiEhwyelxxUfVVM4XiBu(P_0)).CloneSource();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Value = P_0.Value;
	}

	[NotifyPropertyChangedInvocator]
	private void g7fi4NZSy9x([CallerMemberName] string propertyName = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				kZbi4jebxh9 = true;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
				return;
			}
		}
	}

	public override string ToString()
	{
		return Resources.ChartAlertConditionTitle;
	}

	public bool GetPropertyHasStandardValues(string P_0)
	{
		return false;
	}

	public bool GetPropertyReadOnly(string P_0)
	{
		return false;
	}

	public IEnumerable<object> GetPropertyStandardValues(string P_0)
	{
		return null;
	}

	public bool GetPropertyVisibility(string P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (Condition != BarSearchConditions.GreaterThenSource && Condition != BarSearchConditions.LessThenSource)
				{
					return Condition == BarSearchConditions.EqualSource;
				}
				return true;
			case 2:
				if (!MSu4BEelesvMtpoS3dVk(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192958702)))
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				return true;
			case 1:
				if (P_0 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x38579D1))
				{
					if (Condition != BarSearchConditions.GreaterThenValue && Condition != BarSearchConditions.LessThenValue)
					{
						return Condition == BarSearchConditions.EqualValue;
					}
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TmsYvii4iJ2QGnYSPoKC()
	{
		VnI8KOelsjWW62lmuXge();
		base._002Ector();
	}

	static TmsYvii4iJ2QGnYSPoKC()
	{
		LvJNM5elXc6YXyodj0hD();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object d4thGjelkP1eUATwnLbw(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool SQswtlelbaKtfhpvWof8()
	{
		return h8KsKFelDInmSHFExhJW == null;
	}

	internal static TmsYvii4iJ2QGnYSPoKC KNsRNGelNlhvwnapHr2p()
	{
		return h8KsKFelDInmSHFExhJW;
	}

	internal static bool hX3fHUel1jwAonEwEIxd(decimal P_0, decimal P_1)
	{
		return P_0 == P_1;
	}

	internal static double p85AUjel5txKdnap9HB8(decimal P_0)
	{
		return (double)P_0;
	}

	internal static object cYgqtielSa22McqY8MST(object P_0)
	{
		return ((TmsYvii4iJ2QGnYSPoKC)P_0).Source1;
	}

	internal static object DiEhwyelxxUfVVM4XiBu(object P_0)
	{
		return ((TmsYvii4iJ2QGnYSPoKC)P_0).Source2;
	}

	internal static object vXSnFcelLEXwZsOxR6vl(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static bool MSu4BEelesvMtpoS3dVk(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void VnI8KOelsjWW62lmuXge()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void LvJNM5elXc6YXyodj0hD()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
