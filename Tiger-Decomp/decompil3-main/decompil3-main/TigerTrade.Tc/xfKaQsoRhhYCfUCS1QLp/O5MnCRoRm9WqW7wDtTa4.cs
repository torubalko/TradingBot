using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace xfKaQsoRhhYCfUCS1QLp;

internal class O5MnCRoRm9WqW7wDtTa4
{
	[CompilerGenerated]
	private readonly string mjRoRFnLjHU;

	[CompilerGenerated]
	private readonly string b9WoR3lkkVs;

	internal static O5MnCRoRm9WqW7wDtTa4 uV14kpSAb5qYFaZLkLPK;

	public O5MnCRoRm9WqW7wDtTa4(string P_0, string P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		b9WoR3lkkVs = P_1;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		mjRoRFnLjHU = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string dsFoR8A3eJv()
	{
		return mjRoRFnLjHU;
	}

	[SpecialName]
	[CompilerGenerated]
	private string KN4oRPIJ3iZ()
	{
		return b9WoR3lkkVs;
	}

	public string VZ4oRwbKBsG(string P_0, string P_1, long P_2)
	{
		string s = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3E0426F0 ^ 0x3E05B670), P_0, P_1, P_2);
		HMACSHA512 hMACSHA = new HMACSHA512(Encoding.UTF8.GetBytes(KN4oRPIJ3iZ()));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				return BitConverter.ToString(hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(s))).Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2123795572 ^ -2123785906), "").ToLowerInvariant();
			}
			finally
			{
				((IDisposable)hMACSHA)?.Dispose();
			}
		}
	}

	public string CtRoR7DDvD0(string P_0, string P_1, string P_2, string P_3, string P_4)
	{
		using SHA512 sHA = SHA512.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(P_1);
		string text = BitConverter.ToString((byte[])LbuSTASA1Id7694FcqD6(sHA, bytes)).Replace((string)GAGN3wSA5K6BouMNa2Y6(0x7F55E538 ^ 0x7F550FFA), "").ToLowerInvariant();
		string text2 = P_0 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-338769610 ^ -338812206) + P_2 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2D3134C9 ^ 0x2D31DF2D) + P_3 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1736566656 ^ -1736510620) + text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5EA8FF2A ^ 0x5EA814CE) + P_4;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			HMACSHA512 hMACSHA = new HMACSHA512((byte[])amcqycSAS47IaEA1OFUu(Encoding.UTF8, KN4oRPIJ3iZ()));
			try
			{
				return ((string)JecG3wSAxyEQOYs79WPx(hMACSHA.ComputeHash((byte[])amcqycSAS47IaEA1OFUu(Encoding.UTF8, text2)))).Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1306877528 ^ -1306899606), "").ToLowerInvariant();
			}
			finally
			{
				if (hMACSHA != null)
				{
					z2bsLbSAL7a6JovUFTZk(hMACSHA);
				}
			}
		}
		}
	}

	static O5MnCRoRm9WqW7wDtTa4()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool OoMr8cSANyR7OS8BH9xy()
	{
		return uV14kpSAb5qYFaZLkLPK == null;
	}

	internal static O5MnCRoRm9WqW7wDtTa4 aZuvpKSAkJxlv6KG7IPc()
	{
		return uV14kpSAb5qYFaZLkLPK;
	}

	internal static object LbuSTASA1Id7694FcqD6(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object GAGN3wSA5K6BouMNa2Y6(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object amcqycSAS47IaEA1OFUu(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object JecG3wSAxyEQOYs79WPx(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static void z2bsLbSAL7a6JovUFTZk(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
