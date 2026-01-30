using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Parsing;

public interface IParser : IKeyedObject
{
	IParseData Parse(IParseRequest request);
}
