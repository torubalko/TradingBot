using System;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

namespace ActiproSoftware.Internal;

internal class LAm : XAK
{
	private DrawAdornmentCallback o8w;

	private Point W86;

	private Size G8H;

	private static LAm i1F;

	public override DrawAdornmentCallback DrawCallback => o8w;

	public override Point Location
	{
		get
		{
			return W86;
		}
		set
		{
			W86 = w;
		}
	}

	public override Size Size => G8H;

	public LAm(DrawAdornmentCallback P_0, Size P_1, object P_2, ITextViewLine P_3, TextSnapshotRange? P_4, TextRangeTrackingModes? P_5, Action<IAdornment> P_6)
	{
		grA.DaB7cz();
		base._002Ector(P_2, P_3, P_4, P_5, P_6);
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197778));
		}
		o8w = P_0;
		G8H = P_1;
	}

	public override void Translate(double P_0, double P_1)
	{
		Point location = Location;
		location.X += P_0;
		location.Y += P_1;
		Location = location;
	}

	internal static bool r19()
	{
		return i1F == null;
	}

	internal static LAm r1J()
	{
		return i1F;
	}
}
