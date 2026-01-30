using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;
using UIKit.Core;

namespace xowxQfi3mG5J8fGOO2yt;

[TemplatePart(Name = "ErrorViewPopup", Type = typeof(Popup))]
public class n7oSZ9i3KgbNmyR22k0d : TextBox
{
	private Popup HtxipluoEwi;

	public static readonly DependencyProperty SHJip4uStVo;

	public static readonly DependencyProperty xDOipDDvuFu;

	public static readonly DependencyProperty Gqripb5mIDF;

	public static readonly DependencyProperty YZDipNwJuXX;

	public static readonly DependencyProperty el2ipkmMQg3;

	public static readonly DependencyProperty Wcgip1JxCDd;

	public static readonly DependencyProperty xuXip5Cqb0a;

	public static readonly DependencyProperty U5ZipSbWMyj;

	public static readonly DependencyProperty IsSmallProperty;

	public static readonly DependencyProperty ftxipxuwHrZ;

	public static readonly DependencyProperty e0UipLUNGyO;

	internal static n7oSZ9i3KgbNmyR22k0d JyVEtiXv90gCbyCUttCp;

	public string Header
	{
		get
		{
			return (string)GetValue(SHJip4uStVo);
		}
		set
		{
			SetValue(SHJip4uStVo, value2);
		}
	}

	public string InfoText
	{
		get
		{
			return (string)GetValue(xDOipDDvuFu);
		}
		set
		{
			SetValue(xDOipDDvuFu, value2);
		}
	}

	public string Placeholder
	{
		get
		{
			return (string)GetValue(Gqripb5mIDF);
		}
		set
		{
			SetValue(Gqripb5mIDF, value2);
		}
	}

	public string ErrorMessage
	{
		get
		{
			return (string)GetValue(YZDipNwJuXX);
		}
		set
		{
			SetValue(YZDipNwJuXX, value2);
		}
	}

	public string LinkText
	{
		get
		{
			return (string)GetValue(el2ipkmMQg3);
		}
		set
		{
			SetValue(el2ipkmMQg3, value2);
		}
	}

	public bool IsLinkArrowVisible
	{
		get
		{
			return (bool)uJGbsdXvovyarblXwi1r(this, Wcgip1JxCDd);
		}
		set
		{
			SetValue(Wcgip1JxCDd, flag);
		}
	}

	public ICommand LinkCommand
	{
		get
		{
			return (ICommand)GetValue(xuXip5Cqb0a);
		}
		set
		{
			SetValue(xuXip5Cqb0a, value2);
		}
	}

	public object LinkCommandParameter
	{
		get
		{
			return GetValue(U5ZipSbWMyj);
		}
		set
		{
			TpfKQ0XvvtlFS7gV4LjC(this, U5ZipSbWMyj, obj);
		}
	}

	public bool IsSmall
	{
		get
		{
			return (bool)GetValue(IsSmallProperty);
		}
		set
		{
			SetValue(IsSmallProperty, flag);
		}
	}

	public ICommand SubmitCommand
	{
		get
		{
			return (ICommand)uJGbsdXvovyarblXwi1r(this, ftxipxuwHrZ);
		}
		set
		{
			SetValue(ftxipxuwHrZ, value2);
		}
	}

	public bool IsErrorVisible
	{
		get
		{
			return (bool)uJGbsdXvovyarblXwi1r(this, e0UipLUNGyO);
		}
		set
		{
			SetValue(e0UipLUNGyO, flag);
		}
	}

	public override void OnApplyTemplate()
	{
		HtxipluoEwi = GetTemplateChild((string)C6uYiGXvY8HAgRtmU34o(0xC1DDB3B ^ 0xC1DDD31)) as Popup;
		base.KeyUp += zdBi3wFJ3VO;
		base.OnApplyTemplate();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_aaee87d70b4c49aab4b237d8e1fb4ee6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private static void Rjgi3hs3hWH(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		n7oSZ9i3KgbNmyR22k0d n7oSZ9i3KgbNmyR22k0d2 = default(n7oSZ9i3KgbNmyR22k0d);
		bool isOpen = default(bool);
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				n7oSZ9i3KgbNmyR22k0d2.HtxipluoEwi.IsOpen = isOpen;
				return;
			case 3:
				n7oSZ9i3KgbNmyR22k0d2 = P_0 as n7oSZ9i3KgbNmyR22k0d;
				num2 = 2;
				break;
			case 5:
				return;
			case 6:
				return;
			case 4:
				if (flag)
				{
					num2 = 5;
					break;
				}
				flag2 = n7oSZ9i3KgbNmyR22k0d2.HtxipluoEwi == null;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_dc59fde267a944f19a1e2e2aaaec7a22 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (flag2)
				{
					num2 = 6;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_ead17c0106b44a49af4758c71ff2ff4b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 1;
			case 2:
			{
				int num4;
				if (n7oSZ9i3KgbNmyR22k0d2 != null)
				{
					object newValue = P_1.NewValue;
					int num3;
					if (newValue is bool)
					{
						isOpen = (bool)newValue;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					num4 = ((num3 == 0) ? 1 : 0);
				}
				else
				{
					num4 = 1;
				}
				flag = (byte)num4 != 0;
				num2 = 4;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a863574b23b747caa2b08ae3edec8640 == 0)
				{
					num2 = 4;
				}
				break;
			}
			}
		}
	}

	private void zdBi3wFJ3VO(object P_0, KeyEventArgs P_1)
	{
		if (JIVmNFXvBC1dp68LoUEN(P_1) != Key.Return)
		{
			return;
		}
		ICommand command = SubmitCommand;
		if (command == null)
		{
			int num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0186f9916c474408b21410971ecb054c == 0)
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
			command.Execute(null);
		}
	}

	public n7oSZ9i3KgbNmyR22k0d()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static n7oSZ9i3KgbNmyR22k0d()
	{
		ll7WggXval3WwDA9o5BA();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		IGelYrXviXAyk29SWEid();
		SHJip4uStVo = (DependencyProperty)wcbJkXXvlRXbwkSOAGks(C6uYiGXvY8HAgRtmU34o(-894902996 ^ -894902936), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554469)));
		xDOipDDvuFu = (DependencyProperty)wcbJkXXvlRXbwkSOAGks(C6uYiGXvY8HAgRtmU34o(--500511424 ^ 0x1DD531C0), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(rwLk25Xv4a8IbZ6ZsPnC(33554469)));
		Gqripb5mIDF = DependencyProperty.Register((string)C6uYiGXvY8HAgRtmU34o(-1153206687 ^ -1153207857), Type.GetTypeFromHandle(rwLk25Xv4a8IbZ6ZsPnC(16777225)), a2iPw0XvDP1TqcXkSZLP(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554469)));
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5fd60ba0c8914ea3b4e84bce73b6a8b9 != 0)
		{
			num = 1;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
				el2ipkmMQg3 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(--871424829 ^ 0x33F0E029), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(rwLk25Xv4a8IbZ6ZsPnC(33554469)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_165393879de545558ca62c901f90f36f != 0)
				{
					num = 0;
				}
				break;
			case 5:
				U5ZipSbWMyj = DependencyProperty.Register((string)C6uYiGXvY8HAgRtmU34o(-5977659 ^ -5977425), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), a2iPw0XvDP1TqcXkSZLP(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554469)));
				IsSmallProperty = (DependencyProperty)QgHj8eXvbZkH0IRndWNU(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1087080834 ^ -1087082440), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554469)), new UIPropertyMetadata(false));
				num2 = 3;
				goto IL_0005;
			default:
				Wcgip1JxCDd = (DependencyProperty)wcbJkXXvlRXbwkSOAGks(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x7F645F3C ^ 0x7F645C14), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(rwLk25Xv4a8IbZ6ZsPnC(33554469)));
				num = 2;
				break;
			case 2:
				xuXip5Cqb0a = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x6D18F862 ^ 0x6D18FB32), a2iPw0XvDP1TqcXkSZLP(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554469)));
				num2 = 5;
				goto IL_0005;
			case 3:
				ftxipxuwHrZ = DependencyProperty.Register((string)C6uYiGXvY8HAgRtmU34o(0x68C7EAE6 ^ 0x68C7E294), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), a2iPw0XvDP1TqcXkSZLP(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554469)));
				e0UipLUNGyO = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x7394D272 ^ 0x7394D42A), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), a2iPw0XvDP1TqcXkSZLP(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554469)), new PropertyMetadata(false, Rjgi3hs3hWH));
				return;
			case 1:
				{
					YZDipNwJuXX = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x4662F6AF ^ 0x4662F085), Type.GetTypeFromHandle(rwLk25Xv4a8IbZ6ZsPnC(16777225)), Type.GetTypeFromHandle(rwLk25Xv4a8IbZ6ZsPnC(33554469)));
					num = 4;
					break;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	internal static object C6uYiGXvY8HAgRtmU34o(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static bool H69dd7Xvn57P0RJ82JAN()
	{
		return JyVEtiXv90gCbyCUttCp == null;
	}

	internal static n7oSZ9i3KgbNmyR22k0d Wv0lbLXvGyZ0WdhMMQLZ()
	{
		return JyVEtiXv90gCbyCUttCp;
	}

	internal static object uJGbsdXvovyarblXwi1r(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void TpfKQ0XvvtlFS7gV4LjC(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static Key JIVmNFXvBC1dp68LoUEN(object P_0)
	{
		return ((KeyEventArgs)P_0).Key;
	}

	internal static void ll7WggXval3WwDA9o5BA()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static void IGelYrXviXAyk29SWEid()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static object wcbJkXXvlRXbwkSOAGks(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static RuntimeTypeHandle rwLk25Xv4a8IbZ6ZsPnC(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type a2iPw0XvDP1TqcXkSZLP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object QgHj8eXvbZkH0IRndWNU(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
