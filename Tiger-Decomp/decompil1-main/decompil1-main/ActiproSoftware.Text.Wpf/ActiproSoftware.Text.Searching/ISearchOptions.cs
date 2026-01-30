using System;

namespace ActiproSoftware.Text.Searching;

public interface ISearchOptions : ICloneable
{
	string FindText { get; set; }

	bool MatchCase { get; set; }

	bool MatchWholeWord { get; set; }

	int MaximumResultCount { get; set; }

	ISearchPatternProvider PatternProvider { get; set; }

	string ReplaceText { get; set; }

	bool SearchUp { get; set; }
}
