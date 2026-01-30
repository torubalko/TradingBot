using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Threading;
using A615taB9Dn9X4ZlrS2SG;
using BfZtb759KlUg4482QKym;
using BwTK9rB9QZ8TYXLbIBVh;
using F9lAiDvP8LdJOg11NREc;
using JuUXiOv8tVDABRiHIaX9;
using K1GcsD5GTtMSlaiJI0Xh;
using mGmyqpBn2CCsA6rjAWw8;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using r8oOHiajFPNBXu6XiAHj;
using RtCXbxvAuJkcnRd34jg6;
using TigerTrade.Core.Utils.Logging;
using WebSocketSharp;
using WebSocketSharp.Net;
using x97CE55GhEYKgt7TSVZT;
using zKdTLMBnv01NQQvU9PJQ;

namespace bNNfcQvF4ycs8EP6LKbI;

internal class lrPIk5vFlRbGZRrD6DiR
{
	private readonly string JZYvFdLSP8S;

	private readonly Action<string> F4evFgLftRo;

	private readonly Action<bool> hP0vFRy3PAL;

	private readonly Action<bool> snJvF64Te8i;

	private readonly Action<object, string> ImZvFM7xB9G;

	private readonly Action<Exception> A49vFO9yrwH;

	private readonly VH7JW8vApym1OZCRtCpJ EgLvFq4gLq8;

	private readonly Timer QFivFIOVXAc;

	private readonly aYvUgmvP7otWQ7LUnwrT kjVvFWHSHf2;

	private WebSocket o90vFt1YarJ;

	private readonly C3trUsajJIHJMtdo9pBg YA2vFUtG6iF;

	private readonly VZf1b9v8WmBe1KShgpKC zakvFTijBKG;

	private bool XukvFy8kKWm;

	private static lrPIk5vFlRbGZRrD6DiR NZCDAVx5hE8u8WJKILIn;

	public lrPIk5vFlRbGZRrD6DiR(string P_0, aYvUgmvP7otWQ7LUnwrT P_1, C3trUsajJIHJMtdo9pBg P_2, VH7JW8vApym1OZCRtCpJ P_3, VZf1b9v8WmBe1KShgpKC P_4, Action<bool> P_5, Action<bool> P_6, Action<object, string> P_7, Action<string> P_8, Action<Exception> P_9)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		JZYvFdLSP8S = P_0;
		kjVvFWHSHf2 = P_1;
		EgLvFq4gLq8 = P_3;
		YA2vFUtG6iF = P_2;
		zakvFTijBKG = P_4;
		QFivFIOVXAc = new Timer(uAGvFDCJnFg, null, -1, -1);
		F4evFgLftRo = P_8;
		hP0vFRy3PAL = P_5;
		snJvF64Te8i = P_6;
		ImZvFM7xB9G = P_7;
		A49vFO9yrwH = P_9;
	}

	private void uAGvFDCJnFg(object P_0)
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		WebSocket obj = o90vFt1YarJ;
		WebSocketState? val = default(WebSocketState?);
		int num;
		if (obj == null)
		{
			val = null;
			num = 5;
			goto IL_0009;
		}
		WebSocketState? val2 = obj.ReadyState;
		goto IL_0187;
		IL_0187:
		WebSocketState? val3 = val2;
		num = 4;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				if ((int)bSXSHBx5Aar6OFw9dUkx(o90vFt1YarJ) != 1)
				{
					return;
				}
				Aj0oHLx5PHqVxVybtrOt(o90vFt1YarJ, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-838841832 ^ -838784984));
				num = 7;
				continue;
			case 7:
				return;
			default:
			{
				string text = ((EgLvFq4gLq8 == (VH7JW8vApym1OZCRtCpJ)0) ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6D18F862 ^ 0x6D1968B0) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC80C6F));
				F4evFgLftRo?.Invoke((string)tllDctx5JeBBCiCr8Den(0x7F55E538 ^ 0x7F548762) + text + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x32DEA4F1 ^ 0x32DFC695));
				WebSocket obj3 = o90vFt1YarJ;
				if (obj3 != null)
				{
					obj3.CloseAsync();
					return;
				}
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
				{
					num = 1;
				}
				continue;
			}
			case 4:
				if (val3.HasValue)
				{
					num = 6;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
					{
						num = 1;
					}
					continue;
				}
				goto default;
			case 6:
			{
				WebSocketState valueOrDefault = val3.GetValueOrDefault();
				switch ((int)valueOrDefault)
				{
				default:
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
					{
						num = 0;
					}
					continue;
				case 0:
				case 2:
					break;
				case 1:
				{
					WebSocket obj2 = o90vFt1YarJ;
					if (obj2 == null || !LI7wC1x5823lDA7BX1RY(obj2))
					{
						num = 2;
						continue;
					}
					break;
				}
				}
				goto case 3;
			}
			case 5:
				break;
			case 1:
				return;
			}
			break;
		}
		val2 = val;
		goto IL_0187;
	}

	public void bRLvFbrpdSL()
	{
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		UbcLpQx5FJZ6ilplAcAl(QFivFIOVXAc, -1, -1);
		if (o90vFt1YarJ != null)
		{
			return;
		}
		o90vFt1YarJ = new WebSocket(JZYvFdLSP8S, Array.Empty<string>())
		{
			EmitOnPing = true,
			WaitTime = XBeJnux53EQ8XkM7OL8Q(10.0)
		};
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				try
				{
					o90vFt1YarJ.ConnectAsync();
					return;
				}
				catch (Exception ex)
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
					{
						num2 = 2;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
						{
							Action<Exception> a49vFO9yrwH = A49vFO9yrwH;
							if (a49vFO9yrwH == null)
							{
								break;
							}
							a49vFO9yrwH(new Exception(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7EB4C5) + ex.Message));
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
							{
								num2 = 0;
							}
							continue;
						}
						case 2:
						{
							Action<string> f4evFgLftRo = F4evFgLftRo;
							if (f4evFgLftRo == null)
							{
								num2 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							f4evFgLftRo(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4662F6AF ^ 0x466331F1) + ex.Message);
							goto case 1;
						}
						}
						break;
					}
					WebSocket obj = o90vFt1YarJ;
					if (obj != null)
					{
						spSANxxS2XcKJVFGiW70(obj);
					}
					return;
				}
			case 3:
				return;
			case 1:
				PS9Bjpx5pNHaWXWtwqtL(o90vFt1YarJ.SslConfiguration, SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12);
				if (YA2vFUtG6iF.TRAaE0bpPZ4())
				{
					o90vFt1YarJ.SetProxy((string)GhQOsix5uxcQl0qO1vNi(YA2vFUtG6iF), YA2vFUtG6iF.OCiaEYswnjC(), (string)r4XvSex5zDWmnIcSKi63(YA2vFUtG6iF));
				}
				Iu9SNNxS0G4JxYWBAXPO(o90vFt1YarJ, (EventHandler)delegate
				{
					QFivFIOVXAc.Change(TimeSpan.FromSeconds(10.0), XBeJnux53EQ8XkM7OL8Q(20.0));
					XukvFy8kKWm = false;
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						woYvFNKO1mE();
						break;
					}
				});
				o90vFt1YarJ.OnClose += delegate(object P_0, CloseEventArgs P_1)
				{
					QFivFIOVXAc.Change(-1, -1);
					snJvF64Te8i(obj: false);
					Action<string> f4evFgLftRo2 = F4evFgLftRo;
					int num3;
					if (f4evFgLftRo2 == null)
					{
						num3 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
						{
							num3 = 0;
						}
						goto IL_0009;
					}
					f4evFgLftRo2((string)CNdfjZxS5eK366NNA1Dg(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3E0426F0 ^ 0x3E054414), dKRbbKxSkMrf1WmltT2R(o90vFt1YarJ), P_1.Reason, eCQ8a7xS1b0atIAd0Lsx(P_1)));
					goto IL_0023;
					IL_0135:
					A49vFO9yrwH?.Invoke(new Exception((string)tllDctx5JeBBCiCr8Den(0x9F0F634 ^ 0x9F131BA) + (P_1.Reason ?? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-962524685 ^ -962543157))));
					goto IL_005f;
					IL_0009:
					while (true)
					{
						switch (num3)
						{
						case 1:
							break;
						case 2:
							return;
						case 3:
							bRLvFbrpdSL();
							num3 = 2;
							continue;
						default:
							goto IL_0135;
						}
						break;
					}
					goto IL_0023;
					IL_005f:
					o90vFt1YarJ = null;
					if (XukvFy8kKWm)
					{
						return;
					}
					Thread.Sleep(1000);
					num3 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
					{
						num3 = 3;
					}
					goto IL_0009;
					IL_0023:
					if (eCQ8a7xS1b0atIAd0Lsx(P_1) == 1006)
					{
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
						{
							num3 = 0;
						}
						goto IL_0009;
					}
					goto IL_005f;
				};
				o90vFt1YarJ.OnError += delegate(object P_0, ErrorEventArgs P_1)
				{
					F4evFgLftRo?.Invoke(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1309555870 ^ -1309630370) + (string)QvkJgLxSSk1gS145iIkf(P_1) + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x446AB724 ^ 0x446BF9CE));
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							WebSocket obj2 = o90vFt1YarJ;
							if (obj2 != null)
							{
								obj2.CloseAsync();
							}
							break;
						}
						catch (Exception obj3)
						{
							A49vFO9yrwH(obj3);
							break;
						}
					}
				};
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
				{
					num = 0;
				}
				continue;
			}
			o90vFt1YarJ.OnMessage += delegate(object P_0, MessageEventArgs P_1)
			{
				if (!P_1.IsPing)
				{
					try
					{
						if (!(P_1.Data == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461949456 ^ -1461941788)))
						{
							while (!hGivFLvvMtm(P_1.Data))
							{
								ImZvFM7xB9G(this, P_1.Data);
								int num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
								{
									num3 = 0;
								}
								switch (num3)
								{
								default:
									return;
								case 1:
									break;
								case 0:
									return;
								}
							}
							LmDvFeEqTvb((string)lMkJMdxSx75BmiOBZNjW(P_1));
						}
					}
					catch (Exception)
					{
					}
				}
			};
			num = 2;
		}
	}

	private void woYvFNKO1mE()
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Invalid comparison between Unknown and I4
		try
		{
			int num;
			if (o90vFt1YarJ == null || (int)o90vFt1YarJ.ReadyState != 1)
			{
				lsmT4PxSH5fr71C4jsZC(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-29702950 ^ -29643784));
				num = 3;
			}
			else
			{
				if (DNk9EZxS9kMsUZPAmYTe(ksh8MHxSfCf5W4dbb1eo(zakvFTijBKG)) || DNk9EZxS9kMsUZPAmYTe(vuufdixSn1Sq9Kw9AikJ(zakvFTijBKG)))
				{
					goto IL_0054;
				}
				num = 2;
			}
			goto IL_001b;
			IL_0054:
			trovF1jZNxv();
			Action<bool> action = hP0vFRy3PAL;
			if (action == null)
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
				{
					num = 0;
				}
				goto IL_001b;
			}
			action(obj: false);
			return;
			IL_001b:
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 1:
				break;
			case 2:
				dscvFkhEemj();
				return;
			}
			goto IL_0054;
		}
		catch (Exception obj)
		{
			A49vFO9yrwH(obj);
		}
	}

	private void dscvFkhEemj()
	{
		try
		{
			string text = kjVvFWHSHf2.s0EvPphhppR().ToString();
			string text2 = kjVvFWHSHf2.qURvJ0mmltZ(text);
			dnva1YBnoQVwcJabQ2FL dnva1YBnoQVwcJabQ2FL = new dnva1YBnoQVwcJabQ2FL();
			yPbDllxSG7NSTlsRvIhU(dnva1YBnoQVwcJabQ2FL, zakvFTijBKG.AYMv8waWxKE);
			hufgLexSoW2LCbP9rRQ7(dnva1YBnoQVwcJabQ2FL, ofrMN4xSYAFffMqO63II(zakvFTijBKG));
			dnva1YBnoQVwcJabQ2FL.Timestamp = text;
			ct4KI7xSvToNrZ2Oky2O(dnva1YBnoQVwcJabQ2FL, text2);
			string text3 = JsonConvert.SerializeObject((object)new pcOtPJBn0NWdBF2N3YUY(dnva1YBnoQVwcJabQ2FL));
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
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
				QoovFxclJTV(text3);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
				{
					num = 1;
				}
			}
		}
		catch (Exception obj)
		{
			A49vFO9yrwH(obj);
		}
	}

	private void trovF1jZNxv()
	{
		try
		{
			cifvF5h1QMZ();
			XeGvFSVUDxf();
		}
		catch (Exception obj)
		{
			A49vFO9yrwH(obj);
		}
	}

	private void cifvF5h1QMZ()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				NemY7IB94N3fUYOxH7oo nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo
				{
					tIWB91mDjZG = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2108526692 ^ -2108482312)
				};
				NemY7IB94N3fUYOxH7oo nemY7IB94N3fUYOxH7oo3 = nemY7IB94N3fUYOxH7oo;
				d9n9rSB9E7JNb7unSugp[] array2 = new d9n9rSB9E7JNb7unSugp[1];
				d9n9rSB9E7JNb7unSugp d9n9rSB9E7JNb7unSugp2 = new d9n9rSB9E7JNb7unSugp();
				hs7xeIxSBkoaqpsX4H7Y(d9n9rSB9E7JNb7unSugp2, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-123775059 ^ -123862869));
				d9n9rSB9E7JNb7unSugp2.Channel = (string)tllDctx5JeBBCiCr8Den(-2017337494 ^ -2017400520);
				d9n9rSB9E7JNb7unSugp2.qPkB9ItR15N = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2056710528 ^ -2056683352);
				array2[0] = d9n9rSB9E7JNb7unSugp2;
				BJPNhyxSaOL3GyTk3uYM(nemY7IB94N3fUYOxH7oo3, array2);
				QoovFxclJTV(JsonConvert.SerializeObject((object)nemY7IB94N3fUYOxH7oo));
				QoovFxclJTV(JsonConvert.SerializeObject((object)new NemY7IB94N3fUYOxH7oo
				{
					tIWB91mDjZG = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-671204305 ^ -671133877),
					GLTB9xnK5Ul = new d9n9rSB9E7JNb7unSugp[1]
					{
						new d9n9rSB9E7JNb7unSugp
						{
							faUB9Ro7C4E = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x37B74BDF ^ 0x37B61CD9),
							Channel = (string)tllDctx5JeBBCiCr8Den(-671204305 ^ -671131585),
							qPkB9ItR15N = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380561496)
						}
					}
				}));
				nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo
				{
					tIWB91mDjZG = (string)tllDctx5JeBBCiCr8Den(0x16AD7E76 ^ 0x16AC0D12)
				};
				NemY7IB94N3fUYOxH7oo nemY7IB94N3fUYOxH7oo4 = nemY7IB94N3fUYOxH7oo;
				d9n9rSB9E7JNb7unSugp[] array3 = new d9n9rSB9E7JNb7unSugp[1];
				d9n9rSB9E7JNb7unSugp d9n9rSB9E7JNb7unSugp3 = new d9n9rSB9E7JNb7unSugp();
				hs7xeIxSBkoaqpsX4H7Y(d9n9rSB9E7JNb7unSugp3, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-60853733 ^ -60938979));
				Bf1lavxSiit28Tg2Wsj5(d9n9rSB9E7JNb7unSugp3, tllDctx5JeBBCiCr8Den(0x28C965BE ^ 0x28C80194));
				d9n9rSB9E7JNb7unSugp3.TenB9UaNndG = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1878953018 ^ -1878923794);
				array3[0] = d9n9rSB9E7JNb7unSugp3;
				nemY7IB94N3fUYOxH7oo4.GLTB9xnK5Ul = array3;
				QoovFxclJTV((string)YOOysfxSlc6y1ZjYIZKB(nemY7IB94N3fUYOxH7oo));
				return;
			}
			case 1:
			{
				NemY7IB94N3fUYOxH7oo nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo
				{
					tIWB91mDjZG = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-53782092 ^ -53859632)
				};
				NemY7IB94N3fUYOxH7oo nemY7IB94N3fUYOxH7oo2 = nemY7IB94N3fUYOxH7oo;
				d9n9rSB9E7JNb7unSugp[] array = new d9n9rSB9E7JNb7unSugp[1];
				d9n9rSB9E7JNb7unSugp d9n9rSB9E7JNb7unSugp = new d9n9rSB9E7JNb7unSugp();
				hs7xeIxSBkoaqpsX4H7Y(d9n9rSB9E7JNb7unSugp, tllDctx5JeBBCiCr8Den(-44540535 ^ -44496241));
				d9n9rSB9E7JNb7unSugp.Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x60620FC1 ^ 0x6063BF3B);
				d9n9rSB9E7JNb7unSugp.qPkB9ItR15N = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB15EE42);
				array[0] = d9n9rSB9E7JNb7unSugp;
				nemY7IB94N3fUYOxH7oo2.GLTB9xnK5Ul = array;
				QoovFxclJTV(JsonConvert.SerializeObject((object)nemY7IB94N3fUYOxH7oo));
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void XeGvFSVUDxf()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			NemY7IB94N3fUYOxH7oo nemY7IB94N3fUYOxH7oo;
			switch (num2)
			{
			case 1:
				nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo();
				xIpBHXxS4wP187d8fnl7(nemY7IB94N3fUYOxH7oo, tllDctx5JeBBCiCr8Den(-90307782 ^ -90214306));
				nemY7IB94N3fUYOxH7oo.GLTB9xnK5Ul = new d9n9rSB9E7JNb7unSugp[1]
				{
					new d9n9rSB9E7JNb7unSugp
					{
						faUB9Ro7C4E = (string)tllDctx5JeBBCiCr8Den(-671204305 ^ -671118039),
						Channel = (string)tllDctx5JeBBCiCr8Den(-1461292091 ^ -1461238423),
						qPkB9ItR15N = (string)tllDctx5JeBBCiCr8Den(-527080372 ^ -527043996)
					}
				};
				QoovFxclJTV(JsonConvert.SerializeObject((object)nemY7IB94N3fUYOxH7oo));
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo();
				xIpBHXxS4wP187d8fnl7(nemY7IB94N3fUYOxH7oo, tllDctx5JeBBCiCr8Den(-624753169 ^ -624789877));
				nemY7IB94N3fUYOxH7oo.GLTB9xnK5Ul = new d9n9rSB9E7JNb7unSugp[1]
				{
					new d9n9rSB9E7JNb7unSugp
					{
						faUB9Ro7C4E = (string)tllDctx5JeBBCiCr8Den(0x6E2DFBED ^ 0x6E2C4AEB),
						Channel = (string)tllDctx5JeBBCiCr8Den(--855742383 ^ 0x3300F385),
						TenB9UaNndG = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841459599)
					}
				};
				QoovFxclJTV(JsonConvert.SerializeObject((object)nemY7IB94N3fUYOxH7oo));
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
				{
					num2 = 1;
				}
				continue;
			}
			nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo();
			xIpBHXxS4wP187d8fnl7(nemY7IB94N3fUYOxH7oo, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1878953018 ^ -1879048030));
			BJPNhyxSaOL3GyTk3uYM(nemY7IB94N3fUYOxH7oo, new d9n9rSB9E7JNb7unSugp[1]
			{
				new d9n9rSB9E7JNb7unSugp
				{
					faUB9Ro7C4E = (string)tllDctx5JeBBCiCr8Den(0x5EA8FF2A ^ 0x5EA94E2C),
					Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1583344314 ^ -1583241796),
					qPkB9ItR15N = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x11D1040B ^ 0x11D19223)
				}
			});
			QoovFxclJTV((string)YOOysfxSlc6y1ZjYIZKB(nemY7IB94N3fUYOxH7oo));
			nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo();
			xIpBHXxS4wP187d8fnl7(nemY7IB94N3fUYOxH7oo, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28ACEAE));
			nemY7IB94N3fUYOxH7oo.GLTB9xnK5Ul = new d9n9rSB9E7JNb7unSugp[1]
			{
				new d9n9rSB9E7JNb7unSugp
				{
					faUB9Ro7C4E = (string)tllDctx5JeBBCiCr8Den(-520155535 ^ -520175753),
					Channel = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-60853733 ^ -60930999),
					qPkB9ItR15N = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x746ED405 ^ 0x746E422D)
				}
			};
			QoovFxclJTV(JsonConvert.SerializeObject((object)nemY7IB94N3fUYOxH7oo));
			nemY7IB94N3fUYOxH7oo = new NemY7IB94N3fUYOxH7oo();
			xIpBHXxS4wP187d8fnl7(nemY7IB94N3fUYOxH7oo, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--737722733 ^ 0x2BF9B209));
			NemY7IB94N3fUYOxH7oo nemY7IB94N3fUYOxH7oo2 = nemY7IB94N3fUYOxH7oo;
			d9n9rSB9E7JNb7unSugp[] array = new d9n9rSB9E7JNb7unSugp[1];
			d9n9rSB9E7JNb7unSugp obj = new d9n9rSB9E7JNb7unSugp
			{
				faUB9Ro7C4E = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1416986301 ^ -1416941499)
			};
			Bf1lavxSiit28Tg2Wsj5(obj, tllDctx5JeBBCiCr8Den(-448941864 ^ -448998200));
			obj.qPkB9ItR15N = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7DB10E6E ^ 0x7DB19846);
			array[0] = obj;
			nemY7IB94N3fUYOxH7oo2.GLTB9xnK5Ul = array;
			QoovFxclJTV(JsonConvert.SerializeObject((object)nemY7IB94N3fUYOxH7oo));
			return;
		}
	}

	public void Disconnect()
	{
		QFivFIOVXAc.Change(-1, -1);
		XukvFy8kKWm = true;
		WebSocket obj = o90vFt1YarJ;
		if (obj != null)
		{
			obj.CloseAsync();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 != 0)
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

	private void QoovFxclJTV(string P_0)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		if (o90vFt1YarJ == null)
		{
			return;
		}
		if ((int)bSXSHBx5Aar6OFw9dUkx(o90vFt1YarJ) != 1)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
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
			o90vFt1YarJ.Send(P_0);
		}
	}

	private bool hGivFLvvMtm(string P_0)
	{
		try
		{
			JToken obj = JObject.Parse(P_0)[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-710503328 ^ -710512224)];
			int num;
			if (obj == null)
			{
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
				{
					num = 1;
				}
				goto IL_0047;
			}
			object obj2 = ((object)obj).ToString();
			goto IL_00c1;
			IL_00c1:
			string text = (string)obj2;
			if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x12620268 ^ 0x12635444)))
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num = 0;
				}
				goto IL_0047;
			}
			int result = 1;
			goto IL_00c9;
			IL_00b6:
			obj2 = null;
			goto IL_00c1;
			IL_00c9:
			return (byte)result != 0;
			IL_0047:
			switch (num)
			{
			case 1:
				goto IL_00b6;
			}
			result = (R0v6qwxSD0FFMgjeEnVm(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x37B74BDF ^ 0x37B67E27)) ? 1 : 0);
			goto IL_00c9;
		}
		catch
		{
			return false;
		}
	}

	private void LmDvFeEqTvb(string P_0)
	{
		try
		{
			JObject obj = JObject.Parse(P_0);
			string text = ((object)obj[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28C965BE ^ 0x28C9807E)])?.ToString();
			string text2 = or8VWGxSbtRQRiEa8cgk(obj, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-45476899 ^ -45418963))?.ToString();
			JToken obj2 = obj[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1962651919 ^ -1962628305)];
			int num;
			if (obj2 == null)
			{
				num = 2;
				goto IL_00a1;
			}
			object obj3 = ((object)obj2).ToString();
			goto IL_016c;
			IL_00a1:
			string text3 = default(string);
			switch (num)
			{
			default:
				if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-530053095 ^ -529973791))
				{
					XPlvFX4CelB(text2, text3);
				}
				return;
			case 1:
				break;
			case 2:
				goto IL_0161;
			}
			goto IL_0152;
			IL_0161:
			obj3 = null;
			goto IL_016c;
			IL_016c:
			text3 = (string)obj3;
			if (!(text == (string)tllDctx5JeBBCiCr8Den(-1346994499 ^ -1346951023)))
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
				{
					num = 0;
				}
				goto IL_00a1;
			}
			goto IL_0152;
			IL_0152:
			vm7vFscKiMs(text2, text3);
		}
		catch (Exception obj4)
		{
			Action<Exception> a49vFO9yrwH = A49vFO9yrwH;
			int num2;
			if (a49vFO9yrwH == null)
			{
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num2 = 1;
				}
				goto IL_0183;
			}
			a49vFO9yrwH(obj4);
			goto IL_01e3;
			IL_0183:
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				break;
			}
			goto IL_01e3;
			IL_01e3:
			XukvFy8kKWm = true;
			WebSocket obj5 = o90vFt1YarJ;
			if (obj5 == null)
			{
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
				{
					num2 = 0;
				}
				goto IL_0183;
			}
			spSANxxS2XcKJVFGiW70(obj5);
		}
	}

	private void vm7vFscKiMs(string P_0, string P_1)
	{
		string message = default(string);
		int num;
		if (!(P_0 == (string)tllDctx5JeBBCiCr8Den(--500511424 ^ 0x1DD5A6B6)))
		{
			message = (string)EVnbIxxSNaEROtQlD45m(new string[5]
			{
				(string)tllDctx5JeBBCiCr8Den(-44540535 ^ -44459451),
				P_1,
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x16AD7E76 ^ 0x16ACC430),
				P_0,
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-181342698 ^ -181354524)
			});
			XukvFy8kKWm = true;
			num = 3;
		}
		else
		{
			Action<bool> action = hP0vFRy3PAL;
			if (action != null)
			{
				action(obj: false);
				goto IL_00ea;
			}
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				WebSocket obj = o90vFt1YarJ;
				if (obj == null)
				{
					goto case 2;
				}
				spSANxxS2XcKJVFGiW70(obj);
				int num2 = 2;
				num = num2;
				continue;
			}
			case 1:
				return;
			case 2:
			{
				Action<Exception> a49vFO9yrwH = A49vFO9yrwH;
				if (a49vFO9yrwH == null)
				{
					return;
				}
				a49vFO9yrwH(new Exception(message));
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
				{
					num = 1;
				}
				continue;
			}
			}
			break;
		}
		goto IL_00ea;
		IL_00ea:
		trovF1jZNxv();
	}

	private void XPlvFX4CelB(string P_0, string P_1)
	{
		string message = (string)EVnbIxxSNaEROtQlD45m(new string[5]
		{
			(string)tllDctx5JeBBCiCr8Den(-1848952786 ^ -1848971204),
			P_1,
			F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-5977659 ^ -5934205),
			P_0,
			(string)tllDctx5JeBBCiCr8Den(--18459671 ^ 0x119FDE5)
		});
		Action<Exception> a49vFO9yrwH = A49vFO9yrwH;
		if (a49vFO9yrwH == null)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
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
			a49vFO9yrwH(new Exception(message));
		}
	}

	[CompilerGenerated]
	private void s0dvFcIZtAn(object P_0, EventArgs P_1)
	{
		QFivFIOVXAc.Change(TimeSpan.FromSeconds(10.0), XBeJnux53EQ8XkM7OL8Q(20.0));
		XukvFy8kKWm = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		woYvFNKO1mE();
	}

	[CompilerGenerated]
	private void ffWvFjJitlH(object P_0, CloseEventArgs P_1)
	{
		QFivFIOVXAc.Change(-1, -1);
		snJvF64Te8i(obj: false);
		Action<string> f4evFgLftRo = F4evFgLftRo;
		int num;
		if (f4evFgLftRo == null)
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		f4evFgLftRo((string)CNdfjZxS5eK366NNA1Dg(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3E0426F0 ^ 0x3E054414), dKRbbKxSkMrf1WmltT2R(o90vFt1YarJ), P_1.Reason, eCQ8a7xS1b0atIAd0Lsx(P_1)));
		goto IL_0023;
		IL_0135:
		A49vFO9yrwH?.Invoke(new Exception((string)tllDctx5JeBBCiCr8Den(0x9F0F634 ^ 0x9F131BA) + (P_1.Reason ?? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-962524685 ^ -962543157))));
		goto IL_005f;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				break;
			case 2:
				return;
			case 3:
				bRLvFbrpdSL();
				num = 2;
				continue;
			default:
				goto IL_0135;
			}
			break;
		}
		goto IL_0023;
		IL_005f:
		o90vFt1YarJ = null;
		if (XukvFy8kKWm)
		{
			return;
		}
		Thread.Sleep(1000);
		num = 3;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
		{
			num = 3;
		}
		goto IL_0009;
		IL_0023:
		if (eCQ8a7xS1b0atIAd0Lsx(P_1) == 1006)
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_005f;
	}

	[CompilerGenerated]
	private void NYSvFERkaok(object P_0, ErrorEventArgs P_1)
	{
		F4evFgLftRo?.Invoke(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1309555870 ^ -1309630370) + (string)QvkJgLxSSk1gS145iIkf(P_1) + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x446AB724 ^ 0x446BF9CE));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			WebSocket obj = o90vFt1YarJ;
			if (obj != null)
			{
				obj.CloseAsync();
			}
		}
		catch (Exception obj2)
		{
			A49vFO9yrwH(obj2);
		}
	}

	[CompilerGenerated]
	private void LUdvFQqsTx4(object P_0, MessageEventArgs P_1)
	{
		if (P_1.IsPing)
		{
			return;
		}
		try
		{
			if (P_1.Data == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461949456 ^ -1461941788))
			{
				return;
			}
			while (!hGivFLvvMtm(P_1.Data))
			{
				ImZvFM7xB9G(this, P_1.Data);
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
			}
			LmDvFeEqTvb((string)lMkJMdxSx75BmiOBZNjW(P_1));
		}
		catch (Exception)
		{
		}
	}

	static lrPIk5vFlRbGZRrD6DiR()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		P2rPqxxSLXGewJDhBtrE();
	}

	internal static bool LI7wC1x5823lDA7BX1RY(object P_0)
	{
		return ((WebSocket)P_0).IsAlive;
	}

	internal static WebSocketState bSXSHBx5Aar6OFw9dUkx(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static void Aj0oHLx5PHqVxVybtrOt(object P_0, object P_1)
	{
		((WebSocket)P_0).Send((string)P_1);
	}

	internal static object tllDctx5JeBBCiCr8Den(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool apRAyKx5wVPAfoZnmKjW()
	{
		return NZCDAVx5hE8u8WJKILIn == null;
	}

	internal static lrPIk5vFlRbGZRrD6DiR r4KGQgx57nDmGgcXRf2B()
	{
		return NZCDAVx5hE8u8WJKILIn;
	}

	internal static bool UbcLpQx5FJZ6ilplAcAl(object P_0, int P_1, int P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}

	internal static TimeSpan XBeJnux53EQ8XkM7OL8Q(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static void PS9Bjpx5pNHaWXWtwqtL(object P_0, SslProtocols P_1)
	{
		((SslConfiguration)P_0).EnabledSslProtocols = P_1;
	}

	internal static object GhQOsix5uxcQl0qO1vNi(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Url;
	}

	internal static object r4XvSex5zDWmnIcSKi63(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Password;
	}

	internal static void Iu9SNNxS0G4JxYWBAXPO(object P_0, object P_1)
	{
		((WebSocket)P_0).OnOpen += (EventHandler)P_1;
	}

	internal static void spSANxxS2XcKJVFGiW70(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static void lsmT4PxSH5fr71C4jsZC(object P_0)
	{
		LogManager.WriteInfo((string)P_0);
	}

	internal static object ksh8MHxSfCf5W4dbb1eo(object P_0)
	{
		return ((VZf1b9v8WmBe1KShgpKC)P_0).AYMv8waWxKE;
	}

	internal static bool DNk9EZxS9kMsUZPAmYTe(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object vuufdixSn1Sq9Kw9AikJ(object P_0)
	{
		return ((VZf1b9v8WmBe1KShgpKC)P_0).KHPv8PZeCk9();
	}

	internal static void yPbDllxSG7NSTlsRvIhU(object P_0, object P_1)
	{
		((dnva1YBnoQVwcJabQ2FL)P_0).dk7BnionVtw = (string)P_1;
	}

	internal static object ofrMN4xSYAFffMqO63II(object P_0)
	{
		return ((VZf1b9v8WmBe1KShgpKC)P_0).oEVv8zyj9um();
	}

	internal static void hufgLexSoW2LCbP9rRQ7(object P_0, object P_1)
	{
		((dnva1YBnoQVwcJabQ2FL)P_0).fkeBnDDi5fD = (string)P_1;
	}

	internal static void ct4KI7xSvToNrZ2Oky2O(object P_0, object P_1)
	{
		((dnva1YBnoQVwcJabQ2FL)P_0).fP6Bn5EsrCQ = (string)P_1;
	}

	internal static void hs7xeIxSBkoaqpsX4H7Y(object P_0, object P_1)
	{
		((d9n9rSB9E7JNb7unSugp)P_0).faUB9Ro7C4E = (string)P_1;
	}

	internal static void BJPNhyxSaOL3GyTk3uYM(object P_0, object P_1)
	{
		((NemY7IB94N3fUYOxH7oo)P_0).GLTB9xnK5Ul = (d9n9rSB9E7JNb7unSugp[])P_1;
	}

	internal static void Bf1lavxSiit28Tg2Wsj5(object P_0, object P_1)
	{
		((d9n9rSB9E7JNb7unSugp)P_0).Channel = (string)P_1;
	}

	internal static object YOOysfxSlc6y1ZjYIZKB(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static void xIpBHXxS4wP187d8fnl7(object P_0, object P_1)
	{
		((NemY7IB94N3fUYOxH7oo)P_0).tIWB91mDjZG = (string)P_1;
	}

	internal static bool R0v6qwxSD0FFMgjeEnVm(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object or8VWGxSbtRQRiEa8cgk(object P_0, object P_1)
	{
		return ((JObject)P_0)[(string)P_1];
	}

	internal static object EVnbIxxSNaEROtQlD45m(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object dKRbbKxSkMrf1WmltT2R(object P_0)
	{
		return ((WebSocket)P_0).Url;
	}

	internal static ushort eCQ8a7xS1b0atIAd0Lsx(object P_0)
	{
		return ((CloseEventArgs)P_0).Code;
	}

	internal static object CNdfjZxS5eK366NNA1Dg(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object QvkJgLxSSk1gS145iIkf(object P_0)
	{
		return ((ErrorEventArgs)P_0).Message;
	}

	internal static object lMkJMdxSx75BmiOBZNjW(object P_0)
	{
		return ((MessageEventArgs)P_0).Data;
	}

	internal static void P2rPqxxSLXGewJDhBtrE()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
