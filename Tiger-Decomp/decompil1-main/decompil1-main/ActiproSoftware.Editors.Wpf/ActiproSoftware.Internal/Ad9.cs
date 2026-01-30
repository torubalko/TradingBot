using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class Ad9 : C6<string>
{
	private static Ad9 uhp;

	public override bool IsOptional => true;

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		P_3 = P_3 ?? CultureInfo.CurrentCulture;
		string positiveSign = P_3.NumberFormat.PositiveSign;
		string negativeSign = P_3.NumberFormat.NegativeSign;
		if (!string.IsNullOrEmpty(positiveSign) && P_1.WC(positiveSign, P_2, StringComparison.OrdinalIgnoreCase))
		{
			P_4 = P_2 + positiveSign.Length;
			return true;
		}
		if (!string.IsNullOrEmpty(negativeSign) && P_1.WC(negativeSign, P_2, StringComparison.OrdinalIgnoreCase))
		{
			P_4 = P_2 + negativeSign.Length;
			return true;
		}
		return false;
	}

	public Ad9()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool nh4()
	{
		return uhp == null;
	}

	internal static Ad9 lh0()
	{
		return uhp;
	}
}
