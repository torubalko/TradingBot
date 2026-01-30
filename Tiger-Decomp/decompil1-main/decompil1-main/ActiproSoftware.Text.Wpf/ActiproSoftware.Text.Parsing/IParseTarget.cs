using System;

namespace ActiproSoftware.Text.Parsing;

public interface IParseTarget
{
	Guid UniqueId { get; }

	void NotifyParseComplete(IParseRequest request, IParseData result);
}
