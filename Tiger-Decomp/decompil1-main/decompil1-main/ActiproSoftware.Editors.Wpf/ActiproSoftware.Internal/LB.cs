using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class LB : C6<int?>, ISpinnablePart<Color?>, IPart
{
	internal static LB ljL;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<Color?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		Color? value = P_0.Value;
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			P_0.Value = VdT.EbO(P_0.Value.Value, -1, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.Increase:
			P_0.Value = VdT.EbO(P_0.Value.Value, 1, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			P_0.Value = VdT.EbO(P_0.Value.Value, -16, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			P_0.Value = VdT.EbO(P_0.Value.Value, 16, P_0.SpinWrapping);
			break;
		}
		return value != P_0.Value;
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = Math.Min(P_1.Length, P_2 + 2);
		return true;
	}

	public LB()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool vjq()
	{
		return ljL == null;
	}

	internal static LB Xjn()
	{
		return ljL;
	}
}
