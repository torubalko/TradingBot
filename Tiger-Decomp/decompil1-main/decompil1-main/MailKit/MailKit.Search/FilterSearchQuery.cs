using System;

namespace MailKit.Search;

public class FilterSearchQuery : SearchQuery
{
	public string Name { get; private set; }

	public FilterSearchQuery(string name)
		: base(SearchTerm.Filter)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("The filter name cannot be empty.", "name");
		}
		Name = name;
	}

	public FilterSearchQuery(MetadataTag filter)
		: base(SearchTerm.Filter)
	{
		if (filter.Id.StartsWith("/private/filters/values/", StringComparison.Ordinal))
		{
			Name = filter.Id.Substring("/private/filters/values/".Length);
			return;
		}
		if (filter.Id.StartsWith("/shared/filters/values/", StringComparison.Ordinal))
		{
			Name = filter.Id.Substring("/shared/filters/values/".Length);
			return;
		}
		throw new ArgumentException("Metadata tag does not reference a valid filter.", "filter");
	}
}
