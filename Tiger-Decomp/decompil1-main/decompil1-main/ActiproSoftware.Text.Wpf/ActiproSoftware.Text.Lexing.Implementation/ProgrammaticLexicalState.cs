using System.Diagnostics.CodeAnalysis;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public class ProgrammaticLexicalState : LexicalStateBase
{
	internal static ProgrammaticLexicalState JU5;

	public ILexicalStateCollection ChildLexicalStates => base.ChildLexicalStatesCore;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lexer")]
	public ILexer Lexer => base.LexerCore;

	public ILexicalScopeCollection LexicalScopes => base.LexicalScopesCore;

	public ProgrammaticLexicalState(int id, string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector(id, key);
	}

	internal static bool zUP()
	{
		return JU5 == null;
	}

	internal static ProgrammaticLexicalState MUU()
	{
		return JU5;
	}
}
