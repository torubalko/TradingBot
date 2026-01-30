namespace ActiproSoftware.Text;

public interface ITextChangeOptions
{
	bool CanMergeIntoPreviousChange { get; set; }

	object CustomData { get; set; }

	bool CheckReadOnly { get; set; }

	TextChangeOffsetDelta OffsetDelta { get; set; }

	bool RetainSelection { get; set; }

	object Source { get; set; }
}
