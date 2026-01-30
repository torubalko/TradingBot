using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal static class vAE
{
	private static vAE CGe;

	[SpecialName]
	private static int m0Y()
	{
		return 500;
	}

	public static void d0c<TAX>(DependencyObject P_0, Action<TAX> P_1, TAX mA1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(9254));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(219366));
		}
		P_0.Dispatcher.BeginInvoke(DispatcherPriority.Normal, P_1, mA1);
	}

	public static void c0a(FrameworkElement P_0)
	{
		P_0?.BringIntoView();
	}

	public static void l0x<kA9>(DependencyObject P_0, Action<kA9> P_1, kA9 BA2)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(9254));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(219366));
		}
		if (P_0.CheckAccess())
		{
			P_1(BA2);
		}
		else
		{
			P_0.Dispatcher.BeginInvoke(DispatcherPriority.Normal, P_1, BA2);
		}
	}

	public static void T0G<qAf>(DependencyObject P_0, Action<qAf> P_1, qAf uA6)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(9254));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(219366));
		}
		if (P_0.CheckAccess())
		{
			P_1(uA6);
		}
		else
		{
			P_0.Dispatcher.Invoke(DispatcherPriority.Normal, P_1, uA6);
		}
	}

	public static Binding A0X(object P_0, object P_1, BindingMode P_2, IValueConverter P_3)
	{
		Binding binding = new Binding();
		if (P_1 is string path)
		{
			binding = new Binding(path);
		}
		else
		{
			binding = new Binding();
			if (P_1 != null)
			{
				binding.Path = new PropertyPath(P_1);
			}
		}
		binding.Source = P_0;
		binding.Mode = P_2;
		binding.Converter = P_3;
		return binding;
	}

	public static SolidColorBrush F0K(Color? P_0)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		SolidColorBrush solidColorBrush = new SolidColorBrush(P_0.Value);
		solidColorBrush.Freeze();
		return solidColorBrush;
	}

	public static Assembly[] P0f()
	{
		return AppDomain.CurrentDomain.GetAssemblies();
	}

	public static UIElementCollection v0D(this Panel P_0)
	{
		return P_0.Children;
	}

	public static bool L0g(this UIElement P_0)
	{
		return P_0.Visibility == Visibility.Visible;
	}

	public static object u0Q()
	{
		return Keyboard.FocusedElement;
	}

	public static Rect h0e(this Rect P_0)
	{
		double num = Math.Round(P_0.X, MidpointRounding.AwayFromZero);
		double num2 = Math.Round(P_0.Y, MidpointRounding.AwayFromZero);
		double num3 = Math.Round(P_0.Width, MidpointRounding.AwayFromZero);
		double num4 = Math.Round(P_0.Height, MidpointRounding.AwayFromZero);
		double num5 = Math.Round(P_0.X - num + (P_0.Width - num3), MidpointRounding.AwayFromZero);
		if (num5 == 1.0)
		{
			num3 += 1.0;
		}
		double num6 = Math.Round(P_0.Y - num2 + (P_0.Height - num4), MidpointRounding.AwayFromZero);
		if (num6 == 1.0)
		{
			int num7 = 0;
			if (YNm() != null)
			{
				int num8 = default(int);
				num7 = num8;
			}
			switch (num7)
			{
			}
			num4 += 1.0;
		}
		P_0 = new Rect(num, num2, num3, num4);
		return P_0;
	}

	public static Type m0l(string P_0)
	{
		int num = P_0.IndexOf(',');
		Type result = default(Type);
		if (num != -1)
		{
			string name = P_0.Substring(0, num).Trim();
			string text = P_0.Substring(num + 1).Trim();
			if (text.IndexOf(',') == -1)
			{
				text += Q7Z.tqM(196626);
			}
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			Assembly[] array = assemblies;
			int num2 = 0;
			int num4 = default(int);
			while (true)
			{
				if (num2 >= array.Length)
				{
					int num3 = 1;
					if (QGz())
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result = Type.GetType(P_0, throwOnError: false, ignoreCase: true);
							num3 = 0;
							if (YNm() != null)
							{
								num3 = num4;
							}
							continue;
						}
						break;
					}
					break;
				}
				Assembly assembly = array[num2];
				if (assembly.FullName.StartsWith(text, StringComparison.OrdinalIgnoreCase))
				{
					result = assembly.GetType(name, throwOnError: false, ignoreCase: true);
					break;
				}
				num2++;
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public static bool L0A(Point P_0, Point P_1, DateTime P_2, DateTime P_3, bool P_4)
	{
		int num = (P_4 ? 10 : 3);
		return P_3.Subtract(P_2).TotalMilliseconds <= (double)m0Y() && new Rect(P_0.X - (double)num, P_0.Y - (double)num, 2 * num, 2 * num).Contains(P_1);
	}

	public static bool x0v(Point P_0, Point P_1, bool P_2)
	{
		double num = 6.0;
		int num2 = ((!P_2) ? 1 : 4);
		return Math.Abs(P_1.X - P_0.X) >= (double)num2 * num || Math.Abs(P_1.Y - P_0.Y) >= (double)num2 * num;
	}

	public static bool y0m(UIElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193602));
		}
		return P_0.IsKeyboardFocusWithin;
	}

	public static bool E0C(IEditorView P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return Keyboard.FocusedElement == P_0.VisualElement;
	}

	public static bool u0u(char P_0)
	{
		return char.IsLowSurrogate(P_0);
	}

	[SpecialName]
	public static ModifierKeys A0o()
	{
		return Keyboard.Modifiers;
	}

	[SpecialName]
	public static int W0w()
	{
		return Math.Max(300, (int)SystemParameters.MouseHoverTime.TotalMilliseconds);
	}

	public static void P01(FrameworkElement P_0, Cursor P_1)
	{
		if (P_0 != null)
		{
			P_0.Cursor = P_1;
		}
	}

	public static void U0F(this UIElement P_0, bool P_1)
	{
		P_0.Visibility = ((!P_1) ? Visibility.Collapsed : Visibility.Visible);
	}

	public static GeneralTransform M03(Visual P_0, Visual P_1)
	{
		return P_0.TransformToAncestor(P_1);
	}

	public static GeneralTransform N0R(Visual P_0, Visual P_1)
	{
		return P_0.TransformToDescendant(P_1);
	}

	internal static bool QGz()
	{
		return CGe == null;
	}

	internal static vAE YNm()
	{
		return CGe;
	}
}
