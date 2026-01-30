using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using E7vLlHvjBYhbrYmhcLDB;
using EVGZtPaSqYL38OPuRcMs;
using fhmYZ4vcqXHYJsvQ4EZc;
using ic1eR9vw7xhuiIRDrhk1;
using jJJ6B2vjncRxM5iRL8uQ;
using K1GcsD5GTtMSlaiJI0Xh;
using KZmYJrvcXKTIk7ovnCMh;
using MNRDcWvc8DTXqy1DEuMC;
using Newtonsoft.Json;
using r8oOHiajFPNBXu6XiAHj;
using wD2D07vwPIrV2JDl7658;
using x97CE55GhEYKgt7TSVZT;

namespace VDZWgevcavLngPGuJs7f;

internal sealed class Dj7ImtvcBhbY0gC3ioDs
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct F5PlnOaJiMK0vMw6MW13 : IAsyncStateMachine
	{
		public int P1EaJlmLpGH;

		public AsyncTaskMethodBuilder<string> kbIaJ4gp66w;

		public Dj7ImtvcBhbY0gC3ioDs gkKaJDIOb2p;

		public HttpRequestMessage IbXaJb3R5Tq;

		public string TPwaJNMqcLF;

		private HttpResponseMessage HGCaJkjM8l8;

		private TaskAwaiter<HttpResponseMessage> VxLaJ1p7IQD;

		private TaskAwaiter<string> OtuaJ52Yold;

		internal static object KcVp6eL1ZyQE0wN2YlZ8;

		private void MoveNext()
		{
			int num = 1;
			int num2 = num;
			string result = default(string);
			int num3 = default(int);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			TaskAwaiter<HttpResponseMessage> awaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			string result2 = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					kbIaJ4gp66w.SetResult(result);
					return;
				case 1:
					num3 = P1EaJlmLpGH;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				Dj7ImtvcBhbY0gC3ioDs dj7ImtvcBhbY0gC3ioDs = gkKaJDIOb2p;
				try
				{
					int num4;
					if (num3 != 0)
					{
						if (num3 != 1)
						{
							num4 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
							{
								num4 = 1;
							}
						}
						else
						{
							awaiter = OtuaJ52Yold;
							num4 = 6;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
							{
								num4 = 2;
							}
						}
						goto IL_0079;
					}
					goto IL_01b0;
					IL_01b0:
					awaiter2 = VxLaJ1p7IQD;
					VxLaJ1p7IQD = default(TaskAwaiter<HttpResponseMessage>);
					num3 = (P1EaJlmLpGH = -1);
					num4 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
					{
						num4 = 10;
					}
					goto IL_0079;
					IL_0079:
					while (true)
					{
						switch (num4)
						{
						default:
							num3 = (P1EaJlmLpGH = -1);
							goto case 7;
						case 5:
							result = result2;
							num4 = 3;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
							{
								num4 = 2;
							}
							continue;
						case 7:
							result2 = awaiter.GetResult();
							if (!rrk6ZBL1rO0BQuWJioe1(HGCaJkjM8l8))
							{
								goto case 1;
							}
							num4 = 4;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
							{
								num4 = 5;
							}
							continue;
						case 2:
							dj7ImtvcBhbY0gC3ioDs.yjbvcNi4QJP(IbXaJb3R5Tq, TPwaJNMqcLF);
							awaiter2 = dj7ImtvcBhbY0gC3ioDs.TCRvcSsWGjq.SendAsync(IbXaJb3R5Tq).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num4 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 != 0)
								{
									num4 = 8;
								}
								continue;
							}
							goto case 10;
						case 6:
							OtuaJ52Yold = default(TaskAwaiter<string>);
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
							{
								num4 = 0;
							}
							continue;
						case 8:
							num3 = (P1EaJlmLpGH = 0);
							VxLaJ1p7IQD = awaiter2;
							kbIaJ4gp66w.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num4 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
							{
								num4 = 4;
							}
							continue;
						case 9:
							break;
						case 3:
							goto end_IL_0079;
						case 10:
						{
							HttpResponseMessage result3 = awaiter2.GetResult();
							HGCaJkjM8l8 = result3;
							awaiter = HGCaJkjM8l8.Content.ReadAsStringAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = (P1EaJlmLpGH = 1);
								OtuaJ52Yold = awaiter;
								num4 = 11;
								continue;
							}
							num4 = 4;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
							{
								num4 = 7;
							}
							continue;
						}
						case 11:
							kbIaJ4gp66w.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 4:
							return;
						case 1:
							try
							{
								throw new YFSa9NvcO5eDJqW0fEjD(JsonConvert.DeserializeObject<iZrUYuvcsw6l54n39ZMw>(result2));
							}
							catch (JsonReaderException)
							{
								throw new YFSa9NvcO5eDJqW0fEjD(result2);
							}
						}
						goto IL_01b0;
						continue;
						end_IL_0079:
						break;
					}
				}
				catch (Exception exception)
				{
					P1EaJlmLpGH = -2;
					HGCaJkjM8l8 = null;
					int num5 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					}
					kbIaJ4gp66w.SetException(exception);
					return;
				}
				P1EaJlmLpGH = -2;
				HGCaJkjM8l8 = null;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 != 0)
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
			kbIaJ4gp66w.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static F5PlnOaJiMK0vMw6MW13()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool rrk6ZBL1rO0BQuWJioe1(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		internal static bool pHodMSL1VMn1tOOitLWa()
		{
			return KcVp6eL1ZyQE0wN2YlZ8 == null;
		}

		internal static object OHjOLOL1CtuoHccd7Svb()
		{
			return KcVp6eL1ZyQE0wN2YlZ8;
		}
	}

	private readonly HttpClient TCRvcSsWGjq;

	private readonly UO8CaPvj9ljjtHViAIZo pShvcxWkpQH;

	private readonly HRNxnGvjvasROXaUs9NU AljvcLJJTNH;

	[CompilerGenerated]
	private TimeSpan ddsvceejLuc;

	private static Dj7ImtvcBhbY0gC3ioDs e6eYDQx42LDPGea9B7Ha;

	[SpecialName]
	[CompilerGenerated]
	public TimeSpan rGYvckHF6IG()
	{
		return ddsvceejLuc;
	}

	[SpecialName]
	[CompilerGenerated]
	public void NGPvc1gLL4p(TimeSpan P_0)
	{
		ddsvceejLuc = P_0;
	}

	public Dj7ImtvcBhbY0gC3ioDs(LudoOrvc7POFV1dZPGZt P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				pShvcxWkpQH = new UO8CaPvj9ljjtHViAIZo();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
				{
					num = 0;
				}
				break;
			default:
				AljvcLJJTNH = new HRNxnGvjvasROXaUs9NU((string)ENPOwFx49FB6JusKJrCp(P_0));
				TCRvcSsWGjq = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN(P_0.DiyvcAEaJ7U(), P_1);
				((HttpHeaders)Ng63Flx4ndK7oi5NT3ES(TCRvcSsWGjq)).Add((string)dNBgE6x4GFwCwZDVAJRv(-2002318893 ^ -2002339389), P_0.ILUvcFWqfI0() ?? string.Empty);
				return;
			}
		}
	}

	public Task<string> Gc2vci2EgNQ(string P_0, zFlAHNvwA9yqWBn2mYyo P_1)
	{
		string text = P_1?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0 + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1522697859 ^ -1522784387) + text)));
		return GgSvcbu4xmx(httpRequestMessage);
	}

	public Task<string> Delete(string action, zFlAHNvwA9yqWBn2mYyo parameters)
	{
		string text = parameters?.MlPl9kI3Tww() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, action + (string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28C965BE ^ 0x28C83BBE) + text)));
		return GgSvcbu4xmx(httpRequestMessage);
	}

	public Task<string> QmDvcl02FYe(string P_0, XOPAoqvwwXZqjTXfpB4m P_1)
	{
		return B6KvcDjKKvR(HttpMethod.Post, P_0, P_1);
	}

	public Task<string> FYZvc4uuxF3(string P_0, XOPAoqvwwXZqjTXfpB4m P_1)
	{
		return B6KvcDjKKvR(HttpMethod.Put, P_0, P_1);
	}

	private Task<string> B6KvcDjKKvR(HttpMethod P_0, string P_1, XOPAoqvwwXZqjTXfpB4m P_2)
	{
		string text = P_2?.uZFvw8BEqAi() ?? string.Empty;
		HttpRequestMessage httpRequestMessage = new HttpRequestMessage(P_0, P_1)
		{
			Content = new StringContent(text, Encoding.UTF8, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2074141628 ^ -2074197438))
		};
		return GgSvcbu4xmx(httpRequestMessage, text);
	}

	[AsyncStateMachine(typeof(F5PlnOaJiMK0vMw6MW13))]
	private Task<string> GgSvcbu4xmx(HttpRequestMessage P_0, string P_1 = null)
	{
		F5PlnOaJiMK0vMw6MW13 stateMachine = default(F5PlnOaJiMK0vMw6MW13);
		stateMachine.kbIaJ4gp66w = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.gkKaJDIOb2p = this;
		stateMachine.IbXaJb3R5Tq = P_0;
		stateMachine.TPwaJNMqcLF = P_1;
		stateMachine.P1EaJlmLpGH = -1;
		stateMachine.kbIaJ4gp66w.Start(ref stateMachine);
		return stateMachine.kbIaJ4gp66w.Task;
	}

	private void yjbvcNi4QJP(HttpRequestMessage P_0, string P_1)
	{
		long num = pShvcxWkpQH.xWivjGtIFZp(rGYvckHF6IG());
		((HttpHeaders)xp1hKQx4Yq8132LWXZZt(P_0)).Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6AB40973 ^ 0x6AB5B951), num.ToString());
		w7oS4Rx4vNguwxrTdW1Y(P_0.Headers, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB14C856), AljvcLJJTNH.MBmvja0OGvQ(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-527080372 ^ -527167812), iWNYbPx4oLhJQcwJISru(P_0), P_0.RequestUri, num.ToString(), P_1)));
		int num2 = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		case 0:
			break;
		}
	}

	static Dj7ImtvcBhbY0gC3ioDs()
	{
		tg4e2px4B5aTOpgnnk3b();
		rZxbiTx4aTiFDpMfLsCU();
	}

	internal static bool kSvv5Ux4HuobTPqbCMgZ()
	{
		return e6eYDQx42LDPGea9B7Ha == null;
	}

	internal static Dj7ImtvcBhbY0gC3ioDs zXo3jSx4fKlaa6Kt2mO1()
	{
		return e6eYDQx42LDPGea9B7Ha;
	}

	internal static object ENPOwFx49FB6JusKJrCp(object P_0)
	{
		return ((LudoOrvc7POFV1dZPGZt)P_0).LievcufSoRx();
	}

	internal static object Ng63Flx4ndK7oi5NT3ES(object P_0)
	{
		return ((HttpClient)P_0).DefaultRequestHeaders;
	}

	internal static object dNBgE6x4GFwCwZDVAJRv(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object xp1hKQx4Yq8132LWXZZt(object P_0)
	{
		return ((HttpRequestMessage)P_0).Headers;
	}

	internal static object iWNYbPx4oLhJQcwJISru(object P_0)
	{
		return ((HttpRequestMessage)P_0).Method;
	}

	internal static void w7oS4Rx4vNguwxrTdW1Y(object P_0, object P_1, object P_2)
	{
		((HttpHeaders)P_0).Add((string)P_1, (string)P_2);
	}

	internal static void tg4e2px4B5aTOpgnnk3b()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void rZxbiTx4aTiFDpMfLsCU()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
