using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "WordBreak")]
public interface IWordBreakFinder
{
	int FindCurrentWordEnd(TextSnapshotOffset snapshotOffset);

	int FindCurrentWordStart(TextSnapshotOffset snapshotOffset);

	int FindNextWordStart(TextSnapshotOffset snapshotOffset);

	int FindPreviousWordStart(TextSnapshotOffset snapshotOffset);
}
