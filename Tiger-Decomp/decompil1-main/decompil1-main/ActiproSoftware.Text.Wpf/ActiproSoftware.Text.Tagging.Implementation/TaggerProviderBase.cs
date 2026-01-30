using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public abstract class TaggerProviderBase<TTagger> where TTagger : class
{
	private static object NAf;

	public IEnumerable<Type> TagTypes
	{
		get
		{
			List<Type> list = new List<Type>();
			Type typeFromHandle = typeof(TTagger);
			Type[] interfaces = typeFromHandle.GetInterfaces();
			Type[] array = interfaces;
			foreach (Type type in array)
			{
				if (type.IsGenericType && type.Name == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5786) && type.Namespace == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5808))
				{
					Type[] genericArguments = type.GetGenericArguments();
					if (genericArguments != null && genericArguments.Length == 1 && typeof(ITag).IsAssignableFrom(genericArguments[0]))
					{
						list.Add(genericArguments[0]);
					}
				}
			}
			return list;
		}
	}

	protected TaggerProviderBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool pAM()
	{
		return NAf == null;
	}

	internal static object lAZ()
	{
		return NAf;
	}
}
