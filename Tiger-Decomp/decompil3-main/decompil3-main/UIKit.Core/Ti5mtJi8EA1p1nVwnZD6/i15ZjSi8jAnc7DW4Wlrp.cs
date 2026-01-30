using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace Ti5mtJi8EA1p1nVwnZD6;

public class i15ZjSi8jAnc7DW4Wlrp : Control
{
	public static readonly DependencyProperty TA8i8IMUFb6;

	public static readonly DependencyProperty Ysii8WHogSk;

	internal static i15ZjSi8jAnc7DW4Wlrp f8FraUXnApLZ5ilBPyBs;

	public string Text
	{
		get
		{
			return (string)GetValue(TA8i8IMUFb6);
		}
		set
		{
			SetValue(TA8i8IMUFb6, value2);
		}
	}

	public bool IsTipOpened
	{
		get
		{
			return (bool)GetValue(Ysii8WHogSk);
		}
		set
		{
			SetValue(Ysii8WHogSk, flag);
		}
	}

	public i15ZjSi8jAnc7DW4Wlrp()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_73b6a8536efd4e5ba31378391aa47e85 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				uEJpgLXnFaF3qKOaZsKK(this, new MouseButtonEventHandler(OWQi8QBwKZ8));
				return;
			}
			base.MouseEnter += wjni8RDVQjK;
			base.MouseLeave += Owei8gNOwq0;
			base.MouseLeftButtonDown += f1Xi8dDpqeS;
			num = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_045d0f7a0142410b9c67d902cef040ca == 0)
			{
				num = 1;
			}
		}
	}

	private void OWQi8QBwKZ8(object P_0, MouseButtonEventArgs P_1)
	{
		qXjTKsXn3SaRmk1mcUOs(P_1, true);
	}

	private void f1Xi8dDpqeS(object P_0, MouseButtonEventArgs P_1)
	{
		P_1.Handled = true;
	}

	private void Owei8gNOwq0(object P_0, MouseEventArgs P_1)
	{
		IsTipOpened = false;
	}

	private void wjni8RDVQjK(object P_0, MouseEventArgs P_1)
	{
		IsTipOpened = true;
	}

	static i15ZjSi8jAnc7DW4Wlrp()
	{
		QF7kh7XnpHhP1b1lpj0j();
		CK7AbSXnuBZY0nTqSUGj();
		tmmBJyXnzXVSG9wBnlJY();
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2aca65174e2e4ee8910c4728495ecb10 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				TA8i8IMUFb6 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-198991962 ^ -198992244), Type.GetTypeFromHandle(GrUHwtXG0oLvu0jYfQop(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554451)));
				Ysii8WHogSk = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x5EA8FF2A ^ 0x5EA8FD4A), Type.GetTypeFromHandle(GrUHwtXG0oLvu0jYfQop(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554451)), new UIPropertyMetadata(false));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f803e8ef04c14ef097ea51825f131558 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void uEJpgLXnFaF3qKOaZsKK(object P_0, object P_1)
	{
		((UIElement)P_0).MouseLeftButtonUp += (MouseButtonEventHandler)P_1;
	}

	internal static bool K7L2e0XnPp0sbDnuXvQb()
	{
		return f8FraUXnApLZ5ilBPyBs == null;
	}

	internal static i15ZjSi8jAnc7DW4Wlrp bb6rTNXnJNga6bKbPN5g()
	{
		return f8FraUXnApLZ5ilBPyBs;
	}

	internal static void qXjTKsXn3SaRmk1mcUOs(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static void QF7kh7XnpHhP1b1lpj0j()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static void CK7AbSXnuBZY0nTqSUGj()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void tmmBJyXnzXVSG9wBnlJY()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static RuntimeTypeHandle GrUHwtXG0oLvu0jYfQop(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}
}
