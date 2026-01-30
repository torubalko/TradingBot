using System;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Grids;

namespace ActiproSoftware.Internal;

internal class EN
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public TreeListBoxItemAdapter EmQ;

		public EN cmy;

		private static _003C_003Ec__DisplayClass8_0 qX6;

		public _003C_003Ec__DisplayClass8_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal bool hmk(oT n)
		{
			string searchText = EmQ.GetSearchText(cmy.sEZ, n.sNm());
			if (!string.IsNullOrEmpty(searchText))
			{
				return searchText.StartsWith(cmy.DEH, StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		internal static bool lXF()
		{
			return qX6 == null;
		}

		internal static _003C_003Ec__DisplayClass8_0 BXs()
		{
			return qX6;
		}
	}

	private DateTime MEh;

	private TreeListBox sEZ;

	private string DEH;

	private TimeSpan JED;

	private static EN Usm;

	public EN(TreeListBox P_0)
	{
		fc.taYSkz();
		MEh = DateTime.Now;
		DEH = string.Empty;
		JED = TimeSpan.FromSeconds(1.0);
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(9926));
		}
		sEZ = P_0;
	}

	[SpecialName]
	public bool kEi()
	{
		return DateTime.Now.Subtract(MEh) <= JED;
	}

	public void bEx()
	{
		if (kEi())
		{
			if (DEH.Length > 0)
			{
				DEH = DEH.Substring(0, DEH.Length - 1);
			}
			MEh = DateTime.Now;
		}
	}

	public void zEa(string P_0)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals6.cmy = this;
		CS_0024_003C_003E8__locals6.EmQ = sEZ.ItemAdapter;
		if (CS_0024_003C_003E8__locals6.EmQ == null)
		{
			return;
		}
		oT oT2 = sEZ.w1F();
		if (oT2 == null)
		{
			return;
		}
		if (!kEi())
		{
			DEH = string.Empty;
		}
		bool flag = DEH.EndsWith(P_0, StringComparison.OrdinalIgnoreCase);
		DEH += P_0;
		Func<oT, bool> func = delegate(oT n)
		{
			string searchText = CS_0024_003C_003E8__locals6.EmQ.GetSearchText(CS_0024_003C_003E8__locals6.cmy.sEZ, n.sNm());
			return !string.IsNullOrEmpty(searchText) && searchText.StartsWith(CS_0024_003C_003E8__locals6.cmy.DEH, StringComparison.OrdinalIgnoreCase);
		};
		yo yo2;
		int num;
		if (!func(oT2))
		{
			yo2 = new yo(oT2);
			yo2.YlW(func);
			if (yo2.Nln() == oT2)
			{
				DEH = DEH.Substring(0, DEH.Length - P_0.Length);
				if (flag && !string.IsNullOrEmpty(DEH))
				{
					num = 1;
					if (!jsi())
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
			}
			goto IL_0027;
		}
		goto IL_0177;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0177;
		}
		yo2.YlW(func);
		goto IL_0027;
		IL_0027:
		sEZ.s1G(yo2.Nln());
		num = 0;
		if (OsA() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0177:
		MEh = DateTime.Now;
	}

	internal static bool jsi()
	{
		return Usm == null;
	}

	internal static EN OsA()
	{
		return Usm;
	}
}
