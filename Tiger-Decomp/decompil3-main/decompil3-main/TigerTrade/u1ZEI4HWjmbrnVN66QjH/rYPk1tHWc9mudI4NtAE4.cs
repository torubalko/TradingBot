using System;
using System.Collections.Generic;
using System.IO;
using DEGmmAHIXxyvftfYe5Jt;
using ECOEgqlSad8NUJZ2Dr9n;
using fbAJrmHWaCq9y2BmAHeQ;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;

namespace u1ZEI4HWjmbrnVN66QjH;

internal sealed class rYPk1tHWc9mudI4NtAE4 : pjrqOEHWB01F6wQ53XQc
{
	[Flags]
	internal enum QQ6VAOnhXHRuOJanceI4
	{
		None = 0
	}

	[Flags]
	internal enum KP9yZLnhEZ2EaKTES9rc
	{
		None = 0,
		OpenPos = 2
	}

	private long Fm3HW6kA0U1;

	private long JVSHWM9hIuV;

	private bool FHjHWOoNOXg;

	internal static rYPk1tHWc9mudI4NtAE4 KcG6FUDq2SdFMTN8E1eI;

	public rYPk1tHWc9mudI4NtAE4(Stream P_0, double P_1, bool P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				eRUHW1VVQpC(P_1);
				MGTHW40uCgF((byte)(P_2 ? 1 : 2));
				return;
			}
			FHjHWOoNOXg = P_2;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
			{
				num = 0;
			}
		}
	}

	private void xB7HWEuApxE(long P_0)
	{
		Hh2HWi1l00v(P_0 - JVSHWM9hIuV);
		JVSHWM9hIuV = P_0;
	}

	private void eUtHWQ3ZbET(DateTime P_0)
	{
		long ticks = P_0.Ticks;
		Hh2HWi1l00v(ticks - Fm3HW6kA0U1);
		Fm3HW6kA0U1 = ticks;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void cRqHWdSH5lH(dKSpGiHyaUa6LiEfhK5I P_0)
	{
		MGTHW40uCgF(0);
		eUtHWQ3ZbET(P_0.Time);
		xB7HWEuApxE(P_0.C7PHyDjhF2K);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				xB7HWEuApxE(P_0.jdxHybNY54C);
				xB7HWEuApxE(P_0.sW6HyNmJLUK);
				xB7HWEuApxE(P_0.Close);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				Hh2HWi1l00v(P_0.Volume);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void HOxHWg2DYmR(dKSpGiHyaUa6LiEfhK5I P_0)
	{
		int num = 4;
		int num2 = num;
		KP9yZLnhEZ2EaKTES9rc kP9yZLnhEZ2EaKTES9rc = default(KP9yZLnhEZ2EaKTES9rc);
		while (true)
		{
			switch (num2)
			{
			default:
				if ((kP9yZLnhEZ2EaKTES9rc & KP9yZLnhEZ2EaKTES9rc.OpenPos) != KP9yZLnhEZ2EaKTES9rc.None)
				{
					Hh2HWi1l00v(P_0.OpenPos);
					num2 = 8;
					break;
				}
				return;
			case 6:
				Hh2HWi1l00v(P_0.Ask);
				num2 = 5;
				break;
			case 5:
				Hh2HWi1l00v(P_0.i98HykoHqN8);
				Hh2HWi1l00v(P_0.LYyHy1w7GsI);
				Hh2HWi1l00v(P_0.j3oHy5YxGRO);
				Hh2HWi1l00v(P_0.WakHySNbeAE);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				MGTHW40uCgF((byte)kP9yZLnhEZ2EaKTES9rc);
				num2 = 9;
				break;
			case 3:
				if (P_0.OpenPos > 0)
				{
					kP9yZLnhEZ2EaKTES9rc |= KP9yZLnhEZ2EaKTES9rc.OpenPos;
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 10;
			case 9:
				eUtHWQ3ZbET(P_0.Time);
				eUtHWQ3ZbET(P_0.OpenTime);
				eUtHWQ3ZbET(P_0.CloseTime);
				xB7HWEuApxE(P_0.C7PHyDjhF2K);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				xB7HWEuApxE(P_0.jdxHybNY54C);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				kP9yZLnhEZ2EaKTES9rc = KP9yZLnhEZ2EaKTES9rc.None;
				num2 = 3;
				break;
			case 7:
				xB7HWEuApxE(P_0.Close);
				Hh2HWi1l00v(P_0.Bid);
				num2 = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
				{
					num2 = 6;
				}
				break;
			case 8:
				Hh2HWi1l00v(P_0.Q1EHyxuWSIV);
				Hh2HWi1l00v(P_0.Fp0HyLeCRZw);
				Hh2HWi1l00v(P_0.MmoHye9Mgnv);
				Hh2HWi1l00v(P_0.yqRHysZeALF);
				return;
			case 2:
				xB7HWEuApxE(P_0.sW6HyNmJLUK);
				num2 = 7;
				break;
			}
		}
	}

	public static byte[] PfKHWRNMERN(List<dKSpGiHyaUa6LiEfhK5I> P_0, bool P_1, double P_2, bool P_3)
	{
		MemoryStream memoryStream = new MemoryStream();
		rYPk1tHWc9mudI4NtAE4 rYPk1tHWc9mudI4NtAE5 = new rYPk1tHWc9mudI4NtAE4(memoryStream, P_2, P_1);
		foreach (dKSpGiHyaUa6LiEfhK5I item in P_0)
		{
			if (P_1)
			{
				rYPk1tHWc9mudI4NtAE5.cRqHWdSH5lH(item);
			}
			else
			{
				rYPk1tHWc9mudI4NtAE5.HOxHWg2DYmR(item);
			}
		}
		if (!P_3)
		{
			return memoryStream.ToArray();
		}
		return kVMHIrHIsg767m7Uj3RM.Compress(memoryStream.ToArray());
	}

	static rYPk1tHWc9mudI4NtAE4()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool DdYVa2DqH7cRHT4GA9kP()
	{
		return KcG6FUDq2SdFMTN8E1eI == null;
	}

	internal static rYPk1tHWc9mudI4NtAE4 D4rvsaDqfXMCuySKCucS()
	{
		return KcG6FUDq2SdFMTN8E1eI;
	}
}
