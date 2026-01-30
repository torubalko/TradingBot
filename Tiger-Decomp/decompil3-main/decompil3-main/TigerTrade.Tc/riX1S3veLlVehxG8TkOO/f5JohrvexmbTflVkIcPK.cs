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
using bkONXMveQTn9La3yJAqs;
using EVGZtPaSqYL38OPuRcMs;
using K1GcsD5GTtMSlaiJI0Xh;
using mgNGl9veZFMQf4T0YQNg;
using Newtonsoft.Json;
using q3N5jAveu8GgmbYJCie2;
using r8oOHiajFPNBXu6XiAHj;
using x97CE55GhEYKgt7TSVZT;

namespace riX1S3veLlVehxG8TkOO;

internal class f5JohrvexmbTflVkIcPK
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct wH0HTkaPS8ThsMvADa2g : IAsyncStateMachine
	{
		public int bJyaPx1UfAX;

		public AsyncTaskMethodBuilder<string> N0haPLjZVjp;

		public f5JohrvexmbTflVkIcPK F0MaPeSrLXG;

		public HttpRequestMessage fVAaPsiXtjY;

		private string KQRaPXrN7iP;

		private HttpResponseMessage hh0aPc3HpPP;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter dxRaPjlm2Ha;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter Y3laPE9T0mj;

		internal static object NGa6JbLkr29GFw9PfAtZ;

		private void MoveNext()
		{
			int num = 2;
			int num2 = num;
			f5JohrvexmbTflVkIcPK f5JohrvexmbTflVkIcPK2 = default(f5JohrvexmbTflVkIcPK);
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
			HttpResponseMessage result2 = default(HttpResponseMessage);
			ConfiguredTaskAwaitable<string> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<string>);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = bJyaPx1UfAX;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					f5JohrvexmbTflVkIcPK2 = F0MaPeSrLXG;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				string result3;
				try
				{
					if ((uint)num3 > 1u)
					{
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						}
						KQRaPXrN7iP = "";
					}
					try
					{
						int num5;
						if (num3 != 0)
						{
							if (num3 == 1)
							{
								awaiter = Y3laPE9T0mj;
								Y3laPE9T0mj = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
								num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
								{
									num5 = 1;
								}
							}
							else
							{
								awaiter2 = f5JohrvexmbTflVkIcPK2.aCcvejjal2Z.SendAsync(fVAaPsiXtjY).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								num5 = 7;
							}
							goto IL_00b3;
						}
						goto IL_017d;
						IL_017d:
						awaiter2 = dxRaPjlm2Ha;
						dxRaPjlm2Ha = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
						num3 = (bJyaPx1UfAX = -1);
						num5 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e != 0)
						{
							num5 = 1;
						}
						goto IL_00b3;
						IL_00b3:
						while (true)
						{
							string result;
							switch (num5)
							{
							default:
								return;
							case 3:
							{
								result2 = awaiter2.GetResult();
								int num6 = 4;
								num5 = num6;
								continue;
							}
							case 1:
								num3 = (bJyaPx1UfAX = -1);
								goto IL_0302;
							case 9:
								result3 = KQRaPXrN7iP;
								goto end_IL_00b3;
							case 5:
								break;
							case 7:
								if (!awaiter2.IsCompleted)
								{
									num5 = 11;
									continue;
								}
								goto case 3;
							case 4:
								hh0aPc3HpPP = result2;
								configuredTaskAwaitable = hh0aPc3HpPP.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
								num5 = 8;
								continue;
							case 12:
								if (!awaiter.IsCompleted)
								{
									num5 = 2;
									continue;
								}
								goto IL_0302;
							case 11:
								num3 = (bJyaPx1UfAX = 0);
								dxRaPjlm2Ha = awaiter2;
								N0haPLjZVjp.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 0:
								return;
							case 2:
								num3 = (bJyaPx1UfAX = 1);
								Y3laPE9T0mj = awaiter;
								N0haPLjZVjp.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
								{
									num5 = 0;
								}
								continue;
							case 8:
								awaiter = configuredTaskAwaitable.GetAwaiter();
								num5 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
								{
									num5 = 12;
								}
								continue;
							case 6:
							case 10:
								{
									throw new rL5BGGveyL9MwqOnpyw9(JsonConvert.DeserializeObject<RY9raZveEQrMDKgnKFJp>(KQRaPXrN7iP));
								}
								IL_0302:
								result = awaiter.GetResult();
								KQRaPXrN7iP = result;
								if (!KW0DrJLkhLBbZ9WoAaoI(hh0aPc3HpPP))
								{
									num5 = 10;
									continue;
								}
								goto case 9;
							}
							goto IL_017d;
							continue;
							end_IL_00b3:
							break;
						}
					}
					catch (JsonReaderException)
					{
						throw new rL5BGGveyL9MwqOnpyw9(KQRaPXrN7iP);
					}
					catch (Exception ex2)
					{
						throw new WebException(ex2.Message, ex2);
					}
				}
				catch (Exception exception)
				{
					bJyaPx1UfAX = -2;
					KQRaPXrN7iP = null;
					int num7 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					}
					N0haPLjZVjp.SetException(exception);
					return;
				}
				bJyaPx1UfAX = -2;
				KQRaPXrN7iP = null;
				N0haPLjZVjp.SetResult(result3);
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
			N0haPLjZVjp.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static wH0HTkaPS8ThsMvADa2g()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool KW0DrJLkhLBbZ9WoAaoI(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		internal static bool YiA049LkKZIPhlOBK3kN()
		{
			return NGa6JbLkr29GFw9PfAtZ == null;
		}

		internal static object qrJYbALkmaWMkOYvc6mn()
		{
			return NGa6JbLkr29GFw9PfAtZ;
		}
	}

	private readonly HttpClient aCcvejjal2Z;

	internal static f5JohrvexmbTflVkIcPK Cw9dBExBmJDMVBw51Lie;

	public f5JohrvexmbTflVkIcPK(string P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				aCcvejjal2Z = plXx4qaSO0mUHx2yKA05.UrBaSI80GWN(P_0, P_1);
				((HttpHeaders)mwrqeoxB722cgqFExcgS(aCcvejjal2Z)).Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-371631841 ^ -371658461), (string)GZGbpExB8tA0IbLZFHra(0x34407BB ^ 0x345AFF7));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
				{
					num = 0;
				}
				break;
			default:
				aCcvejjal2Z.DefaultRequestHeaders.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1736566656 ^ -1736462318), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1801468030 ^ -1801556170));
				return;
			}
		}
	}

	public Task<string> ulgveeUqHA7(string P_0, AVK2rXvep2iLZehbC0Wt P_1)
	{
		HttpRequestMessage httpRequestMessage = pbMveXEsmTb(HttpMethod.Post, P_0, P_1);
		return leDvesmi8vt(httpRequestMessage);
	}

	[AsyncStateMachine(typeof(wH0HTkaPS8ThsMvADa2g))]
	private Task<string> leDvesmi8vt(HttpRequestMessage P_0)
	{
		wH0HTkaPS8ThsMvADa2g stateMachine = default(wH0HTkaPS8ThsMvADa2g);
		stateMachine.N0haPLjZVjp = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.F0MaPeSrLXG = this;
		stateMachine.fVAaPsiXtjY = P_0;
		stateMachine.bJyaPx1UfAX = -1;
		stateMachine.N0haPLjZVjp.Start(ref stateMachine);
		return stateMachine.N0haPLjZVjp.Task;
	}

	private HttpRequestMessage pbMveXEsmTb(HttpMethod P_0, string P_1, AVK2rXvep2iLZehbC0Wt P_2)
	{
		int num = 7;
		int num2 = num;
		string text = default(string);
		HttpRequestMessage httpRequestMessage = default(HttpRequestMessage);
		string value = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				if (RsL2FTxBAck5RRSu4pV4(P_0, HttpMethod.Post))
				{
					num2 = 5;
					break;
				}
				goto IL_00ab;
			case 3:
				text = string.Empty;
				httpRequestMessage.Content = new StringContent((string)bjFGPgxBPQ6L2OEmeJ3e(P_2), (Encoding)RLaVtQxBJxMDx5ZHk2sj(), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1487846E ^ 0x1486DA68));
				goto IL_00df;
			case 8:
				obj = null;
				goto IL_0249;
			case 4:
				httpRequestMessage.Headers.Add((string)GZGbpExB8tA0IbLZFHra(-1583344314 ^ -1583236058), value);
				((HttpHeaders)EuOEAAxBp3736ipJBUFg(httpRequestMessage)).Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1192989954 ^ -1192901758), value);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (!(P_0 != HttpMethod.Put))
				{
					goto IL_00ab;
				}
				if (P_2 == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
					{
						num2 = 8;
					}
					break;
				}
				obj = P_2.MlPl9kI3Tww();
				goto IL_0249;
			case 1:
				return httpRequestMessage;
			case 7:
				text = string.Empty;
				num2 = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				obj = string.Empty;
				goto IL_026f;
			default:
				{
					httpRequestMessage.RequestUri = new Uri((string)ruD0l1xBuYksneZSUGwQ(P_1, string.IsNullOrWhiteSpace(text) ? string.Empty : (F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1583344314 ^ -1583264954) + text)), UriKind.RelativeOrAbsolute);
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_00df:
				value = Yb8Q4bxBFshqaRh97xie().ToString();
				eEJc1cxB3KAmm9VbItr0(httpRequestMessage.Headers, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-82860344 ^ -82964950), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1878953018 ^ -1878992076));
				httpRequestMessage.Headers.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x9F0F634 ^ 0x9F1513E), (string)GZGbpExB8tA0IbLZFHra(-1999650146 ^ -1999737930));
				num2 = 4;
				break;
				IL_026f:
				text = (string)obj;
				goto IL_00ab;
				IL_0249:
				if (obj == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_026f;
				IL_00ab:
				httpRequestMessage = new HttpRequestMessage(P_0, P_1);
				if (!(P_0 == HttpMethod.Post))
				{
					if (P_0 == HttpMethod.Put)
					{
						goto case 3;
					}
					goto IL_00df;
				}
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public void EyavecvAlXj(string P_0)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (string.IsNullOrEmpty(P_0))
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
					{
						num2 = 1;
					}
					break;
				}
				if (aCcvejjal2Z.DefaultRequestHeaders.Contains((string)GZGbpExB8tA0IbLZFHra(0x86EFEF6 ^ 0x86F5756)))
				{
					aCcvejjal2Z.DefaultRequestHeaders.Remove((string)GZGbpExB8tA0IbLZFHra(-1583344314 ^ -1583235866));
				}
				text = (string)GZGbpExB8tA0IbLZFHra(-1127423276 ^ -1127396502) + P_0;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				eEJc1cxB3KAmm9VbItr0(aCcvejjal2Z.DefaultRequestHeaders, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1801468030 ^ -1801556446), text);
				return;
			case 1:
				return;
			}
		}
	}

	static f5JohrvexmbTflVkIcPK()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object mwrqeoxB722cgqFExcgS(object P_0)
	{
		return ((HttpClient)P_0).DefaultRequestHeaders;
	}

	internal static object GZGbpExB8tA0IbLZFHra(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool l29joUxBhN4Scc6E4Cex()
	{
		return Cw9dBExBmJDMVBw51Lie == null;
	}

	internal static f5JohrvexmbTflVkIcPK esnEfIxBwFZQW8aEk6ij()
	{
		return Cw9dBExBmJDMVBw51Lie;
	}

	internal static bool RsL2FTxBAck5RRSu4pV4(object P_0, object P_1)
	{
		return (HttpMethod)P_0 != (HttpMethod)P_1;
	}

	internal static object bjFGPgxBPQ6L2OEmeJ3e(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static object RLaVtQxBJxMDx5ZHk2sj()
	{
		return Encoding.UTF8;
	}

	internal static Guid Yb8Q4bxBFshqaRh97xie()
	{
		return Guid.NewGuid();
	}

	internal static void eEJc1cxB3KAmm9VbItr0(object P_0, object P_1, object P_2)
	{
		((HttpHeaders)P_0).Add((string)P_1, (string)P_2);
	}

	internal static object EuOEAAxBp3736ipJBUFg(object P_0)
	{
		return ((HttpRequestMessage)P_0).Headers;
	}

	internal static object ruD0l1xBuYksneZSUGwQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
