using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface ITextPositionFinder
{
	TextPosition GetPositionForCharacterDelta(TextPosition position, int characterDelta, bool wrapAtLineTerminators, bool forceVirtualSpace);

	TextPosition GetPositionForLineDelta(TextPosition position, int lineDelta, double? preferredHorizontalLocation, bool forceVirtualSpace);

	TextPosition GetPositionForLineEnd(TextPosition position);

	TextPosition GetPositionForLineStart(TextPosition position);
}
