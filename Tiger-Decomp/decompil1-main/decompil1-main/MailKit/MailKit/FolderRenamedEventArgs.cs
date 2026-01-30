using System;

namespace MailKit;

public class FolderRenamedEventArgs : EventArgs
{
	public string OldName { get; private set; }

	public string NewName { get; private set; }

	public FolderRenamedEventArgs(string oldName, string newName)
	{
		if (oldName == null)
		{
			throw new ArgumentNullException("oldName");
		}
		if (newName == null)
		{
			throw new ArgumentNullException("newName");
		}
		OldName = oldName;
		NewName = newName;
	}
}
