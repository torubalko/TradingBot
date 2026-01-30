using System;

namespace MailKit;

public class AnnotationAttribute : IEquatable<AnnotationAttribute>
{
	private static readonly char[] Wildcards = new char[2] { '*', '%' };

	public static readonly AnnotationAttribute Value = new AnnotationAttribute("value", AnnotationScope.Both);

	public static readonly AnnotationAttribute SharedValue = new AnnotationAttribute("value", AnnotationScope.Shared);

	public static readonly AnnotationAttribute PrivateValue = new AnnotationAttribute("value", AnnotationScope.Private);

	public static readonly AnnotationAttribute Size = new AnnotationAttribute("size", AnnotationScope.Both);

	public static readonly AnnotationAttribute SharedSize = new AnnotationAttribute("size", AnnotationScope.Shared);

	public static readonly AnnotationAttribute PrivateSize = new AnnotationAttribute("size", AnnotationScope.Private);

	public string Name { get; private set; }

	public AnnotationScope Scope { get; private set; }

	public string Specifier { get; private set; }

	private AnnotationAttribute(string name, AnnotationScope scope)
	{
		switch (scope)
		{
		case AnnotationScope.Shared:
			Specifier = $"{name}.shared";
			break;
		case AnnotationScope.Private:
			Specifier = $"{name}.priv";
			break;
		default:
			Specifier = name;
			break;
		}
		Scope = scope;
		Name = name;
	}

	public AnnotationAttribute(string specifier)
	{
		if (specifier == null)
		{
			throw new ArgumentNullException("specifier");
		}
		if (specifier.Length == 0)
		{
			throw new ArgumentException("Annotation attribute specifiers cannot be empty.", "specifier");
		}
		if (specifier.IndexOfAny(Wildcards) != -1)
		{
			throw new ArgumentException("Annotation attribute specifiers cannot contain '*' or '%'.", "specifier");
		}
		Specifier = specifier;
		if (specifier.EndsWith(".shared", StringComparison.Ordinal))
		{
			Name = specifier.Substring(0, specifier.Length - ".shared".Length);
			Scope = AnnotationScope.Shared;
		}
		else if (specifier.EndsWith(".priv", StringComparison.Ordinal))
		{
			Name = specifier.Substring(0, specifier.Length - ".priv".Length);
			Scope = AnnotationScope.Private;
		}
		else
		{
			Scope = AnnotationScope.Both;
			Name = specifier;
		}
	}

	public bool Equals(AnnotationAttribute other)
	{
		return other?.Specifier == Specifier;
	}

	public static bool operator ==(AnnotationAttribute attr1, AnnotationAttribute attr2)
	{
		return attr1?.Specifier == attr2?.Specifier;
	}

	public static bool operator !=(AnnotationAttribute attr1, AnnotationAttribute attr2)
	{
		return attr1?.Specifier != attr2?.Specifier;
	}

	public override bool Equals(object obj)
	{
		if (obj is AnnotationAttribute)
		{
			return ((AnnotationAttribute)obj).Specifier == Specifier;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Specifier.GetHashCode();
	}

	public override string ToString()
	{
		return Specifier;
	}
}
