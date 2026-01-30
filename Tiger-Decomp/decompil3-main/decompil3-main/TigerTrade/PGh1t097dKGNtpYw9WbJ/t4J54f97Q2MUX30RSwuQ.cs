using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ECOEgqlSad8NUJZ2Dr9n;
using Gw4lH797Nqi7S3NF78x1;
using Io0TBCnnT6SonDXm9K0y;
using k2djPS9h3aXysXOe0uK1;
using QmOgjd9h4C152q15GnsF;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using wfgqtU9htHKSCYqG2l2W;

namespace PGh1t097dKGNtpYw9WbJ;

internal sealed class t4J54f97Q2MUX30RSwuQ
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct PTHOPQG0NOhA4Cf5KyJr
	{
		public long WcqG0kHk3Ld;

		public Side XifG01EuQ1W;

		public long yIWG05PJVFB;

		public Side JlTG0SOWsP2;
	}

	[CompilerGenerated]
	private int Sb99788gKd8;

	[CompilerGenerated]
	private readonly CoPfjK9hF3ASs5TbM8OK T9A97AYHg8Y;

	private readonly Dictionary<long, I0xHaV9hWE00eUtcW1Zm> WiO97PfIblR;

	private readonly Dictionary<long, I0xHaV9hWE00eUtcW1Zm> vDd97J9Haw0;

	private readonly Dictionary<long, I0xHaV9hWE00eUtcW1Zm> jVJ97FfFwwS;

	private readonly Dictionary<string, cLhcml97bc8jKEraVPl0> HXR973Q9QCs;

	private readonly List<IhHpoC9hliGX2eZqQA6k> rhc97piYNHE;

	private static t4J54f97Q2MUX30RSwuQ HWEAALbVVRDBFGAmEKXD;

	public int PriceScale
	{
		[CompilerGenerated]
		get
		{
			return Sb99788gKd8;
		}
		[CompilerGenerated]
		set
		{
			Sb99788gKd8 = sb99788gKd;
		}
	}

	public CoPfjK9hF3ASs5TbM8OK Position
	{
		[CompilerGenerated]
		get
		{
			return T9A97AYHg8Y;
		}
	}

	public IEnumerable<I0xHaV9hWE00eUtcW1Zm> Orders => WiO97PfIblR.Values;

	public IEnumerable<I0xHaV9hWE00eUtcW1Zm> Triggers => jVJ97FfFwwS.Values;

	public ICollection<cLhcml97bc8jKEraVPl0> Executions => HXR973Q9QCs.Values;

	public ICollection<IhHpoC9hliGX2eZqQA6k> Deals => rhc97piYNHE;

	public t4J54f97Q2MUX30RSwuQ()
	{
		smhAgvbVKYeI8ONEIMmg();
		WiO97PfIblR = new Dictionary<long, I0xHaV9hWE00eUtcW1Zm>();
		vDd97J9Haw0 = new Dictionary<long, I0xHaV9hWE00eUtcW1Zm>();
		jVJ97FfFwwS = new Dictionary<long, I0xHaV9hWE00eUtcW1Zm>();
		HXR973Q9QCs = new Dictionary<string, cLhcml97bc8jKEraVPl0>();
		rhc97piYNHE = new List<IhHpoC9hliGX2eZqQA6k>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				T9A97AYHg8Y = new CoPfjK9hF3ASs5TbM8OK();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				PriceScale = 1;
				num = 2;
				break;
			}
		}
	}

	public void HFU97gM26ou(UserPosition P_0, bool P_1 = false)
	{
		Position.Gat9wfU5hCb(P_0, P_1);
	}

	public void ClearPosition()
	{
		Position.Gat9wfU5hCb(null);
	}

	[SpecialName]
	public IEnumerable<I0xHaV9hWE00eUtcW1Zm> B0397Ke6A4G()
	{
		return vDd97J9Haw0.Values;
	}

	public bool Y0S97RSnjsa(OrderGroup P_0, long P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return jVJ97FfFwwS.ContainsKey(P_1);
			default:
				return false;
			case 1:
				switch (P_0)
				{
				case OrderGroup.MarketAndLimit:
					return WiO97PfIblR.ContainsKey(P_1);
				case OrderGroup.StopAndStopLimit:
					return vDd97J9Haw0.ContainsKey(P_1);
				case OrderGroup.Trigger:
					return jVJ97FfFwwS.ContainsKey(P_1);
				default:
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
					{
						num2 = 0;
					}
					break;
				case OrderGroup.All:
					if (WiO97PfIblR.ContainsKey(P_1) || vDd97J9Haw0.ContainsKey(P_1))
					{
						return true;
					}
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
					{
						num2 = 1;
					}
					break;
				}
				break;
			}
		}
	}

	public I0xHaV9hWE00eUtcW1Zm xoT976PMTbM(OrderGroup P_0, long P_1)
	{
		switch (P_0)
		{
		case OrderGroup.StopAndStopLimit:
		{
			if (!vDd97J9Haw0.TryGetValue(P_1, out var value2))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					return null;
				}
				goto case OrderGroup.MarketAndLimit;
			}
			return value2;
		}
		default:
			return null;
		case OrderGroup.MarketAndLimit:
		{
			if (!WiO97PfIblR.TryGetValue(P_1, out var value3))
			{
				return null;
			}
			return value3;
		}
		case OrderGroup.Trigger:
		{
			if (!jVJ97FfFwwS.TryGetValue(P_1, out var value))
			{
				return null;
			}
			return value;
		}
		}
	}

	public void Oyu97M1yapr(List<Order> P_0, long P_1)
	{
		long num = 0L;
		long num2 = 0L;
		double num3 = 0.0;
		double num4 = 0.0;
		PTHOPQG0NOhA4Cf5KyJr pTHOPQG0NOhA4Cf5KyJr = default(PTHOPQG0NOhA4Cf5KyJr);
		pTHOPQG0NOhA4Cf5KyJr.XifG01EuQ1W = Side.Buy;
		pTHOPQG0NOhA4Cf5KyJr.JlTG0SOWsP2 = Side.Sell;
		pTHOPQG0NOhA4Cf5KyJr.WcqG0kHk3Ld = long.MaxValue;
		pTHOPQG0NOhA4Cf5KyJr.yIWG05PJVFB = long.MinValue;
		xbo97OtqE5i();
		foreach (Order item in P_0)
		{
			if (item.Type != OrderType.None)
			{
				switch (item.Type)
				{
				case OrderType.Limit:
					if (item.Price <= P_1)
					{
						num += item.Remaining;
						num3 += item.Symbol.GetQuoteSize(item.Remaining, item.Price);
						J9k97TX372t(item.Price, item.Side, ref pTHOPQG0NOhA4Cf5KyJr);
					}
					else
					{
						num2 += item.Remaining;
						num4 += item.Symbol.GetQuoteSize(item.Remaining, item.Price);
						O1b97yswXlS(item.Price, item.Side, ref pTHOPQG0NOhA4Cf5KyJr);
					}
					break;
				case OrderType.Stop:
				case OrderType.StopLimit:
				case OrderType.Trigger:
					if (item.StopPrice > 0 && item.StopPrice <= P_1)
					{
						num += item.Remaining;
						num3 += item.Symbol.GetQuoteSize(item.Remaining, item.StopPrice);
						J9k97TX372t(item.StopPrice, item.Side, ref pTHOPQG0NOhA4Cf5KyJr);
					}
					else if (item.TakePrice > 0 && item.TakePrice <= P_1)
					{
						num += item.Remaining;
						num3 += item.Symbol.GetQuoteSize(item.Remaining, item.TakePrice);
						J9k97TX372t(item.TakePrice, item.Side, ref pTHOPQG0NOhA4Cf5KyJr);
					}
					else if (item.StopPrice > 0 && item.StopPrice > P_1)
					{
						num2 += item.Remaining;
						num4 += item.Symbol.GetQuoteSize(item.Remaining, item.StopPrice);
						O1b97yswXlS(item.StopPrice, item.Side, ref pTHOPQG0NOhA4Cf5KyJr);
					}
					else if (item.TakePrice > 0 && item.TakePrice > P_1)
					{
						num2 += item.Remaining;
						num4 += item.Symbol.GetQuoteSize(item.Remaining, item.TakePrice);
						O1b97yswXlS(item.TakePrice, item.Side, ref pTHOPQG0NOhA4Cf5KyJr);
					}
					break;
				}
			}
			long num5 = MI4nfsnnUf3PYtFXkT2T.zaMnnyYmoGU(item.Price, PriceScale);
			long num6 = MI4nfsnnUf3PYtFXkT2T.zaMnnyYmoGU((item.StopPrice > 0) ? item.StopPrice : item.TakePrice, PriceScale);
			switch (item.Type)
			{
			case OrderType.Market:
			case OrderType.Limit:
			{
				if (WiO97PfIblR.ContainsKey(num5))
				{
					WiO97PfIblR[num5].Quantity += item.Remaining;
					break;
				}
				Dictionary<long, I0xHaV9hWE00eUtcW1Zm> wiO97PfIblR = WiO97PfIblR;
				I0xHaV9hWE00eUtcW1Zm i0xHaV9hWE00eUtcW1Zm2 = new I0xHaV9hWE00eUtcW1Zm();
				i0xHaV9hWE00eUtcW1Zm2.Price = num5;
				i0xHaV9hWE00eUtcW1Zm2.RealPrice = item.Price;
				i0xHaV9hWE00eUtcW1Zm2.Quantity = item.Remaining;
				i0xHaV9hWE00eUtcW1Zm2.Side = item.Side;
				i0xHaV9hWE00eUtcW1Zm2.WfM9hh7R93Q(item.IsReduceOnly());
				wiO97PfIblR.Add(num5, i0xHaV9hWE00eUtcW1Zm2);
				break;
			}
			case OrderType.Stop:
			case OrderType.StopLimit:
			{
				if (vDd97J9Haw0.ContainsKey(num6))
				{
					vDd97J9Haw0[num6].Quantity += item.Remaining;
					break;
				}
				Dictionary<long, I0xHaV9hWE00eUtcW1Zm> dictionary = vDd97J9Haw0;
				I0xHaV9hWE00eUtcW1Zm i0xHaV9hWE00eUtcW1Zm = new I0xHaV9hWE00eUtcW1Zm();
				i0xHaV9hWE00eUtcW1Zm.Price = num6;
				i0xHaV9hWE00eUtcW1Zm.RealPrice = ((item.StopPrice > 0) ? item.StopPrice : item.TakePrice);
				i0xHaV9hWE00eUtcW1Zm.Quantity = item.Quantity;
				i0xHaV9hWE00eUtcW1Zm.Side = item.Side;
				i0xHaV9hWE00eUtcW1Zm.WfM9hh7R93Q(item.IsReduceOnly());
				dictionary.Add(num6, i0xHaV9hWE00eUtcW1Zm);
				break;
			}
			case OrderType.Trigger:
				if (jVJ97FfFwwS.ContainsKey(num6))
				{
					jVJ97FfFwwS[num6].Quantity += item.Remaining;
					break;
				}
				jVJ97FfFwwS.Add(num6, new I0xHaV9hWE00eUtcW1Zm
				{
					Price = num6,
					RealPrice = ((item.StopPrice > 0) ? item.StopPrice : item.TakePrice),
					Quantity = item.Remaining,
					Side = item.Side
				});
				break;
			}
		}
		Position.TotalBids = num;
		Position.TotalAsks = num2;
		Position.E9d9wZH1dpv(num3);
		Position.z2Y9wr0Cf1n(num4);
		Position.Ntg9whO8Xh5(pTHOPQG0NOhA4Cf5KyJr.XifG01EuQ1W);
		Position.kYa9w8qI9xw(pTHOPQG0NOhA4Cf5KyJr.JlTG0SOWsP2);
	}

	public void xbo97OtqE5i()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				wRY4n1bVmp3MffRlJBem(Position, 0L);
				wP14g7bVhqnlDvkOOJb5(Position, 0L);
				G89fxIbVwC2M96QWDTUh(Position, 0.0);
				Position.z2Y9wr0Cf1n(0.0);
				return;
			case 2:
				vDd97J9Haw0.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				WiO97PfIblR.Clear();
				num2 = 2;
				break;
			default:
				jVJ97FfFwwS.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void dWq97q4HErA(List<Execution> P_0)
	{
		HXR973Q9QCs.Clear();
		foreach (Execution item in P_0)
		{
			if (!HXR973Q9QCs.ContainsKey(item.ExecutionID))
			{
				HXR973Q9QCs.Add(item.ExecutionID, new cLhcml97bc8jKEraVPl0
				{
					Time = item.Time,
					Price = item.Price,
					Quantity = item.Quantity,
					Side = item.Side
				});
			}
		}
	}

	public void rjv97I8YAwV(Execution P_0)
	{
		if (!HXR973Q9QCs.ContainsKey(P_0.ExecutionID))
		{
			Dictionary<string, cLhcml97bc8jKEraVPl0> hXR973Q9QCs = HXR973Q9QCs;
			string executionID = P_0.ExecutionID;
			cLhcml97bc8jKEraVPl0 obj = new cLhcml97bc8jKEraVPl0
			{
				Time = rLrFmEbV7jDoJLAcklI1(P_0)
			};
			QH8PWfbV8w96a5xkgmj4(obj, P_0.Price);
			obj.Quantity = P_0.Quantity;
			obj.Side = P_0.Side;
			hXR973Q9QCs.Add(executionID, obj);
		}
	}

	public void xJZ97WvO064()
	{
		HXR973Q9QCs.Clear();
	}

	public void yU197t1PPfw(List<UserDeal> P_0)
	{
		rhc97piYNHE.Clear();
		foreach (UserDeal item in P_0)
		{
			hDC97UeAa07(item);
		}
	}

	public void hDC97UeAa07(UserDeal P_0)
	{
		List<IhHpoC9hliGX2eZqQA6k> list = rhc97piYNHE;
		IhHpoC9hliGX2eZqQA6k obj = new IhHpoC9hliGX2eZqQA6k
		{
			OpenTime = xu4i0obVAICpam8dYLp3(P_0),
			OpenPrice = P_0.OpenPrice
		};
		lKcjF1bVPgd79ZRDs9n5(obj, P_0.CloseTime);
		obj.ClosePrice = P_0.ClosePrice;
		obj.Side = P_0.Side;
		w7p9RkbVJq9vb8dsBMN4(obj, P_0.MaxQuantity);
		obj.Points = P_0.Points;
		vSPRbybV3LblhhXPexUG(obj, juVbSTbVF7l5tGVtEK9P(P_0));
		list.Add(obj);
	}

	public void ClearDeals()
	{
		cn7RKvbVpgeBX1n0ayPT(rhc97piYNHE);
	}

	[CompilerGenerated]
	internal static void J9k97TX372t(long P_0, Side P_1, ref PTHOPQG0NOhA4Cf5KyJr P_2)
	{
		if (P_0 < P_2.WcqG0kHk3Ld)
		{
			P_2.WcqG0kHk3Ld = P_0;
			P_2.XifG01EuQ1W = P_1;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	[CompilerGenerated]
	internal static void O1b97yswXlS(long P_0, Side P_1, ref PTHOPQG0NOhA4Cf5KyJr P_2)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0 > P_2.yIWG05PJVFB)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				P_2.yIWG05PJVFB = P_0;
				P_2.JlTG0SOWsP2 = P_1;
				return;
			}
		}
	}

	static t4J54f97Q2MUX30RSwuQ()
	{
		JUwPDxbVuno74FdYhn65();
	}

	internal static bool BRRnJ6bVCF5dv5TLFshn()
	{
		return HWEAALbVVRDBFGAmEKXD == null;
	}

	internal static t4J54f97Q2MUX30RSwuQ MBoEvmbVrZcr23fUY7pp()
	{
		return HWEAALbVVRDBFGAmEKXD;
	}

	internal static void smhAgvbVKYeI8ONEIMmg()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void wRY4n1bVmp3MffRlJBem(object P_0, long P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).TotalBids = P_1;
	}

	internal static void wP14g7bVhqnlDvkOOJb5(object P_0, long P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).TotalAsks = P_1;
	}

	internal static void G89fxIbVwC2M96QWDTUh(object P_0, double P_1)
	{
		((CoPfjK9hF3ASs5TbM8OK)P_0).E9d9wZH1dpv(P_1);
	}

	internal static DateTime rLrFmEbV7jDoJLAcklI1(object P_0)
	{
		return ((Execution)P_0).Time;
	}

	internal static void QH8PWfbV8w96a5xkgmj4(object P_0, long P_1)
	{
		((cLhcml97bc8jKEraVPl0)P_0).Price = P_1;
	}

	internal static DateTime xu4i0obVAICpam8dYLp3(object P_0)
	{
		return ((UserDeal)P_0).OpenTime;
	}

	internal static void lKcjF1bVPgd79ZRDs9n5(object P_0, DateTime P_1)
	{
		((IhHpoC9hliGX2eZqQA6k)P_0).CloseTime = P_1;
	}

	internal static void w7p9RkbVJq9vb8dsBMN4(object P_0, double P_1)
	{
		((IhHpoC9hliGX2eZqQA6k)P_0).Quantity = P_1;
	}

	internal static double juVbSTbVF7l5tGVtEK9P(object P_0)
	{
		return ((UserDeal)P_0).Profit;
	}

	internal static void vSPRbybV3LblhhXPexUG(object P_0, double P_1)
	{
		((IhHpoC9hliGX2eZqQA6k)P_0).Profit = P_1;
	}

	internal static void cn7RKvbVpgeBX1n0ayPT(object P_0)
	{
		((List<IhHpoC9hliGX2eZqQA6k>)P_0).Clear();
	}

	internal static void JUwPDxbVuno74FdYhn65()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
