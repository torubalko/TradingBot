using System;

namespace MailKit;

public class AnnotationEntry : IEquatable<AnnotationEntry>
{
	public static readonly AnnotationEntry Comment = new AnnotationEntry("/comment");

	public static readonly AnnotationEntry PrivateComment = new AnnotationEntry("/comment", AnnotationScope.Private);

	public static readonly AnnotationEntry SharedComment = new AnnotationEntry("/comment", AnnotationScope.Shared);

	public static readonly AnnotationEntry Flags = new AnnotationEntry("/flags");

	public static readonly AnnotationEntry PrivateFlags = new AnnotationEntry("/flags", AnnotationScope.Private);

	public static readonly AnnotationEntry SharedFlags = new AnnotationEntry("/flags", AnnotationScope.Shared);

	public static readonly AnnotationEntry AltSubject = new AnnotationEntry("/altsubject");

	public static readonly AnnotationEntry PrivateAltSubject = new AnnotationEntry("/altsubject", AnnotationScope.Private);

	public static readonly AnnotationEntry SharedAltSubject = new AnnotationEntry("/altsubject", AnnotationScope.Shared);

	public string Entry { get; private set; }

	public string PartSpecifier { get; private set; }

	public string Path { get; private set; }

	public AnnotationScope Scope { get; private set; }

	private static void ValidatePath(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException("Annotation entry paths cannot be empty.", "path");
		}
		if (path[0] != '/' && path[0] != '*' && path[0] != '%')
		{
			throw new ArgumentException("Annotation entry paths must begin with '/'.", "path");
		}
		if (path.Length > 1 && path[1] >= '0' && path[1] <= '9')
		{
			throw new ArgumentException("Annotation entry paths must not include a part-specifier.", "path");
		}
		if (path == "*" || path == "%")
		{
			return;
		}
		char c = path[0];
		for (int i = 1; i < path.Length; i++)
		{
			char c2 = path[i];
			if (c2 > '\u007f')
			{
				throw new ArgumentException($"Invalid character in annotation entry path: '{c2}'.", "path");
			}
			if (c2 >= '0' && c2 <= '9' && c == '/')
			{
				throw new ArgumentException("Invalid annotation entry path.", "path");
			}
			if ((c == '/' || c == '.') && (c2 == '/' || c2 == '.'))
			{
				throw new ArgumentException("Invalid annotation entry path.", "path");
			}
			c = c2;
		}
		int index = path.Length - 1;
		if (path[index] == '/')
		{
			throw new ArgumentException("Annotation entry paths must not end with '/'.", "path");
		}
		if (path[index] != '.')
		{
			return;
		}
		throw new ArgumentException("Annotation entry paths must not end with '.'.", "path");
	}

	private static void ValidatePartSpecifier(string partSpecifier)
	{
		if (partSpecifier == null)
		{
			throw new ArgumentNullException("partSpecifier");
		}
		char c = '\0';
		foreach (char c2 in partSpecifier)
		{
			if (((c2 < '0' || c2 > '9') && c2 != '.') || (c2 == '.' && (c == '.' || c == '\0')))
			{
				throw new ArgumentException("Invalid part-specifier.", "partSpecifier");
			}
			c = c2;
		}
		if (c == '.')
		{
			throw new ArgumentException("Invalid part-specifier.", "partSpecifier");
		}
	}

	private AnnotationEntry()
	{
	}

	public AnnotationEntry(string path, AnnotationScope scope = AnnotationScope.Both)
	{
		ValidatePath(path);
		switch (scope)
		{
		case AnnotationScope.Private:
			Entry = path + ".priv";
			break;
		case AnnotationScope.Shared:
			Entry = path + ".shared";
			break;
		default:
			Entry = path;
			break;
		}
		PartSpecifier = null;
		Path = path;
		Scope = scope;
	}

	public AnnotationEntry(string partSpecifier, string path, AnnotationScope scope = AnnotationScope.Both)
	{
		ValidatePartSpecifier(partSpecifier);
		ValidatePath(path);
		switch (scope)
		{
		case AnnotationScope.Private:
			Entry = $"/{partSpecifier}{path}.priv";
			break;
		case AnnotationScope.Shared:
			Entry = $"/{partSpecifier}{path}.shared";
			break;
		default:
			Entry = $"/{partSpecifier}{path}";
			break;
		}
		PartSpecifier = partSpecifier;
		Path = path;
		Scope = scope;
	}

	public AnnotationEntry(BodyPart part, string path, AnnotationScope scope = AnnotationScope.Both)
	{
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		ValidatePath(path);
		switch (scope)
		{
		case AnnotationScope.Private:
			Entry = $"/{part.PartSpecifier}{path}.priv";
			break;
		case AnnotationScope.Shared:
			Entry = $"/{part.PartSpecifier}{path}.shared";
			break;
		default:
			Entry = $"/{part.PartSpecifier}{path}";
			break;
		}
		PartSpecifier = part.PartSpecifier;
		Path = path;
		Scope = scope;
	}

	public bool Equals(AnnotationEntry other)
	{
		return other?.Entry == Entry;
	}

	public static bool operator ==(AnnotationEntry entry1, AnnotationEntry entry2)
	{
		return entry1?.Entry == entry2?.Entry;
	}

	public static bool operator !=(AnnotationEntry entry1, AnnotationEntry entry2)
	{
		return entry1?.Entry != entry2?.Entry;
	}

	public override bool Equals(object obj)
	{
		if (obj is AnnotationEntry)
		{
			return ((AnnotationEntry)obj).Entry == Entry;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Entry.GetHashCode();
	}

	public override string ToString()
	{
		return Entry;
	}

	public static AnnotationEntry Parse(string entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (entry.Length == 0)
		{
			throw new FormatException("An annotation entry cannot be empty.");
		}
		if (entry[0] != '/' && entry[0] != '*' && entry[0] != '%')
		{
			throw new FormatException("An annotation entry must begin with a '/' character.");
		}
		AnnotationScope scope = AnnotationScope.Both;
		int num = 0;
		string partSpecifier = null;
		int num2 = 0;
		char c = entry[0];
		int num3;
		for (int i = 1; i < entry.Length; i++)
		{
			char c2 = entry[i];
			if (c2 >= '0' && c2 <= '9' && c == '/')
			{
				if (num2 > 0)
				{
					throw new FormatException("Invalid annotation entry.");
				}
				num = i;
				num3 = i + 1;
				c = c2;
				while (num3 < entry.Length)
				{
					c2 = entry[num3];
					if (c2 == '/')
					{
						if (c != '.')
						{
							break;
						}
						throw new FormatException("Invalid part-specifier in annotation entry.");
					}
					if ((c2 < '0' || c2 > '9') && c2 != '.')
					{
						throw new FormatException($"Invalid character in part-specifier: '{c2}'.");
					}
					if (c2 == '.' && c == '.')
					{
						throw new FormatException("Invalid part-specifier in annotation entry.");
					}
					num3++;
					c = c2;
				}
				if (num3 >= entry.Length)
				{
					throw new FormatException("Incomplete part-specifier in annotation entry.");
				}
				partSpecifier = entry.Substring(num, num3 - num);
				i = (num = num3);
				num2++;
			}
			else if (c2 == '/' || c2 == '.')
			{
				if (c == '/' || c == '.')
				{
					throw new FormatException("Invalid annotation entry path.");
				}
				if (c2 == '/')
				{
					num2++;
				}
			}
			else if (c2 > '\u007f')
			{
				throw new FormatException($"Invalid character in annotation entry path: '{c2}'.");
			}
			c = c2;
		}
		if (c == '/' || c == '.')
		{
			throw new FormatException("Invalid annotation entry path.");
		}
		if (entry.EndsWith(".shared", StringComparison.Ordinal))
		{
			num3 = entry.Length - ".shared".Length;
			scope = AnnotationScope.Shared;
		}
		else if (entry.EndsWith(".priv", StringComparison.Ordinal))
		{
			num3 = entry.Length - ".priv".Length;
			scope = AnnotationScope.Private;
		}
		else
		{
			num3 = entry.Length;
		}
		string path = entry.Substring(num, num3 - num);
		return new AnnotationEntry
		{
			PartSpecifier = partSpecifier,
			Entry = entry,
			Path = path,
			Scope = scope
		};
	}

	internal static AnnotationEntry Create(string entry)
	{
		return entry switch
		{
			"/comment" => Comment, 
			"/comment.priv" => PrivateComment, 
			"/comment.shared" => SharedComment, 
			"/flags" => Flags, 
			"/flags.priv" => PrivateFlags, 
			"/flags.shared" => SharedFlags, 
			"/altsubject" => AltSubject, 
			"/altsubject.priv" => PrivateAltSubject, 
			"/altsubject.shared" => SharedAltSubject, 
			_ => Parse(entry), 
		};
	}
}
