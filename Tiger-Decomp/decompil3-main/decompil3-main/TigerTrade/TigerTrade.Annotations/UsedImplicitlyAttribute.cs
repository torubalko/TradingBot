using System;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.Annotations;

[AttributeUsage(AttributeTargets.All)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	private static UsedImplicitlyAttribute rRaAoClW7cQibNhsn4i3;

	public ImplicitUseKindFlags UseKindFlags { get; private set; }

	public ImplicitUseTargetFlags TargetFlags { get; private set; }

	public UsedImplicitlyAttribute()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		this._002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
	{
		oAw9S8lWPKY9teUpSTQL();
		this._002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
	}

	public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		this._002Ector(ImplicitUseKindFlags.Default, targetFlags);
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		UseKindFlags = useKindFlags;
		TargetFlags = targetFlags;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
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
		llIldklWJJWA7sF3C41E();
	}

	internal static bool zn44XwlW8bYiv0ondFka()
	{
		return rRaAoClW7cQibNhsn4i3 == null;
	}

	internal static UsedImplicitlyAttribute iWv4n5lWAapokQ4rQRdI()
	{
		return rRaAoClW7cQibNhsn4i3;
	}

	internal static void oAw9S8lWPKY9teUpSTQL()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void llIldklWJJWA7sF3C41E()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
