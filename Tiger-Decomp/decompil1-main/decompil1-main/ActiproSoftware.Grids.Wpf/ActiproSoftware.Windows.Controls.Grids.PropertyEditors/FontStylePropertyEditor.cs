using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class FontStylePropertyEditor : PropertyEditor
{
	internal static FontStylePropertyEditor uCL;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public FontStylePropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.FontStyle;
	}

	internal static bool cCB()
	{
		return uCL == null;
	}

	internal static FontStylePropertyEditor XCt()
	{
		return uCL;
	}
}
