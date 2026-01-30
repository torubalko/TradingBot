using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using Cd9gDBHe7p0apEd7AdMg;
using dUn2yJ9f6P2UZZ4Qpn;
using ECOEgqlSad8NUJZ2Dr9n;
using gye4ecHbAhUURhS3ga;
using Newtonsoft.Json;
using TigerTrade.Config.Common;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;

namespace uYplnWHIfqg5T2KfikxM;

internal class bPQZS9HIHRR7iHYLorGJ
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct hJYWfenmXek5DcuDG3Fy : IAsyncStateMachine
	{
		public int XoKnmciii4G;

		public AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD> eWGnmjlJE6u;

		public bPQZS9HIHRR7iHYLorGJ iP2nmE1hnbM;

		public string pXGnmQHE7ub;

		private HttpResponseMessage RqpnmdZ4Bj7;

		private string xQunmgyXtRw;

		private string NVNnmRZHopR;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter Swwnm69ic7p;

		private TaskAwaiter<string> MKGnmMxP9qn;

		internal static object HhZUd1NERTawB693sDew;

		private void MoveNext()
		{
			int num = XoKnmciii4G;
			bPQZS9HIHRR7iHYLorGJ bPQZS9HIHRR7iHYLorGJ2 = iP2nmE1hnbM;
			HUvclsHewvbEZGvt3TVD result2 = default(HUvclsHewvbEZGvt3TVD);
			try
			{
				if ((uint)num > 1u)
				{
					goto IL_005f;
				}
				goto IL_008a;
				IL_008a:
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 1:
					break;
				default:
					try
					{
						int num3;
						if (num != 0)
						{
							num3 = 9;
							goto IL_00dc;
						}
						ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = Swwnm69ic7p;
						int num4 = 11;
						goto IL_00e0;
						IL_00e0:
						TaskAwaiter<string> awaiter2 = default(TaskAwaiter<string>);
						while (true)
						{
							HttpResponseMessage result;
							string result3;
							switch (num4)
							{
							case 8:
								if (!awaiter2.IsCompleted)
								{
									num4 = 10;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
									{
										num4 = 9;
									}
									continue;
								}
								goto IL_0192;
							case 3:
								MKGnmMxP9qn = awaiter2;
								num4 = 6;
								continue;
							case 1:
								Swwnm69ic7p = awaiter;
								eWGnmjlJE6u.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								eWGnmjlJE6u.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 5:
								result2 = (HUvclsHewvbEZGvt3TVD)10000;
								num4 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
								{
									num4 = 2;
								}
								continue;
							case 11:
								Swwnm69ic7p = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
								num = (XoKnmciii4G = -1);
								goto IL_0152;
							case 10:
								num = (XoKnmciii4G = 1);
								num4 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
								{
									num4 = 3;
								}
								continue;
							case 9:
								if (num != 1)
								{
									num4 = 4;
									continue;
								}
								awaiter2 = MKGnmMxP9qn;
								MKGnmMxP9qn = default(TaskAwaiter<string>);
								num = (XoKnmciii4G = -1);
								goto IL_0192;
							case 4:
								awaiter = bPQZS9HIHRR7iHYLorGJ2.a7vHIGfxSgE(NVNnmRZHopR, new b2L9F92gx63f5rMQcH<string>(pXGnmQHE7ub)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								num4 = 7;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
								{
									num4 = 6;
								}
								continue;
							default:
								num = (XoKnmciii4G = 0);
								num4 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
								{
									num4 = 1;
								}
								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num4 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto IL_0152;
							case 2:
								goto end_IL_00e0;
								IL_0152:
								result = awaiter.GetResult();
								RqpnmdZ4Bj7 = result;
								awaiter2 = RqpnmdZ4Bj7.Content.ReadAsStringAsync().GetAwaiter();
								num3 = 8;
								break;
								IL_0192:
								result3 = awaiter2.GetResult();
								xQunmgyXtRw = result3;
								RqpnmdZ4Bj7.EnsureSuccessStatusCode();
								num4 = 5;
								continue;
							}
							goto IL_00dc;
							continue;
							end_IL_00e0:
							break;
						}
						goto end_IL_00c7;
						IL_00dc:
						num4 = num3;
						goto IL_00e0;
						end_IL_00c7:;
					}
					catch (HttpRequestException)
					{
						HUvclsHewvbEZGvt3TVD hUvclsHewvbEZGvt3TVD = default(HUvclsHewvbEZGvt3TVD);
						int num5;
						if (RqpnmdZ4Bj7 != null)
						{
							hUvclsHewvbEZGvt3TVD = bPQZS9HIHRR7iHYLorGJ2.yuiHIvXS402(RqpnmdZ4Bj7.StatusCode);
							if (hUvclsHewvbEZGvt3TVD != (HUvclsHewvbEZGvt3TVD)31900)
							{
								goto IL_037f;
							}
							num5 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
							{
								num5 = 0;
							}
						}
						else
						{
							GYZU24NEqDLR41B6uImZ(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x684F243E ^ 0x684BADB8) + xQunmgyXtRw);
							GYZU24NEqDLR41B6uImZ(odvd4KNEWpp23mfaXiiG(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-203064540 ^ -203296460), 31010));
							num5 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
							{
								num5 = 0;
							}
						}
						goto IL_0361;
						IL_0361:
						while (true)
						{
							switch (num5)
							{
							default:
								GYZU24NEqDLR41B6uImZ(KvXik4NEOthlQwxXFBb3(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44249525), bPQZS9HIHRR7iHYLorGJ2.A8QHIB7ZnuW, NVNnmRZHopR));
								num5 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
								{
									num5 = 0;
								}
								continue;
							case 4:
								goto end_IL_0361;
							case 1:
								LogManager.WriteError((string)YCmL1HNEIu5gLAmmfkux(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECEB6AE), xQunmgyXtRw));
								num5 = 2;
								continue;
							case 2:
								LogManager.WriteError((string)odvd4KNEWpp23mfaXiiG(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -339059994), (int)RqpnmdZ4Bj7.StatusCode) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -58061389) + RqpnmdZ4Bj7.ReasonPhrase);
								LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380822640), (int)hUvclsHewvbEZGvt3TVD));
								break;
							case 3:
								result2 = (HUvclsHewvbEZGvt3TVD)31010;
								goto end_IL_0361;
							}
							goto IL_037f;
							continue;
							end_IL_0361:
							break;
						}
						goto end_IL_0357;
						IL_037f:
						result2 = hUvclsHewvbEZGvt3TVD;
						num5 = 4;
						goto IL_0361;
						end_IL_0357:;
					}
					catch (Exception)
					{
						int num6 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						default:
							LogManager.WriteError((string)YCmL1HNEIu5gLAmmfkux(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529759841), xQunmgyXtRw));
							LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68DEE0F ^ 0x689641F), 31900));
							result2 = (HUvclsHewvbEZGvt3TVD)31900;
							break;
						}
					}
					goto end_IL_002c;
				}
				goto IL_005f;
				IL_005f:
				RqpnmdZ4Bj7 = null;
				xQunmgyXtRw = string.Empty;
				NVNnmRZHopR = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68DEE0F ^ 0x6897DAF);
				goto IL_008a;
				end_IL_002c:;
			}
			catch (Exception exception)
			{
				XoKnmciii4G = -2;
				RqpnmdZ4Bj7 = null;
				int num7 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num7 = 1;
				}
				while (true)
				{
					switch (num7)
					{
					default:
						return;
					case 1:
						xQunmgyXtRw = null;
						NVNnmRZHopR = null;
						eWGnmjlJE6u.SetException(exception);
						num7 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
						{
							num7 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
			while (true)
			{
				XoKnmciii4G = -2;
				int num8 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
				{
					num8 = 0;
				}
				while (true)
				{
					switch (num8)
					{
					default:
						RqpnmdZ4Bj7 = null;
						xQunmgyXtRw = null;
						NVNnmRZHopR = null;
						num8 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
						{
							num8 = 1;
						}
						continue;
					case 1:
						eWGnmjlJE6u.SetResult(result2);
						return;
					case 2:
						break;
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
			eWGnmjlJE6u.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static hJYWfenmXek5DcuDG3Fy()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static object KvXik4NEOthlQwxXFBb3(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static void GYZU24NEqDLR41B6uImZ(object P_0)
		{
			LogManager.WriteError((string)P_0);
		}

		internal static object YCmL1HNEIu5gLAmmfkux(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static object odvd4KNEWpp23mfaXiiG(object P_0, object P_1)
		{
			return string.Format((string)P_0, P_1);
		}

		internal static bool IPOqcsNE6MqPgb5YOfSV()
		{
			return HhZUd1NERTawB693sDew == null;
		}

		internal static object Xd2PsWNEMvvpYyFJyKQa()
		{
			return HhZUd1NERTawB693sDew;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct jTkaqlnmObI036YH2dU5 : IAsyncStateMachine
	{
		public int rGNnmqAdKKL;

		public AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD> oG6nmI443hI;

		public bPQZS9HIHRR7iHYLorGJ vbYnmWYp5ap;

		public string ouRnmtLoDUT;

		public string WkDnmUWDFjU;

		private HttpResponseMessage ednnmT3TnLd;

		private string W3Cnmy4N5q7;

		private string kxZnmZUI14K;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter iJ1nmVlQa66;

		private TaskAwaiter<string> QmXnmC6CRoc;

		private static object i8yGyfNEtWZ4KtDJ4KoW;

		private void MoveNext()
		{
			int num = rGNnmqAdKKL;
			bPQZS9HIHRR7iHYLorGJ bPQZS9HIHRR7iHYLorGJ2 = vbYnmWYp5ap;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
			{
				num2 = 0;
			}
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			TaskAwaiter<string> awaiter2 = default(TaskAwaiter<string>);
			HUvclsHewvbEZGvt3TVD result = default(HUvclsHewvbEZGvt3TVD);
			string locale = default(string);
			AppLanguage appLanguage = default(AppLanguage);
			ConfiguredTaskAwaitable<HttpResponseMessage> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<HttpResponseMessage>);
			HUvclsHewvbEZGvt3TVD hUvclsHewvbEZGvt3TVD = default(HUvclsHewvbEZGvt3TVD);
			while (true)
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					try
					{
						int num3;
						if ((uint)num <= 1u)
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
							{
								num3 = 0;
							}
						}
						else
						{
							ednnmT3TnLd = null;
							W3Cnmy4N5q7 = string.Empty;
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
							{
								num3 = 1;
							}
						}
						switch (num3)
						{
						case 1:
							kxZnmZUI14K = (string)L1ZAK9NEyq1chpEg1kQX(0x1AB79299 ^ 0x1AB306AF);
							break;
						}
						try
						{
							if (num == 0)
							{
								awaiter = iJ1nmVlQa66;
								iJ1nmVlQa66 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
								num = (rGNnmqAdKKL = -1);
								goto IL_047f;
							}
							int num4;
							if (num != 1)
							{
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
								{
									num4 = 0;
								}
								goto IL_0106;
							}
							goto IL_0344;
							IL_0106:
							while (true)
							{
								int num5;
								switch (num4)
								{
								case 3:
									if (!awaiter.IsCompleted)
									{
										goto case 8;
									}
									goto IL_047f;
								case 11:
								{
									string result2 = awaiter2.GetResult();
									W3Cnmy4N5q7 = result2;
									ednnmT3TnLd.EnsureSuccessStatusCode();
									result = (HUvclsHewvbEZGvt3TVD)10000;
									num4 = 14;
									continue;
								}
								case 1:
									if (xiWoyJNErM68P4COEC6R(((CultureInfo)YZsw6lNECjbTjrkV7Yl7(UctaU1NEVLnKmTyoowwZ())).Name, L1ZAK9NEyq1chpEg1kQX(0x7DB10E6E ^ 0x7DB1ED4E)))
									{
										locale = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380566880);
										num4 = 13;
										continue;
									}
									goto case 2;
								default:
									locale = (string)L1ZAK9NEyq1chpEg1kQX(-342738082 ^ -342762942);
									appLanguage = oUWUiPNEZAsLNeeKSylm(j18iDj9nukSCmEyZs5lH.Settings);
									if (appLanguage != AppLanguage.System)
									{
										if (appLanguage == AppLanguage.Russian)
										{
											locale = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047173969);
											num5 = 5;
											goto IL_0102;
										}
										num4 = 12;
										continue;
									}
									goto case 1;
								case 15:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									num4 = 3;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
									{
										num4 = 0;
									}
									continue;
								case 18:
									QmXnmC6CRoc = awaiter2;
									num4 = 10;
									continue;
								case 9:
									break;
								case 12:
									goto IL_0351;
								case 7:
									awaiter2 = ednnmT3TnLd.Content.ReadAsStringAsync().GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num = (rGNnmqAdKKL = 1);
										num4 = 18;
										continue;
									}
									goto case 11;
								case 4:
								case 5:
								case 6:
								case 13:
								case 17:
									configuredTaskAwaitable = bPQZS9HIHRR7iHYLorGJ2.a7vHIGfxSgE(kxZnmZUI14K, new K51UG7fTplX0hskQpe<string, string, string>(ouRnmtLoDUT, WkDnmUWDFjU, locale)).ConfigureAwait(continueOnCapturedContext: false);
									num5 = 15;
									goto IL_0102;
								case 10:
									oG6nmI443hI.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								case 16:
									num = (rGNnmqAdKKL = -1);
									num5 = 11;
									goto IL_0102;
								case 8:
									num = (rGNnmqAdKKL = 0);
									iJ1nmVlQa66 = awaiter;
									oG6nmI443hI.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 2:
									if (((CultureInfo)YZsw6lNECjbTjrkV7Yl7(Thread.CurrentThread)).Name.Contains((string)L1ZAK9NEyq1chpEg1kQX(-1306877528 ^ -1306597200)))
									{
										locale = (string)L1ZAK9NEyq1chpEg1kQX(-527080372 ^ -527356588);
										num5 = 6;
										goto IL_0102;
									}
									goto case 4;
								case 14:
									goto end_IL_00f6;
									IL_0102:
									num4 = num5;
									continue;
								}
								break;
								IL_0351:
								if (appLanguage == AppLanguage.Ukraine)
								{
									locale = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-377195341 ^ -377471573);
									num4 = 4;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
									{
										num4 = 4;
									}
								}
								else
								{
									num4 = 17;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
									{
										num4 = 4;
									}
								}
							}
							goto IL_0344;
							IL_047f:
							HttpResponseMessage result3 = awaiter.GetResult();
							ednnmT3TnLd = result3;
							num4 = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
							{
								num4 = 7;
							}
							goto IL_0106;
							IL_0344:
							awaiter2 = QmXnmC6CRoc;
							QmXnmC6CRoc = default(TaskAwaiter<string>);
							num4 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
							{
								num4 = 16;
							}
							goto IL_0106;
							end_IL_00f6:;
						}
						catch (HttpRequestException)
						{
							int num7;
							if (ednnmT3TnLd != null)
							{
								hUvclsHewvbEZGvt3TVD = bPQZS9HIHRR7iHYLorGJ2.SsbHIok3wTj(ednnmT3TnLd.StatusCode);
								if (hUvclsHewvbEZGvt3TVD != (HUvclsHewvbEZGvt3TVD)30900)
								{
									goto IL_05b2;
								}
								int num6 = 3;
								num7 = num6;
							}
							else
							{
								LogManager.WriteError((string)sKvXWsNEwwfB1UBFRZLP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -339066704), W3Cnmy4N5q7));
								IsHVn4NEmM9e5JDZ5QGQ(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325002845), 30010));
								result = (HUvclsHewvbEZGvt3TVD)30010;
								num7 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
								{
									num7 = 0;
								}
							}
							goto IL_054a;
							IL_054a:
							while (true)
							{
								switch (num7)
								{
								default:
									goto end_IL_054a;
								case 4:
									IsHVn4NEmM9e5JDZ5QGQ(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BA24CC) + W3Cnmy4N5q7);
									LogManager.WriteError(string.Format((string)L1ZAK9NEyq1chpEg1kQX(-2002318893 ^ -2002543211), (int)ednnmT3TnLd.StatusCode) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E00AF0C) + ednnmT3TnLd.ReasonPhrase);
									num7 = 2;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
									{
										num7 = 2;
									}
									continue;
								case 1:
									goto end_IL_054a;
								case 3:
									IsHVn4NEmM9e5JDZ5QGQ(CE12K9NEKlNyd9flByBe(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1309555870 ^ -1309323104), bPQZS9HIHRR7iHYLorGJ2.A8QHIB7ZnuW, kxZnmZUI14K));
									num7 = 4;
									continue;
								case 2:
									IsHVn4NEmM9e5JDZ5QGQ(udvbVPNEholBjmbpahFA(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -124002883), (int)hUvclsHewvbEZGvt3TVD));
									break;
								case 0:
									goto end_IL_054a;
								}
								goto IL_05b2;
								continue;
								end_IL_054a:
								break;
							}
							goto end_IL_0540;
							IL_05b2:
							result = hUvclsHewvbEZGvt3TVD;
							num7 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
							{
								num7 = 1;
							}
							goto IL_054a;
							end_IL_0540:;
						}
						catch (Exception)
						{
							LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44248049) + W3Cnmy4N5q7);
							int num8 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
							{
								num8 = 0;
							}
							switch (num8)
							{
							default:
								LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529759735), 30900));
								result = (HUvclsHewvbEZGvt3TVD)30900;
								break;
							}
						}
					}
					catch (Exception exception)
					{
						rGNnmqAdKKL = -2;
						ednnmT3TnLd = null;
						W3Cnmy4N5q7 = null;
						int num9 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								kxZnmZUI14K = null;
								oG6nmI443hI.SetException(exception);
								num9 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
								{
									num9 = 0;
								}
								break;
							}
						}
					}
					break;
				case 2:
					kxZnmZUI14K = null;
					oG6nmI443hI.SetResult(result);
					return;
				}
				rGNnmqAdKKL = -2;
				ednnmT3TnLd = null;
				W3Cnmy4N5q7 = null;
				num2 = 2;
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
			oG6nmI443hI.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static jTkaqlnmObI036YH2dU5()
		{
			zqY2DRNE7KTX10m21uK8();
		}

		internal static object L1ZAK9NEyq1chpEg1kQX(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static AppLanguage oUWUiPNEZAsLNeeKSylm(object P_0)
		{
			return ((MhMDPU9v8rkigy1ao0Th)P_0).Language;
		}

		internal static object UctaU1NEVLnKmTyoowwZ()
		{
			return Thread.CurrentThread;
		}

		internal static object YZsw6lNECjbTjrkV7Yl7(object P_0)
		{
			return ((Thread)P_0).CurrentUICulture;
		}

		internal static bool xiWoyJNErM68P4COEC6R(object P_0, object P_1)
		{
			return ((string)P_0).Contains((string)P_1);
		}

		internal static object CE12K9NEKlNyd9flByBe(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static void IsHVn4NEmM9e5JDZ5QGQ(object P_0)
		{
			LogManager.WriteError((string)P_0);
		}

		internal static object udvbVPNEholBjmbpahFA(object P_0, object P_1)
		{
			return string.Format((string)P_0, P_1);
		}

		internal static object sKvXWsNEwwfB1UBFRZLP(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static bool KIfc8DNEULieC4MHtXMp()
		{
			return i8yGyfNEtWZ4KtDJ4KoW == null;
		}

		internal static object gESSPDNETWXiGU2wnyPX()
		{
			return i8yGyfNEtWZ4KtDJ4KoW;
		}

		internal static void zqY2DRNE7KTX10m21uK8()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct djNdQWnmryLRYD2m289r : IAsyncStateMachine
	{
		public int dmPnmKOfMIt;

		public AsyncTaskMethodBuilder<HttpResponseMessage> vqjnmmiWEAB;

		public bPQZS9HIHRR7iHYLorGJ UxDnmhAPMG1;

		public object xVwnmwNoWw3;

		public string gubnm7j3nxi;

		private HttpClient nMJnm8RWybW;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter aw2nmAVRFL6;

		internal static object SuUKoLNE8TkYombP0PYu;

		private void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			HttpResponseMessage result = default(HttpResponseMessage);
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			StringContent content = default(StringContent);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = dmPnmKOfMIt;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					vqjnmmiWEAB.SetResult(result);
					return;
				}
				bPQZS9HIHRR7iHYLorGJ bPQZS9HIHRR7iHYLorGJ2 = UxDnmhAPMG1;
				try
				{
					if (num3 != 0)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						}
						nMJnm8RWybW = bPQZS9HIHRR7iHYLorGJ2.DPGHIYEh3CB();
					}
					try
					{
						int num5;
						if (num3 != 0)
						{
							num5 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
							{
								num5 = 3;
							}
						}
						else
						{
							awaiter = aw2nmAVRFL6;
							num5 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
							{
								num5 = 1;
							}
						}
						while (true)
						{
							switch (num5)
							{
							case 4:
								if (!awaiter.IsCompleted)
								{
									num3 = (dmPnmKOfMIt = 0);
									num5 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
									{
										num5 = 0;
									}
									break;
								}
								goto IL_00c7;
							default:
								aw2nmAVRFL6 = awaiter;
								vqjnmmiWEAB.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 2:
								aw2nmAVRFL6 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
								num3 = (dmPnmKOfMIt = -1);
								goto IL_00c7;
							case 1:
								awaiter = nMJnm8RWybW.PostAsync(gubnm7j3nxi, content).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								num5 = 4;
								break;
							case 3:
								{
									content = new StringContent((string)vMYIi3NEJmBXBFSqju42(xVwnmwNoWw3), (Encoding)P0EJp4NEFFVnCKrJ9Zkx(), (string)WvInqTNE36oOKuC1KVlQ(0x4220DA8 ^ 0x421EC8C));
									num5 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
									{
										num5 = 1;
									}
									break;
								}
								IL_00c7:
								result = awaiter.GetResult();
								goto end_IL_00a9;
							}
							continue;
							end_IL_00a9:
							break;
						}
					}
					catch (Exception e)
					{
						LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F60D504), nMJnm8RWybW.BaseAddress, gubnm7j3nxi), e);
						throw;
					}
					finally
					{
						if (num3 < 0)
						{
							while (true)
							{
								if (nMJnm8RWybW == null)
								{
									int num6 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 1:
										break;
									default:
										continue;
									}
								}
								else
								{
									Gw1XZXNEpki7DxG7lxDM(nMJnm8RWybW);
								}
								break;
							}
						}
					}
				}
				catch (Exception exception)
				{
					int num7 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					}
					dmPnmKOfMIt = -2;
					vqjnmmiWEAB.SetException(exception);
					return;
				}
				dmPnmKOfMIt = -2;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
				{
					num2 = 1;
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
			vqjnmmiWEAB.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static djNdQWnmryLRYD2m289r()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static object vMYIi3NEJmBXBFSqju42(object P_0)
		{
			return JsonConvert.SerializeObject(P_0);
		}

		internal static object P0EJp4NEFFVnCKrJ9Zkx()
		{
			return Encoding.UTF8;
		}

		internal static object WvInqTNE36oOKuC1KVlQ(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static void Gw1XZXNEpki7DxG7lxDM(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool QQjw0KNEALhTBMNdaB4Y()
		{
			return SuUKoLNE8TkYombP0PYu == null;
		}

		internal static object et3VHKNEPbUnIL5febCP()
		{
			return SuUKoLNE8TkYombP0PYu;
		}
	}

	private readonly string A8QHIB7ZnuW;

	internal static bPQZS9HIHRR7iHYLorGJ KNm4yvDMWKKm8HjGHq5C;

	[AsyncStateMachine(typeof(hJYWfenmXek5DcuDG3Fy))]
	public Task<HUvclsHewvbEZGvt3TVD> OChHI9dM37b(string P_0)
	{
		hJYWfenmXek5DcuDG3Fy stateMachine = default(hJYWfenmXek5DcuDG3Fy);
		stateMachine.eWGnmjlJE6u = AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD>.Create();
		stateMachine.iP2nmE1hnbM = this;
		stateMachine.pXGnmQHE7ub = P_0;
		stateMachine.XoKnmciii4G = -1;
		stateMachine.eWGnmjlJE6u.Start(ref stateMachine);
		return stateMachine.eWGnmjlJE6u.Task;
	}

	[AsyncStateMachine(typeof(jTkaqlnmObI036YH2dU5))]
	public Task<HUvclsHewvbEZGvt3TVD> ne0HInHZx5Z(string P_0, string P_1)
	{
		jTkaqlnmObI036YH2dU5 stateMachine = default(jTkaqlnmObI036YH2dU5);
		stateMachine.oG6nmI443hI = AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD>.Create();
		stateMachine.vbYnmWYp5ap = this;
		stateMachine.ouRnmtLoDUT = P_0;
		stateMachine.WkDnmUWDFjU = P_1;
		stateMachine.rGNnmqAdKKL = -1;
		stateMachine.oG6nmI443hI.Start(ref stateMachine);
		return stateMachine.oG6nmI443hI.Task;
	}

	[AsyncStateMachine(typeof(djNdQWnmryLRYD2m289r))]
	private Task<HttpResponseMessage> a7vHIGfxSgE(string P_0, object P_1)
	{
		djNdQWnmryLRYD2m289r stateMachine = default(djNdQWnmryLRYD2m289r);
		stateMachine.vqjnmmiWEAB = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.UxDnmhAPMG1 = this;
		stateMachine.gubnm7j3nxi = P_0;
		stateMachine.xVwnmwNoWw3 = P_1;
		stateMachine.dmPnmKOfMIt = -1;
		stateMachine.vqjnmmiWEAB.Start(ref stateMachine);
		return stateMachine.vqjnmmiWEAB.Task;
	}

	private HttpClient DPGHIYEh3CB()
	{
		HttpClient httpClient = new HttpClient();
		In5ETTDMTdelFAsqtyMs(httpClient, new Uri(new Uri(j18iDj9nukSCmEyZs5lH.Wed9vMLTjki), A8QHIB7ZnuW));
		return httpClient;
	}

	private HUvclsHewvbEZGvt3TVD SsbHIok3wTj(HttpStatusCode P_0)
	{
		int num;
		if (P_0 <= HttpStatusCode.BadRequest)
		{
			if ((uint)(P_0 - 200) <= 1u)
			{
				return (HUvclsHewvbEZGvt3TVD)10000;
			}
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_009a;
		IL_009a:
		if (P_0 > (HttpStatusCode)429)
		{
			num = 4;
		}
		else
		{
			if (P_0 == HttpStatusCode.Conflict)
			{
				goto IL_0066;
			}
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
			{
				num = 2;
			}
		}
		goto IL_0009;
		IL_00af:
		switch (P_0)
		{
		case HttpStatusCode.InternalServerError:
			return (HUvclsHewvbEZGvt3TVD)30500;
		case HttpStatusCode.ServiceUnavailable:
			return (HUvclsHewvbEZGvt3TVD)30503;
		}
		goto IL_0084;
		IL_0084:
		return (HUvclsHewvbEZGvt3TVD)30900;
		IL_0066:
		return (HUvclsHewvbEZGvt3TVD)30204;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
				if (P_0 == (HttpStatusCode)429)
				{
					return (HUvclsHewvbEZGvt3TVD)40020;
				}
				break;
			default:
				goto IL_009a;
			case 4:
				goto IL_00af;
			case 3:
				goto IL_00bf;
			}
			break;
			IL_00bf:
			switch (P_0)
			{
			case HttpStatusCode.NoContent:
				break;
			case HttpStatusCode.BadRequest:
				return (HUvclsHewvbEZGvt3TVD)40030;
			default:
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
				{
					num = 0;
				}
				continue;
			}
			goto IL_0066;
		}
		goto IL_0084;
	}

	private HUvclsHewvbEZGvt3TVD yuiHIvXS402(HttpStatusCode P_0)
	{
		int num;
		if (P_0 <= HttpStatusCode.Conflict)
		{
			if ((uint)(P_0 - 200) > 1u)
			{
				if (P_0 != HttpStatusCode.NotFound)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
					{
						num = 1;
					}
					goto IL_0009;
				}
				return (HUvclsHewvbEZGvt3TVD)40000;
			}
			return (HUvclsHewvbEZGvt3TVD)10000;
		}
		goto IL_00f7;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (P_0 != HttpStatusCode.Conflict)
				{
					goto default;
				}
				return (HUvclsHewvbEZGvt3TVD)40010;
			default:
				return (HUvclsHewvbEZGvt3TVD)31900;
			case 2:
				if (P_0 == HttpStatusCode.ServiceUnavailable)
				{
					return (HUvclsHewvbEZGvt3TVD)31503;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
				{
					num = 0;
				}
				continue;
			case 3:
				break;
			}
			break;
		}
		goto IL_00f7;
		IL_00f7:
		if (P_0 == (HttpStatusCode)429)
		{
			return (HUvclsHewvbEZGvt3TVD)40020;
		}
		if (P_0 == HttpStatusCode.InternalServerError)
		{
			return (HUvclsHewvbEZGvt3TVD)31500;
		}
		num = 2;
		goto IL_0009;
	}

	public bPQZS9HIHRR7iHYLorGJ()
	{
		L36HWgDMyeAvVKK6ERUx();
		A8QHIB7ZnuW = (string)TxapUSDMZu5weYyKJUtP(-1309555870 ^ -1309528712);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static bPQZS9HIHRR7iHYLorGJ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void In5ETTDMTdelFAsqtyMs(object P_0, object P_1)
	{
		((HttpClient)P_0).BaseAddress = (Uri)P_1;
	}

	internal static bool x1nVLXDMtwVHPx6YaBr9()
	{
		return KNm4yvDMWKKm8HjGHq5C == null;
	}

	internal static bPQZS9HIHRR7iHYLorGJ rZAbiHDMUfijPpRWJQeY()
	{
		return KNm4yvDMWKKm8HjGHq5C;
	}

	internal static void L36HWgDMyeAvVKK6ERUx()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object TxapUSDMZu5weYyKJUtP(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
