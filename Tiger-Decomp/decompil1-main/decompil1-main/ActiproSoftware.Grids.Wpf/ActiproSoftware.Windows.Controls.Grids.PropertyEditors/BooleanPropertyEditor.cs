using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class BooleanPropertyEditor : PropertyEditor
{
	internal static BooleanPropertyEditor jWd;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public BooleanPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.Boolean;
	}

	internal static bool GWN()
	{
		return jWd == null;
	}

	internal static BooleanPropertyEditor cW3()
	{
		return jWd;
	}
}
