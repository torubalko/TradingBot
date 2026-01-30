namespace ActiproSoftware.Text.Lexing;

public interface ILexicalStateTransition
{
	ISyntaxLanguage ChildLanguage { get; }

	ILexicalScope ChildLexicalScope { get; }

	ILexicalState ChildLexicalState { get; }

	ILexicalScope ParentLexicalScope { get; }
}
