using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text;

public interface ITextStatistic : IKeyedObject
{
	string Description { get; }

	string StringValue { get; }

	object Value { get; }
}
