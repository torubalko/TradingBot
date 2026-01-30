using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

[TemplatePart(Name = "ErrorViewPopup", Type = typeof(Popup))]
public class CheckBox : System.Windows.Controls.CheckBox
{
	private Popup O1piJNsIt12;

	private bool fQjiJkMrgWM;

	public static readonly DependencyProperty GqUiJ1fl4yu;

	public static readonly DependencyProperty qVKiJ5FA5jo;

	public static readonly DependencyProperty IsSmallProperty;

	public static readonly DependencyProperty wddiJSqoVET;

	public static readonly DependencyProperty J6JiJxgtDAc;

	private static CheckBox zbLuEDXYyOlKNosdhhXq;

	public string InfoText
	{
		get
		{
			return (string)za23lSXYmIhbIn81fcKw(this, GqUiJ1fl4yu);
		}
		set
		{
			SetValue(GqUiJ1fl4yu, value2);
		}
	}

	public string ErrorMessage
	{
		get
		{
			return (string)za23lSXYmIhbIn81fcKw(this, qVKiJ5FA5jo);
		}
		set
		{
			DMoed8XYhmmaLNUWp1cT(this, qVKiJ5FA5jo, text);
		}
	}

	public bool IsSmall
	{
		get
		{
			return (bool)za23lSXYmIhbIn81fcKw(this, IsSmallProperty);
		}
		set
		{
			SetValue(IsSmallProperty, flag);
		}
	}

	public bool IsErrorVisible
	{
		get
		{
			return (bool)GetValue(wddiJSqoVET);
		}
		set
		{
			SetValue(wddiJSqoVET, flag);
		}
	}

	public bool IsFocusedFromKeyboard
	{
		get
		{
			return (bool)GetValue(J6JiJxgtDAc);
		}
		set
		{
			SetValue(J6JiJxgtDAc, flag);
		}
	}

	public CheckBox()
	{
		KnbxqbXYC6gQb9FutBr0();
		fQjiJkMrgWM = false;
		base._002Ector();
		base.GotFocus += PpuiJf7eKvX;
		base.LostFocus += vPIiJ9ZQbDe;
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5e0114e6421d4bf1bbeb31361714f3af != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				base.PreviewMouseDown += AohiJn0LG4b;
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2de1ce522cf44e4cac85a49e39c09b28 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		O1piJNsIt12 = uIioEFXYKduchKOYGOZA(this, B1W2QdXYrhgkyUxZRTK7(-1047165041 ^ -1047166587)) as Popup;
		base.OnApplyTemplate();
	}

	private static void VbMiJHEcscl(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		CheckBox checkBox = default(CheckBox);
		object newValue = default(object);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 2:
					num3 = 1;
					goto IL_012e;
				default:
					if (checkBox == null)
					{
						return;
					}
					goto end_IL_0012;
				case 6:
					newValue = P_1.NewValue;
					num2 = 5;
					continue;
				case 3:
					return;
				case 5:
					if (newValue is bool)
					{
						flag = (bool)newValue;
						num2 = 1;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_9249cfe3564840d59be521a3d2da53f1 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					num3 = 0;
					goto IL_012e;
				case 1:
					checkBox = P_0 as CheckBox;
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e500693622c345f4b5a2910bf7d09298 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
					IL_012e:
					if (num3 == 0 || checkBox.O1piJNsIt12 == null)
					{
						return;
					}
					break;
				}
				pjCH9gXYwR76yq4nujlv(checkBox.O1piJNsIt12, flag);
				return;
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	private void PpuiJf7eKvX(object P_0, RoutedEventArgs P_1)
	{
		int num;
		if (!Equals(y0EJcWXY7MXicnfLDqHf(P_1)))
		{
			num = 2;
			goto IL_0009;
		}
		goto IL_0077;
		IL_0077:
		bool flag = !fQjiJkMrgWM;
		num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_97352da3f1db406e82084031ac91a168 != 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			if (flag)
			{
				IsFocusedFromKeyboard = true;
			}
			fQjiJkMrgWM = false;
			return;
		case 2:
			return;
		}
		goto IL_0077;
	}

	private void vPIiJ9ZQbDe(object P_0, RoutedEventArgs P_1)
	{
		IsFocusedFromKeyboard = false;
		fQjiJkMrgWM = false;
	}

	private void AohiJn0LG4b(object P_0, MouseButtonEventArgs P_1)
	{
		fQjiJkMrgWM = true;
	}

	static CheckBox()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				cs9myyXY8f00rK2xmgcv();
				num2 = 2;
				break;
			case 1:
				qVKiJ5FA5jo = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-837284864 ^ -837285334), Type.GetTypeFromHandle(naStFrXYA5uhO2GmKQSk(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554464)));
				IsSmallProperty = DependencyProperty.Register((string)B1W2QdXYrhgkyUxZRTK7(--500511424 ^ 0x1DD53486), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), OqodAwXYPVMS6P4qg6sq(naStFrXYA5uhO2GmKQSk(33554464)), new UIPropertyMetadata(false));
				wddiJSqoVET = DependencyProperty.Register((string)B1W2QdXYrhgkyUxZRTK7(0x6AB40973 ^ 0x6AB40F2B), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(naStFrXYA5uhO2GmKQSk(33554464)), new PropertyMetadata(false, VbMiJHEcscl));
				J6JiJxgtDAc = (DependencyProperty)dvuy4TXYJLsjZh62oVLi(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-520155535 ^ -520155345), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), OqodAwXYPVMS6P4qg6sq(naStFrXYA5uhO2GmKQSk(33554464)));
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_847a34ceceb940cb835fbd83b690b6cf == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				GqUiJ1fl4yu = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1878953018 ^ -1878953786), OqodAwXYPVMS6P4qg6sq(naStFrXYA5uhO2GmKQSk(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554464)));
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1b6d8ff14504513bad907cfbd3ee92f == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void KnbxqbXYC6gQb9FutBr0()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static bool v0bUg2XYZBQQX1MnDL2o()
	{
		return zbLuEDXYyOlKNosdhhXq == null;
	}

	internal static CheckBox SgK3EIXYVioOGD9CHdPP()
	{
		return zbLuEDXYyOlKNosdhhXq;
	}

	internal static object B1W2QdXYrhgkyUxZRTK7(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static object uIioEFXYKduchKOYGOZA(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static object za23lSXYmIhbIn81fcKw(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void DMoed8XYhmmaLNUWp1cT(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void pjCH9gXYwR76yq4nujlv(object P_0, bool P_1)
	{
		((System.Windows.Controls.Primitives.Popup)P_0).IsOpen = P_1;
	}

	internal static object y0EJcWXY7MXicnfLDqHf(object P_0)
	{
		return ((RoutedEventArgs)P_0).Source;
	}

	internal static void cs9myyXY8f00rK2xmgcv()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static RuntimeTypeHandle naStFrXYA5uhO2GmKQSk(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type OqodAwXYPVMS6P4qg6sq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object dvuy4TXYJLsjZh62oVLi(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
