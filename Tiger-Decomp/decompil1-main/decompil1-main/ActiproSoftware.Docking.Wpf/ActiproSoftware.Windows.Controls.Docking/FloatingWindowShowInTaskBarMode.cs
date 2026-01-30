using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Docking;

[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TaskBar")]
public enum FloatingWindowShowInTaskBarMode
{
	Default,
	Never,
	Always
}
