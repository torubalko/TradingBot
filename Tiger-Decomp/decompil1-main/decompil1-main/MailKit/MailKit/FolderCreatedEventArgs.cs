using System;

namespace MailKit;

public class FolderCreatedEventArgs : EventArgs
{
	public IMailFolder Folder { get; private set; }

	public FolderCreatedEventArgs(IMailFolder folder)
	{
		if (folder == null)
		{
			throw new ArgumentNullException("folder");
		}
		Folder = folder;
	}
}
