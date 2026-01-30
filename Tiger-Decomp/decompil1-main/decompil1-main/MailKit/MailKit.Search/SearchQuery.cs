using System;
using System.Collections.Generic;

namespace MailKit.Search;

public class SearchQuery
{
	public static readonly SearchQuery All = new SearchQuery(SearchTerm.All);

	public static readonly SearchQuery Answered = new SearchQuery(SearchTerm.Answered);

	public static readonly SearchQuery Deleted = new SearchQuery(SearchTerm.Deleted);

	public static readonly SearchQuery Draft = new SearchQuery(SearchTerm.Draft);

	public static readonly SearchQuery Flagged = new SearchQuery(SearchTerm.Flagged);

	public static readonly SearchQuery New = new SearchQuery(SearchTerm.New);

	public static readonly SearchQuery NotAnswered = new SearchQuery(SearchTerm.NotAnswered);

	public static readonly SearchQuery NotDeleted = new SearchQuery(SearchTerm.NotDeleted);

	public static readonly SearchQuery NotDraft = new SearchQuery(SearchTerm.NotDraft);

	public static readonly SearchQuery NotFlagged = new SearchQuery(SearchTerm.NotFlagged);

	public static readonly SearchQuery NotRecent = new SearchQuery(SearchTerm.NotRecent);

	public static readonly SearchQuery NotSeen = new SearchQuery(SearchTerm.NotSeen);

	public static readonly SearchQuery Old = new SearchQuery(SearchTerm.NotRecent);

	public static readonly SearchQuery Recent = new SearchQuery(SearchTerm.Recent);

	public static readonly SearchQuery SaveDateSupported = new SearchQuery(SearchTerm.SaveDateSupported);

	public static readonly SearchQuery Seen = new SearchQuery(SearchTerm.Seen);

	public SearchTerm Term { get; private set; }

	public SearchQuery()
		: this(SearchTerm.All)
	{
	}

	protected SearchQuery(SearchTerm term)
	{
		Term = term;
	}

	public static BinarySearchQuery And(SearchQuery left, SearchQuery right)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		return new BinarySearchQuery(SearchTerm.And, left, right);
	}

	public BinarySearchQuery And(SearchQuery expr)
	{
		if (expr == null)
		{
			throw new ArgumentNullException("expr");
		}
		return new BinarySearchQuery(SearchTerm.And, this, expr);
	}

	public static AnnotationSearchQuery AnnotationsContain(AnnotationEntry entry, AnnotationAttribute attribute, string value)
	{
		return new AnnotationSearchQuery(entry, attribute, value);
	}

	public static TextSearchQuery BccContains(string text)
	{
		return new TextSearchQuery(SearchTerm.BccContains, text);
	}

	public static TextSearchQuery BodyContains(string text)
	{
		return new TextSearchQuery(SearchTerm.BodyContains, text);
	}

	public static TextSearchQuery CcContains(string text)
	{
		return new TextSearchQuery(SearchTerm.CcContains, text);
	}

	public static SearchQuery ChangedSince(ulong modseq)
	{
		return new NumericSearchQuery(SearchTerm.ModSeq, modseq);
	}

	public static DateSearchQuery DeliveredAfter(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.DeliveredAfter, date);
	}

	public static DateSearchQuery DeliveredBefore(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.DeliveredBefore, date);
	}

	public static DateSearchQuery DeliveredOn(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.DeliveredOn, date);
	}

	[Obsolete("Use NotKeyword() instead.")]
	public static TextSearchQuery DoesNotHaveCustomFlag(string flag)
	{
		return NotKeyword(flag);
	}

	[Obsolete("Use NotKeywords() instead.")]
	public static SearchQuery DoesNotHaveCustomFlags(IEnumerable<string> flags)
	{
		return NotKeywords(flags);
	}

	[Obsolete("Use NotFlags() instead.")]
	public static SearchQuery DoesNotHaveFlags(MessageFlags flags)
	{
		return NotFlags(flags);
	}

	public static SearchQuery Filter(string name)
	{
		return new FilterSearchQuery(name);
	}

	public static SearchQuery Filter(MetadataTag filter)
	{
		return new FilterSearchQuery(filter);
	}

	public static TextSearchQuery FromContains(string text)
	{
		return new TextSearchQuery(SearchTerm.FromContains, text);
	}

	public static UnarySearchQuery Fuzzy(SearchQuery expr)
	{
		if (expr == null)
		{
			throw new ArgumentNullException("expr");
		}
		return new UnarySearchQuery(SearchTerm.Fuzzy, expr);
	}

	[Obsolete("Use HasKeyword() instead.")]
	public static TextSearchQuery HasCustomFlag(string flag)
	{
		return HasKeyword(flag);
	}

	[Obsolete("Use HasKeywords() instead.")]
	public static SearchQuery HasCustomFlags(IEnumerable<string> flags)
	{
		return HasKeywords(flags);
	}

	public static SearchQuery HasFlags(MessageFlags flags)
	{
		List<SearchQuery> list = new List<SearchQuery>();
		if ((flags & MessageFlags.Seen) != MessageFlags.None)
		{
			list.Add(Seen);
		}
		if ((flags & MessageFlags.Answered) != MessageFlags.None)
		{
			list.Add(Answered);
		}
		if ((flags & MessageFlags.Flagged) != MessageFlags.None)
		{
			list.Add(Flagged);
		}
		if ((flags & MessageFlags.Deleted) != MessageFlags.None)
		{
			list.Add(Deleted);
		}
		if ((flags & MessageFlags.Draft) != MessageFlags.None)
		{
			list.Add(Draft);
		}
		if ((flags & MessageFlags.Recent) != MessageFlags.None)
		{
			list.Add(Recent);
		}
		if (list.Count == 0)
		{
			throw new ArgumentException("No flags specified.", "flags");
		}
		SearchQuery searchQuery = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			searchQuery = searchQuery.And(list[i]);
		}
		return searchQuery;
	}

	public static SearchQuery NotFlags(MessageFlags flags)
	{
		List<SearchQuery> list = new List<SearchQuery>();
		if ((flags & MessageFlags.Seen) != MessageFlags.None)
		{
			list.Add(NotSeen);
		}
		if ((flags & MessageFlags.Answered) != MessageFlags.None)
		{
			list.Add(NotAnswered);
		}
		if ((flags & MessageFlags.Flagged) != MessageFlags.None)
		{
			list.Add(NotFlagged);
		}
		if ((flags & MessageFlags.Deleted) != MessageFlags.None)
		{
			list.Add(NotDeleted);
		}
		if ((flags & MessageFlags.Draft) != MessageFlags.None)
		{
			list.Add(NotDraft);
		}
		if ((flags & MessageFlags.Recent) != MessageFlags.None)
		{
			list.Add(NotRecent);
		}
		if (list.Count == 0)
		{
			throw new ArgumentException("No flags specified.", "flags");
		}
		SearchQuery searchQuery = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			searchQuery = searchQuery.And(list[i]);
		}
		return searchQuery;
	}

	public static TextSearchQuery HasKeyword(string keyword)
	{
		if (keyword == null)
		{
			throw new ArgumentNullException("keyword");
		}
		if (keyword.Length == 0)
		{
			throw new ArgumentException("The keyword cannot be an empty string.", "keyword");
		}
		return new TextSearchQuery(SearchTerm.Keyword, keyword);
	}

	public static SearchQuery HasKeywords(IEnumerable<string> keywords)
	{
		if (keywords == null)
		{
			throw new ArgumentNullException("keywords");
		}
		List<SearchQuery> list = new List<SearchQuery>();
		foreach (string keyword in keywords)
		{
			if (string.IsNullOrEmpty(keyword))
			{
				throw new ArgumentException("Cannot search for null or empty keywords.", "keywords");
			}
			list.Add(new TextSearchQuery(SearchTerm.Keyword, keyword));
		}
		if (list.Count == 0)
		{
			throw new ArgumentException("No keywords specified.", "keywords");
		}
		SearchQuery searchQuery = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			searchQuery = searchQuery.And(list[i]);
		}
		return searchQuery;
	}

	public static TextSearchQuery NotKeyword(string keyword)
	{
		if (keyword == null)
		{
			throw new ArgumentNullException("keyword");
		}
		if (keyword.Length == 0)
		{
			throw new ArgumentException("The keyword cannot be an empty string.", "keyword");
		}
		return new TextSearchQuery(SearchTerm.NotKeyword, keyword);
	}

	public static SearchQuery NotKeywords(IEnumerable<string> keywords)
	{
		if (keywords == null)
		{
			throw new ArgumentNullException("keywords");
		}
		List<SearchQuery> list = new List<SearchQuery>();
		foreach (string keyword in keywords)
		{
			if (string.IsNullOrEmpty(keyword))
			{
				throw new ArgumentException("Cannot search for null or empty keywords.", "keywords");
			}
			list.Add(new TextSearchQuery(SearchTerm.NotKeyword, keyword));
		}
		if (list.Count == 0)
		{
			throw new ArgumentException("No flags specified.", "keywords");
		}
		SearchQuery searchQuery = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			searchQuery = searchQuery.And(list[i]);
		}
		return searchQuery;
	}

	public static HeaderSearchQuery HeaderContains(string field, string text)
	{
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		if (field.Length == 0)
		{
			throw new ArgumentException("Cannot search an empty header field name.", "field");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		return new HeaderSearchQuery(field, text);
	}

	public static NumericSearchQuery LargerThan(int octets)
	{
		if (octets < 0)
		{
			throw new ArgumentOutOfRangeException("octets");
		}
		return new NumericSearchQuery(SearchTerm.LargerThan, (ulong)octets);
	}

	public static TextSearchQuery MessageContains(string text)
	{
		return new TextSearchQuery(SearchTerm.MessageContains, text);
	}

	public static UnarySearchQuery Not(SearchQuery expr)
	{
		if (expr == null)
		{
			throw new ArgumentNullException("expr");
		}
		return new UnarySearchQuery(SearchTerm.Not, expr);
	}

	public static NumericSearchQuery OlderThan(int seconds)
	{
		if (seconds < 1)
		{
			throw new ArgumentOutOfRangeException("seconds");
		}
		return new NumericSearchQuery(SearchTerm.Older, (ulong)seconds);
	}

	public static BinarySearchQuery Or(SearchQuery left, SearchQuery right)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		return new BinarySearchQuery(SearchTerm.Or, left, right);
	}

	public BinarySearchQuery Or(SearchQuery expr)
	{
		if (expr == null)
		{
			throw new ArgumentNullException("expr");
		}
		return new BinarySearchQuery(SearchTerm.Or, this, expr);
	}

	public static DateSearchQuery SavedBefore(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.SavedBefore, date);
	}

	public static DateSearchQuery SavedOn(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.SavedOn, date);
	}

	public static DateSearchQuery SavedSince(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.SavedSince, date);
	}

	[Obsolete("Use SentSince (DateTime)")]
	public static DateSearchQuery SentAfter(DateTime date)
	{
		return SentSince(date);
	}

	public static DateSearchQuery SentBefore(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.SentBefore, date);
	}

	public static DateSearchQuery SentOn(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.SentOn, date);
	}

	public static DateSearchQuery SentSince(DateTime date)
	{
		return new DateSearchQuery(SearchTerm.SentSince, date);
	}

	public static NumericSearchQuery SmallerThan(int octets)
	{
		if (octets < 0)
		{
			throw new ArgumentOutOfRangeException("octets");
		}
		return new NumericSearchQuery(SearchTerm.SmallerThan, (ulong)octets);
	}

	public static TextSearchQuery SubjectContains(string text)
	{
		return new TextSearchQuery(SearchTerm.SubjectContains, text);
	}

	public static TextSearchQuery ToContains(string text)
	{
		return new TextSearchQuery(SearchTerm.ToContains, text);
	}

	public static UidSearchQuery Uids(IList<UniqueId> uids)
	{
		return new UidSearchQuery(uids);
	}

	public static NumericSearchQuery YoungerThan(int seconds)
	{
		if (seconds < 1)
		{
			throw new ArgumentOutOfRangeException("seconds");
		}
		return new NumericSearchQuery(SearchTerm.Younger, (ulong)seconds);
	}

	public static NumericSearchQuery GMailMessageId(ulong id)
	{
		return new NumericSearchQuery(SearchTerm.GMailMessageId, id);
	}

	public static NumericSearchQuery GMailThreadId(ulong thread)
	{
		return new NumericSearchQuery(SearchTerm.GMailThreadId, thread);
	}

	public static TextSearchQuery HasGMailLabel(string label)
	{
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		if (label.Length == 0)
		{
			throw new ArgumentException("Cannot search for an empty string.", "label");
		}
		return new TextSearchQuery(SearchTerm.GMailLabels, label);
	}

	public static TextSearchQuery GMailRawSearch(string expression)
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		if (expression.Length == 0)
		{
			throw new ArgumentException("Cannot search for an empty string.", "expression");
		}
		return new TextSearchQuery(SearchTerm.GMailRaw, expression);
	}

	internal virtual SearchQuery Optimize(ISearchQueryOptimizer optimizer)
	{
		return optimizer.Reduce(this);
	}
}
