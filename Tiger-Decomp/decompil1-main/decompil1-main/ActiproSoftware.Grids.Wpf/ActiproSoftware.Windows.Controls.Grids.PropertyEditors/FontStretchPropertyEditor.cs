using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class FontStretchPropertyEditor : PropertyEditor
{
	internal static FontStretchPropertyEditor NCG;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public FontStretchPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.FontStretch;
	}

	internal static bool UC0()
	{
		return NCG == null;
	}

	internal static FontStretchPropertyEditor JCj()
	{
		return NCG;
	}
}
