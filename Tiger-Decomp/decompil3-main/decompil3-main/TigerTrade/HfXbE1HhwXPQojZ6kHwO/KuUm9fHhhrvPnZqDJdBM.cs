using System;
using System.Collections.Generic;
using System.Globalization;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json.Linq;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;

namespace HfXbE1HhwXPQojZ6kHwO;

internal abstract class KuUm9fHhhrvPnZqDJdBM
{
	private static KuUm9fHhhrvPnZqDJdBM K1FRJmDUSRmnbLeljJuP;

	public static List<dKSpGiHyaUa6LiEfhK5I> vwWHh7KFUJ4(JArray P_0, Symbol P_1)
	{
		List<dKSpGiHyaUa6LiEfhK5I> list = new List<dKSpGiHyaUa6LiEfhK5I>();
		DateTime dateTime = new DateTime(1970, 1, 1);
		foreach (JToken item in P_0)
		{
			if (long.TryParse(((object)item[(object)0])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
			{
				dKSpGiHyaUa6LiEfhK5I dKSpGiHyaUa6LiEfhK5I = new dKSpGiHyaUa6LiEfhK5I(dateTime.AddMilliseconds(result));
				if (double.TryParse(((object)item[(object)1])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result2))
				{
					dKSpGiHyaUa6LiEfhK5I.C7PHyDjhF2K = P_1.GetShortPrice(result2);
				}
				if (double.TryParse(((object)item[(object)2])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result3))
				{
					dKSpGiHyaUa6LiEfhK5I.jdxHybNY54C = P_1.GetShortPrice(result3);
				}
				if (double.TryParse(((object)item[(object)3])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result4))
				{
					dKSpGiHyaUa6LiEfhK5I.sW6HyNmJLUK = P_1.GetShortPrice(result4);
				}
				if (double.TryParse(((object)item[(object)4])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result5))
				{
					dKSpGiHyaUa6LiEfhK5I.Close = P_1.GetShortPrice(result5);
				}
				if (double.TryParse(((object)item[(object)5])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result6))
				{
					dKSpGiHyaUa6LiEfhK5I.Volume = (long)Math.Min(9223372036854775807m, P_1.GetShortSizeRaw(result6));
				}
				list.Add(dKSpGiHyaUa6LiEfhK5I);
			}
		}
		return list;
	}

	protected KuUm9fHhhrvPnZqDJdBM()
	{
		pMCMSfDUeFdHi0852WKc();
		base._002Ector();
	}

	static KuUm9fHhhrvPnZqDJdBM()
	{
		sB6fxDDUs5NN8bBk7SY1();
	}

	internal static void pMCMSfDUeFdHi0852WKc()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool SMc5AoDUxd0RVfWu4Eab()
	{
		return K1FRJmDUSRmnbLeljJuP == null;
	}

	internal static KuUm9fHhhrvPnZqDJdBM kF3gguDULIGBHpleVSog()
	{
		return K1FRJmDUSRmnbLeljJuP;
	}

	internal static void sB6fxDDUs5NN8bBk7SY1()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
