using System;
using System.Resources;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Properties;

namespace TigerTrade.Chart.Objects.Common;

[AttributeUsage(AttributeTargets.Class)]
public class ChartObjectAttribute : Attribute
{
	private static ChartObjectAttribute kY7fPyenzqXlBShS5L0p;

	public string ID { get; }

	public string Name { get; }

	public int Points { get; }

	public Type Type { get; set; }

	public ChartObjectAttribute(string id, string name, int points)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		ID = id;
		Name = LookupResource(name);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Points = points;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static string LookupResource(string resourceKey)
	{
		return (string)(bj8b2SeGHqkqbq5vdqyV(Resources.ResourceManager, resourceKey) ?? resourceKey);
	}

	static ChartObjectAttribute()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		zkY3sbeGfwMYrjqU37X2();
	}

	internal static bool UFAkLAeG0C6iMWNN6VEN()
	{
		return kY7fPyenzqXlBShS5L0p == null;
	}

	internal static ChartObjectAttribute BR1sdPeG2I68VXugZ9el()
	{
		return kY7fPyenzqXlBShS5L0p;
	}

	internal static object bj8b2SeGHqkqbq5vdqyV(object P_0, object P_1)
	{
		return ((ResourceManager)P_0).GetString((string)P_1);
	}

	internal static void zkY3sbeGfwMYrjqU37X2()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
