using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class tD : C6<int?>, ISpinnablePart<DateTime?>, IPart
{
	private static tD MGw;

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
			P_0.Value = ldZ.ebz(P_0.Value.Value, -1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.Increase:
			P_0.Value = ldZ.ebz(P_0.Value.Value, 1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			P_0.Value = ldZ.ebz(P_0.Value.Value, -3, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			P_0.Value = ldZ.ebz(P_0.Value.Value, 3, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		}
		return value != P_0.Value;
	}

	protected override string BkT(string P_0)
	{
		if (P_0 != null)
		{
			if (QdM.AR8(18838) == P_0 || QdM.AR8(25910) == P_0)
			{
				return QdM.AR8(25910);
			}
			if (QdM.AR8(25918) == P_0)
			{
				return QdM.AR8(25918);
			}
			if (QdM.AR8(25926) == P_0)
			{
				return QdM.AR8(25926);
			}
			if (P_0.StartsWith(QdM.AR8(25936), StringComparison.Ordinal))
			{
				return QdM.AR8(25936);
			}
		}
		return QdM.AR8(20244);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		int num = 0;
		string text = base.Format;
		string text2 = text;
		if (!(text2 == QdM.AR8(25936)))
		{
			if (!(text2 == QdM.AR8(20244)))
			{
				if (!(text2 == QdM.AR8(25926)))
				{
					if (text2 == QdM.AR8(25918))
					{
						num = ((P_1.yV(P_2) && P_1.yV(P_2 + 1)) ? 2 : 0);
					}
					else if (P_1.yV(P_2))
					{
						num = ((!P_1.yV(P_2 + 1)) ? 1 : 2);
					}
				}
				else
				{
					num = ((P_1.yV(P_2) && P_1.yV(P_2 + 1) && P_1.yV(P_2 + 2)) ? (P_1.yV(P_2 + 3) ? 4 : 3) : 0);
				}
			}
			else
			{
				num = ((P_1.yV(P_2) && P_1.yV(P_2 + 1) && P_1.yV(P_2 + 2) && P_1.yV(P_2 + 3)) ? 4 : 0);
			}
		}
		else
		{
			num = ((P_1.yV(P_2) && P_1.yV(P_2 + 1) && P_1.yV(P_2 + 2) && P_1.yV(P_2 + 3) && P_1.yV(P_2 + 4)) ? 5 : 0);
		}
		if (num > 0)
		{
			P_4 = P_2 + num;
			return true;
		}
		return false;
	}

	public tD()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool NGo()
	{
		return MGw == null;
	}

	internal static tD cG2()
	{
		return MGw;
	}
}
