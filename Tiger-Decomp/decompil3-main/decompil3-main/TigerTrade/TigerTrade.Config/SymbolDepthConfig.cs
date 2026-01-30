using System.Collections.Generic;
using System.Configuration;
using ECOEgqlSad8NUJZ2Dr9n;
using QTHhwX9f8Xdf60vpRbwm;
using TuAMtrl1Nd3XoZQQUXf0;
using wak3C49fKF7ypGYvHQIa;

namespace TigerTrade.Config;

public class SymbolDepthConfig : ConfigurationSection
{
	internal static SymbolDepthConfig gb5JDqbbW8iyPvZUigXc;

	[ConfigurationProperty("symbols")]
	[ConfigurationCollection(typeof(X7LIel9frF8ocZTf1BE4))]
	private X7LIel9frF8ocZTf1BE4 SymbolCollection => (X7LIel9frF8ocZTf1BE4)base[(string)KGEnydbbTkStOxk1H1Kf(-1435596783 ^ -1435847753)];

	public Dictionary<string, int> Symbols
	{
		get
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			foreach (object item in SymbolCollection)
			{
				if (item is Rc9bRZ9f7uZ1kpq4j1X8 rc9bRZ9f7uZ1kpq4j1X && int.TryParse(rc9bRZ9f7uZ1kpq4j1X.aGC9f3h2mNc, out var result))
				{
					dictionary.Add(rc9bRZ9f7uZ1kpq4j1X.Key, result);
				}
			}
			return dictionary;
		}
	}

	public SymbolDepthConfig()
	{
		FDhpq8bbycQkBQgtJSoi();
		base._002Ector();
	}

	static SymbolDepthConfig()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object KGEnydbbTkStOxk1H1Kf(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool aVIabAbbtCYlbbxnxmtA()
	{
		return gb5JDqbbW8iyPvZUigXc == null;
	}

	internal static SymbolDepthConfig V4rgRGbbUCXxI52mAgP3()
	{
		return gb5JDqbbW8iyPvZUigXc;
	}

	internal static void FDhpq8bbycQkBQgtJSoi()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
