using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class R5 : bq, ISpinnablePart<Int32Rect?>, IPart
{
	private static R5 mJ1;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<Int32Rect?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		Int32Rect? value = P_0.Value;
		int num = ((!P_0.SmallChange.HasValue) ? 1 : P_0.SmallChange.Value.X);
		int num2 = ((!P_0.LargeChange.HasValue) ? 1 : P_0.LargeChange.Value.X);
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			if (num != 0)
			{
				P_0.Value = Vd0.jG6(P_0.Value.Value, -num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.Increase:
			if (num != 0)
			{
				P_0.Value = Vd0.jG6(P_0.Value.Value, num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			if (num2 != 0)
			{
				P_0.Value = Vd0.jG6(P_0.Value.Value, -num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			if (num2 != 0)
			{
				P_0.Value = Vd0.jG6(P_0.Value.Value, num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
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

	public R5()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool FJQ()
	{
		return mJ1 == null;
	}

	internal static R5 tJZ()
	{
		return mJ1;
	}
}
