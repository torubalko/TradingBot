using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class KK : C6<string>
{
	private static KK bG4;

	public override bool IsEditable => false;

	protected override string BkT(string P_0)
	{
		return QdM.AR8(25896);
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		if (P_1.WC(QdM.AR8(2098), P_2, StringComparison.Ordinal) || P_1.WC(QdM.AR8(25904), P_2, StringComparison.Ordinal))
		{
			int num = 1;
			if (P_1.yV(P_2 + num))
			{
				num++;
				if (P_1.yV(P_2 + num))
				{
					num++;
					if (P_1.yV(P_2 + num))
					{
						num++;
						if (P_1.yV(P_2 + num))
						{
							num++;
							P_4 = P_2 + num;
							return true;
						}
						P_4 = P_2 + num;
						return true;
					}
					if (!P_1.WC(QdM.AR8(19056), P_2 + num, StringComparison.Ordinal))
					{
						P_4 = P_2 + num;
						return true;
					}
					num++;
					if (P_1.yV(P_2 + num))
					{
						num++;
						if (P_1.yV(P_2 + num))
						{
							num++;
							P_4 = P_2 + num;
							return true;
						}
						P_4 = P_2 + num;
						return true;
					}
				}
				else
				{
					if (!P_1.WC(QdM.AR8(19056), P_2 + num, StringComparison.Ordinal))
					{
						P_4 = P_2 + num;
						return true;
					}
					num++;
					if (P_1.yV(P_2 + num))
					{
						num++;
						if (P_1.yV(P_2 + num))
						{
							num++;
							P_4 = P_2 + num;
							return true;
						}
						P_4 = P_2 + num;
						return true;
					}
				}
			}
			return false;
		}
		if (P_1.WC(QdM.AR8(23494), P_2, StringComparison.Ordinal))
		{
			P_4 = P_2 + 1;
			return true;
		}
		return true;
	}

	public KK()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool MG0()
	{
		return bG4 == null;
	}

	internal static KK aG7()
	{
		return bG4;
	}
}
