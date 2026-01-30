namespace ActiproSoftware.Text.Lexing;

public interface ILexicalScopeStateNode
{
	ILexicalScope LexicalScope { get; set; }

	ILexicalState LexicalState { get; set; }

	ILexicalScopeStateNode Parent { get; set; }
}
