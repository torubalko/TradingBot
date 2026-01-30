using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ECOEgqlSad8NUJZ2Dr9n;
using hTabtpHZ5rp1Am1FvYmp;
using Microsoft.IdentityModel.Tokens;
using p9TTcsHCw7Nx8eLJhObh;
using r5KQolHZv1kdRuFVTnUq;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;
using XsDptMfu1TZDPkNQ2KkJ;

namespace LIZPJWHZEY2VKUjdIYiN;

internal static class LStMKXHZj9m30GIr08xj
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct FCd4PYnhddrsPetJiKby : IAsyncStateMachine
	{
		public int FnTnhgbqrC2;

		public AsyncTaskMethodBuilder Q9anhRi9dVE;

		public q7ohYNHZ1Db3CcCWYhdv D9qnh6Kc3fr;

		public DateTime aOEnhMh0Wg4;

		private TaskAwaiter gEHnhOax6kL;

		internal static object cMoKRiNQyESLXAqmlyk7;

		private void MoveNext()
		{
			int num = FnTnhgbqrC2;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 2;
					goto IL_0048;
				}
				goto IL_00ec;
				IL_00bb:
				int num3 = 3;
				goto IL_0044;
				IL_0048:
				TaskAwaiter awaiter = default(TaskAwaiter);
				while (true)
				{
					switch (num2)
					{
					case 5:
						gEHnhOax6kL = default(TaskAwaiter);
						num = (FnTnhgbqrC2 = -1);
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						goto IL_00ec;
					case 2:
						goto IL_0115;
					case 0:
						break;
					case 4:
						gEHnhOax6kL = awaiter;
						Q9anhRi9dVE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1:
						goto IL_0142;
					case 3:
						goto IL_01bd;
					}
					break;
					IL_0115:
					if (D9qnh6Kc3fr.dG4HZxeFDQt <= 0)
					{
						break;
					}
					if (RNMvZkNQCGC5S82P1c97(D9qnh6Kc3fr.waFHZS0rmmF) > DataCycleBase.Week)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					DateTime value = new DateTime(1970, 1, 1);
					long num4 = (long)aOEnhMh0Wg4.Subtract(value).TotalMilliseconds;
					awaiter = ((Task)W2yiC8NQrHsWSQ18UuRb(D9qnh6Kc3fr.Symbol, D9qnh6Kc3fr.waFHZS0rmmF, num4)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						goto IL_00bb;
					}
					goto IL_0142;
					IL_0142:
					awaiter.GetResult();
					break;
				}
				goto end_IL_0033;
				IL_00ec:
				awaiter = gEHnhOax6kL;
				num3 = 5;
				goto IL_0044;
				IL_0044:
				num2 = num3;
				goto IL_0048;
				IL_01bd:
				num = (FnTnhgbqrC2 = 0);
				num3 = 4;
				goto IL_0044;
				end_IL_0033:;
			}
			catch (Exception exception)
			{
				FnTnhgbqrC2 = -2;
				int num5 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
				Q9anhRi9dVE.SetException(exception);
				return;
			}
			FnTnhgbqrC2 = -2;
			Q9anhRi9dVE.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			Q9anhRi9dVE.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static FCd4PYnhddrsPetJiKby()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static DataCycleBase RNMvZkNQCGC5S82P1c97(object P_0)
		{
			return ((DataCycle)P_0).CycleBase;
		}

		internal static object W2yiC8NQrHsWSQ18UuRb(object P_0, object P_1, long P_2)
		{
			return b8AkysfukSBAWXjMK6sm.kWXfuyrkpiM((Symbol)P_0, (DataCycle)P_1, P_2);
		}

		internal static bool tMya6kNQZBTwbN6uIbHC()
		{
			return cMoKRiNQyESLXAqmlyk7 == null;
		}

		internal static object VpPyqjNQVKwyLnOAOxvM()
		{
			return cMoKRiNQyESLXAqmlyk7;
		}
	}

	[CompilerGenerated]
	private sealed class RZPb6BnhqDMlhM0ZnLxg
	{
		public Symbol cXGnhtx47e9;

		public Func<q7ohYNHZ1Db3CcCWYhdv, bool> EG7nhUgNob6;

		public Func<dKSpGiHyaUa6LiEfhK5I, OjH2QVHZoARxtkRLMBCI> AsEnhTuS8u8;

		internal static RZPb6BnhqDMlhM0ZnLxg ueMvVTNQKV7qp8VK9wNT;

		public RZPb6BnhqDMlhM0ZnLxg()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool QkWnhILSbLy(q7ohYNHZ1Db3CcCWYhdv barsItem)
		{
			return barsItem.Symbol == cXGnhtx47e9;
		}

		internal OjH2QVHZoARxtkRLMBCI yGynhWJ8awK(dKSpGiHyaUa6LiEfhK5I b)
		{
			return new OjH2QVHZoARxtkRLMBCI(b.Time, (double)b.Close * cXGnhtx47e9.Step, _0020: true);
		}

		static RZPb6BnhqDMlhM0ZnLxg()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool lVbqFVNQmem71HYaRVdU()
		{
			return ueMvVTNQKV7qp8VK9wNT == null;
		}

		internal static RZPb6BnhqDMlhM0ZnLxg QO3Y2PNQhQm13ybUAv4H()
		{
			return ueMvVTNQKV7qp8VK9wNT;
		}
	}

	private static readonly Dictionary<string, q7ohYNHZ1Db3CcCWYhdv> Go7HZCLjSCR;

	private static readonly object GxsHZrJXYnp;

	[CompilerGenerated]
	private static Action<q7ohYNHZ1Db3CcCWYhdv> KcIHZKLpS8c;

	private static LStMKXHZj9m30GIr08xj PFcc7gDIDvJZSpUMh0LS;

	[SpecialName]
	[CompilerGenerated]
	public static void D03HZyEkss1(Action<q7ohYNHZ1Db3CcCWYhdv> P_0)
	{
		Action<q7ohYNHZ1Db3CcCWYhdv> action = KcIHZKLpS8c;
		Action<q7ohYNHZ1Db3CcCWYhdv> action2;
		do
		{
			action2 = action;
			Action<q7ohYNHZ1Db3CcCWYhdv> value = (Action<q7ohYNHZ1Db3CcCWYhdv>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref KcIHZKLpS8c, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void kD0HZZUTQ8f(Action<q7ohYNHZ1Db3CcCWYhdv> P_0)
	{
		Action<q7ohYNHZ1Db3CcCWYhdv> action = KcIHZKLpS8c;
		Action<q7ohYNHZ1Db3CcCWYhdv> action2;
		do
		{
			action2 = action;
			Action<q7ohYNHZ1Db3CcCWYhdv> value = (Action<q7ohYNHZ1Db3CcCWYhdv>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref KcIHZKLpS8c, value, action2);
		}
		while ((object)action != action2);
	}

	static LStMKXHZj9m30GIr08xj()
	{
		o6ovAIDIkY6Vl1oOPIHU();
		Ot37JhDI1hOcyOk6QuKx();
		Go7HZCLjSCR = new Dictionary<string, q7ohYNHZ1Db3CcCWYhdv>();
		GxsHZrJXYnp = new object();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static void IxjHZQVGieV(Symbol P_0, DataCycle P_1)
	{
		string text = gfRHZtERYYp(P_0, P_1);
		if (text.IsNullOrEmpty())
		{
			return;
		}
		object gxsHZrJXYnp = GxsHZrJXYnp;
		bool lockTaken = false;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			try
			{
				Monitor.Enter(gxsHZrJXYnp, ref lockTaken);
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
				{
					num2 = 0;
				}
				q7ohYNHZ1Db3CcCWYhdv value = default(q7ohYNHZ1Db3CcCWYhdv);
				while (true)
				{
					switch (num2)
					{
					default:
						if (!Go7HZCLjSCR.TryGetValue(text, out value))
						{
							value = new q7ohYNHZ1Db3CcCWYhdv(P_0, P_1);
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0064;
					case 1:
						{
							Go7HZCLjSCR.Add(text, value);
							goto IL_0064;
						}
						IL_0064:
						value.dG4HZxeFDQt++;
						return;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(gxsHZrJXYnp);
				}
			}
		}
	}

	public static void k3CHZdW1sOk(Symbol P_0, DataCycleBase P_1, int P_2)
	{
		string text = (string)Hq7thRDI5cvaICPOB2XK(P_0, P_1, P_2);
		if (text.IsNullOrEmpty())
		{
			return;
		}
		object gxsHZrJXYnp = GxsHZrJXYnp;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
		{
			num = 0;
		}
		bool lockTaken = default(bool);
		q7ohYNHZ1Db3CcCWYhdv value = default(q7ohYNHZ1Db3CcCWYhdv);
		while (true)
		{
			switch (num)
			{
			case 1:
				try
				{
					Monitor.Enter(gxsHZrJXYnp, ref lockTaken);
					int num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							if (value.dG4HZxeFDQt <= 0)
							{
								Go7HZCLjSCR.Remove(text);
							}
							return;
						case 1:
							if (Go7HZCLjSCR.TryGetValue(text, out value))
							{
								if (value.dG4HZxeFDQt <= 0)
								{
									return;
								}
								value.dG4HZxeFDQt--;
								num2 = 2;
							}
							else
							{
								num2 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
								{
									num2 = 0;
								}
							}
							break;
						}
					}
				}
				finally
				{
					if (!lockTaken)
					{
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
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
						vuNfpmDIS3cIpP6PAHR3(gxsHZrJXYnp);
					}
				}
			default:
				lockTaken = false;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public static void BSmHZgoTnIV(Symbol P_0, DataCycle P_1, DateTime P_2, DateTime P_3)
	{
		string key = gfRHZtERYYp(P_0, P_1);
		if (!Go7HZCLjSCR.TryGetValue(key, out var value))
		{
			return;
		}
		object zdtHZckosBk = value.zdtHZckosBk;
		bool lockTaken = false;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
		{
			num = 1;
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			try
			{
				Monitor.Enter(zdtHZckosBk, ref lockTaken);
				int num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
				{
					num2 = 3;
				}
				OjH2QVHZoARxtkRLMBCI ojH2QVHZoARxtkRLMBCI = default(OjH2QVHZoARxtkRLMBCI);
				DateTime dateTime = default(DateTime);
				DateTime dateTime2 = default(DateTime);
				while (true)
				{
					DateTime dateTime3;
					OjH2QVHZoARxtkRLMBCI ojH2QVHZoARxtkRLMBCI2;
					switch (num2)
					{
					case 5:
						return;
					case 6:
						value.W4FHZsa6WQA = P_2;
						num2 = 2;
						continue;
					case 9:
					{
						DateTime? dateTime4 = ojH2QVHZoARxtkRLMBCI?.Time;
						if (!dateTime4.HasValue || !qXdpM3DIxGT4qIXIkRe9(dateTime, dateTime4.GetValueOrDefault()))
						{
							return;
						}
						if (!(value.xKiHZXfODLu.AddSeconds(30.0) < lj8qPnDILmHwBtYPEiaa()))
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_01aa;
					}
					case 7:
						ojH2QVHZoARxtkRLMBCI = value.Jl8HZL7wNm1.LastOrDefault();
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
						{
							num2 = 4;
						}
						continue;
					case 8:
						dateTime3 = LFXKKMDIsXbyJSIZ10HE(ojH2QVHZoARxtkRLMBCI);
						break;
					case 2:
						value.xKiHZXfODLu = DateTime.Now;
						sDRHZRkBdYH(value, P_2);
						return;
					case 1:
						FMC0stDIXtLw29WM61ou(value, dateTime2);
						num2 = 5;
						continue;
					default:
						if (!ffaCDQDIe7KEsVpK811y(value.xKiHZXfODLu, P_3))
						{
							return;
						}
						goto IL_01aa;
					case 3:
						if (P_2 < value.W4FHZsa6WQA)
						{
							goto case 6;
						}
						goto case 7;
					case 4:
						{
							dateTime = P_3;
							num2 = 9;
							continue;
						}
						IL_01aa:
						ojH2QVHZoARxtkRLMBCI2 = value.Jl8HZL7wNm1.First();
						value.xKiHZXfODLu = DateTime.Now;
						if (!(value.W4FHZsa6WQA < ojH2QVHZoARxtkRLMBCI2.Time))
						{
							int num3 = 8;
							num2 = num3;
							continue;
						}
						dateTime3 = value.W4FHZsa6WQA;
						break;
					}
					dateTime2 = dateTime3;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
					{
						num2 = 1;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					vuNfpmDIS3cIpP6PAHR3(zdtHZckosBk);
					int num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	[AsyncStateMachine(typeof(FCd4PYnhddrsPetJiKby))]
	private static Task sDRHZRkBdYH(q7ohYNHZ1Db3CcCWYhdv P_0, DateTime P_1)
	{
		int num = 1;
		int num2 = num;
		FCd4PYnhddrsPetJiKby stateMachine = default(FCd4PYnhddrsPetJiKby);
		while (true)
		{
			switch (num2)
			{
			case 2:
				stateMachine.FnTnhgbqrC2 = -1;
				stateMachine.Q9anhRi9dVE.Start(ref stateMachine);
				return stateMachine.Q9anhRi9dVE.Task;
			case 1:
				stateMachine.Q9anhRi9dVE = AsyncTaskMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num2 = 0;
				}
				continue;
			}
			stateMachine.D9qnh6Kc3fr = P_0;
			stateMachine.aOEnhMh0Wg4 = P_1;
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
			{
				num2 = 0;
			}
		}
	}

	private static bool ikIHZ6Nj7mR(DateTime P_0, DataCycle P_1, DataCycle P_2, out DateTime P_3)
	{
		DateTime dateTime = P_0.AddMilliseconds(JC9NavDIcAatgo1AWxrV(P_1));
		if (!XKRf5aDIjVPCAMNxXClJ(P_2, dateTime))
		{
			P_3 = DateTime.MinValue;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => false, 
			};
		}
		P_3 = dateTime.AddMilliseconds(-TARHZO9ledt(P_2));
		return true;
	}

	private static bool jgAHZMid323(DataCycle P_0, DateTime P_1)
	{
		if (P_0.CycleBase >= DataCycleBase.Day)
		{
			return false;
		}
		return (3600000 * P_1.Hour + 60000 * P_1.Minute + 1000 * P_1.Second + P_1.Millisecond) % TARHZO9ledt(P_0) == 0;
	}

	private static long TARHZO9ledt(DataCycle P_0)
	{
		int num = 1;
		int num2 = num;
		DataCycleBase cycleBase = default(DataCycleBase);
		while (true)
		{
			switch (num2)
			{
			default:
				return cycleBase switch
				{
					DataCycleBase.Second => 1000L * (long)LPEdliDIEi1YfsWpQGOo(P_0), 
					DataCycleBase.Minute => 60000L * (long)LPEdliDIEi1YfsWpQGOo(P_0), 
					DataCycleBase.Hour => 3600000L * (long)P_0.Repeat, 
					DataCycleBase.Day => 86400000L * (long)P_0.Repeat, 
					DataCycleBase.Week => 604800000L * (long)P_0.Repeat, 
					_ => -1L, 
				};
			case 1:
				cycleBase = P_0.CycleBase;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static List<OjH2QVHZoARxtkRLMBCI> SpBHZq8ACYl(List<dKSpGiHyaUa6LiEfhK5I> P_0, Symbol P_1, DataCycle P_2, DataCycle P_3)
	{
		long num = TARHZO9ledt(P_3);
		long num2 = TARHZO9ledt(P_2);
		if (num < num2 || num % num2 != 0L)
		{
			return null;
		}
		List<OjH2QVHZoARxtkRLMBCI> list = new List<OjH2QVHZoARxtkRLMBCI>();
		foreach (dKSpGiHyaUa6LiEfhK5I item in P_0)
		{
			bool flag = item == P_0.Last();
			if (ikIHZ6Nj7mR(item.Time, P_2, P_3, out var dateTime))
			{
				list.Add(new OjH2QVHZoARxtkRLMBCI(dateTime, (double)item.Close * P_1.Step, flag));
			}
		}
		return list;
	}

	public static void Ek3HZIytuVe(List<dKSpGiHyaUa6LiEfhK5I> P_0, Symbol P_1, DataCycle P_2)
	{
		RZPb6BnhqDMlhM0ZnLxg CS_0024_003C_003E8__locals7 = new RZPb6BnhqDMlhM0ZnLxg();
		CS_0024_003C_003E8__locals7.cXGnhtx47e9 = P_1;
		if (CS_0024_003C_003E8__locals7.cXGnhtx47e9 == null || P_0 == null || P_0.Count == 0)
		{
			return;
		}
		foreach (q7ohYNHZ1Db3CcCWYhdv item in Go7HZCLjSCR.Values.Where((q7ohYNHZ1Db3CcCWYhdv barsItem) => barsItem.Symbol == CS_0024_003C_003E8__locals7.cXGnhtx47e9))
		{
			bool flag;
			if (P_2.Equals(item.waFHZS0rmmF))
			{
				List<OjH2QVHZoARxtkRLMBCI> list = P_0.Select((dKSpGiHyaUa6LiEfhK5I b) => new OjH2QVHZoARxtkRLMBCI(b.Time, (double)b.Close * CS_0024_003C_003E8__locals7.cXGnhtx47e9.Step, _0020: true)).ToList();
				list.Last().IsClosed = false;
				flag = nrOHZWVDw3X(list, CS_0024_003C_003E8__locals7.cXGnhtx47e9, P_2);
			}
			else
			{
				flag = nrOHZWVDw3X(SpBHZq8ACYl(P_0, CS_0024_003C_003E8__locals7.cXGnhtx47e9, P_2, item.waFHZS0rmmF), CS_0024_003C_003E8__locals7.cXGnhtx47e9, item.waFHZS0rmmF);
			}
			if (flag)
			{
				KcIHZKLpS8c?.Invoke(item);
			}
		}
	}

	private static bool nrOHZWVDw3X(List<OjH2QVHZoARxtkRLMBCI> P_0, Symbol P_1, DataCycle P_2)
	{
		if (P_1 == null || P_0 == null || P_0.Count == 0)
		{
			return false;
		}
		string key = gfRHZtERYYp(P_1, P_2);
		if (!Go7HZCLjSCR.TryGetValue(key, out var value))
		{
			return false;
		}
		lock (value.JuBHZeTc0gj)
		{
			List<OjH2QVHZoARxtkRLMBCI> jl8HZL7wNm = value.Jl8HZL7wNm1;
			if (jl8HZL7wNm.Count == 0)
			{
				jl8HZL7wNm.AddRange(P_0);
				return true;
			}
			int num = jl8HZL7wNm.Count - 1;
			while (num >= 0 && !(jl8HZL7wNm[num].Time < P_0[0].Time))
			{
				num--;
			}
			num++;
			foreach (OjH2QVHZoARxtkRLMBCI item in P_0)
			{
				if (num < jl8HZL7wNm.Count)
				{
					for (; num < jl8HZL7wNm.Count; num++)
					{
						if (jl8HZL7wNm[num].Time >= item.Time)
						{
							num--;
							break;
						}
					}
					num++;
				}
				if (num == jl8HZL7wNm.Count || jl8HZL7wNm[num].Time > item.Time)
				{
					jl8HZL7wNm.Insert(num, item);
				}
				else
				{
					jl8HZL7wNm[num] = item;
				}
				num++;
			}
		}
		return true;
	}

	private static string gfRHZtERYYp(Symbol P_0, DataCycle P_1)
	{
		if (P_1 != null)
		{
			return le6HZUaNVuB(P_0, P_1.CycleBase, P_1.Repeat);
		}
		return null;
	}

	private static string le6HZUaNVuB(Symbol P_0, DataCycleBase P_1, int P_2)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (P_0 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				string text = zYZeUVHCh1Om9Qf74p6d.ztTHC8B0MOa(P_1, P_2);
				if (!text.IsNullOrEmpty())
				{
					return (string)dOtoJgDIQ0nQXONsLu46(P_0) + (string)RHABLpDIdfpqpbmShkt2(-1306877528 ^ -1306882824) + text;
				}
				return null;
			}
			default:
				return null;
			}
		}
	}

	public static List<OjH2QVHZoARxtkRLMBCI> MP6HZT4QbxW(Symbol P_0, DataCycle P_1)
	{
		string key = gfRHZtERYYp(P_0, P_1);
		Go7HZCLjSCR.TryGetValue(key, out var value);
		return value?.Jl8HZL7wNm1;
	}

	internal static void o6ovAIDIkY6Vl1oOPIHU()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void Ot37JhDI1hOcyOk6QuKx()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool OXeWO5DIbsX9BFv7Cajs()
	{
		return PFcc7gDIDvJZSpUMh0LS == null;
	}

	internal static LStMKXHZj9m30GIr08xj FMIT8lDINaoOt72EECPi()
	{
		return PFcc7gDIDvJZSpUMh0LS;
	}

	internal static object Hq7thRDI5cvaICPOB2XK(object P_0, DataCycleBase P_1, int P_2)
	{
		return le6HZUaNVuB((Symbol)P_0, P_1, P_2);
	}

	internal static void vuNfpmDIS3cIpP6PAHR3(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool qXdpM3DIxGT4qIXIkRe9(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static DateTime lj8qPnDILmHwBtYPEiaa()
	{
		return DateTime.Now;
	}

	internal static bool ffaCDQDIe7KEsVpK811y(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static DateTime LFXKKMDIsXbyJSIZ10HE(object P_0)
	{
		return ((OjH2QVHZoARxtkRLMBCI)P_0).Time;
	}

	internal static object FMC0stDIXtLw29WM61ou(object P_0, DateTime P_1)
	{
		return sDRHZRkBdYH((q7ohYNHZ1Db3CcCWYhdv)P_0, P_1);
	}

	internal static long JC9NavDIcAatgo1AWxrV(object P_0)
	{
		return TARHZO9ledt((DataCycle)P_0);
	}

	internal static bool XKRf5aDIjVPCAMNxXClJ(object P_0, DateTime P_1)
	{
		return jgAHZMid323((DataCycle)P_0, P_1);
	}

	internal static int LPEdliDIEi1YfsWpQGOo(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static object dOtoJgDIQ0nQXONsLu46(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static object RHABLpDIdfpqpbmShkt2(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
