using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using aBOZD3vJGWkYIHlZ3oju;
using BfZtb759KlUg4482QKym;
using dh9BxBvPVrQ9XMU2C7iR;
using EVGZtPaSqYL38OPuRcMs;
using FYPAyFv3UNgybtHs0afu;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using r8oOHiajFPNBXu6XiAHj;
using X1fHpgvPUWLBCVAauecd;
using x97CE55GhEYKgt7TSVZT;
using xbqD7jvJz3g7lKJnhZ8A;
using yvd07Fv3ymtUwGyCpNfP;

namespace NRFf8EvPkp2qS6iAkEm9;

internal class Va0l1avPNwmWMGqotemZ
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct n6thATa3HIKv0JYXx2bm : IAsyncStateMachine
	{
		public int YaVa3fRRCEl;

		public AsyncTaskMethodBuilder<string> Scka39JoJTF;

		public Va0l1avPNwmWMGqotemZ viUa3nhKMan;

		public HttpRequestMessage w20a3G2HP6n;

		private string vWAa3Yyddb9;

		private HttpResponseMessage WmPa3ovBNda;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter Ajha3vZLZZp;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter nywa3Bb4j5C;

		internal static object CfeZ0eLxPwOlcpOuLYq9;

		private void MoveNext()
		{
			int num = YaVa3fRRCEl;
			Va0l1avPNwmWMGqotemZ va0l1avPNwmWMGqotemZ = viUa3nhKMan;
			int num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
			{
				num2 = 1;
			}
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			ConfiguredTaskAwaitable<HttpResponseMessage> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<HttpResponseMessage>);
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
				{
					string result3;
					try
					{
						if ((uint)num > 1u)
						{
							vWAa3Yyddb9 = "";
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							}
						}
						try
						{
							int num4;
							if (num == 0)
							{
								awaiter = Ajha3vZLZZp;
								Ajha3vZLZZp = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
								num4 = 7;
							}
							else
							{
								if (num == 1)
								{
									goto IL_028f;
								}
								configuredTaskAwaitable = va0l1avPNwmWMGqotemZ.O6DvPOcGAnh.SendAsync(w20a3G2HP6n).ConfigureAwait(continueOnCapturedContext: false);
								num4 = 9;
							}
							goto IL_00e7;
							IL_00e7:
							while (true)
							{
								HttpResponseMessage result2;
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 12:
									return;
								case 9:
									awaiter = configuredTaskAwaitable.GetAwaiter();
									num4 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
									{
										num4 = 1;
									}
									continue;
								case 3:
									Scka39JoJTF.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num4 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 != 0)
									{
										num4 = 0;
									}
									continue;
								case 6:
								{
									Ajha3vZLZZp = awaiter;
									Scka39JoJTF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									int num5 = 12;
									num4 = num5;
									continue;
								}
								case 11:
								{
									string result = awaiter2.GetResult();
									vWAa3Yyddb9 = result;
									num4 = 4;
									continue;
								}
								case 4:
									if (HiQUISLxpv8cywWEdTg0(WmPa3ovBNda))
									{
										result3 = vWAa3Yyddb9;
										goto end_IL_00e7;
									}
									throw new nYukrQvPtRYU7R4FAKBr(JsonConvert.DeserializeObject<kPkcG1vPZ0Qq2PTVmkuG>(vWAa3Yyddb9));
								case 7:
									num = (YaVa3fRRCEl = -1);
									goto IL_0357;
								case 10:
									break;
								case 5:
									num = (YaVa3fRRCEl = 1);
									num4 = 2;
									continue;
								case 1:
									if (!awaiter.IsCompleted)
									{
										num = (YaVa3fRRCEl = 0);
										num4 = 6;
										continue;
									}
									goto IL_0357;
								case 2:
									nywa3Bb4j5C = awaiter2;
									num4 = 3;
									continue;
								case 8:
									{
										if (!awaiter2.IsCompleted)
										{
											num4 = 5;
											if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
											{
												num4 = 3;
											}
											continue;
										}
										goto case 11;
									}
									IL_0357:
									result2 = awaiter.GetResult();
									WmPa3ovBNda = result2;
									awaiter2 = ((HttpContent)diq2oZLx3LeNbxKb69vl(WmPa3ovBNda)).ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
									num4 = 8;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
									{
										num4 = 8;
									}
									continue;
								}
								goto IL_028f;
								continue;
								end_IL_00e7:
								break;
							}
							goto end_IL_00d7;
							IL_028f:
							awaiter2 = nywa3Bb4j5C;
							nywa3Bb4j5C = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							num = (YaVa3fRRCEl = -1);
							num4 = 11;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
							{
								num4 = 5;
							}
							goto IL_00e7;
							end_IL_00d7:;
						}
						catch (JsonReaderException)
						{
							throw new nYukrQvPtRYU7R4FAKBr(vWAa3Yyddb9);
						}
						catch (Exception ex2)
						{
							throw new WebException(ex2.Message, ex2);
						}
					}
					catch (Exception exception)
					{
						YaVa3fRRCEl = -2;
						int num6 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						}
						vWAa3Yyddb9 = null;
						Scka39JoJTF.SetException(exception);
						return;
					}
					YaVa3fRRCEl = -2;
					vWAa3Yyddb9 = null;
					Scka39JoJTF.SetResult(result3);
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
					{
						num2 = 0;
					}
					break;
				}
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
			Scka39JoJTF.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static n6thATa3HIKv0JYXx2bm()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object diq2oZLx3LeNbxKb69vl(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		internal static bool HiQUISLxpv8cywWEdTg0(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		internal static bool S3kltZLxJn6FBpqQVGvd()
		{
			return CfeZ0eLxPwOlcpOuLYq9 == null;
		}

		internal static object tMoyJ1LxFmOy7hZ5fXEN()
		{
			return CfeZ0eLxPwOlcpOuLYq9;
		}
	}

	private readonly HttpClient O6DvPOcGAnh;

	private readonly wnAXHuvJucRWfCkU17QJ VksvPqbqkeI;

	[CompilerGenerated]
	private long vsBvPIU3CG2;

	[CompilerGenerated]
	private long YRXvPWLFKBN;

	internal static Va0l1avPNwmWMGqotemZ Fp6D6Dx1LdhrMaGi2YU7;

	public long Timestamp
	{
		[CompilerGenerated]
		get
		{
			return YRXvPWLFKBN;
		}
		[CompilerGenerated]
		set
		{
			YRXvPWLFKBN = yRXvPWLFKBN;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public long XGvvPEBuQh2()
	{
		return vsBvPIU3CG2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void u7svPQul3Xh(long P_0)
	{
		vsBvPIU3CG2 = P_0;
	}

	[SpecialName]
	public long VAbvP60GIc7()
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(Timestamp).ToUnixTimeSeconds();
	}

	public Va0l1avPNwmWMGqotemZ(aWN1XVvJnZVvo1SBGOSE P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		VksvPqbqkeI = new wnAXHuvJucRWfCkU17QJ(P_0.aSUvJBNLg6R(), (string)v3eqhnx1Xh3W09wBFeBW(P_0), P_0.YH7vJbZgklk());
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				O6DvPOcGAnh = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN(P_0.YPJvJYPxt4v(), P_1);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num = 0;
				}
				break;
			default:
				O6DvPOcGAnh.DefaultRequestHeaders.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-842040449 ^ -842089157), (string)J1tKc5x1cl10Sc8s77GO(-1306877528 ^ -1306826812));
				return;
			}
		}
	}

	public Task<string> fHUvP10eBun(string P_0, Sviu2Xv3tHiLJQDHNU4L P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769D2731) + text)));
		return bXhvPsvhJNl(httpRequestMessage);
	}

	public Task<string> d8YvP5yoLLp(string P_0, LtOnkDv3TQ6fvypQLnWO P_1)
	{
		HttpRequestMessage httpRequestMessage = bHMvPXvoJdh(HttpMethod.Get, P_0, P_1);
		return bXhvPsvhJNl(httpRequestMessage);
	}

	public Task<string> AflvPSvYkIw(string P_0, Sviu2Xv3tHiLJQDHNU4L P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F1BD3D) + text)));
		return bXhvPsvhJNl(httpRequestMessage);
	}

	public Task<string> IREvPx2J6Eo(string P_0, LtOnkDv3TQ6fvypQLnWO P_1)
	{
		HttpRequestMessage httpRequestMessage = bHMvPXvoJdh(HttpMethod.Post, P_0, P_1);
		return bXhvPsvhJNl(httpRequestMessage);
	}

	public Task<string> uDDvPL5SRlu(string P_0, Sviu2Xv3tHiLJQDHNU4L P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-624753169 ^ -624796689) + text)));
		return bXhvPsvhJNl(httpRequestMessage);
	}

	public Task<string> n8vvPeqamSR(string P_0, LtOnkDv3TQ6fvypQLnWO P_1)
	{
		HttpRequestMessage httpRequestMessage = bHMvPXvoJdh(HttpMethod.Put, P_0, P_1);
		return bXhvPsvhJNl(httpRequestMessage);
	}

	public Task<string> Delete(string action, Sviu2Xv3tHiLJQDHNU4L parameters)
	{
		string text = parameters?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x706541F3 ^ 0x70641FF3) + text)));
		return bXhvPsvhJNl(httpRequestMessage);
	}

	public Task<string> Delete(string action, LtOnkDv3TQ6fvypQLnWO parameters)
	{
		HttpRequestMessage httpRequestMessage = bHMvPXvoJdh(HttpMethod.Delete, action, parameters);
		return bXhvPsvhJNl(httpRequestMessage);
	}

	[AsyncStateMachine(typeof(n6thATa3HIKv0JYXx2bm))]
	private Task<string> bXhvPsvhJNl(HttpRequestMessage P_0)
	{
		n6thATa3HIKv0JYXx2bm stateMachine = default(n6thATa3HIKv0JYXx2bm);
		stateMachine.Scka39JoJTF = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.viUa3nhKMan = this;
		stateMachine.w20a3G2HP6n = P_0;
		stateMachine.YaVa3fRRCEl = -1;
		stateMachine.Scka39JoJTF.Start(ref stateMachine);
		return stateMachine.Scka39JoJTF.Task;
	}

	private HttpRequestMessage bHMvPXvoJdh(HttpMethod P_0, string P_1, LtOnkDv3TQ6fvypQLnWO P_2)
	{
		int num = 5;
		HttpRequestMessage httpRequestMessage = default(HttpRequestMessage);
		string text4 = default(string);
		string text3 = default(string);
		string text5 = default(string);
		string text2 = default(string);
		long num3 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string value;
				string text;
				switch (num2)
				{
				default:
					if (!string.IsNullOrEmpty(VksvPqbqkeI.gKDvFoWD9DW()))
					{
						((HttpHeaders)Qsc2Gjx1dADqUZgHWhi0(httpRequestMessage)).Add((string)J1tKc5x1cl10Sc8s77GO(-448941864 ^ -449022446), (string)R5X1Z6x1gmMnD8QAHL3a(VksvPqbqkeI));
						num2 = 13;
						continue;
					}
					goto case 13;
				case 9:
					value = VksvPqbqkeI.Ag7vF24Q8OT(httpRequestMessage.Method.ToString(), text4, cWS1dEx1OOcJMeVDibop(httpRequestMessage).ToString(), text3, text5);
					goto IL_0223;
				case 5:
					text4 = string.Empty;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
					{
						num2 = 4;
					}
					continue;
				case 13:
					text2 = (new Uri(P_1, UriKind.RelativeOrAbsolute).IsAbsoluteUri ? new Uri(P_1).PathAndQuery : P_1);
					num2 = 12;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
					{
						num2 = 12;
					}
					continue;
				case 10:
					httpRequestMessage.Headers.Add((string)J1tKc5x1cl10Sc8s77GO(-673683647 ^ -673603097), text5);
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (P_0 == HttpMethod.Post || bQbIBtx1Q4uBlJmJLir2(P_0, HttpMethod.Put))
					{
						text4 = JsonConvert.SerializeObject((object)P_2);
						text3 = string.Empty;
						num2 = 3;
						continue;
					}
					goto IL_00d4;
				case 8:
					return httpRequestMessage;
				case 1:
					if (Uk18eux1ja3KdLATLle8(P_0, HttpMethod.Post))
					{
						num2 = 2;
						continue;
					}
					goto IL_0257;
				case 4:
					text3 = string.Empty;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					text3 = P_2?.MlPl9kI3Tww() ?? string.Empty;
					goto IL_0257;
				case 11:
					num3 = VAbvP60GIc7();
					text = num3.ToString();
					break;
				case 12:
					if (!WRS1t7x1RhNVR1thJiGE(P_1, J1tKc5x1cl10Sc8s77GO(0x5CD4F15 ^ 0x5CC896F)))
					{
						goto case 9;
					}
					value = (string)NsnCLNx1MGRKDOmyoKcG(VksvPqbqkeI, vVVBMOx16HOSAl8pwjVE(httpRequestMessage).ToString(), text2, text3, text4, text5);
					goto IL_0223;
				case 3:
					httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject((object)P_2), Encoding.UTF8, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-602153869 ^ -602242443));
					goto IL_00d4;
				case 2:
					if (Uk18eux1ja3KdLATLle8(P_0, BfOwZpx1EBy541mNuWfo()))
					{
						goto end_IL_0012;
					}
					goto IL_0257;
				case 14:
					{
						text = num3.ToString();
						break;
					}
					IL_00d4:
					if (!P_1.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-490987856 ^ -490874678)))
					{
						num2 = 11;
						continue;
					}
					num3 = Timestamp;
					num2 = 14;
					continue;
					IL_0223:
					httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x315AB1E3 ^ 0x315B7713), value);
					httpRequestMessage.RequestUri = new Uri(P_1 + (string.IsNullOrWhiteSpace(text3) ? string.Empty : ((string)J1tKc5x1cl10Sc8s77GO(0x1EFE0A28 ^ 0x1EFF5428) + text3)), UriKind.RelativeOrAbsolute);
					num2 = 8;
					continue;
					IL_0257:
					httpRequestMessage = new HttpRequestMessage(P_0, P_1);
					num2 = 7;
					continue;
				}
				text5 = text;
				httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x68C7EAE6 ^ 0x68C62C68), VksvPqbqkeI.bPOvF9Xdf2s());
				num2 = 10;
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public string GilvPc2MA2H(string P_0, string P_1, long P_2)
	{
		return VksvPqbqkeI.rhDvF08KbZX(P_0, P_1, P_2);
	}

	public string lpYvPjbC359(string P_0)
	{
		return (string)XjDk3jx1qZBcCMjreqJk(VksvPqbqkeI, P_0);
	}

	static Va0l1avPNwmWMGqotemZ()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool xZmLlJx1eXdB0cTQ2vEF()
	{
		return Fp6D6Dx1LdhrMaGi2YU7 == null;
	}

	internal static Va0l1avPNwmWMGqotemZ DR5KNax1s8oFRCAvkEAn()
	{
		return Fp6D6Dx1LdhrMaGi2YU7;
	}

	internal static object v3eqhnx1Xh3W09wBFeBW(object P_0)
	{
		return ((aWN1XVvJnZVvo1SBGOSE)P_0).FGtvJlppXc3();
	}

	internal static object J1tKc5x1cl10Sc8s77GO(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool Uk18eux1ja3KdLATLle8(object P_0, object P_1)
	{
		return (HttpMethod)P_0 != (HttpMethod)P_1;
	}

	internal static object BfOwZpx1EBy541mNuWfo()
	{
		return HttpMethod.Put;
	}

	internal static bool bQbIBtx1Q4uBlJmJLir2(object P_0, object P_1)
	{
		return (HttpMethod)P_0 == (HttpMethod)P_1;
	}

	internal static object Qsc2Gjx1dADqUZgHWhi0(object P_0)
	{
		return ((HttpRequestMessage)P_0).Headers;
	}

	internal static object R5X1Z6x1gmMnD8QAHL3a(object P_0)
	{
		return ((wnAXHuvJucRWfCkU17QJ)P_0).gKDvFoWD9DW();
	}

	internal static bool WRS1t7x1RhNVR1thJiGE(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object vVVBMOx16HOSAl8pwjVE(object P_0)
	{
		return ((HttpRequestMessage)P_0).Method;
	}

	internal static object NsnCLNx1MGRKDOmyoKcG(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		return ((wnAXHuvJucRWfCkU17QJ)P_0).isYvFfkffuV((string)P_1, (string)P_2, (string)P_3, (string)P_4, (string)P_5);
	}

	internal static object cWS1dEx1OOcJMeVDibop(object P_0)
	{
		return ((HttpRequestMessage)P_0).RequestUri;
	}

	internal static object XjDk3jx1qZBcCMjreqJk(object P_0, object P_1)
	{
		return ((wnAXHuvJucRWfCkU17QJ)P_0).D2CvFH9MSYM((string)P_1);
	}
}
