using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using BfZtb759KlUg4482QKym;
using EO2fsbGanGp7v7OqhupP;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace wD2D07vwPIrV2JDl7658;

internal abstract class zFlAHNvwA9yqWBn2mYyo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class hUCxsmaJcy4hFcel7t5K
	{
		public static readonly hUCxsmaJcy4hFcel7t5K uF7aJQwZy1n;

		public static Func<PropertyInfo, bool> vMbaJdpg9xW;

		public static Func<PropertyInfo, tQyhkEGa92I8hQ11oW75<DisplayNameAttribute, PropertyInfo>> eldaJgw94rI;

		private static hUCxsmaJcy4hFcel7t5K AIv6CTL50p2RdS87NULQ;

		static hUCxsmaJcy4hFcel7t5K()
		{
			Y7jD0ML5fu90UnM5DEyQ();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			uF7aJQwZy1n = new hUCxsmaJcy4hFcel7t5K();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public hUCxsmaJcy4hFcel7t5K()
		{
			bwfGIyL59IJfI1U0gdpQ();
			base._002Ector();
		}

		internal bool Jt4aJjjOtoO(PropertyInfo a)
		{
			return a.GetCustomAttributes<DisplayNameAttribute>().Any();
		}

		internal tQyhkEGa92I8hQ11oW75<DisplayNameAttribute, PropertyInfo> tyqaJE6PDlZ(PropertyInfo a)
		{
			return new tQyhkEGa92I8hQ11oW75<DisplayNameAttribute, PropertyInfo>(a.GetCustomAttributes<DisplayNameAttribute>().First(), a);
		}

		internal static void Y7jD0ML5fu90UnM5DEyQ()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static bool hMsyncL52u3bUyRTVgcy()
		{
			return AIv6CTL50p2RdS87NULQ == null;
		}

		internal static hUCxsmaJcy4hFcel7t5K dIOjV8L5Hu7AET9Q0gOJ()
		{
			return AIv6CTL50p2RdS87NULQ;
		}

		internal static void bwfGIyL59IJfI1U0gdpQ()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}
	}

	internal static zFlAHNvwA9yqWBn2mYyo nMKMe9xbBum7WtCJQdqL;

	public virtual string MlPl9kI3Tww()
	{
		IEnumerable<string> values = from a in UMZ4qCxblC2u7JE07V0m(this).GetProperties()
			where a.GetCustomAttributes<DisplayNameAttribute>().Any()
			select new tQyhkEGa92I8hQ11oW75<DisplayNameAttribute, PropertyInfo>(a.GetCustomAttributes<DisplayNameAttribute>().First(), a) into P_0
			select P_0.DisplayNameAttr.DisplayName + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1127423276 ^ -1127464056) + HttpUtility.HtmlEncode(P_0.Prop.GetValue(this));
		return string.Join(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769D24BD), values) ?? "";
	}

	protected zFlAHNvwA9yqWBn2mYyo()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	[CompilerGenerated]
	private string sCPvwJHCA9A(tQyhkEGa92I8hQ11oW75<DisplayNameAttribute, PropertyInfo> P_0)
	{
		return P_0.DisplayNameAttr.DisplayName + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1127423276 ^ -1127464056) + HttpUtility.HtmlEncode(P_0.Prop.GetValue(this));
	}

	static zFlAHNvwA9yqWBn2mYyo()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		VXKvIrxb4RZIHiJnJeop();
	}

	internal static Type UMZ4qCxblC2u7JE07V0m(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool WmGdTZxbafOxiBeTvBOp()
	{
		return nMKMe9xbBum7WtCJQdqL == null;
	}

	internal static zFlAHNvwA9yqWBn2mYyo iYJ6xtxbirJBWKSb3Vie()
	{
		return nMKMe9xbBum7WtCJQdqL;
	}

	internal static void VXKvIrxb4RZIHiJnJeop()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
