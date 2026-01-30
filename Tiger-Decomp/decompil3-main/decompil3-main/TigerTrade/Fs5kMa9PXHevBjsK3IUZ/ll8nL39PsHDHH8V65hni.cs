using System;
using System.Collections.Generic;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using bFLVeaGpb14YNScYcv2Q;
using ECOEgqlSad8NUJZ2Dr9n;
using EPTTTK9AHwAIaZbPECNj;
using ESfWR89rpJGqlpJwL5ej;
using fUAfhM3R3NY0EmpvNsH;
using Q1O0jf3dgjOpYkdqdXJ;
using TigerTrade.Config.Common;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using TuAMtrl1Nd3XoZQQUXf0;
using zy8uls9AtRKGi5l5tZKJ;

namespace Fs5kMa9PXHevBjsK3IUZ;

internal class ll8nL39PsHDHH8V65hni : qt9C3B9AWZP5dEmJcrrj
{
	private readonly U2sMUm9r39JSXDgxgx8p NC99PjScbrF;

	private readonly Dictionary<long, IFiUWV3Q45rxorDJcns.FRYg6WnQosHw7tyyquFs> G7b9PE2nWfb;

	private bool BeB9PQsowas;

	private string Qrr9Pd1rWWs;

	private DateTime J1b9PgEQZ9Q;

	internal static ll8nL39PsHDHH8V65hni UhQpKRbKNOGiZEVoH6b3;

	public ll8nL39PsHDHH8V65hni(U2sMUm9r39JSXDgxgx8p P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		G7b9PE2nWfb = new Dictionary<long, IFiUWV3Q45rxorDJcns.FRYg6WnQosHw7tyyquFs>();
		Qrr9Pd1rWWs = "";
		J1b9PgEQZ9Q = DateTime.Now;
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				NC99PjScbrF = P_0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public string xeN9PcE57ah(long P_0)
	{
		if (G7b9PE2nWfb.Count != 0 && G7b9PE2nWfb.TryGetValue(P_0, out var value))
		{
			TimeSpan timeSpan = DD7plVbKxJTpxy4vl6mj(jRm47pbK5bJk01wNyIKm(), xMv1AVbKSP9RPpO36xt7(value.Time));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				case 1:
					return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C396EA), (int)timeSpan.TotalHours, timeSpan.Minutes);
				default:
					if ((int)timeSpan.TotalHours == 0)
					{
						if (timeSpan.Minutes == 0)
						{
							return string.Empty;
						}
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
						{
							num = 1;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
		}
		return string.Empty;
	}

	public void RequestData()
	{
		if (((MhMDPU9v8rkigy1ao0Th)jF6W1YbKLgWWcxEgcwPp()).TradeMode == AppTradeMode.Player)
		{
			return;
		}
		int num;
		if (!dO45wabKsVGFH282kqkL(NC99PjScbrF.Symbol.Exchange, RX4Ht0bKe8vMbTQxxF1F(-1841489831 ^ -1841466037)))
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_008e;
		IL_008e:
		if (J1b9PgEQZ9Q.AddSeconds(10.0) > DateTime.Now || NC99PjScbrF.Count == 0)
		{
			return;
		}
		NC99PjScbrF.og0lnBFfnMH(Qrr9Pd1rWWs);
		num = 2;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				if (!UE6hLbbKcm4jSGflZuF1(KilHnVbKXYNPSVcY3yca(NC99PjScbrF.Symbol), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1848945490)))
				{
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num = 3;
					}
					continue;
				}
				break;
			case 2:
				Qrr9Pd1rWWs = Guid.NewGuid().ToString();
				J1b9PgEQZ9Q = MiYLQvbKEMEUCOsxaV5g();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
				{
					num = 1;
				}
				continue;
			case 3:
			{
				RktveN9A29kC5WSbk87T rktveN9A29kC5WSbk87T = new RktveN9A29kC5WSbk87T();
				NC99PjScbrF.GGGlnaVMwtf(Qrr9Pd1rWWs, rktveN9A29kC5WSbk87T, this);
				return;
			}
			case 4:
				if (!UE6hLbbKcm4jSGflZuF1(((SymbolBase)W4I5bybKjfdRthorlifM(NC99PjScbrF)).Exchange, RX4Ht0bKe8vMbTQxxF1F(0x7F645F3C ^ 0x7F64338A)))
				{
					return;
				}
				break;
			case 1:
				BeB9PQsowas = true;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
				{
					num = 3;
				}
				continue;
			}
			break;
		}
		goto IL_008e;
	}

	public void V6Hl9CmUBcW(string P_0, ICollection<byte[]> P_1)
	{
		if (Qrr9Pd1rWWs != P_0)
		{
			return;
		}
		if (P_1 == null)
		{
			BeB9PQsowas = false;
			return;
		}
		G7b9PE2nWfb.Clear();
		foreach (byte[] item in P_1)
		{
			if (item == null)
			{
				continue;
			}
			JA8Igx3gg75PX3uPX0i jA8Igx3gg75PX3uPX0i = new JA8Igx3gg75PX3uPX0i(item);
			int num = jA8Igx3gg75PX3uPX0i.fbE3MpEadn();
			for (int i = 0; i < num; i++)
			{
				long num2 = jA8Igx3gg75PX3uPX0i.D4h36qWNZi();
				IFiUWV3Q45rxorDJcns.FRYg6WnQosHw7tyyquFs fRYg6WnQosHw7tyyquFs = new IFiUWV3Q45rxorDJcns.FRYg6WnQosHw7tyyquFs(num2)
				{
					Time = jA8Igx3gg75PX3uPX0i.D4h36qWNZi()
				};
				int num3 = jA8Igx3gg75PX3uPX0i.fbE3MpEadn();
				for (int j = 0; j < num3; j++)
				{
					fRYg6WnQosHw7tyyquFs.Items.Add(jA8Igx3gg75PX3uPX0i.u9W3OWvSiK());
				}
				G7b9PE2nWfb[num2] = fRYg6WnQosHw7tyyquFs;
			}
		}
		BeB9PQsowas = false;
	}

	public void Clear()
	{
		G7b9PE2nWfb.Clear();
		BeB9PQsowas = false;
	}

	public void jn1l9rlHE2X(string P_0, IDataReader<TickEvent> P_1)
	{
	}

	public void LTel9KrLkYM()
	{
	}

	static ll8nL39PsHDHH8V65hni()
	{
		S9YdafbKQL9bR4oUvfIl();
	}

	internal static bool psuyoXbKk2ZvPKcJwfrh()
	{
		return UhQpKRbKNOGiZEVoH6b3 == null;
	}

	internal static ll8nL39PsHDHH8V65hni VHJCBTbK1Axr8C4EEDTb()
	{
		return UhQpKRbKNOGiZEVoH6b3;
	}

	internal static DateTimeOffset jRm47pbK5bJk01wNyIKm()
	{
		return DateTimeOffset.UtcNow;
	}

	internal static DateTimeOffset xMv1AVbKSP9RPpO36xt7(long P_0)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(P_0);
	}

	internal static TimeSpan DD7plVbKxJTpxy4vl6mj(DateTimeOffset P_0, DateTimeOffset P_1)
	{
		return P_0 - P_1;
	}

	internal static object jF6W1YbKLgWWcxEgcwPp()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object RX4Ht0bKe8vMbTQxxF1F(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool dO45wabKsVGFH282kqkL(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object KilHnVbKXYNPSVcY3yca(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static bool UE6hLbbKcm4jSGflZuF1(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object W4I5bybKjfdRthorlifM(object P_0)
	{
		return ((U2sMUm9r39JSXDgxgx8p)P_0).Symbol;
	}

	internal static DateTime MiYLQvbKEMEUCOsxaV5g()
	{
		return DateTime.Now;
	}

	internal static void S9YdafbKQL9bR4oUvfIl()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
