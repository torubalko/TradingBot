using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class LexicalScopeTokenData : IMergableTokenLexerData
{
	private ILexicalScope d2k;

	private int f2E;

	internal static LexicalScopeTokenData jPQ;

	public IClassificationType ClassificationType => null;

	public IMergableLexer Lexer => d2k.LexicalState.Lexer as IMergableLexer;

	public ILexicalScope LexicalScope => d2k;

	public ILexicalState LexicalState => d2k.LexicalState;

	public int TokenId => f2E;

	public virtual string TokenKey
	{
		get
		{
			ILexer lexer = Lexer;
			if (lexer != null && lexer.TokenIdProvider != null)
			{
				return lexer.TokenIdProvider.GetKey(f2E);
			}
			return null;
		}
	}

	public LexicalScopeTokenData(ILexicalScope lexicalScope, int tokenId)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (lexicalScope == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8238));
		}
		d2k = lexicalScope;
		f2E = tokenId;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is LexicalScopeTokenData lexicalScopeTokenData))
		{
			return false;
		}
		return f2E == lexicalScopeTokenData.f2E && d2k == lexicalScopeTokenData.d2k;
	}

	public override int GetHashCode()
	{
		return f2E.GetHashCode();
	}

	internal static bool xPx()
	{
		return jPQ == null;
	}

	internal static LexicalScopeTokenData CPT()
	{
		return jPQ;
	}
}
