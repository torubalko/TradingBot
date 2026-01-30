using System.Collections;

namespace ActiproSoftware.Text;

public interface ITextSnapshotLineCollection : ICollection, IEnumerable
{
	ITextSnapshotLine this[int index] { get; }

	TextRange GetLineTextRange(int index);

	int IndexOf(int offset);
}
