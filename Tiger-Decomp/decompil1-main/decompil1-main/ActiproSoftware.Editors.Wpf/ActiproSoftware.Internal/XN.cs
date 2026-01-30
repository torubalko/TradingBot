using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class XN : C6<int?>, ISpinnablePart<DateTime?>, IPart
{
	internal static XN zGc;

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
		int num = ((!P_0.SmallChange.HasValue) ? 1 : P_0.SmallChange.Value.Millisecond);
		int num2 = (P_0.LargeChange.HasValue ? P_0.LargeChange.Value.Millisecond : 50);
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			P_0.Value = ldZ.Ubh(P_0.Value.Value, -num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.Increase:
			P_0.Value = ldZ.Ubh(P_0.Value.Value, num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			P_0.Value = ldZ.Ubh(P_0.Value.Value, -num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			P_0.Value = ldZ.Ubh(P_0.Value.Value, num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			break;
		}
		return value != P_0.Value;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override string BkT(string P_0)
	{
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0))
		{
		case 1797453421u:
			if (!(P_0 == QdM.AR8(25662)))
			{
				break;
			}
			return QdM.AR8(25662);
		case 3003732817u:
			if (!(P_0 == QdM.AR8(25670)))
			{
				break;
			}
			goto IL_02c6;
		case 246284181u:
			if (!(P_0 == QdM.AR8(25680)))
			{
				break;
			}
			goto IL_02c6;
		case 250211209u:
			if (!(P_0 == QdM.AR8(25692)))
			{
				break;
			}
			goto IL_02c6;
		case 1765697853u:
			if (!(P_0 == QdM.AR8(25706)))
			{
				break;
			}
			goto IL_02c6;
		case 138402369u:
			if (!(P_0 == QdM.AR8(25722)))
			{
				break;
			}
			goto IL_02c6;
		case 3272340793u:
			if (!(P_0 == QdM.AR8(18784)))
			{
				break;
			}
			goto IL_02d7;
		case 1505357586u:
			if (!(P_0 == QdM.AR8(25740)))
			{
				break;
			}
			goto IL_02d7;
		case 2329114349u:
			if (!(P_0 == QdM.AR8(25748)))
			{
				break;
			}
			return QdM.AR8(25748);
		case 904122161u:
			if (!(P_0 == QdM.AR8(25756)))
			{
				break;
			}
			goto IL_02f9;
		case 1285527637u:
			if (!(P_0 == QdM.AR8(25766)))
			{
				break;
			}
			goto IL_02f9;
		case 2990302697u:
			if (!(P_0 == QdM.AR8(25778)))
			{
				break;
			}
			goto IL_02f9;
		case 1142166141u:
			if (!(P_0 == QdM.AR8(25792)))
			{
				break;
			}
			goto IL_02f9;
		case 1721283297u:
			{
				if (!(P_0 == QdM.AR8(25808)))
				{
					break;
				}
				goto IL_02f9;
			}
			IL_02f9:
			return QdM.AR8(25756);
			IL_02d7:
			return QdM.AR8(25740);
			IL_02c6:
			return QdM.AR8(25670);
		}
		return QdM.AR8(25826);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		int num = 0;
		int num2 = 0;
		string text = base.Format;
		string text2 = text;
		if (!(text2 == QdM.AR8(25826)))
		{
			if (!(text2 == QdM.AR8(25662)) && !(text2 == QdM.AR8(25670)))
			{
				if (!(text2 == QdM.AR8(25740)))
				{
					if (text2 == QdM.AR8(25748) || text2 == QdM.AR8(25756))
					{
						num = 0;
						num2 = base.Format.Length;
					}
				}
				else
				{
					num = 0;
					num2 = 1;
				}
			}
			else
			{
				num = base.Format.Length;
				num2 = num;
			}
		}
		else
		{
			num = 1;
			num2 = num;
		}
		if (num2 > 0)
		{
			int num3 = 0;
			while (P_1.yV(P_2 + num3))
			{
				num3++;
				if (num3 > num2)
				{
					break;
				}
			}
			if (num3 >= num)
			{
				P_4 = P_2 + num3;
				return true;
			}
		}
		return false;
	}

	public XN()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool dGD()
	{
		return zGc == null;
	}

	internal static XN vGy()
	{
		return zGc;
	}
}
