using System;

namespace MailKit.Search;

public class TextSearchQuery : SearchQuery
{
	public string Text { get; private set; }

	public TextSearchQuery(SearchTerm term, string text)
		: base(term)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (text.Length == 0)
		{
			throw new ArgumentException("Cannot search for an empty string.", "text");
		}
		Text = text;
	}
}
