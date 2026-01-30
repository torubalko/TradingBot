using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using eLGYWsvoT3XKnYX66NiY;
using EVGZtPaSqYL38OPuRcMs;
using fRHBwhv2srPDEKUcRRhB;
using HVBijhv0cSr5UIgfskpl;
using K1GcsD5GTtMSlaiJI0Xh;
using Mb7gLGv2IdM2MvvJJaDx;
using Newtonsoft.Json;
using r8oOHiajFPNBXu6XiAHj;
using Vy7tsOv2oDSeLDcLNTkv;
using x8w0Iqv0Fss9QwlSrySK;
using x97CE55GhEYKgt7TSVZT;

namespace gXK3pTv0t6LVvHmUoLg7;

internal sealed class j04MOav0W2r5SdRX4HyJ
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct bJlWdaaAKK4R36YNDWTG : IAsyncStateMachine
	{
		public int rfraAmgpDN0;

		public AsyncTaskMethodBuilder<string> aLeaAhYmGUF;

		public j04MOav0W2r5SdRX4HyJ A5haAwCCNEj;

		public HttpRequestMessage VHTaA7f5OWZ;

		private string A0DaA8LBUgH;

		private HttpResponseMessage iTRaAAvo8K7;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter Bx9aAP9VEyp;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter NqHaAJWtSrV;

		internal static object HJkh39Lkv3KQcoWwFEKY;

		private void MoveNext()
		{
			int num = rfraAmgpDN0;
			j04MOav0W2r5SdRX4HyJ j04MOav0W2r5SdRX4HyJ2 = A5haAwCCNEj;
			string result2;
			try
			{
				if ((uint)num > 1u)
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					A0DaA8LBUgH = "";
				}
				try
				{
					int num3;
					ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
					if (num != 0)
					{
						num3 = 3;
					}
					else
					{
						awaiter = Bx9aAP9VEyp;
						num3 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
						{
							num3 = 6;
						}
					}
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					ConfiguredTaskAwaitable<HttpResponseMessage> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<HttpResponseMessage>);
					while (true)
					{
						HttpResponseMessage result;
						switch (num3)
						{
						case 5:
							aLeaAhYmGUF.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 6:
							Bx9aAP9VEyp = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
							num3 = 7;
							continue;
						case 4:
							aLeaAhYmGUF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 11:
							awaiter = configuredTaskAwaitable.GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (rfraAmgpDN0 = 0);
								Bx9aAP9VEyp = awaiter;
								num3 = 4;
								continue;
							}
							goto IL_01b7;
						case 1:
							NqHaAJWtSrV = awaiter2;
							num3 = 5;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
							{
								num3 = 4;
							}
							continue;
						case 8:
							NqHaAJWtSrV = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
							num3 = 9;
							continue;
						case 9:
							num = (rfraAmgpDN0 = -1);
							num3 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
						{
							string result3 = awaiter2.GetResult();
							A0DaA8LBUgH = result3;
							num3 = 8;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
							{
								num3 = 10;
							}
							continue;
						}
						case 10:
							if (!HAueqiLklakOygdQrb5N(iTRaAAvo8K7))
							{
								break;
							}
							result2 = A0DaA8LBUgH;
							goto end_IL_0088;
						case 7:
							num = (rfraAmgpDN0 = -1);
							goto IL_01b7;
						case 3:
							{
								if (num == 1)
								{
									awaiter2 = NqHaAJWtSrV;
									num3 = 8;
									continue;
								}
								configuredTaskAwaitable = j04MOav0W2r5SdRX4HyJ2.R2jv0h0pfUX.SendAsync(VHTaA7f5OWZ).ConfigureAwait(continueOnCapturedContext: false);
								num3 = 11;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							IL_01b7:
							result = awaiter.GetResult();
							iTRaAAvo8K7 = result;
							awaiter2 = ((HttpContent)QgYe9rLkiWtUweDKrfZ4(iTRaAAvo8K7)).ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (rfraAmgpDN0 = 1);
								num3 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 2;
						}
						throw new bWr0Y2v0JZh75rRMyyRq(JsonConvert.DeserializeObject<XDklwJv0XU4atNYMLCoh>(A0DaA8LBUgH));
						continue;
						end_IL_0088:
						break;
					}
				}
				catch (JsonReaderException)
				{
					throw new bWr0Y2v0JZh75rRMyyRq(A0DaA8LBUgH);
				}
				catch (Exception ex2)
				{
					throw new WebException(ex2.Message, ex2);
				}
			}
			catch (Exception exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				}
				rfraAmgpDN0 = -2;
				A0DaA8LBUgH = null;
				aLeaAhYmGUF.SetException(exception);
				return;
			}
			while (true)
			{
				rfraAmgpDN0 = -2;
				int num5 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				case 1:
					continue;
				}
				A0DaA8LBUgH = null;
				aLeaAhYmGUF.SetResult(result2);
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
			aLeaAhYmGUF.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bJlWdaaAKK4R36YNDWTG()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			Y41xpfLk4XB1XpkMg9ZK();
		}

		internal static object QgYe9rLkiWtUweDKrfZ4(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		internal static bool HAueqiLklakOygdQrb5N(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		internal static bool wv3OUfLkBhOM7ojADluL()
		{
			return HJkh39Lkv3KQcoWwFEKY == null;
		}

		internal static object jRJdvTLkaE0LkyV41Rgx()
		{
			return HJkh39Lkv3KQcoWwFEKY;
		}

		internal static void Y41xpfLk4XB1XpkMg9ZK()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private readonly HttpClient R2jv0h0pfUX;

	private readonly NwqcyDv2esYJkTUNx3Al VLpv0wxFUM6;

	private readonly XA1bLov2q9n0NrgrYJMu F6Rv072Q1Af;

	private readonly string JUMv08AEGhO;

	private readonly string rkOv0AwoeMR;

	[CompilerGenerated]
	private TimeSpan np2v0PHx5dN;

	internal static j04MOav0W2r5SdRX4HyJ M3yZ80xnwQ0ujwBoyy4S;

	[SpecialName]
	[CompilerGenerated]
	public TimeSpan o5Vv0rtxhLX()
	{
		return np2v0PHx5dN;
	}

	[SpecialName]
	[CompilerGenerated]
	public void Thuv0KxRiWQ(TimeSpan P_0)
	{
		np2v0PHx5dN = P_0;
	}

	public j04MOav0W2r5SdRX4HyJ(VL0ZTov2YgtElWJ0hYmB P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		q7OgsMxnAcTpclItkvOg();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				JUMv08AEGhO = P_0.t0Tv2ipbaER();
				rkOv0AwoeMR = (string)ljva8rxnPSHxn8ikZej4(P_0);
				VLpv0wxFUM6 = new NwqcyDv2esYJkTUNx3Al();
				F6Rv072Q1Af = new XA1bLov2q9n0NrgrYJMu();
				R2jv0h0pfUX = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN((string)YAqPgxxnJqpxPqBRTq78(P_0), P_1);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				R2jv0h0pfUX.DefaultRequestHeaders.Add((string)mQ8eN0xnFX3N2tXwKmwb(0x2D3134C9 ^ 0x2D3093C3), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-838841832 ^ -838734588));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Task<string> afUv0UFXKrH(string P_0, eKmq3YvoU7afiSLhE5Xm P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1D7BA1ED ^ 0x1D7AFFED) + text)));
		return yUnv0VWYNiv(httpRequestMessage);
	}

	public Task<string> mWbv0TRybOf(string P_0, string P_1)
	{
		string value = wk8v0CZhAmq(P_1);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(P_1) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6AB40973 ^ 0x6AB55773) + P_1)));
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x68DEE0F ^ 0x68C493B), JUMv08AEGhO);
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--737722733 ^ 0x2BF96639), VLpv0wxFUM6.mKiv2cblceT(o5Vv0rtxhLX()).ToString());
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2BD86B18 ^ 0x2BD9CC60), VLpv0wxFUM6.m9ov2jXC9Zl().ToString());
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1161619942 ^ -1161645638), value);
		return yUnv0VWYNiv(httpRequestMessage);
	}

	public Task<string> KiOv0yJWxtA(string P_0, eKmq3YvoU7afiSLhE5Xm P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x34407BB ^ 0x34559BB) + text)));
		return yUnv0VWYNiv(httpRequestMessage);
	}

	public Task<string> AHCv0Z9myNK(string P_0, string P_1)
	{
		string value = wk8v0CZhAmq(P_1);
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0);
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28C965BE ^ 0x28C8C28A), JUMv08AEGhO);
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-490987856 ^ -490882588), VLpv0wxFUM6.mKiv2cblceT(o5Vv0rtxhLX()).ToString());
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1251569705 ^ -1251530577), VLpv0wxFUM6.m9ov2jXC9Zl().ToString());
		httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-53782092 ^ -53805548), value);
		httpRequestMessage.Content = new StringContent(P_1, Encoding.UTF8, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2108526692 ^ -2108477030));
		return yUnv0VWYNiv(httpRequestMessage);
	}

	[AsyncStateMachine(typeof(bJlWdaaAKK4R36YNDWTG))]
	private Task<string> yUnv0VWYNiv(HttpRequestMessage P_0)
	{
		bJlWdaaAKK4R36YNDWTG stateMachine = default(bJlWdaaAKK4R36YNDWTG);
		stateMachine.aLeaAhYmGUF = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.A5haAwCCNEj = this;
		stateMachine.VHTaA7f5OWZ = P_0;
		stateMachine.rfraAmgpDN0 = -1;
		stateMachine.aLeaAhYmGUF.Start(ref stateMachine);
		return stateMachine.aLeaAhYmGUF.Task;
	}

	private string wk8v0CZhAmq(string P_0)
	{
		string text = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7ADBF691 ^ 0x7ADA9C61), ifTDgRxn3Wto2304pxpV(VLpv0wxFUM6, o5Vv0rtxhLX()), JUMv08AEGhO, VLpv0wxFUM6.m9ov2jXC9Zl(), P_0);
		return (string)R6tWgRxnpMVbgAM309Zc(F6Rv072Q1Af, rkOv0AwoeMR, text);
	}

	static j04MOav0W2r5SdRX4HyJ()
	{
		sDlwbsxnuWGl2MlM3SEq();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool cgxK8txn7hRQmL20H9ZJ()
	{
		return M3yZ80xnwQ0ujwBoyy4S == null;
	}

	internal static j04MOav0W2r5SdRX4HyJ W8udUxxn8GsdIaciZHkK()
	{
		return M3yZ80xnwQ0ujwBoyy4S;
	}

	internal static void q7OgsMxnAcTpclItkvOg()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object ljva8rxnPSHxn8ikZej4(object P_0)
	{
		return ((VL0ZTov2YgtElWJ0hYmB)P_0).n2sv2D9PKo1();
	}

	internal static object YAqPgxxnJqpxPqBRTq78(object P_0)
	{
		return ((VL0ZTov2YgtElWJ0hYmB)P_0).TcTv2vnbt1j();
	}

	internal static object mQ8eN0xnFX3N2tXwKmwb(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static long ifTDgRxn3Wto2304pxpV(object P_0, TimeSpan P_1)
	{
		return ((NwqcyDv2esYJkTUNx3Al)P_0).mKiv2cblceT(P_1);
	}

	internal static object R6tWgRxnpMVbgAM309Zc(object P_0, object P_1, object P_2)
	{
		return ((XA1bLov2q9n0NrgrYJMu)P_0).bahv2WAdaDI((string)P_1, (string)P_2);
	}

	internal static void sDlwbsxnuWGl2MlM3SEq()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
