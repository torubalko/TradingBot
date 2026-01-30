using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public static class HintProperties
{
	private static readonly DependencyPropertyKey XA2;

	private static readonly DependencyPropertyKey wAe;

	public static readonly DependencyProperty HasContentProperty;

	public static readonly DependencyProperty HasHintProperty;

	public static readonly DependencyProperty HintProperty;

	public static readonly DependencyProperty HintTemplateProperty;

	public static readonly DependencyProperty HintTemplateSelectorProperty;

	private static HintProperties tGO;

	private static void gA9(object P_0, SelectionChangedEventArgs P_1)
	{
		if (P_0 is ComboBox { IsEditable: false } comboBox)
		{
			SetHasContent(comboBox);
		}
	}

	private static void DAh(object P_0, TextChangedEventArgs P_1)
	{
		if (P_0 is ComboBox { IsEditable: not false } comboBox)
		{
			SetHasContent(comboBox);
		}
	}

	private static void WAm(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		bool flag = (bool)P_1.NewValue;
		ComboBox comboBox = P_0 as ComboBox;
		bool flag2 = default(bool);
		int num;
		if (comboBox != null)
		{
			flag2 = flag;
			num = 1;
			if (!TGq())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_002f;
		IL_002f:
		TextBox textBox = P_0 as TextBox;
		if (textBox == null)
		{
			if (P_0 is PasswordBox passwordBox)
			{
				if (flag)
				{
					passwordBox.PasswordChanged += HA4;
					SetHasContent(passwordBox);
				}
				else
				{
					passwordBox.PasswordChanged -= HA4;
					passwordBox.ClearValue(XA2);
				}
			}
			return;
		}
		if (flag)
		{
			textBox.TextChanged += qAu;
			num = 0;
			if (!TGq())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		textBox.TextChanged -= qAu;
		textBox.ClearValue(XA2);
		return;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 3:
			break;
		case 1:
			if (flag2)
			{
				comboBox.SelectionChanged += gA9;
				comboBox.AddHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(DAh));
				SetHasContent(comboBox);
			}
			else
			{
				comboBox.SelectionChanged -= gA9;
				comboBox.RemoveHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(DAh));
				comboBox.ClearValue(XA2);
			}
			return;
		case 2:
			return;
		default:
			SetHasContent(textBox);
			return;
		}
		goto IL_002f;
	}

	private static void DAw(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 != null)
		{
			bool value = GetHint(P_0) != null || GetHintTemplate(P_0) != null || GetHintTemplateSelector(P_0) != null;
			SetHasHint(P_0, value);
		}
	}

	private static void HA4(object P_0, RoutedEventArgs P_1)
	{
		SetHasContent(P_0 as PasswordBox);
	}

	private static void qAu(object P_0, TextChangedEventArgs P_1)
	{
		SetHasContent(P_0 as TextBox);
	}

	private static void SetHasContent(ComboBox comboBox)
	{
		if (comboBox != null)
		{
			if (comboBox.IsEditable)
			{
				SetHasContent(comboBox, !string.IsNullOrEmpty(comboBox.Text));
			}
			else
			{
				SetHasContent(comboBox, comboBox.SelectedItem != null);
			}
		}
	}

	private static void SetHasContent(PasswordBox passwordBox)
	{
		if (passwordBox != null)
		{
			SetHasContent(passwordBox, passwordBox.SecurePassword.Length != 0);
		}
	}

	private static void SetHasContent(TextBox textBox)
	{
		if (textBox != null)
		{
			SetHasContent(textBox, !string.IsNullOrEmpty(textBox.Text));
		}
	}

	public static bool GetHasContent(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(HasContentProperty);
	}

	private static void SetHasContent(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(XA2, value);
	}

	public static bool GetHasHint(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(HasHintProperty);
	}

	private static void SetHasHint(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(wAe, value);
	}

	public static object GetHint(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return obj.GetValue(HintProperty);
	}

	public static void SetHint(DependencyObject obj, object value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HintProperty, value);
	}

	public static DataTemplate GetHintTemplate(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (DataTemplate)obj.GetValue(HintTemplateProperty);
	}

	public static void SetHintTemplate(DependencyObject obj, DataTemplate value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HintTemplateProperty, value);
	}

	public static DataTemplateSelector GetHintTemplateSelector(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (DataTemplateSelector)obj.GetValue(HintTemplateSelectorProperty);
	}

	public static void SetHintTemplateSelector(DependencyObject obj, DataTemplateSelector value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(HintTemplateSelectorProperty, value);
	}

	static HintProperties()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		XA2 = DependencyProperty.RegisterAttachedReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114424), typeof(bool), typeof(HintProperties), new FrameworkPropertyMetadata(false));
		wAe = DependencyProperty.RegisterAttachedReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114448), typeof(bool), typeof(HintProperties), new FrameworkPropertyMetadata(false, WAm));
		HasContentProperty = XA2.DependencyProperty;
		HasHintProperty = wAe.DependencyProperty;
		HintProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114466), typeof(object), typeof(HintProperties), new FrameworkPropertyMetadata(null, DAw));
		HintTemplateProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114478), typeof(DataTemplate), typeof(HintProperties), new FrameworkPropertyMetadata(null, DAw));
		HintTemplateSelectorProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114506), typeof(DataTemplateSelector), typeof(HintProperties), new FrameworkPropertyMetadata(null, DAw));
	}

	internal static bool TGq()
	{
		return tGO == null;
	}

	internal static HintProperties BGG()
	{
		return tGO;
	}
}
