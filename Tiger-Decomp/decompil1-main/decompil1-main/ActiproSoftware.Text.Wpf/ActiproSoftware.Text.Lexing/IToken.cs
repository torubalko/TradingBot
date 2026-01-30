namespace ActiproSoftware.Text.Lexing;

public interface IToken
{
	int EndOffset { get; }

	TextPosition EndPosition { get; }

	int Id { get; }

	string Key { get; }

	int Length { get; set; }

	int LexicalStateId { get; }

	TextPositionRange PositionRange { get; }

	int StartOffset { get; set; }

	TextPosition StartPosition { get; }

	TextRange TextRange { get; }

	bool Contains(int offset);

	bool Contains(TextPosition position);
}
