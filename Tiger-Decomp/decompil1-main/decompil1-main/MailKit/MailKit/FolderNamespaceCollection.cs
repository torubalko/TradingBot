using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MimeKit.Utils;

namespace MailKit;

public class FolderNamespaceCollection : IEnumerable<FolderNamespace>, IEnumerable
{
	private readonly List<FolderNamespace> namespaces;

	public int Count => namespaces.Count;

	public FolderNamespace this[int index]
	{
		get
		{
			if (index < 0 || index >= namespaces.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return namespaces[index];
		}
		set
		{
			if (index < 0 || index >= namespaces.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			namespaces[index] = value;
		}
	}

	public FolderNamespaceCollection()
	{
		namespaces = new List<FolderNamespace>();
	}

	public void Add(FolderNamespace @namespace)
	{
		if (@namespace == null)
		{
			throw new ArgumentNullException("namespace");
		}
		namespaces.Add(@namespace);
	}

	public void Clear()
	{
		namespaces.Clear();
	}

	public bool Contains(FolderNamespace @namespace)
	{
		if (@namespace == null)
		{
			throw new ArgumentNullException("namespace");
		}
		return namespaces.Contains(@namespace);
	}

	public bool Remove(FolderNamespace @namespace)
	{
		if (@namespace == null)
		{
			throw new ArgumentNullException("namespace");
		}
		return namespaces.Remove(@namespace);
	}

	public IEnumerator<FolderNamespace> GetEnumerator()
	{
		return namespaces.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return namespaces.GetEnumerator();
	}

	private static bool Escape(char directorySeparator)
	{
		if (directorySeparator != '\\')
		{
			return directorySeparator == '"';
		}
		return true;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('(');
		for (int i = 0; i < namespaces.Count; i++)
		{
			stringBuilder.Append("(\"");
			if (Escape(namespaces[i].DirectorySeparator))
			{
				stringBuilder.Append('\\');
			}
			stringBuilder.Append(namespaces[i].DirectorySeparator);
			stringBuilder.Append("\" ");
			MimeUtils.AppendQuoted(stringBuilder, namespaces[i].Path);
			stringBuilder.Append(")");
		}
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}
}
