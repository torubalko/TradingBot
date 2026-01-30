using System;

namespace MailKit.Search;

public class HeaderSearchQuery : SearchQuery
{
	public string Field { get; private set; }

	public string Value { get; private set; }

	public HeaderSearchQuery(string field, string value)
		: base(SearchTerm.HeaderContains)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		if (field.Length == 0)
		{
			throw new ArgumentException("Cannot search an empty header field name.", "field");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Field = field;
		Value = value;
	}
}
