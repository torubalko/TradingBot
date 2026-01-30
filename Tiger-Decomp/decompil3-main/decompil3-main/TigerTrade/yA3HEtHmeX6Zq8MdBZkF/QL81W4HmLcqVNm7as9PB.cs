using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AfTdcIHKD22TwwMNEUC3;
using BeZUmLHycXdIKSy1sjhT;
using ECOEgqlSad8NUJZ2Dr9n;
using hX1duHHIjapqMYXosM8f;
using JDQ6KCGfdXAs3N4Dq3K0;
using JqoLlqHyBgBYvLLyNweQ;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using ohbhE3HrJKGixMhAfl81;
using QXJwWTHmurMk4nGdS0fA;
using SiIjO2HT3B67XBQMGhXK;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using vaMkL6HK5XJSTKSwDIac;
using VlIPc7HKV9GQuwHAPPBg;
using xDCpWkHyiuKZ3Q54rgJS;
using yTUn42HtsQvWm8KqT3n7;

namespace yA3HEtHmeX6Zq8MdBZkF;

internal abstract class QL81W4HmLcqVNm7as9PB
{
	private static QL81W4HmLcqVNm7as9PB IDYPG6DtyOLJWCkIP3ey;

	public static List<dKSpGiHyaUa6LiEfhK5I> BoDHmsJc1ya(JArray P_0, Symbol P_1)
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
					dKSpGiHyaUa6LiEfhK5I.Volume = (long)Math.Min(9223372036854775807m, P_1.GetShortSizeRaw(result6));
				}
				list.Add(dKSpGiHyaUa6LiEfhK5I);
			}
		}
		return list;
	}

	public static List<Symbol> T7tHmXIb1WX(string P_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		IList<GxM83THrPaJlbcQsN4bm> list = JsonConvert.DeserializeObject<VGDHqbHmp4dZlFVSOcI8<if0X1JHKZi5phXFqoHwB>>(P_0, (JsonConverter[])(object)new JsonConverter[1] { (JsonConverter)new StringEnumConverter() })?.Result?.Symbols;
		if (list == null || list.Count == 0)
		{
			return null;
		}
		return list.Select(YINHmctuEcH).ToList();
	}

	private static Symbol YINHmctuEcH(GxM83THrPaJlbcQsN4bm P_0)
	{
		int num = 5;
		int num2 = num;
		Symbol symbol = default(Symbol);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				symbol.Exchange = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F55E538 ^ 0x7F55882A);
				symbol.PointValue = 1.0;
				fd5xoaDthYXZMjL7R4ET(symbol, ((zd2REhHK4Gv9pMHKOG7t)KQl1VUDtmMRPelHCt85C(P_0)).TickSize);
				oZUPqODt7CFi5MZMQ9E5(symbol, xJABt8GfQN3bpiGT4k9G.LocGfReqp7D(pOwINiDtwrJiEuF09OHR(P_0.z1mHKnamFdY)));
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
			{
				Symbol symbol2 = symbol;
				Hashtable obj = new Hashtable { 
				{
					stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1086880726),
					stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769C4381)
				} };
				xW68cdDt3FTA9vqcFHU4(obj, Dg8IkCDtrSw2SLmBJrMH(0x86EFEF6 ^ 0x86D0C9C), PMLt8yDtF3pFOoPNuRo0(P_0.RVUHKoOh8OS.QuotePrecision));
				obj.Add(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D2F681), P_0.RVUHKoOh8OS.zKHHK66atVl);
				symbol2.AdditionalData = obj;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 2:
				return symbol;
			case 5:
				text = P_0.WbTHrz7YGXN;
				num2 = 4;
				break;
			case 4:
				text2 = (string)k5VU8ADtCp7tribbiU5l(P_0);
				symbol = new Symbol(text + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311281679) + text2 + (string)Dg8IkCDtrSw2SLmBJrMH(-602153869 ^ -602395009), SymbolType.Crypto);
				symbol.Code = text + text2;
				r4MEQ1DtKaZXYQ2WfKhp(symbol, text2);
				num2 = 7;
				break;
			case 1:
				symbol.Name = text + (string)Dg8IkCDtrSw2SLmBJrMH(-1127423276 ^ -1127280398) + text2;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				symbol.Description = (string)uxFRjnDt8m5tZpPkIp8k(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53957742), text2);
				num2 = 6;
				break;
			case 6:
				uoVoreDtASBHOpJkylF5(symbol, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774564825) + text + text2 + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1841489831 ^ -1841370513) + text + text2 + (string)Dg8IkCDtrSw2SLmBJrMH(-1416986301 ^ -1417055487));
				symbol.IsDeleted = false;
				symbol.LotStep = XTJYQ0DtPAC15EBZjO0F(P_0.RVUHKoOh8OS);
				hi7YKyDtJfBEAWPyOu8d(symbol, P_0.RVUHKoOh8OS.L9THKjYKla8);
				num2 = 8;
				break;
			case 3:
				symbol.SizeStep = P_0.RVUHKoOh8OS.nhbHKLU7pZG;
				symbol.SizePrecision = xJABt8GfQN3bpiGT4k9G.LocGfReqp7D(P_0.RVUHKoOh8OS.nhbHKLU7pZG);
				symbol.PnlPrecision = 8;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static List<Ai3xtDHyXEfq3el8VjlP> rY1Hmj6wxo6(string P_0, Symbol P_1, iKCR2MHtemRfkSuS8bq4 P_2)
	{
		int num = P_2.HIYHIECZnvA();
		List<Ai3xtDHyXEfq3el8VjlP> list = new List<Ai3xtDHyXEfq3el8VjlP>();
		JObject val = JObject.Parse(P_0);
		Ai3xtDHyXEfq3el8VjlP ai3xtDHyXEfq3el8VjlP = null;
		JToken obj = val[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x31594349)];
		if (obj == null || obj.ToObject<long>() != 0)
		{
			return list;
		}
		foreach (JToken item in ((IEnumerable<JToken>)val[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CEBDA9)][(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1251569705 ^ -1251640037)]).Reverse())
		{
			if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x3159433B)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
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
				yrSXmVHTFktGXlDx147H.oZXHyonkMXM = ((!(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x73972354)])?.ToString() == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-377195341 ^ -377163217))) ? BfOPPuHyv8PQM9MdOwif.Sell : BfOPPuHyv8PQM9MdOwif.Buy);
				if (double.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C808600)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result2))
				{
					yrSXmVHTFktGXlDx147H.mPRHynleDCG = P_1.GetShortPrice(result2);
				}
				if (double.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F67ADCE)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result3))
				{
					yrSXmVHTFktGXlDx147H.Size = P_1.GetShortSize(result3);
				}
				ai3xtDHyXEfq3el8VjlP.tEXHyj5d92E(yrSXmVHTFktGXlDx147H, P_2.DataScale);
			}
		}
		return list;
	}

	protected QL81W4HmLcqVNm7as9PB()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static QL81W4HmLcqVNm7as9PB()
	{
		fWGj6FDtp0r6wVIVye4b();
	}

	internal static object k5VU8ADtCp7tribbiU5l(object P_0)
	{
		return ((GxM83THrPaJlbcQsN4bm)P_0).JoIHKHGTrZL;
	}

	internal static object Dg8IkCDtrSw2SLmBJrMH(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void r4MEQ1DtKaZXYQ2WfKhp(object P_0, object P_1)
	{
		((Symbol)P_0).Currency = (string)P_1;
	}

	internal static object KQl1VUDtmMRPelHCt85C(object P_0)
	{
		return ((GxM83THrPaJlbcQsN4bm)P_0).z1mHKnamFdY;
	}

	internal static void fd5xoaDthYXZMjL7R4ET(object P_0, double P_1)
	{
		((SymbolBase)P_0).Step = P_1;
	}

	internal static double pOwINiDtwrJiEuF09OHR(object P_0)
	{
		return ((zd2REhHK4Gv9pMHKOG7t)P_0).TickSize;
	}

	internal static void oZUPqODt7CFi5MZMQ9E5(object P_0, int P_1)
	{
		((Symbol)P_0).Precision = P_1;
	}

	internal static object uxFRjnDt8m5tZpPkIp8k(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void uoVoreDtASBHOpJkylF5(object P_0, object P_1)
	{
		((Symbol)P_0).Mapping = (string)P_1;
	}

	internal static double XTJYQ0DtPAC15EBZjO0F(object P_0)
	{
		return ((bDGW9IHK1Y1XctO5rDwC)P_0).nhbHKLU7pZG;
	}

	internal static void hi7YKyDtJfBEAWPyOu8d(object P_0, double P_1)
	{
		((Symbol)P_0).MinQty = P_1;
	}

	internal static int PMLt8yDtF3pFOoPNuRo0(double P_0)
	{
		return xJABt8GfQN3bpiGT4k9G.LocGfReqp7D(P_0);
	}

	internal static void xW68cdDt3FTA9vqcFHU4(object P_0, object P_1, object P_2)
	{
		((Hashtable)P_0).Add(P_1, P_2);
	}

	internal static bool TeaHEcDtZ3eIyTWSPqFv()
	{
		return IDYPG6DtyOLJWCkIP3ey == null;
	}

	internal static QL81W4HmLcqVNm7as9PB ql2m8eDtV8tnK6FDY9Ot()
	{
		return IDYPG6DtyOLJWCkIP3ey;
	}

	internal static void fWGj6FDtp0r6wVIVye4b()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
