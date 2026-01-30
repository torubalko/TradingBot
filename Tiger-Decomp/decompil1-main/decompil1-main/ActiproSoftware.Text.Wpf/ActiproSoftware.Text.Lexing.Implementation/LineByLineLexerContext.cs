using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class LineByLineLexerContext : ILineByLineLexerContext, ILexerContext
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int Em8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IToken UmT;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ILexicalScopeStateNode Am2;

	internal static LineByLineLexerContext bPg;

	public int Character
	{
		[CompilerGenerated]
		get
		{
			return Em8;
		}
		[CompilerGenerated]
		set
		{
			Em8 = value;
		}
	}

	public IToken CompleteLineToken
	{
		[CompilerGenerated]
		get
		{
			return UmT;
		}
		[CompilerGenerated]
		set
		{
			UmT = value;
		}
	}

	public ILexicalScopeStateNode ScopeState
	{
		[CompilerGenerated]
		get
		{
			return Am2;
		}
		[CompilerGenerated]
		set
		{
			Am2 = value;
		}
	}

	public override bool Equals(object obj)
	{
		if (!(obj is ILineByLineLexerContext lineByLineLexerContext))
		{
			return false;
		}
		if (Character != lineByLineLexerContext.Character)
		{
			return false;
		}
		if (CompleteLineToken != null)
		{
			if (lineByLineLexerContext.CompleteLineToken != null)
			{
				return CompleteLineToken.Id == lineByLineLexerContext.CompleteLineToken.Id && CompleteLineToken.Length == lineByLineLexerContext.CompleteLineToken.Length && CompleteLineToken.StartPosition == lineByLineLexerContext.CompleteLineToken.StartPosition && CompleteLineToken.EndPosition == lineByLineLexerContext.CompleteLineToken.EndPosition;
			}
			return false;
		}
		if (lineByLineLexerContext.CompleteLineToken != null)
		{
			return false;
		}
		if (ScopeState != null)
		{
			return ScopeState.Equals(lineByLineLexerContext.ScopeState);
		}
		return lineByLineLexerContext.ScopeState == null;
	}

	public override int GetHashCode()
	{
		return ((ScopeState != null) ? ScopeState.GetHashCode() : ((CompleteLineToken != null) ? CompleteLineToken.GetHashCode() : 0)) ^ base.GetHashCode();
	}

	public override string ToString()
	{
		if (CompleteLineToken != null)
		{
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8334) + CompleteLineToken?.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
		}
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8376) + Character + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8426) + ScopeState?.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	public LineByLineLexerContext()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool JPp()
	{
		return bPg == null;
	}

	internal static LineByLineLexerContext IPm()
	{
		return bPg;
	}
}
