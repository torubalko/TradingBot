namespace ActiproSoftware.Text.Lexing;

public interface ILexicalScope
{
	bool IsAncestorEndScopeCheckEnabled { get; }

	ILexicalState LexicalState { get; }

	ILexicalStateTransition ParentTransition { get; }

	object Tag { get; set; }

	ILexicalStateTransition Transition { get; }

	MergableLexerResult IsScopeEnd(ITextBufferReader reader);

	MergableLexerResult IsScopeStart(ITextBufferReader reader);
}
