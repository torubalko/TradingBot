using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace l0dmE0fn4kXfTKZRt2cL;

[DataContract(Name = "DealsCollection", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Deals")]
internal sealed class c9iN9HfnlOpMpBvAIIM1 : ICloneable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class YpjDj1n7L7o8HfbtndL0
	{
		public static readonly YpjDj1n7L7o8HfbtndL0 OW6n7EOB850;

		public static Func<UserDeal, DateTime> B6En7QjKqmq;

		public static Func<UserDeal, UserDeal> Fi9n7dyXVOg;

		public static Func<KeyValuePair<string, List<UserDeal>>, string> GX6n7gNeQV0;

		public static Func<UserDeal, UserDeal> ge1n7REa3gg;

		public static Func<KeyValuePair<string, List<UserDeal>>, List<UserDeal>> kaAn76IIPkv;

		internal static YpjDj1n7L7o8HfbtndL0 HuqkXDNgXJqZO3WHIMew;

		static YpjDj1n7L7o8HfbtndL0()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			OW6n7EOB850 = new YpjDj1n7L7o8HfbtndL0();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public YpjDj1n7L7o8HfbtndL0()
		{
			lI3sEyNgEnVexxH1w6vu();
			base._002Ector();
		}

		internal DateTime jmwn7e0t0sS(UserDeal d)
		{
			return d.CloseTime;
		}

		internal UserDeal yS0n7sJt94j(UserDeal key)
		{
			return (UserDeal)key.Clone();
		}

		internal string XCQn7X1b8Dm(KeyValuePair<string, List<UserDeal>> key)
		{
			return key.Key;
		}

		internal List<UserDeal> k0yn7c6ZuxS(KeyValuePair<string, List<UserDeal>> value)
		{
			return new List<UserDeal>(value.Value.Select((UserDeal d) => (UserDeal)d.Clone()));
		}

		internal UserDeal Wein7jEaYiw(UserDeal d)
		{
			return (UserDeal)d.Clone();
		}

		internal static bool dXOMfANgccGiFrVhhwnn()
		{
			return HuqkXDNgXJqZO3WHIMew == null;
		}

		internal static YpjDj1n7L7o8HfbtndL0 uKCvNgNgj2aN4eZF6A3I()
		{
			return HuqkXDNgXJqZO3WHIMew;
		}

		internal static void lI3sEyNgEnVexxH1w6vu()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}
	}

	[CompilerGenerated]
	private sealed class ifiFBln7MUvCPBQjxYHc
	{
		public string ddKn7qoikNk;

		internal static ifiFBln7MUvCPBQjxYHc GvA9EkNgQbVCjP2L9ytg;

		public ifiFBln7MUvCPBQjxYHc()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool cv0n7OGkEty(UserDeal d)
		{
			return (string)rjGxntNgRV8795iq29Eu(d) == ddKn7qoikNk;
		}

		static ifiFBln7MUvCPBQjxYHc()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool arpSvCNgdhrFAR1Zqal6()
		{
			return GvA9EkNgQbVCjP2L9ytg == null;
		}

		internal static ifiFBln7MUvCPBQjxYHc pjhS4DNggZiLQtMatTYn()
		{
			return GvA9EkNgQbVCjP2L9ytg;
		}

		internal static object rjGxntNgRV8795iq29Eu(object P_0)
		{
			return ((UserDeal)P_0).DealID;
		}
	}

	[CompilerGenerated]
	private sealed class PSVw9An7IovDPyGlaIAK
	{
		public string NoEn7tcjO4o;

		public string WKSn7UI6AXd;

		internal static PSVw9An7IovDPyGlaIAK uqBR7INg6AC7QUF2W0C9;

		public PSVw9An7IovDPyGlaIAK()
		{
			gxmYehNgqaJQHOWHAm4v();
			base._002Ector();
		}

		internal bool twTn7WlGjfB(UserDeal d)
		{
			if ((string)Kb5tbGNgIflglQtD6a7w(d) == NoEn7tcjO4o)
			{
				return pYiqJcNgtMVOL5ilgyAL(J5akUfNgWtcGk7etiDox(d), WKSn7UI6AXd);
			}
			return false;
		}

		static PSVw9An7IovDPyGlaIAK()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void gxmYehNgqaJQHOWHAm4v()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool tkL7JjNgM5JgXqS3NgI4()
		{
			return uqBR7INg6AC7QUF2W0C9 == null;
		}

		internal static PSVw9An7IovDPyGlaIAK BogrwYNgO7X6uLiODQdm()
		{
			return uqBR7INg6AC7QUF2W0C9;
		}

		internal static object Kb5tbGNgIflglQtD6a7w(object P_0)
		{
			return ((UserDeal)P_0).AccountID;
		}

		internal static object J5akUfNgWtcGk7etiDox(object P_0)
		{
			return ((UserDeal)P_0).SymbolID;
		}

		internal static bool pYiqJcNgtMVOL5ilgyAL(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}
	}

	private List<UserDeal> JVBfnQGO9LJ;

	private Dictionary<string, List<UserDeal>> DpOfndTiWfd;

	private bool wptfngN7tdG;

	private static c9iN9HfnlOpMpBvAIIM1 FYBN6IDC5h12mvwC4AO7;

	[DataMember(Name = "Deals")]
	public List<UserDeal> Deals
	{
		get
		{
			return JVBfnQGO9LJ ?? (JVBfnQGO9LJ = new List<UserDeal>());
		}
		set
		{
			JVBfnQGO9LJ = jVBfnQGO9LJ;
		}
	}

	[SpecialName]
	private Dictionary<string, List<UserDeal>> egwfnc9DMHp()
	{
		return DpOfndTiWfd ?? (DpOfndTiWfd = new Dictionary<string, List<UserDeal>>());
	}

	[SpecialName]
	private void bp5fnjmgcUV(Dictionary<string, List<UserDeal>> P_0)
	{
		DpOfndTiWfd = P_0;
	}

	public void q61fnD71YtO()
	{
		List<UserDeal> list = Deals.OrderBy((UserDeal d) => d.CloseTime).ToList();
		r9pDh1DCL1CIfBByp4XI(Deals);
		foreach (UserDeal item in list)
		{
			Deals.Add(item);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
	}

	public void J9rfnbpVNYJ()
	{
		SRZoYLDCeS8w7WOQqxhq(egwfnc9DMHp());
		List<UserDeal> list = Deals.ToList();
		bp5fnjmgcUV(new Dictionary<string, List<UserDeal>>());
		using List<UserDeal>.Enumerator enumerator = list.GetEnumerator();
		Symbol symbol = default(Symbol);
		while (enumerator.MoveNext())
		{
			while (true)
			{
				UserDeal current = enumerator.Current;
				int num = 2;
				while (true)
				{
					switch (num)
					{
					case 3:
						if (symbol == null)
						{
							goto end_IL_00bb;
						}
						goto default;
					default:
						if (JHuZFiDCXjVxImSMyCP3(current).Date == TimeHelper.GetCurrDate(symbol.Exchange))
						{
							t3mfnkq3Vux(current);
						}
						goto end_IL_00bb;
					case 2:
						symbol = SymbolManager.Get((string)cwivqbDCsiREdc53BG53(current));
						num = 3;
						continue;
					case 1:
						break;
					}
					break;
				}
				continue;
				end_IL_00bb:
				break;
			}
		}
	}

	public bool FppfnNK7El6(UserDeal P_0)
	{
		if (QU6fn1W8eWY((string)g9tDv1DCcptTeAqkRwgV(P_0)) == null)
		{
			Deals.Add(P_0);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				t3mfnkq3Vux(P_0);
				return true;
			}
		}
		return false;
	}

	private void t3mfnkq3Vux(UserDeal P_0)
	{
		string key = bHbfnLsb9qU(P_0);
		if (!egwfnc9DMHp().ContainsKey(key))
		{
			egwfnc9DMHp().Add(key, new List<UserDeal>());
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		egwfnc9DMHp()[key].Add(P_0);
	}

	public void Delete(List<string> ids)
	{
		HashSet<string> hashSet = new HashSet<string>(ids);
		List<UserDeal> list = Deals.ToList();
		Deals.Clear();
		foreach (UserDeal item in list)
		{
			if (!hashSet.Contains(item.DealID))
			{
				Deals.Add(item);
			}
		}
		wptfngN7tdG = false;
	}

	public void Clear()
	{
		Deals.Clear();
	}

	public UserDeal QU6fn1W8eWY(string P_0)
	{
		ifiFBln7MUvCPBQjxYHc CS_0024_003C_003E8__locals2 = new ifiFBln7MUvCPBQjxYHc();
		CS_0024_003C_003E8__locals2.ddKn7qoikNk = P_0;
		return Deals.FirstOrDefault((UserDeal d) => (string)ifiFBln7MUvCPBQjxYHc.rjGxntNgRV8795iq29Eu(d) == CS_0024_003C_003E8__locals2.ddKn7qoikNk);
	}

	public List<UserDeal> dhMfn5nChPU()
	{
		return Deals.ToList();
	}

	public List<UserDeal> nk9fnSY6bNi(string P_0, string P_1)
	{
		PSVw9An7IovDPyGlaIAK CS_0024_003C_003E8__locals4 = new PSVw9An7IovDPyGlaIAK();
		CS_0024_003C_003E8__locals4.NoEn7tcjO4o = P_1;
		CS_0024_003C_003E8__locals4.WKSn7UI6AXd = P_0;
		return Deals.Where((UserDeal d) => (string)PSVw9An7IovDPyGlaIAK.Kb5tbGNgIflglQtD6a7w(d) == CS_0024_003C_003E8__locals4.NoEn7tcjO4o && PSVw9An7IovDPyGlaIAK.pYiqJcNgtMVOL5ilgyAL(PSVw9An7IovDPyGlaIAK.J5akUfNgWtcGk7etiDox(d), CS_0024_003C_003E8__locals4.WKSn7UI6AXd)).ToList();
	}

	public List<UserDeal> OBJfnxSSOXQ(string P_0, string P_1)
	{
		if (!wptfngN7tdG)
		{
			J9rfnbpVNYJ();
			wptfngN7tdG = true;
		}
		string key = VwhfnemSVjs(P_0, P_1);
		if (!egwfnc9DMHp().ContainsKey(key))
		{
			return new List<UserDeal>();
		}
		return egwfnc9DMHp()[key].ToList();
	}

	private static string bHbfnLsb9qU(UserDeal P_0)
	{
		return P_0.SymbolID + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056700976) + (string)GsJITGDCjJBxgJoKwwD8(P_0);
	}

	private static string VwhfnemSVjs(string P_0, string P_1)
	{
		return P_0 + (string)m08G4EDCEmx4vkcXJLPv(-673683647 ^ -673691119) + P_1;
	}

	public object Clone()
	{
		return new c9iN9HfnlOpMpBvAIIM1
		{
			JVBfnQGO9LJ = new List<UserDeal>(JVBfnQGO9LJ.Select((UserDeal key) => (UserDeal)key.Clone())),
			DpOfndTiWfd = DpOfndTiWfd?.ToDictionary((KeyValuePair<string, List<UserDeal>> key) => key.Key, (KeyValuePair<string, List<UserDeal>> value) => new List<UserDeal>(value.Value.Select((UserDeal d) => (UserDeal)d.Clone())))
		};
	}

	public c9iN9HfnlOpMpBvAIIM1()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static c9iN9HfnlOpMpBvAIIM1()
	{
		gfREsbDCQhV8tmqQA6DN();
	}

	internal static void r9pDh1DCL1CIfBByp4XI(object P_0)
	{
		((List<UserDeal>)P_0).Clear();
	}

	internal static bool DnVs2LDCSIxFVN6VkIWu()
	{
		return FYBN6IDC5h12mvwC4AO7 == null;
	}

	internal static c9iN9HfnlOpMpBvAIIM1 wH6PfmDCxqDMldoTguIF()
	{
		return FYBN6IDC5h12mvwC4AO7;
	}

	internal static void SRZoYLDCeS8w7WOQqxhq(object P_0)
	{
		((Dictionary<string, List<UserDeal>>)P_0).Clear();
	}

	internal static object cwivqbDCsiREdc53BG53(object P_0)
	{
		return ((UserDeal)P_0).SymbolID;
	}

	internal static DateTime JHuZFiDCXjVxImSMyCP3(object P_0)
	{
		return ((UserDeal)P_0).LocalTime;
	}

	internal static object g9tDv1DCcptTeAqkRwgV(object P_0)
	{
		return ((UserDeal)P_0).DealID;
	}

	internal static object GsJITGDCjJBxgJoKwwD8(object P_0)
	{
		return ((UserDeal)P_0).AccountID;
	}

	internal static object m08G4EDCEmx4vkcXJLPv(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void gfREsbDCQhV8tmqQA6DN()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
