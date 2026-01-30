using MailKit.Search;

namespace MailKit.Net.Imap;

internal class ImapSearchQueryOptimizer : ISearchQueryOptimizer
{
	public SearchQuery Reduce(SearchQuery expr)
	{
		if (expr.Term == SearchTerm.And)
		{
			BinarySearchQuery binarySearchQuery = (BinarySearchQuery)expr;
			if (binarySearchQuery.Left.Term == SearchTerm.All)
			{
				return binarySearchQuery.Right.Optimize(this);
			}
			if (binarySearchQuery.Right.Term == SearchTerm.All)
			{
				return binarySearchQuery.Left.Optimize(this);
			}
		}
		else if (expr.Term == SearchTerm.Or)
		{
			BinarySearchQuery binarySearchQuery2 = (BinarySearchQuery)expr;
			if (binarySearchQuery2.Left.Term == SearchTerm.All)
			{
				return SearchQuery.All;
			}
			if (binarySearchQuery2.Right.Term == SearchTerm.All)
			{
				return SearchQuery.All;
			}
		}
		else if (expr.Term == SearchTerm.Not)
		{
			UnarySearchQuery unarySearchQuery = (UnarySearchQuery)expr;
			switch (unarySearchQuery.Operand.Term)
			{
			case SearchTerm.Not:
				return ((UnarySearchQuery)unarySearchQuery.Operand).Operand.Optimize(this);
			case SearchTerm.NotAnswered:
				return SearchQuery.Answered;
			case SearchTerm.Answered:
				return SearchQuery.NotAnswered;
			case SearchTerm.NotDeleted:
				return SearchQuery.Deleted;
			case SearchTerm.Deleted:
				return SearchQuery.NotDeleted;
			case SearchTerm.NotDraft:
				return SearchQuery.Draft;
			case SearchTerm.Draft:
				return SearchQuery.NotDraft;
			case SearchTerm.NotFlagged:
				return SearchQuery.Flagged;
			case SearchTerm.Flagged:
				return SearchQuery.NotFlagged;
			case SearchTerm.NotRecent:
				return SearchQuery.Recent;
			case SearchTerm.Recent:
				return SearchQuery.NotRecent;
			case SearchTerm.NotSeen:
				return SearchQuery.Seen;
			case SearchTerm.Seen:
				return SearchQuery.NotSeen;
			}
			if (unarySearchQuery.Operand.Term == SearchTerm.Keyword)
			{
				return new TextSearchQuery(SearchTerm.NotKeyword, ((TextSearchQuery)unarySearchQuery.Operand).Text);
			}
			if (unarySearchQuery.Operand.Term == SearchTerm.NotKeyword)
			{
				return new TextSearchQuery(SearchTerm.Keyword, ((TextSearchQuery)unarySearchQuery.Operand).Text);
			}
		}
		return expr;
	}
}
