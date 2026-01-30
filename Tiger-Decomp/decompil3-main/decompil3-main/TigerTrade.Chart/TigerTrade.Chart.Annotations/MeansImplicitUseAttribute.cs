using System;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Annotations;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	private static MeansImplicitUseAttribute eg7cbLLJdP8HdSN6x5eC;

	[UsedImplicitly]
	public ImplicitUseKindFlags UseKindFlags { get; private set; }

	[UsedImplicitly]
	public ImplicitUseTargetFlags TargetFlags { get; private set; }

	public MeansImplicitUseAttribute()
	{
		RvC1ZWLJ60gHcxqbUGWK();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
	{
		RvC1ZWLJ60gHcxqbUGWK();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
	}

	public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
	{
		RvC1ZWLJ60gHcxqbUGWK();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
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
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void RvC1ZWLJ60gHcxqbUGWK()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static bool E93krJLJga3ekiMNXn6x()
	{
		return eg7cbLLJdP8HdSN6x5eC == null;
	}

	internal static MeansImplicitUseAttribute qGDWVxLJREcOa1TVmLYf()
	{
		return eg7cbLLJdP8HdSN6x5eC;
	}
}
