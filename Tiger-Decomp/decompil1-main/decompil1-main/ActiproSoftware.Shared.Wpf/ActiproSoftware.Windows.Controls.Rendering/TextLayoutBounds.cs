using System.Diagnostics.CodeAnalysis;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal struct TextLayoutBounds : ITextBounds
{
	private double NIi;

	private bool NIS;

	private double wI3;

	private double VIt;

	private double LIJ;

	internal static object bnE;

	public double Bottom => LIJ + NIi;

	public double Height => NIi;

	public bool IsRightToLeft => NIS;

	public double Left => VIt;

	public Rect Rect => new Rect(VIt, LIJ, wI3, NIi);

	public double Right => VIt + wI3;

	public double Top => LIJ;

	public double Width => wI3;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X")]
	public double X => VIt;

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X")]
	public double Y => LIJ;

	public TextLayoutBounds(Rect bounds, bool isRightToLeft)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		VIt = bounds.X;
		LIJ = bounds.Y;
		wI3 = bounds.Width;
		NIi = bounds.Height;
		NIS = isRightToLeft;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is ITextBounds textBounds))
		{
			return false;
		}
		return VIt == textBounds.X && LIJ == textBounds.Y && wI3 == textBounds.Width && NIi == textBounds.Height && NIS == textBounds.IsRightToLeft;
	}

	public override int GetHashCode()
	{
		return VIt.GetHashCode() ^ LIJ.GetHashCode() ^ wI3.GetHashCode() ^ NIi.GetHashCode();
	}

	public override string ToString()
	{
		return Rect.ToString();
	}

	public static bool operator ==(TextLayoutBounds left, ITextBounds right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextLayoutBounds left, ITextBounds right)
	{
		return !(left == right);
	}

	internal static bool Bnx()
	{
		return bnE == null;
	}

	internal static object CnS()
	{
		return bnE;
	}
}
