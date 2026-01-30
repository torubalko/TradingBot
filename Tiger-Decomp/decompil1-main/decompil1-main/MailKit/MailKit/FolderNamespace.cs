using System;

namespace MailKit;

public class FolderNamespace
{
	public readonly char DirectorySeparator;

	public readonly string Path;

	public FolderNamespace(char directorySeparator, string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		DirectorySeparator = directorySeparator;
		Path = path;
	}
}
