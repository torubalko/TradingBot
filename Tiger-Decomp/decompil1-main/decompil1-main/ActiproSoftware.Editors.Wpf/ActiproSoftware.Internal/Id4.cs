using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class Id4 : C6<int?>, ISpinnablePart<TimeSpan?>, IPart
{
	internal static Id4 Whi;

	public bool ApplyIncrementalChange(IncrementalChangeRequest<TimeSpan?> P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(QdM.AR8(25536));
		}
		if (!P_0.Value.HasValue)
		{
			return false;
		}
		TimeSpan? value = P_0.Value;
		int num = ((!P_0.SmallChange.HasValue) ? 1 : P_0.SmallChange.Value.Milliseconds);
		int num2 = (P_0.LargeChange.HasValue ? P_0.LargeChange.Value.Milliseconds : 50);
		switch (P_0.Kind)
		{
		case IncrementalChangeRequestKind.Decrease:
			if (num != 0)
			{
				P_0.Value = xdU.cq4(P_0.Value.Value, -num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.Increase:
			if (num != 0)
			{
				P_0.Value = xdU.cq4(P_0.Value.Value, num, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleDecrease:
			if (num2 != 0)
			{
				P_0.Value = xdU.cq4(P_0.Value.Value, -num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		case IncrementalChangeRequestKind.MultipleIncrease:
			if (num2 != 0)
			{
				P_0.Value = xdU.cq4(P_0.Value.Value, num2, P_0.Minimum, P_0.Maximum, P_0.SpinWrapping);
			}
			break;
		}
		return value != P_0.Value;
	}

	[SpecialName]
	public bool RIr()
	{
		return !string.IsNullOrEmpty(base.Format) && char.IsUpper(base.Format[0]);
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
			goto IL_02d0;
		case 246284181u:
			if (!(P_0 == QdM.AR8(25680)))
			{
				break;
			}
			goto IL_02d0;
		case 250211209u:
			if (!(P_0 == QdM.AR8(25692)))
			{
				break;
			}
			goto IL_02d0;
		case 1765697853u:
			if (!(P_0 == QdM.AR8(25706)))
			{
				break;
			}
			goto IL_02d0;
		case 138402369u:
			if (!(P_0 == QdM.AR8(25722)))
			{
				break;
			}
			goto IL_02d0;
		case 3272340793u:
			if (!(P_0 == QdM.AR8(18784)))
			{
				break;
			}
			goto IL_02e1;
		case 1505357586u:
			if (P_0 == QdM.AR8(25740))
			{
				goto IL_02e1;
			}
			break;
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
			goto IL_0303;
		case 1285527637u:
			if (!(P_0 == QdM.AR8(25766)))
			{
				break;
			}
			goto IL_0303;
		case 2990302697u:
			if (!(P_0 == QdM.AR8(25778)))
			{
				break;
			}
			goto IL_0303;
		case 1142166141u:
			if (!(P_0 == QdM.AR8(25792)))
			{
				break;
			}
			goto IL_0303;
		case 1721283297u:
			{
				if (!(P_0 == QdM.AR8(25808)))
				{
					break;
				}
				goto IL_0303;
			}
			IL_0303:
			return QdM.AR8(25756);
			IL_02e1:
			return QdM.AR8(25740);
			IL_02d0:
			return QdM.AR8(25670);
		}
		return QdM.AR8(25826);
	}

	[SpecialName]
	public string bIp()
	{
		if (!string.IsNullOrEmpty(base.Format))
		{
			if (!base.Format.StartsWith(QdM.AR8(25958), StringComparison.Ordinal))
			{
				return QdM.AR8(1942) + Math.Max(1, Math.Min(3, base.Format.Length));
			}
			return QdM.AR8(25964);
		}
		return QdM.AR8(25972);
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

	public Id4()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool eh5()
	{
		return Whi == null;
	}

	internal static Id4 HhI()
	{
		return Whi;
	}
}
