using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace ActiproSoftware.Internal;

internal static class Ad6
{
	internal static Ad6 kAY;

	public static void tuu(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			Clipboard.SetText(P_0);
		}
	}

	public static string FuK()
	{
		if (!Clipboard.ContainsText())
		{
			return null;
		}
		return Clipboard.GetText();
	}

	public static object cuR()
	{
		return Keyboard.FocusedElement;
	}

	public static bool tud(KeyEventArgs P_0, Key P_1)
	{
		return P_0.SystemKey == P_1 && suc() == ModifierKeys.Alt;
	}

	public static bool Pu9(UIElement P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(34470));
		}
		return P_0.IsKeyboardFocusWithin;
	}

	public static bool pu5(Key P_0)
	{
		return Keyboard.IsKeyDown(P_0);
	}

	[SpecialName]
	public static ModifierKeys suc()
	{
		return Keyboard.Modifiers;
	}

	internal static bool NAx()
	{
		return kAY == null;
	}

	internal static Ad6 vAz()
	{
		return kAY;
	}
}
