using System;
using System.Security.Authentication;
using System.Threading;
using bcBiT7aopOi4BIQIfDbH;
using BfZtb759KlUg4482QKym;
using cpsa95aGJriFBY5f9cNY;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Parameters;
using QTLJiyaSDC5spqPa3PT9;
using r8oOHiajFPNBXu6XiAHj;
using VKvOBwavjMOD3lnZn01e;
using WebSocketSharp;
using WebSocketSharp.Net;
using x97CE55GhEYKgt7TSVZT;
using ysbju8aSaDjTbhg64L8I;

namespace AyhGYeavgE38lJQSElev;

internal class l0e90navdXV5uj7Z3LWs
{
	private readonly string djjavy0PxjA;

	private readonly Action<string> dwdavZ9Ljx2;

	private readonly Action BV4avVuYPLc;

	private readonly Action laGavCUc3F4;

	private readonly Action<object, string> x38avrWocdQ;

	private readonly Action<Exception> aSoavKethsS;

	private readonly Timer kiBavmOPk92;

	private WebSocket pRGavhZWt6s;

	private readonly C3trUsajJIHJMtdo9pBg jZqavwKNpRQ;

	private readonly Func<DateTimeOffset> lIeav7Se4Fo;

	private readonly string WcBav8v9MWs;

	private readonly heHRjXavcNFu0DWiuxhe GWYavAIjqrv;

	private bool KhpavPbAetU;

	private bool sI3avJNWM4e;

	internal static l0e90navdXV5uj7Z3LWs MA4IFPxVE6yHVhkIgf8S;

	public l0e90navdXV5uj7Z3LWs(string P_0, I8gStRao3HEONCxvirC9 P_1, C3trUsajJIHJMtdo9pBg P_2, YLWPWdaGPmF6W4OFwnd0 P_3, Func<DateTimeOffset> P_4, Action P_5, Action P_6, Action<object, string> P_7, Action<string> P_8, Action<Exception> P_9)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		djjavy0PxjA = P_0;
		jZqavwKNpRQ = P_2;
		lIeav7Se4Fo = P_4;
		WcBav8v9MWs = P_3.PKpaYn1P4OS;
		byte[] buf = Convert.FromBase64String(P_3.S1vaYvsNZA8());
		GWYavAIjqrv = new heHRjXavcNFu0DWiuxhe(new Ed25519PrivateKeyParameters(buf));
		kiBavmOPk92 = new Timer(SubavRW9alB, null, -1, -1);
		dwdavZ9Ljx2 = P_8;
		BV4avVuYPLc = P_5;
		laGavCUc3F4 = P_6;
		x38avrWocdQ = P_7;
		aSoavKethsS = P_9;
	}

	private void SubavRW9alB(object P_0)
	{
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected I4, but got Unknown
		WebSocket obj = pRGavhZWt6s;
		int num;
		Action<string> action;
		switch ((obj != null) ? new WebSocketState?(cL8RWFxVgA4Pjt8k2VnS(obj)) : ((WebSocketState?)null))
		{
		case (WebSocketState)1L:
		{
			WebSocket obj2 = pRGavhZWt6s;
			if (obj2 == null)
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			if (f2v9cVxVRLxgj1ZTr1qQ(obj2))
			{
				break;
			}
			goto IL_006b;
		}
		case (WebSocketState)0L:
		case (WebSocketState)2L:
			break;
		default:
			goto IL_006b;
			IL_006b:
			action = dwdavZ9Ljx2;
			if (action == null)
			{
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
				{
					num = 2;
				}
			}
			else
			{
				action((string)cvvcHHxV6lc3kddmqRoY(0x7394D272 ^ 0x739539C8));
				num = 5;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					break;
				case 3:
				case 5:
					goto IL_0052;
				case 0:
					return;
				case 1:
					goto IL_006b;
				case 4:
					return;
				}
				break;
				IL_0052:
				WebSocket obj3 = pRGavhZWt6s;
				if (obj3 == null)
				{
					num = 4;
					continue;
				}
				w61dEQxVMrOUDU9FvCvd(obj3);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
				{
					num = 0;
				}
			}
			goto case (WebSocketState)1L;
		}
	}

	public void avfav6dRYTv()
	{
		YYhvE9xVOFQt47yWP9rb(kiBavmOPk92, -1, -1);
		t0HavMFdDNU();
	}

	public void Disconnect()
	{
		KhpavPbAetU = true;
		nJHavOkQv9I();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		laGavCUc3F4?.Invoke();
	}

	private void t0HavMFdDNU()
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_018b: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (pRGavhZWt6s != null && ((int)pRGavhZWt6s.ReadyState == 1 || (int)pRGavhZWt6s.ReadyState == 0))
			{
				return;
			}
			WebSocket val = new WebSocket(djjavy0PxjA, Array.Empty<string>())
			{
				EmitOnPing = true
			};
			ANCo2AxVqbEeG9tJEgBy((object)val, TimeSpan.FromSeconds(10.0));
			pRGavhZWt6s = val;
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					BI377dxVTcWeFXsPEN05(pRGavhZWt6s, new EventHandler(qMNavqLVTqu));
					pRGavhZWt6s.OnClose += hvwavIOW7JI;
					pRGavhZWt6s.OnError += q2MavWCChwV;
					pRGavhZWt6s.OnMessage += LT0avtUYyGe;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
					{
						num = 4;
					}
					break;
				case 1:
					((SslConfiguration)PUSp7QxVIbQSu6GeOMGC(pRGavhZWt6s)).EnabledSslProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;
					num = 2;
					break;
				case 3:
					pRGavhZWt6s.SetProxy((string)R9R8mqxVte7mfE7tUm0w(jZqavwKNpRQ), (string)XDJQ32xVUNyGfOtNfKev(jZqavwKNpRQ), jZqavwKNpRQ.Password);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					if (fXQinwxVWuFkEinTAEJB(jZqavwKNpRQ))
					{
						int num2 = 3;
						num = num2;
						break;
					}
					goto default;
				case 4:
					pRGavhZWt6s.ConnectAsync();
					return;
				}
			}
		}
		catch (Exception obj)
		{
			Action<Exception> action = aSoavKethsS;
			if (action == null)
			{
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
			}
			else
			{
				action(obj);
			}
		}
	}

	private void nJHavOkQv9I()
	{
		try
		{
			int num;
			if (!sI3avJNWM4e)
			{
				Timer timer = kiBavmOPk92;
				if (timer != null)
				{
					timer.Change(-1, -1);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
					{
						num = 0;
					}
					goto IL_0015;
				}
			}
			goto IL_0073;
			IL_0073:
			if (pRGavhZWt6s != null)
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
				{
					num = 0;
				}
				goto IL_0015;
			}
			return;
			IL_0015:
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					pRGavhZWt6s.OnClose -= hvwavIOW7JI;
					pRGavhZWt6s.OnError -= q2MavWCChwV;
					pRGavhZWt6s.OnMessage -= LT0avtUYyGe;
					pRGavhZWt6s.CloseAsync();
					int num2 = 3;
					num = num2;
					continue;
				}
				case 3:
					pRGavhZWt6s = null;
					return;
				case 1:
					break;
				default:
					pRGavhZWt6s.OnOpen -= qMNavqLVTqu;
					num = 2;
					continue;
				}
				break;
			}
			goto IL_0073;
		}
		catch (Exception obj)
		{
			int num3 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
			{
				num3 = 0;
			}
			switch (num3)
			{
			}
			aSoavKethsS?.Invoke(obj);
		}
	}

	private void qMNavqLVTqu(object P_0, EventArgs P_1)
	{
		kiBavmOPk92.Change(TimeSpan.FromSeconds(5.0), TimeSpan.FromSeconds(15.0));
		rk3avUOrDjU();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		BV4avVuYPLc?.Invoke();
	}

	private void hvwavIOW7JI(object P_0, CloseEventArgs P_1)
	{
		Action action = laGavCUc3F4;
		if (action != null)
		{
			dg0fVFxVyyqTvBMRlV4c(action);
		}
		if (!KhpavPbAetU)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			t0HavMFdDNU();
		}
	}

	private void q2MavWCChwV(object P_0, ErrorEventArgs P_1)
	{
		aSoavKethsS?.Invoke(P_1.Exception);
	}

	private void LT0avtUYyGe(object P_0, MessageEventArgs P_1)
	{
		if (P_1.IsPing)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			x38avrWocdQ?.Invoke(this, (string)itX8ZyxVZATh2MXtCW49(P_1));
		}
		catch (Exception obj)
		{
			Action<Exception> action = aSoavKethsS;
			if (action == null)
			{
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				action(obj);
			}
		}
	}

	private void rk3avUOrDjU()
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		try
		{
			if (pRGavhZWt6s == null)
			{
				return;
			}
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
			{
				num = 0;
			}
			string text3 = default(string);
			long num3 = default(long);
			string text4 = default(string);
			string text5 = default(string);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 1:
					if ((int)pRGavhZWt6s.ReadyState != 1)
					{
						return;
					}
					break;
				case 4:
					text3 = num3.ToString();
					num2 = 3;
					goto IL_002c;
				case 5:
				{
					ks3jeEaS4IpYAY11M27j ks3jeEaS4IpYAY11M27j = new ks3jeEaS4IpYAY11M27j();
					ks3jeEaS4IpYAY11M27j.wobaSkYK6sI = ybCTFpaSBe900G1N4E1N.RnlaSiHAqjT;
					ks3jeEaS4IpYAY11M27j.vpZaSSnsNIS = new string[2]
					{
						F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-448941864 ^ -449028942),
						(string)cvvcHHxV6lc3kddmqRoY(0x3E0426F0 ^ 0x3E05CA64)
					};
					ks3jeEaS4IpYAY11M27j.tlIaSeyxh47 = new string[4]
					{
						WcBav8v9MWs,
						text4,
						text3,
						5000.ToString()
					};
					text5 = (string)dspV4fxVrDnmPT5qBCcw(ks3jeEaS4IpYAY11M27j);
					num = 2;
					continue;
				}
				case 2:
					pRGavhZWt6s.Send(text5);
					return;
				case 3:
					{
						string text = (string)cvvcHHxV6lc3kddmqRoY(0x32DEA4F1 ^ 0x32DFD795);
						string text2 = (string)NQnHm8xVVSsZF3dbG5Vj(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--737722733 ^ 0x2BF92D7B), text, text3, 5000);
						text4 = (string)OB3fRbxVCOUMkfU2lxik(GWYavAIjqrv, text2);
						num2 = 5;
						goto IL_002c;
					}
					IL_002c:
					num = num2;
					continue;
				}
				num3 = lIeav7Se4Fo().ToUnixTimeMilliseconds();
				num = 4;
			}
		}
		catch (Exception obj)
		{
			Action<Exception> action = aSoavKethsS;
			if (action == null)
			{
				int num4 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
			else
			{
				action(obj);
			}
		}
	}

	public void b6FavTByi3t()
	{
		if (sI3avJNWM4e)
		{
			return;
		}
		sI3avJNWM4e = true;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc != 0)
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
			nJHavOkQv9I();
			Timer timer = kiBavmOPk92;
			if (timer != null)
			{
				timer.Dispose();
				return;
			}
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
			{
				num = 1;
			}
		}
	}

	static l0e90navdXV5uj7Z3LWs()
	{
		Gd1NgXxVKWEDpgO9goms();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static WebSocketState cL8RWFxVgA4Pjt8k2VnS(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static bool f2v9cVxVRLxgj1ZTr1qQ(object P_0)
	{
		return ((WebSocket)P_0).IsAlive;
	}

	internal static object cvvcHHxV6lc3kddmqRoY(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void w61dEQxVMrOUDU9FvCvd(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static bool tvYqsxxVQvfBBxGaFT4F()
	{
		return MA4IFPxVE6yHVhkIgf8S == null;
	}

	internal static l0e90navdXV5uj7Z3LWs qoKgDIxVdZLBnrV8uKbV()
	{
		return MA4IFPxVE6yHVhkIgf8S;
	}

	internal static bool YYhvE9xVOFQt47yWP9rb(object P_0, int P_1, int P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}

	internal static void ANCo2AxVqbEeG9tJEgBy(object P_0, TimeSpan P_1)
	{
		((WebSocket)P_0).WaitTime = P_1;
	}

	internal static object PUSp7QxVIbQSu6GeOMGC(object P_0)
	{
		return ((WebSocket)P_0).SslConfiguration;
	}

	internal static bool fXQinwxVWuFkEinTAEJB(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).TRAaE0bpPZ4();
	}

	internal static object R9R8mqxVte7mfE7tUm0w(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Url;
	}

	internal static object XDJQ32xVUNyGfOtNfKev(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).OCiaEYswnjC();
	}

	internal static void BI377dxVTcWeFXsPEN05(object P_0, object P_1)
	{
		((WebSocket)P_0).OnOpen += (EventHandler)P_1;
	}

	internal static void dg0fVFxVyyqTvBMRlV4c(object P_0)
	{
		P_0();
	}

	internal static object itX8ZyxVZATh2MXtCW49(object P_0)
	{
		return ((MessageEventArgs)P_0).Data;
	}

	internal static object NQnHm8xVVSsZF3dbG5Vj(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object OB3fRbxVCOUMkfU2lxik(object P_0, object P_1)
	{
		return ((heHRjXavcNFu0DWiuxhe)P_0).rVpavEoqS62((string)P_1);
	}

	internal static object dspV4fxVrDnmPT5qBCcw(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static void Gd1NgXxVKWEDpgO9goms()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
