namespace ActiproSoftware.Text.Analysis;

public interface IStructureMatchResult : ITextRangeProvider
{
	StructureMatchEdges MatchEdges { get; }

	bool IsSource { get; }

	TextSnapshotOffset? NavigationSnapshotOffset { get; }

	TextSnapshotRange SnapshotRange { get; }
}
