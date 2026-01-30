using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ECOEgqlSad8NUJZ2Dr9n;
using oHQ83JOt5YvFycBeriK;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace mavUpbOKrGvHvBt5wgT;

public static class hgBD5jOrYqDlpwXxerP
{
	[Serializable]
	[CompilerGenerated]
	private sealed class YNIxVonLCJCTpueGqohb
	{
		public static readonly YNIxVonLCJCTpueGqohb sPKnLKrR3Le;

		public static Func<bO1x5FOWAfoDL74XW1D, bool> qdtnLmXrmHf;

		private static YNIxVonLCJCTpueGqohb ek95ZFNoyStg2CaEHoYi;

		static YNIxVonLCJCTpueGqohb()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			KZqvYQNoC45J6Gjd5stO();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			sPKnLKrR3Le = new YNIxVonLCJCTpueGqohb();
		}

		public YNIxVonLCJCTpueGqohb()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal bool swdnLrjJqRJ(bO1x5FOWAfoDL74XW1D r)
		{
			return !r.IsValid;
		}

		internal static void KZqvYQNoC45J6Gjd5stO()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool pDqX6BNoZcm3JRv4snA9()
		{
			return ek95ZFNoyStg2CaEHoYi == null;
		}

		internal static YNIxVonLCJCTpueGqohb mgUayGNoVG3fF6bvxD1a()
		{
			return ek95ZFNoyStg2CaEHoYi;
		}
	}

	private static hgBD5jOrYqDlpwXxerP PthMrl4Bz6SvaMbi8kum;

	public static string a20Omq2816(string P_0)
	{
		if (string.IsNullOrWhiteSpace(P_0))
		{
			return (string)I2LxwD4aH67pUPfG0gwk();
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			try
			{
				new MailAddress(P_0);
				return null;
			}
			catch (Exception)
			{
				return Resources.OnboardingValidationInvalidEmail;
			}
		}
	}

	public static string spkOhRFuOi(string P_0)
	{
		if (string.IsNullOrWhiteSpace(P_0))
		{
			return dGlOwMuUTe(P_0);
		}
		if (((IEnumerable<bO1x5FOWAfoDL74XW1D>)z024mB4afhVNMsWtgBoR(P_0)).Where((bO1x5FOWAfoDL74XW1D r) => !r.IsValid).ToList().Any())
		{
			return dGlOwMuUTe(P_0);
		}
		return string.Empty;
	}

	private static string dGlOwMuUTe(string P_0)
	{
		bO1x5FOWAfoDL74XW1D[] array = o4aO7Tksxx(P_0);
		List<string> list = new List<string>();
		bO1x5FOWAfoDL74XW1D[] array2 = array;
		int num = 0;
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				bO1x5FOWAfoDL74XW1D bO1x5FOWAfoDL74XW1D = array2[num];
				string text = (string)(bO1x5FOWAfoDL74XW1D.IsValid ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839673694) : saVA6h4a9Tdcdq09gwiW(0xC1DDB3B ^ 0xC1D9CC1));
				list.Add(text + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90299776) + bO1x5FOWAfoDL74XW1D.Text);
				num++;
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				if (num >= array2.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 1:
				return string.Join((string)saVA6h4a9Tdcdq09gwiW(0x22BF43FC ^ 0x22BF0BFA), list);
			}
		}
	}

	public static bO1x5FOWAfoDL74XW1D[] o4aO7Tksxx(string P_0)
	{
		P_0 = P_0 ?? string.Empty;
		bO1x5FOWAfoDL74XW1D[] array = new bO1x5FOWAfoDL74XW1D[5];
		bO1x5FOWAfoDL74XW1D bO1x5FOWAfoDL74XW1D = new bO1x5FOWAfoDL74XW1D();
		sIUDWW4anpSmNXdY3TjT(bO1x5FOWAfoDL74XW1D, Resources.OnboardingPasswordRequirementMinLength);
		bO1x5FOWAfoDL74XW1D.IsValid = P_0.Length >= 8;
		array[0] = bO1x5FOWAfoDL74XW1D;
		bO1x5FOWAfoDL74XW1D obj = new bO1x5FOWAfoDL74XW1D
		{
			Text = (string)nBgbsq4aGJk45syxDJbs()
		};
		bVBi774aYCWHqoXeOb5K(obj, Regex.IsMatch(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306859100)));
		array[1] = obj;
		array[2] = new bO1x5FOWAfoDL74XW1D
		{
			Text = (string)eWt3f74aoyQUC6I9RWII(),
			IsValid = Regex.IsMatch(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44558947))
		};
		array[3] = new bO1x5FOWAfoDL74XW1D
		{
			Text = (string)ge15QP4avjqxK8WnCK9N(),
			IsValid = Regex.IsMatch(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFE4200))
		};
		bO1x5FOWAfoDL74XW1D bO1x5FOWAfoDL74XW1D2 = new bO1x5FOWAfoDL74XW1D();
		sIUDWW4anpSmNXdY3TjT(bO1x5FOWAfoDL74XW1D2, RhJgl54aBwNxJoR7UTGh());
		bVBi774aYCWHqoXeOb5K(bO1x5FOWAfoDL74XW1D2, d7IN994aarU7U9tC4OoA(P_0, saVA6h4a9Tdcdq09gwiW(0x741B85CB ^ 0x741BCDFD)));
		array[4] = bO1x5FOWAfoDL74XW1D2;
		return array;
	}

	static hgBD5jOrYqDlpwXxerP()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object I2LxwD4aH67pUPfG0gwk()
	{
		return Resources.OnboardingValidationTextInputCanNotEmpty;
	}

	internal static bool zC6FV14a0XSxoRKBtpn9()
	{
		return PthMrl4Bz6SvaMbi8kum == null;
	}

	internal static hgBD5jOrYqDlpwXxerP BIp9Q94a2eXniOltL3cf()
	{
		return PthMrl4Bz6SvaMbi8kum;
	}

	internal static object z024mB4afhVNMsWtgBoR(object P_0)
	{
		return o4aO7Tksxx((string)P_0);
	}

	internal static object saVA6h4a9Tdcdq09gwiW(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void sIUDWW4anpSmNXdY3TjT(object P_0, object P_1)
	{
		((bO1x5FOWAfoDL74XW1D)P_0).Text = (string)P_1;
	}

	internal static object nBgbsq4aGJk45syxDJbs()
	{
		return Resources.OnboardingPasswordRequirementDigit;
	}

	internal static void bVBi774aYCWHqoXeOb5K(object P_0, bool P_1)
	{
		((bO1x5FOWAfoDL74XW1D)P_0).IsValid = P_1;
	}

	internal static object eWt3f74aoyQUC6I9RWII()
	{
		return Resources.OnboardingPasswordRequirementLetter;
	}

	internal static object ge15QP4avjqxK8WnCK9N()
	{
		return Resources.OnboardingPasswordRequirementUppercase;
	}

	internal static object RhJgl54aBwNxJoR7UTGh()
	{
		return Resources.OnboardingPasswordRequirementSymbol;
	}

	internal static bool d7IN994aarU7U9tC4OoA(object P_0, object P_1)
	{
		return Regex.IsMatch((string)P_0, (string)P_1);
	}
}
