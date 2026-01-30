using System;
using System.Windows;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

public interface IAdornment
{
	DrawAdornmentCallback DrawCallback { get; }

	Point Location { get; set; }

	Action<IAdornment> RemovedCallback { get; }

	Size Size { get; }

	TextSnapshotRange? SnapshotRange { get; }

	object Tag { get; }

	TextRangeTrackingModes? TrackingModes { get; }

	ITextViewLine ViewLine { get; }

	UIElement VisualElement { get; }

	void Translate(double deltaX, double deltaY);
}
