using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using cMcoMXoITqk6fURwMs2s;
using EVGZtPaSqYL38OPuRcMs;
using hhGaL4oMXZSualHpaFrF;
using K1GcsD5GTtMSlaiJI0Xh;
using MV9kI3ogvE5Adbbb9197;
using mYtZY2oqffpBp5U7t5yQ;
using Newtonsoft.Json;
using O3KQAhoglx9FrL5ZEVFO;
using oGyGqpogMOXncjMlTUu0;
using PvgjGjoMj7pceZImqG15;
using r8oOHiajFPNBXu6XiAHj;
using shPyEpoMZDOvTW4WifH4;
using x97CE55GhEYKgt7TSVZT;
using xfKaQsoRhhYCfUCS1QLp;
using y0CjY6oqDkpq4ydC0OQE;
using yIuoPNoI6FuTAyfmDFxC;

namespace Hub4gmodmxOYjxPytvaO;

internal class l1wPPOodKiY8E5mXdZ4v
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct UlikRHaKA5EHDBZRTKYV : IAsyncStateMachine
	{
		public int a1XaKP9sGan;

		public AsyncTaskMethodBuilder<string> rchaKJxaqVA;

		public l1wPPOodKiY8E5mXdZ4v OrYaKFnPYW8;

		public HttpRequestMessage MS9aK3edaRd;

		private HttpResponseMessage MISaKpyYqcc;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter O7RaKu871oT;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter HgFaKzfOjxU;

		internal static object B4QhlVLaLAkwfclA3ogR;

		private void MoveNext()
		{
			int num = a1XaKP9sGan;
			l1wPPOodKiY8E5mXdZ4v l1wPPOodKiY8E5mXdZ4v2 = OrYaKFnPYW8;
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
			{
				num2 = 0;
			}
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			string result2 = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				string result;
				try
				{
					_ = 1;
					try
					{
						if (num == 0)
						{
							goto IL_0156;
						}
						int num3;
						if (num != 1)
						{
							num3 = 5;
							goto IL_0086;
						}
						goto IL_0211;
						IL_0211:
						awaiter = HgFaKzfOjxU;
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab != 0)
						{
							num3 = 0;
						}
						goto IL_0086;
						IL_0156:
						awaiter2 = O7RaKu871oT;
						O7RaKu871oT = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
						num3 = 2;
						goto IL_0086;
						IL_0086:
						while (true)
						{
							switch (num3)
							{
							default:
								HgFaKzfOjxU = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
								num3 = 10;
								continue;
							case 11:
								result = result2;
								goto end_IL_0076;
							case 6:
								num = (a1XaKP9sGan = 1);
								HgFaKzfOjxU = awaiter;
								rchaKJxaqVA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
								{
									num3 = 3;
								}
								continue;
							case 4:
								break;
							case 5:
								awaiter2 = l1wPPOodKiY8E5mXdZ4v2.PQyog9AhNCb.SendAsync(MS9aK3edaRd).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								num3 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								num = (a1XaKP9sGan = -1);
								num3 = 7;
								continue;
							case 8:
								goto IL_0211;
							case 10:
								goto IL_0233;
							case 3:
								return;
							case 1:
								goto IL_02ca;
							case 7:
							case 9:
								goto IL_02e0;
							}
							break;
							IL_02e0:
							HttpResponseMessage result3 = awaiter2.GetResult();
							MISaKpyYqcc = result3;
							awaiter = MISaKpyYqcc.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = 6;
								continue;
							}
							goto IL_00c0;
							IL_00c0:
							result2 = awaiter.GetResult();
							if (MISaKpyYqcc.IsSuccessStatusCode)
							{
								int num4 = 11;
								num3 = num4;
								continue;
							}
							throw new Bmo56hogootR9tPeAqQH(JsonConvert.DeserializeObject<T9mWR7ogiPyaiXpk2RbF>(result2));
							IL_02ca:
							if (!awaiter2.IsCompleted)
							{
								num = (a1XaKP9sGan = 0);
								O7RaKu871oT = awaiter2;
								rchaKJxaqVA.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							num3 = 9;
							continue;
							IL_0233:
							num = (a1XaKP9sGan = -1);
							goto IL_00c0;
						}
						goto IL_0156;
						end_IL_0076:;
					}
					catch (JsonReaderException)
					{
						throw new Bmo56hogootR9tPeAqQH(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x24B0B9E6 ^ 0x24B2B808));
					}
					catch (Exception ex2)
					{
						throw new WebException(ex2.Message, ex2);
					}
				}
				catch (Exception exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					}
					a1XaKP9sGan = -2;
					rchaKJxaqVA.SetException(exception);
					return;
				}
				a1XaKP9sGan = -2;
				rchaKJxaqVA.SetResult(result);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
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
			rchaKJxaqVA.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static UlikRHaKA5EHDBZRTKYV()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			QkNhs2LaXcexrRRI9YP8();
		}

		internal static bool BOPgbSLae5GXbevLbUuZ()
		{
			return B4QhlVLaLAkwfclA3ogR == null;
		}

		internal static object EkoiFmLasd9gQoH267Am()
		{
			return B4QhlVLaLAkwfclA3ogR;
		}

		internal static void QkNhs2LaXcexrRRI9YP8()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private readonly HttpClient PQyog9AhNCb;

	private readonly O5MnCRoRm9WqW7wDtTa4 vXEognrrLUF;

	[CompilerGenerated]
	private long eS7ogG6bG2f;

	[CompilerGenerated]
	private long Pj8ogYZ08Rv;

	private static l1wPPOodKiY8E5mXdZ4v EDA8YyS7urbjrmFuLdLs;

	public long Timestamp
	{
		[CompilerGenerated]
		get
		{
			return Pj8ogYZ08Rv;
		}
		[CompilerGenerated]
		set
		{
			Pj8ogYZ08Rv = pj8ogYZ08Rv;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public long Q4bodpLYnnJ()
	{
		return eS7ogG6bG2f;
	}

	[SpecialName]
	[CompilerGenerated]
	public void UldoduCui8E(long P_0)
	{
		eS7ogG6bG2f = P_0;
	}

	[SpecialName]
	public long ixHogHLC8vS()
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(Timestamp).ToUnixTimeSeconds();
	}

	public l1wPPOodKiY8E5mXdZ4v(lX9B90og62ZaRME1ThWe P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		rFZt4QS82lvGwNdP8qCr();
		base._002Ector();
		vXEognrrLUF = new O5MnCRoRm9WqW7wDtTa4(P_0.OE4ogWLDZ8J(), P_0.sbTogTmPem9());
		PQyog9AhNCb = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN((string)mokG7yS8HsijdRWEBkPO(P_0), P_1);
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				MDufHmS8nE33CnWdUdwe(uEAXjaS8fCLaJydlSeFc(PQyog9AhNCb), Ivuri7S89N4EoQ5muHUY(0x6F7F734B ^ 0x6F7EFCFD), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x404ED0BE ^ 0x404F5F62));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public Task<string> u3WodhRAKZy(string P_0, Tq0kGroMsYHJbDZKAVrV P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7DB10E6E ^ 0x7DB0506E) + text)));
		if (P_1 is bygsN2oMywOpEbv3FffX bygsN2oMywOpEbv3FffX)
		{
			httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + bygsN2oMywOpEbv3FffX.OTVoMr0twvg);
		}
		return RbWodJEsswi(httpRequestMessage);
	}

	public Task<string> gjRodwQZ4ag(string P_0, kmK95BoMc2hxSuavkfy0 P_1)
	{
		HttpRequestMessage httpRequestMessage = nIhodFu1Nnl(HttpMethod.Get, P_0, P_1);
		return RbWodJEsswi(httpRequestMessage);
	}

	public Task<string> U0wod76sPC2(string P_0, Tq0kGroMsYHJbDZKAVrV P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F55E538 ^ 0x7F54BB38) + text)));
		return RbWodJEsswi(httpRequestMessage);
	}

	public Task<string> FYQod8gxsKm(string P_0, kmK95BoMc2hxSuavkfy0 P_1)
	{
		HttpRequestMessage httpRequestMessage = nIhodFu1Nnl(HttpMethod.Post, P_0, P_1);
		return RbWodJEsswi(httpRequestMessage);
	}

	public Task<string> bnvodA75LXT(string P_0, Tq0kGroMsYHJbDZKAVrV P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-198991962 ^ -199048794) + text)));
		return RbWodJEsswi(httpRequestMessage);
	}

	public Task<string> rsfodP10xnj(string P_0, kmK95BoMc2hxSuavkfy0 P_1)
	{
		HttpRequestMessage httpRequestMessage = nIhodFu1Nnl(HttpMethod.Put, P_0, P_1);
		return RbWodJEsswi(httpRequestMessage);
	}

	public Task<string> Delete(string action, Tq0kGroMsYHJbDZKAVrV parameters)
	{
		string text = parameters?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225745875) + text)));
		return RbWodJEsswi(httpRequestMessage);
	}

	public Task<string> Delete(string action, kmK95BoMc2hxSuavkfy0 parameters)
	{
		HttpRequestMessage httpRequestMessage = nIhodFu1Nnl(HttpMethod.Delete, action, parameters);
		return RbWodJEsswi(httpRequestMessage);
	}

	[AsyncStateMachine(typeof(UlikRHaKA5EHDBZRTKYV))]
	private Task<string> RbWodJEsswi(HttpRequestMessage P_0)
	{
		UlikRHaKA5EHDBZRTKYV stateMachine = default(UlikRHaKA5EHDBZRTKYV);
		stateMachine.rchaKJxaqVA = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.OrYaKFnPYW8 = this;
		stateMachine.MS9aK3edaRd = P_0;
		stateMachine.a1XaKP9sGan = -1;
		stateMachine.rchaKJxaqVA.Start(ref stateMachine);
		return stateMachine.rchaKJxaqVA.Task;
	}

	private HttpRequestMessage nIhodFu1Nnl(HttpMethod P_0, string P_1, kmK95BoMc2hxSuavkfy0 P_2)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		int num = 17;
		HttpRequestMessage httpRequestMessage = default(HttpRequestMessage);
		long num2 = default(long);
		vqO7vboq4BMum9DaLiD5 vqO7vboq4BMum9DaLiD = default(vqO7vboq4BMum9DaLiD5);
		string text3 = default(string);
		F3ewTXoIUK0Z6nyUlqMR f3ewTXoIUK0Z6nyUlqMR = default(F3ewTXoIUK0Z6nyUlqMR);
		ei9tKSoqHJEnxoEPEuDG ei9tKSoqHJEnxoEPEuDG = default(ei9tKSoqHJEnxoEPEuDG);
		BiDplVoIRyfb4UTT8TkY biDplVoIRyfb4UTT8TkY = default(BiDplVoIRyfb4UTT8TkY);
		while (true)
		{
			object obj;
			HttpRequestMessage httpRequestMessage2;
			string text4;
			object obj2;
			switch (num)
			{
			case 1:
			case 2:
			case 6:
				httpRequestMessage = new HttpRequestMessage(P_0, P_1);
				if (O7OwZuS8aypbogDUxwvx(P_0, HttpMethod.Post) || P_0 == (HttpMethod)GnuSpKS8iH2Z2EgnxTba())
				{
					text = JsonConvert.SerializeObject((object)P_2);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
					{
						num = 7;
					}
					continue;
				}
				goto case 5;
			case 9:
				if (!(P_0 != HttpMethod.Put))
				{
					num = 2;
					continue;
				}
				if (P_2 == null)
				{
					num = 3;
					continue;
				}
				obj = P_2.MlPl9kI3Tww();
				goto IL_0480;
			case 5:
				num2 = ixHogHLC8vS();
				num = 11;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
				{
					num = 7;
				}
				continue;
			case 18:
				return httpRequestMessage;
			case 10:
				P_1 = (string)RSMdFoS8oLyxDcDWLodB(P_1, Sgk6qUS8BAYmCuaHBOUU(vqO7vboq4BMum9DaLiD));
				num = 6;
				continue;
			case 11:
				text3 = num2.ToString();
				MDufHmS8nE33CnWdUdwe(httpRequestMessage.Headers, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x684F243E ^ 0x684EB41E), vXEognrrLUF.dsFoR8A3eJv());
				httpRequestMessage.Headers.Add((string)Ivuri7S89N4EoQ5muHUY(-225822163 ^ -225727993), text3);
				if (!(P_2 is ei9tKSoqHJEnxoEPEuDG))
				{
					num = 4;
					continue;
				}
				goto case 12;
			case 12:
				text2 = P_2.MlPl9kI3Tww();
				num = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
				{
					num = 13;
				}
				continue;
			case 3:
				obj = null;
				goto IL_0480;
			case 15:
				P_1 = (string)RSMdFoS8oLyxDcDWLodB(P_1, f3ewTXoIUK0Z6nyUlqMR.OrderId);
				goto case 1;
			case 7:
				text2 = string.Empty;
				httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject((object)P_2), Encoding.UTF8, (string)Ivuri7S89N4EoQ5muHUY(-225822163 ^ -225745877));
				num = 5;
				continue;
			case 4:
			case 13:
				MDufHmS8nE33CnWdUdwe(httpRequestMessage.Headers, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--855742383 ^ 0x330007EF), vXEognrrLUF.CtRoR7DDvD0(httpRequestMessage.Method.ToString(), text, tQI9DGS8lMAhNd37VQ5M(httpRequestMessage).ToString(), text2, text3));
				httpRequestMessage2 = httpRequestMessage;
				text4 = P_1;
				obj2 = (FAY4SdS84dTNJYO9wwKY(text2) ? string.Empty : RSMdFoS8oLyxDcDWLodB(Ivuri7S89N4EoQ5muHUY(-90307782 ^ -90219206), text2));
				break;
			case 8:
				if (f3ewTXoIUK0Z6nyUlqMR == null)
				{
					ei9tKSoqHJEnxoEPEuDG = P_2 as ei9tKSoqHJEnxoEPEuDG;
					num = 16;
					continue;
				}
				goto case 15;
			case 19:
				P_1 = (string)BknQU6S8v5DRuBsmL7f8(P_1, ei9tKSoqHJEnxoEPEuDG.Symbol, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-617064403 ^ -616970201));
				goto case 1;
			case 17:
				biDplVoIRyfb4UTT8TkY = P_2 as BiDplVoIRyfb4UTT8TkY;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
				{
					num = 0;
				}
				continue;
			case 14:
				text2 = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2123795572 ^ -2123826074) + (string)WQysiIS8YEjLHYRr06tU(biDplVoIRyfb4UTT8TkY);
				goto IL_0365;
			default:
				if (biDplVoIRyfb4UTT8TkY == null)
				{
					f3ewTXoIUK0Z6nyUlqMR = P_2 as F3ewTXoIUK0Z6nyUlqMR;
					num = 8;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
					{
						num = 5;
					}
					continue;
				}
				if (YW0CwcS8GGyZakGIq9UE(biDplVoIRyfb4UTT8TkY.Symbol))
				{
					goto IL_0365;
				}
				goto case 14;
			case 16:
				{
					if (ei9tKSoqHJEnxoEPEuDG == null)
					{
						vqO7vboq4BMum9DaLiD = P_2 as vqO7vboq4BMum9DaLiD5;
						if (vqO7vboq4BMum9DaLiD == null)
						{
							if (!(P_0 != HttpMethod.Post))
							{
								num = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
								{
									num = 0;
								}
								continue;
							}
							goto case 9;
						}
						goto case 10;
					}
					goto case 19;
				}
				IL_0480:
				if (obj == null)
				{
					obj = string.Empty;
				}
				text2 = (string)obj;
				goto case 1;
				IL_0365:
				P_1 += biDplVoIRyfb4UTT8TkY.OrderId;
				goto case 1;
			}
			httpRequestMessage2.RequestUri = new Uri((string)RSMdFoS8oLyxDcDWLodB(text4, obj2), UriKind.RelativeOrAbsolute);
			num = 15;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
			{
				num = 18;
			}
		}
	}

	public string W5jod37XGaM(string P_0, string P_1, long P_2)
	{
		return vXEognrrLUF.VZ4oRwbKBsG(P_0, P_1, P_2);
	}

	static l1wPPOodKiY8E5mXdZ4v()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		nFUAqKS8Di7WhQFhCtex();
	}

	internal static bool egZ0aGS7zpnLyn8u8r1y()
	{
		return EDA8YyS7urbjrmFuLdLs == null;
	}

	internal static l1wPPOodKiY8E5mXdZ4v eVGf70S80AktXcOF9dwd()
	{
		return EDA8YyS7urbjrmFuLdLs;
	}

	internal static void rFZt4QS82lvGwNdP8qCr()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object mokG7yS8HsijdRWEBkPO(object P_0)
	{
		return ((lX9B90og62ZaRME1ThWe)P_0).HqEogOQj4aC();
	}

	internal static object uEAXjaS8fCLaJydlSeFc(object P_0)
	{
		return ((HttpClient)P_0).DefaultRequestHeaders;
	}

	internal static object Ivuri7S89N4EoQ5muHUY(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void MDufHmS8nE33CnWdUdwe(object P_0, object P_1, object P_2)
	{
		((HttpHeaders)P_0).Add((string)P_1, (string)P_2);
	}

	internal static bool YW0CwcS8GGyZakGIq9UE(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object WQysiIS8YEjLHYRr06tU(object P_0)
	{
		return ((BiDplVoIRyfb4UTT8TkY)P_0).Symbol;
	}

	internal static object RSMdFoS8oLyxDcDWLodB(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object BknQU6S8v5DRuBsmL7f8(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object Sgk6qUS8BAYmCuaHBOUU(object P_0)
	{
		return ((vqO7vboq4BMum9DaLiD5)P_0).Symbol;
	}

	internal static bool O7OwZuS8aypbogDUxwvx(object P_0, object P_1)
	{
		return (HttpMethod)P_0 == (HttpMethod)P_1;
	}

	internal static object GnuSpKS8iH2Z2EgnxTba()
	{
		return HttpMethod.Put;
	}

	internal static object tQI9DGS8lMAhNd37VQ5M(object P_0)
	{
		return ((HttpRequestMessage)P_0).RequestUri;
	}

	internal static bool FAY4SdS84dTNJYO9wwKY(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void nFUAqKS8Di7WhQFhCtex()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
