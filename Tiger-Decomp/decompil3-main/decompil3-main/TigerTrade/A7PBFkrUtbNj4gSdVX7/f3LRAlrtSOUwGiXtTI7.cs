using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using iTKs8kKoZFtJVRfCm8S;
using l5fyixCdr9wYCP9KK6I;
using QP1pXiZJsqJcfmyhm4k;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace A7PBFkrUtbNj4gSdVX7;

[DataContract(Name = "SmartTapeSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.SmartTape.Settings")]
internal sealed class f3LRAlrtSOUwGiXtTI7 : zImfxTKY16LCm1N4HBE
{
	[CompilerGenerated]
	private string bYPK0xYjvF;

	[CompilerGenerated]
	private string Am2K2aYxdN;

	private miUjgiCQ4L4boFEaJpD B8wKH63Z8i;

	private syGBQLZPrWA2UUI6eRT IByKflP7lK;

	private XFont iFgK90w6IN;

	[CompilerGenerated]
	private string HoNKnYwj38;

	[CompilerGenerated]
	private int EOnKGetXYc;

	private static f3LRAlrtSOUwGiXtTI7 G7wEGm4NYHmiI4TuZgwn;

	[DataMember(Name = "TemplateID")]
	public string H5HrKAOBSk
	{
		[CompilerGenerated]
		get
		{
			return bYPK0xYjvF;
		}
		[CompilerGenerated]
		set
		{
			bYPK0xYjvF = text;
		}
	}

	[DataMember(Name = "TemplateName")]
	public string TemplateName
	{
		[CompilerGenerated]
		get
		{
			return Am2K2aYxdN;
		}
		[CompilerGenerated]
		set
		{
			Am2K2aYxdN = am2K2aYxdN;
		}
	}

	[DataMember(Name = "GeneralSettings")]
	public miUjgiCQ4L4boFEaJpD GeneralSettings
	{
		get
		{
			return B8wKH63Z8i ?? (B8wKH63Z8i = new miUjgiCQ4L4boFEaJpD());
		}
		set
		{
			if (!object.Equals(miUjgiCQ4L4boFEaJpD, B8wKH63Z8i))
			{
				B8wKH63Z8i = miUjgiCQ4L4boFEaJpD;
				GgMKvYwS7c(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1848936664));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
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
	}

	[DataMember(Name = "AlertsSettings")]
	public syGBQLZPrWA2UUI6eRT AlertsSettings
	{
		get
		{
			return IByKflP7lK ?? (IByKflP7lK = new syGBQLZPrWA2UUI6eRT());
		}
		set
		{
			if (!object.Equals(syGBQLZPrWA2UUI6eRT, IByKflP7lK))
			{
				IByKflP7lK = syGBQLZPrWA2UUI6eRT;
				GgMKvYwS7c(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA8B002));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
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
	}

	private string FontName
	{
		[CompilerGenerated]
		get
		{
			return HoNKnYwj38;
		}
		[CompilerGenerated]
		set
		{
			HoNKnYwj38 = hoNKnYwj;
		}
	}

	private int FontSize
	{
		[CompilerGenerated]
		get
		{
			return EOnKGetXYc;
		}
		[CompilerGenerated]
		set
		{
			EOnKGetXYc = eOnKGetXYc;
		}
	}

	public f3LRAlrtSOUwGiXtTI7()
	{
		hcECfO4NBDQHHS1Mbo9n();
		base._002Ector();
	}

	public void XTfrTRvU8v(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				GeneralSettings.E2PKiCBBGy = P_0;
				Hj5IGU4NaFtUJ3OjwqeM(AlertsSettings, P_0);
				return;
			case 1:
				base.E2PKiCBBGy = P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void DPmrytAJR2(f3LRAlrtSOUwGiXtTI7 P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (P_0 != null)
				{
					try
					{
						f3LRAlrtSOUwGiXtTI7 f3LRAlrtSOUwGiXtTI8 = ConfigSerializer.LoadFromString<f3LRAlrtSOUwGiXtTI7>(ConfigSerializer.SaveToString(P_0));
						NWicNC4NiBqsbQLr70dA(GeneralSettings, f3LRAlrtSOUwGiXtTI8.GeneralSettings);
						AlertsSettings.Jt6ZFViFqH((syGBQLZPrWA2UUI6eRT)PhinnQ4NlYtREUGlKYHI(f3LRAlrtSOUwGiXtTI8));
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
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
					catch (Exception ex)
					{
						IZWgZ64N41QKOQLm0OH0(ex);
						return;
					}
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[SpecialName]
	public XFont OnprP3oVqe()
	{
		return iFgK90w6IN ?? (iFgK90w6IN = new XFont());
	}

	[SpecialName]
	private void ng6rJ2J3Lo(XFont P_0)
	{
		iFgK90w6IN = P_0;
	}

	public void A6trZRfgGA()
	{
		int num = 3;
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (tL1rQC4Nb0xfc8BqRaZ9(text))
					{
						text = (string)fHal1T4NNSi0LmAfdhxA(0x11D1040B ^ 0x11D15259);
					}
					num3 = j18iDj9nukSCmEyZs5lH.Settings.SmartTapeFontSize;
					if (num3 >= 8)
					{
						num2 = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 1;
				case 0:
					return;
				case 3:
					break;
				case 1:
					num3 = 14;
					goto IL_00dc;
				case 4:
					{
						if (num3 > 50)
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_00dc;
					}
					IL_00dc:
					FontName = text;
					FontSize = num3;
					kCgrVqKsmC();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			text = (string)gAqjcx4NDq20oH3lBycn(j18iDj9nukSCmEyZs5lH.Settings);
			num = 2;
		}
	}

	private void kCgrVqKsmC()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (tL1rQC4Nb0xfc8BqRaZ9(FontName))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_0052;
			case 1:
				{
					FontName = (string)fHal1T4NNSi0LmAfdhxA(-1799510641 ^ -1799490595);
					goto IL_0052;
				}
				IL_0052:
				if (FontSize < 8 || FontSize > 50)
				{
					FontSize = 14;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			break;
		}
		ng6rJ2J3Lo(new XFont(FontName, FontSize));
	}

	static f3LRAlrtSOUwGiXtTI7()
	{
		NxnKo14NkdUsN49Q58St();
	}

	internal static bool RxW7Dd4Nor8EqVqWAA9f()
	{
		return G7wEGm4NYHmiI4TuZgwn == null;
	}

	internal static f3LRAlrtSOUwGiXtTI7 wVNASG4NvOAroK1GMrMI()
	{
		return G7wEGm4NYHmiI4TuZgwn;
	}

	internal static void hcECfO4NBDQHHS1Mbo9n()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void Hj5IGU4NaFtUJ3OjwqeM(object P_0, object P_1)
	{
		((zImfxTKY16LCm1N4HBE)P_0).E2PKiCBBGy = (string)P_1;
	}

	internal static void NWicNC4NiBqsbQLr70dA(object P_0, object P_1)
	{
		((miUjgiCQ4L4boFEaJpD)P_0).p1qCgbAwPZ((miUjgiCQ4L4boFEaJpD)P_1);
	}

	internal static object PhinnQ4NlYtREUGlKYHI(object P_0)
	{
		return ((f3LRAlrtSOUwGiXtTI7)P_0).AlertsSettings;
	}

	internal static void IZWgZ64N41QKOQLm0OH0(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static object gAqjcx4NDq20oH3lBycn(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).SmartTapeFontName;
	}

	internal static bool tL1rQC4Nb0xfc8BqRaZ9(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object fHal1T4NNSi0LmAfdhxA(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void NxnKo14NkdUsN49Q58St()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
