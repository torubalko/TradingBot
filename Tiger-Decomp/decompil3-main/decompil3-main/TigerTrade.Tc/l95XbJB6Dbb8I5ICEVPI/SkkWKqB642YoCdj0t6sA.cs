using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using EVGZtPaSqYL38OPuRcMs;
using F0ON9QBMCSxmqMFcIkry;
using HZ8XBEB6ICb445r32D5G;
using K1GcsD5GTtMSlaiJI0Xh;
using k7dnUvBqTCAfi8Y8Tlb1;
using Kn220bBqOEUSDihnvK9V;
using KSdx09BMoCV6YKpu9HP1;
using mmNZg7ajAdJcNlRR59sJ;
using Newtonsoft.Json;
using PYGx2kBMFKFtMm0RBunX;
using r8oOHiajFPNBXu6XiAHj;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Tc.Properties;
using u6sIf5BW3540ExjCFQ1D;
using wvMMQwB6rv6s8IYtQRl2;
using x97CE55GhEYKgt7TSVZT;

namespace l95XbJB6Dbb8I5ICEVPI;

internal sealed class SkkWKqB642YoCdj0t6sA
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct rJ4y2Ji2A2ROBJVra4NO : IAsyncStateMachine
	{
		public int Hn5i2Ph4ihB;

		public AsyncTaskMethodBuilder xBvi2JdiIni;

		public SkkWKqB642YoCdj0t6sA kdPi2FeLVdY;

		public int zGGi23LqdvR;

		private TaskAwaiter wJXi2pHoQfC;

		internal static object gvQoyLLj82Bb5Hn8nHsW;

		private void MoveNext()
		{
			int num = Hn5i2Ph4ihB;
			SkkWKqB642YoCdj0t6sA skkWKqB642YoCdj0t6sA = kdPi2FeLVdY;
			try
			{
				int num3;
				if (num == 0)
				{
					int num2 = 5;
					num3 = num2;
					goto IL_0071;
				}
				goto IL_015c;
				IL_015c:
				if (skkWKqB642YoCdj0t6sA.ndMB6sQXR85() <= zGGi23LqdvR)
				{
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
					{
						num3 = 0;
					}
					goto IL_0071;
				}
				goto IL_00b2;
				IL_0071:
				TaskAwaiter awaiter = default(TaskAwaiter);
				while (true)
				{
					switch (num3)
					{
					case 4:
						goto IL_00b2;
					case 3:
						goto IL_00e3;
					case 1:
					case 5:
						awaiter = wJXi2pHoQfC;
						wJXi2pHoQfC = default(TaskAwaiter);
						num3 = 3;
						continue;
					case 2:
						goto IL_014b;
					case 0:
						break;
					}
					break;
				}
				goto end_IL_0058;
				IL_014b:
				if (!awaiter.IsCompleted)
				{
					num = (Hn5i2Ph4ihB = 0);
					wJXi2pHoQfC = awaiter;
					xBvi2JdiIni.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00a6;
				IL_00b2:
				awaiter = ((Task)XqQoVkLjJbh8N3IyFwQJ((60 - skkWKqB642YoCdj0t6sA.hhEB66sZVNQ.Second) * 1000 + 1000)).GetAwaiter();
				num3 = 2;
				goto IL_0071;
				IL_00e3:
				num = (Hn5i2Ph4ihB = -1);
				goto IL_00a6;
				IL_00a6:
				awaiter.GetResult();
				goto IL_015c;
				end_IL_0058:;
			}
			catch (Exception exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				}
				Hn5i2Ph4ihB = -2;
				xBvi2JdiIni.SetException(exception);
				return;
			}
			while (true)
			{
				Hn5i2Ph4ihB = -2;
				int num5 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				case 1:
					xBvi2JdiIni.SetResult();
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
			xBvi2JdiIni.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static rJ4y2Ji2A2ROBJVra4NO()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object XqQoVkLjJbh8N3IyFwQJ(int P_0)
		{
			return Task.Delay(P_0);
		}

		internal static bool prr2SpLjAvUxgvH8mmop()
		{
			return gvQoyLLj82Bb5Hn8nHsW == null;
		}

		internal static object IYlk5XLjPVKYQqWStJ8w()
		{
			return gvQoyLLj82Bb5Hn8nHsW;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct bOaekDi2uhC5mSMtOTHV : IAsyncStateMachine
	{
		public int OVwi2zg2hPB;

		public AsyncTaskMethodBuilder<string> y2HiH0xX2i1;

		public SkkWKqB642YoCdj0t6sA VJOiH2gxv75;

		public HttpRequestMessage KRliHHGOpN3;

		private HttpResponseMessage vbAiHfT5Pbs;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter EwCiH9dxcrx;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter DTpiHnrIJH4;

		private static object kodyNSLjF44fWRIVda80;

		private void MoveNext()
		{
			int num = 1;
			int num2 = num;
			SkkWKqB642YoCdj0t6sA skkWKqB642YoCdj0t6sA = default(SkkWKqB642YoCdj0t6sA);
			int num3 = default(int);
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
			string result = default(string);
			HttpResponseMessage result2 = default(HttpResponseMessage);
			ConfiguredTaskAwaitable<string> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<string>);
			while (true)
			{
				switch (num2)
				{
				default:
					skkWKqB642YoCdj0t6sA = VJOiH2gxv75;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
				{
					string result5;
					try
					{
						int num4;
						if (num3 == 0)
						{
							awaiter = EwCiH9dxcrx;
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
							{
								num4 = 0;
							}
						}
						else if (num3 == 1)
						{
							awaiter2 = DTpiHnrIJH4;
							num4 = 8;
						}
						else
						{
							awaiter = skkWKqB642YoCdj0t6sA.NOXB6Q7aXcH.SendAsync(KRliHHGOpN3).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
							{
								num4 = 7;
							}
						}
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 13:
								if (vbAiHfT5Pbs.StatusCode != (HttpStatusCode)429)
								{
									if (Ed2upTLE2xW7eggZ5nSX(vbAiHfT5Pbs) == (HttpStatusCode)418)
									{
										num4 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
										{
											num4 = 12;
										}
										break;
									}
									try
									{
										throw new xvtj4lB6CvdKfmyKtKdJ(KRliHHGOpN3.RequestUri, JsonConvert.DeserializeObject<tAH6k6B6qKUq3HLJ0Qva>(result));
									}
									catch (JsonReaderException)
									{
										throw new xvtj4lB6CvdKfmyKtKdJ((Uri)zVx9TRLjzX1v2Tp046wu(KRliHHGOpN3), result);
									}
								}
								goto case 12;
							case 3:
								result5 = result;
								goto end_IL_005b;
							case 8:
								DTpiHnrIJH4 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
								num3 = (OVwi2zg2hPB = -1);
								goto IL_00e2;
							case 1:
								result2 = awaiter.GetResult();
								num4 = 9;
								break;
							case 2:
								y2HiH0xX2i1.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 6:
								awaiter2 = configuredTaskAwaitable.GetAwaiter();
								num4 = 10;
								break;
							case 10:
								if (!awaiter2.IsCompleted)
								{
									num3 = (OVwi2zg2hPB = 1);
									DTpiHnrIJH4 = awaiter2;
									num4 = 5;
									break;
								}
								goto IL_00e2;
							default:
								EwCiH9dxcrx = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
								num3 = (OVwi2zg2hPB = -1);
								num4 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
								{
									num4 = 0;
								}
								break;
							case 4:
								try
								{
									HttpResponseHeaders headers = vbAiHfT5Pbs.Headers;
									int result3 = 0;
									DateTime result4 = default(DateTime);
									if (headers.TryGetValues(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769E64ED), out var values) && values.Any())
									{
										int.TryParse(values.FirstOrDefault(), out result3);
									}
									int num6;
									if (!headers.TryGetValues(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1999650146 ^ -1999749374), out var values2))
									{
										num6 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
										{
											num6 = 0;
										}
										goto IL_02c5;
									}
									goto IL_04b9;
									IL_0473:
									object kFrB6M0PJvH = skkWKqB642YoCdj0t6sA.kFrB6M0PJvH;
									bool lockTaken = false;
									try
									{
										Monitor.Enter(kFrB6M0PJvH, ref lockTaken);
										int num7;
										if (!(result4 > skkWKqB642YoCdj0t6sA.hhEB66sZVNQ))
										{
											num7 = 1;
											if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
											{
												num7 = 1;
											}
											goto IL_0336;
										}
										goto IL_035a;
										IL_0336:
										while (true)
										{
											switch (num7)
											{
											default:
												goto end_IL_0336;
											case 2:
												skkWKqB642YoCdj0t6sA.MZZB6XP0YmP(result3);
												goto end_IL_0336;
											case 1:
												if (!(result4 == skkWKqB642YoCdj0t6sA.hhEB66sZVNQ))
												{
													goto end_IL_0336;
												}
												if (result3 <= skkWKqB642YoCdj0t6sA.ndMB6sQXR85())
												{
													num7 = 0;
													if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
													{
														num7 = 0;
													}
													continue;
												}
												break;
											case 0:
												goto end_IL_0336;
											}
											goto IL_035a;
											continue;
											end_IL_0336:
											break;
										}
										goto end_IL_0324;
										IL_035a:
										skkWKqB642YoCdj0t6sA.hhEB66sZVNQ = result4;
										int num8 = 2;
										num7 = num8;
										goto IL_0336;
										end_IL_0324:;
									}
									finally
									{
										if (num3 < 0 && lockTaken)
										{
											int num9 = 0;
											if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
											{
												num9 = 0;
											}
											switch (num9)
											{
											default:
												Monitor.Exit(kFrB6M0PJvH);
												break;
											}
										}
									}
									if (KRliHHGOpN3.RequestUri.AbsolutePath.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-45476899 ^ -45355403)) || ((string)WgeOfhLE0F0xd99K2LJh(zVx9TRLjzX1v2Tp046wu(KRliHHGOpN3))).Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3544E813 ^ 0x354515D1)))
									{
										LogManager.WriteInfo(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2017337494 ^ -2017214110) + result);
										num6 = 3;
										goto IL_02c5;
									}
									goto end_IL_0237;
									IL_02c5:
									switch (num6)
									{
									case 2:
										goto IL_04b9;
									case 3:
										goto end_IL_0237;
									}
									goto IL_0473;
									IL_04b9:
									if (values2.Any())
									{
										DateTime.TryParse(values2.FirstOrDefault(), CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out result4);
										num6 = 1;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b != 0)
										{
											num6 = 1;
										}
										goto IL_02c5;
									}
									goto IL_0473;
									end_IL_0237:;
								}
								catch (Exception)
								{
									LogManager.WriteFake();
								}
								goto case 3;
							case 9:
								vbAiHfT5Pbs = result2;
								configuredTaskAwaitable = vbAiHfT5Pbs.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
								num4 = 6;
								break;
							case 5:
								y2HiH0xX2i1.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num3 = (OVwi2zg2hPB = 0);
									num5 = 11;
									goto IL_0057;
								}
								goto case 1;
							case 11:
								EwCiH9dxcrx = awaiter;
								num4 = 2;
								break;
							case 12:
								{
									Uri requestUri = KRliHHGOpN3.RequestUri;
									tAH6k6B6qKUq3HLJ0Qva obj = new tAH6k6B6qKUq3HLJ0Qva
									{
										Code = (int)vbAiHfT5Pbs.StatusCode
									};
									UoIkFpLEffaaxP6L19Zd(obj, fKXOVBLEH4tEAqwXGAWf());
									throw new xvtj4lB6CvdKfmyKtKdJ(requestUri, obj);
								}
								IL_0057:
								num4 = num5;
								break;
								IL_00e2:
								result = awaiter2.GetResult();
								if (!RenMi3LjuQ97rFeeUJnY(vbAiHfT5Pbs))
								{
									if (vbAiHfT5Pbs.StatusCode != HttpStatusCode.Forbidden)
									{
										num5 = 13;
										goto IL_0057;
									}
									goto case 12;
								}
								num4 = 4;
								break;
							}
							continue;
							end_IL_005b:
							break;
						}
					}
					catch (Exception exception)
					{
						OVwi2zg2hPB = -2;
						int num10 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						}
						vbAiHfT5Pbs = null;
						y2HiH0xX2i1.SetException(exception);
						return;
					}
					OVwi2zg2hPB = -2;
					vbAiHfT5Pbs = null;
					y2HiH0xX2i1.SetResult(result5);
					return;
				}
				case 1:
					num3 = OVwi2zg2hPB;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
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
			y2HiH0xX2i1.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bOaekDi2uhC5mSMtOTHV()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool RenMi3LjuQ97rFeeUJnY(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		internal static object zVx9TRLjzX1v2Tp046wu(object P_0)
		{
			return ((HttpRequestMessage)P_0).RequestUri;
		}

		internal static object WgeOfhLE0F0xd99K2LJh(object P_0)
		{
			return ((Uri)P_0).AbsolutePath;
		}

		internal static HttpStatusCode Ed2upTLE2xW7eggZ5nSX(object P_0)
		{
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		internal static object fKXOVBLEH4tEAqwXGAWf()
		{
			return Resources.BinanceApiErrorRequestLimitExceeded;
		}

		internal static void UoIkFpLEffaaxP6L19Zd(object P_0, object P_1)
		{
			((tAH6k6B6qKUq3HLJ0Qva)P_0).wTRB6yGFpnH = (string)P_1;
		}

		internal static bool OmqqMdLj3kNMPwuXfAtw()
		{
			return kodyNSLjF44fWRIVda80 == null;
		}

		internal static object jVxeliLjpS4tKINHRnEr()
		{
			return kodyNSLjF44fWRIVda80;
		}
	}

	private readonly HttpClient NOXB6Q7aXcH;

	private readonly ctXsiuBMVXK4EFbG1sQs yWsB6dYueGV;

	private readonly pqunSQBMJAkeA7ZcCPt9 aXpB6gNq1pp;

	[CompilerGenerated]
	private int jEnB6RDthWW;

	private DateTime hhEB66sZVNQ;

	private readonly object kFrB6M0PJvH;

	[CompilerGenerated]
	private long k6QB6OifMNV;

	private static SkkWKqB642YoCdj0t6sA MwZpjhxRS7mXmt3XtKZZ;

	public long Timestamp
	{
		[CompilerGenerated]
		get
		{
			return k6QB6OifMNV;
		}
		[CompilerGenerated]
		set
		{
			k6QB6OifMNV = num;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public int ndMB6sQXR85()
	{
		return jEnB6RDthWW;
	}

	[SpecialName]
	[CompilerGenerated]
	private void MZZB6XP0YmP(int P_0)
	{
		jEnB6RDthWW = P_0;
	}

	public SkkWKqB642YoCdj0t6sA(FEdaZIBMYBQiNHglCmuu P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		kFrB6M0PJvH = new object();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				NOXB6Q7aXcH = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN((string)N1aAHjxReiZNT3LWm8nB(P_0), P_1);
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				NOXB6Q7aXcH.DefaultRequestHeaders.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28C965BE ^ 0x28C8382C), (string)vUA5VCxRsR0ExoaTcmIR(P_0));
				return;
			case 1:
				yWsB6dYueGV = new ctXsiuBMVXK4EFbG1sQs();
				aXpB6gNq1pp = ((P_0.B8PBMkA49Pp() != null) ? new pqunSQBMJAkeA7ZcCPt9(P_0.B8PBMkA49Pp()) : new pqunSQBMJAkeA7ZcCPt9(P_0.acHBMDCZWyA()));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(rJ4y2Ji2A2ROBJVra4NO))]
	public Task q2dB6bAgtBu(int P_0)
	{
		int num = 1;
		int num2 = num;
		rJ4y2Ji2A2ROBJVra4NO stateMachine = default(rJ4y2Ji2A2ROBJVra4NO);
		while (true)
		{
			switch (num2)
			{
			case 2:
				stateMachine.xBvi2JdiIni.Start(ref stateMachine);
				return stateMachine.xBvi2JdiIni.Task;
			case 1:
				stateMachine.xBvi2JdiIni = AsyncTaskMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
				{
					num2 = 0;
				}
				continue;
			}
			stateMachine.kdPi2FeLVdY = this;
			stateMachine.zGGi23LqdvR = P_0;
			stateMachine.Hn5i2Ph4ihB = -1;
			num2 = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
			{
				num2 = 0;
			}
		}
	}

	public Task<string> Mu4B6NXXNWn(string P_0, skOVJTBqMb0H5lpWL7yZ P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225745875) + text)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	public Task<string> N2RB6k7NwSx(string P_0, t5eDSmBqUL1ghG8hBO4e P_1)
	{
		P_1.Timestamp = ctXsiuBMVXK4EFbG1sQs.pZoBMr76Z1o(Timestamp);
		P_1.xAmBqrqoejf = yWsB6dYueGV.RdnBMKaZs4I();
		string text = P_1.MlPl9kI3Tww() ?? string.Empty;
		text = Y7DB6e22DrZ(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841543591) + text)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	public Task<string> PwZB61b7J2f(string P_0, skOVJTBqMb0H5lpWL7yZ P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181293034) + text)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	public Task<string> CL3B655USUi(string P_0, t5eDSmBqUL1ghG8hBO4e P_1)
	{
		P_1.Timestamp = ctXsiuBMVXK4EFbG1sQs.pZoBMr76Z1o(Timestamp);
		P_1.xAmBqrqoejf = yWsB6dYueGV.RdnBMKaZs4I();
		string text = ((P_1 is HmIpVNBWFUEXYYJ7Hutd) ? P_1.yRHlvkHQHMS() : P_1.MlPl9kI3Tww()) ?? string.Empty;
		string text2 = Y7DB6e22DrZ(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text2) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894860500) + text2)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	public Task<string> aRaB6S0ablC(string P_0, skOVJTBqMb0H5lpWL7yZ P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894860500) + text)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	public Task<string> JyPB6xbbZJ3(string P_0, t5eDSmBqUL1ghG8hBO4e P_1)
	{
		P_1.Timestamp = ctXsiuBMVXK4EFbG1sQs.pZoBMr76Z1o(Timestamp);
		P_1.xAmBqrqoejf = yWsB6dYueGV.RdnBMKaZs4I();
		string text = P_1.MlPl9kI3Tww();
		string text2 = Y7DB6e22DrZ(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text2) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DFFAF1) + text2)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	public Task<string> Delete(string action, skOVJTBqMb0H5lpWL7yZ parameters)
	{
		string text = parameters?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-602153869 ^ -602242445) + text)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	public Task<string> Delete(string action, t5eDSmBqUL1ghG8hBO4e parameters)
	{
		parameters.Timestamp = ctXsiuBMVXK4EFbG1sQs.pZoBMr76Z1o(Timestamp);
		parameters.xAmBqrqoejf = yWsB6dYueGV.RdnBMKaZs4I();
		string text = parameters.MlPl9kI3Tww() ?? string.Empty;
		text = Y7DB6e22DrZ(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x746ED405 ^ 0x746F8A05) + text)));
		return muNB6LJPyrg(httpRequestMessage);
	}

	[AsyncStateMachine(typeof(bOaekDi2uhC5mSMtOTHV))]
	private Task<string> muNB6LJPyrg(HttpRequestMessage P_0)
	{
		bOaekDi2uhC5mSMtOTHV stateMachine = default(bOaekDi2uhC5mSMtOTHV);
		stateMachine.y2HiH0xX2i1 = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.VJOiH2gxv75 = this;
		stateMachine.KRliHHGOpN3 = P_0;
		stateMachine.OVwi2zg2hPB = -1;
		stateMachine.y2HiH0xX2i1.Start(ref stateMachine);
		return stateMachine.y2HiH0xX2i1.Task;
	}

	private string Y7DB6e22DrZ(string P_0)
	{
		string text = sxGw9Vaj8QRi9QIWqN4Z.FnrajPYqJCN(P_0);
		string text2 = aXpB6gNq1pp.Fe0BM3IvgBN(text);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			if (string.IsNullOrEmpty(text))
			{
				return (string)MMgdUWxRXrssxvWnq0Pj(-624753169 ^ -624789295) + text2;
			}
			return (string)mmIBoTxRcbrIjfNIBtTe(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F645F3C ^ 0x7F65226A), text2);
		}
	}

	static SkkWKqB642YoCdj0t6sA()
	{
		qPkGnuxRjSBEsWZgrHON();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool drmSXZxRxeGWMkDsMV2V()
	{
		return MwZpjhxRS7mXmt3XtKZZ == null;
	}

	internal static SkkWKqB642YoCdj0t6sA KeuFWOxRL5GSRBi51JS7()
	{
		return MwZpjhxRS7mXmt3XtKZZ;
	}

	internal static object N1aAHjxReiZNT3LWm8nB(object P_0)
	{
		return ((FEdaZIBMYBQiNHglCmuu)P_0).jtYBMvyCax5();
	}

	internal static object vUA5VCxRsR0ExoaTcmIR(object P_0)
	{
		return ((FEdaZIBMYBQiNHglCmuu)P_0).s8ABMinS00Q();
	}

	internal static object MMgdUWxRXrssxvWnq0Pj(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object mmIBoTxRcbrIjfNIBtTe(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void qPkGnuxRjSBEsWZgrHON()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
