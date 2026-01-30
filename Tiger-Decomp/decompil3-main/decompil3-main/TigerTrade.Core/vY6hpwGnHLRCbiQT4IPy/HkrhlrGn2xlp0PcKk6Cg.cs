using System;
using System.Reflection;
using System.Resources;
using EDugZvNwF6e5LYsQZ3C5;
using gyWf8lN8Aps6C4Xje11n;
using nff6NvN8pYC4xeKDOd05;
using TigerTrade.Core.Properties;

namespace vY6hpwGnHLRCbiQT4IPy;

internal static class HkrhlrGn2xlp0PcKk6Cg
{
	private static HkrhlrGn2xlp0PcKk6Cg cgNCXFknVEQIF7pZMob8;

	internal static string kA2Gnfin7Cx(string P_0)
	{
		return ((ResourceManager)cbpV5HknKNNiWIhc1C50()).GetString(P_0) ?? P_0;
	}

	internal static string QkmGn9rUu7N(Type P_0, string P_1)
	{
		PropertyInfo[] properties = P_0.GetProperties(BindingFlags.Static | BindingFlags.Public);
		int num = 0;
		int num2 = 1;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d4c05ecce72042a689087de91a91d628 != 0)
		{
			num2 = 1;
		}
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 2:
				if (num >= properties.Length)
				{
					return P_1;
				}
				propertyInfo = properties[num];
				if (!(propertyInfo.PropertyType == Type.GetTypeFromHandle(w8VJICknmcBTYaoYsgoQ(16777387))))
				{
					num++;
					num2 = 2;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d3878af610b846108a5237604e24fce3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)xhsQ1HknwhsHQ5BwEQQj((ResourceManager)KsxSvtknhCcOMNfNemRV(propertyInfo, null, null), P_1);
			}
		}
	}

	static HkrhlrGn2xlp0PcKk6Cg()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object cbpV5HknKNNiWIhc1C50()
	{
		return Resources.ResourceManager;
	}

	internal static bool deMZ9IknCDL37ZMWDKfg()
	{
		return cgNCXFknVEQIF7pZMob8 == null;
	}

	internal static HkrhlrGn2xlp0PcKk6Cg EI0yuOknrFJxn7fSArFk()
	{
		return cgNCXFknVEQIF7pZMob8;
	}

	internal static RuntimeTypeHandle w8VJICknmcBTYaoYsgoQ(int token)
	{
		return V666v0N8875hxUavxV17.cHJk4pLGZX2(token);
	}

	internal static object KsxSvtknhCcOMNfNemRV(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object xhsQ1HknwhsHQ5BwEQQj(object P_0, object P_1)
	{
		return ((ResourceManager)P_0).GetString((string)P_1);
	}
}
