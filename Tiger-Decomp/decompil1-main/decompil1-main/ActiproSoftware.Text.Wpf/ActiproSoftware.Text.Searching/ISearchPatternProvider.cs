using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Text.Searching;

public interface ISearchPatternProvider : IKeyedObject
{
	string Description { get; }

	bool RequiresCaseSensitivity { get; }

	string GetFindPattern(string pattern);

	string GetReplacePattern(string pattern);
}
