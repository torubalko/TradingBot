using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Rendering;

[Flags]
[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
public enum TextProviderTranslateModes
{
	FromSourceText = 0,
	ToSourceText = 1,
	PositiveTracking = 2
}
