using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class LimitedObjectPropertyEditor : PropertyEditor
{
	private static LimitedObjectPropertyEditor HCf;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public LimitedObjectPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.LimitedObject;
	}

	internal static bool SCo()
	{
		return HCf == null;
	}

	internal static LimitedObjectPropertyEditor bCZ()
	{
		return HCf;
	}
}
