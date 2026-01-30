namespace ActiproSoftware.Text;

public interface ITextVersionRange
{
	ITextDocument Document { get; }

	TextRangeTrackingModes TrackingModes { get; }

	TextSnapshotRange Translate(ITextSnapshot toSnapshot);

	TextRange Translate(ITextVersion toVersion);
}
