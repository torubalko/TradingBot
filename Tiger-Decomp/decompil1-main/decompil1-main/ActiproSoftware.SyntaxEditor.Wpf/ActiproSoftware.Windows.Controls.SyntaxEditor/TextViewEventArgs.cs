using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class TextViewEventArgs : RoutedEventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextView DX0;

	private static TextViewEventArgs wDR;

	public ITextView View
	{
		[CompilerGenerated]
		get
		{
			return DX0;
		}
		[CompilerGenerated]
		private set
		{
			DX0 = value;
		}
	}

	public TextViewEventArgs(ITextView view)
	{
		grA.DaB7cz();
		base._002Ector();
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		View = view;
	}

	internal static bool rDO()
	{
		return wDR == null;
	}

	internal static TextViewEventArgs fD1()
	{
		return wDR;
	}
}
