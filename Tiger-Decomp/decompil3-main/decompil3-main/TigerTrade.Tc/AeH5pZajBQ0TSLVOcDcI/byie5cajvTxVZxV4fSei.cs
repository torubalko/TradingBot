using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using x97CE55GhEYKgt7TSVZT;

namespace AeH5pZajBQ0TSLVOcDcI;

internal class byie5cajvTxVZxV4fSei : JsonConverter<DateTimeOffset>
{
	internal static byie5cajvTxVZxV4fSei DnnqU0xwmujPesY7S4kw;

	public override DateTimeOffset ReadJson(JsonReader P_0, Type P_1, DateTimeOffset P_2, bool P_3, JsonSerializer P_4)
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		int num;
		if ((int)P_0.TokenType == 11)
		{
			if (wjTCjIxw7VaIHSaXGhgQ(P_1, typeof(DateTimeOffset?)))
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			throw new JsonSerializationException(string.Format((string)ODTBOIxw8e1blhsp6VyV(-3429745 ^ -3516199), P_1));
		}
		long result;
		if ((int)P_0.TokenType != 9)
		{
			if ((int)P_0.TokenType != 7)
			{
				throw new JsonSerializationException(string.Format((string)ODTBOIxw8e1blhsp6VyV(0x2BD86B18 ^ 0x2BD999CC), P_1, qTrY7XxwA1oo19crpvd8(P_0)));
			}
			result = (long)P_0.Value;
		}
		else if (!long.TryParse((string)P_0.Value, out result))
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		return jZYY5DxwPLaV2XuknVeW(result);
		IL_0009:
		DateTimeOffset result2 = default(DateTimeOffset);
		while (true)
		{
			switch (num)
			{
			default:
				throw new JsonSerializationException(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1435596783 ^ -1435534709), P_1));
			case 1:
				result2 = default(DateTimeOffset);
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return result2;
			}
		}
	}

	public override void WriteJson(JsonWriter P_0, DateTimeOffset P_1, JsonSerializer P_2)
	{
		P_0.WriteValue(P_1.ToUnixTimeMilliseconds());
	}

	public byie5cajvTxVZxV4fSei()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static byie5cajvTxVZxV4fSei()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool wjTCjIxw7VaIHSaXGhgQ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object ODTBOIxw8e1blhsp6VyV(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static JsonToken qTrY7XxwA1oo19crpvd8(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonReader)P_0).TokenType;
	}

	internal static DateTimeOffset jZYY5DxwPLaV2XuknVeW(long P_0)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(P_0);
	}

	internal static bool fyPfJRxwh33c58H0orHn()
	{
		return DnnqU0xwmujPesY7S4kw == null;
	}

	internal static byie5cajvTxVZxV4fSei n1CBiYxwwoNTCqDgxMl0()
	{
		return DnnqU0xwmujPesY7S4kw;
	}
}
