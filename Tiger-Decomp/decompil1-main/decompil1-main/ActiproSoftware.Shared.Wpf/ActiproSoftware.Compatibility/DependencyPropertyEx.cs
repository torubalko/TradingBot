using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace ActiproSoftware.Compatibility;

[SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
public static class DependencyPropertyEx
{
	private static DependencyPropertyEx IgA;

	public static DependencyProperty Register(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata)
	{
		return DependencyProperty.Register(name, propertyType, ownerType, typeMetadata);
	}

	public static DependencyProperty Register(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata, ValidateValueCallback validateValueCallback)
	{
		return DependencyProperty.Register(name, propertyType, ownerType, typeMetadata, validateValueCallback);
	}

	public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata)
	{
		return DependencyProperty.RegisterAttached(name, propertyType, ownerType, typeMetadata);
	}

	public static DependencyProperty RegisterAttached(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata, ValidateValueCallback validateValueCallback)
	{
		return DependencyProperty.RegisterAttached(name, propertyType, ownerType, typeMetadata, validateValueCallback);
	}

	public static DependencyPropertyKey RegisterAttachedReadOnly(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata)
	{
		return DependencyProperty.RegisterAttachedReadOnly(name, propertyType, ownerType, typeMetadata);
	}

	public static DependencyPropertyKey RegisterReadOnly(string name, Type propertyType, Type ownerType, PropertyMetadata typeMetadata)
	{
		return DependencyProperty.RegisterReadOnly(name, propertyType, ownerType, typeMetadata);
	}

	internal static bool wgV()
	{
		return IgA == null;
	}

	internal static DependencyPropertyEx PgT()
	{
		return IgA;
	}
}
