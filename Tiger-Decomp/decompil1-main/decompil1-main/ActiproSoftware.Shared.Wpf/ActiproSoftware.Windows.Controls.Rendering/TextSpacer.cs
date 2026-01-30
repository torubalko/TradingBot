using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class TextSpacer : ITextSpacer
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double eIH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int AI6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object iIV;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Size OI5;

	private static TextSpacer p0H;

	public double Baseline
	{
		[CompilerGenerated]
		get
		{
			return eIH;
		}
		[CompilerGenerated]
		private set
		{
			eIH = value;
		}
	}

	public int CharacterIndex
	{
		[CompilerGenerated]
		get
		{
			return AI6;
		}
		[CompilerGenerated]
		private set
		{
			AI6 = value;
		}
	}

	public object Key
	{
		[CompilerGenerated]
		get
		{
			return iIV;
		}
		[CompilerGenerated]
		private set
		{
			iIV = value;
		}
	}

	public Size Size
	{
		[CompilerGenerated]
		get
		{
			return OI5;
		}
		[CompilerGenerated]
		private set
		{
			OI5 = value;
		}
	}

	public TextSpacer(int characterIndex, object key, Size size, double baseline)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		CharacterIndex = characterIndex;
		Key = key;
		Size = size;
		Baseline = baseline;
	}

	internal static bool i0J()
	{
		return p0H == null;
	}

	internal static TextSpacer v03()
	{
		return p0H;
	}
}
