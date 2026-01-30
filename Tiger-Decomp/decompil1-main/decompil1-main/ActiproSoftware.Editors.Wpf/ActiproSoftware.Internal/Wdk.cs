using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class Wdk : C6<int?>, ISpinnablePart<TimeSpan?>, IPart
{
	private static Wdk BhP;

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public string AIS => QdM.AR8(1942);

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
		int num = ((!P_0.SmallChange.HasValue) ? 1 : P_0.SmallChange.Value.Days);
		int num2 = (P_0.LargeChange.HasValue ? P_0.LargeChange.Value.Days : 7);
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			if (num != 0)
			{
				P_0.Value = xdU.PqE(P_0.Value.Value, -num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.Increase:
			if (num != 0)
			{
				P_0.Value = xdU.PqE(P_0.Value.Value, num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			if (num2 != 0)
			{
				P_0.Value = xdU.PqE(P_0.Value.Value, -num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			if (num2 != 0)
			{
				P_0.Value = xdU.PqE(P_0.Value.Value, num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		}
		return value != P_0.Value;
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		if (P_1 != null)
		{
			P_4 = P_2;
			while (P_4 < P_1.Length && P_1.yV(P_4))
			{
				P_4++;
			}
			if (P_4 > P_2 && P_0 != null)
			{
				int num = P_0.IndexOf(this);
				if (num + 1 < P_0.Count && P_0[num + 1] is ME { IsLiteral: not false, Text: var value } mE && !string.IsNullOrEmpty(value) && P_1.WC(mE.Text, P_4, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
		}
		P_4 = P_2;
		return false;
	}

	public Wdk()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool xh8()
	{
		return BhP == null;
	}

	internal static Wdk oh1()
	{
		return BhP;
	}
}
