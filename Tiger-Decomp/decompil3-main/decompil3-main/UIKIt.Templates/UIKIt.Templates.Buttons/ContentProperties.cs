using System;
using System.Windows;
using frv4s5X5SOo66jNvMvO6;
using hkZMMTXxD6qN8IAyOFGI;
using MhxjOdXxkI6wEJmk4G3f;
using PWXKwRXxL9cVgWUpa4xk;

namespace UIKIt.Templates.Buttons;

public class ContentProperties : DependencyObject
{
	public static readonly DependencyProperty sprl2u3OxEY;

	public static readonly DependencyProperty IconProperty;

	public static readonly DependencyProperty IconMarginProperty;

	private static ContentProperties XvwA05Xg6a9PEcOi6NPl;

	public static void aA3l23JQh3C(DependencyObject P_0, string P_1)
	{
		P_0.SetValue(sprl2u3OxEY, P_1);
	}

	public static string r0Tl2prBp9p(DependencyObject P_0)
	{
		return (string)P_0.GetValue(sprl2u3OxEY);
	}

	public static void SetIcon(DependencyObject element, object value)
	{
		element.SetValue(IconProperty, value);
	}

	public static object GetIcon(DependencyObject element)
	{
		return H37k0WXgquNZYLrhCp7t(element, IconProperty);
	}

	public static void SetIconMargin(DependencyObject element, Thickness value)
	{
		element.SetValue(IconMarginProperty, value);
	}

	public static Thickness GetIconMargin(DependencyObject element)
	{
		return (Thickness)H37k0WXgquNZYLrhCp7t(element, IconMarginProperty);
	}

	public ContentProperties()
	{
		Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
		base._002Ector();
	}

	static ContentProperties()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				RMpEErX55SDH1mxasQVF.v64X5Ol3UFK();
				num2 = 0;
				if (_003CModule_003E_007Babb06716_002D70a8_002D4032_002Db545_002D6fbf61bd2cd6_007D.m_b53b19f04a5843039da666ff7f1a76ce == 0)
				{
					num2 = 0;
				}
				continue;
			}
			inixpGXxxRbVxvw72CyL.kLjw4iIsCLsZtxc4lksN0j();
			Gn8wU4Xx4ZYh48eQvpr3.zPVXtYYvGYD();
			sprl2u3OxEY = DependencyProperty.RegisterAttached((string)Sai08lXgIaVsrmrbSfo3(--855742383 ^ 0x3301955D), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777225)), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554444)), new PropertyMetadata((object)null));
			IconProperty = DependencyProperty.RegisterAttached((string)Sai08lXgIaVsrmrbSfo3(-53782092 ^ -53781686), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777239)), tUsvauXgtf3mlJssmtQq(bgcBbYXgWClSM91hTI1S(33554444)), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits));
			IconMarginProperty = DependencyProperty.RegisterAttached(RMpEErX55SDH1mxasQVF.pbtX5yHUPdJ(-1087080834 ^ -1087081100), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(16777270)), Type.GetTypeFromHandle(yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(33554444)), new FrameworkPropertyMetadata(default(Thickness), FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits));
			num2 = 2;
			if (_003CModule_003E_007Babb06716_002D70a8_002D4032_002Db545_002D6fbf61bd2cd6_007D.m_4d83f90b08d34ff1a2dca6a6d6fff114 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static bool j94QJAXgMZ821HEj6wg4()
	{
		return XvwA05Xg6a9PEcOi6NPl == null;
	}

	internal static ContentProperties BQdu9eXgObyl0DeDmFlu()
	{
		return XvwA05Xg6a9PEcOi6NPl;
	}

	internal static object H37k0WXgquNZYLrhCp7t(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static object Sai08lXgIaVsrmrbSfo3(int P_0)
	{
		return RMpEErX55SDH1mxasQVF.pbtX5yHUPdJ(P_0);
	}

	internal static RuntimeTypeHandle bgcBbYXgWClSM91hTI1S(int token)
	{
		return yV6W9VXxN4GgYFfnstL7.WSAXtoGDu2m(token);
	}

	internal static Type tUsvauXgtf3mlJssmtQq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
