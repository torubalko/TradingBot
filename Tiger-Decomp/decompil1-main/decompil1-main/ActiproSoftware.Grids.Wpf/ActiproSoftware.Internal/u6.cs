using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace ActiproSoftware.Internal;

internal static class u6
{
	internal static u6 W68;

	private static bool CW5(Type P_0)
	{
		if (P_0.IsGenericType)
		{
			return P_0.GetGenericTypeDefinition() == typeof(ICollection<>);
		}
		return false;
	}

	public static bool OWW(object P_0, object P_1)
	{
		if (P_0 is IList { IsReadOnly: false, IsFixedSize: false } list)
		{
			list.Add(P_1);
			return true;
		}
		return false;
	}

	public static bool EWn(object P_0)
	{
		if (P_0 is IList { IsReadOnly: false, IsFixedSize: false } list)
		{
			Type type = TWN(list);
			int num = 0;
			if (F6m() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (type != null)
			{
				if (!type.IsValueType && !(type == typeof(string)))
				{
					if (!type.IsAbstract)
					{
						return type.GetConstructor(Type.EmptyTypes) != null;
					}
					return false;
				}
				return true;
			}
		}
		return false;
	}

	public static object vWp(object P_0)
	{
		Type type;
		if (P_0 is IList list)
		{
			type = TWN(list);
			if (type != null)
			{
				if (type == typeof(string))
				{
					return string.Empty;
				}
				if (type.IsValueType)
				{
					goto IL_00ad;
				}
				if (!type.IsAbstract)
				{
					int num = 0;
					if (F6m() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					if (type.GetConstructor(Type.EmptyTypes) != null)
					{
						goto IL_00ad;
					}
				}
			}
		}
		return null;
		IL_00ad:
		return Activator.CreateInstance(type);
	}

	public static int jWE(object P_0)
	{
		if (P_0 is ICollection collection)
		{
			return collection.Count;
		}
		if (P_0 != null)
		{
			Type[] interfaces = P_0.GetType().GetInterfaces();
			foreach (Type type in interfaces)
			{
				if (CW5(type))
				{
					PropertyInfo property = type.GetProperty(xv.hTz(8748));
					if (property != null)
					{
						return (int)property.GetValue(P_0, null);
					}
				}
			}
		}
		return 0;
	}

	public static Type oWC(ICollection P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(8762));
		}
		Type[] interfaces = P_0.GetType().GetInterfaces();
		foreach (Type type in interfaces)
		{
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ICollection<>))
			{
				return type.GetGenericArguments()[0];
			}
		}
		return null;
	}

	public static Type zWK(IDictionary P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(8786));
		}
		Type[] interfaces = P_0.GetType().GetInterfaces();
		int num = 0;
		Type type;
		while (true)
		{
			if (num >= interfaces.Length)
			{
				return null;
			}
			type = interfaces[num];
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IDictionary<, >))
			{
				break;
			}
			num++;
		}
		return type.GetGenericArguments()[1];
	}

	public static Type TWN(IList P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(8810));
		}
		Type[] interfaces = P_0.GetType().GetInterfaces();
		int num = 0;
		if (F6m() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			foreach (Type type in interfaces)
			{
				if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IList<>))
				{
					return type.GetGenericArguments()[0];
				}
			}
			return null;
		}
	}

	public static bool KWl(Type P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(8822));
		}
		if (typeof(ICollection).IsAssignableFrom(P_0))
		{
			return true;
		}
		if (CW5(P_0))
		{
			return true;
		}
		Type[] interfaces = P_0.GetInterfaces();
		for (int i = 0; i < interfaces.Length; i++)
		{
			if (CW5(interfaces[i]))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool C6k()
	{
		return W68 == null;
	}

	internal static u6 F6m()
	{
		return W68;
	}
}
