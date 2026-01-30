using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Text;

public enum CaseSensitivity
{
	Sensitive,
	Insensitive,
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "AutoCorrect")]
	AutoCorrect
}
