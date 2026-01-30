using System;
using System.Windows;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Compatibility;

internal static class CompatibilityHelper
{
	private static CompatibilityHelper Egx;

	public static ModifierKeys ModifierKeys => Keyboard.Modifiers;

	public static bool IsFocusWithin(UIElement targetElement)
	{
		if (targetElement == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(136172));
		}
		return targetElement.IsKeyboardFocusWithin;
	}

	internal static bool igS()
	{
		return Egx == null;
	}

	internal static CompatibilityHelper EgB()
	{
		return Egx;
	}
}
