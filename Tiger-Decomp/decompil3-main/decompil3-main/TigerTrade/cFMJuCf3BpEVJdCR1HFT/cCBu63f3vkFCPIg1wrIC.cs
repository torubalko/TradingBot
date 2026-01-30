using System;
using System.Collections.Generic;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using bQeLQJ9JVIVGlOu9BJva;
using c71M56fFrIRknXFy5cnV;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace cFMJuCf3BpEVJdCR1HFT;

internal sealed class cCBu63f3vkFCPIg1wrIC
{
	private readonly List<Sl9ykSfFCMU49HP0CuHU> A9Qf34AsuEu;

	private Sl9ykSfFCMU49HP0CuHU JjSf3DZOjp5;

	private bool ch0f3bS2R7L;

	private static cCBu63f3vkFCPIg1wrIC TsXUfbblGQhvBiQgRHg4;

	public void aDpf3adN55a(KHxL9R9JZMZ1sv2HFY9P P_0, bool P_1, long P_2, bool P_3)
	{
		int num = 12;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					JjSf3DZOjp5.Price = P_0.Price;
					JjSf3DZOjp5.Size = P_0.Size;
					JjSf3DZOjp5.Side = P_0.Side;
					JjSf3DZOjp5.qFmfF80SRFu(0L);
					f36HVLbll6oqbTovPmjG(JjSf3DZOjp5, P_0.QuoteSize);
					goto case 2;
				case 1:
					JjSf3DZOjp5.XiKf30waNIS(_0020: false);
					num2 = 7;
					continue;
				case 6:
					acOvvHblNODFxcixOYE1(A9Qf34AsuEu, A9Qf34AsuEu.Count - 1);
					num2 = 15;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					if (P_1 && (double)j18iDj9nukSCmEyZs5lH.Settings.TradesAggPeriod >= rUDFLOblarn29QENwSqa(hdZM7nblBgHwGf2QurUo(P_0.Time, JjSf3DZOjp5.Time).TotalMilliseconds) && JjSf3DZOjp5.Side == P_0.Side)
					{
						num2 = 10;
						continue;
					}
					goto default;
				case 13:
				case 15:
					if (xqhgSxblbq72FsrVAHeF(A9Qf34AsuEu) < num3)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						JjSf3DZOjp5 = A9Qf34AsuEu[xqhgSxblbq72FsrVAHeF(A9Qf34AsuEu) - 1];
						num2 = 6;
					}
					continue;
				case 5:
				{
					Sl9ykSfFCMU49HP0CuHU jjSf3DZOjp = JjSf3DZOjp5;
					f36HVLbll6oqbTovPmjG(jjSf3DZOjp, Sn1vHFblitKsLDLykiDT(jjSf3DZOjp) + P_0.QuoteSize);
					I3dKgnblD3qtr8ZCnCLs(JjSf3DZOjp5, LIIM1Ibl4LUg1u6iUtCf(P_0));
					num2 = 2;
					continue;
				}
				case 9:
					JjSf3DZOjp5.XiKf30waNIS(_0020: true);
					A9Qf34AsuEu.Insert(0, JjSf3DZOjp5);
					num2 = 4;
					continue;
				case 11:
					if (JjSf3DZOjp5 == null)
					{
						JjSf3DZOjp5 = new Sl9ykSfFCMU49HP0CuHU(P_0);
						num2 = 14;
						continue;
					}
					goto case 8;
				case 10:
					break;
				case 12:
					num3 = ((MhMDPU9v8rkigy1ao0Th)hvbRCwblvEUJjMX075Fm()).CountTradesInTape;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
					{
						num2 = 11;
					}
					continue;
				case 2:
				case 14:
				{
					long num4 = (P_3 ? JjSf3DZOjp5.Size : Sn1vHFblitKsLDLykiDT(JjSf3DZOjp5));
					if (JjSf3DZOjp5 != null && num4 >= P_2 && !JjSf3DZOjp5.SWefFzBueLI())
					{
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				}
				case 7:
					JjSf3DZOjp5.Time = P_0.Time;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
					{
						num2 = 3;
					}
					continue;
				default:
					if (xqhgSxblbq72FsrVAHeF(A9Qf34AsuEu) < num3)
					{
						JjSf3DZOjp5 = new Sl9ykSfFCMU49HP0CuHU(P_0);
						goto case 2;
					}
					num2 = 13;
					continue;
				case 4:
					ch0f3bS2R7L = true;
					return;
				}
				break;
			}
			JjSf3DZOjp5.Size += P_0.Size;
			num = 5;
		}
	}

	public void Clear()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				JjSf3DZOjp5 = null;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				A9Qf34AsuEu.Clear();
				ch0f3bS2R7L = true;
				return;
			}
		}
	}

	public List<Sl9ykSfFCMU49HP0CuHU> Vvyf3iGvqcN()
	{
		return A9Qf34AsuEu;
	}

	public bool x4df3laBDHb()
	{
		if (!ch0f3bS2R7L)
		{
			return false;
		}
		ch0f3bS2R7L = false;
		return true;
	}

	public cCBu63f3vkFCPIg1wrIC()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		A9Qf34AsuEu = new List<Sl9ykSfFCMU49HP0CuHU>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static cCBu63f3vkFCPIg1wrIC()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object hvbRCwblvEUJjMX075Fm()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static TimeSpan hdZM7nblBgHwGf2QurUo(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static double rUDFLOblarn29QENwSqa(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static long Sn1vHFblitKsLDLykiDT(object P_0)
	{
		return ((Sl9ykSfFCMU49HP0CuHU)P_0).QuoteSize;
	}

	internal static void f36HVLbll6oqbTovPmjG(object P_0, long P_1)
	{
		((Sl9ykSfFCMU49HP0CuHU)P_0).QuoteSize = P_1;
	}

	internal static long LIIM1Ibl4LUg1u6iUtCf(object P_0)
	{
		return ((KHxL9R9JZMZ1sv2HFY9P)P_0).Price;
	}

	internal static void I3dKgnblD3qtr8ZCnCLs(object P_0, long P_1)
	{
		((Sl9ykSfFCMU49HP0CuHU)P_0).qFmfF80SRFu(P_1);
	}

	internal static int xqhgSxblbq72FsrVAHeF(object P_0)
	{
		return ((List<Sl9ykSfFCMU49HP0CuHU>)P_0).Count;
	}

	internal static void acOvvHblNODFxcixOYE1(object P_0, int P_1)
	{
		((List<Sl9ykSfFCMU49HP0CuHU>)P_0).RemoveAt(P_1);
	}

	internal static bool rkIR8eblYAqAbKmmiP08()
	{
		return TsXUfbblGQhvBiQgRHg4 == null;
	}

	internal static cCBu63f3vkFCPIg1wrIC NoG760bloiAUBqS0Bo0r()
	{
		return TsXUfbblGQhvBiQgRHg4;
	}
}
