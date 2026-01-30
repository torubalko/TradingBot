using System;
using System.Collections.Generic;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

public class EnumValueNameSortComparer : IComparer<Enum>
{
	private static readonly EnumValueNameSortComparer BOF;

	internal static EnumValueNameSortComparer vjP;

	public static EnumValueNameSortComparer Instance => BOF;

	public int Compare(Enum x, Enum y)
	{
		if (x != null && y != null)
		{
			string name = Enum.GetName(x.GetType(), x);
			string name2 = Enum.GetName(y.GetType(), y);
			return string.Compare(name, name2, StringComparison.OrdinalIgnoreCase);
		}
		return 0;
	}

	public EnumValueNameSortComparer()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	static EnumValueNameSortComparer()
	{
		awj.QuEwGz();
		BOF = new EnumValueNameSortComparer();
	}

	internal static bool Rj8()
	{
		return vjP == null;
	}

	internal static EnumValueNameSortComparer Vj1()
	{
		return vjP;
	}
}
