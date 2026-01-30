using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

public class StringTextProvider : ITextProvider
{
	private string WYa;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int tYq;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int UYW;

	internal static StringTextProvider xno;

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return tYq;
		}
		[CompilerGenerated]
		private set
		{
			tYq = value;
		}
	}

	public int StartCharacterIndex
	{
		[CompilerGenerated]
		get
		{
			return UYW;
		}
		[CompilerGenerated]
		private set
		{
			UYW = value;
		}
	}

	public StringTextProvider(string text)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(text, 0);
	}

	public StringTextProvider(string text, int startCharacterIndex)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (text == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117076));
		}
		WYa = text;
		Length = text.Length;
		StartCharacterIndex = startCharacterIndex;
	}

	public string GetSubstring(int characterIndex, int characterCount)
	{
		if (characterIndex == 0 && characterCount == Length)
		{
			return WYa;
		}
		return WYa.Substring(characterIndex, characterCount);
	}

	public int Translate(int characterIndex, TextProviderTranslateModes modes)
	{
		switch (modes)
		{
		case TextProviderTranslateModes.FromSourceText:
		case TextProviderTranslateModes.PositiveTracking:
			characterIndex -= StartCharacterIndex;
			if (characterIndex < 0 || characterIndex >= Length)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117088));
			}
			break;
		case TextProviderTranslateModes.ToSourceText:
		case TextProviderTranslateModes.ToSourceText | TextProviderTranslateModes.PositiveTracking:
			if (characterIndex < 0 || characterIndex >= Length)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117088));
			}
			characterIndex += StartCharacterIndex;
			break;
		}
		return characterIndex;
	}

	internal static bool Mn5()
	{
		return xno == null;
	}

	internal static StringTextProvider inm()
	{
		return xno;
	}
}
