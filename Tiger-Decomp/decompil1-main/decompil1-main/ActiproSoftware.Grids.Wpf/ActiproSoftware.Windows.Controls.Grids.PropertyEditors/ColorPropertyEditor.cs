using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class ColorPropertyEditor : PropertyEditor
{
	internal static ColorPropertyEditor hC9;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public ColorPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.Color;
	}

	internal static bool MC8()
	{
		return hC9 == null;
	}

	internal static ColorPropertyEditor NCk()
	{
		return hC9;
	}
}
