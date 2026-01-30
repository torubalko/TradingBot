using System.Runtime.CompilerServices;
using aWyZAjHVfueYKTD2qNgp;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace Q71Na6HC0mTaCRwcejFA;

[JsonObject(/*Could not decode attribute arguments.*/)]
internal class ef8psiHVzimMO4mM8fwu : QCMRkVHVHQDMIML9Hckc
{
	[CompilerGenerated]
	private string MSdHClu1cxj;

	[CompilerGenerated]
	private string aEKHC47OqfX;

	[CompilerGenerated]
	private int llgHCDNorH3;

	[CompilerGenerated]
	private string n7yHCbbLis3;

	private static ef8psiHVzimMO4mM8fwu VCA1HaDWogfHvqYJNVMV;

	[JsonProperty("instId")]
	public string Symbol
	{
		[CompilerGenerated]
		get
		{
			return MSdHClu1cxj;
		}
		[CompilerGenerated]
		set
		{
			MSdHClu1cxj = value;
		}
	}

	[JsonProperty("bar")]
	public string BQ8HCGbq043
	{
		[CompilerGenerated]
		get
		{
			return aEKHC47OqfX;
		}
		[CompilerGenerated]
		set
		{
			aEKHC47OqfX = value;
		}
	}

	[JsonProperty("limit")]
	public int B0AHCvr5AYN
	{
		[CompilerGenerated]
		get
		{
			return llgHCDNorH3;
		}
		[CompilerGenerated]
		set
		{
			llgHCDNorH3 = value;
		}
	}

	[JsonProperty("after")]
	public string TQKHCilohc5
	{
		[CompilerGenerated]
		get
		{
			return n7yHCbbLis3;
		}
		[CompilerGenerated]
		set
		{
			n7yHCbbLis3 = value;
		}
	}

	public ef8psiHVzimMO4mM8fwu(Symbol t6cNk1ll6GKyvabAVsS1, DataCycle cfDXD8llMfGY6bxG6TkJ)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				B0AHCvr5AYN = 300;
				BQ8HCGbq043 = PhmHC2iJCSe(cfDXD8llMfGY6bxG6TkJ);
				return;
			case 1:
				Symbol = t6cNk1ll6GKyvabAVsS1.Code;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private string PhmHC2iJCSe(DataCycle xhsMxEllONR37OgN1Ejs)
	{
		int repeat = default(int);
		int num;
		switch (xhsMxEllONR37OgN1Ejs.CycleBase)
		{
		case DataCycleBase.Week:
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1B08AC);
		case DataCycleBase.Month:
			repeat = xhsMxEllONR37OgN1Ejs.Repeat;
			num = 5;
			goto IL_0009;
		case DataCycleBase.Minute:
			repeat = xhsMxEllONR37OgN1Ejs.Repeat;
			num = 13;
			goto IL_0009;
		case DataCycleBase.Year:
			return (string)aZHy1ADWa6E2tJE7PeDK(-1878953018 ^ -1878883540);
		case DataCycleBase.Hour:
			repeat = xhsMxEllONR37OgN1Ejs.Repeat;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case DataCycleBase.Day:
			repeat = xhsMxEllONR37OgN1Ejs.Repeat;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
			{
				num = 0;
			}
			goto IL_0009;
		default:
			{
				num = 2;
				goto IL_0009;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 10:
					if (xhsMxEllONR37OgN1Ejs.Repeat % 3 != 0)
					{
						return (string)aZHy1ADWa6E2tJE7PeDK(0x20B584D2 ^ 0x20B6740E);
					}
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774565133);
				case 9:
					if (xhsMxEllONR37OgN1Ejs.Repeat % 12 == 0)
					{
						return (string)aZHy1ADWa6E2tJE7PeDK(-338769610 ^ -338871902);
					}
					if (xhsMxEllONR37OgN1Ejs.Repeat % 6 == 0)
					{
						num = 7;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
						{
							num = 3;
						}
						continue;
					}
					if (noKnYsDWib2oIEvQRMA2(xhsMxEllONR37OgN1Ejs) % 4 == 0)
					{
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1153213225);
					}
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num = 3;
					}
					continue;
				case 6:
					return (string)aZHy1ADWa6E2tJE7PeDK(0x315AB1E3 ^ 0x315941D3);
				case 4:
					if (repeat != 30)
					{
						num = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
						{
							num = 3;
						}
						continue;
					}
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DD54B3);
				case 3:
					if (noKnYsDWib2oIEvQRMA2(xhsMxEllONR37OgN1Ejs) % 2 != 0)
					{
						return (string)aZHy1ADWa6E2tJE7PeDK(0x6EC99CAF ^ 0x6EC9B609);
					}
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416975379);
				case 8:
					if (xhsMxEllONR37OgN1Ejs.Repeat % 30 == 0)
					{
						return (string)aZHy1ADWa6E2tJE7PeDK(-838841832 ^ -838616486);
					}
					if (noKnYsDWib2oIEvQRMA2(xhsMxEllONR37OgN1Ejs) % 15 == 0)
					{
						num = 11;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
						{
							num = 6;
						}
						continue;
					}
					if (xhsMxEllONR37OgN1Ejs.Repeat % 5 != 0)
					{
						if (noKnYsDWib2oIEvQRMA2(xhsMxEllONR37OgN1Ejs) % 3 != 0)
						{
							return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690727851);
						}
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529794969);
					}
					goto case 6;
				case 2:
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x46610687);
				case 5:
					switch (repeat)
					{
					case 1:
						return (string)aZHy1ADWa6E2tJE7PeDK(0x2C8374E4 ^ 0x2C808438);
					case 3:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1E2BD1);
					default:
						num = 10;
						break;
					}
					continue;
				case 13:
					switch (repeat)
					{
					case 1:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -448904976);
					case 3:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3544E813 ^ 0x3547186D);
					case 5:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x44694714);
					case 15:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-342738082 ^ -342766746);
					case 2:
					case 4:
						break;
					default:
						num = 4;
						continue;
					}
					goto case 8;
				case 1:
					switch (repeat)
					{
					case 1:
						return (string)aZHy1ADWa6E2tJE7PeDK(-1774602229 ^ -1774611795);
					case 2:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801458388);
					case 4:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x3741DB82);
					case 6:
						return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DD5477);
					case 3:
					case 5:
						break;
					default:
						num = 12;
						continue;
					}
					goto case 9;
				case 7:
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056591866);
				case 12:
					if (repeat == 12)
					{
						return (string)aZHy1ADWa6E2tJE7PeDK(-225822163 ^ -225850695);
					}
					num = 9;
					continue;
				case 11:
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602395573);
				}
				switch (repeat)
				{
				case 1:
					return (string)aZHy1ADWa6E2tJE7PeDK(0x735715F1 ^ 0x7354E555);
				case 2:
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x240BA9B2);
				case 3:
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1B08A2);
				default:
					if (xhsMxEllONR37OgN1Ejs.Repeat % 3 == 0)
					{
						return (string)aZHy1ADWa6E2tJE7PeDK(0x28C965BE ^ 0x28CA957E);
					}
					if (xhsMxEllONR37OgN1Ejs.Repeat % 2 != 0)
					{
						return (string)aZHy1ADWa6E2tJE7PeDK(0x28B345BB ^ 0x28B0B51F);
					}
					return (string)aZHy1ADWa6E2tJE7PeDK(-991861155 ^ -991783185);
				}
			}
		}
	}

	static ef8psiHVzimMO4mM8fwu()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool IBFUxqDWv7gtan2igpV5()
	{
		return VCA1HaDWogfHvqYJNVMV == null;
	}

	internal static ef8psiHVzimMO4mM8fwu igMG5TDWBr80DZTSrUZT()
	{
		return VCA1HaDWogfHvqYJNVMV;
	}

	internal static object aZHy1ADWa6E2tJE7PeDK(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static int noKnYsDWib2oIEvQRMA2(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}
}
