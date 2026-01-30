using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Internal;

internal class X9 : RoutedEventArgs
{
	[CompilerGenerated]
	private Point aIT;

	[CompilerGenerated]
	private InputPointerEventArgs nI8;

	internal static X9 vz;

	public X9(Point P_0, InputPointerEventArgs P_1)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_1 == null)
		{
			throw new ArgumentNullException(vVK.ssH(4416));
		}
		CIB(P_0);
		LIn(P_1);
	}

	[SpecialName]
	[CompilerGenerated]
	public Point VIW()
	{
		return aIT;
	}

	[SpecialName]
	[CompilerGenerated]
	private void CIB(Point P_0)
	{
		aIT = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public InputPointerEventArgs sIJ()
	{
		return nI8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void LIn(InputPointerEventArgs P_0)
	{
		nI8 = P_0;
	}

	internal static bool R10()
	{
		return vz == null;
	}

	internal static X9 N11()
	{
		return vz;
	}
}
