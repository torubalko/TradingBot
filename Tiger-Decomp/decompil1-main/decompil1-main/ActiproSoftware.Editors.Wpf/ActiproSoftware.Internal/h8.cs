using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class h8 : C6<int?>, ISpinnablePart<DateTime?>, IPart
{
	internal static h8 SG5;

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
			P_0.Value = ldZ.ObB(P_0.Value.Value, -1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.Increase:
			P_0.Value = ldZ.ObB(P_0.Value.Value, 1, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			P_0.Value = ldZ.ObB(P_0.Value.Value, -3, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			P_0.Value = ldZ.ObB(P_0.Value.Value, 3, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		}
		return value != P_0.Value;
	}

	protected override string BkT(string P_0)
	{
		if (P_0 != null)
		{
			if (P_0.StartsWith(QdM.AR8(25624), StringComparison.Ordinal))
			{
				return QdM.AR8(25624);
			}
			if (QdM.AR8(25632) == P_0 || QdM.AR8(25638) == P_0)
			{
				return QdM.AR8(25638);
			}
			if (P_0.StartsWith(QdM.AR8(25646), StringComparison.Ordinal))
			{
				return QdM.AR8(25646);
			}
		}
		return QdM.AR8(25654);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		int num = 0;
		if (base.Format == QdM.AR8(25624) || base.Format == QdM.AR8(25646))
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

	public h8()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool RGI()
	{
		return SG5 == null;
	}

	internal static h8 rG6()
	{
		return SG5;
	}
}
