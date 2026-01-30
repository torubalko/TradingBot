using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using VgwQA4YH5JLfyq50fYtW;
using x97CE55GhEYKgt7TSVZT;

namespace YSs1TkYHnkW19m68oarR;

internal sealed class Pqq4dbYH9SVPPEGYtXHJ
{
	[CompilerGenerated]
	private Action<TicksRequest, byte[]> LJ3YHD8LxtP;

	private readonly tUiVpIYH1G7oGcZgrndS WdNYHbycHfE;

	private readonly Dictionary<string, TicksRequest> ABZYHNhQ8Ft;

	private readonly HashSet<string> d6mYHkpRexY;

	internal static Pqq4dbYH9SVPPEGYtXHJ AKjtflS0ZkH0xYBtS2si;

	[SpecialName]
	[CompilerGenerated]
	public void mriYHiMWGWu(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = LJ3YHD8LxtP;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref LJ3YHD8LxtP, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void e4CYHlphQUq(Action<TicksRequest, byte[]> P_0)
	{
		Action<TicksRequest, byte[]> action = LJ3YHD8LxtP;
		Action<TicksRequest, byte[]> action2;
		do
		{
			action2 = action;
			Action<TicksRequest, byte[]> value = (Action<TicksRequest, byte[]>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref LJ3YHD8LxtP, value, action2);
		}
		while ((object)action != action2);
	}

	public void cscYHGXoxpr(TicksRequest P_0)
	{
		lock (ABZYHNhQ8Ft)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (gSBYHoVWDPh(P_0.InternalSymbol))
					{
						Action<TicksRequest, byte[]> action = LJ3YHD8LxtP;
						if (action == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
							{
								num2 = 0;
							}
							break;
						}
						action(P_0, WdNYHbycHfE.BmvYHLQv1Ui(P_0.InternalSymbol.ID));
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
						{
							num2 = 1;
						}
						break;
					}
					if (!ABZYHNhQ8Ft.ContainsKey(P_0.RequestID))
					{
						ABZYHNhQ8Ft.Add(P_0.RequestID, P_0);
					}
					return;
				case 0:
					return;
				case 1:
					return;
				}
			}
		}
	}

	private void EjKYHYlu5J1(Symbol P_0)
	{
		using List<TicksRequest>.Enumerator enumerator = ABZYHNhQ8Ft.Values.ToList().GetEnumerator();
		TicksRequest current = default(TicksRequest);
		while (true)
		{
			int num;
			if (!enumerator.MoveNext())
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
				{
					num = 0;
				}
			}
			else
			{
				current = enumerator.Current;
				if (wM38gDS0KOXgga3UeVw5(J86VxsS0rWrTW80SbTAM(current.InternalSymbol), P_0.ID))
				{
					goto IL_0098;
				}
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			default:
				return;
			case 2:
				continue;
			case 1:
				break;
			case 0:
				return;
			}
			goto IL_0098;
			IL_0098:
			ABZYHNhQ8Ft.Remove(current.RequestID);
			LJ3YHD8LxtP?.Invoke(current, (byte[])jSLxwdS0hYUCKQrhSJ7m(WdNYHbycHfE, ((Symbol)qe3fQ7S0mdhBHhk7JCRU(current)).ID));
		}
	}

	public bool gSBYHoVWDPh(Symbol P_0)
	{
		lock (d6mYHkpRexY)
		{
			return d6mYHkpRexY.Contains(P_0.ID);
		}
	}

	public void Check(Symbol symbol)
	{
		int num = 1;
		int num2 = num;
		HashSet<string> obj = default(HashSet<string>);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (gSBYHoVWDPh(symbol))
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				WdNYHbycHfE.LUdYHeO05eK(symbol);
				obj = d6mYHkpRexY;
				lockTaken = false;
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					d6mYHkpRexY.Add((string)J86VxsS0rWrTW80SbTAM(symbol));
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				EjKYHYlu5J1(symbol);
				return;
			}
		}
	}

	public void HgoYHv6qJbj(Symbol P_0, TickEvent P_1, bool P_2)
	{
		if (P_2)
		{
			WdNYHbycHfE.IoKYHxfFYqG(P_0, P_1);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			WdNYHbycHfE.ck0YHSAmqWe(P_0, P_1);
		}
	}

	public void fl6YHBg7CFn()
	{
		HashSet<string> obj = d6mYHkpRexY;
		bool lockTaken = false;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 1:
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				d6mYHkpRexY.Clear();
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			break;
		}
		WdNYHbycHfE.Clear();
		Uape2pS0we9ShtQnseob(WdNYHbycHfE);
	}

	public int krqYHaXdQLO(Symbol P_0)
	{
		HashSet<string> obj = d6mYHkpRexY;
		bool lockTaken = false;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d == 0)
		{
			num = 1;
		}
		TimeSpan timeSpan = default(TimeSpan);
		DateTime dateTime2 = default(DateTime);
		while (true)
		{
			switch (num)
			{
			case 2:
				return (int)timeSpan.TotalSeconds;
			case 3:
				return (int)dateTime2.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
			default:
				timeSpan = dateTime2.Subtract(new DateTime(1970, 1, 1));
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b == 0)
				{
					num = 2;
				}
				break;
			case 1:
			{
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (d6mYHkpRexY.Contains(P_0.ID))
					{
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						default:
							d6mYHkpRexY.Remove((string)J86VxsS0rWrTW80SbTAM(P_0));
							break;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
				DateTime dateTime = lebByHS07qsyAX1NTX3A(WdNYHbycHfE, P_0.ID);
				if (!bsabpOS083kxF43SExNG(dateTime, DateTime.MinValue))
				{
					dateTime2 = TimeHelper.ConvertTimeToLocal(dateTime, (string)ceYLFES0PGjP40aYqLcV(P_0), ignoreGlobalOption: true);
					num = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b != 0)
					{
						num = 1;
					}
				}
				else
				{
					dateTime2 = qk445eS0AEQyYHWmY9Jd().AddMinutes(-30.0);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
					{
						num = 0;
					}
				}
				break;
			}
			}
		}
	}

	public Pqq4dbYH9SVPPEGYtXHJ()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		WdNYHbycHfE = new tUiVpIYH1G7oGcZgrndS();
		ABZYHNhQ8Ft = new Dictionary<string, TicksRequest>();
		d6mYHkpRexY = new HashSet<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Pqq4dbYH9SVPPEGYtXHJ()
	{
		mYsDQDS0JTccvcTPj4SN();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool QgoJaoS0V8Z83XrqkH6r()
	{
		return AKjtflS0ZkH0xYBtS2si == null;
	}

	internal static Pqq4dbYH9SVPPEGYtXHJ I4BqvYS0Cu0nrwUyMFpl()
	{
		return AKjtflS0ZkH0xYBtS2si;
	}

	internal static object J86VxsS0rWrTW80SbTAM(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static bool wM38gDS0KOXgga3UeVw5(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object qe3fQ7S0mdhBHhk7JCRU(object P_0)
	{
		return ((TicksRequest)P_0).InternalSymbol;
	}

	internal static object jSLxwdS0hYUCKQrhSJ7m(object P_0, object P_1)
	{
		return ((tUiVpIYH1G7oGcZgrndS)P_0).BmvYHLQv1Ui((string)P_1);
	}

	internal static void Uape2pS0we9ShtQnseob(object P_0)
	{
		((tUiVpIYH1G7oGcZgrndS)P_0).R3iYHsN3iJf();
	}

	internal static DateTime lebByHS07qsyAX1NTX3A(object P_0, object P_1)
	{
		return ((tUiVpIYH1G7oGcZgrndS)P_0).nbTYHXGayiQ((string)P_1);
	}

	internal static bool bsabpOS083kxF43SExNG(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static DateTime qk445eS0AEQyYHWmY9Jd()
	{
		return TimeHelper.LocalTime;
	}

	internal static object ceYLFES0PGjP40aYqLcV(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static void mYsDQDS0JTccvcTPj4SN()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
