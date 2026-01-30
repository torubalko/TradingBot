using System;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using FbEh2t9xijg3wW8B3f8g;
using FIOH2Afgg2xm3yXQSZWT;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using waDpctGJom9MvAveNXHq;

namespace Vs7D1ifgOBnFeIIPKkYP;

internal static class gYaZ35fgMe1lUXl9Fd7Z
{
	private static readonly vOadlr9xaVCgXpG0X5P3 rkqfgUYt5S0;

	private static gYaZ35fgMe1lUXl9Fd7Z o7s9P8bfx3nI6h7ulwi1;

	public static int ewCfgqPoEij()
	{
		if (((MhMDPU9v8rkigy1ao0Th)EBr0qrbfsQERHUE4Cfg6()).LotWidgetAdjMode != Yw4WJlfgdvKJGJtIGWLx.twwfg6jPKyL)
		{
			return 1;
		}
		int num = rkqfgUYt5S0.beE9xlnxlyK();
		if (num < 2)
		{
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 1:
				break;
			default:
				return 1;
			}
		}
		if (num >= 4)
		{
			if (num >= 6)
			{
				return 15;
			}
			return 7;
		}
		return 3;
	}

	public static double PO6fgIRgPlr(Symbol P_0, long P_1, bool P_2, bool P_3)
	{
		int num = 3;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = JSrjaPbfXRCMdrjSBDWN(P_0) * P_0.ContractValue;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return 1.0;
			case 3:
				if (!P_3)
				{
					if (P_1 == 0L || P_0 == null)
					{
						return 0.0;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 2;
					}
				}
				break;
			case 1:
				if (!P_2)
				{
					return Math.Max(num3, ((MhMDPU9v8rkigy1ao0Th)EBr0qrbfsQERHUE4Cfg6()).PresetStepViaScroll / (double)P_1 / fvp4TSbfcehZtNUTNRv3(P_0));
				}
				return Math.Max(0.01, XDjNDvbfjIFNRTfbYrsm(num3 * (double)P_1 * P_0.Step, j18iDj9nukSCmEyZs5lH.Settings.PresetStepViaScroll));
			}
		}
	}

	private static double kwBfgWdjoq4(double P_0, Symbol P_1, bool P_2 = true)
	{
		int digits = JLFqEJGJYiHaSdoROJXI.PfRGJNxKWYQ(P_1.SizeStep);
		double num = P_1.SizeStep * P_1.ContractValue;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			case 1:
				return P_0;
			}
			P_0 = (P_2 ? (Math.Floor(P_0 / num) * num) : (Math.Round(P_0 / num) * num));
			P_0 = Math.Round(P_0, digits);
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
			{
				num2 = 1;
			}
		}
	}

	public static double BnZfgtdn8kh(double P_0, Symbol P_1, double P_2, double P_3, bool P_4, bool P_5)
	{
		double num = default(double);
		double num2 = default(double);
		int num3;
		double num4 = default(double);
		if (!P_4)
		{
			if (P_5)
			{
				return MyPjIPbfEwB4yfytxVZS(P_3);
			}
			num = Math.Max(P_0, P_3);
			if (sKd9QKbfQUwMYVFP80Vg(num))
			{
				goto IL_0094;
			}
			if (!(num - P_0 < double.Epsilon))
			{
				num2 = kwBfgWdjoq4(num, P_1);
				num3 = 4;
			}
			else
			{
				num3 = 3;
			}
		}
		else
		{
			num4 = Math.Max(P_0, P_3);
			num3 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
			{
				num3 = 0;
			}
		}
		int digits = default(int);
		while (true)
		{
			switch (num3)
			{
			case 2:
				num4 = P_0;
				goto IL_0106;
			default:
				return Math.Round(num4, digits);
			case 4:
				if (!(Math.Abs(P_2 - num2) > double.Epsilon))
				{
					return kwBfgWdjoq4(num, P_1, _0020: false);
				}
				return num2;
			case 1:
				if (double.IsNaN(num4))
				{
					goto case 2;
				}
				if (num4 - P_0 < double.Epsilon)
				{
					num3 = 2;
					continue;
				}
				goto IL_0106;
			case 3:
				break;
				IL_0106:
				digits = 8 - ((int)num4).ToString().Length + 1;
				num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num3 = 0;
				}
				continue;
			}
			break;
		}
		goto IL_0094;
		IL_0094:
		return kwBfgWdjoq4(P_0, P_1);
	}

	static gYaZ35fgMe1lUXl9Fd7Z()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		rkqfgUYt5S0 = new vOadlr9xaVCgXpG0X5P3(1000);
	}

	internal static object EBr0qrbfsQERHUE4Cfg6()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static bool B9qBqWbfLZyvHEF4Ue1u()
	{
		return o7s9P8bfx3nI6h7ulwi1 == null;
	}

	internal static gYaZ35fgMe1lUXl9Fd7Z DmAbW5bfe7eiBAHZvbj6()
	{
		return o7s9P8bfx3nI6h7ulwi1;
	}

	internal static double JSrjaPbfXRCMdrjSBDWN(object P_0)
	{
		return ((Symbol)P_0).LotStep;
	}

	internal static double fvp4TSbfcehZtNUTNRv3(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static double XDjNDvbfjIFNRTfbYrsm(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double MyPjIPbfEwB4yfytxVZS(double P_0)
	{
		return Math.Round(P_0);
	}

	internal static bool sKd9QKbfQUwMYVFP80Vg(double P_0)
	{
		return double.IsNaN(P_0);
	}
}
