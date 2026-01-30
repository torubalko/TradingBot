using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Annotations;

[AttributeUsage(AttributeTargets.All)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	private static UsedImplicitlyAttribute RdeRr65yLFgaEQypQRew;

	public ImplicitUseKindFlags UseKindFlags { get; private set; }

	public ImplicitUseTargetFlags TargetFlags { get; private set; }

	public UsedImplicitlyAttribute()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
	}

	public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
	{
		tlZmFl5yXHtk2830W2c9();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		UseKindFlags = useKindFlags;
		TargetFlags = targetFlags;
	}

	static UsedImplicitlyAttribute()
	{
		nGn3w05yc2ZYdb1ZO5ku();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool U3lCYr5yeEBghKypA3KI()
	{
		return RdeRr65yLFgaEQypQRew == null;
	}

	internal static UsedImplicitlyAttribute SuuCiJ5ysig02LgO4MV3()
	{
		return RdeRr65yLFgaEQypQRew;
	}

	internal static void tlZmFl5yXHtk2830W2c9()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void nGn3w05yc2ZYdb1ZO5ku()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
