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
using Eh8k3mYP4j0a5y12Wpnl;
using emk5iIY3YxqFqMN3yvns;
using EVGZtPaSqYL38OPuRcMs;
using iP0kayYJZG0Mb7BTEwGK;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using OksbiPYJ6BBtYQEOwkV3;
using QajSYgY39thNe2TVgarg;
using r8oOHiajFPNBXu6XiAHj;
using rUGmoXYPh3nafAtXvkq4;
using x97CE55GhEYKgt7TSVZT;
using YVGnU0YPL0SHPH3hZQxB;

namespace G5JveRYAFOw1IfYmxELg;

internal sealed class s8vvd0YAJmyoLRrTUYU0
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct ylqq8AaZhEsVep80tKpK : IAsyncStateMachine
	{
		public int WN9aZw2NTXn;

		public AsyncTaskMethodBuilder<string> POKaZ7upScv;

		public bool xYUaZ8yo1mZ;

		public s8vvd0YAJmyoLRrTUYU0 qwPaZAtptqi;

		public HttpRequestMessage aFeaZPjXabi;

		public string DQRaZJcUyEu;

		private string vS0aZF57fUr;

		private HttpResponseMessage QdnaZ3QSbC3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter D2UaZpXbq78;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter P7vaZuYgFi7;

		internal static object Peas8uLGIBy5BaeIKOfI;

		private void MoveNext()
		{
			int num = WN9aZw2NTXn;
			s8vvd0YAJmyoLRrTUYU0 s8vvd0YAJmyoLRrTUYU1 = qwPaZAtptqi;
			int num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
			{
				num2 = 1;
			}
			string result2 = default(string);
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			HttpResponseMessage result = default(HttpResponseMessage);
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
			while (true)
			{
				switch (num2)
				{
				default:
					POKaZ7upScv.SetResult(result2);
					return;
				case 1:
					try
					{
						if ((uint)num > 1u)
						{
							vS0aZF57fUr = "";
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
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
							if (num != 0)
							{
								num4 = 11;
							}
							else
							{
								awaiter = D2UaZpXbq78;
								num4 = 9;
							}
							while (true)
							{
								switch (num4)
								{
								case 9:
									D2UaZpXbq78 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
									num4 = 4;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
									{
										num4 = 8;
									}
									break;
								case 12:
									QdnaZ3QSbC3 = result;
									awaiter2 = ((HttpContent)mCAnaZLGUxs2RGl0h7OG(QdnaZ3QSbC3)).ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num = (WN9aZw2NTXn = 1);
										num4 = 2;
										break;
									}
									goto case 4;
								case 3:
									P7vaZuYgFi7 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
									num = (WN9aZw2NTXn = -1);
									num4 = 4;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
									{
										num4 = 1;
									}
									break;
								case 13:
									result = awaiter.GetResult();
									num4 = 12;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
									{
										num4 = 1;
									}
									break;
								default:
									POKaZ7upScv.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 5:
									awaiter2 = P7vaZuYgFi7;
									num4 = 3;
									break;
								case 10:
									awaiter = s8vvd0YAJmyoLRrTUYU1.HT0YPYdScga.SendAsync(aFeaZPjXabi).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = (WN9aZw2NTXn = 0);
										D2UaZpXbq78 = awaiter;
										num4 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
										{
											num4 = 0;
										}
										break;
									}
									goto case 13;
								case 8:
									num = (WN9aZw2NTXn = -1);
									num4 = 13;
									break;
								case 2:
									P7vaZuYgFi7 = awaiter2;
									POKaZ7upScv.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num4 = 7;
									break;
								case 4:
								{
									string result3 = awaiter2.GetResult();
									vS0aZF57fUr = result3;
									num4 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
									{
										num4 = 0;
									}
									break;
								}
								case 1:
									if (!QdnaZ3QSbC3.IsSuccessStatusCode)
									{
										num4 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
										{
											num4 = 6;
										}
										break;
									}
									result2 = vS0aZF57fUr;
									goto end_IL_008e;
								case 7:
									return;
								case 11:
									if (num == 1)
									{
										goto case 5;
									}
									if (xYUaZ8yo1mZ)
									{
										s8vvd0YAJmyoLRrTUYU1.x5qYPflaMXu(aFeaZPjXabi, DQRaZJcUyEu);
										num4 = 10;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
										{
											num4 = 0;
										}
										break;
									}
									goto case 10;
								case 6:
									throw new GcwnxWYPxWWXHT0xytet(JsonConvert.DeserializeObject<cgLUAPYPlYyjF6b0REvp>(vS0aZF57fUr));
								}
								continue;
								end_IL_008e:
								break;
							}
						}
						catch (JsonReaderException)
						{
							throw new GcwnxWYPxWWXHT0xytet(vS0aZF57fUr);
						}
						catch (Exception ex2)
						{
							throw new WebException((string)jKG491LGT9u4XXnXLgG9(ex2), ex2);
						}
					}
					catch (Exception exception)
					{
						int num5 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						}
						WN9aZw2NTXn = -2;
						vS0aZF57fUr = null;
						POKaZ7upScv.SetException(exception);
						return;
					}
					WN9aZw2NTXn = -2;
					vS0aZF57fUr = null;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 != 0)
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
			POKaZ7upScv.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static ylqq8AaZhEsVep80tKpK()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			kqsppTLGyfi5AT6MU7Xg();
		}

		internal static object mCAnaZLGUxs2RGl0h7OG(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		internal static object jKG491LGT9u4XXnXLgG9(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		internal static bool jNxpkkLGWXBJVZXEYjj8()
		{
			return Peas8uLGIBy5BaeIKOfI == null;
		}

		internal static object UuPJuXLGtwgnE28I3HP1()
		{
			return Peas8uLGIBy5BaeIKOfI;
		}

		internal static void kqsppTLGyfi5AT6MU7Xg()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private readonly HttpClient HT0YPYdScga;

	private readonly MHiHZ4YJRWg1X9TyK3Bf ynXYPo52oRn;

	private readonly U6nJD5YJyWwa5cv5aSZn m3MYPv7jxCv;

	private readonly OJ9SbAYPm1Y38Nv1Z9gL puqYPBocpE8;

	private readonly bool DOnYPad4M63;

	[CompilerGenerated]
	private TimeSpan OLJYPiLFkW8;

	private static s8vvd0YAJmyoLRrTUYU0 H4W1MVSM4R8iiGAsLebX;

	[SpecialName]
	[CompilerGenerated]
	public TimeSpan sKOYP92wUJc()
	{
		return OLJYPiLFkW8;
	}

	[SpecialName]
	[CompilerGenerated]
	public void oWBYPnmLAiE(TimeSpan P_0)
	{
		OLJYPiLFkW8 = P_0;
	}

	public s8vvd0YAJmyoLRrTUYU0(OJ9SbAYPm1Y38Nv1Z9gL P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		puqYPBocpE8 = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			ynXYPo52oRn = new MHiHZ4YJRWg1X9TyK3Bf();
			m3MYPv7jxCv = new U6nJD5YJyWwa5cv5aSZn(P_0.S2bYPuyhdBi());
			HT0YPYdScga = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN((string)wAORk9SMNqcTKisI2UnJ(P_0), P_1);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
			{
				num = 1;
			}
		}
	}

	public Task<string> wCuYA3WWung(string P_0, qfIQM5Y3f5f7a40N6GVA P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181293034) + text)));
		return xkLYPHW0dfF(httpRequestMessage);
	}

	public Task<string> CGRYApLatw3(string P_0, VLxcBDY3GgZLAvA4D9bX P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x60620FC1 ^ 0x606351C1) + text)));
		return xkLYPHW0dfF(httpRequestMessage, null, _0020: true);
	}

	public Task<string> j4UYAupAHg7(string P_0, qfIQM5Y3f5f7a40N6GVA P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1878953018 ^ -1879036474) + text)));
		return xkLYPHW0dfF(httpRequestMessage);
	}

	public Task<string> mHoYAzp90lj(string P_0, VLxcBDY3GgZLAvA4D9bX P_1)
	{
		string text = P_1?.vgoY3ni86Ux(P_1.XHKY3BFaFNi) ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0)
		{
			Content = new StringContent(text, Encoding.UTF8, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-44540535 ^ -44498033))
		};
		return xkLYPHW0dfF(httpRequestMessage, text, _0020: true);
	}

	public Task<string> xtjYP0hAOfV(string P_0, qfIQM5Y3f5f7a40N6GVA P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x315AB1E3 ^ 0x315BEFE3) + text)));
		return xkLYPHW0dfF(httpRequestMessage);
	}

	public Task<string> HTRYP2jp8BA(string P_0, VLxcBDY3GgZLAvA4D9bX P_1)
	{
		P_1.MlPl9kI3Tww();
		string text = "";
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F645F3C ^ 0x7F65013C) + text)));
		return xkLYPHW0dfF(httpRequestMessage);
	}

	public Task<string> Delete(string action, qfIQM5Y3f5f7a40N6GVA parameters)
	{
		string text = parameters?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-842040449 ^ -842128001) + text)));
		return xkLYPHW0dfF(httpRequestMessage);
	}

	public Task<string> Delete(string action, VLxcBDY3GgZLAvA4D9bX parameters)
	{
		string text = "";
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769D2731) + text)));
		return xkLYPHW0dfF(httpRequestMessage);
	}

	[AsyncStateMachine(typeof(ylqq8AaZhEsVep80tKpK))]
	private Task<string> xkLYPHW0dfF(HttpRequestMessage P_0, string P_1 = null, bool P_2 = false)
	{
		ylqq8AaZhEsVep80tKpK stateMachine = default(ylqq8AaZhEsVep80tKpK);
		stateMachine.POKaZ7upScv = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.qwPaZAtptqi = this;
		stateMachine.aFeaZPjXabi = P_0;
		stateMachine.DQRaZJcUyEu = P_1;
		stateMachine.xYUaZ8yo1mZ = P_2;
		stateMachine.WN9aZw2NTXn = -1;
		stateMachine.POKaZ7upScv.Start(ref stateMachine);
		return stateMachine.POKaZ7upScv.Task;
	}

	private void x5qYPflaMXu(HttpRequestMessage P_0, string P_1)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				text = ynXYPo52oRn.lldYJOakoQq(sKOYP92wUJc());
				num2 = 2;
				break;
			case 1:
				((HttpHeaders)qrls6GSMkF37bignVUxQ(P_0)).Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x130FEA25 ^ 0x130E80F5), m3MYPv7jxCv.rApYJV3AKlB((string)DvLUl5SMxlFbvaqbT0Ps(u6CA7TSM1EBMggFA2MGa(0x86EFEF6 ^ 0x86F9406), new object[4]
				{
					text,
					bi6cSySMScJx1imkyCLd(P_0),
					P_0.RequestUri,
					P_1
				})));
				if (puqYPBocpE8.P5HYJ9R6t7t())
				{
					P_0.Headers.Add((string)u6CA7TSM1EBMggFA2MGa(0x68DEE0F ^ 0x68C8503), (string)u6CA7TSM1EBMggFA2MGa(-57768881 ^ -57798179));
				}
				return;
			case 2:
				((HttpHeaders)qrls6GSMkF37bignVUxQ(P_0)).Add((string)u6CA7TSM1EBMggFA2MGa(0x37B74BDF ^ 0x37B62183), (string)rmpcAsSM5AnYRXqqkZ6O(puqYPBocpE8));
				((HttpHeaders)qrls6GSMkF37bignVUxQ(P_0)).Add((string)u6CA7TSM1EBMggFA2MGa(-839659358 ^ -839730472), puqYPBocpE8.D4XYJ2SNBPA());
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				((HttpHeaders)qrls6GSMkF37bignVUxQ(P_0)).Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x24085900 ^ 0x240933A6), text);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	static s8vvd0YAJmyoLRrTUYU0()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		nDR5KvSMLXbFWoyndfjQ();
	}

	internal static bool w14HNZSMDTsBEY04yhnO()
	{
		return H4W1MVSM4R8iiGAsLebX == null;
	}

	internal static s8vvd0YAJmyoLRrTUYU0 TmOcBfSMb6Mk0vEZrQ9d()
	{
		return H4W1MVSM4R8iiGAsLebX;
	}

	internal static object wAORk9SMNqcTKisI2UnJ(object P_0)
	{
		return ((OJ9SbAYPm1Y38Nv1Z9gL)P_0).bqUYPwtbyna();
	}

	internal static object qrls6GSMkF37bignVUxQ(object P_0)
	{
		return ((HttpRequestMessage)P_0).Headers;
	}

	internal static object u6CA7TSM1EBMggFA2MGa(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object rmpcAsSM5AnYRXqqkZ6O(object P_0)
	{
		return ((OJ9SbAYPm1Y38Nv1Z9gL)P_0).ti9YPFNXeJE();
	}

	internal static object bi6cSySMScJx1imkyCLd(object P_0)
	{
		return ((HttpRequestMessage)P_0).Method;
	}

	internal static object DvLUl5SMxlFbvaqbT0Ps(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void nDR5KvSMLXbFWoyndfjQ()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
