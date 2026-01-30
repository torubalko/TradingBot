using System;
using System.Windows;
using System.Windows.Media;
using frv4s5X5SOo66jNvMvO6;
using hkZMMTXxD6qN8IAyOFGI;
using MhxjOdXxkI6wEJmk4G3f;
using PWXKwRXxL9cVgWUpa4xk;

namespace UIKIt.Templates.Buttons;

public class VisualStyleProperties : DependencyObject
{
	public static readonly DependencyProperty NormalBackgroundProperty;

	public static readonly DependencyProperty MouseOverBackgroundProperty;

	public static readonly DependencyProperty PressedBackgroundProperty;

	public static readonly DependencyProperty DisabledBackgroundProperty;

	public static readonly DependencyProperty BusyBackgroundProperty;

	public static readonly DependencyProperty FocusedCornerRadiusProperty;

	internal static VisualStyleProperties CCXnBeXgXL6Q0h2DfAxq;

	public static void SetNormalBackground(DependencyObject element, Brush value)
	{
		element.SetValue(NormalBackgroundProperty, value);
	}

	public static Brush GetNormalBackground(DependencyObject element)
	{
		return (Brush)s4FCpLXgEIdybX0NpXd1(element, NormalBackgroundProperty);
	}

	public static void SetMouseOverBackground(DependencyObject element, Brush value)
	{
		fyS5CQXgQc7U6PDsbqr3(element, MouseOverBackgroundProperty, value);
	}

	public static Brush GetMouseOverBackground(DependencyObject element)
	{
		return (Brush)s4FCpLXgEIdybX0NpXd1(element, MouseOverBackgroundProperty);
	}

	public static void SetPressedBackground(DependencyObject element, Brush value)
	{
		element.SetValue(PressedBackgroundProperty, value);
	}

	public static Brush GetPressedBackground(DependencyObject element)
	{
		return (Brush)s4FCpLXgEIdybX0NpXd1(element, PressedBackgroundProperty);
	}

	public static void SetDisabledBackground(DependencyObject element, Brush value)
	{
		element.SetValue(DisabledBackgroundProperty, value);
	}

	public static Brush GetDisabledBackground(DependencyObject element)
	{
		return (Brush)s4FCpLXgEIdybX0NpXd1(element, DisabledBackgroundProperty);
	}

	public static void SetBusyBackground(DependencyObject element, Brush value)
	{
		element.SetValue(BusyBackgroundProperty, value);
	}

	public static Brush GetBusyBackground(DependencyObject element)
	{
		return (Brush)element.GetValue(BusyBackgroundProperty);
	}

	public static void SetFocusedCornerRadius(DependencyObject element, CornerRadius value)
	{
		element.SetValue(FocusedCornerRadiusProperty, value);
	}

	public static CornerRadius GetFocusedCornerRadius(DependencyObject element)
	{
		return (CornerRadius)s4FCpLXgEIdybX0NpXd1(element, FocusedCornerRadiusProperty);
	}

	public VisualStyleProperties()
	{
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
		base._002Ector();
	}

	static VisualStyleProperties()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				FocusedCornerRadiusProperty = DependencyProperty.RegisterAttached((string)g78cmGXgdDZ9JAAn0BJs(0x706541F3 ^ 0x7065433B), Type.GetTypeFromHandle(HXVKCdXggJUZgOONdUoO(16777268)), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554443)), new PropertyMetadata(default(CornerRadius)));
				return;
			case 3:
				NormalBackgroundProperty = DependencyProperty.RegisterAttached((string)g78cmGXgdDZ9JAAn0BJs(0x4297C3EB ^ 0x4297C1E7), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777267)), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554443)), new PropertyMetadata((object)null));
				num2 = 4;
				break;
			case 1:
				RMpEErX55SDH1mxasQVF.v64X5Ol3UFK();
				num2 = 0;
				if (_003CModule_003E_007Babb06716_002D70a8_002D4032_002Db545_002D6fbf61bd2cd6_007D.m_2661ddc7bf334dca8f3f7d382ac20a6f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				MouseOverBackgroundProperty = DependencyProperty.RegisterAttached(RMpEErX55SDH1mxasQVF.pbtX5yHUPdJ(-2002318893 ^ -2002318365), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777267)), dSk92KXgRJTH9tn25Wc2(HXVKCdXggJUZgOONdUoO(33554443)), new PropertyMetadata((object)null));
				PressedBackgroundProperty = DependencyProperty.RegisterAttached((string)g78cmGXgdDZ9JAAn0BJs(0x746ED405 ^ 0x746ED65F), dSk92KXgRJTH9tn25Wc2(HXVKCdXggJUZgOONdUoO(16777267)), dSk92KXgRJTH9tn25Wc2(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554443)), new PropertyMetadata((object)null));
				DisabledBackgroundProperty = DependencyProperty.RegisterAttached((string)g78cmGXgdDZ9JAAn0BJs(-1461292091 ^ -1461292731), Type.GetTypeFromHandle(HXVKCdXggJUZgOONdUoO(16777267)), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554443)), new PropertyMetadata((object)null));
				BusyBackgroundProperty = DependencyProperty.RegisterAttached((string)g78cmGXgdDZ9JAAn0BJs(-1763895751 ^ -1763896175), dSk92KXgRJTH9tn25Wc2(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777267)), dSk92KXgRJTH9tn25Wc2(HXVKCdXggJUZgOONdUoO(33554443)), new PropertyMetadata((object)null));
				num2 = 2;
				if (_003CModule_003E_007Babb06716_002D70a8_002D4032_002Db545_002D6fbf61bd2cd6_007D.m_1230347effb84c10801fe5ff981b8a5a == 0)
				{
					num2 = 2;
				}
				break;
			default:
				inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
				Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
				num2 = 3;
				if (_003CModule_003E_007Babb06716_002D70a8_002D4032_002Db545_002D6fbf61bd2cd6_007D.m_17d72030731741c2be0063dcc3d6c73a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool eKeKhnXgcHi5YnRjqf8Y()
	{
		return CCXnBeXgXL6Q0h2DfAxq == null;
	}

	internal static VisualStyleProperties tdcHABXgjira6ZEWEV3K()
	{
		return CCXnBeXgXL6Q0h2DfAxq;
	}

	internal static object s4FCpLXgEIdybX0NpXd1(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void fyS5CQXgQc7U6PDsbqr3(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object g78cmGXgdDZ9JAAn0BJs(int P_0)
	{
		return RMpEErX55SDH1mxasQVF.pbtX5yHUPdJ(P_0);
	}

	internal static RuntimeTypeHandle HXVKCdXggJUZgOONdUoO(int token)
	{
		return yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(token);
	}

	internal static Type dSk92KXgRJTH9tn25Wc2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
