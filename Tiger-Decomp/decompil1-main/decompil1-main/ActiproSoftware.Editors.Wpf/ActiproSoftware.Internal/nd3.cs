using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class nd3 : yU, ISpinnablePart<Vector?>, IPart
{
	internal static nd3 sh7;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<Vector?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		Vector? value = P_0.Value;
		double num = (P_0.SmallChange.HasValue ? P_0.SmallChange.Value.X : 1.0);
		double num2 = (P_0.LargeChange.HasValue ? P_0.LargeChange.Value.X : 1.0);
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			if (num != 0.0)
			{
				P_0.Value = Jdb.Mu2(P_0.Value.Value, 0.0 - num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping, P_0.RoundingDecimalPlace);
			}
			break;
		case IncrementalChangeRequestKind.Increase:
			if (num != 0.0)
			{
				P_0.Value = Jdb.Mu2(P_0.Value.Value, num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping, P_0.RoundingDecimalPlace);
			}
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			if (num2 != 0.0)
			{
				P_0.Value = Jdb.Mu2(P_0.Value.Value, 0.0 - num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping, P_0.RoundingDecimalPlace);
			}
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			if (num2 != 0.0)
			{
				P_0.Value = Jdb.Mu2(P_0.Value.Value, num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping, P_0.RoundingDecimalPlace);
			}
			break;
		}
		return value != P_0.Value;
	}

	[SpecialName]
	protected override bool Qkf()
	{
		return true;
	}

	public nd3()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool ehw()
	{
		return sh7 == null;
	}

	internal static nd3 Yho()
	{
		return sh7;
	}
}
