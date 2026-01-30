using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MailKit;

public class MessagesVanishedEventArgs : EventArgs
{
	public IList<UniqueId> UniqueIds { get; private set; }

	public bool Earlier { get; private set; }

	public MessagesVanishedEventArgs(IList<UniqueId> uids, bool earlier)
	{
		UniqueIds = new ReadOnlyCollection<UniqueId>(uids);
		Earlier = earlier;
	}
}
