using System.Buffers;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using x97CE55GhEYKgt7TSVZT;

namespace zbMA7QBqkJBExWAD6XIl;

public class jeWNwxBqN03Aawp6AlJd : IArrayPool<char>
{
	public static readonly jeWNwxBqN03Aawp6AlJd RTpBq1Oibjv;

	internal static jeWNwxBqN03Aawp6AlJd DJNLPOxMVcX1K3eWDJIo;

	public char[] Rent(int P_0)
	{
		return ArrayPool<char>.Shared.Rent(P_0);
	}

	public void Return(char[] P_0)
	{
		xmY5JTxMKjrpoxB2InDE(ArrayPool<char>.Shared, P_0, false);
	}

	public jeWNwxBqN03Aawp6AlJd()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static jeWNwxBqN03Aawp6AlJd()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
				sZrbvQxMmYWCdmlmXaXe();
				RTpBq1Oibjv = new jeWNwxBqN03Aawp6AlJd();
				return;
			}
		}
	}

	internal static bool JD1IZdxMCd04onGbE6C4()
	{
		return DJNLPOxMVcX1K3eWDJIo == null;
	}

	internal static jeWNwxBqN03Aawp6AlJd LBdTIVxMrTVPVy9HUqf2()
	{
		return DJNLPOxMVcX1K3eWDJIo;
	}

	internal static void xmY5JTxMKjrpoxB2InDE(object P_0, object P_1, bool P_2)
	{
		((ArrayPool<char>)P_0).Return((char[])P_1, P_2);
	}

	internal static void sZrbvQxMmYWCdmlmXaXe()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}
}
