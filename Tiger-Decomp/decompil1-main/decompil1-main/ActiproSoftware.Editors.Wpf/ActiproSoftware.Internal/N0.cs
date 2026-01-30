using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class N0 : C6<DayOfWeek?>, ISpinnablePart<DateTime?>, IPart
{
	internal static N0 dGO;

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
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			P_0.Value = ldZ.Qb4(P_0.Value.Value, -1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.Increase:
			P_0.Value = ldZ.Qb4(P_0.Value.Value, 1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			P_0.Value = ldZ.Qb4(P_0.Value.Value, -7, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			P_0.Value = ldZ.Qb4(P_0.Value.Value, 7, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		}
		return value != P_0.Value;
	}

	protected override string BkT(string P_0)
	{
		if (P_0 != null && P_0.StartsWith(QdM.AR8(25570), StringComparison.Ordinal))
		{
			return QdM.AR8(25570);
		}
		return QdM.AR8(25582);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		P_3 = P_3 ?? CultureInfo.CurrentCulture;
		string[] array = ((base.Format == QdM.AR8(25570)) ? P_3.DateTimeFormat.DayNames : P_3.DateTimeFormat.AbbreviatedDayNames);
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (P_1.WC(text, P_2, StringComparison.OrdinalIgnoreCase))
			{
				P_4 = P_2 + text.Length;
				return true;
			}
		}
		return false;
	}

	public N0()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool HGm()
	{
		return dGO == null;
	}

	internal static N0 JGP()
	{
		return dGO;
	}
}
