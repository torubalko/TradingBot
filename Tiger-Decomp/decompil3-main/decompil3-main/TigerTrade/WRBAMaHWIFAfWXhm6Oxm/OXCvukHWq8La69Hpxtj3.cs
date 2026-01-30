using System;
using System.Collections.Generic;
using System.IO;
using ABxgvYHyUBReVTOnCgrh;
using BeZUmLHycXdIKSy1sjhT;
using DEGmmAHIXxyvftfYe5Jt;
using ECOEgqlSad8NUJZ2Dr9n;
using fbAJrmHWaCq9y2BmAHeQ;
using TuAMtrl1Nd3XoZQQUXf0;

namespace WRBAMaHWIFAfWXhm6Oxm;

internal sealed class OXCvukHWq8La69Hpxtj3 : pjrqOEHWB01F6wQ53XQc
{
	[Flags]
	internal enum xXSNLYnhQwJwrHpXNqDw
	{
		None = 0,
		OpenPos = 1
	}

	private long LFYHWyD44Bv;

	private long VCxHWZuZeKl;

	private static OXCvukHWq8La69Hpxtj3 wIlYq8Dq9DNStUxxWt7r;

	public OXCvukHWq8La69Hpxtj3(Stream P_0, double P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		eRUHW1VVQpC(P_1);
	}

	private void yAkHWWeJRXe(long P_0)
	{
		Hh2HWi1l00v(P_0 - VCxHWZuZeKl);
		VCxHWZuZeKl = P_0;
	}

	private void YmFHWttHKpN(DateTime P_0)
	{
		long ticks = P_0.Ticks;
		Hh2HWi1l00v(ticks - LFYHWyD44Bv);
		LFYHWyD44Bv = ticks;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void FyAHWUbjqK4(Ai3xtDHyXEfq3el8VjlP P_0)
	{
		xXSNLYnhQwJwrHpXNqDw xXSNLYnhQwJwrHpXNqDw = xXSNLYnhQwJwrHpXNqDw.None;
		if (P_0.OpenPos > 0)
		{
			xXSNLYnhQwJwrHpXNqDw |= xXSNLYnhQwJwrHpXNqDw.OpenPos;
			goto IL_0037;
		}
		int num = 2;
		goto IL_0009;
		IL_0037:
		MGTHW40uCgF((byte)xXSNLYnhQwJwrHpXNqDw);
		num = 6;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
		{
			num = 8;
		}
		goto IL_0009;
		IL_0009:
		Dictionary<long, BJtE02HytsgECDGsyUU4>.ValueCollection.Enumerator enumerator = default(Dictionary<long, BJtE02HytsgECDGsyUU4>.ValueCollection.Enumerator);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 7:
				Hh2HWi1l00v(P_0.CLXHyWqXcuh);
				goto IL_02c0;
			case 1:
				return;
			case 8:
				YmFHWttHKpN(P_0.Time);
				YmFHWttHKpN(P_0.OpenTime);
				num = 3;
				continue;
			case 6:
				yAkHWWeJRXe(P_0.Close);
				Hh2HWi1l00v(Math.Abs(P_0.KcWHy6OudXg));
				Hh2HWi1l00v(v7KLANDqYDfaBJYPRa3L(P_0.fcnHyMI3Ecm));
				if ((xXSNLYnhQwJwrHpXNqDw & xXSNLYnhQwJwrHpXNqDw.OpenPos) != xXSNLYnhQwJwrHpXNqDw.None)
				{
					goto case 4;
				}
				goto IL_02c0;
			case 5:
			{
				Hh2HWi1l00v(P_0.AmEHyIifxoV);
				int num4 = 7;
				num = num4;
				continue;
			}
			case 4:
				Hh2HWi1l00v(P_0.OpenPos);
				num = 5;
				continue;
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							IL_01e3:
							BJtE02HytsgECDGsyUU4 current = enumerator.Current;
							yAkHWWeJRXe(current.kt5HyTQHYFD);
							Hh2HWi1l00v(current.Bid);
							Hh2HWi1l00v(current.Ask);
							int num2 = 3;
							while (true)
							{
								switch (num2)
								{
								case 2:
									Hh2HWi1l00v(current.Sd2HyCo9Wbh);
									num2 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
									{
										num2 = 0;
									}
									continue;
								case 3:
								{
									Hh2HWi1l00v(current.thSHyVbl7Ce);
									int num3 = 2;
									num2 = num3;
									continue;
								}
								default:
									if ((xXSNLYnhQwJwrHpXNqDw & xXSNLYnhQwJwrHpXNqDw.OpenPos) == 0)
									{
										break;
									}
									Hh2HWi1l00v(current.HLKHyrsbDms);
									Hh2HWi1l00v(current.Pe6HyKSV4d0);
									num2 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
									{
										num2 = 1;
									}
									continue;
								case 1:
									break;
								case 4:
									goto IL_01e3;
								}
								break;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			case 3:
				{
					YmFHWttHKpN(P_0.CloseTime);
					yAkHWWeJRXe(P_0.WT4Hydamaer);
					yAkHWWeJRXe(P_0.ocgHygQL53j);
					yAkHWWeJRXe(P_0.aMKHyRo2BUc);
					num = 6;
					continue;
				}
				IL_02c0:
				Hh2HWi1l00v(P_0.Items.Count);
				enumerator = P_0.Items.Values.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_0037;
	}

	public static byte[] WnVHWTw2ULs(List<Ai3xtDHyXEfq3el8VjlP> P_0, double P_1, bool P_2)
	{
		MemoryStream memoryStream = new MemoryStream();
		OXCvukHWq8La69Hpxtj3 oXCvukHWq8La69Hpxtj = new OXCvukHWq8La69Hpxtj3(memoryStream, P_1);
		foreach (Ai3xtDHyXEfq3el8VjlP item in P_0)
		{
			oXCvukHWq8La69Hpxtj.FyAHWUbjqK4(item);
		}
		if (!P_2)
		{
			return memoryStream.ToArray();
		}
		return kVMHIrHIsg767m7Uj3RM.Compress(memoryStream.ToArray());
	}

	static OXCvukHWq8La69Hpxtj3()
	{
		t09Oa9DqoiEAUryg6fLl();
	}

	internal static bool GZNMgeDqnKsGjSMWHvjQ()
	{
		return wIlYq8Dq9DNStUxxWt7r == null;
	}

	internal static OXCvukHWq8La69Hpxtj3 jpGa5SDqGr9d7l9gODQx()
	{
		return wIlYq8Dq9DNStUxxWt7r;
	}

	internal static long v7KLANDqYDfaBJYPRa3L(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static void t09Oa9DqoiEAUryg6fLl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
