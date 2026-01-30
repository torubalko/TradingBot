using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace ActiproSoftware.Windows.Controls.Rendering;

public interface ITextBounds
{
	double Bottom { get; }

	double Height { get; }

	bool IsRightToLeft { get; }

	double Left { get; }

	Rect Rect { get; }

	double Right { get; }

	double Top { get; }

	double Width { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X")]
	double X { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Y")]
	double Y { get; }
}
