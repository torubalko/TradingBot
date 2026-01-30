using System.Windows;
using ActiproSoftware.Windows.Controls;

namespace ActiproSoftware.Internal;

internal interface Va : IOrientedElement
{
	UIElement ElementAfter { get; }

	UIElement ElementBefore { get; }

	bool IsHighlighted { get; set; }

	double TranslationOffset { get; set; }

	Rect GetBounds();
}
