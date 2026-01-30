using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetFolder : ICodeSnippetFolder
{
	private List<ICodeSnippetFolder> kC2;

	private List<ICodeSnippetMetadata> GC7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string TCi;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object oCp;

	internal static CodeSnippetFolder Ba4;

	public IList<ICodeSnippetFolder> Folders
	{
		get
		{
			if (kC2 == null)
			{
				kC2 = new List<ICodeSnippetFolder>();
			}
			return kC2;
		}
	}

	public IList<ICodeSnippetMetadata> Items
	{
		get
		{
			if (GC7 == null)
			{
				GC7 = new List<ICodeSnippetMetadata>();
			}
			return GC7;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return TCi;
		}
		[CompilerGenerated]
		set
		{
			TCi = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return oCp;
		}
		[CompilerGenerated]
		set
		{
			oCp = value;
		}
	}

	public CodeSnippetFolder(string name)
	{
		grA.DaB7cz();
		base._002Ector();
		Name = name;
	}

	public ICodeSnippetMetadata FindItemByShortcut(string shortcut, bool isCaseSensitive)
	{
		if (GC7 != null)
		{
			foreach (ICodeSnippetMetadata item in GC7)
			{
				if (string.Compare(item.Shortcut, shortcut, isCaseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) == 0)
				{
					return item;
				}
			}
		}
		if (kC2 != null)
		{
			foreach (ICodeSnippetFolder item2 in kC2)
			{
				ICodeSnippetMetadata codeSnippetMetadata = item2.FindItemByShortcut(shortcut, isCaseSensitive);
				if (codeSnippetMetadata != null)
				{
					return codeSnippetMetadata;
				}
			}
		}
		return null;
	}

	public static ICodeSnippetFolder LoadFrom(string path, string language)
	{
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException(Q7Z.tqM(12470));
		}
		if (!Directory.Exists(path))
		{
			return null;
		}
		CodeSnippetFolder codeSnippetFolder = new CodeSnippetFolder(Path.GetFileName(path));
		CodeSnippetSerializer codeSnippetSerializer = new CodeSnippetSerializer();
		foreach (string item in Directory.EnumerateFiles(path, Q7Z.tqM(12482), SearchOption.TopDirectoryOnly))
		{
			try
			{
				IEnumerable<ICodeSnippet> enumerable = codeSnippetSerializer.LoadFromFile(item);
				if (enumerable == null)
				{
					continue;
				}
				foreach (ICodeSnippet item2 in enumerable)
				{
					CodeSnippetFile codeSnippetFile = new CodeSnippetFile(item, item2);
					if (codeSnippetFile != null && (string.IsNullOrEmpty(language) || string.Compare(codeSnippetFile.CodeLanguage, language, StringComparison.OrdinalIgnoreCase) == 0))
					{
						codeSnippetFolder.Items.Add(codeSnippetFile);
					}
				}
			}
			catch (NotSupportedException)
			{
			}
			catch (SecurityException)
			{
			}
			catch (IOException)
			{
			}
		}
		try
		{
			foreach (string item3 in Directory.EnumerateDirectories(path, Q7Z.tqM(12504), SearchOption.TopDirectoryOnly))
			{
				ICodeSnippetFolder codeSnippetFolder2 = LoadFrom(item3, language);
				if (codeSnippetFolder2 != null && codeSnippetFolder2.Folders.Count + codeSnippetFolder2.Items.Count > 0)
				{
					codeSnippetFolder.Folders.Add(codeSnippetFolder2);
				}
			}
		}
		catch (NotSupportedException)
		{
		}
		catch (SecurityException)
		{
		}
		catch (IOException)
		{
		}
		return (codeSnippetFolder.Folders.Count + codeSnippetFolder.Items.Count > 0) ? codeSnippetFolder : null;
	}

	internal static bool caD()
	{
		return Ba4 == null;
	}

	internal static CodeSnippetFolder oaB()
	{
		return Ba4;
	}
}
