using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class Ke : C6<Guid?>, ISpinnablePart<Guid?>, IPart
{
	internal static Ke kGq;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<Guid?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		P_0.Value = Ody.oDy();
		return true;
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_1.Length;
		return P_4 > P_2;
	}

	public Ke()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool FGn()
	{
		return kGq == null;
	}

	internal static Ke DGg()
	{
		return kGq;
	}
}
