using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

public class Header : Control
{
	public static readonly DependencyProperty HdtiAb3oCNQ;

	public static readonly DependencyProperty tg8iANiRGrT;

	public static readonly DependencyProperty IAZiAk6X6V5;

	public static readonly DependencyProperty WxTiA1OvELC;

	public static readonly DependencyProperty yfRiA5idUPF;

	public static readonly DependencyProperty MwhiASUoyXQ;

	internal static Header ChS54YXGsDHP0pn4bPj9;

	public string Value
	{
		get
		{
			return (string)BfZlUDXGjoPtCU2VhAAF(this, HdtiAb3oCNQ);
		}
		set
		{
			ikNlHbXGEwlcRnXaI4tH(this, HdtiAb3oCNQ, text);
		}
	}

	public string InfoText
	{
		get
		{
			return (string)BfZlUDXGjoPtCU2VhAAF(this, tg8iANiRGrT);
		}
		set
		{
			ikNlHbXGEwlcRnXaI4tH(this, tg8iANiRGrT, text);
		}
	}

	public string LinkText
	{
		get
		{
			return (string)BfZlUDXGjoPtCU2VhAAF(this, IAZiAk6X6V5);
		}
		set
		{
			SetValue(IAZiAk6X6V5, value2);
		}
	}

	public bool IsLinkArrowVisible
	{
		get
		{
			return (bool)GetValue(WxTiA1OvELC);
		}
		set
		{
			ikNlHbXGEwlcRnXaI4tH(this, WxTiA1OvELC, flag);
		}
	}

	public ICommand LinkCommand
	{
		get
		{
			return (ICommand)GetValue(yfRiA5idUPF);
		}
		set
		{
			SetValue(yfRiA5idUPF, value2);
		}
	}

	public object LinkCommandParameter
	{
		get
		{
			return GetValue(MwhiASUoyXQ);
		}
		set
		{
			ikNlHbXGEwlcRnXaI4tH(this, MwhiASUoyXQ, obj);
		}
	}

	public Header()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static Header()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		FveMU2XGQl1pXddRqSjm();
		E5jbgyXGdXKD2ZCIECmK();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f613416004f048ed97d95a2596e7c9aa == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				WxTiA1OvELC = (DependencyProperty)D9PjqDXGM12yZ1Ob2RHk(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x2D3134C9 ^ 0x2D3137E1), jxOhEDXGRDTf3CfsWDJf(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(Cq2meXXGgXAaq3Wqamh1(33554455)));
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a7f6954a72b440769776337ebaf426d5 != 0)
				{
					num = 3;
				}
				break;
			case 2:
				return;
			case 1:
				HdtiAb3oCNQ = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-690510723 ^ -690510193), jxOhEDXGRDTf3CfsWDJf(Cq2meXXGgXAaq3Wqamh1(16777225)), Type.GetTypeFromHandle(Cq2meXXGgXAaq3Wqamh1(33554455)));
				tg8iANiRGrT = (DependencyProperty)D9PjqDXGM12yZ1Ob2RHk(MgbGHkXG6gy2W4fV9rw5(0x5CD4F15 ^ 0x5CD4C15), Type.GetTypeFromHandle(Cq2meXXGgXAaq3Wqamh1(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554455)));
				IAZiAk6X6V5 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-45476899 ^ -45477687), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(Cq2meXXGgXAaq3Wqamh1(33554455)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1a6c635ab4940dbb3ffcd364da08562 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				yfRiA5idUPF = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-342738082 ^ -342738930), jxOhEDXGRDTf3CfsWDJf(Cq2meXXGgXAaq3Wqamh1(16777255)), Type.GetTypeFromHandle(Cq2meXXGgXAaq3Wqamh1(33554455)));
				MwhiASUoyXQ = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x11D1040B ^ 0x11D10761), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554455)));
				num = 2;
				break;
			}
		}
	}

	internal static object BfZlUDXGjoPtCU2VhAAF(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool e9ZZ9EXGXMKwA9ORY7Pj()
	{
		return ChS54YXGsDHP0pn4bPj9 == null;
	}

	internal static Header vGjOqWXGcSU24WvmjHI7()
	{
		return ChS54YXGsDHP0pn4bPj9;
	}

	internal static void ikNlHbXGEwlcRnXaI4tH(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void FveMU2XGQl1pXddRqSjm()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void E5jbgyXGdXKD2ZCIECmK()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static RuntimeTypeHandle Cq2meXXGgXAaq3Wqamh1(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type jxOhEDXGRDTf3CfsWDJf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object MgbGHkXG6gy2W4fV9rw5(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static object D9PjqDXGM12yZ1Ob2RHk(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
