using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
public class MergableLexerResult
{
	[SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes")]
	public static readonly MergableLexerResult NoMatch;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IMergableTokenLexerData ETl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private MatchType ITi;

	private static MergableLexerResult S50;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	public IMergableTokenLexerData LexerData
	{
		[CompilerGenerated]
		get
		{
			return ETl;
		}
		[CompilerGenerated]
		private set
		{
			ETl = value;
		}
	}

	public MatchType MatchType
	{
		[CompilerGenerated]
		get
		{
			return ITi;
		}
		[CompilerGenerated]
		private set
		{
			ITi = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "lexer")]
	public MergableLexerResult(MatchType matchType, IMergableTokenLexerData lexerData)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (matchType == MatchType.NoMatch)
		{
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (lexerData == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7840));
		}
		MatchType = matchType;
		LexerData = lexerData;
	}

	static MergableLexerResult()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		NoMatch = new MergableLexerResult(MatchType.NoMatch, null);
	}

	internal static bool s5N()
	{
		return S50 == null;
	}

	internal static MergableLexerResult H5r()
	{
		return S50;
	}
}
