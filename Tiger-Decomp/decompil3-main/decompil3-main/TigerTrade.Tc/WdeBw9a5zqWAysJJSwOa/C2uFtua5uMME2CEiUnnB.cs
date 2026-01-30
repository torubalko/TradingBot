using System;
using System.Globalization;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using x97CE55GhEYKgt7TSVZT;

namespace WdeBw9a5zqWAysJJSwOa;

public class C2uFtua5uMME2CEiUnnB : JsonConverter<decimal?>
{
	internal static C2uFtua5uMME2CEiUnnB LU3xHBxrwtTXXKBAQlEu;

	public override void WriteJson(JsonWriter P_0, decimal? P_1, JsonSerializer P_2)
	{
		if (P_1.HasValue)
		{
			P_0.WriteValue(P_1.Value.ToString(CultureInfo.InvariantCulture));
		}
		else
		{
			P_0.WriteNull();
		}
	}

	public override decimal? ReadJson(JsonReader P_0, Type P_1, decimal? P_2, bool P_3, JsonSerializer P_4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		if ((int)P_0.TokenType == 9)
		{
			if (decimal.TryParse(P_0.Value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
			{
				return result;
			}
		}
		else if ((int)P_0.TokenType == 8 || (int)P_0.TokenType == 7)
		{
			return Convert.ToDecimal(P_0.Value);
		}
		return null;
	}

	public C2uFtua5uMME2CEiUnnB()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static C2uFtua5uMME2CEiUnnB()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		kWBwp9xrA6y4sl7RoROr();
	}

	internal static bool utBWRaxr7JNHPOjCEUXg()
	{
		return LU3xHBxrwtTXXKBAQlEu == null;
	}

	internal static C2uFtua5uMME2CEiUnnB wk0tjCxr8bPgqwqkm2Nw()
	{
		return LU3xHBxrwtTXXKBAQlEu;
	}

	internal static void kWBwp9xrA6y4sl7RoROr()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
