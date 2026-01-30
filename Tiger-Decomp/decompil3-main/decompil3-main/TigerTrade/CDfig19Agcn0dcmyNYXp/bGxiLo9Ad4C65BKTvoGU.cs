using System;
using System.Collections.Generic;
using System.Diagnostics;
using bFLVeaGpb14YNScYcv2Q;
using ECOEgqlSad8NUJZ2Dr9n;
using ESfWR89rpJGqlpJwL5ej;
using Jgts7nfznYcKf4dWwwEP;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Tc.History;
using TuAMtrl1Nd3XoZQQUXf0;
using zy8uls9AtRKGi5l5tZKJ;

namespace CDfig19Agcn0dcmyNYXp;

internal sealed class bGxiLo9Ad4C65BKTvoGU
{
	private readonly U2sMUm9r39JSXDgxgx8p YY09AONSyb1;

	private readonly Dictionary<string, qt9C3B9AWZP5dEmJcrrj> tOi9AqHpC50;

	private readonly Dictionary<string, qt9C3B9AWZP5dEmJcrrj> N7F9AIpRQJr;

	private static bGxiLo9Ad4C65BKTvoGU fh8McpbruFiieatGiODu;

	public bGxiLo9Ad4C65BKTvoGU(U2sMUm9r39JSXDgxgx8p P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		tOi9AqHpC50 = new Dictionary<string, qt9C3B9AWZP5dEmJcrrj>();
		N7F9AIpRQJr = new Dictionary<string, qt9C3B9AWZP5dEmJcrrj>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
		{
			num = 0;
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
				YY09AONSyb1 = P_0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void bRf9ARmBblL(string P_0, qt9C3B9AWZP5dEmJcrrj P_1)
	{
		if (tOi9AqHpC50.ContainsKey(P_0))
		{
			return;
		}
		tOi9AqHpC50.Add(P_0, P_1);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 1:
			return;
		}
		if (!N7F9AIpRQJr.ContainsKey(P_0))
		{
			N7F9AIpRQJr.Add(P_0, P_1);
		}
	}

	public void AJW9A65VpCG(string P_0, ICollection<byte[]> P_1, t8QNqWfz9x1DweDKl161 P_2)
	{
		if (tOi9AqHpC50.ContainsKey(P_0))
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			qt9C3B9AWZP5dEmJcrrj qt9C3B9AWZP5dEmJcrrj = tOi9AqHpC50[P_0];
			try
			{
				qt9C3B9AWZP5dEmJcrrj.V6Hl9CmUBcW(P_0, P_1);
			}
			catch (Exception ex)
			{
				LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3305EF6B), qt9C3B9AWZP5dEmJcrrj.GetType().Name, P_2.Symbol.ID, P_2.DataCycle.StartDate, P_2.DataCycle.EndDate, P_2.DataCycle, P_2.DataScale, ex));
			}
			tOi9AqHpC50.Remove(P_0);
			stopwatch.Stop();
			LogManager.WriteInfo(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1251569705 ^ -1251805575), qt9C3B9AWZP5dEmJcrrj.GetType().Name, P_2.Symbol.Name, P_2.DataCycle.StartDate, P_2.DataCycle.EndDate, P_2.DataCycle, P_2.DataScale, P_1.Count, stopwatch.ElapsedMilliseconds));
		}
	}

	public void z8t9AMZsMPV(string P_0, IDataReader<TickEvent> P_1, TicksRequest P_2)
	{
		if (!P_1.IsEmpty && N7F9AIpRQJr.ContainsKey(P_0))
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			qt9C3B9AWZP5dEmJcrrj qt9C3B9AWZP5dEmJcrrj = N7F9AIpRQJr[P_0];
			try
			{
				qt9C3B9AWZP5dEmJcrrj.jn1l9rlHE2X(P_0, P_1);
			}
			catch (Exception ex)
			{
				LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741FFF61), qt9C3B9AWZP5dEmJcrrj.GetType().Name, P_2.Symbol.ID, YY09AONSyb1.DataCycle, YY09AONSyb1.UJElnHayjot, ex));
			}
			N7F9AIpRQJr.Remove(P_0);
			stopwatch.Stop();
			LogManager.WriteInfo(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x37458A66), qt9C3B9AWZP5dEmJcrrj.GetType().Name, P_2.Symbol.Name, YY09AONSyb1.DataCycle, YY09AONSyb1.UJElnHayjot, stopwatch.ElapsedMilliseconds));
		}
	}

	static bGxiLo9Ad4C65BKTvoGU()
	{
		OIo4MxbK2yyC0KwaEFIa();
	}

	internal static bool ITj5w9brztSV0hE7IDLB()
	{
		return fh8McpbruFiieatGiODu == null;
	}

	internal static bGxiLo9Ad4C65BKTvoGU yQ0J20bK0E0aQ45qLNVE()
	{
		return fh8McpbruFiieatGiODu;
	}

	internal static void OIo4MxbK2yyC0KwaEFIa()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
