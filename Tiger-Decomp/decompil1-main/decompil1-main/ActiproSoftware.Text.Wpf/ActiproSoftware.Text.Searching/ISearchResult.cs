namespace ActiproSoftware.Text.Searching;

public interface ISearchResult : ITextRangeProvider
{
	ISearchCaptureCollection Captures { get; }

	TextSnapshotRange FindSnapshotRange { get; }

	TextSnapshotRange ReplaceSnapshotRange { get; }
}
