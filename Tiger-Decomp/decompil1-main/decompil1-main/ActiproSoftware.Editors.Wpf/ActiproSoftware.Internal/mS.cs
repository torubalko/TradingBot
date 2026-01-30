using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class mS : C6<int?>, ISpinnablePart<DateTime?>, IPart
{
	private static mS RGE;

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
			P_0.Value = ldZ.hbN(P_0.Value.Value, -1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.Increase:
			P_0.Value = ldZ.hbN(P_0.Value.Value, 1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			P_0.Value = ldZ.hbN(P_0.Value.Value, -3, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			P_0.Value = ldZ.hbN(P_0.Value.Value, 3, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		}
		return value != P_0.Value;
	}

	protected override string BkT(string P_0)
	{
		string result;
		if (P_0 != null)
		{
			if (!(QdM.AR8(10070) == P_0))
			{
				if (!(QdM.AR8(25850) == P_0))
				{
					if (!(QdM.AR8(25860) == P_0))
					{
						goto IL_00f8;
					}
					result = QdM.AR8(25860);
				}
				else
				{
					result = QdM.AR8(25850);
				}
			}
			else
			{
				result = QdM.AR8(10070);
			}
			goto IL_0023;
		}
		goto IL_00f8;
		IL_00f8:
		result = QdM.AR8(25872);
		int num = 0;
		if (!PG3())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		goto IL_0023;
		IL_0023:
		return result;
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		P_3 = P_3 ?? CultureInfo.CurrentCulture;
		int num = 0;
		if (base.Format == QdM.AR8(10070))
		{
			num = ((P_1.yV(P_2) && P_1.yV(P_2 + 1)) ? 2 : 0);
		}
		else if (base.Format == QdM.AR8(25872) && P_1.yV(P_2))
		{
			num = ((!P_1.yV(P_2 + 1)) ? 1 : 2);
		}
		if (num > 0)
		{
			P_4 = P_2 + num;
			return true;
		}
		string[] array = ((base.Format == QdM.AR8(25860)) ? P_3.DateTimeFormat.MonthNames : P_3.DateTimeFormat.AbbreviatedMonthNames);
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

	public mS()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool PG3()
	{
		return RGE == null;
	}

	internal static mS RGb()
	{
		return RGE;
	}
}
