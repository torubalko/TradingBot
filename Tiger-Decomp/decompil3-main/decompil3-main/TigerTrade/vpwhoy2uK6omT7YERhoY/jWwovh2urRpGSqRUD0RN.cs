using System.Collections;
using System.ComponentModel;
using System.Reflection;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Core.UI.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace vpwhoy2uK6omT7YERhoY;

internal sealed class jWwovh2urRpGSqRUD0RN : PropertyDescriptorPropertyModel
{
	private bool aHG2upHmSJO;

	private bool? fY32uuC52FO;

	private bool Ti12uzmHpvE;

	private static jWwovh2urRpGSqRUD0RN VhvggjDvW4FUN1DTpI0J;

	protected override bool HasStandardValuesCore
	{
		get
		{
			int num = 1;
			int num2 = num;
			IDynamicProperty dynamicProperty = default(IDynamicProperty);
			while (true)
			{
				switch (num2)
				{
				default:
					if (dynamicProperty != null && dynamicProperty.GetPropertyHasStandardValues(Name))
					{
						return true;
					}
					return base.HasStandardValuesCore;
				case 1:
					dynamicProperty = hb1TdqDvZcnFa0AoGXH0(this) as IDynamicProperty;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override bool IsLimitedToStandardValuesCore
	{
		get
		{
			if (Target is IDynamicProperty dynamicProperty && dynamicProperty.GetPropertyHasStandardValues((string)EnqJHMDvV4JZ7dH5Dopc(this)))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => true, 
				};
			}
			return base.IsLimitedToStandardValuesCore;
		}
	}

	protected override bool IsValueReadOnlyCore
	{
		get
		{
			if (hb1TdqDvZcnFa0AoGXH0(this) is IDynamicProperty dynamicProperty)
			{
				return NZWF5RDvCONyV8JWDGw0(dynamicProperty, EnqJHMDvV4JZ7dH5Dopc(this));
			}
			return base.IsValueReadOnlyCore;
		}
	}

	public bool IsVisible
	{
		get
		{
			if (!fY32uuC52FO.HasValue)
			{
				fY32uuC52FO = !(Target is IDynamicProperty dynamicProperty) || dynamicProperty.GetPropertyVisibility((string)EnqJHMDvV4JZ7dH5Dopc(this));
			}
			return fY32uuC52FO.Value;
		}
	}

	public bool IsIndividual
	{
		get
		{
			return Ti12uzmHpvE;
		}
		set
		{
			if (Ti12uzmHpvE != flag)
			{
				Ti12uzmHpvE = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				NotifyPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29736764));
			}
		}
	}

	public bool IsSoundEnabled
	{
		get
		{
			string text = pDD2u7Y59O2();
			if (!string.IsNullOrEmpty(text))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				PropertyInfo property = hb1TdqDvZcnFa0AoGXH0(this).GetType().GetProperty(text);
				if (t5LXbGDvrZcjG8XBHoaN(property, null))
				{
					return (bool)property.GetValue(hb1TdqDvZcnFa0AoGXH0(this));
				}
			}
			return false;
		}
		set
		{
			string text = pDD2u7Y59O2();
			PropertyInfo property = default(PropertyInfo);
			int num;
			if (!bfSX8xDvKZW1IxhS6sgv(text))
			{
				property = Target.GetType().GetProperty(text);
				num = 2;
			}
			else
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
				{
					num = 0;
				}
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					if (dDrcxZDvmrqaJE9x6NVQ(property, null) || (bool)vI25tIDvhim0yvC6YXrY(property, Target) == flag)
					{
						return;
					}
					fhZ6l4DvwTo0BibdtZvP(property, Target, flag);
					NotifyPropertyChanged((string)A5RbbXDvT7mKw6SlNjKb(--146713930 ^ 0x8BE5A7E));
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
				case 1:
					return;
				}
			}
		}
	}

	public bool IsSoundProperty => !string.IsNullOrEmpty(pDD2u7Y59O2());

	protected override IEnumerable StandardValuesCore
	{
		get
		{
			int num = 1;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					IDynamicProperty obj2 = hb1TdqDvZcnFa0AoGXH0(this) as IDynamicProperty;
					if (obj2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = obj2.GetPropertyStandardValues(Name);
					break;
				}
				default:
					obj = null;
					break;
				}
				break;
			}
			IEnumerable enumerable = (IEnumerable)obj;
			return enumerable ?? base.StandardValuesCore;
		}
	}

	public jWwovh2urRpGSqRUD0RN(object P_0, PropertyDescriptor P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0, P_1);
	}

	private void Geh2um8Qkrm()
	{
		NotifyPropertyChanged((string)A5RbbXDvT7mKw6SlNjKb(0x6D18F862 ^ 0x6D180ECA));
		NotifyPropertyChanged(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962624965));
	}

	private void J8T2uh4OZTE()
	{
		fY32uuC52FO = null;
		QfpFfADvyt9dq4HmPnjf(this, A5RbbXDvT7mKw6SlNjKb(-165474503 ^ -165474251));
	}

	private void IZ82uwSX3jg()
	{
		NotifyPropertyChanged((string)A5RbbXDvT7mKw6SlNjKb(-5977659 ^ -6013145));
		NotifyPropertyChanged((string)A5RbbXDvT7mKw6SlNjKb(-690510723 ^ -690531457));
	}

	private string pDD2u7Y59O2()
	{
		int num = 12;
		int num2 = num;
		uint num3 = default(uint);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			case 14:
				if (num3 == 1630637035)
				{
					if (!psv7wvDv7PqLTKpZc1lV(name, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991846791)))
					{
						goto case 8;
					}
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B57D06);
				}
				num2 = 16;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
				{
					num2 = 9;
				}
				break;
			case 9:
				if (num3 != 756052682)
				{
					goto case 8;
				}
				goto case 15;
			case 13:
				if (!psv7wvDv7PqLTKpZc1lV(name, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -6013295)))
				{
					num2 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
					{
						num2 = 17;
					}
					break;
				}
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFEF2AE);
			case 4:
				if (num3 != 3688813071u)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			default:
				if (num3 != 4204077332u || !(name == (string)A5RbbXDvT7mKw6SlNjKb(0x1AB79299 ^ 0x1AB76527)))
				{
					goto case 8;
				}
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1D7BA1ED ^ 0x1D7B58D5);
			case 1:
				if (num3 != 1428919215)
				{
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
					{
						num2 = 14;
					}
					break;
				}
				if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416989025))
				{
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203062708);
				}
				goto case 8;
			case 6:
				if (num3 <= 1630637035)
				{
					num2 = 18;
					break;
				}
				goto case 2;
			case 7:
				return (string)A5RbbXDvT7mKw6SlNjKb(0x78D396D8 ^ 0x78D36CE4);
			case 8:
			case 16:
			case 17:
				return null;
			case 18:
				if (num3 <= 756052682)
				{
					if (num3 != 661893800)
					{
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
						{
							num2 = 9;
						}
						break;
					}
					if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181398000))
					{
						return (string)A5RbbXDvT7mKw6SlNjKb(-123775059 ^ -123752951);
					}
				}
				else
				{
					if (num3 != 838159352)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461285971))
					{
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
						{
							num2 = 7;
						}
						break;
					}
				}
				goto case 8;
			case 3:
				if (!(name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1192977032)))
				{
					goto case 8;
				}
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009581397);
			case 12:
				name = Name;
				num2 = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				if (num3 <= 2448031718u)
				{
					if (num3 != 2079757168)
					{
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 13;
				}
				if (num3 == 2864429845u)
				{
					if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53760492))
					{
						return (string)A5RbbXDvT7mKw6SlNjKb(-1736566656 ^ -1736515192);
					}
					goto case 8;
				}
				num2 = 4;
				break;
			case 5:
				if (name == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44522041))
				{
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799528545);
				}
				num2 = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(name);
				num2 = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				if (num3 != 2448031718u)
				{
					goto case 8;
				}
				goto case 3;
			case 15:
				if (name == (string)A5RbbXDvT7mKw6SlNjKb(0x7F55E538 ^ 0x7F551252))
				{
					return (string)A5RbbXDvT7mKw6SlNjKb(-1999650146 ^ -1999685072);
				}
				goto case 8;
			}
		}
	}

	protected override void OnPropertyChanged(PropertyChangedEventArgs P_0)
	{
		int num = 1;
		int num2 = num;
		IDynamicProperty dynamicProperty = default(IDynamicProperty);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				base.OnPropertyChanged(P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (aHG2upHmSJO || S6JHNTDv8oG2IynFwE04(P_0.PropertyName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1848917438)))
			{
				return;
			}
			try
			{
				aHG2upHmSJO = true;
				Geh2um8Qkrm();
				J8T2uh4OZTE();
				int num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						dynamicProperty.GetPropertyHasStandardValues(Name);
						return;
					case 1:
						dynamicProperty = hb1TdqDvZcnFa0AoGXH0(this) as IDynamicProperty;
						if (dynamicProperty == null)
						{
							return;
						}
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
			finally
			{
				aHG2upHmSJO = false;
			}
		}
	}

	static jWwovh2urRpGSqRUD0RN()
	{
		NZ0o3uDvAFw0wAKkRJMM();
	}

	internal static bool DWp6NoDvtecnbs0jHmGk()
	{
		return VhvggjDvW4FUN1DTpI0J == null;
	}

	internal static jWwovh2urRpGSqRUD0RN YIgC6bDvUEQebG7Mp1Mo()
	{
		return VhvggjDvW4FUN1DTpI0J;
	}

	internal static object A5RbbXDvT7mKw6SlNjKb(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void QfpFfADvyt9dq4HmPnjf(object P_0, object P_1)
	{
		((ObservableObjectBase)P_0).NotifyPropertyChanged((string)P_1);
	}

	internal static object hb1TdqDvZcnFa0AoGXH0(object P_0)
	{
		return ((CachedPropertyModelBase)P_0).Target;
	}

	internal static object EnqJHMDvV4JZ7dH5Dopc(object P_0)
	{
		return ((CachedPropertyModelBase)P_0).Name;
	}

	internal static bool NZWF5RDvCONyV8JWDGw0(object P_0, object P_1)
	{
		return ((IDynamicProperty)P_0).GetPropertyReadOnly((string)P_1);
	}

	internal static bool t5LXbGDvrZcjG8XBHoaN(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static bool bfSX8xDvKZW1IxhS6sgv(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool dDrcxZDvmrqaJE9x6NVQ(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object vI25tIDvhim0yvC6YXrY(object P_0, object P_1)
	{
		return ((PropertyInfo)P_0).GetValue(P_1);
	}

	internal static void fhZ6l4DvwTo0BibdtZvP(object P_0, object P_1, object P_2)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2);
	}

	internal static bool psv7wvDv7PqLTKpZc1lV(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool S6JHNTDv8oG2IynFwE04(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void NZ0o3uDvAFw0wAKkRJMM()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
