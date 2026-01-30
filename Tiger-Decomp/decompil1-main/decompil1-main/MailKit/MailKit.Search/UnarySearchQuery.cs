using System;

namespace MailKit.Search;

public class UnarySearchQuery : SearchQuery
{
	public SearchQuery Operand { get; private set; }

	public UnarySearchQuery(SearchTerm term, SearchQuery operand)
		: base(term)
	{
		if (operand == null)
		{
			throw new ArgumentNullException("operand");
		}
		Operand = operand;
	}

	internal override SearchQuery Optimize(ISearchQueryOptimizer optimizer)
	{
		SearchQuery searchQuery = Operand.Optimize(optimizer);
		SearchQuery expr = ((searchQuery == Operand) ? this : new UnarySearchQuery(base.Term, searchQuery));
		return optimizer.Reduce(expr);
	}
}
