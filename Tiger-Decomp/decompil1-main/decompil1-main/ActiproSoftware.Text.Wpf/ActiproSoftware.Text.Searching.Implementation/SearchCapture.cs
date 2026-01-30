using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal class SearchCapture : ISearchCapture, ITextRangeProvider, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string rA1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string lA4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextRange JAK;

	internal static SearchCapture UVj;

	TextRange ITextRangeProvider.TextRange
	{
		get
		{
			return TextRange;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return rA1;
		}
		[CompilerGenerated]
		private set
		{
			rA1 = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return lA4;
		}
		[CompilerGenerated]
		private set
		{
			lA4 = value;
		}
	}

	public TextRange TextRange
	{
		[CompilerGenerated]
		get
		{
			return JAK;
		}
		[CompilerGenerated]
		private set
		{
			JAK = value;
		}
	}

	internal SearchCapture(string key, TextRange textRange, string text)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Key = key;
		TextRange = textRange;
		Text = text;
	}

	internal static bool FVK()
	{
		return UVj == null;
	}

	internal static SearchCapture rVl()
	{
		return UVj;
	}
}
