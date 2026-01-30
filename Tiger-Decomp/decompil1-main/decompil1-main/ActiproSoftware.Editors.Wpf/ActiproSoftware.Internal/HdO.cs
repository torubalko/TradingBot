using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class HdO : Wdk
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string hR0;

		internal static _003C_003Ec__DisplayClass2_0 Hea;

		public _003C_003Ec__DisplayClass2_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal bool PRX(IPart p)
		{
			return p is ME mE && mE.Text == hR0;
		}

		internal bool KRx(char c)
		{
			return c == hR0[0];
		}

		internal static bool wej()
		{
			return Hea == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 QeG()
		{
			return Hea;
		}
	}

	internal static HdO fhy;

	public override bool IsOptional => true;

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		bool result = base.TryParseText(P_0, P_1, P_2, P_3, out P_4);
		if (P_0 != null)
		{
			int num = P_0.IndexOf(this);
			if (num != -1 && num + 1 < P_0.Count && P_0[num + 1] is ME { IsLiteral: not false } mE)
			{
				_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass2_0();
				CS_0024_003C_003E8__locals5.hR0 = mE.Text;
				if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals5.hR0) && CS_0024_003C_003E8__locals5.hR0.Length == 1)
				{
					int num2 = P_0.Count((IPart part) => part is ME mE2 && mE2.Text == CS_0024_003C_003E8__locals5.hR0);
					int num3 = P_1.Count((char c) => c == CS_0024_003C_003E8__locals5.hR0[0]);
					if (num3 < num2)
					{
						P_4 = P_2;
						return false;
					}
				}
			}
		}
		return result;
	}

	public HdO()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool FhX()
	{
		return fhy == null;
	}

	internal static HdO OhK()
	{
		return fhy;
	}
}
