using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Annotations;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	internal static MeansImplicitUseAttribute GtYDHm5yjEUu7d3q20VT;

	[UsedImplicitly]
	public ImplicitUseKindFlags UseKindFlags { get; private set; }

	[UsedImplicitly]
	public ImplicitUseTargetFlags TargetFlags { get; private set; }

	public MeansImplicitUseAttribute()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
	{
		kaWEsd5ydPI7203YEAGA();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
	}

	public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
	{
		kaWEsd5ydPI7203YEAGA();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		kaWEsd5ydPI7203YEAGA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		UseKindFlags = useKindFlags;
		TargetFlags = targetFlags;
	}

	static MeansImplicitUseAttribute()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		iTof4V5ygdeswjInN3YS();
	}

	internal static bool HAtOVo5yExbuYy6DEr7s()
	{
		return GtYDHm5yjEUu7d3q20VT == null;
	}

	internal static MeansImplicitUseAttribute WZv5ys5yQNZv7mKyaCT4()
	{
		return GtYDHm5yjEUu7d3q20VT;
	}

	internal static void kaWEsd5ydPI7203YEAGA()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void iTof4V5ygdeswjInN3YS()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
