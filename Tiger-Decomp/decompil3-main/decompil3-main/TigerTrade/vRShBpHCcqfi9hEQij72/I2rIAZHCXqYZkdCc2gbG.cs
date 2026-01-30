using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BeZUmLHycXdIKSy1sjhT;
using ECOEgqlSad8NUJZ2Dr9n;
using hX1duHHIjapqMYXosM8f;
using JqoLlqHyBgBYvLLyNweQ;
using Newtonsoft.Json.Linq;
using SiIjO2HT3B67XBQMGhXK;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;
using yTUn42HtsQvWm8KqT3n7;

namespace vRShBpHCcqfi9hEQij72;

internal abstract class I2rIAZHCXqYZkdCc2gbG
{
	internal static I2rIAZHCXqYZkdCc2gbG bfNDiaDWNDn2pTJbl8XX;

	public static List<dKSpGiHyaUa6LiEfhK5I> GvNHCj2VN5C(JArray P_0, Symbol P_1)
	{
		List<dKSpGiHyaUa6LiEfhK5I> list = new List<dKSpGiHyaUa6LiEfhK5I>();
		DateTime dateTime = new DateTime(1970, 1, 1);
		foreach (JToken item in ((IEnumerable<JToken>)P_0).Reverse())
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
					dKSpGiHyaUa6LiEfhK5I.Volume = P_1.GetShortSize(P_1.NeedHistoryCorrect ? result6 : (result6 * P_1.ContractValue));
				}
				list.Add(dKSpGiHyaUa6LiEfhK5I);
			}
		}
		return list;
	}

	public static List<Ai3xtDHyXEfq3el8VjlP> OJ2HCEtaYVh(string P_0, Symbol P_1, iKCR2MHtemRfkSuS8bq4 P_2)
	{
		int num = P_2.HIYHIECZnvA();
		List<Ai3xtDHyXEfq3el8VjlP> list = new List<Ai3xtDHyXEfq3el8VjlP>();
		JObject val = JObject.Parse(P_0);
		Ai3xtDHyXEfq3el8VjlP ai3xtDHyXEfq3el8VjlP = null;
		JToken obj = val[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42DB68B3)];
		if (obj == null || obj.ToObject<long>() != 0)
		{
			return list;
		}
		foreach (JToken item in ((IEnumerable<JToken>)val[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44323685)]).Reverse())
		{
			if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325304659)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
			{
				DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds(result).DateTime;
				DateTime dateTime2 = dateTime.Round(TimeSpan.FromSeconds(num));
				if (ai3xtDHyXEfq3el8VjlP == null || dateTime2 > ai3xtDHyXEfq3el8VjlP.Time)
				{
					ai3xtDHyXEfq3el8VjlP = new Ai3xtDHyXEfq3el8VjlP(dateTime);
					list.Add(ai3xtDHyXEfq3el8VjlP);
				}
				YrSXmVHTFktGXlDx147H yrSXmVHTFktGXlDx147H = new YrSXmVHTFktGXlDx147H();
				yrSXmVHTFktGXlDx147H.Time = dateTime;
				yrSXmVHTFktGXlDx147H.oZXHyonkMXM = ((!(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EAB0E0C)])?.ToString() == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878883596))) ? BfOPPuHyv8PQM9MdOwif.Sell : BfOPPuHyv8PQM9MdOwif.Buy);
				if (double.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1B095E)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result2))
				{
					yrSXmVHTFktGXlDx147H.mPRHynleDCG = P_1.GetShortPrice(result2);
				}
				if (double.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BD5C0E)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result3))
				{
					yrSXmVHTFktGXlDx147H.Size = P_1.GetShortSize(result3);
				}
				ai3xtDHyXEfq3el8VjlP.tEXHyj5d92E(yrSXmVHTFktGXlDx147H, P_2.DataScale);
			}
		}
		return list;
	}

	protected I2rIAZHCXqYZkdCc2gbG()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static I2rIAZHCXqYZkdCc2gbG()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Xwc7faDWk1qXS3LHshGo()
	{
		return bfNDiaDWNDn2pTJbl8XX == null;
	}

	internal static I2rIAZHCXqYZkdCc2gbG m8vN6NDW1JrHOGc3huQx()
	{
		return bfNDiaDWNDn2pTJbl8XX;
	}
}
