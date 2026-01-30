using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Threading;
using BfZtb759KlUg4482QKym;
using gYq6H0oWkT0kbqdORSkk;
using i7JYExodxX02E86fJ5ex;
using JOl4xjoI7GcXZYP5wxVs;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using r8oOHiajFPNBXu6XiAHj;
using ryJZvwoQgJCVAqV5lkPr;
using TigerTrade.Core.Utils.Logging;
using WebSocketSharp;
using WebSocketSharp.Net;
using x97CE55GhEYKgt7TSVZT;
using Yl86fCogSBylgpGlmYSN;

namespace YuSNkwoRuJIr7p64GaQ4;

internal class UM9VZQoRpM2cbJoaXyID
{
	private readonly Action<string> ecoo6oBX3Jy;

	private readonly Action<bool> UyAo6vQuInT;

	private readonly Action<bool> a5ro6BFbftg;

	private readonly Action<object, string> zioo6anpvA6;

	private readonly Action<Exception> awYo6insPu9;

	private readonly JxtCu1odSeiVhALcwIWc Dt2o6lHacWb;

	private readonly Timer L4do64MeZdc;

	private readonly ld5C00og5BCZZfCQqfJd PVdo6DyBTd3;

	private WebSocket tQGo6bRRIn9;

	private readonly C3trUsajJIHJMtdo9pBg zx0o6N8xeob;

	private readonly mysGYhoQd9e8jCPK96PH jDoo6kLkiUX;

	private bool VYFo61xJCGa;

	private readonly string eNro65ME9vF;

	internal static UM9VZQoRpM2cbJoaXyID S74sBrSAetJv131oKb6q;

	public UM9VZQoRpM2cbJoaXyID(string P_0, ld5C00og5BCZZfCQqfJd P_1, C3trUsajJIHJMtdo9pBg P_2, JxtCu1odSeiVhALcwIWc P_3, mysGYhoQd9e8jCPK96PH P_4, Action<bool> P_5, Action<bool> P_6, Action<object, string> P_7, Action<string> P_8, Action<Exception> P_9)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		eNro65ME9vF = P_0;
		PVdo6DyBTd3 = P_1;
		Dt2o6lHacWb = P_3;
		zx0o6N8xeob = P_2;
		jDoo6kLkiUX = P_4;
		L4do64MeZdc = new Timer(Tj0oRzoNZgw, null, -1, -1);
		ecoo6oBX3Jy = P_8;
		UyAo6vQuInT = P_5;
		a5ro6BFbftg = P_6;
		zioo6anpvA6 = P_7;
		awYo6insPu9 = P_9;
	}

	private void Tj0oRzoNZgw(object P_0)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected I4, but got Unknown
		WebSocket obj = tQGo6bRRIn9;
		WebSocketState? val = ((obj != null) ? new WebSocketState?(obj.ReadyState) : ((WebSocketState?)null));
		WebSocketState valueOrDefault = default(WebSocketState);
		int num2;
		if (val.HasValue)
		{
			valueOrDefault = val.GetValueOrDefault();
			int num = 4;
			num2 = num;
			goto IL_0009;
		}
		goto IL_00a1;
		IL_00a1:
		if (Dt2o6lHacWb == (JxtCu1odSeiVhALcwIWc)0)
		{
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		goto IL_00f3;
		IL_00f3:
		string text = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x78D396D8 ^ 0x78D20618);
		goto IL_0183;
		IL_016d:
		text = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB14E8B8);
		goto IL_0183;
		IL_0183:
		string text2 = text;
		num2 = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
		{
			num2 = 1;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 5:
			{
				WebSocket obj2 = tQGo6bRRIn9;
				if (obj2 != null)
				{
					obj2.CloseAsync();
				}
				return;
			}
			case 2:
			case 3:
				break;
			case 4:
				goto IL_00c6;
			case 6:
				goto IL_00f3;
			default:
				goto IL_016d;
			case 1:
			{
				Action<string> action = ecoo6oBX3Jy;
				if (action == null)
				{
					goto case 5;
				}
				action(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4220DA8 ^ 0x4236FF2) + text2 + (string)P9EJyUSAcF9DUGTG27n7(-342738082 ^ -342664902));
				num2 = 5;
				continue;
			}
			}
			break;
			IL_00c6:
			switch ((int)valueOrDefault)
			{
			case 0:
			case 2:
				return;
			default:
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				break;
			}
			WebSocket obj3 = tQGo6bRRIn9;
			if (obj3 != null)
			{
				if (!obj3.IsAlive)
				{
					break;
				}
				return;
			}
			num2 = 2;
		}
		goto IL_00a1;
	}

	public void IQ9o608K5X9()
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		L4do64MeZdc.Change(-1, -1);
		if (tQGo6bRRIn9 != null)
		{
			return;
		}
		WebSocket val = new WebSocket(eNro65ME9vF, Array.Empty<string>());
		Fm08uWSAjwxUa9X0cxmA((object)val, true);
		val.WaitTime = TimeSpan.FromSeconds(10.0);
		tQGo6bRRIn9 = val;
		pH3UrvSAEo1Cq3sTBci1(tQGo6bRRIn9.SslConfiguration, SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12);
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				tQGo6bRRIn9.OnClose += delegate(object P_0, CloseEventArgs P_1)
				{
					L4do64MeZdc.Change(-1, -1);
					a5ro6BFbftg(obj: false);
					Action<string> action = ecoo6oBX3Jy;
					int num4;
					if (action == null)
					{
						num4 = 2;
						goto IL_0009;
					}
					action(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--500511424 ^ 0x1DD45024), tQGo6bRRIn9.Url, fn1hXdSAI49tiKpow9QE(P_1), P_1.Code));
					goto IL_006a;
					IL_006a:
					tQGo6bRRIn9 = null;
					num4 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
					{
						num4 = 0;
					}
					goto IL_0009;
					IL_0009:
					while (true)
					{
						switch (num4)
						{
						default:
							if (VYFo61xJCGa)
							{
								return;
							}
							Thread.Sleep(1000);
							IQ9o608K5X9();
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
							{
								num4 = 1;
							}
							continue;
						case 2:
							break;
						case 1:
							return;
						}
						break;
					}
					goto IL_006a;
				};
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
				{
					num = 2;
				}
				continue;
			case 1:
			{
				if (zx0o6N8xeob.TRAaE0bpPZ4())
				{
					caqGZhSAQ3lIJbQ7KHmf(tQGo6bRRIn9, zx0o6N8xeob.Url, zx0o6N8xeob.OCiaEYswnjC(), zx0o6N8xeob.Password);
				}
				tQGo6bRRIn9.OnOpen += delegate
				{
					int num4 = 1;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						case 1:
							L4do64MeZdc.Change(TimeSpan.FromSeconds(10.0), TimeSpan.FromSeconds(20.0));
							num5 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
							{
								num5 = 0;
							}
							break;
						case 2:
							VYFo61xJCGa = false;
							QILo624OUZJ();
							return;
						default:
						{
							Action<bool> uyAo6vQuInT = UyAo6vQuInT;
							if (uyAo6vQuInT != null)
							{
								uyAo6vQuInT(obj: false);
								num5 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
								{
									num5 = 2;
								}
								break;
							}
							goto case 2;
						}
						}
					}
				};
				int num2 = 3;
				num = num2;
				continue;
			}
			case 2:
				tQGo6bRRIn9.OnError += delegate(object P_0, ErrorEventArgs P_1)
				{
					//IL_001d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0023: Invalid comparison between Unknown and I4
					WebSocket val2 = (WebSocket)((P_0 is WebSocket) ? P_0 : null);
					if (val2 != null)
					{
						int num4;
						if ((int)val2.ReadyState != 1)
						{
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
							{
								num4 = 1;
							}
						}
						else
						{
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
							{
								num4 = 0;
							}
						}
						switch (num4)
						{
						default:
							try
							{
								val2.CloseAsync();
								Action<string> action = ecoo6oBX3Jy;
								if (action != null)
								{
									action(string.Format((string)P9EJyUSAcF9DUGTG27n7(-894902996 ^ -894874464), val2.Url, P_1.Message));
									int num5 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								break;
							}
							catch (Exception obj2)
							{
								awYo6insPu9(obj2);
								break;
							}
						case 1:
							break;
						}
					}
				};
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
				{
					num = 0;
				}
				continue;
			}
			tQGo6bRRIn9.OnMessage += delegate(object P_0, MessageEventArgs P_1)
			{
				if (!P_1.IsPing)
				{
					try
					{
						zioo6anpvA6(this, (string)LSrYnqSAW9lUmWfsRWfY(P_1));
					}
					catch (Exception)
					{
					}
				}
			};
			try
			{
				tQGo6bRRIn9.ConnectAsync();
				return;
			}
			catch (Exception)
			{
				WebSocket obj = tQGo6bRRIn9;
				if (obj != null)
				{
					pRBuaDSAdTJ80j3FJpdP(obj);
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				return;
			}
		}
	}

	private void QILo624OUZJ()
	{
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Invalid comparison between Unknown and I4
		try
		{
			if (tQGo6bRRIn9 == null)
			{
				goto IL_00cb;
			}
			goto IL_01b4;
			IL_00cb:
			LogManager.WriteInfo(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1999650146 ^ -1999721028));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
			{
				num = 1;
			}
			goto IL_0015;
			IL_01b4:
			object obj;
			if ((int)KMEfj1SAgSssnZiFXeTy(tQGo6bRRIn9) == 1)
			{
				if (Dt2o6lHacWb != 0)
				{
					int num2 = 4;
					num = num2;
					goto IL_0015;
				}
				obj = P9EJyUSAcF9DUGTG27n7(-225822163 ^ -225727745);
				goto IL_0284;
			}
			goto IL_00cb;
			IL_0015:
			JxtCu1odSeiVhALcwIWc dt2o6lHacWb = default(JxtCu1odSeiVhALcwIWc);
			string text = default(string);
			while (true)
			{
				switch (num)
				{
				case 5:
					if (dt2o6lHacWb != (JxtCu1odSeiVhALcwIWc)1)
					{
						num = 3;
						continue;
					}
					goto default;
				case 2:
					break;
				case 4:
					goto end_IL_0015;
				default:
					SQSo6fW6WDQ(JsonConvert.SerializeObject((object)FARo6HjQBdM((string)idKd9LSA68Sq61lCA6Ss(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28A2CF6)))));
					num = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
					{
						num = 6;
					}
					continue;
				case 3:
					return;
				case 7:
					goto IL_01b4;
				case 1:
					return;
				case 6:
					SQSo6fW6WDQ(JsonConvert.SerializeObject((object)FARo6HjQBdM(text + (string)P9EJyUSAcF9DUGTG27n7(-1962651919 ^ -1962549339))));
					return;
				}
				SQSo6fW6WDQ((string)UVTd81SAR3w5qYptsubo(FARo6HjQBdM(text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1848952786 ^ -1848989456))));
				SQSo6fW6WDQ(JsonConvert.SerializeObject((object)FARo6HjQBdM(text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380496528))));
				SQSo6fW6WDQ(JsonConvert.SerializeObject((object)FARo6HjQBdM((string)idKd9LSA68Sq61lCA6Ss(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC80DA5)))));
				dt2o6lHacWb = Dt2o6lHacWb;
				if (dt2o6lHacWb != 0)
				{
					num = 5;
					continue;
				}
				SQSo6fW6WDQ(JsonConvert.SerializeObject((object)FARo6HjQBdM(text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7394D272 ^ 0x73954352))));
				return;
				continue;
				end_IL_0015:
				break;
			}
			obj = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC80C6F);
			goto IL_0284;
			IL_0284:
			text = (string)obj;
			num = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
			{
				num = 2;
			}
			goto IL_0015;
		}
		catch (Exception obj2)
		{
			awYo6insPu9(obj2);
		}
	}

	private Q5ZOdcoIwkUwANZfr752 FARo6HjQBdM(string P_0)
	{
		Q5ZOdcoIwkUwANZfr752 q5ZOdcoIwkUwANZfr = new Q5ZOdcoIwkUwANZfr752();
		q5ZOdcoIwkUwANZfr.Timestamp = UxJ148SAMEgrtViqpLjF(PVdo6DyBTd3);
		FAv4aFSAOjyu4r5dfqcQ(q5ZOdcoIwkUwANZfr, P_0);
		q5ZOdcoIwkUwANZfr.Symbols = JArray.FromObject((object)new string[1] { F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894874558) });
		q5ZOdcoIwkUwANZfr.efAoIuDZsdt = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-624753169 ^ -624789877);
		int num = 2;
		int num2 = num;
		Q5ZOdcoIwkUwANZfr752 q5ZOdcoIwkUwANZfr2 = default(Q5ZOdcoIwkUwANZfr752);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return q5ZOdcoIwkUwANZfr2;
			case 2:
				q5ZOdcoIwkUwANZfr2 = q5ZOdcoIwkUwANZfr;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			q5ZOdcoIwkUwANZfr2.TE5oWfCcJGU = new MaKfLsoWNZlQ5mBBxMJG
			{
				z9uoWSoeiJS = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1251569705 ^ -1251533139),
				nUcoWe98ZSb = jDoo6kLkiUX.zSToQykxI7I,
				GCNoWcM7BEe = PVdo6DyBTd3.jhhogExh0jq(P_0, (string)G7ovPRSAqPBWQKrN9ADN(q5ZOdcoIwkUwANZfr2))
			};
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
			{
				num2 = 1;
			}
		}
	}

	public void Disconnect()
	{
		L4do64MeZdc.Change(-1, -1);
		VYFo61xJCGa = true;
		WebSocket obj = tQGo6bRRIn9;
		if (obj != null)
		{
			pRBuaDSAdTJ80j3FJpdP(obj);
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

	private void SQSo6fW6WDQ(string P_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		if (tQGo6bRRIn9 == null)
		{
			return;
		}
		if ((int)tQGo6bRRIn9.ReadyState != 1)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
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
			tQGo6bRRIn9.Send(P_0);
		}
	}

	[CompilerGenerated]
	private void uaTo69hku00(object P_0, EventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				L4do64MeZdc.Change(TimeSpan.FromSeconds(10.0), TimeSpan.FromSeconds(20.0));
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				VYFo61xJCGa = false;
				QILo624OUZJ();
				return;
			default:
			{
				Action<bool> uyAo6vQuInT = UyAo6vQuInT;
				if (uyAo6vQuInT == null)
				{
					goto case 2;
				}
				uyAo6vQuInT(obj: false);
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num2 = 2;
				}
				break;
			}
			}
		}
	}

	[CompilerGenerated]
	private void QT2o6niO9IO(object P_0, CloseEventArgs P_1)
	{
		L4do64MeZdc.Change(-1, -1);
		a5ro6BFbftg(obj: false);
		Action<string> action = ecoo6oBX3Jy;
		int num;
		if (action == null)
		{
			num = 2;
			goto IL_0009;
		}
		action(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--500511424 ^ 0x1DD45024), tQGo6bRRIn9.Url, fn1hXdSAI49tiKpow9QE(P_1), P_1.Code));
		goto IL_006a;
		IL_006a:
		tQGo6bRRIn9 = null;
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				if (VYFo61xJCGa)
				{
					return;
				}
				Thread.Sleep(1000);
				IQ9o608K5X9();
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
				{
					num = 1;
				}
				continue;
			case 2:
				break;
			case 1:
				return;
			}
			break;
		}
		goto IL_006a;
	}

	[CompilerGenerated]
	private void y3Yo6GkS90J(object P_0, ErrorEventArgs P_1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		WebSocket val = (WebSocket)((P_0 is WebSocket) ? P_0 : null);
		if (val == null)
		{
			return;
		}
		int num;
		if ((int)val.ReadyState != 1)
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			return;
		}
		try
		{
			val.CloseAsync();
			Action<string> action = ecoo6oBX3Jy;
			if (action != null)
			{
				action(string.Format((string)P9EJyUSAcF9DUGTG27n7(-894902996 ^ -894874464), val.Url, P_1.Message));
				int num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
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
			awYo6insPu9(obj);
		}
	}

	[CompilerGenerated]
	private void vlNo6YYwIJu(object P_0, MessageEventArgs P_1)
	{
		if (!P_1.IsPing)
		{
			try
			{
				zioo6anpvA6(this, (string)LSrYnqSAW9lUmWfsRWfY(P_1));
			}
			catch (Exception)
			{
			}
		}
	}

	static UM9VZQoRpM2cbJoaXyID()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object P9EJyUSAcF9DUGTG27n7(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool gQ8ARYSAsQq8sudivhag()
	{
		return S74sBrSAetJv131oKb6q == null;
	}

	internal static UM9VZQoRpM2cbJoaXyID vt60AuSAXRwEJgvJRiTR()
	{
		return S74sBrSAetJv131oKb6q;
	}

	internal static void Fm08uWSAjwxUa9X0cxmA(object P_0, bool P_1)
	{
		((WebSocket)P_0).EmitOnPing = P_1;
	}

	internal static void pH3UrvSAEo1Cq3sTBci1(object P_0, SslProtocols P_1)
	{
		((SslConfiguration)P_0).EnabledSslProtocols = P_1;
	}

	internal static void caqGZhSAQ3lIJbQ7KHmf(object P_0, object P_1, object P_2, object P_3)
	{
		((WebSocket)P_0).SetProxy((string)P_1, (string)P_2, (string)P_3);
	}

	internal static void pRBuaDSAdTJ80j3FJpdP(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static WebSocketState KMEfj1SAgSssnZiFXeTy(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static object UVTd81SAR3w5qYptsubo(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static object idKd9LSA68Sq61lCA6Ss(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static long UxJ148SAMEgrtViqpLjF(object P_0)
	{
		return ((ld5C00og5BCZZfCQqfJd)P_0).FuFogjl8iiJ();
	}

	internal static void FAv4aFSAOjyu4r5dfqcQ(object P_0, object P_1)
	{
		((Q5ZOdcoIwkUwANZfr752)P_0).Channel = (string)P_1;
	}

	internal static object G7ovPRSAqPBWQKrN9ADN(object P_0)
	{
		return ((Q5ZOdcoIwkUwANZfr752)P_0).efAoIuDZsdt;
	}

	internal static object fn1hXdSAI49tiKpow9QE(object P_0)
	{
		return ((CloseEventArgs)P_0).Reason;
	}

	internal static object LSrYnqSAW9lUmWfsRWfY(object P_0)
	{
		return ((MessageEventArgs)P_0).Data;
	}
}
