using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetFile : CodeSnippetMetadataBase
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string fCq;

	private static CodeSnippetFile txz;

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return fCq;
		}
		[CompilerGenerated]
		private set
		{
			fCq = value;
		}
	}

	public CodeSnippetFile(string path, ICodeSnippet codeSnippet)
	{
		grA.DaB7cz();
		base._002Ector();
		if (string.IsNullOrEmpty(path))
		{
			throw new ArgumentNullException(Q7Z.tqM(12470));
		}
		if (codeSnippet == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12064));
		}
		Path = path;
		base.CodeKind = codeSnippet.CodeKind;
		base.CodeLanguage = codeSnippet.CodeLanguage;
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		base.Description = codeSnippet.Description;
		base.Shortcut = codeSnippet.Shortcut;
		base.SnippetTypes = codeSnippet.SnippetTypes;
		base.Title = codeSnippet.Title;
	}

	public override ICodeSnippet GetCodeSnippet()
	{
		try
		{
			CodeSnippetSerializer codeSnippetSerializer = new CodeSnippetSerializer();
			IEnumerable<ICodeSnippet> enumerable = codeSnippetSerializer.LoadFromFile(Path);
			if (enumerable != null)
			{
				foreach (ICodeSnippet item in enumerable)
				{
					if (item.Title == base.Title)
					{
						return item;
					}
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
		return null;
	}

	internal static bool Lam()
	{
		return txz == null;
	}

	internal static CodeSnippetFile Jap()
	{
		return txz;
	}
}
