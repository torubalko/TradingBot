using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal static class Yp
{
	internal static Yp vK9;

	public static void gRf<C3>(DependencyObject P_0, Action<C3> P_1, C3 aT)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(15298));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(28022));
		}
		P_0.Dispatcher.BeginInvoke(DispatcherPriority.Normal, P_1, aT);
	}

	public static Window iRU(DependencyObject P_0, bool P_1 = false)
	{
		object obj = VisualTreeHelperExtended.GetAncestor(P_0, typeof(Window)) as Window;
		if (obj == null)
		{
			if (!P_1)
			{
				return Window.GetWindow(P_0);
			}
			obj = null;
		}
		return (Window)obj;
	}

	[SpecialName]
	public static ModifierKeys aR4()
	{
		return Keyboard.Modifiers;
	}

	public static void ARc(FrameworkElement P_0, Cursor P_1)
	{
		if (P_0 != null)
		{
			P_0.Cursor = P_1;
		}
	}

	internal static bool tKm()
	{
		return vK9 == null;
	}

	internal static Yp tKo()
	{
		return vK9;
	}
}
