using System.Runtime.CompilerServices;
using aWyZAjHVfueYKTD2qNgp;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace pi8CE9HCde3u8rCCHWZF;

[JsonObject(/*Could not decode attribute arguments.*/)]
internal class rE02mkHCQ3bg4nFWWDjZ : QCMRkVHVHQDMIML9Hckc
{
	[CompilerGenerated]
	private string gx0HCUCLXXe;

	[CompilerGenerated]
	private string DgCHCTVfsGq;

	[CompilerGenerated]
	private int HJ4HCyfgmy9;

	private static rE02mkHCQ3bg4nFWWDjZ A283y7DW53YMGc7LfxUp;

	[JsonProperty("symbol")]
	public string Symbol
	{
		[CompilerGenerated]
		get
		{
			return gx0HCUCLXXe;
		}
		[CompilerGenerated]
		set
		{
			gx0HCUCLXXe = value;
		}
	}

	[JsonProperty("interval")]
	public string yeRHCqMP8dh
	{
		[CompilerGenerated]
		get
		{
			return DgCHCTVfsGq;
		}
		[CompilerGenerated]
		set
		{
			DgCHCTVfsGq = value;
		}
	}

	[JsonProperty("limit")]
	public int P4bHCtMFuRa
	{
		[CompilerGenerated]
		get
		{
			return HJ4HCyfgmy9;
		}
		[CompilerGenerated]
		set
		{
			HJ4HCyfgmy9 = value;
		}
	}

	public rE02mkHCQ3bg4nFWWDjZ(Symbol b7kfAUllh5hbXubkc3LP, DataCycle gddJmsllwDv8M7iibKP9)
	{
		OFrWVpDWLuejrjVSxh4x();
		base._002Ector();
		Symbol = (string)SDrou2DWeSdQmwxoPuNL(b7kfAUllh5hbXubkc3LP);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			yeRHCqMP8dh = CPDHCgYPSW3(gddJmsllwDv8M7iibKP9);
			P4bHCtMFuRa = 1000;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
			{
				num = 1;
			}
		}
	}

	private string CPDHCgYPSW3(DataCycle W772uQll7FyKDuf9ok9x)
	{
		int num;
		int num2 = default(int);
		switch (W772uQll7FyKDuf9ok9x.CycleBase)
		{
		case DataCycleBase.Minute:
			goto IL_0090;
		case DataCycleBase.Day:
			_ = W772uQll7FyKDuf9ok9x.Repeat;
			_ = 1;
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
			{
				num = 5;
			}
			goto IL_0009;
		case DataCycleBase.Hour:
			num2 = uPnTSFDWsHNlDVq9bobb(W772uQll7FyKDuf9ok9x);
			if (num2 != 1)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			goto IL_01a1;
		default:
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case DataCycleBase.Week:
			{
				uPnTSFDWsHNlDVq9bobb(W772uQll7FyKDuf9ok9x);
				_ = 1;
				return (string)OIiGPmDWXNbRDNvG9oNe(0x68C7EAE6 ^ 0x68C41BB0);
			}
			IL_0090:
			num2 = uPnTSFDWsHNlDVq9bobb(W772uQll7FyKDuf9ok9x);
			if (num2 <= 5)
			{
				if (num2 == 1)
				{
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602395557);
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num = 4;
				}
			}
			else
			{
				if (num2 == 15)
				{
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047103561);
				}
				num = 2;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 7:
					break;
				case 8:
					goto IL_0090;
				case 4:
					goto IL_0159;
				case 6:
					goto IL_01a1;
				case 3:
					goto IL_01c4;
				case 5:
					return (string)OIiGPmDWXNbRDNvG9oNe(-198991962 ^ -199200830);
				case 2:
					if (num2 == 30)
					{
						return (string)OIiGPmDWXNbRDNvG9oNe(-1380525184 ^ -1380635710);
					}
					break;
				default:
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522707661);
				case 1:
					goto IL_02d9;
				}
				break;
				IL_02d9:
				if (num2 == 4)
				{
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x11A5C43);
				}
				num = 3;
				continue;
				IL_0159:
				if (num2 == 5)
				{
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D2F43B);
				}
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num = 7;
				}
			}
			if (W772uQll7FyKDuf9ok9x.Repeat % 30 == 0)
			{
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29805416);
			}
			if (W772uQll7FyKDuf9ok9x.Repeat % 15 == 0)
			{
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325304437);
			}
			if (W772uQll7FyKDuf9ok9x.Repeat % 5 != 0)
			{
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522628267);
			}
			return (string)OIiGPmDWXNbRDNvG9oNe(0x24B0B9E6 ^ 0x24B349D6);
			IL_01a1:
			return (string)OIiGPmDWXNbRDNvG9oNe(0x6D18F862 ^ 0x6D1B092E);
			IL_01c4:
			if (W772uQll7FyKDuf9ok9x.Repeat % 4 != 0)
			{
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176578833);
			}
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -616847239);
		}
	}

	static rE02mkHCQ3bg4nFWWDjZ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool rLMRicDWSjBI9UmtZVhh()
	{
		return A283y7DW53YMGc7LfxUp == null;
	}

	internal static rE02mkHCQ3bg4nFWWDjZ g6vyRiDWxfpMtOFckD1B()
	{
		return A283y7DW53YMGc7LfxUp;
	}

	internal static void OFrWVpDWLuejrjVSxh4x()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object SDrou2DWeSdQmwxoPuNL(object P_0)
	{
		return ((Symbol)P_0).Code;
	}

	internal static int uPnTSFDWsHNlDVq9bobb(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static object OIiGPmDWXNbRDNvG9oNe(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
