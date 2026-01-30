using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using F7fL8iY6KuWEb91ZVDrv;
using K1GcsD5GTtMSlaiJI0Xh;
using r19VrrY6urN3CSj6U03f;
using x97CE55GhEYKgt7TSVZT;

namespace GcoFACYM91uS5v8NBEbo;

internal class vgm5qqYMfaCODJqOND6X
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct KsdsKOatb8Bw7UMtsksG : IAsyncStateMachine
	{
		public int sBtatNJLnDJ;

		public AsyncTaskMethodBuilder<MwkhAOY6rI1NhC5OsMmu> UuFatkPds5m;

		public vgm5qqYMfaCODJqOND6X X2Hat1mnKF7;

		public string yXiat58dubh;

		public int bBfatSHmu0Q;

		private TaskAwaiter<TcpClient> wyhatxO9J26;

		internal static object QpaqeRL2LXAlSJP300ND;

		private void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			TcpClient result = default(TcpClient);
			MwkhAOY6rI1NhC5OsMmu result2 = default(MwkhAOY6rI1NhC5OsMmu);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					num3 = sBtatNJLnDJ;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
					{
						num2 = 0;
					}
					continue;
				}
				vgm5qqYMfaCODJqOND6X vgm5qqYMfaCODJqOND6X2 = X2Hat1mnKF7;
				try
				{
					if (num3 == 0)
					{
						goto IL_00b7;
					}
					TaskAwaiter<TcpClient> awaiter = vgm5qqYMfaCODJqOND6X2.FguYMGQ7Ab8(yXiat58dubh, bBfatSHmu0Q).GetAwaiter();
					int num4;
					if (!awaiter.IsCompleted)
					{
						num3 = (sBtatNJLnDJ = 0);
						num4 = 4;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 != 0)
						{
							num4 = 5;
						}
						goto IL_003a;
					}
					goto IL_01a2;
					IL_00b7:
					awaiter = wyhatxO9J26;
					num4 = 2;
					goto IL_003a;
					IL_011b:
					wyhatxO9J26 = default(TaskAwaiter<TcpClient>);
					num3 = (sBtatNJLnDJ = -1);
					goto IL_01a2;
					IL_01a2:
					result = awaiter.GetResult();
					if (!result.Connected)
					{
						num4 = 6;
					}
					else
					{
						vgm5qqYMfaCODJqOND6X2.Log(string.Format((string)rN96W1L2X8cOkKj2jn9P(-2074141628 ^ -2074155272), yXiat58dubh, bBfatSHmu0Q));
						num4 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
						{
							num4 = 0;
						}
					}
					goto IL_003a;
					IL_003a:
					while (true)
					{
						switch (num4)
						{
						default:
							result2 = new MwkhAOY6rI1NhC5OsMmu(result, vgm5qqYMfaCODJqOND6X2.uwVYM1R9Rfr);
							num4 = 7;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
							{
								num4 = 6;
							}
							continue;
						case 4:
							break;
						case 2:
							goto IL_011b;
						case 5:
							wyhatxO9J26 = awaiter;
							UuFatkPds5m.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 3:
						case 6:
							GMgYM4IfwX4(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x12620268 ^ 0x1263F96E));
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							vgm5qqYMfaCODJqOND6X2.ut1YMYcQ0o2(result);
							goto default;
						case 7:
							goto end_IL_002a;
						}
						break;
					}
					goto IL_00b7;
					end_IL_002a:;
				}
				catch (Exception exception)
				{
					sBtatNJLnDJ = -2;
					UuFatkPds5m.SetException(exception);
					int num5 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
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
				sBtatNJLnDJ = -2;
				UuFatkPds5m.SetResult(result2);
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
				{
					num2 = 0;
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
			UuFatkPds5m.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static KsdsKOatb8Bw7UMtsksG()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			i9MV5BL2cbYtnfi3lP6i();
		}

		internal static object rN96W1L2X8cOkKj2jn9P(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool l94qP3L2eS1t1Sl6qCyR()
		{
			return QpaqeRL2LXAlSJP300ND == null;
		}

		internal static object U61GsKL2sZmF5iBcGZRG()
		{
			return QpaqeRL2LXAlSJP300ND;
		}

		internal static void i9MV5BL2cbYtnfi3lP6i()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct SK7nrkatLgVEIpRq7M2t : IAsyncStateMachine
	{
		public int WMqaterAwxM;

		public AsyncTaskMethodBuilder<TcpClient> n4Rats6nZy2;

		public string ixUatXbqEje;

		public int Uh2atcJoJAy;

		public vgm5qqYMfaCODJqOND6X jjvatjhR8LM;

		private TcpClient SeCatE9JwKe;

		private int YNnatQ312kp;

		private int lDQatd2oFh3;

		private TaskAwaiter ly0atgIiXBn;

		internal static object QCVYS8L2juPADXKBagxZ;

		private void MoveNext()
		{
			int num = WMqaterAwxM;
			vgm5qqYMfaCODJqOND6X vgm5qqYMfaCODJqOND6X2 = jjvatjhR8LM;
			TcpClient result;
			try
			{
				if (num == 0)
				{
					goto IL_0115;
				}
				if (num == 1)
				{
					goto IL_026f;
				}
				SeCatE9JwKe = new TcpClient();
				YNnatQ312kp = 0;
				goto IL_0398;
				IL_032f:
				int num2 = default(int);
				YNnatQ312kp = num2 + 1;
				goto IL_0398;
				IL_035d:
				result = SeCatE9JwKe;
				goto end_IL_0028;
				IL_0398:
				int num3;
				if (YNnatQ312kp < 15)
				{
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
					{
						num3 = 0;
					}
					goto IL_0038;
				}
				goto IL_035d;
				IL_031d:
				num2 = YNnatQ312kp;
				num3 = 2;
				goto IL_0038;
				IL_00f2:
				num2 = lDQatd2oFh3;
				if (num2 == 1)
				{
					num3 = 3;
					goto IL_0038;
				}
				goto IL_031d;
				IL_0038:
				TaskAwaiter awaiter = default(TaskAwaiter);
				while (true)
				{
					switch (num3)
					{
					case 4:
						n4Rats6nZy2.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num3 = 9;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
						{
							num3 = 0;
						}
						continue;
					case 9:
						return;
					case 10:
						break;
					default:
						if (!TqhuspL2ddAvgprtXnE4(SeCatE9JwKe) && !hJSeajL2gEnTFHSpNo5N(vgm5qqYMfaCODJqOND6X2.PYcYM5Ny1st))
						{
							goto case 7;
						}
						goto IL_035d;
					case 6:
						goto IL_0115;
					case 1:
						goto IL_026f;
					case 8:
						goto IL_0291;
					case 5:
						goto IL_02a2;
					case 3:
						awaiter = Task.Delay(1000, vgm5qqYMfaCODJqOND6X2.PYcYM5Ny1st.Token).GetAwaiter();
						num3 = 5;
						continue;
					case 7:
						lDQatd2oFh3 = 0;
						num3 = 6;
						continue;
					case 2:
						goto IL_032f;
					}
					break;
					IL_02a2:
					if (!awaiter.IsCompleted)
					{
						num = (WMqaterAwxM = 1);
						ly0atgIiXBn = awaiter;
						num3 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
						{
							num3 = 4;
						}
						continue;
					}
					goto IL_038c;
					IL_0291:
					ly0atgIiXBn = default(TaskAwaiter);
					num = (WMqaterAwxM = -1);
					goto IL_038c;
					IL_038c:
					awaiter.GetResult();
					goto IL_031d;
				}
				goto IL_00f2;
				IL_026f:
				awaiter = ly0atgIiXBn;
				num3 = 8;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
				{
					num3 = 6;
				}
				goto IL_0038;
				IL_0115:
				try
				{
					if (num == 0)
					{
						goto IL_01b6;
					}
					awaiter = qDThctY6paCd6SuDnjQo.cpYYMHZ0vN2(SeCatE9JwKe.Client, Fp2YMlKAudo(ref ixUatXbqEje), Uh2atcJoJAy).GetAwaiter();
					int num4;
					if (!awaiter.IsCompleted)
					{
						num = (WMqaterAwxM = 0);
						ly0atgIiXBn = awaiter;
						n4Rats6nZy2.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num4 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
						{
							num4 = 3;
						}
						goto IL_0125;
					}
					goto IL_0212;
					IL_0125:
					switch (num4)
					{
					case 3:
						return;
					case 2:
						goto IL_01b6;
					case 1:
						goto end_IL_0115;
					}
					ly0atgIiXBn = default(TaskAwaiter);
					num = (WMqaterAwxM = -1);
					goto IL_0212;
					IL_01b6:
					awaiter = ly0atgIiXBn;
					num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
					{
						num4 = 0;
					}
					goto IL_0125;
					IL_0212:
					awaiter.GetResult();
					num4 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
					{
						num4 = 1;
					}
					goto IL_0125;
					end_IL_0115:;
				}
				catch
				{
					lDQatd2oFh3 = 1;
				}
				goto IL_00f2;
				end_IL_0028:;
			}
			catch (Exception exception)
			{
				WMqaterAwxM = -2;
				SeCatE9JwKe = null;
				int num5 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
				n4Rats6nZy2.SetException(exception);
				return;
			}
			while (true)
			{
				WMqaterAwxM = -2;
				SeCatE9JwKe = null;
				n4Rats6nZy2.SetResult(result);
				int num6 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
				{
					num6 = 0;
				}
				switch (num6)
				{
				default:
					return;
				case 1:
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
			n4Rats6nZy2.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static SK7nrkatLgVEIpRq7M2t()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool TqhuspL2ddAvgprtXnE4(object P_0)
		{
			return ((TcpClient)P_0).Connected;
		}

		internal static bool hJSeajL2gEnTFHSpNo5N(object P_0)
		{
			return ((CancellationTokenSource)P_0).IsCancellationRequested;
		}

		internal static bool KGcupFL2EZWjiOT1Qn6l()
		{
			return QCVYS8L2juPADXKBagxZ == null;
		}

		internal static object ReGsELL2Qu3Y3alppoXV()
		{
			return QCVYS8L2juPADXKBagxZ;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct VV5Q9gatRh8lGqG2RGci : IAsyncStateMachine
	{
		public int Suyat6nXcfd;

		public AsyncVoidMethodBuilder tyLatMM0EwZ;

		public TcpClient dyUatOCELS8;

		public vgm5qqYMfaCODJqOND6X uJIatqTXLgw;

		private List<byte> sd7atIZlpTS;

		private NetworkStream PykatWou4Xk;

		private MwkhAOY6rI1NhC5OsMmu tcIattOb6Vk;

		private byte[] EHaatUH8j4X;

		private TaskAwaiter<int> lOSatTdOQAq;

		private static object iBkFmAL2RBd1W9ioZRr3;

		private void MoveNext()
		{
			int num = 2;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter<int> awaiter = default(TaskAwaiter<int>);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				{
					vgm5qqYMfaCODJqOND6X vgm5qqYMfaCODJqOND6X2 = uJIatqTXLgw;
					try
					{
						if (num3 == 0)
						{
							goto IL_009e;
						}
						int num4 = 2;
						while (true)
						{
							switch (num4)
							{
							default:
								goto end_IL_003e;
							case 0:
								goto end_IL_003e;
							case 2:
								if (dyUatOCELS8 == null)
								{
									goto end_IL_003e;
								}
								if (!VySc70L2Oa9K5a1WAMJf(dyUatOCELS8))
								{
									num4 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 3;
							case 1:
								PykatWou4Xk = dyUatOCELS8.GetStream();
								break;
							case 3:
								sd7atIZlpTS = new List<byte>();
								num4 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
								{
									num4 = 1;
								}
								continue;
							}
							goto IL_009e;
							continue;
							end_IL_003e:
							break;
						}
						goto end_IL_0029;
						IL_009e:
						try
						{
							int num5;
							if (num3 == 0)
							{
								awaiter = lOSatTdOQAq;
								lOSatTdOQAq = default(TaskAwaiter<int>);
								num5 = 6;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f != 0)
								{
									num5 = 7;
								}
							}
							else
							{
								tcIattOb6Vk = new MwkhAOY6rI1NhC5OsMmu(dyUatOCELS8, vgm5qqYMfaCODJqOND6X2.uwVYM1R9Rfr);
								num5 = 4;
							}
							while (true)
							{
								switch (num5)
								{
								case 4:
									EHaatUH8j4X = new byte[vgm5qqYMfaCODJqOND6X2.G0AYMk2sgKl];
									num5 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
									{
										num5 = 0;
									}
									continue;
								case 5:
									tyLatMM0EwZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 7:
									num3 = (Suyat6nXcfd = -1);
									num5 = 3;
									continue;
								case 3:
								{
									int result;
									if ((result = awaiter.GetResult()) > 0)
									{
										sd7atIZlpTS.AddRange((IEnumerable<byte>)oi5cgPL2qBHm2nQxrVsb(EHaatUH8j4X, result));
										try
										{
											vgm5qqYMfaCODJqOND6X2.QhPYMoKIH2r(sd7atIZlpTS, tcIattOb6Vk);
										}
										catch (Exception ex)
										{
											GMgYM4IfwX4((string)ig14ydL2IXor6OV8Ijc7(-1325234765 ^ -1325170949), ex);
										}
										break;
									}
									tcIattOb6Vk = null;
									EHaatUH8j4X = null;
									goto end_IL_00ae;
								}
								case 1:
									lOSatTdOQAq = awaiter;
									num5 = 5;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
									{
										num5 = 1;
									}
									continue;
								case 2:
									if (awaiter.IsCompleted)
									{
										goto case 3;
									}
									num3 = (Suyat6nXcfd = 0);
									num5 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
									{
										num5 = 1;
									}
									continue;
								}
								awaiter = YBtYMa29mhC(PykatWou4Xk, EHaatUH8j4X, vgm5qqYMfaCODJqOND6X2.PYcYM5Ny1st.Token).GetAwaiter();
								num5 = 2;
								continue;
								end_IL_00ae:
								break;
							}
						}
						finally
						{
							if (num3 < 0)
							{
								int num6 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								default:
									if (PykatWou4Xk != null)
									{
										((IDisposable)PykatWou4Xk).Dispose();
									}
									break;
								}
							}
						}
						PykatWou4Xk = null;
						end_IL_0029:;
					}
					catch (Exception exception)
					{
						Suyat6nXcfd = -2;
						int num7 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						}
						sd7atIZlpTS = null;
						tyLatMM0EwZ.SetException(exception);
						return;
					}
					Suyat6nXcfd = -2;
					sd7atIZlpTS = null;
					tyLatMM0EwZ.SetResult();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					num3 = Suyat6nXcfd;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
					{
						num2 = 1;
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
			tyLatMM0EwZ.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static VV5Q9gatRh8lGqG2RGci()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			aqDJ9OL2W1JpXBSVs8pS();
		}

		internal static bool VySc70L2Oa9K5a1WAMJf(object P_0)
		{
			return ((TcpClient)P_0).Connected;
		}

		internal static object oi5cgPL2qBHm2nQxrVsb(object P_0, int P_1)
		{
			return IAXYMi785sp((byte[])P_0, P_1);
		}

		internal static object ig14ydL2IXor6OV8Ijc7(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool y5JXuFL261skgexFnOlh()
		{
			return iBkFmAL2RBd1W9ioZRr3 == null;
		}

		internal static object i3KVTnL2MVirt9UyeDYB()
		{
			return iBkFmAL2RBd1W9ioZRr3;
		}

		internal static void aqDJ9OL2W1JpXBSVs8pS()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct xYnrTxaty7aAIuWpcqaB : IAsyncStateMachine
	{
		public int OlSatZfXTxm;

		public AsyncTaskMethodBuilder<int> j9MatVi2C4t;

		public NetworkStream lgSatClqN12;

		public byte[] QN4atrQp8XJ;

		public CancellationToken OxtatK7JddD;

		private TaskAwaiter<int> fVpatm1VOZ3;

		internal static object g4edGZL2tiDspwylYVXH;

		private void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			int result = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = OlSatZfXTxm;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab != 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					try
					{
						TaskAwaiter<int> awaiter;
						int num4;
						if (num3 == 0)
						{
							awaiter = fVpatm1VOZ3;
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
							{
								num4 = 1;
							}
						}
						else
						{
							awaiter = lgSatClqN12.ReadAsync(QN4atrQp8XJ, 0, QN4atrQp8XJ.Length, OxtatK7JddD).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_0166;
							}
							num3 = (OlSatZfXTxm = 0);
							fVpatm1VOZ3 = awaiter;
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
							{
								num4 = 2;
							}
						}
						goto IL_006a;
						IL_006a:
						while (true)
						{
							switch (num4)
							{
							case 2:
								j9MatVi2C4t.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								fVpatm1VOZ3 = default(TaskAwaiter<int>);
								num3 = (OlSatZfXTxm = -1);
								num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
								{
									num4 = 0;
								}
								continue;
							case 3:
								goto end_IL_006a;
							}
							goto IL_0166;
							continue;
							end_IL_006a:
							break;
						}
						goto end_IL_005a;
						IL_0166:
						result = awaiter.GetResult();
						num4 = 3;
						goto IL_006a;
						end_IL_005a:;
					}
					catch (TaskCanceledException)
					{
						goto IL_0051;
					}
					catch (Exception ex2)
					{
						GMgYM4IfwX4(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1251569705 ^ -1251511127), ex2);
						goto IL_0051;
					}
					goto end_IL_0037;
					IL_0051:
					result = 0;
					end_IL_0037:;
				}
				catch (Exception exception)
				{
					OlSatZfXTxm = -2;
					j9MatVi2C4t.SetException(exception);
					int num5 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
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
				OlSatZfXTxm = -2;
				j9MatVi2C4t.SetResult(result);
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
			j9MatVi2C4t.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static xYnrTxaty7aAIuWpcqaB()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool v8rS0cL2UqIOoeMA1vk1()
		{
			return g4edGZL2tiDspwylYVXH == null;
		}

		internal static object oGqwkGL2TSH7jQsFAcXI()
		{
			return g4edGZL2tiDspwylYVXH;
		}
	}

	private readonly int o80YMNn4HOr;

	private readonly int G0AYMk2sgKl;

	private readonly byte[] uwVYM1R9Rfr;

	private readonly CancellationTokenSource PYcYM5Ny1st;

	private readonly Action<List<byte>, MwkhAOY6rI1NhC5OsMmu> etBYMSHkhf1;

	private static vgm5qqYMfaCODJqOND6X vqSwOISepkMykuQBw9P6;

	public vgm5qqYMfaCODJqOND6X(Action<List<byte>, MwkhAOY6rI1NhC5OsMmu> P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		PYcYM5Ny1st = new CancellationTokenSource();
		base._002Ector();
		o80YMNn4HOr = 0;
		G0AYMk2sgKl = 1024;
		etBYMSHkhf1 = P_0;
		uwVYM1R9Rfr = Encoding.Default.GetBytes(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1346994499 ^ -1346950563));
	}

	[AsyncStateMachine(typeof(KsdsKOatb8Bw7UMtsksG))]
	public Task<MwkhAOY6rI1NhC5OsMmu> fpdYMnA0uDf(int P_0, string P_1 = null)
	{
		KsdsKOatb8Bw7UMtsksG stateMachine = default(KsdsKOatb8Bw7UMtsksG);
		stateMachine.UuFatkPds5m = AsyncTaskMethodBuilder<MwkhAOY6rI1NhC5OsMmu>.Create();
		stateMachine.X2Hat1mnKF7 = this;
		stateMachine.bBfatSHmu0Q = P_0;
		stateMachine.yXiat58dubh = P_1;
		stateMachine.sBtatNJLnDJ = -1;
		stateMachine.UuFatkPds5m.Start(ref stateMachine);
		return stateMachine.UuFatkPds5m.Task;
	}

	[AsyncStateMachine(typeof(SK7nrkatLgVEIpRq7M2t))]
	private Task<TcpClient> FguYMGQ7Ab8(string P_0, int P_1)
	{
		SK7nrkatLgVEIpRq7M2t stateMachine = default(SK7nrkatLgVEIpRq7M2t);
		stateMachine.n4Rats6nZy2 = AsyncTaskMethodBuilder<TcpClient>.Create();
		stateMachine.jjvatjhR8LM = this;
		stateMachine.ixUatXbqEje = P_0;
		stateMachine.Uh2atcJoJAy = P_1;
		stateMachine.WMqaterAwxM = -1;
		stateMachine.n4Rats6nZy2.Start(ref stateMachine);
		return stateMachine.n4Rats6nZy2.Task;
	}

	[AsyncStateMachine(typeof(VV5Q9gatRh8lGqG2RGci))]
	private void ut1YMYcQ0o2(TcpClient P_0)
	{
		VV5Q9gatRh8lGqG2RGci stateMachine = default(VV5Q9gatRh8lGqG2RGci);
		stateMachine.tyLatMM0EwZ = zM9SiSSs0UE1EG6cvpLU();
		stateMachine.uJIatqTXLgw = this;
		stateMachine.dyUatOCELS8 = P_0;
		stateMachine.Suyat6nXcfd = -1;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				stateMachine.tyLatMM0EwZ.Start(ref stateMachine);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void QhPYMoKIH2r(List<byte> P_0, MwkhAOY6rI1NhC5OsMmu P_1)
	{
		foreach (List<byte> item in DpqYMvRYouF(P_0, uwVYM1R9Rfr))
		{
			if (item != null)
			{
				try
				{
					etBYMSHkhf1?.Invoke(item, P_1);
				}
				catch (Exception ex)
				{
					GMgYM4IfwX4(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1325234765 ^ -1325149887), ex);
				}
			}
		}
	}

	private static List<List<byte>> DpqYMvRYouF(List<byte> P_0, byte[] P_1)
	{
		List<List<byte>> list = new List<List<byte>>();
		int num = 0;
		byte[] array;
		for (int i = 0; i < P_0.Count; i++)
		{
			if (eyUYMBQ3Pyc(P_0, P_1, i))
			{
				array = new byte[i - num];
				Array.Copy(P_0.ToArray(), num, array, 0, array.Length);
				list.Add(new List<byte>(array));
				num = i + P_1.Length;
				i += P_1.Length - 1;
			}
		}
		array = new byte[P_0.Count - num];
		Array.Copy(P_0.ToArray(), num, array, 0, array.Length);
		P_0.Clear();
		P_0.AddRange(array);
		return list;
	}

	private static bool eyUYMBQ3Pyc(List<byte> P_0, byte[] P_1, int P_2)
	{
		for (int i = 0; i < P_1.Length; i++)
		{
			if (P_2 + i >= P_0.Count || P_0[P_2 + i] != P_1[i])
			{
				return false;
			}
		}
		return true;
	}

	[AsyncStateMachine(typeof(xYnrTxaty7aAIuWpcqaB))]
	private static Task<int> YBtYMa29mhC(NetworkStream P_0, byte[] P_1, CancellationToken P_2)
	{
		xYnrTxaty7aAIuWpcqaB stateMachine = default(xYnrTxaty7aAIuWpcqaB);
		stateMachine.j9MatVi2C4t = AsyncTaskMethodBuilder<int>.Create();
		stateMachine.lgSatClqN12 = P_0;
		stateMachine.QN4atrQp8XJ = P_1;
		stateMachine.OxtatK7JddD = P_2;
		stateMachine.OlSatZfXTxm = -1;
		stateMachine.j9MatVi2C4t.Start(ref stateMachine);
		return stateMachine.j9MatVi2C4t.Task;
	}

	private static byte[] IAXYMi785sp(byte[] P_0, int P_1)
	{
		byte[] array;
		if (P_1 >= P_0.Length)
		{
			while (true)
			{
				array = P_0;
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 != 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					continue;
				}
				break;
			}
		}
		else
		{
			array = new byte[P_1];
			Array.Copy(P_0, array, P_1);
		}
		return array;
	}

	private static IPAddress Fp2YMlKAudo(ref string P_0)
	{
		return IPAddress.Parse(P_0 = (string)(string.IsNullOrEmpty(P_0) ? BUK9ktSs2ZRfgboW4wD3(0x446AB724 ^ 0x446A4B2C) : P_0));
	}

	public void Stop()
	{
		PBtyBfSsHlwggbQXV6EI(PYcYM5Ny1st);
	}

	private void Log(string s, int level = 0)
	{
		if (o80YMNn4HOr >= level)
		{
			Console.WriteLine(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-82860344 ^ -82906124) + s);
		}
	}

	private static void GMgYM4IfwX4(string P_0, Exception P_1 = null)
	{
		Console.WriteLine((string)NDORa9Ssfb6iey51lTpN(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DFF055), P_0, P_1));
	}

	static vgm5qqYMfaCODJqOND6X()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static AsyncVoidMethodBuilder zM9SiSSs0UE1EG6cvpLU()
	{
		return AsyncVoidMethodBuilder.Create();
	}

	internal static bool nVtVk3Seufy7STZ7RSRG()
	{
		return vqSwOISepkMykuQBw9P6 == null;
	}

	internal static vgm5qqYMfaCODJqOND6X zGHa0uSezppLyRY9fUjQ()
	{
		return vqSwOISepkMykuQBw9P6;
	}

	internal static object BUK9ktSs2ZRfgboW4wD3(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void PBtyBfSsHlwggbQXV6EI(object P_0)
	{
		((CancellationTokenSource)P_0).Cancel();
	}

	internal static object NDORa9Ssfb6iey51lTpN(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}
}
