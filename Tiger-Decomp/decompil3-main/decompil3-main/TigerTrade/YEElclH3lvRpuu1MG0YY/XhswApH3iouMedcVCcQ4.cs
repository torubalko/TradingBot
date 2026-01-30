using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using lj4T8ZHF7x3Bq5iQiaUo;
using m5kKroH39ZiR9W2RfHIU;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using tsQHvsH35TbwGvTJYivH;
using TuAMtrl1Nd3XoZQQUXf0;

namespace YEElclH3lvRpuu1MG0YY;

internal static class XhswApH3iouMedcVCcQ4
{
	[CompilerGenerated]
	private static WjB0DfH31o2TXoQckhVQ Tv9H3kjf3MM;

	private static XhswApH3iouMedcVCcQ4 DgxgPeDZ6JZmi1vddARk;

	public static WjB0DfH31o2TXoQckhVQ Settings
	{
		[CompilerGenerated]
		get
		{
			return Tv9H3kjf3MM;
		}
		[CompilerGenerated]
		set
		{
			Tv9H3kjf3MM = tv9H3kjf3MM;
		}
	}

	static XhswApH3iouMedcVCcQ4()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				FV5V17DZIOectYlHWIue();
				Settings = ConfigSerializer.LoadFromFile<WjB0DfH31o2TXoQckhVQ>((string)t6jmU7DZW4XHmuHFnCZM()) ?? new WjB0DfH31o2TXoQckhVQ();
				return;
			case 1:
				ggo8JpDZq9pC4H2vZRkG();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void vAZH34trGu5()
	{
		ConfigSerializer.SaveToFile(Settings, j18iDj9nukSCmEyZs5lH.huf9oDPRMFW());
	}

	public static void H3VH3DTMgWf()
	{
		List<TrustAccount> list = new List<TrustAccount>();
		List<bPlY5UHFwpoioxZbeXFB>.Enumerator enumerator = ((WjB0DfH31o2TXoQckhVQ)TtAwn4DZtHB7RjV2UV6W()).lGTH3LYjunm.GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			List<Gq6c51H3fl7aCYAJ5FOV>.Enumerator enumerator2 = default(List<Gq6c51H3fl7aCYAJ5FOV>.Enumerator);
			Gq6c51H3fl7aCYAJ5FOV current2 = default(Gq6c51H3fl7aCYAJ5FOV);
			while (enumerator.MoveNext())
			{
				TrustAccount trustAccount;
				while (true)
				{
					bPlY5UHFwpoioxZbeXFB current = enumerator.Current;
					trustAccount = new TrustAccount(current.L4uHFJO69K1)
					{
						Name = current.Name
					};
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						case 2:
							enumerator2 = current.Portfolios.GetEnumerator();
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
							{
								num2 = 1;
							}
							continue;
						case 1:
							try
							{
								while (true)
								{
									int num3;
									if (!enumerator2.MoveNext())
									{
										num3 = 1;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
										{
											num3 = 2;
										}
										goto IL_0116;
									}
									goto IL_0187;
									IL_0116:
									switch (num3)
									{
									case 1:
										break;
									default:
										goto IL_01b4;
									case 2:
										goto end_IL_0157;
									}
									goto IL_0187;
									IL_01b4:
									if (!trustAccount.Accounts.ContainsKey(current2.Account))
									{
										trustAccount.Accounts.Add((string)Sw9WKgDZUg66tuJTvOyM(current2), current2.Weight);
									}
									continue;
									IL_0187:
									current2 = enumerator2.Current;
									if (string.IsNullOrWhiteSpace((string)Sw9WKgDZUg66tuJTvOyM(current2)))
									{
										continue;
									}
									num3 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
									{
										num3 = 0;
									}
									goto IL_0116;
									continue;
									end_IL_0157:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
							}
							goto end_IL_01fc;
						}
						break;
					}
					continue;
					end_IL_01fc:
					break;
				}
				list.Add(trustAccount);
			}
		}
		finally
		{
			((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
		}
		DataManager.LoadTrustAccounts(list);
	}

	internal static void ggo8JpDZq9pC4H2vZRkG()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void FV5V17DZIOectYlHWIue()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object t6jmU7DZW4XHmuHFnCZM()
	{
		return j18iDj9nukSCmEyZs5lH.huf9oDPRMFW();
	}

	internal static bool mDb3tDDZMGxOvCVuSARS()
	{
		return DgxgPeDZ6JZmi1vddARk == null;
	}

	internal static XhswApH3iouMedcVCcQ4 aTtivXDZOrBhYdqIE5eE()
	{
		return DgxgPeDZ6JZmi1vddARk;
	}

	internal static object TtAwn4DZtHB7RjV2UV6W()
	{
		return Settings;
	}

	internal static object Sw9WKgDZUg66tuJTvOyM(object P_0)
	{
		return ((Gq6c51H3fl7aCYAJ5FOV)P_0).Account;
	}
}
