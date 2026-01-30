using System.Collections.Generic;
using System.Runtime.CompilerServices;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using cvsMDenpthHB6chZmnm;
using ECOEgqlSad8NUJZ2Dr9n;
using isnQObHkoBLhLETXDS3X;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace lM9xconKIP2UunwAoZl;

internal sealed class SsSxcsnrdCDK7MkPasj : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private readonly LOaTZ5HkYs6IUi82qZ8y<gSC5j6n3i4ckEaQII3r> brLnPbAASP;

	private readonly Dictionary<string, gSC5j6n3i4ckEaQII3r> S3BnJwiV5N;

	private gSC5j6n3i4ckEaQII3r o12nFjDTh3;

	private static SsSxcsnrdCDK7MkPasj KiuoVulmzkswuWXnf6KZ;

	public LOaTZ5HkYs6IUi82qZ8y<gSC5j6n3i4ckEaQII3r> Trades
	{
		[CompilerGenerated]
		get
		{
			return brLnPbAASP;
		}
	}

	public gSC5j6n3i4ckEaQII3r SelectedExecution
	{
		get
		{
			return o12nFjDTh3;
		}
		set
		{
			if (!DNAKeolhnTYilLM5RW1Z(gSC5j6n3i4ckEaQII3r, o12nFjDTh3))
			{
				o12nFjDTh3 = gSC5j6n3i4ckEaQII3r;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x344195D));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	public SsSxcsnrdCDK7MkPasj()
	{
		ycpFbplhH9yeCqwGHDbJ();
		S3BnJwiV5N = new Dictionary<string, gSC5j6n3i4ckEaQII3r>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				DataManager.OnExecutions += qrfnmpYlt9;
				DataManager.OnUpdateFilters += delegate
				{
					foreach (gSC5j6n3i4ckEaQII3r item in Trades)
					{
						int num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						}
						YJcUMklhGpRfCZigROKC(item, Filter(item));
					}
				};
				return;
			default:
			{
				LOaTZ5HkYs6IUi82qZ8y<gSC5j6n3i4ckEaQII3r> lOaTZ5HkYs6IUi82qZ8y = new LOaTZ5HkYs6IUi82qZ8y<gSC5j6n3i4ckEaQII3r>();
				Pp6Fmclh9KwN3FTlwEV9(lOaTZ5HkYs6IUi82qZ8y, ((MhMDPU9v8rkigy1ao0Th)JxHUXRlhfSF36J1LF5hF()).OrdersTableCapacity);
				brLnPbAASP = lOaTZ5HkYs6IUi82qZ8y;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	private void qrfnmpYlt9(IEnumerable<Execution> P_0)
	{
		Trades.rf8HkBEyiZ3();
		foreach (Execution item in P_0)
		{
			SPfnhqAfJN(item);
		}
		Trades.qnkHka9KJbR();
	}

	private void SPfnhqAfJN(Execution P_0)
	{
		int num;
		if (S3BnJwiV5N.TryGetValue(P_0.ID, out var value))
		{
			value.gbDnusxTLK(P_0);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
			{
				num = 0;
			}
		}
		else
		{
			gSC5j6n3i4ckEaQII3r gSC5j6n3i4ckEaQII3r = new gSC5j6n3i4ckEaQII3r(P_0);
			YJcUMklhGpRfCZigROKC(gSC5j6n3i4ckEaQII3r, Filter(gSC5j6n3i4ckEaQII3r));
			S3BnJwiV5N.Add(P_0.ID, gSC5j6n3i4ckEaQII3r);
			LOaTZ5HkYs6IUi82qZ8y<gSC5j6n3i4ckEaQII3r> lOaTZ5HkYs6IUi82qZ8y = Trades;
			if (lOaTZ5HkYs6IUi82qZ8y == null)
			{
				int num2 = 2;
				num = num2;
			}
			else
			{
				lOaTZ5HkYs6IUi82qZ8y.Add(gSC5j6n3i4ckEaQII3r);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num = 1;
				}
			}
		}
		switch (num)
		{
		case 1:
			return;
		case 2:
			return;
		}
		value.IsVisible = Filter(value);
	}

	private bool Filter(object obj)
	{
		if (obj is gSC5j6n3i4ckEaQII3r gSC5j6n3i4ckEaQII3r)
		{
			return DataManager.FilterAccount((Account)sYj2mNlhoQy6ifDoCuYs(YtOrvvlhYf4MhdQ7PEuM(gSC5j6n3i4ckEaQII3r)));
		}
		return false;
	}

	[CompilerGenerated]
	private void G1bnwjrHZY()
	{
		foreach (gSC5j6n3i4ckEaQII3r item in Trades)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			YJcUMklhGpRfCZigROKC(item, Filter(item));
		}
	}

	static SsSxcsnrdCDK7MkPasj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void ycpFbplhH9yeCqwGHDbJ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object JxHUXRlhfSF36J1LF5hF()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static void Pp6Fmclh9KwN3FTlwEV9(object P_0, int P_1)
	{
		((LOaTZ5HkYs6IUi82qZ8y<gSC5j6n3i4ckEaQII3r>)P_0).Capacity = P_1;
	}

	internal static bool C8wwVWlh0YTa9aLujrJh()
	{
		return KiuoVulmzkswuWXnf6KZ == null;
	}

	internal static SsSxcsnrdCDK7MkPasj FrNkp1lh2hegqM2q5JhC()
	{
		return KiuoVulmzkswuWXnf6KZ;
	}

	internal static bool DNAKeolhnTYilLM5RW1Z(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void YJcUMklhGpRfCZigROKC(object P_0, bool P_1)
	{
		((gSC5j6n3i4ckEaQII3r)P_0).IsVisible = P_1;
	}

	internal static object YtOrvvlhYf4MhdQ7PEuM(object P_0)
	{
		return ((gSC5j6n3i4ckEaQII3r)P_0).Execution;
	}

	internal static object sYj2mNlhoQy6ifDoCuYs(object P_0)
	{
		return ((Execution)P_0).Account;
	}
}
