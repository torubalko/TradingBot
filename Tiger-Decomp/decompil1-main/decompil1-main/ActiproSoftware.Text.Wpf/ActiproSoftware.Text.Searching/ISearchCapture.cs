using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Searching;

public interface ISearchCapture : ITextRangeProvider, IKeyedObject
{
	string Text { get; }
}
