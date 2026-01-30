using System.Collections.Generic;

namespace MailKit.Search;

public class SearchResults
{
	public IList<UniqueId> UniqueIds { get; set; }

	public int Count { get; set; }

	public UniqueId? Min { get; set; }

	public UniqueId? Max { get; set; }

	public ulong? ModSeq { get; set; }

	public IList<byte> Relevancy { get; set; }

	public SearchResults(uint uidValidity, SortOrder order = SortOrder.None)
	{
		UniqueIds = new UniqueIdSet(uidValidity, order);
	}

	public SearchResults(SortOrder order = SortOrder.None)
	{
		UniqueIds = new UniqueIdSet(order);
	}
}
