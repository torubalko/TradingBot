using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class LimitedStringPropertyEditor : PropertyEditor
{
	internal static LimitedStringPropertyEditor MCx;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public LimitedStringPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.LimitedString;
	}

	internal static bool vCS()
	{
		return MCx == null;
	}

	internal static LimitedStringPropertyEditor BC1()
	{
		return MCx;
	}
}
