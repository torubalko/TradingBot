namespace ActiproSoftware.Text;

public interface ITextChangeOperation : ITextChangeRangedOperation
{
	string DeletedText { get; }

	string InsertedText { get; }

	bool IsProgrammaticTextReplacement { get; }

	bool IsTextReplacement { get; }
}
