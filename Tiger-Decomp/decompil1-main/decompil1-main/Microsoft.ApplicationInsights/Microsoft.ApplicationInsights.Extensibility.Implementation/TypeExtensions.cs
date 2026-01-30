using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal static class TypeExtensions
{
	public static bool IsAssignableFrom(this Type type, Type otherType)
	{
		return type.GetTypeInfo().IsAssignableFrom(otherType.GetTypeInfo());
	}

	public static PropertyInfo[] GetProperties(this Type type)
	{
		List<PropertyInfo> list = new List<PropertyInfo>();
		list.AddRange(type.GetTypeInfo().DeclaredProperties);
		Type baseType = type.GetTypeInfo().BaseType;
		if (baseType != null)
		{
			list.AddRange(baseType.GetProperties());
		}
		return list.ToArray();
	}

	public static Type[] GetGenericArguments(this Type type)
	{
		return type.GetTypeInfo().GenericTypeArguments;
	}

	public static Type[] GetInterfaces(this Type type)
	{
		return type.GetTypeInfo().ImplementedInterfaces.ToArray();
	}

	public static bool IsAbstract(this Type type)
	{
		return type.GetTypeInfo().IsAbstract;
	}

	public static bool IsGenericType(this Type type)
	{
		return type.GetTypeInfo().IsGenericType;
	}
}
