using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ActiproSoftware.Internal;

internal static class LY
{
	internal static LY wcl;

	public static object zld()
	{
		return Keyboard.FocusedElement;
	}

	public static bool KlB(Control P_0)
	{
		return P_0.IsKeyboardFocused;
	}

	public static bool vlR(Point P_0, Point P_1, bool P_2)
	{
		int num = ((!P_2) ? 1 : 4);
		if (!(Math.Abs(P_1.X - P_0.X) >= (double)num * (SystemParameters.MinimumHorizontalDragDistance + 2.0)))
		{
			return Math.Abs(P_1.Y - P_0.Y) >= (double)num * (SystemParameters.MinimumVerticalDragDistance + 2.0);
		}
		return true;
	}

	public static bool OlM(UIElement P_0)
	{
		return P_0.IsKeyboardFocusWithin;
	}

	[SpecialName]
	public static ModifierKeys hle()
	{
		return Keyboard.Modifiers;
	}

	[SpecialName]
	public static int elG()
	{
		return 500;
	}

	internal static bool scI()
	{
		return wcl == null;
	}

	internal static LY tcY()
	{
		return wcl;
	}
}
