namespace ActiproSoftware.Text.StringTrees;

internal interface IStringTreeNode
{
	int Depth { get; }

	bool IsLeaf { get; }

	IStringTreeNode Left { get; }

	int Length { get; }

	int LineFeedCount { get; }

	IStringTreeNode Right { get; }

	char this[int index] { get; }

	void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);

	int GetLineIndex(int offset);

	TextRange GetLineTextRange(int lineIndex);

	IStringTreeNode Replace(int startOffset, int endOffset, string text);

	IStringTreeNode Substring(int startOffset, int endOffset);

	string ToString(int startOffset, int endOffset);
}
