using System;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface ICollapsedRegionManager
{
	event EventHandler<TextSnapshotRangeEventArgs> RegionsChanged;

	TextSnapshotRange GetCollapsedRange(TextSnapshotOffset snapshotOffset);

	NormalizedTextSnapshotRangeCollection GetCollapsedRanges(TextSnapshotRange snapshotRange);

	int GetVisibleOffset(TextSnapshotOffset snapshotOffset, bool hasFarAffinity);
}
