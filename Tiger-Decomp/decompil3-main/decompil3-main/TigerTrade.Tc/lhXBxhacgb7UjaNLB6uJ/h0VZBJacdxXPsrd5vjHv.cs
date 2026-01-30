using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web;
using BfZtb759KlUg4482QKym;
using dgZJY3GhircmyNVV0iAS;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using RRGeI95GVMJEHGH0bnkl;
using x97CE55GhEYKgt7TSVZT;

namespace lhXBxhacgb7UjaNLB6uJ;

[wxMJrmGhaoZN9BPmFRb2]
internal static class h0VZBJacdxXPsrd5vjHv
{
	[Serializable]
	[CompilerGenerated]
	private sealed class CI2P9tioDV2AUIyNhEMG
	{
		public static readonly CI2P9tioDV2AUIyNhEMG NhWio5JdPMm;

		public static Func<KeyValuePair<string, object>, string> D72ioS1cQf8;

		public static Func<string, string> EDKioxvgkrN;

		public static Func<KeyValuePair<string, object>, string> ubqioLvYq4f;

		public static Func<string, string> P3gioe3DUrD;

		private static CI2P9tioDV2AUIyNhEMG uCMBm0L6XvyYPFuHUlhO;

		static CI2P9tioDV2AUIyNhEMG()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			NhWio5JdPMm = new CI2P9tioDV2AUIyNhEMG();
		}

		public CI2P9tioDV2AUIyNhEMG()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal string nCUiobDvodW(KeyValuePair<string, object> kv)
		{
			return HttpUtility.UrlEncode(kv.Key) + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DE05AD) + HttpUtility.UrlEncode(KDSacqSbbJ5(kv.Value));
		}

		internal string VMCioNrhTSX(string p)
		{
			return p;
		}

		internal string bUPiokS0TMw(KeyValuePair<string, object> kv)
		{
			return kv.Key + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x34407BB ^ 0x344A6E7) + KDSacqSbbJ5(kv.Value);
		}

		internal string c7Oio124RA7(string p)
		{
			return p;
		}

		internal static bool mlYuaPL6csu0LCwPfwRQ()
		{
			return uCMBm0L6XvyYPFuHUlhO == null;
		}

		internal static CI2P9tioDV2AUIyNhEMG oFqDeHL6jgeBPwbXNd8w()
		{
			return uCMBm0L6XvyYPFuHUlhO;
		}
	}

	private static h0VZBJacdxXPsrd5vjHv gEIVm9xw1oY7MopB7xV7;

	[wxMJrmGhaoZN9BPmFRb2]
	public static Dictionary<string, object> dsyacRJKVAw(object P_0)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		PropertyInfo[] properties = P_0.GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (!Attribute.IsDefined(propertyInfo, Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777796))))
			{
				object value = propertyInfo.GetValue(P_0);
				if (value != null)
				{
					object obj = propertyInfo.GetCustomAttributes(Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777797)), inherit: false).FirstOrDefault();
					object obj2 = ((obj is JsonPropertyAttribute) ? obj : null);
					string key = ((obj2 != null) ? ((JsonPropertyAttribute)obj2).PropertyName : null) ?? propertyInfo.Name;
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	[wxMJrmGhaoZN9BPmFRb2]
	public static string y4Yac6RJX5k(object P_0, bool P_1 = true)
	{
		return pYZacMw0lC3(dsyacRJKVAw(P_0), P_1);
	}

	[wxMJrmGhaoZN9BPmFRb2]
	public static string pYZacMw0lC3(Dictionary<string, object> P_0, bool P_1 = true)
	{
		IEnumerable<string> enumerable = P_0.Select((KeyValuePair<string, object> kv) => HttpUtility.UrlEncode(kv.Key) + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DE05AD) + HttpUtility.UrlEncode(KDSacqSbbJ5(kv.Value)));
		if (P_1)
		{
			enumerable = enumerable.OrderBy((string p) => p);
		}
		return string.Join(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-44540535 ^ -44498939), enumerable);
	}

	[wxMJrmGhaoZN9BPmFRb2]
	public static string NFgacOBatE0(Dictionary<string, object> P_0, bool P_1 = true)
	{
		IEnumerable<string> enumerable = P_0.Select((KeyValuePair<string, object> kv) => kv.Key + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x34407BB ^ 0x344A6E7) + KDSacqSbbJ5(kv.Value));
		if (P_1)
		{
			enumerable = enumerable.OrderBy((string p) => p);
		}
		return string.Join(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841543723), enumerable);
	}

	public static string KDSacqSbbJ5(object P_0)
	{
		bool flag = default(bool);
		int num;
		Enum obj = default(Enum);
		IFormattable formattable = default(IFormattable);
		if (P_0 is bool)
		{
			flag = (bool)P_0;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
			{
				num = 0;
			}
		}
		else
		{
			obj = P_0 as Enum;
			if (obj != null)
			{
				goto IL_004f;
			}
			formattable = P_0 as IFormattable;
			num = 2;
		}
		while (true)
		{
			object obj2;
			switch (num)
			{
			case 1:
				break;
			case 2:
				if (formattable != null)
				{
					return formattable.ToString(null, CultureInfo.InvariantCulture);
				}
				if (P_0 != null)
				{
					goto IL_00cf;
				}
				obj2 = null;
				goto IL_00f9;
			default:
				return flag.ToString().ToLowerInvariant();
			case 3:
				{
					obj2 = P_0.ToString();
					goto IL_00f9;
				}
				IL_00f9:
				if (obj2 == null)
				{
					obj2 = string.Empty;
				}
				return (string)obj2;
			}
			break;
			IL_00cf:
			num = 3;
		}
		goto IL_004f;
		IL_004f:
		return pAJacICVsPU(obj);
	}

	[wxMJrmGhaoZN9BPmFRb2]
	public static string pAJacICVsPU(Enum P_0)
	{
		MemberInfo memberInfo = P_0.GetType().GetMember(P_0.ToString()).FirstOrDefault();
		if (rWjkW7xwxiFa08k6XuHq(memberInfo, null))
		{
			return P_0.ToString();
		}
		object obj = ((IEnumerable)hkev6nxwePWAA8n9sipD(memberInfo, Type.GetTypeFromHandle(TVSVdQxwL6lyKMBpKdL2(16777799)), false)).Cast<EnumMemberAttribute>().FirstOrDefault()?.Value;
		if (obj == null)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			obj = P_0.ToString();
		}
		return (string)obj;
	}

	static h0VZBJacdxXPsrd5vjHv()
	{
		HoKBy9xwsUFIt1uLKLEm();
		scUV8rxwXEQBttB51f1V();
	}

	internal static bool FJwJ5Qxw5B4lFtyE8nlF()
	{
		return gEIVm9xw1oY7MopB7xV7 == null;
	}

	internal static h0VZBJacdxXPsrd5vjHv z5MP0PxwSE4siEVDPuOB()
	{
		return gEIVm9xw1oY7MopB7xV7;
	}

	internal static bool rWjkW7xwxiFa08k6XuHq(object P_0, object P_1)
	{
		return (MemberInfo)P_0 == (MemberInfo)P_1;
	}

	internal static RuntimeTypeHandle TVSVdQxwL6lyKMBpKdL2(int token)
	{
		return mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(token);
	}

	internal static object hkev6nxwePWAA8n9sipD(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static void HoKBy9xwsUFIt1uLKLEm()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void scUV8rxwXEQBttB51f1V()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
