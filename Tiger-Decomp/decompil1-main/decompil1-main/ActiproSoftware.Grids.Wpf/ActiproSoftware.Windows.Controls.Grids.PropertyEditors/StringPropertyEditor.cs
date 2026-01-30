using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class StringPropertyEditor : PropertyEditor
{
	internal static StringPropertyEditor TC7;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public StringPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.String;
	}

	internal static bool lCO()
	{
		return TC7 == null;
	}

	internal static StringPropertyEditor MCD()
	{
		return TC7;
	}
}
