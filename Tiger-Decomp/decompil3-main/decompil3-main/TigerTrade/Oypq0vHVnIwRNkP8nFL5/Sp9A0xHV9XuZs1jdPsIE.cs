using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using rZJ1jSHVvieeKc4mQ1J0;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;

namespace Oypq0vHVnIwRNkP8nFL5;

internal abstract class Sp9A0xHV9XuZs1jdPsIE
{
	[CompilerGenerated]
	private sealed class e4rJhEnwncFBcUFHov44
	{
		public DateTime xQPnwYEqxOH;

		public Symbol wWXnwowS1k6;

		private static e4rJhEnwncFBcUFHov44 Odg3TYNdHbQlGLe9pphM;

		public e4rJhEnwncFBcUFHov44()
		{
			QdnRXuNdnUYZaTKWdOhX();
			base._002Ector();
		}

		internal dKSpGiHyaUa6LiEfhK5I EgbnwGwVAVM(Bn9oOWHVokuMSOERvS3h kline)
		{
			return new dKSpGiHyaUa6LiEfhK5I(xQPnwYEqxOH.AddSeconds(jnfXexNdGeD9AAIDFGa8(kline)))
			{
				Close = wWXnwowS1k6.GetShortPrice(TiKg2UNdYqF9MpAhMaEu(kline)),
				jdxHybNY54C = GZSyWmNdo5Rbqrp6q20F(wWXnwowS1k6, kline.High),
				sW6HyNmJLUK = GZSyWmNdo5Rbqrp6q20F(wWXnwowS1k6, BhtNFWNdvICp1l12lNuD(kline)),
				C7PHyDjhF2K = GZSyWmNdo5Rbqrp6q20F(wWXnwowS1k6, C9SfUpNdBS2lO59LaT0D(kline)),
				Volume = wWXnwowS1k6.GetShortSize(thVUfHNdaLhewp16vjyu(kline))
			};
		}

		static e4rJhEnwncFBcUFHov44()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void QdnRXuNdnUYZaTKWdOhX()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool gIH5lUNdfcSrEGNvtuqH()
		{
			return Odg3TYNdHbQlGLe9pphM == null;
		}

		internal static e4rJhEnwncFBcUFHov44 YfSq9tNd9Pm7MAZFbhgR()
		{
			return Odg3TYNdHbQlGLe9pphM;
		}

		internal static double jnfXexNdGeD9AAIDFGa8(object P_0)
		{
			return ((Bn9oOWHVokuMSOERvS3h)P_0).tbbHViF5BjC;
		}

		internal static double TiKg2UNdYqF9MpAhMaEu(object P_0)
		{
			return ((Bn9oOWHVokuMSOERvS3h)P_0).Close;
		}

		internal static long GZSyWmNdo5Rbqrp6q20F(object P_0, double P_1)
		{
			return ((Symbol)P_0).GetShortPrice(P_1);
		}

		internal static double BhtNFWNdvICp1l12lNuD(object P_0)
		{
			return ((Bn9oOWHVokuMSOERvS3h)P_0).Low;
		}

		internal static double C9SfUpNdBS2lO59LaT0D(object P_0)
		{
			return ((Bn9oOWHVokuMSOERvS3h)P_0).K8gHV1ZbJql;
		}

		internal static long thVUfHNdaLhewp16vjyu(object P_0)
		{
			return ((Bn9oOWHVokuMSOERvS3h)P_0).Volume;
		}
	}

	private static Sp9A0xHV9XuZs1jdPsIE EyGKMBDI73fUmt0AZK8E;

	public static List<dKSpGiHyaUa6LiEfhK5I> XwSHVG385OJ(string P_0, Symbol P_1)
	{
		List<dKSpGiHyaUa6LiEfhK5I> list = new List<dKSpGiHyaUa6LiEfhK5I>();
		JArray obj = JArray.Parse(P_0);
		DateTime dateTime = new DateTime(1970, 1, 1);
		foreach (JToken item in obj)
		{
			if (long.TryParse(((object)item[(object)0])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
			{
				dKSpGiHyaUa6LiEfhK5I dKSpGiHyaUa6LiEfhK5I = new dKSpGiHyaUa6LiEfhK5I(dateTime.AddSeconds(result));
				if (double.TryParse(((object)item[(object)2])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result2))
				{
					dKSpGiHyaUa6LiEfhK5I.Close = P_1.GetShortPrice(result2);
				}
				if (double.TryParse(((object)item[(object)3])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result3))
				{
					dKSpGiHyaUa6LiEfhK5I.jdxHybNY54C = P_1.GetShortPrice(result3);
				}
				if (double.TryParse(((object)item[(object)4])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result4))
				{
					dKSpGiHyaUa6LiEfhK5I.sW6HyNmJLUK = P_1.GetShortPrice(result4);
				}
				if (double.TryParse(((object)item[(object)5])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result5))
				{
					dKSpGiHyaUa6LiEfhK5I.C7PHyDjhF2K = P_1.GetShortPrice(result5);
				}
				if (double.TryParse(((object)item[(object)6])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result6))
				{
					dKSpGiHyaUa6LiEfhK5I.Volume = P_1.GetShortSize(result6);
				}
				list.Add(dKSpGiHyaUa6LiEfhK5I);
			}
		}
		return list;
	}

	public static List<dKSpGiHyaUa6LiEfhK5I> ibeHVYl3TNA(string P_0, Symbol P_1)
	{
		e4rJhEnwncFBcUFHov44 CS_0024_003C_003E8__locals8 = new e4rJhEnwncFBcUFHov44();
		CS_0024_003C_003E8__locals8.wWXnwowS1k6 = P_1;
		List<Bn9oOWHVokuMSOERvS3h> source = JsonConvert.DeserializeObject<List<Bn9oOWHVokuMSOERvS3h>>(P_0);
		CS_0024_003C_003E8__locals8.xQPnwYEqxOH = new DateTime(1970, 1, 1);
		return source.Select((Bn9oOWHVokuMSOERvS3h kline) => new dKSpGiHyaUa6LiEfhK5I(CS_0024_003C_003E8__locals8.xQPnwYEqxOH.AddSeconds(e4rJhEnwncFBcUFHov44.jnfXexNdGeD9AAIDFGa8(kline)))
		{
			Close = CS_0024_003C_003E8__locals8.wWXnwowS1k6.GetShortPrice(e4rJhEnwncFBcUFHov44.TiKg2UNdYqF9MpAhMaEu(kline)),
			jdxHybNY54C = e4rJhEnwncFBcUFHov44.GZSyWmNdo5Rbqrp6q20F(CS_0024_003C_003E8__locals8.wWXnwowS1k6, kline.High),
			sW6HyNmJLUK = e4rJhEnwncFBcUFHov44.GZSyWmNdo5Rbqrp6q20F(CS_0024_003C_003E8__locals8.wWXnwowS1k6, e4rJhEnwncFBcUFHov44.BhtNFWNdvICp1l12lNuD(kline)),
			C7PHyDjhF2K = e4rJhEnwncFBcUFHov44.GZSyWmNdo5Rbqrp6q20F(CS_0024_003C_003E8__locals8.wWXnwowS1k6, e4rJhEnwncFBcUFHov44.C9SfUpNdBS2lO59LaT0D(kline)),
			Volume = CS_0024_003C_003E8__locals8.wWXnwowS1k6.GetShortSize(e4rJhEnwncFBcUFHov44.thVUfHNdaLhewp16vjyu(kline))
		}).ToList();
	}

	protected Sp9A0xHV9XuZs1jdPsIE()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static Sp9A0xHV9XuZs1jdPsIE()
	{
		frpOpNDIPwAw89Y9ijnf();
	}

	internal static bool B6tH2jDI8P5yTrAESiHe()
	{
		return EyGKMBDI73fUmt0AZK8E == null;
	}

	internal static Sp9A0xHV9XuZs1jdPsIE Ci3YLkDIAbKVbAkfXVaj()
	{
		return EyGKMBDI73fUmt0AZK8E;
	}

	internal static void frpOpNDIPwAw89Y9ijnf()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
