using System;
using System.Collections.Generic;
using System.Globalization;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json.Linq;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;

namespace HBOwBnHCVE06twdYpC6N;

internal abstract class hnCW5aHCZBMlIPiFbK15
{
	private static hnCW5aHCZBMlIPiFbK15 NvddDrDWcO8jw35BSqfD;

	public static List<dKSpGiHyaUa6LiEfhK5I> oHJHCCEDroA(string P_0, Symbol P_1)
	{
		List<dKSpGiHyaUa6LiEfhK5I> list = new List<dKSpGiHyaUa6LiEfhK5I>();
		JArray obj = JArray.Parse(P_0);
		DateTime dateTime = new DateTime(1970, 1, 1);
		foreach (JToken item in obj)
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
					dKSpGiHyaUa6LiEfhK5I.Volume = P_1.GetShortSize(result6);
				}
				list.Add(dKSpGiHyaUa6LiEfhK5I);
			}
		}
		return list;
	}

	protected hnCW5aHCZBMlIPiFbK15()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static hnCW5aHCZBMlIPiFbK15()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool R3aTf8DWjAF12FaVpbB1()
	{
		return NvddDrDWcO8jw35BSqfD == null;
	}

	internal static hnCW5aHCZBMlIPiFbK15 X4DxGWDWE6jupEZMZkYm()
	{
		return NvddDrDWcO8jw35BSqfD;
	}
}
