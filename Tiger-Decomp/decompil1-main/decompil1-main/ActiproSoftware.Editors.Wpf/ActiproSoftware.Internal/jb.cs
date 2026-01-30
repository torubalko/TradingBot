using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class jb : hC<object>, ISpinnablePart<object>, IPart
{
	private static jb cGM;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<object> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (P_0.Value == null)
		{
			return false;
		}
		object value = P_0.Value;
		if (value != null)
		{
			switch (P_0.Kind)
			{
			case IncrementalChangeRequestKind.Decrease:
			case IncrementalChangeRequestKind.MultipleDecrease:
				if (value.Equals(P_0.Minimum) && P_0.SpinWrapping != SpinWrapping.NoWrap && P_0.Maximum != null)
				{
					P_0.Value = P_0.Maximum;
				}
				else if (P_0.Minimum != null)
				{
					P_0.Value = P_0.Minimum;
				}
				break;
			case IncrementalChangeRequestKind.Increase:
			case IncrementalChangeRequestKind.MultipleIncrease:
				if (value.Equals(P_0.Maximum) && P_0.SpinWrapping != SpinWrapping.NoWrap && P_0.Minimum != null)
				{
					P_0.Value = P_0.Minimum;
				}
				else if (P_0.Maximum != null)
				{
					P_0.Value = P_0.Maximum;
				}
				break;
			}
		}
		return value != P_0.Value;
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_1.Length;
		return P_4 > P_2;
	}

	public jb()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool uGT()
	{
		return cGM == null;
	}

	internal static jb XGk()
	{
		return cGM;
	}
}
