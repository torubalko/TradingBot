using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class DynamicLexicalPattern
{
	private string oT4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private RegexCode NTK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CharClass WTk;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IMergableTokenLexerData kTE;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DynamicLexicalPatternGroup uTr;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object DT3;

	internal static DynamicLexicalPattern s5h;

	internal RegexCode RegexCode
	{
		[CompilerGenerated]
		get
		{
			return NTK;
		}
		[CompilerGenerated]
		set
		{
			NTK = value;
		}
	}

	internal CharClass StartsWith
	{
		[CompilerGenerated]
		get
		{
			return WTk;
		}
		[CompilerGenerated]
		set
		{
			WTk = value;
		}
	}

	internal IMergableTokenLexerData TokenLexerData
	{
		[CompilerGenerated]
		get
		{
			return kTE;
		}
		[CompilerGenerated]
		set
		{
			kTE = value;
		}
	}

	public DynamicLexicalPatternGroup LexicalPatternGroup
	{
		[CompilerGenerated]
		get
		{
			return uTr;
		}
		[CompilerGenerated]
		internal set
		{
			uTr = value;
		}
	}

	public string Pattern
	{
		get
		{
			return oT4;
		}
		set
		{
			if (!(oT4 == value))
			{
				oT4 = value;
				if (LexicalPatternGroup != null)
				{
					LexicalPatternGroup.InvalidateRegexs(this);
				}
				else
				{
					RegexCode = null;
				}
			}
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return DT3;
		}
		[CompilerGenerated]
		set
		{
			DT3 = value;
		}
	}

	public DynamicLexicalPattern(string pattern)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		oT4 = pattern;
		TokenLexerData = new DynamicLexicalPatternTokenData(this);
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7990) + oT4 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool D5Q()
	{
		return s5h == null;
	}

	internal static DynamicLexicalPattern r5x()
	{
		return s5h;
	}
}
