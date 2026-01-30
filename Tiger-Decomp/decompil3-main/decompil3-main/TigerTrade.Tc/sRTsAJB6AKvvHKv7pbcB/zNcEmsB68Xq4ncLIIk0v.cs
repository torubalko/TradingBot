using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using k7dnUvBqTCAfi8Y8Tlb1;
using Kn220bBqOEUSDihnvK9V;
using KSdx09BMoCV6YKpu9HP1;
using l95XbJB6Dbb8I5ICEVPI;
using Newtonsoft.Json;
using pTV1afBO0e5xX74R486l;
using r8oOHiajFPNBXu6XiAHj;
using uiZLHABMwdeXbx7dtKy5;
using x97CE55GhEYKgt7TSVZT;

namespace sRTsAJB6AKvvHKv7pbcB;

internal sealed class zNcEmsB68Xq4ncLIIk0v
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct KpBtLfiHGirfpAbtNaL2 : IAsyncStateMachine
	{
		public int CORiHY5L73F;

		public AsyncTaskMethodBuilder MjPiHolmmR7;

		public zNcEmsB68Xq4ncLIIk0v jIQiHvUDbUT;

		public int IBZiHBnolMN;

		private TaskAwaiter qZViHa2UO1X;

		internal static object cZfFCCLE9QDTGLVpRbNd;

		private void MoveNext()
		{
			int num = CORiHY5L73F;
			zNcEmsB68Xq4ncLIIk0v zNcEmsB68Xq4ncLIIk0v2 = jIQiHvUDbUT;
			try
			{
				TaskAwaiter awaiter;
				int num2;
				if (num == 0)
				{
					awaiter = qZViHa2UO1X;
					num2 = 3;
				}
				else
				{
					awaiter = tm0OIvLEoCAnFGTbCyHY(fEL5j4LEYl3RZLjLvTP5(zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP, IBZiHBnolMN));
					if (awaiter.IsCompleted)
					{
						goto IL_0070;
					}
					num = (CORiHY5L73F = 0);
					qZViHa2UO1X = awaiter;
					MjPiHolmmR7.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
					{
						num2 = 0;
					}
				}
				while (true)
				{
					switch (num2)
					{
					case 3:
						qZViHa2UO1X = default(TaskAwaiter);
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						return;
					case 1:
						num = (CORiHY5L73F = -1);
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				goto IL_0070;
				IL_0070:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				CORiHY5L73F = -2;
				MjPiHolmmR7.SetException(exception);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
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
			while (true)
			{
				CORiHY5L73F = -2;
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 1:
					continue;
				}
				MjPiHolmmR7.SetResult();
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
			MjPiHolmmR7.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static KpBtLfiHGirfpAbtNaL2()
		{
			gXJUJ2LEvEpKolh6gd01();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object fEL5j4LEYl3RZLjLvTP5(object P_0, int P_1)
		{
			return ((SkkWKqB642YoCdj0t6sA)P_0).q2dB6bAgtBu(P_1);
		}

		internal static TaskAwaiter tm0OIvLEoCAnFGTbCyHY(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		internal static bool iQhlLmLEndqPThJXfBCK()
		{
			return cZfFCCLE9QDTGLVpRbNd == null;
		}

		internal static object mv4wMlLEGbALiFhsJFVq()
		{
			return cZfFCCLE9QDTGLVpRbNd;
		}

		internal static void gXJUJ2LEvEpKolh6gd01()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct pAeG5tiHiRIL8JQQXn6l<Qt5Rbr5fZAl6shwaC3kT, Fy9sfq5fVCnVncj3gqCt> : IAsyncStateMachine
	{
		public int Oxx5fCoBjiP;

		public AsyncTaskMethodBuilder<Fy9sfq5fVCnVncj3gqCt> sLp5frPYQ2W;

		public Qt5Rbr5fZAl6shwaC3kT w5q5fKhlQuL;

		public nsBdROBMzGNXafCHoKTI<Qt5Rbr5fZAl6shwaC3kT, Fy9sfq5fVCnVncj3gqCt> aJE5fmUZbM9;

		public zNcEmsB68Xq4ncLIIk0v ATg5fhoYCCy;

		private TaskAwaiter<string> c5E5fwDMsdW;

		private void MoveNext()
		{
			int num = 2;
			int num2 = num;
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			skOVJTBqMb0H5lpWL7yZ skOVJTBqMb0H5lpWL7yZ = default(skOVJTBqMb0H5lpWL7yZ);
			Fy9sfq5fVCnVncj3gqCt result = default(Fy9sfq5fVCnVncj3gqCt);
			ntRdIABMhfsLMduEQw1Q ntRdIABMhfsLMduEQw1Q = default(ntRdIABMhfsLMduEQw1Q);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					zNcEmsB68Xq4ncLIIk0v zNcEmsB68Xq4ncLIIk0v2 = ATg5fhoYCCy;
					try
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = 8;
							goto IL_004e;
						case 0:
							awaiter = c5E5fwDMsdW;
							num4 = 10;
							goto IL_004e;
						case 1:
							awaiter = c5E5fwDMsdW;
							num4 = 7;
							goto IL_004e;
						case 3:
							awaiter = c5E5fwDMsdW;
							c5E5fwDMsdW = default(TaskAwaiter<string>);
							num3 = (Oxx5fCoBjiP = -1);
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
							{
								num4 = 0;
							}
							goto IL_004e;
						case 2:
							{
								awaiter = c5E5fwDMsdW;
								c5E5fwDMsdW = default(TaskAwaiter<string>);
								num3 = (Oxx5fCoBjiP = -1);
								break;
							}
							IL_004e:
							while (true)
							{
								int num5;
								switch (num4)
								{
								case 16:
									c5E5fwDMsdW = awaiter;
									num4 = 17;
									continue;
								case 7:
									c5E5fwDMsdW = default(TaskAwaiter<string>);
									num3 = (Oxx5fCoBjiP = -1);
									goto IL_0217;
								case 19:
									awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.Delete(aJE5fmUZbM9.Action, skOVJTBqMb0H5lpWL7yZ).GetAwaiter();
									if (awaiter.IsCompleted)
									{
										num5 = 15;
										goto IL_004a;
									}
									goto case 9;
								case 20:
									goto IL_012a;
								case 1:
									c5E5fwDMsdW = awaiter;
									num4 = 6;
									continue;
								case 17:
									sLp5frPYQ2W.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 21:
									num3 = (Oxx5fCoBjiP = -1);
									num4 = 14;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 != 0)
									{
										num4 = 9;
									}
									continue;
								case 6:
									sLp5frPYQ2W.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 11:
									goto end_IL_004e;
								case 14:
									result = JsonConvert.DeserializeObject<Fy9sfq5fVCnVncj3gqCt>(awaiter.GetResult());
									num4 = 11;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
									{
										num4 = 8;
									}
									continue;
								case 10:
									c5E5fwDMsdW = default(TaskAwaiter<string>);
									num4 = 21;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
									{
										num4 = 3;
									}
									continue;
								case 4:
									ntRdIABMhfsLMduEQw1Q = aJE5fmUZbM9.tM5BOHo5w1K();
									num4 = 3;
									continue;
								case 9:
									num3 = (Oxx5fCoBjiP = 3);
									num5 = 16;
									goto IL_004a;
								case 8:
									skOVJTBqMb0H5lpWL7yZ = w5q5fKhlQuL as skOVJTBqMb0H5lpWL7yZ;
									num4 = 4;
									continue;
								default:
									result = JsonConvert.DeserializeObject<Fy9sfq5fVCnVncj3gqCt>(awaiter.GetResult());
									num4 = 5;
									continue;
								case 18:
									goto IL_03c7;
								case 12:
									num3 = (Oxx5fCoBjiP = 2);
									c5E5fwDMsdW = awaiter;
									sLp5frPYQ2W.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 3:
									switch (ntRdIABMhfsLMduEQw1Q)
									{
									case (ntRdIABMhfsLMduEQw1Q)4:
										break;
									case (ntRdIABMhfsLMduEQw1Q)2:
										goto IL_012a;
									case (ntRdIABMhfsLMduEQw1Q)1:
										goto IL_03c7;
									default:
										goto IL_0423;
									case (ntRdIABMhfsLMduEQw1Q)3:
										goto IL_043c;
									}
									goto case 19;
								case 13:
									goto IL_043c;
								case 5:
									goto end_IL_004e;
								case 2:
									{
										throw new ArgumentOutOfRangeException();
									}
									IL_043c:
									awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.aRaB6S0ablC(aJE5fmUZbM9.Action, skOVJTBqMb0H5lpWL7yZ).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num4 = 12;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
										{
											num4 = 2;
										}
										continue;
									}
									break;
									IL_012a:
									awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.PwZB61b7J2f(aJE5fmUZbM9.Action, skOVJTBqMb0H5lpWL7yZ).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = (Oxx5fCoBjiP = 1);
										c5E5fwDMsdW = awaiter;
										sLp5frPYQ2W.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_0217;
									IL_0217:
									result = JsonConvert.DeserializeObject<Fy9sfq5fVCnVncj3gqCt>(awaiter.GetResult());
									goto end_IL_004e;
									IL_0423:
									num4 = 2;
									continue;
									IL_03c7:
									awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.Mu4B6NXXNWn(aJE5fmUZbM9.Action, skOVJTBqMb0H5lpWL7yZ).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num3 = (Oxx5fCoBjiP = 0);
										num4 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 14;
									IL_004a:
									num4 = num5;
									continue;
								}
								goto end_IL_002b;
								continue;
								end_IL_004e:
								break;
							}
							goto end_IL_0029;
							end_IL_002b:
							break;
						}
						result = JsonConvert.DeserializeObject<Fy9sfq5fVCnVncj3gqCt>(awaiter.GetResult());
						end_IL_0029:;
					}
					catch (Exception exception)
					{
						int num6 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						}
						Oxx5fCoBjiP = -2;
						sLp5frPYQ2W.SetException(exception);
						return;
					}
					Oxx5fCoBjiP = -2;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
					{
						num2 = 0;
					}
					break;
				}
				default:
					sLp5frPYQ2W.SetResult(result);
					return;
				case 2:
					num3 = Oxx5fCoBjiP;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
					{
						num2 = 1;
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
			sLp5frPYQ2W.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static pAeG5tiHiRIL8JQQXn6l()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool jWWw7ELEaUnLGncf3pqo()
		{
			return true;
		}

		internal static object vOXq90LEiaIaT99Jyfsk()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct ppgoSbiHle9cx6cdYw2G<RU9paV5f7eMuyFPTjeXE, VYBZyC5f8MVdkEqfFOea> : IAsyncStateMachine
	{
		public int Wun5fALTks5;

		public AsyncTaskMethodBuilder<VYBZyC5f8MVdkEqfFOea> Qxg5fPXGqg4;

		public RU9paV5f7eMuyFPTjeXE q6j5fJMZtxf;

		public nsBdROBMzGNXafCHoKTI<RU9paV5f7eMuyFPTjeXE, VYBZyC5f8MVdkEqfFOea> OQD5fFOpkj3;

		public zNcEmsB68Xq4ncLIIk0v FEQ5f3JGryW;

		private TaskAwaiter<string> iM75fpETElh;

		private void MoveNext()
		{
			int num = Wun5fALTks5;
			zNcEmsB68Xq4ncLIIk0v zNcEmsB68Xq4ncLIIk0v2 = FEQ5f3JGryW;
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
			{
				num2 = 1;
			}
			VYBZyC5f8MVdkEqfFOea result = default(VYBZyC5f8MVdkEqfFOea);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			t5eDSmBqUL1ghG8hBO4e t5eDSmBqUL1ghG8hBO4e = default(t5eDSmBqUL1ghG8hBO4e);
			while (true)
			{
				switch (num2)
				{
				default:
					Qxg5fPXGqg4.SetResult(result);
					return;
				case 1:
					try
					{
						int num3;
						int num4;
						switch (num)
						{
						default:
							num3 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
							{
								num3 = 5;
							}
							goto IL_00a7;
						case 2:
							goto IL_023b;
						case 3:
							awaiter = iM75fpETElh;
							num3 = 20;
							goto IL_00a7;
						case 0:
							goto IL_03b4;
						case 1:
							{
								awaiter = iM75fpETElh;
								num3 = 3;
								goto IL_00a7;
							}
							IL_038e:
							result = JsonConvert.DeserializeObject<VYBZyC5f8MVdkEqfFOea>(awaiter.GetResult());
							num4 = 8;
							goto IL_00a3;
							IL_00a7:
							while (true)
							{
								switch (num3)
								{
								case 8:
									break;
								case 4:
									iM75fpETElh = default(TaskAwaiter<string>);
									num = (Wun5fALTks5 = -1);
									goto IL_0306;
								case 18:
									goto IL_016a;
								case 13:
									iM75fpETElh = awaiter;
									Qxg5fPXGqg4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num3 = 6;
									continue;
								case 11:
									num = (Wun5fALTks5 = 0);
									num3 = 16;
									continue;
								case 7:
									num = (Wun5fALTks5 = 2);
									iM75fpETElh = awaiter;
									Qxg5fPXGqg4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 14:
									goto IL_023b;
								case 15:
									iM75fpETElh = awaiter;
									num3 = 9;
									continue;
								case 1:
									goto IL_025a;
								case 6:
									return;
								case 3:
									goto IL_02e3;
								case 9:
									Qxg5fPXGqg4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 20:
									iM75fpETElh = default(TaskAwaiter<string>);
									num = (Wun5fALTks5 = -1);
									num3 = 12;
									continue;
								case 16:
									iM75fpETElh = awaiter;
									Qxg5fPXGqg4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 19:
									if (awaiter.IsCompleted)
									{
										goto end_IL_0074;
									}
									goto case 7;
								case 12:
									goto IL_038e;
								case 21:
									goto IL_03b4;
								case 5:
									t5eDSmBqUL1ghG8hBO4e = q6j5fJMZtxf as t5eDSmBqUL1ghG8hBO4e;
									num3 = 2;
									continue;
								case 0:
									break;
								case 10:
									if (awaiter.IsCompleted)
									{
										goto IL_0306;
									}
									goto IL_042a;
								case 17:
									goto IL_0456;
								case 2:
									goto IL_04ad;
									IL_0306:
									result = JsonConvert.DeserializeObject<VYBZyC5f8MVdkEqfFOea>(awaiter.GetResult());
									num3 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
								IL_04ad:
								switch (OQD5fFOpkj3.tM5BOHo5w1K())
								{
								case (ntRdIABMhfsLMduEQw1Q)2:
									break;
								case (ntRdIABMhfsLMduEQw1Q)4:
									goto IL_0289;
								case (ntRdIABMhfsLMduEQw1Q)1:
									goto IL_0456;
								case (ntRdIABMhfsLMduEQw1Q)3:
									goto IL_04d1;
								default:
									throw new ArgumentOutOfRangeException();
								}
								goto IL_025a;
								IL_04d1:
								awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.JyPB6xbbZJ3(OQD5fFOpkj3.Action, t5eDSmBqUL1ghG8hBO4e).GetAwaiter();
								num3 = 19;
								continue;
								IL_0289:
								awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.Delete(OQD5fFOpkj3.Action, t5eDSmBqUL1ghG8hBO4e).GetAwaiter();
								num3 = 18;
								continue;
								IL_0456:
								awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.N2RB6k7NwSx(OQD5fFOpkj3.Action, t5eDSmBqUL1ghG8hBO4e).GetAwaiter();
								num3 = 10;
								continue;
								IL_02e3:
								iM75fpETElh = default(TaskAwaiter<string>);
								num = (Wun5fALTks5 = -1);
								goto IL_0138;
								IL_025a:
								awaiter = zNcEmsB68Xq4ncLIIk0v2.jPaBM2AtdAP.CL3B655USUi(OQD5fFOpkj3.Action, t5eDSmBqUL1ghG8hBO4e).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (Wun5fALTks5 = 1);
									num3 = 15;
									continue;
								}
								goto IL_0138;
								IL_0138:
								result = JsonConvert.DeserializeObject<VYBZyC5f8MVdkEqfFOea>(awaiter.GetResult());
								break;
							}
							goto end_IL_0072;
							IL_042a:
							num4 = 11;
							goto IL_00a3;
							IL_03b4:
							awaiter = iM75fpETElh;
							num4 = 4;
							goto IL_00a3;
							IL_023b:
							awaiter = iM75fpETElh;
							iM75fpETElh = default(TaskAwaiter<string>);
							num = (Wun5fALTks5 = -1);
							break;
							IL_016a:
							if (!awaiter.IsCompleted)
							{
								num = (Wun5fALTks5 = 3);
								num4 = 13;
								goto IL_00a3;
							}
							goto IL_038e;
							IL_00a3:
							num3 = num4;
							goto IL_00a7;
							end_IL_0074:
							break;
						}
						result = JsonConvert.DeserializeObject<VYBZyC5f8MVdkEqfFOea>(awaiter.GetResult());
						end_IL_0072:;
					}
					catch (Exception exception)
					{
						Wun5fALTks5 = -2;
						Qxg5fPXGqg4.SetException(exception);
						int num5 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
						return;
					}
					Wun5fALTks5 = -2;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
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
			Qxg5fPXGqg4.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static ppgoSbiHle9cx6cdYw2G()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool MjftHULE4pF8XBU9pAjr()
		{
			return true;
		}

		internal static object FdkwssLEDHtwlXXtvQRB()
		{
			return null;
		}
	}

	private readonly SkkWKqB642YoCdj0t6sA jPaBM2AtdAP;

	private static zNcEmsB68Xq4ncLIIk0v hqVQIixRTpB3Q1N0rI3y;

	[SpecialName]
	public int AQ2B6zi4XPF()
	{
		return qiFmqGxRV3llyObdxIck(jPaBM2AtdAP);
	}

	private zNcEmsB68Xq4ncLIIk0v(FEdaZIBMYBQiNHglCmuu P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		jPaBM2AtdAP = new SkkWKqB642YoCdj0t6sA(P_0, P_1);
	}

	[AsyncStateMachine(typeof(KpBtLfiHGirfpAbtNaL2))]
	public Task kFjB6PxiqWC(int P_0)
	{
		KpBtLfiHGirfpAbtNaL2 stateMachine = default(KpBtLfiHGirfpAbtNaL2);
		stateMachine.MjPiHolmmR7 = AsyncTaskMethodBuilder.Create();
		stateMachine.jIQiHvUDbUT = this;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.MjPiHolmmR7.Start(ref stateMachine);
				return stateMachine.MjPiHolmmR7.Task;
			}
			stateMachine.IBZiHBnolMN = P_0;
			stateMachine.CORiHY5L73F = -1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
			{
				num = 1;
			}
		}
	}

	[AsyncStateMachine(typeof(pAeG5tiHiRIL8JQQXn6l<, >))]
	public Task<S99tc51T4jFn2hLRic88> rj9B6J2E8Pv<nTeGM51TlNBtGAESr2yn, S99tc51T4jFn2hLRic88>(nsBdROBMzGNXafCHoKTI<nTeGM51TlNBtGAESr2yn, S99tc51T4jFn2hLRic88> P_0, nTeGM51TlNBtGAESr2yn G8GbKB1TDIgmkfWVNAfy)
	{
		pAeG5tiHiRIL8JQQXn6l<nTeGM51TlNBtGAESr2yn, S99tc51T4jFn2hLRic88> stateMachine = default(pAeG5tiHiRIL8JQQXn6l<nTeGM51TlNBtGAESr2yn, S99tc51T4jFn2hLRic88>);
		stateMachine.sLp5frPYQ2W = AsyncTaskMethodBuilder<S99tc51T4jFn2hLRic88>.Create();
		stateMachine.ATg5fhoYCCy = this;
		stateMachine.aJE5fmUZbM9 = P_0;
		stateMachine.w5q5fKhlQuL = G8GbKB1TDIgmkfWVNAfy;
		stateMachine.Oxx5fCoBjiP = -1;
		stateMachine.sLp5frPYQ2W.Start(ref stateMachine);
		return stateMachine.sLp5frPYQ2W.Task;
	}

	[AsyncStateMachine(typeof(ppgoSbiHle9cx6cdYw2G<, >))]
	public Task<kxZr9J1TN7RnCavLMQ8b> nQuB6FxXHLm<Mn99IN1TbNhWanPesDce, kxZr9J1TN7RnCavLMQ8b>(nsBdROBMzGNXafCHoKTI<Mn99IN1TbNhWanPesDce, kxZr9J1TN7RnCavLMQ8b> P_0, Mn99IN1TbNhWanPesDce yNVta51TkOfNlbPRQo2n)
	{
		ppgoSbiHle9cx6cdYw2G<Mn99IN1TbNhWanPesDce, kxZr9J1TN7RnCavLMQ8b> stateMachine = default(ppgoSbiHle9cx6cdYw2G<Mn99IN1TbNhWanPesDce, kxZr9J1TN7RnCavLMQ8b>);
		stateMachine.Qxg5fPXGqg4 = AsyncTaskMethodBuilder<kxZr9J1TN7RnCavLMQ8b>.Create();
		stateMachine.FEQ5f3JGryW = this;
		stateMachine.OQD5fFOpkj3 = P_0;
		stateMachine.q6j5fJMZtxf = yNVta51TkOfNlbPRQo2n;
		stateMachine.Wun5fALTks5 = -1;
		stateMachine.Qxg5fPXGqg4.Start(ref stateMachine);
		return stateMachine.Qxg5fPXGqg4.Task;
	}

	public void YIcB63wo63U(long P_0)
	{
		TqavP0xRCyhO04MCVxjk(jPaBM2AtdAP, P_0);
	}

	public long piZB6pUgQ5w()
	{
		return jPaBM2AtdAP.Timestamp;
	}

	public static zNcEmsB68Xq4ncLIIk0v nCGB6ugdkYU(FEdaZIBMYBQiNHglCmuu P_0, C3trUsajJIHJMtdo9pBg P_1)
	{
		return new zNcEmsB68Xq4ncLIIk0v(P_0, P_1);
	}

	static zNcEmsB68Xq4ncLIIk0v()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static int qiFmqGxRV3llyObdxIck(object P_0)
	{
		return ((SkkWKqB642YoCdj0t6sA)P_0).ndMB6sQXR85();
	}

	internal static bool dSoslTxRydx8mYEmt8XO()
	{
		return hqVQIixRTpB3Q1N0rI3y == null;
	}

	internal static zNcEmsB68Xq4ncLIIk0v rPeqhGxRZ5Uh6KuwdvTj()
	{
		return hqVQIixRTpB3Q1N0rI3y;
	}

	internal static void TqavP0xRCyhO04MCVxjk(object P_0, long P_1)
	{
		((SkkWKqB642YoCdj0t6sA)P_0).Timestamp = P_1;
	}
}
