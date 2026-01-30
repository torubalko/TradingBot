using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace EYoI6xoFNTrwwRyTGjLT;

internal class rdC2D2oFbxrrBsTYLN7D : DelegatingHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct cOw8n9aw8Ojk1GOAu2hX : IAsyncStateMachine
	{
		public int k6tawAXkaCC;

		public AsyncTaskMethodBuilder<HttpResponseMessage> VIgawP8gOhx;

		public HttpRequestMessage Q4cawJC4k3A;

		public rdC2D2oFbxrrBsTYLN7D luMawFA2yJl;

		public CancellationToken g0aaw3DKQgW;

		private HttpResponseMessage NwEawpZOvja;

		private TaskAwaiter<string> mytawuGYXAV;

		private TaskAwaiter<HttpResponseMessage> WKlawz6F8ap;

		private static object M9sRJUL4L4FDhFcZp4IT;

		private void MoveNext()
		{
			int num = k6tawAXkaCC;
			rdC2D2oFbxrrBsTYLN7D rdC2D2oFbxrrBsTYLN7D2 = luMawFA2yJl;
			HttpResponseMessage result2;
			try
			{
				int num2;
				TaskAwaiter<string> awaiter2 = default(TaskAwaiter<string>);
				TaskAwaiter<HttpResponseMessage> awaiter = default(TaskAwaiter<HttpResponseMessage>);
				switch (num)
				{
				default:
					Console.WriteLine(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-123775059 ^ -123904035) + DateTime.Now.ToString((string)ANy7PpL4XNCRj3ExxdeE(0x24085900 ^ 0x240A5186)));
					num2 = 16;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
					{
						num2 = 17;
					}
					goto IL_0085;
				case 0:
					awaiter2 = mytawuGYXAV;
					num2 = 12;
					goto IL_0085;
				case 2:
					goto IL_03fc;
				case 1:
					{
						awaiter = WKlawz6F8ap;
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
						{
							num2 = 0;
						}
						goto IL_0085;
					}
					IL_01af:
					HaLww8L4cWKko1DUoBrG(awaiter2.GetResult());
					goto IL_04b6;
					IL_04b6:
					nAOhG5L4QQPFrfFjnnPh();
					num2 = 16;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de != 0)
					{
						num2 = 14;
					}
					goto IL_0085;
					IL_0085:
					while (true)
					{
						switch (num2)
						{
						case 9:
							VIgawP8gOhx.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 12:
							mytawuGYXAV = default(TaskAwaiter<string>);
							num = (k6tawAXkaCC = -1);
							num2 = 15;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
							{
								num2 = 9;
							}
							continue;
						case 13:
							if (Q4cawJC4k3A.Content != null)
							{
								num2 = 7;
								continue;
							}
							goto IL_025e;
						case 15:
							Console.WriteLine(awaiter2.GetResult());
							goto IL_025e;
						case 17:
							HaLww8L4cWKko1DUoBrG(Q4cawJC4k3A.ToString());
							num2 = 13;
							continue;
						case 3:
							break;
						case 8:
							goto end_IL_0085;
						case 11:
							if (!awaiter2.IsCompleted)
							{
								num2 = 2;
								continue;
							}
							goto case 15;
						case 4:
						{
							HttpResponseMessage result = awaiter.GetResult();
							NwEawpZOvja = result;
							num2 = 14;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b == 0)
							{
								num2 = 11;
							}
							continue;
						}
						case 14:
							Console.WriteLine((string)ANy7PpL4XNCRj3ExxdeE(-5977659 ^ -5848729) + DateTime.Now.ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1087080834 ^ -1086947592)));
							HaLww8L4cWKko1DUoBrG(NwEawpZOvja.ToString());
							num2 = 3;
							continue;
						case 10:
							VIgawP8gOhx.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
							WKlawz6F8ap = default(TaskAwaiter<HttpResponseMessage>);
							num = (k6tawAXkaCC = -1);
							num2 = 4;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
							{
								num2 = 3;
							}
							continue;
						case 16:
							result2 = NwEawpZOvja;
							goto end_IL_006b;
						case 2:
							num = (k6tawAXkaCC = 0);
							mytawuGYXAV = awaiter2;
							VIgawP8gOhx.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num2 = 3;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
							{
								num2 = 5;
							}
							continue;
						case 5:
							return;
						case 6:
							goto IL_03fc;
						case 7:
							awaiter2 = ((HttpContent)oginMKL4jcpZIZlGWGkv(Q4cawJC4k3A)).ReadAsStringAsync().GetAwaiter();
							num2 = 11;
							continue;
						case 1:
							{
								WKlawz6F8ap = awaiter;
								num2 = 9;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
								{
									num2 = 10;
								}
								continue;
							}
							IL_025e:
							Console.WriteLine();
							awaiter = ((DelegatingHandler)rdC2D2oFbxrrBsTYLN7D2).SendAsync(Q4cawJC4k3A, g0aaw3DKQgW).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (k6tawAXkaCC = 1);
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto case 4;
						}
						if (JNMC4cL4ElNmEXiswyia(NwEawpZOvja) != null)
						{
							awaiter2 = ((HttpContent)JNMC4cL4ElNmEXiswyia(NwEawpZOvja)).ReadAsStringAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (k6tawAXkaCC = 2);
								mytawuGYXAV = awaiter2;
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 != 0)
								{
									num2 = 9;
								}
								continue;
							}
							goto IL_01af;
						}
						goto IL_04b6;
						continue;
						end_IL_0085:
						break;
					}
					goto case 0;
					IL_03fc:
					awaiter2 = mytawuGYXAV;
					mytawuGYXAV = default(TaskAwaiter<string>);
					num = (k6tawAXkaCC = -1);
					goto IL_01af;
					end_IL_006b:
					break;
				}
			}
			catch (Exception exception)
			{
				k6tawAXkaCC = -2;
				NwEawpZOvja = null;
				VIgawP8gOhx.SetException(exception);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			k6tawAXkaCC = -2;
			int num4 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
			{
				num4 = 0;
			}
			while (true)
			{
				switch (num4)
				{
				case 1:
					VIgawP8gOhx.SetResult(result2);
					return;
				}
				NwEawpZOvja = null;
				num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
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
			VIgawP8gOhx.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static cOw8n9aw8Ojk1GOAu2hX()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object ANy7PpL4XNCRj3ExxdeE(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static void HaLww8L4cWKko1DUoBrG(object P_0)
		{
			Console.WriteLine((string)P_0);
		}

		internal static object oginMKL4jcpZIZlGWGkv(object P_0)
		{
			return ((HttpRequestMessage)P_0).Content;
		}

		internal static object JNMC4cL4ElNmEXiswyia(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		internal static void nAOhG5L4QQPFrfFjnnPh()
		{
			Console.WriteLine();
		}

		internal static bool w8RBgwL4ek5SdALoVdIG()
		{
			return M9sRJUL4L4FDhFcZp4IT == null;
		}

		internal static object oxSHsWL4sA79ypguZvIk()
		{
			return M9sRJUL4L4FDhFcZp4IT;
		}
	}

	private static rdC2D2oFbxrrBsTYLN7D Kqbnl0x0XdZoEJeZLhn5;

	public rdC2D2oFbxrrBsTYLN7D(HttpMessageHandler P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector(P_0);
	}

	[AsyncStateMachine(typeof(cOw8n9aw8Ojk1GOAu2hX))]
	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage P_0, CancellationToken P_1)
	{
		cOw8n9aw8Ojk1GOAu2hX stateMachine = default(cOw8n9aw8Ojk1GOAu2hX);
		stateMachine.VIgawP8gOhx = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.luMawFA2yJl = this;
		stateMachine.Q4cawJC4k3A = P_0;
		stateMachine.g0aaw3DKQgW = P_1;
		stateMachine.k6tawAXkaCC = -1;
		stateMachine.VIgawP8gOhx.Start(ref stateMachine);
		return stateMachine.VIgawP8gOhx.Task;
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private Task<HttpResponseMessage> zBHoFkSiXWE(HttpRequestMessage P_0, CancellationToken P_1)
	{
		return base.SendAsync(P_0, P_1);
	}

	static rdC2D2oFbxrrBsTYLN7D()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool TZ6apnx0c8sLO0KDXEot()
	{
		return Kqbnl0x0XdZoEJeZLhn5 == null;
	}

	internal static rdC2D2oFbxrrBsTYLN7D XRIBqwx0j01cCmcVEkqi()
	{
		return Kqbnl0x0XdZoEJeZLhn5;
	}
}
