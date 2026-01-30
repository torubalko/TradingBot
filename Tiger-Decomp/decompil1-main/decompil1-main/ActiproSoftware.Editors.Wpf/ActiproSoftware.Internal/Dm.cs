using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class Dm : C6<byte?>, ISpinnablePart<byte?>, IPart
{
	private static Dm pju;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<byte?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		byte? value = P_0.Value;
		byte b = P_0.SmallChange ?? 1;
		byte b2 = P_0.LargeChange ?? 5;
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			if (b != 0)
			{
				P_0.Value = cda.DbP(P_0.Value.Value, -b, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.Increase:
			if (b != 0)
			{
				P_0.Value = cda.DbP(P_0.Value.Value, b, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			if (b2 != 0)
			{
				P_0.Value = cda.DbP(P_0.Value.Value, -b2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			if (b2 != 0)
			{
				P_0.Value = cda.DbP(P_0.Value.Value, b2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
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
			string text = cda.bbX();
			int num = P_1.IndexOf(text.Trim(), P_2, StringComparison.OrdinalIgnoreCase);
			if (num != -1)
			{
				P_4 = num;
			}
		}
		return P_4 > P_2;
	}

	public Dm()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool DjH()
	{
		return pju == null;
	}

	internal static Dm HjU()
	{
		return pju;
	}
}
