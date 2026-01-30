using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal static class VdT
{
	public static readonly Color abb;

	internal static VdT KSO;

	public static string Hb0(Color? P_0, bool P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		return UIColor.FromColor(P_0.Value).ToWebColor(P_1);
	}

	[SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "ActiproSoftware.Windows.Controls.Editors.Primitives.LiteralPart.set_Text(System.String)")]
	public static IList<IPart> qbY(bool P_0)
	{
		List<IPart> list = new List<IPart>();
		list.Add(new ME
		{
			Text = QdM.AR8(26570)
		});
		if (P_0)
		{
			list.Add(new Wa());
		}
		list.Add(new lZ());
		list.Add(new LB());
		list.Add(new LT());
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Color cbg(Color P_0, int P_1, SpinWrapping P_2)
	{
		byte b = 0;
		byte b2 = byte.MaxValue;
		try
		{
			byte a4 = (byte)cdY.YD7(P_0.A, P_1, b, b2, P_2);
			P_0 = Color.FromArgb(a4, P_0.R, P_0.G, P_0.B);
		}
		catch (OverflowException)
		{
			P_0 = Color.FromArgb((P_1 > 0) ? b2 : b, P_0.R, P_0.G, P_0.B);
		}
		return P_0;
	}

	public static Color gbo(Color P_0, int P_1, SpinWrapping P_2)
	{
		byte b = 0;
		byte b2 = byte.MaxValue;
		try
		{
			byte b3 = (byte)cdY.YD7(P_0.B, P_1, b, b2, P_2);
			P_0 = Color.FromArgb(P_0.A, P_0.R, P_0.G, b3);
		}
		catch (OverflowException)
		{
			P_0 = Color.FromArgb(P_0.A, P_0.R, P_0.G, (P_1 > 0) ? b2 : b);
		}
		return P_0;
	}

	public static Color EbO(Color P_0, int P_1, SpinWrapping P_2)
	{
		byte b = 0;
		byte b2 = byte.MaxValue;
		try
		{
			byte g = (byte)cdY.YD7(P_0.G, P_1, b, b2, P_2);
			P_0 = Color.FromArgb(P_0.A, P_0.R, g, P_0.B);
		}
		catch (OverflowException)
		{
			P_0 = Color.FromArgb(P_0.A, P_0.R, (P_1 > 0) ? b2 : b, P_0.B);
		}
		return P_0;
	}

	public static Color UbT(Color P_0, int P_1, SpinWrapping P_2)
	{
		byte b = 0;
		byte b2 = byte.MaxValue;
		try
		{
			byte r = (byte)cdY.YD7(P_0.R, P_1, b, b2, P_2);
			P_0 = Color.FromArgb(P_0.A, r, P_0.G, P_0.B);
		}
		catch (OverflowException)
		{
			P_0 = Color.FromArgb(P_0.A, (P_1 > 0) ? b2 : b, P_0.G, P_0.B);
		}
		return P_0;
	}

	public static bool vbI(string P_0, bool P_1, out Color? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		try
		{
			if (!UIColor.TryFromWebColor(P_0, out var color))
			{
				return false;
			}
			if (!P_1 && color.A < byte.MaxValue)
			{
				color.A = byte.MaxValue;
			}
			P_2 = color.ToColor();
		}
		catch (ArgumentException)
		{
			return false;
		}
		return true;
	}

	static VdT()
	{
		awj.QuEwGz();
		abb = Colors.Red;
	}

	internal static bool HSm()
	{
		return KSO == null;
	}

	internal static VdT gSP()
	{
		return KSO;
	}
}
