using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using kmPUr7actBs48BSagCU8;
using Newtonsoft.Json;
using oU62lnaXZKfCrjjOVx5J;
using q3N5jAveu8GgmbYJCie2;
using r8oOHiajFPNBXu6XiAHj;
using riX1S3veLlVehxG8TkOO;
using x97CE55GhEYKgt7TSVZT;

namespace EvbL7tveK7uAaCf2ivES;

internal sealed class UdyxHRvertGSi6ITYD24
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct PNImGKaPQjQJPdWVG5Da<hGTuB65fa7eu54OMqfBa, MaHhbp5fijvVP4cotUqs> : IAsyncStateMachine
	{
		public int Ak15flZvQ1M;

		public AsyncTaskMethodBuilder<MaHhbp5fijvVP4cotUqs> jVn5f4tW02A;

		public hGTuB65fa7eu54OMqfBa exx5fDK5g0w;

		public mLf6eEaXygNmbpM1QQhY<hGTuB65fa7eu54OMqfBa, MaHhbp5fijvVP4cotUqs> UWJ5fbWLrNh;

		public UdyxHRvertGSi6ITYD24 Pg95fNNJEFL;

		public string B435fkttZVi;

		private TaskAwaiter<string> Ge85f1n7s8T;

		private void MoveNext()
		{
			int num = 2;
			int num2 = num;
			UdyxHRvertGSi6ITYD24 udyxHRvertGSi6ITYD = default(UdyxHRvertGSi6ITYD24);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			AVK2rXvep2iLZehbC0Wt aVK2rXvep2iLZehbC0Wt = default(AVK2rXvep2iLZehbC0Wt);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					udyxHRvertGSi6ITYD = Pg95fNNJEFL;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num3 = Ak15flZvQ1M;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				MaHhbp5fijvVP4cotUqs result2;
				try
				{
					int num4;
					if (num3 != 0)
					{
						num4 = 2;
						goto IL_003e;
					}
					goto IL_019a;
					IL_019a:
					awaiter = Ge85f1n7s8T;
					Ge85f1n7s8T = default(TaskAwaiter<string>);
					num4 = 4;
					goto IL_003e;
					IL_003e:
					while (true)
					{
						switch (num4)
						{
						case 2:
							aVK2rXvep2iLZehbC0Wt = exx5fDK5g0w as AVK2rXvep2iLZehbC0Wt;
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
							{
								num4 = 6;
							}
							continue;
						default:
							Ge85f1n7s8T = awaiter;
							jVn5f4tW02A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 4:
							num3 = (Ak15flZvQ1M = -1);
							num4 = 3;
							continue;
						case 6:
							if (UWJ5fbWLrNh.dEjaXCmT13F() != (NhWo0EacWemMF9LI09AS)2)
							{
								throw new ArgumentOutOfRangeException();
							}
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
							{
								num4 = 1;
							}
							continue;
						case 3:
						{
							string result = awaiter.GetResult();
							result2 = JsonConvert.DeserializeObject<MaHhbp5fijvVP4cotUqs>(result);
							goto end_IL_003e;
						}
						case 5:
							break;
						case 1:
							udyxHRvertGSi6ITYD.j9xvewa4Ttm.EyavecvAlXj(B435fkttZVi);
							awaiter = udyxHRvertGSi6ITYD.j9xvewa4Ttm.ulgveeUqHA7(UWJ5fbWLrNh.Action, aVK2rXvep2iLZehbC0Wt).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num3 = (Ak15flZvQ1M = 0);
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 3;
						}
						goto IL_019a;
						continue;
						end_IL_003e:
						break;
					}
				}
				catch (Exception exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					}
					Ak15flZvQ1M = -2;
					jVn5f4tW02A.SetException(exception);
					return;
				}
				Ak15flZvQ1M = -2;
				jVn5f4tW02A.SetResult(result2);
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
			jVn5f4tW02A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static PNImGKaPQjQJPdWVG5Da()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool gI2PJcLk7Oxr10Lheqc1()
		{
			return true;
		}

		internal static object PhC9I1Lk8t99YvaX6Y7j()
		{
			return null;
		}
	}

	private readonly f5JohrvexmbTflVkIcPK j9xvewa4Ttm;

	internal static UdyxHRvertGSi6ITYD24 QonJehxalbyrtOZVaF64;

	private UdyxHRvertGSi6ITYD24(string P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		j9xvewa4Ttm = new f5JohrvexmbTflVkIcPK(P_0, P_1);
	}

	[AsyncStateMachine(typeof(PNImGKaPQjQJPdWVG5Da<, >))]
	public Task<dKT3wB1lT2WYWcSGt6cj> rcfvemDIImY<gKRmRl1lUMUt6Jk84iw2, dKT3wB1lT2WYWcSGt6cj>(mLf6eEaXygNmbpM1QQhY<gKRmRl1lUMUt6Jk84iw2, dKT3wB1lT2WYWcSGt6cj> P_0, gKRmRl1lUMUt6Jk84iw2 lHodDB1lylL4vWcxA98v, string P_2)
	{
		PNImGKaPQjQJPdWVG5Da<gKRmRl1lUMUt6Jk84iw2, dKT3wB1lT2WYWcSGt6cj> stateMachine = default(PNImGKaPQjQJPdWVG5Da<gKRmRl1lUMUt6Jk84iw2, dKT3wB1lT2WYWcSGt6cj>);
		stateMachine.jVn5f4tW02A = AsyncTaskMethodBuilder<dKT3wB1lT2WYWcSGt6cj>.Create();
		stateMachine.Pg95fNNJEFL = this;
		stateMachine.UWJ5fbWLrNh = P_0;
		stateMachine.exx5fDK5g0w = lHodDB1lylL4vWcxA98v;
		stateMachine.B435fkttZVi = P_2;
		stateMachine.Ak15flZvQ1M = -1;
		stateMachine.jVn5f4tW02A.Start(ref stateMachine);
		return stateMachine.jVn5f4tW02A.Task;
	}

	public static UdyxHRvertGSi6ITYD24 gPcveh1DbqO(string P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		return new UdyxHRvertGSi6ITYD24(P_0, P_1);
	}

	static UdyxHRvertGSi6ITYD24()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool AHgvkExa4vREqrwatDGq()
	{
		return QonJehxalbyrtOZVaF64 == null;
	}

	internal static UdyxHRvertGSi6ITYD24 j84KaAxaD4IZHKsFXWCv()
	{
		return QonJehxalbyrtOZVaF64;
	}
}
