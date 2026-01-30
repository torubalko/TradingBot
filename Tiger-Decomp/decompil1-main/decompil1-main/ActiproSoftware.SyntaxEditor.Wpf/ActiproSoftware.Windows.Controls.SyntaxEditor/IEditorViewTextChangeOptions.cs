using System;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewTextChangeOptions : ITextChangeOptions
{
	Func<ITextViewLine, Range, Range> BlockEditRangeAdjustFunc { get; set; }

	bool CanApplyToBlockEdit { get; set; }

	bool CanApplyToMultipleSelections { get; set; }

	bool IsBlock { get; set; }

	bool SelectInsertedText { get; set; }

	bool VirtualCharacterFill { get; set; }

	Func<TextPosition, TextPositionRange> ZeroLengthEditRangeAdjustFunc { get; set; }
}
