using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface ITextView
{
	ICollapsedRegionManager CollapsedRegionManager { get; }

	ITextSnapshot CurrentSnapshot { get; }

	Color DefaultBackgroundColor { get; }

	double DefaultCharacterWidth { get; }

	string DefaultFontFamilyName { get; }

	float DefaultFontSize { get; }

	Color DefaultForegroundColor { get; }

	double DefaultLineHeight { get; }

	double DefaultSpaceWidth { get; }

	IHighlightingStyleRegistry HighlightingStyleRegistry { get; }

	bool IsDefaultBackgroundColorLight { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	bool IsWhitespaceVisible { get; }

	PropertyDictionary Properties { get; }

	TextViewScrollState ScrollState { get; }

	SyntaxEditor SyntaxEditor { get; }

	Thickness TextAreaPadding { get; }

	Size TextAreaSize { get; }

	Rect TextAreaViewportBounds { get; }

	Guid UniqueId { get; }

	ITextViewLineCollection VisibleViewLines { get; }

	FrameworkElement VisualElement { get; }

	double ZoomLevel { get; }

	event RoutedEventHandler Closed;

	event RoutedEventHandler MarginsDestroyed;

	event EventHandler<TextViewTextAreaLayoutEventArgs> TextAreaLayout;

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	ITagAggregator<T> CreateTagAggregator<T>() where T : ITag;

	IAdornmentLayer GetAdornmentLayer(AdornmentLayerDefinition layerDefinition);

	ITextViewLine GetViewLine(int offset);

	ITextViewLine GetViewLine(int offset, bool hasFarAffinity);

	ITextViewLine GetViewLine(TextPosition position);

	ITextViewLine GetViewLine(ITextViewLine viewLine, int lineDelta);

	ITextViewLine GetViewLine(ITextViewLine viewLine, int lineDelta, bool forceVirtualSpace);

	void InvalidateRender();

	TextPosition OffsetToPosition(int offset);

	int PositionToOffset(TextPosition position);

	Point TransformFromTextArea(Point location);

	Rect TransformFromTextArea(Rect bounds);

	Point TransformToTextArea(Point location);

	Rect TransformToTextArea(Rect bounds);
}
