using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

[TemplatePart(Name = "PART_EditableTextBox", Type = typeof(TextBox))]
[TemplatePart(Name = "ErrorViewPopup", Type = typeof(Popup))]
public class DropDown : ComboBox
{
	private Popup x36iFx53PJq;

	private TextBox sVuiFLie19B;

	private bool nYmiFeFyEj0;

	private bool p7AiFsVAgFj;

	private bool moJiFXPDQcR;

	public static readonly DependencyProperty dYFiFcNQtYr;

	public static readonly DependencyProperty P7siFjG0QcO;

	public static readonly DependencyProperty UAXiFEaoZrt;

	public static readonly DependencyProperty F6diFQUAeQ2;

	public static readonly DependencyProperty d9iiFdFIeHs;

	public static readonly DependencyProperty veXiFg8oJAB;

	public static readonly DependencyProperty TsKiFR165et;

	public static readonly DependencyProperty IsSmallProperty;

	public static readonly DependencyProperty rTsiF6vYvHT;

	public static readonly DependencyProperty HXviFMJiqAV;

	public static readonly DependencyProperty hesiFO1fQAN;

	public static readonly DependencyProperty CawiFqM7dhe;

	private INotifyCollectionChanged vhGiFIPE3rU;

	internal static DropDown cVNBeLXo9SyF1iTdnWe3;

	public string Header
	{
		get
		{
			return (string)GetValue(dYFiFcNQtYr);
		}
		set
		{
			WLD3v6XolanXMnfdQ21t(this, dYFiFcNQtYr, text);
		}
	}

	public string InfoText
	{
		get
		{
			return (string)GetValue(P7siFjG0QcO);
		}
		set
		{
			WLD3v6XolanXMnfdQ21t(this, P7siFjG0QcO, text);
		}
	}

	public string Placeholder
	{
		get
		{
			return (string)A7VvOQXo4XjQJAT2xlXO(this, UAXiFEaoZrt);
		}
		set
		{
			WLD3v6XolanXMnfdQ21t(this, UAXiFEaoZrt, text);
		}
	}

	public string LinkText
	{
		get
		{
			return (string)GetValue(F6diFQUAeQ2);
		}
		set
		{
			SetValue(F6diFQUAeQ2, value2);
		}
	}

	public bool IsLinkArrowVisible
	{
		get
		{
			return (bool)A7VvOQXo4XjQJAT2xlXO(this, d9iiFdFIeHs);
		}
		set
		{
			SetValue(d9iiFdFIeHs, flag);
		}
	}

	public ICommand LinkCommand
	{
		get
		{
			return (ICommand)A7VvOQXo4XjQJAT2xlXO(this, veXiFg8oJAB);
		}
		set
		{
			SetValue(veXiFg8oJAB, value2);
		}
	}

	public object LinkCommandParameter
	{
		get
		{
			return GetValue(TsKiFR165et);
		}
		set
		{
			SetValue(TsKiFR165et, value2);
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
			WLD3v6XolanXMnfdQ21t(this, IsSmallProperty, flag);
		}
	}

	public string ErrorMessage
	{
		get
		{
			return (string)A7VvOQXo4XjQJAT2xlXO(this, rTsiF6vYvHT);
		}
		set
		{
			SetValue(rTsiF6vYvHT, value2);
		}
	}

	public bool IsErrorVisible
	{
		get
		{
			return (bool)A7VvOQXo4XjQJAT2xlXO(this, HXviFMJiqAV);
		}
		set
		{
			SetValue(HXviFMJiqAV, flag);
		}
	}

	public bool IsFocusedFromKeyboard
	{
		get
		{
			return (bool)GetValue(hesiFO1fQAN);
		}
		set
		{
			SetValue(hesiFO1fQAN, flag);
		}
	}

	public object BottomPopupContent
	{
		get
		{
			return GetValue(CawiFqM7dhe);
		}
		set
		{
			SetValue(CawiFqM7dhe, value2);
		}
	}

	public DropDown()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		nYmiFeFyEj0 = false;
		p7AiFsVAgFj = false;
		moJiFXPDQcR = false;
		base._002Ector();
		int num = 5;
		DependencyPropertyDescriptor dependencyPropertyDescriptor = default(DependencyPropertyDescriptor);
		while (true)
		{
			switch (num)
			{
			case 1:
				dependencyPropertyDescriptor = DependencyPropertyDescriptor.FromProperty(ComboBox.IsReadOnlyProperty, Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_676a22a67a2e42df98963bf8d98eb889 == 0)
				{
					num = 0;
				}
				break;
			default:
				nUDgAeXoiexwI4SichGA(dependencyPropertyDescriptor, this, (EventHandler)delegate(object P_0, EventArgs P_1)
				{
					a2hiJVMERLK(P_1);
				});
				return;
			case 5:
			{
				base.DefaultStyleKey = Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466));
				ac9jZgXoYNQAQ55WcmjQ(this, new RoutedEventHandler(h3PiJwA6mIT));
				int num2 = 4;
				num = num2;
				break;
			}
			case 3:
				Cyvxk6XoBIThM50Qs1fS(this, new EventHandler(uapiJAiP37y));
				l9o32xXoaePkS2FOZ7uZ(this, new KeyEventHandler(FkEiJJOmsjK));
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2de1ce522cf44e4cac85a49e39c09b28 != 0)
				{
					num = 0;
				}
				break;
			case 4:
				zS9sQqXooctDY5eXTCQP(this, new RoutedEventHandler(soGiJ7TbVMq));
				num = 2;
				break;
			case 2:
				base.PreviewMouseDown += HETiJ8H99iB;
				yJ4wvkXovtdRSS7FEmx4(this, new EventHandler(VntiJPsuj5C));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b3963df8083a49d0b999c02f6b3ac8e5 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	private static void CRCiJZmTuiL(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		DropDown dropDown = default(DropDown);
		object newValue = default(object);
		bool isOpen = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 1:
				if (dropDown == null)
				{
					return;
				}
				newValue = P_1.NewValue;
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f97c2b59553f423fb8445ca09317c97d == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				isOpen = (bool)newValue;
				num2 = 6;
				break;
			default:
				if (!flag)
				{
					dropDown.x36iFx53PJq.IsOpen = isOpen;
				}
				return;
			case 4:
				flag = dropDown.x36iFx53PJq == null;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_bdf9ffaedfd8484d8034adffb350a786 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				dropDown = P_0 as DropDown;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_73b6a8536efd4e5ba31378391aa47e85 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (newValue is bool)
				{
					num2 = 5;
					break;
				}
				num3 = 0;
				goto IL_012c;
			case 6:
				{
					num3 = 1;
					goto IL_012c;
				}
				IL_012c:
				if (num3 == 0)
				{
					return;
				}
				goto case 4;
			}
		}
	}

	private void a2hiJVMERLK(EventArgs P_0)
	{
		int num;
		if (!base.IsReadOnly)
		{
			VisualStateManager.GoToState(this, (string)tuSixLXoDPSJJSQIQLtS(-5977659 ^ -5976393), useTransitions: true);
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6d9219368a864c2d9c7ba55f24c4b4c6 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_9f8ecae2cf874f8089694e259de8b5f7 == 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			VisualStateManager.GoToState(this, (string)tuSixLXoDPSJJSQIQLtS(-1153206687 ^ -1153208001), useTransitions: true);
			break;
		case 0:
			break;
		}
	}

	public override void OnApplyTemplate()
	{
		x36iFx53PJq = GetTemplateChild(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x28B345BB ^ 0x28B343B1)) as Popup;
		sVuiFLie19B = GetTemplateChild(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x28B345BB ^ 0x28B34239)) as TextBox;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5cd8e53bfc054438a37c94de95b33088 != 0)
		{
			num = 3;
		}
		bool isReadOnly = default(bool);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (sVuiFLie19B != null)
				{
					sVuiFLie19B.TextChanged += qSLiJrfCvWM;
					sVuiFLie19B.GotFocus += MNViJCxEnnR;
					goto case 2;
				}
				num = 2;
				break;
			case 2:
				isReadOnly = base.IsReadOnly;
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a863574b23b747caa2b08ae3edec8640 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				H9hZycXoNZY5GHinB2Er(this);
				return;
			default:
				if (isReadOnly)
				{
					EgIrbkXobtWYwc1xWBRO(this, OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2123795572 ^ -2123795246), true);
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a863574b23b747caa2b08ae3edec8640 == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	private void MNViJCxEnnR(object P_0, RoutedEventArgs P_1)
	{
		IsFocusedFromKeyboard = true;
	}

	private void qSLiJrfCvWM(object P_0, TextChangedEventArgs P_1)
	{
		if (base.IsDropDownOpen || !ylexm8Xokr3UjfO8fjNa(sVuiFLie19B))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_00e09dc7183a485ea31bd9282e0f2cd4 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			base.IsDropDownOpen = true;
			num = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_847a34ceceb940cb835fbd83b690b6cf == 0)
			{
				num = 1;
			}
		}
	}

	protected override void OnItemsSourceChanged(IEnumerable P_0, IEnumerable P_1)
	{
		base.OnItemsSourceChanged(P_0, P_1);
		INotifyCollectionChanged notifyCollectionChanged = P_1 as INotifyCollectionChanged;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_cc0a9b45cb4f45a7adab1adba50d4a70 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				vhGiFIPE3rU.CollectionChanged -= TDViJKTpUna;
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_26b3e8355b0647d7acbfe1c7692947fd != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				if (notifyCollectionChanged == null)
				{
					break;
				}
				if (vhGiFIPE3rU != null)
				{
					goto case 3;
				}
				goto default;
			default:
				vhGiFIPE3rU = notifyCollectionChanged;
				num = 2;
				continue;
			case 2:
				jy2Ye8Xo1WMlnR3wduuH(vhGiFIPE3rU, new NotifyCollectionChangedEventHandler(TDViJKTpUna));
				break;
			}
			break;
		}
		H6uiJmEZa9y();
	}

	private void TDViJKTpUna(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		H6uiJmEZa9y();
	}

	private void H6uiJmEZa9y()
	{
		base.IsReadOnly = !base.IsEditable && QyBxQkXoSTPgoGK3XZQE(FVsXgcXo5uwPeRBMshrM(this)) < 2 && BottomPopupContent == null;
	}

	private static void z4miJhr1l9r(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		DropDown dropDown = default(DropDown);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dropDown = P_0 as DropDown;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_bdf9ffaedfd8484d8034adffb350a786 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				flag = dropDown == null;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (!flag)
				{
					dropDown.IsReadOnly = !dropDown.IsEditable && QyBxQkXoSTPgoGK3XZQE(dropDown.Items) < 2 && P_1.NewValue == null;
				}
				return;
			}
		}
	}

	private void h3PiJwA6mIT(object P_0, RoutedEventArgs P_1)
	{
		int num;
		bool flag = default(bool);
		if (base.IsEditable)
		{
			IsFocusedFromKeyboard = true;
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0e4e3e10f47f4fbdadc4c1fff6fde999 == 0)
			{
				num = 0;
			}
		}
		else
		{
			flag = !moJiFXPDQcR;
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				base.IsDropDownOpen = true;
				return;
			case 2:
				if (flag)
				{
					IsFocusedFromKeyboard = !nYmiFeFyEj0;
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_72636cc658db410dbd2030e9fe5ca30c != 0)
					{
						num = 1;
					}
					break;
				}
				return;
			case 1:
				return;
			}
		}
	}

	private void soGiJ7TbVMq(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = !base.IsDropDownOpen;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e0422e3937cf4958b4c4343ee25d0b9a == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			if (!flag)
			{
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1a27a07fa480489cbce606bf6f419593 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			IsFocusedFromKeyboard = false;
			nYmiFeFyEj0 = false;
			return;
		}
	}

	private void HETiJ8H99iB(object P_0, MouseButtonEventArgs P_1)
	{
		int num;
		if (oo3YeRXoxXtrh7nUxTYF(this))
		{
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_af46a509e9534fea96b5ad3b1ed7edfc == 0)
			{
				num = 0;
			}
		}
		else
		{
			IsFocusedFromKeyboard = false;
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_156f781fb1b2449cbaf69125616eaf4b != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			nYmiFeFyEj0 = true;
			break;
		case 0:
			break;
		}
	}

	private void uapiJAiP37y(object P_0, EventArgs P_1)
	{
		if (!oo3YeRXoxXtrh7nUxTYF(this))
		{
			p7AiFsVAgFj = nYmiFeFyEj0;
			moJiFXPDQcR = true;
		}
	}

	private void VntiJPsuj5C(object P_0, EventArgs P_1)
	{
		int num;
		if (oo3YeRXoxXtrh7nUxTYF(this))
		{
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a4dd3ba864e24f44bf9ef3932a4f38e3 == 0)
			{
				num = 1;
			}
		}
		else
		{
			nYmiFeFyEj0 = p7AiFsVAgFj;
			IsFocusedFromKeyboard = !nYmiFeFyEj0;
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_42b310095a3c40c8b2751106577afb55 != 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			return;
		}
		moJiFXPDQcR = false;
	}

	private void FkEiJJOmsjK(object P_0, KeyEventArgs P_1)
	{
		bool flag = !base.IsDropDownOpen && (P_1.Key == Key.Space || P_1.Key == Key.Return);
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_668c29c4a5854494b66fe0091e71ecb8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				P_1.Handled = true;
				return;
			case 2:
				idofJHXoL7GEfc9VW24s(this, true);
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_2de1ce522cf44e4cac85a49e39c09b28 == 0)
				{
					num = 1;
				}
				continue;
			}
			if (flag)
			{
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_803c47111668403c8cad114fc119cb89 == 0)
				{
					num = 1;
				}
				continue;
			}
			return;
		}
	}

	static DropDown()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 5:
				rTsiF6vYvHT = (DependencyProperty)ItCfoUXosn8wMIVnblqo(tuSixLXoDPSJJSQIQLtS(-3429745 ^ -3429211), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)));
				HXviFMJiqAV = DependencyProperty.Register((string)tuSixLXoDPSJJSQIQLtS(0x746ED405 ^ 0x746ED25D), J1n4uuXoXHHH2Mdd4e5L(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)), new PropertyMetadata(false, CRCiJZmTuiL));
				hesiFO1fQAN = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x130FEA25 ^ 0x130FEB7B), Type.GetTypeFromHandle(KdvHEyXoeekqaDQ9dW8c(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)));
				num = 3;
				break;
			case 3:
				CawiFqM7dhe = DependencyProperty.Register((string)tuSixLXoDPSJJSQIQLtS(-3429745 ^ -3429049), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)), new UIPropertyMetadata(z4miJhr1l9r));
				return;
			default:
				F6diFQUAeQ2 = DependencyProperty.Register((string)tuSixLXoDPSJJSQIQLtS(-894902996 ^ -894902728), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), J1n4uuXoXHHH2Mdd4e5L(KdvHEyXoeekqaDQ9dW8c(33554466)));
				d9iiFdFIeHs = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(--18459671 ^ 0x119AF3F), J1n4uuXoXHHH2Mdd4e5L(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(KdvHEyXoeekqaDQ9dW8c(33554466)));
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_af46a509e9534fea96b5ad3b1ed7edfc != 0)
				{
					num = 1;
				}
				break;
			case 1:
				veXiFg8oJAB = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-842040449 ^ -842041297), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), J1n4uuXoXHHH2Mdd4e5L(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)));
				TsKiFR165et = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-45476899 ^ -45477705), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)));
				IsSmallProperty = (DependencyProperty)iNWKgKXoctX2SAt08hvT(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-203064540 ^ -203063966), Type.GetTypeFromHandle(KdvHEyXoeekqaDQ9dW8c(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)), new UIPropertyMetadata(false));
				num = 5;
				break;
			case 4:
				dYFiFcNQtYr = DependencyProperty.Register((string)tuSixLXoDPSJJSQIQLtS(-673683647 ^ -673683707), Type.GetTypeFromHandle(KdvHEyXoeekqaDQ9dW8c(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)));
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_13cf2cd6b38241bbaa1a8ec9e9113aad == 0)
				{
					num = 1;
				}
				break;
			case 2:
				P7siFjG0QcO = DependencyProperty.Register((string)tuSixLXoDPSJJSQIQLtS(0x4662F6AF ^ 0x4662F5AF), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(KdvHEyXoeekqaDQ9dW8c(33554466)));
				UAXiFEaoZrt = (DependencyProperty)ItCfoUXosn8wMIVnblqo(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1878953018 ^ -1878952856), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554466)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_936331747ae74ee19c9bb932c2cd39d1 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void bFYiJFTnTxS(object P_0, EventArgs P_1)
	{
		a2hiJVMERLK(P_1);
	}

	internal static void ac9jZgXoYNQAQ55WcmjQ(object P_0, object P_1)
	{
		((UIElement)P_0).GotFocus += (RoutedEventHandler)P_1;
	}

	internal static void zS9sQqXooctDY5eXTCQP(object P_0, object P_1)
	{
		((UIElement)P_0).LostFocus += (RoutedEventHandler)P_1;
	}

	internal static void yJ4wvkXovtdRSS7FEmx4(object P_0, object P_1)
	{
		((ComboBox)P_0).DropDownClosed += (EventHandler)P_1;
	}

	internal static void Cyvxk6XoBIThM50Qs1fS(object P_0, object P_1)
	{
		((ComboBox)P_0).DropDownOpened += (EventHandler)P_1;
	}

	internal static void l9o32xXoaePkS2FOZ7uZ(object P_0, object P_1)
	{
		((UIElement)P_0).PreviewKeyDown += (KeyEventHandler)P_1;
	}

	internal static void nUDgAeXoiexwI4SichGA(object P_0, object P_1, object P_2)
	{
		((PropertyDescriptor)P_0).AddValueChanged(P_1, (EventHandler)P_2);
	}

	internal static bool HeUOc0Xonnuv9KgQK0p1()
	{
		return cVNBeLXo9SyF1iTdnWe3 == null;
	}

	internal static DropDown WoZ9HMXoGbPrBErOmdii()
	{
		return cVNBeLXo9SyF1iTdnWe3;
	}

	internal static void WLD3v6XolanXMnfdQ21t(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object A7VvOQXo4XjQJAT2xlXO(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static object tuSixLXoDPSJJSQIQLtS(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static bool EgIrbkXobtWYwc1xWBRO(object P_0, object P_1, bool P_2)
	{
		return VisualStateManager.GoToState((FrameworkElement)P_0, (string)P_1, P_2);
	}

	internal static void H9hZycXoNZY5GHinB2Er(object P_0)
	{
		((ComboBox)P_0).OnApplyTemplate();
	}

	internal static bool ylexm8Xokr3UjfO8fjNa(object P_0)
	{
		return ((UIElement)P_0).IsFocused;
	}

	internal static void jy2Ye8Xo1WMlnR3wduuH(object P_0, object P_1)
	{
		((INotifyCollectionChanged)P_0).CollectionChanged += (NotifyCollectionChangedEventHandler)P_1;
	}

	internal static object FVsXgcXo5uwPeRBMshrM(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static int QyBxQkXoSTPgoGK3XZQE(object P_0)
	{
		return ((CollectionView)P_0).Count;
	}

	internal static bool oo3YeRXoxXtrh7nUxTYF(object P_0)
	{
		return ((ComboBox)P_0).IsEditable;
	}

	internal static void idofJHXoL7GEfc9VW24s(object P_0, bool P_1)
	{
		((ComboBox)P_0).IsDropDownOpen = P_1;
	}

	internal static RuntimeTypeHandle KdvHEyXoeekqaDQ9dW8c(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static object ItCfoUXosn8wMIVnblqo(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static Type J1n4uuXoXHHH2Mdd4e5L(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object iNWKgKXoctX2SAt08hvT(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
