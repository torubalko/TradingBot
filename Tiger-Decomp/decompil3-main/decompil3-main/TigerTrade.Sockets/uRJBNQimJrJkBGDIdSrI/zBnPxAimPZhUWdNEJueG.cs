#define DEBUG
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using aZtLg8ihtqYfMHk8HOH6;
using HExkDCsORifnalUv1owx;
using meTobGihMP9d9Gi9ua6i;
using mV2bWoihsGeLRwn4JdeC;
using qmi5SHihE3KddTVA49Or;
using UxBecVsOUPcejrh1NEnp;
using VDcZaSihxrowDaCDnBT8;
using vGgPQ4s6WEgjxnvUb1Vk;

namespace uRJBNQimJrJkBGDIdSrI;

public class zBnPxAimPZhUWdNEJueG : IDisposable
{
	[CompilerGenerated]
	private sealed class MooG1viw2unkqaN1J3ts
	{
		public SocketAsyncEventArgs hwyiwfGMqUd;

		private static MooG1viw2unkqaN1J3ts hXoJqGsCrn6IQSrLPnrl;

		public MooG1viw2unkqaN1J3ts()
		{
			wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
			base._002Ector();
		}

		internal void kNsiwH6fpnb(object x)
		{
			Socket.CancelConnectAsync(hwyiwfGMqUd);
		}

		static MooG1viw2unkqaN1J3ts()
		{
			qTOVvvsChDj4ZVoFmjso();
			yQ65BOsCwsjJlQa9qyEt();
		}

		internal static bool CmZkSXsCKsaRE6iLxcwn()
		{
			return hXoJqGsCrn6IQSrLPnrl == null;
		}

		internal static MooG1viw2unkqaN1J3ts Q5hrgZsCmXduuc0nHp4W()
		{
			return hXoJqGsCrn6IQSrLPnrl;
		}

		internal static void qTOVvvsChDj4ZVoFmjso()
		{
			qhHWErs6IBu8qtqJbdvd.DI9s6AAreQp();
		}

		internal static void yQ65BOsCwsjJlQa9qyEt()
		{
			vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private ArrayPool<byte> n1RihlPqar3;

	private FDLTIxiheHEviR0wIpW2 P4gih4xNPnM;

	private Socket n9vihDRysfV;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EndPoint xduihb9U22x;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EndPoint Rc7ihN97o9J;

	public EventHandler<SnUrFRihjVvYOFapgiSb> fjQihkHq5YP;

	public EventHandler<IB4lUTih6mtX3FbGl0jS> Fx4ih1f61yI;

	public EventHandler<yuBs7SihWUBNBxlHjnMi> V0tih5i80gn;

	private static zBnPxAimPZhUWdNEJueG QIxOSYsVAUa3UYGseymj;

	[SpecialName]
	[CompilerGenerated]
	public EndPoint TZZihYOcfxm()
	{
		return xduihb9U22x;
	}

	[SpecialName]
	[CompilerGenerated]
	private void UP7ihocuGRf(EndPoint P_0)
	{
		xduihb9U22x = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public EndPoint cYXihBLgsJx()
	{
		return Rc7ihN97o9J;
	}

	[SpecialName]
	[CompilerGenerated]
	private void HeOihanTqHx(EndPoint P_0)
	{
		Rc7ihN97o9J = P_0;
	}

	public zBnPxAimPZhUWdNEJueG(Socket P_0)
	{
		RrWRjssVFBYSP41hZLwH();
		n1RihlPqar3 = ArrayPool<byte>.Create();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_bc6f65dbdb0047aa9f1d1363a50015e2 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				HeOihanTqHx(n9vihDRysfV.RemoteEndPoint);
				return;
			default:
				UP7ihocuGRf(n9vihDRysfV.LocalEndPoint);
				num = 2;
				break;
			case 1:
				n9vihDRysfV = P_0;
				n9vihDRysfV.NoDelay = true;
				n9vihDRysfV.LingerState = new LingerOption(enable: true, 0);
				num = 3;
				break;
			case 3:
				P4gih4xNPnM = FDLTIxiheHEviR0wIpW2.Connected;
				num = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_cf14fc4ab0824770b67d7e35d557d53c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public zBnPxAimPZhUWdNEJueG()
	{
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
		n1RihlPqar3 = ArrayPool<byte>.Create();
		base._002Ector();
		P4gih4xNPnM = (FDLTIxiheHEviR0wIpW2)0;
		int num = 0;
		if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_d76251f1b1c647fca2ebd52fad04e9df == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Dispose()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				n9vihDRysfV?.Dispose();
				return;
			case 1:
				P4gih4xNPnM = (FDLTIxiheHEviR0wIpW2)0;
				num2 = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_50db7e2272684f008131f4368d8cb328 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool SJeimFaHgMk()
	{
		return P4gih4xNPnM == FDLTIxiheHEviR0wIpW2.Connected;
	}

	public void ie1im3eXltv()
	{
		P4gih4xNPnM = (FDLTIxiheHEviR0wIpW2)0;
	}

	private void SWLimpv4Yp1(SocketError P_0, SocketAsyncOperation P_1)
	{
		int num = 1;
		bool flag = default(bool);
		FDLTIxiheHEviR0wIpW2 fDLTIxiheHEviR0wIpW = default(FDLTIxiheHEviR0wIpW2);
		bool flag2 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
				{
					SnUrFRihjVvYOFapgiSb e = new SnUrFRihjVvYOFapgiSb(this, P4gih4xNPnM, P_1, P_0);
					fjQihkHq5YP?.Invoke(this, e);
					return;
				}
				case 7:
					return;
				case 6:
					if (flag)
					{
						num2 = 7;
						continue;
					}
					P4gih4xNPnM = fDLTIxiheHEviR0wIpW;
					num2 = 8;
					continue;
				case 3:
					if (flag2)
					{
						fDLTIxiheHEviR0wIpW = FDLTIxiheHEviR0wIpW2.Connected;
					}
					else if (P_1 == SocketAsyncOperation.Disconnect)
					{
						fDLTIxiheHEviR0wIpW = FDLTIxiheHEviR0wIpW2.Disconnected;
						num2 = 5;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_7cd87f3332884063b7e9b0388cd582e9 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 4;
				case 4:
				case 5:
					flag = P4gih4xNPnM == fDLTIxiheHEviR0wIpW;
					num2 = 6;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_94f9ccceaf224c41bcdf7f8d50844d95 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					flag2 = P_1 == SocketAsyncOperation.Connect;
					num2 = 3;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_4613f38c15aa42aab5d77bb132211696 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					fDLTIxiheHEviR0wIpW = P4gih4xNPnM;
					num2 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_d761ac488ee44ba08d08bd33e017c335 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (P_0 == SocketError.Success)
				{
					num2 = 2;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_d761ac488ee44ba08d08bd33e017c335 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				fDLTIxiheHEviR0wIpW = FDLTIxiheHEviR0wIpW2.Disconnected;
				num = 4;
				break;
			}
		}
	}

	public void RUCimuVuSPW(EndPoint P_0, int P_1 = 2000)
	{
		MooG1viw2unkqaN1J3ts CS_0024_003C_003E8__locals11 = new MooG1viw2unkqaN1J3ts();
		if (SJeimFaHgMk())
		{
			return;
		}
		int num = 6;
		CancellationToken cancellationToken = default(CancellationToken);
		CancellationTokenSource cancellationTokenSource = default(CancellationTokenSource);
		while (true)
		{
			switch (num)
			{
			case 1:
				cancellationToken.Register(delegate
				{
					Socket.CancelConnectAsync(CS_0024_003C_003E8__locals11.hwyiwfGMqUd);
				}, null);
				num = 2;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_1ce727535b1c4b9296c23ed324e0f404 != 0)
				{
					num = 4;
				}
				break;
			case 3:
				CS_0024_003C_003E8__locals11.hwyiwfGMqUd.Completed += Es1imzloMT0;
				CS_0024_003C_003E8__locals11.hwyiwfGMqUd.UserToken = cancellationTokenSource;
				cancellationToken = Ohf60LsVpW4wGbtHRs1m(cancellationTokenSource);
				num = 1;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_56843438bb34482aaf9263e5c70bbdc6 == 0)
				{
					num = 1;
				}
				break;
			default:
				n9vihDRysfV = (Socket)KVmasNsV30P0Pkhb5C3j();
				cancellationTokenSource = new CancellationTokenSource(P_1);
				num = 5;
				break;
			case 4:
				cancellationTokenSource.CancelAfter(P_1);
				num = 2;
				break;
			case 2:
				try
				{
					bool flag = n9vihDRysfV.ConnectAsync(CS_0024_003C_003E8__locals11.hwyiwfGMqUd);
					bool flag2 = !flag;
					int num2 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_94f9ccceaf224c41bcdf7f8d50844d95 != 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					if (flag2)
					{
						Es1imzloMT0(this, CS_0024_003C_003E8__locals11.hwyiwfGMqUd);
					}
					return;
				}
				catch (Exception)
				{
					int num3 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_58c2826f69204559a74e308dfec350ae != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					SWLimpv4Yp1(CS_0024_003C_003E8__locals11.hwyiwfGMqUd.SocketError, CS_0024_003C_003E8__locals11.hwyiwfGMqUd.LastOperation);
					CS_0024_003C_003E8__locals11.hwyiwfGMqUd.Completed -= Es1imzloMT0;
					CUNhq8sVudPCVvrn64B9(CS_0024_003C_003E8__locals11.hwyiwfGMqUd);
					return;
				}
			case 5:
				CS_0024_003C_003E8__locals11.hwyiwfGMqUd = new SocketAsyncEventArgs();
				CS_0024_003C_003E8__locals11.hwyiwfGMqUd.RemoteEndPoint = P_0;
				num = 3;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_d761ac488ee44ba08d08bd33e017c335 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void Es1imzloMT0(object P_0, SocketAsyncEventArgs P_1)
	{
		try
		{
			CancellationTokenSource cancellationTokenSource = s3Q7yhsVzhcwpiIMb3uF(P_1) as CancellationTokenSource;
			int num = 5;
			int num2 = num;
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 4:
					Debug.WriteLine(qhHWErs6IBu8qtqJbdvd.rA7s6znQmFT(--927068468 ^ 0x3741F134), P_1.RemoteEndPoint, P_1.SocketError, CDXxWQsCHiWXmapsM452(P_1));
					return;
				case 6:
					UP7ihocuGRf((EndPoint)K3F0v5sC21BK0KGJU2sH(n9vihDRysfV));
					return;
				case 3:
					if (!flag)
					{
						if (rbwqaEsC0qBPKhDPWNl0(P_1) != SocketError.OperationAborted && rbwqaEsC0qBPKhDPWNl0(P_1) != SocketError.ConnectionAborted)
						{
							return;
						}
						num2 = 3;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_889edb28bdf34d76abb035d3b284c0b9 != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_d0e2307f01854712886bf2a99c5230cf != 0)
						{
							num2 = 1;
						}
					}
					break;
				case 5:
					if (cancellationTokenSource != null)
					{
						cancellationTokenSource.Dispose();
						num2 = 0;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_dd8fdf3c20e345af8fb0f646992cf439 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_3299e82082784282994797f28428b924 == 0)
						{
							num2 = 2;
						}
					}
					break;
				default:
					P_1.UserToken = null;
					if (P_1.LastOperation == SocketAsyncOperation.Connect)
					{
						flag = rbwqaEsC0qBPKhDPWNl0(P_1) == SocketError.Success;
						num2 = 3;
						break;
					}
					return;
				case 1:
					HeOihanTqHx(n9vihDRysfV.RemoteEndPoint);
					num2 = 6;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_cfb1f495ceff49b99d058aba2ed819af == 0)
					{
						num2 = 6;
					}
					break;
				}
			}
		}
		catch (Exception value)
		{
			Debug.WriteLine(value);
		}
		finally
		{
			SWLimpv4Yp1(rbwqaEsC0qBPKhDPWNl0(P_1), P_1.LastOperation);
			P_1.Completed -= Es1imzloMT0;
			int num3 = 0;
			if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_e5c482e8b7954e4db77bcd5c17aa4d7f != 0)
			{
				num3 = 0;
			}
			switch (num3)
			{
			default:
				P_1.Dispose();
				break;
			}
		}
	}

	public void Uufih0NH0H3()
	{
		if (!SJeimFaHgMk())
		{
			return;
		}
		SocketAsyncEventArgs e = new SocketAsyncEventArgs();
		int num = 1;
		if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_9b5b2847d75b462595e85e849a03c955 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				e.Completed += bbAih2PgPyM;
				num = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_ccd4315b44084109ba2d10619dd6de78 == 0)
				{
					num = 0;
				}
				break;
			default:
				num = 2;
				break;
			case 2:
				try
				{
					bool flag = n9vihDRysfV.DisconnectAsync(e);
					int num2 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_bddef78f475044339562b4f01f11b862 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					if (!flag)
					{
						bbAih2PgPyM(this, e);
					}
					return;
				}
				catch (Exception)
				{
					SWLimpv4Yp1(e.SocketError, e.LastOperation);
					int num3 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_1ce727535b1c4b9296c23ed324e0f404 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					e.Completed -= bbAih2PgPyM;
					CUNhq8sVudPCVvrn64B9(e);
					return;
				}
			}
		}
	}

	private void bbAih2PgPyM(object P_0, SocketAsyncEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SWLimpv4Yp1(rbwqaEsC0qBPKhDPWNl0(P_1), P_1.LastOperation);
				num2 = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_52a73a444a3343b4b6530c66da2bce84 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				P_1.Completed -= bbAih2PgPyM;
				CUNhq8sVudPCVvrn64B9(P_1);
				return;
			}
		}
	}

	public void hZfihH3FN0K(string P_0, byte[] P_1)
	{
		int num;
		List<ArraySegment<byte>> bufferList = default(List<ArraySegment<byte>>);
		if (!SJeimFaHgMk())
		{
			num = 0;
			if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_80cb7b5561754813abcc1c8f6314ebfe != 0)
			{
				num = 0;
			}
		}
		else
		{
			bufferList = new List<ArraySegment<byte>>
			{
				new ArraySegment<byte>(BitConverter.GetBytes(P_1.Length)),
				new ArraySegment<byte>(P_1)
			};
			num = 2;
		}
		SocketAsyncEventArgs e = default(SocketAsyncEventArgs);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				e = new SocketAsyncEventArgs();
				uVKocxsCf6ULrIy4k7jK(e, P_0);
				num = 1;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_ab3f5fae347e4b0d9cd301f86d581d5d != 0)
				{
					num = 3;
				}
				break;
			case 1:
				e.Completed += zO3ihfhoxJw;
				try
				{
					if (CApA1EsC94ZpiYtagSYZ(n9vihDRysfV, e))
					{
						return;
					}
					while (true)
					{
						zO3ihfhoxJw(this, e);
						int num2 = 1;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_631ccb82732a44e78536d313b5c4f40d == 0)
						{
							num2 = 1;
						}
						switch (num2)
						{
						case 1:
							return;
						}
					}
				}
				catch (Exception)
				{
					int num3 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_c1f1402763e149dfa62cdba4df48709f == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							CUNhq8sVudPCVvrn64B9(e);
							return;
						}
						vHvZMSsCnEYj9jMUVh5a(n9vihDRysfV);
						SWLimpv4Yp1(e.SocketError, e.LastOperation);
						e.Completed -= zO3ihfhoxJw;
						num3 = 1;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_130d6e0ff71e428dabd0d79852717440 != 0)
						{
							num3 = 0;
						}
					}
				}
			case 3:
				e.BufferList = bufferList;
				num = 1;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_7f27254642ea4e2c87c67f45cec02e25 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void zO3ihfhoxJw(object P_0, SocketAsyncEventArgs P_1)
	{
		SWLimpv4Yp1(rbwqaEsC0qBPKhDPWNl0(P_1), P_1.LastOperation);
		object userToken = P_1.UserToken;
		int num;
		if (userToken == null)
		{
			num = 2;
			if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_9b5b2847d75b462595e85e849a03c955 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		object obj = userToken.ToString();
		goto IL_0139;
		IL_0009:
		string text = default(string);
		int count = default(int);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			default:
			{
				EventHandler<yuBs7SihWUBNBxlHjnMi> v0tih5i80gn = V0tih5i80gn;
				if (v0tih5i80gn == null)
				{
					int num2 = 3;
					num = num2;
					continue;
				}
				v0tih5i80gn(this, new yuBs7SihWUBNBxlHjnMi(this, text, count));
				return;
			}
			case 1:
				if (flag)
				{
					return;
				}
				goto default;
			case 4:
				CUNhq8sVudPCVvrn64B9(P_1);
				flag = !SJeimFaHgMk();
				num = 1;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_05352bfe3fc54bd2af80e635e64c90b4 != 0)
				{
					num = 0;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		obj = null;
		goto IL_0139;
		IL_0139:
		text = (string)obj;
		count = P_1.BufferList[1].Count;
		P_1.Completed -= zO3ihfhoxJw;
		num = 4;
		if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_bc6f65dbdb0047aa9f1d1363a50015e2 != 0)
		{
			num = 2;
		}
		goto IL_0009;
	}

	public void pnEih96fy82()
	{
		if (!SJeimFaHgMk())
		{
			return;
		}
		byte[] array = new byte[4];
		int num = 3;
		if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_52a73a444a3343b4b6530c66da2bce84 == 0)
		{
			num = 2;
		}
		SocketAsyncEventArgs e = default(SocketAsyncEventArgs);
		while (true)
		{
			switch (num)
			{
			default:
				e.Completed += xsPihn8Y3DO;
				num = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_95a1bad6e61f46aa85fc4fba16aff58d == 0)
				{
					num = 1;
				}
				break;
			case 2:
				try
				{
					bool flag = tA0aFZsCYvUH7HeUdkng(n9vihDRysfV, e);
					bool flag2 = !flag;
					int num2 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_8305dafac8c54751b2cf7bcd07fe9ddf == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					if (flag2)
					{
						xsPihn8Y3DO(this, e);
					}
					return;
				}
				catch (Exception)
				{
					int num3 = 1;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_9c7edd7113324b61a1e35f8294ce908c == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							e.Dispose();
							return;
						case 1:
							n9vihDRysfV.Close();
							SWLimpv4Yp1(rbwqaEsC0qBPKhDPWNl0(e), e.LastOperation);
							e.Completed -= xsPihn8Y3DO;
							num3 = 0;
							if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_58c2826f69204559a74e308dfec350ae == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
			case 1:
				num = 2;
				break;
			case 3:
				e = new SocketAsyncEventArgs();
				JqBIKisCG4sjxb4SP51y(e, array, 0, array.Length);
				num = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_da6d90b5adfe470a9697098dd8815488 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void xsPihn8Y3DO(object P_0, SocketAsyncEventArgs P_1)
	{
		SWLimpv4Yp1(P_1.SocketError, P_1.LastOperation);
		P_1.Completed -= xsPihn8Y3DO;
		int num = 8;
		bool flag = default(bool);
		SocketAsyncEventArgs e = default(SocketAsyncEventArgs);
		byte[] array = default(byte[]);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 5:
				if (flag)
				{
					pnEih96fy82();
					return;
				}
				goto case 9;
			case 12:
				if (!SJeimFaHgMk())
				{
					CUNhq8sVudPCVvrn64B9(P_1);
					return;
				}
				goto case 10;
			case 6:
				JqBIKisCG4sjxb4SP51y(e, array, 0, num8);
				num = 3;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_5c99fb2a64f544a485e88f71eb893dcd == 0)
				{
					num = 2;
				}
				break;
			case 8:
				if (P_1.BytesTransferred == 0)
				{
					SWLimpv4Yp1(SocketError.Success, SocketAsyncOperation.Disconnect);
					num = 12;
					break;
				}
				goto case 12;
			case 7:
				P_1.Completed += xsPihn8Y3DO;
				num = 1;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_38dbc7c60ec34ffba98950769d13a289 != 0)
				{
					num = 1;
				}
				break;
			case 11:
				try
				{
					if (!n9vihDRysfV.ReceiveAsync(e))
					{
						XlDihG9rddB(this, e);
						int num6 = 0;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_460dc26359d64d34bada0d3ee4c02ca1 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					return;
				}
				catch (Exception)
				{
					int num7 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_f528d44c04c342058b74b91355406b8a == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							return;
						}
						wU8LwjsCaGDm4iUkahDy(n1RihlPqar3, array, false);
						n9vihDRysfV.Close();
						SWLimpv4Yp1(e.SocketError, e.LastOperation);
						e.Completed -= XlDihG9rddB;
						e.Dispose();
						num7 = 1;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_bb4fc3ed98a04d82903eda6ba4a5a816 == 0)
						{
							num7 = 0;
						}
					}
				}
			case 3:
				e.Completed += XlDihG9rddB;
				num = 3;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_05352bfe3fc54bd2af80e635e64c90b4 == 0)
				{
					num = 11;
				}
				break;
			case 2:
				return;
			case 9:
				array = n1RihlPqar3.Rent(num8);
				e = new SocketAsyncEventArgs();
				num = 6;
				break;
			default:
			{
				int num5 = P_1.Count - P_1.BytesTransferred;
				RKfbpusCB7rKsK80NP9X(P_1, num4, num5);
				num = 7;
				break;
			}
			case 4:
				num4 = nNhm2rsCvfTV9TSbA7oI(P_1) + P_1.BytesTransferred;
				num = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_c08227eb352646a49edcb84910f7cc62 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				try
				{
					if (!n9vihDRysfV.ReceiveAsync(P_1))
					{
						xsPihn8Y3DO(this, P_1);
						int num2 = 0;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_b699df46a9a1469587a7e395f488ca0d != 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
					}
					return;
				}
				catch (Exception)
				{
					vHvZMSsCnEYj9jMUVh5a(n9vihDRysfV);
					SWLimpv4Yp1(P_1.SocketError, CDXxWQsCHiWXmapsM452(P_1));
					P_1.Completed -= xsPihn8Y3DO;
					int num3 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_cbadd15939f941cd8ecc9cc1d66ebd7d != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						P_1.Dispose();
						num3 = 1;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_dd8fdf3c20e345af8fb0f646992cf439 == 0)
						{
							num3 = 1;
						}
					}
				}
			case 10:
			{
				int num9;
				if (P_1.BytesTransferred < J2qZRMsCoFBYGCkil4TI(P_1))
				{
					num9 = 4;
				}
				else
				{
					num8 = BitConverter.ToInt32(P_1.Buffer, 0);
					CUNhq8sVudPCVvrn64B9(P_1);
					flag = num8 < 1;
					num9 = 5;
				}
				num = num9;
				break;
			}
			}
		}
	}

	private void XlDihG9rddB(object P_0, SocketAsyncEventArgs P_1)
	{
		int num = 7;
		int num2 = num;
		bool flag = default(bool);
		bool flag2 = default(bool);
		int offset = default(int);
		int count = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 6:
				P_1.Completed -= XlDihG9rddB;
				if (w7jXKBsCiaDaliEOcxM0(P_1) == 0)
				{
					SWLimpv4Yp1(SocketError.Success, SocketAsyncOperation.Disconnect);
				}
				flag = !SJeimFaHgMk();
				num2 = 1;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_5c99fb2a64f544a485e88f71eb893dcd == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (flag2)
				{
					num2 = 2;
					break;
				}
				goto case 8;
			case 2:
				offset = P_1.Offset + P_1.BytesTransferred;
				num2 = 0;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_cf14fc4ab0824770b67d7e35d557d53c != 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				return;
			case 4:
				P_1.SetBuffer(offset, count);
				P_1.Completed += XlDihG9rddB;
				try
				{
					if (!n9vihDRysfV.ReceiveAsync(P_1))
					{
						int num3 = 0;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_94f9ccceaf224c41bcdf7f8d50844d95 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						}
						XlDihG9rddB(this, P_1);
					}
					return;
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_9595ecc74c7446cdbf3540a0f73178c3 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							SWLimpv4Yp1(P_1.SocketError, CDXxWQsCHiWXmapsM452(P_1));
							P_1.Completed -= XlDihG9rddB;
							P_1.Dispose();
							return;
						}
						n9vihDRysfV.Close();
						num4 = 1;
						if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_c08227eb352646a49edcb84910f7cc62 == 0)
						{
							num4 = 1;
						}
					}
				}
			case 7:
				SWLimpv4Yp1(P_1.SocketError, CDXxWQsCHiWXmapsM452(P_1));
				num2 = 6;
				break;
			case 1:
				if (flag)
				{
					P_1.Dispose();
					num2 = 1;
					if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_da6d90b5adfe470a9697098dd8815488 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 5;
			case 5:
				flag2 = P_1.BytesTransferred < J2qZRMsCoFBYGCkil4TI(P_1);
				num2 = 7;
				if (_003CModule_003E_007Be4da9d67_002De675_002D4930_002D9a1b_002D9e250fabea14_007D.m_9cc33e86f4014331a90ed9f6c0ffce55 != 0)
				{
					num2 = 9;
				}
				break;
			case 8:
			{
				byte[] array = (byte[])gKXcaLsClBFmp2FxKvZl(P_1);
				CUNhq8sVudPCVvrn64B9(P_1);
				Fx4ih1f61yI?.Invoke(this, new IB4lUTih6mtX3FbGl0jS(this, array, J2qZRMsCoFBYGCkil4TI(P_1), n1RihlPqar3));
				pnEih96fy82();
				return;
			}
			default:
				count = P_1.Count - P_1.BytesTransferred;
				num2 = 4;
				break;
			}
		}
	}

	static zBnPxAimPZhUWdNEJueG()
	{
		qhHWErs6IBu8qtqJbdvd.DI9s6AAreQp();
		vgyu2XsOtpI4mGGhk89T.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool AYyAAPsVP7Y3KaJxl85k()
	{
		return QIxOSYsVAUa3UYGseymj == null;
	}

	internal static zBnPxAimPZhUWdNEJueG Iqvb1LsVJMbbqpf9XMMJ()
	{
		return QIxOSYsVAUa3UYGseymj;
	}

	internal static void RrWRjssVFBYSP41hZLwH()
	{
		wWAC1VsOg4Kc82iwFm5G.P20sACplATA();
	}

	internal static object KVmasNsV30P0Pkhb5C3j()
	{
		return bSDfhrihSfAbGTIuQ16h.UyjihLR0voS();
	}

	internal static CancellationToken Ohf60LsVpW4wGbtHRs1m(object P_0)
	{
		return ((CancellationTokenSource)P_0).Token;
	}

	internal static void CUNhq8sVudPCVvrn64B9(object P_0)
	{
		((SocketAsyncEventArgs)P_0).Dispose();
	}

	internal static object s3Q7yhsVzhcwpiIMb3uF(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).UserToken;
	}

	internal static SocketError rbwqaEsC0qBPKhDPWNl0(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).SocketError;
	}

	internal static object K3F0v5sC21BK0KGJU2sH(object P_0)
	{
		return ((Socket)P_0).LocalEndPoint;
	}

	internal static SocketAsyncOperation CDXxWQsCHiWXmapsM452(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).LastOperation;
	}

	internal static void uVKocxsCf6ULrIy4k7jK(object P_0, object P_1)
	{
		((SocketAsyncEventArgs)P_0).UserToken = P_1;
	}

	internal static bool CApA1EsC94ZpiYtagSYZ(object P_0, object P_1)
	{
		return ((Socket)P_0).SendAsync((SocketAsyncEventArgs)P_1);
	}

	internal static void vHvZMSsCnEYj9jMUVh5a(object P_0)
	{
		((Socket)P_0).Close();
	}

	internal static void JqBIKisCG4sjxb4SP51y(object P_0, object P_1, int P_2, int P_3)
	{
		((SocketAsyncEventArgs)P_0).SetBuffer((byte[])P_1, P_2, P_3);
	}

	internal static bool tA0aFZsCYvUH7HeUdkng(object P_0, object P_1)
	{
		return ((Socket)P_0).ReceiveAsync((SocketAsyncEventArgs)P_1);
	}

	internal static int J2qZRMsCoFBYGCkil4TI(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).Count;
	}

	internal static int nNhm2rsCvfTV9TSbA7oI(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).Offset;
	}

	internal static void RKfbpusCB7rKsK80NP9X(object P_0, int P_1, int P_2)
	{
		((SocketAsyncEventArgs)P_0).SetBuffer(P_1, P_2);
	}

	internal static void wU8LwjsCaGDm4iUkahDy(object P_0, object P_1, bool P_2)
	{
		((ArrayPool<byte>)P_0).Return((byte[])P_1, P_2);
	}

	internal static int w7jXKBsCiaDaliEOcxM0(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).BytesTransferred;
	}

	internal static object gKXcaLsClBFmp2FxKvZl(object P_0)
	{
		return ((SocketAsyncEventArgs)P_0).Buffer;
	}
}
