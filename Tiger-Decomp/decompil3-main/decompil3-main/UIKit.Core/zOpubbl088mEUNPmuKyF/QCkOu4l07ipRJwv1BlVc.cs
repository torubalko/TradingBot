using System;
using System.Windows;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace zOpubbl088mEUNPmuKyF;

public class QCkOu4l07ipRJwv1BlVc
{
	public static readonly DependencyProperty RemoveFocusOnEnterProperty;

	private static QCkOu4l07ipRJwv1BlVc fat4cYXaKFy82vsB4U24;

	public static void SetRemoveFocusOnEnter(DependencyObject element, bool value)
	{
		element.SetValue(RemoveFocusOnEnterProperty, value);
	}

	public static bool GetRemoveFocusOnEnter(DependencyObject element)
	{
		return (bool)M9iEMjXawA5suTsu7Z0O(element, RemoveFocusOnEnterProperty);
	}

	private static void SiEl0AAdcD6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 3;
		object newValue = default(object);
		bool flag = default(bool);
		FrameworkElement frameworkElement = default(FrameworkElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 6:
				{
					int num3;
					if (newValue is bool)
					{
						flag = (bool)newValue;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					if (num3 == 0)
					{
						return;
					}
					break;
				}
				case 3:
					goto end_IL_0012;
				case 2:
					if (frameworkElement == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_867f6430c8bf44129c7d3aede0ae7e7f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 4:
					newValue = P_1.NewValue;
					num2 = 3;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_dae2a0acfd5b428ba7eb3ad10fcbb7da != 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					return;
				}
				if (!flag)
				{
					return;
				}
				frameworkElement.KeyDown += mmdl0Ja5tm0;
				frameworkElement.Unloaded += Hqil0PZfPsT;
				num2 = 4;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a4dd3ba864e24f44bf9ef3932a4f38e3 == 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			frameworkElement = P_0 as FrameworkElement;
			num = 2;
		}
	}

	private static void Hqil0PZfPsT(object P_0, RoutedEventArgs P_1)
	{
		int num;
		if (P_0 is FrameworkElement frameworkElement)
		{
			jWbBk3Xa7mrIkSUhpyfM(frameworkElement, new RoutedEventHandler(Hqil0PZfPsT));
			frameworkElement.KeyDown -= mmdl0Ja5tm0;
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0186f9916c474408b21410971ecb054c != 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6cac8bca385d4f06aa9f854441c8d5db != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			break;
		}
	}

	private static void mmdl0Ja5tm0(object P_0, KeyEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 2:
				if (flag)
				{
					Keyboard.ClearFocus();
				}
				return;
			case 1:
				if (P_1.Key != Key.Return)
				{
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_13cf2cd6b38241bbaa1a8ec9e9113aad == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = 1;
				break;
			default:
				num3 = ((P_1.Key == Key.Return) ? 1 : 0);
				break;
			}
			flag = (byte)num3 != 0;
			num2 = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0bd24d908e924c0b83abf9fb2f7c1f25 == 0)
			{
				num2 = 2;
			}
		}
	}

	public QCkOu4l07ipRJwv1BlVc()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	static QCkOu4l07ipRJwv1BlVc()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_44d5028189244b3b837cdd6ae856eaca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		RemoveFocusOnEnterProperty = DependencyProperty.RegisterAttached((string)puVTbrXa8JO2wPJGoFWh(-57768881 ^ -57766155), Type.GetTypeFromHandle(Rbt9bqXaAqyvTZKv0I3j(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554490)), new PropertyMetadata(false, SiEl0AAdcD6));
	}

	internal static bool YU62jKXamOCFKUKi9aLi()
	{
		return fat4cYXaKFy82vsB4U24 == null;
	}

	internal static QCkOu4l07ipRJwv1BlVc PAhtFQXahMxhReoPKCOy()
	{
		return fat4cYXaKFy82vsB4U24;
	}

	internal static object M9iEMjXawA5suTsu7Z0O(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void jWbBk3Xa7mrIkSUhpyfM(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Unloaded -= (RoutedEventHandler)P_1;
	}

	internal static object puVTbrXa8JO2wPJGoFWh(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static RuntimeTypeHandle Rbt9bqXaAqyvTZKv0I3j(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}
}
