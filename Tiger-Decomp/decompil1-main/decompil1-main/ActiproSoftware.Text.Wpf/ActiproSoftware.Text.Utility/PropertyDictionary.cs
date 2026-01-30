using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

[SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
public class PropertyDictionary
{
	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	public delegate TValue Creator<TValue>();

	private Dictionary<object, object> IBB;

	private object dB9;

	private static PropertyDictionary JWj;

	public ReadOnlyCollection<object> Keys
	{
		get
		{
			lock (dB9)
			{
				List<object> list = new List<object>(IBB.Keys);
				return new ReadOnlyCollection<object>(list);
			}
		}
	}

	public object this[object key]
	{
		get
		{
			lock (dB9)
			{
				return IBB[key];
			}
		}
		set
		{
			lock (dB9)
			{
				IBB[key] = value;
			}
		}
	}

	public void Add(object key, object value)
	{
		lock (dB9)
		{
			IBB.Add(key, value);
		}
	}

	public bool ContainsKey(object key)
	{
		lock (dB9)
		{
			return IBB.ContainsKey(key);
		}
	}

	public TValue GetOrCreateSingleton<TValue>(Creator<TValue> creator)
	{
		return GetOrCreateSingleton(typeof(TValue), creator);
	}

	public TValue GetOrCreateSingleton<TValue>(object key, Creator<TValue> creator)
	{
		if (creator == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5244));
		}
		if (!TryGetValue<TValue>(key, out var value))
		{
			value = creator();
			if (value != null)
			{
				IBB.Add(key, value);
			}
		}
		return value;
	}

	public bool Remove(object key)
	{
		lock (dB9)
		{
			return IBB.Remove(key);
		}
	}

	public bool TryGetValue<TValue>(object key, out TValue value)
	{
		lock (dB9)
		{
			if (IBB.TryGetValue(key, out var value2))
			{
				value = (TValue)value2;
				return true;
			}
			value = default(TValue);
			return false;
		}
	}

	public PropertyDictionary()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		IBB = new Dictionary<object, object>();
		dB9 = new object();
		base._002Ector();
	}

	internal static bool HWK()
	{
		return JWj == null;
	}

	internal static PropertyDictionary GWl()
	{
		return JWj;
	}
}
