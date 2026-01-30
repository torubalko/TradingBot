using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using BfZtb759KlUg4482QKym;
using EBwZqeajkUULymgLZ6pW;
using jG6ZTfYWDhFseU2J0Rv8;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using OhwR2LaxHYJ0lj0C9GSK;
using r8oOHiajFPNBXu6XiAHj;
using TigerTrade.Tc.Properties;
using x97CE55GhEYKgt7TSVZT;

namespace yW2lnGYWMmDfmRlVPfeY;

[DataContract(Name = "TigerXSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.TradeClient")]
internal sealed class y1UTwfYW6jIuwTT65Lor : gpnr5oG8Q1cRMmiYT0Ut
{
	[CompilerGenerated]
	private string V0bYtXMaaVr;

	[CompilerGenerated]
	private string cIsYtc7DgPU;

	[CompilerGenerated]
	private string PBiYtjfiJnq;

	[CompilerGenerated]
	private string XkGYtEp5h6P;

	[CompilerGenerated]
	private string AXfYtQ1kIaj;

	[CompilerGenerated]
	private string C2kYtdtCH9C;

	[CompilerGenerated]
	private string v1QYtgpxS6b;

	private int TloYtRNbf4F;

	[CompilerGenerated]
	private int DdSYt6HRY9H;

	[CompilerGenerated]
	private bool xUKYtM54liO;

	[CompilerGenerated]
	private bool MBAYtO08oAf;

	[CompilerGenerated]
	private bool C2nYtqA9auX;

	[CompilerGenerated]
	private bool pP9YtIhdMgx;

	[CompilerGenerated]
	private bool? qbGYtW5P6vV;

	[CompilerGenerated]
	private bool OfgYttrDWZA;

	internal static y1UTwfYW6jIuwTT65Lor cARb3JSEEd78VHrjJVBh;

	[DataMember(Name = "Account")]
	public string Account
	{
		[CompilerGenerated]
		get
		{
			return V0bYtXMaaVr;
		}
		[CompilerGenerated]
		set
		{
			V0bYtXMaaVr = v0bYtXMaaVr;
		}
	}

	[DataMember(Name = "ApiKey")]
	public string gJ8YWZre7YF
	{
		[CompilerGenerated]
		get
		{
			return cIsYtc7DgPU;
		}
		[CompilerGenerated]
		set
		{
			cIsYtc7DgPU = text;
		}
	}

	[DataMember(Name = "ApiSecret")]
	public string TaNYWrvl2ex
	{
		[CompilerGenerated]
		get
		{
			return PBiYtjfiJnq;
		}
		[CompilerGenerated]
		set
		{
			PBiYtjfiJnq = pBiYtjfiJnq;
		}
	}

	[DataMember(Name = "ProxyId")]
	public string xvXYW8aFepv
	{
		[CompilerGenerated]
		get
		{
			return XkGYtEp5h6P;
		}
		[CompilerGenerated]
		set
		{
			XkGYtEp5h6P = xkGYtEp5h6P;
		}
	}

	[DataMember(Name = "Proxy")]
	public string Proxy
	{
		[CompilerGenerated]
		get
		{
			return AXfYtQ1kIaj;
		}
		[CompilerGenerated]
		set
		{
			AXfYtQ1kIaj = aXfYtQ1kIaj;
		}
	}

	[DataMember(Name = "ProxyUser")]
	public string S08YW3bbpZj
	{
		[CompilerGenerated]
		get
		{
			return C2kYtdtCH9C;
		}
		[CompilerGenerated]
		set
		{
			C2kYtdtCH9C = c2kYtdtCH9C;
		}
	}

	[DataMember(Name = "ProxyPass")]
	public string rHMYWzLADsJ
	{
		[CompilerGenerated]
		get
		{
			return v1QYtgpxS6b;
		}
		[CompilerGenerated]
		set
		{
			v1QYtgpxS6b = text;
		}
	}

	[DefaultValue(3000)]
	[DataMember(Name = "DepthMaxLevels")]
	public int fcTYtHBR76o
	{
		get
		{
			return TloYtRNbf4F;
		}
		set
		{
			num = Math.Max(500, ABGhJ8SEgKreHpwsjbWo(10000, num));
			TloYtRNbf4F = num;
		}
	}

	[DataMember(Name = "TigerXServer")]
	public int tvlYtnLifK5
	{
		[CompilerGenerated]
		get
		{
			return DdSYt6HRY9H;
		}
		[CompilerGenerated]
		set
		{
			DdSYt6HRY9H = ddSYt6HRY9H;
		}
	}

	[DataMember(Name = "ReduceDom")]
	public bool VlNYtoaoJbi
	{
		[CompilerGenerated]
		get
		{
			return xUKYtM54liO;
		}
		[CompilerGenerated]
		set
		{
			xUKYtM54liO = flag;
		}
	}

	[DataMember(Name = "UseProxyForMarketData")]
	public bool ThnYtapiFB9
	{
		[CompilerGenerated]
		get
		{
			return MBAYtO08oAf;
		}
		[CompilerGenerated]
		set
		{
			MBAYtO08oAf = mBAYtO08oAf;
		}
	}

	[DataMember(Name = "UseProxyForUserData")]
	public bool swuYt48xZq6
	{
		[CompilerGenerated]
		get
		{
			return C2nYtqA9auX;
		}
		[CompilerGenerated]
		set
		{
			C2nYtqA9auX = c2nYtqA9auX;
		}
	}

	[DataMember(Name = "UseProxyForOrders")]
	public bool OR6YtNUfnKs
	{
		[CompilerGenerated]
		get
		{
			return pP9YtIhdMgx;
		}
		[CompilerGenerated]
		set
		{
			pP9YtIhdMgx = flag;
		}
	}

	[DataMember(Name = "IsBrokerCredentials")]
	public bool? yIWYt5ThnHY
	{
		[CompilerGenerated]
		get
		{
			return qbGYtW5P6vV;
		}
		[CompilerGenerated]
		set
		{
			qbGYtW5P6vV = flag;
		}
	}

	[DataMember(Name = "IsUserCustomizationDone")]
	public bool Pv2YtLqASbI
	{
		[CompilerGenerated]
		get
		{
			return OfgYttrDWZA;
		}
		[CompilerGenerated]
		set
		{
			OfgYttrDWZA = ofgYttrDWZA;
		}
	}

	[SpecialName]
	public string t4tYWKH0rhA()
	{
		return bKiVl7ajN7b8mPCIOURL.GcUajSSfECS(TaNYWrvl2ex);
	}

	[SpecialName]
	public void onMYWmoPT7E(string P_0)
	{
		TaNYWrvl2ex = bKiVl7ajN7b8mPCIOURL.I1Uaj5WJ3yL(P_0);
	}

	private static List<purcbjYW4n7eIUr5KMNN> zHkYWOVvjGx()
	{
		return new List<purcbjYW4n7eIUr5KMNN>
		{
			new purcbjYW4n7eIUr5KMNN(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-837284864 ^ -837201542), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3544E813 ^ 0x3545B569))
		};
	}

	[SpecialName]
	public static List<purcbjYW4n7eIUr5KMNN> KkgYte6amdJ()
	{
		return new List<purcbjYW4n7eIUr5KMNN>
		{
			new purcbjYW4n7eIUr5KMNN(1, Resources.TigerXEasternRoute),
			new purcbjYW4n7eIUr5KMNN(0, Resources.TigerXWesternRoute)
		};
	}

	public y1UTwfYW6jIuwTT65Lor()
	{
		pBJQOmSERfMUtD1g21Wl();
		base._002Ector();
		Account = zHkYWOVvjGx()[0].F0XYW5NllsH();
		int num = 2;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				onMYWmoPT7E("");
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
				{
					num = 0;
				}
				break;
			case 2:
				gJ8YWZre7YF = "";
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
				{
					num = 0;
				}
				break;
			default:
				Proxy = "";
				VlNYtoaoJbi = false;
				Pv2YtLqASbI = false;
				return;
			}
		}
	}

	public purcbjYW4n7eIUr5KMNN e3YYWqo3kqb()
	{
		return zHkYWOVvjGx().FirstOrDefault((purcbjYW4n7eIUr5KMNN P_0) => ISglZiSEMP13V2X5TO8K(P_0.F0XYW5NllsH(), Account)) ?? zHkYWOVvjGx()[0];
	}

	public override C3trUsajJIHJMtdo9pBg j6RloBnORGD()
	{
		C3trUsajJIHJMtdo9pBg c3trUsajJIHJMtdo9pBg = C3trUsajJIHJMtdo9pBg.ELKaj3JVu7e(xvXYW8aFepv, Proxy, S08YW3bbpZj, rHMYWzLADsJ);
		xvXYW8aFepv = c3trUsajJIHJMtdo9pBg.Id;
		return c3trUsajJIHJMtdo9pBg;
	}

	public override void krqloaeIlq6(C3trUsajJIHJMtdo9pBg P_0)
	{
		xvXYW8aFepv = (string)(string.IsNullOrEmpty(P_0?.Id) ? qXLXHlax25yCgG9femcG.jVxaxscCLFW.Id : QZ1LF4SE6SV6hyhMljp5(P_0));
	}

	[OnDeserializing]
	private void Sg3YWIrW05t(StreamingContext P_0)
	{
		ThnYtapiFB9 = true;
		swuYt48xZq6 = true;
		OR6YtNUfnKs = true;
		fcTYtHBR76o = 3000;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[CompilerGenerated]
	private bool H5LYWWqpGjm(purcbjYW4n7eIUr5KMNN P_0)
	{
		return ISglZiSEMP13V2X5TO8K(P_0.F0XYW5NllsH(), Account);
	}

	static y1UTwfYW6jIuwTT65Lor()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		n5iLUaSEOv0ZeGtEQWuh();
	}

	internal static bool B9Drq5SEQwfL2QXSd9G0()
	{
		return cARb3JSEEd78VHrjJVBh == null;
	}

	internal static y1UTwfYW6jIuwTT65Lor pkglZ1SEdF1geCLtAEtC()
	{
		return cARb3JSEEd78VHrjJVBh;
	}

	internal static int ABGhJ8SEgKreHpwsjbWo(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void pBJQOmSERfMUtD1g21Wl()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object QZ1LF4SE6SV6hyhMljp5(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Id;
	}

	internal static bool ISglZiSEMP13V2X5TO8K(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void n5iLUaSEOv0ZeGtEQWuh()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
