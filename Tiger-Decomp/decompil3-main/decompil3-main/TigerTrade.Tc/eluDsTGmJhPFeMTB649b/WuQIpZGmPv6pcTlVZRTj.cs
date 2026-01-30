using System;
using System.Collections.Generic;
using System.Text;
using BfZtb759KlUg4482QKym;
using JZ8sb1GrXwPFkVDPEGJ4;
using x97CE55GhEYKgt7TSVZT;

namespace eluDsTGmJhPFeMTB649b;

internal static class WuQIpZGmPv6pcTlVZRTj
{
	internal static WuQIpZGmPv6pcTlVZRTj VOhkCt5W4QbDMisc9VRm;

	public static bool M46GmFCwSNh(string P_0)
	{
		if (P_0 != null)
		{
			return P_0.Length == 0;
		}
		return true;
	}

	public static string w6WGm38aUUx(string P_0)
	{
		if (P_0 == null)
		{
			return "";
		}
		return P_0;
	}

	public static int KYxGmpVu8dP(string P_0, string P_1)
	{
		return w6WGm38aUUx(P_0).CompareTo(w6WGm38aUUx(P_1));
	}

	public static int BCFGmugYYTh(string P_0, string P_1)
	{
		string text = w6WGm38aUUx(P_0);
		string text2 = (string)EwNyUn5WNU26vwfIvQsm(P_1);
		return SLhTRv5WkWKk7fpFmoZG(text, text2, true);
	}

	public static bool cOdGmziJtOt<SSyYDgkWppY0j4gReti7>(List<SSyYDgkWppY0j4gReti7> P_0, List<SSyYDgkWppY0j4gReti7> P_1)
	{
		if (P_0 == P_1)
		{
			return true;
		}
		int num = P_0?.Count ?? 0;
		int num2 = P_1?.Count ?? 0;
		if (num != num2)
		{
			return false;
		}
		if (num == 0)
		{
			return true;
		}
		bool[] array = new bool[num2];
		for (int i = 0; i < num; i++)
		{
			object obj = P_0[i];
			int j;
			for (j = 0; j < num2; j++)
			{
				if (!array[j] && obj.Equals(P_1[j]))
				{
					array[j] = true;
					break;
				}
			}
			if (j >= num2)
			{
				return false;
			}
		}
		return true;
	}

	public static string K9FGh0iPXCZ(int P_0)
	{
		object obj;
		if (P_0 != int.MaxValue)
		{
			obj = P_0.ToString();
			if (obj == null)
			{
				return "";
			}
		}
		else
		{
			obj = "";
		}
		return (string)obj;
	}

	public static string DiHGh2vNvbH(long P_0)
	{
		object obj;
		if (P_0 != long.MaxValue)
		{
			obj = P_0.ToString();
			if (obj == null)
			{
				return "";
			}
		}
		else
		{
			obj = "";
		}
		return (string)obj;
	}

	public static string kGoGhHeb8u4(double P_0)
	{
		object obj;
		if (P_0 != double.MaxValue)
		{
			obj = P_0.ToString();
			if (obj == null)
			{
				return "";
			}
		}
		else
		{
			obj = "";
		}
		return (string)obj;
	}

	public static string LnPGhfuAsSr(long P_0, string P_1)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(R9C4nW5W1rNmkh13HyhE(P_0)).ToString(P_1);
	}

	public static string E6LGh9jUnhU(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			return string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5EA8FF2A ^ 0x5EA85E62), double.Parse(P_0));
		}
		return "";
	}

	public static string WE7Ghnl7bDB(List<YTRgdjGrspdQ4JAkykFO> P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = P_0?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			YTRgdjGrspdQ4JAkykFO yTRgdjGrspdQ4JAkykFO = P_0[i];
			stringBuilder.Append(yTRgdjGrspdQ4JAkykFO.Tag).Append(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1999650146 ^ -1999674430)).Append(yTRgdjGrspdQ4JAkykFO.Value)
				.Append(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-448941864 ^ -448982598));
		}
		return stringBuilder.ToString();
	}

	static WuQIpZGmPv6pcTlVZRTj()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool AceE0d5WDAYbgF2Zq0GT()
	{
		return VOhkCt5W4QbDMisc9VRm == null;
	}

	internal static WuQIpZGmPv6pcTlVZRTj sjmWp45Wb6hWQa5UWPX2()
	{
		return VOhkCt5W4QbDMisc9VRm;
	}

	internal static object EwNyUn5WNU26vwfIvQsm(object P_0)
	{
		return w6WGm38aUUx((string)P_0);
	}

	internal static int SLhTRv5WkWKk7fpFmoZG(object P_0, object P_1, bool P_2)
	{
		return string.Compare((string)P_0, (string)P_1, P_2);
	}

	internal static double R9C4nW5W1rNmkh13HyhE(long P_0)
	{
		return Convert.ToDouble(P_0);
	}
}
