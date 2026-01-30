using System;

namespace MailKit.Search;

public class BinarySearchQuery : SearchQuery
{
	public SearchQuery Left { get; private set; }

	public SearchQuery Right { get; private set; }

	public BinarySearchQuery(SearchTerm term, SearchQuery left, SearchQuery right)
		: base(term)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		Right = right;
		Left = left;
	}

	internal override SearchQuery Optimize(ISearchQueryOptimizer optimizer)
	{
		SearchQuery searchQuery = Right.Optimize(optimizer);
		SearchQuery searchQuery2 = Left.Optimize(optimizer);
		SearchQuery expr = ((searchQuery2 == Left && searchQuery == Right) ? this : new BinarySearchQuery(base.Term, searchQuery2, searchQuery));
		return optimizer.Reduce(expr);
	}
}
