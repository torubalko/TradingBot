using System;

namespace MailKit.Search;

public class DateSearchQuery : SearchQuery
{
	public DateTime Date { get; private set; }

	public DateSearchQuery(SearchTerm term, DateTime date)
		: base(term)
	{
		Date = date;
	}
}
