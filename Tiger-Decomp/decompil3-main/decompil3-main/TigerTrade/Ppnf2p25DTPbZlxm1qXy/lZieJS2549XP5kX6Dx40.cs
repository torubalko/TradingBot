using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using JOmqgw25sgFDZPPRciRT;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace Ppnf2p25DTPbZlxm1qXy;

[DataContract]
internal sealed class lZieJS2549XP5kX6Dx40
{
	[CompilerGenerated]
	private string at125xkr0To;

	[CompilerGenerated]
	private List<nkG8KR25eJkKfVv2jXpe> DM325LJfQ3M;

	private static lZieJS2549XP5kX6Dx40 Ud8J0P4ZZihbTVwsuMsB;

	[DataMember]
	public string Title
	{
		[CompilerGenerated]
		get
		{
			return at125xkr0To;
		}
		[CompilerGenerated]
		set
		{
			at125xkr0To = text;
		}
	}

	[DataMember]
	public List<nkG8KR25eJkKfVv2jXpe> Items
	{
		[CompilerGenerated]
		get
		{
			return DM325LJfQ3M;
		}
		[CompilerGenerated]
		set
		{
			DM325LJfQ3M = dM325LJfQ3M;
		}
	}

	public static lZieJS2549XP5kX6Dx40 D2o25bcbE1U(string P_0, IEnumerable<Symbol> P_1)
	{
		lZieJS2549XP5kX6Dx40 lZieJS2549XP5kX6Dx41 = new lZieJS2549XP5kX6Dx40
		{
			Title = (string.IsNullOrWhiteSpace(P_0) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087060406) : (P_0 + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C75AF6)))
		};
		foreach (Symbol item2 in P_1 ?? Enumerable.Empty<Symbol>())
		{
			nkG8KR25eJkKfVv2jXpe item = new nkG8KR25eJkKfVv2jXpe
			{
				Exchange = item2.Exchange,
				NNn25QAsByo = Guid.NewGuid().ToString(),
				sNO25Ru2LU0 = Guid.NewGuid().ToString(),
				zlH25OSMbJB = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53745178) + C4J25N2WnTl(item2.Exchange),
				OOT25WpJeRy = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123774998) + C4J25N2WnTl(item2.Exchange)
			};
			lZieJS2549XP5kX6Dx41.Items.Add(item);
		}
		return lZieJS2549XP5kX6Dx41;
	}

	private static string C4J25N2WnTl(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return string.Empty;
		}
		return ((string)moQpuL4ZKjPjDhaq9Qdb(P_0.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624746107), (string)RWTntX4Zrel71ijKQ7Gn(0x3E0426F0 ^ 0x3E040BA0)), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736558278), RWTntX4Zrel71ijKQ7Gn(0x2CBEEA31 ^ 0x2CBEC761))).Replace((string)RWTntX4Zrel71ijKQ7Gn(-894902996 ^ -894896956), (string)RWTntX4Zrel71ijKQ7Gn(-2108526692 ^ -2108538164));
	}

	public lZieJS2549XP5kX6Dx40()
	{
		CNSeCo4ZmnGy5EaWxgVx();
		DM325LJfQ3M = new List<nkG8KR25eJkKfVv2jXpe>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static lZieJS2549XP5kX6Dx40()
	{
		s92VZk4Zh8hiugtigjoh();
	}

	internal static bool QFYt274ZVPWrea32Fg2d()
	{
		return Ud8J0P4ZZihbTVwsuMsB == null;
	}

	internal static lZieJS2549XP5kX6Dx40 WpsEuU4ZCl3puPVqPpiW()
	{
		return Ud8J0P4ZZihbTVwsuMsB;
	}

	internal static object RWTntX4Zrel71ijKQ7Gn(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object moQpuL4ZKjPjDhaq9Qdb(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void CNSeCo4ZmnGy5EaWxgVx()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void s92VZk4Zh8hiugtigjoh()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
