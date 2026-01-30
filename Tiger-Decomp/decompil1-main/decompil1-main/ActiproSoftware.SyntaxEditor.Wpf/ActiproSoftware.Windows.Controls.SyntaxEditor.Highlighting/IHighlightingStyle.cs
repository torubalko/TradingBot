using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Rendering;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

public interface IHighlightingStyle : INotifyPropertyChanged
{
	Color? Background { get; set; }

	bool BackgroundSpansVirtualSpace { get; set; }

	bool? Bold { get; set; }

	Color? BorderColor { get; set; }

	HighlightingStyleBorderCornerKind BorderCornerKind { get; set; }

	LineKind BorderKind { get; set; }

	string FontFamilyName { get; set; }

	[TypeConverter(typeof(FontSizeConverter))]
	float FontSize { get; set; }

	Color? Foreground { get; set; }

	bool HasBackground { get; }

	bool HasBorder { get; }

	bool HasDefaultFormatting { get; }

	bool HasFontChange { get; }

	bool HasStrikethrough { get; }

	bool HasUnderline { get; }

	bool IsBackgroundEditable { get; set; }

	bool IsBoldEditable { get; set; }

	bool IsBorderEditable { get; set; }

	bool IsForegroundEditable { get; set; }

	bool IsItalicEditable { get; set; }

	bool? Italic { get; set; }

	Color? StrikethroughColor { get; set; }

	LineKind StrikethroughKind { get; set; }

	TextLineWeight StrikethroughWeight { get; set; }

	object Tag { get; set; }

	Color? UnderlineColor { get; set; }

	LineKind UnderlineKind { get; set; }

	TextLineWeight UnderlineWeight { get; set; }
}
