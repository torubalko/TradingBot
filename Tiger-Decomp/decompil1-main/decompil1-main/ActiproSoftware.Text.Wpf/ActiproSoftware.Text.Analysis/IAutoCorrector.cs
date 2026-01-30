using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text.Analysis;

public interface IAutoCorrector
{
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoCorrect")]
	void AutoCorrect(TextSnapshotRange snapshotRange);
}
