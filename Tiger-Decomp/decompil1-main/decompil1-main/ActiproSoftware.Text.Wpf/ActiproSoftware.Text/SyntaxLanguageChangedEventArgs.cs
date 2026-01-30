using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text;

public class SyntaxLanguageChangedEventArgs : EventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ISyntaxLanguage Cw;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ISyntaxLanguage CH;

	private static SyntaxLanguageChangedEventArgs qig;

	public ISyntaxLanguage NewLanguage
	{
		[CompilerGenerated]
		get
		{
			return Cw;
		}
		[CompilerGenerated]
		private set
		{
			Cw = value;
		}
	}

	public ISyntaxLanguage OldLanguage
	{
		[CompilerGenerated]
		get
		{
			return CH;
		}
		[CompilerGenerated]
		private set
		{
			CH = value;
		}
	}

	public SyntaxLanguageChangedEventArgs(ISyntaxLanguage oldLanguage, ISyntaxLanguage newLanguage)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		OldLanguage = oldLanguage;
		NewLanguage = newLanguage;
	}

	internal static bool Cip()
	{
		return qig == null;
	}

	internal static SyntaxLanguageChangedEventArgs yim()
	{
		return qig;
	}
}
