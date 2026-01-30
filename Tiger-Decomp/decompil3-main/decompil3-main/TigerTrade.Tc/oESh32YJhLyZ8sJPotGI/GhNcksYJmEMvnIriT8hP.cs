using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Threading;
using BfZtb759KlUg4482QKym;
using bMLHvPYFoXtORHWAVmNQ;
using HV6pAeY8eH02d7TZENcf;
using iP0kayYJZG0Mb7BTEwGK;
using K1GcsD5GTtMSlaiJI0Xh;
using mkKPCionXtiCx27ydgOR;
using MnHUKJon6hqTd3godF95;
using OksbiPYJ6BBtYQEOwkV3;
using r8oOHiajFPNBXu6XiAHj;
using TigerTrade.Core.Utils.Logging;
using WebSocketSharp;
using WebSocketSharp.Net;
using x97CE55GhEYKgt7TSVZT;

namespace oESh32YJhLyZ8sJPotGI;

internal class GhNcksYJmEMvnIriT8hP
{
	[CompilerGenerated]
	private sealed class plpmFjaVn1phl0cqgCJL
	{
		public GhNcksYJmEMvnIriT8hP o4LaVBRpTyC;

		public TimeSpan IWxaVa1mqvF;

		internal static plpmFjaVn1phl0cqgCJL beJOXsLGAq8bElThjR54;

		public plpmFjaVn1phl0cqgCJL()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal void BxLaVGrU0Hq(object sender, EventArgs args)
		{
			QcjemPLG3BCcsh2tRnWe(o4LaVBRpTyC.wehYF0c0jkC, TimeSpan.FromSeconds(10.0), egh0dRLGFee0DopqawXI(20.0));
			Action<bool> qUqYJFJhdnA = o4LaVBRpTyC.QUqYJFJhdnA;
			int num;
			if (qUqYJFJhdnA == null)
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 != 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			qUqYJFJhdnA(obj: false);
			goto IL_001c;
			IL_001c:
			o4LaVBRpTyC.RcwYFnpODRW = false;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
			{
				num = 0;
			}
			goto IL_0009;
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			default:
				o4LaVBRpTyC.YhUYJ8kCeTj();
				return;
			}
			goto IL_001c;
		}

		internal void UwJaVYnsWLm(object sender, CloseEventArgs e)
		{
			o4LaVBRpTyC.wehYF0c0jkC.Change(-1, -1);
			o4LaVBRpTyC.OJ6YJ3cWAVR(obj: false);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					o4LaVBRpTyC.Q24YF23Wstk = null;
					if (!o4LaVBRpTyC.RcwYFnpODRW)
					{
						Thread.Sleep(1000);
						o4LaVBRpTyC.yPUYJ7fjD8j(IWxaVa1mqvF);
						return;
					}
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
					{
						num = 2;
					}
					break;
				default:
				{
					Action<string> i5xYJJXpFhT = o4LaVBRpTyC.I5xYJJXpFhT;
					if (i5xYJJXpFhT == null)
					{
						goto case 1;
					}
					i5xYJJXpFhT(string.Format((string)uOgYjXLGpBR4GaVp0DJi(-5977659 ^ -5919967), o4LaVBRpTyC.Q24YF23Wstk.Url, e.Reason, e.Code));
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
					{
						num = 1;
					}
					break;
				}
				case 2:
					return;
				}
			}
		}

		internal void AbHaVowQ855(object sender, ErrorEventArgs e)
		{
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Invalid comparison between Unknown and I4
			WebSocket val = (WebSocket)((sender is WebSocket) ? sender : null);
			if (val == null)
			{
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					return;
				}
			}
			if ((int)val.ReadyState != 1)
			{
				return;
			}
			try
			{
				val.CloseAsync();
				Action<string> i5xYJJXpFhT = o4LaVBRpTyC.I5xYJJXpFhT;
				if (i5xYJJXpFhT != null)
				{
					i5xYJJXpFhT(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181305446), val.Url, e.Message));
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
			}
			catch (Exception obj)
			{
				o4LaVBRpTyC.NhWYJuqOEQv(obj);
			}
		}

		internal void L8AaVvJy8NK(object sender, MessageEventArgs e)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (e.IsPing)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
						{
							num2 = 0;
						}
						break;
					}
					try
					{
						o4LaVBRpTyC.uruYJpXffwO(o4LaVBRpTyC, (string)xtKhydLGuH7yZbXPYgfX(e));
						return;
					}
					catch (Exception)
					{
						return;
					}
				case 0:
					return;
				}
			}
		}

		static plpmFjaVn1phl0cqgCJL()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			Y33I7CLGzl5pjlJToHQp();
		}

		internal static bool xXjB3cLGPqXHO6uEpOZb()
		{
			return beJOXsLGAq8bElThjR54 == null;
		}

		internal static plpmFjaVn1phl0cqgCJL EhWQA6LGJrC4q0HL9jbu()
		{
			return beJOXsLGAq8bElThjR54;
		}

		internal static TimeSpan egh0dRLGFee0DopqawXI(double P_0)
		{
			return TimeSpan.FromSeconds(P_0);
		}

		internal static bool QcjemPLG3BCcsh2tRnWe(object P_0, TimeSpan P_1, TimeSpan P_2)
		{
			return ((Timer)P_0).Change(P_1, P_2);
		}

		internal static object uOgYjXLGpBR4GaVp0DJi(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static object xtKhydLGuH7yZbXPYgfX(object P_0)
		{
			return ((MessageEventArgs)P_0).Data;
		}

		internal static void Y33I7CLGzl5pjlJToHQp()
		{
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private readonly Action<string> I5xYJJXpFhT;

	private readonly Action<bool> QUqYJFJhdnA;

	private readonly Action<bool> OJ6YJ3cWAVR;

	private readonly Action<object, string> uruYJpXffwO;

	private readonly Action<Exception> NhWYJuqOEQv;

	private readonly N7ZfoBYFYGRP0RCbl7LV RdgYJz6vnyI;

	private readonly Timer wehYF0c0jkC;

	private WebSocket Q24YF23Wstk;

	private readonly C3trUsajJIHJMtdo9pBg krDYFH3Bmw8;

	private readonly sjYW1CY8LJNwDD6rJjop gl0YFfsbTj4;

	private TimeSpan IcqYF9K8JkD;

	private bool RcwYFnpODRW;

	private readonly string A1mYFGdPsv7;

	private static GhNcksYJmEMvnIriT8hP TRc6noSObpvVu95c6S07;

	public GhNcksYJmEMvnIriT8hP(string P_0, C3trUsajJIHJMtdo9pBg P_1, N7ZfoBYFYGRP0RCbl7LV P_2, sjYW1CY8LJNwDD6rJjop P_3, Action<bool> P_4, Action<bool> P_5, Action<object, string> P_6, Action<string> P_7, Action<Exception> P_8)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		A1mYFGdPsv7 = P_0;
		RdgYJz6vnyI = P_2;
		krDYFH3Bmw8 = P_1;
		gl0YFfsbTj4 = P_3;
		wehYF0c0jkC = new Timer(NFvYJwDQsse, null, -1, -1);
		I5xYJJXpFhT = P_7;
		QUqYJFJhdnA = P_4;
		OJ6YJ3cWAVR = P_5;
		uruYJpXffwO = P_6;
		NhWYJuqOEQv = P_8;
	}

	private void NFvYJwDQsse(object P_0)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected I4, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		WebSocketState valueOrDefault = default(WebSocketState);
		WebSocketState? val = default(WebSocketState?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				WebSocketState? obj;
				object obj2;
				switch (num2)
				{
				default:
					obj = null;
					goto IL_0174;
				case 4:
				{
					switch ((int)valueOrDefault)
					{
					default:
						goto end_IL_0012;
					case 0:
					case 2:
						return;
					case 1:
						break;
					}
					WebSocket q24YF23Wstk = Q24YF23Wstk;
					if (q24YF23Wstk == null)
					{
						num2 = 3;
						continue;
					}
					if (bLDAOASO52t5ICat7Nkx(q24YF23Wstk))
					{
						return;
					}
					goto case 3;
				}
				case 3:
				case 7:
					if (RdgYJz6vnyI != (N7ZfoBYFYGRP0RCbl7LV)1)
					{
						num2 = 6;
						continue;
					}
					obj2 = Yy9I0LSO1LBXBvjEJhrW(0x6EC99CAF ^ 0x6EC8FEE7);
					break;
				case 1:
				{
					WebSocket q24YF23Wstk2 = Q24YF23Wstk;
					if (q24YF23Wstk2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = q24YF23Wstk2.ReadyState;
					goto IL_0174;
				}
				case 5:
					if (val.HasValue)
					{
						valueOrDefault = val.GetValueOrDefault();
						num2 = 4;
						continue;
					}
					goto case 3;
				case 6:
					obj2 = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841531049);
					break;
				case 2:
					{
						eR5YJAWdV5p((string)Yy9I0LSO1LBXBvjEJhrW(-530053095 ^ -529962455));
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_0174:
					val = obj;
					num2 = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				string text = (string)obj2;
				I5xYJJXpFhT?.Invoke((string)Yy9I0LSO1LBXBvjEJhrW(-1848952786 ^ -1849009548) + text + (string)Yy9I0LSO1LBXBvjEJhrW(-2123795572 ^ -2123886104));
				WebSocket q24YF23Wstk3 = Q24YF23Wstk;
				if (q24YF23Wstk3 != null)
				{
					eNA2JrSOSWaWVf26P3jt(q24YF23Wstk3);
				}
				return;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public void yPUYJ7fjD8j(TimeSpan P_0)
	{
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		plpmFjaVn1phl0cqgCJL CS_0024_003C_003E8__locals19 = new plpmFjaVn1phl0cqgCJL();
		CS_0024_003C_003E8__locals19.o4LaVBRpTyC = this;
		CS_0024_003C_003E8__locals19.IWxaVa1mqvF = P_0;
		IcqYF9K8JkD = CS_0024_003C_003E8__locals19.IWxaVa1mqvF;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				try
				{
					Q24YF23Wstk.ConnectAsync();
					return;
				}
				catch (Exception)
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					WebSocket q24YF23Wstk = Q24YF23Wstk;
					if (q24YF23Wstk != null)
					{
						eNA2JrSOSWaWVf26P3jt(q24YF23Wstk);
					}
					return;
				}
			case 3:
				Q24YF23Wstk.OnOpen += delegate
				{
					plpmFjaVn1phl0cqgCJL.QcjemPLG3BCcsh2tRnWe(CS_0024_003C_003E8__locals19.o4LaVBRpTyC.wehYF0c0jkC, TimeSpan.FromSeconds(10.0), plpmFjaVn1phl0cqgCJL.egh0dRLGFee0DopqawXI(20.0));
					Action<bool> qUqYJFJhdnA = CS_0024_003C_003E8__locals19.o4LaVBRpTyC.QUqYJFJhdnA;
					int num3;
					if (qUqYJFJhdnA == null)
					{
						num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 != 0)
						{
							num3 = 1;
						}
						goto IL_0009;
					}
					qUqYJFJhdnA(obj: false);
					goto IL_001c;
					IL_001c:
					CS_0024_003C_003E8__locals19.o4LaVBRpTyC.RcwYFnpODRW = false;
					num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
					{
						num3 = 0;
					}
					goto IL_0009;
					IL_0009:
					switch (num3)
					{
					case 1:
						break;
					default:
						CS_0024_003C_003E8__locals19.o4LaVBRpTyC.YhUYJ8kCeTj();
						return;
					}
					goto IL_001c;
				};
				Q24YF23Wstk.OnClose += delegate(object sender, CloseEventArgs e)
				{
					CS_0024_003C_003E8__locals19.o4LaVBRpTyC.wehYF0c0jkC.Change(-1, -1);
					CS_0024_003C_003E8__locals19.o4LaVBRpTyC.OJ6YJ3cWAVR(obj: false);
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							CS_0024_003C_003E8__locals19.o4LaVBRpTyC.Q24YF23Wstk = null;
							if (!CS_0024_003C_003E8__locals19.o4LaVBRpTyC.RcwYFnpODRW)
							{
								Thread.Sleep(1000);
								CS_0024_003C_003E8__locals19.o4LaVBRpTyC.yPUYJ7fjD8j(CS_0024_003C_003E8__locals19.IWxaVa1mqvF);
								return;
							}
							num3 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
							{
								num3 = 2;
							}
							break;
						default:
						{
							Action<string> i5xYJJXpFhT = CS_0024_003C_003E8__locals19.o4LaVBRpTyC.I5xYJJXpFhT;
							if (i5xYJJXpFhT != null)
							{
								i5xYJJXpFhT(string.Format((string)plpmFjaVn1phl0cqgCJL.uOgYjXLGpBR4GaVp0DJi(-5977659 ^ -5919967), CS_0024_003C_003E8__locals19.o4LaVBRpTyC.Q24YF23Wstk.Url, e.Reason, e.Code));
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 1;
						}
						case 2:
							return;
						}
					}
				};
				num = 4;
				break;
			case 2:
				if (Q24YF23Wstk != null)
				{
					return;
				}
				Q24YF23Wstk = new WebSocket(A1mYFGdPsv7, Array.Empty<string>())
				{
					EmitOnPing = true,
					WaitTime = TimeSpan.FromSeconds(10.0)
				};
				num = 5;
				break;
			case 4:
				Q24YF23Wstk.OnError += delegate(object sender, ErrorEventArgs e)
				{
					//IL_011b: Unknown result type (might be due to invalid IL or missing references)
					//IL_0121: Invalid comparison between Unknown and I4
					WebSocket val = (WebSocket)((sender is WebSocket) ? sender : null);
					if (val == null)
					{
						int num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
						{
							num3 = 1;
						}
						switch (num3)
						{
						case 1:
							return;
						}
					}
					if ((int)val.ReadyState == 1)
					{
						try
						{
							val.CloseAsync();
							Action<string> i5xYJJXpFhT = CS_0024_003C_003E8__locals19.o4LaVBRpTyC.I5xYJJXpFhT;
							if (i5xYJJXpFhT != null)
							{
								i5xYJJXpFhT(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181305446), val.Url, e.Message));
								int num4 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
						}
						catch (Exception obj)
						{
							CS_0024_003C_003E8__locals19.o4LaVBRpTyC.NhWYJuqOEQv(obj);
						}
					}
				};
				Q24YF23Wstk.OnMessage += delegate(object sender, MessageEventArgs e)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							if (!e.IsPing)
							{
								try
								{
									CS_0024_003C_003E8__locals19.o4LaVBRpTyC.uruYJpXffwO(CS_0024_003C_003E8__locals19.o4LaVBRpTyC, (string)plpmFjaVn1phl0cqgCJL.xtKhydLGuH7yZbXPYgfX(e));
									return;
								}
								catch (Exception)
								{
									return;
								}
							}
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				};
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 != 0)
				{
					num = 0;
				}
				break;
			default:
				wehYF0c0jkC.Change(-1, -1);
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
				{
					num = 1;
				}
				break;
			case 5:
				zV7kP3SOLnEOY3cSIQpA(O000wFSOxVuJhb0Bepab(Q24YF23Wstk), SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12);
				if (eRNr3QSOe37PVVkI2kq3(krDYFH3Bmw8))
				{
					Q24YF23Wstk.SetProxy((string)f4eBe0SOsZuKW3foW9pn(krDYFH3Bmw8), krDYFH3Bmw8.OCiaEYswnjC(), krDYFH3Bmw8.Password);
					num = 3;
					break;
				}
				goto case 3;
			}
		}
	}

	private void YhUYJ8kCeTj()
	{
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		try
		{
			int num;
			if (Q24YF23Wstk == null)
			{
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
				{
					num = 3;
				}
				goto IL_0030;
			}
			goto IL_0165;
			IL_004a:
			uURd2dSOcYOQshroTuUq(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--146713930 ^ 0x8BFC268));
			return;
			IL_0165:
			long num2 = default(long);
			string l28Di3kmp6yB8VgWIWcg = default(string);
			if ((int)o7cyG7SOX5nOkACVPZ7g(Q24YF23Wstk) == 1)
			{
				num2 = new MHiHZ4YJRWg1X9TyK3Bf().CORYJMybjlg(IcqYF9K8JkD);
				l28Di3kmp6yB8VgWIWcg = new U6nJD5YJyWwa5cv5aSZn((string)Nf9XdtSOjBBZN1BL4HOE(gl0YFfsbTj4)).rApYJV3AKlB((string)Eolmc0SOEQkU1I58K9Qm(Yy9I0LSO1LBXBvjEJhrW(0x3544E813 ^ 0x35458789), num2));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
				{
					num = 2;
				}
				goto IL_0030;
			}
			goto IL_004a;
			IL_0030:
			oWQhZdonsnfVOePm0yun oWQhZdonsnfVOePm0yun = default(oWQhZdonsnfVOePm0yun);
			while (true)
			{
				switch (num)
				{
				case 3:
					break;
				case 2:
				{
					B6RkkEonRjCRDytEInst[] array = new B6RkkEonRjCRDytEInst[1];
					B6RkkEonRjCRDytEInst obj = new B6RkkEonRjCRDytEInst
					{
						frJonqFrB4S = gl0YFfsbTj4.m7RY86NHZ38
					};
					kxrYptSOQ5vXEM8F3Erk(obj, gl0YFfsbTj4.TfvY8J1FJL0());
					W7IBhaSOdUFNk9t0dwRJ(obj, num2);
					obj.dWqonV8G8M4 = l28Di3kmp6yB8VgWIWcg;
					array[0] = obj;
					oWQhZdonsnfVOePm0yun = new oWQhZdonsnfVOePm0yun(array);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 != 0)
					{
						num = 1;
					}
					continue;
				}
				case 1:
					eR5YJAWdV5p(oWQhZdonsnfVOePm0yun.ToString());
					return;
				default:
					goto IL_0165;
				}
				break;
			}
			goto IL_004a;
		}
		catch (Exception obj2)
		{
			NhWYJuqOEQv(obj2);
		}
	}

	public void Disconnect()
	{
		wehYF0c0jkC.Change(-1, -1);
		RcwYFnpODRW = true;
		WebSocket q24YF23Wstk = Q24YF23Wstk;
		if (q24YF23Wstk == null)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			q24YF23Wstk.CloseAsync();
		}
	}

	public void eR5YJAWdV5p(string P_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (Q24YF23Wstk != null && (int)Q24YF23Wstk.ReadyState == 1)
		{
			H5TjXaSOgoExkqvUA2Ff(Q24YF23Wstk, P_0);
		}
	}

	public void MBsYJPdk1Hr()
	{
		if (RdgYJz6vnyI != (N7ZfoBYFYGRP0RCbl7LV)2)
		{
			eR5YJAWdV5p(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6E2DFBED ^ 0x6E2C8BB3));
			eR5YJAWdV5p(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769D09F5));
			eR5YJAWdV5p(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28B345BB ^ 0x28B234E3));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
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
				eR5YJAWdV5p(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x9F0F634 ^ 0x9F187D2));
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
				{
					num = 1;
				}
			}
		}
		eR5YJAWdV5p((string)Yy9I0LSO1LBXBvjEJhrW(0x4297C3EB ^ 0x4296AC25));
	}

	static GhNcksYJmEMvnIriT8hP()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object Yy9I0LSO1LBXBvjEJhrW(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool bLDAOASO52t5ICat7Nkx(object P_0)
	{
		return ((WebSocket)P_0).IsAlive;
	}

	internal static void eNA2JrSOSWaWVf26P3jt(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static bool OCP84HSONmBSBEhPhW9Y()
	{
		return TRc6noSObpvVu95c6S07 == null;
	}

	internal static GhNcksYJmEMvnIriT8hP LBw26LSOkb8QBYSn3NPd()
	{
		return TRc6noSObpvVu95c6S07;
	}

	internal static object O000wFSOxVuJhb0Bepab(object P_0)
	{
		return ((WebSocket)P_0).SslConfiguration;
	}

	internal static void zV7kP3SOLnEOY3cSIQpA(object P_0, SslProtocols P_1)
	{
		((SslConfiguration)P_0).EnabledSslProtocols = P_1;
	}

	internal static bool eRNr3QSOe37PVVkI2kq3(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).TRAaE0bpPZ4();
	}

	internal static object f4eBe0SOsZuKW3foW9pn(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Url;
	}

	internal static WebSocketState o7cyG7SOX5nOkACVPZ7g(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static void uURd2dSOcYOQshroTuUq(object P_0)
	{
		LogManager.WriteInfo((string)P_0);
	}

	internal static object Nf9XdtSOjBBZN1BL4HOE(object P_0)
	{
		return ((sjYW1CY8LJNwDD6rJjop)P_0).ctTY8I3prMp();
	}

	internal static object Eolmc0SOEQkU1I58K9Qm(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void kxrYptSOQ5vXEM8F3Erk(object P_0, object P_1)
	{
		((B6RkkEonRjCRDytEInst)P_0).Iv7ontmYjlV = (string)P_1;
	}

	internal static void W7IBhaSOdUFNk9t0dwRJ(object P_0, long Bh1tSRkm3lS2Rupkul1q)
	{
		((B6RkkEonRjCRDytEInst)P_0).Timestamp = Bh1tSRkm3lS2Rupkul1q;
	}

	internal static void H5TjXaSOgoExkqvUA2Ff(object P_0, object P_1)
	{
		((WebSocket)P_0).Send((string)P_1);
	}
}
