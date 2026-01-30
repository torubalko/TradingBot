using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CA00IGfn6UyfKXYOM3Is;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace tmiOgtfnafYpG9fBJt1k;

public static class Flyt5efnBIh25uHU3kuk
{
	[CompilerGenerated]
	private sealed class rJTokHn7iScIZOrrg5M1
	{
		public ConnectionInfo DYEn7DSX5dC;

		public List<string> P3Un7bUj9kS;

		internal static rJTokHn7iScIZOrrg5M1 cdnmxZNgkmPEpJVigu6m;

		public rJTokHn7iScIZOrrg5M1()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool v4sn7lEAUTj(Account acc)
		{
			return acc.ConnectionID == DYEn7DSX5dC.ConnectionID;
		}

		internal bool T1Qn74FpoFB(UserDeal d)
		{
			if (P3Un7bUj9kS.Contains((string)HYxc9ENgSCnuNChY93vQ(d)))
			{
				return !d.IsMt5TimeValid;
			}
			return false;
		}

		static rJTokHn7iScIZOrrg5M1()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool T6H4UUNg1bw3Vu3VrZ9H()
		{
			return cdnmxZNgkmPEpJVigu6m == null;
		}

		internal static rJTokHn7iScIZOrrg5M1 A7tXcbNg5mFU21WlXmbg()
		{
			return cdnmxZNgkmPEpJVigu6m;
		}

		internal static object HYxc9ENgSCnuNChY93vQ(object P_0)
		{
			return ((UserDeal)P_0).AccountID;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class C9rIV2n7NV5UcJl2KpKY
	{
		public static readonly C9rIV2n7NV5UcJl2KpKY afDn75URI80;

		public static Func<Account, string> yMon7SeeIIQ;

		public static Func<UserDeal, string> fimn7xOvING;

		private static C9rIV2n7NV5UcJl2KpKY YMQRouNgxreMs1YaTWP1;

		static C9rIV2n7NV5UcJl2KpKY()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			afDn75URI80 = new C9rIV2n7NV5UcJl2KpKY();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public C9rIV2n7NV5UcJl2KpKY()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal string qkbn7kyeUX9(Account s)
		{
			return (string)kl7IwDNgsGotqqSn66nq(s);
		}

		internal string aeGn71rfvnf(UserDeal d)
		{
			return d.DealID;
		}

		internal static bool xuVQ6iNgLJOrj78rWBRS()
		{
			return YMQRouNgxreMs1YaTWP1 == null;
		}

		internal static C9rIV2n7NV5UcJl2KpKY GUBDt6NgeE5JjY4b8w7a()
		{
			return YMQRouNgxreMs1YaTWP1;
		}

		internal static object kl7IwDNgsGotqqSn66nq(object P_0)
		{
			return ((Account)P_0).AccountID;
		}
	}

	internal static Flyt5efnBIh25uHU3kuk bvlljGDCDufon9dlr1FQ;

	public static void AGnfniBDbg2(ConnectionInfo P_0)
	{
		rJTokHn7iScIZOrrg5M1 CS_0024_003C_003E8__locals6 = new rJTokHn7iScIZOrrg5M1();
		CS_0024_003C_003E8__locals6.DYEn7DSX5dC = P_0;
		if (KH9ibADC1p0h2abFLq0e(CS_0024_003C_003E8__locals6.DYEn7DSX5dC.TradeClientID, n7SxUWDCkO4NaWJtDOkw(0x7F645F3C ^ 0x7F605D08)) || !CS_0024_003C_003E8__locals6.DYEn7DSX5dC.IsConnected)
		{
			return;
		}
		CS_0024_003C_003E8__locals6.P3Un7bUj9kS = (from s in DataManager.GetAccounts()
			where s.ConnectionID == CS_0024_003C_003E8__locals6.DYEn7DSX5dC.ConnectionID
			select (string)C9rIV2n7NV5UcJl2KpKY.kl7IwDNgsGotqqSn66nq(s)).ToList();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				h8uiRtfnRZ9JJpkepmSl.Delete((from d in h8uiRtfnRZ9JJpkepmSl.QY1fnI1yKes()
					where CS_0024_003C_003E8__locals6.P3Un7bUj9kS.Contains((string)rJTokHn7iScIZOrrg5M1.HYxc9ENgSCnuNChY93vQ(d)) && !d.IsMt5TimeValid
					select d.DealID).ToList());
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static Flyt5efnBIh25uHU3kuk()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object n7SxUWDCkO4NaWJtDOkw(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool KH9ibADC1p0h2abFLq0e(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static bool xNcfuJDCbwmajufR3A37()
	{
		return bvlljGDCDufon9dlr1FQ == null;
	}

	internal static Flyt5efnBIh25uHU3kuk jmmgOaDCN973YreJPOBc()
	{
		return bvlljGDCDufon9dlr1FQ;
	}
}
