using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.Editors;

public enum ColorPickerTextInputMode
{
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rgb")]
	[Display(Name = "RGB")]
	Rgb,
	[Display(Name = "HSB")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hsb")]
	Hsb
}
