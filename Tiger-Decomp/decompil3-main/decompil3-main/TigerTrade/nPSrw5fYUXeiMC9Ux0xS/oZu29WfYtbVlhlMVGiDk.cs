using System;
using System.Runtime.CompilerServices;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using JbtcCQfvnTuno7NXkd9W;
using tgMNbbfYJncTUJlMM3t7;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;

namespace nPSrw5fYUXeiMC9Ux0xS;

internal sealed class oZu29WfYtbVlhlMVGiDk
{
	[CompilerGenerated]
	private static readonly UwYeOefYP8lJpje6lqk7 TInfYAHyfjC;

	private static oZu29WfYtbVlhlMVGiDk sXdLdIDrXp3E4lAcPSkM;

	public static UwYeOefYP8lJpje6lqk7 SoundAlerts
	{
		[CompilerGenerated]
		get
		{
			return TInfYAHyfjC;
		}
	}

	static oZu29WfYtbVlhlMVGiDk()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
		{
			num = 0;
		}
		UwYeOefYP8lJpje6lqk7 uwYeOefYP8lJpje6lqk;
		while (true)
		{
			switch (num)
			{
			default:
				UwYeOefYP8lJpje6lqk7.wDkfYplXa43(j18iDj9nukSCmEyZs5lH.cte9YDt0Xx9());
				uwYeOefYP8lJpje6lqk = ConfigSerializer.LoadFromFile<UwYeOefYP8lJpje6lqk7>((string)kwy0e3DrE0bynuYWqMpV());
				if (uwYeOefYP8lJpje6lqk == null)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			case 1:
				uwYeOefYP8lJpje6lqk = new UwYeOefYP8lJpje6lqk7();
				break;
			}
			break;
		}
		TInfYAHyfjC = uwYeOefYP8lJpje6lqk;
	}

	public static void pF5fYTVx55q()
	{
		ConfigSerializer.SaveToFile((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND(), (string)kwy0e3DrE0bynuYWqMpV());
	}

	public static void RiseScreenerAlert()
	{
		try
		{
			if (OSNWBIDrdGQjkM2HohI2(SoundAlerts))
			{
				PPM8INfv9VK01EnoXpRO.oSVfvocGSUI(((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).ScreenerAlert, SoundAlerts.V6IfoUT1bpc);
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BB4994), e);
		}
	}

	public static void AMPfYypUWml()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (SoundAlerts.PlayConnectedSound)
				{
					PPM8INfv9VK01EnoXpRO.oSVfvocGSUI(SoundAlerts.Connected, rfNNEZDrgCw5lETUjxSN(wkklNeDrQjJoHT6SUpND()));
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void XuCfYZmYa9t()
	{
		if (((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).PlayDisconnectedSound)
		{
			PPM8INfv9VK01EnoXpRO.oSVfvocGSUI(SoundAlerts.Disconnected, ((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).V6IfoUT1bpc);
		}
	}

	public static void G3WfYV2ZdfB()
	{
		if (lkp1YfDrRVrCJY5Xa3ni(wkklNeDrQjJoHT6SUpND()))
		{
			PPM8INfv9VK01EnoXpRO.oSVfvocGSUI(((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).OrderPlaced, SoundAlerts.V6IfoUT1bpc);
		}
	}

	public static void tltfYCvawBn()
	{
		if (SoundAlerts.PlayOrderRejectedSound && !((MhMDPU9v8rkigy1ao0Th)keYLI6Dr64NAtHME2BAx()).ErrorNotificationsDisabled)
		{
			PPM8INfv9VK01EnoXpRO.oSVfvocGSUI((string)JrhW1jDrMR3JgkwaG0Le(wkklNeDrQjJoHT6SUpND()), SoundAlerts.V6IfoUT1bpc);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
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

	public static void L9YfYrWaIes()
	{
		if (SoundAlerts.PlayOrderModifiedSound)
		{
			ksWkfUDrq2Z0Fjfen5YJ(h2vjNxDrOnwrS6CtwBnB(SoundAlerts), SoundAlerts.V6IfoUT1bpc);
		}
	}

	public static void G1ifYKb8m5V()
	{
		if (((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).PlayOrderModifyRejectedSound && !((MhMDPU9v8rkigy1ao0Th)keYLI6Dr64NAtHME2BAx()).ErrorNotificationsDisabled)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			ksWkfUDrq2Z0Fjfen5YJ(SoundAlerts.OrderModifyRejected, ((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).V6IfoUT1bpc);
		}
	}

	public static void w5dfYm2G3Db()
	{
		if (SoundAlerts.PlayOrderCanceledSound)
		{
			ksWkfUDrq2Z0Fjfen5YJ(aEBQsYDrI5uyM8bsqY34(SoundAlerts), rfNNEZDrgCw5lETUjxSN(wkklNeDrQjJoHT6SUpND()));
		}
	}

	public static void xBsfYheBxgw()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (vB4e9vDrWb9U00y7By3a(SoundAlerts))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				if (!HS0FNYDrt23LFkfVRRuw(keYLI6Dr64NAtHME2BAx()))
				{
					ksWkfUDrq2Z0Fjfen5YJ(((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).OrderCancelRejected, SoundAlerts.V6IfoUT1bpc);
				}
				return;
			}
		}
	}

	public static void KDCfYwJuCYD()
	{
		if (SoundAlerts.PlayOrderFilledSound)
		{
			ksWkfUDrq2Z0Fjfen5YJ(SoundAlerts.OrderFilled, rfNNEZDrgCw5lETUjxSN(SoundAlerts));
		}
	}

	public static void UX8fY7ZbJhw(string P_0, int P_1 = 0)
	{
		nwZrNyDrUEqd6TgKvOSK(P_0, P_1, ((UwYeOefYP8lJpje6lqk7)wkklNeDrQjJoHT6SUpND()).V6IfoUT1bpc);
	}

	public oZu29WfYtbVlhlMVGiDk()
	{
		nCGhdWDrTtLvsF7QWuC3();
		base._002Ector();
	}

	internal static object kwy0e3DrE0bynuYWqMpV()
	{
		return j18iDj9nukSCmEyZs5lH.cte9YDt0Xx9();
	}

	internal static bool tdDsBbDrcZ3BXnOXdZGK()
	{
		return sXdLdIDrXp3E4lAcPSkM == null;
	}

	internal static oZu29WfYtbVlhlMVGiDk lDXBPsDrj4mMNYmSaIsG()
	{
		return sXdLdIDrXp3E4lAcPSkM;
	}

	internal static object wkklNeDrQjJoHT6SUpND()
	{
		return SoundAlerts;
	}

	internal static bool OSNWBIDrdGQjkM2HohI2(object P_0)
	{
		return ((UwYeOefYP8lJpje6lqk7)P_0).PlayScreenerAlertSound;
	}

	internal static int rfNNEZDrgCw5lETUjxSN(object P_0)
	{
		return ((UwYeOefYP8lJpje6lqk7)P_0).V6IfoUT1bpc;
	}

	internal static bool lkp1YfDrRVrCJY5Xa3ni(object P_0)
	{
		return ((UwYeOefYP8lJpje6lqk7)P_0).PlayOrderPlacedSound;
	}

	internal static object keYLI6Dr64NAtHME2BAx()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object JrhW1jDrMR3JgkwaG0Le(object P_0)
	{
		return ((UwYeOefYP8lJpje6lqk7)P_0).OrderRejected;
	}

	internal static object h2vjNxDrOnwrS6CtwBnB(object P_0)
	{
		return ((UwYeOefYP8lJpje6lqk7)P_0).OrderModified;
	}

	internal static void ksWkfUDrq2Z0Fjfen5YJ(object P_0, int P_1)
	{
		PPM8INfv9VK01EnoXpRO.oSVfvocGSUI((string)P_0, P_1);
	}

	internal static object aEBQsYDrI5uyM8bsqY34(object P_0)
	{
		return ((UwYeOefYP8lJpje6lqk7)P_0).OrderCanceled;
	}

	internal static bool vB4e9vDrWb9U00y7By3a(object P_0)
	{
		return ((UwYeOefYP8lJpje6lqk7)P_0).PlayOrderCancelRejectedSound;
	}

	internal static bool HS0FNYDrt23LFkfVRRuw(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ErrorNotificationsDisabled;
	}

	internal static void nwZrNyDrUEqd6TgKvOSK(object P_0, int P_1, int P_2)
	{
		PPM8INfv9VK01EnoXpRO.AGCfvafhMkf((string)P_0, P_1, P_2);
	}

	internal static void nCGhdWDrTtLvsF7QWuC3()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
