namespace ActiproSoftware.Text.Lexing;

internal interface ILineByLineLexerContext : ILexerContext
{
	int Character { get; set; }

	IToken CompleteLineToken { get; }
}
