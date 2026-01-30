namespace ActiproSoftware.Text;

public interface ILineCommenter
{
	void Comment(ITextSnapshot snapshot, ITextPositionRangeCollection positionRanges, ITextChangeOptions options);

	void Uncomment(ITextSnapshot snapshot, ITextPositionRangeCollection positionRanges, ITextChangeOptions options);
}
