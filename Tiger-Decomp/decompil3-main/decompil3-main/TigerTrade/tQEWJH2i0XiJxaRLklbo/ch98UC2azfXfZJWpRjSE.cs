using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using VRsApd2ilCEhtIGFXcpy;
using yQpJFd2ikoEhOlxEU8S7;

namespace tQEWJH2i0XiJxaRLklbo;

internal class ch98UC2azfXfZJWpRjSE : aQQCx92iNagyA1PyOvhd
{
	private readonly string oy72io0YjK2;

	private readonly v6IITN2iiGSrbfxWwCYF Vlh2ivEaFNX;

	[CompilerGenerated]
	private readonly string Flr2iB35e84;

	[CompilerGenerated]
	private string xYs2iaYrRbN;

	private static ch98UC2azfXfZJWpRjSE gqg0YK4IiJ3JnSRxXq3A;

	public ch98UC2azfXfZJWpRjSE(string P_0, string P_1, v6IITN2iiGSrbfxWwCYF P_2, bool P_3)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_1, P_3);
		Flr2iB35e84 = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				KqI2i284O5d();
				return;
			case 1:
				oy72io0YjK2 = Account.GetConnectionID(mwp2ifAB11O());
				Vlh2ivEaFNX = P_2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public string mwp2ifAB11O()
	{
		return Flr2iB35e84;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GdB2inuEDXM()
	{
		return xYs2iaYrRbN;
	}

	[SpecialName]
	[CompilerGenerated]
	private void oFV2iG5Bnpe(string P_0)
	{
		xYs2iaYrRbN = P_0;
	}

	public void KqI2i284O5d()
	{
		oFV2iG5Bnpe((string)PUoT1a4IDrwq4dPM2rNN(base.Name, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123745127), NfQ2iH9gbpc(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311253603)));
	}

	private string NfQ2iH9gbpc()
	{
		return ((ConnectionInfo)vwR37V4IbeedXbkaADo3(oy72io0YjK2))?.ConnectionName ?? Vlh2ivEaFNX.GetName(oy72io0YjK2);
	}

	public override string ToString()
	{
		return GdB2inuEDXM();
	}

	static ch98UC2azfXfZJWpRjSE()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool OgdMwf4IlCErqC9cPSUh()
	{
		return gqg0YK4IiJ3JnSRxXq3A == null;
	}

	internal static ch98UC2azfXfZJWpRjSE ckH9Sd4I4yaixRv7yMIK()
	{
		return gqg0YK4IiJ3JnSRxXq3A;
	}

	internal static object PUoT1a4IDrwq4dPM2rNN(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static object vwR37V4IbeedXbkaADo3(object P_0)
	{
		return DataManager.GetConnectionInfo((string)P_0);
	}
}
