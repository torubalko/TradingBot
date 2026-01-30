namespace ActiproSoftware.Text;

public interface ITextFormatter
{
	void Format(ITextSnapshot snapshot, ITextPositionRangeCollection selectionPositionRanges, TextFormatMode mode = TextFormatMode.Ranges);
}
