using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class sdm
{
	public static readonly Brush Vb6;

	internal static sdm SSJ;

	public static string VbQ(Brush P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return null;
		}
		SolidColorBrush solidColorBrush = P_0 as SolidColorBrush;
		int num = 0;
		if (CSS() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (solidColorBrush != null)
			{
				return VdT.Hb0(solidColorBrush.Color, P_1);
			}
			if (P_0 is GradientBrush)
			{
				return SR.GetString(SRName.UIGradientBrushText);
			}
			return P_0.ToString();
		}
	}

	public static IList<IPart> CbV()
	{
		List<IPart> list = new List<IPart>();
		list.Add(new Gu());
		return new ReadOnlyCollection<IPart>(list);
	}

	public static bool WbC(string P_0, bool P_1, out Brush P_2)
	{
		P_2 = null;
		bool result;
		if (!string.IsNullOrEmpty(P_0))
		{
			if (VdT.vbI(P_0, P_1, out var color))
			{
				P_2 = new SolidColorBrush
				{
					Color = color.Value
				};
				result = true;
				int num = 0;
				if (CSS() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				result = false;
			}
		}
		else
		{
			result = true;
		}
		return result;
	}

	static sdm()
	{
		awj.QuEwGz();
		Vb6 = new SolidColorBrush
		{
			Color = Color.FromArgb(byte.MaxValue, byte.MaxValue, 0, 0)
		};
	}

	internal static bool KSh()
	{
		return SSJ == null;
	}

	internal static sdm CSS()
	{
		return SSJ;
	}
}
