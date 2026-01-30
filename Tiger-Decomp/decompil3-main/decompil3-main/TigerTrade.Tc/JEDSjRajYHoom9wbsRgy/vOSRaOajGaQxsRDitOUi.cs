using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using x97CE55GhEYKgt7TSVZT;

namespace JEDSjRajYHoom9wbsRgy;

public class vOSRaOajGaQxsRDitOUi : JsonConverter<DateTimeOffset>
{
	private static vOSRaOajGaQxsRDitOUi nkspedxwU8EWl6OxR5in;

	public override void WriteJson(JsonWriter P_0, DateTimeOffset P_1, JsonSerializer P_2)
	{
		long num = P_1.ToUnixTimeMilliseconds() * 1000;
		xMdq51xwZaWb11527bmG(P_0, num);
	}

	public override DateTimeOffset ReadJson(JsonReader P_0, Type P_1, DateTimeOffset P_2, bool P_3, JsonSerializer P_4)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			long result;
			switch (num2)
			{
			case 2:
				if (!long.TryParse((string)tD4sVkxwCuNhUoHqJ3Xx(P_0), out result))
				{
					goto case 3;
				}
				goto IL_015c;
			default:
				if (!(P_1 == hrQj4uxwVuuwTxA8O1LP(typeof(DateTimeOffset?).TypeHandle)))
				{
					throw new JsonSerializationException(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1309555870 ^ -1309658828), P_1));
				}
				return default(DateTimeOffset);
			case 1:
				if ((int)P_0.TokenType != 11)
				{
					if ((int)P_0.TokenType == 9)
					{
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
						{
							num2 = 2;
						}
						break;
					}
					if ((int)Cdk6gcxwKMGY8HHoc6yX(P_0) != 7)
					{
						goto case 4;
					}
					result = (long)P_0.Value;
					goto IL_015c;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				throw new JsonSerializationException(string.Format((string)vNP0rVxwrmujrFsShxB3(-690510723 ^ -690596121), P_1));
			case 4:
				{
					throw new JsonSerializationException(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1583344314 ^ -1583224942), P_1, P_0.TokenType));
				}
				IL_015c:
				return DateTimeOffset.FromUnixTimeMilliseconds(result / 1000);
			}
		}
	}

	public vOSRaOajGaQxsRDitOUi()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static vOSRaOajGaQxsRDitOUi()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void xMdq51xwZaWb11527bmG(object P_0, long P_1)
	{
		((JsonWriter)P_0).WriteValue(P_1);
	}

	internal static bool C33THpxwT8xEuNDhaylA()
	{
		return nkspedxwU8EWl6OxR5in == null;
	}

	internal static vOSRaOajGaQxsRDitOUi Y2am3WxwyAWyH9VNyIaE()
	{
		return nkspedxwU8EWl6OxR5in;
	}

	internal static Type hrQj4uxwVuuwTxA8O1LP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object tD4sVkxwCuNhUoHqJ3Xx(object P_0)
	{
		return ((JsonReader)P_0).Value;
	}

	internal static object vNP0rVxwrmujrFsShxB3(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static JsonToken Cdk6gcxwKMGY8HHoc6yX(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonReader)P_0).TokenType;
	}
}
