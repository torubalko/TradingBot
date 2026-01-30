using System;

namespace MailKit.Net.Imap;

public sealed class ImapFolderConstructorArgs
{
	internal readonly string EncodedName;

	internal readonly ImapEngine Engine;

	public FolderAttributes Attributes { get; private set; }

	public char DirectorySeparator { get; private set; }

	public string FullName { get; private set; }

	public string Name { get; private set; }

	internal ImapFolderConstructorArgs(ImapEngine engine, string encodedName, FolderAttributes attributes, char delim)
		: this()
	{
		FullName = engine.DecodeMailboxName(encodedName);
		Name = GetBaseName(FullName, delim);
		DirectorySeparator = delim;
		EncodedName = encodedName;
		Attributes = attributes;
		Engine = engine;
	}

	private ImapFolderConstructorArgs()
	{
	}

	private static string GetBaseName(string fullName, char delim)
	{
		string[] array = fullName.Split(new char[1] { delim }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length == 0)
		{
			return fullName;
		}
		return array[array.Length - 1];
	}
}
