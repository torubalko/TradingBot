using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using HBn5hCYeh50VjeVE1aNX;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using x97CE55GhEYKgt7TSVZT;

namespace x8wxx2YeR4jmJ4qEoOJe;

internal sealed class V0SMrHYegmUSexl9rYPN
{
	[CompilerGenerated]
	private Action<TicksRequest, byte[]> ioVYeVSGu1O;

	[CompilerGenerated]
	private bool CPtYeCEwi3X;

	private readonly xBjPu0YemrsrZ4vv4Nj1 uvVYerVyeYf;

	private readonly Dictionary<string, TicksRequest> uFSYeKSVQir;

	internal static V0SMrHYegmUSexl9rYPN b6yDQOS5v6ROouGcVHHL;

	[SpecialName]
	[CompilerGenerated]
	public void uW4YeT9i8W5(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = ioVYeVSGu1O;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref ioVYeVSGu1O, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void Nl6YeytAOOQ(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = ioVYeVSGu1O;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref ioVYeVSGu1O, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public bool KYXYeWHmOf3()
	{
		return CPtYeCEwi3X;
	}

	[SpecialName]
	[CompilerGenerated]
	private void GKtYet0ePNd(bool P_0)
	{
		CPtYeCEwi3X = P_0;
	}

	public void DFTYe6wkIfx(TicksRequest P_0)
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, TicksRequest> dictionary = default(Dictionary<string, TicksRequest>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dictionary = uFSYeKSVQir;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(dictionary, ref lockTaken);
				if (!KYXYeWHmOf3())
				{
					int num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f != 0)
					{
						num3 = 1;
					}
					switch (num3)
					{
					case 1:
						if (!uFSYeKSVQir.ContainsKey(P_0.RequestID))
						{
							uFSYeKSVQir.Add((string)sLUdn9S5iaX3kBqjf4ta(P_0), P_0);
						}
						return;
					}
				}
				ioVYeVSGu1O(P_0, uvVYerVyeYf.weSYe7GXRyl(((Symbol)gCGp8CS5l7LqpyPxIXA1(P_0)).ID));
				return;
			}
			finally
			{
				if (lockTaken)
				{
					BunsIjS54GwGifspc7G4(dictionary);
				}
			}
		}
	}

	public void GfjYeMv91FW()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				GKtYet0ePNd(_0020: true);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			using List<TicksRequest>.Enumerator enumerator = uFSYeKSVQir.Values.ToList().GetEnumerator();
			while (enumerator.MoveNext())
			{
				TicksRequest current;
				while (true)
				{
					current = enumerator.Current;
					int num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
					{
						num3 = 1;
					}
					switch (num3)
					{
					case 1:
						goto end_IL_00d1;
					}
					continue;
					end_IL_00d1:
					break;
				}
				uFSYeKSVQir.Remove((string)sLUdn9S5iaX3kBqjf4ta(current));
				ioVYeVSGu1O(current, (byte[])oZJuPYS5DHeXGUxtIfgB(uvVYerVyeYf, current.InternalSymbol.ID));
			}
			return;
		}
	}

	public void NErYeOnpksW(Symbol P_0, TickEvent P_1)
	{
		uvVYerVyeYf.V4yYew7nNeX(P_0, P_1);
	}

	public void bdDYeqiNOBh()
	{
		GKtYet0ePNd(_0020: false);
		QKVxpAS5b4e30ABqEiZ0(uvVYerVyeYf);
	}

	public DateTime fUYYeIVnoDd(Symbol P_0)
	{
		return uvVYerVyeYf.vwjYe8Xmopg(P_0.ID);
	}

	public V0SMrHYegmUSexl9rYPN()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		uvVYerVyeYf = new xBjPu0YemrsrZ4vv4Nj1();
		uFSYeKSVQir = new Dictionary<string, TicksRequest>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static V0SMrHYegmUSexl9rYPN()
	{
		KH1PaMS5NVLd7ZHjFWo0();
		VEPYbSS5kKdVE0BkcUO8();
	}

	internal static bool UvvZ3ZS5BTUyfCS3YFlC()
	{
		return b6yDQOS5v6ROouGcVHHL == null;
	}

	internal static V0SMrHYegmUSexl9rYPN NofCgUS5ac7h3QEBJ6LQ()
	{
		return b6yDQOS5v6ROouGcVHHL;
	}

	internal static object sLUdn9S5iaX3kBqjf4ta(object P_0)
	{
		return ((TicksRequest)P_0).RequestID;
	}

	internal static object gCGp8CS5l7LqpyPxIXA1(object P_0)
	{
		return ((TicksRequest)P_0).InternalSymbol;
	}

	internal static void BunsIjS54GwGifspc7G4(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object oZJuPYS5DHeXGUxtIfgB(object P_0, object P_1)
	{
		return ((xBjPu0YemrsrZ4vv4Nj1)P_0).weSYe7GXRyl((string)P_1);
	}

	internal static void QKVxpAS5b4e30ABqEiZ0(object P_0)
	{
		((xBjPu0YemrsrZ4vv4Nj1)P_0).Clear();
	}

	internal static void KH1PaMS5NVLd7ZHjFWo0()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void VEPYbSS5kKdVE0BkcUO8()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
