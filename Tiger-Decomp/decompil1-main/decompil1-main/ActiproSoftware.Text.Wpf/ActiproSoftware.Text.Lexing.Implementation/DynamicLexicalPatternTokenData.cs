using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class DynamicLexicalPatternTokenData : IMergableTokenLexerData
{
	private DynamicLexicalPattern z22;

	internal static DynamicLexicalPatternTokenData U5y;

	public IClassificationType ClassificationType => (z22.LexicalPatternGroup != null) ? (z22.LexicalPatternGroup.ClassificationType ?? ((z22.LexicalPatternGroup.LexicalState != null) ? z22.LexicalPatternGroup.LexicalState.DefaultClassificationType : null)) : null;

	public IMergableLexer Lexer
	{
		get
		{
			DynamicLexicalState lexicalState = z22.LexicalPatternGroup.LexicalState;
			if (lexicalState == null && z22.LexicalPatternGroup.LexicalScope != null)
			{
				lexicalState = z22.LexicalPatternGroup.LexicalScope.LexicalState;
			}
			return lexicalState?.Lexer;
		}
	}

	public DynamicLexicalPattern LexicalPattern => z22;

	public ILexicalScope LexicalScope => z22.LexicalPatternGroup.LexicalScope;

	public ILexicalState LexicalState => z22.LexicalPatternGroup.LexicalState;

	public int TokenId
	{
		get
		{
			int num = z22.LexicalPatternGroup.TokenId;
			if (num <= 0 && z22.LexicalPatternGroup.LexicalState != null)
			{
				num = z22.LexicalPatternGroup.LexicalState.DefaultTokenId;
			}
			return num;
		}
	}

	public string TokenKey => z22.LexicalPatternGroup.TokenKey ?? z22.LexicalPatternGroup.LexicalState.DefaultTokenKey;

	internal DynamicLexicalPatternTokenData(DynamicLexicalPattern lexicalPattern)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		z22 = lexicalPattern;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is DynamicLexicalPatternTokenData dynamicLexicalPatternTokenData))
		{
			return false;
		}
		return z22 == dynamicLexicalPatternTokenData.z22;
	}

	public override int GetHashCode()
	{
		return z22.GetHashCode();
	}

	internal static bool z5F()
	{
		return U5y == null;
	}

	internal static DynamicLexicalPatternTokenData e5O()
	{
		return U5y;
	}
}
