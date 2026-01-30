using System;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Annotations;

[AttributeUsage(AttributeTargets.All)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	internal static UsedImplicitlyAttribute esMYTeLJcZDcmflj5F4U;

	public ImplicitUseKindFlags UseKindFlags { get; private set; }

	public ImplicitUseTargetFlags TargetFlags { get; private set; }

	public UsedImplicitlyAttribute()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
	}

	public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		UseKindFlags = useKindFlags;
		TargetFlags = targetFlags;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UsedImplicitlyAttribute()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		LAHDFfLJQ67nLNyiqbfS();
	}

	internal static bool vMju2tLJj2P25deNjp4u()
	{
		return esMYTeLJcZDcmflj5F4U == null;
	}

	internal static UsedImplicitlyAttribute z3KqHnLJEUsgmYZ9LchU()
	{
		return esMYTeLJcZDcmflj5F4U;
	}

	internal static void LAHDFfLJQ67nLNyiqbfS()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
