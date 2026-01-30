using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using GgaBbw2rMpPQSyDFpVt4;
using KhLsunOuV5fXe8JLMUd;
using TigerTrade.Properties;
using TigerTrade.UI.Dialogs.Models;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Onboarding.Common;

internal class LicenseGroupDescription
{
	[CompilerGenerated]
	private readonly EglEJYOpesRD66Nfv8j zhcqYpfiT8;

	[CompilerGenerated]
	private readonly string bBZqoDMLV6;

	private static Dictionary<EglEJYOpesRD66Nfv8j, LicenseGroupDescription> LAJqvDhV4c;

	internal static LicenseGroupDescription oTDvRT4a5o7coWJXvFW8;

	public string Features
	{
		[CompilerGenerated]
		get
		{
			return bBZqoDMLV6;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public EglEJYOpesRD66Nfv8j IYeq9KrUqH()
	{
		return zhcqYpfiT8;
	}

	private LicenseGroupDescription(EglEJYOpesRD66Nfv8j P_0, string P_1)
	{
		glRgNU4aLvdh5kg2YTaY();
		base._002Ector();
		zhcqYpfiT8 = P_0;
		bBZqoDMLV6 = P_1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static LicenseGroupDescription havqHbE0HS(G1scEK2r6h2VJ8X13I0W P_0)
	{
		switch (g05aOk4ae9kItQHXVvqB(P_0))
		{
		case LicenseName.Crypto:
			return LAJqvDhV4c[(EglEJYOpesRD66Nfv8j)1];
		case LicenseName.Full:
			return LAJqvDhV4c[(EglEJYOpesRD66Nfv8j)2];
		case LicenseName.Trial:
			return LAJqvDhV4c[(EglEJYOpesRD66Nfv8j)3];
		case LicenseName.Player:
			return LAJqvDhV4c[EglEJYOpesRD66Nfv8j.Player];
		default:
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => null, 
			};
		}
		}
	}

	public static LicenseGroupDescription TTqqfSqaYq(EglEJYOpesRD66Nfv8j P_0)
	{
		LAJqvDhV4c.TryGetValue(P_0, out var value);
		return value;
	}

	static LicenseGroupDescription()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		LAJqvDhV4c = new Dictionary<EglEJYOpesRD66Nfv8j, LicenseGroupDescription>
		{
			{
				(EglEJYOpesRD66Nfv8j)1,
				new LicenseGroupDescription((EglEJYOpesRD66Nfv8j)1, Resources.OnboardingCryptoLicenseDescription)
			},
			{
				(EglEJYOpesRD66Nfv8j)2,
				new LicenseGroupDescription((EglEJYOpesRD66Nfv8j)2, Resources.OnboardingFullLicenseDescription)
			},
			{
				(EglEJYOpesRD66Nfv8j)3,
				new LicenseGroupDescription((EglEJYOpesRD66Nfv8j)3, Resources.OnboardingTrialLicenseDescription)
			},
			{
				EglEJYOpesRD66Nfv8j.Player,
				new LicenseGroupDescription(EglEJYOpesRD66Nfv8j.Player, (string)JTOMc84asp1bX3pNPQEY())
			}
		};
	}

	internal static void glRgNU4aLvdh5kg2YTaY()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool uPYQpL4aSFbcpTa9Mcl0()
	{
		return oTDvRT4a5o7coWJXvFW8 == null;
	}

	internal static LicenseGroupDescription nT2P9M4axHOFonBaeb9h()
	{
		return oTDvRT4a5o7coWJXvFW8;
	}

	internal static LicenseName g05aOk4ae9kItQHXVvqB(object P_0)
	{
		return ((G1scEK2r6h2VJ8X13I0W)P_0).LicenseName;
	}

	internal static object JTOMc84asp1bX3pNPQEY()
	{
		return Resources.OnboardingPlayerLicenseDescription;
	}
}
