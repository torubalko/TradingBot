using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.Tc.Properties;
using x97CE55GhEYKgt7TSVZT;

namespace waDpctGJom9MvAveNXHq;

public static class JLFqEJGJYiHaSdoROJXI
{
	[CompilerGenerated]
	private sealed class wXYpoYaq44INTOUlygXg
	{
		public string hCeaqbRDSRh;

		private static wXYpoYaq44INTOUlygXg xG3YeXxuWMiZQT2XgrVZ;

		public wXYpoYaq44INTOUlygXg()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool I7KaqDdr3cA(string crypto)
		{
			return SkTK5RxuTWRfkJWi0TFq(hCeaqbRDSRh, crypto);
		}

		static wXYpoYaq44INTOUlygXg()
		{
			TcM4kKxuy3K6oOIYIgbC();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool zILndNxutf8VQ9FTVSkr()
		{
			return xG3YeXxuWMiZQT2XgrVZ == null;
		}

		internal static wXYpoYaq44INTOUlygXg w3tdayxuUIbJPFAFqilw()
		{
			return xG3YeXxuWMiZQT2XgrVZ;
		}

		internal static bool SkTK5RxuTWRfkJWi0TFq(object P_0, object P_1)
		{
			return ((string)P_0).Contains((string)P_1);
		}

		internal static void TcM4kKxuy3K6oOIYIgbC()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class i4KZ1raqNI1n3QTThALl
	{
		public static readonly i4KZ1raqNI1n3QTThALl ianaq1kQX06;

		public static Func<ConnectionInfo, bool> dJFaq5bT5Bb;

		private static i4KZ1raqNI1n3QTThALl ivf60UxuZ9lAFM23FBuk;

		static i4KZ1raqNI1n3QTThALl()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f != 0)
					{
						num2 = 0;
					}
					break;
				default:
					pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
					itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
					ianaq1kQX06 = new i4KZ1raqNI1n3QTThALl();
					return;
				}
			}
		}

		public i4KZ1raqNI1n3QTThALl()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal bool cGaaqkZWDyY(ConnectionInfo c)
		{
			return c.IsConnected;
		}

		internal static bool waqYlgxuVpPY4FoS2MRE()
		{
			return ivf60UxuZ9lAFM23FBuk == null;
		}

		internal static i4KZ1raqNI1n3QTThALl eocOw6xuCPu8UmOcYXsI()
		{
			return ivf60UxuZ9lAFM23FBuk;
		}
	}

	private static string uuxGJ1CHYab;

	private static readonly HashSet<string> trbGJ5iQZOE;

	internal static JLFqEJGJYiHaSdoROJXI qtdaHZ57X62QSaXXFJ7N;

	public static bool WTeGJv6DrNH(string P_0)
	{
		int num = 1;
		int num2 = num;
		wXYpoYaq44INTOUlygXg wXYpoYaq44INTOUlygXg = default(wXYpoYaq44INTOUlygXg);
		while (true)
		{
			switch (num2)
			{
			default:
				if (MsEt1f57EPP1W28pN1W1(P_0))
				{
					return false;
				}
				wXYpoYaq44INTOUlygXg.hCeaqbRDSRh = P_0.ToUpper();
				return trbGJ5iQZOE.Any(wXYpoYaq44INTOUlygXg.I7KaqDdr3cA);
			case 1:
				wXYpoYaq44INTOUlygXg = new wXYpoYaq44INTOUlygXg();
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static HashSet<string> aFKGJBIwWtd()
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		foreach (ConnectionInfo item in from c in DataManager.GetConnectionsInfo()
			where c.IsConnected
			select c)
		{
			string text = item.TradeClientName.Trim().ToUpper();
			if (text.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F03C1B)))
			{
				string marketType = item.MarketType;
				if (!(marketType == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7F9B9F)))
				{
					if (marketType == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7DB10E6E ^ 0x7DB1E688))
					{
						hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4297C3EB ^ 0x42972AF7));
					}
					else
					{
						hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--500511424 ^ 0x1DD5EDE6));
					}
				}
				else
				{
					hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x404ED0BE ^ 0x404E3846));
				}
			}
			else if (text.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2056710528 ^ -2056653824)))
			{
				hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2BD86B18 ^ 0x2BD88998));
			}
			else if (text.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-198991962 ^ -199002480)))
			{
				if (item.MarketType == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1161619942 ^ -1161560238))
				{
					hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F007B3));
					hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1EFE0A28 ^ 0x1EFEEE5A));
				}
				else
				{
					hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1127423276 ^ -1127478394) + item.MarketType);
				}
			}
			else if (text.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1251569705 ^ -1251595115)))
			{
				hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1522697859 ^ -1522673089));
			}
			else if (text.Contains(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1848952786 ^ -1848913592)))
			{
				hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x130FEA25 ^ 0x130F0E95));
				hashSet.Add(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x68DEE0F ^ 0x68D0ADF));
			}
			else
			{
				if (!WTeGJv6DrNH(text))
				{
					text = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--146713930 ^ 0x8BE443C);
				}
				hashSet.Add(text);
			}
		}
		return hashSet;
	}

	public static bool xmKGJaYrkMM(Symbol P_0)
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!P_0.IsBybit)
					{
						goto end_IL_0012;
					}
					goto IL_0070;
				case 3:
					if (P_0.IsFTX || wgks9u57ROCcQmBBnqYL(P_0) || P_0.IsGateIo)
					{
						goto IL_0070;
					}
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					if (P_0.IsBybit)
					{
						num2 = 6;
						break;
					}
					goto IL_0096;
				case 1:
					if (!(P_0.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-57768881 ^ -57774765)))
					{
						num2 = 2;
						break;
					}
					goto IL_0070;
				case 2:
					if (!dJ1YXJ57gjqUbj4xD66d(P_0))
					{
						num2 = 5;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto IL_0070;
				case 4:
					if (!P_0.IsDeribit)
					{
						num2 = 3;
						break;
					}
					goto IL_0070;
				case 6:
					if (P_0.AdditionalData.ContainsValue(vdvwZa57Qmu55N3caSRV(0x22BF43FC ^ 0x22BFAA70)) || P_0.AdditionalData.ContainsValue(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-5977659 ^ -6021015)))
					{
						return false;
					}
					goto IL_0096;
				default:
					if (!P_0.IsMEXC && !P_0.IsBackpack && !rvHSiY576K3E40b6rS3y(P_0))
					{
						return P_0.IsBitget;
					}
					goto IL_0070;
				case 8:
					{
						if (P_0.Exchange == (string)vdvwZa57Qmu55N3caSRV(-690510723 ^ -690521253))
						{
							goto IL_0070;
						}
						goto case 1;
					}
					IL_0096:
					if (Fxs6uC57dxEcUaDkkR0E(P_0) == SymbolType.Crypto)
					{
						return true;
					}
					num2 = 7;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
					{
						num2 = 8;
					}
					break;
					IL_0070:
					return true;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public static double q1nGJi4WVQh(double P_0, long P_1, double P_2, double P_3, double P_4, double P_5)
	{
		double num = P_2 * P_4;
		return Math.Round(Math.Floor(P_0 / ((double)P_1 * P_3) / num) * num, PfRGJNxKWYQ(P_5));
	}

	public static bool UAtGJlwm3mG(Symbol P_0, bool P_1, bool P_2, double P_3, double P_4, double P_5, long P_6, out double P_7, out string P_8)
	{
		int num = 3;
		double num4 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num3;
				switch (num2)
				{
				case 3:
					goto end_IL_0012;
				case 2:
					P_8 = null;
					if (P_1 || P_2)
					{
						if (P_2)
						{
							if (!(P_4 < -5E-324))
							{
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto IL_0038;
						}
						goto IL_016e;
					}
					P_7 = P_5;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					num3 = P_0.ContractValue;
					break;
				case 6:
					P_7 = q1nGJi4WVQh(P_5, P_6, P_0.LotStep, P_0.Step, num4, P_0.SizeStep);
					return true;
				default:
					if (P_3 < double.Epsilon)
					{
						goto IL_0038;
					}
					P_5 = gmaKYh57Mi9uqewyIjAq(P_4, P_3, (int)Math.Round(P_5));
					goto IL_016e;
				case 1:
					return true;
				case 4:
					{
						return false;
					}
					IL_0038:
					P_8 = Resources.ResourceManager.GetString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28B7B12));
					num2 = 4;
					continue;
					IL_016e:
					if (P_0.IsGateIo)
					{
						if (P_0.Type != SymbolType.Future)
						{
							num2 = 5;
							continue;
						}
						num3 = 1.0;
						break;
					}
					goto case 5;
				}
				num4 = num3;
				num2 = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			P_7 = double.NegativeInfinity;
			num = 2;
		}
	}

	public static double k62GJ45Rvfj(double P_0, double P_1, int P_2)
	{
		return P_0 * P_1 * (double)P_2 / 100.0;
	}

	public static int Qr8GJD6AHk5(double P_0, double P_1, double P_2)
	{
		return (int)Math.Round(P_2 / P_0 / P_1 * 100.0);
	}

	public static double AZ0GJbFd8HF(double P_0, long P_1, double P_2)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				if (P_0 > 100000000.0)
				{
					return e7Bdlk57OyxDp53VYV1i(P_0);
				}
				int num3 = 8 - ((int)P_0).ToString().Length + 1;
				return utqH9I57qDnUqQrk1Obm(P_0, num3);
			}
			case 1:
				P_0 *= (double)P_1 * P_2;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static int PfRGJNxKWYQ(double P_0)
	{
		if (P_0 < double.Epsilon)
		{
			return 0;
		}
		string[] array = P_0.ToString(uuxGJ1CHYab, (IFormatProvider)NaXRgc57IdhQ7FkWAb2v()).Split(ikTWCM57UT7jQjtpFRE4(dIf82Q57tTio2WErBXEC(D4W3lL57Wet2PMQUKG6A(CultureInfo.InvariantCulture)), 0));
		if (array == null)
		{
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_005f;
			}
			goto IL_0052;
		}
		goto IL_005f;
		IL_0052:
		return array.LastOrDefault().Length;
		IL_005f:
		if (array.Length < 2)
		{
			return 0;
		}
		goto IL_0052;
	}

	public static string NpyGJkKFar8(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return P_0;
		}
		return (string)NJQxRf57TfCQesgka98W(P_0, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894946052), "");
	}

	static JLFqEJGJYiHaSdoROJXI()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
				uuxGJ1CHYab = (string)vdvwZa57Qmu55N3caSRV(0x7F645F3C ^ 0x7F64B6D8);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a != 0)
				{
					num = 0;
				}
				continue;
			}
			trbGJ5iQZOE = new HashSet<string>
			{
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2074141628 ^ -2074086056),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7394D272 ^ 0x73943A8A),
				(string)vdvwZa57Qmu55N3caSRV(0x2D3134C9 ^ 0x2D31EBEF),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1A5F1B9E ^ 0x1A5FFE94),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1435596783 ^ -1435606499),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7394D272 ^ 0x73943688),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1522697859 ^ -1522689027),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894945488),
				(string)vdvwZa57Qmu55N3caSRV(0x315AB1E3 ^ 0x315A5BCD),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-490987856 ^ -490946168),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1EFE0A28 ^ 0x1EFEE31E),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7ADBF691 ^ 0x7ADB55B7),
				F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-44540535 ^ -44517455),
				(string)vdvwZa57Qmu55N3caSRV(0x2D3134C9 ^ 0x2D31DE85),
				(string)vdvwZa57Qmu55N3caSRV(0x11D1040B ^ 0x11D1EE67),
				(string)vdvwZa57Qmu55N3caSRV(-181342698 ^ -181402478)
			};
			return;
		}
	}

	internal static bool MsEt1f57EPP1W28pN1W1(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool JqXjn457cVdvOBM36vKP()
	{
		return qtdaHZ57X62QSaXXFJ7N == null;
	}

	internal static JLFqEJGJYiHaSdoROJXI HgEroM57jY8vhkFsGEVI()
	{
		return qtdaHZ57X62QSaXXFJ7N;
	}

	internal static object vdvwZa57Qmu55N3caSRV(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static SymbolType Fxs6uC57dxEcUaDkkR0E(object P_0)
	{
		return ((Symbol)P_0).Type;
	}

	internal static bool dJ1YXJ57gjqUbj4xD66d(object P_0)
	{
		return ((Symbol)P_0).IsBitMEX;
	}

	internal static bool wgks9u57ROCcQmBBnqYL(object P_0)
	{
		return ((Symbol)P_0).IsOKX;
	}

	internal static bool rvHSiY576K3E40b6rS3y(object P_0)
	{
		return ((Symbol)P_0).IsTigerX;
	}

	internal static double gmaKYh57Mi9uqewyIjAq(double P_0, double P_1, int P_2)
	{
		return k62GJ45Rvfj(P_0, P_1, P_2);
	}

	internal static double e7Bdlk57OyxDp53VYV1i(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	internal static double utqH9I57qDnUqQrk1Obm(double P_0, int P_1)
	{
		return Math.Round(P_0, P_1);
	}

	internal static object NaXRgc57IdhQ7FkWAb2v()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object D4W3lL57Wet2PMQUKG6A(object P_0)
	{
		return ((CultureInfo)P_0).NumberFormat;
	}

	internal static object dIf82Q57tTio2WErBXEC(object P_0)
	{
		return ((NumberFormatInfo)P_0).NumberDecimalSeparator;
	}

	internal static char ikTWCM57UT7jQjtpFRE4(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object NJQxRf57TfCQesgka98W(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}
}
