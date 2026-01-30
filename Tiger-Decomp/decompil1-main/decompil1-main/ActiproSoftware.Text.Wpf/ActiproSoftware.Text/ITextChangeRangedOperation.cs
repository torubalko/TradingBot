namespace ActiproSoftware.Text;

public interface ITextChangeRangedOperation
{
	int DeletionEndOffset { get; }

	TextPosition DeletionEndPosition { get; }

	int DeletionLength { get; }

	bool HasDeletion { get; }

	bool HasInsertion { get; }

	int InsertionEndOffset { get; }

	TextPosition InsertionEndPosition { get; }

	int InsertionLength { get; }

	bool IsIgnoredForTranslation { get; }

	int LengthDelta { get; }

	int LinesDeleted { get; }

	int LinesDelta { get; }

	int LinesInserted { get; }

	int StartOffset { get; }

	TextPosition StartPosition { get; }
}
