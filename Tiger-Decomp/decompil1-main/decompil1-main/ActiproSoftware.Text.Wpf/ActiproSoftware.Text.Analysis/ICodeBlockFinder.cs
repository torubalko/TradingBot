namespace ActiproSoftware.Text.Analysis;

public interface ICodeBlockFinder
{
	TextSnapshotRange FindContaining(TextSnapshotRange snapshotRange);
}
