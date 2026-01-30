using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class fv : C6<string>
{
	private static fv iGZ;

	public override bool IsEditable => false;

	protected override string BkT(string P_0)
	{
		if (P_0 != null && (QdM.AR8(18772) == P_0 || QdM.AR8(25608) == P_0))
		{
			return QdM.AR8(25608);
		}
		return QdM.AR8(25616);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		P_3 = P_3 ?? CultureInfo.CurrentCulture;
		string text = DateTime.Today.ToString(base.Format, P_3);
		if (P_1.WC(text, P_2, StringComparison.OrdinalIgnoreCase))
		{
			P_4 = P_2 + text.Length;
			return true;
		}
		return false;
	}

	public fv()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool sGR()
	{
		return iGZ == null;
	}

	internal static fv VGi()
	{
		return iGZ;
	}
}
