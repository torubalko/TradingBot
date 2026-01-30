using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

public enum LineTerminator
{
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Newline")]
	Newline,
	CarriageReturn,
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Newline")]
	CarriageReturnNewline
}
