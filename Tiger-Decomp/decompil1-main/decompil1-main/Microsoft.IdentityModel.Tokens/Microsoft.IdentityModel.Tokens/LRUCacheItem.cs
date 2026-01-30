using System;
using System.Collections.Generic;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal class LRUCacheItem<TKey, TValue>
{
	internal TKey Key { get; }

	internal TValue Value { get; set; }

	internal DateTime ExpirationTime { get; set; }

	internal LRUCacheItem(TKey key, TValue value)
	{
		if (key == null)
		{
			throw LogHelper.LogArgumentNullException("key");
		}
		Key = key;
		if (value == null)
		{
			throw LogHelper.LogArgumentNullException("value");
		}
		Value = value;
	}

	internal LRUCacheItem(TKey key, TValue value, DateTime expirationTime)
	{
		if (key == null)
		{
			throw LogHelper.LogArgumentNullException("key");
		}
		Key = key;
		if (value == null)
		{
			throw LogHelper.LogArgumentNullException("value");
		}
		Value = value;
		ExpirationTime = expirationTime;
	}

	public override bool Equals(object obj)
	{
		if (obj is LRUCacheItem<TKey, TValue> lRUCacheItem)
		{
			return Key.Equals(lRUCacheItem.Key);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return 990326508 + EqualityComparer<TKey>.Default.GetHashCode(Key);
	}
}
