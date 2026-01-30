using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class NullableBooleanPropertyEditor : PropertyEditor
{
	internal static NullableBooleanPropertyEditor YCU;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public NullableBooleanPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.NullableBoolean;
	}

	internal static bool eC5()
	{
		return YCU == null;
	}

	internal static NullableBooleanPropertyEditor aCa()
	{
		return YCU;
	}
}
