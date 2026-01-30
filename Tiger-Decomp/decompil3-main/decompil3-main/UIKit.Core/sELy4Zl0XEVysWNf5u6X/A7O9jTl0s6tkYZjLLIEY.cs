using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace sELy4Zl0XEVysWNf5u6X;

[TemplateVisualState(Name = "OnState")]
[TemplateVisualState(Name = "OffState")]
[TemplateVisualState(Name = "LoadingState")]
public class A7O9jTl0s6tkYZjLLIEY : ToggleButton
{
	public static readonly DependencyProperty fxvl0IHvf53;

	private static A7O9jTl0s6tkYZjLLIEY vLmOnsXaN0gZirGViZbY;

	public bool IsBusy
	{
		get
		{
			return (bool)GetValue(fxvl0IHvf53);
		}
		set
		{
			SetValue(fxvl0IHvf53, flag);
		}
	}

	static A7O9jTl0s6tkYZjLLIEY()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1594731a38ca4f1ca85d192afb773766 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				fxvl0IHvf53 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x1EFE0A28 ^ 0x1EFE0A7C), pfYqLuXaSlsrP5rimZ2N(CSUmEqXa5CM8U1eGyosF(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554487)), new PropertyMetadata(false, U7Bl0c5JHWj));
				FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(pfYqLuXaSlsrP5rimZ2N(CSUmEqXa5CM8U1eGyosF(33554487)), new FrameworkPropertyMetadata(Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554487))));
				return;
			case 1:
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_8498c2de12f54982b39e8d73ac4157f9 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public A7O9jTl0s6tkYZjLLIEY()
	{
		gHmLoMXaxuooiv8HJVhg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_78db3f70c2724c5d84fddcb4ca645af8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				DependencyPropertyDescriptor dependencyPropertyDescriptor = DependencyPropertyDescriptor.FromProperty(ToggleButton.IsCheckedProperty, Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554487)));
				sArcdpXaeq5COEohlcPQ(dependencyPropertyDescriptor, this, (EventHandler)delegate(object P_0, EventArgs P_1)
				{
					eqwl0ErvBcp(P_1);
				});
				return;
			}
			}
			DependencyPropertyDescriptor dependencyPropertyDescriptor2 = (DependencyPropertyDescriptor)Dloml8XaLNbbfQI799qe(UIElement.IsEnabledProperty, Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554487)));
			sArcdpXaeq5COEohlcPQ(dependencyPropertyDescriptor2, this, (EventHandler)delegate(object P_0, EventArgs P_1)
			{
				wW5l0jpog8y(P_1);
			});
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1a6c635ab4940dbb3ffcd364da08562 != 0)
			{
				num = 1;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		o7Dl0QC8MZP(_0020: false);
	}

	private static void U7Bl0c5JHWj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		A7O9jTl0s6tkYZjLLIEY a7O9jTl0s6tkYZjLLIEY = default(A7O9jTl0s6tkYZjLLIEY);
		while (true)
		{
			switch (num2)
			{
			case 1:
				a7O9jTl0s6tkYZjLLIEY = P_0 as A7O9jTl0s6tkYZjLLIEY;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_457e68c9d4ab4ecd899461247f8893ca == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			if (a7O9jTl0s6tkYZjLLIEY == null)
			{
				return;
			}
			a7O9jTl0s6tkYZjLLIEY.o7Dl0QC8MZP();
			num2 = 2;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_936331747ae74ee19c9bb932c2cd39d1 != 0)
			{
				num2 = 2;
			}
		}
	}

	private void wW5l0jpog8y(EventArgs P_0)
	{
		o7Dl0QC8MZP();
	}

	private void eqwl0ErvBcp(EventArgs P_0)
	{
		o7Dl0QC8MZP();
	}

	private void o7Dl0QC8MZP(bool P_0 = true)
	{
		int num = 1;
		bool flag2 = default(bool);
		bool? isChecked = default(bool?);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					break;
				default:
					if (flag2)
					{
						VisualStateManager.GoToState(this, OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-837284864 ^ -837286412), P_0);
						num2 = 3;
						continue;
					}
					isChecked = base.IsChecked;
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1b6d8ff14504513bad907cfbd3ee92f == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					flag2 = IsBusy;
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_97352da3f1db406e82084031ac91a168 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					VisualStateManager.GoToState(this, flag ? OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1962651919 ^ -1962654507) : OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2074141628 ^ -2074143148), P_0);
					return;
				}
				break;
			}
			flag = isChecked == true;
			num = 4;
		}
	}

	[CompilerGenerated]
	private void wgrl0dFGA25(object P_0, EventArgs P_1)
	{
		wW5l0jpog8y(P_1);
	}

	[CompilerGenerated]
	private void EQxl0gQBW32(object P_0, EventArgs P_1)
	{
		eqwl0ErvBcp(P_1);
	}

	internal static RuntimeTypeHandle CSUmEqXa5CM8U1eGyosF(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type pfYqLuXaSlsrP5rimZ2N(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool hJvuWFXak6fNLoke3Z8p()
	{
		return vLmOnsXaN0gZirGViZbY == null;
	}

	internal static A7O9jTl0s6tkYZjLLIEY pBoogKXa177CJ0iyDff5()
	{
		return vLmOnsXaN0gZirGViZbY;
	}

	internal static void gHmLoMXaxuooiv8HJVhg()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static object Dloml8XaLNbbfQI799qe(object P_0, Type P_1)
	{
		return DependencyPropertyDescriptor.FromProperty((DependencyProperty)P_0, P_1);
	}

	internal static void sArcdpXaeq5COEohlcPQ(object P_0, object P_1, object P_2)
	{
		((PropertyDescriptor)P_0).AddValueChanged(P_1, (EventHandler)P_2);
	}
}
