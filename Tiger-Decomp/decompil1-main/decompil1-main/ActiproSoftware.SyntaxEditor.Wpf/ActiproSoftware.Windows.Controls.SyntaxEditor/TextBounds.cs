using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public struct TextBounds
{
	private double YXe;

	private bool XXl;

	private double VXA;

	private double DXv;

	private double mXm;

	private static TextBounds RXC;

	private static object vDS;

	public double Bottom => mXm + YXe;

	public static TextBounds Empty => RXC;

	public FlowDirection FlowDirection => XXl ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;

	public double Height => YXe;

	public bool IsEmpty => VXA < 0.0;

	public bool IsLeftToRight => !XXl;

	public bool IsRightToLeft => XXl;

	public bool IsYValid
	{
		get
		{
			return !double.IsPositiveInfinity(mXm);
		}
		internal set
		{
			if (!value)
			{
				mXm = double.PositiveInfinity;
			}
			else
			{
				mXm = 0.0;
			}
		}
	}

	public double Left => DXv;

	public Rect Rect
	{
		get
		{
			if (IsEmpty)
			{
				return Rect.Empty;
			}
			return new Rect(DXv, mXm, VXA, YXe);
		}
	}

	public double Right => DXv + VXA;

	public double Top => mXm;

	public double Width => VXA;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X")]
	public double X => DXv;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Y")]
	public double Y => mXm;

	public TextBounds(Rect bounds, bool isRightToLeft)
	{
		grA.DaB7cz();
		DXv = bounds.X;
		mXm = bounds.Y;
		VXA = bounds.Width;
		YXe = bounds.Height;
		XXl = isRightToLeft;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "y")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x")]
	public TextBounds(double x, double y, double width, double height, bool isRightToLeft)
	{
		grA.DaB7cz();
		DXv = x;
		mXm = y;
		VXA = width;
		YXe = height;
		XXl = isRightToLeft;
	}

	public override bool Equals(object obj)
	{
		if (obj is TextBounds textBounds)
		{
			int result;
			if (DXv == textBounds.DXv && mXm == textBounds.mXm && VXA == textBounds.VXA && YXe == textBounds.YXe)
			{
				int num = 0;
				if (hDZ() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				result = ((XXl == textBounds.XXl) ? 1 : 0);
			}
			else
			{
				result = 0;
			}
			return (byte)result != 0;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return DXv.GetHashCode() ^ mXm.GetHashCode() ^ VXA.GetHashCode() ^ YXe.GetHashCode();
	}

	public override string ToString()
	{
		return Rect.ToString(CultureInfo.CurrentCulture);
	}

	public static bool operator ==(TextBounds left, TextBounds right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextBounds left, TextBounds right)
	{
		return !(left == right);
	}

	static TextBounds()
	{
		grA.DaB7cz();
		RXC = new TextBounds(Rect.Empty, isRightToLeft: false);
	}

	internal static bool sDk()
	{
		return vDS == null;
	}

	internal static object hDZ()
	{
		return vDS;
	}
}
