using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Threading;
using atoQGRYAqqIsaXNYqFXH;
using BfZtb759KlUg4482QKym;
using c2LywJonwyAmuDOScbY4;
using cpn3QfoYdDGf7ZYKEG4d;
using fwF8mto0SvUAwv9xS1xV;
using K1GcsD5GTtMSlaiJI0Xh;
using kTfvF5o0dNSl0EXexCqJ;
using lFFs11G39ohaRVknaFPC;
using ltQkSKYAyli0O69Ty1a8;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using nI0iklG3L4EXgsHYE0T1;
using o5cuPYYJd2pZ4lpRAlek;
using OcHbQtGP3xkr6ulp8wLV;
using ol7RTpoGtcB2EhwNow3F;
using OWhORdGzgDWLWxLpUFfx;
using r8oOHiajFPNBXu6XiAHj;
using RwlEnWYpww8AG8TuYcX3;
using SCZR5AYuHMEgUFWy1qyr;
using sIFWheGF3OYNVQk97tur;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using utVC8XoYLi77ujS1NEcl;
using WebSocketSharp;
using WebSocketSharp.Net;
using x97CE55GhEYKgt7TSVZT;
using y9e8njonfEGtBInZHtcn;
using YZUdiEoFgRDMIugxodC4;

namespace PNwXEdYFiMN63VMZw8HO;

internal sealed class XGGQ8pYFa2yVBpVUAYAi : U89K3uYATyxssFLlXLdl, yYTjIuoFdESZ0WX3eI6v
{
	private readonly bool LSgYFcbNtiB;

	private static long mucYFj5FhsY;

	private readonly string y37YFEMi9Ow;

	private readonly HuFXDXYAO3q2epASB3O9 xKHYFMKBqTE;

	private readonly object LA9YFOFlB3f;

	private readonly object QcDYFqOCZ8q;

	private readonly string HDRYFIVFpBt;

	private readonly C3trUsajJIHJMtdo9pBg r21YFWX5lGI;

	private readonly Dictionary<string, Rybo1XGzd9ch5SOUQC2H> fTfYFtXDPxf;

	private readonly Dictionary<string, XaQvAHYJQjbrDJbfH8Zs> kscYFUiI0ob;

	private WebSocket HffYFTGldfO;

	private bool nZPYFyuvE05;

	private readonly Timer JJwYFZLSGdB;

	private Action bSdYFVdmZuH;

	private readonly Action<string> cVQYFCfQg2a;

	[CompilerGenerated]
	private Action<X8tGy9onhsPMCXH31SYX> jYAYFraEp2W;

	[CompilerGenerated]
	private Action<ycnf2IoYQUWKIM1CocU9> rrwYFKhrKkh;

	[CompilerGenerated]
	private Action<MarketDepthFullEvent> Ji9YFm5Ocqf;

	[CompilerGenerated]
	private Action<MarketDepthDiffEvent> sU2YFhw1KKq;

	[CompilerGenerated]
	private Action<TUEuO1Yu2tTkuI5RCv4W> G9IYFw5u9La;

	[CompilerGenerated]
	private Action<vHtWHMYphTAdhJW7CR80> kW6YF7aDsxO;

	[CompilerGenerated]
	private Action<string, bool> ARXYF86hHWC;

	[CompilerGenerated]
	private Action<Exception> UeQYFAGX1nE;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> eKUYFP9q0ta;

	private readonly ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H> sDiYFJxyoSW;

	private static XGGQ8pYFa2yVBpVUAYAi OG8ptvSOORxE4uGvxNx8;

	[SpecialName]
	[CompilerGenerated]
	public void DxgloZAQZXZ(Action<X8tGy9onhsPMCXH31SYX> P_0)
	{
		Action<X8tGy9onhsPMCXH31SYX> action = jYAYFraEp2W;
		Action<X8tGy9onhsPMCXH31SYX> action2;
		do
		{
			action2 = action;
			Action<X8tGy9onhsPMCXH31SYX> value = (Action<X8tGy9onhsPMCXH31SYX>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref jYAYFraEp2W, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void vb7loVWZoe4(Action<X8tGy9onhsPMCXH31SYX> P_0)
	{
		Action<X8tGy9onhsPMCXH31SYX> action = jYAYFraEp2W;
		Action<X8tGy9onhsPMCXH31SYX> action2;
		do
		{
			action2 = action;
			Action<X8tGy9onhsPMCXH31SYX> value = (Action<X8tGy9onhsPMCXH31SYX>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref jYAYFraEp2W, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void OhDlorCyqyA(Action<ycnf2IoYQUWKIM1CocU9> P_0)
	{
		Action<ycnf2IoYQUWKIM1CocU9> action = rrwYFKhrKkh;
		Action<ycnf2IoYQUWKIM1CocU9> action2;
		do
		{
			action2 = action;
			Action<ycnf2IoYQUWKIM1CocU9> value = (Action<ycnf2IoYQUWKIM1CocU9>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref rrwYFKhrKkh, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void o1BloK0n9rP(Action<ycnf2IoYQUWKIM1CocU9> P_0)
	{
		Action<ycnf2IoYQUWKIM1CocU9> action = rrwYFKhrKkh;
		Action<ycnf2IoYQUWKIM1CocU9> action2;
		do
		{
			action2 = action;
			Action<ycnf2IoYQUWKIM1CocU9> value = (Action<ycnf2IoYQUWKIM1CocU9>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref rrwYFKhrKkh, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void puvloJ4L5Eq(Action<MarketDepthFullEvent> P_0)
	{
		Action<MarketDepthFullEvent> action = Ji9YFm5Ocqf;
		Action<MarketDepthFullEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthFullEvent> value = (Action<MarketDepthFullEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref Ji9YFm5Ocqf, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void QvFloFlJ5cR(Action<MarketDepthFullEvent> P_0)
	{
		Action<MarketDepthFullEvent> action = Ji9YFm5Ocqf;
		Action<MarketDepthFullEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthFullEvent> value = (Action<MarketDepthFullEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref Ji9YFm5Ocqf, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void ikolopXNCnV(Action<MarketDepthDiffEvent> P_0)
	{
		Action<MarketDepthDiffEvent> action = sU2YFhw1KKq;
		Action<MarketDepthDiffEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthDiffEvent> value = (Action<MarketDepthDiffEvent>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref sU2YFhw1KKq, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void PuelouGmXeq(Action<MarketDepthDiffEvent> P_0)
	{
		Action<MarketDepthDiffEvent> action = sU2YFhw1KKq;
		Action<MarketDepthDiffEvent> action2;
		do
		{
			action2 = action;
			Action<MarketDepthDiffEvent> value = (Action<MarketDepthDiffEvent>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref sU2YFhw1KKq, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void AAclohymp3j(Action<TUEuO1Yu2tTkuI5RCv4W> P_0)
	{
		Action<TUEuO1Yu2tTkuI5RCv4W> action = G9IYFw5u9La;
		Action<TUEuO1Yu2tTkuI5RCv4W> action2;
		do
		{
			action2 = action;
			Action<TUEuO1Yu2tTkuI5RCv4W> value = (Action<TUEuO1Yu2tTkuI5RCv4W>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref G9IYFw5u9La, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void IIZlowf5r2K(Action<TUEuO1Yu2tTkuI5RCv4W> P_0)
	{
		Action<TUEuO1Yu2tTkuI5RCv4W> action = G9IYFw5u9La;
		Action<TUEuO1Yu2tTkuI5RCv4W> action2;
		do
		{
			action2 = action;
			Action<TUEuO1Yu2tTkuI5RCv4W> value = (Action<TUEuO1Yu2tTkuI5RCv4W>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref G9IYFw5u9La, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void HO8lo8E2X35(Action<vHtWHMYphTAdhJW7CR80> P_0)
	{
		Action<vHtWHMYphTAdhJW7CR80> action = kW6YF7aDsxO;
		Action<vHtWHMYphTAdhJW7CR80> action2;
		do
		{
			action2 = action;
			Action<vHtWHMYphTAdhJW7CR80> value = (Action<vHtWHMYphTAdhJW7CR80>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref kW6YF7aDsxO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void WpGloA103cE(Action<vHtWHMYphTAdhJW7CR80> P_0)
	{
		Action<vHtWHMYphTAdhJW7CR80> action = kW6YF7aDsxO;
		Action<vHtWHMYphTAdhJW7CR80> action2;
		do
		{
			action2 = action;
			Action<vHtWHMYphTAdhJW7CR80> value = (Action<vHtWHMYphTAdhJW7CR80>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref kW6YF7aDsxO, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void lK1lv00pgeu(Action<string, bool> P_0)
	{
		Action<string, bool> action = ARXYF86hHWC;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref ARXYF86hHWC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void YLDlv2bKTEJ(Action<string, bool> P_0)
	{
		Action<string, bool> action = ARXYF86hHWC;
		Action<string, bool> action2;
		do
		{
			action2 = action;
			Action<string, bool> value = (Action<string, bool>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref ARXYF86hHWC, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void FZrlvfRH5vZ(Action<Exception> P_0)
	{
		Action<Exception> action = UeQYFAGX1nE;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref UeQYFAGX1nE, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public void DRFlv9K5tCP(Action<Exception> P_0)
	{
		Action<Exception> action = UeQYFAGX1nE;
		Action<Exception> action2;
		do
		{
			action2 = action;
			Action<Exception> value = (Action<Exception>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref UeQYFAGX1nE, value, action2);
		}
		while ((object)action != action2);
	}

	public XGGQ8pYFa2yVBpVUAYAi(string P_0, C3trUsajJIHJMtdo9pBg P_1, Action P_2, Action<string> P_3, HuFXDXYAO3q2epASB3O9 P_4, string P_5)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		LSgYFcbNtiB = Convert.ToBoolean(ConfigurationManager.AppSettings[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x385FFAB ^ 0x3848DC7)]);
		LA9YFOFlB3f = new object();
		QcDYFqOCZ8q = new object();
		fTfYFtXDPxf = new Dictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		kscYFUiI0ob = new Dictionary<string, XaQvAHYJQjbrDJbfH8Zs>();
		eKUYFP9q0ta = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		sDiYFJxyoSW = new ConcurrentDictionary<string, Rybo1XGzd9ch5SOUQC2H>();
		base._002Ector();
		y37YFEMi9Ow = string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x68C7EAE6 ^ 0x68C6987A), Interlocked.Increment(ref mucYFj5FhsY), P_4, P_5);
		HDRYFIVFpBt = P_0;
		r21YFWX5lGI = P_1;
		bSdYFVdmZuH = P_2;
		cVQYFCfQg2a = P_3;
		xKHYFMKBqTE = P_4;
		JJwYFZLSGdB = new Timer(CJHYFl1aTiD, null, -1, -1);
	}

	private void CJHYFl1aTiD(object P_0)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Invalid comparison between Unknown and I4
		WebSocket hffYFTGldfO = HffYFTGldfO;
		if (hffYFTGldfO != null && (int)hffYFTGldfO.ReadyState == 0)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 1:
			{
				WebSocket hffYFTGldfO3 = HffYFTGldfO;
				if (hffYFTGldfO3 != null && (int)oEEYSkSOWsb2xS6r0cv6(hffYFTGldfO3) == 2)
				{
					return;
				}
				WebSocket hffYFTGldfO4 = HffYFTGldfO;
				if (hffYFTGldfO4 == null || (int)oEEYSkSOWsb2xS6r0cv6(hffYFTGldfO4) != 1)
				{
					goto case 2;
				}
				num = 4;
				break;
			}
			case 4:
			{
				WebSocket hffYFTGldfO5 = HffYFTGldfO;
				if (hffYFTGldfO5 == null)
				{
					int num2 = 2;
					num = num2;
					break;
				}
				if (!cnHrngSOtZMCylvBT7wK(hffYFTGldfO5))
				{
					goto case 2;
				}
				return;
			}
			case 2:
				zZMYFxiJNXp((string)VFVyinSOUlhLPWhAwe2L(-57768881 ^ -57673993));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
				{
					num = 0;
				}
				break;
			default:
			{
				WebSocket hffYFTGldfO2 = HffYFTGldfO;
				if (hffYFTGldfO2 == null)
				{
					return;
				}
				hffYFTGldfO2.CloseAsync();
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
				{
					num = 3;
				}
				break;
			}
			}
		}
	}

	public void lihlfMp6ULY()
	{
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01f0: Expected O, but got Unknown
		try
		{
			int num;
			if (HffYFTGldfO == null)
			{
				num = 2;
			}
			else
			{
				if ((int)HffYFTGldfO.ReadyState == 1 || (int)HffYFTGldfO.ReadyState == 0)
				{
					return;
				}
				num = 6;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
				case 6:
				{
					kscYFUiI0ob.Clear();
					WebSocket val = new WebSocket(HDRYFIVFpBt, Array.Empty<string>())
					{
						EmitOnPing = true
					};
					kSVhBpSOTfsqbJFnpjuQ((object)val, TimeSpan.FromSeconds(10.0));
					HffYFTGldfO = val;
					((SslConfiguration)HffYFTGldfO.SslConfiguration).EnabledSslProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;
					if (D9tToxSOyEgnivbCpASQ(r21YFWX5lGI))
					{
						yP9ynoSOZn25u0cLDuAR(HffYFTGldfO, r21YFWX5lGI.Url, r21YFWX5lGI.OCiaEYswnjC(), r21YFWX5lGI.Password);
					}
					HffYFTGldfO.OnOpen += i2YYFNoiyG8;
					num = 3;
					break;
				}
				case 3:
					HffYFTGldfO.OnClose += ahBYFkDaJpp;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
					{
						num = 1;
					}
					break;
				case 5:
					JJwYFZLSGdB.Change(TimeSpan.FromSeconds(5.0), TimeSpan.FromSeconds(15.0));
					num = 4;
					break;
				case 1:
					HffYFTGldfO.OnError += k4WYF1TaaUi;
					HffYFTGldfO.OnMessage += y7cYF58ZIPG;
					num = 5;
					break;
				case 4:
					HffYFTGldfO.ConnectAsync();
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
		catch (Exception obj)
		{
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			UeQYFAGX1nE?.Invoke(obj);
		}
	}

	public void Disconnect()
	{
		try
		{
			mucYFj5FhsY = 0L;
			fTfYFtXDPxf.Clear();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
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
				nZPYFyuvE05 = true;
				bSdYFVdmZuH = null;
				WebSocket hffYFTGldfO = HffYFTGldfO;
				if (hffYFTGldfO == null)
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
					{
						num = 1;
					}
					continue;
				}
				mxwULsSOV1wlKayPIRrO(hffYFTGldfO);
				return;
			}
		}
		catch (Exception obj)
		{
			Action<Exception> action = UeQYFAGX1nE;
			if (action != null)
			{
				action(obj);
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
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
	}

	[SpecialName]
	public bool bqmYFLObsIn()
	{
		return eKUYFP9q0ta.Count < 100;
	}

	[SpecialName]
	public bool giRYFsiOBKK()
	{
		return eKUYFP9q0ta.Count == 0;
	}

	public bool ik0YF4MHwbB(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		return eKUYFP9q0ta.TryAdd((string)EWTg3bSOCXKPrIKDuwKo(P_0), P_0);
	}

	public bool fplYFD1tWKR(Rybo1XGzd9ch5SOUQC2H P_0)
	{
		eKUYFP9q0ta.TryRemove(P_0.Code, out var _);
		return sDiYFJxyoSW.TryAdd(P_0.Code, P_0);
	}

	public void hqxYFb2U7gJ()
	{
		if (!eKUYFP9q0ta.Any() && !sDiYFJxyoSW.Any())
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_0046;
			}
		}
		oW1lYsReHKK(eKUYFP9q0ta.Values.Union(sDiYFJxyoSW.Values).ToArray());
		goto IL_0046;
		IL_0046:
		sDiYFJxyoSW.Clear();
	}

	public void oW1lYsReHKK(params Rybo1XGzd9ch5SOUQC2H[] symbols)
	{
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Invalid comparison between Unknown and I4
		object lA9YFOFlB3f = LA9YFOFlB3f;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(lA9YFOFlB3f, ref lockTaken);
			try
			{
				WebSocket hffYFTGldfO = HffYFTGldfO;
				if (hffYFTGldfO == null || (int)hffYFTGldfO.ReadyState != 1)
				{
					return;
				}
				int num2 = 16;
				Rybo1XGzd9ch5SOUQC2H value = default(Rybo1XGzd9ch5SOUQC2H);
				List<AVFYHlo0QjsqBFxq8ad1> list2 = default(List<AVFYHlo0QjsqBFxq8ad1>);
				Rybo1XGzd9ch5SOUQC2H rybo1XGzd9ch5SOUQC2H = default(Rybo1XGzd9ch5SOUQC2H);
				List<AVFYHlo0QjsqBFxq8ad1> list = default(List<AVFYHlo0QjsqBFxq8ad1>);
				bool flag = default(bool);
				int num3 = default(int);
				Rybo1XGzd9ch5SOUQC2H[] array = default(Rybo1XGzd9ch5SOUQC2H[]);
				vsH1rlo05sWSyQZ9h92W vsH1rlo05sWSyQZ9h92W = default(vsH1rlo05sWSyQZ9h92W);
				vsH1rlo05sWSyQZ9h92W vsH1rlo05sWSyQZ9h92W2 = default(vsH1rlo05sWSyQZ9h92W);
				while (true)
				{
					int num4;
					List<AVFYHlo0QjsqBFxq8ad1> list7;
					AVFYHlo0QjsqBFxq8ad1 obj2;
					switch (num2)
					{
					case 20:
						return;
					case 23:
						if (value.E07GzJKBNZY)
						{
							list2.Add(new AVFYHlo0QjsqBFxq8ad1
							{
								Symbol = rybo1XGzd9ch5SOUQC2H.Code,
								Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-490987856 ^ -490902100)
							});
							num2 = 9;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
							{
								num2 = 7;
							}
							break;
						}
						goto case 9;
					default:
					{
						List<AVFYHlo0QjsqBFxq8ad1> list10 = list;
						AVFYHlo0QjsqBFxq8ad1 aVFYHlo0QjsqBFxq8ad6 = new AVFYHlo0QjsqBFxq8ad1();
						vK3pp7SOKSAnO3CccxL3(aVFYHlo0QjsqBFxq8ad6, rybo1XGzd9ch5SOUQC2H.Code);
						aVFYHlo0QjsqBFxq8ad6.Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1487846E ^ 0x1486F772);
						list10.Add(aVFYHlo0QjsqBFxq8ad6);
						goto case 9;
					}
					case 15:
					{
						List<AVFYHlo0QjsqBFxq8ad1> list5 = list;
						AVFYHlo0QjsqBFxq8ad1 aVFYHlo0QjsqBFxq8ad2 = new AVFYHlo0QjsqBFxq8ad1();
						vK3pp7SOKSAnO3CccxL3(aVFYHlo0QjsqBFxq8ad2, rybo1XGzd9ch5SOUQC2H.Code);
						aVFYHlo0QjsqBFxq8ad2.Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-90307782 ^ -90214286);
						list5.Add(aVFYHlo0QjsqBFxq8ad2);
						goto case 12;
					}
					case 4:
						if (flag && !rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7 && value.m54GzFaRoc7)
						{
							num2 = 30;
							break;
						}
						goto case 13;
					case 34:
						if (flag && !rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1)
						{
							num2 = 38;
							break;
						}
						goto case 5;
					case 6:
						num3 = 0;
						num2 = 29;
						break;
					case 8:
						zZMYFxiJNXp(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x86EFEF6 ^ 0x86F8D44), list2.Count));
						num2 = 20;
						break;
					case 19:
						if (!value.kHYGzP3WQN1)
						{
							num4 = 21;
							goto IL_0069;
						}
						goto case 34;
					case 29:
						if (num3 < array.Length)
						{
							goto case 26;
						}
						vsH1rlo05sWSyQZ9h92W = new vsH1rlo05sWSyQZ9h92W
						{
							HxAo0eeH4id = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x24B0B9E6 ^ 0x24B1CA82),
							nu4o0clIw8j = list
						};
						vsH1rlo05sWSyQZ9h92W2 = new vsH1rlo05sWSyQZ9h92W
						{
							HxAo0eeH4id = (string)VFVyinSOUlhLPWhAwe2L(--927068468 ^ 0x3740824E),
							nu4o0clIw8j = list2
						};
						if (vsH1rlo05sWSyQZ9h92W.nu4o0clIw8j.Any())
						{
							num2 = 25;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
							{
								num2 = 20;
							}
							break;
						}
						goto case 14;
					case 33:
						value.sVYGz3io63y = rybo1XGzd9ch5SOUQC2H.sVYGz3io63y;
						num2 = 18;
						break;
					case 32:
						value.kHYGzP3WQN1 = rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1;
						value.E07GzJKBNZY = rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY;
						num2 = 33;
						break;
					case 7:
						if (value.sVYGz3io63y)
						{
							List<AVFYHlo0QjsqBFxq8ad1> list9 = list2;
							AVFYHlo0QjsqBFxq8ad1 aVFYHlo0QjsqBFxq8ad5 = new AVFYHlo0QjsqBFxq8ad1();
							vK3pp7SOKSAnO3CccxL3(aVFYHlo0QjsqBFxq8ad5, rybo1XGzd9ch5SOUQC2H.Code);
							Q8vs6iSOrs99nbPePuNa(aVFYHlo0QjsqBFxq8ad5, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x446AB724 ^ 0x446BC40E));
							list9.Add(aVFYHlo0QjsqBFxq8ad5);
						}
						goto case 35;
					case 14:
						if (!vsH1rlo05sWSyQZ9h92W2.nu4o0clIw8j.Any())
						{
							return;
						}
						J8UqEvSO76LlciYKSKRH(HffYFTGldfO, gEL4mgSOwokUcJ4JvF0n(vsH1rlo05sWSyQZ9h92W2));
						num2 = 6;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
						{
							num2 = 8;
						}
						break;
					case 38:
						if (value.kHYGzP3WQN1)
						{
							list2.Add(new AVFYHlo0QjsqBFxq8ad1
							{
								Symbol = rybo1XGzd9ch5SOUQC2H.Code,
								Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1763895751 ^ -1763941069)
							});
							num2 = 3;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
							{
								num2 = 5;
							}
							break;
						}
						goto case 5;
					case 18:
						num3++;
						goto case 29;
					case 5:
						if (!xKHYFMKBqTE.HasFlag((HuFXDXYAO3q2epASB3O9)2))
						{
							num2 = 11;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
							{
								num2 = 22;
							}
							break;
						}
						if (rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY)
						{
							if (!flag)
							{
								goto default;
							}
							if (!value.E07GzJKBNZY)
							{
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
								{
									num2 = 0;
								}
								break;
							}
						}
						if (flag && !rybo1XGzd9ch5SOUQC2H.E07GzJKBNZY)
						{
							num2 = 23;
							break;
						}
						goto case 9;
					case 26:
						rybo1XGzd9ch5SOUQC2H = array[num3];
						flag = fTfYFtXDPxf.TryGetValue(rybo1XGzd9ch5SOUQC2H.Code, out value);
						num2 = 36;
						break;
					case 36:
						if (xKHYFMKBqTE.HasFlag(HuFXDXYAO3q2epASB3O9.Trades))
						{
							if (!rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7)
							{
								goto case 4;
							}
							if (flag)
							{
								num2 = 24;
								break;
							}
							goto IL_06c5;
						}
						goto case 13;
					case 24:
						if (value.m54GzFaRoc7)
						{
							goto case 4;
						}
						goto IL_06c5;
					case 27:
						array = symbols;
						num2 = 6;
						break;
					case 25:
						HffYFTGldfO.Send(JsonConvert.SerializeObject((object)vsH1rlo05sWSyQZ9h92W));
						zZMYFxiJNXp((string)ngKNDdSOhvba6JloLUsr(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x20B584D2 ^ 0x20B4F746), FtmFfTSOmnmxirLgLQM9(list)));
						num2 = 14;
						break;
					case 3:
						fTfYFtXDPxf[value.Code] = value;
						goto IL_031f;
					case 30:
					{
						List<AVFYHlo0QjsqBFxq8ad1> list6 = list2;
						AVFYHlo0QjsqBFxq8ad1 aVFYHlo0QjsqBFxq8ad3 = new AVFYHlo0QjsqBFxq8ad1();
						vK3pp7SOKSAnO3CccxL3(aVFYHlo0QjsqBFxq8ad3, EWTg3bSOCXKPrIKDuwKo(rybo1XGzd9ch5SOUQC2H));
						aVFYHlo0QjsqBFxq8ad3.Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--134855371 ^ 0x8092657);
						list6.Add(aVFYHlo0QjsqBFxq8ad3);
						num4 = 13;
						goto IL_0069;
					}
					case 35:
						if (!xKHYFMKBqTE.HasFlag((HuFXDXYAO3q2epASB3O9)16))
						{
							goto case 12;
						}
						if (!rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7)
						{
							num2 = 28;
							break;
						}
						goto case 1;
					case 10:
					case 11:
					case 28:
						if (flag && !rybo1XGzd9ch5SOUQC2H.sVYGz3io63y)
						{
							if (!value.sVYGz3io63y)
							{
								num2 = 9;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
								{
									num2 = 17;
								}
							}
							else
							{
								List<AVFYHlo0QjsqBFxq8ad1> list4 = list2;
								AVFYHlo0QjsqBFxq8ad1 aVFYHlo0QjsqBFxq8ad = new AVFYHlo0QjsqBFxq8ad1();
								vK3pp7SOKSAnO3CccxL3(aVFYHlo0QjsqBFxq8ad, rybo1XGzd9ch5SOUQC2H.Code);
								aVFYHlo0QjsqBFxq8ad.Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1346994499 ^ -1346957835);
								list4.Add(aVFYHlo0QjsqBFxq8ad);
								num2 = 12;
							}
							break;
						}
						goto case 12;
					case 2:
						if (!flag || !value.sVYGz3io63y)
						{
							List<AVFYHlo0QjsqBFxq8ad1> list3 = list;
							AVFYHlo0QjsqBFxq8ad1 obj = new AVFYHlo0QjsqBFxq8ad1
							{
								Symbol = rybo1XGzd9ch5SOUQC2H.Code
							};
							Q8vs6iSOrs99nbPePuNa(obj, VFVyinSOUlhLPWhAwe2L(0xECA3F28 ^ 0xECB4C02));
							list3.Add(obj);
							num2 = 35;
							break;
						}
						goto case 37;
					case 37:
						if (flag && !rybo1XGzd9ch5SOUQC2H.sVYGz3io63y)
						{
							goto case 7;
						}
						goto case 35;
					case 12:
					case 17:
						if (!flag)
						{
							value = new Rybo1XGzd9ch5SOUQC2H(rybo1XGzd9ch5SOUQC2H.Symbol, rybo1XGzd9ch5SOUQC2H.Qa2Gz62Cyav());
							value.Code = rybo1XGzd9ch5SOUQC2H.Code;
							num4 = 3;
							goto IL_0069;
						}
						goto IL_031f;
					case 16:
						list = new List<AVFYHlo0QjsqBFxq8ad1>();
						list2 = new List<AVFYHlo0QjsqBFxq8ad1>();
						num2 = 27;
						break;
					case 9:
					case 22:
						if (!xKHYFMKBqTE.HasFlag((HuFXDXYAO3q2epASB3O9)8))
						{
							goto case 35;
						}
						if (rybo1XGzd9ch5SOUQC2H.sVYGz3io63y)
						{
							num2 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
							{
								num2 = 2;
							}
							break;
						}
						goto case 37;
					case 21:
					{
						List<AVFYHlo0QjsqBFxq8ad1> list8 = list;
						AVFYHlo0QjsqBFxq8ad1 aVFYHlo0QjsqBFxq8ad4 = new AVFYHlo0QjsqBFxq8ad1();
						vK3pp7SOKSAnO3CccxL3(aVFYHlo0QjsqBFxq8ad4, rybo1XGzd9ch5SOUQC2H.Code);
						aVFYHlo0QjsqBFxq8ad4.Channel = (string)VFVyinSOUlhLPWhAwe2L(-1801468030 ^ -1801538424);
						list8.Add(aVFYHlo0QjsqBFxq8ad4);
						goto case 5;
					}
					case 1:
						if (flag && value.m54GzFaRoc7)
						{
							num2 = 11;
							break;
						}
						goto case 15;
					case 13:
					case 31:
						{
							if (!xKHYFMKBqTE.HasFlag((HuFXDXYAO3q2epASB3O9)1))
							{
								goto case 5;
							}
							if (!rybo1XGzd9ch5SOUQC2H.kHYGzP3WQN1)
							{
								goto case 34;
							}
							if (flag)
							{
								num2 = 19;
								break;
							}
							goto case 21;
						}
						IL_031f:
						value.m54GzFaRoc7 = rybo1XGzd9ch5SOUQC2H.m54GzFaRoc7;
						num2 = 32;
						break;
						IL_06c5:
						list7 = list;
						obj2 = new AVFYHlo0QjsqBFxq8ad1
						{
							Symbol = rybo1XGzd9ch5SOUQC2H.Code
						};
						Q8vs6iSOrs99nbPePuNa(obj2, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2056710528 ^ -2056680932));
						list7.Add(obj2);
						num2 = 31;
						break;
						IL_0069:
						num2 = num4;
						break;
					}
				}
			}
			catch (Exception obj3)
			{
				int num5 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
				UeQYFAGX1nE?.Invoke(obj3);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(lA9YFOFlB3f);
			}
		}
	}

	private void i2YYFNoiyG8(object P_0, EventArgs P_1)
	{
		zZMYFxiJNXp(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x37B74BDF ^ 0x37B6380B));
		nZPYFyuvE05 = false;
		Action action = bSdYFVdmZuH;
		if (action != null)
		{
			action();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
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

	private void ahBYFkDaJpp(object P_0, EventArgs P_1)
	{
		zZMYFxiJNXp(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-838841832 ^ -838780420));
		JJwYFZLSGdB.Change(-1, -1);
		int num = 2;
		int num2 = num;
		object qcDYFqOCZ8q = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				fTfYFtXDPxf.Clear();
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				bool lockTaken = false;
				try
				{
					Monitor.Enter(qcDYFqOCZ8q, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							HffYFTGldfO = null;
							break;
						default:
							HffYFTGldfO.OnClose -= ahBYFkDaJpp;
							HffYFTGldfO.OnError -= k4WYF1TaaUi;
							HffYFTGldfO.OnMessage -= y7cYF58ZIPG;
							num3 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							if (HffYFTGldfO != null)
							{
								HffYFTGldfO.OnOpen -= i2YYFNoiyG8;
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					if (lockTaken)
					{
						nRWAF0SOA05il1AbF0Zt(qcDYFqOCZ8q);
					}
				}
				if (!nZPYFyuvE05)
				{
					Thread.Sleep(1000);
					lihlfMp6ULY();
				}
				return;
			}
			case 1:
				qcDYFqOCZ8q = QcDYFqOCZ8q;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				P13vV0SO856vMpTNlUsy(kscYFUiI0ob);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void k4WYF1TaaUi(object P_0, ErrorEventArgs P_1)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		int num = 2;
		int num2 = num;
		WebSocket val = default(WebSocket);
		while (true)
		{
			switch (num2)
			{
			case 1:
				val = (WebSocket)((P_0 is WebSocket) ? P_0 : null);
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 2:
			{
				Exception exception = P_1.Exception;
				zZMYFxiJNXp((string)(((exception != null) ? O7eWBZSOP4NU63T1Q4rA(exception) : null) ?? P_1.Message));
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			}
			if ((int)Abv0yeSOJek8njSVXcfL(val) != 1)
			{
				return;
			}
			try
			{
				Ah8LqcSOFKlJanpl0yoK(val);
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				}
				UeQYFAGX1nE?.Invoke((Exception)nHJJSYSO3SvkIq3rclbX(P_1));
				return;
			}
			catch (Exception obj)
			{
				Action<Exception> action = UeQYFAGX1nE;
				if (action != null)
				{
					action(obj);
					int num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				return;
			}
		}
	}

	private void y7cYF58ZIPG(object P_0, MessageEventArgs P_1)
	{
		if (P_1.IsPing)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			m5mYFSnXWet((string)OdwSGOSOpepZ7bembS5V(P_1));
		}
		catch (Exception obj)
		{
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			UeQYFAGX1nE?.Invoke(obj);
		}
	}

	private void m5mYFSnXWet(string P_0)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (P_0 == (string)VFVyinSOUlhLPWhAwe2L(0x3E0426F0 ^ 0x3E04C4E4))
			{
				return;
			}
			string text = default(string);
			JEnumerable<JObject> val = default(JEnumerable<JObject>);
			string key2 = default(string);
			Rybo1XGzd9ch5SOUQC2H value2 = default(Rybo1XGzd9ch5SOUQC2H);
			MarketDepthFullEvent marketDepthFullEvent = default(MarketDepthFullEvent);
			TUEuO1Yu2tTkuI5RCv4W obj3 = default(TUEuO1Yu2tTkuI5RCv4W);
			string key = default(string);
			Rybo1XGzd9ch5SOUQC2H value = default(Rybo1XGzd9ch5SOUQC2H);
			IEnumerator<JObject> enumerator = default(IEnumerator<JObject>);
			while (true)
			{
				YImFoMoGWynW9T5H905Z yImFoMoGWynW9T5H905Z = cxGyMAGPFRTsIrxXZNpt.ziuGPpTmqfM(P_0);
				int num;
				if (string.IsNullOrEmpty(yImFoMoGWynW9T5H905Z.ABEoGyoSLm5) && Y5nskQSOuAy4LpiWp8MH(yImFoMoGWynW9T5H905Z) != null)
				{
					text = yImFoMoGWynW9T5H905Z.mwtoGPiJssR.Channel;
					num = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
					{
						num = 2;
					}
					goto IL_0031;
				}
				goto IL_0824;
				IL_0031:
				while (true)
				{
					int num4;
					switch (num)
					{
					case 3:
						return;
					case 9:
						return;
					case 10:
						return;
					case 13:
						return;
					case 15:
						return;
					case 17:
						return;
					case 21:
						return;
					case 23:
						return;
					case 2:
						break;
					case 1:
						try
						{
							while (true)
							{
								int num3;
								if (lIggMVSq2Y6RXBZoDEoj(enumerator))
								{
									X8tGy9onhsPMCXH31SYX obj2 = (X8tGy9onhsPMCXH31SYX)F418C2Sq0ufLqKmYlVCB(enumerator.Current);
									Action<X8tGy9onhsPMCXH31SYX> action3 = jYAYFraEp2W;
									if (action3 != null)
									{
										action3(obj2);
										continue;
									}
									num3 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
									{
										num3 = 0;
									}
								}
								else
								{
									num3 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
									{
										num3 = 1;
									}
								}
								switch (num3)
								{
								case 1:
									return;
								}
							}
						}
						finally
						{
							if (enumerator != null)
							{
								tAv53pSqHZvnHT10yMjF(enumerator);
							}
						}
					case 8:
						enumerator = val.GetEnumerator();
						num = 6;
						continue;
					case 11:
						kscYFUiI0ob[key2].odClvnSDwKl((Symbol)EG5lghSqnXsshyncjly5(value2), marketDepthFullEvent);
						num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
						{
							num = 0;
						}
						continue;
					case 25:
						marketDepthFullEvent.Version.vNpG3X8YCxF();
						num = 11;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
						{
							num = 7;
						}
						continue;
					case 24:
						marketDepthFullEvent = IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk(value2.Symbol);
						num = 25;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
						{
							num = 13;
						}
						continue;
					case 26:
						if (yImFoMoGWynW9T5H905Z.Action == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1487846E ^ 0x1486F79A))
						{
							num = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
							{
								num = 4;
							}
							continue;
						}
						goto case 7;
					case 6:
						try
						{
							while (true)
							{
								int num5;
								if (!enumerator.MoveNext())
								{
									num5 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
									{
										num5 = 0;
									}
								}
								else
								{
									obj3 = cxGyMAGPFRTsIrxXZNpt.fYuGJ0BqGB5(enumerator.Current);
									num5 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
									{
										num5 = 1;
									}
								}
								switch (num5)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									G9IYFw5u9La?.Invoke(obj3);
									break;
								}
							}
						}
						finally
						{
							enumerator?.Dispose();
						}
					case 20:
						val = ((JToken)DNxQptSqfTLJL5rgpCYF(yImFoMoGWynW9T5H905Z)).Children<JObject>();
						num4 = 19;
						goto IL_002d;
					case 19:
						enumerator = val.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								AEMJjhonHIXgcruji9oy aEMJjhonHIXgcruji9oy = cxGyMAGPFRTsIrxXZNpt.hHYGJHoJv4O(enumerator.Current);
								kscYFUiI0ob.Add(key, new XaQvAHYJQjbrDJbfH8Zs(aEMJjhonHIXgcruji9oy, value.Symbol));
							}
						}
						finally
						{
							if (enumerator != null)
							{
								tAv53pSqHZvnHT10yMjF(enumerator);
							}
						}
						goto case 16;
					case 4:
						key = ((zbsNOPoYxNACXhXG43y2)Y5nskQSOuAy4LpiWp8MH(yImFoMoGWynW9T5H905Z)).Symbol;
						if (!fTfYFtXDPxf.TryGetValue(key, out value))
						{
							num = 4;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
							{
								num = 15;
							}
							continue;
						}
						if (!kscYFUiI0ob.ContainsKey(key))
						{
							goto case 20;
						}
						goto case 16;
					case 12:
						if (!fTfYFtXDPxf.TryGetValue(key2, out value2))
						{
							return;
						}
						if (kscYFUiI0ob.ContainsKey(key2))
						{
							val = ((JToken)yImFoMoGWynW9T5H905Z.EZeoG35YPMI).Children<JObject>();
							num = 22;
							continue;
						}
						goto case 24;
					case 27:
						goto end_IL_0031;
					case 14:
						goto IL_0824;
					case 16:
					{
						MarketDepthFullEvent marketDepthFullEvent2 = IlvHiXGF9pA6U4gUK5bq.GElGFDDmQlk(value.Symbol);
						((syh8dIG3xetxRkGYZ5kB)vACoZeSq9RBsHrcIlwVj(marketDepthFullEvent2)).vNpG3X8YCxF();
						kscYFUiI0ob[key].odClvnSDwKl((Symbol)EG5lghSqnXsshyncjly5(value), marketDepthFullEvent2);
						Action<MarketDepthFullEvent> action2 = Ji9YFm5Ocqf;
						if (action2 == null)
						{
							num = 3;
							continue;
						}
						action2(marketDepthFullEvent2);
						return;
					}
					case 18:
						enumerator = ((JToken)yImFoMoGWynW9T5H905Z.EZeoG35YPMI).Children<JObject>().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								while (true)
								{
									ycnf2IoYQUWKIM1CocU9 obj4 = cxGyMAGPFRTsIrxXZNpt.HmuGPzrH6My(enumerator.Current);
									Action<ycnf2IoYQUWKIM1CocU9> action4 = rrwYFKhrKkh;
									if (action4 != null)
									{
										action4(obj4);
										int num7 = 0;
										if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 1:
											continue;
										}
									}
									break;
								}
							}
							return;
						}
						finally
						{
							if (enumerator != null)
							{
								tAv53pSqHZvnHT10yMjF(enumerator);
								int num8 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
								{
									num8 = 0;
								}
								switch (num8)
								{
								case 0:
									break;
								}
							}
						}
					case 7:
						if (!((string)hZvMu7SqG8N2kxT46lB2(yImFoMoGWynW9T5H905Z) == (string)VFVyinSOUlhLPWhAwe2L(0x16AD7E76 ^ 0x16AC0A7E)))
						{
							return;
						}
						key2 = (string)Cjq014SqYeKR9UaQgikH(yImFoMoGWynW9T5H905Z.mwtoGPiJssR);
						num4 = 12;
						goto IL_002d;
					default:
						goto IL_0936;
					case 22:
						enumerator = val.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								AEMJjhonHIXgcruji9oy aEMJjhonHIXgcruji9oy2 = cxGyMAGPFRTsIrxXZNpt.hHYGJHoJv4O(enumerator.Current);
								kscYFUiI0ob[key2].TBJYJgovona(aEMJjhonHIXgcruji9oy2, value2.Symbol);
							}
							int num6 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
						finally
						{
							enumerator?.Dispose();
						}
						goto case 24;
					case 5:
						{
							if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1416986301 ^ -1416891831)))
							{
								if (!(text == (string)VFVyinSOUlhLPWhAwe2L(0x50C1C840 ^ 0x50C154DC)))
								{
									if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225752825))
									{
										break;
									}
									if (!FT1mjWSOzLoSTfL8KdWI(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x404ED0BE ^ 0x404FA3F6)))
									{
										if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xC1DDB3B ^ 0xC1CA827)))
										{
											return;
										}
										goto case 26;
									}
									enumerator = ((JToken)yImFoMoGWynW9T5H905Z.EZeoG35YPMI).Children<JObject>().GetEnumerator();
									try
									{
										while (enumerator.MoveNext())
										{
											vHtWHMYphTAdhJW7CR80 obj = cxGyMAGPFRTsIrxXZNpt.SCfGJ2olq1d(enumerator.Current);
											int num2 = 0;
											if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
											{
												num2 = 0;
											}
											while (true)
											{
												switch (num2)
												{
												default:
												{
													Action<vHtWHMYphTAdhJW7CR80> action = kW6YF7aDsxO;
													if (action == null)
													{
														num2 = 1;
														if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
														{
															num2 = 1;
														}
														continue;
													}
													action(obj);
													break;
												}
												case 1:
													break;
												}
												break;
											}
										}
										return;
									}
									finally
									{
										if (enumerator != null)
										{
											tAv53pSqHZvnHT10yMjF(enumerator);
										}
									}
								}
								goto case 18;
							}
							val = ((JToken)yImFoMoGWynW9T5H905Z.EZeoG35YPMI).Children<JObject>();
							enumerator = val.GetEnumerator();
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
							{
								num = 0;
							}
							continue;
						}
						IL_002d:
						num = num4;
						continue;
					}
					val = ((JToken)yImFoMoGWynW9T5H905Z.EZeoG35YPMI).Children<JObject>();
					num = 6;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
					{
						num = 8;
					}
					continue;
					IL_0936:
					Action<MarketDepthFullEvent> action5 = Ji9YFm5Ocqf;
					if (action5 == null)
					{
						num = 10;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
						{
							num = 6;
						}
					}
					else
					{
						action5(marketDepthFullEvent);
						num = 23;
					}
					continue;
					end_IL_0031:
					break;
				}
				continue;
				IL_0824:
				if (hOVWmlSqoqyD3xskBB0g(yImFoMoGWynW9T5H905Z) == 0 && !(yImFoMoGWynW9T5H905Z.ABEoGyoSLm5 == (string)VFVyinSOUlhLPWhAwe2L(0x78D396D8 ^ 0x78D2A320)))
				{
					break;
				}
				if (!string.IsNullOrEmpty(yImFoMoGWynW9T5H905Z.Message))
				{
					Action<string, bool> action6 = ARXYF86hHWC;
					if (action6 == null)
					{
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
						{
							num = 21;
						}
					}
					else
					{
						action6(yImFoMoGWynW9T5H905Z.ABEoGyoSLm5 + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2074141628 ^ -2074101784) + yImFoMoGWynW9T5H905Z.Message, arg2: false);
						num = 5;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
						{
							num = 17;
						}
					}
				}
				else
				{
					num = 13;
				}
				goto IL_0031;
			}
		}
		catch (Exception obj5)
		{
			Action<Exception> action7 = UeQYFAGX1nE;
			if (action7 != null)
			{
				action7(obj5);
				int num9 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
				{
					num9 = 0;
				}
				switch (num9)
				{
				case 0:
					break;
				}
			}
		}
	}

	public void zZMYFxiJNXp(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				cVQYFCfQg2a?.Invoke(y37YFEMi9Ow + (string)VFVyinSOUlhLPWhAwe2L(0x6EC99CAF ^ 0x6EC93703) + P_0);
				return;
			case 1:
				if (LSgYFcbNtiB)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			}
		}
	}

	static XGGQ8pYFa2yVBpVUAYAi()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		RhVjdXSqvrnw7eHcigto();
	}

	internal static WebSocketState oEEYSkSOWsb2xS6r0cv6(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static bool cnHrngSOtZMCylvBT7wK(object P_0)
	{
		return ((WebSocket)P_0).IsAlive;
	}

	internal static object VFVyinSOUlhLPWhAwe2L(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool jupI0sSOqidvxSuopFqB()
	{
		return OG8ptvSOORxE4uGvxNx8 == null;
	}

	internal static XGGQ8pYFa2yVBpVUAYAi ENVs7VSOIOLSc0sAeY2v()
	{
		return OG8ptvSOORxE4uGvxNx8;
	}

	internal static void kSVhBpSOTfsqbJFnpjuQ(object P_0, TimeSpan P_1)
	{
		((WebSocket)P_0).WaitTime = P_1;
	}

	internal static bool D9tToxSOyEgnivbCpASQ(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).TRAaE0bpPZ4();
	}

	internal static void yP9ynoSOZn25u0cLDuAR(object P_0, object P_1, object P_2, object P_3)
	{
		((WebSocket)P_0).SetProxy((string)P_1, (string)P_2, (string)P_3);
	}

	internal static void mxwULsSOV1wlKayPIRrO(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static object EWTg3bSOCXKPrIKDuwKo(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Code;
	}

	internal static void Q8vs6iSOrs99nbPePuNa(object P_0, object P_1)
	{
		((AVFYHlo0QjsqBFxq8ad1)P_0).Channel = (string)P_1;
	}

	internal static void vK3pp7SOKSAnO3CccxL3(object P_0, object P_1)
	{
		((AVFYHlo0QjsqBFxq8ad1)P_0).Symbol = (string)P_1;
	}

	internal static int FtmFfTSOmnmxirLgLQM9(object P_0)
	{
		return ((List<AVFYHlo0QjsqBFxq8ad1>)P_0).Count;
	}

	internal static object ngKNDdSOhvba6JloLUsr(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object gEL4mgSOwokUcJ4JvF0n(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static void J8UqEvSO76LlciYKSKRH(object P_0, object P_1)
	{
		((WebSocket)P_0).Send((string)P_1);
	}

	internal static void P13vV0SO856vMpTNlUsy(object P_0)
	{
		((Dictionary<string, XaQvAHYJQjbrDJbfH8Zs>)P_0).Clear();
	}

	internal static void nRWAF0SOA05il1AbF0Zt(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object O7eWBZSOP4NU63T1Q4rA(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static WebSocketState Abv0yeSOJek8njSVXcfL(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static void Ah8LqcSOFKlJanpl0yoK(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static object nHJJSYSO3SvkIq3rclbX(object P_0)
	{
		return ((ErrorEventArgs)P_0).Exception;
	}

	internal static object OdwSGOSOpepZ7bembS5V(object P_0)
	{
		return ((MessageEventArgs)P_0).Data;
	}

	internal static object Y5nskQSOuAy4LpiWp8MH(object P_0)
	{
		return ((YImFoMoGWynW9T5H905Z)P_0).mwtoGPiJssR;
	}

	internal static bool FT1mjWSOzLoSTfL8KdWI(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object F418C2Sq0ufLqKmYlVCB(object P_0)
	{
		return cxGyMAGPFRTsIrxXZNpt.r78GPueS5qH((JObject)P_0);
	}

	internal static bool lIggMVSq2Y6RXBZoDEoj(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void tAv53pSqHZvnHT10yMjF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object DNxQptSqfTLJL5rgpCYF(object P_0)
	{
		return ((YImFoMoGWynW9T5H905Z)P_0).EZeoG35YPMI;
	}

	internal static object vACoZeSq9RBsHrcIlwVj(object P_0)
	{
		return ((MarketDepthDiffEvent)P_0).Version;
	}

	internal static object EG5lghSqnXsshyncjly5(object P_0)
	{
		return ((Rybo1XGzd9ch5SOUQC2H)P_0).Symbol;
	}

	internal static object hZvMu7SqG8N2kxT46lB2(object P_0)
	{
		return ((YImFoMoGWynW9T5H905Z)P_0).Action;
	}

	internal static object Cjq014SqYeKR9UaQgikH(object P_0)
	{
		return ((zbsNOPoYxNACXhXG43y2)P_0).Symbol;
	}

	internal static int hOVWmlSqoqyD3xskBB0g(object P_0)
	{
		return ((YImFoMoGWynW9T5H905Z)P_0).Code;
	}

	internal static void RhVjdXSqvrnw7eHcigto()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
