using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace xU2QSTizKjpAYIp2tgCd;

[ValueConversion(typeof(bool), typeof(object))]
public class K3QL4rizrUuc1Zqc3QtC : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object q1Ziz8uOEAd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object FvXizAKkmmP;

	internal static K3QL4rizrUuc1Zqc3QtC QvycOxXBhdyeggbCorNy;

	public object TrueValue
	{
		[CompilerGenerated]
		get
		{
			return q1Ziz8uOEAd;
		}
		[CompilerGenerated]
		set
		{
			q1Ziz8uOEAd = obj;
		}
	}

	public object FalseValue
	{
		[CompilerGenerated]
		get
		{
			return FvXizAKkmmP;
		}
		[CompilerGenerated]
		set
		{
			FvXizAKkmmP = fvXizAKkmmP;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		object result = default(object);
		if (P_0 is bool flag)
		{
			int num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d226d78a4e104f1db903a0d012416f7b == 0)
			{
				num = 0;
			}
			while (true)
			{
				object obj;
				switch (num)
				{
				case 1:
					obj = FalseValue;
					goto IL_00d9;
				case 3:
					if (!flag)
					{
						num = 1;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1b6d8ff14504513bad907cfbd3ee92f != 0)
						{
							num = 0;
						}
						continue;
					}
					obj = TrueValue;
					goto IL_00d9;
				default:
					if (true)
					{
						goto case 3;
					}
					goto IL_005e;
				case 2:
					break;
					IL_00d9:
					result = obj;
					num = 2;
					continue;
				}
				break;
			}
			goto IL_00c8;
		}
		goto IL_005e;
		IL_005e:
		result = FalseValue;
		goto IL_00c8;
		IL_00c8:
		return result;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return Binding.DoNothing;
	}

	public K3QL4rizrUuc1Zqc3QtC()
	{
		x2MSrpXB8sjDw0YpgX5W();
		base._002Ector();
	}

	static K3QL4rizrUuc1Zqc3QtC()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		m2tJnsXBA3E6LyVHTDev();
	}

	internal static bool fUcDTsXBwLxjGvuiWopk()
	{
		return QvycOxXBhdyeggbCorNy == null;
	}

	internal static K3QL4rizrUuc1Zqc3QtC MtkHp3XB7KIRi2aZreBt()
	{
		return QvycOxXBhdyeggbCorNy;
	}

	internal static void x2MSrpXB8sjDw0YpgX5W()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static void m2tJnsXBA3E6LyVHTDev()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}
}
