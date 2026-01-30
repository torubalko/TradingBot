using System;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.Annotations;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	private static MeansImplicitUseAttribute vTNBt0lWFD6Ipue9Hkyq;

	[UsedImplicitly]
	public ImplicitUseKindFlags UseKindFlags { get; private set; }

	[UsedImplicitly]
	public ImplicitUseTargetFlags TargetFlags { get; private set; }

	public MeansImplicitUseAttribute()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
	}

	public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
	}

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		djQ38slWuxsNfiP5RQQ3();
		base._002Ector();
		UseKindFlags = useKindFlags;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		TargetFlags = targetFlags;
	}

	static MeansImplicitUseAttribute()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool NlqvNOlW3B2Zs9rSYtm3()
	{
		return vTNBt0lWFD6Ipue9Hkyq == null;
	}

	internal static MeansImplicitUseAttribute CT1U5UlWpYQJObGY98XK()
	{
		return vTNBt0lWFD6Ipue9Hkyq;
	}

	internal static void djQ38slWuxsNfiP5RQQ3()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
