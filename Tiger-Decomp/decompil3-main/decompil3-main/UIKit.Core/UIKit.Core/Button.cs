using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

public class Button : System.Windows.Controls.Button
{
	public static readonly DependencyProperty TVqi7Rj8lWp;

	public static readonly DependencyProperty TGci76SQANB;

	public static readonly DependencyProperty sJui7MF6Zst;

	internal static Button mJO4ZIXnvVJQ02Hfpx7I;

	public bool IsBusy
	{
		get
		{
			return (bool)NHyguoXnbYRdEnliat5e(this, TVqi7Rj8lWp);
		}
		set
		{
			SetValue(TVqi7Rj8lWp, flag);
		}
	}

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)NHyguoXnbYRdEnliat5e(this, TGci76SQANB);
		}
		set
		{
			SetValue(TGci76SQANB, cornerRadius);
		}
	}

	public bool IsFocusedFromKeyboard
	{
		get
		{
			return (bool)GetValue(sJui7MF6Zst);
		}
		set
		{
			NKVGPWXnNlZAQxcttp1H(this, sJui7MF6Zst, flag);
		}
	}

	public Button()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static Button()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_97352da3f1db406e82084031ac91a168 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				sJui7MF6Zst = DependencyProperty.Register((string)nQAFapXniBtr43gDGD2g(-838841832 ^ -838841530), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(MxhoaBXnlk68OhxZTcc4(33554445)));
				qQvrlvXnDCEoW6yQli0N(FrameworkElement.DefaultStyleKeyProperty, Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554445)), new FrameworkPropertyMetadata(Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554445))));
				return;
			case 1:
				TVqi7Rj8lWp = DependencyProperty.Register((string)nQAFapXniBtr43gDGD2g(0x4662F6AF ^ 0x4662F6FB), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554445)), new PropertyMetadata(false));
				TGci76SQANB = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x22BF43FC ^ 0x22BF42BE), MODS2OXn4UyCp4Ugyi7o(MxhoaBXnlk68OhxZTcc4(16777283)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554445)), new PropertyMetadata(default(CornerRadius)));
				num = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_800979ef175f4570a283be4fa8173624 == 0)
				{
					num = 1;
				}
				break;
			default:
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e45e5ac62513442e89d79a2fa6de9ea2 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs P_0)
	{
		base.OnIsKeyboardFocusWithinChanged(P_0);
		IsFocusedFromKeyboard = InputManager.Current.MostRecentInputDevice is KeyboardDevice && (bool)P_0.NewValue;
	}

	internal static bool GfJLuCXnBPbmEJ1UgxQH()
	{
		return mJO4ZIXnvVJQ02Hfpx7I == null;
	}

	internal static Button P2BAANXnaxKivbL2rcTs()
	{
		return mJO4ZIXnvVJQ02Hfpx7I;
	}

	internal static object nQAFapXniBtr43gDGD2g(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static RuntimeTypeHandle MxhoaBXnlk68OhxZTcc4(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type MODS2OXn4UyCp4Ugyi7o(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void qQvrlvXnDCEoW6yQli0N(object P_0, Type P_1, object P_2)
	{
		((DependencyProperty)P_0).OverrideMetadata(P_1, (PropertyMetadata)P_2);
	}

	internal static object NHyguoXnbYRdEnliat5e(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void NKVGPWXnNlZAQxcttp1H(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}
}
