namespace MailKit.Search;

public class NumericSearchQuery : SearchQuery
{
	public ulong Value { get; private set; }

	public NumericSearchQuery(SearchTerm term, ulong value)
		: base(term)
	{
		Value = value;
	}
}
