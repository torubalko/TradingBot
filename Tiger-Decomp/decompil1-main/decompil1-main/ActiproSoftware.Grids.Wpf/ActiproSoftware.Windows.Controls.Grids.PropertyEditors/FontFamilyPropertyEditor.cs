using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class FontFamilyPropertyEditor : PropertyEditor
{
	private static FontFamilyPropertyEditor hCu;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public FontFamilyPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.FontFamily;
	}

	internal static bool QCq()
	{
		return hCu == null;
	}

	internal static FontFamilyPropertyEditor MCH()
	{
		return hCu;
	}
}
