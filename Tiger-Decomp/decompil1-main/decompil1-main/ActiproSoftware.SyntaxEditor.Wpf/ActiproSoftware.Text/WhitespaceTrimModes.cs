using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

[Flags]
[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
public enum WhitespaceTrimModes
{
	None = 0,
	TrailingOnPaste = 1,
	TrailingOnTextReplacement = 2
}
