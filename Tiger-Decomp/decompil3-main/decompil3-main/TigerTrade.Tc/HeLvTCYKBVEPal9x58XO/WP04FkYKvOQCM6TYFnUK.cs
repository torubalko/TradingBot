using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using BfZtb759KlUg4482QKym;
using EyD6NKGhRYBSlyBqPfrJ;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using nr77PcYKOQGdcitNus3o;
using r8oOHiajFPNBXu6XiAHj;
using T6kiCgGaalqUWUfQfSet;
using WebSocketSharp;
using WebSocketSharp.Net;
using wpSacyGal0lb1xw8cagG;
using x97CE55GhEYKgt7TSVZT;
using yW2lnGYWMmDfmRlVPfeY;

namespace HeLvTCYKBVEPal9x58XO;

internal class WP04FkYKvOQCM6TYFnUK
{
	private readonly Action<string> D9lYKLxLj8s;

	private readonly Action<bool> iTVYKe74Vhc;

	private readonly Action<bool> y2iYKsun8v9;

	private readonly Action<object, string> hKLYKXBuJ2E;

	private readonly Action<Exception> DeoYKcDvNqq;

	private readonly Timer R0dYKj8j2ua;

	private WebSocket myHYKEkfX56;

	private readonly C3trUsajJIHJMtdo9pBg rS4YKQkay6j;

	private readonly y1UTwfYW6jIuwTT65Lor DvyYKdV2f0j;

	private bool a0KYKgOpg28;

	private readonly string HsjYKRwBhkI;

	[CompilerGenerated]
	private readonly T1sPEBYKMvulRT8LphAC NgaYK69Xr9x;

	private static WP04FkYKvOQCM6TYFnUK eWM0ncSQJ20cG890gFlZ;

	public bool IsConnected
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Invalid comparison between Unknown and I4
			if (myHYKEkfX56 != null)
			{
				return (int)myHYKEkfX56.ReadyState == 1;
			}
			return false;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public T1sPEBYKMvulRT8LphAC swIYKSE3uuI()
	{
		return NgaYK69Xr9x;
	}

	public WP04FkYKvOQCM6TYFnUK(string P_0, C3trUsajJIHJMtdo9pBg P_1, T1sPEBYKMvulRT8LphAC P_2, y1UTwfYW6jIuwTT65Lor P_3, Action<bool> P_4, Action<bool> P_5, Action<object, string> P_6, Action<string> P_7, Action<Exception> P_8)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		HsjYKRwBhkI = P_0;
		NgaYK69Xr9x = P_2;
		rS4YKQkay6j = P_1;
		DvyYKdV2f0j = P_3;
		R0dYKj8j2ua = new Timer(BomYKaQHro4, null, -1, -1);
		D9lYKLxLj8s = P_7;
		iTVYKe74Vhc = P_4;
		y2iYKsun8v9 = P_5;
		hKLYKXBuJ2E = P_6;
		DeoYKcDvNqq = P_8;
	}

	private void BomYKaQHro4(object P_0)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		WebSocket obj = myHYKEkfX56;
		WebSocketState? val = ((obj != null) ? new WebSocketState?(WBsgfnSQpTyw2ZTrXygV(obj)) : ((WebSocketState?)null));
		int num = 6;
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 5:
			{
				text = (string)((swIYKSE3uuI() == (T1sPEBYKMvulRT8LphAC)1) ? GB40ogSd0xgOOVCQVria(-338769610 ^ -338711682) : GB40ogSd0xgOOVCQVria(-1878953018 ^ -1879043590));
				int num2 = 2;
				num = num2;
				break;
			}
			case 0:
				return;
			case 6:
				if (val.HasValue && (int)val.GetValueOrDefault() == 1)
				{
					WebSocket obj3 = myHYKEkfX56;
					if (obj3 == null)
					{
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
						{
							num = 5;
						}
						break;
					}
					if (o6lBiPSQu0JPXXfVHZLn(obj3))
					{
						num = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
						{
							num = 1;
						}
						break;
					}
				}
				goto case 5;
			case 1:
			case 4:
			{
				WebSocket obj2 = myHYKEkfX56;
				if (obj2 == null)
				{
					return;
				}
				obj2.CloseAsync();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
				{
					num = 0;
				}
				break;
			}
			case 3:
			{
				WebSocket obj4 = myHYKEkfX56;
				if (obj4 != null)
				{
					Nxj3dnSQzkXOg3eQZ8rv(obj4, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x11D1040B ^ 0x11D0663B));
				}
				return;
			}
			case 2:
			{
				Action<string> d9lYKLxLj8s = D9lYKLxLj8s;
				if (d9lYKLxLj8s == null)
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 != 0)
					{
						num = 1;
					}
				}
				else
				{
					d9lYKLxLj8s((string)R6HKomSd2YNEtOtObMeH(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6AB40973 ^ 0x6AB56B29), text, GB40ogSd0xgOOVCQVria(-45476899 ^ -45387335)));
					num = 4;
				}
				break;
			}
			}
		}
	}

	public void UFoYKiCGHeV()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		R0dYKj8j2ua.Change(-1, -1);
		int num;
		if (myHYKEkfX56 == null)
		{
			myHYKEkfX56 = new WebSocket(HsjYKRwBhkI, Array.Empty<string>())
			{
				EmitOnPing = true,
				WaitTime = TimeSpan.FromSeconds(10.0)
			};
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
			{
				num = 0;
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
				vgBngsSdHdSXHveK5nHv(myHYKEkfX56.SslConfiguration, SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12);
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
				{
					num = 3;
				}
				break;
			case 4:
				myHYKEkfX56.OnError += delegate(object P_0, ErrorEventArgs P_1)
				{
					try
					{
						WebSocket obj3 = myHYKEkfX56;
						if (obj3 != null)
						{
							ojA1LbSdvYKh36HjWUmi(obj3);
						}
						Action<string> d9lYKLxLj8s = D9lYKLxLj8s;
						if (d9lYKLxLj8s == null)
						{
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
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
							d9lYKLxLj8s((string)R6HKomSd2YNEtOtObMeH(GB40ogSd0xgOOVCQVria(--146713930 ^ 0x8BFCE76), P_1.Message, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-60853733 ^ -60932879)));
						}
					}
					catch (Exception obj4)
					{
						DeoYKcDvNqq(obj4);
					}
				};
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
				{
					num = 1;
				}
				break;
			case 1:
				myHYKEkfX56.OnMessage += delegate(object P_0, MessageEventArgs P_1)
				{
					if (!P_1.IsPing)
					{
						int num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								hKLYKXBuJ2E(this, P_1.Data);
								break;
							}
							catch (Exception)
							{
								break;
							}
						}
					}
				};
				try
				{
					WebSocket obj = myHYKEkfX56;
					if (obj != null)
					{
						obj.ConnectAsync();
					}
					return;
				}
				catch (Exception)
				{
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
					WebSocket obj2 = myHYKEkfX56;
					if (obj2 != null)
					{
						obj2.CloseAsync();
					}
					return;
				}
			case 3:
				if (rS4YKQkay6j.TRAaE0bpPZ4() && DvyYKdV2f0j.swuYt48xZq6)
				{
					ks5POXSdfawiVJktmNYX(myHYKEkfX56, rS4YKQkay6j.Url, rS4YKQkay6j.OCiaEYswnjC(), rS4YKQkay6j.Password);
				}
				KwvPRKSd9qQmG8HoRhJ9(myHYKEkfX56, (EventHandler)delegate
				{
					int num3 = 2;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							R0dYKj8j2ua.Change(TimeSpan.FromSeconds(10.0), RkvrqySdYkZMaqJCMtDe(20.0));
							num4 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							iTVYKe74Vhc?.Invoke(obj: false);
							a0KYKgOpg28 = false;
							qv4YKljmkkU();
							num4 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				myHYKEkfX56.OnClose += delegate(object P_0, CloseEventArgs P_1)
				{
					R0dYKj8j2ua.Change(-1, -1);
					y2iYKsun8v9(obj: false);
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
						{
							Action<string> d9lYKLxLj8s = D9lYKLxLj8s;
							if (d9lYKLxLj8s != null)
							{
								d9lYKLxLj8s(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-90307782 ^ -90218018), myHYKEkfX56.Url, P_1.Reason, F3i68kSdogAh4XnyBrr3(P_1)));
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
								{
									num3 = 0;
								}
								break;
							}
							goto default;
						}
						case 2:
							Thread.Sleep(1000);
							UFoYKiCGHeV();
							return;
						case 3:
							if (a0KYKgOpg28)
							{
								return;
							}
							num3 = 2;
							break;
						default:
							myHYKEkfX56 = null;
							num3 = 3;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
							{
								num3 = 1;
							}
							break;
						}
					}
				};
				num = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	private void qv4YKljmkkU()
	{
		try
		{
			if (myHYKEkfX56 == null)
			{
				return;
			}
			string text = default(string);
			string sign = default(string);
			while (true)
			{
				long num = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + Acj0FgGhg83F5A0lfPa4.q3hGwXLLhPb() / 1000;
				int num2 = 3;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					default:
					{
						string text2 = JsonConvert.SerializeObject((object)new yvX1nRGaBRMndLV6HWFA<string, tJKI8HGaiZ51RZSuCJlU<string, string, string>>(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-203064540 ^ -203150072), new tJKI8HGaiZ51RZSuCJlU<string, string, string>(DvyYKdV2f0j.gJ8YWZre7YF, text, sign)));
						WebSocket obj = myHYKEkfX56;
						if (obj == null)
						{
							return;
						}
						obj.Send(text2);
						num2 = 2;
						continue;
					}
					case 1:
						break;
					case 3:
						text = num.ToString();
						sign = QbQYK4JBxOI(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-690510723 ^ -690567473), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x24B0B9E6 ^ 0x24B1DB5A));
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}
		catch (Exception obj2)
		{
			DeoYKcDvNqq(obj2);
		}
	}

	private string QbQYK4JBxOI(string P_0, string P_1, string P_2)
	{
		int num = 1;
		int num2 = num;
		string s = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				s = (string)R6HKomSd2YNEtOtObMeH(P_0, P_1, P_2);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(DvyYKdV2f0j.t4tYWKH0rhA());
			byte[] bytes2 = ((Encoding)iiWVAYSdnA8yb5Q5nWvI()).GetBytes(s);
			HMACSHA256 hMACSHA = new HMACSHA256(bytes);
			try
			{
				return BitConverter.ToString(hMACSHA.ComputeHash(bytes2)).Replace((string)GB40ogSd0xgOOVCQVria(0x735715F1 ^ 0x7357FF33), "").ToLower();
			}
			finally
			{
				if (hMACSHA != null)
				{
					tF5SnaSdGO1yvXhSwkYr(hMACSHA);
				}
			}
		}
	}

	public void Disconnect()
	{
		R0dYKj8j2ua.Change(-1, -1);
		a0KYKgOpg28 = true;
		WebSocket obj = myHYKEkfX56;
		if (obj == null)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 != 0)
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
			obj.CloseAsync();
		}
	}

	public void Rh3YKDRSsck(string P_0)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		if (myHYKEkfX56 == null)
		{
			return;
		}
		if ((int)myHYKEkfX56.ReadyState != 1)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
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
			myHYKEkfX56.Send(P_0);
		}
	}

	[CompilerGenerated]
	private void l5TYKbAYo8D(object P_0, EventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				R0dYKj8j2ua.Change(TimeSpan.FromSeconds(10.0), RkvrqySdYkZMaqJCMtDe(20.0));
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				iTVYKe74Vhc?.Invoke(obj: false);
				a0KYKgOpg28 = false;
				qv4YKljmkkU();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void xUcYKNBK1Qi(object P_0, CloseEventArgs P_1)
	{
		R0dYKj8j2ua.Change(-1, -1);
		y2iYKsun8v9(obj: false);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				Action<string> d9lYKLxLj8s = D9lYKLxLj8s;
				if (d9lYKLxLj8s == null)
				{
					goto default;
				}
				d9lYKLxLj8s(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-90307782 ^ -90218018), myHYKEkfX56.Url, P_1.Reason, F3i68kSdogAh4XnyBrr3(P_1)));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
				{
					num = 0;
				}
				break;
			}
			case 2:
				Thread.Sleep(1000);
				UFoYKiCGHeV();
				return;
			case 3:
				if (a0KYKgOpg28)
				{
					return;
				}
				num = 2;
				break;
			default:
				myHYKEkfX56 = null;
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void nuDYKkbyCJ1(object P_0, ErrorEventArgs P_1)
	{
		try
		{
			WebSocket obj = myHYKEkfX56;
			if (obj != null)
			{
				ojA1LbSdvYKh36HjWUmi(obj);
			}
			Action<string> d9lYKLxLj8s = D9lYKLxLj8s;
			if (d9lYKLxLj8s == null)
			{
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
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
				d9lYKLxLj8s((string)R6HKomSd2YNEtOtObMeH(GB40ogSd0xgOOVCQVria(--146713930 ^ 0x8BFCE76), P_1.Message, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-60853733 ^ -60932879)));
			}
		}
		catch (Exception obj2)
		{
			DeoYKcDvNqq(obj2);
		}
	}

	[CompilerGenerated]
	private void THrYK164Lv0(object P_0, MessageEventArgs P_1)
	{
		if (P_1.IsPing)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			hKLYKXBuJ2E(this, P_1.Data);
		}
		catch (Exception)
		{
		}
	}

	static WP04FkYKvOQCM6TYFnUK()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		o7v1nNSdBuYJdauqgKsi();
	}

	internal static bool SMpDuASQFREcIb7gEIdE()
	{
		return eWM0ncSQJ20cG890gFlZ == null;
	}

	internal static WP04FkYKvOQCM6TYFnUK ePvI4cSQ3g8sAiVJjeqw()
	{
		return eWM0ncSQJ20cG890gFlZ;
	}

	internal static WebSocketState WBsgfnSQpTyw2ZTrXygV(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocket)P_0).ReadyState;
	}

	internal static bool o6lBiPSQu0JPXXfVHZLn(object P_0)
	{
		return ((WebSocket)P_0).IsAlive;
	}

	internal static void Nxj3dnSQzkXOg3eQZ8rv(object P_0, object P_1)
	{
		((WebSocket)P_0).Send((string)P_1);
	}

	internal static object GB40ogSd0xgOOVCQVria(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object R6HKomSd2YNEtOtObMeH(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void vgBngsSdHdSXHveK5nHv(object P_0, SslProtocols P_1)
	{
		((SslConfiguration)P_0).EnabledSslProtocols = P_1;
	}

	internal static void ks5POXSdfawiVJktmNYX(object P_0, object P_1, object P_2, object P_3)
	{
		((WebSocket)P_0).SetProxy((string)P_1, (string)P_2, (string)P_3);
	}

	internal static void KwvPRKSd9qQmG8HoRhJ9(object P_0, object P_1)
	{
		((WebSocket)P_0).OnOpen += (EventHandler)P_1;
	}

	internal static object iiWVAYSdnA8yb5Q5nWvI()
	{
		return Encoding.UTF8;
	}

	internal static void tF5SnaSdGO1yvXhSwkYr(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static TimeSpan RkvrqySdYkZMaqJCMtDe(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static ushort F3i68kSdogAh4XnyBrr3(object P_0)
	{
		return ((CloseEventArgs)P_0).Code;
	}

	internal static void ojA1LbSdvYKh36HjWUmi(object P_0)
	{
		((WebSocket)P_0).CloseAsync();
	}

	internal static void o7v1nNSdBuYJdauqgKsi()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
