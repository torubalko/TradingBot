using System.Collections.Generic;

namespace ActiproSoftware.Text.Parsing;

public interface IParseErrorProvider
{
	IEnumerable<IParseError> Errors { get; }

	ITextSnapshot Snapshot { get; }
}
