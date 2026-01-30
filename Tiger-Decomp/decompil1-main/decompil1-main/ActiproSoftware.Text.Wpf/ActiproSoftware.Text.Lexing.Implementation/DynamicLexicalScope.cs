using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class DynamicLexicalScope : LexicalScopeBase
{
	private DynamicLexicalPatternGroup O2m;

	private DynamicLexicalPatternGroup l2c;

	private static DynamicLexicalScope O5e;

	public DynamicLexicalPatternGroup EndLexicalPatternGroup
	{
		get
		{
			return O2m;
		}
		set
		{
			if (O2m != value)
			{
				if (O2m != null && O2m.LexicalScope == this)
				{
					O2m.LexicalScope = null;
				}
				O2m = value;
				if (O2m != null)
				{
					O2m.LexicalScope = this;
				}
			}
		}
	}

	public DynamicLexicalState LexicalState
	{
		get
		{
			return base.LexicalStateCore as DynamicLexicalState;
		}
		internal set
		{
			base.LexicalStateCore = value;
		}
	}

	public DynamicLexicalPatternGroup StartLexicalPatternGroup
	{
		get
		{
			return l2c;
		}
		set
		{
			if (l2c != value)
			{
				if (l2c != null && l2c.LexicalScope == this)
				{
					l2c.LexicalScope = null;
				}
				l2c = value;
				if (l2c != null)
				{
					l2c.LexicalScope = this;
				}
			}
		}
	}

	public override MergableLexerResult IsScopeEnd(ITextBufferReader reader)
	{
		if (O2m == null)
		{
			return MergableLexerResult.NoMatch;
		}
		return O2m.Match(reader);
	}

	public override MergableLexerResult IsScopeStart(ITextBufferReader reader)
	{
		if (l2c != null)
		{
			return l2c.Match(reader);
		}
		return MergableLexerResult.NoMatch;
	}

	public DynamicLexicalScope()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool G5g()
	{
		return O5e == null;
	}

	internal static DynamicLexicalScope F5p()
	{
		return O5e;
	}
}
