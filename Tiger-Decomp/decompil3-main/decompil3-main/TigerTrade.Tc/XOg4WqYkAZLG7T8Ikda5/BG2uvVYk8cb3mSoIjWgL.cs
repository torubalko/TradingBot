using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using EyD6NKGhRYBSlyBqPfrJ;
using K1GcsD5GTtMSlaiJI0Xh;
using KOWlDaY1vtw5BYDxJyT0;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using x97CE55GhEYKgt7TSVZT;

namespace XOg4WqYkAZLG7T8Ikda5;

internal sealed class BG2uvVYk8cb3mSoIjWgL
{
	[CompilerGenerated]
	private Action<TicksRequest, byte[]> vCLY1fif1QY;

	private readonly LrPEAGY1o6rbef20jWY7 JP7Y19UVaB8;

	private readonly Dictionary<string, TicksRequest> fOMY1nb4TIS;

	private readonly HashSet<string> A4BY1GQBoaF;

	private readonly Dictionary<string, long> g47Y1YtikPh;

	internal static BG2uvVYk8cb3mSoIjWgL ScstvvSlc2xqWWl5m3jm;

	[SpecialName]
	[CompilerGenerated]
	public void RjZY10KjKK4(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = vCLY1fif1QY;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref vCLY1fif1QY, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void wnNY125k9iT(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = vCLY1fif1QY;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref vCLY1fif1QY, value, action2);
		}
		while ((object)action != action2);
	}

	public void T5KYkPfXMIb(TicksRequest P_0)
	{
		Dictionary<string, TicksRequest> dictionary = default(Dictionary<string, TicksRequest>);
		bool lockTaken = default(bool);
		int num;
		if ((!(P_0.Symbol.Exchange == (string)nu5NQPSlQDuHksqBMvly(-1311293279 ^ -1311265127)) && !(P_0.Symbol.Exchange == (string)nu5NQPSlQDuHksqBMvly(-1461949456 ^ -1461942860))) || zkeUEcSldnpWOpegbg1F())
		{
			dictionary = fOMY1nb4TIS;
			lockTaken = false;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 2:
			return;
		case 1:
			vCLY1fif1QY?.Invoke(P_0, null);
			return;
		}
		try
		{
			Monitor.Enter(dictionary, ref lockTaken);
			int num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
			{
				num2 = 1;
			}
			while (true)
			{
				Action<TicksRequest, byte[]> action;
				switch (num2)
				{
				case 2:
					return;
				case 1:
					if (!s03YkpnqHlY(P_0.InternalSymbol))
					{
						if (fOMY1nb4TIS.ContainsKey(P_0.RequestID))
						{
							return;
						}
						break;
					}
					action = vCLY1fif1QY;
					if (action != null)
					{
						goto IL_0177;
					}
					return;
				}
				break;
				IL_0177:
				action(P_0, JP7Y19UVaB8.oU8Y1aNRUwX((string)cGPqAfSlR9SXIPTqAV3x(P_0.InternalSymbol)));
				num2 = 2;
			}
			fOMY1nb4TIS.Add((string)aDW6Z1Slg8I7c6gCqSRy(P_0), P_0);
		}
		finally
		{
			if (!lockTaken)
			{
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
			}
			else
			{
				DjMj6OSl6kYiVpSk07OC(dictionary);
			}
		}
	}

	public void dWiYkJjtInd(Symbol P_0)
	{
		using List<TicksRequest>.Enumerator enumerator = fOMY1nb4TIS.Values.ToList().GetEnumerator();
		while (enumerator.MoveNext())
		{
			while (true)
			{
				TicksRequest current = enumerator.Current;
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
						break;
					case 1:
						goto IL_0053;
					default:
						goto IL_00b2;
					}
					break;
					IL_00b2:
					vCLY1fif1QY?.Invoke(current, JP7Y19UVaB8.oU8Y1aNRUwX(current.InternalSymbol.ID));
					goto end_IL_0030;
					IL_0053:
					if (!((string)cGPqAfSlR9SXIPTqAV3x(current.InternalSymbol) == (string)cGPqAfSlR9SXIPTqAV3x(P_0)))
					{
						goto end_IL_0030;
					}
					fOMY1nb4TIS.Remove(current.RequestID);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
					{
						num = 0;
					}
				}
				continue;
				end_IL_0030:
				break;
			}
		}
	}

	public void mO1YkFy75AL(Symbol P_0, TickEvent P_1)
	{
		JP7Y19UVaB8.qNhY1BfXGUZ(P_0, P_1);
	}

	public void AALYk3WG8J8()
	{
		HashSet<string> a4BY1GQBoaF = A4BY1GQBoaF;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			case 2:
				try
				{
					Monitor.Enter(a4BY1GQBoaF, ref lockTaken);
					yawRLtSlMGtcAaH83k1B(A4BY1GQBoaF);
				}
				finally
				{
					if (lockTaken)
					{
						DjMj6OSl6kYiVpSk07OC(a4BY1GQBoaF);
					}
				}
				break;
			}
			Dictionary<string, long> dictionary = g47Y1YtikPh;
			lockTaken = false;
			try
			{
				Monitor.Enter(dictionary, ref lockTaken);
				g47Y1YtikPh.Clear();
			}
			finally
			{
				if (lockTaken)
				{
					DjMj6OSl6kYiVpSk07OC(dictionary);
				}
			}
			JP7Y19UVaB8.Clear();
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
			{
				num = 0;
			}
		}
	}

	private bool s03YkpnqHlY(Symbol P_0)
	{
		HashSet<string> a4BY1GQBoaF = A4BY1GQBoaF;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(a4BY1GQBoaF, ref lockTaken);
			return A4BY1GQBoaF.Contains((string)cGPqAfSlR9SXIPTqAV3x(P_0));
		}
		finally
		{
			if (lockTaken)
			{
				DjMj6OSl6kYiVpSk07OC(a4BY1GQBoaF);
			}
		}
	}

	public void Check(Symbol symbol)
	{
		int num = 2;
		int num2 = num;
		HashSet<string> a4BY1GQBoaF = default(HashSet<string>);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (s03YkpnqHlY(symbol))
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				a4BY1GQBoaF = A4BY1GQBoaF;
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				return;
			}
			try
			{
				Monitor.Enter(a4BY1GQBoaF, ref lockTaken);
				A4BY1GQBoaF.Add((string)cGPqAfSlR9SXIPTqAV3x(symbol));
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(a4BY1GQBoaF);
				}
			}
			dWiYkJjtInd(symbol);
			return;
		}
	}

	public void IQnYkuF2VDZ(string P_0, long P_1)
	{
		int num = 1;
		int num2 = num;
		Dictionary<string, long> obj = default(Dictionary<string, long>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = g47Y1YtikPh;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				if (!g47Y1YtikPh.ContainsKey(P_0))
				{
					g47Y1YtikPh.Add(P_0, P_1);
				}
				else
				{
					g47Y1YtikPh[P_0] = P_1;
				}
				return;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
	}

	public long tJEYkzpgsAx(string P_0)
	{
		Dictionary<string, long> dictionary = g47Y1YtikPh;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(dictionary, ref lockTaken);
			if (g47Y1YtikPh.ContainsKey(P_0))
			{
				return g47Y1YtikPh[P_0];
			}
		}
		finally
		{
			if (lockTaken)
			{
				DjMj6OSl6kYiVpSk07OC(dictionary);
			}
		}
		return 1L;
	}

	public BG2uvVYk8cb3mSoIjWgL()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		JP7Y19UVaB8 = new LrPEAGY1o6rbef20jWY7();
		fOMY1nb4TIS = new Dictionary<string, TicksRequest>();
		A4BY1GQBoaF = new HashSet<string>();
		g47Y1YtikPh = new Dictionary<string, long>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static BG2uvVYk8cb3mSoIjWgL()
	{
		LuXTl8SlOcVqZBpcZrQy();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object nu5NQPSlQDuHksqBMvly(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool zkeUEcSldnpWOpegbg1F()
	{
		return Acj0FgGhg83F5A0lfPa4.AO1Gh6sdXiP();
	}

	internal static object aDW6Z1Slg8I7c6gCqSRy(object P_0)
	{
		return ((TicksRequest)P_0).RequestID;
	}

	internal static object cGPqAfSlR9SXIPTqAV3x(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static void DjMj6OSl6kYiVpSk07OC(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool SHoKYsSljZwei6muZnJl()
	{
		return ScstvvSlc2xqWWl5m3jm == null;
	}

	internal static BG2uvVYk8cb3mSoIjWgL hDYBygSlES8sTuUDEwIE()
	{
		return ScstvvSlc2xqWWl5m3jm;
	}

	internal static void yawRLtSlMGtcAaH83k1B(object P_0)
	{
		((HashSet<string>)P_0).Clear();
	}

	internal static void LuXTl8SlOcVqZBpcZrQy()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
