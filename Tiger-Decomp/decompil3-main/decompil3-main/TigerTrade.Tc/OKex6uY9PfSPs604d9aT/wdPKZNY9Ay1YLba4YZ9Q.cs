using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using BfZtb759KlUg4482QKym;
using EBwZqeajkUULymgLZ6pW;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using siIK6eY9t5vjpCCCFKlo;
using TigerTrade.Tc.Properties;
using x97CE55GhEYKgt7TSVZT;

namespace OKex6uY9PfSPs604d9aT;

[DataContract(Name = "SmartComSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.TradeClient")]
internal sealed class wdPKZNY9Ay1YLba4YZ9Q : gpnr5oG8Q1cRMmiYT0Ut
{
	[CompilerGenerated]
	private string uMhYnoT1bjm;

	[CompilerGenerated]
	private string kDIYnvj9aVG;

	[CompilerGenerated]
	private string JT2YnBtSfrk;

	private static wdPKZNY9Ay1YLba4YZ9Q gkuoTCS9HWbM6kxhPTau;

	[DataMember(Name = "Host")]
	public string jRXY9zuuBax
	{
		[CompilerGenerated]
		get
		{
			return uMhYnoT1bjm;
		}
		[CompilerGenerated]
		set
		{
			uMhYnoT1bjm = text;
		}
	}

	[DataMember(Name = "Login")]
	public string Login
	{
		[CompilerGenerated]
		get
		{
			return kDIYnvj9aVG;
		}
		[CompilerGenerated]
		set
		{
			kDIYnvj9aVG = text;
		}
	}

	[DataMember(Name = "Password")]
	public string rspYn9midoL
	{
		[CompilerGenerated]
		get
		{
			return JT2YnBtSfrk;
		}
		[CompilerGenerated]
		set
		{
			JT2YnBtSfrk = jT2YnBtSfrk;
		}
	}

	public string Password
	{
		get
		{
			return bKiVl7ajN7b8mPCIOURL.GcUajSSfECS(rspYn9midoL);
		}
		set
		{
			rspYn9midoL = bKiVl7ajN7b8mPCIOURL.I1Uaj5WJ3yL(text);
		}
	}

	public static List<wSisEnY9W3gHNPIFUdbR> Servers => null;

	public static List<wSisEnY9W3gHNPIFUdbR> NBcY9JWmA0o(bool P_0 = true)
	{
		List<wSisEnY9W3gHNPIFUdbR> list = new List<wSisEnY9W3gHNPIFUdbR>
		{
			new wSisEnY9W3gHNPIFUdbR(Resources.SmartComSettingsMainServer1, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841436781), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x735715F1 ^ 0x7357EA0B)),
			new wSisEnY9W3gHNPIFUdbR(Resources.SmartComSettingsMainServer2, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2D313048 ^ 0x2D30304E), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-673683647 ^ -673670981)),
			new wSisEnY9W3gHNPIFUdbR(Resources.SmartComSettingsReserveServer1, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28ABDFC), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-838841832 ^ -838814238)),
			new wSisEnY9W3gHNPIFUdbR(Resources.SmartComSettingsReserveServer2, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1763895751 ^ -1763961251), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1522697859 ^ -1522694521))
		};
		if (P_0)
		{
			list.Add(new wSisEnY9W3gHNPIFUdbR(Resources.SmartComSettingsDemoServer, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1487846E ^ 0x148684FC), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1416986301 ^ -1416986951)));
		}
		return list;
	}

	public wSisEnY9W3gHNPIFUdbR zmVY9FroG4Z()
	{
		return NBcY9JWmA0o().FirstOrDefault((wSisEnY9W3gHNPIFUdbR P_0) => NQuY7pS9nmATuWdOewdw(P_0.yQRY9mcRdk0(), jRXY9zuuBax));
	}

	public wdPKZNY9Ay1YLba4YZ9Q()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		jRXY9zuuBax = NBcY9JWmA0o()[0].yQRY9mcRdk0();
		Login = "";
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Password = "";
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[CompilerGenerated]
	private bool mujY93HRdf4(wSisEnY9W3gHNPIFUdbR P_0)
	{
		return NQuY7pS9nmATuWdOewdw(P_0.yQRY9mcRdk0(), jRXY9zuuBax);
	}

	static wdPKZNY9Ay1YLba4YZ9Q()
	{
		O2gWcgS9GJv92RwjQify();
		s7wVCeS9YoHB2YekGZoD();
	}

	internal static bool eMGTbRS9fcB8tF1HEUAa()
	{
		return gkuoTCS9HWbM6kxhPTau == null;
	}

	internal static wdPKZNY9Ay1YLba4YZ9Q hFrRsoS99wecuIBHQwoi()
	{
		return gkuoTCS9HWbM6kxhPTau;
	}

	internal static bool NQuY7pS9nmATuWdOewdw(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void O2gWcgS9GJv92RwjQify()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void s7wVCeS9YoHB2YekGZoD()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
