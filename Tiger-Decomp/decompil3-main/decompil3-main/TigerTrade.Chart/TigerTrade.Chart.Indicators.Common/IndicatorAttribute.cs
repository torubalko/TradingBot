using System;
using System.Resources;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Properties;

namespace TigerTrade.Chart.Indicators.Common;

[AttributeUsage(AttributeTargets.Class)]
public class IndicatorAttribute : Attribute
{
	internal static IndicatorAttribute Lgjf6JeMYMQpnO5p7Dnn;

	public string ID { get; }

	public string Name { get; }

	public bool Overlay { get; }

	public string Category { get; set; }

	public Type Type { get; set; }

	public IndicatorAttribute(string id, string name, bool overlay)
	{
		ADftg2eMBWEsN6KZoKtg();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ID = id;
				Name = LookupResource(name);
				Overlay = overlay;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static string LookupResource(string resourceKey)
	{
		return (string)(dmYVwXeMiNOVZrJoZlvN(mP3WIbeMaFBtL9d346ni(), resourceKey) ?? resourceKey);
	}

	static IndicatorAttribute()
	{
		xIW9yeeMlLkCpE7Lt9hx();
		HqUKuceM4raMocAK405k();
	}

	internal static bool PHHOpDeMoNVnLxOF3kva()
	{
		return Lgjf6JeMYMQpnO5p7Dnn == null;
	}

	internal static IndicatorAttribute zRlVSpeMvB8mCl3fW8gw()
	{
		return Lgjf6JeMYMQpnO5p7Dnn;
	}

	internal static void ADftg2eMBWEsN6KZoKtg()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static object mP3WIbeMaFBtL9d346ni()
	{
		return Resources.ResourceManager;
	}

	internal static object dmYVwXeMiNOVZrJoZlvN(object P_0, object P_1)
	{
		return ((ResourceManager)P_0).GetString((string)P_1);
	}

	internal static void xIW9yeeMlLkCpE7Lt9hx()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void HqUKuceM4raMocAK405k()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
