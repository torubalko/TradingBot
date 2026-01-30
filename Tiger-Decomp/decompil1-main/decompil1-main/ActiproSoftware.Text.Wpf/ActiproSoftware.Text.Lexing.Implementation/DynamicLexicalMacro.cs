using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class DynamicLexicalMacro : IKeyedObject
{
	private RegexNode eTY;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string STo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string STD;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object QT1;

	internal static DynamicLexicalMacro Y5o;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return STo;
		}
		[CompilerGenerated]
		private set
		{
			STo = value;
		}
	}

	public string Pattern
	{
		[CompilerGenerated]
		get
		{
			return STD;
		}
		[CompilerGenerated]
		private set
		{
			STD = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return QT1;
		}
		[CompilerGenerated]
		set
		{
			QT1 = value;
		}
	}

	public DynamicLexicalMacro(string key, string pattern)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Key = key;
		Pattern = pattern;
	}

	internal RegexNode GetRegexNode(IRegexMacroMap macroMap)
	{
		if (eTY == null)
		{
			try
			{
				eTY = new RegexParser().ParsePatternAndExpandMacros(Pattern, requestAllowCapturing: false, requestIsReplacementPattern: false, macroMap, CaseSensitivity.Sensitive);
			}
			catch (InvalidRegexPatternException ex)
			{
				throw new InvalidRegexPatternException(ex.Message + Environment.NewLine + string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidDynamicLexicalMacroRegex), new object[2] { Key, Pattern }));
			}
		}
		return eTY;
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7924) + string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7968), new object[1] { Key }) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool N5I()
	{
		return Y5o == null;
	}

	internal static DynamicLexicalMacro k5H()
	{
		return Y5o;
	}
}
