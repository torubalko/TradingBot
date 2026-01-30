using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class bq : C6<int?>, ISpinnablePart<int?>, IPart
{
	private static bq DJh;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<int?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		int? value = P_0.Value;
		int num = P_0.SmallChange ?? 1;
		int num2 = P_0.LargeChange ?? 5;
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			if (num != 0)
			{
				P_0.Value = cdY.YD7(P_0.Value.Value, -num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.Increase:
			if (num != 0)
			{
				P_0.Value = cdY.YD7(P_0.Value.Value, num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			if (num2 != 0)
			{
				P_0.Value = cdY.YD7(P_0.Value.Value, -num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			if (num2 != 0)
			{
				P_0.Value = cdY.YD7(P_0.Value.Value, num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		}
		return value != P_0.Value;
	}

	[SpecialName]
	protected virtual bool Qkf()
	{
		return false;
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_1?.Length ?? 0;
		if (Qkf() && P_1 != null)
		{
			string text = cdY.zDN();
			int num = P_1.IndexOf(text.Trim(), P_2, StringComparison.OrdinalIgnoreCase);
			if (num != -1)
			{
				P_4 = num;
			}
		}
		return P_4 > P_2;
	}

	public bq()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool PJS()
	{
		return DJh == null;
	}

	internal static bq JJA()
	{
		return DJh;
	}
}
