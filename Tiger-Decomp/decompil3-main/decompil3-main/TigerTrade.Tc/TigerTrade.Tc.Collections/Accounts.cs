using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Collections;

internal sealed class Accounts
{
	[CompilerGenerated]
	private sealed class bXnJiFiogLvJ9QqAOc0t
	{
		public string ngUio6d1t0b;

		internal static bXnJiFiogLvJ9QqAOc0t fvapBtL6MXAfOoBIHrlA;

		public bXnJiFiogLvJ9QqAOc0t()
		{
			jc6JCnL6IQcgWCXgQdpm();
			base._002Ector();
		}

		internal bool Ni7ioR6sHlY(Account a)
		{
			return a.Name == ngUio6d1t0b;
		}

		static bXnJiFiogLvJ9QqAOc0t()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void jc6JCnL6IQcgWCXgQdpm()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool R4yDXDL6O1vDXXX3kt7j()
		{
			return fvapBtL6MXAfOoBIHrlA == null;
		}

		internal static bXnJiFiogLvJ9QqAOc0t gTbAkLL6qnR3PkFkEiat()
		{
			return fvapBtL6MXAfOoBIHrlA;
		}
	}

	private readonly Dictionary<string, Account> vlDaEEsQAU2;

	private readonly object suGaEQxTiU6;

	internal static Accounts VPejCkx8YlJKIoFNiF38;

	internal void uFqaExS6jk0(Account P_0)
	{
		object obj = suGaEQxTiU6;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			if (vlDaEEsQAU2.ContainsKey((string)km9PhBx8BaXjJ1vqTvY8(P_0)))
			{
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				vlDaEEsQAU2.Add((string)km9PhBx8BaXjJ1vqTvY8(P_0), P_0);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	public Account N07aELTPF6E(string P_0)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		Account result = default(Account);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = suGaEQxTiU6;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num3 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						result = null;
						break;
					case 1:
					{
						string uniqueID = Account.GetUniqueID(P_0);
						if (!string.IsNullOrEmpty(uniqueID) && vlDaEEsQAU2.ContainsKey(uniqueID))
						{
							result = vlDaEEsQAU2[uniqueID];
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 2;
					}
					case 0:
						break;
					}
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					NbrXDPx8arhaUIcqiGo5(obj);
				}
			}
			return result;
		}
	}

	internal Account eTHaEeINcUH(string P_0)
	{
		object obj = suGaEQxTiU6;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
		{
			Account result = default(Account);
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					default:
						if (h5r6VUx8iJO3lCHLQ1JS(P_0) || !vlDaEEsQAU2.ContainsKey(P_0))
						{
							goto case 1;
						}
						result = vlDaEEsQAU2[P_0];
						num2 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						break;
					case 1:
						result = null;
						break;
					}
					break;
				}
			}
			finally
			{
				if (lockTaken)
				{
					NbrXDPx8arhaUIcqiGo5(obj);
				}
			}
			return result;
		}
		}
	}

	public List<Account> H4saEsREVA4()
	{
		lock (suGaEQxTiU6)
		{
			return vlDaEEsQAU2.Values.ToList();
		}
	}

	public List<Account> GxOaEXtrQVr(string P_0)
	{
		bXnJiFiogLvJ9QqAOc0t CS_0024_003C_003E8__locals2 = new bXnJiFiogLvJ9QqAOc0t();
		CS_0024_003C_003E8__locals2.ngUio6d1t0b = P_0;
		lock (suGaEQxTiU6)
		{
			return vlDaEEsQAU2.Values.Where((Account a) => a.Name == CS_0024_003C_003E8__locals2.ngUio6d1t0b).ToList();
		}
	}

	internal void Clear()
	{
		object obj = suGaEQxTiU6;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			vlDaEEsQAU2.Clear();
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[SpecialName]
	public int GSbaEc6K61U()
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = suGaEQxTiU6;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				return vlDaEEsQAU2.Count;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
	}

	public Accounts()
	{
		f7W1SUx8l5itmDibymc4();
		vlDaEEsQAU2 = new Dictionary<string, Account>();
		suGaEQxTiU6 = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Accounts()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object km9PhBx8BaXjJ1vqTvY8(object P_0)
	{
		return ((Account)P_0).UniqueID;
	}

	internal static bool daY020x8op9p3EU9O5W1()
	{
		return VPejCkx8YlJKIoFNiF38 == null;
	}

	internal static Accounts HRIlPqx8vSUtioTY02pn()
	{
		return VPejCkx8YlJKIoFNiF38;
	}

	internal static void NbrXDPx8arhaUIcqiGo5(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool h5r6VUx8iJO3lCHLQ1JS(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void f7W1SUx8l5itmDibymc4()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}
}
