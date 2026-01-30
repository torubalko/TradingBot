using System.ComponentModel;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using LxkBMPH3MZ8ObkVk5Atk;
using MIA3eC2ZXsuRyAB0mjn;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Parts.Symbols;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace qup3Wb2Uct4HQ9fqn434;

internal sealed class htyRfB2UXes0ZJJy1QIP : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private readonly string dEl2UIXTCQL;

	[CompilerGenerated]
	private readonly SymbolType UJq2UWEMcgF;

	[CompilerGenerated]
	private readonly string Elx2UtW5KEh;

	[CompilerGenerated]
	private readonly string vWH2UUKx6P4;

	[CompilerGenerated]
	private readonly string gNo2UTJrH6U;

	private string agl2UyvnU5J;

	[CompilerGenerated]
	private readonly p4gwA9H36qTSRys5LY33 fHg2UZPlAcy;

	internal static htyRfB2UXes0ZJJy1QIP YxsENe4uanLCax42QBvo;

	[Browsable(false)]
	public string wV62UQmc3dL
	{
		[CompilerGenerated]
		get
		{
			return dEl2UIXTCQL;
		}
	}

	[Browsable(false)]
	public SymbolType SymbolType
	{
		[CompilerGenerated]
		get
		{
			return UJq2UWEMcgF;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("SymbolsWindowName")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return Elx2UtW5KEh;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("SymbolsWindowType")]
	public string Type
	{
		[CompilerGenerated]
		get
		{
			return vWH2UUKx6P4;
		}
	}

	[bBo0Zd2ycQQr3LNHQf4("SymbolsWindowExpiration")]
	public string Expiration
	{
		[CompilerGenerated]
		get
		{
			return gNo2UTJrH6U;
		}
	}

	[Description("Right")]
	[bBo0Zd2ycQQr3LNHQf4("SymbolsWindowComission")]
	public string Comission
	{
		get
		{
			return agl2UyvnU5J;
		}
		set
		{
			if (!text.Equals(agl2UyvnU5J))
			{
				agl2UyvnU5J = text;
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57762937));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
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

	[Browsable(false)]
	public p4gwA9H36qTSRys5LY33 Settings
	{
		[CompilerGenerated]
		get
		{
			return fHg2UZPlAcy;
		}
	}

	public htyRfB2UXes0ZJJy1QIP(Symbol P_0, p4gwA9H36qTSRys5LY33 P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 8;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
		{
			num = 9;
		}
		SymbolType type = default(SymbolType);
		while (true)
		{
			switch (num)
			{
			case 9:
				dEl2UIXTCQL = P_0.ID;
				UJq2UWEMcgF = P_0.Type;
				fHg2UZPlAcy = P_1;
				num = 2;
				continue;
			case 8:
				vWH2UUKx6P4 = Resources.SymbolsWindowCrypto;
				num = 7;
				continue;
			case 6:
				goto IL_00d9;
			case 2:
				Elx2UtW5KEh = P_0.Name;
				type = P_0.Type;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
				{
					num = 5;
				}
				continue;
			case 1:
				return;
			case 3:
			case 7:
				break;
			default:
				goto IL_016d;
			case 5:
				switch (type)
				{
				case SymbolType.Stock:
					vWH2UUKx6P4 = (string)XoGxEf4uDQvqwDkHBN36();
					goto end_IL_0033;
				case SymbolType.Future:
					vWH2UUKx6P4 = Resources.SymbolsWindowFuture;
					gNo2UTJrH6U = P_0.Expiration.ToShortDateString();
					goto end_IL_0033;
				case SymbolType.Crypto:
					break;
				case SymbolType.Currency:
					vWH2UUKx6P4 = (string)xEIIlc4ubjH5e8P7AXLQ();
					goto end_IL_0033;
				case SymbolType.Index:
					goto IL_00d9;
				default:
					goto end_IL_0033;
				case SymbolType.Option:
					goto IL_016d;
				case SymbolType.Forex:
					goto IL_01d6;
				}
				goto case 8;
			case 4:
				goto IL_01d6;
				IL_01d6:
				vWH2UUKx6P4 = Resources.SymbolsWindowForex;
				break;
				IL_016d:
				vWH2UUKx6P4 = Resources.SymbolsWindowOption;
				break;
				IL_00d9:
				vWH2UUKx6P4 = (string)u10gVi4u4rYG9p3Of4xj();
				num = 3;
				continue;
				end_IL_0033:
				break;
			}
			mHX2UjhvpMO();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
			{
				num = 1;
			}
		}
	}

	public void mHX2UjhvpMO()
	{
		double num = wKkxoW4uNukv1HNgMMMc(Settings) + Settings.ExchangeComission;
		if (!(num > 0.0))
		{
			return;
		}
		int num2;
		if (AywZFB4uk9EUeE5o9htf(Settings) == SymbolCommissionType.Fixed)
		{
			Comission = num.ToString((string)FGXo9j4u1YsPeQ3VKVWo(0xAD5B8B3 ^ 0xAD5D2B7));
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
			{
				num2 = 0;
			}
		}
		else
		{
			Comission = num.ToString((string)FGXo9j4u1YsPeQ3VKVWo(-1346994499 ^ -1347021639)) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B3DE21);
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
			{
				num2 = 1;
			}
		}
		switch (num2)
		{
		case 1:
			break;
		case 0:
			break;
		}
	}

	static htyRfB2UXes0ZJJy1QIP()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool NQnRr64uiU6XaZ7PDaIi()
	{
		return YxsENe4uanLCax42QBvo == null;
	}

	internal static htyRfB2UXes0ZJJy1QIP QKUfPT4ulYSkSUSg2bSt()
	{
		return YxsENe4uanLCax42QBvo;
	}

	internal static object u10gVi4u4rYG9p3Of4xj()
	{
		return Resources.SymbolsWindowIndex;
	}

	internal static object XoGxEf4uDQvqwDkHBN36()
	{
		return Resources.SymbolsWindowStock;
	}

	internal static object xEIIlc4ubjH5e8P7AXLQ()
	{
		return Resources.SymbolsWindowCurrency;
	}

	internal static double wKkxoW4uNukv1HNgMMMc(object P_0)
	{
		return ((p4gwA9H36qTSRys5LY33)P_0).BrokerComission;
	}

	internal static SymbolCommissionType AywZFB4uk9EUeE5o9htf(object P_0)
	{
		return ((p4gwA9H36qTSRys5LY33)P_0).CommissionType;
	}

	internal static object FGXo9j4u1YsPeQ3VKVWo(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
