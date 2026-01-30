using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using IQYLj190jO7J9KJxPiiQ;
using Jgts7nfznYcKf4dWwwEP;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace fl2m71HISn0woXH4Aohv;

internal abstract class zhZBf5HI5x0qedOPCfJX
{
	internal static zhZBf5HI5x0qedOPCfJX Jhwh1FDMm921tYrlu17n;

	public static bool EONHIxYU95i(t8QNqWfz9x1DweDKl161 P_0)
	{
		if (DataManager.Player)
		{
			return false;
		}
		if (P_0.Symbol.Exchange == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842066141))
		{
			return false;
		}
		int num;
		if (P_0.Symbol.IsMEXC && AAjHIL9nmuj(P_0))
		{
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
			{
				num = 5;
			}
			goto IL_0009;
		}
		goto IL_003d;
		IL_0009:
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				return true;
			case 2:
				break;
			case 1:
				goto IL_0092;
			case 9:
				if (((Symbol)P21g7QDM8GXCrSlPoRaB(P_0)).IsBybit)
				{
					goto end_IL_0009;
				}
				goto case 3;
			case 6:
				return false;
			case 7:
				if (!P_0.Symbol.IsBitget)
				{
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
					{
						num = 4;
					}
					continue;
				}
				goto end_IL_0009;
			case 3:
				if (!P_0.Symbol.IsOKX && !B4Ld6iDMAxPUmoES3G9g(P21g7QDM8GXCrSlPoRaB(P_0)))
				{
					num = 2;
					continue;
				}
				goto end_IL_0009;
			case 4:
				if (!djYpf0DMFo69h2NQU3bl(P_0.Symbol))
				{
					return false;
				}
				goto end_IL_0009;
			case 5:
				goto IL_023d;
			case 8:
				goto IL_0277;
			}
			if (ESesmbDMPhPiwqfiFRdU(P21g7QDM8GXCrSlPoRaB(P_0)) || y4Xb96DMJeW5nqbVmnm3(P_0.Symbol))
			{
				break;
			}
			num = 7;
			continue;
			IL_0277:
			if (wEDysbDMuwCuiAeVO22c(P_0) == (jRw7Dn90c0fQ7x3w42EX)2)
			{
				return rB5HIe92n3d(P_0);
			}
			goto IL_0136;
			IL_0092:
			if (jDVmOCDM78uwtSnNMWD8(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B3377D)))
			{
				if (((MhMDPU9v8rkigy1ao0Th)u9ThNjDMpYNOqLwoNV5M()).DomLoadFromExchange)
				{
					num = 8;
					continue;
				}
				goto IL_0136;
			}
			num = 6;
			continue;
			IL_023d:
			if (jDVmOCDM78uwtSnNMWD8(P_0.Source, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -617036131)))
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
				{
					num = 0;
				}
				continue;
			}
			goto IL_003d;
			IL_0136:
			return false;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0202;
		IL_003d:
		if (!P_0.Symbol.IsBinance)
		{
			int num2 = 9;
			num = num2;
			goto IL_0009;
		}
		goto IL_0202;
		IL_0202:
		text = P_0.Source;
		if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203037292))
		{
			if (csbCWoDM3EsERPfcEXUP(j18iDj9nukSCmEyZs5lH.Settings) && P_0.Type == (jRw7Dn90c0fQ7x3w42EX)3)
			{
				return AAjHIL9nmuj(P_0);
			}
			return false;
		}
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	private static bool AAjHIL9nmuj(t8QNqWfz9x1DweDKl161 P_0)
	{
		if ((P_0.Symbol.IsBinance || tYJM5MDMzPtDa6yhbSAC(P_0.Symbol)) && P_0.Symbol.Type == SymbolType.Crypto && P_0.DataCycle.CycleBase == DataCycleBase.Second)
		{
			return true;
		}
		int num;
		if (P_0.Symbol.IsGateIo)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
			{
				num = 5;
			}
			goto IL_0009;
		}
		goto IL_00cd;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 4:
				goto IL_006c;
			case 3:
				return false;
			case 2:
				return false;
			case 1:
				if (Ai7ymlDO0rwMvb8YDAIs(P_0.DataCycle) != DataCycleBase.Second)
				{
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
					{
						num = 4;
					}
					continue;
				}
				goto case 3;
			case 5:
				goto IL_0189;
			}
			break;
			IL_0189:
			if (P_0.DataCycle.CycleBase == DataCycleBase.Second)
			{
				num = 2;
				continue;
			}
			goto IL_00cd;
			IL_006c:
			if (((DataCycle)z3NftFDO2MuhwNeWF5Ba(P_0)).CycleBase == DataCycleBase.Year)
			{
				num = 3;
				continue;
			}
			goto IL_00b5;
		}
		if (Ai7ymlDO0rwMvb8YDAIs(P_0.DataCycle) != DataCycleBase.Day && Ai7ymlDO0rwMvb8YDAIs(P_0.DataCycle) != DataCycleBase.Week && ((DataCycle)z3NftFDO2MuhwNeWF5Ba(P_0)).CycleBase != DataCycleBase.Month)
		{
			return P_0.DataCycle.CycleBase == DataCycleBase.Year;
		}
		goto IL_0106;
		IL_00b5:
		if (P_0.DataCycle.CycleBase != DataCycleBase.Minute && ((DataCycle)z3NftFDO2MuhwNeWF5Ba(P_0)).CycleBase != DataCycleBase.Hour)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0106;
		IL_00cd:
		if (P_0.Symbol.IsMEXC)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_00b5;
		IL_0106:
		return true;
	}

	private static bool rB5HIe92n3d(t8QNqWfz9x1DweDKl161 P_0)
	{
		if (P_0.DataCycle.CycleBase != DataCycleBase.Second && P_0.DataCycle.CycleBase != DataCycleBase.Minute && P_0.DataCycle.CycleBase != DataCycleBase.Hour && P_0.DataCycle.CycleBase != DataCycleBase.Day && P_0.DataCycle.CycleBase != DataCycleBase.Week)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					return Ai7ymlDO0rwMvb8YDAIs(z3NftFDO2MuhwNeWF5Ba(P_0)) == DataCycleBase.Year;
				}
				if (P_0.DataCycle.CycleBase == DataCycleBase.Month)
				{
					break;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
				{
					num = 0;
				}
			}
		}
		return true;
	}

	protected zhZBf5HI5x0qedOPCfJX()
	{
		cnvSNhDOHUdYZHPUJM8V();
		base._002Ector();
	}

	static zhZBf5HI5x0qedOPCfJX()
	{
		vUVEULDOf7ikgdancmpT();
	}

	internal static bool jDVmOCDM78uwtSnNMWD8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object P21g7QDM8GXCrSlPoRaB(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).Symbol;
	}

	internal static bool B4Ld6iDMAxPUmoES3G9g(object P_0)
	{
		return ((Symbol)P_0).IsGateIo;
	}

	internal static bool ESesmbDMPhPiwqfiFRdU(object P_0)
	{
		return ((Symbol)P_0).IsMEXC;
	}

	internal static bool y4Xb96DMJeW5nqbVmnm3(object P_0)
	{
		return ((Symbol)P_0).IsTigerX;
	}

	internal static bool djYpf0DMFo69h2NQU3bl(object P_0)
	{
		return ((Symbol)P_0).IsBackpack;
	}

	internal static bool csbCWoDM3EsERPfcEXUP(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).ChartLoadFromExchange;
	}

	internal static object u9ThNjDMpYNOqLwoNV5M()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static jRw7Dn90c0fQ7x3w42EX wEDysbDMuwCuiAeVO22c(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).Type;
	}

	internal static bool w0e7V8DMhcQ2TcmFmv46()
	{
		return Jhwh1FDMm921tYrlu17n == null;
	}

	internal static zhZBf5HI5x0qedOPCfJX vtqegTDMwfXtvMLHUWTm()
	{
		return Jhwh1FDMm921tYrlu17n;
	}

	internal static bool tYJM5MDMzPtDa6yhbSAC(object P_0)
	{
		return ((Symbol)P_0).IsBinanceX;
	}

	internal static DataCycleBase Ai7ymlDO0rwMvb8YDAIs(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static object z3NftFDO2MuhwNeWF5Ba(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).DataCycle;
	}

	internal static void cnvSNhDOHUdYZHPUJM8V()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void vUVEULDOf7ikgdancmpT()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
