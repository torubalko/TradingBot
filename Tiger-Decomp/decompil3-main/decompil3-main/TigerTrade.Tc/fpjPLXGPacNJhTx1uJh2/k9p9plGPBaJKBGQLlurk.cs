using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace fpjPLXGPacNJhTx1uJh2;

internal sealed class k9p9plGPBaJKBGQLlurk
{
	[Serializable]
	[CompilerGenerated]
	private sealed class HeUOJOaO3CKvbyhTUc1X
	{
		public static readonly HeUOJOaO3CKvbyhTUc1X joxaOuQISFx;

		public static Func<KeyValuePair<string, string>, string> ow3aOzaHOoE;

		internal static HeUOJOaO3CKvbyhTUc1X a6COwFxuxia2NOgy9jlg;

		static HeUOJOaO3CKvbyhTUc1X()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
					itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
					joxaOuQISFx = new HeUOJOaO3CKvbyhTUc1X();
					return;
				case 1:
					F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public HeUOJOaO3CKvbyhTUc1X()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal string kFyaOp9mOtU(KeyValuePair<string, string> code)
		{
			return code.Key;
		}

		internal static bool aFuNVUxuLqVA1d49XpLt()
		{
			return a6COwFxuxia2NOgy9jlg == null;
		}

		internal static HeUOJOaO3CKvbyhTUc1X RnN625xueDbp0gZpS5Xw()
		{
			return a6COwFxuxia2NOgy9jlg;
		}
	}

	private readonly Dictionary<string, Dictionary<string, string>> Ts8GPDFHSQS;

	internal static k9p9plGPBaJKBGQLlurk SAyqBY5hefYxRSIYWx1X;

	public void qnAGPiOC6Ps(Symbol P_0)
	{
		string mapping = P_0.Mapping;
		if (string.IsNullOrEmpty(mapping))
		{
			return;
		}
		int num = 7;
		string[] array2 = default(string[]);
		string key = default(string);
		string key2 = default(string);
		string[] array = default(string[]);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				if (array2.Length == 2)
				{
					key = array2[0];
					key2 = array2[1];
					if (!Ts8GPDFHSQS.ContainsKey(key))
					{
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
						{
							num = 2;
						}
						break;
					}
					goto case 3;
				}
				goto IL_011b;
			case 3:
				if (!Ts8GPDFHSQS[key].ContainsKey(key2))
				{
					Ts8GPDFHSQS[key].Add(key2, P_0.ID);
				}
				goto IL_011b;
			case 7:
				array = mapping.Split(';');
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
				{
					num = 1;
				}
				break;
			case 5:
				return;
			case 2:
				Ts8GPDFHSQS.Add(key, new Dictionary<string, string>());
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
				{
					num = 0;
				}
				break;
			default:
				if (num2 < array.Length)
				{
					string text = array[num2];
					if (!iglN8K5hcDPSdeN5bPem(text))
					{
						array2 = (string[])EIkBxC5hjL0Kaf43u2A9(text, new char[1] { ':' });
						num = 4;
						break;
					}
					goto IL_011b;
				}
				num = 5;
				break;
			case 1:
				{
					num2 = 0;
					num = 6;
					break;
				}
				IL_011b:
				num2++;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public string I1IGPlHmZK0(string P_0, string P_1, string P_2)
	{
		if (!Ts8GPDFHSQS.ContainsKey(P_0))
		{
			return null;
		}
		string key = P_1;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return Ts8GPDFHSQS[P_0][key];
			}
			if (!iglN8K5hcDPSdeN5bPem(P_2))
			{
				key = (string)gQJdWF5hQ5qAxMHQpc4d(P_1, spNduP5hEric4PwyPQ2l(-1848952786 ^ -1848910544), P_2);
			}
			if (Ts8GPDFHSQS[P_0].ContainsKey(key))
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
				{
					num = 0;
				}
				continue;
			}
			return null;
		}
	}

	public List<string> B80GP4hx40J(string P_0)
	{
		List<string> list = new List<string>();
		if (Ts8GPDFHSQS.ContainsKey(P_0))
		{
			list.AddRange(Ts8GPDFHSQS[P_0].Select((KeyValuePair<string, string> code) => code.Key));
		}
		return list;
	}

	public void Clear()
	{
		Ts8GPDFHSQS.Clear();
	}

	public k9p9plGPBaJKBGQLlurk()
	{
		NmgO1c5hdTs7yqgpdv2O();
		Ts8GPDFHSQS = new Dictionary<string, Dictionary<string, string>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static k9p9plGPBaJKBGQLlurk()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		fIBfoR5hg5KetIAU3nj5();
	}

	internal static bool iglN8K5hcDPSdeN5bPem(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object EIkBxC5hjL0Kaf43u2A9(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static bool pDUQlL5hsemE9eyjaFSa()
	{
		return SAyqBY5hefYxRSIYWx1X == null;
	}

	internal static k9p9plGPBaJKBGQLlurk v5Y0Vt5hX6wmOmidoDHp()
	{
		return SAyqBY5hefYxRSIYWx1X;
	}

	internal static object spNduP5hEric4PwyPQ2l(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object gQJdWF5hQ5qAxMHQpc4d(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void NmgO1c5hdTs7yqgpdv2O()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void fIBfoR5hg5KetIAU3nj5()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
