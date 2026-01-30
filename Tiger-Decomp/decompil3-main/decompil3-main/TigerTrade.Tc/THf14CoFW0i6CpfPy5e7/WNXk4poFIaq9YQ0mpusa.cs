using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Threading;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using BqO2H6vvFrkJCXg7C5Zs;
using EyD6NKGhRYBSlyBqPfrJ;
using gQ80RYoF52Cr7su4JSBU;
using hi2fdGv0Bh30qRbPI9Gx;
using ihfFIkvxd9VOYaZTBlHU;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using LPq3llG3QX4HMCBL7b1Q;
using n6CTU9vNZPj1djEEJbvk;
using N9KUA1vvECpB62WMmCyy;
using Newtonsoft.Json;
using OWhORdGzgDWLWxLpUFfx;
using pfZBeCvBNtBvM0761c9j;
using pHIEt6vamhCfP3MCtp7e;
using pvtLeqv0ktrWR5BPVgdc;
using qcQEIyozIMTlUFVYIJis;
using r8oOHiajFPNBXu6XiAHj;
using rr3Q13v2xmu51IulDZia;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using uyZAkjGzbty6fP4YlLSY;
using WebSocketSharp;
using WebSocketSharp.Net;
using x97CE55GhEYKgt7TSVZT;
using yU5DeIv0z3wN70eMiNyC;

namespace THf14CoFW0i6CpfPy5e7;

internal sealed class WNXk4poFIaq9YQ0mpusa : CmNdmgv0NAZRXohrPfUE
{
	private readonly bool B8yo3G4UQSi;

	private static long Usro3Ybidnn;

	private readonly string dYYo3oMPQDy;

	private readonly object nDbo3vpYUHQ;

	private readonly object W70o3B6L1dM;

	[CompilerGenerated]
	private Action<TickEvent> sG5o3aZFkdy;

	[CompilerGenerated]
	private Action<MarketDepthFullEvent> xiTo3i0VHeM;

	[CompilerGenerated]
	private Action<MarketDepthDiffEvent> z3Do3lnNk9y;

	[CompilerGenerated]
	private Action<SecurityEvent> AX3o344Js1f;

	[CompilerGenerated]
	private Action<SecurityEvent> YHHo3DWGrL9;

	[CompilerGenerated]
	private Action<string, bool> CTmo3bKRn1e;

	[CompilerGenerated]
	private Action<Exception> Rk7o3NRHSdC;

	private WebSocket v1lo3k6EAb8;

	private readonly Timer Hjso31pjjuW;

	private readonly Dictionary<string, Rybo1XGzd9ch5SOUQC2H> sFPo35TL2MB;

	private readonly Dictionary<string, iFjyNDv2SEFtUCyPn1e5> LDpo3S3A5F3;

	private readonly Dictionary<string, Security> aYSo3xWIvcm;

	private readonly DateTime WmNo3LADJuP;

	private readonly irk5DKv0uHOdmYbemCNO v9Mo3e0Of3N;

	private readonly fXV5bjozqaQcU9EyR3i4 pboo3sdiqfV;

	private readonly string L0Fo3X4rQsX;

	private readonly yLN4Icv0vK5q17pYNHvp rSJo3cfpkig;

	private C3trUsajJIHJMtdo9pBg nj4o3jcVqtC;

	private bool t1ao3EqU5xB;

	private Action eTVo3QoWFLB;

	private readonly Action<string> waxo3dpbiUy;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> yoKo3gF582m;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> VGvo3ROsenA;

	[CompilerGenerated]
	private long? btRo368TrGy;

	internal static WNXk4poFIaq9YQ0mpusa auqcPmx0hBpbgG8E35XC;

	[SpecialName]
	[CompilerGenerated]
	public void sTolvGsSqbW(Action<TickEvent> P_0)
	{
		Action<TickEvent> action = sG5o3aZFkdy;
		Action<TickEvent> action2;
		do
		{
			action2 = action;
			Action<TickEvent> value = (Action<TickEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref sG5o3aZFkdy, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void L6xlvYWS4y4(Action<TickEvent> P_0)
	{
		Action<TickEvent> action = sG5o3aZFkdy;
		Action<TickEvent> action2;
		do
		{
			action2 = action;
			Action<TickEvent> value = (Action<TickEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref sG5o3aZFkdy, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void puvloJ4L5Eq(Action<MarketDepthFullEvent> P_0)
	{
		Action<MarketDepthFullEvent> action = xiTo3i0VHeM;
		Action<MarketDepthFullEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthFullEvent> value = (Action<MarketDepthFullEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref xiTo3i0VHeM, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void QvFloFlJ5cR(Action<MarketDepthFullEvent> P_0)
	{
		Action<MarketDepthFullEvent> action = xiTo3i0VHeM;
		Action<MarketDepthFullEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthFullEvent> value = (Action<MarketDepthFullEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref xiTo3i0VHeM, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ikolopXNCnV(Action<MarketDepthDiffEvent> P_0)
	{
		Action<MarketDepthDiffEvent> action = z3Do3lnNk9y;
		Action<MarketDepthDiffEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthDiffEvent> value = (Action<MarketDepthDiffEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref z3Do3lnNk9y, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void PuelouGmXeq(Action<MarketDepthDiffEvent> P_0)
	{
		Action<MarketDepthDiffEvent> action = z3Do3lnNk9y;
		Action<MarketDepthDiffEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthDiffEvent> value = (Action<MarketDepthDiffEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref z3Do3lnNk9y, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void iS7lvoQZRBo(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = AX3o344Js1f;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref AX3o344Js1f, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void T83lvvVSHpP(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = AX3o344Js1f;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref AX3o344Js1f, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void HvElvatNnkM(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = YHHo3DWGrL9;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref YHHo3DWGrL9, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void auRlviFMnLp(Action<SecurityEvent> P_0)
	{
		Action<SecurityEvent> action = YHHo3DWGrL9;
		Action<SecurityEvent> action2;
		do
		{
			action2 = action;
			Action<SecurityEvent> value = (Action<SecurityEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref YHHo3DWGrL9, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void lK1lv00pgeu(Action<string, bool> P_0)
	{
		Action<string, bool> action = CTmo3bKRn1e;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref CTmo3bKRn1e, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void YLDlv2bKTEJ(Action<string, bool> P_0)
	{
		Action<string, bool> action = CTmo3bKRn1e;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref CTmo3bKRn1e, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void FZrlvfRH5vZ(Action<Exception> P_0)
	{
		Action<Exception> action = Rk7o3NRHSdC;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref Rk7o3NRHSdC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void DRFlv9K5tCP(Action<Exception> P_0)
	{
		Action<Exception> action = Rk7o3NRHSdC;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref Rk7o3NRHSdC, value, action2);
		}
		while ((object)action != action2);
	}

	public WNXk4poFIaq9YQ0mpusa(irk5DKv0uHOdmYbemCNO P_0, fXV5bjozqaQcU9EyR3i4 P_1, string P_2, yLN4Icv0vK5q17pYNHvp P_3, C3trUsajJIHJMtdo9pBg P_4, Action P_5, Action<string> P_6, string P_7)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		B8yo3G4UQSi = Convert.ToBoolean(ConfigurationManager.AppSettings[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1325234765 ^ -1325140001)]);
		nDbo3vpYUHQ = new object();
		W70o3B6L1dM = new object();
		sFPo35TL2MB = new Dictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		LDpo3S3A5F3 = new Dictionary<string, iFjyNDv2SEFtUCyPn1e5>();
		aYSo3xWIvcm = new Dictionary<string, Security>();
		yoKo3gF582m = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		VGvo3ROsenA = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		base._002Ector();
		dYYo3oMPQDy = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461949456 ^ -1461905044), Interlocked.Increment(ref Usro3Ybidnn), P_3, P_7);
		WmNo3LADJuP = new DateTime(1970, 1, 1);
		v9Mo3e0Of3N = P_0;
		pboo3sdiqfV = P_1;
		L0Fo3X4rQsX = P_2;
		rSJo3cfpkig = P_3;
		nj4o3jcVqtC = P_4;
		eTVo3QoWFLB = P_5;
		waxo3dpbiUy = P_6;
		Hjso31pjjuW = new Timer(J17oFtHYf29, null, -1, -1);
	}

	private void J17oFtHYf29(object P_0)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		WebSocket obj = v1lo3k6EAb8;
		if (obj != null && (int)obj.ReadyState == 0)
		{
			return;
		}
		WebSocket obj2 = v1lo3k6EAb8;
		int num;
		if (obj2 == null || (int)yvkbMYx08H9G765Y7Nl0(obj2) != 2)
		{
			WebSocket obj3 = v1lo3k6EAb8;
			if (obj3 != null && (int)yvkbMYx08H9G765Y7Nl0(obj3) == 1)
			{
				WebSocket obj4 = v1lo3k6EAb8;
				if (obj4 == null)
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
					{
						num = 0;
					}
					goto IL_0009;
				}
				if (obj4.IsAlive)
				{
					return;
				}
			}
			goto IL_004b;
		}
		num = 3;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 1:
			break;
		case 0:
			return;
		case 3:
			return;
		case 2:
			return;
		}
		goto IL_004b;
		IL_004b:
		KgRoFukkImv((string)hD5y0Sx0AqZQZXj77aw2(0x24B0B9E6 ^ 0x24B1CB5E));
		WebSocket obj5 = v1lo3k6EAb8;
		if (obj5 == null)
		{
			int num2 = 2;
			num = num2;
		}
		else
		{
			OTx4ewx0PjOeQohGVSsp(obj5);
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
			{
				num = 0;
			}
		}
		goto IL_0009;
	}

	public void lihlfMp6ULY()
	{
		MrGoFUTxxlX();
	}

	public void Disconnect()
	{
		EB5oFTdlqdN();
	}

	private void MrGoFUTxxlX()
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0180: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (v1lo3k6EAb8 != null && ((int)v1lo3k6EAb8.ReadyState == 1 || (int)paXEtYx0JyI2X24G3VKk(v1lo3k6EAb8) == 0))
			{
				return;
			}
			LDpo3S3A5F3.Clear();
			WebSocket val = new WebSocket(L0Fo3X4rQsX, Array.Empty<string>())
			{
				EmitOnPing = true
			};
			em5Eqqx0F9GJMwwuGcQa((object)val, TimeSpan.FromSeconds(10.0));
			v1lo3k6EAb8 = val;
			((SslConfiguration)V2bAN6x03klqCSsuunxg(v1lo3k6EAb8)).EnabledSslProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;
			int num;
			if (nj4o3jcVqtC.TRAaE0bpPZ4())
			{
				num = 6;
				goto IL_001b;
			}
			goto IL_00b1;
			IL_00b1:
			v1lo3k6EAb8.OnOpen += dIkoFpfj8nj;
			num = 2;
			goto IL_001b;
			IL_001b:
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					return;
				case 6:
					break;
				case 4:
					LMVdIkx22iCeJjARFSrf(Hjso31pjjuW, WLoSjyx20cV8iXEyUnYS(5.0), TimeSpan.FromSeconds(30.0));
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
					{
						num = 0;
					}
					continue;
				case 5:
					v1lo3k6EAb8.OnError += DZFoFFDa1H8;
					v1lo3k6EAb8.OnMessage += oWjoFCuPXuw;
					num2 = 4;
					goto IL_0017;
				case 2:
					v1lo3k6EAb8.OnClose += mhXoF3aLECU;
					num2 = 5;
					goto IL_0017;
				case 1:
					{
						v1lo3k6EAb8.ConnectAsync();
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
						{
							num = 2;
						}
						continue;
					}
					IL_0017:
					num = num2;
					continue;
				}
				break;
			}
			EPH7mKx0zDxOGKTrNoAk(v1lo3k6EAb8, DMlZ6Px0pxFgJeAcHnNZ(nj4o3jcVqtC), nj4o3jcVqtC.OCiaEYswnjC(), DU8Wn2x0uVH9bgP52dVD(nj4o3jcVqtC));
			goto IL_00b1;
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	private void EB5oFTdlqdN()
	{
		try
		{
			Usro3Ybidnn = 0L;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
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
				t1ao3EqU5xB = true;
				eTVo3QoWFLB = null;
				WebSocket obj = v1lo3k6EAb8;
				if (obj == null)
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
					{
						num = 1;
					}
					continue;
				}
				obj.CloseAsync();
				return;
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	[SpecialName]
	public bool jxxoFz3c69q()
	{
		return sMY4Aux2HUTGe8WgWUTy(yoKo3gF582m) < 100;
	}

	[SpecialName]
	public bool xPto32rpyhf()
	{
		return yoKo3gF582m.Count == 0;
	}

	public bool sPMoFypDtEv(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		return yoKo3gF582m.TryAdd((string)xC3Chcx2fqjeMNhDKY8u(P_0), P_0);
	}

	public bool B6IoFZKrwUA(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		yoKo3gF582m.TryRemove(P_0.Code, out var _);
		return VGvo3ROsenA.TryAdd((string)xC3Chcx2fqjeMNhDKY8u(P_0), P_0);
	}

	public void qODoFVi92DO()
	{
		if (yoKo3gF582m.Any() || VGvo3ROsenA.Any())
		{
			oW1lYsReHKK(yoKo3gF582m.Values.Union(VGvo3ROsenA.Values).ToArray());
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		u54iojx29m7ZcOUN2OSG(VGvo3ROsenA);
	}

	private void oWjoFCuPXuw(object P_0, MessageEventArgs P_1)
	{
		try
		{
			JkYoFrIyQAV(P_1.Data);
		}
		catch (Exception message)
		{
			Log(P_1.Data, show: false);
			Log(message);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	private void JkYoFrIyQAV(string P_0)
	{
		try
		{
			lbU0JXvvJlEkX1KaqiEM lbU0JXvvJlEkX1KaqiEM = mFYoFK6AjLX(P_0);
			if (lbU0JXvvJlEkX1KaqiEM.Message == (string)hD5y0Sx0AqZQZXj77aw2(-1251569705 ^ -1251534941))
			{
				return;
			}
			string text = default(string);
			rN00GsvxQSbLyKga7xJY rN00GsvxQSbLyKga7xJY = default(rN00GsvxQSbLyKga7xJY);
			List<iXmPhYvvjFjXiQS9owCn>.Enumerator enumerator = default(List<iXmPhYvvjFjXiQS9owCn>.Enumerator);
			while (!string.IsNullOrEmpty(lbU0JXvvJlEkX1KaqiEM.y5Zvv3Kejaa()))
			{
				int num = 5;
				while (true)
				{
					switch (num)
					{
					case 2:
						if (!(text == (string)hD5y0Sx0AqZQZXj77aw2(-2056710528 ^ -2056745410)) && !(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3E0426F0 ^ 0x3E05BE2C)))
						{
							if (!(text == (string)hD5y0Sx0AqZQZXj77aw2(--927068468 ^ 0x374069C8)))
							{
								return;
							}
							goto default;
						}
						goto IL_03a9;
					case 4:
						return;
					case 8:
						break;
					case 3:
					{
						if (text == (string)hD5y0Sx0AqZQZXj77aw2(-2123795572 ^ -2123890554))
						{
							rN00GsvxQSbLyKga7xJY = SyAoFmPnAOT(P_0);
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
							{
								num = 6;
							}
							continue;
						}
						if (!oF4dirx2nv9f7iNYM8dx(text, hD5y0Sx0AqZQZXj77aw2(0x5EA8FF2A ^ 0x5EA967AC)))
						{
							if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xAD5B8B3 ^ 0xAD42013)))
							{
								num = 2;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
								{
									num = 2;
								}
								continue;
							}
							goto IL_03a9;
						}
						using List<PK8l0XvBbkbPqwEYHd9S>.Enumerator enumerator2 = d3AoF7iIx7A(P_0).GetEnumerator();
						while (enumerator2.MoveNext())
						{
							PK8l0XvBbkbPqwEYHd9S current3 = enumerator2.Current;
							ROHoF83Ppd9(current3);
						}
						int num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					default:
						enumerator = odeoFhWSLSS(P_0, lbU0JXvvJlEkX1KaqiEM.y5Zvv3Kejaa(), lbU0JXvvJlEkX1KaqiEM.Type).GetEnumerator();
						num = 7;
						continue;
					case 1:
						try
						{
							while (enumerator.MoveNext())
							{
								iXmPhYvvjFjXiQS9owCn current2 = enumerator.Current;
								MvSoFwYQGrO(current2);
							}
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
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
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					case 6:
						FTQoFPuIhBI(rN00GsvxQSbLyKga7xJY);
						num = 4;
						continue;
					case 5:
						text = lbU0JXvvJlEkX1KaqiEM.y5Zvv3Kejaa();
						num = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
						{
							num = 3;
						}
						continue;
					case 7:
						{
							try
							{
								while (enumerator.MoveNext())
								{
									iXmPhYvvjFjXiQS9owCn current = enumerator.Current;
									AaQoFJpHfde(current);
								}
								int num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
								{
									num2 = 0;
								}
								switch (num2)
								{
								case 0:
									break;
								}
								return;
							}
							finally
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
						IL_03a9:
						enumerator = odeoFhWSLSS(P_0, (string)URkpQrx2GBr7NFQSbL7l(lbU0JXvvJlEkX1KaqiEM), (string)ebl8V0x2YALrJ7gTU5IO(lbU0JXvvJlEkX1KaqiEM)).GetEnumerator();
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	private lbU0JXvvJlEkX1KaqiEM mFYoFK6AjLX(string P_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		lbU0JXvvJlEkX1KaqiEM lbU0JXvvJlEkX1KaqiEM = new lbU0JXvvJlEkX1KaqiEM();
		JsonTextReader val = new JsonTextReader((TextReader)new StringReader(P_0));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				string text = string.Empty;
				int num2 = 4;
				int num3 = num2;
				string[] array = default(string[]);
				string text2 = default(string);
				JsonToken val2 = default(JsonToken);
				while (true)
				{
					switch (num3)
					{
					case 7:
						return lbU0JXvvJlEkX1KaqiEM;
					case 8:
						array = (string[])q5nBo4x2Bbg1jFYtEsYe(text2, new char[1] { '.' });
						num3 = 6;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
						{
							num3 = 3;
						}
						break;
					case 4:
						if (!((JsonReader)val).Read())
						{
							num3 = 7;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
							{
								num3 = 1;
							}
						}
						else
						{
							val2 = zxFod6x2oMSffgCpG7Bh(val);
							num3 = 3;
						}
						break;
					case 1:
						if ((int)val2 != 9)
						{
							goto case 4;
						}
						text2 = exd3gVx2vKnbKDdys1wY(val).ToString();
						if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-837284864 ^ -837184234))
						{
							goto case 8;
						}
						goto IL_0144;
					default:
						lbU0JXvvJlEkX1KaqiEM.Type = text2;
						goto case 4;
					case 5:
						if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-962524685 ^ -962466813))
						{
							aRG4kdx2ijkntvyFFHtA(lbU0JXvvJlEkX1KaqiEM, text2);
						}
						if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1435596783 ^ -1435519797))
						{
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 4;
					case 3:
						if ((int)val2 == 4)
						{
							text = ((JsonReader)val).Value.ToString();
							goto case 4;
						}
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
						{
							num3 = 1;
						}
						break;
					case 2:
						jTQUfAx2axjbgOUxfETt(lbU0JXvvJlEkX1KaqiEM, text2);
						goto case 5;
					case 6:
						{
							lbU0JXvvJlEkX1KaqiEM.ErmvvpCpXVb((array[0] == (string)hD5y0Sx0AqZQZXj77aw2(-838841832 ^ -838741188)) ? (array[0] + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2D313048 ^ 0x2D307EA2) + array[1]) : array[0]);
							lbU0JXvvJlEkX1KaqiEM.Symbol = ((array[0] == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1325234765 ^ -1325196137)) ? array[2] : array[1]);
							goto IL_0144;
						}
						IL_0144:
						if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x68DEE0F ^ 0x68D0BD1)))
						{
							num3 = 5;
							break;
						}
						goto case 2;
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	private rN00GsvxQSbLyKga7xJY SyAoFmPnAOT(string P_0)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Invalid comparison between Unknown and I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Invalid comparison between Unknown and I4
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Invalid comparison between Unknown and I4
		int num = 1;
		int num2 = num;
		rN00GsvxQSbLyKga7xJY rN00GsvxQSbLyKga7xJY = default(rN00GsvxQSbLyKga7xJY);
		string text2 = default(string);
		uint num5 = default(uint);
		JsonToken tokenType = default(JsonToken);
		while (true)
		{
			switch (num2)
			{
			case 1:
				rN00GsvxQSbLyKga7xJY = null;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
				{
					num2 = 0;
				}
				continue;
			}
			JsonTextReader val = new JsonTextReader((TextReader)new StringReader(P_0));
			try
			{
				string text = string.Empty;
				int num3 = 17;
				while (true)
				{
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 45:
							if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x42D899B5 ^ 0x42D9039D)))
							{
								goto case 1;
							}
							goto case 46;
						case 20:
							if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x741B85CB ^ 0x741A1C5B))
							{
								rN00GsvxQSbLyKga7xJY.blTvxrjMlyB = double.Parse(text2, CultureInfo.InvariantCulture);
								goto case 1;
							}
							num4 = 34;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
							{
								num4 = 18;
							}
							continue;
						case 32:
							if (num5 <= 725274920)
							{
								if (num5 == 24483660)
								{
									goto case 20;
								}
								if (num5 != 725274920)
								{
									goto case 1;
								}
								goto case 40;
							}
							if (num5 == 959523216)
							{
								if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-962524685 ^ -962555809)))
								{
									num4 = 30;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
									{
										num4 = 15;
									}
									continue;
								}
								goto case 6;
							}
							num3 = 21;
							break;
						case 29:
							if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181307570)))
							{
								num4 = 33;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
								{
									num4 = 30;
								}
								continue;
							}
							rN00GsvxQSbLyKga7xJY.N10vxZ21YGP = double.Parse(text2, (IFormatProvider)abhf2dx241HRFUZck4jf());
							goto case 1;
						case 5:
							if (!oF4dirx2nv9f7iNYM8dx(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x130FEA25 ^ 0x130F0CD3)))
							{
								goto case 1;
							}
							rN00GsvxQSbLyKga7xJY.OhFvL5g8sQX = RsOU3fx2DHCxHLvEgCWY(text2, CultureInfo.InvariantCulture);
							num4 = 2;
							continue;
						case 28:
							if ((int)tokenType != 1)
							{
								num3 = 4;
								break;
							}
							if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1009517961 ^ -1009616059))
							{
								num4 = 9;
								continue;
							}
							goto case 1;
						case 4:
							if ((int)tokenType == 4)
							{
								text = ((JsonReader)val).Value.ToString();
								num4 = 16;
								continue;
							}
							if ((int)tokenType != 9)
							{
								goto case 1;
							}
							goto case 31;
						case 25:
							if (num5 <= 1539611856)
							{
								num4 = 32;
								continue;
							}
							if (num5 > 2043718814)
							{
								if (num5 == 2052638631)
								{
									goto case 29;
								}
								if (num5 != 2695095205u)
								{
									num4 = 28;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
									{
										num4 = 38;
									}
									continue;
								}
								if (oF4dirx2nv9f7iNYM8dx(text, hD5y0Sx0AqZQZXj77aw2(-1774602229 ^ -1774706383)))
								{
									rN00GsvxQSbLyKga7xJY.tKQvxIXxyxM = text2;
								}
								goto case 1;
							}
							num4 = 44;
							continue;
						case 9:
							rN00GsvxQSbLyKga7xJY = new rN00GsvxQSbLyKga7xJY();
							goto case 1;
						case 37:
							if (num5 <= 2866701442u)
							{
								if (num5 != 2764748191u)
								{
									if (num5 == 2866701442u)
									{
										goto case 45;
									}
									goto case 1;
								}
								goto case 19;
							}
							if (num5 == 3421039731u)
							{
								if (text == (string)hD5y0Sx0AqZQZXj77aw2(-673683647 ^ -673579331))
								{
									rN00GsvxQSbLyKga7xJY.Cj0vLN7qAxk = RsOU3fx2DHCxHLvEgCWY(text2, abhf2dx241HRFUZck4jf());
									num4 = 14;
									continue;
								}
								num4 = 8;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
								{
									num4 = 15;
								}
							}
							else
							{
								num4 = 6;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
								{
									num4 = 26;
								}
							}
							continue;
						case 12:
							if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1309555870 ^ -1309584170)))
							{
								num4 = 41;
								continue;
							}
							goto default;
						case 21:
							if (num5 == 1539611856)
							{
								goto case 5;
							}
							goto case 1;
						case 11:
							if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC806BD)))
							{
								goto case 1;
							}
							goto case 7;
						case 35:
							num5 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
							if (num5 <= 2695095205u)
							{
								num4 = 25;
								continue;
							}
							goto case 24;
						case 27:
							rN00GsvxQSbLyKga7xJY.AskSize = RsOU3fx2DHCxHLvEgCWY(text2, CultureInfo.InvariantCulture);
							goto case 1;
						case 22:
							if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--927068468 ^ 0x374068D6))
							{
								rN00GsvxQSbLyKga7xJY.sAQvL4EjCbg = double.Parse(text2, CultureInfo.InvariantCulture);
							}
							goto case 1;
						case 48:
							if (num5 != 4168637004u)
							{
								num4 = 39;
								continue;
							}
							goto case 11;
						case 43:
							if (!string.IsNullOrEmpty(text2))
							{
								num4 = 35;
								continue;
							}
							goto case 1;
						case 1:
						case 2:
						case 8:
						case 14:
						case 15:
						case 16:
						case 17:
						case 18:
						case 23:
						case 30:
						case 33:
						case 34:
						case 36:
						case 38:
						case 39:
						case 41:
						case 42:
						case 47:
							if (!z9dtEdx2N7aJA6KiyK7q(val))
							{
								return rN00GsvxQSbLyKga7xJY;
							}
							goto case 3;
						case 24:
							if (num5 > 3706424872u)
							{
								if (num5 > 4168637004u)
								{
									if (num5 == 4184124930u)
									{
										goto case 22;
									}
									if (num5 != 4292379550u || !(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7EE977)))
									{
										goto case 1;
									}
									rN00GsvxQSbLyKga7xJY.AskPrice = double.Parse(text2, (IFormatProvider)abhf2dx241HRFUZck4jf());
									num4 = 8;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
									{
										num4 = 6;
									}
									continue;
								}
								if (num5 != 4093333969u)
								{
									num4 = 48;
									continue;
								}
								goto case 10;
							}
							num3 = 37;
							break;
						case 44:
							if (num5 != 1659126361)
							{
								if (num5 == 2043718814)
								{
									goto case 12;
								}
							}
							else if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--500511424 ^ 0x1DD4ABB4))
							{
								rN00GsvxQSbLyKga7xJY.hWIvxU0fQCA = double.Parse(text2, (IFormatProvider)abhf2dx241HRFUZck4jf());
								num4 = 42;
								continue;
							}
							goto case 1;
						case 31:
							text2 = ((JsonReader)val).Value.ToString();
							num4 = 43;
							continue;
						case 19:
							if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461292091 ^ -1461196285))
							{
								rN00GsvxQSbLyKga7xJY.OpenInterest = double.Parse(text2, (IFormatProvider)abhf2dx241HRFUZck4jf());
								num4 = 11;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
								{
									num4 = 18;
								}
							}
							else
							{
								num4 = 47;
							}
							continue;
						case 46:
							rN00GsvxQSbLyKga7xJY.BidSize = double.Parse(text2, (IFormatProvider)abhf2dx241HRFUZck4jf());
							goto case 1;
						case 6:
							rN00GsvxQSbLyKga7xJY.kdnvxhCDaIS = double.Parse(text2, CultureInfo.InvariantCulture);
							goto case 1;
						case 7:
							rN00GsvxQSbLyKga7xJY.BidPrice = RsOU3fx2DHCxHLvEgCWY(text2, CultureInfo.InvariantCulture);
							num4 = 11;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
							{
								num4 = 36;
							}
							continue;
						case 10:
							if (oF4dirx2nv9f7iNYM8dx(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x22BF43FC ^ 0x22BEC218)))
							{
								OxJ05Ox2lsTExj8tYVYl(rN00GsvxQSbLyKga7xJY, text2);
								goto case 1;
							}
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
							{
								num4 = 1;
							}
							continue;
						case 40:
							if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB14E238))
							{
								goto case 27;
							}
							goto case 1;
						case 3:
							tokenType = ((JsonReader)val).TokenType;
							num4 = 28;
							continue;
						case 13:
							if (oF4dirx2nv9f7iNYM8dx(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x315AB1E3 ^ 0x315B2B85)))
							{
								rN00GsvxQSbLyKga7xJY.UlOvLLap3Oh = G9H2G8x2bZvvo4alACNW(text2, CultureInfo.InvariantCulture);
							}
							goto case 1;
						case 26:
							if (num5 != 3706424872u)
							{
								num4 = 23;
								continue;
							}
							goto case 13;
						default:
							rN00GsvxQSbLyKga7xJY.LastPrice = double.Parse(text2, (IFormatProvider)abhf2dx241HRFUZck4jf());
							goto case 1;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	private List<iXmPhYvvjFjXiQS9owCn> odeoFhWSLSS(string P_0, string P_1, string P_2)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected I4, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		List<iXmPhYvvjFjXiQS9owCn> list = new List<iXmPhYvvjFjXiQS9owCn>();
		string text = string.Empty;
		JsonTextReader val = new JsonTextReader((TextReader)new StringReader(P_0));
		try
		{
			string text2 = string.Empty;
			iXmPhYvvjFjXiQS9owCn iXmPhYvvjFjXiQS9owCn = null;
			List<double[]> list2 = new List<double[]>();
			double[] array = new double[2];
			while (((JsonReader)val).Read())
			{
				JsonToken tokenType = ((JsonReader)val).TokenType;
				switch (tokenType - 1)
				{
				case 3:
					text2 = ((JsonReader)val).Value.ToString();
					continue;
				case 1:
					if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-203064540 ^ -203035352)))
					{
						if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2BD86B18 ^ 0x2BD9EA86))
						{
							if (list2.Count == 0)
							{
								iXmPhYvvjFjXiQS9owCn.oxVvvVaf8Ui = new List<double[]>();
								list2 = new List<double[]>();
							}
							else
							{
								array = new double[2];
							}
						}
					}
					else if (list2.Count == 0)
					{
						iXmPhYvvjFjXiQS9owCn.OvXvvKIZbP8 = new List<double[]>();
						list2 = new List<double[]>();
					}
					else
					{
						array = new double[2];
					}
					continue;
				case 0:
					if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7EF279))
					{
						text = text2;
					}
					if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-690510723 ^ -690608817))
					{
						iXmPhYvvjFjXiQS9owCn = new iXmPhYvvjFjXiQS9owCn();
						int num = P_1?.LastIndexOf('.') ?? (-1);
						if (num > -1 && num + 1 < P_1.Length && int.TryParse(P_1.Substring(num + 1), out var result))
						{
							iXmPhYvvjFjXiQS9owCn.VsIvvdgga03(result);
						}
						iXmPhYvvjFjXiQS9owCn.hrmvv6erh2T(string.Equals(P_2, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1736566656 ^ -1736479884), StringComparison.OrdinalIgnoreCase));
						list.Add(iXmPhYvvjFjXiQS9owCn);
					}
					continue;
				case 8:
				{
					string text3 = ((JsonReader)val).Value.ToString();
					if (string.IsNullOrEmpty(text3))
					{
						continue;
					}
					if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5CD4F15 ^ 0x5CDD919)))
					{
						if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2017337494 ^ -2017435916)))
						{
							if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-673683647 ^ -673674515))
							{
								iXmPhYvvjFjXiQS9owCn.Symbol = text3;
							}
						}
						else if (array[0] == 0.0)
						{
							array[0] = double.Parse(text3, CultureInfo.InvariantCulture);
						}
						else
						{
							array[1] = double.Parse(text3, CultureInfo.InvariantCulture);
						}
					}
					else if (array[0] == 0.0)
					{
						array[0] = double.Parse(text3, CultureInfo.InvariantCulture);
					}
					else
					{
						array[1] = double.Parse(text3, CultureInfo.InvariantCulture);
					}
					continue;
				}
				case 6:
					if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5EA8FF2A ^ 0x5EA97EA6))
					{
						iXmPhYvvjFjXiQS9owCn.MHlvvIDCXg9 = (long)((JsonReader)val).Value;
					}
					continue;
				case 2:
				case 4:
				case 5:
				case 7:
					continue;
				}
				if ((int)tokenType != 14)
				{
					continue;
				}
				if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DE32FD)))
				{
					if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5EA8FF2A ^ 0x5EA97EB4))
					{
						if (array.First() != 0.0)
						{
							list2.Add(array);
							array = new double[2];
						}
						else if (list2.Count > 0)
						{
							iXmPhYvvjFjXiQS9owCn.oxVvvVaf8Ui.AddRange(list2);
							list2 = new List<double[]>();
						}
					}
				}
				else if (array.First() != 0.0)
				{
					list2.Add(array);
					array = new double[2];
				}
				else
				{
					iXmPhYvvjFjXiQS9owCn.OvXvvKIZbP8.AddRange(list2);
					list2 = new List<double[]>();
				}
			}
			return list;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void MvSoFwYQGrO(iXmPhYvvjFjXiQS9owCn P_0)
	{
		int num = 4;
		Rybo1XGzd9ch5SOUQC2H value = default(Rybo1XGzd9ch5SOUQC2H);
		Symbol symbol = default(Symbol);
		MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (!value.E07GzJKBNZY)
					{
						return;
					}
					symbol = value.Symbol;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					if (!jvYg86x2kcBYyWdefIwx(P_0))
					{
						return;
					}
					LDpo3S3A5F3[P_0.Symbol] = new iFjyNDv2SEFtUCyPn1e5(P_0, symbol);
					goto end_IL_0012;
				case 1:
					if (LDpo3S3A5F3.ContainsKey(P_0.Symbol))
					{
						goto end_IL_0012;
					}
					if (P_0.TRYvvQD2dU5() == 1000)
					{
						num2 = 2;
						break;
					}
					return;
				case 6:
				{
					marketDepthFullEvent.Version.vNpG3X8YCxF();
					NjsVaOx21ZWIlDFJo7TE(LDpo3S3A5F3[symbol.Code], symbol, marketDepthFullEvent);
					Action<MarketDepthFullEvent> action = xiTo3i0VHeM;
					if (action == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c != 0)
						{
							num2 = 0;
						}
						break;
					}
					action(marketDepthFullEvent);
					return;
				}
				case 4:
					if (sFPo35TL2MB.TryGetValue(P_0.Symbol, out value))
					{
						num2 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 5:
					return;
				case 0:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			LDpo3S3A5F3[P_0.Symbol].pRhv2LxJjIa(P_0, symbol);
			marketDepthFullEvent = IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk(symbol);
			num = 6;
		}
	}

	private List<PK8l0XvBbkbPqwEYHd9S> d3AoF7iIx7A(string P_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		List<PK8l0XvBbkbPqwEYHd9S> list = new List<PK8l0XvBbkbPqwEYHd9S>();
		string text = string.Empty;
		JsonTextReader val = new JsonTextReader((TextReader)new StringReader(P_0));
		try
		{
			string text2 = string.Empty;
			PK8l0XvBbkbPqwEYHd9S pK8l0XvBbkbPqwEYHd9S = null;
			while (((JsonReader)val).Read())
			{
				JsonToken tokenType = ((JsonReader)val).TokenType;
				if ((int)tokenType <= 4)
				{
					if ((int)tokenType != 1)
					{
						if ((int)tokenType == 4)
						{
							text2 = ((JsonReader)val).Value.ToString();
						}
						continue;
					}
					if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DF25C3))
					{
						text = text2;
					}
					if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1799510641 ^ -1799609155))
					{
						pK8l0XvBbkbPqwEYHd9S = new PK8l0XvBbkbPqwEYHd9S();
						list.Add(pK8l0XvBbkbPqwEYHd9S);
					}
				}
				else if ((int)tokenType != 7)
				{
					if ((int)tokenType != 9)
					{
						continue;
					}
					string text3 = ((JsonReader)val).Value.ToString();
					if (string.IsNullOrEmpty(text3))
					{
						continue;
					}
					if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2002318893 ^ -2002262913)))
					{
						if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-82860344 ^ -82958502)))
						{
							if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2D3134C9 ^ 0x2D30B549)))
							{
								if (!(text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xAD5B8B3 ^ 0xAD5EA8D)))
								{
									if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1583344314 ^ -1583288068))
									{
										pK8l0XvBbkbPqwEYHd9S.U9tvBQ31JiT = text3 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1962651919 ^ -1962552199);
									}
								}
								else
								{
									pK8l0XvBbkbPqwEYHd9S.Quantity = double.Parse(text3, CultureInfo.InvariantCulture);
								}
							}
							else
							{
								pK8l0XvBbkbPqwEYHd9S.Price = double.Parse(text3, CultureInfo.InvariantCulture);
							}
						}
						else
						{
							pK8l0XvBbkbPqwEYHd9S.TradeId = text3;
						}
					}
					else
					{
						pK8l0XvBbkbPqwEYHd9S.Symbol = text3;
					}
				}
				else if (text2 == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-338769610 ^ -338696348))
				{
					pK8l0XvBbkbPqwEYHd9S.Timestamp = (long)((JsonReader)val).Value;
				}
			}
			return list;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void ROHoF83Ppd9(PK8l0XvBbkbPqwEYHd9S P_0)
	{
		try
		{
			if (!sFPo35TL2MB.TryGetValue(P_0.Symbol, out var value))
			{
				return;
			}
			Symbol symbol = default(Symbol);
			TickEvent tickEvent = default(TickEvent);
			int num;
			if (value.m54GzFaRoc7)
			{
				symbol = value.Symbol;
				tickEvent = IlvHiXGF9pA6U4gUK5bq.yxVGF4IeGkY(symbol);
				tickEvent.Price = symbol.GetShortPrice(JxYyljx25AdFNlFRcEtT(P_0));
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
				{
					num = 1;
				}
			}
			else
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				default:
					C9SHgRx2x5oA80JS4iQu(tickEvent, symbol.GetShortSize(P_0.Quantity));
					num = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
					{
						num = 4;
					}
					break;
				case 3:
					sG5o3aZFkdy?.Invoke(tickEvent);
					return;
				case 1:
					tv98Cfx2SGoM6UNf0vRl(tickEvent, VXWoFAmuiY2(P_0.Timestamp));
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
					{
						num = 0;
					}
					break;
				case 4:
					tickEvent.Side = ((!rYYKXKx2LoZwp27e4jXs(P_0)) ? Side.Sell : Side.Buy);
					num = 3;
					break;
				}
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	private DateTime VXWoFAmuiY2(long P_0)
	{
		return WmNo3LADJuP.AddMilliseconds(P_0);
	}

	private void FTQoFPuIhBI(rN00GsvxQSbLyKga7xJY P_0)
	{
		try
		{
			if (!sFPo35TL2MB.TryGetValue(P_0.Symbol, out var value) || !value.kHYGzP3WQN1)
			{
				return;
			}
			Symbol symbol = value.Symbol;
			int num;
			if (!aYSo3xWIvcm.ContainsKey(P_0.Symbol))
			{
				aYSo3xWIvcm[P_0.Symbol] = new Security(symbol);
				num = 17;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 != 0)
				{
					num = 6;
				}
			}
			else
			{
				num = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
				{
					num = 7;
				}
			}
			double? num4 = default(double?);
			Security security2 = default(Security);
			long? num3 = default(long?);
			DateTimeOffset dateTimeOffset = default(DateTimeOffset);
			DateTime dateTime = default(DateTime);
			long? num6 = default(long?);
			while (true)
			{
				int num5;
				long num2;
				switch (num)
				{
				case 10:
					num4 = P_0.sAQvL4EjCbg;
					if (num4.HasValue)
					{
						num = 21;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
						{
							num = 1;
						}
						break;
					}
					goto case 2;
				case 25:
					if (num4.HasValue)
					{
						num = 22;
						break;
					}
					goto IL_04ad;
				case 21:
				{
					Security security5 = security2;
					num4 = P_0.sAQvL4EjCbg;
					eZrbxKx2X9hHcSuI9jSe(security5, (long)num4.Value);
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
					{
						num = 2;
					}
					break;
				}
				case 14:
					security2.BidSize = symbol.GetShortSize(P_0.BidSize.Value);
					goto IL_03c4;
				case 13:
					security2.AskSize = symbol.GetShortSize(P_0.AskSize.Value);
					goto IL_00fe;
				case 7:
				case 17:
					security2 = aYSo3xWIvcm[P_0.Symbol];
					if (P_0.LastPrice.HasValue)
					{
						security2.LastPrice = symbol.GetShortPrice(P_0.LastPrice.Value);
					}
					num4 = P_0.hWIvxU0fQCA;
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
					{
						num = 4;
					}
					break;
				case 20:
					if (num3.HasValue)
					{
						num5 = 11;
						goto IL_0024;
					}
					goto case 6;
				case 19:
					if (num4.HasValue)
					{
						Security security3 = security2;
						num4 = P_0.Cj0vLN7qAxk;
						security3.Volume = (long)num4.Value;
						num = 26;
						break;
					}
					goto case 26;
				case 3:
					if (P_0.kdnvxhCDaIS.HasValue)
					{
						Dt30C5x2sbU4iObFLYeJ(security2, P_0.kdnvxhCDaIS.Value);
					}
					num4 = P_0.Cj0vLN7qAxk;
					num = 19;
					break;
				case 2:
					num4 = P_0.BidPrice;
					num = 25;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
					{
						num = 14;
					}
					break;
				case 23:
					UETH72GzDcyNAirT5ahJ.E09GzekvJKi().gZNGzNGhYT9(symbol.ID, security2.FundingRate, P_0.UlOvLLap3Oh);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
					{
						num = 16;
					}
					break;
				case 18:
					if (Mv5o3faNP6X().HasValue)
					{
						goto IL_053a;
					}
					goto case 16;
				case 15:
				{
					Security security7 = security2;
					num4 = P_0.hWIvxU0fQCA;
					security7.OpenPrice = num4.Value;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 != 0)
					{
						num = 0;
					}
					break;
				}
				case 26:
					if (P_0.OpenInterest.HasValue)
					{
						Security security4 = security2;
						num4 = P_0.OpenInterest;
						security4.OpenInt = (long)num4.Value;
						num = 10;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
						{
							num = 5;
						}
						break;
					}
					goto case 10;
				case 1:
				{
					Security security6 = security2;
					num4 = P_0.OhFvL5g8sQX;
					security6.FundingRate = num4.Value * 100.0;
					goto case 24;
				}
				case 22:
					security2.BidPrice = symbol.GetShortPrice(P_0.BidPrice.Value);
					goto IL_04ad;
				case 5:
					if (num4.HasValue)
					{
						lja8p2x2jxTu539fiu2D(security2, v062Qnx2cv6lphkaZ5TO(symbol, P_0.AskPrice.Value));
					}
					num4 = P_0.AskSize;
					if (num4.HasValue)
					{
						num = 13;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
						{
							num = 8;
						}
						break;
					}
					goto IL_00fe;
				case 8:
					security2.FundingNext = yli1vGx2QHtt5R5XEQOm(dateTimeOffset, dateTime).Ticks / 1000;
					if (P_0.UlOvLLap3Oh.HasValue)
					{
						num3 = P_0.UlOvLLap3Oh;
						Wsvo39B2USC(num3.Value);
						num = 23;
						break;
					}
					goto case 16;
				case 16:
					AX3o344Js1f?.Invoke(security2.GetEvent((Symbol)o2Q8eMx2dNtrkTLDaqv3(security2)));
					return;
				case 27:
					if (num4.HasValue)
					{
						num5 = 14;
						goto IL_0024;
					}
					goto IL_03c4;
				case 28:
					num2 = num6.Value;
					goto IL_06ea;
				case 9:
					if (!num4.HasValue)
					{
						num = 24;
						break;
					}
					goto case 1;
				default:
					security2.ClosePrice = P_0.hWIvxU0fQCA.Value;
					goto IL_0687;
				case 24:
					num3 = P_0.UlOvLLap3Oh;
					if (!num3.HasValue)
					{
						num = 18;
						break;
					}
					goto IL_053a;
				case 6:
					num6 = Mv5o3faNP6X();
					num = 28;
					break;
				case 4:
					if (num4.HasValue)
					{
						num5 = 15;
						goto IL_0024;
					}
					goto IL_0687;
				case 12:
				{
					if (!num4.HasValue)
					{
						goto case 3;
					}
					Security security = security2;
					num4 = P_0.blTvxrjMlyB;
					FehXSDx2eXosRacvkNwu(security, num4.Value);
					num = 3;
					break;
				}
				case 11:
					{
						num2 = num3.GetValueOrDefault();
						goto IL_06ea;
					}
					IL_0687:
					num4 = P_0.blTvxrjMlyB;
					num = 12;
					break;
					IL_06ea:
					dateTimeOffset = pGCrhjx2ErMnXWvZHVFr(num2);
					dateTime = DateTime.UtcNow.AddMilliseconds(Acj0FgGhg83F5A0lfPa4.q3hGwXLLhPb());
					num = 8;
					break;
					IL_03c4:
					num4 = P_0.AskPrice;
					num = 5;
					break;
					IL_0024:
					num = num5;
					break;
					IL_053a:
					num3 = P_0.UlOvLLap3Oh;
					num = 20;
					break;
					IL_04ad:
					num4 = P_0.BidSize;
					num = 27;
					break;
					IL_00fe:
					num4 = P_0.OhFvL5g8sQX;
					num = 9;
					break;
				}
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private long? Mv5o3faNP6X()
	{
		return btRo368TrGy;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Wsvo39B2USC(long? P_0)
	{
		btRo368TrGy = P_0;
	}

	private void AaQoFJpHfde(iXmPhYvvjFjXiQS9owCn P_0)
	{
		try
		{
			if (!sFPo35TL2MB.TryGetValue(P_0.Symbol, out var value) || !value.kHYGzP3WQN1)
			{
				return;
			}
			Symbol symbol = (Symbol)kngPfBx2gb8ScyRSAOA0(value);
			if (!aYSo3xWIvcm.ContainsKey((string)UojRBtx2RHB0jKwKJBwG(P_0)))
			{
				aYSo3xWIvcm[(string)UojRBtx2RHB0jKwKJBwG(P_0)] = new Security(symbol);
			}
			Security security = aYSo3xWIvcm[P_0.Symbol];
			int num = 3;
			while (true)
			{
				Action<SecurityEvent> action;
				switch (num)
				{
				case 4:
					return;
				default:
					if (Lgm72gx2Otam7p5gSCU1(P_0.oxVvvVaf8Ui) != 0)
					{
						security.BidPrice = symbol.GetShortPrice(P_0.oxVvvVaf8Ui[0][0]);
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
						{
							num = 5;
						}
						break;
					}
					goto IL_007f;
				case 3:
					if (P_0.OvXvvKIZbP8.Count != 0)
					{
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
						{
							num = 2;
						}
						break;
					}
					goto default;
				case 2:
					security.AskPrice = symbol.GetShortPrice(P_0.OvXvvKIZbP8[0][0]);
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					GFEyawx2MTjClaFq2qOQ(security, yAem5Jx26ad2dI8ka0Md(symbol, P_0.OvXvvKIZbP8[0][1]));
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
					{
						num = 0;
					}
					break;
				case 5:
					{
						security.BidSize = yAem5Jx26ad2dI8ka0Md(symbol, P_0.oxVvvVaf8Ui[0][1]);
						goto IL_007f;
					}
					IL_007f:
					action = AX3o344Js1f;
					if (action == null)
					{
						return;
					}
					action(security.GetEvent(symbol));
					num = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 != 0)
					{
						num = 3;
					}
					break;
				}
			}
		}
		catch (Exception message)
		{
			Log(message);
		}
	}

	private void DZFoFFDa1H8(object P_0, ErrorEventArgs P_1)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		object obj = C3pHX2x2q2saJIV7QNKV(P_1);
		KgRoFukkImv((string)(((obj != null) ? EmQSLGx2Icoj83h5TvAY(obj) : null) ?? P_1.Message));
		WebSocket val = (WebSocket)((P_0 is WebSocket) ? P_0 : null);
		int num;
		if (val == null)
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_00c4;
		IL_0009:
		switch (num)
		{
		case 2:
			return;
		default:
			try
			{
				if (val != null)
				{
					val.Close();
				}
				return;
			}
			catch (Exception message)
			{
				Log(message);
				return;
			}
		case 1:
			break;
		}
		goto IL_00c4;
		IL_00c4:
		if ((int)val.ReadyState != 1)
		{
			return;
		}
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	private void mhXoF3aLECU(object P_0, EventArgs P_1)
	{
		KgRoFukkImv(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x706541F3 ^ 0x70643217));
		Hjso31pjjuW.Change(-1, -1);
		LDpo3S3A5F3.Clear();
		sFPo35TL2MB.Clear();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				if (t1ao3EqU5xB)
				{
					return;
				}
				num = 2;
				break;
			case 3:
			{
				object w70o3B6L1dM = W70o3B6L1dM;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(w70o3B6L1dM, ref lockTaken);
					if (v1lo3k6EAb8 != null)
					{
						O48AjWx2WGBTc3v1Pjdo(v1lo3k6EAb8, new EventHandler(dIkoFpfj8nj));
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
						{
							num2 = 1;
						}
						while (true)
						{
							switch (num2)
							{
							case 1:
								v1lo3k6EAb8.OnClose -= mhXoF3aLECU;
								v1lo3k6EAb8.OnError -= DZFoFFDa1H8;
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								v1lo3k6EAb8 = null;
								goto end_IL_00e4;
							default:
								v1lo3k6EAb8.OnMessage -= oWjoFCuPXuw;
								num2 = 2;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
								{
									num2 = 1;
								}
								break;
							}
							continue;
							end_IL_00e4:
							break;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						L72Sirx2tePPHxZp5j7g(w70o3B6L1dM);
					}
				}
				goto case 1;
			}
			case 2:
				Thread.Sleep(1000);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
				{
					num = 0;
				}
				break;
			default:
				MrGoFUTxxlX();
				return;
			}
		}
	}

	private void dIkoFpfj8nj(object P_0, EventArgs P_1)
	{
		KgRoFukkImv((string)hD5y0Sx0AqZQZXj77aw2(-377195341 ^ -377157785));
		t1ao3EqU5xB = false;
		Action action = eTVo3QoWFLB;
		if (action != null)
		{
			action();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void oW1lYsReHKK(params Rybo1XGzd9ch5SOUQC2H[] symbols)
	{
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Invalid comparison between Unknown and I4
		object obj = nDbo3vpYUHQ;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			try
			{
				WebSocket obj2 = v1lo3k6EAb8;
				int num;
				if (obj2 == null)
				{
					num = 10;
					goto IL_0043;
				}
				Rybo1XGzd9ch5SOUQC2H[] array = default(Rybo1XGzd9ch5SOUQC2H[]);
				int num2 = default(int);
				if ((int)obj2.ReadyState == 1)
				{
					array = symbols;
					num2 = 0;
					goto IL_03ff;
				}
				goto IL_0b71;
				IL_03ff:
				Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = default(Rybo1XGzd9ch5SOUQC2H);
				if (num2 >= array.Length)
				{
					num = 14;
				}
				else
				{
					rybo1XGzd9ch5SOUQC2H = array[num2];
					num = 34;
				}
				goto IL_0043;
				IL_0b71:
				num = 12;
				goto IL_0043;
				IL_0043:
				List<yAgCFQvaKB3ghilxGg3P> list = default(List<yAgCFQvaKB3ghilxGg3P>);
				string fbSf9m1BvI7O0vlage6R = default(string);
				Rybo1XGzd9ch5SOUQC2H value = default(Rybo1XGzd9ch5SOUQC2H);
				bool flag = default(bool);
				List<yAgCFQvaKB3ghilxGg3P> list2 = default(List<yAgCFQvaKB3ghilxGg3P>);
				List<yAgCFQvaKB3ghilxGg3P>.Enumerator enumerator = default(List<yAgCFQvaKB3ghilxGg3P>.Enumerator);
				while (true)
				{
					switch (num)
					{
					case 12:
						return;
					case 14:
						return;
					case 33:
						list.Add(new rOVdWZvNytDIg59EX1Nk(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-837284864 ^ -837189788), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1799510641 ^ -1799602829), fbSf9m1BvI7O0vlage6R));
						goto IL_0a34;
					case 19:
						if (value.E07GzJKBNZY)
						{
							goto IL_0942;
						}
						goto IL_0aab;
					case 38:
						if (rSJo3cfpkig.HasFlag((yLN4Icv0vK5q17pYNHvp)16))
						{
							if (rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1)
							{
								if (flag && value.kHYGzP3WQN1)
								{
									num = 8;
									continue;
								}
								goto case 33;
							}
							goto case 8;
						}
						goto IL_0a34;
					case 3:
						value = new Rybo1XGzd9ch5SOUQC2H((Symbol)kngPfBx2gb8ScyRSAOA0(rybo1XGzd9ch5SOUQC2H), (string)ni5s1lx2UuLiLjrfUKtP(rybo1XGzd9ch5SOUQC2H));
						value.Code = rybo1XGzd9ch5SOUQC2H.Code;
						num = 26;
						continue;
					case 30:
						if (!rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY)
						{
							if (!value.E07GzJKBNZY)
							{
								num = 15;
								continue;
							}
							goto case 40;
						}
						goto case 15;
					case 25:
						list2.Add(new rOVdWZvNytDIg59EX1Nk((string)hD5y0Sx0AqZQZXj77aw2(0x32DEA4F1 ^ 0x32DFD78B), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x37B74BDF ^ 0x37B6D361), fbSf9m1BvI7O0vlage6R));
						goto IL_0ae4;
					case 23:
						enumerator = list.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								yAgCFQvaKB3ghilxGg3P current2 = enumerator.Current;
								int num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								}
								v1lo3k6EAb8.Send((string)i3IK3Tx2TZxdYjZwnwuU(current2));
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
						KgRoFukkImv(string.Format((string)hD5y0Sx0AqZQZXj77aw2(-1799510641 ^ -1799563749), list.Count));
						num = 8;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
						{
							num = 20;
						}
						continue;
					case 13:
						list.Add(new rOVdWZvNytDIg59EX1Nk(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1848952786 ^ -1849013430), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1D7BA1ED ^ 0x1D7A396B), fbSf9m1BvI7O0vlage6R));
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
						{
							num = 0;
						}
						continue;
					case 40:
						list2.Add(new rOVdWZvNytDIg59EX1Nk((string)hD5y0Sx0AqZQZXj77aw2(-1306877528 ^ -1306799406), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1325234765 ^ -1325195921), fbSf9m1BvI7O0vlage6R));
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
						{
							num = 16;
						}
						continue;
					case 9:
						if (value.kHYGzP3WQN1)
						{
							goto IL_06fc;
						}
						goto IL_0999;
					case 2:
						if (!rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY && value.E07GzJKBNZY)
						{
							num = 25;
							continue;
						}
						goto IL_0ae4;
					case 8:
						if (flag && !rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1 && value.kHYGzP3WQN1)
						{
							num = 22;
							continue;
						}
						goto IL_0a34;
					case 39:
						enumerator = list2.GetEnumerator();
						num = 4;
						continue;
					case 17:
						break;
					case 4:
						try
						{
							while (enumerator.MoveNext())
							{
								yAgCFQvaKB3ghilxGg3P current = enumerator.Current;
								int num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
								{
									num3 = 0;
								}
								switch (num3)
								{
								}
								tQLj51x2yBQvZQychfmm(v1lo3k6EAb8, JsonConvert.SerializeObject((object)current));
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
						goto case 32;
					case 29:
						list2 = new List<yAgCFQvaKB3ghilxGg3P>();
						if (!rSJo3cfpkig.HasFlag((yLN4Icv0vK5q17pYNHvp)2))
						{
							goto case 38;
						}
						if (rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1)
						{
							num = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
							{
								num = 5;
							}
							continue;
						}
						goto IL_06fc;
					case 32:
						KgRoFukkImv(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1D7BA1ED ^ 0x1D7AD25F), list2.Count));
						num = 35;
						continue;
					case 31:
						value.m54GzFaRoc7 = rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7;
						if (list.Any())
						{
							num = 23;
							continue;
						}
						goto case 20;
					case 7:
						if (flag)
						{
							goto case 30;
						}
						goto case 15;
					case 26:
						sFPo35TL2MB[value.Code] = value;
						goto IL_0102;
					case 27:
						if (flag)
						{
							num = 19;
							continue;
						}
						goto IL_0aab;
					case 11:
						if (flag && value.E07GzJKBNZY)
						{
							goto case 7;
						}
						list.Add(new rOVdWZvNytDIg59EX1Nk(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-690510723 ^ -690563303), (string)hD5y0Sx0AqZQZXj77aw2(-5977659 ^ -5943015), fbSf9m1BvI7O0vlage6R));
						goto case 15;
					case 5:
						if (flag)
						{
							num = 9;
							continue;
						}
						goto IL_0999;
					case 24:
						list2.Add(new rOVdWZvNytDIg59EX1Nk(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841534173), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DF3C77), fbSf9m1BvI7O0vlage6R));
						num = 36;
						continue;
					case 28:
						if (value.m54GzFaRoc7)
						{
							num = 24;
							continue;
						}
						goto default;
					case 1:
						list.Add(new rOVdWZvNytDIg59EX1Nk(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-710503328 ^ -710416636), (string)hD5y0Sx0AqZQZXj77aw2(-165474503 ^ -165505145), fbSf9m1BvI7O0vlage6R));
						goto IL_0ae4;
					case 6:
						if (flag)
						{
							num = 18;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
							{
								num = 18;
							}
							continue;
						}
						goto case 13;
					case 20:
						if (list2.Any())
						{
							num = 39;
							continue;
						}
						goto case 35;
					case 18:
						if (!value.m54GzFaRoc7)
						{
							num = 13;
							continue;
						}
						goto IL_01bf;
					case 22:
						list2.Add(new rOVdWZvNytDIg59EX1Nk(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1487846E ^ 0x1486F714), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2017337494 ^ -2017441898), fbSf9m1BvI7O0vlage6R));
						goto IL_0a34;
					case 37:
						if (flag)
						{
							num = 2;
							continue;
						}
						goto IL_0ae4;
					default:
						if (!flag)
						{
							num = 3;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c != 0)
							{
								num = 2;
							}
							continue;
						}
						goto IL_0102;
					case 15:
					case 16:
						if (rSJo3cfpkig.HasFlag((yLN4Icv0vK5q17pYNHvp)1))
						{
							if (!rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7)
							{
								goto IL_01bf;
							}
							goto case 6;
						}
						goto default;
					case 34:
						flag = sFPo35TL2MB.TryGetValue(rybo1XGzd9ch5SOUQC2H.Code, out value);
						fbSf9m1BvI7O0vlage6R = rybo1XGzd9ch5SOUQC2H.Code;
						list = new List<yAgCFQvaKB3ghilxGg3P>();
						num = 29;
						continue;
					case 21:
						value.E07GzJKBNZY = rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY;
						num = 31;
						continue;
					case 35:
						num2++;
						num = 17;
						continue;
					case 10:
						goto IL_0b71;
						IL_0102:
						value.kHYGzP3WQN1 = rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1;
						num = 21;
						continue;
						IL_0aab:
						list.Add(new rOVdWZvNytDIg59EX1Nk((string)hD5y0Sx0AqZQZXj77aw2(0x385FFAB ^ 0x3848CCF), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1153206687 ^ -1153241407), fbSf9m1BvI7O0vlage6R));
						goto IL_0b2b;
						IL_0a34:
						if (rSJo3cfpkig.HasFlag((yLN4Icv0vK5q17pYNHvp)8))
						{
							if (rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY)
							{
								num = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 == 0)
								{
									num = 27;
								}
								continue;
							}
							goto IL_0942;
						}
						goto IL_0b2b;
						IL_0999:
						list.Add(new rOVdWZvNytDIg59EX1Nk((string)hD5y0Sx0AqZQZXj77aw2(0x68DEE0F ^ 0x68C9D6B), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-45476899 ^ -45391657), fbSf9m1BvI7O0vlage6R));
						goto case 38;
						IL_06fc:
						if (flag && !rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1 && value.kHYGzP3WQN1)
						{
							list2.Add(new rOVdWZvNytDIg59EX1Nk(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xC1DDB3B ^ 0xC1CA85F), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7E0041), fbSf9m1BvI7O0vlage6R));
							int num4 = 38;
							num = num4;
							continue;
						}
						goto case 38;
						IL_0ae4:
						if (rSJo3cfpkig.HasFlag((yLN4Icv0vK5q17pYNHvp)32))
						{
							if (rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY)
							{
								num = 7;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
								{
									num = 11;
								}
								continue;
							}
							goto case 7;
						}
						goto case 15;
						IL_0942:
						if (flag && !rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY && value.E07GzJKBNZY)
						{
							list2.Add(new rOVdWZvNytDIg59EX1Nk((string)hD5y0Sx0AqZQZXj77aw2(-520155535 ^ -520192757), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1962651919 ^ -1962551727), fbSf9m1BvI7O0vlage6R));
						}
						goto IL_0b2b;
						IL_01bf:
						if (flag && !rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7)
						{
							num = 18;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
							{
								num = 28;
							}
							continue;
						}
						goto default;
						IL_0b2b:
						if (rSJo3cfpkig.HasFlag((yLN4Icv0vK5q17pYNHvp)4))
						{
							if (rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY)
							{
								if (!flag)
								{
									goto case 1;
								}
								if (!value.E07GzJKBNZY)
								{
									num = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
									{
										num = 1;
									}
									continue;
								}
							}
							goto case 37;
						}
						goto IL_0ae4;
					}
					break;
				}
				goto IL_03ff;
			}
			catch (Exception obj3)
			{
				Action<Exception> action = Rk7o3NRHSdC;
				if (action != null)
				{
					action(obj3);
					int num6 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				L72Sirx2tePPHxZp5j7g(obj);
			}
		}
	}

	public void xWUloD1FdfW(string P_0)
	{
		WebSocket obj = v1lo3k6EAb8;
		if (obj != null)
		{
			obj.Send(P_0);
		}
	}

	private void Log(Exception message)
	{
		Rk7o3NRHSdC?.Invoke(message);
	}

	private void Log(string message, bool show)
	{
		CTmo3bKRn1e?.Invoke(message, show);
	}

	public void KgRoFukkImv(string P_0)
	{
		if (!B8yo3G4UQSi)
		{
			return;
		}
		Action<string> action = waxo3dpbiUy;
		if (action == null)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
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
			action((string)f76f1Cx2Zh4GnMTdYNQG(dYYo3oMPQDy, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x37B74BDF ^ 0x37B7E073), P_0));
		}
	}

	static WNXk4poFIaq9YQ0mpusa()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		MMHx55x2VV2LsIux9Lp9();
	}

	internal static WebSocketState yvkbMYx08H9G765Y7Nl0(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static object hD5y0Sx0AqZQZXj77aw2(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void OTx4ewx0PjOeQohGVSsp(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static bool OcfVHPx0wFKPUHKbOk5y()
	{
		return auqcPmx0hBpbgG8E35XC == null;
	}

	internal static WNXk4poFIaq9YQ0mpusa dIvOKyx07TSSkR8jqKCO()
	{
		return auqcPmx0hBpbgG8E35XC;
	}

	internal static WebSocketState paXEtYx0JyI2X24G3VKk(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static void em5Eqqx0F9GJMwwuGcQa(object P_0, TimeSpan P_1)
	{
		((WebSocket)P_0).WaitTime = P_1;
	}

	internal static object V2bAN6x03klqCSsuunxg(object P_0)
	{
		return ((WebSocket)P_0).SslConfiguration;
	}

	internal static object DMlZ6Px0pxFgJeAcHnNZ(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Url;
	}

	internal static object DU8Wn2x0uVH9bgP52dVD(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Password;
	}

	internal static void EPH7mKx0zDxOGKTrNoAk(object P_0, object P_1, object P_2, object P_3)
	{
		((WebSocket)P_0).SetProxy((string)P_1, (string)P_2, (string)P_3);
	}

	internal static TimeSpan WLoSjyx20cV8iXEyUnYS(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static bool LMVdIkx22iCeJjARFSrf(object P_0, TimeSpan P_1, TimeSpan P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}

	internal static int sMY4Aux2HUTGe8WgWUTy(object P_0)
	{
		return ((ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>)P_0).Count;
	}

	internal static object xC3Chcx2fqjeMNhDKY8u(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Code;
	}

	internal static void u54iojx29m7ZcOUN2OSG(object P_0)
	{
		((ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>)P_0).Clear();
	}

	internal static bool oF4dirx2nv9f7iNYM8dx(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object URkpQrx2GBr7NFQSbL7l(object P_0)
	{
		return ((lbU0JXvvJlEkX1KaqiEM)P_0).y5Zvv3Kejaa();
	}

	internal static object ebl8V0x2YALrJ7gTU5IO(object P_0)
	{
		return ((lbU0JXvvJlEkX1KaqiEM)P_0).Type;
	}

	internal static JsonToken zxFod6x2oMSffgCpG7Bh(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonReader)P_0).TokenType;
	}

	internal static object exd3gVx2vKnbKDdys1wY(object P_0)
	{
		return ((JsonReader)P_0).Value;
	}

	internal static object q5nBo4x2Bbg1jFYtEsYe(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void jTQUfAx2axjbgOUxfETt(object P_0, object P_1)
	{
		((lbU0JXvvJlEkX1KaqiEM)P_0).Message = (string)P_1;
	}

	internal static void aRG4kdx2ijkntvyFFHtA(object P_0, object P_1)
	{
		((lbU0JXvvJlEkX1KaqiEM)P_0).Code = (string)P_1;
	}

	internal static void OxJ05Ox2lsTExj8tYVYl(object P_0, object P_1)
	{
		((rN00GsvxQSbLyKga7xJY)P_0).Symbol = (string)P_1;
	}

	internal static object abhf2dx241HRFUZck4jf()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static double RsOU3fx2DHCxHLvEgCWY(object P_0, object P_1)
	{
		return double.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static long G9H2G8x2bZvvo4alACNW(object P_0, object P_1)
	{
		return long.Parse((string)P_0, (IFormatProvider)P_1);
	}

	internal static bool z9dtEdx2N7aJA6KiyK7q(object P_0)
	{
		return ((JsonReader)P_0).Read();
	}

	internal static bool jvYg86x2kcBYyWdefIwx(object P_0)
	{
		return ((iXmPhYvvjFjXiQS9owCn)P_0).EH7vvReFT9N();
	}

	internal static void NjsVaOx21ZWIlDFJo7TE(object P_0, object P_1, object P_2)
	{
		((vdq7k7oF1bjOLTKJ5ZnM)P_0).odClvnSDwKl((Symbol)P_1, (MarketDepthFullEvent)P_2);
	}

	internal static double JxYyljx25AdFNlFRcEtT(object P_0)
	{
		return ((PK8l0XvBbkbPqwEYHd9S)P_0).Price;
	}

	internal static void tv98Cfx2SGoM6UNf0vRl(object P_0, DateTime P_1)
	{
		((TickEvent)P_0).Time = P_1;
	}

	internal static void C9SHgRx2x5oA80JS4iQu(object P_0, long P_1)
	{
		((TickEvent)P_0).Size = P_1;
	}

	internal static bool rYYKXKx2LoZwp27e4jXs(object P_0)
	{
		return ((PK8l0XvBbkbPqwEYHd9S)P_0).U9tvBQ31JiT;
	}

	internal static void FehXSDx2eXosRacvkNwu(object P_0, double value)
	{
		((Security)P_0).HighPrice = value;
	}

	internal static void Dt30C5x2sbU4iObFLYeJ(object P_0, double value)
	{
		((Security)P_0).LowPrice = value;
	}

	internal static void eZrbxKx2X9hHcSuI9jSe(object P_0, long value)
	{
		((Security)P_0).Value = value;
	}

	internal static long v062Qnx2cv6lphkaZ5TO(object P_0, double price)
	{
		return ((Symbol)P_0).GetShortPrice(price);
	}

	internal static void lja8p2x2jxTu539fiu2D(object P_0, long value)
	{
		((Security)P_0).AskPrice = value;
	}

	internal static DateTimeOffset pGCrhjx2ErMnXWvZHVFr(long P_0)
	{
		return DateTimeOffset.FromUnixTimeMilliseconds(P_0);
	}

	internal static TimeSpan yli1vGx2QHtt5R5XEQOm(DateTimeOffset P_0, DateTimeOffset P_1)
	{
		return P_0 - P_1;
	}

	internal static object o2Q8eMx2dNtrkTLDaqv3(object P_0)
	{
		return ((Security)P_0).Symbol;
	}

	internal static object kngPfBx2gb8ScyRSAOA0(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Symbol;
	}

	internal static object UojRBtx2RHB0jKwKJBwG(object P_0)
	{
		return ((iXmPhYvvjFjXiQS9owCn)P_0).Symbol;
	}

	internal static long yAem5Jx26ad2dI8ka0Md(object P_0, double size)
	{
		return ((SymbolBase)P_0).GetShortSize(size);
	}

	internal static void GFEyawx2MTjClaFq2qOQ(object P_0, long value)
	{
		((Security)P_0).AskSize = value;
	}

	internal static int Lgm72gx2Otam7p5gSCU1(object P_0)
	{
		return ((List<double[]>)P_0).Count;
	}

	internal static object C3pHX2x2q2saJIV7QNKV(object P_0)
	{
		return ((ErrorEventArgs)P_0).Exception;
	}

	internal static object EmQSLGx2Icoj83h5TvAY(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void O48AjWx2WGBTc3v1Pjdo(object P_0, object P_1)
	{
		((WebSocket)P_0).OnOpen -= (EventHandler)P_1;
	}

	internal static void L72Sirx2tePPHxZp5j7g(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object ni5s1lx2UuLiLjrfUKtP(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Qa2Gz62Cyav();
	}

	internal static object i3IK3Tx2TZxdYjZwnwuU(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static void tQLj51x2yBQvZQychfmm(object P_0, object P_1)
	{
		((WebSocket)P_0).Send((string)P_1);
	}

	internal static object f76f1Cx2Zh4GnMTdYNQG(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void MMHx55x2VV2LsIux9Lp9()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
