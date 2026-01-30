using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using JCn9CJaiPhkWSKHLEK1c;
using K1GcsD5GTtMSlaiJI0Xh;
using lhXBxhacgb7UjaNLB6uJ;
using LPq3llG3QX4HMCBL7b1Q;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using nKA4Oxa4ynxiT1XtKlQj;
using Org.BouncyCastle.Crypto.Parameters;
using OWhORdGzgDWLWxLpUFfx;
using qFoXqJaadfSuNHmuM1Rr;
using QTLJiyaSDC5spqPa3PT9;
using r8oOHiajFPNBXu6XiAHj;
using t8efU2aDyycbJD5J5fyb;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using ULWGTraj2l6bcVplnnMn;
using uyZAkjGzbty6fP4YlLSY;
using VKvOBwavjMOD3lnZn01e;
using vwKQpHaiSfF8vFM5hmQd;
using WebSocketSharp;
using WebSocketSharp.Net;
using x8mi3ua4zU3uXeHWpXU0;
using x97CE55GhEYKgt7TSVZT;
using xGlWBPainqtsSxRT598X;
using xYXWIyaBa0eL10IuBCpJ;
using ysbju8aSaDjTbhg64L8I;

namespace ODIT5YaYqarEkUjmHc3G;

internal sealed class Bl9BKPaYOyTwXdO4Msyk : IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class qpJdnsin0XWFHMAiLx91
	{
		public static readonly qpJdnsin0XWFHMAiLx91 aRqinf6ecfh;

		public static Func<DateTimeOffset> VN1in9ToWMu;

		public static Func<KeyValuePair<string, (bool, bool)>, string> xZTinn7PfZE;

		internal static qpJdnsin0XWFHMAiLx91 g5sWcDLdVNlBJ5aP3Nsf;

		static qpJdnsin0XWFHMAiLx91()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			aRqinf6ecfh = new qpJdnsin0XWFHMAiLx91();
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

		public qpJdnsin0XWFHMAiLx91()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal DateTimeOffset j75in2ipv4I()
		{
			return Qp3vCMLdKynGwm5GQttx();
		}

		internal string xFoinHEt4oH(KeyValuePair<string, (bool isSubsribed, bool isPrivate)> kvp)
		{
			return kvp.Key;
		}

		internal static bool j3E2CPLdC1ys3aPiq5dG()
		{
			return g5sWcDLdVNlBJ5aP3Nsf == null;
		}

		internal static qpJdnsin0XWFHMAiLx91 oMslWhLdrVXkNY3J10q2()
		{
			return g5sWcDLdVNlBJ5aP3Nsf;
		}

		internal static DateTimeOffset Qp3vCMLdKynGwm5GQttx()
		{
			return DateTimeOffset.UtcNow;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct AcyVJJinGRQiWvWYmRlA : IAsyncStateMachine
	{
		public int zfbinYgmytF;

		public AsyncTaskMethodBuilder ej5inoplSU4;

		public Bl9BKPaYOyTwXdO4Msyk RF0invnqCKb;

		public string F2linBnyxgr;

		public bool EAiinalFxCo;

		private TaskAwaiter<bool> F6pinimekAf;

		private static object siXlc5LdmvH2gMMdkjSr;

		private void MoveNext()
		{
			int num = zfbinYgmytF;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = RF0invnqCKb;
			int num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
			{
				num2 = 1;
			}
			switch (num2)
			{
			case 1:
				try
				{
					(bool, bool) value = default((bool, bool));
					int num3;
					TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
					if (num != 0)
					{
						if (bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW.TryGetValue(F2linBnyxgr, out value))
						{
							goto IL_00bf;
						}
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
						{
							num3 = 1;
						}
					}
					else
					{
						awaiter = F6pinimekAf;
						F6pinimekAf = default(TaskAwaiter<bool>);
						num = (zfbinYgmytF = -1);
						int num4 = 2;
						num3 = num4;
					}
					goto IL_0057;
					IL_0057:
					bool result = default(bool);
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 3:
							break;
						case 2:
						case 5:
							result = awaiter.GetResult();
							num3 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
							{
								num3 = 7;
							}
							continue;
						case 6:
							goto IL_00bf;
						case 1:
							goto IL_0151;
						case 4:
							goto IL_018f;
						case 7:
							bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW[F2linBnyxgr] = (result, EAiinalFxCo);
							break;
						}
						break;
						IL_018f:
						if (awaiter.IsCompleted)
						{
							num3 = 5;
							continue;
						}
						num = (zfbinYgmytF = 0);
						F6pinimekAf = awaiter;
						ej5inoplSU4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
						{
							num3 = 0;
						}
					}
					goto end_IL_0047;
					IL_0151:
					awaiter = bl9BKPaYOyTwXdO4Msyk.uT4aYmueseu(ybCTFpaSBe900G1N4E1N.RnlaSiHAqjT, new string[1] { F2linBnyxgr }, EAiinalFxCo).GetAwaiter();
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
					{
						num3 = 4;
					}
					goto IL_0057;
					IL_00bf:
					if (value.Item1)
					{
						break;
					}
					goto IL_0151;
					end_IL_0047:;
				}
				catch (Exception exception)
				{
					zfbinYgmytF = -2;
					ej5inoplSU4.SetException(exception);
					int num5 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
					return;
				}
				break;
			}
			zfbinYgmytF = -2;
			ej5inoplSU4.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			ej5inoplSU4.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static AcyVJJinGRQiWvWYmRlA()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool R653cZLdhtb3vfdIcxfe()
		{
			return siXlc5LdmvH2gMMdkjSr == null;
		}

		internal static object NjALP3Ldws4RbjdBZBbV()
		{
			return siXlc5LdmvH2gMMdkjSr;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct TPExJrinl46hQBjvwFij : IAsyncStateMachine
	{
		public int fEcin4aCubn;

		public AsyncTaskMethodBuilder XISinDIeg83;

		public string[] R0rinbRPxTw;

		public Bl9BKPaYOyTwXdO4Msyk nR7inNunF02;

		public bool nCwinkdrrjb;

		private int kp7in1PSoUR;

		private string[] xNGin5fv6ru;

		private TaskAwaiter<bool> txlinSPaX69;

		private TaskAwaiter DyWinx3WtjW;

		internal static object PAevgmLd7ChiY3e74YnR;

		private void MoveNext()
		{
			int num = fEcin4aCubn;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = nR7inNunF02;
			try
			{
				int num2;
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_023a;
					}
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
					{
						num2 = 8;
					}
				}
				else
				{
					awaiter = txlinSPaX69;
					num2 = 7;
				}
				goto IL_0039;
				IL_023a:
				TaskAwaiter awaiter2 = DyWinx3WtjW;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
				{
					num2 = 1;
				}
				goto IL_0039;
				IL_0039:
				string key = default(string);
				bool result = default(bool);
				int num3 = default(int);
				string[] array = default(string[]);
				while (true)
				{
					switch (num2)
					{
					case 4:
						xNGin5fv6ru = null;
						kp7in1PSoUR += 5;
						num2 = 5;
						continue;
					case 5:
						if (kp7in1PSoUR >= R0rinbRPxTw.Length)
						{
							goto end_IL_0039;
						}
						xNGin5fv6ru = R0rinbRPxTw.Skip(kp7in1PSoUR).Take(5).ToArray();
						awaiter = bl9BKPaYOyTwXdO4Msyk.uT4aYmueseu(ybCTFpaSBe900G1N4E1N.RnlaSiHAqjT, xNGin5fv6ru, nCwinkdrrjb).GetAwaiter();
						num2 = 14;
						continue;
					case 6:
						bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW[key] = (result, nCwinkdrrjb);
						num3++;
						goto case 10;
					default:
						num3 = 0;
						num2 = 10;
						continue;
					case 10:
						if (num3 < array.Length)
						{
							goto case 3;
						}
						awaiter2 = ((Task)mfXNf5LdPlr0d62gtAck(100)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (fEcin4aCubn = 1);
							DyWinx3WtjW = awaiter2;
							num2 = 13;
							continue;
						}
						goto IL_0317;
					case 8:
						kp7in1PSoUR = 0;
						goto case 5;
					case 12:
						array = xNGin5fv6ru;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 != 0)
						{
							num2 = 0;
						}
						continue;
					case 11:
						num = (fEcin4aCubn = -1);
						goto IL_0317;
					case 2:
						return;
					case 1:
						DyWinx3WtjW = default(TaskAwaiter);
						num2 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
						{
							num2 = 11;
						}
						continue;
					case 9:
						break;
					case 7:
						txlinSPaX69 = default(TaskAwaiter<bool>);
						num = (fEcin4aCubn = -1);
						goto IL_02ec;
					case 3:
					{
						key = array[num3];
						int num4 = 6;
						num2 = num4;
						continue;
					}
					case 14:
						if (!awaiter.IsCompleted)
						{
							num = (fEcin4aCubn = 0);
							txlinSPaX69 = awaiter;
							XISinDIeg83.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02ec;
					case 13:
						{
							XISinDIeg83.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num2 = 2;
							continue;
						}
						IL_02ec:
						result = awaiter.GetResult();
						num2 = 12;
						continue;
						IL_0317:
						awaiter2.GetResult();
						num2 = 4;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_023a;
					continue;
					end_IL_0039:
					break;
				}
			}
			catch (Exception exception)
			{
				int num5 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
				fEcin4aCubn = -2;
				XISinDIeg83.SetException(exception);
				return;
			}
			while (true)
			{
				fEcin4aCubn = -2;
				XISinDIeg83.SetResult();
				int num6 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
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
			XISinDIeg83.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static TPExJrinl46hQBjvwFij()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object mfXNf5LdPlr0d62gtAck(int P_0)
		{
			return Task.Delay(P_0);
		}

		internal static bool XixZ79Ld8MdfPqMIS1KV()
		{
			return PAevgmLd7ChiY3e74YnR == null;
		}

		internal static object ik4GdyLdA5GuUsLLxQ75()
		{
			return PAevgmLd7ChiY3e74YnR;
		}
	}

	[CompilerGenerated]
	private sealed class pnlGH9inLyiE9bDb4dtU
	{
		public bool OSCinsZq2R6;

		private static pnlGH9inLyiE9bDb4dtU tyUnpqLdJ74yWe1FO8kf;

		public pnlGH9inLyiE9bDb4dtU()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool B4Qine57OvH(KeyValuePair<string, (bool isSubsribed, bool isPrivate)> kvp)
		{
			return kvp.Value.isPrivate == OSCinsZq2R6;
		}

		static pnlGH9inLyiE9bDb4dtU()
		{
			eAgBqBLdp1ELYmilOiOr();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool TMi2atLdFeM18rxff8DE()
		{
			return tyUnpqLdJ74yWe1FO8kf == null;
		}

		internal static pnlGH9inLyiE9bDb4dtU Vynm6ALd3J524yeIouME()
		{
			return tyUnpqLdJ74yWe1FO8kf;
		}

		internal static void eAgBqBLdp1ELYmilOiOr()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct HjCgtrinX2peWWiHBYV1 : IAsyncStateMachine
	{
		public int MX2incnNVQ2;

		public AsyncTaskMethodBuilder wffinjQfFmn;

		public bool Q9yinEJ64am;

		public Bl9BKPaYOyTwXdO4Msyk eSkinQIeTas;

		public string[] okcindMa14L;

		private pnlGH9inLyiE9bDb4dtU uNQingtr9wa;

		private string[] tYainR6oak1;

		private TaskAwaiter HS5in6mwLH7;

		internal static object Jxst59LduGnrVfMcpcbC;

		private void MoveNext()
		{
			int num = MX2incnNVQ2;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = eSkinQIeTas;
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
			{
				num2 = 1;
			}
			TaskAwaiter awaiter = default(TaskAwaiter);
			string[] array = default(string[]);
			while (true)
			{
				switch (num2)
				{
				default:
					tYainR6oak1 = null;
					wffinjQfFmn.SetResult();
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 1:
					try
					{
						int num3;
						if (num != 0)
						{
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 != 0)
							{
								num3 = 7;
							}
						}
						else
						{
							awaiter = HS5in6mwLH7;
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
							{
								num3 = 4;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 9:
								HS5in6mwLH7 = default(TaskAwaiter);
								num = (MX2incnNVQ2 = -1);
								goto IL_0250;
							case 10:
							{
								string[] array2 = okcindMa14L.Except(tYainR6oak1).ToArray();
								if (array2.Length != 0)
								{
									awaiter = sBgwb3Lg2vbDXjsEBhQF(bl9BKPaYOyTwXdO4Msyk.Subscribe(array2, uNQingtr9wa.OSCinsZq2R6));
									num3 = 6;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto end_IL_00d4;
							}
							case 4:
								HS5in6mwLH7 = default(TaskAwaiter);
								num = (MX2incnNVQ2 = -1);
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
								{
									num3 = 0;
								}
								continue;
							default:
								awaiter.GetResult();
								num3 = 7;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
								{
									num3 = 10;
								}
								continue;
							case 11:
								wffinjQfFmn.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								continue;
							case 12:
								awaiter = bl9BKPaYOyTwXdO4Msyk.Unsubscribe(array, uNQingtr9wa.OSCinsZq2R6).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto default;
								}
								goto case 1;
							case 8:
								num = (MX2incnNVQ2 = 1);
								HS5in6mwLH7 = awaiter;
								num3 = 2;
								continue;
							case 2:
								wffinjQfFmn.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 7:
								if (num == 1)
								{
									break;
								}
								uNQingtr9wa = new pnlGH9inLyiE9bDb4dtU();
								uNQingtr9wa.OSCinsZq2R6 = Q9yinEJ64am;
								tYainR6oak1 = bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW.Where(uNQingtr9wa.B4Qine57OvH).Select(qpJdnsin0XWFHMAiLx91.aRqinf6ecfh.xFoinHEt4oH).ToArray();
								array = tYainR6oak1.Except(okcindMa14L).ToArray();
								if (array.Length == 0)
								{
									goto case 10;
								}
								goto case 12;
							case 1:
							{
								num = (MX2incnNVQ2 = 0);
								HS5in6mwLH7 = awaiter;
								int num4 = 11;
								num3 = num4;
								continue;
							}
							case 6:
								if (!awaiter.IsCompleted)
								{
									num3 = 8;
									continue;
								}
								goto IL_0250;
							case 13:
								break;
							case 5:
								goto end_IL_00d4;
								IL_0250:
								awaiter.GetResult();
								num3 = 5;
								continue;
							}
							awaiter = HS5in6mwLH7;
							num3 = 9;
							continue;
							end_IL_00d4:
							break;
						}
					}
					catch (Exception exception)
					{
						int num5 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								MX2incnNVQ2 = -2;
								num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a != 0)
								{
									num5 = 0;
								}
								break;
							default:
								uNQingtr9wa = null;
								tYainR6oak1 = null;
								wffinjQfFmn.SetException(exception);
								return;
							}
						}
					}
					MX2incnNVQ2 = -2;
					uNQingtr9wa = null;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
					{
						num2 = 0;
					}
					break;
				}
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
			wffinjQfFmn.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static HjCgtrinX2peWWiHBYV1()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			gxsJh1LgH2rkQw5CpDeP();
		}

		internal static TaskAwaiter sBgwb3Lg2vbDXjsEBhQF(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		internal static bool GoGoRQLdzP03X1uHIJum()
		{
			return Jxst59LduGnrVfMcpcbC == null;
		}

		internal static object lKKcXeLg0bnJUUwy0Dr3()
		{
			return Jxst59LduGnrVfMcpcbC;
		}

		internal static void gxsJh1LgH2rkQw5CpDeP()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct oW9mCxinMFOvHhSAIs9F : IAsyncStateMachine
	{
		public int fJ0inOIad6d;

		public AsyncTaskMethodBuilder Hp7inqt5lJI;

		public Bl9BKPaYOyTwXdO4Msyk xgXinILTf8A;

		public string jSNinWdqguF;

		private TaskAwaiter<bool> yF8intXn8vx;

		internal static object EpC21kLgfgx3sORg2Kpr;

		private void MoveNext()
		{
			int num = fJ0inOIad6d;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = xgXinILTf8A;
			try
			{
				int num2;
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				if (num != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					awaiter = yF8intXn8vx;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
					{
						num2 = 0;
					}
				}
				(bool, bool) value = default((bool, bool));
				while (true)
				{
					(bool, bool) value2;
					switch (num2)
					{
					case 1:
						yF8intXn8vx = default(TaskAwaiter<bool>);
						num = (fJ0inOIad6d = -1);
						goto IL_011c;
					case 2:
						awaiter = bl9BKPaYOyTwXdO4Msyk.uT4aYmueseu(ybCTFpaSBe900G1N4E1N.n5waSlIHa6m, new string[1] { jSNinWdqguF }, value.Item2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (fJ0inOIad6d = 0);
							yF8intXn8vx = awaiter;
							num2 = 5;
							continue;
						}
						goto IL_011c;
					default:
						if (bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW.TryGetValue(jSNinWdqguF, out value))
						{
							goto case 2;
						}
						break;
					case 5:
						Hp7inqt5lJI.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 4;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
						{
							num2 = 4;
						}
						continue;
					case 4:
						return;
					case 3:
						break;
						IL_011c:
						awaiter.GetResult();
						bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW.TryRemove(jSNinWdqguF, out value2);
						num2 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
			}
			catch (Exception exception)
			{
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				}
				fJ0inOIad6d = -2;
				Hp7inqt5lJI.SetException(exception);
				return;
			}
			while (true)
			{
				fJ0inOIad6d = -2;
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 1:
					continue;
				}
				Hp7inqt5lJI.SetResult();
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
			Hp7inqt5lJI.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static oW9mCxinMFOvHhSAIs9F()
		{
			i5MHmbLgGtOCR7pJska4();
			jPX0HqLgYT4dbaoZ6OGm();
		}

		internal static bool RVPLSLLg9K7k7DQxdifu()
		{
			return EpC21kLgfgx3sORg2Kpr == null;
		}

		internal static object Ud6wJ0LgnveAIe406O0E()
		{
			return EpC21kLgfgx3sORg2Kpr;
		}

		internal static void i5MHmbLgGtOCR7pJska4()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static void jPX0HqLgYT4dbaoZ6OGm()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct y4sSEwinUkyJum1UHN9Y : IAsyncStateMachine
	{
		public int gNTinTycMva;

		public AsyncTaskMethodBuilder wukinycED9D;

		public Bl9BKPaYOyTwXdO4Msyk tMcinZfUegv;

		public string[] NCminViTLtC;

		public bool ni0inCZgYoL;

		private string[] VbninrleQdW;

		private int awXinKOI7RV;

		private string[] huNinmNEPjO;

		private TaskAwaiter<bool> y2Winh5RXpo;

		private TaskAwaiter rt4inw8OvAV;

		private static object wWujL1Lgow6R9oZdq31q;

		private void MoveNext()
		{
			int num = gNTinTycMva;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = tMcinZfUegv;
			try
			{
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				int num2;
				if (num == 0)
				{
					awaiter = y2Winh5RXpo;
					num2 = 12;
					goto IL_0046;
				}
				goto IL_016a;
				IL_02e7:
				rt4inw8OvAV = default(TaskAwaiter);
				num2 = 5;
				goto IL_0046;
				IL_0046:
				int num3 = num2;
				goto IL_004a;
				IL_004a:
				TaskAwaiter awaiter2 = default(TaskAwaiter);
				int num4 = default(int);
				string[] array = default(string[]);
				string key = default(string);
				while (true)
				{
					switch (num3)
					{
					case 15:
						return;
					case 6:
						awaiter2.GetResult();
						huNinmNEPjO = null;
						awXinKOI7RV += 5;
						goto IL_0236;
					case 9:
						VbninrleQdW = bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW.Keys.Intersect(NCminViTLtC).ToArray();
						num3 = 8;
						continue;
					case 14:
						if (num4 >= array.Length)
						{
							awaiter2 = ((Task)PMGghaLgapekI3meCjZh(100)).GetAwaiter();
							num3 = 2;
							continue;
						}
						goto case 1;
					case 13:
						break;
					case 1:
						key = array[num4];
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
						{
							num3 = 0;
						}
						continue;
					default:
					{
						bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW.TryRemove(key, out var _);
						num4++;
						goto case 14;
					}
					case 5:
						num = (gNTinTycMva = -1);
						num3 = 6;
						continue;
					case 10:
						num = (gNTinTycMva = 1);
						rt4inw8OvAV = awaiter2;
						wukinycED9D.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num3 = 12;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
						{
							num3 = 15;
						}
						continue;
					case 4:
						goto IL_02e7;
					case 7:
						array = huNinmNEPjO;
						num4 = 0;
						num3 = 14;
						continue;
					case 2:
						if (!awaiter2.IsCompleted)
						{
							num3 = 10;
							continue;
						}
						goto case 6;
					case 12:
						y2Winh5RXpo = default(TaskAwaiter<bool>);
						num = (gNTinTycMva = -1);
						goto IL_0386;
					case 11:
						awaiter = bl9BKPaYOyTwXdO4Msyk.uT4aYmueseu(ybCTFpaSBe900G1N4E1N.n5waSlIHa6m, huNinmNEPjO, ni0inCZgYoL).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (gNTinTycMva = 0);
							y2Winh5RXpo = awaiter;
							wukinycED9D.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0386;
					case 8:
						awXinKOI7RV = 0;
						goto IL_0236;
					case 3:
						goto end_IL_003a;
						IL_0386:
						awaiter.GetResult();
						num3 = 7;
						continue;
						IL_0236:
						if (awXinKOI7RV < VbninrleQdW.Length)
						{
							huNinmNEPjO = VbninrleQdW.Skip(awXinKOI7RV).Take(5).ToArray();
							num3 = 11;
							continue;
						}
						goto IL_0249;
					}
					break;
				}
				goto IL_016a;
				IL_0249:
				num2 = 3;
				goto IL_0046;
				IL_016a:
				if (num == 1)
				{
					awaiter2 = rt4inw8OvAV;
					num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
					{
						num3 = 4;
					}
				}
				else
				{
					num3 = 9;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
					{
						num3 = 7;
					}
				}
				goto IL_004a;
				end_IL_003a:;
			}
			catch (Exception exception)
			{
				int num5 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
				gNTinTycMva = -2;
				VbninrleQdW = null;
				wukinycED9D.SetException(exception);
				return;
			}
			gNTinTycMva = -2;
			int num6 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
			{
				num6 = 0;
			}
			while (true)
			{
				switch (num6)
				{
				case 1:
					wukinycED9D.SetResult();
					return;
				}
				VbninrleQdW = null;
				num6 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
				{
					num6 = 1;
				}
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
			wukinycED9D.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static y4sSEwinUkyJum1UHN9Y()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object PMGghaLgapekI3meCjZh(int P_0)
		{
			return Task.Delay(P_0);
		}

		internal static bool rWGfGLLgvnUubFpGsZM0()
		{
			return wWujL1Lgow6R9oZdq31q == null;
		}

		internal static object iLIZ1eLgBYv0PGPV4iTV()
		{
			return wWujL1Lgow6R9oZdq31q;
		}
	}

	[CompilerGenerated]
	private sealed class lWoub8in7DX2InJDcwQd
	{
		public Bl9BKPaYOyTwXdO4Msyk sUVinAy6GOQ;

		public bool br2inPjijpF;

		private static lWoub8in7DX2InJDcwQd L5uwiBLgiAkqEfbyIGgH;

		public lWoub8in7DX2InJDcwQd()
		{
			bFMM1aLgDghwDmgvbWNL();
			base._002Ector();
		}

		internal bool Pgoin85FZOY(string k)
		{
			return sUVinAy6GOQ.e4VaoKl0lfW[k].Item2 == br2inPjijpF;
		}

		static lWoub8in7DX2InJDcwQd()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			kbI8fhLgbbIZqKC4oJmj();
		}

		internal static void bFMM1aLgDghwDmgvbWNL()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool IFyEsYLgl1qB8qF3PH4U()
		{
			return L5uwiBLgiAkqEfbyIGgH == null;
		}

		internal static lWoub8in7DX2InJDcwQd cnOlM4Lg4gKAYw2N9Gxo()
		{
			return L5uwiBLgiAkqEfbyIGgH;
		}

		internal static void kbI8fhLgbbIZqKC4oJmj()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct nJYYRFinJGvLEdRLuprx : IAsyncStateMachine
	{
		public int Pe4inFbe3pP;

		public AsyncTaskMethodBuilder ffEin3Y4E4R;

		public Bl9BKPaYOyTwXdO4Msyk HNpinpimPFB;

		public bool dwHinulNJG1;

		private TaskAwaiter<bool> fc4inzxOtt9;

		internal static object tNVIqlLgNYnXQY9nkVt3;

		private void MoveNext()
		{
			int num = Pe4inFbe3pP;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = HNpinpimPFB;
			try
			{
				int num2;
				lWoub8in7DX2InJDcwQd lWoub8in7DX2InJDcwQd = default(lWoub8in7DX2InJDcwQd);
				if (num == 0)
				{
					num2 = 7;
				}
				else
				{
					lWoub8in7DX2InJDcwQd = new lWoub8in7DX2InJDcwQd();
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
					{
						num2 = 1;
					}
				}
				TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 2:
						fc4inzxOtt9 = default(TaskAwaiter<bool>);
						num = (Pe4inFbe3pP = -1);
						goto IL_0192;
					case 3:
						ffEin3Y4E4R.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 0:
						break;
					case 6:
						if (!awaiter.IsCompleted)
						{
							num = (Pe4inFbe3pP = 0);
							fc4inzxOtt9 = awaiter;
							num2 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto IL_0192;
					case 1:
						lWoub8in7DX2InJDcwQd.sUVinAy6GOQ = HNpinpimPFB;
						num2 = 4;
						continue;
					case 7:
						awaiter = fc4inzxOtt9;
						num2 = 2;
						continue;
					case 4:
					{
						lWoub8in7DX2InJDcwQd.br2inPjijpF = dwHinulNJG1;
						string[] array = bl9BKPaYOyTwXdO4Msyk.e4VaoKl0lfW.Keys.Where(lWoub8in7DX2InJDcwQd.Pgoin85FZOY).ToArray();
						if (!array.Any())
						{
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
							{
								num2 = 0;
							}
						}
						else
						{
							awaiter = bl9BKPaYOyTwXdO4Msyk.uT4aYmueseu(ybCTFpaSBe900G1N4E1N.RnlaSiHAqjT, array, lWoub8in7DX2InJDcwQd.br2inPjijpF).GetAwaiter();
							num2 = 6;
						}
						continue;
					}
					case 5:
						break;
						IL_0192:
						awaiter.GetResult();
						num3 = 5;
						num2 = num3;
						continue;
					}
					break;
				}
			}
			catch (Exception exception)
			{
				Pe4inFbe3pP = -2;
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				}
				ffEin3Y4E4R.SetException(exception);
				return;
			}
			while (true)
			{
				Pe4inFbe3pP = -2;
				ffEin3Y4E4R.SetResult();
				int num5 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					break;
				}
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
			ffEin3Y4E4R.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static nJYYRFinJGvLEdRLuprx()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool LSa3ZZLgkxewebfX3SsU()
		{
			return tNVIqlLgNYnXQY9nkVt3 == null;
		}

		internal static object i3seGjLg1ceCBgjeRbEv()
		{
			return tNVIqlLgNYnXQY9nkVt3;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct rucH1ciG0jIVFmVwIMBO : IAsyncStateMachine
	{
		public int zvqiG2vH2w1;

		public AsyncTaskMethodBuilder hoNiGH1Dk6g;

		public Bl9BKPaYOyTwXdO4Msyk Dq7iGffdXo3;

		private TaskAwaiter lWPiG9Ykutn;

		internal static object tBPbBPLg5tUYMmC43V4U;

		private void MoveNext()
		{
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Invalid comparison between Unknown and I4
			int num = zvqiG2vH2w1;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = Dq7iGffdXo3;
			try
			{
				int num2;
				TaskAwaiter awaiter = default(TaskAwaiter);
				if (num != 0)
				{
					if ((uint)(num - 1) <= 1u)
					{
						goto IL_0169;
					}
					awaiter = ((Task)D8xP0QLgL9OHmbY2kHSh(bl9BKPaYOyTwXdO4Msyk.GC4aoWdqi5g)).GetAwaiter();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					awaiter = lWPiG9Ykutn;
					num2 = 2;
				}
				while (true)
				{
					switch (num2)
					{
					case 6:
						num = (zvqiG2vH2w1 = 0);
						lWPiG9Ykutn = awaiter;
						hoNiGH1Dk6g.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 2:
					{
						lWPiG9Ykutn = default(TaskAwaiter);
						int num3 = 5;
						num2 = num3;
						continue;
					}
					default:
						if (awaiter.IsCompleted)
						{
							num2 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 6;
					case 1:
					case 3:
						awaiter.GetResult();
						num2 = 4;
						continue;
					case 5:
						num = (zvqiG2vH2w1 = -1);
						num2 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
						{
							num2 = 2;
						}
						continue;
					case 4:
						break;
					}
					break;
				}
				goto IL_0169;
				IL_0169:
				try
				{
					int num4;
					if (num != 1)
					{
						if (num != 2)
						{
							num4 = 3;
							goto IL_017a;
						}
						goto IL_0451;
					}
					goto IL_01cb;
					IL_03e3:
					if (bl9BKPaYOyTwXdO4Msyk.AnIaoUDQWFY && !bl9BKPaYOyTwXdO4Msyk.epxaotUC3UU)
					{
						num4 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
						{
							num4 = 0;
						}
						goto IL_017a;
					}
					goto end_IL_0169;
					IL_0382:
					awaiter.GetResult();
					goto IL_03e3;
					IL_017a:
					while (true)
					{
						switch (num4)
						{
						case 5:
						case 7:
							break;
						case 4:
							num = (zvqiG2vH2w1 = 2);
							num4 = 6;
							continue;
						case 6:
							lWPiG9Ykutn = awaiter;
							num4 = 2;
							continue;
						case 2:
							hoNiGH1Dk6g.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 3:
							goto IL_03e3;
						case 1:
							goto IL_0429;
						default:
							goto IL_0451;
						}
						break;
						IL_0429:
						WebSocket xyvaoOjfNJE = bl9BKPaYOyTwXdO4Msyk.xyvaoOjfNJE;
						if (xyvaoOjfNJE == null)
						{
							num4 = 5;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
							{
								num4 = 1;
							}
							continue;
						}
						if ((int)xyvaoOjfNJE.ReadyState != 1)
						{
							break;
						}
						goto end_IL_0169;
					}
					goto IL_01cb;
					IL_0451:
					awaiter = lWPiG9Ykutn;
					lWPiG9Ykutn = default(TaskAwaiter);
					num = (zvqiG2vH2w1 = -1);
					goto IL_0382;
					IL_01cb:
					try
					{
						int num5;
						if (num != 1)
						{
							bl9BKPaYOyTwXdO4Msyk.hagaY3gNVCv();
							awaiter = bl9BKPaYOyTwXdO4Msyk.mpwaYrZBPhm().GetAwaiter();
							num5 = 2;
						}
						else
						{
							awaiter = lWPiG9Ykutn;
							lWPiG9Ykutn = default(TaskAwaiter);
							num5 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
							{
								num5 = 0;
							}
						}
						while (true)
						{
							switch (num5)
							{
							case 4:
								return;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num = (zvqiG2vH2w1 = 1);
									lWPiG9Ykutn = awaiter;
									hoNiGH1Dk6g.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num5 = 4;
									continue;
								}
								break;
							default:
								num = (zvqiG2vH2w1 = -1);
								num5 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							case 3:
								goto end_IL_01dc;
							}
							awaiter.GetResult();
							num5 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
							{
								num5 = 3;
							}
							continue;
							end_IL_01dc:
							break;
						}
					}
					catch (Exception obj)
					{
						int num6 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						default:
							bl9BKPaYOyTwXdO4Msyk.Close();
							bl9BKPaYOyTwXdO4Msyk.GyTaowF7RKh?.Invoke(obj);
							break;
						}
					}
					awaiter = GaLkU3LgeJmKDfYbIL5w(Task.Delay(1000));
					if (!awaiter.IsCompleted)
					{
						num4 = 4;
						goto IL_017a;
					}
					goto IL_0382;
					end_IL_0169:;
				}
				finally
				{
					if (num < 0)
					{
						SaVwelLgsp34TrguGYAi(bl9BKPaYOyTwXdO4Msyk.GC4aoWdqi5g);
					}
				}
			}
			catch (Exception exception)
			{
				int num7 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				}
				zvqiG2vH2w1 = -2;
				hoNiGH1Dk6g.SetException(exception);
				return;
			}
			zvqiG2vH2w1 = -2;
			int num8 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
			{
				num8 = 0;
			}
			while (true)
			{
				switch (num8)
				{
				case 1:
					return;
				}
				hoNiGH1Dk6g.SetResult();
				num8 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
				{
					num8 = 1;
				}
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
			hoNiGH1Dk6g.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static rucH1ciG0jIVFmVwIMBO()
		{
			ULiqBwLgXQRNSQs3kOvB();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object D8xP0QLgL9OHmbY2kHSh(object P_0)
		{
			return ((SemaphoreSlim)P_0).WaitAsync();
		}

		internal static TaskAwaiter GaLkU3LgeJmKDfYbIL5w(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		internal static int SaVwelLgsp34TrguGYAi(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}

		internal static bool kRSYbLLgSQqp0IVTLJGW()
		{
			return tBPbBPLg5tUYMmC43V4U == null;
		}

		internal static object ND2HtcLgxWyfgBw9WO0V()
		{
			return tBPbBPLg5tUYMmC43V4U;
		}

		internal static void ULiqBwLgXQRNSQs3kOvB()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[CompilerGenerated]
	private sealed class oQK4ZniGnpTp89ChOdvR
	{
		public Bl9BKPaYOyTwXdO4Msyk IQhiGYAjh0f;

		public string hjViGownkeJ;

		internal static oQK4ZniGnpTp89ChOdvR R3XtHuLgcDO3vMdx6g4E;

		public oQK4ZniGnpTp89ChOdvR()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal void T8viGGSMT1U()
		{
			WebSocket xyvaoOjfNJE = IQhiGYAjh0f.xyvaoOjfNJE;
			if (xyvaoOjfNJE != null)
			{
				xyvaoOjfNJE.Send(hjViGownkeJ);
			}
		}

		static oQK4ZniGnpTp89ChOdvR()
		{
			xAUFjILgQDJZ0BIUXIfM();
			DEnYdZLgdvxcLc23pS2q();
		}

		internal static bool gnxRb2LgjAL39ejanIxn()
		{
			return R3XtHuLgcDO3vMdx6g4E == null;
		}

		internal static oQK4ZniGnpTp89ChOdvR UQPEaeLgENvr5RNEOfpd()
		{
			return R3XtHuLgcDO3vMdx6g4E;
		}

		internal static void xAUFjILgQDJZ0BIUXIfM()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static void DEnYdZLgdvxcLc23pS2q()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct dRLyuyiGvE7apXrew26R : IAsyncStateMachine
	{
		public int mvAiGBFTML7;

		public AsyncTaskMethodBuilder<bool> bCkiGa8pDZ8;

		public Bl9BKPaYOyTwXdO4Msyk rGniGiq4G0Z;

		public bool LCNiGlfg1oA;

		public ybCTFpaSBe900G1N4E1N LSqiG4NJh3a;

		public string[] geZiGDNkodU;

		private TaskAwaiter iVMiGbZX7wc;

		internal static object uUn6vTLggPnBZUf61mAd;

		private void MoveNext()
		{
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Invalid comparison between Unknown and I4
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			string[] array = default(string[]);
			TaskAwaiter awaiter = default(TaskAwaiter);
			string text3 = default(string);
			long num6 = default(long);
			string text2 = default(string);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					num3 = mvAiGBFTML7;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = rGniGiq4G0Z;
				bool result;
				try
				{
					try
					{
						int num4;
						if (num3 != 0)
						{
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
							{
								num4 = 0;
							}
							goto IL_00c1;
						}
						goto IL_0118;
						IL_00c1:
						while (true)
						{
							switch (num4)
							{
							case 4:
								array = null;
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
								{
									num4 = 1;
								}
								continue;
							case 7:
								break;
							case 5:
								awaiter.GetResult();
								result = true;
								goto end_IL_00c1;
							default:
								if (bl9BKPaYOyTwXdO4Msyk.xyvaoOjfNJE != null)
								{
									num4 = 8;
									continue;
								}
								goto IL_0331;
							case 10:
							{
								text3 = num6.ToString();
								string arg = (string)YBRsIXLgMiGbjLF1daNt(LSqiG4NJh3a);
								string text4 = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DF48E7), arg, text3, 5000);
								text2 = bl9BKPaYOyTwXdO4Msyk.oDHaoItKa0D.rVpavEoqS62(text4);
								num4 = 9;
								continue;
							}
							case 1:
								if (LCNiGlfg1oA)
								{
									goto case 2;
								}
								goto case 11;
							case 9:
								array = new string[4]
								{
									bl9BKPaYOyTwXdO4Msyk.Dtbaoqn3Aqh,
									text2,
									text3,
									5000.ToString()
								};
								num4 = 11;
								continue;
							case 2:
								num6 = bl9BKPaYOyTwXdO4Msyk.FmpaomnRPwC().ToUnixTimeMilliseconds();
								num4 = 10;
								continue;
							case 11:
							{
								ks3jeEaS4IpYAY11M27j obj = new ks3jeEaS4IpYAY11M27j
								{
									wobaSkYK6sI = LSqiG4NJh3a,
									vpZaSSnsNIS = geZiGDNkodU
								};
								mj3EgZLgOtuj4rdeP9rF(obj, array);
								text = L0J0aHaj0ET5qEqoWTOb.PWCajHnNxOb(obj);
								num4 = 6;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
								{
									num4 = 5;
								}
								continue;
							}
							case 3:
							{
								iVMiGbZX7wc = default(TaskAwaiter);
								num3 = (mvAiGBFTML7 = -1);
								int num5 = 5;
								num4 = num5;
								continue;
							}
							case 6:
								awaiter = dlIM2LLgqAlSw9iUmoSA(bl9BKPaYOyTwXdO4Msyk.DWqaYKG72D7(text));
								if (!awaiter.IsCompleted)
								{
									num3 = (mvAiGBFTML7 = 0);
									iVMiGbZX7wc = awaiter;
									bCkiGa8pDZ8.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto case 5;
							case 8:
								{
									if ((int)bl9BKPaYOyTwXdO4Msyk.xyvaoOjfNJE.ReadyState == 1)
									{
										goto case 4;
									}
									goto IL_0331;
								}
								IL_0331:
								result = false;
								goto end_IL_00c1;
							}
							goto IL_0118;
							continue;
							end_IL_00c1:
							break;
						}
						goto end_IL_009c;
						IL_0118:
						awaiter = iVMiGbZX7wc;
						num4 = 3;
						goto IL_00c1;
						end_IL_009c:;
					}
					catch (Exception obj2)
					{
						Action<Exception> action = bl9BKPaYOyTwXdO4Msyk.GyTaowF7RKh;
						if (action != null)
						{
							action(obj2);
							int num7 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 != 0)
							{
								num7 = 0;
							}
							switch (num7)
							{
							}
						}
						result = false;
					}
				}
				catch (Exception exception)
				{
					int num8 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					}
					mvAiGBFTML7 = -2;
					bCkiGa8pDZ8.SetException(exception);
					return;
				}
				mvAiGBFTML7 = -2;
				bCkiGa8pDZ8.SetResult(result);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
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
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			bCkiGa8pDZ8.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static dRLyuyiGvE7apXrew26R()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			q4fubMLgIcCVIjSPXeAh();
		}

		internal static object YBRsIXLgMiGbjLF1daNt(object P_0)
		{
			return h0VZBJacdxXPsrd5vjHv.KDSacqSbbJ5(P_0);
		}

		internal static void mj3EgZLgOtuj4rdeP9rF(object P_0, object P_1)
		{
			((ks3jeEaS4IpYAY11M27j)P_0).tlIaSeyxh47 = (string[])P_1;
		}

		internal static TaskAwaiter dlIM2LLgqAlSw9iUmoSA(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		internal static bool xhneQrLgRw13hWysWYBQ()
		{
			return uUn6vTLggPnBZUf61mAd == null;
		}

		internal static object fkQa19Lg6XL4ZbtVbmaW()
		{
			return uUn6vTLggPnBZUf61mAd;
		}

		internal static void q4fubMLgIcCVIjSPXeAh()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct pTdAmuiGNLf65ih9nCta : IAsyncStateMachine
	{
		public int PB2iGkm1dr6;

		public AsyncTaskMethodBuilder aXliG1bTuxU;

		public Action VXeiG5Z2cjM;

		public Bl9BKPaYOyTwXdO4Msyk EYLiGSH4cTO;

		private Task jOriGxhZ1Ix;

		private TaskAwaiter<Task> LEDiGLSbHQo;

		internal static object u8dIQqLgWNvXYRfQX8yG;

		private void MoveNext()
		{
			int num = PB2iGkm1dr6;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = EYLiGSH4cTO;
			try
			{
				int num2;
				TaskAwaiter<Task> awaiter = default(TaskAwaiter<Task>);
				if (num != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					awaiter = LEDiGLSbHQo;
					num2 = 4;
				}
				Task task = default(Task);
				while (true)
				{
					switch (num2)
					{
					case 5:
						if (!awaiter.IsCompleted)
						{
							goto case 1;
						}
						goto IL_0148;
					case 1:
						num = (PB2iGkm1dr6 = 0);
						LEDiGLSbHQo = awaiter;
						num2 = 3;
						continue;
					case 2:
						awaiter = Task.WhenAny(task, jOriGxhZ1Ix).GetAwaiter();
						num2 = 5;
						continue;
					case 4:
						LEDiGLSbHQo = default(TaskAwaiter<Task>);
						num = (PB2iGkm1dr6 = -1);
						goto IL_0148;
					case 3:
						{
							aXliG1bTuxU.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						IL_0148:
						if (awaiter.GetResult() == jOriGxhZ1Ix)
						{
							throw new TimeoutException((string)sBQS9ALgTdGsayNVQDHG(-1763895751 ^ -1763757209));
						}
						goto end_IL_0063;
					}
					task = Task.Run(VXeiG5Z2cjM);
					jOriGxhZ1Ix = Task.Delay(bl9BKPaYOyTwXdO4Msyk.IakaYuIIRF2());
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
					{
						num2 = 2;
					}
					continue;
					end_IL_0063:
					break;
				}
			}
			catch (Exception exception)
			{
				PB2iGkm1dr6 = -2;
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				}
				jOriGxhZ1Ix = null;
				aXliG1bTuxU.SetException(exception);
				return;
			}
			PB2iGkm1dr6 = -2;
			jOriGxhZ1Ix = null;
			int num4 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
			{
				num4 = 0;
			}
			while (true)
			{
				switch (num4)
				{
				case 1:
					return;
				}
				aXliG1bTuxU.SetResult();
				num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
				{
					num4 = 1;
				}
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
			aXliG1bTuxU.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static pTdAmuiGNLf65ih9nCta()
		{
			iHCExqLgy6YJcFqmODMO();
			yESxJBLgZLGcSep6UCga();
		}

		internal static object sBQS9ALgTdGsayNVQDHG(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool k5uIWFLgt0U4ukyAtMYr()
		{
			return u8dIQqLgWNvXYRfQX8yG == null;
		}

		internal static object qwVPKdLgUeitvqfbed0I()
		{
			return u8dIQqLgWNvXYRfQX8yG;
		}

		internal static void iHCExqLgy6YJcFqmODMO()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}

		internal static void yESxJBLgZLGcSep6UCga()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct V0O0nyiGexwgIQlNTD7P : IAsyncStateMachine
	{
		public int zYuiGs2SMKy;

		public AsyncVoidMethodBuilder YSriGXHlspS;

		public Bl9BKPaYOyTwXdO4Msyk DnGiGcmh1KE;

		private TaskAwaiter uobiGjIWNDb;

		private static object pB8bTfLgVDMpGP7dhAeP;

		private void MoveNext()
		{
			int num = zYuiGs2SMKy;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = DnGiGcmh1KE;
			try
			{
				TaskAwaiter awaiter = default(TaskAwaiter);
				if (num == 0)
				{
					awaiter = uobiGjIWNDb;
					uobiGjIWNDb = default(TaskAwaiter);
					num = (zYuiGs2SMKy = -1);
					goto IL_021f;
				}
				int num2;
				if (num != 1)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					awaiter = uobiGjIWNDb;
					num2 = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
					{
						num2 = 4;
					}
				}
				goto IL_0052;
				IL_021f:
				awaiter.GetResult();
				awaiter = bl9BKPaYOyTwXdO4Msyk.zZ6aYZWV04R(_0020: true).GetAwaiter();
				num2 = 9;
				goto IL_0052;
				IL_0052:
				while (true)
				{
					switch (num2)
					{
					case 3:
						return;
					case 4:
						awaiter.GetResult();
						Krp5UXLgmHC9ytT9DMrg(bl9BKPaYOyTwXdO4Msyk.AIQaoy4HMxd, pNDkV4LgKa8qSQO18NUm(5.0), pNDkV4LgKa8qSQO18NUm(15.0));
						bl9BKPaYOyTwXdO4Msyk.C9yaYpRpuNf((string)hyHlPILghOYEMrP5vbkN(-1461292091 ^ -1461430667));
						num2 = 6;
						continue;
					case 1:
					{
						awaiter = bl9BKPaYOyTwXdO4Msyk.zZ6aYZWV04R().GetAwaiter();
						int num3 = 8;
						num2 = num3;
						continue;
					}
					case 7:
						num = (zYuiGs2SMKy = -1);
						num2 = 4;
						continue;
					case 5:
						uobiGjIWNDb = default(TaskAwaiter);
						num2 = 7;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
						{
							num2 = 4;
						}
						continue;
					case 8:
						if (!awaiter.IsCompleted)
						{
							num2 = 2;
							continue;
						}
						break;
					default:
						YSriGXHlspS.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 9:
						if (!awaiter.IsCompleted)
						{
							num = (zYuiGs2SMKy = 1);
							uobiGjIWNDb = awaiter;
							YSriGXHlspS.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = 3;
							continue;
						}
						goto case 4;
					case 2:
						num = (zYuiGs2SMKy = 0);
						uobiGjIWNDb = awaiter;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 != 0)
						{
							num2 = 0;
						}
						continue;
					case 6:
						goto end_IL_0052;
					}
					goto IL_021f;
					continue;
					end_IL_0052:
					break;
				}
			}
			catch (Exception exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				}
				zYuiGs2SMKy = -2;
				YSriGXHlspS.SetException(exception);
				return;
			}
			zYuiGs2SMKy = -2;
			int num5 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
			{
				num5 = 0;
			}
			while (true)
			{
				switch (num5)
				{
				case 1:
					return;
				}
				YSriGXHlspS.SetResult();
				num5 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
				{
					num5 = 1;
				}
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
			YSriGXHlspS.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static V0O0nyiGexwgIQlNTD7P()
		{
			qtbdrHLgwrxIddGp7i4l();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static TimeSpan pNDkV4LgKa8qSQO18NUm(double P_0)
		{
			return TimeSpan.FromSeconds(P_0);
		}

		internal static bool Krp5UXLgmHC9ytT9DMrg(object P_0, TimeSpan P_1, TimeSpan P_2)
		{
			return ((Timer)P_0).Change(P_1, P_2);
		}

		internal static object hyHlPILghOYEMrP5vbkN(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool CEFCnoLgCFy18ZJV3VuD()
		{
			return pB8bTfLgVDMpGP7dhAeP == null;
		}

		internal static object wJP3iDLgrTqewSwfjGcl()
		{
			return pB8bTfLgVDMpGP7dhAeP;
		}

		internal static void qtbdrHLgwrxIddGp7i4l()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct mvkWaJiGEB3E3FUoQ2gC : IAsyncStateMachine
	{
		public int qnViGQOVgGp;

		public AsyncVoidMethodBuilder g7fiGdrrkEn;

		public Bl9BKPaYOyTwXdO4Msyk n4viGg9HjWa;

		public CloseEventArgs ppRiGRerwKe;

		private TaskAwaiter TLqiG6VdcZP;

		internal static object o7YvRkLg7F1NO9JqDibp;

		private void MoveNext()
		{
			int num = qnViGQOVgGp;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = n4viGg9HjWa;
			try
			{
				int num2;
				if (num != 0)
				{
					bl9BKPaYOyTwXdO4Msyk.Close();
					bl9BKPaYOyTwXdO4Msyk.C9yaYpRpuNf((string)sHFJlsLgJ91UJciyor1C(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-176525661 ^ -176665737), ppRiGRerwKe.Code, eAG3itLgPmY1DlnMFlF7(ppRiGRerwKe)));
					num2 = 4;
					goto IL_002c;
				}
				goto IL_0139;
				IL_0139:
				TaskAwaiter awaiter = TLqiG6VdcZP;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b != 0)
				{
					num2 = 1;
				}
				goto IL_002c;
				IL_002c:
				while (true)
				{
					switch (num2)
					{
					case 5:
					{
						num = (qnViGQOVgGp = -1);
						int num3 = 2;
						num2 = num3;
						continue;
					}
					case 4:
						if (!bl9BKPaYOyTwXdO4Msyk.AnIaoUDQWFY)
						{
							goto end_IL_002c;
						}
						awaiter = bl9BKPaYOyTwXdO4Msyk.ignaYCWLRrJ().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (qnViGQOVgGp = 0);
							TLqiG6VdcZP = awaiter;
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					case 3:
						break;
					case 2:
						awaiter.GetResult();
						goto end_IL_002c;
					default:
						g7fiGdrrkEn.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1:
						TLqiG6VdcZP = default(TaskAwaiter);
						num2 = 5;
						continue;
					}
					goto IL_0139;
					continue;
					end_IL_002c:
					break;
				}
			}
			catch (Exception exception)
			{
				qnViGQOVgGp = -2;
				g7fiGdrrkEn.SetException(exception);
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
				return;
			}
			while (true)
			{
				qnViGQOVgGp = -2;
				g7fiGdrrkEn.SetResult();
				int num5 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
				{
					num5 = 1;
				}
				switch (num5)
				{
				case 1:
					return;
				}
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
			g7fiGdrrkEn.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static mvkWaJiGEB3E3FUoQ2gC()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object eAG3itLgPmY1DlnMFlF7(object P_0)
		{
			return ((CloseEventArgs)P_0).Reason;
		}

		internal static object sHFJlsLgJ91UJciyor1C(object P_0, object P_1, object P_2)
		{
			return string.Format((string)P_0, P_1, P_2);
		}

		internal static bool SofIOtLg8wp5GSoeKfgs()
		{
			return o7YvRkLg7F1NO9JqDibp == null;
		}

		internal static object knhAbxLgAt2fxMGigC6g()
		{
			return o7YvRkLg7F1NO9JqDibp;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct sNM47OiGMfAKwYsO52gQ : IAsyncStateMachine
	{
		public int W5aiGOkGFZX;

		public AsyncVoidMethodBuilder OSJiGqLPYvi;

		public Bl9BKPaYOyTwXdO4Msyk ROFiGIL0Giy;

		public ErrorEventArgs L0miGW16fIa;

		private TaskAwaiter hUZiGtHfgPC;

		internal static object lCvxlnLgFrvk3KfaRp1Q;

		private void MoveNext()
		{
			int num = W5aiGOkGFZX;
			Bl9BKPaYOyTwXdO4Msyk bl9BKPaYOyTwXdO4Msyk = ROFiGIL0Giy;
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
			{
				num2 = 1;
			}
			TaskAwaiter awaiter = default(TaskAwaiter);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					try
					{
						int num3;
						if (num != 0)
						{
							bl9BKPaYOyTwXdO4Msyk.Close();
							num3 = 4;
						}
						else
						{
							awaiter = hUZiGtHfgPC;
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
							{
								num3 = 0;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								hUZiGtHfgPC = awaiter;
								OSJiGqLPYvi.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								hUZiGtHfgPC = default(TaskAwaiter);
								num = (W5aiGOkGFZX = -1);
								num3 = 3;
								continue;
							case 1:
								if (!awaiter.IsCompleted)
								{
									num3 = 2;
									continue;
								}
								goto case 3;
							case 2:
								num = (W5aiGOkGFZX = 0);
								num3 = 5;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								awaiter.GetResult();
								break;
							case 4:
								bl9BKPaYOyTwXdO4Msyk.GyTaowF7RKh?.Invoke(L0miGW16fIa.Exception ?? new Exception(L0miGW16fIa.Message));
								if (bl9BKPaYOyTwXdO4Msyk.AnIaoUDQWFY)
								{
									awaiter = xebFK8LguBCowbQ5fxtV(bl9BKPaYOyTwXdO4Msyk.ignaYCWLRrJ());
									num3 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						W5aiGOkGFZX = -2;
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						}
						OSJiGqLPYvi.SetException(exception);
						return;
					}
					W5aiGOkGFZX = -2;
					OSJiGqLPYvi.SetResult();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
					{
						num2 = 0;
					}
					break;
				}
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
			OSJiGqLPYvi.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static sNM47OiGMfAKwYsO52gQ()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			HxpHyDLgzIuTXFKum8th();
		}

		internal static TaskAwaiter xebFK8LguBCowbQ5fxtV(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		internal static bool ak3OTdLg3nIPHoEZoUnh()
		{
			return lCvxlnLgFrvk3KfaRp1Q == null;
		}

		internal static object r2VOCULgp8DuZbEnEhe5()
		{
			return lCvxlnLgFrvk3KfaRp1Q;
		}

		internal static void HxpHyDLgzIuTXFKum8th()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private readonly bool iA9aoEiLAdN;

	private static long ftFaoQ7CBje;

	private readonly string UJdaodpe3pm;

	private readonly object aUPaogtuWsd;

	private readonly object a1ZaoR1CenD;

	private readonly string mMEao69HGKX;

	private readonly C3trUsajJIHJMtdo9pBg jDcaoMlWQoo;

	private WebSocket xyvaoOjfNJE;

	private readonly string Dtbaoqn3Aqh;

	private readonly heHRjXavcNFu0DWiuxhe oDHaoItKa0D;

	private SemaphoreSlim GC4aoWdqi5g;

	private bool epxaotUC3UU;

	private bool AnIaoUDQWFY;

	[CompilerGenerated]
	private int VULaoTU0p0o;

	private readonly Timer AIQaoy4HMxd;

	private readonly Action<string> E2jaoZo2rQK;

	private readonly Dictionary<string, Rybo1XGzd9ch5SOUQC2H> ilRaoVUcdNw;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> gjhaoCKs5js;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> GZ0aorxU7cZ;

	private ConcurrentDictionary<string, (bool, bool)> e4VaoKl0lfW;

	private Func<DateTimeOffset> FmpaomnRPwC;

	[CompilerGenerated]
	private Action<string, bool> tO3aohgGJRK;

	[CompilerGenerated]
	private Action<Exception> GyTaowF7RKh;

	[CompilerGenerated]
	private Action<mOTLJQa4uyPiJwynUL8R> uoaao7YcRLt;

	[CompilerGenerated]
	private Action<SecurityEvent> Euhao8ctQli;

	[CompilerGenerated]
	private Action<OkWq1PaDThitifkx90sL> RhbaoAWTJnL;

	[CompilerGenerated]
	private Action<I2ngA9ai5VZChqQ7WSBT> oHTaoPCv8Ss;

	[CompilerGenerated]
	private Action<GNctRLa4TxX6mLvdxLOn> bNRaoJLx8Go;

	[CompilerGenerated]
	private Action<P2VYHDaiAUacHyEv0hbX> MlQaoFr3u2x;

	private static Bl9BKPaYOyTwXdO4Msyk VQDXppxZyeQRKchddf30;

	[SpecialName]
	[CompilerGenerated]
	public int IakaYuIIRF2()
	{
		return VULaoTU0p0o;
	}

	[SpecialName]
	[CompilerGenerated]
	public void HDUaYz2WsLd(int P_0)
	{
		VULaoTU0p0o = P_0;
	}

	[SpecialName]
	public bool Vr9ao2HujmD()
	{
		return gjhaoCKs5js.Count < 100;
	}

	[SpecialName]
	public bool F6LaofK29sG()
	{
		return wZrh1vxZCa0Z9FaDCKD3(gjhaoCKs5js) == 0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void pScaonTTmiy(Action<string, bool> P_0)
	{
		Action<string, bool> action = tO3aohgGJRK;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref tO3aohgGJRK, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void tElaoG90t4U(Action<string, bool> P_0)
	{
		Action<string, bool> action = tO3aohgGJRK;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref tO3aohgGJRK, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void WAtaooHO127(Action<Exception> P_0)
	{
		Action<Exception> action = GyTaowF7RKh;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref GyTaowF7RKh, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void p1haov8r92u(Action<Exception> P_0)
	{
		Action<Exception> action = GyTaowF7RKh;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref GyTaowF7RKh, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void bbEaoaNFBif(Action<mOTLJQa4uyPiJwynUL8R> P_0)
	{
		Action<mOTLJQa4uyPiJwynUL8R> action = uoaao7YcRLt;
		Action<mOTLJQa4uyPiJwynUL8R> action2;
		do
		{
			action2 = action;
			Action<mOTLJQa4uyPiJwynUL8R> value = (Action<mOTLJQa4uyPiJwynUL8R>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref uoaao7YcRLt, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void rCtaoiL50Ho(Action<mOTLJQa4uyPiJwynUL8R> P_0)
	{
		Action<mOTLJQa4uyPiJwynUL8R> action = uoaao7YcRLt;
		Action<mOTLJQa4uyPiJwynUL8R> action2;
		do
		{
			action2 = action;
			Action<mOTLJQa4uyPiJwynUL8R> value = (Action<mOTLJQa4uyPiJwynUL8R>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref uoaao7YcRLt, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void IFTao4aVrY9(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = Euhao8ctQli;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref Euhao8ctQli, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void QbpaoD4aQUJ(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = Euhao8ctQli;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref Euhao8ctQli, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void CWqaoNQTVUS(Action<OkWq1PaDThitifkx90sL> P_0)
	{
		Action<OkWq1PaDThitifkx90sL> action = RhbaoAWTJnL;
		Action<OkWq1PaDThitifkx90sL> action2;
		do
		{
			action2 = action;
			Action<OkWq1PaDThitifkx90sL> value = (Action<OkWq1PaDThitifkx90sL>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref RhbaoAWTJnL, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void l3vaoklOLb5(Action<OkWq1PaDThitifkx90sL> P_0)
	{
		Action<OkWq1PaDThitifkx90sL> action = RhbaoAWTJnL;
		Action<OkWq1PaDThitifkx90sL> action2;
		do
		{
			action2 = action;
			Action<OkWq1PaDThitifkx90sL> value = (Action<OkWq1PaDThitifkx90sL>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref RhbaoAWTJnL, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void oCtao5nvmHs(Action<I2ngA9ai5VZChqQ7WSBT> P_0)
	{
		Action<I2ngA9ai5VZChqQ7WSBT> action = oHTaoPCv8Ss;
		Action<I2ngA9ai5VZChqQ7WSBT> action2;
		do
		{
			action2 = action;
			Action<I2ngA9ai5VZChqQ7WSBT> value = (Action<I2ngA9ai5VZChqQ7WSBT>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref oHTaoPCv8Ss, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void DE5aoSsKFcA(Action<I2ngA9ai5VZChqQ7WSBT> P_0)
	{
		Action<I2ngA9ai5VZChqQ7WSBT> action = oHTaoPCv8Ss;
		Action<I2ngA9ai5VZChqQ7WSBT> action2;
		do
		{
			action2 = action;
			Action<I2ngA9ai5VZChqQ7WSBT> value = (Action<I2ngA9ai5VZChqQ7WSBT>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref oHTaoPCv8Ss, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void rFbaoLX60j4(Action<GNctRLa4TxX6mLvdxLOn> P_0)
	{
		Action<GNctRLa4TxX6mLvdxLOn> action = bNRaoJLx8Go;
		Action<GNctRLa4TxX6mLvdxLOn> action2;
		do
		{
			action2 = action;
			Action<GNctRLa4TxX6mLvdxLOn> value = (Action<GNctRLa4TxX6mLvdxLOn>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref bNRaoJLx8Go, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void UgjaoeKMy8D(Action<GNctRLa4TxX6mLvdxLOn> P_0)
	{
		Action<GNctRLa4TxX6mLvdxLOn> action = bNRaoJLx8Go;
		Action<GNctRLa4TxX6mLvdxLOn> action2;
		do
		{
			action2 = action;
			Action<GNctRLa4TxX6mLvdxLOn> value = (Action<GNctRLa4TxX6mLvdxLOn>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref bNRaoJLx8Go, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void SrbaoXSVWh7(Action<P2VYHDaiAUacHyEv0hbX> P_0)
	{
		Action<P2VYHDaiAUacHyEv0hbX> action = MlQaoFr3u2x;
		Action<P2VYHDaiAUacHyEv0hbX> action2;
		do
		{
			action2 = action;
			Action<P2VYHDaiAUacHyEv0hbX> value = (Action<P2VYHDaiAUacHyEv0hbX>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref MlQaoFr3u2x, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void hfqaocGtUAo(Action<P2VYHDaiAUacHyEv0hbX> P_0)
	{
		Action<P2VYHDaiAUacHyEv0hbX> action = MlQaoFr3u2x;
		Action<P2VYHDaiAUacHyEv0hbX> action2;
		do
		{
			action2 = action;
			Action<P2VYHDaiAUacHyEv0hbX> value = (Action<P2VYHDaiAUacHyEv0hbX>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref MlQaoFr3u2x, value, action2);
		}
		while ((object)action != action2);
	}

	public Bl9BKPaYOyTwXdO4Msyk(rWKthDaBBumJKpZCOVF1 P_0, C3trUsajJIHJMtdo9pBg P_1, Action P_2, Action<string> P_3, string P_4, Func<DateTimeOffset> P_5 = null)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		iA9aoEiLAdN = Convert.ToBoolean(ConfigurationManager.AppSettings[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461949456 ^ -1461904996)]);
		aUPaogtuWsd = new object();
		a1ZaoR1CenD = new object();
		GC4aoWdqi5g = new SemaphoreSlim(1, 1);
		VULaoTU0p0o = 10000;
		ilRaoVUcdNw = new Dictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		gjhaoCKs5js = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		GZ0aorxU7cZ = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		e4VaoKl0lfW = new ConcurrentDictionary<string, (bool, bool)>();
		base._002Ector();
		UJdaodpe3pm = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1962651919 ^ -1962564127), Interlocked.Increment(ref ftFaoQ7CBje), P_4);
		mMEao69HGKX = P_0.NG5aBDlgoWJ();
		Dtbaoqn3Aqh = P_0.XUBaBkZdXeK();
		byte[] buf = Convert.FromBase64String(P_0.apyaBSh2YcW());
		oDHaoItKa0D = new heHRjXavcNFu0DWiuxhe(new Ed25519PrivateKeyParameters(buf));
		jDcaoMlWQoo = P_1;
		E2jaoZo2rQK = P_3;
		FmpaomnRPwC = P_5 ?? ((Func<DateTimeOffset>)(() => qpJdnsin0XWFHMAiLx91.Qp3vCMLdKynGwm5GQttx()));
		AIQaoy4HMxd = new Timer(WlNaYT6auEx, null, -1, -1);
	}

	public void KZYaYIkFtkW()
	{
		AnIaoUDQWFY = true;
		ignaYCWLRrJ();
	}

	public void Disconnect()
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
				AnIaoUDQWFY = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
			{
				Timer aIQaoy4HMxd = AIQaoy4HMxd;
				if (aIQaoy4HMxd != null)
				{
					wrchUIxZrp0gYySjJQ9N(aIQaoy4HMxd, -1, -1);
				}
				ilRaoVUcdNw.Clear();
				Close();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public bool AcRaYWN4dJe(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		return gjhaoCKs5js.TryAdd(P_0.Code, P_0);
	}

	public bool r5XaYt0l41D(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		gjhaoCKs5js.TryRemove(P_0.Code, out var _);
		return GZ0aorxU7cZ.TryAdd(P_0.Code, P_0);
	}

	public void XgoaYUKjbRj()
	{
		int num = 6;
		List<string> list = default(List<string>);
		Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = default(Rybo1XGzd9ch5SOUQC2H);
		int num3 = default(int);
		Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H2 = default(Rybo1XGzd9ch5SOUQC2H);
		Rybo1XGzd9ch5SOUQC2H[] array = default(Rybo1XGzd9ch5SOUQC2H[]);
		List<string> list2 = default(List<string>);
		Rybo1XGzd9ch5SOUQC2H[] array2 = default(Rybo1XGzd9ch5SOUQC2H[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					list.Add((string)nXkqfExZm9TAyEEsd3X2(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F55E538 ^ 0x7F540E6E), rybo1XGzd9ch5SOUQC2H.Code.ToUpper()));
					num3++;
					goto case 12;
				case 15:
					rybo1XGzd9ch5SOUQC2H2 = array[num3];
					ilRaoVUcdNw[rybo1XGzd9ch5SOUQC2H2.Code] = rybo1XGzd9ch5SOUQC2H2;
					if (!rybo1XGzd9ch5SOUQC2H2.kHYGzP3WQN1)
					{
						num2 = 16;
						break;
					}
					list2.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x24B0B9E6 ^ 0x24B12D68) + rybo1XGzd9ch5SOUQC2H2.Code.ToUpper());
					list2.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769D9215) + rybo1XGzd9ch5SOUQC2H2.Code.ToUpper());
					list2.Add((string)nXkqfExZm9TAyEEsd3X2(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181336792), N8cHbRxZh9vJJRCiDZe9(rybo1XGzd9ch5SOUQC2H2.Code)));
					num2 = 7;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
					{
						num2 = 4;
					}
					break;
				case 10:
					if (WF1NPQxZ72JECBbAC9WO(list2) > 0)
					{
						Subscribe(list2.ToArray());
					}
					return;
				case 5:
					if (GZ0aorxU7cZ.Any())
					{
						num2 = 8;
						break;
					}
					return;
				case 4:
					if (WF1NPQxZ72JECBbAC9WO(list) <= 0)
					{
						num2 = 10;
						break;
					}
					Unsubscribe(list.ToArray());
					goto case 10;
				case 13:
					rybo1XGzd9ch5SOUQC2H = array[num3];
					ilRaoVUcdNw.Remove(rybo1XGzd9ch5SOUQC2H.Code);
					list.Add((string)HRBUNsxZKg4m74Gjbkhs(-1606927328 ^ -1606834002) + rybo1XGzd9ch5SOUQC2H.Code.ToUpper());
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					num3 = 0;
					num2 = 12;
					break;
				case 8:
				{
					array2 = gjhaoCKs5js.Values.ToArray();
					Rybo1XGzd9ch5SOUQC2H[] array3 = GZ0aorxU7cZ.Values.ToArray();
					gjhaoCKs5js.Clear();
					GZ0aorxU7cZ.Clear();
					list = new List<string>();
					array = array3;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
					{
						num2 = 2;
					}
					break;
				}
				case 3:
					if (num3 >= array.Length)
					{
						num2 = 4;
						break;
					}
					goto case 15;
				case 14:
					if (rybo1XGzd9ch5SOUQC2H2.m54GzFaRoc7)
					{
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_03be;
				case 1:
					list2.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-377195341 ^ -377118921) + ((string)yF9Mp3xZwMI0wE7c6Wsh(rybo1XGzd9ch5SOUQC2H2)).ToUpper());
					goto IL_03be;
				case 7:
					list2.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x24B0B9E6 ^ 0x24B152B0) + ((string)yF9Mp3xZwMI0wE7c6Wsh(rybo1XGzd9ch5SOUQC2H2)).ToUpper());
					goto case 16;
				case 6:
					if (!gjhaoCKs5js.Any())
					{
						num2 = 5;
						break;
					}
					goto case 8;
				default:
					list.Add((string)nXkqfExZm9TAyEEsd3X2(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-3429745 ^ -3522133), rybo1XGzd9ch5SOUQC2H.Code.ToUpper()));
					num2 = 9;
					break;
				case 9:
					list.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-44540535 ^ -44452169) + rybo1XGzd9ch5SOUQC2H.Code.ToUpper());
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
					{
						num2 = 11;
					}
					break;
				case 12:
					if (num3 >= array.Length)
					{
						goto end_IL_0012;
					}
					goto case 13;
				case 16:
					{
						if (rybo1XGzd9ch5SOUQC2H2.E07GzJKBNZY)
						{
							list2.Add((string)HRBUNsxZKg4m74Gjbkhs(-1878953018 ^ -1879009102) + (string)N8cHbRxZh9vJJRCiDZe9(rybo1XGzd9ch5SOUQC2H2.Code));
							num2 = 14;
							break;
						}
						goto case 14;
					}
					IL_03be:
					num3++;
					goto case 3;
				}
				continue;
				end_IL_0012:
				break;
			}
			list2 = new List<string>();
			array = array2;
			num3 = 0;
			num = 3;
		}
	}

	private void WlNaYT6auEx(object P_0)
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Invalid comparison between Unknown and I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Invalid comparison between Unknown and I4
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				return;
			case 1:
			{
				WebSocket obj2 = xyvaoOjfNJE;
				if (obj2 != null && (int)obj2.ReadyState == 1)
				{
					WebSocket obj3 = xyvaoOjfNJE;
					if (obj3 != null && obj3.IsAlive)
					{
						return;
					}
				}
				C9yaYpRpuNf((string)HRBUNsxZKg4m74Gjbkhs(-82860344 ^ -82914192));
				num2 = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
			{
				WebSocket obj5 = xyvaoOjfNJE;
				if (obj5 == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 != 0)
					{
						num2 = 1;
					}
					break;
				}
				if ((int)obj5.ReadyState == 2)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
			case 4:
				if (!epxaotUC3UU)
				{
					WebSocket obj4 = xyvaoOjfNJE;
					if (obj4 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
						{
							num2 = 0;
						}
						break;
					}
					if ((int)DJCKSHxZ8TC9uRdiN9iK(obj4) == 0)
					{
						return;
					}
					goto default;
				}
				num2 = 3;
				break;
			case 5:
			{
				WebSocket obj = xyvaoOjfNJE;
				if (obj != null)
				{
					obj.CloseAsync();
				}
				return;
			}
			}
		}
	}

	[AsyncStateMachine(typeof(AcyVJJinGRQiWvWYmRlA))]
	public Task Subscribe(string channel, bool isPrivate = false)
	{
		AcyVJJinGRQiWvWYmRlA stateMachine = default(AcyVJJinGRQiWvWYmRlA);
		stateMachine.ej5inoplSU4 = AsyncTaskMethodBuilder.Create();
		stateMachine.RF0invnqCKb = this;
		stateMachine.F2linBnyxgr = channel;
		stateMachine.EAiinalFxCo = isPrivate;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.ej5inoplSU4.Start(ref stateMachine);
				return stateMachine.ej5inoplSU4.Task;
			}
			stateMachine.zfbinYgmytF = -1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
			{
				num = 1;
			}
		}
	}

	[AsyncStateMachine(typeof(TPExJrinl46hQBjvwFij))]
	public Task Subscribe(string[] channels, bool isPrivate = false)
	{
		TPExJrinl46hQBjvwFij stateMachine = default(TPExJrinl46hQBjvwFij);
		stateMachine.XISinDIeg83 = AsyncTaskMethodBuilder.Create();
		stateMachine.nR7inNunF02 = this;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.R0rinbRPxTw = channels;
				stateMachine.nCwinkdrrjb = isPrivate;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
				{
					num = 0;
				}
				break;
			default:
				stateMachine.fEcin4aCubn = -1;
				stateMachine.XISinDIeg83.Start(ref stateMachine);
				return stateMachine.XISinDIeg83.Task;
			}
		}
	}

	[AsyncStateMachine(typeof(HjCgtrinX2peWWiHBYV1))]
	public Task wL4aYyJ3ROe(string[] P_0, bool P_1 = false)
	{
		HjCgtrinX2peWWiHBYV1 stateMachine = default(HjCgtrinX2peWWiHBYV1);
		stateMachine.wffinjQfFmn = AsyncTaskMethodBuilder.Create();
		stateMachine.eSkinQIeTas = this;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.okcindMa14L = P_0;
				stateMachine.Q9yinEJ64am = P_1;
				stateMachine.MX2incnNVQ2 = -1;
				stateMachine.wffinjQfFmn.Start(ref stateMachine);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 != 0)
				{
					num = 0;
				}
				break;
			default:
				return stateMachine.wffinjQfFmn.Task;
			}
		}
	}

	[AsyncStateMachine(typeof(oW9mCxinMFOvHhSAIs9F))]
	public Task Unsubscribe(string channel)
	{
		int num = 2;
		int num2 = num;
		oW9mCxinMFOvHhSAIs9F stateMachine = default(oW9mCxinMFOvHhSAIs9F);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine.jSNinWdqguF = channel;
				stateMachine.fJ0inOIad6d = -1;
				stateMachine.Hp7inqt5lJI.Start(ref stateMachine);
				return stateMachine.Hp7inqt5lJI.Task;
			case 1:
				stateMachine.xgXinILTf8A = this;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine.Hp7inqt5lJI = AsyncTaskMethodBuilder.Create();
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(y4sSEwinUkyJum1UHN9Y))]
	public Task Unsubscribe(string[] channels, bool isPrivate = false)
	{
		y4sSEwinUkyJum1UHN9Y stateMachine = default(y4sSEwinUkyJum1UHN9Y);
		stateMachine.wukinycED9D = AsyncTaskMethodBuilder.Create();
		stateMachine.tMcinZfUegv = this;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return stateMachine.wukinycED9D.Task;
			}
			stateMachine.NCminViTLtC = channels;
			stateMachine.ni0inCZgYoL = isPrivate;
			stateMachine.gNTinTycMva = -1;
			stateMachine.wukinycED9D.Start(ref stateMachine);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
			{
				num = 0;
			}
		}
	}

	[AsyncStateMachine(typeof(nJYYRFinJGvLEdRLuprx))]
	private Task zZ6aYZWV04R(bool P_0 = false)
	{
		int num = 2;
		int num2 = num;
		nJYYRFinJGvLEdRLuprx stateMachine = default(nJYYRFinJGvLEdRLuprx);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine.Pe4inFbe3pP = -1;
				stateMachine.ffEin3Y4E4R.Start(ref stateMachine);
				return stateMachine.ffEin3Y4E4R.Task;
			case 1:
				stateMachine.HNpinpimPFB = this;
				stateMachine.dwHinulNJG1 = P_0;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine.ffEin3Y4E4R = AsyncTaskMethodBuilder.Create();
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void wqBaYVgKwph()
	{
		using IEnumerator<KeyValuePair<string, (bool, bool)>> enumerator = e4VaoKl0lfW.GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, (bool, bool)> current = enumerator.Current;
			e4VaoKl0lfW[current.Key] = (false, current.Value.Item2);
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[AsyncStateMachine(typeof(rucH1ciG0jIVFmVwIMBO))]
	private Task ignaYCWLRrJ()
	{
		rucH1ciG0jIVFmVwIMBO stateMachine = default(rucH1ciG0jIVFmVwIMBO);
		stateMachine.hoNiGH1Dk6g = AsyncTaskMethodBuilder.Create();
		stateMachine.Dq7iGffdXo3 = this;
		stateMachine.zvqiG2vH2w1 = -1;
		stateMachine.hoNiGH1Dk6g.Start(ref stateMachine);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b != 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => stateMachine.hoNiGH1Dk6g.Task, 
		};
	}

	private Task mpwaYrZBPhm()
	{
		return OU0aYhpCNP0((Action)xyvaoOjfNJE.Connect);
	}

	private Task DWqaYKG72D7(string P_0)
	{
		oQK4ZniGnpTp89ChOdvR CS_0024_003C_003E8__locals4 = new oQK4ZniGnpTp89ChOdvR();
		CS_0024_003C_003E8__locals4.IQhiGYAjh0f = this;
		CS_0024_003C_003E8__locals4.hjViGownkeJ = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => OU0aYhpCNP0(delegate
			{
				WebSocket obj = CS_0024_003C_003E8__locals4.IQhiGYAjh0f.xyvaoOjfNJE;
				if (obj != null)
				{
					obj.Send(CS_0024_003C_003E8__locals4.hjViGownkeJ);
				}
			}), 
		};
	}

	[AsyncStateMachine(typeof(dRLyuyiGvE7apXrew26R))]
	private Task<bool> uT4aYmueseu(ybCTFpaSBe900G1N4E1N P_0, string[] P_1, bool P_2 = false)
	{
		dRLyuyiGvE7apXrew26R stateMachine = default(dRLyuyiGvE7apXrew26R);
		stateMachine.bCkiGa8pDZ8 = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.rGniGiq4G0Z = this;
		stateMachine.LSqiG4NJh3a = P_0;
		stateMachine.geZiGDNkodU = P_1;
		stateMachine.LCNiGlfg1oA = P_2;
		stateMachine.mvAiGBFTML7 = -1;
		stateMachine.bCkiGa8pDZ8.Start(ref stateMachine);
		return stateMachine.bCkiGa8pDZ8.Task;
	}

	[AsyncStateMachine(typeof(pTdAmuiGNLf65ih9nCta))]
	private Task OU0aYhpCNP0(Action P_0)
	{
		int num = 1;
		int num2 = num;
		pTdAmuiGNLf65ih9nCta stateMachine = default(pTdAmuiGNLf65ih9nCta);
		while (true)
		{
			switch (num2)
			{
			case 2:
				stateMachine.PB2iGkm1dr6 = -1;
				stateMachine.aXliG1bTuxU.Start(ref stateMachine);
				return stateMachine.aXliG1bTuxU.Task;
			case 1:
				stateMachine.aXliG1bTuxU = FGjLpIxZATQEt3HiqLW1();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
				{
					num2 = 0;
				}
				continue;
			}
			stateMachine.EYLiGSH4cTO = this;
			stateMachine.VXeiG5Z2cjM = P_0;
			num2 = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
			{
				num2 = 0;
			}
		}
	}

	public void Close()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				eweaYFcjS4f();
				WebSocket obj = xyvaoOjfNJE;
				if (obj != null)
				{
					obj.CloseAsync();
				}
				xyvaoOjfNJE = null;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				wqBaYVgKwph();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[AsyncStateMachine(typeof(V0O0nyiGexwgIQlNTD7P))]
	private void vhMaYwjenh7(object P_0, EventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		V0O0nyiGexwgIQlNTD7P stateMachine = default(V0O0nyiGexwgIQlNTD7P);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine.DnGiGcmh1KE = this;
				stateMachine.zYuiGs2SMKy = -1;
				stateMachine.YSriGXHlspS.Start(ref stateMachine);
				return;
			case 1:
				stateMachine.YSriGXHlspS = AsyncVoidMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(mvkWaJiGEB3E3FUoQ2gC))]
	private void jOVaY7qSOyC(object P_0, CloseEventArgs P_1)
	{
		mvkWaJiGEB3E3FUoQ2gC stateMachine = default(mvkWaJiGEB3E3FUoQ2gC);
		stateMachine.g7fiGdrrkEn = AsyncVoidMethodBuilder.Create();
		stateMachine.n4viGg9HjWa = this;
		stateMachine.ppRiGRerwKe = P_1;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.g7fiGdrrkEn.Start(ref stateMachine);
				return;
			}
			stateMachine.qnViGQOVgGp = -1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
			{
				num = 1;
			}
		}
	}

	[AsyncStateMachine(typeof(sNM47OiGMfAKwYsO52gQ))]
	private void XPkaY8qF1mx(object P_0, ErrorEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		sNM47OiGMfAKwYsO52gQ stateMachine = default(sNM47OiGMfAKwYsO52gQ);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine.ROFiGIL0Giy = this;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				stateMachine.L0miGW16fIa = P_1;
				stateMachine.W5aiGOkGFZX = -1;
				stateMachine.OSJiGqLPYvi.Start(ref stateMachine);
				return;
			case 1:
				stateMachine.OSJiGqLPYvi = ESipHgxZPMShBaHZNCsF();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void MLCaYArRpN5(object P_0, MessageEventArgs P_1)
	{
		if (P_1.IsPing)
		{
			return;
		}
		try
		{
			DMp0KAai9uIl1q53EwFw dMp0KAai9uIl1q53EwFw = JsonConvert.DeserializeObject<DMp0KAai9uIl1q53EwFw>(P_1.Data);
			int num = 11;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
			{
				num = 2;
			}
			string text = default(string);
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 3:
					return;
				case 4:
					return;
				case 5:
					return;
				case 9:
					return;
				case 10:
					if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x86EFEF6 ^ 0x86FC3C0))
					{
						goto default;
					}
					if (!k8pZkTxZFTd6lNaO1bES(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1009517961 ^ -1009612881)))
					{
						if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5CD4F15 ^ 0x5CCD6D3)))
						{
							num = 7;
							break;
						}
						MlQaoFr3u2x?.Invoke(((JToken)kh9dyfxZ3s5vioWZlRwy(dMp0KAai9uIl1q53EwFw)).ToObject<P2VYHDaiAUacHyEv0hbX>());
						return;
					}
					goto case 6;
				default:
				{
					Action<OkWq1PaDThitifkx90sL> action2 = RhbaoAWTJnL;
					if (action2 == null)
					{
						return;
					}
					action2(((JToken)dMp0KAai9uIl1q53EwFw.CEAaiaGCoif).ToObject<OkWq1PaDThitifkx90sL>());
					num = 4;
					break;
				}
				case 7:
					if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1127423276 ^ -1127450220)))
					{
						return;
					}
					goto case 8;
				case 8:
					VPuaYPBvQyR(((JToken)dMp0KAai9uIl1q53EwFw.CEAaiaGCoif).ToObject<IjjCe3aaQ9gNChuFBC5u>());
					return;
				case 6:
				{
					Action<GNctRLa4TxX6mLvdxLOn> action4 = bNRaoJLx8Go;
					if (action4 == null)
					{
						return;
					}
					action4(((JToken)dMp0KAai9uIl1q53EwFw.CEAaiaGCoif).ToObject<GNctRLa4TxX6mLvdxLOn>());
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
					{
						num = 0;
					}
					break;
				}
				case 11:
					if (dMp0KAai9uIl1q53EwFw == null)
					{
						return;
					}
					if (dMp0KAai9uIl1q53EwFw.vLDaioiqHu0 == null)
					{
						num = 5;
						break;
					}
					text = ((string)twv8SKxZJLghdRnpaEDw(dMp0KAai9uIl1q53EwFw)).Split(new char[1] { '.' })[0];
					if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-29702950 ^ -29684348)))
					{
						if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6D18F862 ^ 0x6D191B3A)))
						{
							num = 10;
							break;
						}
						Action<I2ngA9ai5VZChqQ7WSBT> action = oHTaoPCv8Ss;
						if (action == null)
						{
							return;
						}
						action(((JToken)dMp0KAai9uIl1q53EwFw.CEAaiaGCoif).ToObject<I2ngA9ai5VZChqQ7WSBT>());
						num = 3;
						break;
					}
					goto case 2;
				case 2:
				{
					Action<mOTLJQa4uyPiJwynUL8R> action3 = uoaao7YcRLt;
					if (action3 == null)
					{
						return;
					}
					action3(((JToken)dMp0KAai9uIl1q53EwFw.CEAaiaGCoif).ToObject<mOTLJQa4uyPiJwynUL8R>());
					num = 9;
					break;
				}
				}
			}
		}
		catch (Exception obj)
		{
			Action<Exception> action5 = GyTaowF7RKh;
			if (action5 == null)
			{
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				action5(obj);
			}
		}
	}

	private void VPuaYPBvQyR(IjjCe3aaQ9gNChuFBC5u P_0)
	{
		try
		{
			if (!ilRaoVUcdNw.TryGetValue(P_0.Symbol, out var value))
			{
				return;
			}
			SecurityEvent securityEvent = default(SecurityEvent);
			while (value.kHYGzP3WQN1)
			{
				Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = value;
				int num = 3;
				while (true)
				{
					Action<SecurityEvent> action;
					switch (num)
					{
					case 1:
					{
						pul5AnxZzKBSqjSmTmGG(P_0);
						securityEvent.FundingRate = (double)(pul5AnxZzKBSqjSmTmGG(P_0) * 100m);
						int num2 = 2;
						num = num2;
						continue;
					}
					case 3:
						securityEvent = (SecurityEvent)HFFRTDxZugmeORXBUZex(LglUjsxZpAhsIRVexDRL(rybo1XGzd9ch5SOUQC2H));
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
						{
							num = 1;
						}
						continue;
					default:
						UETH72GzDcyNAirT5ahJ.E09GzekvJKi().gZNGzNGhYT9(rybo1XGzd9ch5SOUQC2H.Symbol.ID, securityEvent.FundingRate, RUK2i2xV0JKmBKvWNLIM(P_0));
						goto IL_011b;
					case 2:
						if (RUK2i2xV0JKmBKvWNLIM(P_0) != 0L)
						{
							securityEvent.FundingNext = P_0.GYuaaTMSAfQ;
							num = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
							{
								num = 0;
							}
							continue;
						}
						goto IL_011b;
					case 5:
						break;
					case 4:
						return;
						IL_011b:
						action = Euhao8ctQli;
						if (action == null)
						{
							num = 4;
							continue;
						}
						action(securityEvent);
						return;
					}
					break;
				}
			}
		}
		catch (Exception obj)
		{
			Action<Exception> action2 = GyTaowF7RKh;
			if (action2 == null)
			{
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
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
				action2(obj);
			}
		}
	}

	private void gyDaYJpE89S()
	{
		xyvaoOjfNJE.OnOpen += vhMaYwjenh7;
		xyvaoOjfNJE.OnClose += jOVaY7qSOyC;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		xyvaoOjfNJE.OnError += XPkaY8qF1mx;
		xyvaoOjfNJE.OnMessage += MLCaYArRpN5;
	}

	private void eweaYFcjS4f()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (xyvaoOjfNJE == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
					{
						num2 = 0;
					}
					break;
				}
				IHvyf8xV2fpjPkmCMdlJ(xyvaoOjfNJE, new EventHandler(vhMaYwjenh7));
				xyvaoOjfNJE.OnClose -= jOVaY7qSOyC;
				xyvaoOjfNJE.OnError -= XPkaY8qF1mx;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				xyvaoOjfNJE.OnMessage -= MLCaYArRpN5;
				return;
			}
		}
	}

	private void hagaY3gNVCv()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				((SslConfiguration)xyvaoOjfNJE.SslConfiguration).EnabledSslProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;
				if (jDcaoMlWQoo.TRAaE0bpPZ4())
				{
					xyvaoOjfNJE.SetProxy(jDcaoMlWQoo.Url, jDcaoMlWQoo.OCiaEYswnjC(), (string)bdsdh0xVHDj18wivcd4M(jDcaoMlWQoo));
				}
				gyDaYJpE89S();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				xyvaoOjfNJE = new WebSocket(mMEao69HGKX, Array.Empty<string>())
				{
					EmitOnPing = true,
					WaitTime = TimeSpan.FromSeconds(10.0)
				};
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Dispose()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Close();
				return;
			case 1:
				return;
			case 2:
				if (!epxaotUC3UU)
				{
					epxaotUC3UU = true;
					Timer aIQaoy4HMxd = AIQaoy4HMxd;
					if (aIQaoy4HMxd == null)
					{
						goto default;
					}
					yDwFqLxVfsDmIHKVNawJ(aIQaoy4HMxd);
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
					{
						num2 = 0;
					}
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void C9yaYpRpuNf(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (iA9aoEiLAdN)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				E2jaoZo2rQK?.Invoke((string)bhnLLJxV9iQSc0OfVn4N(UJdaodpe3pm, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-520155535 ^ -520116771), P_0));
				return;
			}
		}
	}

	static Bl9BKPaYOyTwXdO4Msyk()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool qEey98xZZxOq6utunj2D()
	{
		return VQDXppxZyeQRKchddf30 == null;
	}

	internal static Bl9BKPaYOyTwXdO4Msyk T99f0gxZVOxJC4JZIBXa()
	{
		return VQDXppxZyeQRKchddf30;
	}

	internal static int wZrh1vxZCa0Z9FaDCKD3(object P_0)
	{
		return ((ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>)P_0).Count;
	}

	internal static bool wrchUIxZrp0gYySjJQ9N(object P_0, int P_1, int P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}

	internal static object HRBUNsxZKg4m74Gjbkhs(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object nXkqfExZm9TAyEEsd3X2(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object N8cHbRxZh9vJJRCiDZe9(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object yF9Mp3xZwMI0wE7c6Wsh(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Code;
	}

	internal static int WF1NPQxZ72JECBbAC9WO(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static WebSocketState DJCKSHxZ8TC9uRdiN9iK(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static AsyncTaskMethodBuilder FGjLpIxZATQEt3HiqLW1()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static AsyncVoidMethodBuilder ESipHgxZPMShBaHZNCsF()
	{
		return AsyncVoidMethodBuilder.Create();
	}

	internal static object twv8SKxZJLghdRnpaEDw(object P_0)
	{
		return ((DMp0KAai9uIl1q53EwFw)P_0).vLDaioiqHu0;
	}

	internal static bool k8pZkTxZFTd6lNaO1bES(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object kh9dyfxZ3s5vioWZlRwy(object P_0)
	{
		return ((DMp0KAai9uIl1q53EwFw)P_0).CEAaiaGCoif;
	}

	internal static object LglUjsxZpAhsIRVexDRL(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Symbol;
	}

	internal static object HFFRTDxZugmeORXBUZex(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.W24GFlpvq8h((Symbol)P_0);
	}

	internal static decimal pul5AnxZzKBSqjSmTmGG(object P_0)
	{
		return ((IjjCe3aaQ9gNChuFBC5u)P_0).dACaaW2W22k;
	}

	internal static long RUK2i2xV0JKmBKvWNLIM(object P_0)
	{
		return ((IjjCe3aaQ9gNChuFBC5u)P_0).GYuaaTMSAfQ;
	}

	internal static void IHvyf8xV2fpjPkmCMdlJ(object P_0, object P_1)
	{
		((WebSocket)P_0).OnOpen -= (EventHandler)P_1;
	}

	internal static object bdsdh0xVHDj18wivcd4M(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Password;
	}

	internal static void yDwFqLxVfsDmIHKVNawJ(object P_0)
	{
		((Timer)P_0).Dispose();
	}

	internal static object bhnLLJxV9iQSc0OfVn4N(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
