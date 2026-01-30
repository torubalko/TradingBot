using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Scroller")]
public interface IEditorViewScroller
{
	bool IsHorizontalScrollBarVisible { get; }

	bool IsHorizontalScrollingEnabled { get; }

	bool IsVerticalScrollBarVisible { get; }

	bool IsVerticalScrollingEnabled { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "y")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "x")]
	void ScrollByPixels(double xPixelDelta, double yPixelDelta);

	void ScrollDown();

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ByPixels")]
	void ScrollHorizontallyByPixels(double pixelDelta);

	void ScrollIntoView(TextPosition position, bool scrollToVerticalMiddle);

	void ScrollLeft();

	void ScrollLineToVisibleBottom();

	void ScrollLineToVisibleMiddle();

	void ScrollLineToVisibleTop();

	void ScrollPageDown();

	void ScrollPageUp();

	void ScrollRight();

	void ScrollTo(TextViewScrollState scrollState);

	void ScrollToCaret();

	void ScrollToDocumentEnd();

	void ScrollToDocumentStart();

	void ScrollUp();

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ByLine")]
	void ScrollVerticallyByLine(int lineDelta);

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "ByPixels")]
	void ScrollVerticallyByPixels(double pixelDelta);
}
