using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;
using UIKit.Core;

namespace eCy4rgl0BJrN3lsDk3dK;

[ValueConversion(typeof(Placement), typeof(object))]
public class GBlh3kl0vreqio726dlZ : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object mXml014QUOI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object nXNl05YgnAX;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object KB5l0S2hAgo;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object nwFl0xabyi4;

	private static GBlh3kl0vreqio726dlZ LmLEsHXaoGrfUFcUF0CI;

	public object LeftValue
	{
		[CompilerGenerated]
		get
		{
			return mXml014QUOI;
		}
		[CompilerGenerated]
		set
		{
			mXml014QUOI = obj;
		}
	}

	public object RightValue
	{
		[CompilerGenerated]
		get
		{
			return nXNl05YgnAX;
		}
		[CompilerGenerated]
		set
		{
			nXNl05YgnAX = obj;
		}
	}

	public object TopValue
	{
		[CompilerGenerated]
		get
		{
			return KB5l0S2hAgo;
		}
		[CompilerGenerated]
		set
		{
			KB5l0S2hAgo = kB5l0S2hAgo;
		}
	}

	public object BottomValue
	{
		[CompilerGenerated]
		get
		{
			return nwFl0xabyi4;
		}
		[CompilerGenerated]
		set
		{
			nwFl0xabyi4 = obj;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 3;
		int num2 = num;
		object result = default(object);
		Placement placement = default(Placement);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!(P_0 is Placement))
				{
					num2 = 2;
					break;
				}
				goto case 7;
			case 1:
			case 4:
			case 5:
			case 8:
				return result;
			case 2:
				result = Binding.DoNothing;
				num2 = 4;
				break;
			default:
				if (true)
				{
					switch (placement)
					{
					case Placement.Top:
						break;
					case Placement.Bottom:
						goto IL_00de;
					case Placement.Left:
						goto IL_0165;
					case Placement.Right:
						goto IL_0181;
					default:
						goto IL_018e;
					}
					result = TopValue;
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2aca65174e2e4ee8910c4728495ecb10 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 9:
				goto IL_00de;
			case 7:
				placement = (Placement)P_0;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f97c2b59553f423fb8445ca09317c97d != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				goto IL_0165;
				IL_018e:
				result = Binding.DoNothing;
				num2 = 8;
				break;
				IL_0181:
				result = RightValue;
				goto case 1;
				IL_0165:
				result = LeftValue;
				num2 = 5;
				break;
				IL_00de:
				result = BottomValue;
				goto case 1;
			}
		}
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return Binding.DoNothing;
	}

	public GBlh3kl0vreqio726dlZ()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static GBlh3kl0vreqio726dlZ()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool rjH5gMXavfgSMZRIfq9q()
	{
		return LmLEsHXaoGrfUFcUF0CI == null;
	}

	internal static GBlh3kl0vreqio726dlZ d7xv9CXaB4OgtB6LhGaj()
	{
		return LmLEsHXaoGrfUFcUF0CI;
	}
}
