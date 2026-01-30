using System.Collections;
using System.Collections.Generic;

namespace ActiproSoftware.Text;

public interface ITextPositionRangeCollection : IEnumerable<TextPositionRange>, IEnumerable
{
	int Count { get; }

	bool IsBlock { get; }

	TextPositionRange Primary { get; }

	int PrimaryIndex { get; }

	TextPositionRange this[int index] { get; }

	int BinarySearch(TextPosition value);
}
