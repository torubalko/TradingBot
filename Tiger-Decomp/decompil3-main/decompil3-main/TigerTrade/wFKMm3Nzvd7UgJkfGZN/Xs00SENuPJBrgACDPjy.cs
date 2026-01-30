using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using aEpmU09nz6MEoNmc0pGJ;
using CQTxnCqa5E1U8LXGvlV;
using DBnSBuk72GkpbxLXiEP;
using ECOEgqlSad8NUJZ2Dr9n;
using k88Q51iwn84dxUE4tGQC;
using lD5TUC1oYhVR4AjY0ZM;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Properties;
using TigerTrade.UI.Dialogs.Models;
using TuAMtrl1Nd3XoZQQUXf0;

namespace wFKMm3Nzvd7UgJkfGZN;

internal class Xs00SENuPJBrgACDPjy : Kb4Jsjiw9kA3pBXEIXBC
{
	private string uHZki7hrff;

	private string CPFklw7e7k;

	[CompilerGenerated]
	private readonly ICommand VfYk4SScJv;

	[CompilerGenerated]
	private readonly ICommand lwukDhW5ZS;

	internal static Xs00SENuPJBrgACDPjy M4KHB9luSCBllIMCkQlU;

	public string ExpirationText
	{
		get
		{
			return uHZki7hrff;
		}
		private set
		{
			SetProperty(ref uHZki7hrff, value2, (string)m1R7PXluXXdSMOCZ0Krb(0x37B74BDF ^ 0x37B77875));
		}
	}

	public string Url
	{
		get
		{
			return CPFklw7e7k;
		}
		private set
		{
			SetProperty(ref CPFklw7e7k, value2, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB43AB9));
		}
	}

	public ICommand StartTradingCommand
	{
		[CompilerGenerated]
		get
		{
			return VfYk4SScJv;
		}
	}

	internal Xs00SENuPJBrgACDPjy()
	{
		r0XfJTlueDGFTjc9GJPm();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				VfYk4SScJv = new RelayCommand(delegate
				{
					bOek0OCSb8();
				});
				lwukDhW5ZS = new RelayCommand(delegate
				{
					XBYiw4Dxcxt(j18iDj9nukSCmEyZs5lH.eFU9vZ5IPof);
				});
				return;
			case 1:
				base.CanClose = true;
				vEp7CelusnK8Wdr5434B(this, false);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public ICommand yOUkBKmyeM()
	{
		return lwukDhW5ZS;
	}

	public override void pfwlfRMSBV3(object P_0 = null)
	{
		base.pfwlfRMSBV3(P_0);
		LicenseName licenseName = g4dfdtqBWBOCYxvPUSf.DOCqiK8QeQ();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				DateTime dateTime = g4dfdtqBWBOCYxvPUSf.mcfqDHb0wb();
				ExpirationText = LL2kH4ln4d(licenseName, dateTime);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
				{
					num = 0;
				}
				break;
			}
			default:
				Url = feQk2K7ZTK(licenseName);
				return;
			}
		}
	}

	private void bOek0OCSb8()
	{
		MXK7ZO1Y0M3if7KwDfj.FnF1D2pOqC((aI4kSFkwtQiWxIKtw47)7);
	}

	private string feQk2K7ZTK(LicenseName? P_0)
	{
		if (P_0 != LicenseName.Player)
		{
			return j18iDj9nukSCmEyZs5lH.vJb9vT64tbL;
		}
		return j18iDj9nukSCmEyZs5lH.NVB9vyCl7LX;
	}

	private string LL2kH4ln4d(LicenseName P_0, DateTime P_1)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				text = (string)OEObbQlucQbxGXx8jNx7();
				goto IL_003c;
			case 4:
				if (P_0 == LicenseName.Full)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (P_0 == LicenseName.Player)
				{
					text = (string)Y9CSWolujm5gFGmnJQij();
					goto IL_003c;
				}
				goto case 1;
			case 3:
				if (P_0 == LicenseName.Crypto)
				{
					num2 = 2;
					break;
				}
				text = null;
				num2 = 4;
				break;
			case 2:
				return Resources.OnboardingFirstConnectionExpirationDateCryptoString;
			case 1:
				{
					if (P_0 == LicenseName.Trial)
					{
						text = (string)UIWoWSluEAb3vu7K70GS();
					}
					goto IL_003c;
				}
				IL_003c:
				if (text == null)
				{
					return string.Empty;
				}
				return string.Format(text, P_1.ToString(Resources.AccountDateExpFormat, (IFormatProvider)AZ7SULluQMKgKWIPG4wp()));
			}
		}
	}

	public override void jV5lf6tiiHF()
	{
		MXK7ZO1Y0M3if7KwDfj.FnF1D2pOqC((aI4kSFkwtQiWxIKtw47)7);
	}

	[CompilerGenerated]
	private void Vq8kfRtBVQ(object P_0)
	{
		bOek0OCSb8();
	}

	[CompilerGenerated]
	private void YDrk9CTybX(object P_0)
	{
		XBYiw4Dxcxt(j18iDj9nukSCmEyZs5lH.eFU9vZ5IPof);
	}

	static Xs00SENuPJBrgACDPjy()
	{
		EIJqoJludeVnyhXL0cvt();
	}

	internal static void r0XfJTlueDGFTjc9GJPm()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void vEp7CelusnK8Wdr5434B(object P_0, bool P_1)
	{
		((Kb4Jsjiw9kA3pBXEIXBC)P_0).CanGoBack = P_1;
	}

	internal static bool felGw6luxOMmirro4TwS()
	{
		return M4KHB9luSCBllIMCkQlU == null;
	}

	internal static Xs00SENuPJBrgACDPjy ot1d0HluLGYXl8qkh42O()
	{
		return M4KHB9luSCBllIMCkQlU;
	}

	internal static object m1R7PXluXXdSMOCZ0Krb(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object OEObbQlucQbxGXx8jNx7()
	{
		return Resources.OnboardingFirstConnectionExpirationDateFullString;
	}

	internal static object Y9CSWolujm5gFGmnJQij()
	{
		return Resources.OnboardingFirstConnectionExpirationDatePlayerString;
	}

	internal static object UIWoWSluEAb3vu7K70GS()
	{
		return Resources.OnboardingFirstConnectionExpirationDateTrialString;
	}

	internal static object AZ7SULluQMKgKWIPG4wp()
	{
		return CultureInfo.DefaultThreadCurrentUICulture;
	}

	internal static void EIJqoJludeVnyhXL0cvt()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
