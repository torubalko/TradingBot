using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Collections;

internal sealed class Positions
{
	[CompilerGenerated]
	private sealed class k6fJKVioJfdJPmh1Sehm
	{
		public string dRPio3o95mU;

		internal static k6fJKVioJfdJPmh1Sehm LQnjxvLM9PJXicyr5klA;

		public k6fJKVioJfdJPmh1Sehm()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool W0qioFHlpVw(Position w)
		{
			if (GvtiVCLMopSWnR2taX08(iFfGqbLMY60jqCkvdKgS(w.Symbol), dRPio3o95mU))
			{
				return w.Quantity != 0;
			}
			return false;
		}

		static k6fJKVioJfdJPmh1Sehm()
		{
			EMjA5WLMvAh9BSVDXtT7();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool xUkTTbLMn7556RwfQa0E()
		{
			return LQnjxvLM9PJXicyr5klA == null;
		}

		internal static k6fJKVioJfdJPmh1Sehm VNdag2LMGYHcBXTP7BqZ()
		{
			return LQnjxvLM9PJXicyr5klA;
		}

		internal static object iFfGqbLMY60jqCkvdKgS(object P_0)
		{
			return ((Symbol)P_0).ID;
		}

		internal static bool GvtiVCLMopSWnR2taX08(object P_0, object P_1)
		{
			return (string)P_0 == (string)P_1;
		}

		internal static void EMjA5WLMvAh9BSVDXtT7()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	private readonly Dictionary<string, Position> BYdaQMObtjD;

	private readonly object XN5aQOuFTxo;

	private static Positions im5kWox8Jal32vivUiYs;

	internal void yXJaQdI5IEf(Position P_0)
	{
		object xN5aQOuFTxo = XN5aQOuFTxo;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(xN5aQOuFTxo, ref lockTaken);
			if (!BYdaQMObtjD.ContainsKey((string)DvK3NJx8piHbwPld2f4k(P_0)))
			{
				BYdaQMObtjD.Add(P_0.UniqueID, P_0);
			}
		}
		finally
		{
			if (lockTaken)
			{
				lQNTucx8uEAPyDFUpYOT(xN5aQOuFTxo);
			}
		}
	}

	internal Position Cn7aQg7hGId(string P_0)
	{
		int num = 1;
		int num2 = num;
		object xN5aQOuFTxo = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				xN5aQOuFTxo = XN5aQOuFTxo;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(xN5aQOuFTxo, ref lockTaken);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
				{
					num3 = 2;
				}
				while (true)
				{
					switch (num3)
					{
					case 2:
						if (string.IsNullOrEmpty(P_0))
						{
							break;
						}
						if (BYdaQMObtjD.ContainsKey(P_0))
						{
							return BYdaQMObtjD[P_0];
						}
						num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 != 0)
						{
							num3 = 1;
						}
						continue;
					}
					break;
				}
				return null;
			}
			finally
			{
				if (lockTaken)
				{
					lQNTucx8uEAPyDFUpYOT(xN5aQOuFTxo);
				}
			}
		}
	}

	public List<Position> qbkaQRwUBuA()
	{
		lock (XN5aQOuFTxo)
		{
			return BYdaQMObtjD.Values.ToList();
		}
	}

	public List<Position> AV9aQ6MXMs8(string P_0)
	{
		k6fJKVioJfdJPmh1Sehm CS_0024_003C_003E8__locals2 = new k6fJKVioJfdJPmh1Sehm();
		CS_0024_003C_003E8__locals2.dRPio3o95mU = P_0;
		lock (XN5aQOuFTxo)
		{
			return BYdaQMObtjD.Values.Where((Position w) => k6fJKVioJfdJPmh1Sehm.GvtiVCLMopSWnR2taX08(k6fJKVioJfdJPmh1Sehm.iFfGqbLMY60jqCkvdKgS(w.Symbol), CS_0024_003C_003E8__locals2.dRPio3o95mU) && w.Quantity != 0).ToList();
		}
	}

	public void Clear()
	{
		object xN5aQOuFTxo = XN5aQOuFTxo;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(xN5aQOuFTxo, ref lockTaken);
			BYdaQMObtjD.Clear();
		}
		finally
		{
			if (lockTaken)
			{
				lQNTucx8uEAPyDFUpYOT(xN5aQOuFTxo);
			}
		}
	}

	public Positions()
	{
		BI94YJx8zsY4Bm7Q55QR();
		BYdaQMObtjD = new Dictionary<string, Position>();
		XN5aQOuFTxo = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Positions()
	{
		tTrLe1xA0pIFxYPryWgj();
		MqiPk3xA2VNJYhSFerqr();
	}

	internal static object DvK3NJx8piHbwPld2f4k(object P_0)
	{
		return ((Position)P_0).UniqueID;
	}

	internal static void lQNTucx8uEAPyDFUpYOT(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool HlTSDEx8FLmfEb8cGQoD()
	{
		return im5kWox8Jal32vivUiYs == null;
	}

	internal static Positions JX5oBqx83j2irqqEcNcj()
	{
		return im5kWox8Jal32vivUiYs;
	}

	internal static void BI94YJx8zsY4Bm7Q55QR()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void tTrLe1xA0pIFxYPryWgj()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void MqiPk3xA2VNJYhSFerqr()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
