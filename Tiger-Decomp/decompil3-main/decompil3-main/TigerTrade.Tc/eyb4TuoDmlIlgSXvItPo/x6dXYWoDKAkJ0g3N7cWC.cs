using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using c0MHhToamHULoqAC8ldx;
using Emx4XqolUdRVsFbdDg2U;
using G34SLLolOocgxnnCJXNm;
using hqRKukoBvZpc4wIphZe8;
using HVPJvOoSBSEDmHoxJgqx;
using I2aBuEo4rbl05pe3KZ0r;
using ijeRrFoNu72JuX3srdfL;
using K1GcsD5GTtMSlaiJI0Xh;
using KPao5po4q6hcHQ1KuWJh;
using lFFs11G39ohaRVknaFPC;
using LfvcrZajDy73S1HIm2xL;
using LPq3llG3QX4HMCBL7b1Q;
using Mdm2PJo4SvIAlHgawIWY;
using MOUaZQolyxwu75rP6Mrh;
using mV9y7loDS1OdZbIExIG1;
using Newtonsoft.Json;
using OWhORdGzgDWLWxLpUFfx;
using pGfL9NokiXleTUFUHXuu;
using r8oOHiajFPNBXu6XiAHj;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using tNudDpolHtj0euTcJsqP;
using U0vBVyGFnRQg4TAEWduY;
using uINuAJoBGspFy2iTQjRE;
using WebSocketSharp;
using WebSocketSharp.Net;
using x97CE55GhEYKgt7TSVZT;
using xYeFfCobpREJxgUFXqaH;
using XZeKVLoi8XK4NmZfZcFd;

namespace eyb4TuoDmlIlgSXvItPo;

internal sealed class x6dXYWoDKAkJ0g3N7cWC : Jdm3fXoltfC6GgGEjWLp
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct hUAZFmaCUSrZdtEFlDKU : IAsyncStateMachine
	{
		public int BScaCT7hDks;

		public AsyncVoidMethodBuilder yGGaCynn5nn;

		public x6dXYWoDKAkJ0g3N7cWC LPKaCZZ9hfY;

		public string D3YaCVbSOMr;

		private TaskAwaiter ipAaCC9kAYJ;

		internal static object hoyTQQLorhvjQWVyKVfi;

		private void MoveNext()
		{
			int num = BScaCT7hDks;
			x6dXYWoDKAkJ0g3N7cWC x6dXYWoDKAkJ0g3N7cWC2 = LPKaCZZ9hfY;
			try
			{
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					try
					{
						TaskAwaiter awaiter = default(TaskAwaiter);
						int num4;
						DateTime value = default(DateTime);
						if (num == 0)
						{
							awaiter = ipAaCC9kAYJ;
							ipAaCC9kAYJ = default(TaskAwaiter);
							num = (BScaCT7hDks = -1);
							int num3 = 5;
							num4 = num3;
						}
						else
						{
							if (!x6dXYWoDKAkJ0g3N7cWC2.Ficobd8m01q.TryGetValue(D3YaCVbSOMr, out value))
							{
								goto IL_01db;
							}
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
							{
								num4 = 0;
							}
						}
						goto IL_006f;
						IL_006f:
						while (true)
						{
							switch (num4)
							{
							case 6:
								num = (BScaCT7hDks = 0);
								ipAaCC9kAYJ = awaiter;
								yGGaCynn5nn.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								awaiter = x6dXYWoDKAkJ0g3N7cWC2.XHmobIrO1jT.oSZo4IoTlMq(jZ5R92o4CoKPBBExYQWe.d59NssaCjsDTbjTpaSuQ.WxfaCQxnnCE, new XO6tBIob3wSJR4IxLbFE
								{
									Symbol = D3YaCVbSOMr
								}).ContinueWith(x6dXYWoDKAkJ0g3N7cWC2.zgBoD3NrXpc, D3YaCVbSOMr).GetAwaiter();
								num4 = 3;
								continue;
							case 5:
								awaiter.GetResult();
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
								{
									num4 = 1;
								}
								continue;
							case 4:
								break;
							case 1:
								goto IL_01a3;
							default:
								goto IL_0201;
							case 3:
								if (!awaiter.IsCompleted)
								{
									num4 = 6;
									continue;
								}
								goto case 5;
							}
							break;
							IL_0201:
							if (value > ehnbOfLohoDgdh86qXFo())
							{
								num4 = 4;
								continue;
							}
							goto IL_01db;
						}
						goto end_IL_005f;
						IL_01a3:
						x6dXYWoDKAkJ0g3N7cWC2.Ficobd8m01q[D3YaCVbSOMr] = DateTime.UtcNow.AddSeconds(1.0);
						goto end_IL_005f;
						IL_01db:
						if (x6dXYWoDKAkJ0g3N7cWC2.aslobWy1a7Y == (dIkcZgolThiYOYbXneEx)0)
						{
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 != 0)
							{
								num4 = 2;
							}
							goto IL_006f;
						}
						goto IL_01a3;
						end_IL_005f:;
					}
					catch (Exception message)
					{
						x6dXYWoDKAkJ0g3N7cWC2.Log(message);
					}
					break;
				}
			}
			catch (Exception exception)
			{
				BScaCT7hDks = -2;
				int num5 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
				yGGaCynn5nn.SetException(exception);
				return;
			}
			while (true)
			{
				BScaCT7hDks = -2;
				int num6 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				case 1:
					continue;
				}
				yGGaCynn5nn.SetResult();
				return;
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			yGGaCynn5nn.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static hUAZFmaCUSrZdtEFlDKU()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static DateTime ehnbOfLohoDgdh86qXFo()
		{
			return DateTime.UtcNow;
		}

		internal static bool vuyjXnLoKlDw4mW9hyJF()
		{
			return hoyTQQLorhvjQWVyKVfi == null;
		}

		internal static object n8D6tDLomrWWnJKlraxH()
		{
			return hoyTQQLorhvjQWVyKVfi;
		}
	}

	[CompilerGenerated]
	private sealed class fej7a1aCra6eaEsIRPG0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct ET5o8wivEGynO7gOqLEx : IAsyncStateMachine
		{
			public int dOXivQySTdo;

			public AsyncTaskMethodBuilder pI5ivd4KQU8;

			public fej7a1aCra6eaEsIRPG0 XQYivgXbFU2;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter huXivRUDlDM;

			internal static object My28iTLMVVUn7t2OtSyk;

			private void MoveNext()
			{
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Invalid comparison between Unknown and I4
				int num = 1;
				int num2 = num;
				int num3 = default(int);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				while (true)
				{
					switch (num2)
					{
					case 1:
						num3 = dOXivQySTdo;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						pI5ivd4KQU8.SetResult();
						return;
					}
					fej7a1aCra6eaEsIRPG0 fej7a1aCra6eaEsIRPG = XQYivgXbFU2;
					try
					{
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								int num5;
								if (num3 == 0)
								{
									num5 = 6;
									goto IL_007b;
								}
								goto IL_0140;
								IL_0140:
								awaiter = gMVB81LMKsnSD8hgUfgO(Task.Delay(fej7a1aCra6eaEsIRPG.ms4aCmCyMQc), false).GetAwaiter();
								num5 = 5;
								goto IL_007b;
								IL_007b:
								while (true)
								{
									switch (num5)
									{
									case 1:
										pI5ivd4KQU8.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 6:
										awaiter = huXivRUDlDM;
										num5 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c != 0)
										{
											num5 = 4;
										}
										continue;
									case 5:
										if (awaiter.IsCompleted)
										{
											goto IL_011e;
										}
										num3 = (dOXivQySTdo = 0);
										huXivRUDlDM = awaiter;
										num5 = 1;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
										{
											num5 = 0;
										}
										continue;
									case 2:
										break;
									case 4:
										huXivRUDlDM = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
										num5 = 7;
										continue;
									case 3:
										fej7a1aCra6eaEsIRPG.bx1aCh61mMJ.wFJobgAaJ1v.Remove(fej7a1aCra6eaEsIRPG.oELaCweSSWI);
										num5 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
										{
											num5 = 0;
										}
										continue;
									case 7:
										num3 = (dOXivQySTdo = -1);
										goto IL_011e;
									default:
										{
											WebSocket kX5obcXe8uk = fej7a1aCra6eaEsIRPG.bx1aCh61mMJ.kX5obcXe8uk;
											if (kX5obcXe8uk != null && (int)kX5obcXe8uk.ReadyState == 1 && fej7a1aCra6eaEsIRPG.bx1aCh61mMJ.vhkobjgomrJ.ContainsKey(fej7a1aCra6eaEsIRPG.oELaCweSSWI))
											{
												fej7a1aCra6eaEsIRPG.bx1aCh61mMJ.GmNoDFMRXHR(fej7a1aCra6eaEsIRPG.oELaCweSSWI);
											}
											goto end_IL_007b;
										}
										IL_011e:
										awaiter.GetResult();
										num5 = 3;
										continue;
									}
									goto IL_0140;
									continue;
									end_IL_007b:
									break;
								}
							}
							catch
							{
							}
							break;
						}
					}
					catch (Exception exception)
					{
						dOXivQySTdo = -2;
						pI5ivd4KQU8.SetException(exception);
						int num6 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
						return;
					}
					dOXivQySTdo = -2;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
					{
						num2 = 2;
					}
				}
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				pI5ivd4KQU8.SetStateMachine(P_0);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}

			static ET5o8wivEGynO7gOqLEx()
			{
				F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
				pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			}

			internal static ConfiguredTaskAwaitable gMVB81LMKsnSD8hgUfgO(object P_0, bool P_1)
			{
				return ((Task)P_0).ConfigureAwait(P_1);
			}

			internal static bool QTcTCkLMClQlmU5Y1c9P()
			{
				return My28iTLMVVUn7t2OtSyk == null;
			}

			internal static object t93bo3LMrV6eanLaSahN()
			{
				return My28iTLMVVUn7t2OtSyk;
			}
		}

		public TimeSpan ms4aCmCyMQc;

		public x6dXYWoDKAkJ0g3N7cWC bx1aCh61mMJ;

		public string oELaCweSSWI;

		private static fej7a1aCra6eaEsIRPG0 eJSs4LLow93jCpH7GLkP;

		public fej7a1aCra6eaEsIRPG0()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		[AsyncStateMachine(typeof(ET5o8wivEGynO7gOqLEx))]
		internal Task mDeaCKYZZNY()
		{
			ET5o8wivEGynO7gOqLEx stateMachine = default(ET5o8wivEGynO7gOqLEx);
			stateMachine.pI5ivd4KQU8 = dQGmlXLoAOrtJifBreZx();
			stateMachine.XQYivgXbFU2 = this;
			stateMachine.dOXivQySTdo = -1;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				stateMachine.pI5ivd4KQU8.Start(ref stateMachine);
				return stateMachine.pI5ivd4KQU8.Task;
			}
		}

		static fej7a1aCra6eaEsIRPG0()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool SkEWVqLo72AR4YgYkRZy()
		{
			return eJSs4LLow93jCpH7GLkP == null;
		}

		internal static fej7a1aCra6eaEsIRPG0 eCPqV0Lo8kOALh9Z3yo9()
		{
			return eJSs4LLow93jCpH7GLkP;
		}

		internal static AsyncTaskMethodBuilder dQGmlXLoAOrtJifBreZx()
		{
			return AsyncTaskMethodBuilder.Create();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class gtBx8GaC7jgb8jbRYvxB
	{
		public static readonly gtBx8GaC7jgb8jbRYvxB sEpaCAcf8vN;

		public static Func<LesfqXoNpogLJQyFhfPG, string> llMaCPGU1wt;

		internal static gtBx8GaC7jgb8jbRYvxB tNsN1rLoP6qfnDRyGUQg;

		static gtBx8GaC7jgb8jbRYvxB()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			sRH5l2Lo3yfduTyVxNMA();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			sEpaCAcf8vN = new gtBx8GaC7jgb8jbRYvxB();
		}

		public gtBx8GaC7jgb8jbRYvxB()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal string n9YaC8ixpcH(LesfqXoNpogLJQyFhfPG s)
		{
			return (string)KDHxRLLopAhAmUVqOxPG(s);
		}

		internal static void sRH5l2Lo3yfduTyVxNMA()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool v9HGx3LoJCcccgOhucCC()
		{
			return tNsN1rLoP6qfnDRyGUQg == null;
		}

		internal static gtBx8GaC7jgb8jbRYvxB riS2oPLoFRnORe8UbV1m()
		{
			return tNsN1rLoP6qfnDRyGUQg;
		}

		internal static object KDHxRLLopAhAmUVqOxPG(object P_0)
		{
			return ((LesfqXoNpogLJQyFhfPG)P_0).XP4okY2VV5k;
		}
	}

	private readonly bool DdmobiwUoC1;

	private static long hFjoblcwYfN;

	private readonly string Lgwob4A721f;

	private readonly object VQUobDJBhMD;

	private readonly object kUCobb1cfQ2;

	[CompilerGenerated]
	private Action<TickEvent> LbQobNAZPPX;

	[CompilerGenerated]
	private Action<MarketDepthFullEvent> cPFobkqWNUs;

	[CompilerGenerated]
	private Action<MarketDepthDiffEvent> V3bob1oTQGE;

	[CompilerGenerated]
	private Action<SecurityEvent> VW2ob5aqOB9;

	[CompilerGenerated]
	private Action<SecurityEvent> XSZobSWFNZf;

	[CompilerGenerated]
	private Action<string, bool> nVfobxu683o;

	[CompilerGenerated]
	private Action<Exception> u8hobLh48DL;

	[CompilerGenerated]
	private Action<string> otEobe70RPu;

	public static string qgZobsIExjT;

	private readonly Timer Em2obX6GGY8;

	private WebSocket kX5obcXe8uk;

	private readonly Dictionary<string, Rybo1XGzd9ch5SOUQC2H> vhkobjgomrJ;

	private readonly Dictionary<string, rJkPoOoD5Rvt2742WnFb> RSHobE471P1;

	private readonly Dictionary<string, int> XyaobQ4xov0;

	private readonly Dictionary<string, DateTime> Ficobd8m01q;

	private readonly HashSet<string> wFJobgAaJ1v;

	private readonly DateTime O9WobRVUOfQ;

	private bool QG1ob6qqWlj;

	private readonly string QmaobM0hRw2;

	private readonly K2j1kDolMOXLRfZJQjhn QwjobOWWeUK;

	private readonly C3trUsajJIHJMtdo9pBg pK4obq7hp9m;

	private readonly w1TmOpo4OLasbmph2s4A XHmobIrO1jT;

	private readonly dIkcZgolThiYOYbXneEx aslobWy1a7Y;

	private Action TP0obtQSVCk;

	private readonly Action<string> TbIobUX31pm;

	private static readonly TimeSpan[] FpIobTI88oi;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> YmAobyvaKA2;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> PSUobZ3HZOd;

	private static x6dXYWoDKAkJ0g3N7cWC RDMmKHSV0Hb6lbr0ZOPE;

	[SpecialName]
	[CompilerGenerated]
	public void sTolvGsSqbW(Action<TickEvent> P_0)
	{
		Action<TickEvent> action = LbQobNAZPPX;
		Action<TickEvent> action2;
		do
		{
			action2 = action;
			Action<TickEvent> value = (Action<TickEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref LbQobNAZPPX, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void L6xlvYWS4y4(Action<TickEvent> P_0)
	{
		Action<TickEvent> action = LbQobNAZPPX;
		Action<TickEvent> action2;
		do
		{
			action2 = action;
			Action<TickEvent> value = (Action<TickEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref LbQobNAZPPX, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void puvloJ4L5Eq(Action<MarketDepthFullEvent> P_0)
	{
		Action<MarketDepthFullEvent> action = cPFobkqWNUs;
		Action<MarketDepthFullEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthFullEvent> value = (Action<MarketDepthFullEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref cPFobkqWNUs, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void QvFloFlJ5cR(Action<MarketDepthFullEvent> P_0)
	{
		Action<MarketDepthFullEvent> action = cPFobkqWNUs;
		Action<MarketDepthFullEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthFullEvent> value = (Action<MarketDepthFullEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref cPFobkqWNUs, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ikolopXNCnV(Action<MarketDepthDiffEvent> P_0)
	{
		Action<MarketDepthDiffEvent> action = V3bob1oTQGE;
		Action<MarketDepthDiffEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthDiffEvent> value = (Action<MarketDepthDiffEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref V3bob1oTQGE, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void PuelouGmXeq(Action<MarketDepthDiffEvent> P_0)
	{
		Action<MarketDepthDiffEvent> action = V3bob1oTQGE;
		Action<MarketDepthDiffEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthDiffEvent> value = (Action<MarketDepthDiffEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref V3bob1oTQGE, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void iS7lvoQZRBo(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = VW2ob5aqOB9;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref VW2ob5aqOB9, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void T83lvvVSHpP(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = VW2ob5aqOB9;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref VW2ob5aqOB9, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void HvElvatNnkM(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = XSZobSWFNZf;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref XSZobSWFNZf, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void auRlviFMnLp(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = XSZobSWFNZf;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref XSZobSWFNZf, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void lK1lv00pgeu(Action<string, bool> P_0)
	{
		Action<string, bool> action = nVfobxu683o;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref nVfobxu683o, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void YLDlv2bKTEJ(Action<string, bool> P_0)
	{
		Action<string, bool> action = nVfobxu683o;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref nVfobxu683o, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void FZrlvfRH5vZ(Action<Exception> P_0)
	{
		Action<Exception> action = u8hobLh48DL;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref u8hobLh48DL, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void DRFlv9K5tCP(Action<Exception> P_0)
	{
		Action<Exception> action = u8hobLh48DL;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref u8hobLh48DL, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void NgNlv47DpPM(Action<string> P_0)
	{
		Action<string> action = otEobe70RPu;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref otEobe70RPu, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ShYlvDR9Ji7(Action<string> P_0)
	{
		Action<string> action = otEobe70RPu;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref otEobe70RPu, value, action2);
		}
		while ((object)action != action2);
	}

	public x6dXYWoDKAkJ0g3N7cWC(w1TmOpo4OLasbmph2s4A P_0, dIkcZgolThiYOYbXneEx P_1, string P_2, K2j1kDolMOXLRfZJQjhn P_3, C3trUsajJIHJMtdo9pBg P_4, Action P_5, Action<string> P_6, string P_7)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		DdmobiwUoC1 = Convert.ToBoolean(ConfigurationManager.AppSettings[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-44540535 ^ -44486683)]);
		VQUobDJBhMD = new object();
		kUCobb1cfQ2 = new object();
		vhkobjgomrJ = new Dictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		RSHobE471P1 = new Dictionary<string, rJkPoOoD5Rvt2742WnFb>();
		XyaobQ4xov0 = new Dictionary<string, int>();
		Ficobd8m01q = new Dictionary<string, DateTime>();
		wFJobgAaJ1v = new HashSet<string>();
		YmAobyvaKA2 = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		PSUobZ3HZOd = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		base._002Ector();
		Lgwob4A721f = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-45476899 ^ -45391551), Interlocked.Increment(ref hFjoblcwYfN), P_3, P_7);
		O9WobRVUOfQ = new DateTime(1970, 1, 1);
		XHmobIrO1jT = P_0;
		aslobWy1a7Y = P_1;
		QmaobM0hRw2 = P_2;
		QwjobOWWeUK = P_3;
		pK4obq7hp9m = P_4;
		TP0obtQSVCk = P_5;
		TbIobUX31pm = P_6;
		Em2obX6GGY8 = new Timer(p6IoDwm4PLW, null, -1, -1);
	}

	public void lihlfMp6ULY()
	{
		P1AoDhsx5AA();
	}

	public void Disconnect()
	{
		XWToD7xNRu2();
	}

	private void P1AoDhsx5AA()
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num;
			if (kX5obcXe8uk != null)
			{
				num = 4;
				goto IL_0020;
			}
			goto IL_01fe;
			IL_01fe:
			R7drO2SV9xdojWbI7JBO(RSHobE471P1);
			kX5obcXe8uk = new WebSocket(QmaobM0hRw2, Array.Empty<string>())
			{
				EmitOnPing = true,
				WaitTime = TimeSpan.FromSeconds(10.0)
			};
			((SslConfiguration)PF7KN9SVnn8hZN297DPg(kX5obcXe8uk)).EnabledSslProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;
			num = 5;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
			{
				num = 5;
			}
			goto IL_0020;
			IL_0020:
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 4:
					break;
				case 2:
					osR1fmSVoQhY69Z08v0R(kX5obcXe8uk, new EventHandler(dc9oD8Shr7O));
					kX5obcXe8uk.OnClose += whNoDAxfb4e;
					kX5obcXe8uk.OnError += LwroDPDj2p9;
					kX5obcXe8uk.OnMessage += LVpoDJqqCP0;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
					{
						num = 1;
					}
					continue;
				case 5:
					if (pK4obq7hp9m.TRAaE0bpPZ4())
					{
						kX5obcXe8uk.SetProxy(pK4obq7hp9m.Url, (string)gYrn5iSVGtPYCEBrHrlK(pK4obq7hp9m), (string)NHHpKESVYgToOkBQwakA(pK4obq7hp9m));
						num = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
						{
							num = 0;
						}
						continue;
					}
					goto case 2;
				default:
					kX5obcXe8uk.ConnectAsync();
					num = 3;
					continue;
				case 1:
					s10oOfSVBZvq97OjZWay(Em2obX6GGY8, ddExunSVv6vURqyLE5yE(5.0), TimeSpan.FromSeconds(30.0));
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			if ((int)EfOy2oSVfRK6KbKgWGfX(kX5obcXe8uk) == 1 || (int)kX5obcXe8uk.ReadyState == 0)
			{
				return;
			}
			goto IL_01fe;
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	private void p6IoDwm4PLW(object P_0)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I4, but got Unknown
		WebSocket obj = kX5obcXe8uk;
		WebSocketState? val = default(WebSocketState?);
		int num;
		if (obj == null)
		{
			val = null;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		WebSocketState? val2 = obj.ReadyState;
		goto IL_0124;
		IL_0124:
		WebSocketState? val3 = val2;
		if (val3.HasValue)
		{
			num = 3;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
			{
				num = 3;
			}
			goto IL_0009;
		}
		goto IL_0058;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
				kX5obcXe8uk.Send(qgZobsIExjT);
				return;
			case 1:
				goto IL_00ba;
			default:
				goto end_IL_0009;
			case 4:
				return;
			}
			WebSocketState valueOrDefault = val3.GetValueOrDefault();
			int num2;
			switch ((int)valueOrDefault)
			{
			case 0:
			case 2:
				return;
			case 1:
			{
				WebSocket obj2 = kX5obcXe8uk;
				if (obj2 != null && obj2.IsAlive)
				{
					num2 = 2;
					goto IL_0005;
				}
				break;
			}
			}
			goto IL_0058;
			IL_00ba:
			WebSocket obj3 = kX5obcXe8uk;
			if (obj3 == null)
			{
				num2 = 4;
				goto IL_0005;
			}
			obj3.CloseAsync();
			return;
			IL_0005:
			num = num2;
			continue;
			end_IL_0009:
			break;
		}
		val2 = val;
		goto IL_0124;
		IL_0058:
		MA4obGtmBc1(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1801468030 ^ -1801538246));
		num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	private void XWToD7xNRu2()
	{
		try
		{
			hFjoblcwYfN = 0L;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					QG1ob6qqWlj = true;
					TP0obtQSVCk = null;
					WebSocket obj = kX5obcXe8uk;
					if (obj == null)
					{
						goto default;
					}
					obj.CloseAsync();
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
					{
						num = 0;
					}
					break;
				}
				case 1:
					Ficobd8m01q.Clear();
					wFJobgAaJ1v.Clear();
					return;
				default:
					XyaobQ4xov0.Clear();
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
					{
						num = 1;
					}
					break;
				}
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	private void dc9oD8Shr7O(object P_0, EventArgs P_1)
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
				MA4obGtmBc1(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2074141628 ^ -2074185840));
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
			{
				QG1ob6qqWlj = false;
				p6IoDwm4PLW(null);
				Action tP0obtQSVCk = TP0obtQSVCk;
				if (tP0obtQSVCk == null)
				{
					return;
				}
				tP0obtQSVCk();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void whNoDAxfb4e(object P_0, EventArgs P_1)
	{
		MA4obGtmBc1(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-839659358 ^ -839736506));
		Em2obX6GGY8.Change(-1, -1);
		RSHobE471P1.Clear();
		YIJBF2SVaUCFH0nJ9ojy(vhkobjgomrJ);
		object obj = kUCobb1cfQ2;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num2 = 2;
					while (true)
					{
						switch (num2)
						{
						case 1:
							kX5obcXe8uk.OnOpen -= dc9oD8Shr7O;
							kX5obcXe8uk.OnClose -= whNoDAxfb4e;
							kX5obcXe8uk.OnError -= LwroDPDj2p9;
							kX5obcXe8uk.OnMessage -= LVpoDJqqCP0;
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
							{
								num2 = 0;
							}
							continue;
						case 2:
							if (kX5obcXe8uk != null)
							{
								num2 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							break;
						default:
							kX5obcXe8uk = null;
							break;
						}
						break;
					}
				}
				finally
				{
					if (!lockTaken)
					{
						int num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
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
						Monitor.Exit(obj);
					}
				}
				goto default;
			}
			default:
				if (!QG1ob6qqWlj)
				{
					Thread.Sleep(1000);
					num = 3;
					break;
				}
				return;
			case 3:
				P1AoDhsx5AA();
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	private void LwroDPDj2p9(object P_0, ErrorEventArgs P_1)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		int num = 2;
		int num2 = num;
		WebSocket val = default(WebSocket);
		while (true)
		{
			switch (num2)
			{
			default:
				if ((int)EfOy2oSVfRK6KbKgWGfX(val) != 1)
				{
					return;
				}
				try
				{
					Log(P_1.Exception);
					zIZSBPSV4pdpdDMb4Z9h(val);
					return;
				}
				catch (Exception message)
				{
					Log(message);
					return;
				}
			case 1:
				MA4obGtmBc1((string)U5jeJSSViicLGXlURdv8(P_1.Exception));
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
			case 4:
				val = (WebSocket)((P_0 is WebSocket) ? P_0 : null);
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				if (P_1.Exception == null)
				{
					if (!TPGHUKSVlo9mO3PdZdI2(P_1.Message))
					{
						MA4obGtmBc1(P_1.Message);
						num2 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 3;
				}
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void LVpoDJqqCP0(object P_0, MessageEventArgs P_1)
	{
		if (P_1.IsPing)
		{
			return;
		}
		try
		{
			TadhShoka0TYAiVjXOgB tadhShoka0TYAiVjXOgB = JsonConvert.DeserializeObject<TadhShoka0TYAiVjXOgB>(P_1.Data);
			if (tadhShoka0TYAiVjXOgB == null)
			{
				return;
			}
			int num = 6;
			string[] array = default(string[]);
			int num3 = default(int);
			int? num2 = default(int?);
			while (true)
			{
				switch (num)
				{
				default:
					if (!string.IsNullOrWhiteSpace(tadhShoka0TYAiVjXOgB.Message))
					{
						array = (string[])UFXbHvSVD6kqL8aEPLee(tadhShoka0TYAiVjXOgB.Message, new char[1] { ',' });
						num3 = 0;
						goto IL_016d;
					}
					return;
				case 6:
					num2 = tadhShoka0TYAiVjXOgB.Code;
					num = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
					{
						num = 2;
					}
					break;
				case 3:
					if (num2.HasValue)
					{
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
						{
							num = 5;
						}
						break;
					}
					return;
				case 4:
					if (num2 != 0)
					{
						return;
					}
					goto default;
				case 2:
				{
					string text = array[num3];
					hfpoDzX9a4q(text);
					num3++;
					goto IL_016d;
				}
				case 5:
					num2 = tadhShoka0TYAiVjXOgB.Code;
					num = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
					IL_016d:
					if (num3 >= array.Length)
					{
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 != 0)
						{
							num = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
		catch (JsonReaderException)
		{
		}
		catch (Exception)
		{
			return;
		}
		TEswCdoi7ke2P9qp1Xmq tEswCdoi7ke2P9qp1Xmq = default(TEswCdoi7ke2P9qp1Xmq);
		List<ecfDaDol23uUJl1nvGXX>.Enumerator enumerator = default(List<ecfDaDol23uUJl1nvGXX>.Enumerator);
		Rybo1XGzd9ch5SOUQC2H value = default(Rybo1XGzd9ch5SOUQC2H);
		Symbol symbol = default(Symbol);
		while (true)
		{
			int num4 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
			{
				num4 = 1;
			}
			switch (num4)
			{
			case 1:
				try
				{
					PsO19ZoBo5RP3Z6m6RKY psO19ZoBo5RP3Z6m6RKY = (PsO19ZoBo5RP3Z6m6RKY)pl3gReSVk9Ki6VcQSsrW(Bj1rhLSVbMvb0tJl1rNf(P_1) ?? Ajs5fiSVNi913aX5jKZS(Encoding.UTF8, P_1.Data));
					if (psO19ZoBo5RP3Z6m6RKY == null)
					{
						return;
					}
					int num6;
					if (psO19ZoBo5RP3Z6m6RKY is JKiJRyoaKDmkFpOUPDi9 jKiJRyoaKDmkFpOUPDi)
					{
						Q0DoDunl25j(jKiJRyoaKDmkFpOUPDi);
						int num5 = 5;
						num6 = num5;
					}
					else
					{
						tEswCdoi7ke2P9qp1Xmq = psO19ZoBo5RP3Z6m6RKY as TEswCdoi7ke2P9qp1Xmq;
						num6 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
						{
							num6 = 0;
						}
					}
					while (true)
					{
						switch (num6)
						{
						case 2:
							enumerator = tEswCdoi7ke2P9qp1Xmq.Deals.GetEnumerator();
							num6 = 3;
							break;
						case 4:
							if (!vhkobjgomrJ.TryGetValue(tEswCdoi7ke2P9qp1Xmq.Symbol, out value) || !value.m54GzFaRoc7)
							{
								return;
							}
							num6 = 6;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 != 0)
							{
								num6 = 5;
							}
							break;
						case 6:
						case 7:
							symbol = value.Symbol;
							num6 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
							{
								num6 = 2;
							}
							break;
						case 3:
							try
							{
								while (enumerator.MoveNext())
								{
									ecfDaDol23uUJl1nvGXX current = enumerator.Current;
									int num7 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
									{
										num7 = 0;
									}
									switch (num7)
									{
									}
									MEkob2qRM7u(symbol, current);
								}
								return;
							}
							finally
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						case 1:
							return;
						default:
							if (tEswCdoi7ke2P9qp1Xmq == null)
							{
								num6 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
								{
									num6 = 1;
								}
								break;
							}
							goto case 4;
						case 5:
							return;
						}
					}
				}
				catch (Exception message)
				{
					Log(P_1.Data, show: false);
					int num8 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					}
					Log(message);
					return;
				}
			}
		}
	}

	[AsyncStateMachine(typeof(hUAZFmaCUSrZdtEFlDKU))]
	private void GmNoDFMRXHR(string P_0)
	{
		int num = 1;
		int num2 = num;
		hUAZFmaCUSrZdtEFlDKU stateMachine = default(hUAZFmaCUSrZdtEFlDKU);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine.yGGaCynn5nn = AsyncVoidMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			stateMachine.LPKaCZZ9hfY = this;
			stateMachine.D3YaCVbSOMr = P_0;
			stateMachine.BScaCT7hDks = -1;
			stateMachine.yGGaCynn5nn.Start(ref stateMachine);
			num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
			{
				num2 = 2;
			}
		}
	}

	private void zgBoD3NrXpc(Task<lEa2hGoSvF3S7lY1ZaNU> P_0, object P_1)
	{
		string text = (string)P_1;
		if (P_0.Exception != null)
		{
			if (P_0.Exception.InnerException is tOdMaho456qG7qryE7dc tOdMaho456qG7qryE7dc)
			{
				Log(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7DB10E6E ^ 0x7DB073F0) + text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-338769610 ^ -338718598) + tOdMaho456qG7qryE7dc.Error.jNCo4RBbAjh, show: true);
			}
			else
			{
				Log(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1A5F1B9E ^ 0x1A5E6600) + text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1306877528 ^ -1306792126), show: true);
			}
			Log(P_0.Exception.InnerException ?? P_0.Exception);
			if (RSHobE471P1.TryGetValue(text, out var value))
			{
				value.ALZoDLwr4Df(null, 0L);
			}
			XqCoDp9H7VP(text);
		}
		else
		{
			if (P_0.Status != TaskStatus.RanToCompletion)
			{
				return;
			}
			lEa2hGoSvF3S7lY1ZaNU result = P_0.Result;
			if (!string.IsNullOrEmpty(text) && vhkobjgomrJ.TryGetValue(text, out var value2) && RSHobE471P1.TryGetValue(text, out var value3))
			{
				if (!value3.ALZoDLwr4Df(result, XHmobIrO1jT.Swmo4T0OStT()))
				{
					XqCoDp9H7VP(text);
					return;
				}
				MarketDepthFullEvent marketDepthFullEvent = IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk(value2.Symbol);
				value3.odClvnSDwKl(value2.Symbol, marketDepthFullEvent);
				marketDepthFullEvent.Version.zncG3eO1nYd(result.LastUpdateId);
				cPFobkqWNUs?.Invoke(marketDepthFullEvent);
				XyaobQ4xov0[text] = 0;
				Ficobd8m01q.Remove(text);
				wFJobgAaJ1v.Remove(text);
			}
		}
	}

	private void XqCoDp9H7VP(string P_0)
	{
		int num = 5;
		int num2 = num;
		fej7a1aCra6eaEsIRPG0 fej7a1aCra6eaEsIRPG = default(fej7a1aCra6eaEsIRPG0);
		int value = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 6:
				fej7a1aCra6eaEsIRPG.ms4aCmCyMQc = FpIobTI88oi[value - 1];
				Ficobd8m01q[fej7a1aCra6eaEsIRPG.oELaCweSSWI] = DateTime.UtcNow.Add(fej7a1aCra6eaEsIRPG.ms4aCmCyMQc);
				num2 = 2;
				break;
			case 4:
			{
				fej7a1aCra6eaEsIRPG.bx1aCh61mMJ = this;
				fej7a1aCra6eaEsIRPG.oELaCweSSWI = P_0;
				XyaobQ4xov0.TryGetValue(fej7a1aCra6eaEsIRPG.oELaCweSSWI, out value);
				if (value < 4)
				{
					value++;
					num2 = 3;
					break;
				}
				if (!RSHobE471P1.TryGetValue(fej7a1aCra6eaEsIRPG.oELaCweSSWI, out var value2))
				{
					return;
				}
				value2.oEOoDxMlVwG();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				Task.Run((Func<Task>)fej7a1aCra6eaEsIRPG.mDeaCKYZZNY);
				return;
			case 2:
				if (!wFJobgAaJ1v.Add(fej7a1aCra6eaEsIRPG.oELaCweSSWI))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				fej7a1aCra6eaEsIRPG = new fej7a1aCra6eaEsIRPG0();
				num2 = 4;
				break;
			case 3:
				XyaobQ4xov0[fej7a1aCra6eaEsIRPG.oELaCweSSWI] = value;
				num2 = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void Q0DoDunl25j(JKiJRyoaKDmkFpOUPDi9 P_0)
	{
		try
		{
			if (string.IsNullOrEmpty((string)N2Oj51SV1Nu9f0uS8KtV(P_0)) || !vhkobjgomrJ.TryGetValue(P_0.Symbol, out var value))
			{
				return;
			}
			rJkPoOoD5Rvt2742WnFb rJkPoOoD5Rvt2742WnFb = wSdob0G9FZT(P_0.Symbol, value.E07GzJKBNZY);
			MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
			int num;
			if (rJkPoOoD5Rvt2742WnFb.kOhoDeQDsSf(P_0, OSK61CSV52lgejWLi6yc(XHmobIrO1jT)))
			{
				marketDepthFullEvent = (MarketDepthFullEvent)tCrtAOSVxj1ruYwZVxt0(ccpdWVSVSHxrI5J15vIL(value));
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
				{
					num = 1;
				}
			}
			else
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
				{
					marketDepthFullEvent.Version.zncG3eO1nYd(zqEVAYSVLMwWcO2wg3n6(P_0));
					int num2 = 3;
					num = num2;
					break;
				}
				case 2:
					return;
				case 3:
				{
					rJkPoOoD5Rvt2742WnFb.odClvnSDwKl((Symbol)ccpdWVSVSHxrI5J15vIL(value), marketDepthFullEvent);
					Action<MarketDepthFullEvent> action = cPFobkqWNUs;
					if (action == null)
					{
						return;
					}
					action(marketDepthFullEvent);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
					{
						num = 0;
					}
					break;
				}
				case 0:
					return;
				}
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	private void hfpoDzX9a4q(string P_0)
	{
		string[] array = P_0.Split('@');
		if (array.Length != 4 || !array[1].Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28AC012)))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
		{
			num = 0;
		}
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				if (string.IsNullOrEmpty(text) || !vhkobjgomrJ.TryGetValue(text, out var value))
				{
					return;
				}
				wSdob0G9FZT(text, value.E07GzJKBNZY);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 != 0)
				{
					num = 0;
				}
				break;
			}
			default:
				text = array[3];
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	private rJkPoOoD5Rvt2742WnFb wSdob0G9FZT(string P_0, bool P_1)
	{
		Dictionary<string, rJkPoOoD5Rvt2742WnFb> rSHobE471P = RSHobE471P1;
		bool lockTaken = false;
		rJkPoOoD5Rvt2742WnFb value;
		rJkPoOoD5Rvt2742WnFb result = default(rJkPoOoD5Rvt2742WnFb);
		try
		{
			Monitor.Enter(rSHobE471P, ref lockTaken);
			int num;
			if (RSHobE471P1.TryGetValue(P_0, out value))
			{
				if (!P_1)
				{
					RSHobE471P1.Remove(P_0);
				}
				result = value;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
				{
					num = 0;
				}
				goto IL_002a;
			}
			goto IL_009a;
			IL_009a:
			RSHobE471P1.Add(P_0, value = new rJkPoOoD5Rvt2742WnFb());
			num = 2;
			goto IL_002a;
			IL_002a:
			switch (num)
			{
			default:
				goto end_IL_0018;
			case 0:
				goto end_IL_0018;
			case 1:
				break;
			case 2:
				goto IL_010e;
			}
			goto IL_009a;
			end_IL_0018:;
		}
		finally
		{
			if (lockTaken)
			{
				zTbusCSVewNII6XcTlaL(rSHobE471P);
			}
		}
		return result;
		IL_010e:
		GmNoDFMRXHR(P_0);
		int num2 = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
		{
			num2 = 0;
		}
		return num2 switch
		{
			_ => value, 
		};
	}

	private void MEkob2qRM7u(Symbol P_0, ecfDaDol23uUJl1nvGXX P_1)
	{
		try
		{
			TickEvent tickEvent = (TickEvent)At0WtISVsDvDANuZRTvR(P_0);
			tickEvent.Side = filRGISVXaCBoLix2dcX(P_1.TradeType);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 1:
					LbQobNAZPPX?.Invoke(tickEvent);
					return;
				case 2:
					tickEvent.Time = fd7obn6Iltu(P_1.Time);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
					{
						num = 0;
					}
					continue;
				}
				wKZ39SSVjTZZ8UCletFa(tickEvent, t7FlsuSVchRhfEWKPtf0(P_0, (double)P_1.Price));
				gxfsgTSVdybMuKIUyDyC(tickEvent, VVDFUKSVQPbDUYVIvpca(P_0, (double)XGuOZKSVEDEohXQwYXZW(P_1)));
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
				{
					num = 1;
				}
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	public void oW1lYsReHKK(params Rybo1XGzd9ch5SOUQC2H[] symbols)
	{
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Invalid comparison between Unknown and I4
		object vQUobDJBhMD = VQUobDJBhMD;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(vQUobDJBhMD, ref lockTaken);
			try
			{
				WebSocket obj = kX5obcXe8uk;
				int num2;
				List<LesfqXoNpogLJQyFhfPG> list = default(List<LesfqXoNpogLJQyFhfPG>);
				if (obj == null)
				{
					num2 = 19;
				}
				else
				{
					if ((int)obj.ReadyState != 1)
					{
						goto IL_0580;
					}
					list = new List<LesfqXoNpogLJQyFhfPG>();
					num2 = 3;
				}
				goto IL_0042;
				IL_0042:
				LesfqXoNpogLJQyFhfPG lesfqXoNpogLJQyFhfPG = default(LesfqXoNpogLJQyFhfPG);
				Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = default(Rybo1XGzd9ch5SOUQC2H);
				Rybo1XGzd9ch5SOUQC2H value = default(Rybo1XGzd9ch5SOUQC2H);
				List<LesfqXoNpogLJQyFhfPG> list2 = default(List<LesfqXoNpogLJQyFhfPG>);
				bool flag = default(bool);
				LesfqXoNpogLJQyFhfPG lesfqXoNpogLJQyFhfPG2 = default(LesfqXoNpogLJQyFhfPG);
				int num3 = default(int);
				Rybo1XGzd9ch5SOUQC2H[] array = default(Rybo1XGzd9ch5SOUQC2H[]);
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 15:
						list.Add(lesfqXoNpogLJQyFhfPG);
						num2 = 11;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
						{
							num2 = 11;
						}
						continue;
					case 6:
						if (rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY)
						{
							num2 = 21;
							continue;
						}
						goto IL_0160;
					case 7:
						if (!rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY && value.E07GzJKBNZY)
						{
							wNOMTKSVR8DTwKHMxa7X(lesfqXoNpogLJQyFhfPG, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--500511424 ^ 0x1DD44CFA));
							list2.Add(lesfqXoNpogLJQyFhfPG);
						}
						goto case 11;
					case 5:
						x9KobYHBvxc(list, _0020: true);
						goto IL_0171;
					case 8:
						if (!flag)
						{
							num2 = 13;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
							{
								num2 = 17;
							}
							continue;
						}
						goto case 1;
					case 21:
						if (!flag)
						{
							num2 = 12;
							continue;
						}
						goto case 9;
					case 16:
						vhkobjgomrJ[(string)ztpHs7SVgA0EQ1WZYMrn(value)] = value;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						if (list.Count <= 0)
						{
							goto IL_0171;
						}
						goto case 5;
					case 9:
						if (!value.E07GzJKBNZY)
						{
							num2 = 18;
							continue;
						}
						goto IL_0160;
					case 20:
						if (flag && !rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7 && value.m54GzFaRoc7)
						{
							lesfqXoNpogLJQyFhfPG2.fXfok2B6ka9 = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1087080834 ^ -1087043516);
							list2.Add(lesfqXoNpogLJQyFhfPG2);
						}
						goto case 8;
					case 11:
						if (QwjobOWWeUK.HasFlag(K2j1kDolMOXLRfZJQjhn.Trades))
						{
							num2 = 5;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
							{
								num2 = 10;
							}
							continue;
						}
						goto case 8;
					case 17:
						value = new Rybo1XGzd9ch5SOUQC2H(rybo1XGzd9ch5SOUQC2H.Symbol, rybo1XGzd9ch5SOUQC2H.Qa2Gz62Cyav())
						{
							Code = rybo1XGzd9ch5SOUQC2H.Code
						};
						num2 = 16;
						continue;
					case 10:
					{
						LesfqXoNpogLJQyFhfPG lesfqXoNpogLJQyFhfPG3 = new LesfqXoNpogLJQyFhfPG();
						see99TSV6v4JlguuPPwP(lesfqXoNpogLJQyFhfPG3, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1606927328 ^ -1606860166) + (string)ztpHs7SVgA0EQ1WZYMrn(rybo1XGzd9ch5SOUQC2H));
						lesfqXoNpogLJQyFhfPG2 = lesfqXoNpogLJQyFhfPG3;
						num2 = 14;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
						{
							num2 = 14;
						}
						continue;
					}
					case 23:
						if (num3 >= array.Length)
						{
							goto case 2;
						}
						rybo1XGzd9ch5SOUQC2H = array[num3];
						flag = vhkobjgomrJ.TryGetValue(rybo1XGzd9ch5SOUQC2H.Code, out value);
						if (QwjobOWWeUK.HasFlag((K2j1kDolMOXLRfZJQjhn)4))
						{
							num2 = 22;
							continue;
						}
						goto case 11;
					case 1:
						value.kHYGzP3WQN1 = rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1;
						value.E07GzJKBNZY = rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY;
						value.m54GzFaRoc7 = rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7;
						num3++;
						goto case 23;
					case 4:
						return;
					case 12:
					case 18:
						lesfqXoNpogLJQyFhfPG.fXfok2B6ka9 = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x50C1C840 ^ 0x50C0B096);
						num2 = 15;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
						{
							num2 = 8;
						}
						continue;
					case 14:
						if (rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7)
						{
							if (!flag || !value.m54GzFaRoc7)
							{
								lesfqXoNpogLJQyFhfPG2.fXfok2B6ka9 = (string)L0LEQoSVMuqY8tyCvlER(0x1D7BA1ED ^ 0x1D7AD93B);
								list.Add(lesfqXoNpogLJQyFhfPG2);
								Action<string> action = otEobe70RPu;
								if (action == null)
								{
									goto case 8;
								}
								action(rybo1XGzd9ch5SOUQC2H.Code);
								num2 = 8;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 20;
						}
						num2 = 5;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
						{
							num2 = 20;
						}
						continue;
					case 3:
						list2 = new List<LesfqXoNpogLJQyFhfPG>();
						array = symbols;
						num3 = 0;
						num2 = 23;
						continue;
					case 22:
						lesfqXoNpogLJQyFhfPG = new LesfqXoNpogLJQyFhfPG
						{
							XP4okY2VV5k = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4662F6AF ^ 0x46638B49) + (string)ztpHs7SVgA0EQ1WZYMrn(rybo1XGzd9ch5SOUQC2H)
						};
						num2 = 6;
						continue;
					case 0:
						return;
					case 19:
						break;
					case 13:
						return;
						IL_0160:
						if (flag)
						{
							num2 = 7;
							continue;
						}
						goto case 11;
						IL_0171:
						if (list2.Count <= 0)
						{
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
							{
								num2 = 0;
							}
							continue;
						}
						x9KobYHBvxc(list2, _0020: false);
						num2 = 9;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					break;
				}
				goto IL_0580;
				IL_0580:
				num2 = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
				{
					num2 = 4;
				}
				goto IL_0042;
			}
			catch (Exception obj2)
			{
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				}
				u8hobLh48DL?.Invoke(obj2);
			}
		}
		finally
		{
			if (lockTaken)
			{
				zTbusCSVewNII6XcTlaL(vQUobDJBhMD);
			}
		}
	}

	[SpecialName]
	public bool VT2oboXFRvx()
	{
		return TowXqeSVOuK5m66OIVva(YmAobyvaKA2) < 30;
	}

	[SpecialName]
	public bool NDmobB8dMRI()
	{
		return YmAobyvaKA2.Count == 0;
	}

	public void L18obHaXUqU(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		YmAobyvaKA2.TryAdd((string)ztpHs7SVgA0EQ1WZYMrn(P_0), P_0);
	}

	public void l61obfWS9nH(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		YmAobyvaKA2.TryRemove(P_0.Code, out var _);
		PSUobZ3HZOd.TryAdd(P_0.Code, P_0);
	}

	public void nGYob9fq9O2()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!YmAobyvaKA2.Any())
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_0074;
			default:
				{
					if (!PSUobZ3HZOd.Any())
					{
						break;
					}
					goto IL_0074;
				}
				IL_0074:
				oW1lYsReHKK(YmAobyvaKA2.Values.Union(PSUobZ3HZOd.Values).ToArray());
				break;
			}
			break;
		}
		PSUobZ3HZOd.Clear();
	}

	private DateTime fd7obn6Iltu(double P_0)
	{
		return O9WobRVUOfQ.AddMilliseconds(P_0);
	}

	private void Log(string message, bool show)
	{
		nVfobxu683o?.Invoke(message, show);
	}

	private void Log(Exception message)
	{
		u8hobLh48DL?.Invoke(message);
	}

	private void MA4obGtmBc1(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (DdmobiwUoC1)
				{
					TbIobUX31pm?.Invoke((string)kIspmuSVqNhXE8LgKFJQ(Lgwob4A721f, L0LEQoSVMuqY8tyCvlER(0x28BBDCA ^ 0x28B1666), P_0));
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static x6dXYWoDKAkJ0g3N7cWC()
	{
		o3Q5BeSVIm2Mk6u7wxhm();
		d5ejolSVWpU8asGx9NkG();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				FpIobTI88oi = new TimeSpan[4]
				{
					TimeSpan.FromSeconds(1.0),
					TimeSpan.FromSeconds(2.0),
					TimeSpan.FromSeconds(5.0),
					TimeSpan.FromSeconds(10.0)
				};
				return;
			case 1:
				itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
				qgZobsIExjT = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--146713930 ^ 0x8BFD3E4);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void x9KobYHBvxc(List<LesfqXoNpogLJQyFhfPG> P_0, bool P_1)
	{
		foreach (List<LesfqXoNpogLJQyFhfPG> item in HGVEngaj4mi935x6J5oj.bZRajbXFqnt(P_0, 15))
		{
			LesfqXoNpogLJQyFhfPG lesfqXoNpogLJQyFhfPG = new LesfqXoNpogLJQyFhfPG
			{
				fXfok2B6ka9 = P_0.FirstOrDefault()?.fXfok2B6ka9,
				htvok9YXJoT = item.Select((LesfqXoNpogLJQyFhfPG s) => (string)gtBx8GaC7jgb8jbRYvxB.KDHxRLLopAhAmUVqOxPG(s)).ToArray()
			};
			kX5obcXe8uk.Send(JsonConvert.SerializeObject((object)lesfqXoNpogLJQyFhfPG));
		}
		string arg = (P_1 ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380473490) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-624753169 ^ -624788677));
		MA4obGtmBc1(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28AE3E0), arg, P_0.Count));
	}

	internal static WebSocketState EfOy2oSVfRK6KbKgWGfX(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static void R7drO2SV9xdojWbI7JBO(object P_0)
	{
		((Dictionary<string, rJkPoOoD5Rvt2742WnFb>)P_0).Clear();
	}

	internal static object PF7KN9SVnn8hZN297DPg(object P_0)
	{
		return ((WebSocket)P_0).SslConfiguration;
	}

	internal static object gYrn5iSVGtPYCEBrHrlK(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).OCiaEYswnjC();
	}

	internal static object NHHpKESVYgToOkBQwakA(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Password;
	}

	internal static void osR1fmSVoQhY69Z08v0R(object P_0, object P_1)
	{
		((WebSocket)P_0).OnOpen += (EventHandler)P_1;
	}

	internal static TimeSpan ddExunSVv6vURqyLE5yE(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static bool s10oOfSVBZvq97OjZWay(object P_0, TimeSpan P_1, TimeSpan P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}

	internal static bool ww4pq3SV2TEyR0Yu5BjJ()
	{
		return RDMmKHSV0Hb6lbr0ZOPE == null;
	}

	internal static x6dXYWoDKAkJ0g3N7cWC ePxrLhSVHKWGNXk1q8ge()
	{
		return RDMmKHSV0Hb6lbr0ZOPE;
	}

	internal static void YIJBF2SVaUCFH0nJ9ojy(object P_0)
	{
		((Dictionary<string, Rybo1XGzd9ch5SOUQC2H>)P_0).Clear();
	}

	internal static object U5jeJSSViicLGXlURdv8(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool TPGHUKSVlo9mO3PdZdI2(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void zIZSBPSV4pdpdDMb4Z9h(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static object UFXbHvSVD6kqL8aEPLee(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object Bj1rhLSVbMvb0tJl1rNf(object P_0)
	{
		return ((MessageEventArgs)P_0).RawData;
	}

	internal static object Ajs5fiSVNi913aX5jKZS(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object pl3gReSVk9Ki6VcQSsrW(object P_0)
	{
		return cixGMEoBn4f66RgYBvmi.GMPoBYpZDOj((byte[])P_0);
	}

	internal static object N2Oj51SV1Nu9f0uS8KtV(object P_0)
	{
		return ((JKiJRyoaKDmkFpOUPDi9)P_0).Symbol;
	}

	internal static long OSK61CSV52lgejWLi6yc(object P_0)
	{
		return ((w1TmOpo4OLasbmph2s4A)P_0).Swmo4T0OStT();
	}

	internal static object ccpdWVSVSHxrI5J15vIL(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Symbol;
	}

	internal static object tCrtAOSVxj1ruYwZVxt0(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk((Symbol)P_0);
	}

	internal static long zqEVAYSVLMwWcO2wg3n6(object P_0)
	{
		return ((JKiJRyoaKDmkFpOUPDi9)P_0).ToVersion;
	}

	internal static void zTbusCSVewNII6XcTlaL(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object At0WtISVsDvDANuZRTvR(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.yxVGF4IeGkY((Symbol)P_0);
	}

	internal static Side filRGISVXaCBoLix2dcX(int P_0)
	{
		return PsO19ZoBo5RP3Z6m6RKY.gkOoBBO6ryB(P_0);
	}

	internal static long t7FlsuSVchRhfEWKPtf0(object P_0, double price)
	{
		return ((Symbol)P_0).GetShortPrice(price);
	}

	internal static void wKZ39SSVjTZZ8UCletFa(object P_0, long P_1)
	{
		((TickEvent)P_0).Price = P_1;
	}

	internal static decimal XGuOZKSVEDEohXQwYXZW(object P_0)
	{
		return ((ecfDaDol23uUJl1nvGXX)P_0).Quantity;
	}

	internal static long VVDFUKSVQPbDUYVIvpca(object P_0, double size)
	{
		return ((SymbolBase)P_0).GetShortSize(size);
	}

	internal static void gxfsgTSVdybMuKIUyDyC(object P_0, long P_1)
	{
		((TickEvent)P_0).Size = P_1;
	}

	internal static object ztpHs7SVgA0EQ1WZYMrn(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Code;
	}

	internal static void wNOMTKSVR8DTwKHMxa7X(object P_0, object P_1)
	{
		((LesfqXoNpogLJQyFhfPG)P_0).fXfok2B6ka9 = (string)P_1;
	}

	internal static void see99TSV6v4JlguuPPwP(object P_0, object P_1)
	{
		((LesfqXoNpogLJQyFhfPG)P_0).XP4okY2VV5k = (string)P_1;
	}

	internal static object L0LEQoSVMuqY8tyCvlER(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static int TowXqeSVOuK5m66OIVva(object P_0)
	{
		return ((ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>)P_0).Count;
	}

	internal static object kIspmuSVqNhXE8LgKFJQ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void o3Q5BeSVIm2Mk6u7wxhm()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void d5ejolSVWpU8asGx9NkG()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
