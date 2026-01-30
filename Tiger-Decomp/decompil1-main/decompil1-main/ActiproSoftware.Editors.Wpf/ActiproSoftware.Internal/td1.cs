using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class td1 : C6<int?>, ISpinnablePart<TimeSpan?>, IPart
{
	internal static td1 xhQ;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<TimeSpan?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		TimeSpan? value = P_0.Value;
		int num = ((!P_0.SmallChange.HasValue) ? 1 : P_0.SmallChange.Value.Hours);
		int num2 = (P_0.LargeChange.HasValue ? P_0.LargeChange.Value.Hours : 3);
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			if (num != 0)
			{
				P_0.Value = xdU.Yq7(P_0.Value.Value, -num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.Increase:
			if (num != 0)
			{
				P_0.Value = xdU.Yq7(P_0.Value.Value, num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			if (num2 != 0)
			{
				P_0.Value = xdU.Yq7(P_0.Value.Value, -num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			if (num2 != 0)
			{
				P_0.Value = xdU.Yq7(P_0.Value.Value, num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		}
		return value != P_0.Value;
	}

	protected override string BkT(string P_0)
	{
		if (P_0 == null || !P_0.StartsWith(QdM.AR8(25624), StringComparison.Ordinal))
		{
			return QdM.AR8(25654);
		}
		return QdM.AR8(25624);
	}

	[SpecialName]
	public string aI1()
	{
		return (base.Format == QdM.AR8(25624)) ? QdM.AR8(25950) : QdM.AR8(1942);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		int num = 0;
		if (base.Format == QdM.AR8(25624))
		{
			num = ((P_1.yV(P_2) && P_1.yV(P_2 + 1)) ? 2 : 0);
		}
		else if (P_1.yV(P_2))
		{
			num = ((!P_1.yV(P_2 + 1)) ? 1 : 2);
		}
		if (num > 0)
		{
			P_4 = P_2 + num;
			return true;
		}
		return false;
	}

	public td1()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool QhZ()
	{
		return xhQ == null;
	}

	internal static td1 bhR()
	{
		return xhQ;
	}
}
