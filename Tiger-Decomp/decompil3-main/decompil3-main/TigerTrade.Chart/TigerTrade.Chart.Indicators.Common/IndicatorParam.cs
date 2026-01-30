using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Indicators.Common;

[Browsable(false)]
[DataContract(Name = "IndicatorParam", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public abstract class IndicatorParam<T>
{
	private string _cacheKey;

	private bool _valueCached;

	private T _cacheValue;

	internal static object RY9VSSeMkT8q8FCgM7fr;

	[Browsable(false)]
	[DataMember(Name = "Value")]
	public T Value { get; set; }

	[Browsable(false)]
	[DataMember(Name = "Values")]
	public Dictionary<string, T> Values { get; set; }

	protected IndicatorParam()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Values = new Dictionary<string, T>();
	}

	public T Get(string key, T defaultValue)
	{
		if (string.IsNullOrEmpty(key))
		{
			return defaultValue;
		}
		if (_valueCached && key == _cacheKey)
		{
			return _cacheValue;
		}
		if (!Values.ContainsKey(key))
		{
			return defaultValue;
		}
		_cacheKey = key;
		_cacheValue = Values[key];
		_valueCached = true;
		Value = _cacheValue;
		return _cacheValue;
	}

	public T Get(string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			return Value;
		}
		if (_valueCached && key == _cacheKey)
		{
			return _cacheValue;
		}
		if (!Values.ContainsKey(key))
		{
			Values.Add(key, Value);
		}
		_cacheKey = key;
		_cacheValue = Values[key];
		_valueCached = true;
		Value = _cacheValue;
		return _cacheValue;
	}

	protected bool Set(string key, T value)
	{
		_valueCached = false;
		if (string.IsNullOrEmpty(key))
		{
			if (object.Equals(value, Value))
			{
				return false;
			}
			Value = value;
			return true;
		}
		if (!Values.ContainsKey(key))
		{
			Value = value;
			Values.Add(key, Value);
			return true;
		}
		if (object.Equals(value, Values[key]))
		{
			Value = value;
			return false;
		}
		Value = value;
		Values[key] = value;
		return true;
	}

	public void Copy(IndicatorParam<T> p)
	{
		_valueCached = false;
		Value = p.Value;
		Values.Clear();
		foreach (KeyValuePair<string, T> value in p.Values)
		{
			Values.Add(value.Key, value.Value);
		}
	}

	public void Clear()
	{
		Values.Clear();
		Value = default(T);
	}

	static IndicatorParam()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool PDs9iZeM1LprnUKTZSPt()
	{
		return RY9VSSeMkT8q8FCgM7fr == null;
	}

	internal static object jcoXlneM5ayVQZxmS1x0()
	{
		return RY9VSSeMkT8q8FCgM7fr;
	}
}
