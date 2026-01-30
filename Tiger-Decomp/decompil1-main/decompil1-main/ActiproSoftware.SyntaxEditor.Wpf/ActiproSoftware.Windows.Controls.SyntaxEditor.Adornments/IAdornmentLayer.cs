using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

public interface IAdornmentLayer : IKeyedObject
{
	ReadOnlyCollection<IAdornment> Adornments { get; }

	double Opacity { get; set; }

	ITextView View { get; }

	IAdornment AddAdornment(AdornmentChangeReason reason, UIElement visualElement, Point location, object tag, Action<IAdornment> removedCallback);

	IAdornment AddAdornment(AdornmentChangeReason reason, DrawAdornmentCallback drawCallback, Rect bounds, object tag, Action<IAdornment> removedCallback);

	IAdornment AddAdornment(AdornmentChangeReason reason, UIElement visualElement, Point location, object tag, ITextViewLine viewLine, TextSnapshotRange snapshotRange, TextRangeTrackingModes trackingModes, Action<IAdornment> removedCallback);

	IAdornment AddAdornment(AdornmentChangeReason reason, DrawAdornmentCallback drawCallback, Rect bounds, object tag, ITextViewLine viewLine, TextSnapshotRange snapshotRange, TextRangeTrackingModes trackingModes, Action<IAdornment> removedCallback);

	IAdornment FindAdornment(UIElement visualElement);

	IAdornment[] FindAdornments(TextSnapshotRange snapshotRange);

	IAdornment[] FindAdornments(object tag);

	IAdornment[] FindAdornments(ITextViewLine viewLine);

	IAdornment[] FindAdornments(Predicate<IAdornment> match);

	bool RemoveAdornment(AdornmentChangeReason reason, IAdornment adornmentToRemove);

	bool RemoveAdornments(AdornmentChangeReason reason, IEnumerable<IAdornment> adornmentsToRemove);

	bool RemoveAllAdornments(AdornmentChangeReason reason);
}
