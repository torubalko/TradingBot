using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

internal class DynamicLexicalStateTokenData : IMergableTokenLexerData
{
	private DynamicLexicalState g2p;

	private static DynamicLexicalStateTokenData IPA;

	public IClassificationType ClassificationType => g2p.DefaultClassificationType;

	public IMergableLexer Lexer => g2p.Lexer;

	public ILexicalScope LexicalScope => null;

	public ILexicalState LexicalState => g2p;

	public int TokenId => g2p.DefaultTokenId;

	public string TokenKey => g2p.DefaultTokenKey;

	public DynamicLexicalStateTokenData(DynamicLexicalState lexicalState)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		g2p = lexicalState;
	}

	public override bool Equals(object obj)
	{
		DynamicLexicalStateTokenData dynamicLexicalStateTokenData = obj as DynamicLexicalStateTokenData;
		if (obj == null || dynamicLexicalStateTokenData == null)
		{
			return false;
		}
		return g2p == dynamicLexicalStateTokenData.g2p;
	}

	public override int GetHashCode()
	{
		return g2p.GetHashCode();
	}

	internal static bool jPV()
	{
		return IPA == null;
	}

	internal static DynamicLexicalStateTokenData xPb()
	{
		return IPA;
	}
}
