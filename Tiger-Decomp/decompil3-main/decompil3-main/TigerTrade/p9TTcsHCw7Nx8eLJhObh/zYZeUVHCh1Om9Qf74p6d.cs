using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TuAMtrl1Nd3XoZQQUXf0;

namespace p9TTcsHCw7Nx8eLJhObh;

internal static class zYZeUVHCh1Om9Qf74p6d
{
	private static zYZeUVHCh1Om9Qf74p6d cbFtymDWMbKdL7yC5LLp;

	public static string nYYHC7Q1Zdp(DataCycle P_0)
	{
		if (P_0 != null)
		{
			return ztTHC8B0MOa(d6WJVMDWI9CEaJsRm1gG(P_0), P_0.Repeat);
		}
		return null;
	}

	public static string ztTHC8B0MOa(DataCycleBase P_0, int P_1)
	{
		return P_0 switch
		{
			DataCycleBase.Second => string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710580930), P_1), 
			DataCycleBase.Minute => string.Format((string)jD3Ed3DWWfZHZMDJrvue(-165474503 ^ -165609901), P_1), 
			DataCycleBase.Hour => string.Format((string)jD3Ed3DWWfZHZMDJrvue(0x1EFE0A28 ^ 0x1EFDFB5E), P_1), 
			DataCycleBase.Day => string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD6C342), P_1), 
			DataCycleBase.Week => (string)VWPlFHDWtXBkmhNpACOE(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225850461), P_1), 
			_ => null, 
		};
	}

	public static bool iZ3HCAQmUav(DataCycle P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		return P_0.CycleBase <= DataCycleBase.Week;
	}

	public static bool QF7HCPSA4m3(DataCycleBase P_0)
	{
		return P_0 <= DataCycleBase.Week;
	}

	static zYZeUVHCh1Om9Qf74p6d()
	{
		Y3I9v7DWUDlKUqJDvgHb();
	}

	internal static DataCycleBase d6WJVMDWI9CEaJsRm1gG(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static bool zd29kXDWO12oRqKYnTye()
	{
		return cbFtymDWMbKdL7yC5LLp == null;
	}

	internal static zYZeUVHCh1Om9Qf74p6d gaOPlVDWqRPtTL2jMFqE()
	{
		return cbFtymDWMbKdL7yC5LLp;
	}

	internal static object jD3Ed3DWWfZHZMDJrvue(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object VWPlFHDWtXBkmhNpACOE(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void Y3I9v7DWUDlKUqJDvgHb()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
