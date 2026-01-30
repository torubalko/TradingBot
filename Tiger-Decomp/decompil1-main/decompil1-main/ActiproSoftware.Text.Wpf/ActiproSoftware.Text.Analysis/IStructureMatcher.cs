namespace ActiproSoftware.Text.Analysis;

public interface IStructureMatcher
{
	IStructureMatchResultSet Match(TextSnapshotOffset snapshotOffset, IStructureMatchOptions options);
}
