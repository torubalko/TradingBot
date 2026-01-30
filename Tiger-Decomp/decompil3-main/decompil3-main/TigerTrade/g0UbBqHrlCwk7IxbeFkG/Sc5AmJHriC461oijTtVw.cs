using System.Runtime.CompilerServices;
using aWyZAjHVfueYKTD2qNgp;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace g0UbBqHrlCwk7IxbeFkG;

[JsonObject(/*Could not decode attribute arguments.*/)]
internal class Sc5AmJHriC461oijTtVw : QCMRkVHVHQDMIML9Hckc
{
	[CompilerGenerated]
	private string r18Hr5PM6Uh;

	[CompilerGenerated]
	private string g34HrSLiRdn;

	[CompilerGenerated]
	private string uWvHrxLERV6;

	private static Sc5AmJHriC461oijTtVw icehqVDW8lnXdMhKjmI4;

	[JsonProperty("exchange")]
	public string Exchange
	{
		[CompilerGenerated]
		get
		{
			return r18Hr5PM6Uh;
		}
		[CompilerGenerated]
		set
		{
			r18Hr5PM6Uh = value;
		}
	}

	[JsonProperty("market")]
	public string Market
	{
		[CompilerGenerated]
		get
		{
			return g34HrSLiRdn;
		}
		[CompilerGenerated]
		set
		{
			g34HrSLiRdn = value;
		}
	}

	[JsonProperty("symbol")]
	public string Symbol
	{
		[CompilerGenerated]
		get
		{
			return uWvHrxLERV6;
		}
		[CompilerGenerated]
		set
		{
			uWvHrxLERV6 = value;
		}
	}

	public Sc5AmJHriC461oijTtVw(Symbol NU1ge9l4i6U4C76BJ8uh)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Exchange = (string)PYhk7hDWJGFdIZxMyUcF(NU1ge9l4i6U4C76BJ8uh);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (NU1ge9l4i6U4C76BJ8uh.IsBinance)
				{
					num = 2;
					continue;
				}
				break;
			case 2:
				Exchange = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123726274);
				break;
			default:
				Symbol = NU1ge9l4i6U4C76BJ8uh.Code;
				return;
			}
			Market = (string)((NU1ge9l4i6U4C76BJ8uh.Type == SymbolType.Crypto) ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962398163) : xQ4f2ADWFwsBqcVt47d4(-839659358 ^ -839900826));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
			{
				num = 0;
			}
		}
	}

	static Sc5AmJHriC461oijTtVw()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool xo9v0eDWAPO2OQwi3eq9()
	{
		return icehqVDW8lnXdMhKjmI4 == null;
	}

	internal static Sc5AmJHriC461oijTtVw CJMFxgDWPhfXEMvQTK6l()
	{
		return icehqVDW8lnXdMhKjmI4;
	}

	internal static object PYhk7hDWJGFdIZxMyUcF(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static object xQ4f2ADWFwsBqcVt47d4(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
