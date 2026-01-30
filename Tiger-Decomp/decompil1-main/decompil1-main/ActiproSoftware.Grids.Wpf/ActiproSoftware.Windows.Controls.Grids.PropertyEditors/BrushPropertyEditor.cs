using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

public class BrushPropertyEditor : PropertyEditor
{
	private static BrushPropertyEditor SWT;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public BrushPropertyEditor()
	{
		fc.taYSkz();
		base._002Ector();
		ValueTemplateKind = DefaultValueTemplateKind.Brush;
	}

	internal static bool MW7()
	{
		return SWT == null;
	}

	internal static BrushPropertyEditor IWO()
	{
		return SWT;
	}
}
