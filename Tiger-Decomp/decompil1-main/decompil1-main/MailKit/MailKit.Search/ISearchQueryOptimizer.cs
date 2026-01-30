namespace MailKit.Search;

internal interface ISearchQueryOptimizer
{
	SearchQuery Reduce(SearchQuery expr);
}
