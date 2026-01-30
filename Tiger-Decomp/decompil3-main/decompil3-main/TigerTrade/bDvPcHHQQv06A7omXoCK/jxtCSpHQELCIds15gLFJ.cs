using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ECOEgqlSad8NUJZ2Dr9n;
using GvSUJ8HQkIZ9hl9rYTHj;
using TuAMtrl1Nd3XoZQQUXf0;
using yfNCRpHQcVf2WUsqGglJ;

namespace bDvPcHHQQv06A7omXoCK;

[Obsolete("Use TigerTrade.Sockets.SocketClient")]
internal sealed class jxtCSpHQELCIds15gLFJ
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct JN6A7cnr3GRRXPGWtgoZ : IAsyncStateMachine
	{
		public int KJBnrpQ6En6;

		public AsyncTaskMethodBuilder<LcoSVPHQNpYgGYLwFlOx> XyQnruC3gdZ;

		public jxtCSpHQELCIds15gLFJ xSOnrze8Bdj;

		public string UranK09Hr1B;

		public int da5nK2IGxiT;

		private TaskAwaiter<TcpClient> NY4nKHbH3RS;

		private static object F402sYNjDLsjwlvKVGSh;

		private void MoveNext()
		{
			int num = KJBnrpQ6En6;
			jxtCSpHQELCIds15gLFJ jxtCSpHQELCIds15gLFJ2 = xSOnrze8Bdj;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
			{
				num2 = 0;
			}
			LcoSVPHQNpYgGYLwFlOx result = default(LcoSVPHQNpYgGYLwFlOx);
			TaskAwaiter<TcpClient> awaiter = default(TaskAwaiter<TcpClient>);
			while (true)
			{
				switch (num2)
				{
				case 1:
					XyQnruC3gdZ.SetResult(result);
					return;
				}
				try
				{
					TcpClient result2;
					try
					{
						if (num != 0)
						{
							int num3 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
							{
								num3 = 1;
							}
							while (true)
							{
								switch (num3)
								{
								default:
									NY4nKHbH3RS = awaiter;
									num3 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									XyQnruC3gdZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 2:
									break;
								case 3:
									awaiter = jxtCSpHQELCIds15gLFJ2.fGnHQgDiB5b(UranK09Hr1B, da5nK2IGxiT).GetAwaiter();
									num3 = 2;
									continue;
								}
								if (awaiter.IsCompleted)
								{
									break;
								}
								num = (KJBnrpQ6En6 = 0);
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
								{
									num3 = 0;
								}
							}
						}
						else
						{
							awaiter = NY4nKHbH3RS;
							NY4nKHbH3RS = default(TaskAwaiter<TcpClient>);
							num = (KJBnrpQ6En6 = -1);
						}
						result2 = awaiter.GetResult();
					}
					catch (Exception ex)
					{
						N3RcEFNjkhV9ku61MOjY(ex);
						throw;
					}
					int num4;
					if (!result2.Connected)
					{
						jgIHQIw5Qo7(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1309555870 ^ -1309324176));
						num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
						{
							num4 = 0;
						}
					}
					else
					{
						num4 = 3;
					}
					while (true)
					{
						switch (num4)
						{
						case 3:
							d5iHQqRoUF5((string)hXMp5hNj55ZVTJKjU4HX(B5BNTbNj1ThHwliCTIrd(0x42D899B5 ^ 0x42DC177D), UranK09Hr1B, da5nK2IGxiT));
							num4 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
							{
								num4 = 2;
							}
							continue;
						case 2:
							jxtCSpHQELCIds15gLFJ2.BDLHQRW3Qw2(result2);
							break;
						case 1:
							goto end_IL_0028;
						}
						result = new LcoSVPHQNpYgGYLwFlOx(result2);
						num4 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
						{
							num4 = 1;
						}
						continue;
						end_IL_0028:
						break;
					}
				}
				catch (Exception exception)
				{
					KJBnrpQ6En6 = -2;
					int num5 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					}
					XyQnruC3gdZ.SetException(exception);
					return;
				}
				KJBnrpQ6En6 = -2;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
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
			XyQnruC3gdZ.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static JN6A7cnr3GRRXPGWtgoZ()
		{
			fNOeWxNjSRsmmmwL99J7();
		}

		internal static void N3RcEFNjkhV9ku61MOjY(object P_0)
		{
			Console.WriteLine(P_0);
		}

		internal static object B5BNTbNj1ThHwliCTIrd(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object hXMp5hNj55ZVTJKjU4HX(object P_0, object P_1, object P_2)
		{
			return string.Format((string)P_0, P_1, P_2);
		}

		internal static bool kYjSeqNjbmRWMcRTvGJj()
		{
			return F402sYNjDLsjwlvKVGSh == null;
		}

		internal static object YmHZ4rNjN7gTx2o8sHKh()
		{
			return F402sYNjDLsjwlvKVGSh;
		}

		internal static void fNOeWxNjSRsmmmwL99J7()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct YtgZlknKfe2YfmAGMgmF : IAsyncStateMachine
	{
		public int zUknK9TnEsU;

		public AsyncTaskMethodBuilder<TcpClient> V0JnKnU1hEZ;

		public string JyDnKG33tcB;

		public int FgknKYOE7UO;

		public jxtCSpHQELCIds15gLFJ QILnKo5J3NV;

		private TcpClient eF3nKvrquiW;

		private int ksHnKBKP5ZX;

		private object s3xnKatU42d;

		private int VmonKiwP2vZ;

		private TaskAwaiter wWxnKlAtmvY;

		private static object FmPfViNjxtLDD87ngpku;

		private void MoveNext()
		{
			int num = zUknK9TnEsU;
			jxtCSpHQELCIds15gLFJ jxtCSpHQELCIds15gLFJ2 = QILnKo5J3NV;
			TcpClient result = default(TcpClient);
			try
			{
				TaskAwaiter awaiter = default(TaskAwaiter);
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = wWxnKlAtmvY;
						wWxnKlAtmvY = default(TaskAwaiter);
						num = (zUknK9TnEsU = -1);
						goto IL_0169;
					}
					num2 = 4;
					goto IL_007b;
				}
				goto IL_0199;
				IL_00b5:
				int num3 = VmonKiwP2vZ;
				if (num3 == 1)
				{
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 != 0)
					{
						num2 = 1;
					}
					goto IL_007b;
				}
				goto IL_03b6;
				IL_03b6:
				s3xnKatU42d = null;
				num2 = 5;
				goto IL_007b;
				IL_0169:
				awaiter.GetResult();
				((ExceptionDispatchInfo)Oe7Hb2NjjypovSrTuQc3((s3xnKatU42d as Exception) ?? throw s3xnKatU42d)).Throw();
				goto IL_03b6;
				IL_007b:
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						break;
					case 8:
						wWxnKlAtmvY = awaiter;
						V0JnKnU1hEZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
					case 10:
						if (ksHnKBKP5ZX >= 1)
						{
							num2 = 11;
							continue;
						}
						if (XpwvTgNjEYJWEnDgpkSV(eF3nKvrquiW) || jxtCSpHQELCIds15gLFJ2.WGuHQWXZaVu.IsCancellationRequested)
						{
							goto case 11;
						}
						goto case 9;
					case 2:
						goto IL_0199;
					case 11:
						result = eF3nKvrquiW;
						num2 = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
						{
							num2 = 7;
						}
						continue;
					case 6:
						goto IL_0382;
					case 5:
						ksHnKBKP5ZX++;
						num2 = 10;
						continue;
					case 4:
						eF3nKvrquiW = new TcpClient();
						ksHnKBKP5ZX = 0;
						num2 = 3;
						continue;
					case 9:
						VmonKiwP2vZ = 0;
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
						{
							num2 = 1;
						}
						continue;
					case 7:
						goto end_IL_006b;
					}
					break;
					IL_0382:
					awaiter = Task.Delay(1000, WLpAdgNjcjtNdfu7AUXw(jxtCSpHQELCIds15gLFJ2.WGuHQWXZaVu)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (zUknK9TnEsU = 1);
						num2 = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto IL_0169;
				}
				goto IL_00b5;
				IL_0199:
				try
				{
					int num4;
					if (num == 0)
					{
						awaiter = wWxnKlAtmvY;
						num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
						{
							num4 = 0;
						}
					}
					else
					{
						eUZANeNjs2WIfFxcUsVj(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325004057));
						awaiter = ((Task)sRwJCUNjXwTMPfkhv1XL(eF3nKvrquiW.Client, qU7HQMA2R4V(ref JyDnKG33tcB), FgknKYOE7UO)).GetAwaiter();
						num4 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
						{
							num4 = 1;
						}
					}
					while (true)
					{
						switch (num4)
						{
						case 2:
							return;
						case 3:
							wWxnKlAtmvY = awaiter;
							V0JnKnU1hEZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num4 = 2;
							break;
						case 1:
							if (!awaiter.IsCompleted)
							{
								num = (zUknK9TnEsU = 0);
								num4 = 3;
								break;
							}
							goto case 4;
						case 4:
							awaiter.GetResult();
							goto end_IL_01a9;
						default:
							wWxnKlAtmvY = default(TaskAwaiter);
							num = (zUknK9TnEsU = -1);
							num4 = 4;
							break;
						}
						continue;
						end_IL_01a9:
						break;
					}
				}
				catch (object obj)
				{
					s3xnKatU42d = obj;
					VmonKiwP2vZ = 1;
					int num5 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto IL_00b5;
				end_IL_006b:;
			}
			catch (Exception exception)
			{
				zUknK9TnEsU = -2;
				eF3nKvrquiW = null;
				V0JnKnU1hEZ.SetException(exception);
				int num6 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				case 0:
					break;
				}
				return;
			}
			zUknK9TnEsU = -2;
			eF3nKvrquiW = null;
			int num7 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
			{
				num7 = 1;
			}
			while (true)
			{
				switch (num7)
				{
				default:
					return;
				case 1:
					V0JnKnU1hEZ.SetResult(result);
					num7 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num7 = 0;
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
			V0JnKnU1hEZ.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static YtgZlknKfe2YfmAGMgmF()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void eUZANeNjs2WIfFxcUsVj(object P_0)
		{
			d5iHQqRoUF5((string)P_0);
		}

		internal static object sRwJCUNjXwTMPfkhv1XL(object P_0, object P_1, int P_2)
		{
			return ((Socket)P_0).q30HQjgdWpq((IPAddress)P_1, P_2);
		}

		internal static CancellationToken WLpAdgNjcjtNdfu7AUXw(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		internal static object Oe7Hb2NjjypovSrTuQc3(object P_0)
		{
			return ExceptionDispatchInfo.Capture((Exception)P_0);
		}

		internal static bool XpwvTgNjEYJWEnDgpkSV(object P_0)
		{
			return ((TcpClient)P_0).Connected;
		}

		internal static bool n7EtMNNjLwjtcFly9T02()
		{
			return FmPfViNjxtLDD87ngpku == null;
		}

		internal static object xOKsUVNjeAuvVpawjZcX()
		{
			return FmPfViNjxtLDD87ngpku;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct V4yvjrnK4F16GvooFWJq : IAsyncStateMachine
	{
		public int DPsnKDwBKY5;

		public AsyncVoidMethodBuilder k8xnKbZFnnF;

		public TcpClient SPBnKNawX6D;

		public jxtCSpHQELCIds15gLFJ dE6nKkPyR0v;

		private NetworkStream vYSnK1Alx0C;

		private LcoSVPHQNpYgGYLwFlOx EhknK5CBbfG;

		private TaskAwaiter<byte[]> WP6nKSjYdHB;

		internal static object erdj8ZNjQlATa3JvdvvA;

		private void MoveNext()
		{
			int num = DPsnKDwBKY5;
			jxtCSpHQELCIds15gLFJ jxtCSpHQELCIds15gLFJ2 = dE6nKkPyR0v;
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
			{
				num2 = 0;
			}
			byte[] result = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				try
				{
					if (num != 0)
					{
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 1:
								goto IL_0371;
							default:
								if (SPBnKNawX6D != null)
								{
									int num4;
									if (SPBnKNawX6D.Connected)
									{
										vYSnK1Alx0C = (NetworkStream)vWOofqNjRVFHUuEq039F(SPBnKNawX6D);
										num4 = 3;
									}
									else
									{
										num4 = 2;
									}
									num3 = num4;
									continue;
								}
								goto end_IL_007e;
							case 2:
								goto end_IL_007e;
							}
							break;
						}
					}
					try
					{
						int num5;
						if (num != 0)
						{
							num5 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
							{
								num5 = 1;
							}
							goto IL_00e3;
						}
						goto IL_02e2;
						IL_00e3:
						switch (num5)
						{
						case 1:
							EhknK5CBbfG = new LcoSVPHQNpYgGYLwFlOx(SPBnKNawX6D);
							break;
						case 2:
							EhknK5CBbfG = null;
							goto end_IL_00be;
						default:
							try
							{
								TaskAwaiter<byte[]> awaiter;
								int num6;
								if (num != 0)
								{
									awaiter = mr1HQ613ONv(vYSnK1Alx0C).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num6 = 3;
										goto IL_019e;
									}
									goto IL_0220;
								}
								goto IL_0256;
								IL_0256:
								awaiter = WP6nKSjYdHB;
								WP6nKSjYdHB = default(TaskAwaiter<byte[]>);
								num = (DPsnKDwBKY5 = -1);
								goto IL_0220;
								IL_0220:
								result = awaiter.GetResult();
								num6 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
								{
									num6 = 0;
								}
								goto IL_019e;
								IL_019e:
								while (true)
								{
									switch (num6)
									{
									default:
										goto end_IL_019e;
									case 2:
										WP6nKSjYdHB = awaiter;
										k8xnKbZFnnF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									case 1:
										break;
									case 3:
										num = (DPsnKDwBKY5 = 0);
										num6 = 2;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
										{
											num6 = 2;
										}
										continue;
									case 0:
										goto end_IL_019e;
									}
									goto IL_0256;
									continue;
									end_IL_019e:
									break;
								}
							}
							catch (Exception ex)
							{
								jgIHQIw5Qo7((string)alhFP3Nj6T05hXgLvW3f(0x32DEA4F1 ^ 0x32DA2B9F), ex);
								goto case 2;
							}
							if (result != null)
							{
								try
								{
									jxtCSpHQELCIds15gLFJ2.T4qHQtYVtMo?.Invoke(result, EhknK5CBbfG);
								}
								catch (Exception ex2)
								{
									jgIHQIw5Qo7((string)alhFP3Nj6T05hXgLvW3f(0x6AB40973 ^ 0x6AB086E3), ex2);
								}
								break;
							}
							goto case 2;
						}
						goto IL_02e2;
						IL_02e2:
						num5 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
						{
							num5 = 0;
						}
						goto IL_00e3;
						end_IL_00be:;
					}
					finally
					{
						if (num < 0 && vYSnK1Alx0C != null)
						{
							ls6Dy4NjMad7O7fhTAI7(vYSnK1Alx0C);
							int num7 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
							{
								num7 = 0;
							}
							switch (num7)
							{
							case 0:
								break;
							}
						}
					}
					goto IL_0371;
					IL_0371:
					vYSnK1Alx0C = null;
					end_IL_007e:;
				}
				catch (Exception exception)
				{
					int num8 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					}
					DPsnKDwBKY5 = -2;
					k8xnKbZFnnF.SetException(exception);
					return;
				}
				DPsnKDwBKY5 = -2;
				k8xnKbZFnnF.SetResult();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
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
			k8xnKbZFnnF.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static V4yvjrnK4F16GvooFWJq()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static object vWOofqNjRVFHUuEq039F(object P_0)
		{
			return ((TcpClient)P_0).GetStream();
		}

		internal static object alhFP3Nj6T05hXgLvW3f(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static void ls6Dy4NjMad7O7fhTAI7(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool gxLBKaNjdhCTRt092SUW()
		{
			return erdj8ZNjQlATa3JvdvvA == null;
		}

		internal static object lMQaBUNjgJWdL48siBB2()
		{
			return erdj8ZNjQlATa3JvdvvA;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct qcj6cBnKxKgKSyknr6Iy : IAsyncStateMachine
	{
		public int r15nKLZSR2M;

		public AsyncTaskMethodBuilder<byte[]> vZwnKetSWqK;

		public Stream GdInKsq5wAu;

		private byte[] QNEnKXltqJL;

		private int ylZnKc7ORUY;

		private byte[] ElUnKjGhSP7;

		private int WECnKE46FHQ;

		private TaskAwaiter<int> RqUnKQfg2W8;

		internal static object W7I6MhNjOg3t9sdFgBSq;

		private void MoveNext()
		{
			int num = r15nKLZSR2M;
			byte[] result2;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 3;
					goto IL_0031;
				}
				goto IL_0336;
				IL_0336:
				TaskAwaiter<int> awaiter = RqUnKQfg2W8;
				RqUnKQfg2W8 = default(TaskAwaiter<int>);
				num2 = 16;
				goto IL_0031;
				IL_0031:
				int result = default(int);
				int num3 = default(int);
				int num4 = default(int);
				while (true)
				{
					switch (num2)
					{
					case 8:
						result = awaiter.GetResult();
						num2 = 4;
						continue;
					case 13:
						awaiter = GdInKsq5wAu.ReadAsync(QNEnKXltqJL, num3, QNEnKXltqJL.Length - num3).GetAwaiter();
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
						{
							num2 = 7;
						}
						continue;
					case 16:
						num = (r15nKLZSR2M = -1);
						num2 = 8;
						continue;
					case 6:
						RqUnKQfg2W8 = default(TaskAwaiter<int>);
						num = (r15nKLZSR2M = -1);
						goto IL_0350;
					case 10:
						WECnKE46FHQ = num3;
						num2 = 13;
						continue;
					case 2:
						if (num3 == 4)
						{
							num2 = 12;
							continue;
						}
						goto case 10;
					case 11:
						num4 = 0;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
						{
							num2 = 0;
						}
						continue;
					case 14:
						result2 = ((num4 == ylZnKc7ORUY) ? ElUnKjGhSP7 : null);
						goto end_IL_0031;
					case 4:
						num3 = WECnKE46FHQ + result;
						goto case 2;
					case 5:
						RqUnKQfg2W8 = awaiter;
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
						{
							num2 = 1;
						}
						continue;
					case 7:
						if (!awaiter.IsCompleted)
						{
							num = (r15nKLZSR2M = 0);
							num2 = 3;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 8;
					default:
						if (num4 != ElUnKjGhSP7.Length)
						{
							WECnKE46FHQ = num4;
							awaiter = GdInKsq5wAu.ReadAsync(ElUnKjGhSP7, num4, ElUnKjGhSP7.Length - num4).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (r15nKLZSR2M = 1);
								RqUnKQfg2W8 = awaiter;
								num2 = 15;
								continue;
							}
							goto IL_0350;
						}
						num2 = 14;
						continue;
					case 12:
						ylZnKc7ORUY = N2lOuENjWA3MgxZM78t4(QNEnKXltqJL, 0);
						ElUnKjGhSP7 = new byte[ylZnKc7ORUY];
						num2 = 11;
						continue;
					case 1:
						vZwnKetSWqK.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 15:
						vZwnKetSWqK.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 9:
						break;
					case 3:
						{
							if (num != 1)
							{
								QNEnKXltqJL = new byte[4];
								num3 = 0;
								num2 = 2;
							}
							else
							{
								awaiter = RqUnKQfg2W8;
								num2 = 6;
							}
							continue;
						}
						IL_0350:
						result = awaiter.GetResult();
						num4 = WECnKE46FHQ + result;
						goto default;
					}
					goto IL_0336;
					continue;
					end_IL_0031:
					break;
				}
			}
			catch (Exception exception)
			{
				r15nKLZSR2M = -2;
				QNEnKXltqJL = null;
				int num5 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
				{
					num5 = 0;
				}
				while (true)
				{
					switch (num5)
					{
					default:
						return;
					case 1:
						ElUnKjGhSP7 = null;
						vZwnKetSWqK.SetException(exception);
						num5 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num5 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
			while (true)
			{
				r15nKLZSR2M = -2;
				int num6 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				case 1:
					continue;
				}
				QNEnKXltqJL = null;
				ElUnKjGhSP7 = null;
				vZwnKetSWqK.SetResult(result2);
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
			vZwnKetSWqK.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static qcj6cBnKxKgKSyknr6Iy()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static int N2lOuENjWA3MgxZM78t4(object P_0, int P_1)
		{
			return BitConverter.ToInt32((byte[])P_0, P_1);
		}

		internal static bool spH8OwNjqoxeqThXQdbV()
		{
			return W7I6MhNjOg3t9sdFgBSq == null;
		}

		internal static object yLBHf3NjIrlh8NeMARWL()
		{
			return W7I6MhNjOg3t9sdFgBSq;
		}
	}

	private readonly CancellationTokenSource WGuHQWXZaVu;

	private readonly Action<byte[], LcoSVPHQNpYgGYLwFlOx> T4qHQtYVtMo;

	private static jxtCSpHQELCIds15gLFJ HfbBo4DdiEkluqhRuJek;

	public jxtCSpHQELCIds15gLFJ(Action<byte[], LcoSVPHQNpYgGYLwFlOx> P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		WGuHQWXZaVu = new CancellationTokenSource();
		base._002Ector();
		T4qHQtYVtMo = P_0;
	}

	[AsyncStateMachine(typeof(JN6A7cnr3GRRXPGWtgoZ))]
	public Task<LcoSVPHQNpYgGYLwFlOx> dTkHQdi6Baj(int P_0, string P_1 = null)
	{
		JN6A7cnr3GRRXPGWtgoZ stateMachine = default(JN6A7cnr3GRRXPGWtgoZ);
		stateMachine.XyQnruC3gdZ = AsyncTaskMethodBuilder<LcoSVPHQNpYgGYLwFlOx>.Create();
		stateMachine.xSOnrze8Bdj = this;
		stateMachine.da5nK2IGxiT = P_0;
		stateMachine.UranK09Hr1B = P_1;
		stateMachine.KJBnrpQ6En6 = -1;
		stateMachine.XyQnruC3gdZ.Start(ref stateMachine);
		return stateMachine.XyQnruC3gdZ.Task;
	}

	[AsyncStateMachine(typeof(YtgZlknKfe2YfmAGMgmF))]
	private Task<TcpClient> fGnHQgDiB5b(string P_0, int P_1)
	{
		YtgZlknKfe2YfmAGMgmF stateMachine = default(YtgZlknKfe2YfmAGMgmF);
		stateMachine.V0JnKnU1hEZ = AsyncTaskMethodBuilder<TcpClient>.Create();
		stateMachine.QILnKo5J3NV = this;
		stateMachine.JyDnKG33tcB = P_0;
		stateMachine.FgknKYOE7UO = P_1;
		stateMachine.zUknK9TnEsU = -1;
		stateMachine.V0JnKnU1hEZ.Start(ref stateMachine);
		return stateMachine.V0JnKnU1hEZ.Task;
	}

	[AsyncStateMachine(typeof(V4yvjrnK4F16GvooFWJq))]
	private void BDLHQRW3Qw2(TcpClient P_0)
	{
		V4yvjrnK4F16GvooFWJq stateMachine = default(V4yvjrnK4F16GvooFWJq);
		stateMachine.k8xnKbZFnnF = AsyncVoidMethodBuilder.Create();
		stateMachine.dE6nKkPyR0v = this;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				stateMachine.DPsnKDwBKY5 = -1;
				stateMachine.k8xnKbZFnnF.Start(ref stateMachine);
				return;
			case 1:
				stateMachine.SPBnKNawX6D = P_0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(qcj6cBnKxKgKSyknr6Iy))]
	private static Task<byte[]> mr1HQ613ONv(Stream P_0)
	{
		qcj6cBnKxKgKSyknr6Iy stateMachine = default(qcj6cBnKxKgKSyknr6Iy);
		stateMachine.vZwnKetSWqK = AsyncTaskMethodBuilder<byte[]>.Create();
		stateMachine.GdInKsq5wAu = P_0;
		stateMachine.r15nKLZSR2M = -1;
		stateMachine.vZwnKetSWqK.Start(ref stateMachine);
		return stateMachine.vZwnKetSWqK.Task;
	}

	private static IPAddress qU7HQMA2R4V(ref string P_0)
	{
		return (IPAddress)ika7dgDdDTWv4CfsP9Tm(P_0 = (string.IsNullOrEmpty(P_0) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45470691) : P_0));
	}

	public void WHVHQO0a5GT()
	{
		WGuHQWXZaVu.Cancel();
	}

	private static void d5iHQqRoUF5(string P_0)
	{
	}

	private static void jgIHQIw5Qo7(string P_0, Exception P_1 = null)
	{
	}

	static jxtCSpHQELCIds15gLFJ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool silgSCDdlX4VVU9QdWuK()
	{
		return HfbBo4DdiEkluqhRuJek == null;
	}

	internal static jxtCSpHQELCIds15gLFJ LRUcBcDd4Y0yYOWAd4K8()
	{
		return HfbBo4DdiEkluqhRuJek;
	}

	internal static object ika7dgDdDTWv4CfsP9Tm(object P_0)
	{
		return IPAddress.Parse((string)P_0);
	}
}
