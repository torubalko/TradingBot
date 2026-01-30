using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using BeZUmLHycXdIKSy1sjhT;
using DTdEQUHwp86pTPFgTWdw;
using E7rs85HwdwwXutbdxrtS;
using ECOEgqlSad8NUJZ2Dr9n;
using hX1duHHIjapqMYXosM8f;
using JDQ6KCGfdXAs3N4Dq3K0;
using JqoLlqHyBgBYvLLyNweQ;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using SiIjO2HT3B67XBQMGhXK;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;
using YLfCBWHw27vHsIWo03Jc;
using yTUn42HtsQvWm8KqT3n7;

namespace gsieLPH7DfyNP9EsSE6K;

internal abstract class OQGi2yH74OpVYrJSJVVS
{
	[Serializable]
	[CompilerGenerated]
	private sealed class uogjR8nwliZuG9TSJ7Ur
	{
		public static readonly uogjR8nwliZuG9TSJ7Ur QsjnwkJ1AEi;

		public static Func<ut99iiHw0LgS5saMahZq, bool> ahxnw1YoUxH;

		public static Func<ut99iiHw0LgS5saMahZq, bool> HvKnw5LeCIG;

		public static Func<ut99iiHw0LgS5saMahZq, bool> qVanwSsYtKH;

		public static Func<ut99iiHw0LgS5saMahZq, bool> AGFnwxPevcC;

		internal static uogjR8nwliZuG9TSJ7Ur TmXSx0NdbGNmGiP1Iy64;

		static uogjR8nwliZuG9TSJ7Ur()
		{
			zBug6xNd1sisvcI7Oswm();
			MniRr6Nd5lgqa6GJyV2P();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			QsjnwkJ1AEi = new uogjR8nwliZuG9TSJ7Ur();
		}

		public uogjR8nwliZuG9TSJ7Ur()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool P2fnw4DghMe(ut99iiHw0LgS5saMahZq f)
		{
			return f.FilterType == (string)hZqy8ANdStPvxQPFnsTj(0x2C8374E4 ^ 0x2C87E1D4);
		}

		internal bool aJlnwDP0cRI(ut99iiHw0LgS5saMahZq f)
		{
			return (string)d6JOP0NdxxnPe4UoHUeR(f) == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1C6D2E);
		}

		internal bool Dm9nwbUEkl4(ut99iiHw0LgS5saMahZq f)
		{
			return QjAea0NdLDBL7ouF4dp1(d6JOP0NdxxnPe4UoHUeR(f), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306643256));
		}

		internal bool L7ZnwNnFb7I(ut99iiHw0LgS5saMahZq f)
		{
			return QjAea0NdLDBL7ouF4dp1(f.FilterType, hZqy8ANdStPvxQPFnsTj(0x42D899B5 ^ 0x42DC0CC1));
		}

		internal static void zBug6xNd1sisvcI7Oswm()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void MniRr6Nd5lgqa6GJyV2P()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool fo9wIENdNmPJHM66J9ZS()
		{
			return TmXSx0NdbGNmGiP1Iy64 == null;
		}

		internal static uogjR8nwliZuG9TSJ7Ur KKGpYgNdkUIC86nBvqrQ()
		{
			return TmXSx0NdbGNmGiP1Iy64;
		}

		internal static object hZqy8ANdStPvxQPFnsTj(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object d6JOP0NdxxnPe4UoHUeR(object P_0)
		{
			return ((ut99iiHw0LgS5saMahZq)P_0).FilterType;
		}

		internal static bool QjAea0NdLDBL7ouF4dp1(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	internal static OQGi2yH74OpVYrJSJVVS jBLPAEDUKfXMPFNRJFTq;

	public static List<dKSpGiHyaUa6LiEfhK5I> pUMH7bsAIaW(string P_0, Symbol P_1)
	{
		List<dKSpGiHyaUa6LiEfhK5I> list = new List<dKSpGiHyaUa6LiEfhK5I>();
		JArray obj = JArray.Parse(P_0);
		DateTime dateTime = new DateTime(1970, 1, 1);
		foreach (JToken item in obj)
		{
			if (long.TryParse(((object)item[(object)0])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
			{
				dKSpGiHyaUa6LiEfhK5I dKSpGiHyaUa6LiEfhK5I = new dKSpGiHyaUa6LiEfhK5I(dateTime.AddMilliseconds(result));
				dKSpGiHyaUa6LiEfhK5I.OpenTime = dKSpGiHyaUa6LiEfhK5I.Time;
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
				if (long.TryParse(((object)item[(object)0])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result7))
				{
					dKSpGiHyaUa6LiEfhK5I.CloseTime = dateTime.AddMilliseconds(result7);
				}
				if (double.TryParse(((object)item[(object)9])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result8))
				{
					dKSpGiHyaUa6LiEfhK5I.Ask = P_1.GetShortSize(result8);
					dKSpGiHyaUa6LiEfhK5I.Bid = dKSpGiHyaUa6LiEfhK5I.Volume - dKSpGiHyaUa6LiEfhK5I.Ask;
				}
				list.Add(dKSpGiHyaUa6LiEfhK5I);
			}
		}
		return list;
	}

	public static List<Ai3xtDHyXEfq3el8VjlP> z27H7N6lEsS(string P_0, Symbol P_1, iKCR2MHtemRfkSuS8bq4 P_2)
	{
		int num = P_2.HIYHIECZnvA();
		List<Ai3xtDHyXEfq3el8VjlP> list = new List<Ai3xtDHyXEfq3el8VjlP>();
		JArray obj = JArray.Parse(P_0);
		Ai3xtDHyXEfq3el8VjlP ai3xtDHyXEfq3el8VjlP = null;
		foreach (JToken item in obj)
		{
			if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306806724)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
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
				if (bool.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127280336)])?.ToString(), out var result2))
				{
					yrSXmVHTFktGXlDx147H.oZXHyonkMXM = (result2 ? BfOPPuHyv8PQM9MdOwif.Sell : BfOPPuHyv8PQM9MdOwif.Buy);
				}
				if (double.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x3860C41)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result3))
				{
					yrSXmVHTFktGXlDx147H.mPRHynleDCG = P_1.GetShortPrice(result3);
				}
				if (double.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461354443)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result4))
				{
					yrSXmVHTFktGXlDx147H.Size = P_1.GetShortSize(result4);
				}
				ai3xtDHyXEfq3el8VjlP.tEXHyj5d92E(yrSXmVHTFktGXlDx147H, P_2.DataScale);
			}
		}
		return list;
	}

	public static List<Symbol> WrjH7kkhJBB(string P_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		ssYpNlHw3KrOKDf74FQk ssYpNlHw3KrOKDf74FQk = JsonConvert.DeserializeObject<ssYpNlHw3KrOKDf74FQk>(P_0, (JsonConverter[])(object)new JsonConverter[1] { (JsonConverter)new StringEnumConverter() });
		if (ssYpNlHw3KrOKDf74FQk == null)
		{
			return null;
		}
		List<lqYKmvHwQwskM6YhKNJh> list = ssYpNlHw3KrOKDf74FQk.Symbols.ToList();
		if (list.Count != 0)
		{
			return list.Select(cP0H71NJOFP).ToList();
		}
		return null;
	}

	private static Symbol cP0H71NJOFP(lqYKmvHwQwskM6YhKNJh P_0)
	{
		double num = 1E-08;
		double sizeStep = 1E-08;
		int num2 = 8;
		double num4 = default(double);
		double minQty = default(double);
		double num3 = default(double);
		ut99iiHw0LgS5saMahZq ut99iiHw0LgS5saMahZq = default(ut99iiHw0LgS5saMahZq);
		Symbol symbol = default(Symbol);
		ut99iiHw0LgS5saMahZq ut99iiHw0LgS5saMahZq2 = default(ut99iiHw0LgS5saMahZq);
		while (true)
		{
			int num5;
			switch (num2)
			{
			case 8:
				num4 = 0.0;
				minQty = 0.0;
				num3 = 0.0;
				ut99iiHw0LgS5saMahZq = P_0.nrjHwhdRoln.FirstOrDefault((ut99iiHw0LgS5saMahZq f) => f.FilterType == (string)uogjR8nwliZuG9TSJ7Ur.hZqy8ANdStPvxQPFnsTj(0x2C8374E4 ^ 0x2C87E1D4));
				num5 = 11;
				goto IL_0005;
			case 1:
				symbol.MinQty = minQty;
				num2 = 13;
				continue;
			default:
				if (ut99iiHw0LgS5saMahZq2 != null)
				{
					sizeStep = (double)osKG8pDU78bN2lAfQUB3(ut99iiHw0LgS5saMahZq2);
					num4 = shJnLsDUw5tPHsfoh2K5(ut99iiHw0LgS5saMahZq2.bIuHwDuVZyH);
					minQty = (double)ut99iiHw0LgS5saMahZq2.MinQty;
					num2 = 7;
					continue;
				}
				break;
			case 5:
				GEs4hMDUuaDTpyOXewVB(symbol, 2);
				symbol.PnlPrecision = 8;
				aHRgoaDUzwUWJuOCXaNi(symbol, P_0.KqcHwODcqpB + (string)JBEJ3XDUPUEmRanLQ5aP(0x315AB1E3 ^ 0x315943C5) + P_0.vp9HwU9Yjkd);
				num5 = 6;
				goto IL_0005;
			case 2:
				ucW1dwDUpeZgpRUfYWG7(symbol, 0);
				symbol.PointValue = 1.0;
				symbol.Step = num;
				symbol.Precision = xJABt8GfQN3bpiGT4k9G.LocGfReqp7D(num);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
				{
					num2 = 3;
				}
				continue;
			case 13:
				oOeNRGDTHaYm5cOkUu94(symbol, num3);
				return symbol;
			case 14:
				xZctyqDU3wbVZAvUHuEs(symbol, yJ7IKbDUABH6VZQ9pCXD(P_0));
				num2 = 12;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num2 = 10;
				}
				continue;
			case 7:
				_ = (double)ut99iiHw0LgS5saMahZq2.PGuHwiGWoPs;
				break;
			case 3:
				symbol.SizeStep = sizeStep;
				num2 = 5;
				continue;
			case 4:
				symbol.IsDeleted = false;
				Q4JoB6DT26aThsyYwOPy(symbol, num4);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
				{
					num2 = 1;
				}
				continue;
			case 12:
				symbol.Exchange = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671199057);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num2 = 2;
				}
				continue;
			case 9:
				symbol.Mapping = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D32C0C3) + (string)u03u2mDU8vLgukgWElyG(P_0) + P_0.vp9HwU9Yjkd + (string)JBEJ3XDUPUEmRanLQ5aP(-839659358 ^ -839900524) + P_0.KqcHwODcqpB + P_0.vp9HwU9Yjkd + (string)JBEJ3XDUPUEmRanLQ5aP(-1127423276 ^ -1127278912);
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num2 = 4;
				}
				continue;
			case 10:
				iwtxlTDUF4o8k6q7Zy23(symbol, P_0.KqcHwODcqpB + P_0.vp9HwU9Yjkd);
				num2 = 14;
				continue;
			case 15:
				num = shJnLsDUw5tPHsfoh2K5(ut99iiHw0LgS5saMahZq.TickSize);
				goto IL_046e;
			case 11:
				if (ut99iiHw0LgS5saMahZq != null)
				{
					num2 = 15;
					continue;
				}
				goto IL_046e;
			case 6:
				{
					kNX6ySDT0biEgKGArXSP(symbol, P_0.KqcHwODcqpB + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D32C6EF) + (string)yJ7IKbDUABH6VZQ9pCXD(P_0));
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
					{
						num2 = 8;
					}
					continue;
				}
				IL_046e:
				ut99iiHw0LgS5saMahZq2 = P_0.nrjHwhdRoln.FirstOrDefault((ut99iiHw0LgS5saMahZq f) => (string)uogjR8nwliZuG9TSJ7Ur.d6JOP0NdxxnPe4UoHUeR(f) == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1C6D2E));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num2 = 0;
				}
				continue;
				IL_0005:
				num2 = num5;
				continue;
			}
			ut99iiHw0LgS5saMahZq ut99iiHw0LgS5saMahZq3 = P_0.nrjHwhdRoln.FirstOrDefault((ut99iiHw0LgS5saMahZq f) => uogjR8nwliZuG9TSJ7Ur.QjAea0NdLDBL7ouF4dp1(uogjR8nwliZuG9TSJ7Ur.d6JOP0NdxxnPe4UoHUeR(f), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306643256)));
			if (ut99iiHw0LgS5saMahZq3 != null)
			{
				num3 = (double)ut99iiHw0LgS5saMahZq3.oiDHwkGIY27;
			}
			ut99iiHw0LgS5saMahZq ut99iiHw0LgS5saMahZq4 = P_0.nrjHwhdRoln.FirstOrDefault((ut99iiHw0LgS5saMahZq f) => uogjR8nwliZuG9TSJ7Ur.QjAea0NdLDBL7ouF4dp1(f.FilterType, uogjR8nwliZuG9TSJ7Ur.hZqy8ANdStPvxQPFnsTj(0x42D899B5 ^ 0x42DC0CC1)));
			if (ut99iiHw0LgS5saMahZq4 != null)
			{
				_ = (double)ut99iiHw0LgS5saMahZq4.PGuHwiGWoPs;
			}
			symbol = new Symbol((string)ggCRExDUJrAyKrw6gtHM(u03u2mDU8vLgukgWElyG(P_0), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x4662DBFF), yJ7IKbDUABH6VZQ9pCXD(P_0), JBEJ3XDUPUEmRanLQ5aP(0x7F55E538 ^ 0x7F5616CE)), SymbolType.Crypto);
			num2 = 10;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
			{
				num2 = 3;
			}
		}
	}

	protected OQGi2yH74OpVYrJSJVVS()
	{
		CHxZRMDTfycqGtYqpjQv();
		base._002Ector();
	}

	static OQGi2yH74OpVYrJSJVVS()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static double shJnLsDUw5tPHsfoh2K5(decimal P_0)
	{
		return (double)P_0;
	}

	internal static decimal osKG8pDU78bN2lAfQUB3(object P_0)
	{
		return ((ut99iiHw0LgS5saMahZq)P_0).bIuHwDuVZyH;
	}

	internal static object u03u2mDU8vLgukgWElyG(object P_0)
	{
		return ((lqYKmvHwQwskM6YhKNJh)P_0).KqcHwODcqpB;
	}

	internal static object yJ7IKbDUABH6VZQ9pCXD(object P_0)
	{
		return ((lqYKmvHwQwskM6YhKNJh)P_0).vp9HwU9Yjkd;
	}

	internal static object JBEJ3XDUPUEmRanLQ5aP(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object ggCRExDUJrAyKrw6gtHM(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static void iwtxlTDUF4o8k6q7Zy23(object P_0, object P_1)
	{
		((Symbol)P_0).Code = (string)P_1;
	}

	internal static void xZctyqDU3wbVZAvUHuEs(object P_0, object P_1)
	{
		((Symbol)P_0).Currency = (string)P_1;
	}

	internal static void ucW1dwDUpeZgpRUfYWG7(object P_0, int P_1)
	{
		((Symbol)P_0).LotSize = P_1;
	}

	internal static void GEs4hMDUuaDTpyOXewVB(object P_0, int P_1)
	{
		((Symbol)P_0).SizePrecision = P_1;
	}

	internal static void aHRgoaDUzwUWJuOCXaNi(object P_0, object P_1)
	{
		((Symbol)P_0).Name = (string)P_1;
	}

	internal static void kNX6ySDT0biEgKGArXSP(object P_0, object P_1)
	{
		((Symbol)P_0).Description = (string)P_1;
	}

	internal static void Q4JoB6DT26aThsyYwOPy(object P_0, double P_1)
	{
		((Symbol)P_0).LotStep = P_1;
	}

	internal static void oOeNRGDTHaYm5cOkUu94(object P_0, double P_1)
	{
		((Symbol)P_0).MinNotional = P_1;
	}

	internal static bool Gr8HRSDUmIUiOpchgwaq()
	{
		return jBLPAEDUKfXMPFNRJFTq == null;
	}

	internal static OQGi2yH74OpVYrJSJVVS Dsa0PsDUhaWQFuwkdjKD()
	{
		return jBLPAEDUKfXMPFNRJFTq;
	}

	internal static void CHxZRMDTfycqGtYqpjQv()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
