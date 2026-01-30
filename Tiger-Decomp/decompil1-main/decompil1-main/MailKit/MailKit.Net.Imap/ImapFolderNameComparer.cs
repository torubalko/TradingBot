using System.Collections.Generic;

namespace MailKit.Net.Imap;

internal class ImapFolderNameComparer : IEqualityComparer<string>
{
	public char DirectorySeparator;

	public ImapFolderNameComparer(char directorySeparator)
	{
		DirectorySeparator = directorySeparator;
	}

	public bool Equals(string x, string y)
	{
		x = ImapUtils.CanonicalizeMailboxName(x, DirectorySeparator);
		y = ImapUtils.CanonicalizeMailboxName(y, DirectorySeparator);
		return x == y;
	}

	public int GetHashCode(string obj)
	{
		return ImapUtils.CanonicalizeMailboxName(obj, DirectorySeparator).GetHashCode();
	}
}
