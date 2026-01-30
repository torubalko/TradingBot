using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

[Flags]
[SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
public enum OutliningMode
{
	None = 0,
	Automatic = 1,
	Manual = 2,
	Default = 3
}
