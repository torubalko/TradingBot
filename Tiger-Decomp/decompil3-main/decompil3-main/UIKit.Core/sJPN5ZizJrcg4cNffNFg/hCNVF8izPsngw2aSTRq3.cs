using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace sJPN5ZizJrcg4cNffNFg;

[ValueConversion(typeof(string), typeof(object))]
public class hCNVF8izPsngw2aSTRq3 : IValueConverter
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object v5rizzrARZx;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object Ogbl00iH0bZ;

	internal static hCNVF8izPsngw2aSTRq3 XpoW6kXBPEs92hJGaegm;

	public object EmptyValue
	{
		[CompilerGenerated]
		get
		{
			return v5rizzrARZx;
		}
		[CompilerGenerated]
		set
		{
			v5rizzrARZx = obj;
		}
	}

	public object NotEmptyValue
	{
		[CompilerGenerated]
		get
		{
			return Ogbl00iH0bZ;
		}
		[CompilerGenerated]
		set
		{
			Ogbl00iH0bZ = ogbl00iH0bZ;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		string text = P_0 as string;
		bool flag = text == null;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6129eef11d5d44a588d08332bc32f8c8 != 0)
		{
			num = 0;
		}
		object result2 = default(object);
		object result;
		while (true)
		{
			switch (num)
			{
			default:
				if (flag)
				{
					return EmptyValue;
				}
				goto case 2;
			case 1:
				return result2;
			case 3:
				result = NotEmptyValue;
				break;
			case 2:
				if (!SOANVZXB3hAivQxQu4Qy(text))
				{
					goto IL_00ae;
				}
				result = EmptyValue;
				break;
			}
			break;
			IL_00ae:
			num = 3;
		}
		return result;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public hCNVF8izPsngw2aSTRq3()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static hCNVF8izPsngw2aSTRq3()
	{
		Q7nOymXBp6pEJ3cSrJ8Z();
		mT9KD9XBuhBWqWdWuc2b();
	}

	internal static bool APUWEEXBJ6lXQV2ZM2I3()
	{
		return XpoW6kXBPEs92hJGaegm == null;
	}

	internal static hCNVF8izPsngw2aSTRq3 Quxk86XBFvPjLpWSLB6S()
	{
		return XpoW6kXBPEs92hJGaegm;
	}

	internal static bool SOANVZXB3hAivQxQu4Qy(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void Q7nOymXBp6pEJ3cSrJ8Z()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static void mT9KD9XBuhBWqWdWuc2b()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}
}
