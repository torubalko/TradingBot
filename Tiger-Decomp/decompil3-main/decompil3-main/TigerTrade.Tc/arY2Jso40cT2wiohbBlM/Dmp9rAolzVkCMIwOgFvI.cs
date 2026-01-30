using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using EL16RUoD6PAwmf8Glusd;
using EVGZtPaSqYL38OPuRcMs;
using K1GcsD5GTtMSlaiJI0Xh;
using liZHxaoDVepZeuXUhCPG;
using Mdm2PJo4SvIAlHgawIWY;
using Newtonsoft.Json;
using nZTBuRo4jHVTUGuQ8Wo7;
using oJELx5obKBarWhrmAPYs;
using r8oOHiajFPNBXu6XiAHj;
using rs1vQ4o4mwxKoZCcV9ox;
using TigerTrade.Core.Utils.Logging;
using UfvpbNobC0OnyAVj3Bm5;
using x97CE55GhEYKgt7TSVZT;

namespace arY2Jso40cT2wiohbBlM;

internal class Dmp9rAolzVkCMIwOgFvI
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct FpvVuBaCkP3In7w1OaJy : IAsyncStateMachine
	{
		public int JQRaC1Y3UBt;

		public AsyncTaskMethodBuilder<string> vqBaC50qKKn;

		public Dmp9rAolzVkCMIwOgFvI M8oaCSxgsyb;

		public HttpRequestMessage TanaCxIiZ9G;

		private HttpResponseMessage fmqaCLZcJpu;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter jOjaCeJdmYS;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter uKCaCsGyurE;

		private static object RFofblLoSEK47OdaBZkZ;

		private void MoveNext()
		{
			int num = 2;
			int num2 = num;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			string result2 = default(string);
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
			int num3 = default(int);
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = JQRaC1Y3UBt;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
				{
					Dmp9rAolzVkCMIwOgFvI dmp9rAolzVkCMIwOgFvI = M8oaCSxgsyb;
					try
					{
						if (num3 == 0)
						{
							goto IL_00a6;
						}
						int num4;
						if (num3 != 1)
						{
							num4 = 6;
							goto IL_0068;
						}
						goto IL_0381;
						IL_031f:
						num4 = 7;
						goto IL_0068;
						IL_00a6:
						awaiter = jOjaCeJdmYS;
						num4 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
						{
							num4 = 4;
						}
						goto IL_0068;
						IL_0068:
						while (true)
						{
							HttpResponseMessage result3;
							switch (num4)
							{
							case 11:
								break;
							case 4:
								jOjaCeJdmYS = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
								num4 = 12;
								continue;
							case 5:
								return;
							case 10:
								goto IL_013d;
							default:
								jOjaCeJdmYS = awaiter;
								num4 = 3;
								continue;
							case 6:
								awaiter = dmp9rAolzVkCMIwOgFvI.XBbo44tgeoc.SendAsync(TanaCxIiZ9G).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num4 = 9;
									continue;
								}
								goto IL_03a1;
							case 9:
								num3 = (JQRaC1Y3UBt = 0);
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
								{
									num4 = 0;
								}
								continue;
							case 12:
								num3 = (JQRaC1Y3UBt = -1);
								goto IL_03a1;
							case 8:
								goto IL_031f;
							case 3:
								vqBaC50qKKn.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 5;
								continue;
							case 2:
								goto IL_0353;
							case 1:
								goto IL_0381;
							case 7:
								{
									try
									{
										throw new tOdMaho456qG7qryE7dc(TanaCxIiZ9G.RequestUri, JsonConvert.DeserializeObject<YFDdJ7o4c6AYZHQe4MtP>(result2));
									}
									catch (JsonReaderException)
									{
										throw new tOdMaho456qG7qryE7dc(TanaCxIiZ9G.RequestUri, result2);
									}
								}
								IL_03a1:
								result3 = awaiter.GetResult();
								fmqaCLZcJpu = result3;
								num4 = 8;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab != 0)
								{
									num4 = 10;
								}
								continue;
							}
							break;
							IL_013d:
							awaiter2 = fmqaCLZcJpu.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num3 = (JQRaC1Y3UBt = 1);
								uKCaCsGyurE = awaiter2;
								vqBaC50qKKn.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							num4 = 2;
						}
						goto IL_00a6;
						IL_0381:
						awaiter2 = uKCaCsGyurE;
						uKCaCsGyurE = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num3 = (JQRaC1Y3UBt = -1);
						goto IL_0353;
						IL_0353:
						result2 = awaiter2.GetResult();
						if (!KHinAjLoepaljLFKOxbE(fmqaCLZcJpu))
						{
							goto IL_031f;
						}
						try
						{
							if (CtXkx0Loc8dkVOmslvrj(((Uri)kcgRs7Los5YZSOHdonOy(TanaCxIiZ9G)).AbsolutePath, iIdl6XLoXLBhCKyOdhb2(-90307782 ^ -90177902)))
							{
								goto IL_01d3;
							}
							if (CtXkx0Loc8dkVOmslvrj(daSAbYLojeDK4QocRLdx(TanaCxIiZ9G.RequestUri), iIdl6XLoXLBhCKyOdhb2(-1774602229 ^ -1774697015)))
							{
								int num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								}
								goto IL_01d3;
							}
							goto end_IL_018c;
							IL_01d3:
							LogManager.WriteInfo(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1962651919 ^ -1962561435) + result2);
							end_IL_018c:;
						}
						catch (Exception)
						{
							XGQqKoLoEVwJrpcF3k0M();
						}
						result = result2;
					}
					catch (Exception exception)
					{
						int num6 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						}
						JQRaC1Y3UBt = -2;
						fmqaCLZcJpu = null;
						vqBaC50qKKn.SetException(exception);
						return;
					}
					JQRaC1Y3UBt = -2;
					fmqaCLZcJpu = null;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					vqBaC50qKKn.SetResult(result);
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
			vqBaC50qKKn.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static FpvVuBaCkP3In7w1OaJy()
		{
			jaBrRdLoQaSCtKoP7AiS();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool KHinAjLoepaljLFKOxbE(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		internal static object kcgRs7Los5YZSOHdonOy(object P_0)
		{
			return ((HttpRequestMessage)P_0).RequestUri;
		}

		internal static object iIdl6XLoXLBhCKyOdhb2(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool CtXkx0Loc8dkVOmslvrj(object P_0, object P_1)
		{
			return ((string)P_0).Contains((string)P_1);
		}

		internal static object daSAbYLojeDK4QocRLdx(object P_0)
		{
			return ((Uri)P_0).AbsolutePath;
		}

		internal static void XGQqKoLoEVwJrpcF3k0M()
		{
			LogManager.WriteFake();
		}

		internal static bool d0cjdILox4SqBvMUMQ4b()
		{
			return RFofblLoSEK47OdaBZkZ == null;
		}

		internal static object wBuVxVLoL16k8TPVrbuY()
		{
			return RFofblLoSEK47OdaBZkZ;
		}

		internal static void jaBrRdLoQaSCtKoP7AiS()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	private readonly HttpClient XBbo44tgeoc;

	private readonly CoZuTpoDZS35VMLJ4Px3 LO0o4D4bcCf;

	private readonly G3jHDZoDR2Jg9gtROQ43 xuco4biVoas;

	private readonly string KL8o4NdFuRO;

	[CompilerGenerated]
	private long FgCo4kTjbpE;

	[CompilerGenerated]
	private long evZo41UpEjn;

	private static Dmp9rAolzVkCMIwOgFvI UfShoTSyP1AA8yXvW0lx;

	public long Timestamp
	{
		[CompilerGenerated]
		get
		{
			return evZo41UpEjn;
		}
		[CompilerGenerated]
		set
		{
			evZo41UpEjn = num;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public long MjAo4vw74Fe()
	{
		return FgCo4kTjbpE;
	}

	[SpecialName]
	[CompilerGenerated]
	public void jxfo4BFTnCX(long P_0)
	{
		FgCo4kTjbpE = P_0;
	}

	public Dmp9rAolzVkCMIwOgFvI(lMpn5Mo4KWtWXQTn2nNm P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				xuco4biVoas = new G3jHDZoDR2Jg9gtROQ43();
				LO0o4D4bcCf = new CoZuTpoDZS35VMLJ4Px3(P_0.eBQo4JLfltS());
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
				{
					num = 0;
				}
				break;
			default:
				KL8o4NdFuRO = P_0.fEwo483eIot();
				XBbo44tgeoc = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN((string)UeJOiASy3pTuUGdvruJL(P_0), P_1);
				return;
			}
		}
	}

	public Task<string> DcGo42OmKTa(string P_0, cBEZh9obVbBXaOTIva7c P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x11D1040B ^ 0x11D05A0B) + text)));
		return R3To4Y4yYuM(httpRequestMessage);
	}

	public Task<string> VJMo4Hi4jwc(string P_0, Dof0wTobrbIaPIdg6qGM P_1)
	{
		P_1.Timestamp = G3jHDZoDR2Jg9gtROQ43.d3MoDMXJGWD(Timestamp);
		P_1.kqNob8wFao6 = xuco4biVoas.rRQoDOVa64o();
		string text = P_1.MlPl9kI3Tww() ?? string.Empty;
		text = ruvo4oYUhCm(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2D313048 ^ 0x2D306E48) + text)));
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-82860344 ^ -82912280), KL8o4NdFuRO);
		return R3To4Y4yYuM(httpRequestMessage);
	}

	public Task<string> PGDo4fx9mOD(string P_0, cBEZh9obVbBXaOTIva7c P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x446AB724 ^ 0x446BE924) + text)));
		return R3To4Y4yYuM(httpRequestMessage);
	}

	public Task<string> La0o49fYrx3(string P_0, Dof0wTobrbIaPIdg6qGM P_1)
	{
		P_1.Timestamp = G3jHDZoDR2Jg9gtROQ43.d3MoDMXJGWD(Timestamp);
		P_1.kqNob8wFao6 = xuco4biVoas.rRQoDOVa64o();
		string text = P_1.MlPl9kI3Tww();
		string text2 = ruvo4oYUhCm(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text2) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-338769610 ^ -338716874) + text2)));
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6D18F862 ^ 0x6D198542), KL8o4NdFuRO);
		return R3To4Y4yYuM(httpRequestMessage);
	}

	public Task<string> rSUo4nyg3wE(string P_0, cBEZh9obVbBXaOTIva7c P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28AE3CA) + text)));
		return R3To4Y4yYuM(httpRequestMessage);
	}

	public Task<string> K0Qo4GduZPw(string P_0, Dof0wTobrbIaPIdg6qGM P_1)
	{
		P_1.Timestamp = G3jHDZoDR2Jg9gtROQ43.d3MoDMXJGWD(Timestamp);
		P_1.kqNob8wFao6 = xuco4biVoas.rRQoDOVa64o();
		string text = P_1.MlPl9kI3Tww();
		string text2 = ruvo4oYUhCm(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text2) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7394D272 ^ 0x73958C72) + text2)));
		return R3To4Y4yYuM(httpRequestMessage);
	}

	public Task<string> Delete(string action, cBEZh9obVbBXaOTIva7c parameters)
	{
		string text = parameters?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1251569705 ^ -1251487273) + text)));
		return R3To4Y4yYuM(httpRequestMessage);
	}

	public Task<string> Delete(string action, Dof0wTobrbIaPIdg6qGM parameters)
	{
		parameters.Timestamp = G3jHDZoDR2Jg9gtROQ43.d3MoDMXJGWD(Timestamp);
		parameters.kqNob8wFao6 = xuco4biVoas.rRQoDOVa64o();
		string text = parameters.MlPl9kI3Tww() ?? string.Empty;
		text = ruvo4oYUhCm(text);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-44540535 ^ -44498039) + text)));
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7ADBF691 ^ 0x7ADA8BB1), KL8o4NdFuRO);
		return R3To4Y4yYuM(httpRequestMessage);
	}

	[AsyncStateMachine(typeof(FpvVuBaCkP3In7w1OaJy))]
	private Task<string> R3To4Y4yYuM(HttpRequestMessage P_0)
	{
		FpvVuBaCkP3In7w1OaJy stateMachine = default(FpvVuBaCkP3In7w1OaJy);
		stateMachine.vqBaC50qKKn = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.M8oaCSxgsyb = this;
		stateMachine.TanaCxIiZ9G = P_0;
		stateMachine.JQRaC1Y3UBt = -1;
		stateMachine.vqBaC50qKKn.Start(ref stateMachine);
		return stateMachine.vqBaC50qKKn.Task;
	}

	private string ruvo4oYUhCm(string P_0)
	{
		string text = (string)z5QXlMSyp7KmR6Ru1OwJ(LO0o4D4bcCf, P_0);
		if (string.IsNullOrEmpty(P_0))
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F19E03) + text;
		}
		return P_0 + (string)ktDrZSSyuThpRVen0cPf(0x22BF43FC ^ 0x22BE3EAA) + text;
	}

	static Dmp9rAolzVkCMIwOgFvI()
	{
		SJy6v6SyzlUR2JTaCLJT();
		kQON7hSZ0vMCjYoaYfkW();
	}

	internal static bool pKiGi6SyJkqDv5tLvy1h()
	{
		return UfShoTSyP1AA8yXvW0lx == null;
	}

	internal static Dmp9rAolzVkCMIwOgFvI NKIho5SyFPgqdjRMb7mA()
	{
		return UfShoTSyP1AA8yXvW0lx;
	}

	internal static object UeJOiASy3pTuUGdvruJL(object P_0)
	{
		return ((lMpn5Mo4KWtWXQTn2nNm)P_0).BvYo4hWFCmv();
	}

	internal static object z5QXlMSyp7KmR6Ru1OwJ(object P_0, object P_1)
	{
		return ((CoZuTpoDZS35VMLJ4Px3)P_0).AqYoDC6s80X((string)P_1);
	}

	internal static object ktDrZSSyuThpRVen0cPf(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void SJy6v6SyzlUR2JTaCLJT()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void kQON7hSZ0vMCjYoaYfkW()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
