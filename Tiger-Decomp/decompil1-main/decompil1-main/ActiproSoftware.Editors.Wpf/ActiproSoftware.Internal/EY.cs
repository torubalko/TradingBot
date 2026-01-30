using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class EY : C6<string>, ISpinnablePart<DateTime?>, IPart
{
	internal static EY nGA;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<DateTime?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		DateTime? value = P_0.Value;
		if (P_0.Value.Value.Hour < 12)
		{
			P_0.Value = ldZ.ObB(P_0.Value.Value, 12, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
		}
		else
		{
			P_0.Value = ldZ.ObB(P_0.Value.Value, -12, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
		}
		return value != P_0.Value;
	}

	protected override string BkT(string P_0)
	{
		if (P_0 != null && (QdM.AR8(18796) == P_0 || QdM.AR8(25554) == P_0))
		{
			return QdM.AR8(25554);
		}
		return QdM.AR8(25562);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		P_3 = P_3 ?? CultureInfo.CurrentCulture;
		string text = P_3.DateTimeFormat.AMDesignator;
		string text2 = P_3.DateTimeFormat.PMDesignator;
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
		{
			return true;
		}
		if (base.Format == QdM.AR8(25554))
		{
			text = text.Substring(0, 1);
			text2 = text2.Substring(0, 1);
		}
		if (P_1.WC(text, P_2, StringComparison.OrdinalIgnoreCase))
		{
			P_4 = P_2 + text.Length;
			return true;
		}
		if (P_1.WC(text2, P_2, StringComparison.OrdinalIgnoreCase))
		{
			P_4 = P_2 + text2.Length;
			return true;
		}
		return false;
	}

	public EY()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool HGt()
	{
		return nGA == null;
	}

	internal static EY EGe()
	{
		return nGA;
	}
}
