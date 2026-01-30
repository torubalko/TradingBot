using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace ActiproSoftware.Windows.Controls.Rendering;

public interface ITextLayoutLine
{
	double Baseline { get; }

	int CharacterCount { get; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "HardLine")]
	bool HasHardLineBreak { get; }

	double Height { get; }

	int StartCharacterIndex { get; }

	double Width { get; }

	ITextBounds GetCharacterBounds(int characterIndex, bool allowVirtualSpace);

	IEnumerable<ITextBounds> GetTextBounds(int characterIndex, int characterCount, bool allowVirtualSpace);

	int HitTest(Point location);
}
