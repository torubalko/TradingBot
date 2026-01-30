using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using LpWHqpHFxDr7bif08Fn4;
using pduUFuHP7jFN8rkxyl0l;
using reuqbSHkyZtO3nPa1eKn;
using RPVQtsHPzsQV1qIogYUn;
using TigerTrade.Properties;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using UfilkavH3oZDuNlIYbg;

namespace ESxd7loP1YOLcDZsCHL;

internal sealed class egRkWboAXfgpDYEiUFC : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private readonly ObservableCollection<OMdL5pv2glbNcP3XDCe> hZkouh2AZE;

	private readonly Dictionary<string, OMdL5pv2glbNcP3XDCe> f8tozDj2Pp;

	private DispatcherTimer T4xv0WW6ft;

	private static egRkWboAXfgpDYEiUFC jtemx2l7UjiYO5v3WJZn;

	public ObservableCollection<OMdL5pv2glbNcP3XDCe> Limits
	{
		[CompilerGenerated]
		get
		{
			return hZkouh2AZE;
		}
	}

	public egRkWboAXfgpDYEiUFC()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		f8tozDj2Pp = new Dictionary<string, OMdL5pv2glbNcP3XDCe>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				(T4xv0WW6ft = new DispatcherTimer(TimeSpan.FromSeconds(1.0), DispatcherPriority.Normal, delegate
				{
					U58oFRhtTW();
				}, (Dispatcher)i9Otqml7ZshQq86qoeuG())).Start();
				return;
			}
			hZkouh2AZE = new ObservableCollection<OMdL5pv2glbNcP3XDCe>();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
			{
				num = 0;
			}
		}
	}

	public void OfOoJ5yDt9()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Limits.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				f8tozDj2Pp.Clear();
				U58oFRhtTW();
				return;
			}
		}
	}

	private void U58oFRhtTW()
	{
		using List<KQbAjaHPuhQcsTd7NH8a>.Enumerator enumerator = ((Jm1YX8HFSEpmh6QJJmd6)eaJZeRl7VjTXJyHjRR9I()).NmjHFsmFyvR.GetEnumerator();
		OMdL5pv2glbNcP3XDCe oMdL5pv2glbNcP3XDCe = default(OMdL5pv2glbNcP3XDCe);
		while (enumerator.MoveNext())
		{
			OMdL5pv2glbNcP3XDCe oMdL5pv2glbNcP3XDCe2;
			string obj;
			while (true)
			{
				KQbAjaHPuhQcsTd7NH8a current = enumerator.Current;
				current.yS7HJonD8Gq();
				string key = current.Key;
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 3:
						break;
					default:
						Limits.Add(oMdL5pv2glbNcP3XDCe);
						num = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
						{
							num = 0;
						}
						continue;
					case 1:
						if (!f8tozDj2Pp.ContainsKey(key))
						{
							oMdL5pv2glbNcP3XDCe = new OMdL5pv2glbNcP3XDCe();
							f8tozDj2Pp.Add(key, oMdL5pv2glbNcP3XDCe);
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 2;
					case 2:
						oMdL5pv2glbNcP3XDCe2 = f8tozDj2Pp[key];
						oMdL5pv2glbNcP3XDCe2.Account = current.vvHHJ4fKkK1;
						oMdL5pv2glbNcP3XDCe2.Symbol = current.FpHHJNbBvoO;
						oMdL5pv2glbNcP3XDCe2.SymbolInstance = SymbolManager.Get(current.Symbol);
						oMdL5pv2glbNcP3XDCe2.PosMaxSize = (string)((current.PosMaxSize > 0m) ? kqUykcl7rtmpIoV3CNQe(us3uiEl7Cu5hxDVyHdiD(-1325234765 ^ -1325227581), current.PosMaxSize) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C1EC2A));
						ylpbNdl7hAMXbbsFJbyp(oMdL5pv2glbNcP3XDCe2, (Y5OQVil7KTZrHjtVgUfI(current) > 0m) ? string.Format((string)us3uiEl7Cu5hxDVyHdiD(0x5CD4F15 ^ 0x5CD6B99), PZjl3Ql7mHtBW6YE1dnr(current), current.mpZHJgmsVbn) : string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57761739), PZjl3Ql7mHtBW6YE1dnr(current)));
						ItmwyQl78h6bbkE8b2Zu(oMdL5pv2glbNcP3XDCe2, eQZC1Nl7w8QBOGUtWXBV(current.sJMHJI52taP, 0m) ? string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746EF089), current.KlZHJUDfBZG, Svng4Fl77gAis3EUg6Nq(current)) : string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894895786), current.KlZHJUDfBZG));
						oMdL5pv2glbNcP3XDCe2.TotalTrades = (string)((current.SvXHJZ10p6M > 0) ? eMvqHEl7PE7rscNQa0RZ(us3uiEl7Cu5hxDVyHdiD(-90307782 ^ -90298466), V9hf5Rl7ALhoh2GAXqxv(current), current.SvXHJZ10p6M) : string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999640860), V9hf5Rl7ALhoh2GAXqxv(current)));
						oMdL5pv2glbNcP3XDCe2.LossTrades = (string)((current.dQNHJh0Aa1Q > 0) ? eMvqHEl7PE7rscNQa0RZ(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC9B80B), fEeaFfl7JDcZKXe5HsAw(current), current.dQNHJh0Aa1Q) : string.Format((string)us3uiEl7Cu5hxDVyHdiD(-602153869 ^ -602146807), current.kBgHJ8GE8aV));
						oMdL5pv2glbNcP3XDCe2.LossSequense = ((current.YdCHJJbrCL1 > 0) ? string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4297E74F), current.vwgHJpO84NL, current.YdCHJJbrCL1) : string.Format((string)us3uiEl7Cu5hxDVyHdiD(0x1A5F1B9E ^ 0x1A5F3FE4), current.vwgHJpO84NL));
						obj = (current.kybHF0DJKF0 ? Resources.LimitsControlViewModelStatusBlocked : Resources.LimitsControlViewModelStatusAllowed);
						goto end_IL_007e;
					}
					break;
				}
				continue;
				end_IL_007e:
				break;
			}
			Og0A8el7FRTiQW12UFjm(oMdL5pv2glbNcP3XDCe2, obj);
		}
	}

	[CompilerGenerated]
	private void Hpco3Oqplj(object P_0, EventArgs P_1)
	{
		U58oFRhtTW();
	}

	static egRkWboAXfgpDYEiUFC()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object i9Otqml7ZshQq86qoeuG()
	{
		return Dispatcher.CurrentDispatcher;
	}

	internal static bool AwtOYYl7TUGGRmaC1woa()
	{
		return jtemx2l7UjiYO5v3WJZn == null;
	}

	internal static egRkWboAXfgpDYEiUFC KnaEcnl7y0JONIrcsuuS()
	{
		return jtemx2l7UjiYO5v3WJZn;
	}

	internal static object eaJZeRl7VjTXJyHjRR9I()
	{
		return zyW7WyHPwnJEtIOWC1Wm.Settings;
	}

	internal static object us3uiEl7Cu5hxDVyHdiD(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object kqUykcl7rtmpIoV3CNQe(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static decimal Y5OQVil7KTZrHjtVgUfI(object P_0)
	{
		return ((KQbAjaHPuhQcsTd7NH8a)P_0).mpZHJgmsVbn;
	}

	internal static decimal PZjl3Ql7mHtBW6YE1dnr(object P_0)
	{
		return ((KQbAjaHPuhQcsTd7NH8a)P_0).EwFHJMMLHap;
	}

	internal static void ylpbNdl7hAMXbbsFJbyp(object P_0, object P_1)
	{
		((OMdL5pv2glbNcP3XDCe)P_0).DayLoss = (string)P_1;
	}

	internal static bool eQZC1Nl7w8QBOGUtWXBV(decimal P_0, decimal P_1)
	{
		return P_0 > P_1;
	}

	internal static decimal Svng4Fl77gAis3EUg6Nq(object P_0)
	{
		return ((KQbAjaHPuhQcsTd7NH8a)P_0).sJMHJI52taP;
	}

	internal static void ItmwyQl78h6bbkE8b2Zu(object P_0, object P_1)
	{
		((OMdL5pv2glbNcP3XDCe)P_0).Drawdown = (string)P_1;
	}

	internal static int V9hf5Rl7ALhoh2GAXqxv(object P_0)
	{
		return ((KQbAjaHPuhQcsTd7NH8a)P_0).sdWHJrQiPnC;
	}

	internal static object eMvqHEl7PE7rscNQa0RZ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static int fEeaFfl7JDcZKXe5HsAw(object P_0)
	{
		return ((KQbAjaHPuhQcsTd7NH8a)P_0).kBgHJ8GE8aV;
	}

	internal static void Og0A8el7FRTiQW12UFjm(object P_0, object P_1)
	{
		((OMdL5pv2glbNcP3XDCe)P_0).Status = (string)P_1;
	}
}
