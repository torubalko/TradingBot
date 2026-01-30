using System.Collections.Generic;
using CdHxygH7MCxS7CTLXABU;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;

namespace daLuqQH8sEj67vJa8Te2;

internal class DvfnBVH8eubTcdroQPLm
{
	private static DvfnBVH8eubTcdroQPLm pFwweaDTSGddnSNN70o2;

	public static List<dKSpGiHyaUa6LiEfhK5I> Kr0H8XlI28L(string P_0, Symbol P_1)
	{
		List<dKSpGiHyaUa6LiEfhK5I> list = new List<dKSpGiHyaUa6LiEfhK5I>();
		mVdvnaH766nmhc5B1RDM[] array = JsonConvert.DeserializeObject<mVdvnaH766nmhc5B1RDM[]>(P_0);
		foreach (mVdvnaH766nmhc5B1RDM mVdvnaH766nmhc5B1RDM in array)
		{
			dKSpGiHyaUa6LiEfhK5I item = new dKSpGiHyaUa6LiEfhK5I(mVdvnaH766nmhc5B1RDM.GIaH7I2yL4r.DateTime)
			{
				C7PHyDjhF2K = P_1.GetShortPrice((double)mVdvnaH766nmhc5B1RDM.OWrH7ZGhG1m),
				jdxHybNY54C = P_1.GetShortPrice((double)mVdvnaH766nmhc5B1RDM.High),
				sW6HyNmJLUK = P_1.GetShortPrice((double)mVdvnaH766nmhc5B1RDM.Low),
				Close = P_1.GetShortPrice((double)mVdvnaH766nmhc5B1RDM.Close),
				Volume = P_1.GetShortSize((double)mVdvnaH766nmhc5B1RDM.Volume)
			};
			list.Add(item);
		}
		return list;
	}

	public DvfnBVH8eubTcdroQPLm()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static DvfnBVH8eubTcdroQPLm()
	{
		gDRPxCDTencOOUyCMHNt();
	}

	internal static bool bmQNUGDTxty5kbng1Hje()
	{
		return pFwweaDTSGddnSNN70o2 == null;
	}

	internal static DvfnBVH8eubTcdroQPLm m7Qb15DTLkmQhGCd1ACP()
	{
		return pFwweaDTSGddnSNN70o2;
	}

	internal static void gDRPxCDTencOOUyCMHNt()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
