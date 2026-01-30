using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using r8oOHiajFPNBXu6XiAHj;
using s2UiSE5YBL9itf1iCcbq;
using x97CE55GhEYKgt7TSVZT;

namespace HDCBWDo8NA8sYY1SmxJD;

internal sealed class L7Hj3Io8bi0qiBrDorL2
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Jd1jxwawVPD4cHF1Z5gA : IAsyncStateMachine
	{
		public int CMiawCeYVM5;

		public AsyncTaskMethodBuilder<string> FZ4awrgR7ll;

		public HttpClient YvIawKNJKnB;

		public HttpRequestMessage xlmawmafGfy;

		private HttpResponseMessage ShyawhriOiY;

		private TaskAwaiter<HttpResponseMessage> C0OawwGT42E;

		private TaskAwaiter<string> CQOaw7ERdGf;

		internal static object HusxEiL4kndOSEBDewah;

		private void MoveNext()
		{
			int num = CMiawCeYVM5;
			string result3 = default(string);
			try
			{
				int num2;
				TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
				int num3;
				TaskAwaiter<HttpResponseMessage> awaiter2 = default(TaskAwaiter<HttpResponseMessage>);
				if (num != 0)
				{
					if (num != 1)
					{
						num2 = 6;
						goto IL_007e;
					}
					awaiter = CQOaw7ERdGf;
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
					{
						num3 = 1;
					}
				}
				else
				{
					awaiter2 = C0OawwGT42E;
					num3 = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
					{
						num3 = 7;
					}
				}
				goto IL_0082;
				IL_007e:
				num3 = num2;
				goto IL_0082;
				IL_0082:
				string result = default(string);
				while (true)
				{
					HttpResponseMessage result2;
					switch (num3)
					{
					case 5:
						return;
					default:
						FZ4awrgR7ll.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 5;
						break;
					case 6:
						awaiter2 = YvIawKNJKnB.SendAsync(xlmawmafGfy).GetAwaiter();
						num3 = 2;
						continue;
					case 8:
						num = (CMiawCeYVM5 = 0);
						C0OawwGT42E = awaiter2;
						FZ4awrgR7ll.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					case 9:
						CQOaw7ERdGf = awaiter;
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						if (wMGRAZL4x0Z7XLHEoDVm(ShyawhriOiY))
						{
							result3 = result;
							num3 = 4;
						}
						else
						{
							num3 = 11;
						}
						continue;
					case 2:
						if (!awaiter2.IsCompleted)
						{
							num3 = 8;
							continue;
						}
						goto IL_0246;
					case 1:
						CQOaw7ERdGf = default(TaskAwaiter<string>);
						num = (CMiawCeYVM5 = -1);
						goto IL_00bc;
					case 4:
						goto end_IL_0082;
					case 7:
						C0OawwGT42E = default(TaskAwaiter<HttpResponseMessage>);
						num3 = 9;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
						{
							num3 = 10;
						}
						continue;
					case 10:
						num = (CMiawCeYVM5 = -1);
						goto IL_0246;
					case 11:
						{
							try
							{
								throw new Exception(result);
							}
							catch (JsonReaderException)
							{
								throw new Exception(result);
							}
						}
						IL_0246:
						result2 = awaiter2.GetResult();
						ShyawhriOiY = result2;
						awaiter = ((HttpContent)Dvg4sXL4Se9CQsJhfsuv(ShyawhriOiY)).ReadAsStringAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (CMiawCeYVM5 = 1);
							num3 = 9;
							continue;
						}
						goto IL_00bc;
						IL_00bc:
						result = awaiter.GetResult();
						num2 = 3;
						break;
					}
					goto IL_007e;
					continue;
					end_IL_0082:
					break;
				}
			}
			catch (Exception exception)
			{
				CMiawCeYVM5 = -2;
				ShyawhriOiY = null;
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				}
				FZ4awrgR7ll.SetException(exception);
				return;
			}
			CMiawCeYVM5 = -2;
			int num5 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
			{
				num5 = 1;
			}
			while (true)
			{
				switch (num5)
				{
				default:
					return;
				case 1:
					ShyawhriOiY = null;
					FZ4awrgR7ll.SetResult(result3);
					num5 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
					{
						num5 = 0;
					}
					break;
				case 0:
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
			FZ4awrgR7ll.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Jd1jxwawVPD4cHF1Z5gA()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object Dvg4sXL4Se9CQsJhfsuv(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		internal static bool wMGRAZL4x0Z7XLHEoDVm(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		internal static bool CVaFOLL41NcOjp8b5gdD()
		{
			return HusxEiL4kndOSEBDewah == null;
		}

		internal static object c3ncSXL45f6pXY5AXT5V()
		{
			return HusxEiL4kndOSEBDewah;
		}
	}

	private static readonly DateTime Gloo8L5gHl6;

	internal static L7Hj3Io8bi0qiBrDorL2 D7TxpRSuq9rAKhUpC21Y;

	public Task<string> obHo8kPlOTO(string P_0, string P_1, C3trUsajJIHJMtdo9pBg P_2)
	{
		object[] array = jR6Pnd5YvEbw7bdAD3oG.YQb5Y4jOfG9(0, new object[3] { P_0, P_1, P_2 }, this);
		return (Task<string>)array[0];
	}

	[AsyncStateMachine(typeof(Jd1jxwawVPD4cHF1Z5gA))]
	private Task<string> I1Mo816vLYW(HttpClient P_0, HttpRequestMessage P_1)
	{
		Jd1jxwawVPD4cHF1Z5gA stateMachine = default(Jd1jxwawVPD4cHF1Z5gA);
		stateMachine.FZ4awrgR7ll = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.YvIawKNJKnB = P_0;
		stateMachine.xlmawmafGfy = P_1;
		stateMachine.CMiawCeYVM5 = -1;
		stateMachine.FZ4awrgR7ll.Start(ref stateMachine);
		return stateMachine.FZ4awrgR7ll.Task;
	}

	private byte[] uLGo855735B(byte[] P_0, byte[] P_1)
	{
		using HMACSHA256 hMACSHA = new HMACSHA256(P_0);
		return (byte[])TsbMfMSutomBjBEoiecn(hMACSHA, P_1);
	}

	private string gKmo8SR0Upy(byte[] P_0)
	{
		int num = 3;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		byte[] array = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stringBuilder = new StringBuilder(P_0.Length * 2);
				num2 = 2;
				break;
			case 2:
				array = P_0;
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 < array.Length)
				{
					byte b = array[num3];
					stringBuilder.AppendFormat((string)z51LusSuUCsLL788eYrC(0x22BF43FC ^ 0x22BED43A), b);
					num2 = 4;
					break;
				}
				return stringBuilder.ToString();
			case 4:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private long Ldio8xtRamd(TimeSpan P_0)
	{
		return (long)(DateTime.UtcNow.Add(P_0) - Gloo8L5gHl6).TotalSeconds * 1000;
	}

	public L7Hj3Io8bi0qiBrDorL2()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static L7Hj3Io8bi0qiBrDorL2()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		U948CpSuTDMF3Tj0fxXX();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		Gloo8L5gHl6 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}

	internal static object TsbMfMSutomBjBEoiecn(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static bool NV2E3XSuIayu8gCNG5vp()
	{
		return D7TxpRSuq9rAKhUpC21Y == null;
	}

	internal static L7Hj3Io8bi0qiBrDorL2 nvfKTHSuW7S2mDTsnQ6j()
	{
		return D7TxpRSuq9rAKhUpC21Y;
	}

	internal static object z51LusSuUCsLL788eYrC(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void U948CpSuTDMF3Tj0fxXX()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
