using System;
using System.Collections.Generic;

namespace MailKit.Search;

public class UidSearchQuery : SearchQuery
{
	public new IList<UniqueId> Uids { get; private set; }

	public UidSearchQuery(IList<UniqueId> uids)
		: base(SearchTerm.Uid)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (uids.Count == 0)
		{
			throw new ArgumentException("Cannot search for an empty set of unique identifiers.", "uids");
		}
		Uids = uids;
	}

	public UidSearchQuery(UniqueId uid)
		: base(SearchTerm.Uid)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("Cannot search for an invalid unique identifier.", "uid");
		}
		Uids = new UniqueIdSet(SortOrder.Ascending);
		Uids.Add(uid);
	}
}
