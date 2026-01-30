using System.Collections.Generic;
using ECOEgqlSad8NUJZ2Dr9n;
using ROhuQx9FcGTLTqPCaJ0j;
using TigerTrade.Chart.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace NuPa6W98cGB9JwL625T8;

internal sealed class qwaYy998Xc1aqZXaxjgb : IChartMarketDepth
{
	private readonly daEwNq9FXerRxid1xGMa uPN98j51QTI;

	private readonly decimal fes98EnF6Ul;

	private readonly decimal qFW98QxvMaD;

	private Dictionary<decimal, decimal> A6298d869IE;

	private Dictionary<decimal, decimal> beQ98gLwbcL;

	internal static qwaYy998Xc1aqZXaxjgb dgKid8brHZptaa2AJxEF;

	public decimal MaxAskPrice => (decimal)uPN98j51QTI.MaxAskPrice * fes98EnF6Ul;

	public decimal MinAskPrice => (decimal)uPN98j51QTI.MinAskPrice * fes98EnF6Ul;

	public decimal MaxBidPrice => (decimal)s9yHMybrG0g9ZGBfxZsN(uPN98j51QTI) * fes98EnF6Ul;

	public decimal MinBidPrice => (decimal)uPN98j51QTI.MinBidPrice * fes98EnF6Ul;

	public decimal MaxSize => m66mMpbrYtE1GrulMBr7(uPN98j51QTI.MaxSize) * qFW98QxvMaD;

	public IReadOnlyDictionary<decimal, decimal> AskQuotes
	{
		get
		{
			if (A6298d869IE == null)
			{
				A6298d869IE = new Dictionary<decimal, decimal>(uPN98j51QTI.AskQuotes.Count);
				foreach (KeyValuePair<long, (long, long)> askQuote in uPN98j51QTI.AskQuotes)
				{
					A6298d869IE.Add((decimal)askQuote.Key * fes98EnF6Ul, (decimal)askQuote.Value.Item1 * qFW98QxvMaD);
				}
			}
			return A6298d869IE;
		}
	}

	public IReadOnlyDictionary<decimal, decimal> BidQuotes
	{
		get
		{
			if (beQ98gLwbcL == null)
			{
				beQ98gLwbcL = new Dictionary<decimal, decimal>(uPN98j51QTI.BidQuotes.Count);
				foreach (KeyValuePair<long, (long, long)> bidQuote in uPN98j51QTI.BidQuotes)
				{
					beQ98gLwbcL.Add((decimal)bidQuote.Key * fes98EnF6Ul, (decimal)bidQuote.Value.Item1 * qFW98QxvMaD);
				}
			}
			return beQ98gLwbcL;
		}
	}

	public qwaYy998Xc1aqZXaxjgb(daEwNq9FXerRxid1xGMa P_0, decimal P_1, decimal P_2)
	{
		D8MXOvbrntSvhRKuwhU6();
		base._002Ector();
		uPN98j51QTI = P_0;
		fes98EnF6Ul = P_1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			qFW98QxvMaD = P_2;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
			{
				num = 1;
			}
		}
	}

	static qwaYy998Xc1aqZXaxjgb()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void D8MXOvbrntSvhRKuwhU6()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool zgcTu8brfwGMrPMFwhFf()
	{
		return dgKid8brHZptaa2AJxEF == null;
	}

	internal static qwaYy998Xc1aqZXaxjgb FSUu8Zbr9syhn6GTB0yx()
	{
		return dgKid8brHZptaa2AJxEF;
	}

	internal static long s9yHMybrG0g9ZGBfxZsN(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).MaxBidPrice;
	}

	internal static decimal m66mMpbrYtE1GrulMBr7(long P_0)
	{
		return P_0;
	}
}
