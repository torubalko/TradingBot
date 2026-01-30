using System.Collections.Generic;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using oqVxNv9MH2vMJDNIliMK;
using TuAMtrl1Nd3XoZQQUXf0;

namespace bSVKll9Mit7D0U2Emymx;

[DataContract(Name = "ChartObjectStyles", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Objects.Styles.Storage")]
internal sealed class I1mSCq9Ma7wofTE6aZap
{
	private Dictionary<string, e5SqZY9M26McMQ8MZ8ZX> bJg9MNm5RGY;

	private static I1mSCq9Ma7wofTE6aZap zuelRfbR0wumhBHB6uiC;

	[DataMember(Name = "StylesList")]
	public Dictionary<string, e5SqZY9M26McMQ8MZ8ZX> Styles
	{
		get
		{
			return bJg9MNm5RGY ?? (bJg9MNm5RGY = new Dictionary<string, e5SqZY9M26McMQ8MZ8ZX>());
		}
		set
		{
			bJg9MNm5RGY = dictionary;
		}
	}

	public I1mSCq9Ma7wofTE6aZap()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Styles = new Dictionary<string, e5SqZY9M26McMQ8MZ8ZX>();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void MTv9MlfSETH(e5SqZY9M26McMQ8MZ8ZX P_0)
	{
		if (Styles.ContainsKey(P_0.lp39MnRPdQp))
		{
			Styles.Remove(P_0.lp39MnRPdQp);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		Styles.Add(P_0.lp39MnRPdQp, P_0);
	}

	public e5SqZY9M26McMQ8MZ8ZX hKo9M4wnsSo(string P_0)
	{
		if (!Styles.ContainsKey(P_0))
		{
			return null;
		}
		return Styles[P_0];
	}

	public void Remove(string id)
	{
		if (Styles.ContainsKey(id))
		{
			Styles.Remove(id);
		}
	}

	static I1mSCq9Ma7wofTE6aZap()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool nEskZpbR21v7Jhg1mG7Z()
	{
		return zuelRfbR0wumhBHB6uiC == null;
	}

	internal static I1mSCq9Ma7wofTE6aZap ut052FbRHiiySh9l9b1A()
	{
		return zuelRfbR0wumhBHB6uiC;
	}
}
