using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class LexicalStateTokenData : IMergableTokenLexerData
{
	private ILexicalState M2e;

	private int M2y;

	private static LexicalStateTokenData yPF;

	public IClassificationType ClassificationType => null;

	public IMergableLexer Lexer => M2e.Lexer as IMergableLexer;

	public ILexicalScope LexicalScope => null;

	public ILexicalState LexicalState => M2e;

	public int TokenId => M2y;

	public virtual string TokenKey
	{
		get
		{
			ILexer lexer = Lexer;
			if (lexer != null && lexer.TokenIdProvider != null)
			{
				return lexer.TokenIdProvider.GetKey(M2y);
			}
			return null;
		}
	}

	public LexicalStateTokenData(ILexicalState lexicalState, int tokenId)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (lexicalState == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7896));
		}
		M2e = lexicalState;
		M2y = tokenId;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is LexicalStateTokenData lexicalStateTokenData))
		{
			return false;
		}
		return M2y == lexicalStateTokenData.M2y && M2e == lexicalStateTokenData.M2e;
	}

	public override int GetHashCode()
	{
		return M2y.GetHashCode();
	}

	internal static bool APO()
	{
		return yPF == null;
	}

	internal static LexicalStateTokenData qPD()
	{
		return yPF;
	}
}
